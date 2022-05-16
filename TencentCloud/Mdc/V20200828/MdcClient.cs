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

namespace TencentCloud.Mdc.V20200828
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mdc.V20200828.Models;

   public class MdcClient : AbstractClient{

       private const string endpoint = "mdc.tencentcloudapi.com";
       private const string version = "2020-08-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MdcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkFlowRequest"/></param>
        /// <returns><see cref="CreateStreamLinkFlowResponse"/></returns>
        public async Task<CreateStreamLinkFlowResponse> CreateStreamLinkFlow(CreateStreamLinkFlowRequest req)
        {
             JsonResponseModel<CreateStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkFlowRequest"/></param>
        /// <returns><see cref="CreateStreamLinkFlowResponse"/></returns>
        public CreateStreamLinkFlowResponse CreateStreamLinkFlowSync(CreateStreamLinkFlowRequest req)
        {
             JsonResponseModel<CreateStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamLink output.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="CreateStreamLinkOutputInfoResponse"/></returns>
        public async Task<CreateStreamLinkOutputInfoResponse> CreateStreamLinkOutputInfo(CreateStreamLinkOutputInfoRequest req)
        {
             JsonResponseModel<CreateStreamLinkOutputInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamLinkOutputInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLinkOutputInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamLink output.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="CreateStreamLinkOutputInfoResponse"/></returns>
        public CreateStreamLinkOutputInfoResponse CreateStreamLinkOutputInfoSync(CreateStreamLinkOutputInfoRequest req)
        {
             JsonResponseModel<CreateStreamLinkOutputInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamLinkOutputInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamLinkOutputInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkFlowResponse"/></returns>
        public async Task<DeleteStreamLinkFlowResponse> DeleteStreamLinkFlow(DeleteStreamLinkFlowRequest req)
        {
             JsonResponseModel<DeleteStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkFlowResponse"/></returns>
        public DeleteStreamLinkFlowResponse DeleteStreamLinkFlowSync(DeleteStreamLinkFlowRequest req)
        {
             JsonResponseModel<DeleteStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkOutputRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkOutputResponse"/></returns>
        public async Task<DeleteStreamLinkOutputResponse> DeleteStreamLinkOutput(DeleteStreamLinkOutputRequest req)
        {
             JsonResponseModel<DeleteStreamLinkOutputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamLinkOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLinkOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkOutputRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkOutputResponse"/></returns>
        public DeleteStreamLinkOutputResponse DeleteStreamLinkOutputSync(DeleteStreamLinkOutputRequest req)
        {
             JsonResponseModel<DeleteStreamLinkOutputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamLinkOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamLinkOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowResponse"/></returns>
        public async Task<DescribeStreamLinkFlowResponse> DescribeStreamLinkFlow(DescribeStreamLinkFlowRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowResponse"/></returns>
        public DescribeStreamLinkFlowResponse DescribeStreamLinkFlowSync(DescribeStreamLinkFlowRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the logs of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowLogsResponse"/></returns>
        public async Task<DescribeStreamLinkFlowLogsResponse> DescribeStreamLinkFlowLogs(DescribeStreamLinkFlowLogsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the logs of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowLogsResponse"/></returns>
        public DescribeStreamLinkFlowLogsResponse DescribeStreamLinkFlowLogsSync(DescribeStreamLinkFlowLogsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowMediaStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowMediaStatisticsResponse"/></returns>
        public async Task<DescribeStreamLinkFlowMediaStatisticsResponse> DescribeStreamLinkFlowMediaStatistics(DescribeStreamLinkFlowMediaStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowMediaStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlowMediaStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowMediaStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowMediaStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowMediaStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowMediaStatisticsResponse DescribeStreamLinkFlowMediaStatisticsSync(DescribeStreamLinkFlowMediaStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowMediaStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlowMediaStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowMediaStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the current status of a flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRealtimeStatusRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowRealtimeStatusResponse"/></returns>
        public async Task<DescribeStreamLinkFlowRealtimeStatusResponse> DescribeStreamLinkFlowRealtimeStatus(DescribeStreamLinkFlowRealtimeStatusRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowRealtimeStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlowRealtimeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowRealtimeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the current status of a flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRealtimeStatusRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowRealtimeStatusResponse"/></returns>
        public DescribeStreamLinkFlowRealtimeStatusResponse DescribeStreamLinkFlowRealtimeStatusSync(DescribeStreamLinkFlowRealtimeStatusRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowRealtimeStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlowRealtimeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowRealtimeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the SRT streaming performance of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowSRTStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowSRTStatisticsResponse"/></returns>
        public async Task<DescribeStreamLinkFlowSRTStatisticsResponse> DescribeStreamLinkFlowSRTStatistics(DescribeStreamLinkFlowSRTStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowSRTStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlowSRTStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowSRTStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the SRT streaming performance of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowSRTStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowSRTStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowSRTStatisticsResponse DescribeStreamLinkFlowSRTStatisticsSync(DescribeStreamLinkFlowSRTStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowSRTStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlowSRTStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowSRTStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowStatisticsResponse"/></returns>
        public async Task<DescribeStreamLinkFlowStatisticsResponse> DescribeStreamLinkFlowStatistics(DescribeStreamLinkFlowStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlowStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowStatisticsResponse DescribeStreamLinkFlowStatisticsSync(DescribeStreamLinkFlowStatisticsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlowStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of multiple StreamLink flows in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowsResponse"/></returns>
        public async Task<DescribeStreamLinkFlowsResponse> DescribeStreamLinkFlows(DescribeStreamLinkFlowsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of multiple StreamLink flows in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowsResponse"/></returns>
        public DescribeStreamLinkFlowsResponse DescribeStreamLinkFlowsSync(DescribeStreamLinkFlowsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all StreamLink regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkRegionsResponse"/></returns>
        public async Task<DescribeStreamLinkRegionsResponse> DescribeStreamLinkRegions(DescribeStreamLinkRegionsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamLinkRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all StreamLink regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkRegionsResponse"/></returns>
        public DescribeStreamLinkRegionsResponse DescribeStreamLinkRegionsSync(DescribeStreamLinkRegionsRequest req)
        {
             JsonResponseModel<DescribeStreamLinkRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamLinkRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamLinkRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkFlowRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkFlowResponse"/></returns>
        public async Task<ModifyStreamLinkFlowResponse> ModifyStreamLinkFlow(ModifyStreamLinkFlowRequest req)
        {
             JsonResponseModel<ModifyStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkFlowRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkFlowResponse"/></returns>
        public ModifyStreamLinkFlowResponse ModifyStreamLinkFlowSync(ModifyStreamLinkFlowRequest req)
        {
             JsonResponseModel<ModifyStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an input of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkInputResponse"/></returns>
        public async Task<ModifyStreamLinkInputResponse> ModifyStreamLinkInput(ModifyStreamLinkInputRequest req)
        {
             JsonResponseModel<ModifyStreamLinkInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLinkInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLinkInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an input of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkInputResponse"/></returns>
        public ModifyStreamLinkInputResponse ModifyStreamLinkInputSync(ModifyStreamLinkInputRequest req)
        {
             JsonResponseModel<ModifyStreamLinkInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLinkInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLinkInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkOutputInfoResponse"/></returns>
        public async Task<ModifyStreamLinkOutputInfoResponse> ModifyStreamLinkOutputInfo(ModifyStreamLinkOutputInfoRequest req)
        {
             JsonResponseModel<ModifyStreamLinkOutputInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamLinkOutputInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLinkOutputInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkOutputInfoResponse"/></returns>
        public ModifyStreamLinkOutputInfoResponse ModifyStreamLinkOutputInfoSync(ModifyStreamLinkOutputInfoRequest req)
        {
             JsonResponseModel<ModifyStreamLinkOutputInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamLinkOutputInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamLinkOutputInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StartStreamLinkFlowResponse"/></returns>
        public async Task<StartStreamLinkFlowResponse> StartStreamLinkFlow(StartStreamLinkFlowRequest req)
        {
             JsonResponseModel<StartStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StartStreamLinkFlowResponse"/></returns>
        public StartStreamLinkFlowResponse StartStreamLinkFlowSync(StartStreamLinkFlowRequest req)
        {
             JsonResponseModel<StartStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StopStreamLinkFlowResponse"/></returns>
        public async Task<StopStreamLinkFlowResponse> StopStreamLinkFlow(StopStreamLinkFlowRequest req)
        {
             JsonResponseModel<StopStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StopStreamLinkFlowResponse"/></returns>
        public StopStreamLinkFlowResponse StopStreamLinkFlowSync(StopStreamLinkFlowRequest req)
        {
             JsonResponseModel<StopStreamLinkFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopStreamLinkFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopStreamLinkFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
