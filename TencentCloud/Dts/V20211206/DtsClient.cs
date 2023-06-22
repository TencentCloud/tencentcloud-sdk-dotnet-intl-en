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

namespace TencentCloud.Dts.V20211206
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dts.V20211206.Models;

   public class DtsClient : AbstractClient{

       private const string endpoint = "dts.tencentcloudapi.com";
       private const string version = "2021-12-06";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready for completion to stop migrating incremental data.
        /// If the task status queried through the `DescribeMigrationJobs` API is ready (`Status` = `readyComplete), you can call this API to complete the migration task.
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public async Task<CompleteMigrateJobResponse> CompleteMigrateJob(CompleteMigrateJobRequest req)
        {
             JsonResponseModel<CompleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready for completion to stop migrating incremental data.
        /// If the task status queried through the `DescribeMigrationJobs` API is ready (`Status` = `readyComplete), you can call this API to complete the migration task.
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public CompleteMigrateJobResponse CompleteMigrateJobSync(CompleteMigrateJobRequest req)
        {
             JsonResponseModel<CompleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a sync task.
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public async Task<ConfigureSyncJobResponse> ConfigureSyncJob(ConfigureSyncJobRequest req)
        {
             JsonResponseModel<ConfigureSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConfigureSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfigureSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a sync task.
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public ConfigureSyncJobResponse ConfigureSyncJobSync(ConfigureSyncJobRequest req)
        {
             JsonResponseModel<ConfigureSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConfigureSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfigureSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume a paused migration task.
        /// </summary>
        /// <param name="req"><see cref="ContinueMigrateJobRequest"/></param>
        /// <returns><see cref="ContinueMigrateJobResponse"/></returns>
        public async Task<ContinueMigrateJobResponse> ContinueMigrateJob(ContinueMigrateJobRequest req)
        {
             JsonResponseModel<ContinueMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ContinueMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContinueMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume a paused migration task.
        /// </summary>
        /// <param name="req"><see cref="ContinueMigrateJobRequest"/></param>
        /// <returns><see cref="ContinueMigrateJobResponse"/></returns>
        public ContinueMigrateJobResponse ContinueMigrateJobSync(ContinueMigrateJobRequest req)
        {
             JsonResponseModel<ContinueMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ContinueMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContinueMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume a paused data sync task.
        /// </summary>
        /// <param name="req"><see cref="ContinueSyncJobRequest"/></param>
        /// <returns><see cref="ContinueSyncJobResponse"/></returns>
        public async Task<ContinueSyncJobResponse> ContinueSyncJob(ContinueSyncJobRequest req)
        {
             JsonResponseModel<ContinueSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ContinueSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContinueSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to resume a paused data sync task.
        /// </summary>
        /// <param name="req"><see cref="ContinueSyncJobRequest"/></param>
        /// <returns><see cref="ContinueSyncJobResponse"/></returns>
        public ContinueSyncJobResponse ContinueSyncJobSync(ContinueSyncJobRequest req)
        {
             JsonResponseModel<ContinueSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ContinueSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContinueSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a sync task by checking required parameters and peripheral configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public async Task<CreateCheckSyncJobResponse> CreateCheckSyncJob(CreateCheckSyncJobRequest req)
        {
             JsonResponseModel<CreateCheckSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCheckSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCheckSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a sync task by checking required parameters and peripheral configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public CreateCheckSyncJobResponse CreateCheckSyncJobSync(CreateCheckSyncJobRequest req)
        {
             JsonResponseModel<CreateCheckSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCheckSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCheckSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a data consistency check task. After the task is successfully created, its ID will be returned in the format of `dts-8yv4w2i1-cmp-37skmii9`, and you can call `StartCompare` to start it.
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public async Task<CreateCompareTaskResponse> CreateCompareTask(CreateCompareTaskRequest req)
        {
             JsonResponseModel<CreateCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a data consistency check task. After the task is successfully created, its ID will be returned in the format of `dts-8yv4w2i1-cmp-37skmii9`, and you can call `StartCompare` to start it.
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public CreateCompareTaskResponse CreateCompareTaskSync(CreateCompareTaskRequest req)
        {
             JsonResponseModel<CreateCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a migration task.
        /// Before migration, you should call this API to create a check task. Migration will start only if the check succeeds. You can view the check result through the `DescribeMigrationCheckJob` API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created, and migration will start only after the new check succeeds.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public async Task<CreateMigrateCheckJobResponse> CreateMigrateCheckJob(CreateMigrateCheckJobRequest req)
        {
             JsonResponseModel<CreateMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a migration task.
        /// Before migration, you should call this API to create a check task. Migration will start only if the check succeeds. You can view the check result through the `DescribeMigrationCheckJob` API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created, and migration will start only after the new check succeeds.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public CreateMigrateCheckJobResponse CreateMigrateCheckJobSync(CreateMigrateCheckJobRequest req)
        {
             JsonResponseModel<CreateMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to purchase migration tasks. After the tasks are purchased successfully, a randomly generated list of task IDs will be returned. You can also call the `DescribeMigrationJobs` API to query the IDs of the successfully purchased tasks. Note that once a task is purchased successfully, the types and regions of the source and target databases cannot be changed.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public async Task<CreateMigrationServiceResponse> CreateMigrationService(CreateMigrationServiceRequest req)
        {
             JsonResponseModel<CreateMigrationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigrationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to purchase migration tasks. After the tasks are purchased successfully, a randomly generated list of task IDs will be returned. You can also call the `DescribeMigrationJobs` API to query the IDs of the successfully purchased tasks. Note that once a task is purchased successfully, the types and regions of the source and target databases cannot be changed.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public CreateMigrationServiceResponse CreateMigrationServiceSync(CreateMigrationServiceRequest req)
        {
             JsonResponseModel<CreateMigrationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigrationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether the current data sync task supports object modification after the task configuration is modified.
        /// </summary>
        /// <param name="req"><see cref="CreateModifyCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateModifyCheckSyncJobResponse"/></returns>
        public async Task<CreateModifyCheckSyncJobResponse> CreateModifyCheckSyncJob(CreateModifyCheckSyncJobRequest req)
        {
             JsonResponseModel<CreateModifyCheckSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModifyCheckSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModifyCheckSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether the current data sync task supports object modification after the task configuration is modified.
        /// </summary>
        /// <param name="req"><see cref="CreateModifyCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateModifyCheckSyncJobResponse"/></returns>
        public CreateModifyCheckSyncJobResponse CreateModifyCheckSyncJobSync(CreateModifyCheckSyncJobRequest req)
        {
             JsonResponseModel<CreateModifyCheckSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModifyCheckSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModifyCheckSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public async Task<CreateSyncJobResponse> CreateSyncJob(CreateSyncJobRequest req)
        {
             JsonResponseModel<CreateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public CreateSyncJobResponse CreateSyncJobSync(CreateSyncJobRequest req)
        {
             JsonResponseModel<CreateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a data consistency check task, which can be called when the task status is `success`, `failed`, or `canceled`.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public async Task<DeleteCompareTaskResponse> DeleteCompareTask(DeleteCompareTaskRequest req)
        {
             JsonResponseModel<DeleteCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a data consistency check task, which can be called when the task status is `success`, `failed`, or `canceled`.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public DeleteCompareTaskResponse DeleteCompareTaskSync(DeleteCompareTaskRequest req)
        {
             JsonResponseModel<DeleteCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of the sync check task and check the required parameters and peripheral configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public async Task<DescribeCheckSyncJobResultResponse> DescribeCheckSyncJobResult(DescribeCheckSyncJobResultRequest req)
        {
             JsonResponseModel<DescribeCheckSyncJobResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCheckSyncJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckSyncJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of the sync check task and check the required parameters and peripheral configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public DescribeCheckSyncJobResultResponse DescribeCheckSyncJobResultSync(DescribeCheckSyncJobResultRequest req)
        {
             JsonResponseModel<DescribeCheckSyncJobResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCheckSyncJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckSyncJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public async Task<DescribeCompareReportResponse> DescribeCompareReport(DescribeCompareReportRequest req)
        {
             JsonResponseModel<DescribeCompareReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompareReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public DescribeCompareReportResponse DescribeCompareReportSync(DescribeCompareReportRequest req)
        {
             JsonResponseModel<DescribeCompareReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompareReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of data consistency check tasks under the current task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public async Task<DescribeCompareTasksResponse> DescribeCompareTasks(DescribeCompareTasksRequest req)
        {
             JsonResponseModel<DescribeCompareTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompareTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of data consistency check tasks under the current task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public DescribeCompareTasksResponse DescribeCompareTasksSync(DescribeCompareTasksRequest req)
        {
             JsonResponseModel<DescribeCompareTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompareTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query migratable database instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public async Task<DescribeMigrateDBInstancesResponse> DescribeMigrateDBInstances(DescribeMigrateDBInstancesRequest req)
        {
             JsonResponseModel<DescribeMigrateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query migratable database instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public DescribeMigrateDBInstancesResponse DescribeMigrateDBInstancesSync(DescribeMigrateDBInstancesRequest req)
        {
             JsonResponseModel<DescribeMigrateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the check result and query the check status and progress after a check is created. 
        /// If the check succeeds, you can call the `StartMigrateJob` API to start migration.
        /// If the check fails, the cause can be queried. Modify the migration configuration or adjust relevant parameters of the source/target instances through the `ModifyMigrationJob` API based on the error message.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrationCheckJobResponse"/></returns>
        public async Task<DescribeMigrationCheckJobResponse> DescribeMigrationCheckJob(DescribeMigrationCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrationCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the check result and query the check status and progress after a check is created. 
        /// If the check succeeds, you can call the `StartMigrateJob` API to start migration.
        /// If the check fails, the cause can be queried. Modify the migration configuration or adjust relevant parameters of the source/target instances through the `ModifyMigrationJob` API based on the error message.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrationCheckJobResponse"/></returns>
        public DescribeMigrationCheckJobResponse DescribeMigrationCheckJobSync(DescribeMigrationCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrationCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a migration task.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public async Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a migration task.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of data migration tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public async Task<DescribeMigrationJobsResponse> DescribeMigrationJobs(DescribeMigrationJobsRequest req)
        {
             JsonResponseModel<DescribeMigrationJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of data migration tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public DescribeMigrationJobsResponse DescribeMigrationJobsSync(DescribeMigrationJobsRequest req)
        {
             JsonResponseModel<DescribeMigrationJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of the created check task for object modification.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeModifyCheckSyncJobResultResponse"/></returns>
        public async Task<DescribeModifyCheckSyncJobResultResponse> DescribeModifyCheckSyncJobResult(DescribeModifyCheckSyncJobResultRequest req)
        {
             JsonResponseModel<DescribeModifyCheckSyncJobResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModifyCheckSyncJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModifyCheckSyncJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of the created check task for object modification.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeModifyCheckSyncJobResultResponse"/></returns>
        public DescribeModifyCheckSyncJobResultResponse DescribeModifyCheckSyncJobResultSync(DescribeModifyCheckSyncJobResultRequest req)
        {
             JsonResponseModel<DescribeModifyCheckSyncJobResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModifyCheckSyncJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModifyCheckSyncJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a sync task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public async Task<DescribeSyncJobsResponse> DescribeSyncJobs(DescribeSyncJobsRequest req)
        {
             JsonResponseModel<DescribeSyncJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSyncJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a sync task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public DescribeSyncJobsResponse DescribeSyncJobsSync(DescribeSyncJobsRequest req)
        {
             JsonResponseModel<DescribeSyncJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSyncJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a data migration task. For a billed task, you must first call the `IsolateMigrateJob` API to isolate it and make sure that it is in **Isolated** status before calling this API to delete it. For a free task, you can directly call the `IsolateMigrateJob` API to delete it.
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public async Task<DestroyMigrateJobResponse> DestroyMigrateJob(DestroyMigrateJobRequest req)
        {
             JsonResponseModel<DestroyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a data migration task. For a billed task, you must first call the `IsolateMigrateJob` API to isolate it and make sure that it is in **Isolated** status before calling this API to delete it. For a free task, you can directly call the `IsolateMigrateJob` API to delete it.
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public DestroyMigrateJobResponse DestroyMigrateJobSync(DestroyMigrateJobRequest req)
        {
             JsonResponseModel<DestroyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a sync task. Only tasks in **Isolated** status can be completely deleted. After deletion, you can call the `DescribeSyncJobs` API to get the task list. If the deleted task is not in the list, it is deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public async Task<DestroySyncJobResponse> DestroySyncJob(DestroySyncJobRequest req)
        {
             JsonResponseModel<DestroySyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a sync task. Only tasks in **Isolated** status can be completely deleted. After deletion, you can call the `DescribeSyncJobs` API to get the task list. If the deleted task is not in the list, it is deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public DestroySyncJobResponse DestroySyncJobSync(DestroySyncJobRequest req)
        {
             JsonResponseModel<DestroySyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to isolate and return a data migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status. For a billed task, after isolating it, you can call `RecoverMigrationJob` to recover it or call `DestroyMigrateJob` to delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public async Task<IsolateMigrateJobResponse> IsolateMigrateJob(IsolateMigrateJobRequest req)
        {
             JsonResponseModel<IsolateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to isolate and return a data migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status. For a billed task, after isolating it, you can call `RecoverMigrationJob` to recover it or call `DestroyMigrateJob` to delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public IsolateMigrateJobResponse IsolateMigrateJobSync(IsolateMigrateJobRequest req)
        {
             JsonResponseModel<IsolateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate a sync task. After the task is isolated, you can call the `DescribeSyncJobs` API to query its status, call `RecoverSyncJob` to recover it, or directly delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public async Task<IsolateSyncJobResponse> IsolateSyncJob(IsolateSyncJobRequest req)
        {
             JsonResponseModel<IsolateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate a sync task. After the task is isolated, you can call the `DescribeSyncJobs` API to query its status, call `RecoverSyncJob` to recover it, or directly delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public IsolateSyncJobResponse IsolateSyncJobSync(IsolateSyncJobRequest req)
        {
             JsonResponseModel<IsolateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the parameters of a data consistency check task after it is created and before it starts.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public async Task<ModifyCompareTaskResponse> ModifyCompareTask(ModifyCompareTaskRequest req)
        {
             JsonResponseModel<ModifyCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the parameters of a data consistency check task after it is created and before it starts.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public ModifyCompareTaskResponse ModifyCompareTaskSync(ModifyCompareTaskRequest req)
        {
             JsonResponseModel<ModifyCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public async Task<ModifyCompareTaskNameResponse> ModifyCompareTaskName(ModifyCompareTaskNameRequest req)
        {
             JsonResponseModel<ModifyCompareTaskNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCompareTaskName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public ModifyCompareTaskNameResponse ModifyCompareTaskNameSync(ModifyCompareTaskNameRequest req)
        {
             JsonResponseModel<ModifyCompareTaskNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCompareTaskName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public async Task<ModifyMigrateJobSpecResponse> ModifyMigrateJobSpec(ModifyMigrateJobSpecRequest req)
        {
             JsonResponseModel<ModifyMigrateJobSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrateJobSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public ModifyMigrateJobSpecResponse ModifyMigrateJobSpecSync(ModifyMigrateJobSpecRequest req)
        {
             JsonResponseModel<ModifyMigrateJobSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrateJobSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public async Task<ModifyMigrateNameResponse> ModifyMigrateName(ModifyMigrateNameRequest req)
        {
             JsonResponseModel<ModifyMigrateNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrateName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public ModifyMigrateNameResponse ModifyMigrateNameSync(ModifyMigrateNameRequest req)
        {
             JsonResponseModel<ModifyMigrateNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrateName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a migration task. After it is configured successfully, you can call the `CreateMigrationCheckJob` API to create a check task, and only after it passes the check can it be started.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public async Task<ModifyMigrationJobResponse> ModifyMigrationJob(ModifyMigrationJobRequest req)
        {
             JsonResponseModel<ModifyMigrationJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrationJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a migration task. After it is configured successfully, you can call the `CreateMigrationCheckJob` API to create a check task, and only after it passes the check can it be started.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public ModifyMigrationJobResponse ModifyMigrationJobSync(ModifyMigrationJobRequest req)
        {
             JsonResponseModel<ModifyMigrationJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrationJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of a data sync task after the task is started.\n Configuration modification steps:  Modify sync task configuration -> Create a modification check task -> Query the check task result -> Start the configuration modification check task
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobConfigRequest"/></param>
        /// <returns><see cref="ModifySyncJobConfigResponse"/></returns>
        public async Task<ModifySyncJobConfigResponse> ModifySyncJobConfig(ModifySyncJobConfigRequest req)
        {
             JsonResponseModel<ModifySyncJobConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySyncJobConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncJobConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of a data sync task after the task is started.\n Configuration modification steps:  Modify sync task configuration -> Create a modification check task -> Query the check task result -> Start the configuration modification check task
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobConfigRequest"/></param>
        /// <returns><see cref="ModifySyncJobConfigResponse"/></returns>
        public ModifySyncJobConfigResponse ModifySyncJobConfigSync(ModifySyncJobConfigRequest req)
        {
             JsonResponseModel<ModifySyncJobConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySyncJobConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncJobConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pause a migration task.
        /// </summary>
        /// <param name="req"><see cref="PauseMigrateJobRequest"/></param>
        /// <returns><see cref="PauseMigrateJobResponse"/></returns>
        public async Task<PauseMigrateJobResponse> PauseMigrateJob(PauseMigrateJobRequest req)
        {
             JsonResponseModel<PauseMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PauseMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pause a migration task.
        /// </summary>
        /// <param name="req"><see cref="PauseMigrateJobRequest"/></param>
        /// <returns><see cref="PauseMigrateJobResponse"/></returns>
        public PauseMigrateJobResponse PauseMigrateJobSync(PauseMigrateJobRequest req)
        {
             JsonResponseModel<PauseMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PauseMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pause a data sync task.
        /// </summary>
        /// <param name="req"><see cref="PauseSyncJobRequest"/></param>
        /// <returns><see cref="PauseSyncJobResponse"/></returns>
        public async Task<PauseSyncJobResponse> PauseSyncJob(PauseSyncJobRequest req)
        {
             JsonResponseModel<PauseSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PauseSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pause a data sync task.
        /// </summary>
        /// <param name="req"><see cref="PauseSyncJobRequest"/></param>
        /// <returns><see cref="PauseSyncJobResponse"/></returns>
        public PauseSyncJobResponse PauseSyncJobSync(PauseSyncJobRequest req)
        {
             JsonResponseModel<PauseSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PauseSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recover a data migration task in **Isolated** status. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public async Task<RecoverMigrateJobResponse> RecoverMigrateJob(RecoverMigrateJobRequest req)
        {
             JsonResponseModel<RecoverMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recover a data migration task in **Isolated** status. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public RecoverMigrateJobResponse RecoverMigrateJobSync(RecoverMigrateJobRequest req)
        {
             JsonResponseModel<RecoverMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recover a sync task in **Isolated** status. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public async Task<RecoverSyncJobResponse> RecoverSyncJob(RecoverSyncJobRequest req)
        {
             JsonResponseModel<RecoverSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recover a sync task in **Isolated** status. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public RecoverSyncJobResponse RecoverSyncJobSync(RecoverSyncJobRequest req)
        {
             JsonResponseModel<RecoverSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go sync task. After this API is called, the backend needs to take about 3-5 minutes to implement the adjustment. You can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public async Task<ResizeSyncJobResponse> ResizeSyncJob(ResizeSyncJobRequest req)
        {
             JsonResponseModel<ResizeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go sync task. After this API is called, the backend needs to take about 3-5 minutes to implement the adjustment. You can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public ResizeSyncJobResponse ResizeSyncJobSync(ResizeSyncJobRequest req)
        {
             JsonResponseModel<ResizeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry an abnormal or failed Redis data migration task. Note that this operation will skip the check stage and directly start the task, just like by calling `StartMigrationJob`. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public async Task<ResumeMigrateJobResponse> ResumeMigrateJob(ResumeMigrateJobRequest req)
        {
             JsonResponseModel<ResumeMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry an abnormal or failed Redis data migration task. Note that this operation will skip the check stage and directly start the task, just like by calling `StartMigrationJob`. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public ResumeMigrateJobResponse ResumeMigrateJobSync(ResumeMigrateJobRequest req)
        {
             JsonResponseModel<ResumeMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry a sync task after certain resolvable errors are reported. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public async Task<ResumeSyncJobResponse> ResumeSyncJob(ResumeSyncJobRequest req)
        {
             JsonResponseModel<ResumeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry a sync task after certain resolvable errors are reported. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public ResumeSyncJobResponse ResumeSyncJobSync(ResumeSyncJobRequest req)
        {
             JsonResponseModel<ResumeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a migration task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public async Task<SkipCheckItemResponse> SkipCheckItem(SkipCheckItemRequest req)
        {
             JsonResponseModel<SkipCheckItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SkipCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a migration task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public SkipCheckItemResponse SkipCheckItemSync(SkipCheckItemRequest req)
        {
             JsonResponseModel<SkipCheckItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SkipCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a sync task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public async Task<SkipSyncCheckItemResponse> SkipSyncCheckItem(SkipSyncCheckItemRequest req)
        {
             JsonResponseModel<SkipSyncCheckItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SkipSyncCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipSyncCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a sync task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public SkipSyncCheckItemResponse SkipSyncCheckItemSync(SkipSyncCheckItemRequest req)
        {
             JsonResponseModel<SkipSyncCheckItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SkipSyncCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipSyncCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a data consistency check task after creating it by calling the `CreateCompareTask` API. After calling this API, you can call the `DescribeCompareTasks` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public async Task<StartCompareResponse> StartCompare(StartCompareRequest req)
        {
             JsonResponseModel<StartCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a data consistency check task after creating it by calling the `CreateCompareTask` API. After calling this API, you can call the `DescribeCompareTasks` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public StartCompareResponse StartCompareSync(StartCompareRequest req)
        {
             JsonResponseModel<StartCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (`StartMigrationJob`) is used to start a migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public async Task<StartMigrateJobResponse> StartMigrateJob(StartMigrateJobRequest req)
        {
             JsonResponseModel<StartMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (`StartMigrationJob`) is used to start a migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public StartMigrateJobResponse StartMigrateJobSync(StartMigrateJobRequest req)
        {
             JsonResponseModel<StartMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start the configuration modification process when the modification check task status becomes “success”.
        /// </summary>
        /// <param name="req"><see cref="StartModifySyncJobRequest"/></param>
        /// <returns><see cref="StartModifySyncJobResponse"/></returns>
        public async Task<StartModifySyncJobResponse> StartModifySyncJob(StartModifySyncJobRequest req)
        {
             JsonResponseModel<StartModifySyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartModifySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartModifySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start the configuration modification process when the modification check task status becomes “success”.
        /// </summary>
        /// <param name="req"><see cref="StartModifySyncJobRequest"/></param>
        /// <returns><see cref="StartModifySyncJobResponse"/></returns>
        public StartModifySyncJobResponse StartModifySyncJobSync(StartModifySyncJobRequest req)
        {
             JsonResponseModel<StartModifySyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartModifySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartModifySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a sync task.
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public async Task<StartSyncJobResponse> StartSyncJob(StartSyncJobRequest req)
        {
             JsonResponseModel<StartSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a sync task.
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public StartSyncJobResponse StartSyncJobSync(StartSyncJobRequest req)
        {
             JsonResponseModel<StartSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public async Task<StopCompareResponse> StopCompare(StopCompareRequest req)
        {
             JsonResponseModel<StopCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public StopCompareResponse StopCompareSync(StopCompareRequest req)
        {
             JsonResponseModel<StopCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a data migration task.
        /// After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public async Task<StopMigrateJobResponse> StopMigrateJob(StopMigrateJobRequest req)
        {
             JsonResponseModel<StopMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a data migration task.
        /// After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public StopMigrateJobResponse StopMigrateJobSync(StopMigrateJobRequest req)
        {
             JsonResponseModel<StopMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a sync task. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public async Task<StopSyncJobResponse> StopSyncJob(StopSyncJobRequest req)
        {
             JsonResponseModel<StopSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a sync task. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public StopSyncJobResponse StopSyncJobSync(StopSyncJobRequest req)
        {
             JsonResponseModel<StopSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
