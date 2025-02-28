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

namespace Google.Cloud.DataLabeling.V1Beta1.Snippets
{
    // [START datalabeling_v1beta1_generated_DataLabelingService_ExportData_async_flattened]
    using Google.Cloud.DataLabeling.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataLabelingServiceClientSnippets
    {
        /// <summary>Snippet for ExportDataAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExportDataAsync()
        {
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            string annotatedDataset = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            string filter = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = await dataLabelingServiceClient.ExportDataAsync(name, annotatedDataset, filter, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datalabeling_v1beta1_generated_DataLabelingService_ExportData_async_flattened]
}
