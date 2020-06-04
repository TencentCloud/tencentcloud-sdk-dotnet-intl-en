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
        /// This API is used to create a media channel.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaLiveChannelRequest"/></param>
        /// <returns><see cref="CreateMediaLiveChannelResponse"/></returns>
        public async Task<CreateMediaLiveChannelResponse> CreateMediaLiveChannel(CreateMediaLiveChannelRequest req)
        {
             JsonResponseModel<CreateMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a media channel.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaLiveChannelRequest"/></param>
        /// <returns><see cref="CreateMediaLiveChannelResponse"/></returns>
        public CreateMediaLiveChannelResponse CreateMediaLiveChannelSync(CreateMediaLiveChannelRequest req)
        {
             JsonResponseModel<CreateMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a media input.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaLiveInputRequest"/></param>
        /// <returns><see cref="CreateMediaLiveInputResponse"/></returns>
        public async Task<CreateMediaLiveInputResponse> CreateMediaLiveInput(CreateMediaLiveInputRequest req)
        {
             JsonResponseModel<CreateMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a media input.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaLiveInputRequest"/></param>
        /// <returns><see cref="CreateMediaLiveInputResponse"/></returns>
        public CreateMediaLiveInputResponse CreateMediaLiveInputSync(CreateMediaLiveInputRequest req)
        {
             JsonResponseModel<CreateMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an input security group. Up to 5 ones can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateMediaLiveInputSecurityGroupResponse"/></returns>
        public async Task<CreateMediaLiveInputSecurityGroupResponse> CreateMediaLiveInputSecurityGroup(CreateMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<CreateMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an input security group. Up to 5 ones can be created.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateMediaLiveInputSecurityGroupResponse"/></returns>
        public CreateMediaLiveInputSecurityGroupResponse CreateMediaLiveInputSecurityGroupSync(CreateMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<CreateMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteMediaLiveChannelResponse"/></returns>
        public async Task<DeleteMediaLiveChannelResponse> DeleteMediaLiveChannel(DeleteMediaLiveChannelRequest req)
        {
             JsonResponseModel<DeleteMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteMediaLiveChannelResponse"/></returns>
        public DeleteMediaLiveChannelResponse DeleteMediaLiveChannelSync(DeleteMediaLiveChannelRequest req)
        {
             JsonResponseModel<DeleteMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a media input.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaLiveInputRequest"/></param>
        /// <returns><see cref="DeleteMediaLiveInputResponse"/></returns>
        public async Task<DeleteMediaLiveInputResponse> DeleteMediaLiveInput(DeleteMediaLiveInputRequest req)
        {
             JsonResponseModel<DeleteMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a media input.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaLiveInputRequest"/></param>
        /// <returns><see cref="DeleteMediaLiveInputResponse"/></returns>
        public DeleteMediaLiveInputResponse DeleteMediaLiveInputSync(DeleteMediaLiveInputRequest req)
        {
             JsonResponseModel<DeleteMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaLiveInputResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteMediaLiveInputSecurityGroupResponse"/></returns>
        public async Task<DeleteMediaLiveInputSecurityGroupResponse> DeleteMediaLiveInputSecurityGroup(DeleteMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaLiveInputSecurityGroupResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteMediaLiveInputSecurityGroupResponse"/></returns>
        public DeleteMediaLiveInputSecurityGroupResponse DeleteMediaLiveInputSecurityGroupSync(DeleteMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelResponse"/></returns>
        public async Task<DescribeMediaLiveChannelResponse> DescribeMediaLiveChannel(DescribeMediaLiveChannelRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelResponse"/></returns>
        public DescribeMediaLiveChannelResponse DescribeMediaLiveChannelSync(DescribeMediaLiveChannelRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the channel alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelAlertsResponse"/></returns>
        public async Task<DescribeMediaLiveChannelAlertsResponse> DescribeMediaLiveChannelAlerts(DescribeMediaLiveChannelAlertsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelAlertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveChannelAlerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelAlertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the channel alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelAlertsResponse"/></returns>
        public DescribeMediaLiveChannelAlertsResponse DescribeMediaLiveChannelAlertsSync(DescribeMediaLiveChannelAlertsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelAlertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveChannelAlerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelAlertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the input statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelInputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelInputStatisticsResponse"/></returns>
        public async Task<DescribeMediaLiveChannelInputStatisticsResponse> DescribeMediaLiveChannelInputStatistics(DescribeMediaLiveChannelInputStatisticsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelInputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveChannelInputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelInputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the input statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelInputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelInputStatisticsResponse"/></returns>
        public DescribeMediaLiveChannelInputStatisticsResponse DescribeMediaLiveChannelInputStatisticsSync(DescribeMediaLiveChannelInputStatisticsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelInputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveChannelInputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelInputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the output statistics of a channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelOutputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelOutputStatisticsResponse"/></returns>
        public async Task<DescribeMediaLiveChannelOutputStatisticsResponse> DescribeMediaLiveChannelOutputStatistics(DescribeMediaLiveChannelOutputStatisticsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelOutputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveChannelOutputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelOutputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the output statistics of a channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelOutputStatisticsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelOutputStatisticsResponse"/></returns>
        public DescribeMediaLiveChannelOutputStatisticsResponse DescribeMediaLiveChannelOutputStatisticsSync(DescribeMediaLiveChannelOutputStatisticsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelOutputStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveChannelOutputStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelOutputStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of MediaLive channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelsResponse"/></returns>
        public async Task<DescribeMediaLiveChannelsResponse> DescribeMediaLiveChannels(DescribeMediaLiveChannelsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of MediaLive channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveChannelsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveChannelsResponse"/></returns>
        public DescribeMediaLiveChannelsResponse DescribeMediaLiveChannelsSync(DescribeMediaLiveChannelsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a media input.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveInputRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputResponse"/></returns>
        public async Task<DescribeMediaLiveInputResponse> DescribeMediaLiveInput(DescribeMediaLiveInputRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a media input.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveInputRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputResponse"/></returns>
        public DescribeMediaLiveInputResponse DescribeMediaLiveInputSync(DescribeMediaLiveInputRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputSecurityGroupResponse"/></returns>
        public async Task<DescribeMediaLiveInputSecurityGroupResponse> DescribeMediaLiveInputSecurityGroup(DescribeMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputSecurityGroupResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputSecurityGroupResponse"/></returns>
        public DescribeMediaLiveInputSecurityGroupResponse DescribeMediaLiveInputSecurityGroupSync(DescribeMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of input security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveInputSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputSecurityGroupsResponse"/></returns>
        public async Task<DescribeMediaLiveInputSecurityGroupsResponse> DescribeMediaLiveInputSecurityGroups(DescribeMediaLiveInputSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveInputSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of input security groups in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveInputSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputSecurityGroupsResponse"/></returns>
        public DescribeMediaLiveInputSecurityGroupsResponse DescribeMediaLiveInputSecurityGroupsSync(DescribeMediaLiveInputSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveInputSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of media inputs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveInputsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputsResponse"/></returns>
        public async Task<DescribeMediaLiveInputsResponse> DescribeMediaLiveInputs(DescribeMediaLiveInputsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaLiveInputs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of media inputs in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaLiveInputsRequest"/></param>
        /// <returns><see cref="DescribeMediaLiveInputsResponse"/></returns>
        public DescribeMediaLiveInputsResponse DescribeMediaLiveInputsSync(DescribeMediaLiveInputsRequest req)
        {
             JsonResponseModel<DescribeMediaLiveInputsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaLiveInputs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaLiveInputsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyMediaLiveChannelResponse"/></returns>
        public async Task<ModifyMediaLiveChannelResponse> ModifyMediaLiveChannel(ModifyMediaLiveChannelRequest req)
        {
             JsonResponseModel<ModifyMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyMediaLiveChannelResponse"/></returns>
        public ModifyMediaLiveChannelResponse ModifyMediaLiveChannelSync(ModifyMediaLiveChannelRequest req)
        {
             JsonResponseModel<ModifyMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a media input.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaLiveInputRequest"/></param>
        /// <returns><see cref="ModifyMediaLiveInputResponse"/></returns>
        public async Task<ModifyMediaLiveInputResponse> ModifyMediaLiveInput(ModifyMediaLiveInputRequest req)
        {
             JsonResponseModel<ModifyMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a media input.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaLiveInputRequest"/></param>
        /// <returns><see cref="ModifyMediaLiveInputResponse"/></returns>
        public ModifyMediaLiveInputResponse ModifyMediaLiveInputSync(ModifyMediaLiveInputRequest req)
        {
             JsonResponseModel<ModifyMediaLiveInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaLiveInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaLiveInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update an input security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyMediaLiveInputSecurityGroupResponse"/></returns>
        public async Task<ModifyMediaLiveInputSecurityGroupResponse> ModifyMediaLiveInputSecurityGroup(ModifyMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update an input security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaLiveInputSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyMediaLiveInputSecurityGroupResponse"/></returns>
        public ModifyMediaLiveInputSecurityGroupResponse ModifyMediaLiveInputSecurityGroupSync(ModifyMediaLiveInputSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyMediaLiveInputSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaLiveInputSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaLiveInputSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="StartMediaLiveChannelRequest"/></param>
        /// <returns><see cref="StartMediaLiveChannelResponse"/></returns>
        public async Task<StartMediaLiveChannelResponse> StartMediaLiveChannel(StartMediaLiveChannelRequest req)
        {
             JsonResponseModel<StartMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="StartMediaLiveChannelRequest"/></param>
        /// <returns><see cref="StartMediaLiveChannelResponse"/></returns>
        public StartMediaLiveChannelResponse StartMediaLiveChannelSync(StartMediaLiveChannelRequest req)
        {
             JsonResponseModel<StartMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="StopMediaLiveChannelRequest"/></param>
        /// <returns><see cref="StopMediaLiveChannelResponse"/></returns>
        public async Task<StopMediaLiveChannelResponse> StopMediaLiveChannel(StopMediaLiveChannelRequest req)
        {
             JsonResponseModel<StopMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a MediaLive channel.
        /// </summary>
        /// <param name="req"><see cref="StopMediaLiveChannelRequest"/></param>
        /// <returns><see cref="StopMediaLiveChannelResponse"/></returns>
        public StopMediaLiveChannelResponse StopMediaLiveChannelSync(StopMediaLiveChannelRequest req)
        {
             JsonResponseModel<StopMediaLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMediaLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMediaLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
