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

namespace TencentCloud.Dts.V20180330
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dts.V20180330.Models;

   public class DtsClient : AbstractClient{

       private const string endpoint = "dts.tencentcloudapi.com";
       private const string version = "2018-03-30";

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
        /// This API is used to configure a data subscription, which can be called only for subscription instances in unconfigured status.
        /// </summary>
        /// <param name="req"><see cref="ActivateSubscribeRequest"/></param>
        /// <returns><see cref="ActivateSubscribeResponse"/></returns>
        public async Task<ActivateSubscribeResponse> ActivateSubscribe(ActivateSubscribeRequest req)
        {
             JsonResponseModel<ActivateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ActivateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActivateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a data subscription, which can be called only for subscription instances in unconfigured status.
        /// </summary>
        /// <param name="req"><see cref="ActivateSubscribeRequest"/></param>
        /// <returns><see cref="ActivateSubscribeResponse"/></returns>
        public ActivateSubscribeResponse ActivateSubscribeSync(ActivateSubscribeRequest req)
        {
             JsonResponseModel<ActivateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ActivateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActivateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CompleteMigrateJob) is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready, so as to stop migrating incremental data.
        /// If the task status queried through the (DescribeMigrateJobs) API is ready (status=8), you can call this API to complete the migration task.
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
        /// This API (CompleteMigrateJob) is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready, so as to stop migrating incremental data.
        /// If the task status queried through the (DescribeMigrateJobs) API is ready (status=8), you can call this API to complete the migration task.
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
        /// This API is used to create a migration check task.
        /// Before migration, you should call this API to create a check. Migration will start only if the check succeeds. You can view the check result through the DescribeMigrateCheckJob API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created and migration will begin only after the new check succeeds.
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
        /// This API is used to create a migration check task.
        /// Before migration, you should call this API to create a check. Migration will start only if the check succeeds. You can view the check result through the DescribeMigrateCheckJob API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created and migration will begin only after the new check succeeds.
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
        /// This API (CreateMigrateJob) is used to create a data migration task.
        /// 
        /// For a finance zone linkage, please use the domain name dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateJobRequest"/></param>
        /// <returns><see cref="CreateMigrateJobResponse"/></returns>
        public async Task<CreateMigrateJobResponse> CreateMigrateJob(CreateMigrateJobRequest req)
        {
             JsonResponseModel<CreateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateMigrateJob) is used to create a data migration task.
        /// 
        /// For a finance zone linkage, please use the domain name dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateJobRequest"/></param>
        /// <returns><see cref="CreateMigrateJobResponse"/></returns>
        public CreateMigrateJobResponse CreateMigrateJobSync(CreateMigrateJobRequest req)
        {
             JsonResponseModel<CreateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public async Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
             JsonResponseModel<CreateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
             JsonResponseModel<CreateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteMigrationJob) is used to delete a data migration task. If the task status queried through the DescribeMigrateJobs API is checking (status=3), running (status=7), ready (status=8), canceling (status=11), or completing (status=12), the task cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public async Task<DeleteMigrateJobResponse> DeleteMigrateJob(DeleteMigrateJobRequest req)
        {
             JsonResponseModel<DeleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteMigrationJob) is used to delete a data migration task. If the task status queried through the DescribeMigrateJobs API is checking (status=3), running (status=7), ready (status=8), canceling (status=11), or completing (status=12), the task cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public DeleteMigrateJobResponse DeleteMigrateJobSync(DeleteMigrateJobRequest req)
        {
             JsonResponseModel<DeleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public async Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the check result and query check status and progress after a check is created. 
        /// If the check succeeds, you can call the StartMigrateJob API to start migration.
        /// If the check fails, the reason can be queried. Please modify the migration configuration or adjust relevant parameters of the source/target instances through the ModifyMigrateJob API based on the error message.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrateCheckJobResponse"/></returns>
        public async Task<DescribeMigrateCheckJobResponse> DescribeMigrateCheckJob(DescribeMigrateCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the check result and query check status and progress after a check is created. 
        /// If the check succeeds, you can call the StartMigrateJob API to start migration.
        /// If the check fails, the reason can be queried. Please modify the migration configuration or adjust relevant parameters of the source/target instances through the ModifyMigrateJob API based on the error message.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrateCheckJobResponse"/></returns>
        public DescribeMigrateCheckJobResponse DescribeMigrateCheckJobSync(DescribeMigrateCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query data migration tasks.
        /// For a finance zone linkage, please use the domain name https://dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public async Task<DescribeMigrateJobsResponse> DescribeMigrateJobs(DescribeMigrateJobsRequest req)
        {
             JsonResponseModel<DescribeMigrateJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrateJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query data migration tasks.
        /// For a finance zone linkage, please use the domain name https://dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public DescribeMigrateJobsResponse DescribeMigrateJobsSync(DescribeMigrateJobsRequest req)
        {
             JsonResponseModel<DescribeMigrateJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrateJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable subscription instance regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionConfRequest"/></param>
        /// <returns><see cref="DescribeRegionConfResponse"/></returns>
        public async Task<DescribeRegionConfResponse> DescribeRegionConf(DescribeRegionConfRequest req)
        {
             JsonResponseModel<DescribeRegionConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegionConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable subscription instance regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionConfRequest"/></param>
        /// <returns><see cref="DescribeRegionConfResponse"/></returns>
        public DescribeRegionConfResponse DescribeRegionConfSync(DescribeRegionConfRequest req)
        {
             JsonResponseModel<DescribeRegionConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegionConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the subscription instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeConfRequest"/></param>
        /// <returns><see cref="DescribeSubscribeConfResponse"/></returns>
        public async Task<DescribeSubscribeConfResponse> DescribeSubscribeConf(DescribeSubscribeConfRequest req)
        {
             JsonResponseModel<DescribeSubscribeConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubscribeConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscribeConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the subscription instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeConfRequest"/></param>
        /// <returns><see cref="DescribeSubscribeConfResponse"/></returns>
        public DescribeSubscribeConfResponse DescribeSubscribeConfSync(DescribeSubscribeConfRequest req)
        {
             JsonResponseModel<DescribeSubscribeConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubscribeConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscribeConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information list of data subscription instances. Pagination is enabled by default with 20 results returned each time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribesRequest"/></param>
        /// <returns><see cref="DescribeSubscribesResponse"/></returns>
        public async Task<DescribeSubscribesResponse> DescribeSubscribes(DescribeSubscribesRequest req)
        {
             JsonResponseModel<DescribeSubscribesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubscribes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscribesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information list of data subscription instances. Pagination is enabled by default with 20 results returned each time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribesRequest"/></param>
        /// <returns><see cref="DescribeSubscribesResponse"/></returns>
        public DescribeSubscribesResponse DescribeSubscribesSync(DescribeSubscribesRequest req)
        {
             JsonResponseModel<DescribeSubscribesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubscribes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscribesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate an hourly billed subscription instance. After this API is called, the instance will become unavailable and billing will stop for it.
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public async Task<IsolateSubscribeResponse> IsolateSubscribe(IsolateSubscribeRequest req)
        {
             JsonResponseModel<IsolateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate an hourly billed subscription instance. After this API is called, the instance will become unavailable and billing will stop for it.
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public IsolateSubscribeResponse IsolateSubscribeSync(IsolateSubscribeRequest req)
        {
             JsonResponseModel<IsolateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyMigrateJob) is used to modify a data migration task.
        /// If the status of a migration task is creating (status=1), check succeeded (status=4), check failed (status=5), or migration failed (status=10), this API can be called to modify the task, but the type of the source and target instances and the region of the target instance cannot be modified.
        /// 
        /// For a finance zone linkage, please use the domain name dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobResponse"/></returns>
        public async Task<ModifyMigrateJobResponse> ModifyMigrateJob(ModifyMigrateJobRequest req)
        {
             JsonResponseModel<ModifyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyMigrateJob) is used to modify a data migration task.
        /// If the status of a migration task is creating (status=1), check succeeded (status=4), check failed (status=5), or migration failed (status=10), this API can be called to modify the task, but the type of the source and target instances and the region of the target instance cannot be modified.
        /// 
        /// For a finance zone linkage, please use the domain name dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobResponse"/></returns>
        public ModifyMigrateJobResponse ModifyMigrateJobSync(ModifyMigrateJobRequest req)
        {
             JsonResponseModel<ModifyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the consumption time point of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeConsumeTimeRequest"/></param>
        /// <returns><see cref="ModifySubscribeConsumeTimeResponse"/></returns>
        public async Task<ModifySubscribeConsumeTimeResponse> ModifySubscribeConsumeTime(ModifySubscribeConsumeTimeRequest req)
        {
             JsonResponseModel<ModifySubscribeConsumeTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubscribeConsumeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeConsumeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the consumption time point of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeConsumeTimeRequest"/></param>
        /// <returns><see cref="ModifySubscribeConsumeTimeResponse"/></returns>
        public ModifySubscribeConsumeTimeResponse ModifySubscribeConsumeTimeSync(ModifySubscribeConsumeTimeRequest req)
        {
             JsonResponseModel<ModifySubscribeConsumeTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubscribeConsumeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeConsumeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public async Task<ModifySubscribeNameResponse> ModifySubscribeName(ModifySubscribeNameRequest req)
        {
             JsonResponseModel<ModifySubscribeNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubscribeName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public ModifySubscribeNameResponse ModifySubscribeNameSync(ModifySubscribeNameRequest req)
        {
             JsonResponseModel<ModifySubscribeNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubscribeName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the subscription rule of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public async Task<ModifySubscribeObjectsResponse> ModifySubscribeObjects(ModifySubscribeObjectsRequest req)
        {
             JsonResponseModel<ModifySubscribeObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubscribeObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the subscription rule of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public ModifySubscribeObjectsResponse ModifySubscribeObjectsSync(ModifySubscribeObjectsRequest req)
        {
             JsonResponseModel<ModifySubscribeObjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubscribeObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeVipVportRequest"/></param>
        /// <returns><see cref="ModifySubscribeVipVportResponse"/></returns>
        public async Task<ModifySubscribeVipVportResponse> ModifySubscribeVipVport(ModifySubscribeVipVportRequest req)
        {
             JsonResponseModel<ModifySubscribeVipVportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubscribeVipVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeVipVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeVipVportRequest"/></param>
        /// <returns><see cref="ModifySubscribeVipVportResponse"/></returns>
        public ModifySubscribeVipVportResponse ModifySubscribeVipVportSync(ModifySubscribeVipVportRequest req)
        {
             JsonResponseModel<ModifySubscribeVipVportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubscribeVipVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscribeVipVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deactivate an isolated data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="OfflineIsolatedSubscribeResponse"/></returns>
        public async Task<OfflineIsolatedSubscribeResponse> OfflineIsolatedSubscribe(OfflineIsolatedSubscribeRequest req)
        {
             JsonResponseModel<OfflineIsolatedSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineIsolatedSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deactivate an isolated data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="OfflineIsolatedSubscribeResponse"/></returns>
        public OfflineIsolatedSubscribeResponse OfflineIsolatedSubscribeSync(OfflineIsolatedSubscribeRequest req)
        {
             JsonResponseModel<OfflineIsolatedSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineIsolatedSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a data subscription instance. Once reset, an activated instance can be bound to other database instances through the `ActivateSubscribe` API.
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public async Task<ResetSubscribeResponse> ResetSubscribe(ResetSubscribeRequest req)
        {
             JsonResponseModel<ResetSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a data subscription instance. Once reset, an activated instance can be bound to other database instances through the `ActivateSubscribe` API.
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public ResetSubscribeResponse ResetSubscribeSync(ResetSubscribeRequest req)
        {
             JsonResponseModel<ResetSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (StartMigrationJob) is used to start a migration task. After the API is called, non-scheduled migration tasks will start the migration immediately, while scheduled tasks will start the countdown.
        /// Before calling this API, be sure to use the CreateMigrateCheckJob API to check the data migration task, which can be started only if its status queried through the DescribeMigrateJobs API is check succeeded (status=4).
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
        /// This API (StartMigrationJob) is used to start a migration task. After the API is called, non-scheduled migration tasks will start the migration immediately, while scheduled tasks will start the countdown.
        /// Before calling this API, be sure to use the CreateMigrateCheckJob API to check the data migration task, which can be started only if its status queried through the DescribeMigrateJobs API is check succeeded (status=4).
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
        /// This API (StopMigrateJob) is used to cancel a data migration task.
        /// During migration, this API can be used to cancel migration if the task status queried through the DescribeMigrateJobs API is running (status=7) or ready (status=8), and the migration task will fail.
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
        /// This API (StopMigrateJob) is used to cancel a data migration task.
        /// During migration, this API can be used to cancel migration if the task status queried through the DescribeMigrateJobs API is running (status=7) or ready (status=8), and the migration task will fail.
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

    }
}
