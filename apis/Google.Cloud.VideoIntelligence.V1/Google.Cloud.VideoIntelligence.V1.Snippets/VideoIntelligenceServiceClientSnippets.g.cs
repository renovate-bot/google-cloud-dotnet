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
    using Google.Cloud.VideoIntelligence.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVideoIntelligenceServiceClientSnippets
    {
        /// <summary>Snippet for AnnotateVideo</summary>
        public void AnnotateVideoRequestObject()
        {
            // Snippet: AnnotateVideo(AnnotateVideoRequest, CallSettings)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = VideoIntelligenceServiceClient.Create();
            // Initialize request argument(s)
            AnnotateVideoRequest request = new AnnotateVideoRequest
            {
                InputUri = "",
                Features =
                {
                    Feature.Unspecified,
                },
                VideoContext = new VideoContext(),
                OutputUri = "",
                LocationId = "",
                InputContent = ByteString.Empty,
            };
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response = videoIntelligenceServiceClient.AnnotateVideo(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse = videoIntelligenceServiceClient.PollOnceAnnotateVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnnotateVideoAsync</summary>
        public async Task AnnotateVideoRequestObjectAsync()
        {
            // Snippet: AnnotateVideoAsync(AnnotateVideoRequest, CallSettings)
            // Additional: AnnotateVideoAsync(AnnotateVideoRequest, CancellationToken)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = await VideoIntelligenceServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotateVideoRequest request = new AnnotateVideoRequest
            {
                InputUri = "",
                Features =
                {
                    Feature.Unspecified,
                },
                VideoContext = new VideoContext(),
                OutputUri = "",
                LocationId = "",
                InputContent = ByteString.Empty,
            };
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response = await videoIntelligenceServiceClient.AnnotateVideoAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse = await videoIntelligenceServiceClient.PollOnceAnnotateVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnnotateVideo</summary>
        public void AnnotateVideo()
        {
            // Snippet: AnnotateVideo(string, IEnumerable<Feature>, CallSettings)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = VideoIntelligenceServiceClient.Create();
            // Initialize request argument(s)
            string inputUri = "";
            IEnumerable<Feature> features = new Feature[]
            {
                Feature.Unspecified,
            };
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response = videoIntelligenceServiceClient.AnnotateVideo(inputUri, features);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse = videoIntelligenceServiceClient.PollOnceAnnotateVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnnotateVideoAsync</summary>
        public async Task AnnotateVideoAsync()
        {
            // Snippet: AnnotateVideoAsync(string, IEnumerable<Feature>, CallSettings)
            // Additional: AnnotateVideoAsync(string, IEnumerable<Feature>, CancellationToken)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = await VideoIntelligenceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string inputUri = "";
            IEnumerable<Feature> features = new Feature[]
            {
                Feature.Unspecified,
            };
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response = await videoIntelligenceServiceClient.AnnotateVideoAsync(inputUri, features);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse = await videoIntelligenceServiceClient.PollOnceAnnotateVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
