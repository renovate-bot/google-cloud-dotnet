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
    // [START storage_v2_generated_Storage_RewriteObject_sync]
    using Google.Cloud.Storage.V2;
    using Google.Protobuf;

    public sealed partial class GeneratedStorageClientSnippets
    {
        /// <summary>Snippet for RewriteObject</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void RewriteObjectRequestObject()
        {
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            RewriteObjectRequest request = new RewriteObjectRequest
            {
                Destination = new Object(),
                SourceBucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                SourceObject = "",
                SourceGeneration = 0L,
                RewriteToken = "",
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                MaxBytesRewrittenPerCall = 0L,
                CopySourceEncryptionAlgorithm = "",
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                CopySourceEncryptionKeyBytes = ByteString.Empty,
                CopySourceEncryptionKeySha256Bytes = ByteString.Empty,
                DestinationName = "",
                DestinationBucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                DestinationKmsKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            RewriteResponse response = storageClient.RewriteObject(request);
        }
    }
    // [END storage_v2_generated_Storage_RewriteObject_sync]
}
