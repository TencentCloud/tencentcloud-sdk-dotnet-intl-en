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

namespace TencentCloud.Wedata.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20210820.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.tencentcloudapi.com";
       private const string version = "2021-08-20";
       private const string sdkVersion = "SDK_NET_3.0.954";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WedataClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Bulk Create Task Alert Rules
        /// </summary>
        /// <param name="req"><see cref="BatchCreateIntegrationTaskAlarmsRequest"/></param>
        /// <returns><see cref="BatchCreateIntegrationTaskAlarmsResponse"/></returns>
        public Task<BatchCreateIntegrationTaskAlarmsResponse> BatchCreateIntegrationTaskAlarms(BatchCreateIntegrationTaskAlarmsRequest req)
        {
            return InternalRequestAsync<BatchCreateIntegrationTaskAlarmsResponse>(req, "BatchCreateIntegrationTaskAlarms");
        }

        /// <summary>
        /// Bulk Create Task Alert Rules
        /// </summary>
        /// <param name="req"><see cref="BatchCreateIntegrationTaskAlarmsRequest"/></param>
        /// <returns><see cref="BatchCreateIntegrationTaskAlarmsResponse"/></returns>
        public BatchCreateIntegrationTaskAlarmsResponse BatchCreateIntegrationTaskAlarmsSync(BatchCreateIntegrationTaskAlarmsRequest req)
        {
            return InternalRequestAsync<BatchCreateIntegrationTaskAlarmsResponse>(req, "BatchCreateIntegrationTaskAlarms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Delete Integration Tasks.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteIntegrationTasksResponse"/></returns>
        public Task<BatchDeleteIntegrationTasksResponse> BatchDeleteIntegrationTasks(BatchDeleteIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteIntegrationTasksResponse>(req, "BatchDeleteIntegrationTasks");
        }

        /// <summary>
        /// Batch Delete Integration Tasks.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteIntegrationTasksResponse"/></returns>
        public BatchDeleteIntegrationTasksResponse BatchDeleteIntegrationTasksSync(BatchDeleteIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteIntegrationTasksResponse>(req, "BatchDeleteIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Operation and Maintenance - Batch Delete Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteOpsTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteOpsTasksResponse"/></returns>
        public Task<BatchDeleteOpsTasksResponse> BatchDeleteOpsTasks(BatchDeleteOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteOpsTasksResponse>(req, "BatchDeleteOpsTasks");
        }

        /// <summary>
        /// Task Operation and Maintenance - Batch Delete Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteOpsTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteOpsTasksResponse"/></returns>
        public BatchDeleteOpsTasksResponse BatchDeleteOpsTasksSync(BatchDeleteOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteOpsTasksResponse>(req, "BatchDeleteOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch set successful integration task instances
        /// </summary>
        /// <param name="req"><see cref="BatchForceSuccessIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchForceSuccessIntegrationTaskInstancesResponse"/></returns>
        public Task<BatchForceSuccessIntegrationTaskInstancesResponse> BatchForceSuccessIntegrationTaskInstances(BatchForceSuccessIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchForceSuccessIntegrationTaskInstancesResponse>(req, "BatchForceSuccessIntegrationTaskInstances");
        }

        /// <summary>
        /// Batch set successful integration task instances
        /// </summary>
        /// <param name="req"><see cref="BatchForceSuccessIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchForceSuccessIntegrationTaskInstancesResponse"/></returns>
        public BatchForceSuccessIntegrationTaskInstancesResponse BatchForceSuccessIntegrationTaskInstancesSync(BatchForceSuccessIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchForceSuccessIntegrationTaskInstancesResponse>(req, "BatchForceSuccessIntegrationTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Terminate Integration Task Instances
        /// </summary>
        /// <param name="req"><see cref="BatchKillIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchKillIntegrationTaskInstancesResponse"/></returns>
        public Task<BatchKillIntegrationTaskInstancesResponse> BatchKillIntegrationTaskInstances(BatchKillIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchKillIntegrationTaskInstancesResponse>(req, "BatchKillIntegrationTaskInstances");
        }

        /// <summary>
        /// Batch Terminate Integration Task Instances
        /// </summary>
        /// <param name="req"><see cref="BatchKillIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchKillIntegrationTaskInstancesResponse"/></returns>
        public BatchKillIntegrationTaskInstancesResponse BatchKillIntegrationTaskInstancesSync(BatchKillIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchKillIntegrationTaskInstancesResponse>(req, "BatchKillIntegrationTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Perform Batch Data Supplement Operation on Integrated Offline Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchMakeUpIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchMakeUpIntegrationTasksResponse"/></returns>
        public Task<BatchMakeUpIntegrationTasksResponse> BatchMakeUpIntegrationTasks(BatchMakeUpIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchMakeUpIntegrationTasksResponse>(req, "BatchMakeUpIntegrationTasks");
        }

        /// <summary>
        /// Perform Batch Data Supplement Operation on Integrated Offline Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchMakeUpIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchMakeUpIntegrationTasksResponse"/></returns>
        public BatchMakeUpIntegrationTasksResponse BatchMakeUpIntegrationTasksSync(BatchMakeUpIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchMakeUpIntegrationTasksResponse>(req, "BatchMakeUpIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Modify Task Assignee
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOpsOwnersRequest"/></param>
        /// <returns><see cref="BatchModifyOpsOwnersResponse"/></returns>
        public Task<BatchModifyOpsOwnersResponse> BatchModifyOpsOwners(BatchModifyOpsOwnersRequest req)
        {
            return InternalRequestAsync<BatchModifyOpsOwnersResponse>(req, "BatchModifyOpsOwners");
        }

        /// <summary>
        /// Batch Modify Task Assignee
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOpsOwnersRequest"/></param>
        /// <returns><see cref="BatchModifyOpsOwnersResponse"/></returns>
        public BatchModifyOpsOwnersResponse BatchModifyOpsOwnersSync(BatchModifyOpsOwnersRequest req)
        {
            return InternalRequestAsync<BatchModifyOpsOwnersResponse>(req, "BatchModifyOpsOwners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Rerun Integration Task Instances
        /// </summary>
        /// <param name="req"><see cref="BatchRerunIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchRerunIntegrationTaskInstancesResponse"/></returns>
        public Task<BatchRerunIntegrationTaskInstancesResponse> BatchRerunIntegrationTaskInstances(BatchRerunIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchRerunIntegrationTaskInstancesResponse>(req, "BatchRerunIntegrationTaskInstances");
        }

        /// <summary>
        /// Batch Rerun Integration Task Instances
        /// </summary>
        /// <param name="req"><see cref="BatchRerunIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchRerunIntegrationTaskInstancesResponse"/></returns>
        public BatchRerunIntegrationTaskInstancesResponse BatchRerunIntegrationTaskInstancesSync(BatchRerunIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchRerunIntegrationTaskInstancesResponse>(req, "BatchRerunIntegrationTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Continue Execution of Integrated Real-time Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchResumeIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchResumeIntegrationTasksResponse"/></returns>
        public Task<BatchResumeIntegrationTasksResponse> BatchResumeIntegrationTasks(BatchResumeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchResumeIntegrationTasksResponse>(req, "BatchResumeIntegrationTasks");
        }

        /// <summary>
        /// Batch Continue Execution of Integrated Real-time Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchResumeIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchResumeIntegrationTasksResponse"/></returns>
        public BatchResumeIntegrationTasksResponse BatchResumeIntegrationTasksSync(BatchResumeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchResumeIntegrationTasksResponse>(req, "BatchResumeIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Operation and Maintenance - Task List Batch Startup
        /// </summary>
        /// <param name="req"><see cref="BatchRunOpsTaskRequest"/></param>
        /// <returns><see cref="BatchRunOpsTaskResponse"/></returns>
        public Task<BatchRunOpsTaskResponse> BatchRunOpsTask(BatchRunOpsTaskRequest req)
        {
            return InternalRequestAsync<BatchRunOpsTaskResponse>(req, "BatchRunOpsTask");
        }

        /// <summary>
        /// Task Operation and Maintenance - Task List Batch Startup
        /// </summary>
        /// <param name="req"><see cref="BatchRunOpsTaskRequest"/></param>
        /// <returns><see cref="BatchRunOpsTaskResponse"/></returns>
        public BatchRunOpsTaskResponse BatchRunOpsTaskSync(BatchRunOpsTaskRequest req)
        {
            return InternalRequestAsync<BatchRunOpsTaskResponse>(req, "BatchRunOpsTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Run Integration Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchStartIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStartIntegrationTasksResponse"/></returns>
        public Task<BatchStartIntegrationTasksResponse> BatchStartIntegrationTasks(BatchStartIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStartIntegrationTasksResponse>(req, "BatchStartIntegrationTasks");
        }

        /// <summary>
        /// Batch Run Integration Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchStartIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStartIntegrationTasksResponse"/></returns>
        public BatchStartIntegrationTasksResponse BatchStartIntegrationTasksSync(BatchStartIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStartIntegrationTasksResponse>(req, "BatchStartIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Stop Integration Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchStopIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStopIntegrationTasksResponse"/></returns>
        public Task<BatchStopIntegrationTasksResponse> BatchStopIntegrationTasks(BatchStopIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStopIntegrationTasksResponse>(req, "BatchStopIntegrationTasks");
        }

        /// <summary>
        /// Batch Stop Integration Tasks
        /// </summary>
        /// <param name="req"><see cref="BatchStopIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStopIntegrationTasksResponse"/></returns>
        public BatchStopIntegrationTasksResponse BatchStopIntegrationTasksSync(BatchStopIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStopIntegrationTasksResponse>(req, "BatchStopIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Only valid for tasks in "Scheduling In Progress" and "Paused" statuses, terminate the task instances of the selected tasks, and stop scheduling
        /// </summary>
        /// <param name="req"><see cref="BatchStopOpsTasksRequest"/></param>
        /// <returns><see cref="BatchStopOpsTasksResponse"/></returns>
        public Task<BatchStopOpsTasksResponse> BatchStopOpsTasks(BatchStopOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchStopOpsTasksResponse>(req, "BatchStopOpsTasks");
        }

        /// <summary>
        /// Only valid for tasks in "Scheduling In Progress" and "Paused" statuses, terminate the task instances of the selected tasks, and stop scheduling
        /// </summary>
        /// <param name="req"><see cref="BatchStopOpsTasksRequest"/></param>
        /// <returns><see cref="BatchStopOpsTasksResponse"/></returns>
        public BatchStopOpsTasksResponse BatchStopOpsTasksSync(BatchStopOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchStopOpsTasksResponse>(req, "BatchStopOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Stop Workflow
        /// </summary>
        /// <param name="req"><see cref="BatchStopWorkflowsByIdsRequest"/></param>
        /// <returns><see cref="BatchStopWorkflowsByIdsResponse"/></returns>
        public Task<BatchStopWorkflowsByIdsResponse> BatchStopWorkflowsByIds(BatchStopWorkflowsByIdsRequest req)
        {
            return InternalRequestAsync<BatchStopWorkflowsByIdsResponse>(req, "BatchStopWorkflowsByIds");
        }

        /// <summary>
        /// Batch Stop Workflow
        /// </summary>
        /// <param name="req"><see cref="BatchStopWorkflowsByIdsRequest"/></param>
        /// <returns><see cref="BatchStopWorkflowsByIdsResponse"/></returns>
        public BatchStopWorkflowsByIdsResponse BatchStopWorkflowsByIdsSync(BatchStopWorkflowsByIdsRequest req)
        {
            return InternalRequestAsync<BatchStopWorkflowsByIdsResponse>(req, "BatchStopWorkflowsByIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch pause integration tasks
        /// </summary>
        /// <param name="req"><see cref="BatchSuspendIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchSuspendIntegrationTasksResponse"/></returns>
        public Task<BatchSuspendIntegrationTasksResponse> BatchSuspendIntegrationTasks(BatchSuspendIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchSuspendIntegrationTasksResponse>(req, "BatchSuspendIntegrationTasks");
        }

        /// <summary>
        /// Batch pause integration tasks
        /// </summary>
        /// <param name="req"><see cref="BatchSuspendIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchSuspendIntegrationTasksResponse"/></returns>
        public BatchSuspendIntegrationTasksResponse BatchSuspendIntegrationTasksSync(BatchSuspendIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchSuspendIntegrationTasksResponse>(req, "BatchSuspendIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bulk Update Integration Tasks (Currently only supports bulk updating of the person in charge)
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchUpdateIntegrationTasksResponse"/></returns>
        public Task<BatchUpdateIntegrationTasksResponse> BatchUpdateIntegrationTasks(BatchUpdateIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchUpdateIntegrationTasksResponse>(req, "BatchUpdateIntegrationTasks");
        }

        /// <summary>
        /// Bulk Update Integration Tasks (Currently only supports bulk updating of the person in charge)
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchUpdateIntegrationTasksResponse"/></returns>
        public BatchUpdateIntegrationTasksResponse BatchUpdateIntegrationTasksSync(BatchUpdateIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchUpdateIntegrationTasksResponse>(req, "BatchUpdateIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Check for Duplicate Alert Rule Names
        /// </summary>
        /// <param name="req"><see cref="CheckAlarmRegularNameExistRequest"/></param>
        /// <returns><see cref="CheckAlarmRegularNameExistResponse"/></returns>
        public Task<CheckAlarmRegularNameExistResponse> CheckAlarmRegularNameExist(CheckAlarmRegularNameExistRequest req)
        {
            return InternalRequestAsync<CheckAlarmRegularNameExistResponse>(req, "CheckAlarmRegularNameExist");
        }

        /// <summary>
        /// Check for Duplicate Alert Rule Names
        /// </summary>
        /// <param name="req"><see cref="CheckAlarmRegularNameExistRequest"/></param>
        /// <returns><see cref="CheckAlarmRegularNameExistResponse"/></returns>
        public CheckAlarmRegularNameExistResponse CheckAlarmRegularNameExistSync(CheckAlarmRegularNameExistRequest req)
        {
            return InternalRequestAsync<CheckAlarmRegularNameExistResponse>(req, "CheckAlarmRegularNameExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Determining if the name of the integrated node exists
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationNodeNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationNodeNameExistsResponse"/></returns>
        public Task<CheckIntegrationNodeNameExistsResponse> CheckIntegrationNodeNameExists(CheckIntegrationNodeNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationNodeNameExistsResponse>(req, "CheckIntegrationNodeNameExists");
        }

        /// <summary>
        /// Determining if the name of the integrated node exists
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationNodeNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationNodeNameExistsResponse"/></returns>
        public CheckIntegrationNodeNameExistsResponse CheckIntegrationNodeNameExistsSync(CheckIntegrationNodeNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationNodeNameExistsResponse>(req, "CheckIntegrationNodeNameExists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Check if Integration Task Name Exists
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationTaskNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationTaskNameExistsResponse"/></returns>
        public Task<CheckIntegrationTaskNameExistsResponse> CheckIntegrationTaskNameExists(CheckIntegrationTaskNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationTaskNameExistsResponse>(req, "CheckIntegrationTaskNameExists");
        }

        /// <summary>
        /// Check if Integration Task Name Exists
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationTaskNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationTaskNameExistsResponse"/></returns>
        public CheckIntegrationTaskNameExistsResponse CheckIntegrationTaskNameExistsSync(CheckIntegrationTaskNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationTaskNameExistsResponse>(req, "CheckIntegrationTaskNameExists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Offline Task Renaming Verification
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistResponse"/></returns>
        public Task<CheckTaskNameExistResponse> CheckTaskNameExist(CheckTaskNameExistRequest req)
        {
            return InternalRequestAsync<CheckTaskNameExistResponse>(req, "CheckTaskNameExist");
        }

        /// <summary>
        /// Offline Task Renaming Verification
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistResponse"/></returns>
        public CheckTaskNameExistResponse CheckTaskNameExistSync(CheckTaskNameExistRequest req)
        {
            return InternalRequestAsync<CheckTaskNameExistResponse>(req, "CheckTaskNameExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit integration task
        /// </summary>
        /// <param name="req"><see cref="CommitIntegrationTaskRequest"/></param>
        /// <returns><see cref="CommitIntegrationTaskResponse"/></returns>
        public Task<CommitIntegrationTaskResponse> CommitIntegrationTask(CommitIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CommitIntegrationTaskResponse>(req, "CommitIntegrationTask");
        }

        /// <summary>
        /// Submit integration task
        /// </summary>
        /// <param name="req"><see cref="CommitIntegrationTaskRequest"/></param>
        /// <returns><see cref="CommitIntegrationTaskResponse"/></returns>
        public CommitIntegrationTaskResponse CommitIntegrationTaskSync(CommitIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CommitIntegrationTaskResponse>(req, "CommitIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit Rule Group to Run Task Interface
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupTaskRequest"/></param>
        /// <returns><see cref="CommitRuleGroupTaskResponse"/></returns>
        public Task<CommitRuleGroupTaskResponse> CommitRuleGroupTask(CommitRuleGroupTaskRequest req)
        {
            return InternalRequestAsync<CommitRuleGroupTaskResponse>(req, "CommitRuleGroupTask");
        }

        /// <summary>
        /// Submit Rule Group to Run Task Interface
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupTaskRequest"/></param>
        /// <returns><see cref="CommitRuleGroupTaskResponse"/></returns>
        public CommitRuleGroupTaskResponse CommitRuleGroupTaskSync(CommitRuleGroupTaskRequest req)
        {
            return InternalRequestAsync<CommitRuleGroupTaskResponse>(req, "CommitRuleGroupTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Statistics on task instance status
        /// </summary>
        /// <param name="req"><see cref="CountOpsInstanceStateRequest"/></param>
        /// <returns><see cref="CountOpsInstanceStateResponse"/></returns>
        public Task<CountOpsInstanceStateResponse> CountOpsInstanceState(CountOpsInstanceStateRequest req)
        {
            return InternalRequestAsync<CountOpsInstanceStateResponse>(req, "CountOpsInstanceState");
        }

        /// <summary>
        /// Statistics on task instance status
        /// </summary>
        /// <param name="req"><see cref="CountOpsInstanceStateRequest"/></param>
        /// <returns><see cref="CountOpsInstanceStateResponse"/></returns>
        public CountOpsInstanceStateResponse CountOpsInstanceStateSync(CountOpsInstanceStateRequest req)
        {
            return InternalRequestAsync<CountOpsInstanceStateResponse>(req, "CountOpsInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create User-Defined Function
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public Task<CreateCustomFunctionResponse> CreateCustomFunction(CreateCustomFunctionRequest req)
        {
            return InternalRequestAsync<CreateCustomFunctionResponse>(req, "CreateCustomFunction");
        }

        /// <summary>
        /// Create User-Defined Function
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public CreateCustomFunctionResponse CreateCustomFunctionSync(CreateCustomFunctionRequest req)
        {
            return InternalRequestAsync<CreateCustomFunctionResponse>(req, "CreateCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Data Source
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource");
        }

        /// <summary>
        /// Create Data Source
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public CreateDataSourceResponse CreateDataSourceSync(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Orchestration Space - Create Folder
        /// </summary>
        /// <param name="req"><see cref="CreateDsFolderRequest"/></param>
        /// <returns><see cref="CreateDsFolderResponse"/></returns>
        public Task<CreateDsFolderResponse> CreateDsFolder(CreateDsFolderRequest req)
        {
            return InternalRequestAsync<CreateDsFolderResponse>(req, "CreateDsFolder");
        }

        /// <summary>
        /// Orchestration Space - Create Folder
        /// </summary>
        /// <param name="req"><see cref="CreateDsFolderRequest"/></param>
        /// <returns><see cref="CreateDsFolderResponse"/></returns>
        public CreateDsFolderResponse CreateDsFolderSync(CreateDsFolderRequest req)
        {
            return InternalRequestAsync<CreateDsFolderResponse>(req, "CreateDsFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Hive Table
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableRequest"/></param>
        /// <returns><see cref="CreateHiveTableResponse"/></returns>
        public Task<CreateHiveTableResponse> CreateHiveTable(CreateHiveTableRequest req)
        {
            return InternalRequestAsync<CreateHiveTableResponse>(req, "CreateHiveTable");
        }

        /// <summary>
        /// Create Hive Table
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableRequest"/></param>
        /// <returns><see cref="CreateHiveTableResponse"/></returns>
        public CreateHiveTableResponse CreateHiveTableSync(CreateHiveTableRequest req)
        {
            return InternalRequestAsync<CreateHiveTableResponse>(req, "CreateHiveTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Hive table and return table name
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableByDDLRequest"/></param>
        /// <returns><see cref="CreateHiveTableByDDLResponse"/></returns>
        public Task<CreateHiveTableByDDLResponse> CreateHiveTableByDDL(CreateHiveTableByDDLRequest req)
        {
            return InternalRequestAsync<CreateHiveTableByDDLResponse>(req, "CreateHiveTableByDDL");
        }

        /// <summary>
        /// Create Hive table and return table name
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableByDDLRequest"/></param>
        /// <returns><see cref="CreateHiveTableByDDLResponse"/></returns>
        public CreateHiveTableByDDLResponse CreateHiveTableByDDLSync(CreateHiveTableByDDLRequest req)
        {
            return InternalRequestAsync<CreateHiveTableByDDLResponse>(req, "CreateHiveTableByDDL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Integration Node
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationNodeRequest"/></param>
        /// <returns><see cref="CreateIntegrationNodeResponse"/></returns>
        public Task<CreateIntegrationNodeResponse> CreateIntegrationNode(CreateIntegrationNodeRequest req)
        {
            return InternalRequestAsync<CreateIntegrationNodeResponse>(req, "CreateIntegrationNode");
        }

        /// <summary>
        /// Create Integration Node
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationNodeRequest"/></param>
        /// <returns><see cref="CreateIntegrationNodeResponse"/></returns>
        public CreateIntegrationNodeResponse CreateIntegrationNodeSync(CreateIntegrationNodeRequest req)
        {
            return InternalRequestAsync<CreateIntegrationNodeResponse>(req, "CreateIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Integration Task
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationTaskRequest"/></param>
        /// <returns><see cref="CreateIntegrationTaskResponse"/></returns>
        public Task<CreateIntegrationTaskResponse> CreateIntegrationTask(CreateIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CreateIntegrationTaskResponse>(req, "CreateIntegrationTask");
        }

        /// <summary>
        /// Create Integration Task
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationTaskRequest"/></param>
        /// <returns><see cref="CreateIntegrationTaskResponse"/></returns>
        public CreateIntegrationTaskResponse CreateIntegrationTaskSync(CreateIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CreateIntegrationTaskResponse>(req, "CreateIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Offline Task
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineTaskRequest"/></param>
        /// <returns><see cref="CreateOfflineTaskResponse"/></returns>
        public Task<CreateOfflineTaskResponse> CreateOfflineTask(CreateOfflineTaskRequest req)
        {
            return InternalRequestAsync<CreateOfflineTaskResponse>(req, "CreateOfflineTask");
        }

        /// <summary>
        /// Create Offline Task
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineTaskRequest"/></param>
        /// <returns><see cref="CreateOfflineTaskResponse"/></returns>
        public CreateOfflineTaskResponse CreateOfflineTaskSync(CreateOfflineTaskRequest req)
        {
            return InternalRequestAsync<CreateOfflineTaskResponse>(req, "CreateOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bulk Data Supplement (Create Supplementary Entry Task)
        /// </summary>
        /// <param name="req"><see cref="CreateOpsMakePlanRequest"/></param>
        /// <returns><see cref="CreateOpsMakePlanResponse"/></returns>
        public Task<CreateOpsMakePlanResponse> CreateOpsMakePlan(CreateOpsMakePlanRequest req)
        {
            return InternalRequestAsync<CreateOpsMakePlanResponse>(req, "CreateOpsMakePlan");
        }

        /// <summary>
        /// Bulk Data Supplement (Create Supplementary Entry Task)
        /// </summary>
        /// <param name="req"><see cref="CreateOpsMakePlanRequest"/></param>
        /// <returns><see cref="CreateOpsMakePlanResponse"/></returns>
        public CreateOpsMakePlanResponse CreateOpsMakePlanSync(CreateOpsMakePlanRequest req)
        {
            return InternalRequestAsync<CreateOpsMakePlanResponse>(req, "CreateOpsMakePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create quality rule interface
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// Create quality rule interface
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Rule Template
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public Task<CreateRuleTemplateResponse> CreateRuleTemplate(CreateRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateRuleTemplateResponse>(req, "CreateRuleTemplate");
        }

        /// <summary>
        /// Create Rule Template
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public CreateRuleTemplateResponse CreateRuleTemplateSync(CreateRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateRuleTemplateResponse>(req, "CreateRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating task
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// Creating task
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create task alert rules
        /// </summary>
        /// <param name="req"><see cref="CreateTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="CreateTaskAlarmRegularResponse"/></returns>
        public Task<CreateTaskAlarmRegularResponse> CreateTaskAlarmRegular(CreateTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<CreateTaskAlarmRegularResponse>(req, "CreateTaskAlarmRegular");
        }

        /// <summary>
        /// Create task alert rules
        /// </summary>
        /// <param name="req"><see cref="CreateTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="CreateTaskAlarmRegularResponse"/></returns>
        public CreateTaskAlarmRegularResponse CreateTaskAlarmRegularSync(CreateTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<CreateTaskAlarmRegularResponse>(req, "CreateTaskAlarmRegular")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Orchestration Space - Workflow - Create Task Folder
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFolderRequest"/></param>
        /// <returns><see cref="CreateTaskFolderResponse"/></returns>
        public Task<CreateTaskFolderResponse> CreateTaskFolder(CreateTaskFolderRequest req)
        {
            return InternalRequestAsync<CreateTaskFolderResponse>(req, "CreateTaskFolder");
        }

        /// <summary>
        /// Orchestration Space - Workflow - Create Task Folder
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFolderRequest"/></param>
        /// <returns><see cref="CreateTaskFolderResponse"/></returns>
        public CreateTaskFolderResponse CreateTaskFolderSync(CreateTaskFolderRequest req)
        {
            return InternalRequestAsync<CreateTaskFolderResponse>(req, "CreateTaskFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit Task Version
        /// </summary>
        /// <param name="req"><see cref="CreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="CreateTaskVersionDsResponse"/></returns>
        public Task<CreateTaskVersionDsResponse> CreateTaskVersionDs(CreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<CreateTaskVersionDsResponse>(req, "CreateTaskVersionDs");
        }

        /// <summary>
        /// Submit Task Version
        /// </summary>
        /// <param name="req"><see cref="CreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="CreateTaskVersionDsResponse"/></returns>
        public CreateTaskVersionDsResponse CreateTaskVersionDsSync(CreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<CreateTaskVersionDsResponse>(req, "CreateTaskVersionDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating workflow
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowDsRequest"/></param>
        /// <returns><see cref="CreateWorkflowDsResponse"/></returns>
        public Task<CreateWorkflowDsResponse> CreateWorkflowDs(CreateWorkflowDsRequest req)
        {
            return InternalRequestAsync<CreateWorkflowDsResponse>(req, "CreateWorkflowDs");
        }

        /// <summary>
        /// Creating workflow
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowDsRequest"/></param>
        /// <returns><see cref="CreateWorkflowDsResponse"/></returns>
        public CreateWorkflowDsResponse CreateWorkflowDsSync(CreateWorkflowDsRequest req)
        {
            return InternalRequestAsync<CreateWorkflowDsResponse>(req, "CreateWorkflowDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pull DAG Instance
        /// </summary>
        /// <param name="req"><see cref="DagInstancesRequest"/></param>
        /// <returns><see cref="DagInstancesResponse"/></returns>
        public Task<DagInstancesResponse> DagInstances(DagInstancesRequest req)
        {
            return InternalRequestAsync<DagInstancesResponse>(req, "DagInstances");
        }

        /// <summary>
        /// Pull DAG Instance
        /// </summary>
        /// <param name="req"><see cref="DagInstancesRequest"/></param>
        /// <returns><see cref="DagInstancesResponse"/></returns>
        public DagInstancesResponse DagInstancesSync(DagInstancesRequest req)
        {
            return InternalRequestAsync<DagInstancesResponse>(req, "DagInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete user-defined Definition functions
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomFunctionRequest"/></param>
        /// <returns><see cref="DeleteCustomFunctionResponse"/></returns>
        public Task<DeleteCustomFunctionResponse> DeleteCustomFunction(DeleteCustomFunctionRequest req)
        {
            return InternalRequestAsync<DeleteCustomFunctionResponse>(req, "DeleteCustomFunction");
        }

        /// <summary>
        /// Delete user-defined Definition functions
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomFunctionRequest"/></param>
        /// <returns><see cref="DeleteCustomFunctionResponse"/></returns>
        public DeleteCustomFunctionResponse DeleteCustomFunctionSync(DeleteCustomFunctionRequest req)
        {
            return InternalRequestAsync<DeleteCustomFunctionResponse>(req, "DeleteCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Data Source
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public Task<DeleteDataSourcesResponse> DeleteDataSources(DeleteDataSourcesRequest req)
        {
            return InternalRequestAsync<DeleteDataSourcesResponse>(req, "DeleteDataSources");
        }

        /// <summary>
        /// Delete Data Source
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public DeleteDataSourcesResponse DeleteDataSourcesSync(DeleteDataSourcesRequest req)
        {
            return InternalRequestAsync<DeleteDataSourcesResponse>(req, "DeleteDataSources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Orchestration space - delete folders
        /// </summary>
        /// <param name="req"><see cref="DeleteDsFolderRequest"/></param>
        /// <returns><see cref="DeleteDsFolderResponse"/></returns>
        public Task<DeleteDsFolderResponse> DeleteDsFolder(DeleteDsFolderRequest req)
        {
            return InternalRequestAsync<DeleteDsFolderResponse>(req, "DeleteDsFolder");
        }

        /// <summary>
        /// Orchestration space - delete folders
        /// </summary>
        /// <param name="req"><see cref="DeleteDsFolderRequest"/></param>
        /// <returns><see cref="DeleteDsFolderResponse"/></returns>
        public DeleteDsFolderResponse DeleteDsFolderSync(DeleteDsFolderRequest req)
        {
            return InternalRequestAsync<DeleteDsFolderResponse>(req, "DeleteDsFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete File
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public Task<DeleteFileResponse> DeleteFile(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile");
        }

        /// <summary>
        /// Delete File
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public DeleteFileResponse DeleteFileSync(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Development Space - Batch Delete Directories and Files
        /// </summary>
        /// <param name="req"><see cref="DeleteFilePathRequest"/></param>
        /// <returns><see cref="DeleteFilePathResponse"/></returns>
        public Task<DeleteFilePathResponse> DeleteFilePath(DeleteFilePathRequest req)
        {
            return InternalRequestAsync<DeleteFilePathResponse>(req, "DeleteFilePath");
        }

        /// <summary>
        /// Development Space - Batch Delete Directories and Files
        /// </summary>
        /// <param name="req"><see cref="DeleteFilePathRequest"/></param>
        /// <returns><see cref="DeleteFilePathResponse"/></returns>
        public DeleteFilePathResponse DeleteFilePathSync(DeleteFilePathRequest req)
        {
            return InternalRequestAsync<DeleteFilePathResponse>(req, "DeleteFilePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Integration Node
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationNodeRequest"/></param>
        /// <returns><see cref="DeleteIntegrationNodeResponse"/></returns>
        public Task<DeleteIntegrationNodeResponse> DeleteIntegrationNode(DeleteIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationNodeResponse>(req, "DeleteIntegrationNode");
        }

        /// <summary>
        /// Delete Integration Node
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationNodeRequest"/></param>
        /// <returns><see cref="DeleteIntegrationNodeResponse"/></returns>
        public DeleteIntegrationNodeResponse DeleteIntegrationNodeSync(DeleteIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationNodeResponse>(req, "DeleteIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete integration tasks
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationTaskRequest"/></param>
        /// <returns><see cref="DeleteIntegrationTaskResponse"/></returns>
        public Task<DeleteIntegrationTaskResponse> DeleteIntegrationTask(DeleteIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationTaskResponse>(req, "DeleteIntegrationTask");
        }

        /// <summary>
        /// Delete integration tasks
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationTaskRequest"/></param>
        /// <returns><see cref="DeleteIntegrationTaskResponse"/></returns>
        public DeleteIntegrationTaskResponse DeleteIntegrationTaskSync(DeleteIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationTaskResponse>(req, "DeleteIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deleting task
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineTaskRequest"/></param>
        /// <returns><see cref="DeleteOfflineTaskResponse"/></returns>
        public Task<DeleteOfflineTaskResponse> DeleteOfflineTask(DeleteOfflineTaskRequest req)
        {
            return InternalRequestAsync<DeleteOfflineTaskResponse>(req, "DeleteOfflineTask");
        }

        /// <summary>
        /// Deleting task
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineTaskRequest"/></param>
        /// <returns><see cref="DeleteOfflineTaskResponse"/></returns>
        public DeleteOfflineTaskResponse DeleteOfflineTaskSync(DeleteOfflineTaskRequest req)
        {
            return InternalRequestAsync<DeleteOfflineTaskResponse>(req, "DeleteOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Project Parameters
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectParamDsRequest"/></param>
        /// <returns><see cref="DeleteProjectParamDsResponse"/></returns>
        public Task<DeleteProjectParamDsResponse> DeleteProjectParamDs(DeleteProjectParamDsRequest req)
        {
            return InternalRequestAsync<DeleteProjectParamDsResponse>(req, "DeleteProjectParamDs");
        }

        /// <summary>
        /// Delete Project Parameters
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectParamDsRequest"/></param>
        /// <returns><see cref="DeleteProjectParamDsResponse"/></returns>
        public DeleteProjectParamDsResponse DeleteProjectParamDsSync(DeleteProjectParamDsRequest req)
        {
            return InternalRequestAsync<DeleteProjectParamDsResponse>(req, "DeleteProjectParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Project Users
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectUsersRequest"/></param>
        /// <returns><see cref="DeleteProjectUsersResponse"/></returns>
        public Task<DeleteProjectUsersResponse> DeleteProjectUsers(DeleteProjectUsersRequest req)
        {
            return InternalRequestAsync<DeleteProjectUsersResponse>(req, "DeleteProjectUsers");
        }

        /// <summary>
        /// Delete Project Users
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectUsersRequest"/></param>
        /// <returns><see cref="DeleteProjectUsersResponse"/></returns>
        public DeleteProjectUsersResponse DeleteProjectUsersSync(DeleteProjectUsersRequest req)
        {
            return InternalRequestAsync<DeleteProjectUsersResponse>(req, "DeleteProjectUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Remove resources in Resource Management
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceRequest"/></param>
        /// <returns><see cref="DeleteResourceResponse"/></returns>
        public Task<DeleteResourceResponse> DeleteResource(DeleteResourceRequest req)
        {
            return InternalRequestAsync<DeleteResourceResponse>(req, "DeleteResource");
        }

        /// <summary>
        /// Remove resources in Resource Management
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceRequest"/></param>
        /// <returns><see cref="DeleteResourceResponse"/></returns>
        public DeleteResourceResponse DeleteResourceSync(DeleteResourceRequest req)
        {
            return InternalRequestAsync<DeleteResourceResponse>(req, "DeleteResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Resource Management - Delete Resource File
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public Task<DeleteResourceFileResponse> DeleteResourceFile(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile");
        }

        /// <summary>
        /// Resource Management - Delete Resource File
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public DeleteResourceFileResponse DeleteResourceFileSync(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Resource Management-Batch Delete Resource Files
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFilesRequest"/></param>
        /// <returns><see cref="DeleteResourceFilesResponse"/></returns>
        public Task<DeleteResourceFilesResponse> DeleteResourceFiles(DeleteResourceFilesRequest req)
        {
            return InternalRequestAsync<DeleteResourceFilesResponse>(req, "DeleteResourceFiles");
        }

        /// <summary>
        /// Resource Management-Batch Delete Resource Files
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFilesRequest"/></param>
        /// <returns><see cref="DeleteResourceFilesResponse"/></returns>
        public DeleteResourceFilesResponse DeleteResourceFilesSync(DeleteResourceFilesRequest req)
        {
            return InternalRequestAsync<DeleteResourceFilesResponse>(req, "DeleteResourceFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Quality Rule Interface
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// Delete Quality Rule Interface
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deleting Rule Template
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public Task<DeleteRuleTemplateResponse> DeleteRuleTemplate(DeleteRuleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRuleTemplateResponse>(req, "DeleteRuleTemplate");
        }

        /// <summary>
        /// Deleting Rule Template
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public DeleteRuleTemplateResponse DeleteRuleTemplateSync(DeleteRuleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRuleTemplateResponse>(req, "DeleteRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Task Alert Rule
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="DeleteTaskAlarmRegularResponse"/></returns>
        public Task<DeleteTaskAlarmRegularResponse> DeleteTaskAlarmRegular(DeleteTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<DeleteTaskAlarmRegularResponse>(req, "DeleteTaskAlarmRegular");
        }

        /// <summary>
        /// Delete Task Alert Rule
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="DeleteTaskAlarmRegularResponse"/></returns>
        public DeleteTaskAlarmRegularResponse DeleteTaskAlarmRegularSync(DeleteTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<DeleteTaskAlarmRegularResponse>(req, "DeleteTaskAlarmRegular")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Orchestration Space Task
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskDsRequest"/></param>
        /// <returns><see cref="DeleteTaskDsResponse"/></returns>
        public Task<DeleteTaskDsResponse> DeleteTaskDs(DeleteTaskDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskDsResponse>(req, "DeleteTaskDs");
        }

        /// <summary>
        /// Delete Orchestration Space Task
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskDsRequest"/></param>
        /// <returns><see cref="DeleteTaskDsResponse"/></returns>
        public DeleteTaskDsResponse DeleteTaskDsSync(DeleteTaskDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskDsResponse>(req, "DeleteTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Workflow by Workflow Id
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowByIdRequest"/></param>
        /// <returns><see cref="DeleteWorkflowByIdResponse"/></returns>
        public Task<DeleteWorkflowByIdResponse> DeleteWorkflowById(DeleteWorkflowByIdRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowByIdResponse>(req, "DeleteWorkflowById");
        }

        /// <summary>
        /// Delete Workflow by Workflow Id
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowByIdRequest"/></param>
        /// <returns><see cref="DeleteWorkflowByIdResponse"/></returns>
        public DeleteWorkflowByIdResponse DeleteWorkflowByIdSync(DeleteWorkflowByIdRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowByIdResponse>(req, "DeleteWorkflowById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Alert event list
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents");
        }

        /// <summary>
        /// Alert event list
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Alert Recipient Details
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmReceiverRequest"/></param>
        /// <returns><see cref="DescribeAlarmReceiverResponse"/></returns>
        public Task<DescribeAlarmReceiverResponse> DescribeAlarmReceiver(DescribeAlarmReceiverRequest req)
        {
            return InternalRequestAsync<DescribeAlarmReceiverResponse>(req, "DescribeAlarmReceiver");
        }

        /// <summary>
        /// Alert Recipient Details
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmReceiverRequest"/></param>
        /// <returns><see cref="DescribeAlarmReceiverResponse"/></returns>
        public DescribeAlarmReceiverResponse DescribeAlarmReceiverSync(DescribeAlarmReceiverRequest req)
        {
            return InternalRequestAsync<DescribeAlarmReceiverResponse>(req, "DescribeAlarmReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all subfolders + workflows under the parent directory
        /// </summary>
        /// <param name="req"><see cref="DescribeAllByFolderNewRequest"/></param>
        /// <returns><see cref="DescribeAllByFolderNewResponse"/></returns>
        public Task<DescribeAllByFolderNewResponse> DescribeAllByFolderNew(DescribeAllByFolderNewRequest req)
        {
            return InternalRequestAsync<DescribeAllByFolderNewResponse>(req, "DescribeAllByFolderNew");
        }

        /// <summary>
        /// Query all subfolders + workflows under the parent directory
        /// </summary>
        /// <param name="req"><see cref="DescribeAllByFolderNewRequest"/></param>
        /// <returns><see cref="DescribeAllByFolderNewResponse"/></returns>
        public DescribeAllByFolderNewResponse DescribeAllByFolderNewSync(DescribeAllByFolderNewRequest req)
        {
            return InternalRequestAsync<DescribeAllByFolderNewResponse>(req, "DescribeAllByFolderNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Getting pending approval list
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveListRequest"/></param>
        /// <returns><see cref="DescribeApproveListResponse"/></returns>
        public Task<DescribeApproveListResponse> DescribeApproveList(DescribeApproveListRequest req)
        {
            return InternalRequestAsync<DescribeApproveListResponse>(req, "DescribeApproveList");
        }

        /// <summary>
        /// Getting pending approval list
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveListRequest"/></param>
        /// <returns><see cref="DescribeApproveListResponse"/></returns>
        public DescribeApproveListResponse DescribeApproveListSync(DescribeApproveListRequest req)
        {
            return InternalRequestAsync<DescribeApproveListResponse>(req, "DescribeApproveList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Approval Category List
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveTypeListRequest"/></param>
        /// <returns><see cref="DescribeApproveTypeListResponse"/></returns>
        public Task<DescribeApproveTypeListResponse> DescribeApproveTypeList(DescribeApproveTypeListRequest req)
        {
            return InternalRequestAsync<DescribeApproveTypeListResponse>(req, "DescribeApproveTypeList");
        }

        /// <summary>
        /// Get Approval Category List
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveTypeListRequest"/></param>
        /// <returns><see cref="DescribeApproveTypeListResponse"/></returns>
        public DescribeApproveTypeListResponse DescribeApproveTypeListSync(DescribeApproveTypeListRequest req)
        {
            return InternalRequestAsync<DescribeApproveTypeListResponse>(req, "DescribeApproveTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch operation page to retrieve task list
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperateTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchOperateTaskResponse"/></returns>
        public Task<DescribeBatchOperateTaskResponse> DescribeBatchOperateTask(DescribeBatchOperateTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperateTaskResponse>(req, "DescribeBatchOperateTask");
        }

        /// <summary>
        /// Batch operation page to retrieve task list
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperateTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchOperateTaskResponse"/></returns>
        public DescribeBatchOperateTaskResponse DescribeBatchOperateTaskSync(DescribeBatchOperateTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperateTaskResponse>(req, "DescribeBatchOperateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Field Lineage Information
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnLineageRequest"/></param>
        /// <returns><see cref="DescribeColumnLineageResponse"/></returns>
        public Task<DescribeColumnLineageResponse> DescribeColumnLineage(DescribeColumnLineageRequest req)
        {
            return InternalRequestAsync<DescribeColumnLineageResponse>(req, "DescribeColumnLineage");
        }

        /// <summary>
        /// List Field Lineage Information
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnLineageRequest"/></param>
        /// <returns><see cref="DescribeColumnLineageResponse"/></returns>
        public DescribeColumnLineageResponse DescribeColumnLineageSync(DescribeColumnLineageRequest req)
        {
            return InternalRequestAsync<DescribeColumnLineageResponse>(req, "DescribeColumnLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all column metadata of the table
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnsMetaRequest"/></param>
        /// <returns><see cref="DescribeColumnsMetaResponse"/></returns>
        public Task<DescribeColumnsMetaResponse> DescribeColumnsMeta(DescribeColumnsMetaRequest req)
        {
            return InternalRequestAsync<DescribeColumnsMetaResponse>(req, "DescribeColumnsMeta");
        }

        /// <summary>
        /// Query all column metadata of the table
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnsMetaRequest"/></param>
        /// <returns><see cref="DescribeColumnsMetaResponse"/></returns>
        public DescribeColumnsMetaResponse DescribeColumnsMetaSync(DescribeColumnsMetaRequest req)
        {
            return InternalRequestAsync<DescribeColumnsMetaResponse>(req, "DescribeColumnsMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Quality Overview Page Data Monitoring Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCheckStatRequest"/></param>
        /// <returns><see cref="DescribeDataCheckStatResponse"/></returns>
        public Task<DescribeDataCheckStatResponse> DescribeDataCheckStat(DescribeDataCheckStatRequest req)
        {
            return InternalRequestAsync<DescribeDataCheckStatResponse>(req, "DescribeDataCheckStat");
        }

        /// <summary>
        /// Data Quality Overview Page Data Monitoring Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCheckStatRequest"/></param>
        /// <returns><see cref="DescribeDataCheckStatResponse"/></returns>
        public DescribeDataCheckStatResponse DescribeDataCheckStatSync(DescribeDataCheckStatRequest req)
        {
            return InternalRequestAsync<DescribeDataCheckStatResponse>(req, "DescribeDataCheckStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Data Source Information - Data Source Pagination List
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceInfoListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceInfoListResponse"/></returns>
        public Task<DescribeDataSourceInfoListResponse> DescribeDataSourceInfoList(DescribeDataSourceInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceInfoListResponse>(req, "DescribeDataSourceInfoList");
        }

        /// <summary>
        /// Obtain Data Source Information - Data Source Pagination List
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceInfoListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceInfoListResponse"/></returns>
        public DescribeDataSourceInfoListResponse DescribeDataSourceInfoListSync(DescribeDataSourceInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceInfoListResponse>(req, "DescribeDataSourceInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Source Details
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public Task<DescribeDataSourceListResponse> DescribeDataSourceList(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList");
        }

        /// <summary>
        /// Data Source Details
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public DescribeDataSourceListResponse DescribeDataSourceListSync(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Database Information
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseInfoListRequest"/></param>
        /// <returns><see cref="DescribeDatabaseInfoListResponse"/></returns>
        public Task<DescribeDatabaseInfoListResponse> DescribeDatabaseInfoList(DescribeDatabaseInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseInfoListResponse>(req, "DescribeDatabaseInfoList");
        }

        /// <summary>
        /// Obtain Database Information
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseInfoListRequest"/></param>
        /// <returns><see cref="DescribeDatabaseInfoListResponse"/></returns>
        public DescribeDatabaseInfoListResponse DescribeDatabaseInfoListSync(DescribeDatabaseInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseInfoListResponse>(req, "DescribeDatabaseInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying database list
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseMetasRequest"/></param>
        /// <returns><see cref="DescribeDatabaseMetasResponse"/></returns>
        public Task<DescribeDatabaseMetasResponse> DescribeDatabaseMetas(DescribeDatabaseMetasRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseMetasResponse>(req, "DescribeDatabaseMetas");
        }

        /// <summary>
        /// Querying database list
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseMetasRequest"/></param>
        /// <returns><see cref="DescribeDatabaseMetasResponse"/></returns>
        public DescribeDatabaseMetasResponse DescribeDatabaseMetasSync(DescribeDatabaseMetasRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseMetasResponse>(req, "DescribeDatabaseMetas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Source Details
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public Task<DescribeDatasourceResponse> DescribeDatasource(DescribeDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceResponse>(req, "DescribeDatasource");
        }

        /// <summary>
        /// Data Source Details
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public DescribeDatasourceResponse DescribeDatasourceSync(DescribeDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceResponse>(req, "DescribeDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Search for upstream/downstream task nodes by hierarchy
        /// </summary>
        /// <param name="req"><see cref="DescribeDependOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeDependOpsTasksResponse"/></returns>
        public Task<DescribeDependOpsTasksResponse> DescribeDependOpsTasks(DescribeDependOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeDependOpsTasksResponse>(req, "DescribeDependOpsTasks");
        }

        /// <summary>
        /// Search for upstream/downstream task nodes by hierarchy
        /// </summary>
        /// <param name="req"><see cref="DescribeDependOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeDependOpsTasksResponse"/></returns>
        public DescribeDependOpsTasksResponse DescribeDependOpsTasksSync(DescribeDependOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeDependOpsTasksResponse>(req, "DescribeDependOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Task Detail List by taskIds
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTaskListsRequest"/></param>
        /// <returns><see cref="DescribeDependTaskListsResponse"/></returns>
        public Task<DescribeDependTaskListsResponse> DescribeDependTaskLists(DescribeDependTaskListsRequest req)
        {
            return InternalRequestAsync<DescribeDependTaskListsResponse>(req, "DescribeDependTaskLists");
        }

        /// <summary>
        /// Query Task Detail List by taskIds
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTaskListsRequest"/></param>
        /// <returns><see cref="DescribeDependTaskListsResponse"/></returns>
        public DescribeDependTaskListsResponse DescribeDependTaskListsSync(DescribeDependTaskListsRequest req)
        {
            return InternalRequestAsync<DescribeDependTaskListsResponse>(req, "DescribeDependTaskLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Quality Report - Query Quality Score
        /// </summary>
        /// <param name="req"><see cref="DescribeDimensionScoreRequest"/></param>
        /// <returns><see cref="DescribeDimensionScoreResponse"/></returns>
        public Task<DescribeDimensionScoreResponse> DescribeDimensionScore(DescribeDimensionScoreRequest req)
        {
            return InternalRequestAsync<DescribeDimensionScoreResponse>(req, "DescribeDimensionScore");
        }

        /// <summary>
        /// Quality Report - Query Quality Score
        /// </summary>
        /// <param name="req"><see cref="DescribeDimensionScoreRequest"/></param>
        /// <returns><see cref="DescribeDimensionScoreResponse"/></returns>
        public DescribeDimensionScoreResponse DescribeDimensionScoreSync(DescribeDimensionScoreRequest req)
        {
            return InternalRequestAsync<DescribeDimensionScoreResponse>(req, "DescribeDimensionScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Paginated Query of Trial Run Instance List
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstancePageRequest"/></param>
        /// <returns><see cref="DescribeDrInstancePageResponse"/></returns>
        public Task<DescribeDrInstancePageResponse> DescribeDrInstancePage(DescribeDrInstancePageRequest req)
        {
            return InternalRequestAsync<DescribeDrInstancePageResponse>(req, "DescribeDrInstancePage");
        }

        /// <summary>
        /// Paginated Query of Trial Run Instance List
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstancePageRequest"/></param>
        /// <returns><see cref="DescribeDrInstancePageResponse"/></returns>
        public DescribeDrInstancePageResponse DescribeDrInstancePageSync(DescribeDrInstancePageRequest req)
        {
            return InternalRequestAsync<DescribeDrInstancePageResponse>(req, "DescribeDrInstancePage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Directory Tree
        /// </summary>
        /// <param name="req"><see cref="DescribeDsFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsFolderTreeResponse"/></returns>
        public Task<DescribeDsFolderTreeResponse> DescribeDsFolderTree(DescribeDsFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsFolderTreeResponse>(req, "DescribeDsFolderTree");
        }

        /// <summary>
        /// Query Directory Tree
        /// </summary>
        /// <param name="req"><see cref="DescribeDsFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsFolderTreeResponse"/></returns>
        public DescribeDsFolderTreeResponse DescribeDsFolderTreeSync(DescribeDsFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsFolderTreeResponse>(req, "DescribeDsFolderTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Parent Directory Tree, for Workflow, Task Localization
        /// </summary>
        /// <param name="req"><see cref="DescribeDsParentFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsParentFolderTreeResponse"/></returns>
        public Task<DescribeDsParentFolderTreeResponse> DescribeDsParentFolderTree(DescribeDsParentFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsParentFolderTreeResponse>(req, "DescribeDsParentFolderTree");
        }

        /// <summary>
        /// Query Parent Directory Tree, for Workflow, Task Localization
        /// </summary>
        /// <param name="req"><see cref="DescribeDsParentFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsParentFolderTreeResponse"/></returns>
        public DescribeDsParentFolderTreeResponse DescribeDsParentFolderTreeSync(DescribeDsParentFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsParentFolderTreeResponse>(req, "DescribeDsParentFolderTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View Event Details by Project ID and Event Name
        /// </summary>
        /// <param name="req"><see cref="DescribeEventRequest"/></param>
        /// <returns><see cref="DescribeEventResponse"/></returns>
        public Task<DescribeEventResponse> DescribeEvent(DescribeEventRequest req)
        {
            return InternalRequestAsync<DescribeEventResponse>(req, "DescribeEvent");
        }

        /// <summary>
        /// View Event Details by Project ID and Event Name
        /// </summary>
        /// <param name="req"><see cref="DescribeEventRequest"/></param>
        /// <returns><see cref="DescribeEventResponse"/></returns>
        public DescribeEventResponse DescribeEventSync(DescribeEventRequest req)
        {
            return InternalRequestAsync<DescribeEventResponse>(req, "DescribeEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Find Event Instances Based on Conditions
        /// </summary>
        /// <param name="req"><see cref="DescribeEventCasesRequest"/></param>
        /// <returns><see cref="DescribeEventCasesResponse"/></returns>
        public Task<DescribeEventCasesResponse> DescribeEventCases(DescribeEventCasesRequest req)
        {
            return InternalRequestAsync<DescribeEventCasesResponse>(req, "DescribeEventCases");
        }

        /// <summary>
        /// Find Event Instances Based on Conditions
        /// </summary>
        /// <param name="req"><see cref="DescribeEventCasesRequest"/></param>
        /// <returns><see cref="DescribeEventCasesResponse"/></returns>
        public DescribeEventCasesResponse DescribeEventCasesSync(DescribeEventCasesRequest req)
        {
            return InternalRequestAsync<DescribeEventCasesResponse>(req, "DescribeEventCases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Viewing consumption tasks of event instances
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConsumeTasksRequest"/></param>
        /// <returns><see cref="DescribeEventConsumeTasksResponse"/></returns>
        public Task<DescribeEventConsumeTasksResponse> DescribeEventConsumeTasks(DescribeEventConsumeTasksRequest req)
        {
            return InternalRequestAsync<DescribeEventConsumeTasksResponse>(req, "DescribeEventConsumeTasks");
        }

        /// <summary>
        /// Viewing consumption tasks of event instances
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConsumeTasksRequest"/></param>
        /// <returns><see cref="DescribeEventConsumeTasksResponse"/></returns>
        public DescribeEventConsumeTasksResponse DescribeEventConsumeTasksSync(DescribeEventConsumeTasksRequest req)
        {
            return InternalRequestAsync<DescribeEventConsumeTasksResponse>(req, "DescribeEventConsumeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Rule Group Execution Policy
        /// </summary>
        /// <param name="req"><see cref="DescribeExecStrategyRequest"/></param>
        /// <returns><see cref="DescribeExecStrategyResponse"/></returns>
        public Task<DescribeExecStrategyResponse> DescribeExecStrategy(DescribeExecStrategyRequest req)
        {
            return InternalRequestAsync<DescribeExecStrategyResponse>(req, "DescribeExecStrategy");
        }

        /// <summary>
        /// Query Rule Group Execution Policy
        /// </summary>
        /// <param name="req"><see cref="DescribeExecStrategyRequest"/></param>
        /// <returns><see cref="DescribeExecStrategyResponse"/></returns>
        public DescribeExecStrategyResponse DescribeExecStrategySync(DescribeExecStrategyRequest req)
        {
            return InternalRequestAsync<DescribeExecStrategyResponse>(req, "DescribeExecStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Metadata Model - Field Basic Information Query Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeFieldBasicInfoResponse"/></returns>
        public Task<DescribeFieldBasicInfoResponse> DescribeFieldBasicInfo(DescribeFieldBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeFieldBasicInfoResponse>(req, "DescribeFieldBasicInfo");
        }

        /// <summary>
        /// Metadata Model - Field Basic Information Query Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeFieldBasicInfoResponse"/></returns>
        public DescribeFieldBasicInfoResponse DescribeFieldBasicInfoSync(DescribeFieldBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeFieldBasicInfoResponse>(req, "DescribeFieldBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all workflow lists under the project by Project ID
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public Task<DescribeFolderWorkflowListResponse> DescribeFolderWorkflowList(DescribeFolderWorkflowListRequest req)
        {
            return InternalRequestAsync<DescribeFolderWorkflowListResponse>(req, "DescribeFolderWorkflowList");
        }

        /// <summary>
        /// Get all workflow lists under the project by Project ID
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public DescribeFolderWorkflowListResponse DescribeFolderWorkflowListSync(DescribeFolderWorkflowListRequest req)
        {
            return InternalRequestAsync<DescribeFolderWorkflowListResponse>(req, "DescribeFolderWorkflowList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Function Classification
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionKindsRequest"/></param>
        /// <returns><see cref="DescribeFunctionKindsResponse"/></returns>
        public Task<DescribeFunctionKindsResponse> DescribeFunctionKinds(DescribeFunctionKindsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionKindsResponse>(req, "DescribeFunctionKinds");
        }

        /// <summary>
        /// Query Function Classification
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionKindsRequest"/></param>
        /// <returns><see cref="DescribeFunctionKindsResponse"/></returns>
        public DescribeFunctionKindsResponse DescribeFunctionKindsSync(DescribeFunctionKindsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionKindsResponse>(req, "DescribeFunctionKinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Function Type
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionTypesRequest"/></param>
        /// <returns><see cref="DescribeFunctionTypesResponse"/></returns>
        public Task<DescribeFunctionTypesResponse> DescribeFunctionTypes(DescribeFunctionTypesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionTypesResponse>(req, "DescribeFunctionTypes");
        }

        /// <summary>
        /// Query Function Type
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionTypesRequest"/></param>
        /// <returns><see cref="DescribeFunctionTypesResponse"/></returns>
        public DescribeFunctionTypesResponse DescribeFunctionTypesSync(DescribeFunctionTypesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionTypesResponse>(req, "DescribeFunctionTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all instances by cycle type
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByCycleRequest"/></param>
        /// <returns><see cref="DescribeInstanceByCycleResponse"/></returns>
        public Task<DescribeInstanceByCycleResponse> DescribeInstanceByCycle(DescribeInstanceByCycleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByCycleResponse>(req, "DescribeInstanceByCycle");
        }

        /// <summary>
        /// Query all instances by cycle type
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByCycleRequest"/></param>
        /// <returns><see cref="DescribeInstanceByCycleResponse"/></returns>
        public DescribeInstanceByCycleResponse DescribeInstanceByCycleSync(DescribeInstanceByCycleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByCycleResponse>(req, "DescribeInstanceByCycle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Log Detail Acquisition Page
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLastLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLastLogResponse"/></returns>
        public Task<DescribeInstanceLastLogResponse> DescribeInstanceLastLog(DescribeInstanceLastLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLastLogResponse>(req, "DescribeInstanceLastLog");
        }

        /// <summary>
        /// Log Detail Acquisition Page
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLastLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLastLogResponse"/></returns>
        public DescribeInstanceLastLogResponse DescribeInstanceLastLogSync(DescribeInstanceLastLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLastLogResponse>(req, "DescribeInstanceLastLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Instance List
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// Get Instance List
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Instance Running Logs
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogResponse"/></returns>
        public Task<DescribeInstanceLogResponse> DescribeInstanceLog(DescribeInstanceLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogResponse>(req, "DescribeInstanceLog");
        }

        /// <summary>
        /// Get Instance Running Logs
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogResponse"/></returns>
        public DescribeInstanceLogResponse DescribeInstanceLogSync(DescribeInstanceLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogResponse>(req, "DescribeInstanceLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Specific Instance-related Log Information
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogDetailResponse"/></returns>
        public Task<DescribeInstanceLogDetailResponse> DescribeInstanceLogDetail(DescribeInstanceLogDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogDetailResponse>(req, "DescribeInstanceLogDetail");
        }

        /// <summary>
        /// Obtain Specific Instance-related Log Information
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogDetailResponse"/></returns>
        public DescribeInstanceLogDetailResponse DescribeInstanceLogDetailSync(DescribeInstanceLogDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogDetailResponse>(req, "DescribeInstanceLogDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Download Log File, Return Log Download URL
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogFileRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogFileResponse"/></returns>
        public Task<DescribeInstanceLogFileResponse> DescribeInstanceLogFile(DescribeInstanceLogFileRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogFileResponse>(req, "DescribeInstanceLogFile");
        }

        /// <summary>
        /// Download Log File, Return Log Download URL
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogFileRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogFileResponse"/></returns>
        public DescribeInstanceLogFileResponse DescribeInstanceLogFileSync(DescribeInstanceLogFileRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogFileResponse>(req, "DescribeInstanceLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Offline Task Instance Run Log List
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogListResponse"/></returns>
        public Task<DescribeInstanceLogListResponse> DescribeInstanceLogList(DescribeInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogListResponse>(req, "DescribeInstanceLogList");
        }

        /// <summary>
        /// Offline Task Instance Run Log List
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogListResponse"/></returns>
        public DescribeInstanceLogListResponse DescribeInstanceLogListSync(DescribeInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogListResponse>(req, "DescribeInstanceLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query integrated nodes
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationNodeRequest"/></param>
        /// <returns><see cref="DescribeIntegrationNodeResponse"/></returns>
        public Task<DescribeIntegrationNodeResponse> DescribeIntegrationNode(DescribeIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationNodeResponse>(req, "DescribeIntegrationNode");
        }

        /// <summary>
        /// Query integrated nodes
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationNodeRequest"/></param>
        /// <returns><see cref="DescribeIntegrationNodeResponse"/></returns>
        public DescribeIntegrationNodeResponse DescribeIntegrationNodeSync(DescribeIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationNodeResponse>(req, "DescribeIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DataInLong Dashboard Overview
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsResponse"/></returns>
        public Task<DescribeIntegrationStatisticsResponse> DescribeIntegrationStatistics(DescribeIntegrationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsResponse>(req, "DescribeIntegrationStatistics");
        }

        /// <summary>
        /// DataInLong Dashboard Overview
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsResponse"/></returns>
        public DescribeIntegrationStatisticsResponse DescribeIntegrationStatisticsSync(DescribeIntegrationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsResponse>(req, "DescribeIntegrationStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DataInLong dashboard instance status statistical trend
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsInstanceTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsInstanceTrendResponse"/></returns>
        public Task<DescribeIntegrationStatisticsInstanceTrendResponse> DescribeIntegrationStatisticsInstanceTrend(DescribeIntegrationStatisticsInstanceTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsInstanceTrendResponse>(req, "DescribeIntegrationStatisticsInstanceTrend");
        }

        /// <summary>
        /// DataInLong dashboard instance status statistical trend
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsInstanceTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsInstanceTrendResponse"/></returns>
        public DescribeIntegrationStatisticsInstanceTrendResponse DescribeIntegrationStatisticsInstanceTrendSync(DescribeIntegrationStatisticsInstanceTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsInstanceTrendResponse>(req, "DescribeIntegrationStatisticsInstanceTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DataInLong Dashboard synchronization count trend
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRecordsTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsRecordsTrendResponse"/></returns>
        public Task<DescribeIntegrationStatisticsRecordsTrendResponse> DescribeIntegrationStatisticsRecordsTrend(DescribeIntegrationStatisticsRecordsTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsRecordsTrendResponse>(req, "DescribeIntegrationStatisticsRecordsTrend");
        }

        /// <summary>
        /// DataInLong Dashboard synchronization count trend
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRecordsTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsRecordsTrendResponse"/></returns>
        public DescribeIntegrationStatisticsRecordsTrendResponse DescribeIntegrationStatisticsRecordsTrendSync(DescribeIntegrationStatisticsRecordsTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsRecordsTrendResponse>(req, "DescribeIntegrationStatisticsRecordsTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DataInLong Dashboard Task Status Distribution Statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusResponse"/></returns>
        public Task<DescribeIntegrationStatisticsTaskStatusResponse> DescribeIntegrationStatisticsTaskStatus(DescribeIntegrationStatisticsTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusResponse>(req, "DescribeIntegrationStatisticsTaskStatus");
        }

        /// <summary>
        /// DataInLong Dashboard Task Status Distribution Statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusResponse"/></returns>
        public DescribeIntegrationStatisticsTaskStatusResponse DescribeIntegrationStatisticsTaskStatusSync(DescribeIntegrationStatisticsTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusResponse>(req, "DescribeIntegrationStatisticsTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DataInLong Dashboard Task Status Statistical Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusTrendResponse"/></returns>
        public Task<DescribeIntegrationStatisticsTaskStatusTrendResponse> DescribeIntegrationStatisticsTaskStatusTrend(DescribeIntegrationStatisticsTaskStatusTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusTrendResponse>(req, "DescribeIntegrationStatisticsTaskStatusTrend");
        }

        /// <summary>
        /// DataInLong Dashboard Task Status Statistical Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusTrendResponse"/></returns>
        public DescribeIntegrationStatisticsTaskStatusTrendResponse DescribeIntegrationStatisticsTaskStatusTrendSync(DescribeIntegrationStatisticsTaskStatusTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusTrendResponse>(req, "DescribeIntegrationStatisticsTaskStatusTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query integration tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTaskResponse"/></returns>
        public Task<DescribeIntegrationTaskResponse> DescribeIntegrationTask(DescribeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTaskResponse>(req, "DescribeIntegrationTask");
        }

        /// <summary>
        /// Query integration tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTaskResponse"/></returns>
        public DescribeIntegrationTaskResponse DescribeIntegrationTaskSync(DescribeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTaskResponse>(req, "DescribeIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Integration Task List
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTasksRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTasksResponse"/></returns>
        public Task<DescribeIntegrationTasksResponse> DescribeIntegrationTasks(DescribeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTasksResponse>(req, "DescribeIntegrationTasks");
        }

        /// <summary>
        /// Query Integration Task List
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTasksRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTasksResponse"/></returns>
        public DescribeIntegrationTasksResponse DescribeIntegrationTasksSync(DescribeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTasksResponse>(req, "DescribeIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Integration Task Version Node Information
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationVersionNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeIntegrationVersionNodesInfoResponse"/></returns>
        public Task<DescribeIntegrationVersionNodesInfoResponse> DescribeIntegrationVersionNodesInfo(DescribeIntegrationVersionNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationVersionNodesInfoResponse>(req, "DescribeIntegrationVersionNodesInfo");
        }

        /// <summary>
        /// Query Integration Task Version Node Information
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationVersionNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeIntegrationVersionNodesInfoResponse"/></returns>
        public DescribeIntegrationVersionNodesInfoResponse DescribeIntegrationVersionNodesInfoSync(DescribeIntegrationVersionNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationVersionNodesInfoResponse>(req, "DescribeIntegrationVersionNodesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Getting long connection Token for offline tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineTaskTokenRequest"/></param>
        /// <returns><see cref="DescribeOfflineTaskTokenResponse"/></returns>
        public Task<DescribeOfflineTaskTokenResponse> DescribeOfflineTaskToken(DescribeOfflineTaskTokenRequest req)
        {
            return InternalRequestAsync<DescribeOfflineTaskTokenResponse>(req, "DescribeOfflineTaskToken");
        }

        /// <summary>
        /// Getting long connection Token for offline tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineTaskTokenRequest"/></param>
        /// <returns><see cref="DescribeOfflineTaskTokenResponse"/></returns>
        public DescribeOfflineTaskTokenResponse DescribeOfflineTaskTokenSync(DescribeOfflineTaskTokenRequest req)
        {
            return InternalRequestAsync<DescribeOfflineTaskTokenResponse>(req, "DescribeOfflineTaskToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Operation and Maintenance List Combined Condition Query
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTasksResponse"/></returns>
        public Task<DescribeOperateOpsTasksResponse> DescribeOperateOpsTasks(DescribeOperateOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTasksResponse>(req, "DescribeOperateOpsTasks");
        }

        /// <summary>
        /// Task Operation and Maintenance List Combined Condition Query
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTasksResponse"/></returns>
        public DescribeOperateOpsTasksResponse DescribeOperateOpsTasksSync(DescribeOperateOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTasksResponse>(req, "DescribeOperateOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Instance Operation and Maintenance - Get Instance Log List
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeOpsInstanceLogListResponse"/></returns>
        public Task<DescribeOpsInstanceLogListResponse> DescribeOpsInstanceLogList(DescribeOpsInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeOpsInstanceLogListResponse>(req, "DescribeOpsInstanceLogList");
        }

        /// <summary>
        /// Instance Operation and Maintenance - Get Instance Log List
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeOpsInstanceLogListResponse"/></returns>
        public DescribeOpsInstanceLogListResponse DescribeOpsInstanceLogListSync(DescribeOpsInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeOpsInstanceLogListResponse>(req, "DescribeOpsInstanceLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the Supplementary Instance List based on the Supplementary Plan and Task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanInstancesResponse"/></returns>
        public Task<DescribeOpsMakePlanInstancesResponse> DescribeOpsMakePlanInstances(DescribeOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanInstancesResponse>(req, "DescribeOpsMakePlanInstances");
        }

        /// <summary>
        /// Obtain the Supplementary Instance List based on the Supplementary Plan and Task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanInstancesResponse"/></returns>
        public DescribeOpsMakePlanInstancesResponse DescribeOpsMakePlanInstancesSync(DescribeOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanInstancesResponse>(req, "DescribeOpsMakePlanInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View Supplemental Plan Tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanTasksRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanTasksResponse"/></returns>
        public Task<DescribeOpsMakePlanTasksResponse> DescribeOpsMakePlanTasks(DescribeOpsMakePlanTasksRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanTasksResponse>(req, "DescribeOpsMakePlanTasks");
        }

        /// <summary>
        /// View Supplemental Plan Tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanTasksRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanTasksResponse"/></returns>
        public DescribeOpsMakePlanTasksResponse DescribeOpsMakePlanTasksSync(DescribeOpsMakePlanTasksRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanTasksResponse>(req, "DescribeOpsMakePlanTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Paginated Query of Supplement Plan Based on Conditions
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlansRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlansResponse"/></returns>
        public Task<DescribeOpsMakePlansResponse> DescribeOpsMakePlans(DescribeOpsMakePlansRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlansResponse>(req, "DescribeOpsMakePlans");
        }

        /// <summary>
        /// Paginated Query of Supplement Plan Based on Conditions
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlansRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlansResponse"/></returns>
        public DescribeOpsMakePlansResponse DescribeOpsMakePlansSync(DescribeOpsMakePlansRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlansResponse>(req, "DescribeOpsMakePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying User Production Workflow List
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeOpsWorkflowsResponse"/></returns>
        public Task<DescribeOpsWorkflowsResponse> DescribeOpsWorkflows(DescribeOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeOpsWorkflowsResponse>(req, "DescribeOpsWorkflows");
        }

        /// <summary>
        /// Querying User Production Workflow List
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeOpsWorkflowsResponse"/></returns>
        public DescribeOpsWorkflowsResponse DescribeOpsWorkflowsSync(DescribeOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeOpsWorkflowsResponse>(req, "DescribeOpsWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Full Functionality
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationalFunctionsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationalFunctionsResponse"/></returns>
        public Task<DescribeOrganizationalFunctionsResponse> DescribeOrganizationalFunctions(DescribeOrganizationalFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationalFunctionsResponse>(req, "DescribeOrganizationalFunctions");
        }

        /// <summary>
        /// Query Full Functionality
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationalFunctionsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationalFunctionsResponse"/></returns>
        public DescribeOrganizationalFunctionsResponse DescribeOrganizationalFunctionsSync(DescribeOrganizationalFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationalFunctionsResponse>(req, "DescribeOrganizationalFunctions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieving Project Information
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject");
        }

        /// <summary>
        /// Retrieving Project Information
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Quality Report - Quality Score
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public Task<DescribeQualityScoreResponse> DescribeQualityScore(DescribeQualityScoreRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreResponse>(req, "DescribeQualityScore");
        }

        /// <summary>
        /// Quality Report - Quality Score
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public DescribeQualityScoreResponse DescribeQualityScoreSync(DescribeQualityScoreRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreResponse>(req, "DescribeQualityScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Quality Report - Quality Score Periodic Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreTrendResponse"/></returns>
        public Task<DescribeQualityScoreTrendResponse> DescribeQualityScoreTrend(DescribeQualityScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreTrendResponse>(req, "DescribeQualityScoreTrend");
        }

        /// <summary>
        /// Quality Report - Quality Score Periodic Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreTrendResponse"/></returns>
        public DescribeQualityScoreTrendResponse DescribeQualityScoreTrendSync(DescribeQualityScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreTrendResponse>(req, "DescribeQualityScoreTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Real-time Task Instance Node Information
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskInstanceNodeInfoResponse"/></returns>
        public Task<DescribeRealTimeTaskInstanceNodeInfoResponse> DescribeRealTimeTaskInstanceNodeInfo(DescribeRealTimeTaskInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskInstanceNodeInfoResponse>(req, "DescribeRealTimeTaskInstanceNodeInfo");
        }

        /// <summary>
        /// Query Real-time Task Instance Node Information
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskInstanceNodeInfoResponse"/></returns>
        public DescribeRealTimeTaskInstanceNodeInfoResponse DescribeRealTimeTaskInstanceNodeInfoSync(DescribeRealTimeTaskInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskInstanceNodeInfoResponse>(req, "DescribeRealTimeTaskInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Real-time Task Running Metrics Overview
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskMetricOverviewResponse"/></returns>
        public Task<DescribeRealTimeTaskMetricOverviewResponse> DescribeRealTimeTaskMetricOverview(DescribeRealTimeTaskMetricOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskMetricOverviewResponse>(req, "DescribeRealTimeTaskMetricOverview");
        }

        /// <summary>
        /// Real-time Task Running Metrics Overview
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskMetricOverviewResponse"/></returns>
        public DescribeRealTimeTaskMetricOverviewResponse DescribeRealTimeTaskMetricOverviewSync(DescribeRealTimeTaskMetricOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskMetricOverviewResponse>(req, "DescribeRealTimeTaskMetricOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Real-time task synchronization speed trend
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskSpeedRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskSpeedResponse"/></returns>
        public Task<DescribeRealTimeTaskSpeedResponse> DescribeRealTimeTaskSpeed(DescribeRealTimeTaskSpeedRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskSpeedResponse>(req, "DescribeRealTimeTaskSpeed");
        }

        /// <summary>
        /// Real-time task synchronization speed trend
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskSpeedRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskSpeedResponse"/></returns>
        public DescribeRealTimeTaskSpeedResponse DescribeRealTimeTaskSpeedSync(DescribeRealTimeTaskSpeedRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskSpeedResponse>(req, "DescribeRealTimeTaskSpeed")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve resource management directory tree
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceManagePathTreesRequest"/></param>
        /// <returns><see cref="DescribeResourceManagePathTreesResponse"/></returns>
        public Task<DescribeResourceManagePathTreesResponse> DescribeResourceManagePathTrees(DescribeResourceManagePathTreesRequest req)
        {
            return InternalRequestAsync<DescribeResourceManagePathTreesResponse>(req, "DescribeResourceManagePathTrees");
        }

        /// <summary>
        /// Retrieve resource management directory tree
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceManagePathTreesRequest"/></param>
        /// <returns><see cref="DescribeResourceManagePathTreesResponse"/></returns>
        public DescribeResourceManagePathTreesResponse DescribeResourceManagePathTreesSync(DescribeResourceManagePathTreesRequest req)
        {
            return InternalRequestAsync<DescribeResourceManagePathTreesResponse>(req, "DescribeResourceManagePathTrees")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries rule details
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public Task<DescribeRuleResponse> DescribeRule(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule");
        }

        /// <summary>
        /// Queries rule details
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public DescribeRuleResponse DescribeRuleSync(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Quality Overview Page Triggers Dimension Distribution Statistics Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDimStatRequest"/></param>
        /// <returns><see cref="DescribeRuleDimStatResponse"/></returns>
        public Task<DescribeRuleDimStatResponse> DescribeRuleDimStat(DescribeRuleDimStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleDimStatResponse>(req, "DescribeRuleDimStat");
        }

        /// <summary>
        /// Data Quality Overview Page Triggers Dimension Distribution Statistics Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDimStatRequest"/></param>
        /// <returns><see cref="DescribeRuleDimStatResponse"/></returns>
        public DescribeRuleDimStatResponse DescribeRuleDimStatSync(DescribeRuleDimStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleDimStatResponse>(req, "DescribeRuleDimStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Rule Execution Result Details
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleExecDetailResponse"/></returns>
        public Task<DescribeRuleExecDetailResponse> DescribeRuleExecDetail(DescribeRuleExecDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecDetailResponse>(req, "DescribeRuleExecDetail");
        }

        /// <summary>
        /// Query Rule Execution Result Details
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleExecDetailResponse"/></returns>
        public DescribeRuleExecDetailResponse DescribeRuleExecDetailSync(DescribeRuleExecDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecDetailResponse>(req, "DescribeRuleExecDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rule Execution Log Query
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecLogRequest"/></param>
        /// <returns><see cref="DescribeRuleExecLogResponse"/></returns>
        public Task<DescribeRuleExecLogResponse> DescribeRuleExecLog(DescribeRuleExecLogRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecLogResponse>(req, "DescribeRuleExecLog");
        }

        /// <summary>
        /// Rule Execution Log Query
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecLogRequest"/></param>
        /// <returns><see cref="DescribeRuleExecLogResponse"/></returns>
        public DescribeRuleExecLogResponse DescribeRuleExecLogSync(DescribeRuleExecLogRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecLogResponse>(req, "DescribeRuleExecLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Rule Execution Result List
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsResponse"/></returns>
        public Task<DescribeRuleExecResultsResponse> DescribeRuleExecResults(DescribeRuleExecResultsRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecResultsResponse>(req, "DescribeRuleExecResults");
        }

        /// <summary>
        /// Query Rule Execution Result List
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsResponse"/></returns>
        public DescribeRuleExecResultsResponse DescribeRuleExecResultsSync(DescribeRuleExecResultsRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecResultsResponse>(req, "DescribeRuleExecResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Quality Overview Page Rule Operation Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecStatRequest"/></param>
        /// <returns><see cref="DescribeRuleExecStatResponse"/></returns>
        public Task<DescribeRuleExecStatResponse> DescribeRuleExecStat(DescribeRuleExecStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecStatResponse>(req, "DescribeRuleExecStat");
        }

        /// <summary>
        /// Data Quality Overview Page Rule Operation Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecStatRequest"/></param>
        /// <returns><see cref="DescribeRuleExecStatResponse"/></returns>
        public DescribeRuleExecStatResponse DescribeRuleExecStatSync(DescribeRuleExecStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecStatResponse>(req, "DescribeRuleExecStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Rule Group Details Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupResponse"/></returns>
        public Task<DescribeRuleGroupResponse> DescribeRuleGroup(DescribeRuleGroupRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupResponse>(req, "DescribeRuleGroup");
        }

        /// <summary>
        /// Query Rule Group Details Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupResponse"/></returns>
        public DescribeRuleGroupResponse DescribeRuleGroupSync(DescribeRuleGroupRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupResponse>(req, "DescribeRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rule Group Execution Result Pagination Query Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageResponse"/></returns>
        public Task<DescribeRuleGroupExecResultsByPageResponse> DescribeRuleGroupExecResultsByPage(DescribeRuleGroupExecResultsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupExecResultsByPageResponse>(req, "DescribeRuleGroupExecResultsByPage");
        }

        /// <summary>
        /// Rule Group Execution Result Pagination Query Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageResponse"/></returns>
        public DescribeRuleGroupExecResultsByPageResponse DescribeRuleGroupExecResultsByPageSync(DescribeRuleGroupExecResultsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupExecResultsByPageResponse>(req, "DescribeRuleGroupExecResultsByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Rule Group Subscription Information
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupSubscriptionResponse"/></returns>
        public Task<DescribeRuleGroupSubscriptionResponse> DescribeRuleGroupSubscription(DescribeRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupSubscriptionResponse>(req, "DescribeRuleGroupSubscription");
        }

        /// <summary>
        /// Query Rule Group Subscription Information
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupSubscriptionResponse"/></returns>
        public DescribeRuleGroupSubscriptionResponse DescribeRuleGroupSubscriptionSync(DescribeRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupSubscriptionResponse>(req, "DescribeRuleGroupSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Table Binding Execution Rule Group Information
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupTableRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupTableResponse"/></returns>
        public Task<DescribeRuleGroupTableResponse> DescribeRuleGroupTable(DescribeRuleGroupTableRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupTableResponse>(req, "DescribeRuleGroupTable");
        }

        /// <summary>
        /// Query Table Binding Execution Rule Group Information
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupTableRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupTableResponse"/></returns>
        public DescribeRuleGroupTableResponse DescribeRuleGroupTableSync(DescribeRuleGroupTableRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupTableResponse>(req, "DescribeRuleGroupTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// [Filter Criteria]
        /// {Table Name (TableName), supports fuzzy matching}       {Table Owner (TableOwnerName), supports fuzzy matching}      {Monitoring Methods (MonitorTypes), 1. Not Configured 2. Linked to Production Scheduling 3. Offline Periodic Inspection, supports multiple selections}  {Subscriber (ReceiverUin)}
        /// [Required Fields]
        /// {Data Source (DatasourceId)}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupsByPageResponse"/></returns>
        public Task<DescribeRuleGroupsByPageResponse> DescribeRuleGroupsByPage(DescribeRuleGroupsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupsByPageResponse>(req, "DescribeRuleGroupsByPage");
        }

        /// <summary>
        /// [Filter Criteria]
        /// {Table Name (TableName), supports fuzzy matching}       {Table Owner (TableOwnerName), supports fuzzy matching}      {Monitoring Methods (MonitorTypes), 1. Not Configured 2. Linked to Production Scheduling 3. Offline Periodic Inspection, supports multiple selections}  {Subscriber (ReceiverUin)}
        /// [Required Fields]
        /// {Data Source (DatasourceId)}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupsByPageResponse"/></returns>
        public DescribeRuleGroupsByPageResponse DescribeRuleGroupsByPageSync(DescribeRuleGroupsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupsByPageResponse>(req, "DescribeRuleGroupsByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Template Details
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplateRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplateResponse"/></returns>
        public Task<DescribeRuleTemplateResponse> DescribeRuleTemplate(DescribeRuleTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplateResponse>(req, "DescribeRuleTemplate");
        }

        /// <summary>
        /// Query Template Details
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplateRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplateResponse"/></returns>
        public DescribeRuleTemplateResponse DescribeRuleTemplateSync(DescribeRuleTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplateResponse>(req, "DescribeRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Viewing Rule Template List
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public Task<DescribeRuleTemplatesResponse> DescribeRuleTemplates(DescribeRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesResponse>(req, "DescribeRuleTemplates");
        }

        /// <summary>
        /// Viewing Rule Template List
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public DescribeRuleTemplatesResponse DescribeRuleTemplatesSync(DescribeRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesResponse>(req, "DescribeRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// [Filter Conditions] {Template Name (Name), supports fuzzy matching} {Template Type (type), 1.System Template 2.Custom Definition Template} {Quality Detection Dimensions (QualityDims), 1.Accuracy 2.Uniqueness 3.Integrity 4.Consistency 5.Timeliness 6.Validity} [Sorting Field] {Citation Sorting Type (CitationOrderType), sort by citation count ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public Task<DescribeRuleTemplatesByPageResponse> DescribeRuleTemplatesByPage(DescribeRuleTemplatesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesByPageResponse>(req, "DescribeRuleTemplatesByPage");
        }

        /// <summary>
        /// [Filter Conditions] {Template Name (Name), supports fuzzy matching} {Template Type (type), 1.System Template 2.Custom Definition Template} {Quality Detection Dimensions (QualityDims), 1.Accuracy 2.Uniqueness 3.Integrity 4.Consistency 5.Timeliness 6.Validity} [Sorting Field] {Citation Sorting Type (CitationOrderType), sort by citation count ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public DescribeRuleTemplatesByPageResponse DescribeRuleTemplatesByPageSync(DescribeRuleTemplatesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesByPageResponse>(req, "DescribeRuleTemplatesByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Quality Rule List
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// Query Quality Rule List
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Paginated Query of Quality Rules
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByPageRequest"/></param>
        /// <returns><see cref="DescribeRulesByPageResponse"/></returns>
        public Task<DescribeRulesByPageResponse> DescribeRulesByPage(DescribeRulesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRulesByPageResponse>(req, "DescribeRulesByPage");
        }

        /// <summary>
        /// Paginated Query of Quality Rules
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByPageRequest"/></param>
        /// <returns><see cref="DescribeRulesByPageResponse"/></returns>
        public DescribeRulesByPageResponse DescribeRulesByPageSync(DescribeRulesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRulesByPageResponse>(req, "DescribeRulesByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Instance List
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduleInstancesRequest"/></param>
        /// <returns><see cref="DescribeScheduleInstancesResponse"/></returns>
        public Task<DescribeScheduleInstancesResponse> DescribeScheduleInstances(DescribeScheduleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeScheduleInstancesResponse>(req, "DescribeScheduleInstances");
        }

        /// <summary>
        /// Get Instance List
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduleInstancesRequest"/></param>
        /// <returns><see cref="DescribeScheduleInstancesResponse"/></returns>
        public DescribeScheduleInstancesResponse DescribeScheduleInstancesSync(DescribeScheduleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeScheduleInstancesResponse>(req, "DescribeScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operation and Maintenance Dashboard-Instance Status Distribution
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerInstanceStatusResponse"/></returns>
        public Task<DescribeSchedulerInstanceStatusResponse> DescribeSchedulerInstanceStatus(DescribeSchedulerInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerInstanceStatusResponse>(req, "DescribeSchedulerInstanceStatus");
        }

        /// <summary>
        /// Operation and Maintenance Dashboard-Instance Status Distribution
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerInstanceStatusResponse"/></returns>
        public DescribeSchedulerInstanceStatusResponse DescribeSchedulerInstanceStatusSync(DescribeSchedulerInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerInstanceStatusResponse>(req, "DescribeSchedulerInstanceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operation and Maintenance Dashboard - Instance Running Duration Ranking
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerRunTimeInstanceCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerRunTimeInstanceCntByStatusResponse"/></returns>
        public Task<DescribeSchedulerRunTimeInstanceCntByStatusResponse> DescribeSchedulerRunTimeInstanceCntByStatus(DescribeSchedulerRunTimeInstanceCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerRunTimeInstanceCntByStatusResponse>(req, "DescribeSchedulerRunTimeInstanceCntByStatus");
        }

        /// <summary>
        /// Operation and Maintenance Dashboard - Instance Running Duration Ranking
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerRunTimeInstanceCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerRunTimeInstanceCntByStatusResponse"/></returns>
        public DescribeSchedulerRunTimeInstanceCntByStatusResponse DescribeSchedulerRunTimeInstanceCntByStatusSync(DescribeSchedulerRunTimeInstanceCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerRunTimeInstanceCntByStatusResponse>(req, "DescribeSchedulerRunTimeInstanceCntByStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Status Statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskCntByStatusResponse"/></returns>
        public Task<DescribeSchedulerTaskCntByStatusResponse> DescribeSchedulerTaskCntByStatus(DescribeSchedulerTaskCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskCntByStatusResponse>(req, "DescribeSchedulerTaskCntByStatus");
        }

        /// <summary>
        /// Task Status Statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskCntByStatusResponse"/></returns>
        public DescribeSchedulerTaskCntByStatusResponse DescribeSchedulerTaskCntByStatusSync(DescribeSchedulerTaskCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskCntByStatusResponse>(req, "DescribeSchedulerTaskCntByStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operation and Maintenance Dashboard - Task Status Distribution
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskTypeCntRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskTypeCntResponse"/></returns>
        public Task<DescribeSchedulerTaskTypeCntResponse> DescribeSchedulerTaskTypeCnt(DescribeSchedulerTaskTypeCntRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskTypeCntResponse>(req, "DescribeSchedulerTaskTypeCnt");
        }

        /// <summary>
        /// Operation and Maintenance Dashboard - Task Status Distribution
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskTypeCntRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskTypeCntResponse"/></returns>
        public DescribeSchedulerTaskTypeCntResponse DescribeSchedulerTaskTypeCntSync(DescribeSchedulerTaskTypeCntRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskTypeCntResponse>(req, "DescribeSchedulerTaskTypeCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Status Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticInstanceStatusTrendOpsRequest"/></param>
        /// <returns><see cref="DescribeStatisticInstanceStatusTrendOpsResponse"/></returns>
        public Task<DescribeStatisticInstanceStatusTrendOpsResponse> DescribeStatisticInstanceStatusTrendOps(DescribeStatisticInstanceStatusTrendOpsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticInstanceStatusTrendOpsResponse>(req, "DescribeStatisticInstanceStatusTrendOps");
        }

        /// <summary>
        /// Task Status Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticInstanceStatusTrendOpsRequest"/></param>
        /// <returns><see cref="DescribeStatisticInstanceStatusTrendOpsResponse"/></returns>
        public DescribeStatisticInstanceStatusTrendOpsResponse DescribeStatisticInstanceStatusTrendOpsSync(DescribeStatisticInstanceStatusTrendOpsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticInstanceStatusTrendOpsResponse>(req, "DescribeStatisticInstanceStatusTrendOps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query real-time task log list
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeStreamTaskLogListResponse"/></returns>
        public Task<DescribeStreamTaskLogListResponse> DescribeStreamTaskLogList(DescribeStreamTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeStreamTaskLogListResponse>(req, "DescribeStreamTaskLogList");
        }

        /// <summary>
        /// Query real-time task log list
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeStreamTaskLogListResponse"/></returns>
        public DescribeStreamTaskLogListResponse DescribeStreamTaskLogListSync(DescribeStreamTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeStreamTaskLogListResponse>(req, "DescribeStreamTaskLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Downstream Task Information
        /// </summary>
        /// <param name="req"><see cref="DescribeSuccessorOpsTaskInfosRequest"/></param>
        /// <returns><see cref="DescribeSuccessorOpsTaskInfosResponse"/></returns>
        public Task<DescribeSuccessorOpsTaskInfosResponse> DescribeSuccessorOpsTaskInfos(DescribeSuccessorOpsTaskInfosRequest req)
        {
            return InternalRequestAsync<DescribeSuccessorOpsTaskInfosResponse>(req, "DescribeSuccessorOpsTaskInfos");
        }

        /// <summary>
        /// Get Downstream Task Information
        /// </summary>
        /// <param name="req"><see cref="DescribeSuccessorOpsTaskInfosRequest"/></param>
        /// <returns><see cref="DescribeSuccessorOpsTaskInfosResponse"/></returns>
        public DescribeSuccessorOpsTaskInfosResponse DescribeSuccessorOpsTaskInfosSync(DescribeSuccessorOpsTaskInfosRequest req)
        {
            return InternalRequestAsync<DescribeSuccessorOpsTaskInfosResponse>(req, "DescribeSuccessorOpsTaskInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Metadata Model-Table Basic Information Query Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeTableBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeTableBasicInfoResponse"/></returns>
        public Task<DescribeTableBasicInfoResponse> DescribeTableBasicInfo(DescribeTableBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableBasicInfoResponse>(req, "DescribeTableBasicInfo");
        }

        /// <summary>
        /// Metadata Model-Table Basic Information Query Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeTableBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeTableBasicInfoResponse"/></returns>
        public DescribeTableBasicInfoResponse DescribeTableBasicInfoSync(DescribeTableBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableBasicInfoResponse>(req, "DescribeTableBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve Data Table Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableInfoListRequest"/></param>
        /// <returns><see cref="DescribeTableInfoListResponse"/></returns>
        public Task<DescribeTableInfoListResponse> DescribeTableInfoList(DescribeTableInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTableInfoListResponse>(req, "DescribeTableInfoList");
        }

        /// <summary>
        /// Retrieve Data Table Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableInfoListRequest"/></param>
        /// <returns><see cref="DescribeTableInfoListResponse"/></returns>
        public DescribeTableInfoListResponse DescribeTableInfoListSync(DescribeTableInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTableInfoListResponse>(req, "DescribeTableInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Table Lineage Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageRequest"/></param>
        /// <returns><see cref="DescribeTableLineageResponse"/></returns>
        public Task<DescribeTableLineageResponse> DescribeTableLineage(DescribeTableLineageRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageResponse>(req, "DescribeTableLineage");
        }

        /// <summary>
        /// List Table Lineage Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageRequest"/></param>
        /// <returns><see cref="DescribeTableLineageResponse"/></returns>
        public DescribeTableLineageResponse DescribeTableLineageSync(DescribeTableLineageRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageResponse>(req, "DescribeTableLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Table Lineage Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageInfoRequest"/></param>
        /// <returns><see cref="DescribeTableLineageInfoResponse"/></returns>
        public Task<DescribeTableLineageInfoResponse> DescribeTableLineageInfo(DescribeTableLineageInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageInfoResponse>(req, "DescribeTableLineageInfo");
        }

        /// <summary>
        /// List Table Lineage Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageInfoRequest"/></param>
        /// <returns><see cref="DescribeTableLineageInfoResponse"/></returns>
        public DescribeTableLineageInfoResponse DescribeTableLineageInfoSync(DescribeTableLineageInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageInfoResponse>(req, "DescribeTableLineageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying Table Metadata Details
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetaRequest"/></param>
        /// <returns><see cref="DescribeTableMetaResponse"/></returns>
        public Task<DescribeTableMetaResponse> DescribeTableMeta(DescribeTableMetaRequest req)
        {
            return InternalRequestAsync<DescribeTableMetaResponse>(req, "DescribeTableMeta");
        }

        /// <summary>
        /// Querying Table Metadata Details
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetaRequest"/></param>
        /// <returns><see cref="DescribeTableMetaResponse"/></returns>
        public DescribeTableMetaResponse DescribeTableMetaSync(DescribeTableMetaRequest req)
        {
            return InternalRequestAsync<DescribeTableMetaResponse>(req, "DescribeTableMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Table Metadata List
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetasRequest"/></param>
        /// <returns><see cref="DescribeTableMetasResponse"/></returns>
        public Task<DescribeTableMetasResponse> DescribeTableMetas(DescribeTableMetasRequest req)
        {
            return InternalRequestAsync<DescribeTableMetasResponse>(req, "DescribeTableMetas");
        }

        /// <summary>
        /// Get Table Metadata List
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetasRequest"/></param>
        /// <returns><see cref="DescribeTableMetasResponse"/></returns>
        public DescribeTableMetasResponse DescribeTableMetasSync(DescribeTableMetasRequest req)
        {
            return InternalRequestAsync<DescribeTableMetasResponse>(req, "DescribeTableMetas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Quality Report - Query Table Quality Details
        /// </summary>
        /// <param name="req"><see cref="DescribeTableQualityDetailsRequest"/></param>
        /// <returns><see cref="DescribeTableQualityDetailsResponse"/></returns>
        public Task<DescribeTableQualityDetailsResponse> DescribeTableQualityDetails(DescribeTableQualityDetailsRequest req)
        {
            return InternalRequestAsync<DescribeTableQualityDetailsResponse>(req, "DescribeTableQualityDetails");
        }

        /// <summary>
        /// Quality Report - Query Table Quality Details
        /// </summary>
        /// <param name="req"><see cref="DescribeTableQualityDetailsRequest"/></param>
        /// <returns><see cref="DescribeTableQualityDetailsResponse"/></returns>
        public DescribeTableQualityDetailsResponse DescribeTableQualityDetailsSync(DescribeTableQualityDetailsRequest req)
        {
            return InternalRequestAsync<DescribeTableQualityDetailsResponse>(req, "DescribeTableQualityDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve Table Schema Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableSchemaInfoRequest"/></param>
        /// <returns><see cref="DescribeTableSchemaInfoResponse"/></returns>
        public Task<DescribeTableSchemaInfoResponse> DescribeTableSchemaInfo(DescribeTableSchemaInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableSchemaInfoResponse>(req, "DescribeTableSchemaInfo");
        }

        /// <summary>
        /// Retrieve Table Schema Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTableSchemaInfoRequest"/></param>
        /// <returns><see cref="DescribeTableSchemaInfoResponse"/></returns>
        public DescribeTableSchemaInfoResponse DescribeTableSchemaInfoSync(DescribeTableSchemaInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableSchemaInfoResponse>(req, "DescribeTableSchemaInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Table Score Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeTableScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeTableScoreTrendResponse"/></returns>
        public Task<DescribeTableScoreTrendResponse> DescribeTableScoreTrend(DescribeTableScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeTableScoreTrendResponse>(req, "DescribeTableScoreTrend");
        }

        /// <summary>
        /// Query Table Score Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeTableScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeTableScoreTrendResponse"/></returns>
        public DescribeTableScoreTrendResponse DescribeTableScoreTrendSync(DescribeTableScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeTableScoreTrendResponse>(req, "DescribeTableScoreTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Task Alert Rule List
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskAlarmRegulationsRequest"/></param>
        /// <returns><see cref="DescribeTaskAlarmRegulationsResponse"/></returns>
        public Task<DescribeTaskAlarmRegulationsResponse> DescribeTaskAlarmRegulations(DescribeTaskAlarmRegulationsRequest req)
        {
            return InternalRequestAsync<DescribeTaskAlarmRegulationsResponse>(req, "DescribeTaskAlarmRegulations");
        }

        /// <summary>
        /// Query Task Alert Rule List
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskAlarmRegulationsRequest"/></param>
        /// <returns><see cref="DescribeTaskAlarmRegulationsResponse"/></returns>
        public DescribeTaskAlarmRegulationsResponse DescribeTaskAlarmRegulationsSync(DescribeTaskAlarmRegulationsRequest req)
        {
            return InternalRequestAsync<DescribeTaskAlarmRegulationsResponse>(req, "DescribeTaskAlarmRegulations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all tasks by cycle type
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleResponse"/></returns>
        public Task<DescribeTaskByCycleResponse> DescribeTaskByCycle(DescribeTaskByCycleRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleResponse>(req, "DescribeTaskByCycle");
        }

        /// <summary>
        /// Query all tasks by cycle type
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleResponse"/></returns>
        public DescribeTaskByCycleResponse DescribeTaskByCycleSync(DescribeTaskByCycleRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleResponse>(req, "DescribeTaskByCycle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Status Cycle Growth Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleReportResponse"/></returns>
        public Task<DescribeTaskByCycleReportResponse> DescribeTaskByCycleReport(DescribeTaskByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleReportResponse>(req, "DescribeTaskByCycleReport");
        }

        /// <summary>
        /// Task Status Cycle Growth Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleReportResponse"/></returns>
        public DescribeTaskByCycleReportResponse DescribeTaskByCycleReportSync(DescribeTaskByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleReportResponse>(req, "DescribeTaskByCycleReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Status Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByStatusReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByStatusReportResponse"/></returns>
        public Task<DescribeTaskByStatusReportResponse> DescribeTaskByStatusReport(DescribeTaskByStatusReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByStatusReportResponse>(req, "DescribeTaskByStatusReport");
        }

        /// <summary>
        /// Task Status Trend
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByStatusReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByStatusReportResponse"/></returns>
        public DescribeTaskByStatusReportResponse DescribeTaskByStatusReportSync(DescribeTaskByStatusReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByStatusReportResponse>(req, "DescribeTaskByStatusReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View Task Lock Status Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLockStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLockStatusResponse"/></returns>
        public Task<DescribeTaskLockStatusResponse> DescribeTaskLockStatus(DescribeTaskLockStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskLockStatusResponse>(req, "DescribeTaskLockStatus");
        }

        /// <summary>
        /// View Task Lock Status Information
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLockStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLockStatusResponse"/></returns>
        public DescribeTaskLockStatusResponse DescribeTaskLockStatusSync(DescribeTaskLockStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskLockStatusResponse>(req, "DescribeTaskLockStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Paging Query Task Execution History
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRunHistoryRequest"/></param>
        /// <returns><see cref="DescribeTaskRunHistoryResponse"/></returns>
        public Task<DescribeTaskRunHistoryResponse> DescribeTaskRunHistory(DescribeTaskRunHistoryRequest req)
        {
            return InternalRequestAsync<DescribeTaskRunHistoryResponse>(req, "DescribeTaskRunHistory");
        }

        /// <summary>
        /// Paging Query Task Execution History
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRunHistoryRequest"/></param>
        /// <returns><see cref="DescribeTaskRunHistoryResponse"/></returns>
        public DescribeTaskRunHistoryResponse DescribeTaskRunHistorySync(DescribeTaskRunHistoryRequest req)
        {
            return InternalRequestAsync<DescribeTaskRunHistoryResponse>(req, "DescribeTaskRunHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Task Script
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public Task<DescribeTaskScriptResponse> DescribeTaskScript(DescribeTaskScriptRequest req)
        {
            return InternalRequestAsync<DescribeTaskScriptResponse>(req, "DescribeTaskScript");
        }

        /// <summary>
        /// Query Task Script
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public DescribeTaskScriptResponse DescribeTaskScriptSync(DescribeTaskScriptRequest req)
        {
            return InternalRequestAsync<DescribeTaskScriptResponse>(req, "DescribeTaskScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query rule template dimension distribution
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateDimCountRequest"/></param>
        /// <returns><see cref="DescribeTemplateDimCountResponse"/></returns>
        public Task<DescribeTemplateDimCountResponse> DescribeTemplateDimCount(DescribeTemplateDimCountRequest req)
        {
            return InternalRequestAsync<DescribeTemplateDimCountResponse>(req, "DescribeTemplateDimCount");
        }

        /// <summary>
        /// Query rule template dimension distribution
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateDimCountRequest"/></param>
        /// <returns><see cref="DescribeTemplateDimCountResponse"/></returns>
        public DescribeTemplateDimCountResponse DescribeTemplateDimCountSync(DescribeTemplateDimCountRequest req)
        {
            return InternalRequestAsync<DescribeTemplateDimCountResponse>(req, "DescribeTemplateDimCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get third-party operation logs
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdTaskRunLogRequest"/></param>
        /// <returns><see cref="DescribeThirdTaskRunLogResponse"/></returns>
        public Task<DescribeThirdTaskRunLogResponse> DescribeThirdTaskRunLog(DescribeThirdTaskRunLogRequest req)
        {
            return InternalRequestAsync<DescribeThirdTaskRunLogResponse>(req, "DescribeThirdTaskRunLog");
        }

        /// <summary>
        /// Get third-party operation logs
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdTaskRunLogRequest"/></param>
        /// <returns><see cref="DescribeThirdTaskRunLogResponse"/></returns>
        public DescribeThirdTaskRunLogResponse DescribeThirdTaskRunLogSync(DescribeThirdTaskRunLogRequest req)
        {
            return InternalRequestAsync<DescribeThirdTaskRunLogResponse>(req, "DescribeThirdTaskRunLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Quality Overview Page Table Ranking Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeTopTableStatRequest"/></param>
        /// <returns><see cref="DescribeTopTableStatResponse"/></returns>
        public Task<DescribeTopTableStatResponse> DescribeTopTableStat(DescribeTopTableStatRequest req)
        {
            return InternalRequestAsync<DescribeTopTableStatResponse>(req, "DescribeTopTableStat");
        }

        /// <summary>
        /// Data Quality Overview Page Table Ranking Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeTopTableStatRequest"/></param>
        /// <returns><see cref="DescribeTopTableStatResponse"/></returns>
        public DescribeTopTableStatResponse DescribeTopTableStatSync(DescribeTopTableStatRequest req)
        {
            return InternalRequestAsync<DescribeTopTableStatResponse>(req, "DescribeTopTableStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Quality Overview Page Trend Change Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeTrendStatRequest"/></param>
        /// <returns><see cref="DescribeTrendStatResponse"/></returns>
        public Task<DescribeTrendStatResponse> DescribeTrendStat(DescribeTrendStatRequest req)
        {
            return InternalRequestAsync<DescribeTrendStatResponse>(req, "DescribeTrendStat");
        }

        /// <summary>
        /// Data Quality Overview Page Trend Change Interface
        /// </summary>
        /// <param name="req"><see cref="DescribeTrendStatRequest"/></param>
        /// <returns><see cref="DescribeTrendStatResponse"/></returns>
        public DescribeTrendStatResponse DescribeTrendStatSync(DescribeTrendStatRequest req)
        {
            return InternalRequestAsync<DescribeTrendStatResponse>(req, "DescribeTrendStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Workflow Canvas
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasInfoResponse"/></returns>
        public Task<DescribeWorkflowCanvasInfoResponse> DescribeWorkflowCanvasInfo(DescribeWorkflowCanvasInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasInfoResponse>(req, "DescribeWorkflowCanvasInfo");
        }

        /// <summary>
        /// Query Workflow Canvas
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasInfoResponse"/></returns>
        public DescribeWorkflowCanvasInfoResponse DescribeWorkflowCanvasInfoSync(DescribeWorkflowCanvasInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasInfoResponse>(req, "DescribeWorkflowCanvasInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Workflow Canvas Run Start and End Time
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowExecuteByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowExecuteByIdResponse"/></returns>
        public Task<DescribeWorkflowExecuteByIdResponse> DescribeWorkflowExecuteById(DescribeWorkflowExecuteByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowExecuteByIdResponse>(req, "DescribeWorkflowExecuteById");
        }

        /// <summary>
        /// Query Workflow Canvas Run Start and End Time
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowExecuteByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowExecuteByIdResponse"/></returns>
        public DescribeWorkflowExecuteByIdResponse DescribeWorkflowExecuteByIdSync(DescribeWorkflowExecuteByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowExecuteByIdResponse>(req, "DescribeWorkflowExecuteById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Workflow Details by Workflow ID
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowInfoByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowInfoByIdResponse"/></returns>
        public Task<DescribeWorkflowInfoByIdResponse> DescribeWorkflowInfoById(DescribeWorkflowInfoByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowInfoByIdResponse>(req, "DescribeWorkflowInfoById");
        }

        /// <summary>
        /// Query Workflow Details by Workflow ID
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowInfoByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowInfoByIdResponse"/></returns>
        public DescribeWorkflowInfoByIdResponse DescribeWorkflowInfoByIdSync(DescribeWorkflowInfoByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowInfoByIdResponse>(req, "DescribeWorkflowInfoById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all workflow lists under the project by Project ID
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowListByProjectIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowListByProjectIdResponse"/></returns>
        public Task<DescribeWorkflowListByProjectIdResponse> DescribeWorkflowListByProjectId(DescribeWorkflowListByProjectIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowListByProjectIdResponse>(req, "DescribeWorkflowListByProjectId");
        }

        /// <summary>
        /// Get all workflow lists under the project by Project ID
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowListByProjectIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowListByProjectIdResponse"/></returns>
        public DescribeWorkflowListByProjectIdResponse DescribeWorkflowListByProjectIdSync(DescribeWorkflowListByProjectIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowListByProjectIdResponse>(req, "DescribeWorkflowListByProjectId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the number of workflow tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowTaskCountRequest"/></param>
        /// <returns><see cref="DescribeWorkflowTaskCountResponse"/></returns>
        public Task<DescribeWorkflowTaskCountResponse> DescribeWorkflowTaskCount(DescribeWorkflowTaskCountRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowTaskCountResponse>(req, "DescribeWorkflowTaskCount");
        }

        /// <summary>
        /// Query the number of workflow tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowTaskCountRequest"/></param>
        /// <returns><see cref="DescribeWorkflowTaskCountResponse"/></returns>
        public DescribeWorkflowTaskCountResponse DescribeWorkflowTaskCountSync(DescribeWorkflowTaskCountRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowTaskCountResponse>(req, "DescribeWorkflowTaskCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Instance diagnosis for diagnosing instances in INITIAL, DEPENDENCE, ALLOCATED, LAUNCHED, EVENT_LISTENING, BEFORE_ASPECT, EXPIRED, FAILED states
        /// </summary>
        /// <param name="req"><see cref="DiagnoseProRequest"/></param>
        /// <returns><see cref="DiagnoseProResponse"/></returns>
        public Task<DiagnoseProResponse> DiagnosePro(DiagnoseProRequest req)
        {
            return InternalRequestAsync<DiagnoseProResponse>(req, "DiagnosePro");
        }

        /// <summary>
        /// Instance diagnosis for diagnosing instances in INITIAL, DEPENDENCE, ALLOCATED, LAUNCHED, EVENT_LISTENING, BEFORE_ASPECT, EXPIRED, FAILED states
        /// </summary>
        /// <param name="req"><see cref="DiagnoseProRequest"/></param>
        /// <returns><see cref="DiagnoseProResponse"/></returns>
        public DiagnoseProResponse DiagnoseProSync(DiagnoseProRequest req)
        {
            return InternalRequestAsync<DiagnoseProResponse>(req, "DiagnosePro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Debug and Run Integration Task
        /// </summary>
        /// <param name="req"><see cref="DryRunDIOfflineTaskRequest"/></param>
        /// <returns><see cref="DryRunDIOfflineTaskResponse"/></returns>
        public Task<DryRunDIOfflineTaskResponse> DryRunDIOfflineTask(DryRunDIOfflineTaskRequest req)
        {
            return InternalRequestAsync<DryRunDIOfflineTaskResponse>(req, "DryRunDIOfflineTask");
        }

        /// <summary>
        /// Debug and Run Integration Task
        /// </summary>
        /// <param name="req"><see cref="DryRunDIOfflineTaskRequest"/></param>
        /// <returns><see cref="DryRunDIOfflineTaskResponse"/></returns>
        public DryRunDIOfflineTaskResponse DryRunDIOfflineTaskSync(DryRunDIOfflineTaskRequest req)
        {
            return InternalRequestAsync<DryRunDIOfflineTaskResponse>(req, "DryRunDIOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Orchestration Space Bulk Operation Page Find All Folders
        /// </summary>
        /// <param name="req"><see cref="FindAllFolderRequest"/></param>
        /// <returns><see cref="FindAllFolderResponse"/></returns>
        public Task<FindAllFolderResponse> FindAllFolder(FindAllFolderRequest req)
        {
            return InternalRequestAsync<FindAllFolderResponse>(req, "FindAllFolder");
        }

        /// <summary>
        /// Orchestration Space Bulk Operation Page Find All Folders
        /// </summary>
        /// <param name="req"><see cref="FindAllFolderRequest"/></param>
        /// <returns><see cref="FindAllFolderResponse"/></returns>
        public FindAllFolderResponse FindAllFolderSync(FindAllFolderRequest req)
        {
            return InternalRequestAsync<FindAllFolderResponse>(req, "FindAllFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Task Operation and Maintenance - Bulk Pause Tasks
        /// </summary>
        /// <param name="req"><see cref="FreezeOpsTasksRequest"/></param>
        /// <returns><see cref="FreezeOpsTasksResponse"/></returns>
        public Task<FreezeOpsTasksResponse> FreezeOpsTasks(FreezeOpsTasksRequest req)
        {
            return InternalRequestAsync<FreezeOpsTasksResponse>(req, "FreezeOpsTasks");
        }

        /// <summary>
        /// Task Operation and Maintenance - Bulk Pause Tasks
        /// </summary>
        /// <param name="req"><see cref="FreezeOpsTasksRequest"/></param>
        /// <returns><see cref="FreezeOpsTasksResponse"/></returns>
        public FreezeOpsTasksResponse FreezeOpsTasksSync(FreezeOpsTasksRequest req)
        {
            return InternalRequestAsync<FreezeOpsTasksResponse>(req, "FreezeOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pause All Tasks Under Workflow
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByWorkflowIdsRequest"/></param>
        /// <returns><see cref="FreezeTasksByWorkflowIdsResponse"/></returns>
        public Task<FreezeTasksByWorkflowIdsResponse> FreezeTasksByWorkflowIds(FreezeTasksByWorkflowIdsRequest req)
        {
            return InternalRequestAsync<FreezeTasksByWorkflowIdsResponse>(req, "FreezeTasksByWorkflowIds");
        }

        /// <summary>
        /// Pause All Tasks Under Workflow
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByWorkflowIdsRequest"/></param>
        /// <returns><see cref="FreezeTasksByWorkflowIdsResponse"/></returns>
        public FreezeTasksByWorkflowIdsResponse FreezeTasksByWorkflowIdsSync(FreezeTasksByWorkflowIdsRequest req)
        {
            return InternalRequestAsync<FreezeTasksByWorkflowIdsResponse>(req, "FreezeTasksByWorkflowIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generate SQL for Creating Hive Table
        /// </summary>
        /// <param name="req"><see cref="GenHiveTableDDLSqlRequest"/></param>
        /// <returns><see cref="GenHiveTableDDLSqlResponse"/></returns>
        public Task<GenHiveTableDDLSqlResponse> GenHiveTableDDLSql(GenHiveTableDDLSqlRequest req)
        {
            return InternalRequestAsync<GenHiveTableDDLSqlResponse>(req, "GenHiveTableDDLSql");
        }

        /// <summary>
        /// Generate SQL for Creating Hive Table
        /// </summary>
        /// <param name="req"><see cref="GenHiveTableDDLSqlRequest"/></param>
        /// <returns><see cref="GenHiveTableDDLSqlResponse"/></returns>
        public GenHiveTableDDLSqlResponse GenHiveTableDDLSqlSync(GenHiveTableDDLSqlRequest req)
        {
            return InternalRequestAsync<GenHiveTableDDLSqlResponse>(req, "GenHiveTableDDLSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Development Space - Obtain data development script information
        /// </summary>
        /// <param name="req"><see cref="GetFileInfoRequest"/></param>
        /// <returns><see cref="GetFileInfoResponse"/></returns>
        public Task<GetFileInfoResponse> GetFileInfo(GetFileInfoRequest req)
        {
            return InternalRequestAsync<GetFileInfoResponse>(req, "GetFileInfo");
        }

        /// <summary>
        /// Development Space - Obtain data development script information
        /// </summary>
        /// <param name="req"><see cref="GetFileInfoRequest"/></param>
        /// <returns><see cref="GetFileInfoResponse"/></returns>
        public GetFileInfoResponse GetFileInfoSync(GetFileInfoRequest req)
        {
            return InternalRequestAsync<GetFileInfoResponse>(req, "GetFileInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Extracting DataInLong Node Field Schema
        /// </summary>
        /// <param name="req"><see cref="GetIntegrationNodeColumnSchemaRequest"/></param>
        /// <returns><see cref="GetIntegrationNodeColumnSchemaResponse"/></returns>
        public Task<GetIntegrationNodeColumnSchemaResponse> GetIntegrationNodeColumnSchema(GetIntegrationNodeColumnSchemaRequest req)
        {
            return InternalRequestAsync<GetIntegrationNodeColumnSchemaResponse>(req, "GetIntegrationNodeColumnSchema");
        }

        /// <summary>
        /// Extracting DataInLong Node Field Schema
        /// </summary>
        /// <param name="req"><see cref="GetIntegrationNodeColumnSchemaRequest"/></param>
        /// <returns><see cref="GetIntegrationNodeColumnSchemaResponse"/></returns>
        public GetIntegrationNodeColumnSchemaResponse GetIntegrationNodeColumnSchemaSync(GetIntegrationNodeColumnSchemaRequest req)
        {
            return InternalRequestAsync<GetIntegrationNodeColumnSchemaResponse>(req, "GetIntegrationNodeColumnSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Offline Task Instance List (New)
        /// </summary>
        /// <param name="req"><see cref="GetOfflineDIInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineDIInstanceListResponse"/></returns>
        public Task<GetOfflineDIInstanceListResponse> GetOfflineDIInstanceList(GetOfflineDIInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineDIInstanceListResponse>(req, "GetOfflineDIInstanceList");
        }

        /// <summary>
        /// Get Offline Task Instance List (New)
        /// </summary>
        /// <param name="req"><see cref="GetOfflineDIInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineDIInstanceListResponse"/></returns>
        public GetOfflineDIInstanceListResponse GetOfflineDIInstanceListSync(GetOfflineDIInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineDIInstanceListResponse>(req, "GetOfflineDIInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Offline Task Instances
        /// </summary>
        /// <param name="req"><see cref="GetOfflineInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineInstanceListResponse"/></returns>
        public Task<GetOfflineInstanceListResponse> GetOfflineInstanceList(GetOfflineInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineInstanceListResponse>(req, "GetOfflineInstanceList");
        }

        /// <summary>
        /// Obtain Offline Task Instances
        /// </summary>
        /// <param name="req"><see cref="GetOfflineInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineInstanceListResponse"/></returns>
        public GetOfflineInstanceListResponse GetOfflineInstanceListSync(GetOfflineInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineInstanceListResponse>(req, "GetOfflineInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Termination of Instances by Supplement Plan.
        /// </summary>
        /// <param name="req"><see cref="KillOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="KillOpsMakePlanInstancesResponse"/></returns>
        public Task<KillOpsMakePlanInstancesResponse> KillOpsMakePlanInstances(KillOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<KillOpsMakePlanInstancesResponse>(req, "KillOpsMakePlanInstances");
        }

        /// <summary>
        /// Batch Termination of Instances by Supplement Plan.
        /// </summary>
        /// <param name="req"><see cref="KillOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="KillOpsMakePlanInstancesResponse"/></returns>
        public KillOpsMakePlanInstancesResponse KillOpsMakePlanInstancesSync(KillOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<KillOpsMakePlanInstancesResponse>(req, "KillOpsMakePlanInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Termination of Instances
        /// </summary>
        /// <param name="req"><see cref="KillScheduleInstancesRequest"/></param>
        /// <returns><see cref="KillScheduleInstancesResponse"/></returns>
        public Task<KillScheduleInstancesResponse> KillScheduleInstances(KillScheduleInstancesRequest req)
        {
            return InternalRequestAsync<KillScheduleInstancesResponse>(req, "KillScheduleInstances");
        }

        /// <summary>
        /// Batch Termination of Instances
        /// </summary>
        /// <param name="req"><see cref="KillScheduleInstancesRequest"/></param>
        /// <returns><see cref="KillScheduleInstancesResponse"/></returns>
        public KillScheduleInstancesResponse KillScheduleInstancesSync(KillScheduleInstancesRequest req)
        {
            return InternalRequestAsync<KillScheduleInstancesResponse>(req, "KillScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lock Integration Task
        /// </summary>
        /// <param name="req"><see cref="LockIntegrationTaskRequest"/></param>
        /// <returns><see cref="LockIntegrationTaskResponse"/></returns>
        public Task<LockIntegrationTaskResponse> LockIntegrationTask(LockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<LockIntegrationTaskResponse>(req, "LockIntegrationTask");
        }

        /// <summary>
        /// Lock Integration Task
        /// </summary>
        /// <param name="req"><see cref="LockIntegrationTaskRequest"/></param>
        /// <returns><see cref="LockIntegrationTaskResponse"/></returns>
        public LockIntegrationTaskResponse LockIntegrationTaskSync(LockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<LockIntegrationTaskResponse>(req, "LockIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Approval Form Status
        /// </summary>
        /// <param name="req"><see cref="ModifyApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyApproveStatusResponse"/></returns>
        public Task<ModifyApproveStatusResponse> ModifyApproveStatus(ModifyApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyApproveStatusResponse>(req, "ModifyApproveStatus");
        }

        /// <summary>
        /// Modify Approval Form Status
        /// </summary>
        /// <param name="req"><see cref="ModifyApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyApproveStatusResponse"/></returns>
        public ModifyApproveStatusResponse ModifyApproveStatusSync(ModifyApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyApproveStatusResponse>(req, "ModifyApproveStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Data Source
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public Task<ModifyDataSourceResponse> ModifyDataSource(ModifyDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyDataSourceResponse>(req, "ModifyDataSource");
        }

        /// <summary>
        /// Modify Data Source
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public ModifyDataSourceResponse ModifyDataSourceSync(ModifyDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyDataSourceResponse>(req, "ModifyDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Quality Report - Modify Dimension Permissions
        /// </summary>
        /// <param name="req"><see cref="ModifyDimensionWeightRequest"/></param>
        /// <returns><see cref="ModifyDimensionWeightResponse"/></returns>
        public Task<ModifyDimensionWeightResponse> ModifyDimensionWeight(ModifyDimensionWeightRequest req)
        {
            return InternalRequestAsync<ModifyDimensionWeightResponse>(req, "ModifyDimensionWeight");
        }

        /// <summary>
        /// Quality Report - Modify Dimension Permissions
        /// </summary>
        /// <param name="req"><see cref="ModifyDimensionWeightRequest"/></param>
        /// <returns><see cref="ModifyDimensionWeightResponse"/></returns>
        public ModifyDimensionWeightResponse ModifyDimensionWeightSync(ModifyDimensionWeightRequest req)
        {
            return InternalRequestAsync<ModifyDimensionWeightResponse>(req, "ModifyDimensionWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Data Development Module - Folder Update
        /// </summary>
        /// <param name="req"><see cref="ModifyDsFolderRequest"/></param>
        /// <returns><see cref="ModifyDsFolderResponse"/></returns>
        public Task<ModifyDsFolderResponse> ModifyDsFolder(ModifyDsFolderRequest req)
        {
            return InternalRequestAsync<ModifyDsFolderResponse>(req, "ModifyDsFolder");
        }

        /// <summary>
        /// Data Development Module - Folder Update
        /// </summary>
        /// <param name="req"><see cref="ModifyDsFolderRequest"/></param>
        /// <returns><see cref="ModifyDsFolderResponse"/></returns>
        public ModifyDsFolderResponse ModifyDsFolderSync(ModifyDsFolderRequest req)
        {
            return InternalRequestAsync<ModifyDsFolderResponse>(req, "ModifyDsFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Rule Group Execution Strategy
        /// </summary>
        /// <param name="req"><see cref="ModifyExecStrategyRequest"/></param>
        /// <returns><see cref="ModifyExecStrategyResponse"/></returns>
        public Task<ModifyExecStrategyResponse> ModifyExecStrategy(ModifyExecStrategyRequest req)
        {
            return InternalRequestAsync<ModifyExecStrategyResponse>(req, "ModifyExecStrategy");
        }

        /// <summary>
        /// Update Rule Group Execution Strategy
        /// </summary>
        /// <param name="req"><see cref="ModifyExecStrategyRequest"/></param>
        /// <returns><see cref="ModifyExecStrategyResponse"/></returns>
        public ModifyExecStrategyResponse ModifyExecStrategySync(ModifyExecStrategyRequest req)
        {
            return InternalRequestAsync<ModifyExecStrategyResponse>(req, "ModifyExecStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updating Integrated Nodes
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationNodeRequest"/></param>
        /// <returns><see cref="ModifyIntegrationNodeResponse"/></returns>
        public Task<ModifyIntegrationNodeResponse> ModifyIntegrationNode(ModifyIntegrationNodeRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationNodeResponse>(req, "ModifyIntegrationNode");
        }

        /// <summary>
        /// Updating Integrated Nodes
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationNodeRequest"/></param>
        /// <returns><see cref="ModifyIntegrationNodeResponse"/></returns>
        public ModifyIntegrationNodeResponse ModifyIntegrationNodeSync(ModifyIntegrationNodeRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationNodeResponse>(req, "ModifyIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Integration Task
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationTaskRequest"/></param>
        /// <returns><see cref="ModifyIntegrationTaskResponse"/></returns>
        public Task<ModifyIntegrationTaskResponse> ModifyIntegrationTask(ModifyIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationTaskResponse>(req, "ModifyIntegrationTask");
        }

        /// <summary>
        /// Update Integration Task
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationTaskRequest"/></param>
        /// <returns><see cref="ModifyIntegrationTaskResponse"/></returns>
        public ModifyIntegrationTaskResponse ModifyIntegrationTaskSync(ModifyIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationTaskResponse>(req, "ModifyIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Monitoring Status
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyMonitorStatusResponse"/></returns>
        public Task<ModifyMonitorStatusResponse> ModifyMonitorStatus(ModifyMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyMonitorStatusResponse>(req, "ModifyMonitorStatus");
        }

        /// <summary>
        /// Update Monitoring Status
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyMonitorStatusResponse"/></returns>
        public ModifyMonitorStatusResponse ModifyMonitorStatusSync(ModifyMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyMonitorStatusResponse>(req, "ModifyMonitorStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Quality Rule Interface
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// Update Quality Rule Interface
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Rule Group Subscription Information
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupSubscriptionResponse"/></returns>
        public Task<ModifyRuleGroupSubscriptionResponse> ModifyRuleGroupSubscription(ModifyRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<ModifyRuleGroupSubscriptionResponse>(req, "ModifyRuleGroupSubscription");
        }

        /// <summary>
        /// Update Rule Group Subscription Information
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupSubscriptionResponse"/></returns>
        public ModifyRuleGroupSubscriptionResponse ModifyRuleGroupSubscriptionSync(ModifyRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<ModifyRuleGroupSubscriptionResponse>(req, "ModifyRuleGroupSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit Rule Template
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleTemplateRequest"/></param>
        /// <returns><see cref="ModifyRuleTemplateResponse"/></returns>
        public Task<ModifyRuleTemplateResponse> ModifyRuleTemplate(ModifyRuleTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRuleTemplateResponse>(req, "ModifyRuleTemplate");
        }

        /// <summary>
        /// Edit Rule Template
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleTemplateRequest"/></param>
        /// <returns><see cref="ModifyRuleTemplateResponse"/></returns>
        public ModifyRuleTemplateResponse ModifyRuleTemplateSync(ModifyRuleTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRuleTemplateResponse>(req, "ModifyRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify task alert rules
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="ModifyTaskAlarmRegularResponse"/></returns>
        public Task<ModifyTaskAlarmRegularResponse> ModifyTaskAlarmRegular(ModifyTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<ModifyTaskAlarmRegularResponse>(req, "ModifyTaskAlarmRegular");
        }

        /// <summary>
        /// Modify task alert rules
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="ModifyTaskAlarmRegularResponse"/></returns>
        public ModifyTaskAlarmRegularResponse ModifyTaskAlarmRegularSync(ModifyTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<ModifyTaskAlarmRegularResponse>(req, "ModifyTaskAlarmRegular")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Update Task
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public Task<ModifyTaskInfoResponse> ModifyTaskInfo(ModifyTaskInfoRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoResponse>(req, "ModifyTaskInfo");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Update Task
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public ModifyTaskInfoResponse ModifyTaskInfoSync(ModifyTaskInfoRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoResponse>(req, "ModifyTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Add Parent Task Dependency
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public Task<ModifyTaskLinksResponse> ModifyTaskLinks(ModifyTaskLinksRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksResponse>(req, "ModifyTaskLinks");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Add Parent Task Dependency
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public ModifyTaskLinksResponse ModifyTaskLinksSync(ModifyTaskLinksRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksResponse>(req, "ModifyTaskLinks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rename Task (Task Editing)
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskNameRequest"/></param>
        /// <returns><see cref="ModifyTaskNameResponse"/></returns>
        public Task<ModifyTaskNameResponse> ModifyTaskName(ModifyTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyTaskNameResponse>(req, "ModifyTaskName");
        }

        /// <summary>
        /// Rename Task (Task Editing)
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskNameRequest"/></param>
        /// <returns><see cref="ModifyTaskNameResponse"/></returns>
        public ModifyTaskNameResponse ModifyTaskNameSync(ModifyTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyTaskNameResponse>(req, "ModifyTaskName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Modify Task Script
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public Task<ModifyTaskScriptResponse> ModifyTaskScript(ModifyTaskScriptRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptResponse>(req, "ModifyTaskScript");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Modify Task Script
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public ModifyTaskScriptResponse ModifyTaskScriptSync(ModifyTaskScriptRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptResponse>(req, "ModifyTaskScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Workflow Information
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public Task<ModifyWorkflowInfoResponse> ModifyWorkflowInfo(ModifyWorkflowInfoRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowInfoResponse>(req, "ModifyWorkflowInfo");
        }

        /// <summary>
        /// Update Workflow Information
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public ModifyWorkflowInfoResponse ModifyWorkflowInfoSync(ModifyWorkflowInfoRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowInfoResponse>(req, "ModifyWorkflowInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update Workflow Scheduling
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public Task<ModifyWorkflowScheduleResponse> ModifyWorkflowSchedule(ModifyWorkflowScheduleRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowScheduleResponse>(req, "ModifyWorkflowSchedule");
        }

        /// <summary>
        /// Update Workflow Scheduling
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public ModifyWorkflowScheduleResponse ModifyWorkflowScheduleSync(ModifyWorkflowScheduleRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowScheduleResponse>(req, "ModifyWorkflowSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Orchestration Space - Workflow - Move Task to Workflow Folder
        /// </summary>
        /// <param name="req"><see cref="MoveTasksToFolderRequest"/></param>
        /// <returns><see cref="MoveTasksToFolderResponse"/></returns>
        public Task<MoveTasksToFolderResponse> MoveTasksToFolder(MoveTasksToFolderRequest req)
        {
            return InternalRequestAsync<MoveTasksToFolderResponse>(req, "MoveTasksToFolder");
        }

        /// <summary>
        /// Orchestration Space - Workflow - Move Task to Workflow Folder
        /// </summary>
        /// <param name="req"><see cref="MoveTasksToFolderRequest"/></param>
        /// <returns><see cref="MoveTasksToFolderResponse"/></returns>
        public MoveTasksToFolderResponse MoveTasksToFolderSync(MoveTasksToFolderRequest req)
        {
            return InternalRequestAsync<MoveTasksToFolderResponse>(req, "MoveTasksToFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Registration Event
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public Task<RegisterEventResponse> RegisterEvent(RegisterEventRequest req)
        {
            return InternalRequestAsync<RegisterEventResponse>(req, "RegisterEvent");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Registration Event
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public RegisterEventResponse RegisterEventSync(RegisterEventRequest req)
        {
            return InternalRequestAsync<RegisterEventResponse>(req, "RegisterEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Register Event Listener
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public Task<RegisterEventListenerResponse> RegisterEventListener(RegisterEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterEventListenerResponse>(req, "RegisterEventListener");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Register Event Listener
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public RegisterEventListenerResponse RegisterEventListenerSync(RegisterEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterEventListenerResponse>(req, "RegisterEventListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete orchestration space workflow
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkflowDsRequest"/></param>
        /// <returns><see cref="RemoveWorkflowDsResponse"/></returns>
        public Task<RemoveWorkflowDsResponse> RemoveWorkflowDs(RemoveWorkflowDsRequest req)
        {
            return InternalRequestAsync<RemoveWorkflowDsResponse>(req, "RemoveWorkflowDs");
        }

        /// <summary>
        /// Delete orchestration space workflow
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkflowDsRequest"/></param>
        /// <returns><see cref="RemoveWorkflowDsResponse"/></returns>
        public RemoveWorkflowDsResponse RemoveWorkflowDsSync(RemoveWorkflowDsRequest req)
        {
            return InternalRequestAsync<RemoveWorkflowDsResponse>(req, "RemoveWorkflowDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Continue Integration Task
        /// </summary>
        /// <param name="req"><see cref="ResumeIntegrationTaskRequest"/></param>
        /// <returns><see cref="ResumeIntegrationTaskResponse"/></returns>
        public Task<ResumeIntegrationTaskResponse> ResumeIntegrationTask(ResumeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ResumeIntegrationTaskResponse>(req, "ResumeIntegrationTask");
        }

        /// <summary>
        /// Continue Integration Task
        /// </summary>
        /// <param name="req"><see cref="ResumeIntegrationTaskRequest"/></param>
        /// <returns><see cref="ResumeIntegrationTaskResponse"/></returns>
        public ResumeIntegrationTaskResponse ResumeIntegrationTaskSync(ResumeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ResumeIntegrationTaskResponse>(req, "ResumeIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Preemptive locking of integration tasks
        /// </summary>
        /// <param name="req"><see cref="RobAndLockIntegrationTaskRequest"/></param>
        /// <returns><see cref="RobAndLockIntegrationTaskResponse"/></returns>
        public Task<RobAndLockIntegrationTaskResponse> RobAndLockIntegrationTask(RobAndLockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<RobAndLockIntegrationTaskResponse>(req, "RobAndLockIntegrationTask");
        }

        /// <summary>
        /// Preemptive locking of integration tasks
        /// </summary>
        /// <param name="req"><see cref="RobAndLockIntegrationTaskRequest"/></param>
        /// <returns><see cref="RobAndLockIntegrationTaskResponse"/></returns>
        public RobAndLockIntegrationTaskResponse RobAndLockIntegrationTaskSync(RobAndLockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<RobAndLockIntegrationTaskResponse>(req, "RobAndLockIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Instance Batch Successfully Configured
        /// </summary>
        /// <param name="req"><see cref="RunForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunForceSucScheduleInstancesResponse"/></returns>
        public Task<RunForceSucScheduleInstancesResponse> RunForceSucScheduleInstances(RunForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunForceSucScheduleInstancesResponse>(req, "RunForceSucScheduleInstances");
        }

        /// <summary>
        /// Instance Batch Successfully Configured
        /// </summary>
        /// <param name="req"><see cref="RunForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunForceSucScheduleInstancesResponse"/></returns>
        public RunForceSucScheduleInstancesResponse RunForceSucScheduleInstancesSync(RunForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunForceSucScheduleInstancesResponse>(req, "RunForceSucScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Instance Batch Rerun
        /// </summary>
        /// <param name="req"><see cref="RunRerunScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunRerunScheduleInstancesResponse"/></returns>
        public Task<RunRerunScheduleInstancesResponse> RunRerunScheduleInstances(RunRerunScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunRerunScheduleInstancesResponse>(req, "RunRerunScheduleInstances");
        }

        /// <summary>
        /// Instance Batch Rerun
        /// </summary>
        /// <param name="req"><see cref="RunRerunScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunRerunScheduleInstancesResponse"/></returns>
        public RunRerunScheduleInstancesResponse RunRerunScheduleInstancesSync(RunRerunScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunRerunScheduleInstancesResponse>(req, "RunRerunScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch startup of workflows
        /// </summary>
        /// <param name="req"><see cref="RunTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="RunTasksByMultiWorkflowResponse"/></returns>
        public Task<RunTasksByMultiWorkflowResponse> RunTasksByMultiWorkflow(RunTasksByMultiWorkflowRequest req)
        {
            return InternalRequestAsync<RunTasksByMultiWorkflowResponse>(req, "RunTasksByMultiWorkflow");
        }

        /// <summary>
        /// Batch startup of workflows
        /// </summary>
        /// <param name="req"><see cref="RunTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="RunTasksByMultiWorkflowResponse"/></returns>
        public RunTasksByMultiWorkflowResponse RunTasksByMultiWorkflowSync(RunTasksByMultiWorkflowRequest req)
        {
            return InternalRequestAsync<RunTasksByMultiWorkflowResponse>(req, "RunTasksByMultiWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Save User-Defined Function
        /// </summary>
        /// <param name="req"><see cref="SaveCustomFunctionRequest"/></param>
        /// <returns><see cref="SaveCustomFunctionResponse"/></returns>
        public Task<SaveCustomFunctionResponse> SaveCustomFunction(SaveCustomFunctionRequest req)
        {
            return InternalRequestAsync<SaveCustomFunctionResponse>(req, "SaveCustomFunction");
        }

        /// <summary>
        /// Save User-Defined Function
        /// </summary>
        /// <param name="req"><see cref="SaveCustomFunctionRequest"/></param>
        /// <returns><see cref="SaveCustomFunctionResponse"/></returns>
        public SaveCustomFunctionResponse SaveCustomFunctionSync(SaveCustomFunctionRequest req)
        {
            return InternalRequestAsync<SaveCustomFunctionResponse>(req, "SaveCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Set Task Alerts, Create/Update Alert Information (Latest)
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public Task<SetTaskAlarmNewResponse> SetTaskAlarmNew(SetTaskAlarmNewRequest req)
        {
            return InternalRequestAsync<SetTaskAlarmNewResponse>(req, "SetTaskAlarmNew");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Set Task Alerts, Create/Update Alert Information (Latest)
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public SetTaskAlarmNewResponse SetTaskAlarmNewSync(SetTaskAlarmNewRequest req)
        {
            return InternalRequestAsync<SetTaskAlarmNewResponse>(req, "SetTaskAlarmNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Initiate Integration Task
        /// </summary>
        /// <param name="req"><see cref="StartIntegrationTaskRequest"/></param>
        /// <returns><see cref="StartIntegrationTaskResponse"/></returns>
        public Task<StartIntegrationTaskResponse> StartIntegrationTask(StartIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StartIntegrationTaskResponse>(req, "StartIntegrationTask");
        }

        /// <summary>
        /// Initiate Integration Task
        /// </summary>
        /// <param name="req"><see cref="StartIntegrationTaskRequest"/></param>
        /// <returns><see cref="StartIntegrationTaskResponse"/></returns>
        public StartIntegrationTaskResponse StartIntegrationTaskSync(StartIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StartIntegrationTaskResponse>(req, "StartIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop Integration Task
        /// </summary>
        /// <param name="req"><see cref="StopIntegrationTaskRequest"/></param>
        /// <returns><see cref="StopIntegrationTaskResponse"/></returns>
        public Task<StopIntegrationTaskResponse> StopIntegrationTask(StopIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StopIntegrationTaskResponse>(req, "StopIntegrationTask");
        }

        /// <summary>
        /// Stop Integration Task
        /// </summary>
        /// <param name="req"><see cref="StopIntegrationTaskRequest"/></param>
        /// <returns><see cref="StopIntegrationTaskResponse"/></returns>
        public StopIntegrationTaskResponse StopIntegrationTaskSync(StopIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StopIntegrationTaskResponse>(req, "StopIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit Custom Definition Function
        /// </summary>
        /// <param name="req"><see cref="SubmitCustomFunctionRequest"/></param>
        /// <returns><see cref="SubmitCustomFunctionResponse"/></returns>
        public Task<SubmitCustomFunctionResponse> SubmitCustomFunction(SubmitCustomFunctionRequest req)
        {
            return InternalRequestAsync<SubmitCustomFunctionResponse>(req, "SubmitCustomFunction");
        }

        /// <summary>
        /// Submit Custom Definition Function
        /// </summary>
        /// <param name="req"><see cref="SubmitCustomFunctionRequest"/></param>
        /// <returns><see cref="SubmitCustomFunctionResponse"/></returns>
        public SubmitCustomFunctionResponse SubmitCustomFunctionSync(SubmitCustomFunctionRequest req)
        {
            return InternalRequestAsync<SubmitCustomFunctionResponse>(req, "SubmitCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Ad Hoc Analysis - Submit SQL Task
        /// </summary>
        /// <param name="req"><see cref="SubmitSqlTaskRequest"/></param>
        /// <returns><see cref="SubmitSqlTaskResponse"/></returns>
        public Task<SubmitSqlTaskResponse> SubmitSqlTask(SubmitSqlTaskRequest req)
        {
            return InternalRequestAsync<SubmitSqlTaskResponse>(req, "SubmitSqlTask");
        }

        /// <summary>
        /// Ad Hoc Analysis - Submit SQL Task
        /// </summary>
        /// <param name="req"><see cref="SubmitSqlTaskRequest"/></param>
        /// <returns><see cref="SubmitSqlTaskResponse"/></returns>
        public SubmitSqlTaskResponse SubmitSqlTaskSync(SubmitSqlTaskRequest req)
        {
            return InternalRequestAsync<SubmitSqlTaskResponse>(req, "SubmitSqlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Submit a Task
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Submit a Task
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public SubmitTaskResponse SubmitTaskSync(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// No
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskTestRunRequest"/></param>
        /// <returns><see cref="SubmitTaskTestRunResponse"/></returns>
        public Task<SubmitTaskTestRunResponse> SubmitTaskTestRun(SubmitTaskTestRunRequest req)
        {
            return InternalRequestAsync<SubmitTaskTestRunResponse>(req, "SubmitTaskTestRun");
        }

        /// <summary>
        /// No
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskTestRunRequest"/></param>
        /// <returns><see cref="SubmitTaskTestRunResponse"/></returns>
        public SubmitTaskTestRunResponse SubmitTaskTestRunSync(SubmitTaskTestRunRequest req)
        {
            return InternalRequestAsync<SubmitTaskTestRunResponse>(req, "SubmitTaskTestRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit Workflow
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public Task<SubmitWorkflowResponse> SubmitWorkflow(SubmitWorkflowRequest req)
        {
            return InternalRequestAsync<SubmitWorkflowResponse>(req, "SubmitWorkflow");
        }

        /// <summary>
        /// Submit Workflow
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public SubmitWorkflowResponse SubmitWorkflowSync(SubmitWorkflowRequest req)
        {
            return InternalRequestAsync<SubmitWorkflowResponse>(req, "SubmitWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pause Integration Task
        /// </summary>
        /// <param name="req"><see cref="SuspendIntegrationTaskRequest"/></param>
        /// <returns><see cref="SuspendIntegrationTaskResponse"/></returns>
        public Task<SuspendIntegrationTaskResponse> SuspendIntegrationTask(SuspendIntegrationTaskRequest req)
        {
            return InternalRequestAsync<SuspendIntegrationTaskResponse>(req, "SuspendIntegrationTask");
        }

        /// <summary>
        /// Pause Integration Task
        /// </summary>
        /// <param name="req"><see cref="SuspendIntegrationTaskRequest"/></param>
        /// <returns><see cref="SuspendIntegrationTaskResponse"/></returns>
        public SuspendIntegrationTaskResponse SuspendIntegrationTaskSync(SuspendIntegrationTaskRequest req)
        {
            return InternalRequestAsync<SuspendIntegrationTaskResponse>(req, "SuspendIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Inlong Manager Logs
        /// </summary>
        /// <param name="req"><see cref="TaskLogRequest"/></param>
        /// <returns><see cref="TaskLogResponse"/></returns>
        public Task<TaskLogResponse> TaskLog(TaskLogRequest req)
        {
            return InternalRequestAsync<TaskLogResponse>(req, "TaskLog");
        }

        /// <summary>
        /// Query Inlong Manager Logs
        /// </summary>
        /// <param name="req"><see cref="TaskLogRequest"/></param>
        /// <returns><see cref="TaskLogResponse"/></returns>
        public TaskLogResponse TaskLogSync(TaskLogRequest req)
        {
            return InternalRequestAsync<TaskLogResponse>(req, "TaskLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Event Management - Triggered Events
        /// </summary>
        /// <param name="req"><see cref="TriggerDsEventRequest"/></param>
        /// <returns><see cref="TriggerDsEventResponse"/></returns>
        public Task<TriggerDsEventResponse> TriggerDsEvent(TriggerDsEventRequest req)
        {
            return InternalRequestAsync<TriggerDsEventResponse>(req, "TriggerDsEvent");
        }

        /// <summary>
        /// Event Management - Triggered Events
        /// </summary>
        /// <param name="req"><see cref="TriggerDsEventRequest"/></param>
        /// <returns><see cref="TriggerDsEventResponse"/></returns>
        public TriggerDsEventResponse TriggerDsEventSync(TriggerDsEventRequest req)
        {
            return InternalRequestAsync<TriggerDsEventResponse>(req, "TriggerDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Trigger events
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public Task<TriggerEventResponse> TriggerEvent(TriggerEventRequest req)
        {
            return InternalRequestAsync<TriggerEventResponse>(req, "TriggerEvent");
        }

        /// <summary>
        /// <p style="color:red;">[Note: This version is only available to a portion of allowlist customers in the Guangzhou Region]</p>
        /// Trigger events
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public TriggerEventResponse TriggerEventSync(TriggerEventRequest req)
        {
            return InternalRequestAsync<TriggerEventResponse>(req, "TriggerEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Unlock Integration Task
        /// </summary>
        /// <param name="req"><see cref="UnlockIntegrationTaskRequest"/></param>
        /// <returns><see cref="UnlockIntegrationTaskResponse"/></returns>
        public Task<UnlockIntegrationTaskResponse> UnlockIntegrationTask(UnlockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<UnlockIntegrationTaskResponse>(req, "UnlockIntegrationTask");
        }

        /// <summary>
        /// Unlock Integration Task
        /// </summary>
        /// <param name="req"><see cref="UnlockIntegrationTaskRequest"/></param>
        /// <returns><see cref="UnlockIntegrationTaskResponse"/></returns>
        public UnlockIntegrationTaskResponse UnlockIntegrationTaskSync(UnlockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<UnlockIntegrationTaskResponse>(req, "UnlockIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifying Workflow Person in Charge
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowOwnerRequest"/></param>
        /// <returns><see cref="UpdateWorkflowOwnerResponse"/></returns>
        public Task<UpdateWorkflowOwnerResponse> UpdateWorkflowOwner(UpdateWorkflowOwnerRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowOwnerResponse>(req, "UpdateWorkflowOwner");
        }

        /// <summary>
        /// Modifying Workflow Person in Charge
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowOwnerRequest"/></param>
        /// <returns><see cref="UpdateWorkflowOwnerResponse"/></returns>
        public UpdateWorkflowOwnerResponse UpdateWorkflowOwnerSync(UpdateWorkflowOwnerRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowOwnerResponse>(req, "UpdateWorkflowOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Save Task Information
        /// </summary>
        /// <param name="req"><see cref="UploadContentRequest"/></param>
        /// <returns><see cref="UploadContentResponse"/></returns>
        public Task<UploadContentResponse> UploadContent(UploadContentRequest req)
        {
            return InternalRequestAsync<UploadContentResponse>(req, "UploadContent");
        }

        /// <summary>
        /// Save Task Information
        /// </summary>
        /// <param name="req"><see cref="UploadContentRequest"/></param>
        /// <returns><see cref="UploadContentResponse"/></returns>
        public UploadContentResponse UploadContentSync(UploadContentRequest req)
        {
            return InternalRequestAsync<UploadContentResponse>(req, "UploadContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
