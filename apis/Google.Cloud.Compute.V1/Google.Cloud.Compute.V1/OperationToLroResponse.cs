﻿// Copyright 2021 Google LLC
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

using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using Google.Api.Gax.Grpc.Rest;

// Note: this will eventually be generated in ComputeLroAdaptation.g.cs. It's the last bit of generator work we need to do.

namespace Google.Cloud.Compute.V1
{
    partial class Operation
    {
        internal lro::Operation ToLroResponse(string name)
        {
            // TODO: Work this out much more carefully. In particular, consider whether a Compute LRO can complete successfully with errors...
            var proto = new lro::Operation
            {
                // Derived from [(google.cloud.operation_field) = STATUS]
                Done = Status == Types.Status.Done,
                // Taken from [(google.cloud.operation_field) = NAME]
                Name = name,
                // Always pack the raw response as metadata
                Metadata = wkt::Any.Pack(this)                
            };
            if (proto.Done)
            {
                // Only pack the raw response as the LRO Response if we're done
                proto.Response = proto.Metadata;
            }
            // Derived from [(google.cloud.operation_field) = ERROR_CODE] and [(google.cloud.operation_field) = ERROR_MESSAGE]
            if (HasHttpErrorStatusCode)
            {
                proto.Error = new Rpc.Status
                {
                    // gRPC status codes directly correspond to values in google.rpc.Code
                    Code = (int) RestGrpcAdapter.ConvertHttpStatusCode(HttpErrorStatusCode),
                    Message = HttpErrorMessage
                };
            }
            return proto;
        }
    }
}
