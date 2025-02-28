// Copyright 2022 Google LLC
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
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dataproc.V1", GetFileDescriptors)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/regions/*/operations/*}:cancel" }
                    proto::ByteString.FromBase64("IjMvdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw=")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/regions/*/operations/*}" }
                    proto::ByteString.FromBase64("KiwvdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/regions/*/operations/*}" }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/regions/*/operations}" }
                    proto::ByteString.FromBase64("EiovdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9uc30=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AutoscalingPoliciesReflection.Descriptor;
            yield return BatchesReflection.Descriptor;
            yield return ClustersReflection.Descriptor;
            yield return JobsReflection.Descriptor;
            yield return OperationsReflection.Descriptor;
            yield return SharedReflection.Descriptor;
            yield return WorkflowTemplatesReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
