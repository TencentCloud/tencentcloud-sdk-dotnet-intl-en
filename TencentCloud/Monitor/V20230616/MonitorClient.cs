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

namespace TencentCloud.Monitor.V20230616
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20230616.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.intl.tencentcloudapi.com";
       private const string version = "2023-06-16";
       private const string sdkVersion = "SDK_NET_3.0.1392";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Cancel dialogue execution
        /// </summary>
        /// <param name="req"><see cref="CancelAIWorkbenchChatRequest"/></param>
        /// <returns><see cref="CancelAIWorkbenchChatResponse"/></returns>
        public Task<CancelAIWorkbenchChatResponse> CancelAIWorkbenchChat(CancelAIWorkbenchChatRequest req)
        {
            return InternalRequestAsync<CancelAIWorkbenchChatResponse>(req, "CancelAIWorkbenchChat");
        }

        /// <summary>
        /// Cancel dialogue execution
        /// </summary>
        /// <param name="req"><see cref="CancelAIWorkbenchChatRequest"/></param>
        /// <returns><see cref="CancelAIWorkbenchChatResponse"/></returns>
        public CancelAIWorkbenchChatResponse CancelAIWorkbenchChatSync(CancelAIWorkbenchChatRequest req)
        {
            return InternalRequestAsync<CancelAIWorkbenchChatResponse>(req, "CancelAIWorkbenchChat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an Agent.
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchAgentResponse"/></returns>
        public Task<CreateAIWorkbenchAgentResponse> CreateAIWorkbenchAgent(CreateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchAgentResponse>(req, "CreateAIWorkbenchAgent");
        }

        /// <summary>
        /// This API is used to create an Agent.
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchAgentResponse"/></returns>
        public CreateAIWorkbenchAgentResponse CreateAIWorkbenchAgentSync(CreateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchAgentResponse>(req, "CreateAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a task
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchTaskResponse"/></returns>
        public Task<CreateAIWorkbenchTaskResponse> CreateAIWorkbenchTask(CreateAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchTaskResponse>(req, "CreateAIWorkbenchTask");
        }

        /// <summary>
        /// Create a task
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchTaskResponse"/></returns>
        public CreateAIWorkbenchTaskResponse CreateAIWorkbenchTaskSync(CreateAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchTaskResponse>(req, "CreateAIWorkbenchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchAgentResponse"/></returns>
        public Task<DeleteAIWorkbenchAgentResponse> DeleteAIWorkbenchAgent(DeleteAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchAgentResponse>(req, "DeleteAIWorkbenchAgent");
        }

        /// <summary>
        /// Delete Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchAgentResponse"/></returns>
        public DeleteAIWorkbenchAgentResponse DeleteAIWorkbenchAgentSync(DeleteAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchAgentResponse>(req, "DeleteAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a task.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchTaskResponse"/></returns>
        public Task<DeleteAIWorkbenchTaskResponse> DeleteAIWorkbenchTask(DeleteAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchTaskResponse>(req, "DeleteAIWorkbenchTask");
        }

        /// <summary>
        /// This API is used to delete a task.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchTaskResponse"/></returns>
        public DeleteAIWorkbenchTaskResponse DeleteAIWorkbenchTaskSync(DeleteAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchTaskResponse>(req, "DeleteAIWorkbenchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Agent details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchAgentResponse"/></returns>
        public Task<DescribeAIWorkbenchAgentResponse> DescribeAIWorkbenchAgent(DescribeAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchAgentResponse>(req, "DescribeAIWorkbenchAgent");
        }

        /// <summary>
        /// Query Agent details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchAgentResponse"/></returns>
        public DescribeAIWorkbenchAgentResponse DescribeAIWorkbenchAgentSync(DescribeAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchAgentResponse>(req, "DescribeAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query artifact details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchArtifactRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchArtifactResponse"/></returns>
        public Task<DescribeAIWorkbenchArtifactResponse> DescribeAIWorkbenchArtifact(DescribeAIWorkbenchArtifactRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchArtifactResponse>(req, "DescribeAIWorkbenchArtifact");
        }

        /// <summary>
        /// Query artifact details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchArtifactRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchArtifactResponse"/></returns>
        public DescribeAIWorkbenchArtifactResponse DescribeAIWorkbenchArtifactSync(DescribeAIWorkbenchArtifactRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchArtifactResponse>(req, "DescribeAIWorkbenchArtifact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query execution details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchExecutionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchExecutionResponse"/></returns>
        public Task<DescribeAIWorkbenchExecutionResponse> DescribeAIWorkbenchExecution(DescribeAIWorkbenchExecutionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchExecutionResponse>(req, "DescribeAIWorkbenchExecution");
        }

        /// <summary>
        /// Query execution details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchExecutionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchExecutionResponse"/></returns>
        public DescribeAIWorkbenchExecutionResponse DescribeAIWorkbenchExecutionSync(DescribeAIWorkbenchExecutionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchExecutionResponse>(req, "DescribeAIWorkbenchExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query session details
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSessionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSessionResponse"/></returns>
        public Task<DescribeAIWorkbenchSessionResponse> DescribeAIWorkbenchSession(DescribeAIWorkbenchSessionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSessionResponse>(req, "DescribeAIWorkbenchSession");
        }

        /// <summary>
        /// Query session details
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSessionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSessionResponse"/></returns>
        public DescribeAIWorkbenchSessionResponse DescribeAIWorkbenchSessionSync(DescribeAIWorkbenchSessionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSessionResponse>(req, "DescribeAIWorkbenchSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query skill details
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSkillRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSkillResponse"/></returns>
        public Task<DescribeAIWorkbenchSkillResponse> DescribeAIWorkbenchSkill(DescribeAIWorkbenchSkillRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSkillResponse>(req, "DescribeAIWorkbenchSkill");
        }

        /// <summary>
        /// Query skill details
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSkillRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSkillResponse"/></returns>
        public DescribeAIWorkbenchSkillResponse DescribeAIWorkbenchSkillSync(DescribeAIWorkbenchSkillRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSkillResponse>(req, "DescribeAIWorkbenchSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query alarm notification history as needed
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNotifyHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNotifyHistoriesResponse"/></returns>
        public Task<DescribeAlarmNotifyHistoriesResponse> DescribeAlarmNotifyHistories(DescribeAlarmNotifyHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNotifyHistoriesResponse>(req, "DescribeAlarmNotifyHistories");
        }

        /// <summary>
        /// Query alarm notification history as needed
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNotifyHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNotifyHistoriesResponse"/></returns>
        public DescribeAlarmNotifyHistoriesResponse DescribeAlarmNotifyHistoriesSync(DescribeAlarmNotifyHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNotifyHistoriesResponse>(req, "DescribeAlarmNotifyHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the download URL of AI Workbench artifacts.
        /// </summary>
        /// <param name="req"><see cref="GetAIWorkbenchArtifactDownloadURLRequest"/></param>
        /// <returns><see cref="GetAIWorkbenchArtifactDownloadURLResponse"/></returns>
        public Task<GetAIWorkbenchArtifactDownloadURLResponse> GetAIWorkbenchArtifactDownloadURL(GetAIWorkbenchArtifactDownloadURLRequest req)
        {
            return InternalRequestAsync<GetAIWorkbenchArtifactDownloadURLResponse>(req, "GetAIWorkbenchArtifactDownloadURL");
        }

        /// <summary>
        /// Get the download URL of AI Workbench artifacts.
        /// </summary>
        /// <param name="req"><see cref="GetAIWorkbenchArtifactDownloadURLRequest"/></param>
        /// <returns><see cref="GetAIWorkbenchArtifactDownloadURLResponse"/></returns>
        public GetAIWorkbenchArtifactDownloadURLResponse GetAIWorkbenchArtifactDownloadURLSync(GetAIWorkbenchArtifactDownloadURLRequest req)
        {
            return InternalRequestAsync<GetAIWorkbenchArtifactDownloadURLResponse>(req, "GetAIWorkbenchArtifactDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Agent list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchAgentsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchAgentsResponse"/></returns>
        public Task<ListAIWorkbenchAgentsResponse> ListAIWorkbenchAgents(ListAIWorkbenchAgentsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchAgentsResponse>(req, "ListAIWorkbenchAgents");
        }

        /// <summary>
        /// Query the Agent list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchAgentsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchAgentsResponse"/></returns>
        public ListAIWorkbenchAgentsResponse ListAIWorkbenchAgentsSync(ListAIWorkbenchAgentsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchAgentsResponse>(req, "ListAIWorkbenchAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the product list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchArtifactsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchArtifactsResponse"/></returns>
        public Task<ListAIWorkbenchArtifactsResponse> ListAIWorkbenchArtifacts(ListAIWorkbenchArtifactsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchArtifactsResponse>(req, "ListAIWorkbenchArtifacts");
        }

        /// <summary>
        /// Query the product list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchArtifactsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchArtifactsResponse"/></returns>
        public ListAIWorkbenchArtifactsResponse ListAIWorkbenchArtifactsSync(ListAIWorkbenchArtifactsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchArtifactsResponse>(req, "ListAIWorkbenchArtifacts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the execution list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchExecutionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchExecutionsResponse"/></returns>
        public Task<ListAIWorkbenchExecutionsResponse> ListAIWorkbenchExecutions(ListAIWorkbenchExecutionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchExecutionsResponse>(req, "ListAIWorkbenchExecutions");
        }

        /// <summary>
        /// Query the execution list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchExecutionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchExecutionsResponse"/></returns>
        public ListAIWorkbenchExecutionsResponse ListAIWorkbenchExecutionsSync(ListAIWorkbenchExecutionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchExecutionsResponse>(req, "ListAIWorkbenchExecutions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the MCP list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMCPsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMCPsResponse"/></returns>
        public Task<ListAIWorkbenchMCPsResponse> ListAIWorkbenchMCPs(ListAIWorkbenchMCPsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMCPsResponse>(req, "ListAIWorkbenchMCPs");
        }

        /// <summary>
        /// Query the MCP list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMCPsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMCPsResponse"/></returns>
        public ListAIWorkbenchMCPsResponse ListAIWorkbenchMCPsSync(ListAIWorkbenchMCPsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMCPsResponse>(req, "ListAIWorkbenchMCPs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query message list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMessagesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMessagesResponse"/></returns>
        public Task<ListAIWorkbenchMessagesResponse> ListAIWorkbenchMessages(ListAIWorkbenchMessagesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMessagesResponse>(req, "ListAIWorkbenchMessages");
        }

        /// <summary>
        /// This API is used to query message list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMessagesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMessagesResponse"/></returns>
        public ListAIWorkbenchMessagesResponse ListAIWorkbenchMessagesSync(ListAIWorkbenchMessagesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMessagesResponse>(req, "ListAIWorkbenchMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List resource instances.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceInstancesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceInstancesResponse"/></returns>
        public Task<ListAIWorkbenchResourceInstancesResponse> ListAIWorkbenchResourceInstances(ListAIWorkbenchResourceInstancesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceInstancesResponse>(req, "ListAIWorkbenchResourceInstances");
        }

        /// <summary>
        /// List resource instances.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceInstancesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceInstancesResponse"/></returns>
        public ListAIWorkbenchResourceInstancesResponse ListAIWorkbenchResourceInstancesSync(ListAIWorkbenchResourceInstancesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceInstancesResponse>(req, "ListAIWorkbenchResourceInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of resource maps
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceMapsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceMapsResponse"/></returns>
        public Task<ListAIWorkbenchResourceMapsResponse> ListAIWorkbenchResourceMaps(ListAIWorkbenchResourceMapsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceMapsResponse>(req, "ListAIWorkbenchResourceMaps");
        }

        /// <summary>
        /// Query the list of resource maps
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceMapsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceMapsResponse"/></returns>
        public ListAIWorkbenchResourceMapsResponse ListAIWorkbenchResourceMapsSync(ListAIWorkbenchResourceMapsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceMapsResponse>(req, "ListAIWorkbenchResourceMaps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query session list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSessionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSessionsResponse"/></returns>
        public Task<ListAIWorkbenchSessionsResponse> ListAIWorkbenchSessions(ListAIWorkbenchSessionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSessionsResponse>(req, "ListAIWorkbenchSessions");
        }

        /// <summary>
        /// Query session list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSessionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSessionsResponse"/></returns>
        public ListAIWorkbenchSessionsResponse ListAIWorkbenchSessionsSync(ListAIWorkbenchSessionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSessionsResponse>(req, "ListAIWorkbenchSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the skill list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSkillsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSkillsResponse"/></returns>
        public Task<ListAIWorkbenchSkillsResponse> ListAIWorkbenchSkills(ListAIWorkbenchSkillsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSkillsResponse>(req, "ListAIWorkbenchSkills");
        }

        /// <summary>
        /// Query the skill list
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSkillsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSkillsResponse"/></returns>
        public ListAIWorkbenchSkillsResponse ListAIWorkbenchSkillsSync(ListAIWorkbenchSkillsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSkillsResponse>(req, "ListAIWorkbenchSkills")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchTasksRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchTasksResponse"/></returns>
        public Task<ListAIWorkbenchTasksResponse> ListAIWorkbenchTasks(ListAIWorkbenchTasksRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchTasksResponse>(req, "ListAIWorkbenchTasks");
        }

        /// <summary>
        /// This API is used to query the task list.
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchTasksRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchTasksResponse"/></returns>
        public ListAIWorkbenchTasksResponse ListAIWorkbenchTasksSync(ListAIWorkbenchTasksRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchTasksResponse>(req, "ListAIWorkbenchTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Manually trigger a task.
        /// </summary>
        /// <param name="req"><see cref="TriggerAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="TriggerAIWorkbenchTaskResponse"/></returns>
        public Task<TriggerAIWorkbenchTaskResponse> TriggerAIWorkbenchTask(TriggerAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<TriggerAIWorkbenchTaskResponse>(req, "TriggerAIWorkbenchTask");
        }

        /// <summary>
        /// Manually trigger a task.
        /// </summary>
        /// <param name="req"><see cref="TriggerAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="TriggerAIWorkbenchTaskResponse"/></returns>
        public TriggerAIWorkbenchTaskResponse TriggerAIWorkbenchTaskSync(TriggerAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<TriggerAIWorkbenchTaskResponse>(req, "TriggerAIWorkbenchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an Agent
        /// </summary>
        /// <param name="req"><see cref="UpdateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="UpdateAIWorkbenchAgentResponse"/></returns>
        public Task<UpdateAIWorkbenchAgentResponse> UpdateAIWorkbenchAgent(UpdateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<UpdateAIWorkbenchAgentResponse>(req, "UpdateAIWorkbenchAgent");
        }

        /// <summary>
        /// Update an Agent
        /// </summary>
        /// <param name="req"><see cref="UpdateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="UpdateAIWorkbenchAgentResponse"/></returns>
        public UpdateAIWorkbenchAgentResponse UpdateAIWorkbenchAgentSync(UpdateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<UpdateAIWorkbenchAgentResponse>(req, "UpdateAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
