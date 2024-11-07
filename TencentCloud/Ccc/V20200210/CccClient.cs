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

namespace TencentCloud.Ccc.V20200210
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ccc.V20200210.Models;

   public class CccClient : AbstractClient{

       private const string endpoint = "ccc.tencentcloudapi.com";
       private const string version = "2020-02-10";
       private const string sdkVersion = "SDK_NET_3.0.1010";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CccClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CccClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// If you want to stop running agent's individual auto task, then call AbortAgentCruiseDialingCampaign to terminate.
        /// </summary>
        /// <param name="req"><see cref="AbortAgentCruiseDialingCampaignRequest"/></param>
        /// <returns><see cref="AbortAgentCruiseDialingCampaignResponse"/></returns>
        public Task<AbortAgentCruiseDialingCampaignResponse> AbortAgentCruiseDialingCampaign(AbortAgentCruiseDialingCampaignRequest req)
        {
            return InternalRequestAsync<AbortAgentCruiseDialingCampaignResponse>(req, "AbortAgentCruiseDialingCampaign");
        }

        /// <summary>
        /// If you want to stop running agent's individual auto task, then call AbortAgentCruiseDialingCampaign to terminate.
        /// </summary>
        /// <param name="req"><see cref="AbortAgentCruiseDialingCampaignRequest"/></param>
        /// <returns><see cref="AbortAgentCruiseDialingCampaignResponse"/></returns>
        public AbortAgentCruiseDialingCampaignResponse AbortAgentCruiseDialingCampaignSync(AbortAgentCruiseDialingCampaignRequest req)
        {
            return InternalRequestAsync<AbortAgentCruiseDialingCampaignResponse>(req, "AbortAgentCruiseDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause predictive dialing campaign
        /// </summary>
        /// <param name="req"><see cref="AbortPredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="AbortPredictiveDialingCampaignResponse"/></returns>
        public Task<AbortPredictiveDialingCampaignResponse> AbortPredictiveDialingCampaign(AbortPredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<AbortPredictiveDialingCampaignResponse>(req, "AbortPredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to pause predictive dialing campaign
        /// </summary>
        /// <param name="req"><see cref="AbortPredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="AbortPredictiveDialingCampaignResponse"/></returns>
        public AbortPredictiveDialingCampaignResponse AbortPredictiveDialingCampaignSync(AbortPredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<AbortPredictiveDialingCampaignResponse>(req, "AbortPredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to assign outbound skill group(s) to your number
        /// </summary>
        /// <param name="req"><see cref="BindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="BindNumberCallOutSkillGroupResponse"/></returns>
        public Task<BindNumberCallOutSkillGroupResponse> BindNumberCallOutSkillGroup(BindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<BindNumberCallOutSkillGroupResponse>(req, "BindNumberCallOutSkillGroup");
        }

        /// <summary>
        /// This API is used to assign outbound skill group(s) to your number
        /// </summary>
        /// <param name="req"><see cref="BindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="BindNumberCallOutSkillGroupResponse"/></returns>
        public BindNumberCallOutSkillGroupResponse BindNumberCallOutSkillGroupSync(BindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<BindNumberCallOutSkillGroupResponse>(req, "BindNumberCallOutSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to assign an agent to skill group
        /// </summary>
        /// <param name="req"><see cref="BindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="BindStaffSkillGroupListResponse"/></returns>
        public Task<BindStaffSkillGroupListResponse> BindStaffSkillGroupList(BindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<BindStaffSkillGroupListResponse>(req, "BindStaffSkillGroupList");
        }

        /// <summary>
        /// This API is used to assign an agent to skill group
        /// </summary>
        /// <param name="req"><see cref="BindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="BindStaffSkillGroupListResponse"/></returns>
        public BindStaffSkillGroupListResponse BindStaffSkillGroupListSync(BindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<BindStaffSkillGroupListResponse>(req, "BindStaffSkillGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a management access link.
        /// </summary>
        /// <param name="req"><see cref="CreateAdminURLRequest"/></param>
        /// <returns><see cref="CreateAdminURLResponse"/></returns>
        public Task<CreateAdminURLResponse> CreateAdminURL(CreateAdminURLRequest req)
        {
            return InternalRequestAsync<CreateAdminURLResponse>(req, "CreateAdminURL");
        }

        /// <summary>
        /// This API is used to create a management access link.
        /// </summary>
        /// <param name="req"><see cref="CreateAdminURLRequest"/></param>
        /// <returns><see cref="CreateAdminURLResponse"/></returns>
        public CreateAdminURLResponse CreateAdminURLSync(CreateAdminURLRequest req)
        {
            return InternalRequestAsync<CreateAdminURLResponse>(req, "CreateAdminURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This document shows how to call API to create an individual auto dialing campaign for agent
        /// </summary>
        /// <param name="req"><see cref="CreateAgentCruiseDialingCampaignRequest"/></param>
        /// <returns><see cref="CreateAgentCruiseDialingCampaignResponse"/></returns>
        public Task<CreateAgentCruiseDialingCampaignResponse> CreateAgentCruiseDialingCampaign(CreateAgentCruiseDialingCampaignRequest req)
        {
            return InternalRequestAsync<CreateAgentCruiseDialingCampaignResponse>(req, "CreateAgentCruiseDialingCampaign");
        }

        /// <summary>
        /// This document shows how to call API to create an individual auto dialing campaign for agent
        /// </summary>
        /// <param name="req"><see cref="CreateAgentCruiseDialingCampaignRequest"/></param>
        /// <returns><see cref="CreateAgentCruiseDialingCampaignResponse"/></returns>
        public CreateAgentCruiseDialingCampaignResponse CreateAgentCruiseDialingCampaignSync(CreateAgentCruiseDialingCampaignRequest req)
        {
            return InternalRequestAsync<CreateAgentCruiseDialingCampaignResponse>(req, "CreateAgentCruiseDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the automatic outbound call task.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="CreateAutoCalloutTaskResponse"/></returns>
        public Task<CreateAutoCalloutTaskResponse> CreateAutoCalloutTask(CreateAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<CreateAutoCalloutTaskResponse>(req, "CreateAutoCalloutTask");
        }

        /// <summary>
        /// This API is used to create the automatic outbound call task.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="CreateAutoCalloutTaskResponse"/></returns>
        public CreateAutoCalloutTaskResponse CreateAutoCalloutTaskSync(CreateAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<CreateAutoCalloutTaskResponse>(req, "CreateAutoCalloutTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a new skill group.
        /// </summary>
        /// <param name="req"><see cref="CreateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="CreateCCCSkillGroupResponse"/></returns>
        public Task<CreateCCCSkillGroupResponse> CreateCCCSkillGroup(CreateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<CreateCCCSkillGroupResponse>(req, "CreateCCCSkillGroup");
        }

        /// <summary>
        /// This API is used to create a new skill group.
        /// </summary>
        /// <param name="req"><see cref="CreateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="CreateCCCSkillGroupResponse"/></returns>
        public CreateCCCSkillGroupResponse CreateCCCSkillGroupSync(CreateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<CreateCCCSkillGroupResponse>(req, "CreateCCCSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create outbound sessions. Currently, only dual call is supported. That is, firstly, please use the platform number to call the agent's cell phone. After the agent answers, then please make outbound calls to the user. Due to ISP frequency restrictions, the agent's phone number must first be added to the allowlist to avoid frequency control which may lead to the failure of the outbound call.
        /// </summary>
        /// <param name="req"><see cref="CreateCallOutSessionRequest"/></param>
        /// <returns><see cref="CreateCallOutSessionResponse"/></returns>
        public Task<CreateCallOutSessionResponse> CreateCallOutSession(CreateCallOutSessionRequest req)
        {
            return InternalRequestAsync<CreateCallOutSessionResponse>(req, "CreateCallOutSession");
        }

        /// <summary>
        /// This API is used to create outbound sessions. Currently, only dual call is supported. That is, firstly, please use the platform number to call the agent's cell phone. After the agent answers, then please make outbound calls to the user. Due to ISP frequency restrictions, the agent's phone number must first be added to the allowlist to avoid frequency control which may lead to the failure of the outbound call.
        /// </summary>
        /// <param name="req"><see cref="CreateCallOutSessionRequest"/></param>
        /// <returns><see cref="CreateCallOutSessionResponse"/></returns>
        public CreateCallOutSessionResponse CreateCallOutSessionSync(CreateCallOutSessionRequest req)
        {
            return InternalRequestAsync<CreateCallOutSessionResponse>(req, "CreateCallOutSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the telephone account.
        /// </summary>
        /// <param name="req"><see cref="CreateExtensionRequest"/></param>
        /// <returns><see cref="CreateExtensionResponse"/></returns>
        public Task<CreateExtensionResponse> CreateExtension(CreateExtensionRequest req)
        {
            return InternalRequestAsync<CreateExtensionResponse>(req, "CreateExtension");
        }

        /// <summary>
        /// This API is used to create the telephone account.
        /// </summary>
        /// <param name="req"><see cref="CreateExtensionRequest"/></param>
        /// <returns><see cref="CreateExtensionResponse"/></returns>
        public CreateExtensionResponse CreateExtensionSync(CreateExtensionRequest req)
        {
            return InternalRequestAsync<CreateExtensionResponse>(req, "CreateExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a session associated with IVR. This feature is supported only in the Advanced Version. Currently, it supports inbound and automatic outbound IVR types. Upon receiving the request, TCCC will first attempt to call the callee, then enter the IVR flow.
        /// </summary>
        /// <param name="req"><see cref="CreateIVRSessionRequest"/></param>
        /// <returns><see cref="CreateIVRSessionResponse"/></returns>
        public Task<CreateIVRSessionResponse> CreateIVRSession(CreateIVRSessionRequest req)
        {
            return InternalRequestAsync<CreateIVRSessionResponse>(req, "CreateIVRSession");
        }

        /// <summary>
        /// Create a session associated with IVR. This feature is supported only in the Advanced Version. Currently, it supports inbound and automatic outbound IVR types. Upon receiving the request, TCCC will first attempt to call the callee, then enter the IVR flow.
        /// </summary>
        /// <param name="req"><see cref="CreateIVRSessionRequest"/></param>
        /// <returns><see cref="CreateIVRSessionResponse"/></returns>
        public CreateIVRSessionResponse CreateIVRSessionSync(CreateIVRSessionRequest req)
        {
            return InternalRequestAsync<CreateIVRSessionResponse>(req, "CreateIVRSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="CreatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="CreatePredictiveDialingCampaignResponse"/></returns>
        public Task<CreatePredictiveDialingCampaignResponse> CreatePredictiveDialingCampaign(CreatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<CreatePredictiveDialingCampaignResponse>(req, "CreatePredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to create the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="CreatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="CreatePredictiveDialingCampaignResponse"/></returns>
        public CreatePredictiveDialingCampaignResponse CreatePredictiveDialingCampaignSync(CreatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<CreatePredictiveDialingCampaignResponse>(req, "CreatePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the SDK log-in token.
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public Task<CreateSDKLoginTokenResponse> CreateSDKLoginToken(CreateSDKLoginTokenRequest req)
        {
            return InternalRequestAsync<CreateSDKLoginTokenResponse>(req, "CreateSDKLoginToken");
        }

        /// <summary>
        /// This API is used to create the SDK log-in token.
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public CreateSDKLoginTokenResponse CreateSDKLoginTokenSync(CreateSDKLoginTokenRequest req)
        {
            return InternalRequestAsync<CreateSDKLoginTokenResponse>(req, "CreateSDKLoginToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the customer service account.
        /// </summary>
        /// <param name="req"><see cref="CreateStaffRequest"/></param>
        /// <returns><see cref="CreateStaffResponse"/></returns>
        public Task<CreateStaffResponse> CreateStaff(CreateStaffRequest req)
        {
            return InternalRequestAsync<CreateStaffResponse>(req, "CreateStaff");
        }

        /// <summary>
        /// This API is used to create the customer service account.
        /// </summary>
        /// <param name="req"><see cref="CreateStaffRequest"/></param>
        /// <returns><see cref="CreateStaffResponse"/></returns>
        public CreateStaffResponse CreateStaffSync(CreateStaffRequest req)
        {
            return InternalRequestAsync<CreateStaffResponse>(req, "CreateStaff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete telephone accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteExtensionRequest"/></param>
        /// <returns><see cref="DeleteExtensionResponse"/></returns>
        public Task<DeleteExtensionResponse> DeleteExtension(DeleteExtensionRequest req)
        {
            return InternalRequestAsync<DeleteExtensionResponse>(req, "DeleteExtension");
        }

        /// <summary>
        /// This API is used to delete telephone accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteExtensionRequest"/></param>
        /// <returns><see cref="DeleteExtensionResponse"/></returns>
        public DeleteExtensionResponse DeleteExtensionSync(DeleteExtensionRequest req)
        {
            return InternalRequestAsync<DeleteExtensionResponse>(req, "DeleteExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="DeletePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DeletePredictiveDialingCampaignResponse"/></returns>
        public Task<DeletePredictiveDialingCampaignResponse> DeletePredictiveDialingCampaign(DeletePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DeletePredictiveDialingCampaignResponse>(req, "DeletePredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to delete the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="DeletePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DeletePredictiveDialingCampaignResponse"/></returns>
        public DeletePredictiveDialingCampaignResponse DeletePredictiveDialingCampaignSync(DeletePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DeletePredictiveDialingCampaignResponse>(req, "DeletePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the agent information.
        /// </summary>
        /// <param name="req"><see cref="DeleteStaffRequest"/></param>
        /// <returns><see cref="DeleteStaffResponse"/></returns>
        public Task<DeleteStaffResponse> DeleteStaff(DeleteStaffRequest req)
        {
            return InternalRequestAsync<DeleteStaffResponse>(req, "DeleteStaff");
        }

        /// <summary>
        /// This API is used to delete the agent information.
        /// </summary>
        /// <param name="req"><see cref="DeleteStaffRequest"/></param>
        /// <returns><see cref="DeleteStaffResponse"/></returns>
        public DeleteStaffResponse DeleteStaffSync(DeleteStaffRequest req)
        {
            return InternalRequestAsync<DeleteStaffResponse>(req, "DeleteStaff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Agent Cruise-style Outbound Call Task
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCruiseDialingCampaignRequest"/></param>
        /// <returns><see cref="DescribeAgentCruiseDialingCampaignResponse"/></returns>
        public Task<DescribeAgentCruiseDialingCampaignResponse> DescribeAgentCruiseDialingCampaign(DescribeAgentCruiseDialingCampaignRequest req)
        {
            return InternalRequestAsync<DescribeAgentCruiseDialingCampaignResponse>(req, "DescribeAgentCruiseDialingCampaign");
        }

        /// <summary>
        /// Query Agent Cruise-style Outbound Call Task
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCruiseDialingCampaignRequest"/></param>
        /// <returns><see cref="DescribeAgentCruiseDialingCampaignResponse"/></returns>
        public DescribeAgentCruiseDialingCampaignResponse DescribeAgentCruiseDialingCampaignSync(DescribeAgentCruiseDialingCampaignRequest req)
        {
            return InternalRequestAsync<DescribeAgentCruiseDialingCampaignResponse>(req, "DescribeAgentCruiseDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query automatic outbound call task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTaskResponse"/></returns>
        public Task<DescribeAutoCalloutTaskResponse> DescribeAutoCalloutTask(DescribeAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTaskResponse>(req, "DescribeAutoCalloutTask");
        }

        /// <summary>
        /// This API is used to query automatic outbound call task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTaskResponse"/></returns>
        public DescribeAutoCalloutTaskResponse DescribeAutoCalloutTaskSync(DescribeAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTaskResponse>(req, "DescribeAutoCalloutTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Query Automatic Outbound Call Tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTasksRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTasksResponse"/></returns>
        public Task<DescribeAutoCalloutTasksResponse> DescribeAutoCalloutTasks(DescribeAutoCalloutTasksRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTasksResponse>(req, "DescribeAutoCalloutTasks");
        }

        /// <summary>
        /// Batch Query Automatic Outbound Call Tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTasksRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTasksResponse"/></returns>
        public DescribeAutoCalloutTasksResponse DescribeAutoCalloutTasksSync(DescribeAutoCalloutTasksRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTasksResponse>(req, "DescribeAutoCalloutTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the user purchasing information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCCBuyInfoListRequest"/></param>
        /// <returns><see cref="DescribeCCCBuyInfoListResponse"/></returns>
        public Task<DescribeCCCBuyInfoListResponse> DescribeCCCBuyInfoList(DescribeCCCBuyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeCCCBuyInfoListResponse>(req, "DescribeCCCBuyInfoList");
        }

        /// <summary>
        /// This API is used to access the user purchasing information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCCBuyInfoListRequest"/></param>
        /// <returns><see cref="DescribeCCCBuyInfoListResponse"/></returns>
        public DescribeCCCBuyInfoListResponse DescribeCCCBuyInfoListSync(DescribeCCCBuyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeCCCBuyInfoListResponse>(req, "DescribeCCCBuyInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the inbound real-time data statistical metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallInMetricsRequest"/></param>
        /// <returns><see cref="DescribeCallInMetricsResponse"/></returns>
        public Task<DescribeCallInMetricsResponse> DescribeCallInMetrics(DescribeCallInMetricsRequest req)
        {
            return InternalRequestAsync<DescribeCallInMetricsResponse>(req, "DescribeCallInMetrics");
        }

        /// <summary>
        /// This API is used to access the inbound real-time data statistical metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallInMetricsRequest"/></param>
        /// <returns><see cref="DescribeCallInMetricsResponse"/></returns>
        public DescribeCallInMetricsResponse DescribeCallInMetricsSync(DescribeCallInMetricsRequest req)
        {
            return InternalRequestAsync<DescribeCallInMetricsResponse>(req, "DescribeCallInMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the telephone information.
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionRequest"/></param>
        /// <returns><see cref="DescribeExtensionResponse"/></returns>
        public Task<DescribeExtensionResponse> DescribeExtension(DescribeExtensionRequest req)
        {
            return InternalRequestAsync<DescribeExtensionResponse>(req, "DescribeExtension");
        }

        /// <summary>
        /// This API is used to access the telephone information.
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionRequest"/></param>
        /// <returns><see cref="DescribeExtensionResponse"/></returns>
        public DescribeExtensionResponse DescribeExtensionSync(DescribeExtensionRequest req)
        {
            return InternalRequestAsync<DescribeExtensionResponse>(req, "DescribeExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the telephone list information.
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionsRequest"/></param>
        /// <returns><see cref="DescribeExtensionsResponse"/></returns>
        public Task<DescribeExtensionsResponse> DescribeExtensions(DescribeExtensionsRequest req)
        {
            return InternalRequestAsync<DescribeExtensionsResponse>(req, "DescribeExtensions");
        }

        /// <summary>
        /// This API is used to query the telephone list information.
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionsRequest"/></param>
        /// <returns><see cref="DescribeExtensionsResponse"/></returns>
        public DescribeExtensionsResponse DescribeExtensionsSync(DescribeExtensionsRequest req)
        {
            return InternalRequestAsync<DescribeExtensionsResponse>(req, "DescribeExtensions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query IVR Audio File List Information
        /// </summary>
        /// <param name="req"><see cref="DescribeIvrAudioListRequest"/></param>
        /// <returns><see cref="DescribeIvrAudioListResponse"/></returns>
        public Task<DescribeIvrAudioListResponse> DescribeIvrAudioList(DescribeIvrAudioListRequest req)
        {
            return InternalRequestAsync<DescribeIvrAudioListResponse>(req, "DescribeIvrAudioList");
        }

        /// <summary>
        /// Query IVR Audio File List Information
        /// </summary>
        /// <param name="req"><see cref="DescribeIvrAudioListRequest"/></param>
        /// <returns><see cref="DescribeIvrAudioListResponse"/></returns>
        public DescribeIvrAudioListResponse DescribeIvrAudioListSync(DescribeIvrAudioListRequest req)
        {
            return InternalRequestAsync<DescribeIvrAudioListResponse>(req, "DescribeIvrAudioList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNumbersRequest"/></param>
        /// <returns><see cref="DescribeNumbersResponse"/></returns>
        public Task<DescribeNumbersResponse> DescribeNumbers(DescribeNumbersRequest req)
        {
            return InternalRequestAsync<DescribeNumbersResponse>(req, "DescribeNumbers");
        }

        /// <summary>
        /// This API is used to query the number list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNumbersRequest"/></param>
        /// <returns><see cref="DescribeNumbersResponse"/></returns>
        public DescribeNumbersResponse DescribeNumbersSync(DescribeNumbersRequest req)
        {
            return InternalRequestAsync<DescribeNumbersResponse>(req, "DescribeNumbers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the current calling session list.
        /// </summary>
        /// <param name="req"><see cref="DescribePSTNActiveSessionListRequest"/></param>
        /// <returns><see cref="DescribePSTNActiveSessionListResponse"/></returns>
        public Task<DescribePSTNActiveSessionListResponse> DescribePSTNActiveSessionList(DescribePSTNActiveSessionListRequest req)
        {
            return InternalRequestAsync<DescribePSTNActiveSessionListResponse>(req, "DescribePSTNActiveSessionList");
        }

        /// <summary>
        /// This API is used to access the current calling session list.
        /// </summary>
        /// <param name="req"><see cref="DescribePSTNActiveSessionListRequest"/></param>
        /// <returns><see cref="DescribePSTNActiveSessionListResponse"/></returns>
        public DescribePSTNActiveSessionListResponse DescribePSTNActiveSessionListSync(DescribePSTNActiveSessionListRequest req)
        {
            return InternalRequestAsync<DescribePSTNActiveSessionListResponse>(req, "DescribePSTNActiveSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignResponse"/></returns>
        public Task<DescribePredictiveDialingCampaignResponse> DescribePredictiveDialingCampaign(DescribePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignResponse>(req, "DescribePredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to query the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignResponse"/></returns>
        public DescribePredictiveDialingCampaignResponse DescribePredictiveDialingCampaignSync(DescribePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignResponse>(req, "DescribePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the predictive outbound call task list.
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignsResponse"/></returns>
        public Task<DescribePredictiveDialingCampaignsResponse> DescribePredictiveDialingCampaigns(DescribePredictiveDialingCampaignsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignsResponse>(req, "DescribePredictiveDialingCampaigns");
        }

        /// <summary>
        /// This API is used to query the predictive outbound call task list.
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignsResponse"/></returns>
        public DescribePredictiveDialingCampaignsResponse DescribePredictiveDialingCampaignsSync(DescribePredictiveDialingCampaignsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignsResponse>(req, "DescribePredictiveDialingCampaigns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the predictive outbound call list.
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingSessionsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingSessionsResponse"/></returns>
        public Task<DescribePredictiveDialingSessionsResponse> DescribePredictiveDialingSessions(DescribePredictiveDialingSessionsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingSessionsResponse>(req, "DescribePredictiveDialingSessions");
        }

        /// <summary>
        /// This API is used to query the predictive outbound call list.
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingSessionsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingSessionsResponse"/></returns>
        public DescribePredictiveDialingSessionsResponse DescribePredictiveDialingSessionsSync(DescribePredictiveDialingSessionsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingSessionsResponse>(req, "DescribePredictiveDialingSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access protected phone service records and recordings for both inbound and outbound calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedTelCdrRequest"/></param>
        /// <returns><see cref="DescribeProtectedTelCdrResponse"/></returns>
        public Task<DescribeProtectedTelCdrResponse> DescribeProtectedTelCdr(DescribeProtectedTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeProtectedTelCdrResponse>(req, "DescribeProtectedTelCdr");
        }

        /// <summary>
        /// This API is used to access protected phone service records and recordings for both inbound and outbound calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedTelCdrRequest"/></param>
        /// <returns><see cref="DescribeProtectedTelCdrResponse"/></returns>
        public DescribeProtectedTelCdrResponse DescribeProtectedTelCdrSync(DescribeProtectedTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeProtectedTelCdrResponse>(req, "DescribeProtectedTelCdr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the skill group information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillGroupInfoListRequest"/></param>
        /// <returns><see cref="DescribeSkillGroupInfoListResponse"/></returns>
        public Task<DescribeSkillGroupInfoListResponse> DescribeSkillGroupInfoList(DescribeSkillGroupInfoListRequest req)
        {
            return InternalRequestAsync<DescribeSkillGroupInfoListResponse>(req, "DescribeSkillGroupInfoList");
        }

        /// <summary>
        /// This API is used to access the skill group information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillGroupInfoListRequest"/></param>
        /// <returns><see cref="DescribeSkillGroupInfoListResponse"/></returns>
        public DescribeSkillGroupInfoListResponse DescribeSkillGroupInfoListSync(DescribeSkillGroupInfoListRequest req)
        {
            return InternalRequestAsync<DescribeSkillGroupInfoListResponse>(req, "DescribeSkillGroupInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the agent information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffInfoListRequest"/></param>
        /// <returns><see cref="DescribeStaffInfoListResponse"/></returns>
        public Task<DescribeStaffInfoListResponse> DescribeStaffInfoList(DescribeStaffInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStaffInfoListResponse>(req, "DescribeStaffInfoList");
        }

        /// <summary>
        /// This API is used to access the agent information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffInfoListRequest"/></param>
        /// <returns><see cref="DescribeStaffInfoListResponse"/></returns>
        public DescribeStaffInfoListResponse DescribeStaffInfoListSync(DescribeStaffInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStaffInfoListResponse>(req, "DescribeStaffInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the real-time status statistics metrics of the agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffStatusMetricsRequest"/></param>
        /// <returns><see cref="DescribeStaffStatusMetricsResponse"/></returns>
        public Task<DescribeStaffStatusMetricsResponse> DescribeStaffStatusMetrics(DescribeStaffStatusMetricsRequest req)
        {
            return InternalRequestAsync<DescribeStaffStatusMetricsResponse>(req, "DescribeStaffStatusMetrics");
        }

        /// <summary>
        /// This API is used to access the real-time status statistics metrics of the agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffStatusMetricsRequest"/></param>
        /// <returns><see cref="DescribeStaffStatusMetricsResponse"/></returns>
        public DescribeStaffStatusMetricsResponse DescribeStaffStatusMetricsSync(DescribeStaffStatusMetricsRequest req)
        {
            return InternalRequestAsync<DescribeStaffStatusMetricsResponse>(req, "DescribeStaffStatusMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access call detail records by application
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCallInfoRequest"/></param>
        /// <returns><see cref="DescribeTelCallInfoResponse"/></returns>
        public Task<DescribeTelCallInfoResponse> DescribeTelCallInfo(DescribeTelCallInfoRequest req)
        {
            return InternalRequestAsync<DescribeTelCallInfoResponse>(req, "DescribeTelCallInfo");
        }

        /// <summary>
        /// This API is used to access call detail records by application
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCallInfoRequest"/></param>
        /// <returns><see cref="DescribeTelCallInfoResponse"/></returns>
        public DescribeTelCallInfoResponse DescribeTelCallInfoSync(DescribeTelCallInfoRequest req)
        {
            return InternalRequestAsync<DescribeTelCallInfoResponse>(req, "DescribeTelCallInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access phone service records and recordings.
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public Task<DescribeTelCdrResponse> DescribeTelCdr(DescribeTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeTelCdrResponse>(req, "DescribeTelCdr");
        }

        /// <summary>
        /// This API is used to access phone service records and recordings.
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public DescribeTelCdrResponse DescribeTelCdrSync(DescribeTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeTelCdrResponse>(req, "DescribeTelCdr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the PSTN session information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTelSessionRequest"/></param>
        /// <returns><see cref="DescribeTelSessionResponse"/></returns>
        public Task<DescribeTelSessionResponse> DescribeTelSession(DescribeTelSessionRequest req)
        {
            return InternalRequestAsync<DescribeTelSessionResponse>(req, "DescribeTelSession");
        }

        /// <summary>
        /// This API is used to access the PSTN session information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTelSessionRequest"/></param>
        /// <returns><see cref="DescribeTelSessionResponse"/></returns>
        public DescribeTelSessionResponse DescribeTelSessionSync(DescribeTelSessionRequest req)
        {
            return InternalRequestAsync<DescribeTelSessionResponse>(req, "DescribeTelSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable numbers.
        /// </summary>
        /// <param name="req"><see cref="DisableCCCPhoneNumberRequest"/></param>
        /// <returns><see cref="DisableCCCPhoneNumberResponse"/></returns>
        public Task<DisableCCCPhoneNumberResponse> DisableCCCPhoneNumber(DisableCCCPhoneNumberRequest req)
        {
            return InternalRequestAsync<DisableCCCPhoneNumberResponse>(req, "DisableCCCPhoneNumber");
        }

        /// <summary>
        /// This API is used to disable numbers.
        /// </summary>
        /// <param name="req"><see cref="DisableCCCPhoneNumberRequest"/></param>
        /// <returns><see cref="DisableCCCPhoneNumberResponse"/></returns>
        public DisableCCCPhoneNumberResponse DisableCCCPhoneNumberSync(DisableCCCPhoneNumberRequest req)
        {
            return InternalRequestAsync<DisableCCCPhoneNumberResponse>(req, "DisableCCCPhoneNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to hang up the phone.
        /// </summary>
        /// <param name="req"><see cref="HangUpCallRequest"/></param>
        /// <returns><see cref="HangUpCallResponse"/></returns>
        public Task<HangUpCallResponse> HangUpCall(HangUpCallRequest req)
        {
            return InternalRequestAsync<HangUpCallResponse>(req, "HangUpCall");
        }

        /// <summary>
        /// This API is used to hang up the phone.
        /// </summary>
        /// <param name="req"><see cref="HangUpCallRequest"/></param>
        /// <returns><see cref="HangUpCallResponse"/></returns>
        public HangUpCallResponse HangUpCallSync(HangUpCallRequest req)
        {
            return InternalRequestAsync<HangUpCallResponse>(req, "HangUpCall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify telephone accounts (binding skill group, binding agent account).
        /// </summary>
        /// <param name="req"><see cref="ModifyExtensionRequest"/></param>
        /// <returns><see cref="ModifyExtensionResponse"/></returns>
        public Task<ModifyExtensionResponse> ModifyExtension(ModifyExtensionRequest req)
        {
            return InternalRequestAsync<ModifyExtensionResponse>(req, "ModifyExtension");
        }

        /// <summary>
        /// This API is used to modify telephone accounts (binding skill group, binding agent account).
        /// </summary>
        /// <param name="req"><see cref="ModifyExtensionRequest"/></param>
        /// <returns><see cref="ModifyExtensionResponse"/></returns>
        public ModifyExtensionResponse ModifyExtensionSync(ModifyExtensionRequest req)
        {
            return InternalRequestAsync<ModifyExtensionResponse>(req, "ModifyExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify  customer service / agent account.
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffRequest"/></param>
        /// <returns><see cref="ModifyStaffResponse"/></returns>
        public Task<ModifyStaffResponse> ModifyStaff(ModifyStaffRequest req)
        {
            return InternalRequestAsync<ModifyStaffResponse>(req, "ModifyStaff");
        }

        /// <summary>
        /// This API is used to modify  customer service / agent account.
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffRequest"/></param>
        /// <returns><see cref="ModifyStaffResponse"/></returns>
        public ModifyStaffResponse ModifyStaffSync(ModifyStaffRequest req)
        {
            return InternalRequestAsync<ModifyStaffResponse>(req, "ModifyStaff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Agent's Password
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffPasswordRequest"/></param>
        /// <returns><see cref="ModifyStaffPasswordResponse"/></returns>
        public Task<ModifyStaffPasswordResponse> ModifyStaffPassword(ModifyStaffPasswordRequest req)
        {
            return InternalRequestAsync<ModifyStaffPasswordResponse>(req, "ModifyStaffPassword");
        }

        /// <summary>
        /// Modify Agent's Password
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffPasswordRequest"/></param>
        /// <returns><see cref="ModifyStaffPasswordResponse"/></returns>
        public ModifyStaffPasswordResponse ModifyStaffPasswordSync(ModifyStaffPasswordRequest req)
        {
            return InternalRequestAsync<ModifyStaffPasswordResponse>(req, "ModifyStaffPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="PausePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="PausePredictiveDialingCampaignResponse"/></returns>
        public Task<PausePredictiveDialingCampaignResponse> PausePredictiveDialingCampaign(PausePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<PausePredictiveDialingCampaignResponse>(req, "PausePredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to pause the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="PausePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="PausePredictiveDialingCampaignResponse"/></returns>
        public PausePredictiveDialingCampaignResponse PausePredictiveDialingCampaignSync(PausePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<PausePredictiveDialingCampaignResponse>(req, "PausePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the telephone register password.
        /// </summary>
        /// <param name="req"><see cref="ResetExtensionPasswordRequest"/></param>
        /// <returns><see cref="ResetExtensionPasswordResponse"/></returns>
        public Task<ResetExtensionPasswordResponse> ResetExtensionPassword(ResetExtensionPasswordRequest req)
        {
            return InternalRequestAsync<ResetExtensionPasswordResponse>(req, "ResetExtensionPassword");
        }

        /// <summary>
        /// This API is used to reset the telephone register password.
        /// </summary>
        /// <param name="req"><see cref="ResetExtensionPasswordRequest"/></param>
        /// <returns><see cref="ResetExtensionPasswordResponse"/></returns>
        public ResetExtensionPasswordResponse ResetExtensionPasswordSync(ResetExtensionPasswordRequest req)
        {
            return InternalRequestAsync<ResetExtensionPasswordResponse>(req, "ResetExtensionPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="ResumePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="ResumePredictiveDialingCampaignResponse"/></returns>
        public Task<ResumePredictiveDialingCampaignResponse> ResumePredictiveDialingCampaign(ResumePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<ResumePredictiveDialingCampaignResponse>(req, "ResumePredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to resume the predictive outbound call task.
        /// </summary>
        /// <param name="req"><see cref="ResumePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="ResumePredictiveDialingCampaignResponse"/></returns>
        public ResumePredictiveDialingCampaignResponse ResumePredictiveDialingCampaignSync(ResumePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<ResumePredictiveDialingCampaignResponse>(req, "ResumePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop the automatic outbound call task.
        /// </summary>
        /// <param name="req"><see cref="StopAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="StopAutoCalloutTaskResponse"/></returns>
        public Task<StopAutoCalloutTaskResponse> StopAutoCalloutTask(StopAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<StopAutoCalloutTaskResponse>(req, "StopAutoCalloutTask");
        }

        /// <summary>
        /// This API is used to stop the automatic outbound call task.
        /// </summary>
        /// <param name="req"><see cref="StopAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="StopAutoCalloutTaskResponse"/></returns>
        public StopAutoCalloutTaskResponse StopAutoCalloutTaskSync(StopAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<StopAutoCalloutTaskResponse>(req, "StopAutoCalloutTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind the number from the outbound call skill group.
        /// </summary>
        /// <param name="req"><see cref="UnbindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="UnbindNumberCallOutSkillGroupResponse"/></returns>
        public Task<UnbindNumberCallOutSkillGroupResponse> UnbindNumberCallOutSkillGroup(UnbindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<UnbindNumberCallOutSkillGroupResponse>(req, "UnbindNumberCallOutSkillGroup");
        }

        /// <summary>
        /// This API is used to unbind the number from the outbound call skill group.
        /// </summary>
        /// <param name="req"><see cref="UnbindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="UnbindNumberCallOutSkillGroupResponse"/></returns>
        public UnbindNumberCallOutSkillGroupResponse UnbindNumberCallOutSkillGroupSync(UnbindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<UnbindNumberCallOutSkillGroupResponse>(req, "UnbindNumberCallOutSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind the agent's skill group.
        /// </summary>
        /// <param name="req"><see cref="UnbindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="UnbindStaffSkillGroupListResponse"/></returns>
        public Task<UnbindStaffSkillGroupListResponse> UnbindStaffSkillGroupList(UnbindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<UnbindStaffSkillGroupListResponse>(req, "UnbindStaffSkillGroupList");
        }

        /// <summary>
        /// This API is used to unbind the agent's skill group.
        /// </summary>
        /// <param name="req"><see cref="UnbindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="UnbindStaffSkillGroupListResponse"/></returns>
        public UnbindStaffSkillGroupListResponse UnbindStaffSkillGroupListSync(UnbindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<UnbindStaffSkillGroupListResponse>(req, "UnbindStaffSkillGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the skill group.
        /// </summary>
        /// <param name="req"><see cref="UpdateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="UpdateCCCSkillGroupResponse"/></returns>
        public Task<UpdateCCCSkillGroupResponse> UpdateCCCSkillGroup(UpdateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<UpdateCCCSkillGroupResponse>(req, "UpdateCCCSkillGroup");
        }

        /// <summary>
        /// This API is used to update the skill group.
        /// </summary>
        /// <param name="req"><see cref="UpdateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="UpdateCCCSkillGroupResponse"/></returns>
        public UpdateCCCSkillGroupResponse UpdateCCCSkillGroupSync(UpdateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<UpdateCCCSkillGroupResponse>(req, "UpdateCCCSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the predictive outbound call task before it starts.
        /// </summary>
        /// <param name="req"><see cref="UpdatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="UpdatePredictiveDialingCampaignResponse"/></returns>
        public Task<UpdatePredictiveDialingCampaignResponse> UpdatePredictiveDialingCampaign(UpdatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<UpdatePredictiveDialingCampaignResponse>(req, "UpdatePredictiveDialingCampaign");
        }

        /// <summary>
        /// This API is used to update the predictive outbound call task before it starts.
        /// </summary>
        /// <param name="req"><see cref="UpdatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="UpdatePredictiveDialingCampaignResponse"/></returns>
        public UpdatePredictiveDialingCampaignResponse UpdatePredictiveDialingCampaignSync(UpdatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<UpdatePredictiveDialingCampaignResponse>(req, "UpdatePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Upload audio files used in IVR, with a daily upload limit of 50 files. (It is recommended to use temporary links stored in Tencent Cloud Cos for the audio file URL in the parameters)
        /// </summary>
        /// <param name="req"><see cref="UploadIvrAudioRequest"/></param>
        /// <returns><see cref="UploadIvrAudioResponse"/></returns>
        public Task<UploadIvrAudioResponse> UploadIvrAudio(UploadIvrAudioRequest req)
        {
            return InternalRequestAsync<UploadIvrAudioResponse>(req, "UploadIvrAudio");
        }

        /// <summary>
        /// Upload audio files used in IVR, with a daily upload limit of 50 files. (It is recommended to use temporary links stored in Tencent Cloud Cos for the audio file URL in the parameters)
        /// </summary>
        /// <param name="req"><see cref="UploadIvrAudioRequest"/></param>
        /// <returns><see cref="UploadIvrAudioResponse"/></returns>
        public UploadIvrAudioResponse UploadIvrAudioSync(UploadIvrAudioRequest req)
        {
            return InternalRequestAsync<UploadIvrAudioResponse>(req, "UploadIvrAudio")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
