// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DiscoveryEngine.V1;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>IdentityMappingStore</c> resource.</summary>
    public sealed partial class IdentityMappingStoreName : gax::IResourceName, sys::IEquatable<IdentityMappingStoreName>
    {
        /// <summary>The possible contents of <see cref="IdentityMappingStoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>.
            /// </summary>
            ProjectLocationIdentityMappingStore = 1,
        }

        private static gax::PathTemplate s_projectLocationIdentityMappingStore = new gax::PathTemplate("projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}");

        /// <summary>Creates a <see cref="IdentityMappingStoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IdentityMappingStoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IdentityMappingStoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IdentityMappingStoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IdentityMappingStoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identityMappingStoreId">
        /// The <c>IdentityMappingStore</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="IdentityMappingStoreName"/> constructed from the provided ids.
        /// </returns>
        public static IdentityMappingStoreName FromProjectLocationIdentityMappingStore(string projectId, string locationId, string identityMappingStoreId) =>
            new IdentityMappingStoreName(ResourceNameType.ProjectLocationIdentityMappingStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), identityMappingStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IdentityMappingStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identityMappingStoreId">
        /// The <c>IdentityMappingStore</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="IdentityMappingStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string identityMappingStoreId) =>
            FormatProjectLocationIdentityMappingStore(projectId, locationId, identityMappingStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IdentityMappingStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identityMappingStoreId">
        /// The <c>IdentityMappingStore</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="IdentityMappingStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>.
        /// </returns>
        public static string FormatProjectLocationIdentityMappingStore(string projectId, string locationId, string identityMappingStoreId) =>
            s_projectLocationIdentityMappingStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IdentityMappingStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="identityMappingStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IdentityMappingStoreName"/> if successful.</returns>
        public static IdentityMappingStoreName Parse(string identityMappingStoreName) =>
            Parse(identityMappingStoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IdentityMappingStoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="identityMappingStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IdentityMappingStoreName"/> if successful.</returns>
        public static IdentityMappingStoreName Parse(string identityMappingStoreName, bool allowUnparsed) =>
            TryParse(identityMappingStoreName, allowUnparsed, out IdentityMappingStoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IdentityMappingStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="identityMappingStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IdentityMappingStoreName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string identityMappingStoreName, out IdentityMappingStoreName result) =>
            TryParse(identityMappingStoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IdentityMappingStoreName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="identityMappingStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IdentityMappingStoreName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string identityMappingStoreName, bool allowUnparsed, out IdentityMappingStoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(identityMappingStoreName, nameof(identityMappingStoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationIdentityMappingStore.TryParseName(identityMappingStoreName, out resourceName))
            {
                result = FromProjectLocationIdentityMappingStore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(identityMappingStoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IdentityMappingStoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string identityMappingStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IdentityMappingStoreId = identityMappingStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IdentityMappingStoreName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/identityMappingStores/{identity_mapping_store}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identityMappingStoreId">
        /// The <c>IdentityMappingStore</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public IdentityMappingStoreName(string projectId, string locationId, string identityMappingStoreId) : this(ResourceNameType.ProjectLocationIdentityMappingStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), identityMappingStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>IdentityMappingStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string IdentityMappingStoreId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationIdentityMappingStore: return s_projectLocationIdentityMappingStore.Expand(ProjectId, LocationId, IdentityMappingStoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IdentityMappingStoreName);

        /// <inheritdoc/>
        public bool Equals(IdentityMappingStoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IdentityMappingStoreName a, IdentityMappingStoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IdentityMappingStoreName a, IdentityMappingStoreName b) => !(a == b);
    }

    public partial class IdentityMappingStore
    {
        /// <summary>
        /// <see cref="gcdv::IdentityMappingStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::IdentityMappingStoreName IdentityMappingStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::IdentityMappingStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
