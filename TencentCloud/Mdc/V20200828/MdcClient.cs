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
       private const string sdkVersion = "SDK_NET_3.0.1018";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkFlowRequest"/></param>
        /// <returns><see cref="CreateStreamLinkFlowResponse"/></returns>
        public Task<CreateStreamLinkFlowResponse> CreateStreamLinkFlow(CreateStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkFlowResponse>(req, "CreateStreamLinkFlow");
        }

        /// <summary>
        /// This API is used to create a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkFlowRequest"/></param>
        /// <returns><see cref="CreateStreamLinkFlowResponse"/></returns>
        public CreateStreamLinkFlowResponse CreateStreamLinkFlowSync(CreateStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkFlowResponse>(req, "CreateStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an input configuration for the StreamLink.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkInputRequest"/></param>
        /// <returns><see cref="CreateStreamLinkInputResponse"/></returns>
        public Task<CreateStreamLinkInputResponse> CreateStreamLinkInput(CreateStreamLinkInputRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkInputResponse>(req, "CreateStreamLinkInput");
        }

        /// <summary>
        /// Create an input configuration for the StreamLink.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkInputRequest"/></param>
        /// <returns><see cref="CreateStreamLinkInputResponse"/></returns>
        public CreateStreamLinkInputResponse CreateStreamLinkInputSync(CreateStreamLinkInputRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkInputResponse>(req, "CreateStreamLinkInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a StreamLink output.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="CreateStreamLinkOutputInfoResponse"/></returns>
        public Task<CreateStreamLinkOutputInfoResponse> CreateStreamLinkOutputInfo(CreateStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkOutputInfoResponse>(req, "CreateStreamLinkOutputInfo");
        }

        /// <summary>
        /// This API is used to create a StreamLink output.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="CreateStreamLinkOutputInfoResponse"/></returns>
        public CreateStreamLinkOutputInfoResponse CreateStreamLinkOutputInfoSync(CreateStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkOutputInfoResponse>(req, "CreateStreamLinkOutputInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkFlowResponse"/></returns>
        public Task<DeleteStreamLinkFlowResponse> DeleteStreamLinkFlow(DeleteStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkFlowResponse>(req, "DeleteStreamLinkFlow");
        }

        /// <summary>
        /// This API is used to delete a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkFlowResponse"/></returns>
        public DeleteStreamLinkFlowResponse DeleteStreamLinkFlowSync(DeleteStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkFlowResponse>(req, "DeleteStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkOutputRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkOutputResponse"/></returns>
        public Task<DeleteStreamLinkOutputResponse> DeleteStreamLinkOutput(DeleteStreamLinkOutputRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkOutputResponse>(req, "DeleteStreamLinkOutput");
        }

        /// <summary>
        /// This API is used to delete an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkOutputRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkOutputResponse"/></returns>
        public DeleteStreamLinkOutputResponse DeleteStreamLinkOutputSync(DeleteStreamLinkOutputRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkOutputResponse>(req, "DeleteStreamLinkOutput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowResponse"/></returns>
        public Task<DescribeStreamLinkFlowResponse> DescribeStreamLinkFlow(DescribeStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowResponse>(req, "DescribeStreamLinkFlow");
        }

        /// <summary>
        /// This API is used to query the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowResponse"/></returns>
        public DescribeStreamLinkFlowResponse DescribeStreamLinkFlowSync(DescribeStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowResponse>(req, "DescribeStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the logs of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowLogsResponse"/></returns>
        public Task<DescribeStreamLinkFlowLogsResponse> DescribeStreamLinkFlowLogs(DescribeStreamLinkFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowLogsResponse>(req, "DescribeStreamLinkFlowLogs");
        }

        /// <summary>
        /// This API is used to query the logs of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowLogsResponse"/></returns>
        public DescribeStreamLinkFlowLogsResponse DescribeStreamLinkFlowLogsSync(DescribeStreamLinkFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowLogsResponse>(req, "DescribeStreamLinkFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowMediaStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowMediaStatisticsResponse"/></returns>
        public Task<DescribeStreamLinkFlowMediaStatisticsResponse> DescribeStreamLinkFlowMediaStatistics(DescribeStreamLinkFlowMediaStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowMediaStatisticsResponse>(req, "DescribeStreamLinkFlowMediaStatistics");
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowMediaStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowMediaStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowMediaStatisticsResponse DescribeStreamLinkFlowMediaStatisticsSync(DescribeStreamLinkFlowMediaStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowMediaStatisticsResponse>(req, "DescribeStreamLinkFlowMediaStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the current status of a flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRealtimeStatusRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowRealtimeStatusResponse"/></returns>
        public Task<DescribeStreamLinkFlowRealtimeStatusResponse> DescribeStreamLinkFlowRealtimeStatus(DescribeStreamLinkFlowRealtimeStatusRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowRealtimeStatusResponse>(req, "DescribeStreamLinkFlowRealtimeStatus");
        }

        /// <summary>
        /// This API is used to query the current status of a flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRealtimeStatusRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowRealtimeStatusResponse"/></returns>
        public DescribeStreamLinkFlowRealtimeStatusResponse DescribeStreamLinkFlowRealtimeStatusSync(DescribeStreamLinkFlowRealtimeStatusRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowRealtimeStatusResponse>(req, "DescribeStreamLinkFlowRealtimeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SRT streaming performance of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowSRTStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowSRTStatisticsResponse"/></returns>
        public Task<DescribeStreamLinkFlowSRTStatisticsResponse> DescribeStreamLinkFlowSRTStatistics(DescribeStreamLinkFlowSRTStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowSRTStatisticsResponse>(req, "DescribeStreamLinkFlowSRTStatistics");
        }

        /// <summary>
        /// This API is used to query the SRT streaming performance of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowSRTStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowSRTStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowSRTStatisticsResponse DescribeStreamLinkFlowSRTStatisticsSync(DescribeStreamLinkFlowSRTStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowSRTStatisticsResponse>(req, "DescribeStreamLinkFlowSRTStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowStatisticsResponse"/></returns>
        public Task<DescribeStreamLinkFlowStatisticsResponse> DescribeStreamLinkFlowStatistics(DescribeStreamLinkFlowStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowStatisticsResponse>(req, "DescribeStreamLinkFlowStatistics");
        }

        /// <summary>
        /// This API is used to query the media quality of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowStatisticsResponse DescribeStreamLinkFlowStatisticsSync(DescribeStreamLinkFlowStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowStatisticsResponse>(req, "DescribeStreamLinkFlowStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration information of multiple StreamLink flows in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowsResponse"/></returns>
        public Task<DescribeStreamLinkFlowsResponse> DescribeStreamLinkFlows(DescribeStreamLinkFlowsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowsResponse>(req, "DescribeStreamLinkFlows");
        }

        /// <summary>
        /// This API is used to query the configuration information of multiple StreamLink flows in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowsResponse"/></returns>
        public DescribeStreamLinkFlowsResponse DescribeStreamLinkFlowsSync(DescribeStreamLinkFlowsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowsResponse>(req, "DescribeStreamLinkFlows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all StreamLink regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkRegionsResponse"/></returns>
        public Task<DescribeStreamLinkRegionsResponse> DescribeStreamLinkRegions(DescribeStreamLinkRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkRegionsResponse>(req, "DescribeStreamLinkRegions");
        }

        /// <summary>
        /// This API is used to query all StreamLink regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkRegionsResponse"/></returns>
        public DescribeStreamLinkRegionsResponse DescribeStreamLinkRegionsSync(DescribeStreamLinkRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkRegionsResponse>(req, "DescribeStreamLinkRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkFlowRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkFlowResponse"/></returns>
        public Task<ModifyStreamLinkFlowResponse> ModifyStreamLinkFlow(ModifyStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkFlowResponse>(req, "ModifyStreamLinkFlow");
        }

        /// <summary>
        /// This API is used to modify the configuration information of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkFlowRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkFlowResponse"/></returns>
        public ModifyStreamLinkFlowResponse ModifyStreamLinkFlowSync(ModifyStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkFlowResponse>(req, "ModifyStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an input of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkInputResponse"/></returns>
        public Task<ModifyStreamLinkInputResponse> ModifyStreamLinkInput(ModifyStreamLinkInputRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkInputResponse>(req, "ModifyStreamLinkInput");
        }

        /// <summary>
        /// This API is used to modify an input of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkInputResponse"/></returns>
        public ModifyStreamLinkInputResponse ModifyStreamLinkInputSync(ModifyStreamLinkInputRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkInputResponse>(req, "ModifyStreamLinkInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkOutputInfoResponse"/></returns>
        public Task<ModifyStreamLinkOutputInfoResponse> ModifyStreamLinkOutputInfo(ModifyStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkOutputInfoResponse>(req, "ModifyStreamLinkOutputInfo");
        }

        /// <summary>
        /// This API is used to modify an output of a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkOutputInfoResponse"/></returns>
        public ModifyStreamLinkOutputInfoResponse ModifyStreamLinkOutputInfoSync(ModifyStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkOutputInfoResponse>(req, "ModifyStreamLinkOutputInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StartStreamLinkFlowResponse"/></returns>
        public Task<StartStreamLinkFlowResponse> StartStreamLinkFlow(StartStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StartStreamLinkFlowResponse>(req, "StartStreamLinkFlow");
        }

        /// <summary>
        /// This API is used to start a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StartStreamLinkFlowResponse"/></returns>
        public StartStreamLinkFlowResponse StartStreamLinkFlowSync(StartStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StartStreamLinkFlowResponse>(req, "StartStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StopStreamLinkFlowResponse"/></returns>
        public Task<StopStreamLinkFlowResponse> StopStreamLinkFlow(StopStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StopStreamLinkFlowResponse>(req, "StopStreamLinkFlow");
        }

        /// <summary>
        /// This API is used to stop a StreamLink flow.
        /// </summary>
        /// <param name="req"><see cref="StopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StopStreamLinkFlowResponse"/></returns>
        public StopStreamLinkFlowResponse StopStreamLinkFlowSync(StopStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StopStreamLinkFlowResponse>(req, "StopStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
