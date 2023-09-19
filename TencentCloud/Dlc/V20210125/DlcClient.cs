/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dlc.V20210125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dlc.V20210125.Models;

   public class DlcClient : AbstractClient{

       private const string endpoint = "dlc.tencentcloudapi.com";
       private const string version = "2021-01-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DlcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DlcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to cancel a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public async Task<CancelSparkSessionBatchSQLResponse> CancelSparkSessionBatchSQL(CancelSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CancelSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public CancelSparkSessionBatchSQLResponse CancelSparkSessionBatchSQLSync(CancelSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CancelSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a task.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a task.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a data engine.
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public async Task<CreateDataEngineResponse> CreateDataEngine(CreateDataEngineRequest req)
        {
             JsonResponseModel<CreateDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a data engine.
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public CreateDataEngineResponse CreateDataEngineSync(CreateDataEngineRequest req)
        {
             JsonResponseModel<CreateDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a managed internal table. It has been disused.
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public async Task<CreateInternalTableResponse> CreateInternalTable(CreateInternalTableRequest req)
        {
             JsonResponseModel<CreateInternalTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInternalTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInternalTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a managed internal table. It has been disused.
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public CreateInternalTableResponse CreateInternalTableSync(CreateInternalTableRequest req)
        {
             JsonResponseModel<CreateInternalTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInternalTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInternalTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a query result download task.
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public async Task<CreateResultDownloadResponse> CreateResultDownload(CreateResultDownloadRequest req)
        {
             JsonResponseModel<CreateResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a query result download task.
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public CreateResultDownloadResponse CreateResultDownloadSync(CreateResultDownloadRequest req)
        {
             JsonResponseModel<CreateResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public async Task<CreateSparkAppResponse> CreateSparkApp(CreateSparkAppRequest req)
        {
             JsonResponseModel<CreateSparkAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public CreateSparkAppResponse CreateSparkAppSync(CreateSparkAppRequest req)
        {
             JsonResponseModel<CreateSparkAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public async Task<CreateSparkAppTaskResponse> CreateSparkAppTask(CreateSparkAppTaskRequest req)
        {
             JsonResponseModel<CreateSparkAppTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSparkAppTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public CreateSparkAppTaskResponse CreateSparkAppTaskSync(CreateSparkAppTaskRequest req)
        {
             JsonResponseModel<CreateSparkAppTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSparkAppTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit a Spark SQL batch task to the job engine.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public async Task<CreateSparkSessionBatchSQLResponse> CreateSparkSessionBatchSQL(CreateSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CreateSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit a Spark SQL batch task to the job engine.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public CreateSparkSessionBatchSQLResponse CreateSparkSessionBatchSQLSync(CreateSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CreateSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create and execute a SQL task. (`CreateTasks` is recommended.)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create and execute a SQL task. (`CreateTasks` is recommended.)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create and execute SQL tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public async Task<CreateTasksResponse> CreateTasks(CreateTasksRequest req)
        {
             JsonResponseModel<CreateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create and execute SQL tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public CreateTasksResponse CreateTasksSync(CreateTasksRequest req)
        {
             JsonResponseModel<CreateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public async Task<DeleteSparkAppResponse> DeleteSparkApp(DeleteSparkAppRequest req)
        {
             JsonResponseModel<DeleteSparkAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public DeleteSparkAppResponse DeleteSparkAppSync(DeleteSparkAppRequest req)
        {
             JsonResponseModel<DeleteSparkAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the resource usage of a data engine based on its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public async Task<DescribeEngineUsageInfoResponse> DescribeEngineUsageInfo(DescribeEngineUsageInfoRequest req)
        {
             JsonResponseModel<DescribeEngineUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEngineUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEngineUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the resource usage of a data engine based on its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public DescribeEngineUsageInfoResponse DescribeEngineUsageInfoSync(DescribeEngineUsageInfoRequest req)
        {
             JsonResponseModel<DescribeEngineUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEngineUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEngineUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of disabled table attributes (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public async Task<DescribeForbiddenTableProResponse> DescribeForbiddenTablePro(DescribeForbiddenTableProRequest req)
        {
             JsonResponseModel<DescribeForbiddenTableProResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeForbiddenTablePro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeForbiddenTableProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of disabled table attributes (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public DescribeForbiddenTableProResponse DescribeForbiddenTableProSync(DescribeForbiddenTableProRequest req)
        {
             JsonResponseModel<DescribeForbiddenTableProResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeForbiddenTablePro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeForbiddenTableProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the summary of a specified directory in a managed storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public async Task<DescribeLakeFsDirSummaryResponse> DescribeLakeFsDirSummary(DescribeLakeFsDirSummaryRequest req)
        {
             JsonResponseModel<DescribeLakeFsDirSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLakeFsDirSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsDirSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the summary of a specified directory in a managed storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public DescribeLakeFsDirSummaryResponse DescribeLakeFsDirSummarySync(DescribeLakeFsDirSummaryRequest req)
        {
             JsonResponseModel<DescribeLakeFsDirSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLakeFsDirSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsDirSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query managed storage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public async Task<DescribeLakeFsInfoResponse> DescribeLakeFsInfo(DescribeLakeFsInfoRequest req)
        {
             JsonResponseModel<DescribeLakeFsInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLakeFsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query managed storage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public DescribeLakeFsInfoResponse DescribeLakeFsInfoSync(DescribeLakeFsInfoRequest req)
        {
             JsonResponseModel<DescribeLakeFsInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLakeFsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a query result download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public async Task<DescribeResultDownloadResponse> DescribeResultDownload(DescribeResultDownloadRequest req)
        {
             JsonResponseModel<DescribeResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a query result download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public DescribeResultDownloadResponse DescribeResultDownloadSync(DescribeResultDownloadRequest req)
        {
             JsonResponseModel<DescribeResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to query the information of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public async Task<DescribeSparkAppJobResponse> DescribeSparkAppJob(DescribeSparkAppJobRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkAppJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to query the information of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public DescribeSparkAppJobResponse DescribeSparkAppJobSync(DescribeSparkAppJobRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkAppJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Spark jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public async Task<DescribeSparkAppJobsResponse> DescribeSparkAppJobs(DescribeSparkAppJobsRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkAppJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Spark jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public DescribeSparkAppJobsResponse DescribeSparkAppJobsSync(DescribeSparkAppJobsRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkAppJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of running task instances of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public async Task<DescribeSparkAppTasksResponse> DescribeSparkAppTasks(DescribeSparkAppTasksRequest req)
        {
             JsonResponseModel<DescribeSparkAppTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkAppTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of running task instances of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public DescribeSparkAppTasksResponse DescribeSparkAppTasksSync(DescribeSparkAppTasksRequest req)
        {
             JsonResponseModel<DescribeSparkAppTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkAppTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the logs of a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public async Task<DescribeSparkSessionBatchSqlLogResponse> DescribeSparkSessionBatchSqlLog(DescribeSparkSessionBatchSqlLogRequest req)
        {
             JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkSessionBatchSqlLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the logs of a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public DescribeSparkSessionBatchSqlLogResponse DescribeSparkSessionBatchSqlLogSync(DescribeSparkSessionBatchSqlLogRequest req)
        {
             JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkSessionBatchSqlLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public async Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate user roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public async Task<DescribeUserRolesResponse> DescribeUserRoles(DescribeUserRolesRequest req)
        {
             JsonResponseModel<DescribeUserRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enumerate user roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public DescribeUserRolesResponse DescribeUserRolesSync(DescribeUserRolesRequest req)
        {
             JsonResponseModel<DescribeUserRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate SQL statements for creating a managed table.
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public async Task<GenerateCreateMangedTableSqlResponse> GenerateCreateMangedTableSql(GenerateCreateMangedTableSqlRequest req)
        {
             JsonResponseModel<GenerateCreateMangedTableSqlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateCreateMangedTableSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateCreateMangedTableSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate SQL statements for creating a managed table.
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public GenerateCreateMangedTableSqlResponse GenerateCreateMangedTableSqlSync(GenerateCreateMangedTableSqlRequest req)
        {
             JsonResponseModel<GenerateCreateMangedTableSqlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateCreateMangedTableSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateCreateMangedTableSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change data governance event thresholds.
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public async Task<ModifyGovernEventRuleResponse> ModifyGovernEventRule(ModifyGovernEventRuleRequest req)
        {
             JsonResponseModel<ModifyGovernEventRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGovernEventRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGovernEventRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change data governance event thresholds.
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public ModifyGovernEventRuleResponse ModifyGovernEventRuleSync(ModifyGovernEventRuleRequest req)
        {
             JsonResponseModel<ModifyGovernEventRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGovernEventRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGovernEventRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Spark job.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public async Task<ModifySparkAppResponse> ModifySparkApp(ModifySparkAppRequest req)
        {
             JsonResponseModel<ModifySparkAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Spark job.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public ModifySparkAppResponse ModifySparkAppSync(ModifySparkAppRequest req)
        {
             JsonResponseModel<ModifySparkAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Spark job parameters in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public async Task<ModifySparkAppBatchResponse> ModifySparkAppBatch(ModifySparkAppBatchRequest req)
        {
             JsonResponseModel<ModifySparkAppBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySparkAppBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Spark job parameters in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public ModifySparkAppBatchResponse ModifySparkAppBatchSync(ModifySparkAppBatchRequest req)
        {
             JsonResponseModel<ModifySparkAppBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySparkAppBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to suspend or start a data engine.
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public async Task<SuspendResumeDataEngineResponse> SuspendResumeDataEngine(SuspendResumeDataEngineRequest req)
        {
             JsonResponseModel<SuspendResumeDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SuspendResumeDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendResumeDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to suspend or start a data engine.
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public SuspendResumeDataEngineResponse SuspendResumeDataEngineSync(SuspendResumeDataEngineRequest req)
        {
             JsonResponseModel<SuspendResumeDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SuspendResumeDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendResumeDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch between the primary and standby clusters.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public async Task<SwitchDataEngineResponse> SwitchDataEngine(SwitchDataEngineRequest req)
        {
             JsonResponseModel<SwitchDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch between the primary and standby clusters.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public SwitchDataEngineResponse SwitchDataEngineSync(SwitchDataEngineRequest req)
        {
             JsonResponseModel<SwitchDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update row filters. Please note that it updates filters only but not catalogs, databases, or tables.
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public async Task<UpdateRowFilterResponse> UpdateRowFilter(UpdateRowFilterRequest req)
        {
             JsonResponseModel<UpdateRowFilterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRowFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRowFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update row filters. Please note that it updates filters only but not catalogs, databases, or tables.
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public UpdateRowFilterResponse UpdateRowFilterSync(UpdateRowFilterRequest req)
        {
             JsonResponseModel<UpdateRowFilterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRowFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRowFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
