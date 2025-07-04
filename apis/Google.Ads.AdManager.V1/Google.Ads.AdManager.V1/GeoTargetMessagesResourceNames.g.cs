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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>GeoTarget</c> resource.</summary>
    public sealed partial class GeoTargetName : gax::IResourceName, sys::IEquatable<GeoTargetName>
    {
        /// <summary>The possible contents of <see cref="GeoTargetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/geoTargets/{geo_target}</c>.</summary>
            NetworkCodeGeoTarget = 1,
        }

        private static gax::PathTemplate s_networkCodeGeoTarget = new gax::PathTemplate("networks/{network_code}/geoTargets/{geo_target}");

        /// <summary>Creates a <see cref="GeoTargetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GeoTargetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GeoTargetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GeoTargetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GeoTargetName"/> with the pattern <c>networks/{network_code}/geoTargets/{geo_target}</c>
        /// .
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="geoTargetId">The <c>GeoTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GeoTargetName"/> constructed from the provided ids.</returns>
        public static GeoTargetName FromNetworkCodeGeoTarget(string networkCodeId, string geoTargetId) =>
            new GeoTargetName(ResourceNameType.NetworkCodeGeoTarget, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), geoTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(geoTargetId, nameof(geoTargetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GeoTargetName"/> with pattern
        /// <c>networks/{network_code}/geoTargets/{geo_target}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="geoTargetId">The <c>GeoTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GeoTargetName"/> with pattern
        /// <c>networks/{network_code}/geoTargets/{geo_target}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string geoTargetId) =>
            FormatNetworkCodeGeoTarget(networkCodeId, geoTargetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GeoTargetName"/> with pattern
        /// <c>networks/{network_code}/geoTargets/{geo_target}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="geoTargetId">The <c>GeoTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GeoTargetName"/> with pattern
        /// <c>networks/{network_code}/geoTargets/{geo_target}</c>.
        /// </returns>
        public static string FormatNetworkCodeGeoTarget(string networkCodeId, string geoTargetId) =>
            s_networkCodeGeoTarget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(geoTargetId, nameof(geoTargetId)));

        /// <summary>Parses the given resource name string into a new <see cref="GeoTargetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/geoTargets/{geo_target}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="geoTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GeoTargetName"/> if successful.</returns>
        public static GeoTargetName Parse(string geoTargetName) => Parse(geoTargetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GeoTargetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/geoTargets/{geo_target}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="geoTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GeoTargetName"/> if successful.</returns>
        public static GeoTargetName Parse(string geoTargetName, bool allowUnparsed) =>
            TryParse(geoTargetName, allowUnparsed, out GeoTargetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GeoTargetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/geoTargets/{geo_target}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="geoTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GeoTargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string geoTargetName, out GeoTargetName result) => TryParse(geoTargetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GeoTargetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/geoTargets/{geo_target}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="geoTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GeoTargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string geoTargetName, bool allowUnparsed, out GeoTargetName result)
        {
            gax::GaxPreconditions.CheckNotNull(geoTargetName, nameof(geoTargetName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeGeoTarget.TryParseName(geoTargetName, out resourceName))
            {
                result = FromNetworkCodeGeoTarget(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(geoTargetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GeoTargetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string geoTargetId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GeoTargetId = geoTargetId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GeoTargetName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/geoTargets/{geo_target}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="geoTargetId">The <c>GeoTarget</c> ID. Must not be <c>null</c> or empty.</param>
        public GeoTargetName(string networkCodeId, string geoTargetId) : this(ResourceNameType.NetworkCodeGeoTarget, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), geoTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(geoTargetId, nameof(geoTargetId)))
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
        /// The <c>GeoTarget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GeoTargetId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeGeoTarget: return s_networkCodeGeoTarget.Expand(NetworkCodeId, GeoTargetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GeoTargetName);

        /// <inheritdoc/>
        public bool Equals(GeoTargetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GeoTargetName a, GeoTargetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GeoTargetName a, GeoTargetName b) => !(a == b);
    }

    public partial class GeoTarget
    {
        /// <summary>
        /// <see cref="gaav::GeoTargetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::GeoTargetName GeoTargetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::GeoTargetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gaav::GeoTargetName"/>-typed view over the <see cref="CanonicalParent"/> resource name property.
        /// </summary>
        public gaav::GeoTargetName CanonicalParentAsGeoTargetName
        {
            get => string.IsNullOrEmpty(CanonicalParent) ? null : gaav::GeoTargetName.Parse(CanonicalParent, allowUnparsed: true);
            set => CanonicalParent = value?.ToString() ?? "";
        }
    }
}
