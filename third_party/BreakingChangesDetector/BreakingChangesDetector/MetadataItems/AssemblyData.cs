﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for externally visible types and members of an <see cref="Assembly"/>.
    /// </summary>
    public sealed class AssemblyData : MetadataItemBase
    {
        private readonly List<ConstructedGenericTypeData> _constructedGenericsToFinalizeAfterLoad;
        private readonly Dictionary<TypeDefinitionData, List<AssemblyData>> _forwardedTypeSources;
        private readonly Dictionary<TypeDefinitionData, string> _forwardedTypeSourcesOnTarget;
        private bool _isLoading;
        private readonly Dictionary<Tuple<MethodSignature, int>, GenericTypeParameterData> _methodOwnedGenericParameters;
        private readonly Dictionary<string, string> _namespaceRenames;
        private readonly HashSet<AssemblyData> _referencedAssemblies; // TODO_Serialize: Round trip and unit test
        private readonly Dictionary<string, TypeDefinitionData> _typeDefinitions;
        private readonly Dictionary<Tuple<string, int>, GenericTypeParameterData> _typeOwnedGenericParameters;

        internal AssemblyData(
            MetadataResolutionContext context,
            string fullName,
            string name,
            string versionComparisonName,
            IEnumerable<KeyValuePair<string, string>> namespaceRenames)
        {
            Context = context;

            _constructedGenericsToFinalizeAfterLoad = new List<ConstructedGenericTypeData>();
            _forwardedTypeSources = new Dictionary<TypeDefinitionData, List<AssemblyData>>();
            _forwardedTypeSourcesOnTarget = new Dictionary<TypeDefinitionData, string>();
            _methodOwnedGenericParameters = new Dictionary<Tuple<MethodSignature, int>, GenericTypeParameterData>();
            _namespaceRenames = new Dictionary<string, string>();
            _referencedAssemblies = new HashSet<AssemblyData>();
            _typeDefinitions = new Dictionary<string, TypeDefinitionData>();
            _typeOwnedGenericParameters = new Dictionary<Tuple<string, int>, GenericTypeParameterData>();

            FullName = fullName;
            Name = name;
            VersionComparisonName = versionComparisonName;

            if (namespaceRenames != null)
            {
                foreach (var namespaceRename in namespaceRenames)
                {
                    _namespaceRenames[namespaceRename.Key] = namespaceRename.Value;
                }
            }
        }

        internal AssemblyData(MetadataResolutionContext context, IAssemblySymbol underlyingAssemblySymbol)
            : this(context, underlyingAssemblySymbol.ToDisplayString(), underlyingAssemblySymbol.Name,
            Utilities.GetVersionComparisonName(underlyingAssemblySymbol),
            Utilities.GetNamespaceRenames(underlyingAssemblySymbol))
        { }

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitAssemblyData(this);

        public override MetadataResolutionContext Context { get; }

        /// <inheritdoc/>
        public override string DisplayName => Name;

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as AssemblyData;
            if (otherTyped == null)
            {
                return false;
            }

            if (FullName != otherTyped.FullName)
            {
                return false;
            }

            if (Name != otherTyped.Name)
            {
                return false;
            }

            if (VersionComparisonName != otherTyped.VersionComparisonName)
            {
                return false;
            }

            if (_typeDefinitions.Count != otherTyped._typeDefinitions.Count)
            {
                return false;
            }

            foreach (var pair in _typeDefinitions)
            {
                var type = pair.Value;
                if (otherTyped._typeDefinitions.TryGetValue(pair.Key, out TypeDefinitionData otherType) == false)
                {
                    return false;
                }

                if (type.DoesMatch(otherType) == false)
                {
                    return false;
                }
            }

            if (_typeOwnedGenericParameters.Count != otherTyped._typeOwnedGenericParameters.Count)
            {
                return false;
            }

            foreach (var pair in _typeOwnedGenericParameters)
            {
                var type = pair.Value;
                if (otherTyped._typeOwnedGenericParameters.TryGetValue(pair.Key, out GenericTypeParameterData otherType) == false)
                {
                    return false;
                }

                if (type.DoesMatch(otherType) == false)
                {
                    return false;
                }
            }

            if (_methodOwnedGenericParameters.Count != otherTyped._methodOwnedGenericParameters.Count)
            {
                return false;
            }

            foreach (var pair in _methodOwnedGenericParameters)
            {
                var type = pair.Value;
                if (otherTyped._methodOwnedGenericParameters.TryGetValue(pair.Key, out GenericTypeParameterData otherType) == false)
                {
                    return false;
                }

                if (type.DoesMatch(otherType) == false)
                {
                    return false;
                }
            }

            if (_namespaceRenames.Count != otherTyped._namespaceRenames.Count)
            {
                return false;
            }

            foreach (var pair in _namespaceRenames)
            {
                var newName = pair.Value;
                var otherNewName = otherTyped._namespaceRenames[pair.Key];

                if (newName != otherNewName)
                {
                    return false;
                }
            }

            var referenceNames = _referencedAssemblies.Select(a => a.FullName).OrderBy(n => n).ToArray();
            var otherReferenceNames = otherTyped._referencedAssemblies.Select(a => a.FullName).OrderBy(n => n).ToArray();
            if (referenceNames.Length != otherReferenceNames.Length)
            {
                return false;
            }

            for (int i = 0; i < referenceNames.Length; i++)
            {
                if (referenceNames[i] != otherReferenceNames[i])
                {
                    return false;
                }
            }

            if (_forwardedTypeSources.Count != otherTyped._forwardedTypeSources.Count)
            {
                return false;
            }

            foreach (var pair in _forwardedTypeSources)
            {
                var assemblies = pair.Value;
                var otherAssemblies = otherTyped._forwardedTypeSources[otherTyped.GetTypeDefinitionData(pair.Key.FullName)];

                if (assemblies.Count != otherAssemblies.Count)
                {
                    return false;
                }

                for (int i = 0; i < assemblies.Count; i++)
                {
                    if (assemblies[i].FullName != otherAssemblies[i].FullName)
                    {
                        return false;
                    }
                }
            }

            if (_forwardedTypeSourcesOnTarget.Count != otherTyped._forwardedTypeSourcesOnTarget.Count)
            {
                return false;
            }

            foreach (var pair in _forwardedTypeSourcesOnTarget)
            {
                var fullName = pair.Value;
                var otherFullName = otherTyped._forwardedTypeSourcesOnTarget[otherTyped.GetTypeDefinitionData(pair.Key.FullName)];

                if (fullName != otherFullName)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.Assembly;

        internal void AddForwardedTypeFromTarget(TypeDefinitionData type, string sourceAssembly) =>
            _forwardedTypeSourcesOnTarget.Add(type, sourceAssembly);

        internal IEnumerable<string> GetForwardedTypeSources(TypeDefinitionData type)
        {
            if (_forwardedTypeSources.TryGetValue(type, out List<AssemblyData> sourceAssemblies))
            {
                foreach (var sourceAssembly in sourceAssemblies)
                {
                    yield return sourceAssembly.FullName;
                }
            }

            if (_forwardedTypeSourcesOnTarget.TryGetValue(type, out string sourceFullName))
            {
                yield return sourceFullName;
            }
        }

        internal GenericTypeParameterData GetGenericTypeParameterData(ITypeParameterSymbol typeParameterSymbol) =>
            typeParameterSymbol.DeclaringMethod != null
                ? GetGenericTypeParameterData(typeParameterSymbol.DeclaringMethod, typeParameterSymbol.Ordinal)
                : GetGenericTypeParameterData(typeParameterSymbol.ContainingType, typeParameterSymbol.Ordinal);

        private GenericTypeParameterData GetGenericTypeParameterData(IMethodSymbol methodSymbol, int position)
        {
            Debug.Assert(
                Context.GetDeclaringAssemblySymbol(methodSymbol.ContainingType).ToDisplayString() == FullName,
                "The method is not from this assembly");
            _methodOwnedGenericParameters.TryGetValue(
                Tuple.Create(new MethodSignature(Context, methodSymbol), position),
                out GenericTypeParameterData genericParameter);
            return genericParameter;
        }

        private GenericTypeParameterData GetGenericTypeParameterData(INamedTypeSymbol typeSymbol, int position)
        {
            Debug.Assert(
                Context.GetDeclaringAssemblySymbol(typeSymbol).ToDisplayString() == FullName,
                "The method is not from this assembly");
            _typeOwnedGenericParameters.TryGetValue(Tuple.Create(typeSymbol.GetFullName(), position), out GenericTypeParameterData genericParameter);
            return genericParameter;
        }

        internal string GetNewNamespaceName(string oldNamespaceName)
        {
            if (oldNamespaceName == null)
            {
                return null;
            }

            _namespaceRenames.TryGetValue(oldNamespaceName, out string newNamespaceName);
            return newNamespaceName;
        }

        /// <summary>
        /// Gets all non-nested types which are type definitions and therefore not constructed generic, array, by-ref, or pointer types.
        /// </summary>
        /// <returns>An enumerable collection of all non-nested type definitions.</returns> 
        internal IEnumerable<TypeDefinitionData> GetNonNestedTypeDefinitions() =>
            _typeDefinitions.Values.OfType<TypeDefinitionData>().Where(t => t.ContainingType == null);

        internal IEnumerable<AssemblyData> GetReferencedAssemblies() => _referencedAssemblies;

        internal AssemblyData GetReferencedAssembly(string name) =>
            Name == name ? this : GetReferencedAssemblies().Where(a => a.Name == name).FirstOrDefault();

        /// <summary>
        /// Gets the <see cref="TypeData"/> instance containing the metadata for externally visible types and members of the specified <see cref="Type"/>.
        /// </summary>
        /// <param name="typeSymbol">The type for which of corresponding to the TypeData to get.</param>
        /// <returns>The TypeData instance containing the metadata for externally visible types and members of the specified Type.</returns> 
        internal TypeData GetTypeData(ITypeSymbol typeSymbol)
        {
            Debug.Assert(
                Context.GetDeclaringAssemblySymbol(typeSymbol).ToDisplayString() == FullName,
                "The type belongs to another assembly.");

            if (typeSymbol is ITypeParameterSymbol typeParameterSymbol)
            {
                return GetGenericTypeParameterData(typeParameterSymbol);
            }

            if (!typeSymbol.DeclaredAccessibility.IsPublicOrProtected())
            {
                return null;
            }

            if (typeSymbol is INamedTypeSymbol namedTypeSymbol)
            {
                // TODO: I think this may be a bug. Report if so: ValueTuple<T1> doesn't report its fully qualified name correctly unless we do this.
                //       However, this is needed anyway to get the proper type info for tuple types.
                if (namedTypeSymbol.IsTupleType)
                {
                    namedTypeSymbol = namedTypeSymbol.TupleUnderlyingType;
                }

                if (namedTypeSymbol.IsConstructed())
                {
                    return Context.GetTypeDefinitionData(namedTypeSymbol.ConstructedFrom).GetConstructedGenericTypeData(namedTypeSymbol.TypeArguments.Select(a => Context.GetTypeData(a)));
                }

                return GetTypeDefinitionData(namedTypeSymbol.GetFullName());
            }

            DeclaringTypeData declaringType = null;
            if (typeSymbol.ContainingType != null)
            {
                declaringType = (DeclaringTypeData)GetTypeData(typeSymbol.ContainingType);
            }

            if (typeSymbol is IArrayTypeSymbol arrayType)
            {
                Debug.Assert(declaringType == null, "Types with elements should not be declared within other types.");
                var elementType = Context.GetTypeData(arrayType.ElementType);
                return elementType.GetArrayType((byte)arrayType.Rank);
            }

            if (typeSymbol is IPointerTypeSymbol pointerTypeSymbol)
            {
                return Context.GetTypeData(pointerTypeSymbol.PointedAtType).GetPointerType();
            }

            if (typeSymbol is IDynamicTypeSymbol dynamicTypeSymbol)
            {
                // TODO: Not sure if this is the right thing to do
                return GetTypeDefinitionData(Utilities.ObjectTypeName);
            }

            Debug.Fail("Unknown kind of type.");
            return Context.GetTypeData(typeSymbol);
        }

        /// <summary>
        /// Gets all <see cref="TypeData"/> instance in the <see cref="AssemblyData"/>.
        /// </summary> 
        internal IList<TypeData> GetTypeDatas() =>
            _typeDefinitions.OrderBy(p => p.Key).Select(p => p.Value).Cast<TypeData>().ToList();

        /// <summary>
        /// Gets the <see cref="DeclaringTypeData"/> representing the type with the specified full name.
        /// </summary>
        /// <param name="fullName">The full name of the type to get.</param>
        /// <returns>The type with the specified full name or null if no such type exists.</returns> 
        internal TypeDefinitionData GetTypeDefinitionData(string fullName)
        {
            _typeDefinitions.TryGetValue(fullName, out TypeDefinitionData internalType);
            return internalType;
        }

        /// <summary>
        /// Indicates whether the current assembly is logically equivalent to the specified assembly, just from a different version.
        /// </summary>
        /// <param name="assemblyData"></param> 
        internal bool IsEquivalentToNewAssembly(AssemblyData assemblyData) =>
            VersionComparisonName == assemblyData?.VersionComparisonName;

        internal void RegisterForFinalize(ConstructedGenericTypeData type)
        {
            if (_isLoading)
            {
                _constructedGenericsToFinalizeAfterLoad.Add(type);
            }
            else
            {
                type.FinalizeDefiniton();
            }
        }

        private void AddForwardedType(TypeDefinitionData type)
        {
            Debug.Assert(this != type.AssemblyData, "A type should not be forwarded to its own assembly.");

            if (type.AssemblyData._forwardedTypeSources.TryGetValue(type, out List<AssemblyData> forwardedTypeSources) == false)
            {
                type.AssemblyData._forwardedTypeSources[type] = forwardedTypeSources = new List<AssemblyData>();
            }

            forwardedTypeSources.Add(this);
        }

        /// <summary>
        /// Adds the <see cref="AssemblyData"/> of a directly assembly reference to the current AssemblyData.
        /// </summary>
        /// <param name="reference">The AssemblyData of the directly referenced assembly.</param> 
        private void AddReference(AssemblyData reference)
        {
            _referencedAssemblies.Add(reference);
        }

        private void IterateAllTypeDefinitions(IAssemblySymbol assemblySymbol,
            Func<INamedTypeSymbol, bool> namedTypeAction,
            Action<ITypeParameterSymbol> typeParameterAction = null) =>
            IterateAllTypeDefinitions(assemblySymbol.GlobalNamespace, namedTypeAction, typeParameterAction);

        private void IterateAllTypeDefinitions(INamespaceSymbol namespaceSymbol,
            Func<INamedTypeSymbol, bool> namedTypeAction,
            Action<ITypeParameterSymbol> typeParameterAction = null)
        {
            foreach (var namespaceOrTypeSymbol in namespaceSymbol.GetMembers())
            {
                if (namespaceOrTypeSymbol.IsType)
                {
                    IterateAllTypeDefinitions((INamedTypeSymbol)namespaceOrTypeSymbol, namedTypeAction, typeParameterAction);
                }
                else
                {
                    IterateAllTypeDefinitions((INamespaceSymbol)namespaceOrTypeSymbol, namedTypeAction, typeParameterAction);
                }
            }
        }

        private void IterateAllTypeDefinitions(INamedTypeSymbol namedTypeSymbol,
            Func<INamedTypeSymbol, bool> namedTypeAction,
            Action<ITypeParameterSymbol> typeParameterAction)
        {
            if (namedTypeAction(namedTypeSymbol) == false)
            {
                return;
            }

            if (typeParameterAction != null)
            {
                foreach (var genericParameter in namedTypeSymbol.TypeParameters)
                {
                    typeParameterAction(genericParameter);
                }

                foreach (var method in namedTypeSymbol.Methods().Where(m => !m.TypeParameters.IsEmpty && m.DeclaredAccessibility.IsPublicOrProtected()))
                {
                    foreach (var genericParameter in method.TypeParameters)
                    {
                        typeParameterAction(genericParameter);
                    }
                }
            }

            foreach (var nestedType in namedTypeSymbol.GetTypeMembers())
            {
                IterateAllTypeDefinitions(nestedType, namedTypeAction, typeParameterAction);
            }
        }

        internal void LoadFromMetadata(IAssemblySymbol assemblySymbol)
        {
            _isLoading = true;
            IterateAllTypeDefinitions(assemblySymbol, namedTypeSymbol =>
            {
                RegisterType(namedTypeSymbol, null);

                // Return false so we don't process nested types. RegisterType will register nested type recursively.
                return false;
            });

            // Finalize Definitions
            IterateAllTypeDefinitions(assemblySymbol,
                namedTypeAction: namedTypeSymbol =>
                {
                    var typeData = (TypeDefinitionData)GetTypeData(namedTypeSymbol);
                    if (typeData == null)
                    {
                        return false;
                    }

                    typeData.FinalizeDefinition(namedTypeSymbol);
                    return true;
                },
                typeParameterAction: typeParameterSymbol =>
                {
                    GetGenericTypeParameterData(typeParameterSymbol).FinalizeDefinition(typeParameterSymbol);
                });

            // Populate Members
            IterateAllTypeDefinitions(assemblySymbol,
                namedTypeAction: namedTypeSymbol =>
                {
                    var typeData = (TypeDefinitionData)GetTypeData(namedTypeSymbol);
                    if (typeData == null)
                    {
                        return false;
                    }

                    typeData.PopulateMembers(namedTypeSymbol);
                    return true;
                });

            while (_constructedGenericsToFinalizeAfterLoad.Count != 0)
            {
                var temp = _constructedGenericsToFinalizeAfterLoad.ToArray();
                _constructedGenericsToFinalizeAfterLoad.Clear();
                foreach (var type in temp)
                {
                    type.FinalizeDefiniton();
                }
            }

            var metadataReader = assemblySymbol.Modules.First().GetMetadata().GetMetadataReader();
            var forwarders = metadataReader.ExportedTypes.Select(metadataReader.GetExportedType).Where(e => e.IsForwarder);
            foreach (var forwarder in forwarders)
            {
                var metadataName = metadataReader.GetString(forwarder.Name);
                if (!forwarder.Namespace.IsNil)
                {
                    metadataName = $"{metadataReader.GetString(forwarder.Namespace)}.{metadataName}";
                }
                var forwardedType = assemblySymbol.ResolveForwardedType(metadataName);
                if (forwardedType != null)
                {
                    var forwardedTypeData = (TypeDefinitionData)Context.GetTypeData(forwardedType);
                    if (forwardedTypeData != null)
                    {
                        AddForwardedType(forwardedTypeData);
                    }
                }
            }

            foreach (var referenceIdentity in assemblySymbol.Modules.SelectMany(m => m.ReferencedAssemblies))
            {
                if (Context._cachedAssemblyDatas.TryGetValue(referenceIdentity, out AssemblyData reference))
                {
                    _referencedAssemblies.Add(reference);
                }
            }

            _isLoading = false;
        }

        private void RegisterType(INamedTypeSymbol namedTypeSymbol, TypeDefinitionData declaringType)
        {
            var accessibility = namedTypeSymbol.DeclaredAccessibility;
            if (!accessibility.IsPublicOrProtected())
            {
                return;
            }

            var typeDefinitionData = new TypeDefinitionData(namedTypeSymbol, declaringType, this);
            _typeDefinitions.Add(namedTypeSymbol.GetFullName(), typeDefinitionData);

            foreach (var typeParameterSymbol in namedTypeSymbol.TypeParameters)
            {
                _typeOwnedGenericParameters.Add(Tuple.Create(namedTypeSymbol.GetFullName(), typeParameterSymbol.Ordinal), new GenericTypeParameterData(typeParameterSymbol, this));
            }

            foreach (var method in namedTypeSymbol.Methods().Where(m => !m.TypeParameters.IsEmpty && m.DeclaredAccessibility.IsPublicOrProtected()))
            {
                var signature = new MethodSignature(Context, method);
                foreach (var typeParameterSymbol in method.TypeParameters)
                {
                    _methodOwnedGenericParameters.Add(Tuple.Create(signature, typeParameterSymbol.Ordinal), new GenericTypeParameterData(typeParameterSymbol, this));
                }
            }

            foreach (var nestedTypeSymbol in namedTypeSymbol.GetTypeMembers())
            {
                RegisterType(nestedTypeSymbol, typeDefinitionData);
            }
        }

        /// <summary>
        /// Gets the full name of the assembly.
        /// </summary>
        public string FullName { get; }

        /// <summary>
        /// Gets the name of the assembly.
        /// </summary>
        public string Name { get; } // TODO_Serialize: Round trip and unit test

        /// <summary>
        /// Gets the name used to compare logically equivalent assemblies from different versions. This should not change across versions 
        /// of the assembly.
        /// </summary>
        public string VersionComparisonName { get; } // TODO_Serialize: Round trip and unit test
    }
}
