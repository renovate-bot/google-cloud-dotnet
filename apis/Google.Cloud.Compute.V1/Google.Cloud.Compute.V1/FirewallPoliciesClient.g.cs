// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="FirewallPoliciesClient"/> instances.</summary>
    public sealed partial class FirewallPoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FirewallPoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FirewallPoliciesSettings"/>.</returns>
        public static FirewallPoliciesSettings GetDefault() => new FirewallPoliciesSettings();

        /// <summary>Constructs a new <see cref="FirewallPoliciesSettings"/> object with default settings.</summary>
        public FirewallPoliciesSettings()
        {
        }

        private FirewallPoliciesSettings(FirewallPoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddAssociationSettings = existing.AddAssociationSettings;
            AddRuleSettings = existing.AddRuleSettings;
            CloneRulesSettings = existing.CloneRulesSettings;
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            GetAssociationSettings = existing.GetAssociationSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            GetRuleSettings = existing.GetRuleSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            ListAssociationsSettings = existing.ListAssociationsSettings;
            MoveSettings = existing.MoveSettings;
            PatchSettings = existing.PatchSettings;
            PatchRuleSettings = existing.PatchRuleSettings;
            RemoveAssociationSettings = existing.RemoveAssociationSettings;
            RemoveRuleSettings = existing.RemoveRuleSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirewallPoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.AddAssociation</c> and <c>FirewallPoliciesClient.AddAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.AddRule</c> and <c>FirewallPoliciesClient.AddRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.CloneRules</c> and <c>FirewallPoliciesClient.CloneRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CloneRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.Delete</c> and <c>FirewallPoliciesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirewallPoliciesClient.Get</c>
        ///  and <c>FirewallPoliciesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.GetAssociation</c> and <c>FirewallPoliciesClient.GetAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.GetIamPolicy</c> and <c>FirewallPoliciesClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.GetRule</c> and <c>FirewallPoliciesClient.GetRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.Insert</c> and <c>FirewallPoliciesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirewallPoliciesClient.List</c>
        ///  and <c>FirewallPoliciesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.ListAssociations</c> and <c>FirewallPoliciesClient.ListAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirewallPoliciesClient.Move</c>
        ///  and <c>FirewallPoliciesClient.MoveAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.Patch</c> and <c>FirewallPoliciesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.PatchRule</c> and <c>FirewallPoliciesClient.PatchRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.RemoveAssociation</c> and <c>FirewallPoliciesClient.RemoveAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.RemoveRule</c> and <c>FirewallPoliciesClient.RemoveRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.SetIamPolicy</c> and <c>FirewallPoliciesClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallPoliciesClient.TestIamPermissions</c> and <c>FirewallPoliciesClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FirewallPoliciesSettings"/> object.</returns>
        public FirewallPoliciesSettings Clone() => new FirewallPoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirewallPoliciesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class FirewallPoliciesClientBuilder : gaxgrpc::ClientBuilderBase<FirewallPoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FirewallPoliciesSettings Settings { get; set; }

        partial void InterceptBuild(ref FirewallPoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FirewallPoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FirewallPoliciesClient Build()
        {
            FirewallPoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FirewallPoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FirewallPoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FirewallPoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirewallPoliciesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FirewallPoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirewallPoliciesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FirewallPoliciesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FirewallPoliciesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirewallPoliciesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>FirewallPolicies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The FirewallPolicies API.
    /// </remarks>
    public abstract partial class FirewallPoliciesClient
    {
        /// <summary>
        /// The default endpoint for the FirewallPolicies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default FirewallPolicies scopes.</summary>
        /// <remarks>
        /// The default FirewallPolicies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="FirewallPoliciesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FirewallPoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FirewallPoliciesClient"/>.</returns>
        public static stt::Task<FirewallPoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FirewallPoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FirewallPoliciesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FirewallPoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FirewallPoliciesClient"/>.</returns>
        public static FirewallPoliciesClient Create() => new FirewallPoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FirewallPoliciesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FirewallPoliciesSettings"/>.</param>
        /// <returns>The created <see cref="FirewallPoliciesClient"/>.</returns>
        internal static FirewallPoliciesClient Create(grpccore::CallInvoker callInvoker, FirewallPoliciesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FirewallPolicies.FirewallPoliciesClient grpcClient = new FirewallPolicies.FirewallPoliciesClient(callInvoker);
            return new FirewallPoliciesClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC FirewallPolicies client</summary>
        public virtual FirewallPolicies.FirewallPoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddAssociation(AddAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddAssociationAsync(AddAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddAssociationAsync(AddAssociationFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            AddAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddAssociation(string firewallPolicy, FirewallPolicyAssociation firewallPolicyAssociationResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAssociation(new AddAssociationFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyAssociationResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyAssociationResource, nameof(firewallPolicyAssociationResource)),
            }, callSettings);

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddAssociationAsync(string firewallPolicy, FirewallPolicyAssociation firewallPolicyAssociationResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAssociationAsync(new AddAssociationFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyAssociationResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyAssociationResource, nameof(firewallPolicyAssociationResource)),
            }, callSettings);

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddAssociationAsync(string firewallPolicy, FirewallPolicyAssociation firewallPolicyAssociationResource, st::CancellationToken cancellationToken) =>
            AddAssociationAsync(firewallPolicy, firewallPolicyAssociationResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddRule(AddRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddRuleAsync(AddRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddRuleAsync(AddRuleFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            AddRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddRule(string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            AddRule(new AddRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddRuleAsync(string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            AddRuleAsync(new AddRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddRuleAsync(string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, st::CancellationToken cancellationToken) =>
            AddRuleAsync(firewallPolicy, firewallPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CloneRules(CloneRulesFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CloneRulesAsync(CloneRulesFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CloneRulesAsync(CloneRulesFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            CloneRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CloneRules(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CloneRules(new CloneRulesFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CloneRulesAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CloneRulesAsync(new CloneRulesFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CloneRulesAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            CloneRulesAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            DeleteAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicy Get(GetFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(GetFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(GetFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicy Get(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            GetAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyAssociation GetAssociation(GetAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(GetAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(GetAssociationFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyAssociation GetAssociation(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAssociation(new GetAssociationFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAssociationAsync(new GetAssociationFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            GetAssociationAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new GetIamPolicyFirewallPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new GetIamPolicyFirewallPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyRule GetRule(GetRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(GetRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(GetRuleFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyRule GetRule(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            GetRuleAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertFirewallPolicyRequest
            {
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertFirewallPolicyRequest
            {
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(FirewallPolicy firewallPolicyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(firewallPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyList List(ListFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyList> ListAsync(ListFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyList> ListAsync(ListFirewallPoliciesRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyList List(gaxgrpc::CallSettings callSettings = null) =>
            List(new ListFirewallPoliciesRequest { }, callSettings);

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyList> ListAsync(gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListFirewallPoliciesRequest { }, callSettings);

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyList> ListAsync(st::CancellationToken cancellationToken) =>
            ListAsync(gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPoliciesListAssociationsResponse ListAssociations(ListAssociationsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPoliciesListAssociationsResponse> ListAssociationsAsync(ListAssociationsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPoliciesListAssociationsResponse> ListAssociationsAsync(ListAssociationsFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            ListAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPoliciesListAssociationsResponse ListAssociations(gaxgrpc::CallSettings callSettings = null) =>
            ListAssociations(new ListAssociationsFirewallPolicyRequest { }, callSettings);

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPoliciesListAssociationsResponse> ListAssociationsAsync(gaxgrpc::CallSettings callSettings = null) =>
            ListAssociationsAsync(new ListAssociationsFirewallPolicyRequest { }, callSettings);

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPoliciesListAssociationsResponse> ListAssociationsAsync(st::CancellationToken cancellationToken) =>
            ListAssociationsAsync(gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Move(MoveFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> MoveAsync(MoveFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> MoveAsync(MoveFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            MoveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Move(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Move(new MoveFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> MoveAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            MoveAsync(new MoveFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> MoveAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            MoveAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string firewallPolicy, FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string firewallPolicy, FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string firewallPolicy, FirewallPolicy firewallPolicyResource, st::CancellationToken cancellationToken) =>
            PatchAsync(firewallPolicy, firewallPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation PatchRule(PatchRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchRuleAsync(PatchRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchRuleAsync(PatchRuleFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            PatchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation PatchRule(string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchRule(new PatchRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchRuleAsync(string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchRuleAsync(new PatchRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchRuleAsync(string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, st::CancellationToken cancellationToken) =>
            PatchRuleAsync(firewallPolicy, firewallPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RemoveAssociation(RemoveAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveAssociationAsync(RemoveAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveAssociationAsync(RemoveAssociationFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            RemoveAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RemoveAssociation(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssociation(new RemoveAssociationFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveAssociationAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssociationAsync(new RemoveAssociationFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveAssociationAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            RemoveAssociationAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RemoveRule(RemoveRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveRuleAsync(RemoveRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveRuleAsync(RemoveRuleFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            RemoveRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RemoveRule(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveRule(new RemoveRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveRuleAsync(string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveRuleAsync(new RemoveRuleFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveRuleAsync(string firewallPolicy, st::CancellationToken cancellationToken) =>
            RemoveRuleAsync(firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="globalOrganizationSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(string resource, GlobalOrganizationSetPolicyRequest globalOrganizationSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(globalOrganizationSetPolicyRequestResource, nameof(globalOrganizationSetPolicyRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="globalOrganizationSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string resource, GlobalOrganizationSetPolicyRequest globalOrganizationSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(globalOrganizationSetPolicyRequestResource, nameof(globalOrganizationSetPolicyRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="globalOrganizationSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string resource, GlobalOrganizationSetPolicyRequest globalOrganizationSetPolicyRequestResource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, globalOrganizationSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FirewallPolicies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The FirewallPolicies API.
    /// </remarks>
    public sealed partial class FirewallPoliciesClientImpl : FirewallPoliciesClient
    {
        private readonly gaxgrpc::ApiCall<AddAssociationFirewallPolicyRequest, Operation> _callAddAssociation;

        private readonly gaxgrpc::ApiCall<AddRuleFirewallPolicyRequest, Operation> _callAddRule;

        private readonly gaxgrpc::ApiCall<CloneRulesFirewallPolicyRequest, Operation> _callCloneRules;

        private readonly gaxgrpc::ApiCall<DeleteFirewallPolicyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetFirewallPolicyRequest, FirewallPolicy> _callGet;

        private readonly gaxgrpc::ApiCall<GetAssociationFirewallPolicyRequest, FirewallPolicyAssociation> _callGetAssociation;

        private readonly gaxgrpc::ApiCall<GetIamPolicyFirewallPolicyRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<GetRuleFirewallPolicyRequest, FirewallPolicyRule> _callGetRule;

        private readonly gaxgrpc::ApiCall<InsertFirewallPolicyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListFirewallPoliciesRequest, FirewallPolicyList> _callList;

        private readonly gaxgrpc::ApiCall<ListAssociationsFirewallPolicyRequest, FirewallPoliciesListAssociationsResponse> _callListAssociations;

        private readonly gaxgrpc::ApiCall<MoveFirewallPolicyRequest, Operation> _callMove;

        private readonly gaxgrpc::ApiCall<PatchFirewallPolicyRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<PatchRuleFirewallPolicyRequest, Operation> _callPatchRule;

        private readonly gaxgrpc::ApiCall<RemoveAssociationFirewallPolicyRequest, Operation> _callRemoveAssociation;

        private readonly gaxgrpc::ApiCall<RemoveRuleFirewallPolicyRequest, Operation> _callRemoveRule;

        private readonly gaxgrpc::ApiCall<SetIamPolicyFirewallPolicyRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsFirewallPolicyRequest, TestPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the FirewallPolicies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirewallPoliciesSettings"/> used within this client.</param>
        public FirewallPoliciesClientImpl(FirewallPolicies.FirewallPoliciesClient grpcClient, FirewallPoliciesSettings settings)
        {
            GrpcClient = grpcClient;
            FirewallPoliciesSettings effectiveSettings = settings ?? FirewallPoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAddAssociation = clientHelper.BuildApiCall<AddAssociationFirewallPolicyRequest, Operation>(grpcClient.AddAssociationAsync, grpcClient.AddAssociation, effectiveSettings.AddAssociationSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callAddAssociation);
            Modify_AddAssociationApiCall(ref _callAddAssociation);
            _callAddRule = clientHelper.BuildApiCall<AddRuleFirewallPolicyRequest, Operation>(grpcClient.AddRuleAsync, grpcClient.AddRule, effectiveSettings.AddRuleSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callAddRule);
            Modify_AddRuleApiCall(ref _callAddRule);
            _callCloneRules = clientHelper.BuildApiCall<CloneRulesFirewallPolicyRequest, Operation>(grpcClient.CloneRulesAsync, grpcClient.CloneRules, effectiveSettings.CloneRulesSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callCloneRules);
            Modify_CloneRulesApiCall(ref _callCloneRules);
            _callDelete = clientHelper.BuildApiCall<DeleteFirewallPolicyRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetFirewallPolicyRequest, FirewallPolicy>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetAssociation = clientHelper.BuildApiCall<GetAssociationFirewallPolicyRequest, FirewallPolicyAssociation>(grpcClient.GetAssociationAsync, grpcClient.GetAssociation, effectiveSettings.GetAssociationSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callGetAssociation);
            Modify_GetAssociationApiCall(ref _callGetAssociation);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyFirewallPolicyRequest, Policy>(grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callGetRule = clientHelper.BuildApiCall<GetRuleFirewallPolicyRequest, FirewallPolicyRule>(grpcClient.GetRuleAsync, grpcClient.GetRule, effectiveSettings.GetRuleSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callGetRule);
            Modify_GetRuleApiCall(ref _callGetRule);
            _callInsert = clientHelper.BuildApiCall<InsertFirewallPolicyRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListFirewallPoliciesRequest, FirewallPolicyList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListAssociations = clientHelper.BuildApiCall<ListAssociationsFirewallPolicyRequest, FirewallPoliciesListAssociationsResponse>(grpcClient.ListAssociationsAsync, grpcClient.ListAssociations, effectiveSettings.ListAssociationsSettings);
            Modify_ApiCall(ref _callListAssociations);
            Modify_ListAssociationsApiCall(ref _callListAssociations);
            _callMove = clientHelper.BuildApiCall<MoveFirewallPolicyRequest, Operation>(grpcClient.MoveAsync, grpcClient.Move, effectiveSettings.MoveSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callMove);
            Modify_MoveApiCall(ref _callMove);
            _callPatch = clientHelper.BuildApiCall<PatchFirewallPolicyRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callPatchRule = clientHelper.BuildApiCall<PatchRuleFirewallPolicyRequest, Operation>(grpcClient.PatchRuleAsync, grpcClient.PatchRule, effectiveSettings.PatchRuleSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callPatchRule);
            Modify_PatchRuleApiCall(ref _callPatchRule);
            _callRemoveAssociation = clientHelper.BuildApiCall<RemoveAssociationFirewallPolicyRequest, Operation>(grpcClient.RemoveAssociationAsync, grpcClient.RemoveAssociation, effectiveSettings.RemoveAssociationSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callRemoveAssociation);
            Modify_RemoveAssociationApiCall(ref _callRemoveAssociation);
            _callRemoveRule = clientHelper.BuildApiCall<RemoveRuleFirewallPolicyRequest, Operation>(grpcClient.RemoveRuleAsync, grpcClient.RemoveRule, effectiveSettings.RemoveRuleSettings).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callRemoveRule);
            Modify_RemoveRuleApiCall(ref _callRemoveRule);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyFirewallPolicyRequest, Policy>(grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsFirewallPolicyRequest, TestPermissionsResponse>(grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddAssociationApiCall(ref gaxgrpc::ApiCall<AddAssociationFirewallPolicyRequest, Operation> call);

        partial void Modify_AddRuleApiCall(ref gaxgrpc::ApiCall<AddRuleFirewallPolicyRequest, Operation> call);

        partial void Modify_CloneRulesApiCall(ref gaxgrpc::ApiCall<CloneRulesFirewallPolicyRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteFirewallPolicyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetFirewallPolicyRequest, FirewallPolicy> call);

        partial void Modify_GetAssociationApiCall(ref gaxgrpc::ApiCall<GetAssociationFirewallPolicyRequest, FirewallPolicyAssociation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyFirewallPolicyRequest, Policy> call);

        partial void Modify_GetRuleApiCall(ref gaxgrpc::ApiCall<GetRuleFirewallPolicyRequest, FirewallPolicyRule> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertFirewallPolicyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListFirewallPoliciesRequest, FirewallPolicyList> call);

        partial void Modify_ListAssociationsApiCall(ref gaxgrpc::ApiCall<ListAssociationsFirewallPolicyRequest, FirewallPoliciesListAssociationsResponse> call);

        partial void Modify_MoveApiCall(ref gaxgrpc::ApiCall<MoveFirewallPolicyRequest, Operation> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchFirewallPolicyRequest, Operation> call);

        partial void Modify_PatchRuleApiCall(ref gaxgrpc::ApiCall<PatchRuleFirewallPolicyRequest, Operation> call);

        partial void Modify_RemoveAssociationApiCall(ref gaxgrpc::ApiCall<RemoveAssociationFirewallPolicyRequest, Operation> call);

        partial void Modify_RemoveRuleApiCall(ref gaxgrpc::ApiCall<RemoveRuleFirewallPolicyRequest, Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyFirewallPolicyRequest, Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsFirewallPolicyRequest, TestPermissionsResponse> call);

        partial void OnConstruction(FirewallPolicies.FirewallPoliciesClient grpcClient, FirewallPoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FirewallPolicies client</summary>
        public override FirewallPolicies.FirewallPoliciesClient GrpcClient { get; }

        partial void Modify_AddAssociationFirewallPolicyRequest(ref AddAssociationFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddRuleFirewallPolicyRequest(ref AddRuleFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CloneRulesFirewallPolicyRequest(ref CloneRulesFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFirewallPolicyRequest(ref DeleteFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFirewallPolicyRequest(ref GetFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssociationFirewallPolicyRequest(ref GetAssociationFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyFirewallPolicyRequest(ref GetIamPolicyFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuleFirewallPolicyRequest(ref GetRuleFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertFirewallPolicyRequest(ref InsertFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFirewallPoliciesRequest(ref ListFirewallPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssociationsFirewallPolicyRequest(ref ListAssociationsFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveFirewallPolicyRequest(ref MoveFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchFirewallPolicyRequest(ref PatchFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRuleFirewallPolicyRequest(ref PatchRuleFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAssociationFirewallPolicyRequest(ref RemoveAssociationFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveRuleFirewallPolicyRequest(ref RemoveRuleFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyFirewallPolicyRequest(ref SetIamPolicyFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsFirewallPolicyRequest(ref TestIamPermissionsFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddAssociation(AddAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssociationFirewallPolicyRequest(ref request, ref callSettings);
            return _callAddAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddAssociationAsync(AddAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssociationFirewallPolicyRequest(ref request, ref callSettings);
            return _callAddAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddRule(AddRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callAddRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddRuleAsync(AddRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callAddRule.Async(request, callSettings);
        }

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation CloneRules(CloneRulesFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloneRulesFirewallPolicyRequest(ref request, ref callSettings);
            return _callCloneRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CloneRulesAsync(CloneRulesFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloneRulesFirewallPolicyRequest(ref request, ref callSettings);
            return _callCloneRules.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallPolicyRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallPolicyRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicy Get(GetFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallPolicyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicy> GetAsync(GetFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallPolicyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicyAssociation GetAssociation(GetAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssociationFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicyAssociation> GetAssociationAsync(GetAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssociationFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicyRule GetRule(GetRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicyRule> GetRuleAsync(GetRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetRule.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertFirewallPolicyRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertFirewallPolicyRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicyList List(ListFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallPoliciesRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicyList> ListAsync(ListFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallPoliciesRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPoliciesListAssociationsResponse ListAssociations(ListAssociationsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssociationsFirewallPolicyRequest(ref request, ref callSettings);
            return _callListAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPoliciesListAssociationsResponse> ListAssociationsAsync(ListAssociationsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssociationsFirewallPolicyRequest(ref request, ref callSettings);
            return _callListAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Move(MoveFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFirewallPolicyRequest(ref request, ref callSettings);
            return _callMove.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> MoveAsync(MoveFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFirewallPolicyRequest(ref request, ref callSettings);
            return _callMove.Async(request, callSettings);
        }

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchFirewallPolicyRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchFirewallPolicyRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation PatchRule(PatchRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callPatchRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchRuleAsync(PatchRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callPatchRule.Async(request, callSettings);
        }

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RemoveAssociation(RemoveAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssociationFirewallPolicyRequest(ref request, ref callSettings);
            return _callRemoveAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RemoveAssociationAsync(RemoveAssociationFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssociationFirewallPolicyRequest(ref request, ref callSettings);
            return _callRemoveAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RemoveRule(RemoveRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callRemoveRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RemoveRuleAsync(RemoveRuleFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveRuleFirewallPolicyRequest(ref request, ref callSettings);
            return _callRemoveRule.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyFirewallPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyFirewallPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsFirewallPolicyRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsFirewallPolicyRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }
}
