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

namespace TencentCloud.Adp.V20260520
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Adp.V20260520.Models;

   public class AdpClient : AbstractClient{

       private const string endpoint = "adp.intl.tencentcloudapi.com";
       private const string version = "2026-05-20";
       private const string sdkVersion = "SDK_NET_3.0.1422";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Tool call triggered by a user in the MCP App iframe.
        /// </summary>
        /// <param name="req"><see cref="CallMCPToolRequest"/></param>
        /// <returns><see cref="CallMCPToolResponse"/></returns>
        public Task<CallMCPToolResponse> CallMCPTool(CallMCPToolRequest req)
        {
            return InternalRequestAsync<CallMCPToolResponse>(req, "CallMCPTool");
        }

        /// <summary>
        /// Tool call triggered by a user in the MCP App iframe.
        /// </summary>
        /// <param name="req"><see cref="CallMCPToolRequest"/></param>
        /// <returns><see cref="CallMCPToolResponse"/></returns>
        public CallMCPToolResponse CallMCPToolSync(CallMCPToolRequest req)
        {
            return InternalRequestAsync<CallMCPToolResponse>(req, "CallMCPTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Validate tags
        /// </summary>
        /// <param name="req"><see cref="CheckLabelRequest"/></param>
        /// <returns><see cref="CheckLabelResponse"/></returns>
        public Task<CheckLabelResponse> CheckLabel(CheckLabelRequest req)
        {
            return InternalRequestAsync<CheckLabelResponse>(req, "CheckLabel");
        }

        /// <summary>
        /// Validate tags
        /// </summary>
        /// <param name="req"><see cref="CheckLabelRequest"/></param>
        /// <returns><see cref="CheckLabelResponse"/></returns>
        public CheckLabelResponse CheckLabelSync(CheckLabelRequest req)
        {
            return InternalRequestAsync<CheckLabelResponse>(req, "CheckLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replicate an Agent. Currently only support claw mode.
        /// </summary>
        /// <param name="req"><see cref="CopyAgentFromAppRequest"/></param>
        /// <returns><see cref="CopyAgentFromAppResponse"/></returns>
        public Task<CopyAgentFromAppResponse> CopyAgentFromApp(CopyAgentFromAppRequest req)
        {
            return InternalRequestAsync<CopyAgentFromAppResponse>(req, "CopyAgentFromApp");
        }

        /// <summary>
        /// This API is used to replicate an Agent. Currently only support claw mode.
        /// </summary>
        /// <param name="req"><see cref="CopyAgentFromAppRequest"/></param>
        /// <returns><see cref="CopyAgentFromAppResponse"/></returns>
        public CopyAgentFromAppResponse CopyAgentFromAppSync(CopyAgentFromAppRequest req)
        {
            return InternalRequestAsync<CopyAgentFromAppResponse>(req, "CopyAgentFromApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Copy an application
        /// </summary>
        /// <param name="req"><see cref="CopyAppRequest"/></param>
        /// <returns><see cref="CopyAppResponse"/></returns>
        public Task<CopyAppResponse> CopyApp(CopyAppRequest req)
        {
            return InternalRequestAsync<CopyAppResponse>(req, "CopyApp");
        }

        /// <summary>
        /// Copy an application
        /// </summary>
        /// <param name="req"><see cref="CopyAppRequest"/></param>
        /// <returns><see cref="CopyAppResponse"/></returns>
        public CopyAppResponse CopyAppSync(CopyAppRequest req)
        {
            return InternalRequestAsync<CopyAppResponse>(req, "CopyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an Agent. Currently only support claw mode.
        /// </summary>
        /// <param name="req"><see cref="CreateAgentRequest"/></param>
        /// <returns><see cref="CreateAgentResponse"/></returns>
        public Task<CreateAgentResponse> CreateAgent(CreateAgentRequest req)
        {
            return InternalRequestAsync<CreateAgentResponse>(req, "CreateAgent");
        }

        /// <summary>
        /// This API is used to create an Agent. Currently only support claw mode.
        /// </summary>
        /// <param name="req"><see cref="CreateAgentRequest"/></param>
        /// <returns><see cref="CreateAgentResponse"/></returns>
        public CreateAgentResponse CreateAgentSync(CreateAgentRequest req)
        {
            return InternalRequestAsync<CreateAgentResponse>(req, "CreateAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp");
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateAppTrigger
        /// </summary>
        /// <param name="req"><see cref="CreateAppTriggerRequest"/></param>
        /// <returns><see cref="CreateAppTriggerResponse"/></returns>
        public Task<CreateAppTriggerResponse> CreateAppTrigger(CreateAppTriggerRequest req)
        {
            return InternalRequestAsync<CreateAppTriggerResponse>(req, "CreateAppTrigger");
        }

        /// <summary>
        /// CreateAppTrigger
        /// </summary>
        /// <param name="req"><see cref="CreateAppTriggerRequest"/></param>
        /// <returns><see cref="CreateAppTriggerResponse"/></returns>
        public CreateAppTriggerResponse CreateAppTriggerSync(CreateAppTriggerRequest req)
        {
            return InternalRequestAsync<CreateAppTriggerResponse>(req, "CreateAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a category
        /// </summary>
        /// <param name="req"><see cref="CreateCategoryRequest"/></param>
        /// <returns><see cref="CreateCategoryResponse"/></returns>
        public Task<CreateCategoryResponse> CreateCategory(CreateCategoryRequest req)
        {
            return InternalRequestAsync<CreateCategoryResponse>(req, "CreateCategory");
        }

        /// <summary>
        /// Create a category
        /// </summary>
        /// <param name="req"><see cref="CreateCategoryRequest"/></param>
        /// <returns><see cref="CreateCategoryResponse"/></returns>
        public CreateCategoryResponse CreateCategorySync(CreateCategoryRequest req)
        {
            return InternalRequestAsync<CreateCategoryResponse>(req, "CreateCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a channel (distinguish B-end application release channels from C-end IM channels by scene)
        /// </summary>
        /// <param name="req"><see cref="CreateChannelRequest"/></param>
        /// <returns><see cref="CreateChannelResponse"/></returns>
        public Task<CreateChannelResponse> CreateChannel(CreateChannelRequest req)
        {
            return InternalRequestAsync<CreateChannelResponse>(req, "CreateChannel");
        }

        /// <summary>
        /// Create a channel (distinguish B-end application release channels from C-end IM channels by scene)
        /// </summary>
        /// <param name="req"><see cref="CreateChannelRequest"/></param>
        /// <returns><see cref="CreateChannelResponse"/></returns>
        public CreateChannelResponse CreateChannelSync(CreateChannelRequest req)
        {
            return InternalRequestAsync<CreateChannelResponse>(req, "CreateChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create session
        /// </summary>
        /// <param name="req"><see cref="CreateConversationRequest"/></param>
        /// <returns><see cref="CreateConversationResponse"/></returns>
        public Task<CreateConversationResponse> CreateConversation(CreateConversationRequest req)
        {
            return InternalRequestAsync<CreateConversationResponse>(req, "CreateConversation");
        }

        /// <summary>
        /// Create session
        /// </summary>
        /// <param name="req"><see cref="CreateConversationRequest"/></param>
        /// <returns><see cref="CreateConversationResponse"/></returns>
        public CreateConversationResponse CreateConversationSync(CreateConversationRequest req)
        {
            return InternalRequestAsync<CreateConversationResponse>(req, "CreateConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a knowledge base.
        /// </summary>
        /// <param name="req"><see cref="CreateKBRequest"/></param>
        /// <returns><see cref="CreateKBResponse"/></returns>
        public Task<CreateKBResponse> CreateKB(CreateKBRequest req)
        {
            return InternalRequestAsync<CreateKBResponse>(req, "CreateKB");
        }

        /// <summary>
        /// This API is used to create a knowledge base.
        /// </summary>
        /// <param name="req"><see cref="CreateKBRequest"/></param>
        /// <returns><see cref="CreateKBResponse"/></returns>
        public CreateKBResponse CreateKBSync(CreateKBRequest req)
        {
            return InternalRequestAsync<CreateKBResponse>(req, "CreateKB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a tag
        /// </summary>
        /// <param name="req"><see cref="CreateLabelRequest"/></param>
        /// <returns><see cref="CreateLabelResponse"/></returns>
        public Task<CreateLabelResponse> CreateLabel(CreateLabelRequest req)
        {
            return InternalRequestAsync<CreateLabelResponse>(req, "CreateLabel");
        }

        /// <summary>
        /// Create a tag
        /// </summary>
        /// <param name="req"><see cref="CreateLabelRequest"/></param>
        /// <returns><see cref="CreateLabelResponse"/></returns>
        public CreateLabelResponse CreateLabelSync(CreateLabelRequest req)
        {
            return InternalRequestAsync<CreateLabelResponse>(req, "CreateLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a message record category, with support for specifying the category name and parent category. A ParentId of 0 indicates a level-1 category.
        /// </summary>
        /// <param name="req"><see cref="CreateMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="CreateMsgRecordCategoryResponse"/></returns>
        public Task<CreateMsgRecordCategoryResponse> CreateMsgRecordCategory(CreateMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<CreateMsgRecordCategoryResponse>(req, "CreateMsgRecordCategory");
        }

        /// <summary>
        /// This API is used to create a message record category, with support for specifying the category name and parent category. A ParentId of 0 indicates a level-1 category.
        /// </summary>
        /// <param name="req"><see cref="CreateMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="CreateMsgRecordCategoryResponse"/></returns>
        public CreateMsgRecordCategoryResponse CreateMsgRecordCategorySync(CreateMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<CreateMsgRecordCategoryResponse>(req, "CreateMsgRecordCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query plugin details.
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public Task<CreatePluginResponse> CreatePlugin(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin");
        }

        /// <summary>
        /// This API is used to query plugin details.
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public CreatePluginResponse CreatePluginSync(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a QA generation task
        /// </summary>
        /// <param name="req"><see cref="CreateQAGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateQAGenerationTaskResponse"/></returns>
        public Task<CreateQAGenerationTaskResponse> CreateQAGenerationTask(CreateQAGenerationTaskRequest req)
        {
            return InternalRequestAsync<CreateQAGenerationTaskResponse>(req, "CreateQAGenerationTask");
        }

        /// <summary>
        /// Create a QA generation task
        /// </summary>
        /// <param name="req"><see cref="CreateQAGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateQAGenerationTaskResponse"/></returns>
        public CreateQAGenerationTaskResponse CreateQAGenerationTaskSync(CreateQAGenerationTaskRequest req)
        {
            return InternalRequestAsync<CreateQAGenerationTaskResponse>(req, "CreateQAGenerationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch create QA
        /// </summary>
        /// <param name="req"><see cref="CreateQAListRequest"/></param>
        /// <returns><see cref="CreateQAListResponse"/></returns>
        public Task<CreateQAListResponse> CreateQAList(CreateQAListRequest req)
        {
            return InternalRequestAsync<CreateQAListResponse>(req, "CreateQAList");
        }

        /// <summary>
        /// Batch create QA
        /// </summary>
        /// <param name="req"><see cref="CreateQAListRequest"/></param>
        /// <returns><see cref="CreateQAListResponse"/></returns>
        public CreateQAListResponse CreateQAListSync(CreateQAListRequest req)
        {
            return InternalRequestAsync<CreateQAListResponse>(req, "CreateQAList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add new release task
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public Task<CreateReleaseResponse> CreateRelease(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease");
        }

        /// <summary>
        /// Add new release task
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public CreateReleaseResponse CreateReleaseSync(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a similar question generation task.
        /// </summary>
        /// <param name="req"><see cref="CreateSimilarQuestionRequest"/></param>
        /// <returns><see cref="CreateSimilarQuestionResponse"/></returns>
        public Task<CreateSimilarQuestionResponse> CreateSimilarQuestion(CreateSimilarQuestionRequest req)
        {
            return InternalRequestAsync<CreateSimilarQuestionResponse>(req, "CreateSimilarQuestion");
        }

        /// <summary>
        /// This API is used to create a similar question generation task.
        /// </summary>
        /// <param name="req"><see cref="CreateSimilarQuestionRequest"/></param>
        /// <returns><see cref="CreateSimilarQuestionResponse"/></returns>
        public CreateSimilarQuestionResponse CreateSimilarQuestionSync(CreateSimilarQuestionRequest req)
        {
            return InternalRequestAsync<CreateSimilarQuestionResponse>(req, "CreateSimilarQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a skill
        /// </summary>
        /// <param name="req"><see cref="CreateSkillRequest"/></param>
        /// <returns><see cref="CreateSkillResponse"/></returns>
        public Task<CreateSkillResponse> CreateSkill(CreateSkillRequest req)
        {
            return InternalRequestAsync<CreateSkillResponse>(req, "CreateSkill");
        }

        /// <summary>
        /// Creates a skill
        /// </summary>
        /// <param name="req"><see cref="CreateSkillRequest"/></param>
        /// <returns><see cref="CreateSkillResponse"/></returns>
        public CreateSkillResponse CreateSkillSync(CreateSkillRequest req)
        {
            return InternalRequestAsync<CreateSkillResponse>(req, "CreateSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit a custom Skill for enterprise-level shared approval (two-segment: submit, approve, callback to create a shared task)
        /// </summary>
        /// <param name="req"><see cref="CreateSkillShareRequest"/></param>
        /// <returns><see cref="CreateSkillShareResponse"/></returns>
        public Task<CreateSkillShareResponse> CreateSkillShare(CreateSkillShareRequest req)
        {
            return InternalRequestAsync<CreateSkillShareResponse>(req, "CreateSkillShare");
        }

        /// <summary>
        /// Submit a custom Skill for enterprise-level shared approval (two-segment: submit, approve, callback to create a shared task)
        /// </summary>
        /// <param name="req"><see cref="CreateSkillShareRequest"/></param>
        /// <returns><see cref="CreateSkillShareResponse"/></returns>
        public CreateSkillShareResponse CreateSkillShareSync(CreateSkillShareRequest req)
        {
            return InternalRequestAsync<CreateSkillShareResponse>(req, "CreateSkillShare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a space
        /// </summary>
        /// <param name="req"><see cref="CreateSpaceRequest"/></param>
        /// <returns><see cref="CreateSpaceResponse"/></returns>
        public Task<CreateSpaceResponse> CreateSpace(CreateSpaceRequest req)
        {
            return InternalRequestAsync<CreateSpaceResponse>(req, "CreateSpace");
        }

        /// <summary>
        /// Create a space
        /// </summary>
        /// <param name="req"><see cref="CreateSpaceRequest"/></param>
        /// <returns><see cref="CreateSpaceResponse"/></returns>
        public CreateSpaceResponse CreateSpaceSync(CreateSpaceRequest req)
        {
            return InternalRequestAsync<CreateSpaceResponse>(req, "CreateSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create parameter variables.
        /// </summary>
        /// <param name="req"><see cref="CreateVariableRequest"/></param>
        /// <returns><see cref="CreateVariableResponse"/></returns>
        public Task<CreateVariableResponse> CreateVariable(CreateVariableRequest req)
        {
            return InternalRequestAsync<CreateVariableResponse>(req, "CreateVariable");
        }

        /// <summary>
        /// This API is used to create parameter variables.
        /// </summary>
        /// <param name="req"><see cref="CreateVariableRequest"/></param>
        /// <returns><see cref="CreateVariableResponse"/></returns>
        public CreateVariableResponse CreateVariableSync(CreateVariableRequest req)
        {
            return InternalRequestAsync<CreateVariableResponse>(req, "CreateVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a WebSocket Token.
        /// </summary>
        /// <param name="req"><see cref="CreateWebSocketTokenRequest"/></param>
        /// <returns><see cref="CreateWebSocketTokenResponse"/></returns>
        public Task<CreateWebSocketTokenResponse> CreateWebSocketToken(CreateWebSocketTokenRequest req)
        {
            return InternalRequestAsync<CreateWebSocketTokenResponse>(req, "CreateWebSocketToken");
        }

        /// <summary>
        /// This API is used to create a WebSocket Token.
        /// </summary>
        /// <param name="req"><see cref="CreateWebSocketTokenRequest"/></param>
        /// <returns><see cref="CreateWebSocketTokenResponse"/></returns>
        public CreateWebSocketTokenResponse CreateWebSocketTokenSync(CreateWebSocketTokenRequest req)
        {
            return InternalRequestAsync<CreateWebSocketTokenResponse>(req, "CreateWebSocketToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an asynchronous running instance of a workflow. After successful creation, the workflow runs asynchronously in the backend. The API returns the workflow running instance ID (WorkflowRunId) and other information. You can call the DescribeWorkflowRun API to query the workflow running details.
        /// Note: Asynchronous execution of a workflow is application-based. The corresponding application configuration must be set to "Single Workflow Mode" before it can be successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRunRequest"/></param>
        /// <returns><see cref="CreateWorkflowRunResponse"/></returns>
        public Task<CreateWorkflowRunResponse> CreateWorkflowRun(CreateWorkflowRunRequest req)
        {
            return InternalRequestAsync<CreateWorkflowRunResponse>(req, "CreateWorkflowRun");
        }

        /// <summary>
        /// This API is used to create an asynchronous running instance of a workflow. After successful creation, the workflow runs asynchronously in the backend. The API returns the workflow running instance ID (WorkflowRunId) and other information. You can call the DescribeWorkflowRun API to query the workflow running details.
        /// Note: Asynchronous execution of a workflow is application-based. The corresponding application configuration must be set to "Single Workflow Mode" before it can be successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRunRequest"/></param>
        /// <returns><see cref="CreateWorkflowRunResponse"/></returns>
        public CreateWorkflowRunResponse CreateWorkflowRunSync(CreateWorkflowRunRequest req)
        {
            return InternalRequestAsync<CreateWorkflowRunResponse>(req, "CreateWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a workspace credential
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceCredentialRequest"/></param>
        /// <returns><see cref="CreateWorkspaceCredentialResponse"/></returns>
        public Task<CreateWorkspaceCredentialResponse> CreateWorkspaceCredential(CreateWorkspaceCredentialRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceCredentialResponse>(req, "CreateWorkspaceCredential");
        }

        /// <summary>
        /// Create a workspace credential
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceCredentialRequest"/></param>
        /// <returns><see cref="CreateWorkspaceCredentialResponse"/></returns>
        public CreateWorkspaceCredentialResponse CreateWorkspaceCredentialSync(CreateWorkspaceCredentialRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceCredentialResponse>(req, "CreateWorkspaceCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an Agent.
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentRequest"/></param>
        /// <returns><see cref="DeleteAgentResponse"/></returns>
        public Task<DeleteAgentResponse> DeleteAgent(DeleteAgentRequest req)
        {
            return InternalRequestAsync<DeleteAgentResponse>(req, "DeleteAgent");
        }

        /// <summary>
        /// This API is used to delete an Agent.
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentRequest"/></param>
        /// <returns><see cref="DeleteAgentResponse"/></returns>
        public DeleteAgentResponse DeleteAgentSync(DeleteAgentRequest req)
        {
            return InternalRequestAsync<DeleteAgentResponse>(req, "DeleteAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete applications
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public Task<DeleteAppResponse> DeleteApp(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp");
        }

        /// <summary>
        /// This API is used to delete applications
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public DeleteAppResponse DeleteAppSync(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DeleteAppTriggerRequest"/></param>
        /// <returns><see cref="DeleteAppTriggerResponse"/></returns>
        public Task<DeleteAppTriggerResponse> DeleteAppTrigger(DeleteAppTriggerRequest req)
        {
            return InternalRequestAsync<DeleteAppTriggerResponse>(req, "DeleteAppTrigger");
        }

        /// <summary>
        /// DeleteAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DeleteAppTriggerRequest"/></param>
        /// <returns><see cref="DeleteAppTriggerResponse"/></returns>
        public DeleteAppTriggerResponse DeleteAppTriggerSync(DeleteAppTriggerRequest req)
        {
            return InternalRequestAsync<DeleteAppTriggerResponse>(req, "DeleteAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="req"><see cref="DeleteCategoryRequest"/></param>
        /// <returns><see cref="DeleteCategoryResponse"/></returns>
        public Task<DeleteCategoryResponse> DeleteCategory(DeleteCategoryRequest req)
        {
            return InternalRequestAsync<DeleteCategoryResponse>(req, "DeleteCategory");
        }

        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="req"><see cref="DeleteCategoryRequest"/></param>
        /// <returns><see cref="DeleteCategoryResponse"/></returns>
        public DeleteCategoryResponse DeleteCategorySync(DeleteCategoryRequest req)
        {
            return InternalRequestAsync<DeleteCategoryResponse>(req, "DeleteCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a channel (scenarios are distinguished by scene)
        /// </summary>
        /// <param name="req"><see cref="DeleteChannelRequest"/></param>
        /// <returns><see cref="DeleteChannelResponse"/></returns>
        public Task<DeleteChannelResponse> DeleteChannel(DeleteChannelRequest req)
        {
            return InternalRequestAsync<DeleteChannelResponse>(req, "DeleteChannel");
        }

        /// <summary>
        /// Delete a channel (scenarios are distinguished by scene)
        /// </summary>
        /// <param name="req"><see cref="DeleteChannelRequest"/></param>
        /// <returns><see cref="DeleteChannelResponse"/></returns>
        public DeleteChannelResponse DeleteChannelSync(DeleteChannelRequest req)
        {
            return InternalRequestAsync<DeleteChannelResponse>(req, "DeleteChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete conversation
        /// </summary>
        /// <param name="req"><see cref="DeleteConversationRequest"/></param>
        /// <returns><see cref="DeleteConversationResponse"/></returns>
        public Task<DeleteConversationResponse> DeleteConversation(DeleteConversationRequest req)
        {
            return InternalRequestAsync<DeleteConversationResponse>(req, "DeleteConversation");
        }

        /// <summary>
        /// Delete conversation
        /// </summary>
        /// <param name="req"><see cref="DeleteConversationRequest"/></param>
        /// <returns><see cref="DeleteConversationResponse"/></returns>
        public DeleteConversationResponse DeleteConversationSync(DeleteConversationRequest req)
        {
            return InternalRequestAsync<DeleteConversationResponse>(req, "DeleteConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete documents in batches
        /// </summary>
        /// <param name="req"><see cref="DeleteDocListRequest"/></param>
        /// <returns><see cref="DeleteDocListResponse"/></returns>
        public Task<DeleteDocListResponse> DeleteDocList(DeleteDocListRequest req)
        {
            return InternalRequestAsync<DeleteDocListResponse>(req, "DeleteDocList");
        }

        /// <summary>
        /// Delete documents in batches
        /// </summary>
        /// <param name="req"><see cref="DeleteDocListRequest"/></param>
        /// <returns><see cref="DeleteDocListResponse"/></returns>
        public DeleteDocListResponse DeleteDocListSync(DeleteDocListRequest req)
        {
            return InternalRequestAsync<DeleteDocListResponse>(req, "DeleteDocList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the knowledge base.
        /// </summary>
        /// <param name="req"><see cref="DeleteKBRequest"/></param>
        /// <returns><see cref="DeleteKBResponse"/></returns>
        public Task<DeleteKBResponse> DeleteKB(DeleteKBRequest req)
        {
            return InternalRequestAsync<DeleteKBResponse>(req, "DeleteKB");
        }

        /// <summary>
        /// This API is used to delete the knowledge base.
        /// </summary>
        /// <param name="req"><see cref="DeleteKBRequest"/></param>
        /// <returns><see cref="DeleteKBResponse"/></returns>
        public DeleteKBResponse DeleteKBSync(DeleteKBRequest req)
        {
            return InternalRequestAsync<DeleteKBResponse>(req, "DeleteKB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch deletes tags
        /// </summary>
        /// <param name="req"><see cref="DeleteLabelListRequest"/></param>
        /// <returns><see cref="DeleteLabelListResponse"/></returns>
        public Task<DeleteLabelListResponse> DeleteLabelList(DeleteLabelListRequest req)
        {
            return InternalRequestAsync<DeleteLabelListResponse>(req, "DeleteLabelList");
        }

        /// <summary>
        /// Batch deletes tags
        /// </summary>
        /// <param name="req"><see cref="DeleteLabelListRequest"/></param>
        /// <returns><see cref="DeleteLabelListResponse"/></returns>
        public DeleteLabelListResponse DeleteLabelListSync(DeleteLabelListRequest req)
        {
            return InternalRequestAsync<DeleteLabelListResponse>(req, "DeleteLabelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a specified message record category
        /// </summary>
        /// <param name="req"><see cref="DeleteMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="DeleteMsgRecordCategoryResponse"/></returns>
        public Task<DeleteMsgRecordCategoryResponse> DeleteMsgRecordCategory(DeleteMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<DeleteMsgRecordCategoryResponse>(req, "DeleteMsgRecordCategory");
        }

        /// <summary>
        /// Deletes a specified message record category
        /// </summary>
        /// <param name="req"><see cref="DeleteMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="DeleteMsgRecordCategoryResponse"/></returns>
        public DeleteMsgRecordCategoryResponse DeleteMsgRecordCategorySync(DeleteMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<DeleteMsgRecordCategoryResponse>(req, "DeleteMsgRecordCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a plug-in
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public Task<DeletePluginResponse> DeletePlugin(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin");
        }

        /// <summary>
        /// Modify a plug-in
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public DeletePluginResponse DeletePluginSync(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete QAs in batches
        /// </summary>
        /// <param name="req"><see cref="DeleteQAListRequest"/></param>
        /// <returns><see cref="DeleteQAListResponse"/></returns>
        public Task<DeleteQAListResponse> DeleteQAList(DeleteQAListRequest req)
        {
            return InternalRequestAsync<DeleteQAListResponse>(req, "DeleteQAList");
        }

        /// <summary>
        /// Delete QAs in batches
        /// </summary>
        /// <param name="req"><see cref="DeleteQAListRequest"/></param>
        /// <returns><see cref="DeleteQAListResponse"/></returns>
        public DeleteQAListResponse DeleteQAListSync(DeleteQAListRequest req)
        {
            return InternalRequestAsync<DeleteQAListResponse>(req, "DeleteQAList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Custom Skill Authorization: creator ∨ (edit permission ∧ delete permission) Denied scenarios: non-Custom type / shared / in security detection / pending listing approval / pending delisting approval
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillRequest"/></param>
        /// <returns><see cref="DeleteSkillResponse"/></returns>
        public Task<DeleteSkillResponse> DeleteSkill(DeleteSkillRequest req)
        {
            return InternalRequestAsync<DeleteSkillResponse>(req, "DeleteSkill");
        }

        /// <summary>
        /// Delete a Custom Skill Authorization: creator ∨ (edit permission ∧ delete permission) Denied scenarios: non-Custom type / shared / in security detection / pending listing approval / pending delisting approval
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillRequest"/></param>
        /// <returns><see cref="DeleteSkillResponse"/></returns>
        public DeleteSkillResponse DeleteSkillSync(DeleteSkillRequest req)
        {
            return InternalRequestAsync<DeleteSkillResponse>(req, "DeleteSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit a shared Skill delisting approval (v2, two-segment: submit → approve → callback to delist the shared Skill) Authorization: right to erasure Denied scenarios: not shared / pending listing approval / pending delisting approval
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillShareRequest"/></param>
        /// <returns><see cref="DeleteSkillShareResponse"/></returns>
        public Task<DeleteSkillShareResponse> DeleteSkillShare(DeleteSkillShareRequest req)
        {
            return InternalRequestAsync<DeleteSkillShareResponse>(req, "DeleteSkillShare");
        }

        /// <summary>
        /// Submit a shared Skill delisting approval (v2, two-segment: submit → approve → callback to delist the shared Skill) Authorization: right to erasure Denied scenarios: not shared / pending listing approval / pending delisting approval
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillShareRequest"/></param>
        /// <returns><see cref="DeleteSkillShareResponse"/></returns>
        public DeleteSkillShareResponse DeleteSkillShareSync(DeleteSkillShareRequest req)
        {
            return InternalRequestAsync<DeleteSkillShareResponse>(req, "DeleteSkillShare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a space
        /// </summary>
        /// <param name="req"><see cref="DeleteSpaceRequest"/></param>
        /// <returns><see cref="DeleteSpaceResponse"/></returns>
        public Task<DeleteSpaceResponse> DeleteSpace(DeleteSpaceRequest req)
        {
            return InternalRequestAsync<DeleteSpaceResponse>(req, "DeleteSpace");
        }

        /// <summary>
        /// Delete a space
        /// </summary>
        /// <param name="req"><see cref="DeleteSpaceRequest"/></param>
        /// <returns><see cref="DeleteSpaceResponse"/></returns>
        public DeleteSpaceResponse DeleteSpaceSync(DeleteSpaceRequest req)
        {
            return InternalRequestAsync<DeleteSpaceResponse>(req, "DeleteSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a parameter variable
        /// </summary>
        /// <param name="req"><see cref="DeleteVariableRequest"/></param>
        /// <returns><see cref="DeleteVariableResponse"/></returns>
        public Task<DeleteVariableResponse> DeleteVariable(DeleteVariableRequest req)
        {
            return InternalRequestAsync<DeleteVariableResponse>(req, "DeleteVariable");
        }

        /// <summary>
        /// Delete a parameter variable
        /// </summary>
        /// <param name="req"><see cref="DeleteVariableRequest"/></param>
        /// <returns><see cref="DeleteVariableResponse"/></returns>
        public DeleteVariableResponse DeleteVariableSync(DeleteVariableRequest req)
        {
            return InternalRequestAsync<DeleteVariableResponse>(req, "DeleteVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View the employee list of a business
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountListRequest"/></param>
        /// <returns><see cref="DescribeAccountListResponse"/></returns>
        public Task<DescribeAccountListResponse> DescribeAccountList(DescribeAccountListRequest req)
        {
            return InternalRequestAsync<DescribeAccountListResponse>(req, "DescribeAccountList");
        }

        /// <summary>
        /// View the employee list of a business
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountListRequest"/></param>
        /// <returns><see cref="DescribeAccountListResponse"/></returns>
        public DescribeAccountListResponse DescribeAccountListSync(DescribeAccountListRequest req)
        {
            return InternalRequestAsync<DescribeAccountListResponse>(req, "DescribeAccountList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Agent details
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDetailRequest"/></param>
        /// <returns><see cref="DescribeAgentDetailResponse"/></returns>
        public Task<DescribeAgentDetailResponse> DescribeAgentDetail(DescribeAgentDetailRequest req)
        {
            return InternalRequestAsync<DescribeAgentDetailResponse>(req, "DescribeAgentDetail");
        }

        /// <summary>
        /// Query Agent details
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDetailRequest"/></param>
        /// <returns><see cref="DescribeAgentDetailResponse"/></returns>
        public DescribeAgentDetailResponse DescribeAgentDetailSync(DescribeAgentDetailRequest req)
        {
            return InternalRequestAsync<DescribeAgentDetailResponse>(req, "DescribeAgentDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the release preview list of agents under an application
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentReleasePreviewListRequest"/></param>
        /// <returns><see cref="DescribeAgentReleasePreviewListResponse"/></returns>
        public Task<DescribeAgentReleasePreviewListResponse> DescribeAgentReleasePreviewList(DescribeAgentReleasePreviewListRequest req)
        {
            return InternalRequestAsync<DescribeAgentReleasePreviewListResponse>(req, "DescribeAgentReleasePreviewList");
        }

        /// <summary>
        /// Get the release preview list of agents under an application
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentReleasePreviewListRequest"/></param>
        /// <returns><see cref="DescribeAgentReleasePreviewListResponse"/></returns>
        public DescribeAgentReleasePreviewListResponse DescribeAgentReleasePreviewListSync(DescribeAgentReleasePreviewListRequest req)
        {
            return InternalRequestAsync<DescribeAgentReleasePreviewListResponse>(req, "DescribeAgentReleasePreviewList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the abstract information list of an Agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAgentSummaryListResponse"/></returns>
        public Task<DescribeAgentSummaryListResponse> DescribeAgentSummaryList(DescribeAgentSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAgentSummaryListResponse>(req, "DescribeAgentSummaryList");
        }

        /// <summary>
        /// Queries the abstract information list of an Agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAgentSummaryListResponse"/></returns>
        public DescribeAgentSummaryListResponse DescribeAgentSummaryListSync(DescribeAgentSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAgentSummaryListResponse>(req, "DescribeAgentSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain application information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp");
        }

        /// <summary>
        /// This API is used to obtain application information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public DescribeAppResponse DescribeAppSync(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the invocation statistics overview under an application view, including the total number of calls, call success rate, avg duration of total tokens, and avg duration of first tokens. For RAG applications, it also returns the count and proportion of calls for each response method for drawing a pie chart.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsOverviewRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsOverviewResponse"/></returns>
        public Task<DescribeAppStatisticsOverviewResponse> DescribeAppStatisticsOverview(DescribeAppStatisticsOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAppStatisticsOverviewResponse>(req, "DescribeAppStatisticsOverview");
        }

        /// <summary>
        /// This API is used to query the invocation statistics overview under an application view, including the total number of calls, call success rate, avg duration of total tokens, and avg duration of first tokens. For RAG applications, it also returns the count and proportion of calls for each response method for drawing a pie chart.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsOverviewRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsOverviewResponse"/></returns>
        public DescribeAppStatisticsOverviewResponse DescribeAppStatisticsOverviewSync(DescribeAppStatisticsOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAppStatisticsOverviewResponse>(req, "DescribeAppStatisticsOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the abstract list of applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppSummaryListResponse"/></returns>
        public Task<DescribeAppSummaryListResponse> DescribeAppSummaryList(DescribeAppSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppSummaryListResponse>(req, "DescribeAppSummaryList");
        }

        /// <summary>
        /// Retrieve the abstract list of applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppSummaryListResponse"/></returns>
        public DescribeAppSummaryListResponse DescribeAppSummaryListSync(DescribeAppSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppSummaryListResponse>(req, "DescribeAppSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerResponse"/></returns>
        public Task<DescribeAppTriggerResponse> DescribeAppTrigger(DescribeAppTriggerRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerResponse>(req, "DescribeAppTrigger");
        }

        /// <summary>
        /// DescribeAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerResponse"/></returns>
        public DescribeAppTriggerResponse DescribeAppTriggerSync(DescribeAppTriggerRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerResponse>(req, "DescribeAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTriggerInstance
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerInstanceRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerInstanceResponse"/></returns>
        public Task<DescribeAppTriggerInstanceResponse> DescribeAppTriggerInstance(DescribeAppTriggerInstanceRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerInstanceResponse>(req, "DescribeAppTriggerInstance");
        }

        /// <summary>
        /// DescribeAppTriggerInstance
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerInstanceRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerInstanceResponse"/></returns>
        public DescribeAppTriggerInstanceResponse DescribeAppTriggerInstanceSync(DescribeAppTriggerInstanceRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerInstanceResponse>(req, "DescribeAppTriggerInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTriggerRunLogList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRunLogListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerRunLogListResponse"/></returns>
        public Task<DescribeAppTriggerRunLogListResponse> DescribeAppTriggerRunLogList(DescribeAppTriggerRunLogListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerRunLogListResponse>(req, "DescribeAppTriggerRunLogList");
        }

        /// <summary>
        /// DescribeAppTriggerRunLogList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRunLogListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerRunLogListResponse"/></returns>
        public DescribeAppTriggerRunLogListResponse DescribeAppTriggerRunLogListSync(DescribeAppTriggerRunLogListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerRunLogListResponse>(req, "DescribeAppTriggerRunLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTriggerSummaryList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerSummaryListResponse"/></returns>
        public Task<DescribeAppTriggerSummaryListResponse> DescribeAppTriggerSummaryList(DescribeAppTriggerSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerSummaryListResponse>(req, "DescribeAppTriggerSummaryList");
        }

        /// <summary>
        /// DescribeAppTriggerSummaryList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerSummaryListResponse"/></returns>
        public DescribeAppTriggerSummaryListResponse DescribeAppTriggerSummaryListSync(DescribeAppTriggerSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerSummaryListResponse>(req, "DescribeAppTriggerSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View operation log list
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogListRequest"/></param>
        /// <returns><see cref="DescribeAuditLogListResponse"/></returns>
        public Task<DescribeAuditLogListResponse> DescribeAuditLogList(DescribeAuditLogListRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogListResponse>(req, "DescribeAuditLogList");
        }

        /// <summary>
        /// View operation log list
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogListRequest"/></param>
        /// <returns><see cref="DescribeAuditLogListResponse"/></returns>
        public DescribeAuditLogListResponse DescribeAuditLogListSync(DescribeAuditLogListRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogListResponse>(req, "DescribeAuditLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the classification list
        /// </summary>
        /// <param name="req"><see cref="DescribeCategoryListRequest"/></param>
        /// <returns><see cref="DescribeCategoryListResponse"/></returns>
        public Task<DescribeCategoryListResponse> DescribeCategoryList(DescribeCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeCategoryListResponse>(req, "DescribeCategoryList");
        }

        /// <summary>
        /// Query the classification list
        /// </summary>
        /// <param name="req"><see cref="DescribeCategoryListRequest"/></param>
        /// <returns><see cref="DescribeCategoryListResponse"/></returns>
        public DescribeCategoryListResponse DescribeCategoryListSync(DescribeCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeCategoryListResponse>(req, "DescribeCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query concurrency overrun details, including QPM/TPM overruns and exclusive concurrency overruns. Return the overrun time, space, app, model, and request content.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyLimitDetailListRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyLimitDetailListResponse"/></returns>
        public Task<DescribeConcurrencyLimitDetailListResponse> DescribeConcurrencyLimitDetailList(DescribeConcurrencyLimitDetailListRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyLimitDetailListResponse>(req, "DescribeConcurrencyLimitDetailList");
        }

        /// <summary>
        /// Query concurrency overrun details, including QPM/TPM overruns and exclusive concurrency overruns. Return the overrun time, space, app, model, and request content.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyLimitDetailListRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyLimitDetailListResponse"/></returns>
        public DescribeConcurrencyLimitDetailListResponse DescribeConcurrencyLimitDetailListSync(DescribeConcurrencyLimitDetailListRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyLimitDetailListResponse>(req, "DescribeConcurrencyLimitDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the conflict query details
        /// </summary>
        /// <param name="req"><see cref="DescribeConflictQARequest"/></param>
        /// <returns><see cref="DescribeConflictQAResponse"/></returns>
        public Task<DescribeConflictQAResponse> DescribeConflictQA(DescribeConflictQARequest req)
        {
            return InternalRequestAsync<DescribeConflictQAResponse>(req, "DescribeConflictQA");
        }

        /// <summary>
        /// Queries the conflict query details
        /// </summary>
        /// <param name="req"><see cref="DescribeConflictQARequest"/></param>
        /// <returns><see cref="DescribeConflictQAResponse"/></returns>
        public DescribeConflictQAResponse DescribeConflictQASync(DescribeConflictQARequest req)
        {
            return InternalRequestAsync<DescribeConflictQAResponse>(req, "DescribeConflictQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the conflict list
        /// </summary>
        /// <param name="req"><see cref="DescribeConflictQASummaryListRequest"/></param>
        /// <returns><see cref="DescribeConflictQASummaryListResponse"/></returns>
        public Task<DescribeConflictQASummaryListResponse> DescribeConflictQASummaryList(DescribeConflictQASummaryListRequest req)
        {
            return InternalRequestAsync<DescribeConflictQASummaryListResponse>(req, "DescribeConflictQASummaryList");
        }

        /// <summary>
        /// Query the conflict list
        /// </summary>
        /// <param name="req"><see cref="DescribeConflictQASummaryListRequest"/></param>
        /// <returns><see cref="DescribeConflictQASummaryListResponse"/></returns>
        public DescribeConflictQASummaryListResponse DescribeConflictQASummaryListSync(DescribeConflictQASummaryListRequest req)
        {
            return InternalRequestAsync<DescribeConflictQASummaryListResponse>(req, "DescribeConflictQASummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View session information.
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationRequest"/></param>
        /// <returns><see cref="DescribeConversationResponse"/></returns>
        public Task<DescribeConversationResponse> DescribeConversation(DescribeConversationRequest req)
        {
            return InternalRequestAsync<DescribeConversationResponse>(req, "DescribeConversation");
        }

        /// <summary>
        /// View session information.
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationRequest"/></param>
        /// <returns><see cref="DescribeConversationResponse"/></returns>
        public DescribeConversationResponse DescribeConversationSync(DescribeConversationRequest req)
        {
            return InternalRequestAsync<DescribeConversationResponse>(req, "DescribeConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get session list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationListRequest"/></param>
        /// <returns><see cref="DescribeConversationListResponse"/></returns>
        public Task<DescribeConversationListResponse> DescribeConversationList(DescribeConversationListRequest req)
        {
            return InternalRequestAsync<DescribeConversationListResponse>(req, "DescribeConversationList");
        }

        /// <summary>
        /// Get session list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationListRequest"/></param>
        /// <returns><see cref="DescribeConversationListResponse"/></returns>
        public DescribeConversationListResponse DescribeConversationListSync(DescribeConversationListRequest req)
        {
            return InternalRequestAsync<DescribeConversationListResponse>(req, "DescribeConversationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get historical messages of a conversation.
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationMessageListRequest"/></param>
        /// <returns><see cref="DescribeConversationMessageListResponse"/></returns>
        public Task<DescribeConversationMessageListResponse> DescribeConversationMessageList(DescribeConversationMessageListRequest req)
        {
            return InternalRequestAsync<DescribeConversationMessageListResponse>(req, "DescribeConversationMessageList");
        }

        /// <summary>
        /// Get historical messages of a conversation.
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationMessageListRequest"/></param>
        /// <returns><see cref="DescribeConversationMessageListResponse"/></returns>
        public DescribeConversationMessageListResponse DescribeConversationMessageListSync(DescribeConversationMessageListRequest req)
        {
            return InternalRequestAsync<DescribeConversationMessageListResponse>(req, "DescribeConversationMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries tag details.
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelRequest"/></param>
        /// <returns><see cref="DescribeLabelResponse"/></returns>
        public Task<DescribeLabelResponse> DescribeLabel(DescribeLabelRequest req)
        {
            return InternalRequestAsync<DescribeLabelResponse>(req, "DescribeLabel");
        }

        /// <summary>
        /// Queries tag details.
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelRequest"/></param>
        /// <returns><see cref="DescribeLabelResponse"/></returns>
        public DescribeLabelResponse DescribeLabelSync(DescribeLabelRequest req)
        {
            return InternalRequestAsync<DescribeLabelResponse>(req, "DescribeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying the Tag List
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelSummaryListRequest"/></param>
        /// <returns><see cref="DescribeLabelSummaryListResponse"/></returns>
        public Task<DescribeLabelSummaryListResponse> DescribeLabelSummaryList(DescribeLabelSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeLabelSummaryListResponse>(req, "DescribeLabelSummaryList");
        }

        /// <summary>
        /// Querying the Tag List
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelSummaryListRequest"/></param>
        /// <returns><see cref="DescribeLabelSummaryListResponse"/></returns>
        public DescribeLabelSummaryListResponse DescribeLabelSummaryListSync(DescribeLabelSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeLabelSummaryListResponse>(req, "DescribeLabelSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pull the latest release info (including release time, status, and channel).
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestReleaseRequest"/></param>
        /// <returns><see cref="DescribeLatestReleaseResponse"/></returns>
        public Task<DescribeLatestReleaseResponse> DescribeLatestRelease(DescribeLatestReleaseRequest req)
        {
            return InternalRequestAsync<DescribeLatestReleaseResponse>(req, "DescribeLatestRelease");
        }

        /// <summary>
        /// Pull the latest release info (including release time, status, and channel).
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestReleaseRequest"/></param>
        /// <returns><see cref="DescribeLatestReleaseResponse"/></returns>
        public DescribeLatestReleaseResponse DescribeLatestReleaseSync(DescribeLatestReleaseRequest req)
        {
            return InternalRequestAsync<DescribeLatestReleaseResponse>(req, "DescribeLatestRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the model list
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public Task<DescribeModelListResponse> DescribeModelList(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList");
        }

        /// <summary>
        /// Query the model list
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public DescribeModelListResponse DescribeModelListSync(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the message record category tree of an app, return categories and subcategories, number of records under each category, and operation permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRecordCategoryListRequest"/></param>
        /// <returns><see cref="DescribeMsgRecordCategoryListResponse"/></returns>
        public Task<DescribeMsgRecordCategoryListResponse> DescribeMsgRecordCategoryList(DescribeMsgRecordCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeMsgRecordCategoryListResponse>(req, "DescribeMsgRecordCategoryList");
        }

        /// <summary>
        /// Query the message record category tree of an app, return categories and subcategories, number of records under each category, and operation permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRecordCategoryListRequest"/></param>
        /// <returns><see cref="DescribeMsgRecordCategoryListResponse"/></returns>
        public DescribeMsgRecordCategoryListResponse DescribeMsgRecordCategoryListSync(DescribeMsgRecordCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeMsgRecordCategoryListResponse>(req, "DescribeMsgRecordCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeNodeBatchRun
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeBatchRunRequest"/></param>
        /// <returns><see cref="DescribeNodeBatchRunResponse"/></returns>
        public Task<DescribeNodeBatchRunResponse> DescribeNodeBatchRun(DescribeNodeBatchRunRequest req)
        {
            return InternalRequestAsync<DescribeNodeBatchRunResponse>(req, "DescribeNodeBatchRun");
        }

        /// <summary>
        /// DescribeNodeBatchRun
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeBatchRunRequest"/></param>
        /// <returns><see cref="DescribeNodeBatchRunResponse"/></returns>
        public DescribeNodeBatchRunResponse DescribeNodeBatchRunSync(DescribeNodeBatchRunRequest req)
        {
            return InternalRequestAsync<DescribeNodeBatchRunResponse>(req, "DescribeNodeBatchRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View workflow node running details.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRunDetailRequest"/></param>
        /// <returns><see cref="DescribeNodeRunDetailResponse"/></returns>
        public Task<DescribeNodeRunDetailResponse> DescribeNodeRunDetail(DescribeNodeRunDetailRequest req)
        {
            return InternalRequestAsync<DescribeNodeRunDetailResponse>(req, "DescribeNodeRunDetail");
        }

        /// <summary>
        /// View workflow node running details.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRunDetailRequest"/></param>
        /// <returns><see cref="DescribeNodeRunDetailResponse"/></returns>
        public DescribeNodeRunDetailResponse DescribeNodeRunDetailSync(DescribeNodeRunDetailRequest req)
        {
            return InternalRequestAsync<DescribeNodeRunDetailResponse>(req, "DescribeNodeRunDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query plugin details.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public Task<DescribePluginResponse> DescribePlugin(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin");
        }

        /// <summary>
        /// This API is used to query plugin details.
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public DescribePluginResponse DescribePluginSync(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying the List of Plugins
        /// </summary>
        /// <param name="req"><see cref="DescribePluginSummaryListRequest"/></param>
        /// <returns><see cref="DescribePluginSummaryListResponse"/></returns>
        public Task<DescribePluginSummaryListResponse> DescribePluginSummaryList(DescribePluginSummaryListRequest req)
        {
            return InternalRequestAsync<DescribePluginSummaryListResponse>(req, "DescribePluginSummaryList");
        }

        /// <summary>
        /// Querying the List of Plugins
        /// </summary>
        /// <param name="req"><see cref="DescribePluginSummaryListRequest"/></param>
        /// <returns><see cref="DescribePluginSummaryListResponse"/></returns>
        public DescribePluginSummaryListResponse DescribePluginSummaryListSync(DescribePluginSummaryListRequest req)
        {
            return InternalRequestAsync<DescribePluginSummaryListResponse>(req, "DescribePluginSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query QA details
        /// </summary>
        /// <param name="req"><see cref="DescribeQARequest"/></param>
        /// <returns><see cref="DescribeQAResponse"/></returns>
        public Task<DescribeQAResponse> DescribeQA(DescribeQARequest req)
        {
            return InternalRequestAsync<DescribeQAResponse>(req, "DescribeQA");
        }

        /// <summary>
        /// Query QA details
        /// </summary>
        /// <param name="req"><see cref="DescribeQARequest"/></param>
        /// <returns><see cref="DescribeQAResponse"/></returns>
        public DescribeQAResponse DescribeQASync(DescribeQARequest req)
        {
            return InternalRequestAsync<DescribeQAResponse>(req, "DescribeQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the QA list
        /// </summary>
        /// <param name="req"><see cref="DescribeQASummaryListRequest"/></param>
        /// <returns><see cref="DescribeQASummaryListResponse"/></returns>
        public Task<DescribeQASummaryListResponse> DescribeQASummaryList(DescribeQASummaryListRequest req)
        {
            return InternalRequestAsync<DescribeQASummaryListResponse>(req, "DescribeQASummaryList");
        }

        /// <summary>
        /// Queries the QA list
        /// </summary>
        /// <param name="req"><see cref="DescribeQASummaryListRequest"/></param>
        /// <returns><see cref="DescribeQASummaryListResponse"/></returns>
        public DescribeQASummaryListResponse DescribeQASummaryListSync(DescribeQASummaryListRequest req)
        {
            return InternalRequestAsync<DescribeQASummaryListResponse>(req, "DescribeQASummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Release record list
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseListRequest"/></param>
        /// <returns><see cref="DescribeReleaseListResponse"/></returns>
        public Task<DescribeReleaseListResponse> DescribeReleaseList(DescribeReleaseListRequest req)
        {
            return InternalRequestAsync<DescribeReleaseListResponse>(req, "DescribeReleaseList");
        }

        /// <summary>
        /// Release record list
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseListRequest"/></param>
        /// <returns><see cref="DescribeReleaseListResponse"/></returns>
        public DescribeReleaseListResponse DescribeReleaseListSync(DescribeReleaseListRequest req)
        {
            return InternalRequestAsync<DescribeReleaseListResponse>(req, "DescribeReleaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries a publication task
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseSummaryRequest"/></param>
        /// <returns><see cref="DescribeReleaseSummaryResponse"/></returns>
        public Task<DescribeReleaseSummaryResponse> DescribeReleaseSummary(DescribeReleaseSummaryRequest req)
        {
            return InternalRequestAsync<DescribeReleaseSummaryResponse>(req, "DescribeReleaseSummary");
        }

        /// <summary>
        /// Queries a publication task
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseSummaryRequest"/></param>
        /// <returns><see cref="DescribeReleaseSummaryResponse"/></returns>
        public DescribeReleaseSummaryResponse DescribeReleaseSummarySync(DescribeReleaseSummaryRequest req)
        {
            return InternalRequestAsync<DescribeReleaseSummaryResponse>(req, "DescribeReleaseSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Skill classification list
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillCategoryListRequest"/></param>
        /// <returns><see cref="DescribeSkillCategoryListResponse"/></returns>
        public Task<DescribeSkillCategoryListResponse> DescribeSkillCategoryList(DescribeSkillCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillCategoryListResponse>(req, "DescribeSkillCategoryList");
        }

        /// <summary>
        /// Query the Skill classification list
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillCategoryListRequest"/></param>
        /// <returns><see cref="DescribeSkillCategoryListResponse"/></returns>
        public DescribeSkillCategoryListResponse DescribeSkillCategoryListSync(DescribeSkillCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillCategoryListResponse>(req, "DescribeSkillCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of details where a certain Skill is referenced, grouped by SkillRefType: OpenClaw, cloud agent, or business assistant agent. Authentication: same as DescribeSkillDetail.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillReferenceListRequest"/></param>
        /// <returns><see cref="DescribeSkillReferenceListResponse"/></returns>
        public Task<DescribeSkillReferenceListResponse> DescribeSkillReferenceList(DescribeSkillReferenceListRequest req)
        {
            return InternalRequestAsync<DescribeSkillReferenceListResponse>(req, "DescribeSkillReferenceList");
        }

        /// <summary>
        /// This API is used to query the list of details where a certain Skill is referenced, grouped by SkillRefType: OpenClaw, cloud agent, or business assistant agent. Authentication: same as DescribeSkillDetail.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillReferenceListRequest"/></param>
        /// <returns><see cref="DescribeSkillReferenceListResponse"/></returns>
        public DescribeSkillReferenceListResponse DescribeSkillReferenceListSync(DescribeSkillReferenceListRequest req)
        {
            return InternalRequestAsync<DescribeSkillReferenceListResponse>(req, "DescribeSkillReferenceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Skill list
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillSummaryListRequest"/></param>
        /// <returns><see cref="DescribeSkillSummaryListResponse"/></returns>
        public Task<DescribeSkillSummaryListResponse> DescribeSkillSummaryList(DescribeSkillSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillSummaryListResponse>(req, "DescribeSkillSummaryList");
        }

        /// <summary>
        /// Query the Skill list
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillSummaryListRequest"/></param>
        /// <returns><see cref="DescribeSkillSummaryListResponse"/></returns>
        public DescribeSkillSummaryListResponse DescribeSkillSummaryListSync(DescribeSkillSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillSummaryListResponse>(req, "DescribeSkillSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the space list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceListRequest"/></param>
        /// <returns><see cref="DescribeSpaceListResponse"/></returns>
        public Task<DescribeSpaceListResponse> DescribeSpaceList(DescribeSpaceListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceListResponse>(req, "DescribeSpaceList");
        }

        /// <summary>
        /// This API is used to obtain the space list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceListRequest"/></param>
        /// <returns><see cref="DescribeSpaceListResponse"/></returns>
        public DescribeSpaceListResponse DescribeSpaceListSync(DescribeSpaceListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceListResponse>(req, "DescribeSpaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain system variables
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVariableListRequest"/></param>
        /// <returns><see cref="DescribeSystemVariableListResponse"/></returns>
        public Task<DescribeSystemVariableListResponse> DescribeSystemVariableList(DescribeSystemVariableListRequest req)
        {
            return InternalRequestAsync<DescribeSystemVariableListResponse>(req, "DescribeSystemVariableList");
        }

        /// <summary>
        /// Obtain system variables
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVariableListRequest"/></param>
        /// <returns><see cref="DescribeSystemVariableListResponse"/></returns>
        public DescribeSystemVariableListResponse DescribeSystemVariableListSync(DescribeSystemVariableListRequest req)
        {
            return InternalRequestAsync<DescribeSystemVariableListResponse>(req, "DescribeSystemVariableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query aggregated details of resource usage, including three types of resources: models, plug-ins, and platforms. It displays indicators such as call count and Token consumption, aggregated by space or application dimension.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryListRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryListResponse"/></returns>
        public Task<DescribeUsageSummaryListResponse> DescribeUsageSummaryList(DescribeUsageSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeUsageSummaryListResponse>(req, "DescribeUsageSummaryList");
        }

        /// <summary>
        /// This API is used to query aggregated details of resource usage, including three types of resources: models, plug-ins, and platforms. It displays indicators such as call count and Token consumption, aggregated by space or application dimension.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryListRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryListResponse"/></returns>
        public DescribeUsageSummaryListResponse DescribeUsageSummaryListSync(DescribeUsageSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeUsageSummaryListResponse>(req, "DescribeUsageSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get parameter variables
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableRequest"/></param>
        /// <returns><see cref="DescribeVariableResponse"/></returns>
        public Task<DescribeVariableResponse> DescribeVariable(DescribeVariableRequest req)
        {
            return InternalRequestAsync<DescribeVariableResponse>(req, "DescribeVariable");
        }

        /// <summary>
        /// Get parameter variables
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableRequest"/></param>
        /// <returns><see cref="DescribeVariableResponse"/></returns>
        public DescribeVariableResponse DescribeVariableSync(DescribeVariableRequest req)
        {
            return InternalRequestAsync<DescribeVariableResponse>(req, "DescribeVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the parameter variable list
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableListRequest"/></param>
        /// <returns><see cref="DescribeVariableListResponse"/></returns>
        public Task<DescribeVariableListResponse> DescribeVariableList(DescribeVariableListRequest req)
        {
            return InternalRequestAsync<DescribeVariableListResponse>(req, "DescribeVariableList");
        }

        /// <summary>
        /// Gets the parameter variable list
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableListRequest"/></param>
        /// <returns><see cref="DescribeVariableListResponse"/></returns>
        public DescribeVariableListResponse DescribeVariableListSync(DescribeVariableListRequest req)
        {
            return InternalRequestAsync<DescribeVariableListResponse>(req, "DescribeVariableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries workflow running details.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowRunRequest"/></param>
        /// <returns><see cref="DescribeWorkflowRunResponse"/></returns>
        public Task<DescribeWorkflowRunResponse> DescribeWorkflowRun(DescribeWorkflowRunRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowRunResponse>(req, "DescribeWorkflowRun");
        }

        /// <summary>
        /// Queries workflow running details.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowRunRequest"/></param>
        /// <returns><see cref="DescribeWorkflowRunResponse"/></returns>
        public DescribeWorkflowRunResponse DescribeWorkflowRunSync(DescribeWorkflowRunRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowRunResponse>(req, "DescribeWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously export QAs.
        /// </summary>
        /// <param name="req"><see cref="ExportQARequest"/></param>
        /// <returns><see cref="ExportQAResponse"/></returns>
        public Task<ExportQAResponse> ExportQA(ExportQARequest req)
        {
            return InternalRequestAsync<ExportQAResponse>(req, "ExportQA");
        }

        /// <summary>
        /// Asynchronously export QAs.
        /// </summary>
        /// <param name="req"><see cref="ExportQARequest"/></param>
        /// <returns><see cref="ExportQAResponse"/></returns>
        public ExportQAResponse ExportQASync(ExportQARequest req)
        {
            return InternalRequestAsync<ExportQAResponse>(req, "ExportQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Agent configuration information
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRequest"/></param>
        /// <returns><see cref="ModifyAgentResponse"/></returns>
        public Task<ModifyAgentResponse> ModifyAgent(ModifyAgentRequest req)
        {
            return InternalRequestAsync<ModifyAgentResponse>(req, "ModifyAgent");
        }

        /// <summary>
        /// Modify Agent configuration information
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRequest"/></param>
        /// <returns><see cref="ModifyAgentResponse"/></returns>
        public ModifyAgentResponse ModifyAgentSync(ModifyAgentRequest req)
        {
            return InternalRequestAsync<ModifyAgentResponse>(req, "ModifyAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies applications
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp");
        }

        /// <summary>
        /// Modifies applications
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyAppTrigger
        /// </summary>
        /// <param name="req"><see cref="ModifyAppTriggerRequest"/></param>
        /// <returns><see cref="ModifyAppTriggerResponse"/></returns>
        public Task<ModifyAppTriggerResponse> ModifyAppTrigger(ModifyAppTriggerRequest req)
        {
            return InternalRequestAsync<ModifyAppTriggerResponse>(req, "ModifyAppTrigger");
        }

        /// <summary>
        /// ModifyAppTrigger
        /// </summary>
        /// <param name="req"><see cref="ModifyAppTriggerRequest"/></param>
        /// <returns><see cref="ModifyAppTriggerResponse"/></returns>
        public ModifyAppTriggerResponse ModifyAppTriggerSync(ModifyAppTriggerRequest req)
        {
            return InternalRequestAsync<ModifyAppTriggerResponse>(req, "ModifyAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify session information.
        /// </summary>
        /// <param name="req"><see cref="ModifyConversationRequest"/></param>
        /// <returns><see cref="ModifyConversationResponse"/></returns>
        public Task<ModifyConversationResponse> ModifyConversation(ModifyConversationRequest req)
        {
            return InternalRequestAsync<ModifyConversationResponse>(req, "ModifyConversation");
        }

        /// <summary>
        /// Modify session information.
        /// </summary>
        /// <param name="req"><see cref="ModifyConversationRequest"/></param>
        /// <returns><see cref="ModifyConversationResponse"/></returns>
        public ModifyConversationResponse ModifyConversationSync(ModifyConversationRequest req)
        {
            return InternalRequestAsync<ModifyConversationResponse>(req, "ModifyConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify documents.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocListRequest"/></param>
        /// <returns><see cref="ModifyDocListResponse"/></returns>
        public Task<ModifyDocListResponse> ModifyDocList(ModifyDocListRequest req)
        {
            return InternalRequestAsync<ModifyDocListResponse>(req, "ModifyDocList");
        }

        /// <summary>
        /// Batch modify documents.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocListRequest"/></param>
        /// <returns><see cref="ModifyDocListResponse"/></returns>
        public ModifyDocListResponse ModifyDocListSync(ModifyDocListRequest req)
        {
            return InternalRequestAsync<ModifyDocListResponse>(req, "ModifyDocList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the knowledge base.
        /// </summary>
        /// <param name="req"><see cref="ModifyKBRequest"/></param>
        /// <returns><see cref="ModifyKBResponse"/></returns>
        public Task<ModifyKBResponse> ModifyKB(ModifyKBRequest req)
        {
            return InternalRequestAsync<ModifyKBResponse>(req, "ModifyKB");
        }

        /// <summary>
        /// This API is used to modify the knowledge base.
        /// </summary>
        /// <param name="req"><see cref="ModifyKBRequest"/></param>
        /// <returns><see cref="ModifyKBResponse"/></returns>
        public ModifyKBResponse ModifyKBSync(ModifyKBRequest req)
        {
            return InternalRequestAsync<ModifyKBResponse>(req, "ModifyKB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a tag
        /// </summary>
        /// <param name="req"><see cref="ModifyLabelRequest"/></param>
        /// <returns><see cref="ModifyLabelResponse"/></returns>
        public Task<ModifyLabelResponse> ModifyLabel(ModifyLabelRequest req)
        {
            return InternalRequestAsync<ModifyLabelResponse>(req, "ModifyLabel");
        }

        /// <summary>
        /// Modify a tag
        /// </summary>
        /// <param name="req"><see cref="ModifyLabelRequest"/></param>
        /// <returns><see cref="ModifyLabelResponse"/></returns>
        public ModifyLabelResponse ModifyLabelSync(ModifyLabelRequest req)
        {
            return InternalRequestAsync<ModifyLabelResponse>(req, "ModifyLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify single QA
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public Task<ModifyQAResponse> ModifyQA(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA");
        }

        /// <summary>
        /// Modify single QA
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public ModifyQAResponse ModifyQASync(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify QAs
        /// </summary>
        /// <param name="req"><see cref="ModifyQAListRequest"/></param>
        /// <returns><see cref="ModifyQAListResponse"/></returns>
        public Task<ModifyQAListResponse> ModifyQAList(ModifyQAListRequest req)
        {
            return InternalRequestAsync<ModifyQAListResponse>(req, "ModifyQAList");
        }

        /// <summary>
        /// Batch modify QAs
        /// </summary>
        /// <param name="req"><see cref="ModifyQAListRequest"/></param>
        /// <returns><see cref="ModifyQAListResponse"/></returns>
        public ModifyQAListResponse ModifyQAListSync(ModifyQAListRequest req)
        {
            return InternalRequestAsync<ModifyQAListResponse>(req, "ModifyQAList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit a space
        /// </summary>
        /// <param name="req"><see cref="ModifySpaceRequest"/></param>
        /// <returns><see cref="ModifySpaceResponse"/></returns>
        public Task<ModifySpaceResponse> ModifySpace(ModifySpaceRequest req)
        {
            return InternalRequestAsync<ModifySpaceResponse>(req, "ModifySpace");
        }

        /// <summary>
        /// Edit a space
        /// </summary>
        /// <param name="req"><see cref="ModifySpaceRequest"/></param>
        /// <returns><see cref="ModifySpaceResponse"/></returns>
        public ModifySpaceResponse ModifySpaceSync(ModifySpaceRequest req)
        {
            return InternalRequestAsync<ModifySpaceResponse>(req, "ModifySpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update parameter variables
        /// </summary>
        /// <param name="req"><see cref="ModifyVariableRequest"/></param>
        /// <returns><see cref="ModifyVariableResponse"/></returns>
        public Task<ModifyVariableResponse> ModifyVariable(ModifyVariableRequest req)
        {
            return InternalRequestAsync<ModifyVariableResponse>(req, "ModifyVariable");
        }

        /// <summary>
        /// Update parameter variables
        /// </summary>
        /// <param name="req"><see cref="ModifyVariableRequest"/></param>
        /// <returns><see cref="ModifyVariableResponse"/></returns>
        public ModifyVariableResponse ModifyVariableSync(ModifyVariableRequest req)
        {
            return InternalRequestAsync<ModifyVariableResponse>(req, "ModifyVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// PauseAppTrigger
        /// </summary>
        /// <param name="req"><see cref="PauseAppTriggerRequest"/></param>
        /// <returns><see cref="PauseAppTriggerResponse"/></returns>
        public Task<PauseAppTriggerResponse> PauseAppTrigger(PauseAppTriggerRequest req)
        {
            return InternalRequestAsync<PauseAppTriggerResponse>(req, "PauseAppTrigger");
        }

        /// <summary>
        /// PauseAppTrigger
        /// </summary>
        /// <param name="req"><see cref="PauseAppTriggerRequest"/></param>
        /// <returns><see cref="PauseAppTriggerResponse"/></returns>
        public PauseAppTriggerResponse PauseAppTriggerSync(PauseAppTriggerRequest req)
        {
            return InternalRequestAsync<PauseAppTriggerResponse>(req, "PauseAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list a skill.
        /// </summary>
        /// <param name="req"><see cref="ReleaseSkillRequest"/></param>
        /// <returns><see cref="ReleaseSkillResponse"/></returns>
        public Task<ReleaseSkillResponse> ReleaseSkill(ReleaseSkillRequest req)
        {
            return InternalRequestAsync<ReleaseSkillResponse>(req, "ReleaseSkill");
        }

        /// <summary>
        /// This API is used to list a skill.
        /// </summary>
        /// <param name="req"><see cref="ReleaseSkillRequest"/></param>
        /// <returns><see cref="ReleaseSkillResponse"/></returns>
        public ReleaseSkillResponse ReleaseSkillSync(ReleaseSkillRequest req)
        {
            return InternalRequestAsync<ReleaseSkillResponse>(req, "ReleaseSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reset a session
        /// Note: Resetting is not supported for the current Claw mode application session.
        /// </summary>
        /// <param name="req"><see cref="ResetConversationRequest"/></param>
        /// <returns><see cref="ResetConversationResponse"/></returns>
        public Task<ResetConversationResponse> ResetConversation(ResetConversationRequest req)
        {
            return InternalRequestAsync<ResetConversationResponse>(req, "ResetConversation");
        }

        /// <summary>
        /// Reset a session
        /// Note: Resetting is not supported for the current Claw mode application session.
        /// </summary>
        /// <param name="req"><see cref="ResetConversationRequest"/></param>
        /// <returns><see cref="ResetConversationResponse"/></returns>
        public ResetConversationResponse ResetConversationSync(ResetConversationRequest req)
        {
            return InternalRequestAsync<ResetConversationResponse>(req, "ResetConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retry publishing (republish after suspension)
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public Task<RetryReleaseResponse> RetryRelease(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease");
        }

        /// <summary>
        /// Retry publishing (republish after suspension)
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public RetryReleaseResponse RetryReleaseSync(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Roll back a release
        /// </summary>
        /// <param name="req"><see cref="RollbackReleaseRequest"/></param>
        /// <returns><see cref="RollbackReleaseResponse"/></returns>
        public Task<RollbackReleaseResponse> RollbackRelease(RollbackReleaseRequest req)
        {
            return InternalRequestAsync<RollbackReleaseResponse>(req, "RollbackRelease");
        }

        /// <summary>
        /// Roll back a release
        /// </summary>
        /// <param name="req"><see cref="RollbackReleaseRequest"/></param>
        /// <returns><see cref="RollbackReleaseResponse"/></returns>
        public RollbackReleaseResponse RollbackReleaseSync(RollbackReleaseRequest req)
        {
            return InternalRequestAsync<RollbackReleaseResponse>(req, "RollbackRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RunAppTriggerNow
        /// </summary>
        /// <param name="req"><see cref="RunAppTriggerNowRequest"/></param>
        /// <returns><see cref="RunAppTriggerNowResponse"/></returns>
        public Task<RunAppTriggerNowResponse> RunAppTriggerNow(RunAppTriggerNowRequest req)
        {
            return InternalRequestAsync<RunAppTriggerNowResponse>(req, "RunAppTriggerNow");
        }

        /// <summary>
        /// RunAppTriggerNow
        /// </summary>
        /// <param name="req"><see cref="RunAppTriggerNowRequest"/></param>
        /// <returns><see cref="RunAppTriggerNowResponse"/></returns>
        public RunAppTriggerNowResponse RunAppTriggerNowSync(RunAppTriggerNowRequest req)
        {
            return InternalRequestAsync<RunAppTriggerNowResponse>(req, "RunAppTriggerNow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Knowledge retrieval
        /// </summary>
        /// <param name="req"><see cref="SearchKnowledgeRequest"/></param>
        /// <returns><see cref="SearchKnowledgeResponse"/></returns>
        public Task<SearchKnowledgeResponse> SearchKnowledge(SearchKnowledgeRequest req)
        {
            return InternalRequestAsync<SearchKnowledgeResponse>(req, "SearchKnowledge");
        }

        /// <summary>
        /// Knowledge retrieval
        /// </summary>
        /// <param name="req"><see cref="SearchKnowledgeRequest"/></param>
        /// <returns><see cref="SearchKnowledgeResponse"/></returns>
        public SearchKnowledgeResponse SearchKnowledgeSync(SearchKnowledgeRequest req)
        {
            return InternalRequestAsync<SearchKnowledgeResponse>(req, "SearchKnowledge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
