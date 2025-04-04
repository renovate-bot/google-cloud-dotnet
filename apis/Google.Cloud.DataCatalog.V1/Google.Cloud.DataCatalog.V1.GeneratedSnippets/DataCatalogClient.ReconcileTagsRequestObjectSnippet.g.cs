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
    // [START datacatalog_v1_generated_DataCatalog_ReconcileTags_sync]
    using Google.Cloud.DataCatalog.V1;
    using Google.LongRunning;
    using System;

    public sealed partial class GeneratedDataCatalogClientSnippets
    {
        /// <summary>Snippet for ReconcileTags</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        [ObsoleteAttribute]
        public void ReconcileTagsRequestObject()
        {
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ReconcileTagsRequest request = new ReconcileTagsRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                TagTemplateAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                ForceDeleteMissing = false,
                Tags = { new Tag(), },
            };
            // Make the request
#pragma warning disable CS0612
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> response = dataCatalogClient.ReconcileTags(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReconcileTagsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> retrievedResponse = dataCatalogClient.PollOnceReconcileTags(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReconcileTagsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datacatalog_v1_generated_DataCatalog_ReconcileTags_sync]
}
