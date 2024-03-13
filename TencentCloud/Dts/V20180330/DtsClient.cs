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
       private const string sdkVersion = "SDK_NET_3.0.856";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to configure a data subscription, which can be called only for subscription instances in unconfigured status.
        /// </summary>
        /// <param name="req"><see cref="ActivateSubscribeRequest"/></param>
        /// <returns><see cref="ActivateSubscribeResponse"/></returns>
        public Task<ActivateSubscribeResponse> ActivateSubscribe(ActivateSubscribeRequest req)
        {
            return InternalRequestAsync<ActivateSubscribeResponse>(req, "ActivateSubscribe");
        }

        /// <summary>
        /// This API is used to configure a data subscription, which can be called only for subscription instances in unconfigured status.
        /// </summary>
        /// <param name="req"><see cref="ActivateSubscribeRequest"/></param>
        /// <returns><see cref="ActivateSubscribeResponse"/></returns>
        public ActivateSubscribeResponse ActivateSubscribeSync(ActivateSubscribeRequest req)
        {
            return InternalRequestAsync<ActivateSubscribeResponse>(req, "ActivateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CompleteMigrateJob) is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready, so as to stop migrating incremental data.
        /// If the task status queried through the (DescribeMigrateJobs) API is ready (status=8), you can call this API to complete the migration task.
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public Task<CompleteMigrateJobResponse> CompleteMigrateJob(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob");
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
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a migration check task.
        /// Before migration, you should call this API to create a check. Migration will start only if the check succeeds. You can view the check result through the `DescribeMigrateCheckJob` API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created and migration will begin only after the new check succeeds.
        /// 
        /// For a finance zone link, use the domain name https://dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public Task<CreateMigrateCheckJobResponse> CreateMigrateCheckJob(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob");
        }

        /// <summary>
        /// This API is used to create a migration check task.
        /// Before migration, you should call this API to create a check. Migration will start only if the check succeeds. You can view the check result through the `DescribeMigrateCheckJob` API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created and migration will begin only after the new check succeeds.
        /// 
        /// For a finance zone link, use the domain name https://dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public CreateMigrateCheckJobResponse CreateMigrateCheckJobSync(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateMigrateJob) is used to create a data migration task.
        /// 
        /// For a finance zone linkage, please use the domain name dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateJobRequest"/></param>
        /// <returns><see cref="CreateMigrateJobResponse"/></returns>
        public Task<CreateMigrateJobResponse> CreateMigrateJob(CreateMigrateJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateJobResponse>(req, "CreateMigrateJob");
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
            return InternalRequestAsync<CreateMigrateJobResponse>(req, "CreateMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe");
        }

        /// <summary>
        /// This API is used to create a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteMigrationJob) is used to delete a data migration task. If the task status queried through the DescribeMigrateJobs API is checking (status=3), running (status=7), ready (status=8), canceling (status=11), or completing (status=12), the task cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public Task<DeleteMigrateJobResponse> DeleteMigrateJob(DeleteMigrateJobRequest req)
        {
            return InternalRequestAsync<DeleteMigrateJobResponse>(req, "DeleteMigrateJob");
        }

        /// <summary>
        /// This API (DeleteMigrationJob) is used to delete a data migration task. If the task status queried through the DescribeMigrateJobs API is checking (status=3), running (status=7), ready (status=8), canceling (status=11), or completing (status=12), the task cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public DeleteMigrateJobResponse DeleteMigrateJobSync(DeleteMigrateJobRequest req)
        {
            return InternalRequestAsync<DeleteMigrateJobResponse>(req, "DeleteMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// This API is used to query the execution result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the check result and query check status and progress after a check is created. 
        /// If the check succeeds, you can call the StartMigrateJob API to start migration.
        /// If the check fails, the reason can be queried. Please modify the migration configuration or adjust relevant parameters of the source/target instances through the ModifyMigrateJob API based on the error message.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrateCheckJobResponse"/></returns>
        public Task<DescribeMigrateCheckJobResponse> DescribeMigrateCheckJob(DescribeMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeMigrateCheckJobResponse>(req, "DescribeMigrateCheckJob");
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
            return InternalRequestAsync<DescribeMigrateCheckJobResponse>(req, "DescribeMigrateCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query data migration tasks.
        /// For a finance zone linkage, please use the domain name https://dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public Task<DescribeMigrateJobsResponse> DescribeMigrateJobs(DescribeMigrateJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrateJobsResponse>(req, "DescribeMigrateJobs");
        }

        /// <summary>
        /// This API is used to query data migration tasks.
        /// For a finance zone linkage, please use the domain name https://dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public DescribeMigrateJobsResponse DescribeMigrateJobsSync(DescribeMigrateJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrateJobsResponse>(req, "DescribeMigrateJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the purchasable subscription instance regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionConfRequest"/></param>
        /// <returns><see cref="DescribeRegionConfResponse"/></returns>
        public Task<DescribeRegionConfResponse> DescribeRegionConf(DescribeRegionConfRequest req)
        {
            return InternalRequestAsync<DescribeRegionConfResponse>(req, "DescribeRegionConf");
        }

        /// <summary>
        /// This API is used to query the purchasable subscription instance regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionConfRequest"/></param>
        /// <returns><see cref="DescribeRegionConfResponse"/></returns>
        public DescribeRegionConfResponse DescribeRegionConfSync(DescribeRegionConfRequest req)
        {
            return InternalRequestAsync<DescribeRegionConfResponse>(req, "DescribeRegionConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the subscription instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeConfRequest"/></param>
        /// <returns><see cref="DescribeSubscribeConfResponse"/></returns>
        public Task<DescribeSubscribeConfResponse> DescribeSubscribeConf(DescribeSubscribeConfRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeConfResponse>(req, "DescribeSubscribeConf");
        }

        /// <summary>
        /// This API is used to query the subscription instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeConfRequest"/></param>
        /// <returns><see cref="DescribeSubscribeConfResponse"/></returns>
        public DescribeSubscribeConfResponse DescribeSubscribeConfSync(DescribeSubscribeConfRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeConfResponse>(req, "DescribeSubscribeConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information list of data subscription instances. Pagination is enabled by default with 20 results returned each time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribesRequest"/></param>
        /// <returns><see cref="DescribeSubscribesResponse"/></returns>
        public Task<DescribeSubscribesResponse> DescribeSubscribes(DescribeSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeSubscribesResponse>(req, "DescribeSubscribes");
        }

        /// <summary>
        /// This API is used to get the information list of data subscription instances. Pagination is enabled by default with 20 results returned each time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribesRequest"/></param>
        /// <returns><see cref="DescribeSubscribesResponse"/></returns>
        public DescribeSubscribesResponse DescribeSubscribesSync(DescribeSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeSubscribesResponse>(req, "DescribeSubscribes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate an hourly billed subscription instance. After this API is called, the instance will become unavailable and billing will stop for it.
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public Task<IsolateSubscribeResponse> IsolateSubscribe(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe");
        }

        /// <summary>
        /// This API is used to isolate an hourly billed subscription instance. After this API is called, the instance will become unavailable and billing will stop for it.
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public IsolateSubscribeResponse IsolateSubscribeSync(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyMigrateJob) is used to modify a data migration task.
        /// If the status of a migration task is creating (status=1), check succeeded (status=4), check failed (status=5), or migration failed (status=10), this API can be called to modify the task, but the type of the source and target instances and the region of the target instance cannot be modified.
        /// 
        /// For a finance zone linkage, please use the domain name dts.ap-shenzhen-fsi.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobResponse"/></returns>
        public Task<ModifyMigrateJobResponse> ModifyMigrateJob(ModifyMigrateJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobResponse>(req, "ModifyMigrateJob");
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
            return InternalRequestAsync<ModifyMigrateJobResponse>(req, "ModifyMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the consumption time point of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeConsumeTimeRequest"/></param>
        /// <returns><see cref="ModifySubscribeConsumeTimeResponse"/></returns>
        public Task<ModifySubscribeConsumeTimeResponse> ModifySubscribeConsumeTime(ModifySubscribeConsumeTimeRequest req)
        {
            return InternalRequestAsync<ModifySubscribeConsumeTimeResponse>(req, "ModifySubscribeConsumeTime");
        }

        /// <summary>
        /// This API is used to modify the consumption time point of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeConsumeTimeRequest"/></param>
        /// <returns><see cref="ModifySubscribeConsumeTimeResponse"/></returns>
        public ModifySubscribeConsumeTimeResponse ModifySubscribeConsumeTimeSync(ModifySubscribeConsumeTimeRequest req)
        {
            return InternalRequestAsync<ModifySubscribeConsumeTimeResponse>(req, "ModifySubscribeConsumeTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public Task<ModifySubscribeNameResponse> ModifySubscribeName(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName");
        }

        /// <summary>
        /// This API is used to rename a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public ModifySubscribeNameResponse ModifySubscribeNameSync(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the subscription rule of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public Task<ModifySubscribeObjectsResponse> ModifySubscribeObjects(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects");
        }

        /// <summary>
        /// This API is used to modify the subscription rule of a data subscription channel.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public ModifySubscribeObjectsResponse ModifySubscribeObjectsSync(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeVipVportRequest"/></param>
        /// <returns><see cref="ModifySubscribeVipVportResponse"/></returns>
        public Task<ModifySubscribeVipVportResponse> ModifySubscribeVipVport(ModifySubscribeVipVportRequest req)
        {
            return InternalRequestAsync<ModifySubscribeVipVportResponse>(req, "ModifySubscribeVipVport");
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeVipVportRequest"/></param>
        /// <returns><see cref="ModifySubscribeVipVportResponse"/></returns>
        public ModifySubscribeVipVportResponse ModifySubscribeVipVportSync(ModifySubscribeVipVportRequest req)
        {
            return InternalRequestAsync<ModifySubscribeVipVportResponse>(req, "ModifySubscribeVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deactivate an isolated data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="OfflineIsolatedSubscribeResponse"/></returns>
        public Task<OfflineIsolatedSubscribeResponse> OfflineIsolatedSubscribe(OfflineIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedSubscribeResponse>(req, "OfflineIsolatedSubscribe");
        }

        /// <summary>
        /// This API is used to deactivate an isolated data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="OfflineIsolatedSubscribeResponse"/></returns>
        public OfflineIsolatedSubscribeResponse OfflineIsolatedSubscribeSync(OfflineIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedSubscribeResponse>(req, "OfflineIsolatedSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset a data subscription instance. Once reset, an activated instance can be bound to other database instances through the `ActivateSubscribe` API.
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public Task<ResetSubscribeResponse> ResetSubscribe(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe");
        }

        /// <summary>
        /// This API is used to reset a data subscription instance. Once reset, an activated instance can be bound to other database instances through the `ActivateSubscribe` API.
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public ResetSubscribeResponse ResetSubscribeSync(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (StartMigrationJob) is used to start a migration task. After the API is called, non-scheduled migration tasks will start the migration immediately, while scheduled tasks will start the countdown.
        /// Before calling this API, be sure to use the CreateMigrateCheckJob API to check the data migration task, which can be started only if its status queried through the DescribeMigrateJobs API is check succeeded (status=4).
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public Task<StartMigrateJobResponse> StartMigrateJob(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob");
        }

        /// <summary>
        /// This API (StartMigrationJob) is used to start a migration task. After the API is called, non-scheduled migration tasks will start the migration immediately, while scheduled tasks will start the countdown.
        /// Before calling this API, be sure to use the CreateMigrateCheckJob API to check the data migration task, which can be started only if its status queried through the DescribeMigrateJobs API is check succeeded (status=4).
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public StartMigrateJobResponse StartMigrateJobSync(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (StopMigrateJob) is used to cancel a data migration task.
        /// During migration, this API can be used to cancel migration if the task status queried through the DescribeMigrateJobs API is running (status=7) or ready (status=8), and the migration task will fail.
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public Task<StopMigrateJobResponse> StopMigrateJob(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob");
        }

        /// <summary>
        /// This API (StopMigrateJob) is used to cancel a data migration task.
        /// During migration, this API can be used to cancel migration if the task status queried through the DescribeMigrateJobs API is running (status=7) or ready (status=8), and the migration task will fail.
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public StopMigrateJobResponse StopMigrateJobSync(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
