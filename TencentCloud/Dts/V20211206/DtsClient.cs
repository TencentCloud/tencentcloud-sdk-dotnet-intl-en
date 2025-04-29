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

       private const string endpoint = "dts.intl.tencentcloudapi.com";
       private const string version = "2021-12-06";
       private const string sdkVersion = "SDK_NET_3.0.1121";

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
        /// This API is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready for completion to stop migrating incremental data.
        /// If the task status queried through the `DescribeMigrationJobs` API is ready (`Status` = `readyComplete`), you can call this API to complete the migration task.
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public Task<CompleteMigrateJobResponse> CompleteMigrateJob(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob");
        }

        /// <summary>
        /// This API is used to complete a data migration task.
        /// For tasks in incremental migration mode, you need to call this API before migration gets ready for completion to stop migrating incremental data.
        /// If the task status queried through the `DescribeMigrationJobs` API is ready (`Status` = `readyComplete`), you can call this API to complete the migration task.
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public CompleteMigrateJobResponse CompleteMigrateJobSync(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure data subscription instances.
        /// </summary>
        /// <param name="req"><see cref="ConfigureSubscribeJobRequest"/></param>
        /// <returns><see cref="ConfigureSubscribeJobResponse"/></returns>
        public Task<ConfigureSubscribeJobResponse> ConfigureSubscribeJob(ConfigureSubscribeJobRequest req)
        {
            return InternalRequestAsync<ConfigureSubscribeJobResponse>(req, "ConfigureSubscribeJob");
        }

        /// <summary>
        /// This API is used to configure data subscription instances.
        /// </summary>
        /// <param name="req"><see cref="ConfigureSubscribeJobRequest"/></param>
        /// <returns><see cref="ConfigureSubscribeJobResponse"/></returns>
        public ConfigureSubscribeJobResponse ConfigureSubscribeJobSync(ConfigureSubscribeJobRequest req)
        {
            return InternalRequestAsync<ConfigureSubscribeJobResponse>(req, "ConfigureSubscribeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure a sync task.
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public Task<ConfigureSyncJobResponse> ConfigureSyncJob(ConfigureSyncJobRequest req)
        {
            return InternalRequestAsync<ConfigureSyncJobResponse>(req, "ConfigureSyncJob");
        }

        /// <summary>
        /// This API is used to configure a sync task.
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public ConfigureSyncJobResponse ConfigureSyncJobSync(ConfigureSyncJobRequest req)
        {
            return InternalRequestAsync<ConfigureSyncJobResponse>(req, "ConfigureSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume a paused migration task.
        /// </summary>
        /// <param name="req"><see cref="ContinueMigrateJobRequest"/></param>
        /// <returns><see cref="ContinueMigrateJobResponse"/></returns>
        public Task<ContinueMigrateJobResponse> ContinueMigrateJob(ContinueMigrateJobRequest req)
        {
            return InternalRequestAsync<ContinueMigrateJobResponse>(req, "ContinueMigrateJob");
        }

        /// <summary>
        /// This API is used to resume a paused migration task.
        /// </summary>
        /// <param name="req"><see cref="ContinueMigrateJobRequest"/></param>
        /// <returns><see cref="ContinueMigrateJobResponse"/></returns>
        public ContinueMigrateJobResponse ContinueMigrateJobSync(ContinueMigrateJobRequest req)
        {
            return InternalRequestAsync<ContinueMigrateJobResponse>(req, "ContinueMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume a paused data sync task.
        /// </summary>
        /// <param name="req"><see cref="ContinueSyncJobRequest"/></param>
        /// <returns><see cref="ContinueSyncJobResponse"/></returns>
        public Task<ContinueSyncJobResponse> ContinueSyncJob(ContinueSyncJobRequest req)
        {
            return InternalRequestAsync<ContinueSyncJobResponse>(req, "ContinueSyncJob");
        }

        /// <summary>
        /// This API is used to resume a paused data sync task.
        /// </summary>
        /// <param name="req"><see cref="ContinueSyncJobRequest"/></param>
        /// <returns><see cref="ContinueSyncJobResponse"/></returns>
        public ContinueSyncJobResponse ContinueSyncJobSync(ContinueSyncJobRequest req)
        {
            return InternalRequestAsync<ContinueSyncJobResponse>(req, "ContinueSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a sync task by checking required parameters and peripheral configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public Task<CreateCheckSyncJobResponse> CreateCheckSyncJob(CreateCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateCheckSyncJobResponse>(req, "CreateCheckSyncJob");
        }

        /// <summary>
        /// This API is used to verify a sync task by checking required parameters and peripheral configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public CreateCheckSyncJobResponse CreateCheckSyncJobSync(CreateCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateCheckSyncJobResponse>(req, "CreateCheckSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data consistency check task. After the task is successfully created, its ID will be returned in the format of `dts-8yv4w2i1-cmp-37skmii9`, and you can call `StartCompare` to start it.
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public Task<CreateCompareTaskResponse> CreateCompareTask(CreateCompareTaskRequest req)
        {
            return InternalRequestAsync<CreateCompareTaskResponse>(req, "CreateCompareTask");
        }

        /// <summary>
        /// This API is used to create a data consistency check task. After the task is successfully created, its ID will be returned in the format of `dts-8yv4w2i1-cmp-37skmii9`, and you can call `StartCompare` to start it.
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public CreateCompareTaskResponse CreateCompareTaskSync(CreateCompareTaskRequest req)
        {
            return InternalRequestAsync<CreateCompareTaskResponse>(req, "CreateCompareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to creat a consumer group for the subscription instance.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public Task<CreateConsumerGroupResponse> CreateConsumerGroup(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup");
        }

        /// <summary>
        /// This API is used to creat a consumer group for the subscription instance.
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public CreateConsumerGroupResponse CreateConsumerGroupSync(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a migration task.
        /// Before migration, you should call this API to create a check task. Migration will start only if the check succeeds. You can view the check result through the `DescribeMigrationCheckJob` API.
        /// After successful check, if the migration task needs to be modified, a new check task should be created, and migration will start only after the new check succeeds.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public Task<CreateMigrateCheckJobResponse> CreateMigrateCheckJob(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob");
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
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase migration tasks. After the tasks are purchased successfully, a randomly generated list of task IDs will be returned. You can also call the `DescribeMigrationJobs` API to query the IDs of the successfully purchased tasks. Note that once a task is purchased successfully, the types and regions of the source and target databases cannot be changed.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public Task<CreateMigrationServiceResponse> CreateMigrationService(CreateMigrationServiceRequest req)
        {
            return InternalRequestAsync<CreateMigrationServiceResponse>(req, "CreateMigrationService");
        }

        /// <summary>
        /// This API is used to purchase migration tasks. After the tasks are purchased successfully, a randomly generated list of task IDs will be returned. You can also call the `DescribeMigrationJobs` API to query the IDs of the successfully purchased tasks. Note that once a task is purchased successfully, the types and regions of the source and target databases cannot be changed.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public CreateMigrationServiceResponse CreateMigrationServiceSync(CreateMigrationServiceRequest req)
        {
            return InternalRequestAsync<CreateMigrationServiceResponse>(req, "CreateMigrationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the current data sync task supports object modification after the task configuration is modified.
        /// </summary>
        /// <param name="req"><see cref="CreateModifyCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateModifyCheckSyncJobResponse"/></returns>
        public Task<CreateModifyCheckSyncJobResponse> CreateModifyCheckSyncJob(CreateModifyCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateModifyCheckSyncJobResponse>(req, "CreateModifyCheckSyncJob");
        }

        /// <summary>
        /// This API is used to check whether the current data sync task supports object modification after the task configuration is modified.
        /// </summary>
        /// <param name="req"><see cref="CreateModifyCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateModifyCheckSyncJobResponse"/></returns>
        public CreateModifyCheckSyncJobResponse CreateModifyCheckSyncJobSync(CreateModifyCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateModifyCheckSyncJobResponse>(req, "CreateModifyCheckSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data subscription task.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe");
        }

        /// <summary>
        /// This API is used to create a data subscription task.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a subscription check task. The task must have successfully called the ConfigureSubscribeJob interface to configure all necessary information before starting the check.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="CreateSubscribeCheckJobResponse"/></returns>
        public Task<CreateSubscribeCheckJobResponse> CreateSubscribeCheckJob(CreateSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<CreateSubscribeCheckJobResponse>(req, "CreateSubscribeCheckJob");
        }

        /// <summary>
        /// This API is used to create a subscription check task. The task must have successfully called the ConfigureSubscribeJob interface to configure all necessary information before starting the check.
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="CreateSubscribeCheckJobResponse"/></returns>
        public CreateSubscribeCheckJobResponse CreateSubscribeCheckJobSync(CreateSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<CreateSubscribeCheckJobResponse>(req, "CreateSubscribeCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public Task<CreateSyncJobResponse> CreateSyncJob(CreateSyncJobRequest req)
        {
            return InternalRequestAsync<CreateSyncJobResponse>(req, "CreateSyncJob");
        }

        /// <summary>
        /// This API is used to create a sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public CreateSyncJobResponse CreateSyncJobSync(CreateSyncJobRequest req)
        {
            return InternalRequestAsync<CreateSyncJobResponse>(req, "CreateSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a data consistency check task, which can be called when the task status is `success`, `failed`, or `canceled`.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public Task<DeleteCompareTaskResponse> DeleteCompareTask(DeleteCompareTaskRequest req)
        {
            return InternalRequestAsync<DeleteCompareTaskResponse>(req, "DeleteCompareTask");
        }

        /// <summary>
        /// This API is used to delete a data consistency check task, which can be called when the task status is `success`, `failed`, or `canceled`.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public DeleteCompareTaskResponse DeleteCompareTaskSync(DeleteCompareTaskRequest req)
        {
            return InternalRequestAsync<DeleteCompareTaskResponse>(req, "DeleteCompareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a consumer group of a subscription task.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public Task<DeleteConsumerGroupResponse> DeleteConsumerGroup(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup");
        }

        /// <summary>
        /// This API is used to delete a consumer group of a subscription task.
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupSync(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of the sync check task and check the required parameters and peripheral configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public Task<DescribeCheckSyncJobResultResponse> DescribeCheckSyncJobResult(DescribeCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeCheckSyncJobResultResponse>(req, "DescribeCheckSyncJobResult");
        }

        /// <summary>
        /// This API is used to query the result of the sync check task and check the required parameters and peripheral configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public DescribeCheckSyncJobResultResponse DescribeCheckSyncJobResultSync(DescribeCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeCheckSyncJobResultResponse>(req, "DescribeCheckSyncJobResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public Task<DescribeCompareReportResponse> DescribeCompareReport(DescribeCompareReportRequest req)
        {
            return InternalRequestAsync<DescribeCompareReportResponse>(req, "DescribeCompareReport");
        }

        /// <summary>
        /// This API is used to query the details of a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public DescribeCompareReportResponse DescribeCompareReportSync(DescribeCompareReportRequest req)
        {
            return InternalRequestAsync<DescribeCompareReportResponse>(req, "DescribeCompareReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of data consistency check tasks under the current task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public Task<DescribeCompareTasksResponse> DescribeCompareTasks(DescribeCompareTasksRequest req)
        {
            return InternalRequestAsync<DescribeCompareTasksResponse>(req, "DescribeCompareTasks");
        }

        /// <summary>
        /// This API is used to query the list of data consistency check tasks under the current task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public DescribeCompareTasksResponse DescribeCompareTasksSync(DescribeCompareTasksRequest req)
        {
            return InternalRequestAsync<DescribeCompareTasksResponse>(req, "DescribeCompareTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get consumer group details for the subscription instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupsRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupsResponse"/></returns>
        public Task<DescribeConsumerGroupsResponse> DescribeConsumerGroups(DescribeConsumerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupsResponse>(req, "DescribeConsumerGroups");
        }

        /// <summary>
        /// This API is used to get consumer group details for the subscription instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupsRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupsResponse"/></returns>
        public DescribeConsumerGroupsResponse DescribeConsumerGroupsSync(DescribeConsumerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupsResponse>(req, "DescribeConsumerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query migratable database instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public Task<DescribeMigrateDBInstancesResponse> DescribeMigrateDBInstances(DescribeMigrateDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeMigrateDBInstancesResponse>(req, "DescribeMigrateDBInstances");
        }

        /// <summary>
        /// This API is used to query migratable database instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public DescribeMigrateDBInstancesResponse DescribeMigrateDBInstancesSync(DescribeMigrateDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeMigrateDBInstancesResponse>(req, "DescribeMigrateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the check result and query the check status and progress after a check is created. 
        /// If the check succeeds, you can call the `StartMigrateJob` API to start migration.
        /// If the check fails, the cause can be queried. Modify the migration configuration or adjust relevant parameters of the source/target instances through the `ModifyMigrationJob` API based on the error message.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrationCheckJobResponse"/></returns>
        public Task<DescribeMigrationCheckJobResponse> DescribeMigrationCheckJob(DescribeMigrationCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeMigrationCheckJobResponse>(req, "DescribeMigrationCheckJob");
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
            return InternalRequestAsync<DescribeMigrationCheckJobResponse>(req, "DescribeMigrationCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a migration task.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail");
        }

        /// <summary>
        /// This API is used to query the details of a migration task.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of data migration tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public Task<DescribeMigrationJobsResponse> DescribeMigrationJobs(DescribeMigrationJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationJobsResponse>(req, "DescribeMigrationJobs");
        }

        /// <summary>
        /// This API is used to query the list of data migration tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public DescribeMigrationJobsResponse DescribeMigrationJobsSync(DescribeMigrationJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationJobsResponse>(req, "DescribeMigrationJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of the created check task for object modification.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeModifyCheckSyncJobResultResponse"/></returns>
        public Task<DescribeModifyCheckSyncJobResultResponse> DescribeModifyCheckSyncJobResult(DescribeModifyCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeModifyCheckSyncJobResultResponse>(req, "DescribeModifyCheckSyncJobResult");
        }

        /// <summary>
        /// This API is used to query the result of the created check task for object modification.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeModifyCheckSyncJobResultResponse"/></returns>
        public DescribeModifyCheckSyncJobResultResponse DescribeModifyCheckSyncJobResultSync(DescribeModifyCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeModifyCheckSyncJobResultResponse>(req, "DescribeModifyCheckSyncJobResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the latest offset before the specified time in KafkaTopic.The offset output by the interface is the closest offset to this time.If the input time is much later than the current time, the output is equivalent to the latest offset;If the input time is much earlier than the current time, the output is equivalent to the oldest offset;If the input is empty, the default time is 0, which is the oldest offset to be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeOffsetByTimeRequest"/></param>
        /// <returns><see cref="DescribeOffsetByTimeResponse"/></returns>
        public Task<DescribeOffsetByTimeResponse> DescribeOffsetByTime(DescribeOffsetByTimeRequest req)
        {
            return InternalRequestAsync<DescribeOffsetByTimeResponse>(req, "DescribeOffsetByTime");
        }

        /// <summary>
        /// This API is used to query the latest offset before the specified time in KafkaTopic.The offset output by the interface is the closest offset to this time.If the input time is much later than the current time, the output is equivalent to the latest offset;If the input time is much earlier than the current time, the output is equivalent to the oldest offset;If the input is empty, the default time is 0, which is the oldest offset to be queried.
        /// </summary>
        /// <param name="req"><see cref="DescribeOffsetByTimeRequest"/></param>
        /// <returns><see cref="DescribeOffsetByTimeResponse"/></returns>
        public DescribeOffsetByTimeResponse DescribeOffsetByTimeSync(DescribeOffsetByTimeRequest req)
        {
            return InternalRequestAsync<DescribeOffsetByTimeResponse>(req, "DescribeOffsetByTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the results of a subscription check task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="DescribeSubscribeCheckJobResponse"/></returns>
        public Task<DescribeSubscribeCheckJobResponse> DescribeSubscribeCheckJob(DescribeSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeCheckJobResponse>(req, "DescribeSubscribeCheckJob");
        }

        /// <summary>
        /// This API is used to query the results of a subscription check task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="DescribeSubscribeCheckJobResponse"/></returns>
        public DescribeSubscribeCheckJobResponse DescribeSubscribeCheckJobSync(DescribeSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeCheckJobResponse>(req, "DescribeSubscribeCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the configuration information of the data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscribeDetailResponse"/></returns>
        public Task<DescribeSubscribeDetailResponse> DescribeSubscribeDetail(DescribeSubscribeDetailRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeDetailResponse>(req, "DescribeSubscribeDetail");
        }

        /// <summary>
        /// This API is used to get the configuration information of the data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscribeDetailResponse"/></returns>
        public DescribeSubscribeDetailResponse DescribeSubscribeDetailSync(DescribeSubscribeDetailRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeDetailResponse>(req, "DescribeSubscribeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information list of data subscription instances. Pagination is enabled by default with 20 results returned each time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeJobsRequest"/></param>
        /// <returns><see cref="DescribeSubscribeJobsResponse"/></returns>
        public Task<DescribeSubscribeJobsResponse> DescribeSubscribeJobs(DescribeSubscribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeJobsResponse>(req, "DescribeSubscribeJobs");
        }

        /// <summary>
        /// This API is used to get the information list of data subscription instances. Pagination is enabled by default with 20 results returned each time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeJobsRequest"/></param>
        /// <returns><see cref="DescribeSubscribeJobsResponse"/></returns>
        public DescribeSubscribeJobsResponse DescribeSubscribeJobsSync(DescribeSubscribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeJobsResponse>(req, "DescribeSubscribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whether a subscription task can be terminated and returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeReturnableRequest"/></param>
        /// <returns><see cref="DescribeSubscribeReturnableResponse"/></returns>
        public Task<DescribeSubscribeReturnableResponse> DescribeSubscribeReturnable(DescribeSubscribeReturnableRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeReturnableResponse>(req, "DescribeSubscribeReturnable");
        }

        /// <summary>
        /// This API is used to query whether a subscription task can be terminated and returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeReturnableRequest"/></param>
        /// <returns><see cref="DescribeSubscribeReturnableResponse"/></returns>
        public DescribeSubscribeReturnableResponse DescribeSubscribeReturnableSync(DescribeSubscribeReturnableRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeReturnableResponse>(req, "DescribeSubscribeReturnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a sync task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public Task<DescribeSyncJobsResponse> DescribeSyncJobs(DescribeSyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeSyncJobsResponse>(req, "DescribeSyncJobs");
        }

        /// <summary>
        /// This API is used to query the information of a sync task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public DescribeSyncJobsResponse DescribeSyncJobsSync(DescribeSyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeSyncJobsResponse>(req, "DescribeSyncJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deactivate an isolated data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="DestroyIsolatedSubscribeResponse"/></returns>
        public Task<DestroyIsolatedSubscribeResponse> DestroyIsolatedSubscribe(DestroyIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<DestroyIsolatedSubscribeResponse>(req, "DestroyIsolatedSubscribe");
        }

        /// <summary>
        /// This API is used to deactivate an isolated data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="DestroyIsolatedSubscribeResponse"/></returns>
        public DestroyIsolatedSubscribeResponse DestroyIsolatedSubscribeSync(DestroyIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<DestroyIsolatedSubscribeResponse>(req, "DestroyIsolatedSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a data migration task. For a billed task, you must first call the `IsolateMigrateJob` API to isolate it and make sure that it is in **Isolated** status before calling this API to delete it. For a free task, you can directly call the `IsolateMigrateJob` API to delete it.
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public Task<DestroyMigrateJobResponse> DestroyMigrateJob(DestroyMigrateJobRequest req)
        {
            return InternalRequestAsync<DestroyMigrateJobResponse>(req, "DestroyMigrateJob");
        }

        /// <summary>
        /// This API is used to delete a data migration task. For a billed task, you must first call the `IsolateMigrateJob` API to isolate it and make sure that it is in **Isolated** status before calling this API to delete it. For a free task, you can directly call the `IsolateMigrateJob` API to delete it.
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public DestroyMigrateJobResponse DestroyMigrateJobSync(DestroyMigrateJobRequest req)
        {
            return InternalRequestAsync<DestroyMigrateJobResponse>(req, "DestroyMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a sync task. Only tasks in **Isolated** status can be completely deleted. After deletion, you can call the `DescribeSyncJobs` API to get the task list. If the deleted task is not in the list, it is deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public Task<DestroySyncJobResponse> DestroySyncJob(DestroySyncJobRequest req)
        {
            return InternalRequestAsync<DestroySyncJobResponse>(req, "DestroySyncJob");
        }

        /// <summary>
        /// This API is used to delete a sync task. Only tasks in **Isolated** status can be completely deleted. After deletion, you can call the `DescribeSyncJobs` API to get the task list. If the deleted task is not in the list, it is deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public DestroySyncJobResponse DestroySyncJobSync(DestroySyncJobRequest req)
        {
            return InternalRequestAsync<DestroySyncJobResponse>(req, "DestroySyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to isolate and return a data migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status. For a billed task, after isolating it, you can call `RecoverMigrationJob` to recover it or call `DestroyMigrateJob` to delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public Task<IsolateMigrateJobResponse> IsolateMigrateJob(IsolateMigrateJobRequest req)
        {
            return InternalRequestAsync<IsolateMigrateJobResponse>(req, "IsolateMigrateJob");
        }

        /// <summary>
        ///  This API is used to isolate and return a data migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status. For a billed task, after isolating it, you can call `RecoverMigrationJob` to recover it or call `DestroyMigrateJob` to delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public IsolateMigrateJobResponse IsolateMigrateJobSync(IsolateMigrateJobRequest req)
        {
            return InternalRequestAsync<IsolateMigrateJobResponse>(req, "IsolateMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate the subscription task. After calling, the subscription task will not be available. Pay-as-you-go tasks will stop billing, and monthly subscription tasks will refund automatically.
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public Task<IsolateSubscribeResponse> IsolateSubscribe(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe");
        }

        /// <summary>
        /// This API is used to isolate the subscription task. After calling, the subscription task will not be available. Pay-as-you-go tasks will stop billing, and monthly subscription tasks will refund automatically.
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public IsolateSubscribeResponse IsolateSubscribeSync(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a sync task. After the task is isolated, you can call the `DescribeSyncJobs` API to query its status, call `RecoverSyncJob` to recover it, or directly delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public Task<IsolateSyncJobResponse> IsolateSyncJob(IsolateSyncJobRequest req)
        {
            return InternalRequestAsync<IsolateSyncJobResponse>(req, "IsolateSyncJob");
        }

        /// <summary>
        /// This API is used to isolate a sync task. After the task is isolated, you can call the `DescribeSyncJobs` API to query its status, call `RecoverSyncJob` to recover it, or directly delete it. For a free task, calling this API will directly delete it permanently.
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public IsolateSyncJobResponse IsolateSyncJobSync(IsolateSyncJobRequest req)
        {
            return InternalRequestAsync<IsolateSyncJobResponse>(req, "IsolateSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the parameters of a data consistency check task after it is created and before it starts.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public Task<ModifyCompareTaskResponse> ModifyCompareTask(ModifyCompareTaskRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskResponse>(req, "ModifyCompareTask");
        }

        /// <summary>
        /// This API is used to modify the parameters of a data consistency check task after it is created and before it starts.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public ModifyCompareTaskResponse ModifyCompareTaskSync(ModifyCompareTaskRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskResponse>(req, "ModifyCompareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public Task<ModifyCompareTaskNameResponse> ModifyCompareTaskName(ModifyCompareTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskNameResponse>(req, "ModifyCompareTaskName");
        }

        /// <summary>
        /// This API is used to rename a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public ModifyCompareTaskNameResponse ModifyCompareTaskNameSync(ModifyCompareTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskNameResponse>(req, "ModifyCompareTaskName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the description of the specified subscription consumption group.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupDescriptionRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupDescriptionResponse"/></returns>
        public Task<ModifyConsumerGroupDescriptionResponse> ModifyConsumerGroupDescription(ModifyConsumerGroupDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupDescriptionResponse>(req, "ModifyConsumerGroupDescription");
        }

        /// <summary>
        /// This API is used to modify the description of the specified subscription consumption group.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupDescriptionRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupDescriptionResponse"/></returns>
        public ModifyConsumerGroupDescriptionResponse ModifyConsumerGroupDescriptionSync(ModifyConsumerGroupDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupDescriptionResponse>(req, "ModifyConsumerGroupDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the password of the specified subscription consumer group.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupPasswordRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupPasswordResponse"/></returns>
        public Task<ModifyConsumerGroupPasswordResponse> ModifyConsumerGroupPassword(ModifyConsumerGroupPasswordRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupPasswordResponse>(req, "ModifyConsumerGroupPassword");
        }

        /// <summary>
        /// This API is used to modify the password of the specified subscription consumer group.
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupPasswordRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupPasswordResponse"/></returns>
        public ModifyConsumerGroupPasswordResponse ModifyConsumerGroupPasswordSync(ModifyConsumerGroupPasswordRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupPasswordResponse>(req, "ModifyConsumerGroupPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public Task<ModifyMigrateJobSpecResponse> ModifyMigrateJobSpec(ModifyMigrateJobSpecRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobSpecResponse>(req, "ModifyMigrateJobSpec");
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public ModifyMigrateJobSpecResponse ModifyMigrateJobSpecSync(ModifyMigrateJobSpecRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobSpecResponse>(req, "ModifyMigrateJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public Task<ModifyMigrateNameResponse> ModifyMigrateName(ModifyMigrateNameRequest req)
        {
            return InternalRequestAsync<ModifyMigrateNameResponse>(req, "ModifyMigrateName");
        }

        /// <summary>
        /// This API is used to rename a migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public ModifyMigrateNameResponse ModifyMigrateNameSync(ModifyMigrateNameRequest req)
        {
            return InternalRequestAsync<ModifyMigrateNameResponse>(req, "ModifyMigrateName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restrict the rate limit of the task, when a user finds that migration task has a large impact on the load of user's database.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRateLimitRequest"/></param>
        /// <returns><see cref="ModifyMigrateRateLimitResponse"/></returns>
        public Task<ModifyMigrateRateLimitResponse> ModifyMigrateRateLimit(ModifyMigrateRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRateLimitResponse>(req, "ModifyMigrateRateLimit");
        }

        /// <summary>
        /// This API is used to restrict the rate limit of the task, when a user finds that migration task has a large impact on the load of user's database.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRateLimitRequest"/></param>
        /// <returns><see cref="ModifyMigrateRateLimitResponse"/></returns>
        public ModifyMigrateRateLimitResponse ModifyMigrateRateLimitSync(ModifyMigrateRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRateLimitResponse>(req, "ModifyMigrateRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify task runtime attributes. This interface is different from the configuration class interface and does not perform state machine evaluation.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRuntimeAttributeRequest"/></param>
        /// <returns><see cref="ModifyMigrateRuntimeAttributeResponse"/></returns>
        public Task<ModifyMigrateRuntimeAttributeResponse> ModifyMigrateRuntimeAttribute(ModifyMigrateRuntimeAttributeRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRuntimeAttributeResponse>(req, "ModifyMigrateRuntimeAttribute");
        }

        /// <summary>
        /// This API is used to modify task runtime attributes. This interface is different from the configuration class interface and does not perform state machine evaluation.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRuntimeAttributeRequest"/></param>
        /// <returns><see cref="ModifyMigrateRuntimeAttributeResponse"/></returns>
        public ModifyMigrateRuntimeAttributeResponse ModifyMigrateRuntimeAttributeSync(ModifyMigrateRuntimeAttributeRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRuntimeAttributeResponse>(req, "ModifyMigrateRuntimeAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure a migration task. After it is configured successfully, you can call the `CreateMigrationCheckJob` API to create a check task, and only after it passes the check can it be started.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public Task<ModifyMigrationJobResponse> ModifyMigrationJob(ModifyMigrationJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrationJobResponse>(req, "ModifyMigrationJob");
        }

        /// <summary>
        /// This API is used to configure a migration task. After it is configured successfully, you can call the `CreateMigrationCheckJob` API to create a check task, and only after it passes the check can it be started.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public ModifyMigrationJobResponse ModifyMigrationJobSync(ModifyMigrationJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrationJobResponse>(req, "ModifyMigrationJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag of your subscription instance. Only the monthly subscription modification task makes sense. After modifying, the pay-as-you-go task has no impact.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifySubscribeAutoRenewFlagResponse"/></returns>
        public Task<ModifySubscribeAutoRenewFlagResponse> ModifySubscribeAutoRenewFlag(ModifySubscribeAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifySubscribeAutoRenewFlagResponse>(req, "ModifySubscribeAutoRenewFlag");
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag of your subscription instance. Only the monthly subscription modification task makes sense. After modifying, the pay-as-you-go task has no impact.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifySubscribeAutoRenewFlagResponse"/></returns>
        public ModifySubscribeAutoRenewFlagResponse ModifySubscribeAutoRenewFlagSync(ModifySubscribeAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifySubscribeAutoRenewFlagResponse>(req, "ModifySubscribeAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name of the data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public Task<ModifySubscribeNameResponse> ModifySubscribeName(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName");
        }

        /// <summary>
        /// This API is used to modify the name of the data subscription instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public ModifySubscribeNameResponse ModifySubscribeNameSync(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the data subscription object and Kafka partition rule. For MongoDB subscription, you can also modify the output aggregation rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public Task<ModifySubscribeObjectsResponse> ModifySubscribeObjects(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects");
        }

        /// <summary>
        /// This API is used to modify the data subscription object and Kafka partition rule. For MongoDB subscription, you can also modify the output aggregation rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public ModifySubscribeObjectsResponse ModifySubscribeObjectsSync(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of a data sync task after the task is started.\n Configuration modification steps:  Modify sync task configuration -> Create a modification check task -> Query the check task result -> Start the configuration modification check task
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobConfigRequest"/></param>
        /// <returns><see cref="ModifySyncJobConfigResponse"/></returns>
        public Task<ModifySyncJobConfigResponse> ModifySyncJobConfig(ModifySyncJobConfigRequest req)
        {
            return InternalRequestAsync<ModifySyncJobConfigResponse>(req, "ModifySyncJobConfig");
        }

        /// <summary>
        /// This API is used to modify the configuration of a data sync task after the task is started.\n Configuration modification steps:  Modify sync task configuration -> Create a modification check task -> Query the check task result -> Start the configuration modification check task
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobConfigRequest"/></param>
        /// <returns><see cref="ModifySyncJobConfigResponse"/></returns>
        public ModifySyncJobConfigResponse ModifySyncJobConfigSync(ModifySyncJobConfigRequest req)
        {
            return InternalRequestAsync<ModifySyncJobConfigResponse>(req, "ModifySyncJobConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restrict the rate limit of the task, when a user finds that the sync task has a large impact on the load of user's database.
        /// </summary>
        /// <param name="req"><see cref="ModifySyncRateLimitRequest"/></param>
        /// <returns><see cref="ModifySyncRateLimitResponse"/></returns>
        public Task<ModifySyncRateLimitResponse> ModifySyncRateLimit(ModifySyncRateLimitRequest req)
        {
            return InternalRequestAsync<ModifySyncRateLimitResponse>(req, "ModifySyncRateLimit");
        }

        /// <summary>
        /// This API is used to restrict the rate limit of the task, when a user finds that the sync task has a large impact on the load of user's database.
        /// </summary>
        /// <param name="req"><see cref="ModifySyncRateLimitRequest"/></param>
        /// <returns><see cref="ModifySyncRateLimitResponse"/></returns>
        public ModifySyncRateLimitResponse ModifySyncRateLimitSync(ModifySyncRateLimitRequest req)
        {
            return InternalRequestAsync<ModifySyncRateLimitResponse>(req, "ModifySyncRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause a migration task.
        /// </summary>
        /// <param name="req"><see cref="PauseMigrateJobRequest"/></param>
        /// <returns><see cref="PauseMigrateJobResponse"/></returns>
        public Task<PauseMigrateJobResponse> PauseMigrateJob(PauseMigrateJobRequest req)
        {
            return InternalRequestAsync<PauseMigrateJobResponse>(req, "PauseMigrateJob");
        }

        /// <summary>
        /// This API is used to pause a migration task.
        /// </summary>
        /// <param name="req"><see cref="PauseMigrateJobRequest"/></param>
        /// <returns><see cref="PauseMigrateJobResponse"/></returns>
        public PauseMigrateJobResponse PauseMigrateJobSync(PauseMigrateJobRequest req)
        {
            return InternalRequestAsync<PauseMigrateJobResponse>(req, "PauseMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause a data sync task.
        /// </summary>
        /// <param name="req"><see cref="PauseSyncJobRequest"/></param>
        /// <returns><see cref="PauseSyncJobResponse"/></returns>
        public Task<PauseSyncJobResponse> PauseSyncJob(PauseSyncJobRequest req)
        {
            return InternalRequestAsync<PauseSyncJobResponse>(req, "PauseSyncJob");
        }

        /// <summary>
        /// This API is used to pause a data sync task.
        /// </summary>
        /// <param name="req"><see cref="PauseSyncJobRequest"/></param>
        /// <returns><see cref="PauseSyncJobResponse"/></returns>
        public PauseSyncJobResponse PauseSyncJobSync(PauseSyncJobRequest req)
        {
            return InternalRequestAsync<PauseSyncJobResponse>(req, "PauseSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover a data migration task in **Isolated** status. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public Task<RecoverMigrateJobResponse> RecoverMigrateJob(RecoverMigrateJobRequest req)
        {
            return InternalRequestAsync<RecoverMigrateJobResponse>(req, "RecoverMigrateJob");
        }

        /// <summary>
        /// This API is used to recover a data migration task in **Isolated** status. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public RecoverMigrateJobResponse RecoverMigrateJobSync(RecoverMigrateJobRequest req)
        {
            return InternalRequestAsync<RecoverMigrateJobResponse>(req, "RecoverMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover a sync task in **Isolated** status. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public Task<RecoverSyncJobResponse> RecoverSyncJob(RecoverSyncJobRequest req)
        {
            return InternalRequestAsync<RecoverSyncJobResponse>(req, "RecoverSyncJob");
        }

        /// <summary>
        /// This API is used to recover a sync task in **Isolated** status. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public RecoverSyncJobResponse RecoverSyncJobSync(RecoverSyncJobRequest req)
        {
            return InternalRequestAsync<RecoverSyncJobResponse>(req, "RecoverSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the offset of the subscription consumer group. Call the DescribeConsumerGroups API to query the status of the consumer group, only when the status is Dead or Empty can this operation be executed. Otherwise, the reset will not be effective and the API will not return any error.
        /// </summary>
        /// <param name="req"><see cref="ResetConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ResetConsumerGroupOffsetResponse"/></returns>
        public Task<ResetConsumerGroupOffsetResponse> ResetConsumerGroupOffset(ResetConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ResetConsumerGroupOffsetResponse>(req, "ResetConsumerGroupOffset");
        }

        /// <summary>
        /// This API is used to reset the offset of the subscription consumer group. Call the DescribeConsumerGroups API to query the status of the consumer group, only when the status is Dead or Empty can this operation be executed. Otherwise, the reset will not be effective and the API will not return any error.
        /// </summary>
        /// <param name="req"><see cref="ResetConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ResetConsumerGroupOffsetResponse"/></returns>
        public ResetConsumerGroupOffsetResponse ResetConsumerGroupOffsetSync(ResetConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ResetConsumerGroupOffsetResponse>(req, "ResetConsumerGroupOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the subscription instance. After resetting, the subscription task can be reconfigured.You can call DescribeSubscribeDetail to query the subscription information to determine whether the subscription is successful. When SubsStatus changes to notStarted, it means the reset is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public Task<ResetSubscribeResponse> ResetSubscribe(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe");
        }

        /// <summary>
        /// This API is used to reset the subscription instance. After resetting, the subscription task can be reconfigured.You can call DescribeSubscribeDetail to query the subscription information to determine whether the subscription is successful. When SubsStatus changes to notStarted, it means the reset is successful.
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public ResetSubscribeResponse ResetSubscribeSync(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go sync task. After this API is called, the backend needs to take about 3-5 minutes to implement the adjustment. You can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public Task<ResizeSyncJobResponse> ResizeSyncJob(ResizeSyncJobRequest req)
        {
            return InternalRequestAsync<ResizeSyncJobResponse>(req, "ResizeSyncJob");
        }

        /// <summary>
        /// This API is used to adjust the specification of a pay-as-you-go sync task. After this API is called, the backend needs to take about 3-5 minutes to implement the adjustment. You can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public ResizeSyncJobResponse ResizeSyncJobSync(ResizeSyncJobRequest req)
        {
            return InternalRequestAsync<ResizeSyncJobResponse>(req, "ResizeSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry an abnormal or failed Redis data migration task. Note that this operation will skip the check stage and directly start the task, just like by calling `StartMigrationJob`. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public Task<ResumeMigrateJobResponse> ResumeMigrateJob(ResumeMigrateJobRequest req)
        {
            return InternalRequestAsync<ResumeMigrateJobResponse>(req, "ResumeMigrateJob");
        }

        /// <summary>
        /// This API is used to retry an abnormal or failed Redis data migration task. Note that this operation will skip the check stage and directly start the task, just like by calling `StartMigrationJob`. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public ResumeMigrateJobResponse ResumeMigrateJobSync(ResumeMigrateJobRequest req)
        {
            return InternalRequestAsync<ResumeMigrateJobResponse>(req, "ResumeMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume faulty subscription tasks. When the status of the subscription task is set to error, you can resume task via this API.
        /// </summary>
        /// <param name="req"><see cref="ResumeSubscribeRequest"/></param>
        /// <returns><see cref="ResumeSubscribeResponse"/></returns>
        public Task<ResumeSubscribeResponse> ResumeSubscribe(ResumeSubscribeRequest req)
        {
            return InternalRequestAsync<ResumeSubscribeResponse>(req, "ResumeSubscribe");
        }

        /// <summary>
        /// This API is used to resume faulty subscription tasks. When the status of the subscription task is set to error, you can resume task via this API.
        /// </summary>
        /// <param name="req"><see cref="ResumeSubscribeRequest"/></param>
        /// <returns><see cref="ResumeSubscribeResponse"/></returns>
        public ResumeSubscribeResponse ResumeSubscribeSync(ResumeSubscribeRequest req)
        {
            return InternalRequestAsync<ResumeSubscribeResponse>(req, "ResumeSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry a sync task after certain resolvable errors are reported. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public Task<ResumeSyncJobResponse> ResumeSyncJob(ResumeSyncJobRequest req)
        {
            return InternalRequestAsync<ResumeSyncJobResponse>(req, "ResumeSyncJob");
        }

        /// <summary>
        /// This API is used to retry a sync task after certain resolvable errors are reported. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public ResumeSyncJobResponse ResumeSyncJobSync(ResumeSyncJobRequest req)
        {
            return InternalRequestAsync<ResumeSyncJobResponse>(req, "ResumeSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a migration task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public Task<SkipCheckItemResponse> SkipCheckItem(SkipCheckItemRequest req)
        {
            return InternalRequestAsync<SkipCheckItemResponse>(req, "SkipCheckItem");
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a migration task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public SkipCheckItemResponse SkipCheckItemSync(SkipCheckItemRequest req)
        {
            return InternalRequestAsync<SkipCheckItemResponse>(req, "SkipCheckItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a sync task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public Task<SkipSyncCheckItemResponse> SkipSyncCheckItem(SkipSyncCheckItemRequest req)
        {
            return InternalRequestAsync<SkipSyncCheckItemResponse>(req, "SkipSyncCheckItem");
        }

        /// <summary>
        /// This API is used for the backend to skip a failed check item. Theoretically, to execute a sync task normally, any check step cannot be skipped, and the check must be passed. For products or links that support check item skipping, see [Check Item Overview](https://www.tencentcloud.com/document/product/571/42551).
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public SkipSyncCheckItemResponse SkipSyncCheckItemSync(SkipSyncCheckItemRequest req)
        {
            return InternalRequestAsync<SkipSyncCheckItemResponse>(req, "SkipSyncCheckItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a data consistency check task after creating it by calling the `CreateCompareTask` API. After calling this API, you can call the `DescribeCompareTasks` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public Task<StartCompareResponse> StartCompare(StartCompareRequest req)
        {
            return InternalRequestAsync<StartCompareResponse>(req, "StartCompare");
        }

        /// <summary>
        /// This API is used to start a data consistency check task after creating it by calling the `CreateCompareTask` API. After calling this API, you can call the `DescribeCompareTasks` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public StartCompareResponse StartCompareSync(StartCompareRequest req)
        {
            return InternalRequestAsync<StartCompareResponse>(req, "StartCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (`StartMigrationJob`) is used to start a migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public Task<StartMigrateJobResponse> StartMigrateJob(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob");
        }

        /// <summary>
        /// This API (`StartMigrationJob`) is used to start a migration task. After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public StartMigrateJobResponse StartMigrateJobSync(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start the configuration modification process when the modification check task status becomes “success”.
        /// </summary>
        /// <param name="req"><see cref="StartModifySyncJobRequest"/></param>
        /// <returns><see cref="StartModifySyncJobResponse"/></returns>
        public Task<StartModifySyncJobResponse> StartModifySyncJob(StartModifySyncJobRequest req)
        {
            return InternalRequestAsync<StartModifySyncJobResponse>(req, "StartModifySyncJob");
        }

        /// <summary>
        /// This API is used to start the configuration modification process when the modification check task status becomes “success”.
        /// </summary>
        /// <param name="req"><see cref="StartModifySyncJobRequest"/></param>
        /// <returns><see cref="StartModifySyncJobResponse"/></returns>
        public StartModifySyncJobResponse StartModifySyncJobSync(StartModifySyncJobRequest req)
        {
            return InternalRequestAsync<StartModifySyncJobResponse>(req, "StartModifySyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a Kafka version of the data subscription instance. This interface can be called only when the status of the subscription task is checkPass.
        /// </summary>
        /// <param name="req"><see cref="StartSubscribeRequest"/></param>
        /// <returns><see cref="StartSubscribeResponse"/></returns>
        public Task<StartSubscribeResponse> StartSubscribe(StartSubscribeRequest req)
        {
            return InternalRequestAsync<StartSubscribeResponse>(req, "StartSubscribe");
        }

        /// <summary>
        /// This API is used to start a Kafka version of the data subscription instance. This interface can be called only when the status of the subscription task is checkPass.
        /// </summary>
        /// <param name="req"><see cref="StartSubscribeRequest"/></param>
        /// <returns><see cref="StartSubscribeResponse"/></returns>
        public StartSubscribeResponse StartSubscribeSync(StartSubscribeRequest req)
        {
            return InternalRequestAsync<StartSubscribeResponse>(req, "StartSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a sync task.
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public Task<StartSyncJobResponse> StartSyncJob(StartSyncJobRequest req)
        {
            return InternalRequestAsync<StartSyncJobResponse>(req, "StartSyncJob");
        }

        /// <summary>
        /// This API is used to start a sync task.
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public StartSyncJobResponse StartSyncJobSync(StartSyncJobRequest req)
        {
            return InternalRequestAsync<StartSyncJobResponse>(req, "StartSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public Task<StopCompareResponse> StopCompare(StopCompareRequest req)
        {
            return InternalRequestAsync<StopCompareResponse>(req, "StopCompare");
        }

        /// <summary>
        /// This API is used to stop a data consistency check task.
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public StopCompareResponse StopCompareSync(StopCompareRequest req)
        {
            return InternalRequestAsync<StopCompareResponse>(req, "StopCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a data migration task.
        /// After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public Task<StopMigrateJobResponse> StopMigrateJob(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob");
        }

        /// <summary>
        /// This API is used to stop a data migration task.
        /// After calling this API, you can call the `DescribeMigrationJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public StopMigrateJobResponse StopMigrateJobSync(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a sync task. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public Task<StopSyncJobResponse> StopSyncJob(StopSyncJobRequest req)
        {
            return InternalRequestAsync<StopSyncJobResponse>(req, "StopSyncJob");
        }

        /// <summary>
        /// This API is used to stop a sync task. After calling this API, you can call the `DescribeSyncJobs` API to query the latest task status.
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public StopSyncJobResponse StopSyncJobSync(StopSyncJobRequest req)
        {
            return InternalRequestAsync<StopSyncJobResponse>(req, "StopSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
