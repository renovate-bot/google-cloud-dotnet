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
    // [START chronicle_v1_generated_ReferenceListService_GetReferenceList_async]
    using Google.Cloud.Chronicle.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedReferenceListServiceClientSnippets
    {
        /// <summary>Snippet for GetReferenceListAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GetReferenceListRequestObjectAsync()
        {
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReferenceListRequest request = new GetReferenceListRequest
            {
                ReferenceListName = ReferenceListName.FromProjectLocationInstanceReferenceList("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[REFERENCE_LIST]"),
                View = ReferenceListView.Unspecified,
            };
            // Make the request
            ReferenceList response = await referenceListServiceClient.GetReferenceListAsync(request);
        }
    }
    // [END chronicle_v1_generated_ReferenceListService_GetReferenceList_async]
}
