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
using gcscv = Google.Cloud.Storage.Control.V2;
using sys = System;

namespace Google.Cloud.Storage.Control.V2
{
    /// <summary>Resource name for the <c>Folder</c> resource.</summary>
    public sealed partial class FolderName : gax::IResourceName, sys::IEquatable<FolderName>
    {
        /// <summary>The possible contents of <see cref="FolderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>.
            /// </summary>
            ProjectBucketFolder = 1,
        }

        private static gax::PathTemplate s_projectBucketFolder = new gax::PathTemplate("projects/{project}/buckets/{bucket}/folders/{folder=**}");

        /// <summary>Creates a <see cref="FolderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FolderName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FolderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FolderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FolderName"/> with the pattern
        /// <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FolderName"/> constructed from the provided ids.</returns>
        public static FolderName FromProjectBucketFolder(string projectId, string bucketId, string folderId) =>
            new FolderName(ResourceNameType.ProjectBucketFolder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId, string folderId) =>
            FormatProjectBucketFolder(projectId, bucketId, folderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>.
        /// </returns>
        public static string FormatProjectBucketFolder(string projectId, string bucketId, string folderId) =>
            s_projectBucketFolder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>Parses the given resource name string into a new <see cref="FolderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderName"/> if successful.</returns>
        public static FolderName Parse(string folderName) => Parse(folderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FolderName"/> if successful.</returns>
        public static FolderName Parse(string folderName, bool allowUnparsed) =>
            TryParse(folderName, allowUnparsed, out FolderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderName, out FolderName result) => TryParse(folderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderName, bool allowUnparsed, out FolderName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucketFolder.TryParseName(folderName, out resourceName))
            {
                result = FromProjectBucketFolder(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(folderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FolderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string folderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            FolderId = folderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FolderName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}/folders/{folder=**}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        public FolderName(string projectId, string bucketId, string folderId) : this(ResourceNameType.ProjectBucketFolder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.ProjectBucketFolder: return s_projectBucketFolder.Expand(ProjectId, BucketId, FolderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FolderName);

        /// <inheritdoc/>
        public bool Equals(FolderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FolderName a, FolderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FolderName a, FolderName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>StorageLayout</c> resource.</summary>
    public sealed partial class StorageLayoutName : gax::IResourceName, sys::IEquatable<StorageLayoutName>
    {
        /// <summary>The possible contents of <see cref="StorageLayoutName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/buckets/{bucket}/storageLayout</c>.
            /// </summary>
            ProjectBucket = 1,
        }

        private static gax::PathTemplate s_projectBucket = new gax::PathTemplate("projects/{project}/buckets/{bucket}/storageLayout");

        /// <summary>Creates a <see cref="StorageLayoutName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StorageLayoutName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StorageLayoutName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StorageLayoutName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StorageLayoutName"/> with the pattern
        /// <c>projects/{project}/buckets/{bucket}/storageLayout</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StorageLayoutName"/> constructed from the provided ids.</returns>
        public static StorageLayoutName FromProjectBucket(string projectId, string bucketId) =>
            new StorageLayoutName(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StorageLayoutName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/storageLayout</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StorageLayoutName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/storageLayout</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId) => FormatProjectBucket(projectId, bucketId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StorageLayoutName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/storageLayout</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StorageLayoutName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/storageLayout</c>.
        /// </returns>
        public static string FormatProjectBucket(string projectId, string bucketId) =>
            s_projectBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StorageLayoutName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/storageLayout</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="storageLayoutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StorageLayoutName"/> if successful.</returns>
        public static StorageLayoutName Parse(string storageLayoutName) => Parse(storageLayoutName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StorageLayoutName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/storageLayout</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="storageLayoutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StorageLayoutName"/> if successful.</returns>
        public static StorageLayoutName Parse(string storageLayoutName, bool allowUnparsed) =>
            TryParse(storageLayoutName, allowUnparsed, out StorageLayoutName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StorageLayoutName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/storageLayout</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="storageLayoutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StorageLayoutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string storageLayoutName, out StorageLayoutName result) =>
            TryParse(storageLayoutName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StorageLayoutName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}/storageLayout</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="storageLayoutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StorageLayoutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string storageLayoutName, bool allowUnparsed, out StorageLayoutName result)
        {
            gax::GaxPreconditions.CheckNotNull(storageLayoutName, nameof(storageLayoutName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucket.TryParseName(storageLayoutName, out resourceName))
            {
                result = FromProjectBucket(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(storageLayoutName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StorageLayoutName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StorageLayoutName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}/storageLayout</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        public StorageLayoutName(string projectId, string bucketId) : this(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

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
                case ResourceNameType.ProjectBucket: return s_projectBucket.Expand(ProjectId, BucketId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StorageLayoutName);

        /// <inheritdoc/>
        public bool Equals(StorageLayoutName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StorageLayoutName a, StorageLayoutName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StorageLayoutName a, StorageLayoutName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ManagedFolder</c> resource.</summary>
    public sealed partial class ManagedFolderName : gax::IResourceName, sys::IEquatable<ManagedFolderName>
    {
        /// <summary>The possible contents of <see cref="ManagedFolderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>
            /// .
            /// </summary>
            ProjectBucketManagedFolder = 1,
        }

        private static gax::PathTemplate s_projectBucketManagedFolder = new gax::PathTemplate("projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}");

        /// <summary>Creates a <see cref="ManagedFolderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ManagedFolderName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ManagedFolderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ManagedFolderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ManagedFolderName"/> with the pattern
        /// <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managedFolderId">The <c>ManagedFolder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ManagedFolderName"/> constructed from the provided ids.</returns>
        public static ManagedFolderName FromProjectBucketManagedFolder(string projectId, string bucketId, string managedFolderId) =>
            new ManagedFolderName(ResourceNameType.ProjectBucketManagedFolder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), managedFolderId: gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagedFolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managedFolderId">The <c>ManagedFolder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagedFolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId, string managedFolderId) =>
            FormatProjectBucketManagedFolder(projectId, bucketId, managedFolderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagedFolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managedFolderId">The <c>ManagedFolder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagedFolderName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>.
        /// </returns>
        public static string FormatProjectBucketManagedFolder(string projectId, string bucketId, string managedFolderId) =>
            s_projectBucketManagedFolder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagedFolderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="managedFolderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ManagedFolderName"/> if successful.</returns>
        public static ManagedFolderName Parse(string managedFolderName) => Parse(managedFolderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagedFolderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managedFolderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ManagedFolderName"/> if successful.</returns>
        public static ManagedFolderName Parse(string managedFolderName, bool allowUnparsed) =>
            TryParse(managedFolderName, allowUnparsed, out ManagedFolderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagedFolderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="managedFolderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagedFolderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedFolderName, out ManagedFolderName result) =>
            TryParse(managedFolderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagedFolderName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managedFolderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagedFolderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedFolderName, bool allowUnparsed, out ManagedFolderName result)
        {
            gax::GaxPreconditions.CheckNotNull(managedFolderName, nameof(managedFolderName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucketManagedFolder.TryParseName(managedFolderName, out resourceName))
            {
                result = FromProjectBucketManagedFolder(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(managedFolderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ManagedFolderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string managedFolderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            ManagedFolderId = managedFolderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ManagedFolderName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managedFolderId">The <c>ManagedFolder</c> ID. Must not be <c>null</c> or empty.</param>
        public ManagedFolderName(string projectId, string bucketId, string managedFolderId) : this(ResourceNameType.ProjectBucketManagedFolder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), managedFolderId: gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>ManagedFolder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ManagedFolderId { get; }

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
                case ResourceNameType.ProjectBucketManagedFolder: return s_projectBucketManagedFolder.Expand(ProjectId, BucketId, ManagedFolderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ManagedFolderName);

        /// <inheritdoc/>
        public bool Equals(ManagedFolderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ManagedFolderName a, ManagedFolderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ManagedFolderName a, ManagedFolderName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AnywhereCache</c> resource.</summary>
    public sealed partial class AnywhereCacheName : gax::IResourceName, sys::IEquatable<AnywhereCacheName>
    {
        /// <summary>The possible contents of <see cref="AnywhereCacheName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>.
            /// </summary>
            ProjectBucketAnywhereCache = 1,
        }

        private static gax::PathTemplate s_projectBucketAnywhereCache = new gax::PathTemplate("projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}");

        /// <summary>Creates a <see cref="AnywhereCacheName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnywhereCacheName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnywhereCacheName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnywhereCacheName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnywhereCacheName"/> with the pattern
        /// <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="anywhereCacheId">The <c>AnywhereCache</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnywhereCacheName"/> constructed from the provided ids.</returns>
        public static AnywhereCacheName FromProjectBucketAnywhereCache(string projectId, string bucketId, string anywhereCacheId) =>
            new AnywhereCacheName(ResourceNameType.ProjectBucketAnywhereCache, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), anywhereCacheId: gax::GaxPreconditions.CheckNotNullOrEmpty(anywhereCacheId, nameof(anywhereCacheId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnywhereCacheName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="anywhereCacheId">The <c>AnywhereCache</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnywhereCacheName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId, string anywhereCacheId) =>
            FormatProjectBucketAnywhereCache(projectId, bucketId, anywhereCacheId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnywhereCacheName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="anywhereCacheId">The <c>AnywhereCache</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnywhereCacheName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>.
        /// </returns>
        public static string FormatProjectBucketAnywhereCache(string projectId, string bucketId, string anywhereCacheId) =>
            s_projectBucketAnywhereCache.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(anywhereCacheId, nameof(anywhereCacheId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnywhereCacheName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="anywhereCacheName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnywhereCacheName"/> if successful.</returns>
        public static AnywhereCacheName Parse(string anywhereCacheName) => Parse(anywhereCacheName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnywhereCacheName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="anywhereCacheName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnywhereCacheName"/> if successful.</returns>
        public static AnywhereCacheName Parse(string anywhereCacheName, bool allowUnparsed) =>
            TryParse(anywhereCacheName, allowUnparsed, out AnywhereCacheName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnywhereCacheName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="anywhereCacheName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnywhereCacheName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string anywhereCacheName, out AnywhereCacheName result) =>
            TryParse(anywhereCacheName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnywhereCacheName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="anywhereCacheName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnywhereCacheName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string anywhereCacheName, bool allowUnparsed, out AnywhereCacheName result)
        {
            gax::GaxPreconditions.CheckNotNull(anywhereCacheName, nameof(anywhereCacheName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucketAnywhereCache.TryParseName(anywhereCacheName, out resourceName))
            {
                result = FromProjectBucketAnywhereCache(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(anywhereCacheName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnywhereCacheName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string anywhereCacheId = null, string bucketId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnywhereCacheId = anywhereCacheId;
            BucketId = bucketId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnywhereCacheName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="anywhereCacheId">The <c>AnywhereCache</c> ID. Must not be <c>null</c> or empty.</param>
        public AnywhereCacheName(string projectId, string bucketId, string anywhereCacheId) : this(ResourceNameType.ProjectBucketAnywhereCache, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), anywhereCacheId: gax::GaxPreconditions.CheckNotNullOrEmpty(anywhereCacheId, nameof(anywhereCacheId)))
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
        /// The <c>AnywhereCache</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnywhereCacheId { get; }

        /// <summary>
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

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
                case ResourceNameType.ProjectBucketAnywhereCache: return s_projectBucketAnywhereCache.Expand(ProjectId, BucketId, AnywhereCacheId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnywhereCacheName);

        /// <inheritdoc/>
        public bool Equals(AnywhereCacheName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnywhereCacheName a, AnywhereCacheName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnywhereCacheName a, AnywhereCacheName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IntelligenceConfig</c> resource.</summary>
    public sealed partial class IntelligenceConfigName : gax::IResourceName, sys::IEquatable<IntelligenceConfigName>
    {
        /// <summary>The possible contents of <see cref="IntelligenceConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/intelligenceConfig</c>.
            /// </summary>
            FolderLocation = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{org}/locations/{location}/intelligenceConfig</c>.
            /// </summary>
            OrgLocation = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/intelligenceConfig</c>.
            /// </summary>
            ProjectLocation = 3,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}/intelligenceConfig");

        private static gax::PathTemplate s_orgLocation = new gax::PathTemplate("organizations/{org}/locations/{location}/intelligenceConfig");

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/intelligenceConfig");

        /// <summary>Creates a <see cref="IntelligenceConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IntelligenceConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IntelligenceConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IntelligenceConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IntelligenceConfigName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IntelligenceConfigName"/> constructed from the provided ids.</returns>
        public static IntelligenceConfigName FromFolderLocation(string folderId, string locationId) =>
            new IntelligenceConfigName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Creates a <see cref="IntelligenceConfigName"/> with the pattern
        /// <c>organizations/{org}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="orgId">The <c>Org</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IntelligenceConfigName"/> constructed from the provided ids.</returns>
        public static IntelligenceConfigName FromOrgLocation(string orgId, string locationId) =>
            new IntelligenceConfigName(ResourceNameType.OrgLocation, orgId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgId, nameof(orgId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Creates a <see cref="IntelligenceConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IntelligenceConfigName"/> constructed from the provided ids.</returns>
        public static IntelligenceConfigName FromProjectLocation(string projectId, string locationId) =>
            new IntelligenceConfigName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/intelligenceConfig</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/intelligenceConfig</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>organizations/{org}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="orgId">The <c>Org</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>organizations/{org}/locations/{location}/intelligenceConfig</c>.
        /// </returns>
        public static string FormatOrgLocation(string orgId, string locationId) =>
            s_orgLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(orgId, nameof(orgId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/intelligenceConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IntelligenceConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/intelligenceConfig</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IntelligenceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>organizations/{org}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/intelligenceConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="intelligenceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IntelligenceConfigName"/> if successful.</returns>
        public static IntelligenceConfigName Parse(string intelligenceConfigName) => Parse(intelligenceConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IntelligenceConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>organizations/{org}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/intelligenceConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="intelligenceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IntelligenceConfigName"/> if successful.</returns>
        public static IntelligenceConfigName Parse(string intelligenceConfigName, bool allowUnparsed) =>
            TryParse(intelligenceConfigName, allowUnparsed, out IntelligenceConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IntelligenceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>organizations/{org}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/intelligenceConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="intelligenceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IntelligenceConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string intelligenceConfigName, out IntelligenceConfigName result) =>
            TryParse(intelligenceConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IntelligenceConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>organizations/{org}/locations/{location}/intelligenceConfig</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/intelligenceConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="intelligenceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IntelligenceConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string intelligenceConfigName, bool allowUnparsed, out IntelligenceConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(intelligenceConfigName, nameof(intelligenceConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(intelligenceConfigName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_orgLocation.TryParseName(intelligenceConfigName, out resourceName))
            {
                result = FromOrgLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocation.TryParseName(intelligenceConfigName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(intelligenceConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IntelligenceConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string orgId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrgId = orgId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IntelligenceConfigName"/> class from the component parts of
        /// pattern <c>folders/{folder}/locations/{location}/intelligenceConfig</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public IntelligenceConfigName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Org</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string OrgId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                case ResourceNameType.OrgLocation: return s_orgLocation.Expand(OrgId, LocationId);
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IntelligenceConfigName);

        /// <inheritdoc/>
        public bool Equals(IntelligenceConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IntelligenceConfigName a, IntelligenceConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IntelligenceConfigName a, IntelligenceConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Bucket</c> resource.</summary>
    public sealed partial class BucketName : gax::IResourceName, sys::IEquatable<BucketName>
    {
        /// <summary>The possible contents of <see cref="BucketName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/buckets/{bucket}</c>.</summary>
            ProjectBucket = 1,
        }

        private static gax::PathTemplate s_projectBucket = new gax::PathTemplate("projects/{project}/buckets/{bucket}");

        /// <summary>Creates a <see cref="BucketName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BucketName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BucketName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BucketName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BucketName"/> with the pattern <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BucketName"/> constructed from the provided ids.</returns>
        public static BucketName FromProjectBucket(string projectId, string bucketId) =>
            new BucketName(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId) => FormatProjectBucket(projectId, bucketId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatProjectBucket(string projectId, string bucketId) =>
            s_projectBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>Parses the given resource name string into a new <see cref="BucketName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName) => Parse(bucketName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BucketName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName, bool allowUnparsed) =>
            TryParse(bucketName, allowUnparsed, out BucketName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, out BucketName result) => TryParse(bucketName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, bool allowUnparsed, out BucketName result)
        {
            gax::GaxPreconditions.CheckNotNull(bucketName, nameof(bucketName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucket.TryParseName(bucketName, out resourceName))
            {
                result = FromProjectBucket(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bucketName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BucketName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BucketName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        public BucketName(string projectId, string bucketId) : this(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

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
                case ResourceNameType.ProjectBucket: return s_projectBucket.Expand(ProjectId, BucketId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BucketName);

        /// <inheritdoc/>
        public bool Equals(BucketName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BucketName a, BucketName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BucketName a, BucketName b) => !(a == b);
    }

    public partial class Folder
    {
        /// <summary>
        /// <see cref="gcscv::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFolderRequest
    {
        /// <summary>
        /// <see cref="gcscv::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFolderRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFolderRequest
    {
        /// <summary>
        /// <see cref="gcscv::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFoldersRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RenameFolderRequest
    {
        /// <summary>
        /// <see cref="gcscv::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StorageLayout
    {
        /// <summary>
        /// <see cref="gcscv::StorageLayoutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::StorageLayoutName StorageLayoutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::StorageLayoutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetStorageLayoutRequest
    {
        /// <summary>
        /// <see cref="gcscv::StorageLayoutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::StorageLayoutName StorageLayoutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::StorageLayoutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ManagedFolder
    {
        /// <summary>
        /// <see cref="gcscv::ManagedFolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::ManagedFolderName ManagedFolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::ManagedFolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetManagedFolderRequest
    {
        /// <summary>
        /// <see cref="gcscv::ManagedFolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::ManagedFolderName ManagedFolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::ManagedFolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateManagedFolderRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteManagedFolderRequest
    {
        /// <summary>
        /// <see cref="gcscv::ManagedFolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::ManagedFolderName ManagedFolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::ManagedFolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListManagedFoldersRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AnywhereCache
    {
        /// <summary>
        /// <see cref="gcscv::AnywhereCacheName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::AnywhereCacheName AnywhereCacheName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::AnywhereCacheName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAnywhereCacheRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DisableAnywhereCacheRequest
    {
        /// <summary>
        /// <see cref="gcscv::AnywhereCacheName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::AnywhereCacheName AnywhereCacheName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::AnywhereCacheName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PauseAnywhereCacheRequest
    {
        /// <summary>
        /// <see cref="gcscv::AnywhereCacheName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::AnywhereCacheName AnywhereCacheName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::AnywhereCacheName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeAnywhereCacheRequest
    {
        /// <summary>
        /// <see cref="gcscv::AnywhereCacheName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::AnywhereCacheName AnywhereCacheName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::AnywhereCacheName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAnywhereCacheRequest
    {
        /// <summary>
        /// <see cref="gcscv::AnywhereCacheName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::AnywhereCacheName AnywhereCacheName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::AnywhereCacheName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnywhereCachesRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class IntelligenceConfig
    {
        /// <summary>
        /// <see cref="gcscv::IntelligenceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::IntelligenceConfigName IntelligenceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::IntelligenceConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetOrganizationIntelligenceConfigRequest
    {
        /// <summary>
        /// <see cref="gcscv::IntelligenceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::IntelligenceConfigName IntelligenceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::IntelligenceConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFolderIntelligenceConfigRequest
    {
        /// <summary>
        /// <see cref="gcscv::IntelligenceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::IntelligenceConfigName IntelligenceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::IntelligenceConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProjectIntelligenceConfigRequest
    {
        /// <summary>
        /// <see cref="gcscv::IntelligenceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::IntelligenceConfigName IntelligenceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::IntelligenceConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
