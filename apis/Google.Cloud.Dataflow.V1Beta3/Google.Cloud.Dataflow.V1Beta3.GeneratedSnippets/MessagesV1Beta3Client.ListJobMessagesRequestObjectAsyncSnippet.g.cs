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
    // [START dataflow_v1beta3_generated_MessagesV1Beta3_ListJobMessages_async]
    using Google.Api.Gax;
    using Google.Cloud.Dataflow.V1Beta3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedMessagesV1Beta3ClientSnippets
    {
        /// <summary>Snippet for ListJobMessagesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ListJobMessagesRequestObjectAsync()
        {
            // Create client
            MessagesV1Beta3Client messagesV1Beta3Client = await MessagesV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            ListJobMessagesRequest request = new ListJobMessagesRequest
            {
                ProjectId = "",
                JobId = "",
                MinimumImportance = JobMessageImportance.Unknown,
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                Location = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobMessagesResponse, JobMessage> response = messagesV1Beta3Client.ListJobMessagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobMessage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobMessage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobMessage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobMessage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END dataflow_v1beta3_generated_MessagesV1Beta3_ListJobMessages_async]
}
