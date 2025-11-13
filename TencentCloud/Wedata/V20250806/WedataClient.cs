/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20250806
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20250806.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.intl.tencentcloudapi.com";
       private const string version = "2025-08-06";
       private const string sdkVersion = "SDK_NET_3.0.1237";

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
        /// This API is used to create a code file.
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFileRequest"/></param>
        /// <returns><see cref="CreateCodeFileResponse"/></returns>
        public Task<CreateCodeFileResponse> CreateCodeFile(CreateCodeFileRequest req)
        {
            return InternalRequestAsync<CreateCodeFileResponse>(req, "CreateCodeFile");
        }

        /// <summary>
        /// This API is used to create a code file.
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFileRequest"/></param>
        /// <returns><see cref="CreateCodeFileResponse"/></returns>
        public CreateCodeFileResponse CreateCodeFileSync(CreateCodeFileRequest req)
        {
            return InternalRequestAsync<CreateCodeFileResponse>(req, "CreateCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a code folder.
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFolderRequest"/></param>
        /// <returns><see cref="CreateCodeFolderResponse"/></returns>
        public Task<CreateCodeFolderResponse> CreateCodeFolder(CreateCodeFolderRequest req)
        {
            return InternalRequestAsync<CreateCodeFolderResponse>(req, "CreateCodeFolder");
        }

        /// <summary>
        /// This API is used to create a code folder.
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFolderRequest"/></param>
        /// <returns><see cref="CreateCodeFolderResponse"/></returns>
        public CreateCodeFolderResponse CreateCodeFolderSync(CreateCodeFolderRequest req)
        {
            return InternalRequestAsync<CreateCodeFolderResponse>(req, "CreateCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data backfill plan.
        /// </summary>
        /// <param name="req"><see cref="CreateDataBackfillPlanRequest"/></param>
        /// <returns><see cref="CreateDataBackfillPlanResponse"/></returns>
        public Task<CreateDataBackfillPlanResponse> CreateDataBackfillPlan(CreateDataBackfillPlanRequest req)
        {
            return InternalRequestAsync<CreateDataBackfillPlanResponse>(req, "CreateDataBackfillPlan");
        }

        /// <summary>
        /// This API is used to create a data backfill plan.
        /// </summary>
        /// <param name="req"><see cref="CreateDataBackfillPlanRequest"/></param>
        /// <returns><see cref="CreateDataBackfillPlanResponse"/></returns>
        public CreateDataBackfillPlanResponse CreateDataBackfillPlanSync(CreateDataBackfillPlanRequest req)
        {
            return InternalRequestAsync<CreateDataBackfillPlanResponse>(req, "CreateDataBackfillPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set alarm rules.
        /// </summary>
        /// <param name="req"><see cref="CreateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="CreateOpsAlarmRuleResponse"/></returns>
        public Task<CreateOpsAlarmRuleResponse> CreateOpsAlarmRule(CreateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<CreateOpsAlarmRuleResponse>(req, "CreateOpsAlarmRule");
        }

        /// <summary>
        /// This API is used to set alarm rules.
        /// </summary>
        /// <param name="req"><see cref="CreateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="CreateOpsAlarmRuleResponse"/></returns>
        public CreateOpsAlarmRuleResponse CreateOpsAlarmRuleSync(CreateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<CreateOpsAlarmRuleResponse>(req, "CreateOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a resource file.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFileRequest"/></param>
        /// <returns><see cref="CreateResourceFileResponse"/></returns>
        public Task<CreateResourceFileResponse> CreateResourceFile(CreateResourceFileRequest req)
        {
            return InternalRequestAsync<CreateResourceFileResponse>(req, "CreateResourceFile");
        }

        /// <summary>
        /// This API is used to create a resource file.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFileRequest"/></param>
        /// <returns><see cref="CreateResourceFileResponse"/></returns>
        public CreateResourceFileResponse CreateResourceFileSync(CreateResourceFileRequest req)
        {
            return InternalRequestAsync<CreateResourceFileResponse>(req, "CreateResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a resource file folder.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFolderRequest"/></param>
        /// <returns><see cref="CreateResourceFolderResponse"/></returns>
        public Task<CreateResourceFolderResponse> CreateResourceFolder(CreateResourceFolderRequest req)
        {
            return InternalRequestAsync<CreateResourceFolderResponse>(req, "CreateResourceFolder");
        }

        /// <summary>
        /// This API is used to create a resource file folder.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFolderRequest"/></param>
        /// <returns><see cref="CreateResourceFolderResponse"/></returns>
        public CreateResourceFolderResponse CreateResourceFolderSync(CreateResourceFolderRequest req)
        {
            return InternalRequestAsync<CreateResourceFolderResponse>(req, "CreateResourceFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an SQL folder
        /// </summary>
        /// <param name="req"><see cref="CreateSQLFolderRequest"/></param>
        /// <returns><see cref="CreateSQLFolderResponse"/></returns>
        public Task<CreateSQLFolderResponse> CreateSQLFolder(CreateSQLFolderRequest req)
        {
            return InternalRequestAsync<CreateSQLFolderResponse>(req, "CreateSQLFolder");
        }

        /// <summary>
        /// This API is used to create an SQL folder
        /// </summary>
        /// <param name="req"><see cref="CreateSQLFolderRequest"/></param>
        /// <returns><see cref="CreateSQLFolderResponse"/></returns>
        public CreateSQLFolderResponse CreateSQLFolderSync(CreateSQLFolderRequest req)
        {
            return InternalRequestAsync<CreateSQLFolderResponse>(req, "CreateSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an SQL script.
        /// </summary>
        /// <param name="req"><see cref="CreateSQLScriptRequest"/></param>
        /// <returns><see cref="CreateSQLScriptResponse"/></returns>
        public Task<CreateSQLScriptResponse> CreateSQLScript(CreateSQLScriptRequest req)
        {
            return InternalRequestAsync<CreateSQLScriptResponse>(req, "CreateSQLScript");
        }

        /// <summary>
        /// This API is used to add an SQL script.
        /// </summary>
        /// <param name="req"><see cref="CreateSQLScriptRequest"/></param>
        /// <returns><see cref="CreateSQLScriptResponse"/></returns>
        public CreateSQLScriptResponse CreateSQLScriptSync(CreateSQLScriptRequest req)
        {
            return InternalRequestAsync<CreateSQLScriptResponse>(req, "CreateSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// This API is used to create a task.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create workflow.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow");
        }

        /// <summary>
        /// This API is used to create workflow.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a workflow folder.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowFolderRequest"/></param>
        /// <returns><see cref="CreateWorkflowFolderResponse"/></returns>
        public Task<CreateWorkflowFolderResponse> CreateWorkflowFolder(CreateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<CreateWorkflowFolderResponse>(req, "CreateWorkflowFolder");
        }

        /// <summary>
        /// This API is used to create a workflow folder.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowFolderRequest"/></param>
        /// <returns><see cref="CreateWorkflowFolderResponse"/></returns>
        public CreateWorkflowFolderResponse CreateWorkflowFolderSync(CreateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<CreateWorkflowFolderResponse>(req, "CreateWorkflowFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a code file.
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFileRequest"/></param>
        /// <returns><see cref="DeleteCodeFileResponse"/></returns>
        public Task<DeleteCodeFileResponse> DeleteCodeFile(DeleteCodeFileRequest req)
        {
            return InternalRequestAsync<DeleteCodeFileResponse>(req, "DeleteCodeFile");
        }

        /// <summary>
        /// This API is used to delete a code file.
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFileRequest"/></param>
        /// <returns><see cref="DeleteCodeFileResponse"/></returns>
        public DeleteCodeFileResponse DeleteCodeFileSync(DeleteCodeFileRequest req)
        {
            return InternalRequestAsync<DeleteCodeFileResponse>(req, "DeleteCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete folders in data exploration.
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFolderRequest"/></param>
        /// <returns><see cref="DeleteCodeFolderResponse"/></returns>
        public Task<DeleteCodeFolderResponse> DeleteCodeFolder(DeleteCodeFolderRequest req)
        {
            return InternalRequestAsync<DeleteCodeFolderResponse>(req, "DeleteCodeFolder");
        }

        /// <summary>
        /// This API is used to delete folders in data exploration.
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFolderRequest"/></param>
        /// <returns><see cref="DeleteCodeFolderResponse"/></returns>
        public DeleteCodeFolderResponse DeleteCodeFolderSync(DeleteCodeFolderRequest req)
        {
            return InternalRequestAsync<DeleteCodeFolderResponse>(req, "DeleteCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes alarm rules
        /// </summary>
        /// <param name="req"><see cref="DeleteOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="DeleteOpsAlarmRuleResponse"/></returns>
        public Task<DeleteOpsAlarmRuleResponse> DeleteOpsAlarmRule(DeleteOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<DeleteOpsAlarmRuleResponse>(req, "DeleteOpsAlarmRule");
        }

        /// <summary>
        /// Deletes alarm rules
        /// </summary>
        /// <param name="req"><see cref="DeleteOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="DeleteOpsAlarmRuleResponse"/></returns>
        public DeleteOpsAlarmRuleResponse DeleteOpsAlarmRuleSync(DeleteOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<DeleteOpsAlarmRuleResponse>(req, "DeleteOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a resource file.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public Task<DeleteResourceFileResponse> DeleteResourceFile(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile");
        }

        /// <summary>
        /// This API is used to delete a resource file.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public DeleteResourceFileResponse DeleteResourceFileSync(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a resource folder.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFolderRequest"/></param>
        /// <returns><see cref="DeleteResourceFolderResponse"/></returns>
        public Task<DeleteResourceFolderResponse> DeleteResourceFolder(DeleteResourceFolderRequest req)
        {
            return InternalRequestAsync<DeleteResourceFolderResponse>(req, "DeleteResourceFolder");
        }

        /// <summary>
        /// This API is used to delete a resource folder.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFolderRequest"/></param>
        /// <returns><see cref="DeleteResourceFolderResponse"/></returns>
        public DeleteResourceFolderResponse DeleteResourceFolderSync(DeleteResourceFolderRequest req)
        {
            return InternalRequestAsync<DeleteResourceFolderResponse>(req, "DeleteResourceFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a SQL folder.
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLFolderRequest"/></param>
        /// <returns><see cref="DeleteSQLFolderResponse"/></returns>
        public Task<DeleteSQLFolderResponse> DeleteSQLFolder(DeleteSQLFolderRequest req)
        {
            return InternalRequestAsync<DeleteSQLFolderResponse>(req, "DeleteSQLFolder");
        }

        /// <summary>
        /// This API is used to delete a SQL folder.
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLFolderRequest"/></param>
        /// <returns><see cref="DeleteSQLFolderResponse"/></returns>
        public DeleteSQLFolderResponse DeleteSQLFolderSync(DeleteSQLFolderRequest req)
        {
            return InternalRequestAsync<DeleteSQLFolderResponse>(req, "DeleteSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an SQL script.
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLScriptRequest"/></param>
        /// <returns><see cref="DeleteSQLScriptResponse"/></returns>
        public Task<DeleteSQLScriptResponse> DeleteSQLScript(DeleteSQLScriptRequest req)
        {
            return InternalRequestAsync<DeleteSQLScriptResponse>(req, "DeleteSQLScript");
        }

        /// <summary>
        /// This API is used to delete an SQL script.
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLScriptRequest"/></param>
        /// <returns><see cref="DeleteSQLScriptResponse"/></returns>
        public DeleteSQLScriptResponse DeleteSQLScriptSync(DeleteSQLScriptRequest req)
        {
            return InternalRequestAsync<DeleteSQLScriptResponse>(req, "DeleteSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an orchestration space task.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask");
        }

        /// <summary>
        /// This API is used to delete an orchestration space task.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a workflow
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow");
        }

        /// <summary>
        /// Deletes a workflow
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public DeleteWorkflowResponse DeleteWorkflowSync(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a data development folder
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowFolderRequest"/></param>
        /// <returns><see cref="DeleteWorkflowFolderResponse"/></returns>
        public Task<DeleteWorkflowFolderResponse> DeleteWorkflowFolder(DeleteWorkflowFolderRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowFolderResponse>(req, "DeleteWorkflowFolder");
        }

        /// <summary>
        /// This API is used to delete a data development folder
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowFolderRequest"/></param>
        /// <returns><see cref="DeleteWorkflowFolderResponse"/></returns>
        public DeleteWorkflowFolderResponse DeleteWorkflowFolderSync(DeleteWorkflowFolderRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowFolderResponse>(req, "DeleteWorkflowFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query alert information details.
        /// </summary>
        /// <param name="req"><see cref="GetAlarmMessageRequest"/></param>
        /// <returns><see cref="GetAlarmMessageResponse"/></returns>
        public Task<GetAlarmMessageResponse> GetAlarmMessage(GetAlarmMessageRequest req)
        {
            return InternalRequestAsync<GetAlarmMessageResponse>(req, "GetAlarmMessage");
        }

        /// <summary>
        /// This API is used to query alert information details.
        /// </summary>
        /// <param name="req"><see cref="GetAlarmMessageRequest"/></param>
        /// <returns><see cref="GetAlarmMessageResponse"/></returns>
        public GetAlarmMessageResponse GetAlarmMessageSync(GetAlarmMessageRequest req)
        {
            return InternalRequestAsync<GetAlarmMessageResponse>(req, "GetAlarmMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view code file details.
        /// </summary>
        /// <param name="req"><see cref="GetCodeFileRequest"/></param>
        /// <returns><see cref="GetCodeFileResponse"/></returns>
        public Task<GetCodeFileResponse> GetCodeFile(GetCodeFileRequest req)
        {
            return InternalRequestAsync<GetCodeFileResponse>(req, "GetCodeFile");
        }

        /// <summary>
        /// This API is used to view code file details.
        /// </summary>
        /// <param name="req"><see cref="GetCodeFileRequest"/></param>
        /// <returns><see cref="GetCodeFileResponse"/></returns>
        public GetCodeFileResponse GetCodeFileSync(GetCodeFileRequest req)
        {
            return InternalRequestAsync<GetCodeFileResponse>(req, "GetCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query alert rule information based on alarm rule id or name.
        /// </summary>
        /// <param name="req"><see cref="GetOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="GetOpsAlarmRuleResponse"/></returns>
        public Task<GetOpsAlarmRuleResponse> GetOpsAlarmRule(GetOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<GetOpsAlarmRuleResponse>(req, "GetOpsAlarmRule");
        }

        /// <summary>
        /// This API is used to query alert rule information based on alarm rule id or name.
        /// </summary>
        /// <param name="req"><see cref="GetOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="GetOpsAlarmRuleResponse"/></returns>
        public GetOpsAlarmRuleResponse GetOpsAlarmRuleSync(GetOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<GetOpsAlarmRuleResponse>(req, "GetOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query async operation details in Ops center.
        /// </summary>
        /// <param name="req"><see cref="GetOpsAsyncJobRequest"/></param>
        /// <returns><see cref="GetOpsAsyncJobResponse"/></returns>
        public Task<GetOpsAsyncJobResponse> GetOpsAsyncJob(GetOpsAsyncJobRequest req)
        {
            return InternalRequestAsync<GetOpsAsyncJobResponse>(req, "GetOpsAsyncJob");
        }

        /// <summary>
        /// This API is used to query async operation details in Ops center.
        /// </summary>
        /// <param name="req"><see cref="GetOpsAsyncJobRequest"/></param>
        /// <returns><see cref="GetOpsAsyncJobResponse"/></returns>
        public GetOpsAsyncJobResponse GetOpsAsyncJobSync(GetOpsAsyncJobRequest req)
        {
            return InternalRequestAsync<GetOpsAsyncJobResponse>(req, "GetOpsAsyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtaining Task Details
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskRequest"/></param>
        /// <returns><see cref="GetOpsTaskResponse"/></returns>
        public Task<GetOpsTaskResponse> GetOpsTask(GetOpsTaskRequest req)
        {
            return InternalRequestAsync<GetOpsTaskResponse>(req, "GetOpsTask");
        }

        /// <summary>
        /// Obtaining Task Details
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskRequest"/></param>
        /// <returns><see cref="GetOpsTaskResponse"/></returns>
        public GetOpsTaskResponse GetOpsTaskSync(GetOpsTaskRequest req)
        {
            return InternalRequestAsync<GetOpsTaskResponse>(req, "GetOpsTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve task code.
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskCodeRequest"/></param>
        /// <returns><see cref="GetOpsTaskCodeResponse"/></returns>
        public Task<GetOpsTaskCodeResponse> GetOpsTaskCode(GetOpsTaskCodeRequest req)
        {
            return InternalRequestAsync<GetOpsTaskCodeResponse>(req, "GetOpsTaskCode");
        }

        /// <summary>
        /// This API is used to retrieve task code.
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskCodeRequest"/></param>
        /// <returns><see cref="GetOpsTaskCodeResponse"/></returns>
        public GetOpsTaskCodeResponse GetOpsTaskCodeSync(GetOpsTaskCodeRequest req)
        {
            return InternalRequestAsync<GetOpsTaskCodeResponse>(req, "GetOpsTaskCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain workflow scheduling details based on the workflow id.
        /// </summary>
        /// <param name="req"><see cref="GetOpsWorkflowRequest"/></param>
        /// <returns><see cref="GetOpsWorkflowResponse"/></returns>
        public Task<GetOpsWorkflowResponse> GetOpsWorkflow(GetOpsWorkflowRequest req)
        {
            return InternalRequestAsync<GetOpsWorkflowResponse>(req, "GetOpsWorkflow");
        }

        /// <summary>
        /// This API is used to obtain workflow scheduling details based on the workflow id.
        /// </summary>
        /// <param name="req"><see cref="GetOpsWorkflowRequest"/></param>
        /// <returns><see cref="GetOpsWorkflowResponse"/></returns>
        public GetOpsWorkflowResponse GetOpsWorkflowSync(GetOpsWorkflowRequest req)
        {
            return InternalRequestAsync<GetOpsWorkflowResponse>(req, "GetOpsWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain resource file details.
        /// </summary>
        /// <param name="req"><see cref="GetResourceFileRequest"/></param>
        /// <returns><see cref="GetResourceFileResponse"/></returns>
        public Task<GetResourceFileResponse> GetResourceFile(GetResourceFileRequest req)
        {
            return InternalRequestAsync<GetResourceFileResponse>(req, "GetResourceFile");
        }

        /// <summary>
        /// This API is used to obtain resource file details.
        /// </summary>
        /// <param name="req"><see cref="GetResourceFileRequest"/></param>
        /// <returns><see cref="GetResourceFileResponse"/></returns>
        public GetResourceFileResponse GetResourceFileSync(GetResourceFileRequest req)
        {
            return InternalRequestAsync<GetResourceFileResponse>(req, "GetResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query script details.
        /// </summary>
        /// <param name="req"><see cref="GetSQLScriptRequest"/></param>
        /// <returns><see cref="GetSQLScriptResponse"/></returns>
        public Task<GetSQLScriptResponse> GetSQLScript(GetSQLScriptRequest req)
        {
            return InternalRequestAsync<GetSQLScriptResponse>(req, "GetSQLScript");
        }

        /// <summary>
        /// This API is used to query script details.
        /// </summary>
        /// <param name="req"><see cref="GetSQLScriptRequest"/></param>
        /// <returns><see cref="GetSQLScriptResponse"/></returns>
        public GetSQLScriptResponse GetSQLScriptSync(GetSQLScriptRequest req)
        {
            return InternalRequestAsync<GetSQLScriptResponse>(req, "GetSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve task details.
        /// </summary>
        /// <param name="req"><see cref="GetTaskRequest"/></param>
        /// <returns><see cref="GetTaskResponse"/></returns>
        public Task<GetTaskResponse> GetTask(GetTaskRequest req)
        {
            return InternalRequestAsync<GetTaskResponse>(req, "GetTask");
        }

        /// <summary>
        /// This API is used to retrieve task details.
        /// </summary>
        /// <param name="req"><see cref="GetTaskRequest"/></param>
        /// <returns><see cref="GetTaskResponse"/></returns>
        public GetTaskResponse GetTaskSync(GetTaskRequest req)
        {
            return InternalRequestAsync<GetTaskResponse>(req, "GetTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain task code.
        /// </summary>
        /// <param name="req"><see cref="GetTaskCodeRequest"/></param>
        /// <returns><see cref="GetTaskCodeResponse"/></returns>
        public Task<GetTaskCodeResponse> GetTaskCode(GetTaskCodeRequest req)
        {
            return InternalRequestAsync<GetTaskCodeResponse>(req, "GetTaskCode");
        }

        /// <summary>
        /// This API is used to obtain task code.
        /// </summary>
        /// <param name="req"><see cref="GetTaskCodeRequest"/></param>
        /// <returns><see cref="GetTaskCodeResponse"/></returns>
        public GetTaskCodeResponse GetTaskCodeSync(GetTaskCodeRequest req)
        {
            return InternalRequestAsync<GetTaskCodeResponse>(req, "GetTaskCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a scheduling instance.
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceRequest"/></param>
        /// <returns><see cref="GetTaskInstanceResponse"/></returns>
        public Task<GetTaskInstanceResponse> GetTaskInstance(GetTaskInstanceRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceResponse>(req, "GetTaskInstance");
        }

        /// <summary>
        /// This API is used to query the details of a scheduling instance.
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceRequest"/></param>
        /// <returns><see cref="GetTaskInstanceResponse"/></returns>
        public GetTaskInstanceResponse GetTaskInstanceSync(GetTaskInstanceRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceResponse>(req, "GetTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain instance lists.
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceLogRequest"/></param>
        /// <returns><see cref="GetTaskInstanceLogResponse"/></returns>
        public Task<GetTaskInstanceLogResponse> GetTaskInstanceLog(GetTaskInstanceLogRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceLogResponse>(req, "GetTaskInstanceLog");
        }

        /// <summary>
        /// This API is used to obtain instance lists.
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceLogRequest"/></param>
        /// <returns><see cref="GetTaskInstanceLogResponse"/></returns>
        public GetTaskInstanceLogResponse GetTaskInstanceLogSync(GetTaskInstanceLogRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceLogResponse>(req, "GetTaskInstanceLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list task versions.
        /// </summary>
        /// <param name="req"><see cref="GetTaskVersionRequest"/></param>
        /// <returns><see cref="GetTaskVersionResponse"/></returns>
        public Task<GetTaskVersionResponse> GetTaskVersion(GetTaskVersionRequest req)
        {
            return InternalRequestAsync<GetTaskVersionResponse>(req, "GetTaskVersion");
        }

        /// <summary>
        /// This API is used to list task versions.
        /// </summary>
        /// <param name="req"><see cref="GetTaskVersionRequest"/></param>
        /// <returns><see cref="GetTaskVersionResponse"/></returns>
        public GetTaskVersionResponse GetTaskVersionSync(GetTaskVersionRequest req)
        {
            return InternalRequestAsync<GetTaskVersionResponse>(req, "GetTaskVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve workflow information.
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public Task<GetWorkflowResponse> GetWorkflow(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow");
        }

        /// <summary>
        /// This API is used to retrieve workflow information.
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public GetWorkflowResponse GetWorkflowSync(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate instances in batches asynchronously.
        /// </summary>
        /// <param name="req"><see cref="KillTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="KillTaskInstancesAsyncResponse"/></returns>
        public Task<KillTaskInstancesAsyncResponse> KillTaskInstancesAsync(KillTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<KillTaskInstancesAsyncResponse>(req, "KillTaskInstancesAsync");
        }

        /// <summary>
        /// This API is used to terminate instances in batches asynchronously.
        /// </summary>
        /// <param name="req"><see cref="KillTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="KillTaskInstancesAsyncResponse"/></returns>
        public KillTaskInstancesAsyncResponse KillTaskInstancesAsyncSync(KillTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<KillTaskInstancesAsyncResponse>(req, "KillTaskInstancesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search the alarm information list.
        /// </summary>
        /// <param name="req"><see cref="ListAlarmMessagesRequest"/></param>
        /// <returns><see cref="ListAlarmMessagesResponse"/></returns>
        public Task<ListAlarmMessagesResponse> ListAlarmMessages(ListAlarmMessagesRequest req)
        {
            return InternalRequestAsync<ListAlarmMessagesResponse>(req, "ListAlarmMessages");
        }

        /// <summary>
        /// This API is used to search the alarm information list.
        /// </summary>
        /// <param name="req"><see cref="ListAlarmMessagesRequest"/></param>
        /// <returns><see cref="ListAlarmMessagesResponse"/></returns>
        public ListAlarmMessagesResponse ListAlarmMessagesSync(ListAlarmMessagesRequest req)
        {
            return InternalRequestAsync<ListAlarmMessagesResponse>(req, "ListAlarmMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get folder content.
        /// </summary>
        /// <param name="req"><see cref="ListCodeFolderContentsRequest"/></param>
        /// <returns><see cref="ListCodeFolderContentsResponse"/></returns>
        public Task<ListCodeFolderContentsResponse> ListCodeFolderContents(ListCodeFolderContentsRequest req)
        {
            return InternalRequestAsync<ListCodeFolderContentsResponse>(req, "ListCodeFolderContents");
        }

        /// <summary>
        /// This API is used to get folder content.
        /// </summary>
        /// <param name="req"><see cref="ListCodeFolderContentsRequest"/></param>
        /// <returns><see cref="ListCodeFolderContentsResponse"/></returns>
        public ListCodeFolderContentsResponse ListCodeFolderContentsSync(ListCodeFolderContentsRequest req)
        {
            return InternalRequestAsync<ListCodeFolderContentsResponse>(req, "ListCodeFolderContents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve all instances of a single backfill.
        /// </summary>
        /// <param name="req"><see cref="ListDataBackfillInstancesRequest"/></param>
        /// <returns><see cref="ListDataBackfillInstancesResponse"/></returns>
        public Task<ListDataBackfillInstancesResponse> ListDataBackfillInstances(ListDataBackfillInstancesRequest req)
        {
            return InternalRequestAsync<ListDataBackfillInstancesResponse>(req, "ListDataBackfillInstances");
        }

        /// <summary>
        /// This API is used to retrieve all instances of a single backfill.
        /// </summary>
        /// <param name="req"><see cref="ListDataBackfillInstancesRequest"/></param>
        /// <returns><see cref="ListDataBackfillInstancesResponse"/></returns>
        public ListDataBackfillInstancesResponse ListDataBackfillInstancesSync(ListDataBackfillInstancesRequest req)
        {
            return InternalRequestAsync<ListDataBackfillInstancesResponse>(req, "ListDataBackfillInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve task direct downstream details.
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamOpsTasksResponse"/></returns>
        public Task<ListDownstreamOpsTasksResponse> ListDownstreamOpsTasks(ListDownstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamOpsTasksResponse>(req, "ListDownstreamOpsTasks");
        }

        /// <summary>
        /// This API is used to retrieve task direct downstream details.
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamOpsTasksResponse"/></returns>
        public ListDownstreamOpsTasksResponse ListDownstreamOpsTasksSync(ListDownstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamOpsTasksResponse>(req, "ListDownstreamOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the direct upstream of an instance.
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListDownstreamTaskInstancesResponse"/></returns>
        public Task<ListDownstreamTaskInstancesResponse> ListDownstreamTaskInstances(ListDownstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListDownstreamTaskInstancesResponse>(req, "ListDownstreamTaskInstances");
        }

        /// <summary>
        /// This API is used to get the direct upstream of an instance.
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListDownstreamTaskInstancesResponse"/></returns>
        public ListDownstreamTaskInstancesResponse ListDownstreamTaskInstancesSync(ListDownstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListDownstreamTaskInstancesResponse>(req, "ListDownstreamTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the direct downstream task details.
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamTasksResponse"/></returns>
        public Task<ListDownstreamTasksResponse> ListDownstreamTasks(ListDownstreamTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamTasksResponse>(req, "ListDownstreamTasks");
        }

        /// <summary>
        /// This API is used to retrieve the direct downstream task details.
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamTasksResponse"/></returns>
        public ListDownstreamTasksResponse ListDownstreamTasksSync(ListDownstreamTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamTasksResponse>(req, "ListDownstreamTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the alarm rule list.
        /// </summary>
        /// <param name="req"><see cref="ListOpsAlarmRulesRequest"/></param>
        /// <returns><see cref="ListOpsAlarmRulesResponse"/></returns>
        public Task<ListOpsAlarmRulesResponse> ListOpsAlarmRules(ListOpsAlarmRulesRequest req)
        {
            return InternalRequestAsync<ListOpsAlarmRulesResponse>(req, "ListOpsAlarmRules");
        }

        /// <summary>
        /// This API is used to query the alarm rule list.
        /// </summary>
        /// <param name="req"><see cref="ListOpsAlarmRulesRequest"/></param>
        /// <returns><see cref="ListOpsAlarmRulesResponse"/></returns>
        public ListOpsAlarmRulesResponse ListOpsAlarmRulesSync(ListOpsAlarmRulesRequest req)
        {
            return InternalRequestAsync<ListOpsAlarmRulesResponse>(req, "ListOpsAlarmRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the task list based on the project id.
        /// </summary>
        /// <param name="req"><see cref="ListOpsTasksRequest"/></param>
        /// <returns><see cref="ListOpsTasksResponse"/></returns>
        public Task<ListOpsTasksResponse> ListOpsTasks(ListOpsTasksRequest req)
        {
            return InternalRequestAsync<ListOpsTasksResponse>(req, "ListOpsTasks");
        }

        /// <summary>
        /// This API is used to obtain the task list based on the project id.
        /// </summary>
        /// <param name="req"><see cref="ListOpsTasksRequest"/></param>
        /// <returns><see cref="ListOpsTasksResponse"/></returns>
        public ListOpsTasksResponse ListOpsTasksSync(ListOpsTasksRequest req)
        {
            return InternalRequestAsync<ListOpsTasksResponse>(req, "ListOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Workflows under a Project by Project ID.
        /// </summary>
        /// <param name="req"><see cref="ListOpsWorkflowsRequest"/></param>
        /// <returns><see cref="ListOpsWorkflowsResponse"/></returns>
        public Task<ListOpsWorkflowsResponse> ListOpsWorkflows(ListOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<ListOpsWorkflowsResponse>(req, "ListOpsWorkflows");
        }

        /// <summary>
        /// Get Workflows under a Project by Project ID.
        /// </summary>
        /// <param name="req"><see cref="ListOpsWorkflowsRequest"/></param>
        /// <returns><see cref="ListOpsWorkflowsResponse"/></returns>
        public ListOpsWorkflowsResponse ListOpsWorkflowsSync(ListOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<ListOpsWorkflowsResponse>(req, "ListOpsWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view resource file list
        /// </summary>
        /// <param name="req"><see cref="ListResourceFilesRequest"/></param>
        /// <returns><see cref="ListResourceFilesResponse"/></returns>
        public Task<ListResourceFilesResponse> ListResourceFiles(ListResourceFilesRequest req)
        {
            return InternalRequestAsync<ListResourceFilesResponse>(req, "ListResourceFiles");
        }

        /// <summary>
        /// This API is used to view resource file list
        /// </summary>
        /// <param name="req"><see cref="ListResourceFilesRequest"/></param>
        /// <returns><see cref="ListResourceFilesResponse"/></returns>
        public ListResourceFilesResponse ListResourceFilesSync(ListResourceFilesRequest req)
        {
            return InternalRequestAsync<ListResourceFilesResponse>(req, "ListResourceFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the resource file folder list.
        /// </summary>
        /// <param name="req"><see cref="ListResourceFoldersRequest"/></param>
        /// <returns><see cref="ListResourceFoldersResponse"/></returns>
        public Task<ListResourceFoldersResponse> ListResourceFolders(ListResourceFoldersRequest req)
        {
            return InternalRequestAsync<ListResourceFoldersResponse>(req, "ListResourceFolders");
        }

        /// <summary>
        /// This API is used to query the resource file folder list.
        /// </summary>
        /// <param name="req"><see cref="ListResourceFoldersRequest"/></param>
        /// <returns><see cref="ListResourceFoldersResponse"/></returns>
        public ListResourceFoldersResponse ListResourceFoldersSync(ListResourceFoldersRequest req)
        {
            return InternalRequestAsync<ListResourceFoldersResponse>(req, "ListResourceFolders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the content list of an sql folder
        /// </summary>
        /// <param name="req"><see cref="ListSQLFolderContentsRequest"/></param>
        /// <returns><see cref="ListSQLFolderContentsResponse"/></returns>
        public Task<ListSQLFolderContentsResponse> ListSQLFolderContents(ListSQLFolderContentsRequest req)
        {
            return InternalRequestAsync<ListSQLFolderContentsResponse>(req, "ListSQLFolderContents");
        }

        /// <summary>
        /// This API is used to retrieve the content list of an sql folder
        /// </summary>
        /// <param name="req"><see cref="ListSQLFolderContentsRequest"/></param>
        /// <returns><see cref="ListSQLFolderContentsResponse"/></returns>
        public ListSQLFolderContentsResponse ListSQLFolderContentsSync(ListSQLFolderContentsRequest req)
        {
            return InternalRequestAsync<ListSQLFolderContentsResponse>(req, "ListSQLFolderContents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query SQL run history.
        /// </summary>
        /// <param name="req"><see cref="ListSQLScriptRunsRequest"/></param>
        /// <returns><see cref="ListSQLScriptRunsResponse"/></returns>
        public Task<ListSQLScriptRunsResponse> ListSQLScriptRuns(ListSQLScriptRunsRequest req)
        {
            return InternalRequestAsync<ListSQLScriptRunsResponse>(req, "ListSQLScriptRuns");
        }

        /// <summary>
        /// This API is used to query SQL run history.
        /// </summary>
        /// <param name="req"><see cref="ListSQLScriptRunsRequest"/></param>
        /// <returns><see cref="ListSQLScriptRunsResponse"/></returns>
        public ListSQLScriptRunsResponse ListSQLScriptRunsSync(ListSQLScriptRunsRequest req)
        {
            return InternalRequestAsync<ListSQLScriptRunsResponse>(req, "ListSQLScriptRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a scheduling instance.
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstanceExecutionsRequest"/></param>
        /// <returns><see cref="ListTaskInstanceExecutionsResponse"/></returns>
        public Task<ListTaskInstanceExecutionsResponse> ListTaskInstanceExecutions(ListTaskInstanceExecutionsRequest req)
        {
            return InternalRequestAsync<ListTaskInstanceExecutionsResponse>(req, "ListTaskInstanceExecutions");
        }

        /// <summary>
        /// This API is used to query the details of a scheduling instance.
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstanceExecutionsRequest"/></param>
        /// <returns><see cref="ListTaskInstanceExecutionsResponse"/></returns>
        public ListTaskInstanceExecutionsResponse ListTaskInstanceExecutionsSync(ListTaskInstanceExecutionsRequest req)
        {
            return InternalRequestAsync<ListTaskInstanceExecutionsResponse>(req, "ListTaskInstanceExecutions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain instance lists.
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstancesRequest"/></param>
        /// <returns><see cref="ListTaskInstancesResponse"/></returns>
        public Task<ListTaskInstancesResponse> ListTaskInstances(ListTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListTaskInstancesResponse>(req, "ListTaskInstances");
        }

        /// <summary>
        /// This API is used to obtain instance lists.
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstancesRequest"/></param>
        /// <returns><see cref="ListTaskInstancesResponse"/></returns>
        public ListTaskInstancesResponse ListTaskInstancesSync(ListTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListTaskInstancesResponse>(req, "ListTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list saved task versions.
        /// </summary>
        /// <param name="req"><see cref="ListTaskVersionsRequest"/></param>
        /// <returns><see cref="ListTaskVersionsResponse"/></returns>
        public Task<ListTaskVersionsResponse> ListTaskVersions(ListTaskVersionsRequest req)
        {
            return InternalRequestAsync<ListTaskVersionsResponse>(req, "ListTaskVersions");
        }

        /// <summary>
        /// This API is used to list saved task versions.
        /// </summary>
        /// <param name="req"><see cref="ListTaskVersionsRequest"/></param>
        /// <returns><see cref="ListTaskVersionsResponse"/></returns>
        public ListTaskVersionsResponse ListTaskVersionsSync(ListTaskVersionsRequest req)
        {
            return InternalRequestAsync<ListTaskVersionsResponse>(req, "ListTaskVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query pagination information of tasks.
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks");
        }

        /// <summary>
        /// This API is used to query pagination information of tasks.
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve task direct upstream.
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamOpsTasksResponse"/></returns>
        public Task<ListUpstreamOpsTasksResponse> ListUpstreamOpsTasks(ListUpstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamOpsTasksResponse>(req, "ListUpstreamOpsTasks");
        }

        /// <summary>
        /// This API is used to retrieve task direct upstream.
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamOpsTasksResponse"/></returns>
        public ListUpstreamOpsTasksResponse ListUpstreamOpsTasksSync(ListUpstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamOpsTasksResponse>(req, "ListUpstreamOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the direct upstream of an instance.
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListUpstreamTaskInstancesResponse"/></returns>
        public Task<ListUpstreamTaskInstancesResponse> ListUpstreamTaskInstances(ListUpstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListUpstreamTaskInstancesResponse>(req, "ListUpstreamTaskInstances");
        }

        /// <summary>
        /// This API is used to get the direct upstream of an instance.
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListUpstreamTaskInstancesResponse"/></returns>
        public ListUpstreamTaskInstancesResponse ListUpstreamTaskInstancesSync(ListUpstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListUpstreamTaskInstancesResponse>(req, "ListUpstreamTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the direct upstream task.
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamTasksResponse"/></returns>
        public Task<ListUpstreamTasksResponse> ListUpstreamTasks(ListUpstreamTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamTasksResponse>(req, "ListUpstreamTasks");
        }

        /// <summary>
        /// This API is used to retrieve the direct upstream task.
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamTasksResponse"/></returns>
        public ListUpstreamTasksResponse ListUpstreamTasksSync(ListUpstreamTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamTasksResponse>(req, "ListUpstreamTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the folder list.
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowFoldersRequest"/></param>
        /// <returns><see cref="ListWorkflowFoldersResponse"/></returns>
        public Task<ListWorkflowFoldersResponse> ListWorkflowFolders(ListWorkflowFoldersRequest req)
        {
            return InternalRequestAsync<ListWorkflowFoldersResponse>(req, "ListWorkflowFolders");
        }

        /// <summary>
        /// This API is used to query the folder list.
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowFoldersRequest"/></param>
        /// <returns><see cref="ListWorkflowFoldersResponse"/></returns>
        public ListWorkflowFoldersResponse ListWorkflowFoldersSync(ListWorkflowFoldersRequest req)
        {
            return InternalRequestAsync<ListWorkflowFoldersResponse>(req, "ListWorkflowFolders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of workflows.
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowsRequest"/></param>
        /// <returns><see cref="ListWorkflowsResponse"/></returns>
        public Task<ListWorkflowsResponse> ListWorkflows(ListWorkflowsRequest req)
        {
            return InternalRequestAsync<ListWorkflowsResponse>(req, "ListWorkflows");
        }

        /// <summary>
        /// This API is used to query the list of workflows.
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowsRequest"/></param>
        /// <returns><see cref="ListWorkflowsResponse"/></returns>
        public ListWorkflowsResponse ListWorkflowsSync(ListWorkflowsRequest req)
        {
            return InternalRequestAsync<ListWorkflowsResponse>(req, "ListWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause tasks in batches asynchronously.
        /// </summary>
        /// <param name="req"><see cref="PauseOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="PauseOpsTasksAsyncResponse"/></returns>
        public Task<PauseOpsTasksAsyncResponse> PauseOpsTasksAsync(PauseOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<PauseOpsTasksAsyncResponse>(req, "PauseOpsTasksAsync");
        }

        /// <summary>
        /// This API is used to pause tasks in batches asynchronously.
        /// </summary>
        /// <param name="req"><see cref="PauseOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="PauseOpsTasksAsyncResponse"/></returns>
        public PauseOpsTasksAsyncResponse PauseOpsTasksAsyncSync(PauseOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<PauseOpsTasksAsyncResponse>(req, "PauseOpsTasksAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch rerun instances asynchronously.
        /// </summary>
        /// <param name="req"><see cref="RerunTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="RerunTaskInstancesAsyncResponse"/></returns>
        public Task<RerunTaskInstancesAsyncResponse> RerunTaskInstancesAsync(RerunTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<RerunTaskInstancesAsyncResponse>(req, "RerunTaskInstancesAsync");
        }

        /// <summary>
        /// This API is used to batch rerun instances asynchronously.
        /// </summary>
        /// <param name="req"><see cref="RerunTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="RerunTaskInstancesAsyncResponse"/></returns>
        public RerunTaskInstancesAsyncResponse RerunTaskInstancesAsyncSync(RerunTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<RerunTaskInstancesAsyncResponse>(req, "RerunTaskInstancesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to run an SQL script.
        /// </summary>
        /// <param name="req"><see cref="RunSQLScriptRequest"/></param>
        /// <returns><see cref="RunSQLScriptResponse"/></returns>
        public Task<RunSQLScriptResponse> RunSQLScript(RunSQLScriptRequest req)
        {
            return InternalRequestAsync<RunSQLScriptResponse>(req, "RunSQLScript");
        }

        /// <summary>
        /// This API is used to run an SQL script.
        /// </summary>
        /// <param name="req"><see cref="RunSQLScriptRequest"/></param>
        /// <returns><see cref="RunSQLScriptResponse"/></returns>
        public RunSQLScriptResponse RunSQLScriptSync(RunSQLScriptRequest req)
        {
            return InternalRequestAsync<RunSQLScriptResponse>(req, "RunSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch configure instances asynchronously.
        /// </summary>
        /// <param name="req"><see cref="SetSuccessTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="SetSuccessTaskInstancesAsyncResponse"/></returns>
        public Task<SetSuccessTaskInstancesAsyncResponse> SetSuccessTaskInstancesAsync(SetSuccessTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<SetSuccessTaskInstancesAsyncResponse>(req, "SetSuccessTaskInstancesAsync");
        }

        /// <summary>
        /// This API is used to batch configure instances asynchronously.
        /// </summary>
        /// <param name="req"><see cref="SetSuccessTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="SetSuccessTaskInstancesAsyncResponse"/></returns>
        public SetSuccessTaskInstancesAsyncResponse SetSuccessTaskInstancesAsyncSync(SetSuccessTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<SetSuccessTaskInstancesAsyncResponse>(req, "SetSuccessTaskInstancesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to asynchronously deactivate tasks in batch.
        /// </summary>
        /// <param name="req"><see cref="StopOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="StopOpsTasksAsyncResponse"/></returns>
        public Task<StopOpsTasksAsyncResponse> StopOpsTasksAsync(StopOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<StopOpsTasksAsyncResponse>(req, "StopOpsTasksAsync");
        }

        /// <summary>
        /// This API is used to asynchronously deactivate tasks in batch.
        /// </summary>
        /// <param name="req"><see cref="StopOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="StopOpsTasksAsyncResponse"/></returns>
        public StopOpsTasksAsyncResponse StopOpsTasksAsyncSync(StopOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<StopOpsTasksAsyncResponse>(req, "StopOpsTasksAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop running an SQL script.
        /// </summary>
        /// <param name="req"><see cref="StopSQLScriptRunRequest"/></param>
        /// <returns><see cref="StopSQLScriptRunResponse"/></returns>
        public Task<StopSQLScriptRunResponse> StopSQLScriptRun(StopSQLScriptRunRequest req)
        {
            return InternalRequestAsync<StopSQLScriptRunResponse>(req, "StopSQLScriptRun");
        }

        /// <summary>
        /// This API is used to stop running an SQL script.
        /// </summary>
        /// <param name="req"><see cref="StopSQLScriptRunRequest"/></param>
        /// <returns><see cref="StopSQLScriptRunResponse"/></returns>
        public StopSQLScriptRunResponse StopSQLScriptRunSync(StopSQLScriptRunRequest req)
        {
            return InternalRequestAsync<StopSQLScriptRunResponse>(req, "StopSQLScriptRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit a task.
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask");
        }

        /// <summary>
        /// This API is used to submit a task.
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public SubmitTaskResponse SubmitTaskSync(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a code file.
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFileRequest"/></param>
        /// <returns><see cref="UpdateCodeFileResponse"/></returns>
        public Task<UpdateCodeFileResponse> UpdateCodeFile(UpdateCodeFileRequest req)
        {
            return InternalRequestAsync<UpdateCodeFileResponse>(req, "UpdateCodeFile");
        }

        /// <summary>
        /// This API is used to update a code file.
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFileRequest"/></param>
        /// <returns><see cref="UpdateCodeFileResponse"/></returns>
        public UpdateCodeFileResponse UpdateCodeFileSync(UpdateCodeFileRequest req)
        {
            return InternalRequestAsync<UpdateCodeFileResponse>(req, "UpdateCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a code folder.
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFolderRequest"/></param>
        /// <returns><see cref="UpdateCodeFolderResponse"/></returns>
        public Task<UpdateCodeFolderResponse> UpdateCodeFolder(UpdateCodeFolderRequest req)
        {
            return InternalRequestAsync<UpdateCodeFolderResponse>(req, "UpdateCodeFolder");
        }

        /// <summary>
        /// This API is used to rename a code folder.
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFolderRequest"/></param>
        /// <returns><see cref="UpdateCodeFolderResponse"/></returns>
        public UpdateCodeFolderResponse UpdateCodeFolderSync(UpdateCodeFolderRequest req)
        {
            return InternalRequestAsync<UpdateCodeFolderResponse>(req, "UpdateCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies alarm rules
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="UpdateOpsAlarmRuleResponse"/></returns>
        public Task<UpdateOpsAlarmRuleResponse> UpdateOpsAlarmRule(UpdateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<UpdateOpsAlarmRuleResponse>(req, "UpdateOpsAlarmRule");
        }

        /// <summary>
        /// Modifies alarm rules
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="UpdateOpsAlarmRuleResponse"/></returns>
        public UpdateOpsAlarmRuleResponse UpdateOpsAlarmRuleSync(UpdateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<UpdateOpsAlarmRuleResponse>(req, "UpdateOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the task owner.
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsTasksOwnerRequest"/></param>
        /// <returns><see cref="UpdateOpsTasksOwnerResponse"/></returns>
        public Task<UpdateOpsTasksOwnerResponse> UpdateOpsTasksOwner(UpdateOpsTasksOwnerRequest req)
        {
            return InternalRequestAsync<UpdateOpsTasksOwnerResponse>(req, "UpdateOpsTasksOwner");
        }

        /// <summary>
        /// This API is used to modify the task owner.
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsTasksOwnerRequest"/></param>
        /// <returns><see cref="UpdateOpsTasksOwnerResponse"/></returns>
        public UpdateOpsTasksOwnerResponse UpdateOpsTasksOwnerSync(UpdateOpsTasksOwnerRequest req)
        {
            return InternalRequestAsync<UpdateOpsTasksOwnerResponse>(req, "UpdateOpsTasksOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a resource file.
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFileRequest"/></param>
        /// <returns><see cref="UpdateResourceFileResponse"/></returns>
        public Task<UpdateResourceFileResponse> UpdateResourceFile(UpdateResourceFileRequest req)
        {
            return InternalRequestAsync<UpdateResourceFileResponse>(req, "UpdateResourceFile");
        }

        /// <summary>
        /// This API is used to update a resource file.
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFileRequest"/></param>
        /// <returns><see cref="UpdateResourceFileResponse"/></returns>
        public UpdateResourceFileResponse UpdateResourceFileSync(UpdateResourceFileRequest req)
        {
            return InternalRequestAsync<UpdateResourceFileResponse>(req, "UpdateResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a resource folder.
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFolderRequest"/></param>
        /// <returns><see cref="UpdateResourceFolderResponse"/></returns>
        public Task<UpdateResourceFolderResponse> UpdateResourceFolder(UpdateResourceFolderRequest req)
        {
            return InternalRequestAsync<UpdateResourceFolderResponse>(req, "UpdateResourceFolder");
        }

        /// <summary>
        /// This API is used to update a resource folder.
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFolderRequest"/></param>
        /// <returns><see cref="UpdateResourceFolderResponse"/></returns>
        public UpdateResourceFolderResponse UpdateResourceFolderSync(UpdateResourceFolderRequest req)
        {
            return InternalRequestAsync<UpdateResourceFolderResponse>(req, "UpdateResourceFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename an SQL folder.
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLFolderRequest"/></param>
        /// <returns><see cref="UpdateSQLFolderResponse"/></returns>
        public Task<UpdateSQLFolderResponse> UpdateSQLFolder(UpdateSQLFolderRequest req)
        {
            return InternalRequestAsync<UpdateSQLFolderResponse>(req, "UpdateSQLFolder");
        }

        /// <summary>
        /// This API is used to rename an SQL folder.
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLFolderRequest"/></param>
        /// <returns><see cref="UpdateSQLFolderResponse"/></returns>
        public UpdateSQLFolderResponse UpdateSQLFolderSync(UpdateSQLFolderRequest req)
        {
            return InternalRequestAsync<UpdateSQLFolderResponse>(req, "UpdateSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to save the script content for data exploration.
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLScriptRequest"/></param>
        /// <returns><see cref="UpdateSQLScriptResponse"/></returns>
        public Task<UpdateSQLScriptResponse> UpdateSQLScript(UpdateSQLScriptRequest req)
        {
            return InternalRequestAsync<UpdateSQLScriptResponse>(req, "UpdateSQLScript");
        }

        /// <summary>
        /// This API is used to save the script content for data exploration.
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLScriptRequest"/></param>
        /// <returns><see cref="UpdateSQLScriptResponse"/></returns>
        public UpdateSQLScriptResponse UpdateSQLScriptSync(UpdateSQLScriptRequest req)
        {
            return InternalRequestAsync<UpdateSQLScriptResponse>(req, "UpdateSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a task.
        /// </summary>
        /// <param name="req"><see cref="UpdateTaskRequest"/></param>
        /// <returns><see cref="UpdateTaskResponse"/></returns>
        public Task<UpdateTaskResponse> UpdateTask(UpdateTaskRequest req)
        {
            return InternalRequestAsync<UpdateTaskResponse>(req, "UpdateTask");
        }

        /// <summary>
        /// This API is used to update a task.
        /// </summary>
        /// <param name="req"><see cref="UpdateTaskRequest"/></param>
        /// <returns><see cref="UpdateTaskResponse"/></returns>
        public UpdateTaskResponse UpdateTaskSync(UpdateTaskRequest req)
        {
            return InternalRequestAsync<UpdateTaskResponse>(req, "UpdateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a workflow including basic information and workflow parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public Task<UpdateWorkflowResponse> UpdateWorkflow(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow");
        }

        /// <summary>
        /// This API is used to update a workflow including basic information and workflow parameters.
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public UpdateWorkflowResponse UpdateWorkflowSync(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a workflow folder
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowFolderRequest"/></param>
        /// <returns><see cref="UpdateWorkflowFolderResponse"/></returns>
        public Task<UpdateWorkflowFolderResponse> UpdateWorkflowFolder(UpdateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowFolderResponse>(req, "UpdateWorkflowFolder");
        }

        /// <summary>
        /// This API is used to update a workflow folder
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowFolderRequest"/></param>
        /// <returns><see cref="UpdateWorkflowFolderResponse"/></returns>
        public UpdateWorkflowFolderResponse UpdateWorkflowFolderSync(UpdateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowFolderResponse>(req, "UpdateWorkflowFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
