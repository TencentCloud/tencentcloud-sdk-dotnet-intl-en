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

namespace TencentCloud.Cfg.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfg.V20210820.Models;

   public class CfgClient : AbstractClient{

       private const string endpoint = "cfg.tencentcloudapi.com";
       private const string version = "2021-08-20";
       private const string sdkVersion = "SDK_NET_3.0.1001";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an experiment with an action.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromActionRequest"/></param>
        /// <returns><see cref="CreateTaskFromActionResponse"/></returns>
        public Task<CreateTaskFromActionResponse> CreateTaskFromAction(CreateTaskFromActionRequest req)
        {
            return InternalRequestAsync<CreateTaskFromActionResponse>(req, "CreateTaskFromAction");
        }

        /// <summary>
        /// This API is used to create an experiment with an action.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromActionRequest"/></param>
        /// <returns><see cref="CreateTaskFromActionResponse"/></returns>
        public CreateTaskFromActionResponse CreateTaskFromActionSync(CreateTaskFromActionRequest req)
        {
            return InternalRequestAsync<CreateTaskFromActionResponse>(req, "CreateTaskFromAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an experiment using a template.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskFromTemplateResponse"/></returns>
        public Task<CreateTaskFromTemplateResponse> CreateTaskFromTemplate(CreateTaskFromTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskFromTemplateResponse>(req, "CreateTaskFromTemplate");
        }

        /// <summary>
        /// This API is used to create an experiment using a template.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskFromTemplateResponse"/></returns>
        public CreateTaskFromTemplateResponse CreateTaskFromTemplateSync(CreateTaskFromTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskFromTemplateResponse>(req, "CreateTaskFromTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a task.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask");
        }

        /// <summary>
        /// This API is used to delete a task.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the dynamic configuration parameters of the action field based on action ID, including action-specific parameters and common parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionFieldConfigListRequest"/></param>
        /// <returns><see cref="DescribeActionFieldConfigListResponse"/></returns>
        public Task<DescribeActionFieldConfigListResponse> DescribeActionFieldConfigList(DescribeActionFieldConfigListRequest req)
        {
            return InternalRequestAsync<DescribeActionFieldConfigListResponse>(req, "DescribeActionFieldConfigList");
        }

        /// <summary>
        /// This API is used to obtain the dynamic configuration parameters of the action field based on action ID, including action-specific parameters and common parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionFieldConfigListRequest"/></param>
        /// <returns><see cref="DescribeActionFieldConfigListResponse"/></returns>
        public DescribeActionFieldConfigListResponse DescribeActionFieldConfigListSync(DescribeActionFieldConfigListRequest req)
        {
            return InternalRequestAsync<DescribeActionFieldConfigListResponse>(req, "DescribeActionFieldConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the action list of Chaotic Fault Generator.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLibraryListRequest"/></param>
        /// <returns><see cref="DescribeActionLibraryListResponse"/></returns>
        public Task<DescribeActionLibraryListResponse> DescribeActionLibraryList(DescribeActionLibraryListRequest req)
        {
            return InternalRequestAsync<DescribeActionLibraryListResponse>(req, "DescribeActionLibraryList");
        }

        /// <summary>
        /// This API is used to obtain the action list of Chaotic Fault Generator.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLibraryListRequest"/></param>
        /// <returns><see cref="DescribeActionLibraryListResponse"/></returns>
        public DescribeActionLibraryListResponse DescribeActionLibraryListSync(DescribeActionLibraryListRequest req)
        {
            return InternalRequestAsync<DescribeActionLibraryListResponse>(req, "DescribeActionLibraryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the object type list.
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectTypeListRequest"/></param>
        /// <returns><see cref="DescribeObjectTypeListResponse"/></returns>
        public Task<DescribeObjectTypeListResponse> DescribeObjectTypeList(DescribeObjectTypeListRequest req)
        {
            return InternalRequestAsync<DescribeObjectTypeListResponse>(req, "DescribeObjectTypeList");
        }

        /// <summary>
        /// This API is used to query the object type list.
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectTypeListRequest"/></param>
        /// <returns><see cref="DescribeObjectTypeListResponse"/></returns>
        public DescribeObjectTypeListResponse DescribeObjectTypeListSync(DescribeObjectTypeListRequest req)
        {
            return InternalRequestAsync<DescribeObjectTypeListResponse>(req, "DescribeObjectTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask");
        }

        /// <summary>
        /// This API is used to query a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all logs generated during an experiment.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskExecuteLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskExecuteLogsResponse"/></returns>
        public Task<DescribeTaskExecuteLogsResponse> DescribeTaskExecuteLogs(DescribeTaskExecuteLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskExecuteLogsResponse>(req, "DescribeTaskExecuteLogs");
        }

        /// <summary>
        /// This API is used to obtain all logs generated during an experiment.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskExecuteLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskExecuteLogsResponse"/></returns>
        public DescribeTaskExecuteLogsResponse DescribeTaskExecuteLogsSync(DescribeTaskExecuteLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskExecuteLogsResponse>(req, "DescribeTaskExecuteLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList");
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the guardrail triggering logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPolicyTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeTaskPolicyTriggerLogResponse"/></returns>
        public Task<DescribeTaskPolicyTriggerLogResponse> DescribeTaskPolicyTriggerLog(DescribeTaskPolicyTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskPolicyTriggerLogResponse>(req, "DescribeTaskPolicyTriggerLog");
        }

        /// <summary>
        /// This API is used to obtain the guardrail triggering logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPolicyTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeTaskPolicyTriggerLogResponse"/></returns>
        public DescribeTaskPolicyTriggerLogResponse DescribeTaskPolicyTriggerLogSync(DescribeTaskPolicyTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskPolicyTriggerLogResponse>(req, "DescribeTaskPolicyTriggerLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a template library.
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public Task<DescribeTemplateResponse> DescribeTemplate(DescribeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeTemplateResponse>(req, "DescribeTemplate");
        }

        /// <summary>
        /// This API is used to query a template library.
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public DescribeTemplateResponse DescribeTemplateSync(DescribeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeTemplateResponse>(req, "DescribeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeTemplateListResponse>(req, "DescribeTemplateList");
        }

        /// <summary>
        /// This API is used to query the template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public DescribeTemplateListResponse DescribeTemplateListSync(DescribeTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeTemplateListResponse>(req, "DescribeTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to run a task.
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public Task<ExecuteTaskResponse> ExecuteTask(ExecuteTaskRequest req)
        {
            return InternalRequestAsync<ExecuteTaskResponse>(req, "ExecuteTask");
        }

        /// <summary>
        /// This API is used to run a task.
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public ExecuteTaskResponse ExecuteTaskSync(ExecuteTaskRequest req)
        {
            return InternalRequestAsync<ExecuteTaskResponse>(req, "ExecuteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger the action of the chaos engineering experiment and perform an experiment on the instance.
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskInstanceRequest"/></param>
        /// <returns><see cref="ExecuteTaskInstanceResponse"/></returns>
        public Task<ExecuteTaskInstanceResponse> ExecuteTaskInstance(ExecuteTaskInstanceRequest req)
        {
            return InternalRequestAsync<ExecuteTaskInstanceResponse>(req, "ExecuteTaskInstance");
        }

        /// <summary>
        /// This API is used to trigger the action of the chaos engineering experiment and perform an experiment on the instance.
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskInstanceRequest"/></param>
        /// <returns><see cref="ExecuteTaskInstanceResponse"/></returns>
        public ExecuteTaskInstanceResponse ExecuteTaskInstanceSync(ExecuteTaskInstanceRequest req)
        {
            return InternalRequestAsync<ExecuteTaskInstanceResponse>(req, "ExecuteTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the task running status.
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRunStatusRequest"/></param>
        /// <returns><see cref="ModifyTaskRunStatusResponse"/></returns>
        public Task<ModifyTaskRunStatusResponse> ModifyTaskRunStatus(ModifyTaskRunStatusRequest req)
        {
            return InternalRequestAsync<ModifyTaskRunStatusResponse>(req, "ModifyTaskRunStatus");
        }

        /// <summary>
        /// This API is used to change the task running status.
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRunStatusRequest"/></param>
        /// <returns><see cref="ModifyTaskRunStatusResponse"/></returns>
        public ModifyTaskRunStatusResponse ModifyTaskRunStatusSync(ModifyTaskRunStatusRequest req)
        {
            return InternalRequestAsync<ModifyTaskRunStatusResponse>(req, "ModifyTaskRunStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger the chaos engineering experiment guardrail (two types: trigger and recovery).
        /// </summary>
        /// <param name="req"><see cref="TriggerPolicyRequest"/></param>
        /// <returns><see cref="TriggerPolicyResponse"/></returns>
        public Task<TriggerPolicyResponse> TriggerPolicy(TriggerPolicyRequest req)
        {
            return InternalRequestAsync<TriggerPolicyResponse>(req, "TriggerPolicy");
        }

        /// <summary>
        /// This API is used to trigger the chaos engineering experiment guardrail (two types: trigger and recovery).
        /// </summary>
        /// <param name="req"><see cref="TriggerPolicyRequest"/></param>
        /// <returns><see cref="TriggerPolicyResponse"/></returns>
        public TriggerPolicyResponse TriggerPolicySync(TriggerPolicyRequest req)
        {
            return InternalRequestAsync<TriggerPolicyResponse>(req, "TriggerPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
