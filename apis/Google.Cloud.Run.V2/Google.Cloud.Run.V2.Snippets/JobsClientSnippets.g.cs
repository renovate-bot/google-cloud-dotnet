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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedJobsClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::CreateJobRequest request = new gcrv::CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new gcrv::Job(),
                JobId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.CreateJob(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::CreateJobRequest request = new gcrv::CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new gcrv::Job(),
                JobId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.CreateJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, string, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Job job = new gcrv::Job();
            string jobId = "";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.CreateJob(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, string, CallSettings)
            // Additional: CreateJobAsync(string, Job, string, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Job job = new gcrv::Job();
            string jobId = "";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.CreateJobAsync(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames()
        {
            // Snippet: CreateJob(LocationName, Job, string, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::Job job = new gcrv::Job();
            string jobId = "";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.CreateJob(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNamesAsync()
        {
            // Snippet: CreateJobAsync(LocationName, Job, string, CallSettings)
            // Additional: CreateJobAsync(LocationName, Job, string, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::Job job = new gcrv::Job();
            string jobId = "";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.CreateJobAsync(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::GetJobRequest request = new gcrv::GetJobRequest
            {
                JobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            gcrv::Job response = jobsClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::GetJobRequest request = new gcrv::GetJobRequest
            {
                JobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            gcrv::Job response = await jobsClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            gcrv::Job response = jobsClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            gcrv::Job response = await jobsClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::JobName name = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            gcrv::Job response = jobsClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::JobName name = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            gcrv::Job response = await jobsClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::ListJobsRequest request = new gcrv::ListJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<gcrv::ListJobsResponse, gcrv::Job> response = jobsClient.ListJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsRequestObjectAsync()
        {
            // Snippet: ListJobsAsync(ListJobsRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ListJobsRequest request = new gcrv::ListJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<gcrv::ListJobsResponse, gcrv::Job> response = jobsClient.ListJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobs()
        {
            // Snippet: ListJobs(string, string, int?, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcrv::ListJobsResponse, gcrv::Job> response = jobsClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsAsync()
        {
            // Snippet: ListJobsAsync(string, string, int?, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcrv::ListJobsResponse, gcrv::Job> response = jobsClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsResourceNames()
        {
            // Snippet: ListJobs(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcrv::ListJobsResponse, gcrv::Job> response = jobsClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsResourceNamesAsync()
        {
            // Snippet: ListJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcrv::ListJobsResponse, gcrv::Job> response = jobsClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJobRequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::UpdateJobRequest request = new gcrv::UpdateJobRequest
            {
                Job = new gcrv::Job(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.UpdateJob(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceUpdateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobRequestObjectAsync()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest, CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::UpdateJobRequest request = new gcrv::UpdateJobRequest
            {
                Job = new gcrv::Job(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.UpdateJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceUpdateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob()
        {
            // Snippet: UpdateJob(Job, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::Job job = new gcrv::Job();
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.UpdateJob(job);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceUpdateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync()
        {
            // Snippet: UpdateJobAsync(Job, CallSettings)
            // Additional: UpdateJobAsync(Job, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::Job job = new gcrv::Job();
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.UpdateJobAsync(job);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceUpdateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobRequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::DeleteJobRequest request = new gcrv::DeleteJobRequest
            {
                JobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.DeleteJob(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobRequestObjectAsync()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::DeleteJobRequest request = new gcrv::DeleteJobRequest
            {
                JobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.DeleteJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.DeleteJob(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.DeleteJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobResourceNames()
        {
            // Snippet: DeleteJob(JobName, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::JobName name = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = jobsClient.DeleteJob(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = jobsClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobResourceNamesAsync()
        {
            // Snippet: DeleteJobAsync(JobName, CallSettings)
            // Additional: DeleteJobAsync(JobName, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::JobName name = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.DeleteJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunJob</summary>
        public void RunJobRequestObject()
        {
            // Snippet: RunJob(RunJobRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::RunJobRequest request = new gcrv::RunJobRequest
            {
                JobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ValidateOnly = false,
                Etag = "",
                Overrides = new gcrv::RunJobRequest.Types.Overrides(),
            };
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = jobsClient.RunJob(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = jobsClient.PollOnceRunJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunJobAsync</summary>
        public async Task RunJobRequestObjectAsync()
        {
            // Snippet: RunJobAsync(RunJobRequest, CallSettings)
            // Additional: RunJobAsync(RunJobRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::RunJobRequest request = new gcrv::RunJobRequest
            {
                JobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ValidateOnly = false,
                Etag = "",
                Overrides = new gcrv::RunJobRequest.Types.Overrides(),
            };
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await jobsClient.RunJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await jobsClient.PollOnceRunJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunJob</summary>
        public void RunJob()
        {
            // Snippet: RunJob(string, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = jobsClient.RunJob(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = jobsClient.PollOnceRunJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunJobAsync</summary>
        public async Task RunJobAsync()
        {
            // Snippet: RunJobAsync(string, CallSettings)
            // Additional: RunJobAsync(string, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await jobsClient.RunJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await jobsClient.PollOnceRunJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunJob</summary>
        public void RunJobResourceNames()
        {
            // Snippet: RunJob(JobName, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            gcrv::JobName name = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = jobsClient.RunJob(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = jobsClient.PollOnceRunJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunJobAsync</summary>
        public async Task RunJobResourceNamesAsync()
        {
            // Snippet: RunJobAsync(JobName, CallSettings)
            // Additional: RunJobAsync(JobName, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::JobName name = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await jobsClient.RunJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await jobsClient.PollOnceRunJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = jobsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await jobsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = jobsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await jobsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcrv::JobsClient jobsClient = gcrv::JobsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = jobsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await jobsClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
