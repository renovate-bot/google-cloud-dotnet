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

namespace GoogleCSharpSnippets
{
    // [START iam_v2_generated_Policies_UpdatePolicy_async]
    using Google.Cloud.Iam.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPoliciesClientSnippets
    {
        /// <summary>Snippet for UpdatePolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdatePolicyRequestObjectAsync()
        {
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = await policiesClient.UpdatePolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = await policiesClient.PollOnceUpdatePolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END iam_v2_generated_Policies_UpdatePolicy_async]
}
