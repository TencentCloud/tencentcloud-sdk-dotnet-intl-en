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

namespace TencentCloud.Mdl.V20200326
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mdl.V20200326.Models;

   public class MdlClient : AbstractClient{

       private const string endpoint = "mdl.tencentcloudapi.com";
       private const string version = "2020-03-26";
       private const string sdkVersion = "SDK_NET_3.0.933";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdlClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MdlClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveChannelRequest"/></param>
        /// <returns><see cref="CreateStreamLiveChannelResponse"/></returns>
        public Task<CreateStreamLiveChannelResponse> CreateStreamLiveChannel(CreateStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveChannelResponse>(req, "CreateStreamLiveChannel");
        }

        /// <summary>
        /// This API is used to create a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveChannelRequest"/></param>
        /// <returns><see cref="CreateStreamLiveChannelResponse"/></returns>
        public CreateStreamLiveChannelResponse CreateStreamLiveChannelSync(CreateStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveChannelResponse>(req, "CreateStreamLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputResponse"/></returns>
        public Task<CreateStreamLiveInputResponse> CreateStreamLiveInput(CreateStreamLiveInputRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveInputResponse>(req, "CreateStreamLiveInput");
        }

        /// <summary>
        /// This API is used to create a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputResponse"/></returns>
        public CreateStreamLiveInputResponse CreateStreamLiveInputSync(CreateStreamLiveInputRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveInputResponse>(req, "CreateStreamLiveInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an input security group. Up to 5 security groups are allowed.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputSecurityGroupResponse"/></returns>
        public Task<CreateStreamLiveInputSecurityGroupResponse> CreateStreamLiveInputSecurityGroup(CreateStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveInputSecurityGroupResponse>(req, "CreateStreamLiveInputSecurityGroup");
        }

        /// <summary>
        /// This API is used to create an input security group. Up to 5 security groups are allowed.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputSecurityGroupResponse"/></returns>
        public CreateStreamLiveInputSecurityGroupResponse CreateStreamLiveInputSecurityGroupSync(CreateStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveInputSecurityGroupResponse>(req, "CreateStreamLiveInputSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an event in the plan.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLivePlanRequest"/></param>
        /// <returns><see cref="CreateStreamLivePlanResponse"/></returns>
        public Task<CreateStreamLivePlanResponse> CreateStreamLivePlan(CreateStreamLivePlanRequest req)
        {
            return InternalRequestAsync<CreateStreamLivePlanResponse>(req, "CreateStreamLivePlan");
        }

        /// <summary>
        /// This API is used to create an event in the plan.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLivePlanRequest"/></param>
        /// <returns><see cref="CreateStreamLivePlanResponse"/></returns>
        public CreateStreamLivePlanResponse CreateStreamLivePlanSync(CreateStreamLivePlanRequest req)
        {
            return InternalRequestAsync<CreateStreamLivePlanResponse>(req, "CreateStreamLivePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a watermark.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="CreateStreamLiveWatermarkResponse"/></returns>
        public Task<CreateStreamLiveWatermarkResponse> CreateStreamLiveWatermark(CreateStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveWatermarkResponse>(req, "CreateStreamLiveWatermark");
        }

        /// <summary>
        /// This API is used to add a watermark.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="CreateStreamLiveWatermarkResponse"/></returns>
        public CreateStreamLiveWatermarkResponse CreateStreamLiveWatermarkSync(CreateStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<CreateStreamLiveWatermarkResponse>(req, "CreateStreamLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveChannelResponse"/></returns>
        public Task<DeleteStreamLiveChannelResponse> DeleteStreamLiveChannel(DeleteStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveChannelResponse>(req, "DeleteStreamLiveChannel");
        }

        /// <summary>
        /// This API is used to delete a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveChannelResponse"/></returns>
        public DeleteStreamLiveChannelResponse DeleteStreamLiveChannelSync(DeleteStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveChannelResponse>(req, "DeleteStreamLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputResponse"/></returns>
        public Task<DeleteStreamLiveInputResponse> DeleteStreamLiveInput(DeleteStreamLiveInputRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveInputResponse>(req, "DeleteStreamLiveInput");
        }

        /// <summary>
        /// This API is used to delete a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputResponse"/></returns>
        public DeleteStreamLiveInputResponse DeleteStreamLiveInputSync(DeleteStreamLiveInputRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveInputResponse>(req, "DeleteStreamLiveInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an input security group.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputSecurityGroupResponse"/></returns>
        public Task<DeleteStreamLiveInputSecurityGroupResponse> DeleteStreamLiveInputSecurityGroup(DeleteStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveInputSecurityGroupResponse>(req, "DeleteStreamLiveInputSecurityGroup");
        }

        /// <summary>
        /// This API is used to delete an input security group.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputSecurityGroupResponse"/></returns>
        public DeleteStreamLiveInputSecurityGroupResponse DeleteStreamLiveInputSecurityGroupSync(DeleteStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveInputSecurityGroupResponse>(req, "DeleteStreamLiveInputSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a StreamLive event.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLivePlanRequest"/></param>
        /// <returns><see cref="DeleteStreamLivePlanResponse"/></returns>
        public Task<DeleteStreamLivePlanResponse> DeleteStreamLivePlan(DeleteStreamLivePlanRequest req)
        {
            return InternalRequestAsync<DeleteStreamLivePlanResponse>(req, "DeleteStreamLivePlan");
        }

        /// <summary>
        /// This API is used to delete a StreamLive event.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLivePlanRequest"/></param>
        /// <returns><see cref="DeleteStreamLivePlanResponse"/></returns>
        public DeleteStreamLivePlanResponse DeleteStreamLivePlanSync(DeleteStreamLivePlanRequest req)
        {
            return InternalRequestAsync<DeleteStreamLivePlanResponse>(req, "DeleteStreamLivePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveWatermarkResponse"/></returns>
        public Task<DeleteStreamLiveWatermarkResponse> DeleteStreamLiveWatermark(DeleteStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveWatermarkResponse>(req, "DeleteStreamLiveWatermark");
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveWatermarkResponse"/></returns>
        public DeleteStreamLiveWatermarkResponse DeleteStreamLiveWatermarkSync(DeleteStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DeleteStreamLiveWatermarkResponse>(req, "DeleteStreamLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelResponse"/></returns>
        public Task<DescribeStreamLiveChannelResponse> DescribeStreamLiveChannel(DescribeStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelResponse>(req, "DescribeStreamLiveChannel");
        }

        /// <summary>
        /// This API is used to query a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelResponse"/></returns>
        public DescribeStreamLiveChannelResponse DescribeStreamLiveChannelSync(DescribeStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelResponse>(req, "DescribeStreamLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the alarm information of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelAlertsResponse"/></returns>
        public Task<DescribeStreamLiveChannelAlertsResponse> DescribeStreamLiveChannelAlerts(DescribeStreamLiveChannelAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelAlertsResponse>(req, "DescribeStreamLiveChannelAlerts");
        }

        /// <summary>
        /// This API is used to query the alarm information of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelAlertsResponse"/></returns>
        public DescribeStreamLiveChannelAlertsResponse DescribeStreamLiveChannelAlertsSync(DescribeStreamLiveChannelAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelAlertsResponse>(req, "DescribeStreamLiveChannelAlerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query input statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelInputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelInputStatisticsResponse"/></returns>
        public Task<DescribeStreamLiveChannelInputStatisticsResponse> DescribeStreamLiveChannelInputStatistics(DescribeStreamLiveChannelInputStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelInputStatisticsResponse>(req, "DescribeStreamLiveChannelInputStatistics");
        }

        /// <summary>
        /// This API is used to query input statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelInputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelInputStatisticsResponse"/></returns>
        public DescribeStreamLiveChannelInputStatisticsResponse DescribeStreamLiveChannelInputStatisticsSync(DescribeStreamLiveChannelInputStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelInputStatisticsResponse>(req, "DescribeStreamLiveChannelInputStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query StreamLive channel logs, such as push event logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelLogsResponse"/></returns>
        public Task<DescribeStreamLiveChannelLogsResponse> DescribeStreamLiveChannelLogs(DescribeStreamLiveChannelLogsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelLogsResponse>(req, "DescribeStreamLiveChannelLogs");
        }

        /// <summary>
        /// This API is used to query StreamLive channel logs, such as push event logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelLogsResponse"/></returns>
        public DescribeStreamLiveChannelLogsResponse DescribeStreamLiveChannelLogsSync(DescribeStreamLiveChannelLogsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelLogsResponse>(req, "DescribeStreamLiveChannelLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the output statistics of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelOutputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelOutputStatisticsResponse"/></returns>
        public Task<DescribeStreamLiveChannelOutputStatisticsResponse> DescribeStreamLiveChannelOutputStatistics(DescribeStreamLiveChannelOutputStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelOutputStatisticsResponse>(req, "DescribeStreamLiveChannelOutputStatistics");
        }

        /// <summary>
        /// This API is used to query the output statistics of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelOutputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelOutputStatisticsResponse"/></returns>
        public DescribeStreamLiveChannelOutputStatisticsResponse DescribeStreamLiveChannelOutputStatisticsSync(DescribeStreamLiveChannelOutputStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelOutputStatisticsResponse>(req, "DescribeStreamLiveChannelOutputStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query StreamLive channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelsResponse"/></returns>
        public Task<DescribeStreamLiveChannelsResponse> DescribeStreamLiveChannels(DescribeStreamLiveChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelsResponse>(req, "DescribeStreamLiveChannels");
        }

        /// <summary>
        /// This API is used to query StreamLive channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelsResponse"/></returns>
        public DescribeStreamLiveChannelsResponse DescribeStreamLiveChannelsSync(DescribeStreamLiveChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveChannelsResponse>(req, "DescribeStreamLiveChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputResponse"/></returns>
        public Task<DescribeStreamLiveInputResponse> DescribeStreamLiveInput(DescribeStreamLiveInputRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputResponse>(req, "DescribeStreamLiveInput");
        }

        /// <summary>
        /// This API is used to query a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputResponse"/></returns>
        public DescribeStreamLiveInputResponse DescribeStreamLiveInputSync(DescribeStreamLiveInputRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputResponse>(req, "DescribeStreamLiveInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an input security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupResponse"/></returns>
        public Task<DescribeStreamLiveInputSecurityGroupResponse> DescribeStreamLiveInputSecurityGroup(DescribeStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputSecurityGroupResponse>(req, "DescribeStreamLiveInputSecurityGroup");
        }

        /// <summary>
        /// This API is used to query an input security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupResponse"/></returns>
        public DescribeStreamLiveInputSecurityGroupResponse DescribeStreamLiveInputSecurityGroupSync(DescribeStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputSecurityGroupResponse>(req, "DescribeStreamLiveInputSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query input security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupsResponse"/></returns>
        public Task<DescribeStreamLiveInputSecurityGroupsResponse> DescribeStreamLiveInputSecurityGroups(DescribeStreamLiveInputSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputSecurityGroupsResponse>(req, "DescribeStreamLiveInputSecurityGroups");
        }

        /// <summary>
        /// This API is used to query input security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupsResponse"/></returns>
        public DescribeStreamLiveInputSecurityGroupsResponse DescribeStreamLiveInputSecurityGroupsSync(DescribeStreamLiveInputSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputSecurityGroupsResponse>(req, "DescribeStreamLiveInputSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query StreamLive inputs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputsResponse"/></returns>
        public Task<DescribeStreamLiveInputsResponse> DescribeStreamLiveInputs(DescribeStreamLiveInputsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputsResponse>(req, "DescribeStreamLiveInputs");
        }

        /// <summary>
        /// This API is used to query StreamLive inputs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputsResponse"/></returns>
        public DescribeStreamLiveInputsResponse DescribeStreamLiveInputsSync(DescribeStreamLiveInputsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveInputsResponse>(req, "DescribeStreamLiveInputs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the events in the plan in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLivePlansRequest"/></param>
        /// <returns><see cref="DescribeStreamLivePlansResponse"/></returns>
        public Task<DescribeStreamLivePlansResponse> DescribeStreamLivePlans(DescribeStreamLivePlansRequest req)
        {
            return InternalRequestAsync<DescribeStreamLivePlansResponse>(req, "DescribeStreamLivePlans");
        }

        /// <summary>
        /// This API is used to query the events in the plan in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLivePlansRequest"/></param>
        /// <returns><see cref="DescribeStreamLivePlansResponse"/></returns>
        public DescribeStreamLivePlansResponse DescribeStreamLivePlansSync(DescribeStreamLivePlansRequest req)
        {
            return InternalRequestAsync<DescribeStreamLivePlansResponse>(req, "DescribeStreamLivePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all StreamLive regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveRegionsResponse"/></returns>
        public Task<DescribeStreamLiveRegionsResponse> DescribeStreamLiveRegions(DescribeStreamLiveRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveRegionsResponse>(req, "DescribeStreamLiveRegions");
        }

        /// <summary>
        /// This API is used to query all StreamLive regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveRegionsResponse"/></returns>
        public DescribeStreamLiveRegionsResponse DescribeStreamLiveRegionsSync(DescribeStreamLiveRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveRegionsResponse>(req, "DescribeStreamLiveRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the transcoding information of StreamLive streams.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveTranscodeDetailRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveTranscodeDetailResponse"/></returns>
        public Task<DescribeStreamLiveTranscodeDetailResponse> DescribeStreamLiveTranscodeDetail(DescribeStreamLiveTranscodeDetailRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveTranscodeDetailResponse>(req, "DescribeStreamLiveTranscodeDetail");
        }

        /// <summary>
        /// This API is used to query the transcoding information of StreamLive streams.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveTranscodeDetailRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveTranscodeDetailResponse"/></returns>
        public DescribeStreamLiveTranscodeDetailResponse DescribeStreamLiveTranscodeDetailSync(DescribeStreamLiveTranscodeDetailRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveTranscodeDetailResponse>(req, "DescribeStreamLiveTranscodeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarkResponse"/></returns>
        public Task<DescribeStreamLiveWatermarkResponse> DescribeStreamLiveWatermark(DescribeStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveWatermarkResponse>(req, "DescribeStreamLiveWatermark");
        }

        /// <summary>
        /// This API is used to query a watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarkResponse"/></returns>
        public DescribeStreamLiveWatermarkResponse DescribeStreamLiveWatermarkSync(DescribeStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveWatermarkResponse>(req, "DescribeStreamLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query multiple watermarks at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarksResponse"/></returns>
        public Task<DescribeStreamLiveWatermarksResponse> DescribeStreamLiveWatermarks(DescribeStreamLiveWatermarksRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveWatermarksResponse>(req, "DescribeStreamLiveWatermarks");
        }

        /// <summary>
        /// This API is used to query multiple watermarks at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarksResponse"/></returns>
        public DescribeStreamLiveWatermarksResponse DescribeStreamLiveWatermarksSync(DescribeStreamLiveWatermarksRequest req)
        {
            return InternalRequestAsync<DescribeStreamLiveWatermarksResponse>(req, "DescribeStreamLiveWatermarks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveChannelResponse"/></returns>
        public Task<ModifyStreamLiveChannelResponse> ModifyStreamLiveChannel(ModifyStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveChannelResponse>(req, "ModifyStreamLiveChannel");
        }

        /// <summary>
        /// This API is used to modify a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveChannelResponse"/></returns>
        public ModifyStreamLiveChannelResponse ModifyStreamLiveChannelSync(ModifyStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveChannelResponse>(req, "ModifyStreamLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputResponse"/></returns>
        public Task<ModifyStreamLiveInputResponse> ModifyStreamLiveInput(ModifyStreamLiveInputRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveInputResponse>(req, "ModifyStreamLiveInput");
        }

        /// <summary>
        /// This API is used to modify a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputResponse"/></returns>
        public ModifyStreamLiveInputResponse ModifyStreamLiveInputSync(ModifyStreamLiveInputRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveInputResponse>(req, "ModifyStreamLiveInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an input security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputSecurityGroupResponse"/></returns>
        public Task<ModifyStreamLiveInputSecurityGroupResponse> ModifyStreamLiveInputSecurityGroup(ModifyStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveInputSecurityGroupResponse>(req, "ModifyStreamLiveInputSecurityGroup");
        }

        /// <summary>
        /// This API is used to modify an input security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputSecurityGroupResponse"/></returns>
        public ModifyStreamLiveInputSecurityGroupResponse ModifyStreamLiveInputSecurityGroupSync(ModifyStreamLiveInputSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveInputSecurityGroupResponse>(req, "ModifyStreamLiveInputSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a watermark.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveWatermarkResponse"/></returns>
        public Task<ModifyStreamLiveWatermarkResponse> ModifyStreamLiveWatermark(ModifyStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveWatermarkResponse>(req, "ModifyStreamLiveWatermark");
        }

        /// <summary>
        /// This API is used to modify a watermark.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveWatermarkResponse"/></returns>
        public ModifyStreamLiveWatermarkResponse ModifyStreamLiveWatermarkSync(ModifyStreamLiveWatermarkRequest req)
        {
            return InternalRequestAsync<ModifyStreamLiveWatermarkResponse>(req, "ModifyStreamLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the stream status of a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="QueryInputStreamStateRequest"/></param>
        /// <returns><see cref="QueryInputStreamStateResponse"/></returns>
        public Task<QueryInputStreamStateResponse> QueryInputStreamState(QueryInputStreamStateRequest req)
        {
            return InternalRequestAsync<QueryInputStreamStateResponse>(req, "QueryInputStreamState");
        }

        /// <summary>
        /// This API is used to query the stream status of a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="QueryInputStreamStateRequest"/></param>
        /// <returns><see cref="QueryInputStreamStateResponse"/></returns>
        public QueryInputStreamStateResponse QueryInputStreamStateSync(QueryInputStreamStateRequest req)
        {
            return InternalRequestAsync<QueryInputStreamStateResponse>(req, "QueryInputStreamState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StartStreamLiveChannelResponse"/></returns>
        public Task<StartStreamLiveChannelResponse> StartStreamLiveChannel(StartStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<StartStreamLiveChannelResponse>(req, "StartStreamLiveChannel");
        }

        /// <summary>
        /// This API is used to start a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StartStreamLiveChannelResponse"/></returns>
        public StartStreamLiveChannelResponse StartStreamLiveChannelSync(StartStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<StartStreamLiveChannelResponse>(req, "StartStreamLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StopStreamLiveChannelResponse"/></returns>
        public Task<StopStreamLiveChannelResponse> StopStreamLiveChannel(StopStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<StopStreamLiveChannelResponse>(req, "StopStreamLiveChannel");
        }

        /// <summary>
        /// This API is used to stop a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StopStreamLiveChannelResponse"/></returns>
        public StopStreamLiveChannelResponse StopStreamLiveChannelSync(StopStreamLiveChannelRequest req)
        {
            return InternalRequestAsync<StopStreamLiveChannelResponse>(req, "StopStreamLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
