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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdlClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to create a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveChannelRequest"/></param>
        /// <returns><see cref="CreateStreamLiveChannelResponse"/></returns>
        public async Task<CreateStreamLiveChannelResponse> CreateStreamLiveChannel(CreateStreamLiveChannelRequest req)
        {
             JsonResponseModel<CreateStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveChannelRequest"/></param>
        /// <returns><see cref="CreateStreamLiveChannelResponse"/></returns>
        public CreateStreamLiveChannelResponse CreateStreamLiveChannelSync(CreateStreamLiveChannelRequest req)
        {
             JsonResponseModel<CreateStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputResponse"/></returns>
        public async Task<CreateStreamLiveInputResponse> CreateStreamLiveInput(CreateStreamLiveInputRequest req)
        {
             JsonResponseModel<CreateStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputResponse"/></returns>
        public CreateStreamLiveInputResponse CreateStreamLiveInputSync(CreateStreamLiveInputRequest req)
        {
             JsonResponseModel<CreateStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an input security group. Up to 5 security groups are allowed.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputSecurityGroupResponse"/></returns>
        public async Task<CreateStreamLiveInputSecurityGroupResponse> CreateStreamLiveInputSecurityGroup(CreateStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<CreateStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an input security group. Up to 5 security groups are allowed.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateStreamLiveInputSecurityGroupResponse"/></returns>
        public CreateStreamLiveInputSecurityGroupResponse CreateStreamLiveInputSecurityGroupSync(CreateStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<CreateStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an event in the plan.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLivePlanRequest"/></param>
        /// <returns><see cref="CreateStreamLivePlanResponse"/></returns>
        public async Task<CreateStreamLivePlanResponse> CreateStreamLivePlan(CreateStreamLivePlanRequest req)
        {
             JsonResponseModel<CreateStreamLivePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLivePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLivePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an event in the plan.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLivePlanRequest"/></param>
        /// <returns><see cref="CreateStreamLivePlanResponse"/></returns>
        public CreateStreamLivePlanResponse CreateStreamLivePlanSync(CreateStreamLivePlanRequest req)
        {
             JsonResponseModel<CreateStreamLivePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLivePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLivePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a watermark.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="CreateStreamLiveWatermarkResponse"/></returns>
        public async Task<CreateStreamLiveWatermarkResponse> CreateStreamLiveWatermark(CreateStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<CreateStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a watermark.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="CreateStreamLiveWatermarkResponse"/></returns>
        public CreateStreamLiveWatermarkResponse CreateStreamLiveWatermarkSync(CreateStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<CreateStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveChannelResponse"/></returns>
        public async Task<DeleteStreamLiveChannelResponse> DeleteStreamLiveChannel(DeleteStreamLiveChannelRequest req)
        {
             JsonResponseModel<DeleteStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveChannelResponse"/></returns>
        public DeleteStreamLiveChannelResponse DeleteStreamLiveChannelSync(DeleteStreamLiveChannelRequest req)
        {
             JsonResponseModel<DeleteStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputResponse"/></returns>
        public async Task<DeleteStreamLiveInputResponse> DeleteStreamLiveInput(DeleteStreamLiveInputRequest req)
        {
             JsonResponseModel<DeleteStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputResponse"/></returns>
        public DeleteStreamLiveInputResponse DeleteStreamLiveInputSync(DeleteStreamLiveInputRequest req)
        {
             JsonResponseModel<DeleteStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an input security group.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputSecurityGroupResponse"/></returns>
        public async Task<DeleteStreamLiveInputSecurityGroupResponse> DeleteStreamLiveInputSecurityGroup(DeleteStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an input security group.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveInputSecurityGroupResponse"/></returns>
        public DeleteStreamLiveInputSecurityGroupResponse DeleteStreamLiveInputSecurityGroupSync(DeleteStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLive event.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLivePlanRequest"/></param>
        /// <returns><see cref="DeleteStreamLivePlanResponse"/></returns>
        public async Task<DeleteStreamLivePlanResponse> DeleteStreamLivePlan(DeleteStreamLivePlanRequest req)
        {
             JsonResponseModel<DeleteStreamLivePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLivePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLivePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLive event.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLivePlanRequest"/></param>
        /// <returns><see cref="DeleteStreamLivePlanResponse"/></returns>
        public DeleteStreamLivePlanResponse DeleteStreamLivePlanSync(DeleteStreamLivePlanRequest req)
        {
             JsonResponseModel<DeleteStreamLivePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLivePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLivePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveWatermarkResponse"/></returns>
        public async Task<DeleteStreamLiveWatermarkResponse> DeleteStreamLiveWatermark(DeleteStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a watermark.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteStreamLiveWatermarkResponse"/></returns>
        public DeleteStreamLiveWatermarkResponse DeleteStreamLiveWatermarkSync(DeleteStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelResponse"/></returns>
        public async Task<DescribeStreamLiveChannelResponse> DescribeStreamLiveChannel(DescribeStreamLiveChannelRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelResponse"/></returns>
        public DescribeStreamLiveChannelResponse DescribeStreamLiveChannelSync(DescribeStreamLiveChannelRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the alarm information of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelAlertsResponse"/></returns>
        public async Task<DescribeStreamLiveChannelAlertsResponse> DescribeStreamLiveChannelAlerts(DescribeStreamLiveChannelAlertsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelAlertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveChannelAlerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelAlertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the alarm information of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelAlertsResponse"/></returns>
        public DescribeStreamLiveChannelAlertsResponse DescribeStreamLiveChannelAlertsSync(DescribeStreamLiveChannelAlertsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelAlertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveChannelAlerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelAlertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query input statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelInputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelInputStatisticsResponse"/></returns>
        public async Task<DescribeStreamLiveChannelInputStatisticsResponse> DescribeStreamLiveChannelInputStatistics(DescribeStreamLiveChannelInputStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelInputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveChannelInputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelInputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query input statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelInputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelInputStatisticsResponse"/></returns>
        public DescribeStreamLiveChannelInputStatisticsResponse DescribeStreamLiveChannelInputStatisticsSync(DescribeStreamLiveChannelInputStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelInputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveChannelInputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelInputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query StreamLive channel logs, such as push event logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelLogsResponse"/></returns>
        public async Task<DescribeStreamLiveChannelLogsResponse> DescribeStreamLiveChannelLogs(DescribeStreamLiveChannelLogsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveChannelLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query StreamLive channel logs, such as push event logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelLogsResponse"/></returns>
        public DescribeStreamLiveChannelLogsResponse DescribeStreamLiveChannelLogsSync(DescribeStreamLiveChannelLogsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveChannelLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the output statistics of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelOutputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelOutputStatisticsResponse"/></returns>
        public async Task<DescribeStreamLiveChannelOutputStatisticsResponse> DescribeStreamLiveChannelOutputStatistics(DescribeStreamLiveChannelOutputStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelOutputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveChannelOutputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelOutputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the output statistics of a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelOutputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelOutputStatisticsResponse"/></returns>
        public DescribeStreamLiveChannelOutputStatisticsResponse DescribeStreamLiveChannelOutputStatisticsSync(DescribeStreamLiveChannelOutputStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelOutputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveChannelOutputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelOutputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query StreamLive channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelsResponse"/></returns>
        public async Task<DescribeStreamLiveChannelsResponse> DescribeStreamLiveChannels(DescribeStreamLiveChannelsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query StreamLive channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveChannelsResponse"/></returns>
        public DescribeStreamLiveChannelsResponse DescribeStreamLiveChannelsSync(DescribeStreamLiveChannelsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputResponse"/></returns>
        public async Task<DescribeStreamLiveInputResponse> DescribeStreamLiveInput(DescribeStreamLiveInputRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputResponse"/></returns>
        public DescribeStreamLiveInputResponse DescribeStreamLiveInputSync(DescribeStreamLiveInputRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an input security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupResponse"/></returns>
        public async Task<DescribeStreamLiveInputSecurityGroupResponse> DescribeStreamLiveInputSecurityGroup(DescribeStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an input security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupResponse"/></returns>
        public DescribeStreamLiveInputSecurityGroupResponse DescribeStreamLiveInputSecurityGroupSync(DescribeStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query input security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupsResponse"/></returns>
        public async Task<DescribeStreamLiveInputSecurityGroupsResponse> DescribeStreamLiveInputSecurityGroups(DescribeStreamLiveInputSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveInputSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query input security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputSecurityGroupsResponse"/></returns>
        public DescribeStreamLiveInputSecurityGroupsResponse DescribeStreamLiveInputSecurityGroupsSync(DescribeStreamLiveInputSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveInputSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query StreamLive inputs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputsResponse"/></returns>
        public async Task<DescribeStreamLiveInputsResponse> DescribeStreamLiveInputs(DescribeStreamLiveInputsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveInputs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query StreamLive inputs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveInputsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveInputsResponse"/></returns>
        public DescribeStreamLiveInputsResponse DescribeStreamLiveInputsSync(DescribeStreamLiveInputsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveInputsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveInputs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveInputsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the events in the plan in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLivePlansRequest"/></param>
        /// <returns><see cref="DescribeStreamLivePlansResponse"/></returns>
        public async Task<DescribeStreamLivePlansResponse> DescribeStreamLivePlans(DescribeStreamLivePlansRequest req)
        {
             JsonResponseModel<DescribeStreamLivePlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLivePlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLivePlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the events in the plan in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLivePlansRequest"/></param>
        /// <returns><see cref="DescribeStreamLivePlansResponse"/></returns>
        public DescribeStreamLivePlansResponse DescribeStreamLivePlansSync(DescribeStreamLivePlansRequest req)
        {
             JsonResponseModel<DescribeStreamLivePlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLivePlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLivePlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all StreamLive regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveRegionsResponse"/></returns>
        public async Task<DescribeStreamLiveRegionsResponse> DescribeStreamLiveRegions(DescribeStreamLiveRegionsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all StreamLive regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveRegionsResponse"/></returns>
        public DescribeStreamLiveRegionsResponse DescribeStreamLiveRegionsSync(DescribeStreamLiveRegionsRequest req)
        {
             JsonResponseModel<DescribeStreamLiveRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarkResponse"/></returns>
        public async Task<DescribeStreamLiveWatermarkResponse> DescribeStreamLiveWatermark(DescribeStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a watermark.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarkResponse"/></returns>
        public DescribeStreamLiveWatermarkResponse DescribeStreamLiveWatermarkSync(DescribeStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query multiple watermarks at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarksResponse"/></returns>
        public async Task<DescribeStreamLiveWatermarksResponse> DescribeStreamLiveWatermarks(DescribeStreamLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeStreamLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query multiple watermarks at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeStreamLiveWatermarksResponse"/></returns>
        public DescribeStreamLiveWatermarksResponse DescribeStreamLiveWatermarksSync(DescribeStreamLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeStreamLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveChannelResponse"/></returns>
        public async Task<ModifyStreamLiveChannelResponse> ModifyStreamLiveChannel(ModifyStreamLiveChannelRequest req)
        {
             JsonResponseModel<ModifyStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveChannelResponse"/></returns>
        public ModifyStreamLiveChannelResponse ModifyStreamLiveChannelSync(ModifyStreamLiveChannelRequest req)
        {
             JsonResponseModel<ModifyStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputResponse"/></returns>
        public async Task<ModifyStreamLiveInputResponse> ModifyStreamLiveInput(ModifyStreamLiveInputRequest req)
        {
             JsonResponseModel<ModifyStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a StreamLive input.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputResponse"/></returns>
        public ModifyStreamLiveInputResponse ModifyStreamLiveInputSync(ModifyStreamLiveInputRequest req)
        {
             JsonResponseModel<ModifyStreamLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an input security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputSecurityGroupResponse"/></returns>
        public async Task<ModifyStreamLiveInputSecurityGroupResponse> ModifyStreamLiveInputSecurityGroup(ModifyStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an input security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveInputSecurityGroupResponse"/></returns>
        public ModifyStreamLiveInputSecurityGroupResponse ModifyStreamLiveInputSecurityGroupSync(ModifyStreamLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyStreamLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a watermark.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveWatermarkResponse"/></returns>
        public async Task<ModifyStreamLiveWatermarkResponse> ModifyStreamLiveWatermark(ModifyStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<ModifyStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a watermark.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLiveWatermarkRequest"/></param>
        /// <returns><see cref="ModifyStreamLiveWatermarkResponse"/></returns>
        public ModifyStreamLiveWatermarkResponse ModifyStreamLiveWatermarkSync(ModifyStreamLiveWatermarkRequest req)
        {
             JsonResponseModel<ModifyStreamLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StartStreamLiveChannelResponse"/></returns>
        public async Task<StartStreamLiveChannelResponse> StartStreamLiveChannel(StartStreamLiveChannelRequest req)
        {
             JsonResponseModel<StartStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StartStreamLiveChannelResponse"/></returns>
        public StartStreamLiveChannelResponse StartStreamLiveChannelSync(StartStreamLiveChannelRequest req)
        {
             JsonResponseModel<StartStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StopStreamLiveChannelResponse"/></returns>
        public async Task<StopStreamLiveChannelResponse> StopStreamLiveChannel(StopStreamLiveChannelRequest req)
        {
             JsonResponseModel<StopStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a StreamLive channel.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLiveChannelRequest"/></param>
        /// <returns><see cref="StopStreamLiveChannelResponse"/></returns>
        public StopStreamLiveChannelResponse StopStreamLiveChannelSync(StopStreamLiveChannelRequest req)
        {
             JsonResponseModel<StopStreamLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopStreamLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopStreamLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
