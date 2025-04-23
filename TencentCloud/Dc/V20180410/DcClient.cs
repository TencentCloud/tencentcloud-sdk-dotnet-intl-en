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

       private const string endpoint = "dc.intl.tencentcloudapi.com";
       private const string version = "2018-04-10";
       private const string sdkVersion = "SDK_NET_3.0.1116";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to accept an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public Task<AcceptDirectConnectTunnelResponse> AcceptDirectConnectTunnel(AcceptDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<AcceptDirectConnectTunnelResponse>(req, "AcceptDirectConnectTunnel");
        }

        /// <summary>
        /// This API is used to accept an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public AcceptDirectConnectTunnelResponse AcceptDirectConnectTunnelSync(AcceptDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<AcceptDirectConnectTunnelResponse>(req, "AcceptDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for an internet tunnel’s CIDR block.
        /// </summary>
        /// <param name="req"><see cref="ApplyInternetAddressRequest"/></param>
        /// <returns><see cref="ApplyInternetAddressResponse"/></returns>
        public Task<ApplyInternetAddressResponse> ApplyInternetAddress(ApplyInternetAddressRequest req)
        {
            return InternalRequestAsync<ApplyInternetAddressResponse>(req, "ApplyInternetAddress");
        }

        /// <summary>
        /// This API is used to apply for an internet tunnel’s CIDR block.
        /// </summary>
        /// <param name="req"><see cref="ApplyInternetAddressRequest"/></param>
        /// <returns><see cref="ApplyInternetAddressResponse"/></returns>
        public ApplyInternetAddressResponse ApplyInternetAddressSync(ApplyInternetAddressRequest req)
        {
            return InternalRequestAsync<ApplyInternetAddressResponse>(req, "ApplyInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for a connection.
        /// When calling this API, please note that:
        /// You need to complete identity verification for your account; otherwise, you cannot apply for a connection;
        /// If there is any connection in arrears under your account, you cannot apply for more connections.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectRequest"/></param>
        /// <returns><see cref="CreateDirectConnectResponse"/></returns>
        public Task<CreateDirectConnectResponse> CreateDirectConnect(CreateDirectConnectRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectResponse>(req, "CreateDirectConnect");
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
            return InternalRequestAsync<CreateDirectConnectResponse>(req, "CreateDirectConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public Task<CreateDirectConnectTunnelResponse> CreateDirectConnectTunnel(CreateDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectTunnelResponse>(req, "CreateDirectConnectTunnel");
        }

        /// <summary>
        /// This API is used to create a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public CreateDirectConnectTunnelResponse CreateDirectConnectTunnelSync(CreateDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectTunnelResponse>(req, "CreateDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a connection.
        /// Only connected connections can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public Task<DeleteDirectConnectResponse> DeleteDirectConnect(DeleteDirectConnectRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectResponse>(req, "DeleteDirectConnect");
        }

        /// <summary>
        /// This API is used to delete a connection.
        /// Only connected connections can be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public DeleteDirectConnectResponse DeleteDirectConnectSync(DeleteDirectConnectRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectResponse>(req, "DeleteDirectConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public Task<DeleteDirectConnectTunnelResponse> DeleteDirectConnectTunnel(DeleteDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectTunnelResponse>(req, "DeleteDirectConnectTunnel");
        }

        /// <summary>
        /// This API is used to delete a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public DeleteDirectConnectTunnelResponse DeleteDirectConnectTunnelSync(DeleteDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectTunnelResponse>(req, "DeleteDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query connection access points.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public Task<DescribeAccessPointsResponse> DescribeAccessPoints(DescribeAccessPointsRequest req)
        {
            return InternalRequestAsync<DescribeAccessPointsResponse>(req, "DescribeAccessPoints");
        }

        /// <summary>
        /// This API is used to query connection access points.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public DescribeAccessPointsResponse DescribeAccessPointsSync(DescribeAccessPointsRequest req)
        {
            return InternalRequestAsync<DescribeAccessPointsResponse>(req, "DescribeAccessPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of dedicated tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public Task<DescribeDirectConnectTunnelsResponse> DescribeDirectConnectTunnels(DescribeDirectConnectTunnelsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectTunnelsResponse>(req, "DescribeDirectConnectTunnels");
        }

        /// <summary>
        /// This API is used to query the list of dedicated tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public DescribeDirectConnectTunnelsResponse DescribeDirectConnectTunnelsSync(DescribeDirectConnectTunnelsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectTunnelsResponse>(req, "DescribeDirectConnectTunnels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public Task<DescribeDirectConnectsResponse> DescribeDirectConnects(DescribeDirectConnectsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectsResponse>(req, "DescribeDirectConnects");
        }

        /// <summary>
        /// This API is used to query the list of connections.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public DescribeDirectConnectsResponse DescribeDirectConnectsSync(DescribeDirectConnectsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectsResponse>(req, "DescribeDirectConnects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the public IP address of an internet tunnel.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressResponse"/></returns>
        public Task<DescribeInternetAddressResponse> DescribeInternetAddress(DescribeInternetAddressRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressResponse>(req, "DescribeInternetAddress");
        }

        /// <summary>
        /// This API is used to obtain the public IP address of an internet tunnel.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressResponse"/></returns>
        public DescribeInternetAddressResponse DescribeInternetAddressSync(DescribeInternetAddressRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressResponse>(req, "DescribeInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the public IP quota of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressQuotaResponse"/></returns>
        public Task<DescribeInternetAddressQuotaResponse> DescribeInternetAddressQuota(DescribeInternetAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressQuotaResponse>(req, "DescribeInternetAddressQuota");
        }

        /// <summary>
        /// This API is used to obtain the public IP quota of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressQuotaResponse"/></returns>
        public DescribeInternetAddressQuotaResponse DescribeInternetAddressQuotaSync(DescribeInternetAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressQuotaResponse>(req, "DescribeInternetAddressQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the public IP address assignment statistics of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressStatisticsRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressStatisticsResponse"/></returns>
        public Task<DescribeInternetAddressStatisticsResponse> DescribeInternetAddressStatistics(DescribeInternetAddressStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressStatisticsResponse>(req, "DescribeInternetAddressStatistics");
        }

        /// <summary>
        /// This API is used to obtain the public IP address assignment statistics of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressStatisticsRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressStatisticsResponse"/></returns>
        public DescribeInternetAddressStatisticsResponse DescribeInternetAddressStatisticsSync(DescribeInternetAddressStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressStatisticsResponse>(req, "DescribeInternetAddressStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a public IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DisableInternetAddressRequest"/></param>
        /// <returns><see cref="DisableInternetAddressResponse"/></returns>
        public Task<DisableInternetAddressResponse> DisableInternetAddress(DisableInternetAddressRequest req)
        {
            return InternalRequestAsync<DisableInternetAddressResponse>(req, "DisableInternetAddress");
        }

        /// <summary>
        /// This API is used to disable a public IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="DisableInternetAddressRequest"/></param>
        /// <returns><see cref="DisableInternetAddressResponse"/></returns>
        public DisableInternetAddressResponse DisableInternetAddressSync(DisableInternetAddressRequest req)
        {
            return InternalRequestAsync<DisableInternetAddressResponse>(req, "DisableInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a public IP address for internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="EnableInternetAddressRequest"/></param>
        /// <returns><see cref="EnableInternetAddressResponse"/></returns>
        public Task<EnableInternetAddressResponse> EnableInternetAddress(EnableInternetAddressRequest req)
        {
            return InternalRequestAsync<EnableInternetAddressResponse>(req, "EnableInternetAddress");
        }

        /// <summary>
        /// This API is used to enable a public IP address for internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="EnableInternetAddressRequest"/></param>
        /// <returns><see cref="EnableInternetAddressResponse"/></returns>
        public EnableInternetAddressResponse EnableInternetAddressSync(EnableInternetAddressRequest req)
        {
            return InternalRequestAsync<EnableInternetAddressResponse>(req, "EnableInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify connection attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public Task<ModifyDirectConnectAttributeResponse> ModifyDirectConnectAttribute(ModifyDirectConnectAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectAttributeResponse>(req, "ModifyDirectConnectAttribute");
        }

        /// <summary>
        /// This API is used to modify connection attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public ModifyDirectConnectAttributeResponse ModifyDirectConnectAttributeSync(ModifyDirectConnectAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectAttributeResponse>(req, "ModifyDirectConnectAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the dedicated tunnel attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public Task<ModifyDirectConnectTunnelAttributeResponse> ModifyDirectConnectTunnelAttribute(ModifyDirectConnectTunnelAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectTunnelAttributeResponse>(req, "ModifyDirectConnectTunnelAttribute");
        }

        /// <summary>
        /// This API is used to modify the dedicated tunnel attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public ModifyDirectConnectTunnelAttributeResponse ModifyDirectConnectTunnelAttributeSync(ModifyDirectConnectTunnelAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectTunnelAttributeResponse>(req, "ModifyDirectConnectTunnelAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reject an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public Task<RejectDirectConnectTunnelResponse> RejectDirectConnectTunnel(RejectDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<RejectDirectConnectTunnelResponse>(req, "RejectDirectConnectTunnel");
        }

        /// <summary>
        /// This API is used to reject an application for a dedicated tunnel.
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public RejectDirectConnectTunnelResponse RejectDirectConnectTunnelSync(RejectDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<RejectDirectConnectTunnelResponse>(req, "RejectDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release an IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="ReleaseInternetAddressRequest"/></param>
        /// <returns><see cref="ReleaseInternetAddressResponse"/></returns>
        public Task<ReleaseInternetAddressResponse> ReleaseInternetAddress(ReleaseInternetAddressRequest req)
        {
            return InternalRequestAsync<ReleaseInternetAddressResponse>(req, "ReleaseInternetAddress");
        }

        /// <summary>
        /// This API is used to release an IP address of internet tunnels.
        /// </summary>
        /// <param name="req"><see cref="ReleaseInternetAddressRequest"/></param>
        /// <returns><see cref="ReleaseInternetAddressResponse"/></returns>
        public ReleaseInternetAddressResponse ReleaseInternetAddressSync(ReleaseInternetAddressRequest req)
        {
            return InternalRequestAsync<ReleaseInternetAddressResponse>(req, "ReleaseInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
