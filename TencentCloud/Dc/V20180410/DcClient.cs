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

namespace TencentCloud.Dc.V20180410
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dc.V20180410.Models;

   public class DcClient : AbstractClient{

       private const string endpoint = "dc.tencentcloudapi.com";
       private const string version = "2018-04-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to accept an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public async Task<AcceptDirectConnectTunnelResponse> AcceptDirectConnectTunnel(AcceptDirectConnectTunnelRequest req)
        {
             JsonResponseModel<AcceptDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to accept an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public AcceptDirectConnectTunnelResponse AcceptDirectConnectTunnelSync(AcceptDirectConnectTunnelRequest req)
        {
             JsonResponseModel<AcceptDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcceptDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for an internet tunnel’s CIDR block.
        /// </summary>
        /// <param name="req"><see cref="ApplyInternetAddressRequest"/></param>
        /// <returns><see cref="ApplyInternetAddressResponse"/></returns>
        public async Task<ApplyInternetAddressResponse> ApplyInternetAddress(ApplyInternetAddressRequest req)
        {
             JsonResponseModel<ApplyInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for an internet tunnel’s CIDR block.
        /// </summary>
        /// <param name="req"><see cref="ApplyInternetAddressRequest"/></param>
        /// <returns><see cref="ApplyInternetAddressResponse"/></returns>
        public ApplyInternetAddressResponse ApplyInternetAddressSync(ApplyInternetAddressRequest req)
        {
             JsonResponseModel<ApplyInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a connection.
        /// When calling this API, please note that:
        /// You need to complete identity verification for your account; otherwise, you cannot apply for a connection;
        /// If there is any connection in arrears under your account, you cannot apply for more connections.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectRequest"/></param>
        /// <returns><see cref="CreateDirectConnectResponse"/></returns>
        public async Task<CreateDirectConnectResponse> CreateDirectConnect(CreateDirectConnectRequest req)
        {
             JsonResponseModel<CreateDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a connection.
        /// When calling this API, please note that:
        /// You need to complete identity verification for your account; otherwise, you cannot apply for a connection;
        /// If there is any connection in arrears under your account, you cannot apply for more connections.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectRequest"/></param>
        /// <returns><see cref="CreateDirectConnectResponse"/></returns>
        public CreateDirectConnectResponse CreateDirectConnectSync(CreateDirectConnectRequest req)
        {
             JsonResponseModel<CreateDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public async Task<CreateDirectConnectTunnelResponse> CreateDirectConnectTunnel(CreateDirectConnectTunnelRequest req)
        {
             JsonResponseModel<CreateDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public CreateDirectConnectTunnelResponse CreateDirectConnectTunnelSync(CreateDirectConnectTunnelRequest req)
        {
             JsonResponseModel<CreateDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a connection.
        /// Only connected connections can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public async Task<DeleteDirectConnectResponse> DeleteDirectConnect(DeleteDirectConnectRequest req)
        {
             JsonResponseModel<DeleteDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a connection.
        /// Only connected connections can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public DeleteDirectConnectResponse DeleteDirectConnectSync(DeleteDirectConnectRequest req)
        {
             JsonResponseModel<DeleteDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public async Task<DeleteDirectConnectTunnelResponse> DeleteDirectConnectTunnel(DeleteDirectConnectTunnelRequest req)
        {
             JsonResponseModel<DeleteDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public DeleteDirectConnectTunnelResponse DeleteDirectConnectTunnelSync(DeleteDirectConnectTunnelRequest req)
        {
             JsonResponseModel<DeleteDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query connection access points.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public async Task<DescribeAccessPointsResponse> DescribeAccessPoints(DescribeAccessPointsRequest req)
        {
             JsonResponseModel<DescribeAccessPointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query connection access points.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public DescribeAccessPointsResponse DescribeAccessPointsSync(DescribeAccessPointsRequest req)
        {
             JsonResponseModel<DescribeAccessPointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of dedicated tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public async Task<DescribeDirectConnectTunnelsResponse> DescribeDirectConnectTunnels(DescribeDirectConnectTunnelsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectTunnelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectTunnels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectTunnelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of dedicated tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public DescribeDirectConnectTunnelsResponse DescribeDirectConnectTunnelsSync(DescribeDirectConnectTunnelsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectTunnelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectTunnels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectTunnelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public async Task<DescribeDirectConnectsResponse> DescribeDirectConnects(DescribeDirectConnectsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public DescribeDirectConnectsResponse DescribeDirectConnectsSync(DescribeDirectConnectsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the public IP address of an internet tunnel.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressResponse"/></returns>
        public async Task<DescribeInternetAddressResponse> DescribeInternetAddress(DescribeInternetAddressRequest req)
        {
             JsonResponseModel<DescribeInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the public IP address of an internet tunnel.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressResponse"/></returns>
        public DescribeInternetAddressResponse DescribeInternetAddressSync(DescribeInternetAddressRequest req)
        {
             JsonResponseModel<DescribeInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the public IP quota of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressQuotaResponse"/></returns>
        public async Task<DescribeInternetAddressQuotaResponse> DescribeInternetAddressQuota(DescribeInternetAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeInternetAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternetAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the public IP quota of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressQuotaResponse"/></returns>
        public DescribeInternetAddressQuotaResponse DescribeInternetAddressQuotaSync(DescribeInternetAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeInternetAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternetAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the public IP address assignment statistics of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressStatisticsRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressStatisticsResponse"/></returns>
        public async Task<DescribeInternetAddressStatisticsResponse> DescribeInternetAddressStatistics(DescribeInternetAddressStatisticsRequest req)
        {
             JsonResponseModel<DescribeInternetAddressStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternetAddressStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetAddressStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the public IP address assignment statistics of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressStatisticsRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressStatisticsResponse"/></returns>
        public DescribeInternetAddressStatisticsResponse DescribeInternetAddressStatisticsSync(DescribeInternetAddressStatisticsRequest req)
        {
             JsonResponseModel<DescribeInternetAddressStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternetAddressStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetAddressStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a public IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DisableInternetAddressRequest"/></param>
        /// <returns><see cref="DisableInternetAddressResponse"/></returns>
        public async Task<DisableInternetAddressResponse> DisableInternetAddress(DisableInternetAddressRequest req)
        {
             JsonResponseModel<DisableInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a public IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DisableInternetAddressRequest"/></param>
        /// <returns><see cref="DisableInternetAddressResponse"/></returns>
        public DisableInternetAddressResponse DisableInternetAddressSync(DisableInternetAddressRequest req)
        {
             JsonResponseModel<DisableInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a public IP address for internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="EnableInternetAddressRequest"/></param>
        /// <returns><see cref="EnableInternetAddressResponse"/></returns>
        public async Task<EnableInternetAddressResponse> EnableInternetAddress(EnableInternetAddressRequest req)
        {
             JsonResponseModel<EnableInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a public IP address for internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="EnableInternetAddressRequest"/></param>
        /// <returns><see cref="EnableInternetAddressResponse"/></returns>
        public EnableInternetAddressResponse EnableInternetAddressSync(EnableInternetAddressRequest req)
        {
             JsonResponseModel<EnableInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify connection attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public async Task<ModifyDirectConnectAttributeResponse> ModifyDirectConnectAttribute(ModifyDirectConnectAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify connection attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public ModifyDirectConnectAttributeResponse ModifyDirectConnectAttributeSync(ModifyDirectConnectAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the dedicated tunnel attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public async Task<ModifyDirectConnectTunnelAttributeResponse> ModifyDirectConnectTunnelAttribute(ModifyDirectConnectTunnelAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectTunnelAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the dedicated tunnel attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public ModifyDirectConnectTunnelAttributeResponse ModifyDirectConnectTunnelAttributeSync(ModifyDirectConnectTunnelAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectTunnelAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reject an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public async Task<RejectDirectConnectTunnelResponse> RejectDirectConnectTunnel(RejectDirectConnectTunnelRequest req)
        {
             JsonResponseModel<RejectDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reject an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public RejectDirectConnectTunnelResponse RejectDirectConnectTunnelSync(RejectDirectConnectTunnelRequest req)
        {
             JsonResponseModel<RejectDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RejectDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release an IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="ReleaseInternetAddressRequest"/></param>
        /// <returns><see cref="ReleaseInternetAddressResponse"/></returns>
        public async Task<ReleaseInternetAddressResponse> ReleaseInternetAddress(ReleaseInternetAddressRequest req)
        {
             JsonResponseModel<ReleaseInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release an IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="ReleaseInternetAddressRequest"/></param>
        /// <returns><see cref="ReleaseInternetAddressResponse"/></returns>
        public ReleaseInternetAddressResponse ReleaseInternetAddressSync(ReleaseInternetAddressRequest req)
        {
             JsonResponseModel<ReleaseInternetAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseInternetAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseInternetAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
