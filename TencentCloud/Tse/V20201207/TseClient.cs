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

namespace TencentCloud.Tse.V20201207
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tse.V20201207.Models;

   public class TseClient : AbstractClient{

       private const string endpoint = "tse.intl.tencentcloudapi.com";
       private const string version = "2020-12-07";
       private const string sdkVersion = "SDK_NET_3.0.1307";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Bind auto scaling policies to gateway groupings in batch
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalerResourceStrategyToGroupsRequest"/></param>
        /// <returns><see cref="BindAutoScalerResourceStrategyToGroupsResponse"/></returns>
        public Task<BindAutoScalerResourceStrategyToGroupsResponse> BindAutoScalerResourceStrategyToGroups(BindAutoScalerResourceStrategyToGroupsRequest req)
        {
            return InternalRequestAsync<BindAutoScalerResourceStrategyToGroupsResponse>(req, "BindAutoScalerResourceStrategyToGroups");
        }

        /// <summary>
        /// Bind auto scaling policies to gateway groupings in batch
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalerResourceStrategyToGroupsRequest"/></param>
        /// <returns><see cref="BindAutoScalerResourceStrategyToGroupsResponse"/></returns>
        public BindAutoScalerResourceStrategyToGroupsResponse BindAutoScalerResourceStrategyToGroupsSync(BindAutoScalerResourceStrategyToGroupsRequest req)
        {
            return InternalRequestAsync<BindAutoScalerResourceStrategyToGroupsResponse>(req, "BindAutoScalerResourceStrategyToGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disables WAF protection
        /// </summary>
        /// <param name="req"><see cref="CloseWafProtectionRequest"/></param>
        /// <returns><see cref="CloseWafProtectionResponse"/></returns>
        public Task<CloseWafProtectionResponse> CloseWafProtection(CloseWafProtectionRequest req)
        {
            return InternalRequestAsync<CloseWafProtectionResponse>(req, "CloseWafProtection");
        }

        /// <summary>
        /// Disables WAF protection
        /// </summary>
        /// <param name="req"><see cref="CloseWafProtectionRequest"/></param>
        /// <returns><see cref="CloseWafProtectionResponse"/></returns>
        public CloseWafProtectionResponse CloseWafProtectionSync(CloseWafProtectionRequest req)
        {
            return InternalRequestAsync<CloseWafProtectionResponse>(req, "CloseWafProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create AS policy
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="CreateAutoScalerResourceStrategyResponse"/></returns>
        public Task<CreateAutoScalerResourceStrategyResponse> CreateAutoScalerResourceStrategy(CreateAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<CreateAutoScalerResourceStrategyResponse>(req, "CreateAutoScalerResourceStrategy");
        }

        /// <summary>
        /// Create AS policy
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="CreateAutoScalerResourceStrategyResponse"/></returns>
        public CreateAutoScalerResourceStrategyResponse CreateAutoScalerResourceStrategySync(CreateAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<CreateAutoScalerResourceStrategyResponse>(req, "CreateAutoScalerResourceStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayResponse> CreateCloudNativeAPIGateway(CreateCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayResponse>(req, "CreateCloudNativeAPIGateway");
        }

        /// <summary>
        /// Create a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayResponse"/></returns>
        public CreateCloudNativeAPIGatewayResponse CreateCloudNativeAPIGatewaySync(CreateCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayResponse>(req, "CreateCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a grayscale rule for the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayCanaryRuleResponse> CreateCloudNativeAPIGatewayCanaryRule(CreateCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCanaryRuleResponse>(req, "CreateCloudNativeAPIGatewayCanaryRule");
        }

        /// <summary>
        /// Create a grayscale rule for the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public CreateCloudNativeAPIGatewayCanaryRuleResponse CreateCloudNativeAPIGatewayCanaryRuleSync(CreateCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCanaryRuleResponse>(req, "CreateCloudNativeAPIGatewayCanaryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud-native gateway certificate
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCertificateResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayCertificateResponse> CreateCloudNativeAPIGatewayCertificate(CreateCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCertificateResponse>(req, "CreateCloudNativeAPIGatewayCertificate");
        }

        /// <summary>
        /// This API is used to create a cloud-native gateway certificate
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCertificateResponse"/></returns>
        public CreateCloudNativeAPIGatewayCertificateResponse CreateCloudNativeAPIGatewayCertificateSync(CreateCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCertificateResponse>(req, "CreateCloudNativeAPIGatewayCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a public network configuration
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayPublicNetworkResponse> CreateCloudNativeAPIGatewayPublicNetwork(CreateCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayPublicNetworkResponse>(req, "CreateCloudNativeAPIGatewayPublicNetwork");
        }

        /// <summary>
        /// Create a public network configuration
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public CreateCloudNativeAPIGatewayPublicNetworkResponse CreateCloudNativeAPIGatewayPublicNetworkSync(CreateCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayPublicNetworkResponse>(req, "CreateCloudNativeAPIGatewayPublicNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud-native gateway route.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayRouteResponse> CreateCloudNativeAPIGatewayRoute(CreateCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteResponse>(req, "CreateCloudNativeAPIGatewayRoute");
        }

        /// <summary>
        /// This API is used to create a cloud-native gateway route.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteResponse"/></returns>
        public CreateCloudNativeAPIGatewayRouteResponse CreateCloudNativeAPIGatewayRouteSync(CreateCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteResponse>(req, "CreateCloudNativeAPIGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud-native gateway traffic throttling plugin.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayRouteRateLimitResponse> CreateCloudNativeAPIGatewayRouteRateLimit(CreateCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteRateLimitResponse>(req, "CreateCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// This API is used to create a cloud-native gateway traffic throttling plugin.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public CreateCloudNativeAPIGatewayRouteRateLimitResponse CreateCloudNativeAPIGatewayRouteRateLimitSync(CreateCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteRateLimitResponse>(req, "CreateCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a cloud-native gateway service
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayServiceResponse> CreateCloudNativeAPIGatewayService(CreateCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceResponse>(req, "CreateCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// Create a cloud-native gateway service
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceResponse"/></returns>
        public CreateCloudNativeAPIGatewayServiceResponse CreateCloudNativeAPIGatewayServiceSync(CreateCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceResponse>(req, "CreateCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a traffic throttling plugin for a cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayServiceRateLimitResponse> CreateCloudNativeAPIGatewayServiceRateLimit(CreateCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceRateLimitResponse>(req, "CreateCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// This API is used to create a traffic throttling plugin for a cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public CreateCloudNativeAPIGatewayServiceRateLimitResponse CreateCloudNativeAPIGatewayServiceRateLimitSync(CreateCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceRateLimitResponse>(req, "CreateCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a lane group
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="CreateGovernanceLaneGroupsResponse"/></returns>
        public Task<CreateGovernanceLaneGroupsResponse> CreateGovernanceLaneGroups(CreateGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<CreateGovernanceLaneGroupsResponse>(req, "CreateGovernanceLaneGroups");
        }

        /// <summary>
        /// Create a lane group
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="CreateGovernanceLaneGroupsResponse"/></returns>
        public CreateGovernanceLaneGroupsResponse CreateGovernanceLaneGroupsSync(CreateGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<CreateGovernanceLaneGroupsResponse>(req, "CreateGovernanceLaneGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Cloud Native Gateway Engine group
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServerGroupResponse"/></returns>
        public Task<CreateNativeGatewayServerGroupResponse> CreateNativeGatewayServerGroup(CreateNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<CreateNativeGatewayServerGroupResponse>(req, "CreateNativeGatewayServerGroup");
        }

        /// <summary>
        /// Create a Cloud Native Gateway Engine group
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServerGroupResponse"/></returns>
        public CreateNativeGatewayServerGroupResponse CreateNativeGatewayServerGroupSync(CreateNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<CreateNativeGatewayServerGroupResponse>(req, "CreateNativeGatewayServerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a gateway service source
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServiceSourceRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServiceSourceResponse"/></returns>
        public Task<CreateNativeGatewayServiceSourceResponse> CreateNativeGatewayServiceSource(CreateNativeGatewayServiceSourceRequest req)
        {
            return InternalRequestAsync<CreateNativeGatewayServiceSourceResponse>(req, "CreateNativeGatewayServiceSource");
        }

        /// <summary>
        /// Create a gateway service source
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServiceSourceRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServiceSourceResponse"/></returns>
        public CreateNativeGatewayServiceSourceResponse CreateNativeGatewayServiceSourceSync(CreateNativeGatewayServiceSourceRequest req)
        {
            return InternalRequestAsync<CreateNativeGatewayServiceSourceResponse>(req, "CreateNativeGatewayServiceSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or edit a cloud-native gateway cross-domain configuration
        /// </summary>
        /// <param name="req"><see cref="CreateOrModifyCloudNativeAPIGatewayCORSRequest"/></param>
        /// <returns><see cref="CreateOrModifyCloudNativeAPIGatewayCORSResponse"/></returns>
        public Task<CreateOrModifyCloudNativeAPIGatewayCORSResponse> CreateOrModifyCloudNativeAPIGatewayCORS(CreateOrModifyCloudNativeAPIGatewayCORSRequest req)
        {
            return InternalRequestAsync<CreateOrModifyCloudNativeAPIGatewayCORSResponse>(req, "CreateOrModifyCloudNativeAPIGatewayCORS");
        }

        /// <summary>
        /// Create or edit a cloud-native gateway cross-domain configuration
        /// </summary>
        /// <param name="req"><see cref="CreateOrModifyCloudNativeAPIGatewayCORSRequest"/></param>
        /// <returns><see cref="CreateOrModifyCloudNativeAPIGatewayCORSResponse"/></returns>
        public CreateOrModifyCloudNativeAPIGatewayCORSResponse CreateOrModifyCloudNativeAPIGatewayCORSSync(CreateOrModifyCloudNativeAPIGatewayCORSRequest req)
        {
            return InternalRequestAsync<CreateOrModifyCloudNativeAPIGatewayCORSResponse>(req, "CreateOrModifyCloudNativeAPIGatewayCORS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a WAF-protected domain name
        /// </summary>
        /// <param name="req"><see cref="CreateWafDomainsRequest"/></param>
        /// <returns><see cref="CreateWafDomainsResponse"/></returns>
        public Task<CreateWafDomainsResponse> CreateWafDomains(CreateWafDomainsRequest req)
        {
            return InternalRequestAsync<CreateWafDomainsResponse>(req, "CreateWafDomains");
        }

        /// <summary>
        /// Create a WAF-protected domain name
        /// </summary>
        /// <param name="req"><see cref="CreateWafDomainsRequest"/></param>
        /// <returns><see cref="CreateWafDomainsResponse"/></returns>
        public CreateWafDomainsResponse CreateWafDomainsSync(CreateWafDomainsRequest req)
        {
            return InternalRequestAsync<CreateWafDomainsResponse>(req, "CreateWafDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete AS policy
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScalerResourceStrategyResponse"/></returns>
        public Task<DeleteAutoScalerResourceStrategyResponse> DeleteAutoScalerResourceStrategy(DeleteAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalerResourceStrategyResponse>(req, "DeleteAutoScalerResourceStrategy");
        }

        /// <summary>
        /// Delete AS policy
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScalerResourceStrategyResponse"/></returns>
        public DeleteAutoScalerResourceStrategyResponse DeleteAutoScalerResourceStrategySync(DeleteAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalerResourceStrategyResponse>(req, "DeleteAutoScalerResourceStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayResponse> DeleteCloudNativeAPIGateway(DeleteCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayResponse>(req, "DeleteCloudNativeAPIGateway");
        }

        /// <summary>
        /// Delete a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayResponse"/></returns>
        public DeleteCloudNativeAPIGatewayResponse DeleteCloudNativeAPIGatewaySync(DeleteCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayResponse>(req, "DeleteCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cloud-native gateway cross-domain plug-in.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCORSRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCORSResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayCORSResponse> DeleteCloudNativeAPIGatewayCORS(DeleteCloudNativeAPIGatewayCORSRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCORSResponse>(req, "DeleteCloudNativeAPIGatewayCORS");
        }

        /// <summary>
        /// This API is used to delete a cloud-native gateway cross-domain plug-in.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCORSRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCORSResponse"/></returns>
        public DeleteCloudNativeAPIGatewayCORSResponse DeleteCloudNativeAPIGatewayCORSSync(DeleteCloudNativeAPIGatewayCORSRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCORSResponse>(req, "DeleteCloudNativeAPIGatewayCORS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the grayscale rule of the cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayCanaryRuleResponse> DeleteCloudNativeAPIGatewayCanaryRule(DeleteCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCanaryRuleResponse>(req, "DeleteCloudNativeAPIGatewayCanaryRule");
        }

        /// <summary>
        /// This API is used to delete the grayscale rule of the cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public DeleteCloudNativeAPIGatewayCanaryRuleResponse DeleteCloudNativeAPIGatewayCanaryRuleSync(DeleteCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCanaryRuleResponse>(req, "DeleteCloudNativeAPIGatewayCanaryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cloud-native gateway cert.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCertificateResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayCertificateResponse> DeleteCloudNativeAPIGatewayCertificate(DeleteCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCertificateResponse>(req, "DeleteCloudNativeAPIGatewayCertificate");
        }

        /// <summary>
        /// This API is used to delete a cloud-native gateway cert.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCertificateResponse"/></returns>
        public DeleteCloudNativeAPIGatewayCertificateResponse DeleteCloudNativeAPIGatewayCertificateSync(DeleteCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCertificateResponse>(req, "DeleteCloudNativeAPIGatewayCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete public network configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayPublicNetworkResponse> DeleteCloudNativeAPIGatewayPublicNetwork(DeleteCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayPublicNetworkResponse>(req, "DeleteCloudNativeAPIGatewayPublicNetwork");
        }

        /// <summary>
        /// Delete public network configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public DeleteCloudNativeAPIGatewayPublicNetworkResponse DeleteCloudNativeAPIGatewayPublicNetworkSync(DeleteCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayPublicNetworkResponse>(req, "DeleteCloudNativeAPIGatewayPublicNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a cloud-native gateway route
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayRouteResponse> DeleteCloudNativeAPIGatewayRoute(DeleteCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteResponse>(req, "DeleteCloudNativeAPIGatewayRoute");
        }

        /// <summary>
        /// Delete a cloud-native gateway route
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteResponse"/></returns>
        public DeleteCloudNativeAPIGatewayRouteResponse DeleteCloudNativeAPIGatewayRouteSync(DeleteCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteResponse>(req, "DeleteCloudNativeAPIGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a traffic throttling plugin of a cloud-native gateway (Route).
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayRouteRateLimitResponse> DeleteCloudNativeAPIGatewayRouteRateLimit(DeleteCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// This API is used to delete a traffic throttling plugin of a cloud-native gateway (Route).
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public DeleteCloudNativeAPIGatewayRouteRateLimitResponse DeleteCloudNativeAPIGatewayRouteRateLimitSync(DeleteCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cloud-native gateway service.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayServiceResponse> DeleteCloudNativeAPIGatewayService(DeleteCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceResponse>(req, "DeleteCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// This API is used to delete a cloud-native gateway service.
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceResponse"/></returns>
        public DeleteCloudNativeAPIGatewayServiceResponse DeleteCloudNativeAPIGatewayServiceSync(DeleteCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceResponse>(req, "DeleteCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the traffic throttling plugin of a cloud-native gateway (Service).
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayServiceRateLimitResponse> DeleteCloudNativeAPIGatewayServiceRateLimit(DeleteCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// This API is used to delete the traffic throttling plugin of a cloud-native gateway (Service).
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public DeleteCloudNativeAPIGatewayServiceRateLimitResponse DeleteCloudNativeAPIGatewayServiceRateLimitSync(DeleteCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a lane group
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="DeleteGovernanceLaneGroupsResponse"/></returns>
        public Task<DeleteGovernanceLaneGroupsResponse> DeleteGovernanceLaneGroups(DeleteGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceLaneGroupsResponse>(req, "DeleteGovernanceLaneGroups");
        }

        /// <summary>
        /// Delete a lane group
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="DeleteGovernanceLaneGroupsResponse"/></returns>
        public DeleteGovernanceLaneGroupsResponse DeleteGovernanceLaneGroupsSync(DeleteGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceLaneGroupsResponse>(req, "DeleteGovernanceLaneGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Gateway Instance Group
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServerGroupResponse"/></returns>
        public Task<DeleteNativeGatewayServerGroupResponse> DeleteNativeGatewayServerGroup(DeleteNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<DeleteNativeGatewayServerGroupResponse>(req, "DeleteNativeGatewayServerGroup");
        }

        /// <summary>
        /// Delete a Gateway Instance Group
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServerGroupResponse"/></returns>
        public DeleteNativeGatewayServerGroupResponse DeleteNativeGatewayServerGroupSync(DeleteNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<DeleteNativeGatewayServerGroupResponse>(req, "DeleteNativeGatewayServerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a gateway service source instance
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServiceSourceRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServiceSourceResponse"/></returns>
        public Task<DeleteNativeGatewayServiceSourceResponse> DeleteNativeGatewayServiceSource(DeleteNativeGatewayServiceSourceRequest req)
        {
            return InternalRequestAsync<DeleteNativeGatewayServiceSourceResponse>(req, "DeleteNativeGatewayServiceSource");
        }

        /// <summary>
        /// Delete a gateway service source instance
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServiceSourceRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServiceSourceResponse"/></returns>
        public DeleteNativeGatewayServiceSourceResponse DeleteNativeGatewayServiceSourceSync(DeleteNativeGatewayServiceSourceRequest req)
        {
            return InternalRequestAsync<DeleteNativeGatewayServiceSourceResponse>(req, "DeleteNativeGatewayServiceSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a WAF-protected domain name
        /// </summary>
        /// <param name="req"><see cref="DeleteWafDomainsRequest"/></param>
        /// <returns><see cref="DeleteWafDomainsResponse"/></returns>
        public Task<DeleteWafDomainsResponse> DeleteWafDomains(DeleteWafDomainsRequest req)
        {
            return InternalRequestAsync<DeleteWafDomainsResponse>(req, "DeleteWafDomains");
        }

        /// <summary>
        /// Delete a WAF-protected domain name
        /// </summary>
        /// <param name="req"><see cref="DeleteWafDomainsRequest"/></param>
        /// <returns><see cref="DeleteWafDomainsResponse"/></returns>
        public DeleteWafDomainsResponse DeleteWafDomainsSync(DeleteWafDomainsRequest req)
        {
            return InternalRequestAsync<DeleteWafDomainsResponse>(req, "DeleteWafDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View AS policy list
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategiesResponse"/></returns>
        public Task<DescribeAutoScalerResourceStrategiesResponse> DescribeAutoScalerResourceStrategies(DescribeAutoScalerResourceStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategiesResponse>(req, "DescribeAutoScalerResourceStrategies");
        }

        /// <summary>
        /// View AS policy list
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategiesResponse"/></returns>
        public DescribeAutoScalerResourceStrategiesResponse DescribeAutoScalerResourceStrategiesSync(DescribeAutoScalerResourceStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategiesResponse>(req, "DescribeAutoScalerResourceStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View gateway groupings bound to an auto scaling policy
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategyBindingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategyBindingGroupsResponse"/></returns>
        public Task<DescribeAutoScalerResourceStrategyBindingGroupsResponse> DescribeAutoScalerResourceStrategyBindingGroups(DescribeAutoScalerResourceStrategyBindingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategyBindingGroupsResponse>(req, "DescribeAutoScalerResourceStrategyBindingGroups");
        }

        /// <summary>
        /// View gateway groupings bound to an auto scaling policy
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategyBindingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategyBindingGroupsResponse"/></returns>
        public DescribeAutoScalerResourceStrategyBindingGroupsResponse DescribeAutoScalerResourceStrategyBindingGroupsSync(DescribeAutoScalerResourceStrategyBindingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategyBindingGroupsResponse>(req, "DescribeAutoScalerResourceStrategyBindingGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain cloud native API gateway instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayResponse> DescribeCloudNativeAPIGateway(DescribeCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayResponse>(req, "DescribeCloudNativeAPIGateway");
        }

        /// <summary>
        /// This API is used to obtain cloud native API gateway instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayResponse"/></returns>
        public DescribeCloudNativeAPIGatewayResponse DescribeCloudNativeAPIGatewaySync(DescribeCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayResponse>(req, "DescribeCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query cloud-native gateway cross-domain configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCORSRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCORSResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCORSResponse> DescribeCloudNativeAPIGatewayCORS(DescribeCloudNativeAPIGatewayCORSRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCORSResponse>(req, "DescribeCloudNativeAPIGatewayCORS");
        }

        /// <summary>
        /// Query cloud-native gateway cross-domain configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCORSRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCORSResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCORSResponse DescribeCloudNativeAPIGatewayCORSSync(DescribeCloudNativeAPIGatewayCORSRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCORSResponse>(req, "DescribeCloudNativeAPIGatewayCORS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the grayscale rule list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCanaryRulesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCanaryRulesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCanaryRulesResponse> DescribeCloudNativeAPIGatewayCanaryRules(DescribeCloudNativeAPIGatewayCanaryRulesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCanaryRulesResponse>(req, "DescribeCloudNativeAPIGatewayCanaryRules");
        }

        /// <summary>
        /// Query the grayscale rule list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCanaryRulesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCanaryRulesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCanaryRulesResponse DescribeCloudNativeAPIGatewayCanaryRulesSync(DescribeCloudNativeAPIGatewayCanaryRulesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCanaryRulesResponse>(req, "DescribeCloudNativeAPIGatewayCanaryRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the certificate detail of one cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCertificateDetailsResponse> DescribeCloudNativeAPIGatewayCertificateDetails(DescribeCloudNativeAPIGatewayCertificateDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificateDetailsResponse>(req, "DescribeCloudNativeAPIGatewayCertificateDetails");
        }

        /// <summary>
        /// Query the certificate detail of one cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCertificateDetailsResponse DescribeCloudNativeAPIGatewayCertificateDetailsSync(DescribeCloudNativeAPIGatewayCertificateDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificateDetailsResponse>(req, "DescribeCloudNativeAPIGatewayCertificateDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the certificate list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificatesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCertificatesResponse> DescribeCloudNativeAPIGatewayCertificates(DescribeCloudNativeAPIGatewayCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificatesResponse>(req, "DescribeCloudNativeAPIGatewayCertificates");
        }

        /// <summary>
        /// Query the certificate list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificatesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCertificatesResponse DescribeCloudNativeAPIGatewayCertificatesSync(DescribeCloudNativeAPIGatewayCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificatesResponse>(req, "DescribeCloudNativeAPIGatewayCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain cloud native API gateway instance network configuration information
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConfigRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConfigResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayConfigResponse> DescribeCloudNativeAPIGatewayConfig(DescribeCloudNativeAPIGatewayConfigRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConfigResponse>(req, "DescribeCloudNativeAPIGatewayConfig");
        }

        /// <summary>
        /// This API is used to obtain cloud native API gateway instance network configuration information
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConfigRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConfigResponse"/></returns>
        public DescribeCloudNativeAPIGatewayConfigResponse DescribeCloudNativeAPIGatewayConfigSync(DescribeCloudNativeAPIGatewayConfigRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConfigResponse>(req, "DescribeCloudNativeAPIGatewayConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query cloud native gateway instance information based on public IP address
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayInfoByIpRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayInfoByIpResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayInfoByIpResponse> DescribeCloudNativeAPIGatewayInfoByIp(DescribeCloudNativeAPIGatewayInfoByIpRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayInfoByIpResponse>(req, "DescribeCloudNativeAPIGatewayInfoByIp");
        }

        /// <summary>
        /// Query cloud native gateway instance information based on public IP address
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayInfoByIpRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayInfoByIpResponse"/></returns>
        public DescribeCloudNativeAPIGatewayInfoByIpResponse DescribeCloudNativeAPIGatewayInfoByIpSync(DescribeCloudNativeAPIGatewayInfoByIpRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayInfoByIpResponse>(req, "DescribeCloudNativeAPIGatewayInfoByIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a cloud-native gateway node list
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayNodesResponse> DescribeCloudNativeAPIGatewayNodes(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayNodesResponse>(req, "DescribeCloudNativeAPIGatewayNodes");
        }

        /// <summary>
        /// This API is used to get a cloud-native gateway node list
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayNodesResponse DescribeCloudNativeAPIGatewayNodesSync(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayNodesResponse>(req, "DescribeCloudNativeAPIGatewayNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve port information of a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayPortsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayPortsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayPortsResponse> DescribeCloudNativeAPIGatewayPorts(DescribeCloudNativeAPIGatewayPortsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayPortsResponse>(req, "DescribeCloudNativeAPIGatewayPorts");
        }

        /// <summary>
        /// Retrieve port information of a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayPortsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayPortsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayPortsResponse DescribeCloudNativeAPIGatewayPortsSync(DescribeCloudNativeAPIGatewayPortsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayPortsResponse>(req, "DescribeCloudNativeAPIGatewayPorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the traffic throttling plugin of a cloud-native gateway (Route).
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayRouteRateLimitResponse> DescribeCloudNativeAPIGatewayRouteRateLimit(DescribeCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// Query the traffic throttling plugin of a cloud-native gateway (Route).
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public DescribeCloudNativeAPIGatewayRouteRateLimitResponse DescribeCloudNativeAPIGatewayRouteRateLimitSync(DescribeCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the routing list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRoutesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayRoutesResponse> DescribeCloudNativeAPIGatewayRoutes(DescribeCloudNativeAPIGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRoutesResponse>(req, "DescribeCloudNativeAPIGatewayRoutes");
        }

        /// <summary>
        /// Query the routing list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRoutesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayRoutesResponse DescribeCloudNativeAPIGatewayRoutesSync(DescribeCloudNativeAPIGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRoutesResponse>(req, "DescribeCloudNativeAPIGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the traffic throttling plugin of a cloud-native gateway (Service).
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayServiceRateLimitResponse> DescribeCloudNativeAPIGatewayServiceRateLimit(DescribeCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// This API is used to query the traffic throttling plugin of a cloud-native gateway (Service).
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServiceRateLimitResponse DescribeCloudNativeAPIGatewayServiceRateLimitSync(DescribeCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the service list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayServicesResponse> DescribeCloudNativeAPIGatewayServices(DescribeCloudNativeAPIGatewayServicesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServicesResponse>(req, "DescribeCloudNativeAPIGatewayServices");
        }

        /// <summary>
        /// Query the service list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServicesResponse DescribeCloudNativeAPIGatewayServicesSync(DescribeCloudNativeAPIGatewayServicesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServicesResponse>(req, "DescribeCloudNativeAPIGatewayServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lightweight query the service list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesLightRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesLightResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayServicesLightResponse> DescribeCloudNativeAPIGatewayServicesLight(DescribeCloudNativeAPIGatewayServicesLightRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServicesLightResponse>(req, "DescribeCloudNativeAPIGatewayServicesLight");
        }

        /// <summary>
        /// Lightweight query the service list of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesLightRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesLightResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServicesLightResponse DescribeCloudNativeAPIGatewayServicesLightSync(DescribeCloudNativeAPIGatewayServicesLightRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServicesLightResponse>(req, "DescribeCloudNativeAPIGatewayServicesLight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Upstream list in the service detail of a cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayUpstreamRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayUpstreamResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayUpstreamResponse> DescribeCloudNativeAPIGatewayUpstream(DescribeCloudNativeAPIGatewayUpstreamRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayUpstreamResponse>(req, "DescribeCloudNativeAPIGatewayUpstream");
        }

        /// <summary>
        /// This API is used to query the Upstream list in the service detail of a cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayUpstreamRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayUpstreamResponse"/></returns>
        public DescribeCloudNativeAPIGatewayUpstreamResponse DescribeCloudNativeAPIGatewayUpstreamSync(DescribeCloudNativeAPIGatewayUpstreamRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayUpstreamResponse>(req, "DescribeCloudNativeAPIGatewayUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cloud native API gateway instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaysResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewaysResponse> DescribeCloudNativeAPIGateways(DescribeCloudNativeAPIGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaysResponse>(req, "DescribeCloudNativeAPIGateways");
        }

        /// <summary>
        /// This API is used to obtain the cloud native API gateway instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaysResponse"/></returns>
        public DescribeCloudNativeAPIGatewaysResponse DescribeCloudNativeAPIGatewaysSync(DescribeCloudNativeAPIGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaysResponse>(req, "DescribeCloudNativeAPIGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query lane group list
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="DescribeGovernanceLaneGroupsResponse"/></returns>
        public Task<DescribeGovernanceLaneGroupsResponse> DescribeGovernanceLaneGroups(DescribeGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceLaneGroupsResponse>(req, "DescribeGovernanceLaneGroups");
        }

        /// <summary>
        /// Query lane group list
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="DescribeGovernanceLaneGroupsResponse"/></returns>
        public DescribeGovernanceLaneGroupsResponse DescribeGovernanceLaneGroupsSync(DescribeGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceLaneGroupsResponse>(req, "DescribeGovernanceLaneGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query cloud native gateway group information
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeGatewayServerGroupsRequest"/></param>
        /// <returns><see cref="DescribeNativeGatewayServerGroupsResponse"/></returns>
        public Task<DescribeNativeGatewayServerGroupsResponse> DescribeNativeGatewayServerGroups(DescribeNativeGatewayServerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeNativeGatewayServerGroupsResponse>(req, "DescribeNativeGatewayServerGroups");
        }

        /// <summary>
        /// Query cloud native gateway group information
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeGatewayServerGroupsRequest"/></param>
        /// <returns><see cref="DescribeNativeGatewayServerGroupsResponse"/></returns>
        public DescribeNativeGatewayServerGroupsResponse DescribeNativeGatewayServerGroupsSync(DescribeNativeGatewayServerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeNativeGatewayServerGroupsResponse>(req, "DescribeNativeGatewayServerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the instance list of the gateway service source
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeGatewayServiceSourcesRequest"/></param>
        /// <returns><see cref="DescribeNativeGatewayServiceSourcesResponse"/></returns>
        public Task<DescribeNativeGatewayServiceSourcesResponse> DescribeNativeGatewayServiceSources(DescribeNativeGatewayServiceSourcesRequest req)
        {
            return InternalRequestAsync<DescribeNativeGatewayServiceSourcesResponse>(req, "DescribeNativeGatewayServiceSources");
        }

        /// <summary>
        /// Query the instance list of the gateway service source
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeGatewayServiceSourcesRequest"/></param>
        /// <returns><see cref="DescribeNativeGatewayServiceSourcesResponse"/></returns>
        public DescribeNativeGatewayServiceSourcesResponse DescribeNativeGatewayServiceSourcesSync(DescribeNativeGatewayServiceSourcesRequest req)
        {
            return InternalRequestAsync<DescribeNativeGatewayServiceSourcesResponse>(req, "DescribeNativeGatewayServiceSources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the service detail of the cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeOneCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DescribeOneCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<DescribeOneCloudNativeAPIGatewayServiceResponse> DescribeOneCloudNativeAPIGatewayService(DescribeOneCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DescribeOneCloudNativeAPIGatewayServiceResponse>(req, "DescribeOneCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// This API is used to obtain the service detail of the cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeOneCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DescribeOneCloudNativeAPIGatewayServiceResponse"/></returns>
        public DescribeOneCloudNativeAPIGatewayServiceResponse DescribeOneCloudNativeAPIGatewayServiceSync(DescribeOneCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DescribeOneCloudNativeAPIGatewayServiceResponse>(req, "DescribeOneCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query public IP address info
        /// </summary>
        /// <param name="req"><see cref="DescribePublicAddressConfigRequest"/></param>
        /// <returns><see cref="DescribePublicAddressConfigResponse"/></returns>
        public Task<DescribePublicAddressConfigResponse> DescribePublicAddressConfig(DescribePublicAddressConfigRequest req)
        {
            return InternalRequestAsync<DescribePublicAddressConfigResponse>(req, "DescribePublicAddressConfig");
        }

        /// <summary>
        /// Query public IP address info
        /// </summary>
        /// <param name="req"><see cref="DescribePublicAddressConfigRequest"/></param>
        /// <returns><see cref="DescribePublicAddressConfigResponse"/></returns>
        public DescribePublicAddressConfigResponse DescribePublicAddressConfigSync(DescribePublicAddressConfigRequest req)
        {
            return InternalRequestAsync<DescribePublicAddressConfigResponse>(req, "DescribePublicAddressConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the public network details of a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkResponse"/></returns>
        public Task<DescribePublicNetworkResponse> DescribePublicNetwork(DescribePublicNetworkRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkResponse>(req, "DescribePublicNetwork");
        }

        /// <summary>
        /// Query the public network details of a cloud native API gateway instance
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkResponse"/></returns>
        public DescribePublicNetworkResponse DescribePublicNetworkSync(DescribePublicNetworkRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkResponse>(req, "DescribePublicNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the health check configuration of the cloud-native gateway service.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="DescribeUpstreamHealthCheckConfigResponse"/></returns>
        public Task<DescribeUpstreamHealthCheckConfigResponse> DescribeUpstreamHealthCheckConfig(DescribeUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamHealthCheckConfigResponse>(req, "DescribeUpstreamHealthCheckConfig");
        }

        /// <summary>
        /// This API is used to obtain the health check configuration of the cloud-native gateway service.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="DescribeUpstreamHealthCheckConfigResponse"/></returns>
        public DescribeUpstreamHealthCheckConfigResponse DescribeUpstreamHealthCheckConfigSync(DescribeUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamHealthCheckConfigResponse>(req, "DescribeUpstreamHealthCheckConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query a WAF-protected domain name
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDomainsRequest"/></param>
        /// <returns><see cref="DescribeWafDomainsResponse"/></returns>
        public Task<DescribeWafDomainsResponse> DescribeWafDomains(DescribeWafDomainsRequest req)
        {
            return InternalRequestAsync<DescribeWafDomainsResponse>(req, "DescribeWafDomains");
        }

        /// <summary>
        /// Query a WAF-protected domain name
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDomainsRequest"/></param>
        /// <returns><see cref="DescribeWafDomainsResponse"/></returns>
        public DescribeWafDomainsResponse DescribeWafDomainsSync(DescribeWafDomainsRequest req)
        {
            return InternalRequestAsync<DescribeWafDomainsResponse>(req, "DescribeWafDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query WAF protection status
        /// </summary>
        /// <param name="req"><see cref="DescribeWafProtectionRequest"/></param>
        /// <returns><see cref="DescribeWafProtectionResponse"/></returns>
        public Task<DescribeWafProtectionResponse> DescribeWafProtection(DescribeWafProtectionRequest req)
        {
            return InternalRequestAsync<DescribeWafProtectionResponse>(req, "DescribeWafProtection");
        }

        /// <summary>
        /// Query WAF protection status
        /// </summary>
        /// <param name="req"><see cref="DescribeWafProtectionRequest"/></param>
        /// <returns><see cref="DescribeWafProtectionResponse"/></returns>
        public DescribeWafProtectionResponse DescribeWafProtectionSync(DescribeWafProtectionRequest req)
        {
            return InternalRequestAsync<DescribeWafProtectionResponse>(req, "DescribeWafProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update AS policy
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScalerResourceStrategyResponse"/></returns>
        public Task<ModifyAutoScalerResourceStrategyResponse> ModifyAutoScalerResourceStrategy(ModifyAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalerResourceStrategyResponse>(req, "ModifyAutoScalerResourceStrategy");
        }

        /// <summary>
        /// Update AS policy
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScalerResourceStrategyResponse"/></returns>
        public ModifyAutoScalerResourceStrategyResponse ModifyAutoScalerResourceStrategySync(ModifyAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalerResourceStrategyResponse>(req, "ModifyAutoScalerResourceStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the basic information of a cloud native API gateway instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayResponse> ModifyCloudNativeAPIGateway(ModifyCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayResponse>(req, "ModifyCloudNativeAPIGateway");
        }

        /// <summary>
        /// This API is used to modify the basic information of a cloud native API gateway instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayResponse"/></returns>
        public ModifyCloudNativeAPIGatewayResponse ModifyCloudNativeAPIGatewaySync(ModifyCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayResponse>(req, "ModifyCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the grayscale rule of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayCanaryRuleResponse> ModifyCloudNativeAPIGatewayCanaryRule(ModifyCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCanaryRuleResponse>(req, "ModifyCloudNativeAPIGatewayCanaryRule");
        }

        /// <summary>
        /// Modify the grayscale rule of the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public ModifyCloudNativeAPIGatewayCanaryRuleResponse ModifyCloudNativeAPIGatewayCanaryRuleSync(ModifyCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCanaryRuleResponse>(req, "ModifyCloudNativeAPIGatewayCanaryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the cloud-native gateway certificate
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCertificateResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayCertificateResponse> ModifyCloudNativeAPIGatewayCertificate(ModifyCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCertificateResponse>(req, "ModifyCloudNativeAPIGatewayCertificate");
        }

        /// <summary>
        /// Update the cloud-native gateway certificate
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCertificateResponse"/></returns>
        public ModifyCloudNativeAPIGatewayCertificateResponse ModifyCloudNativeAPIGatewayCertificateSync(ModifyCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCertificateResponse>(req, "ModifyCloudNativeAPIGatewayCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a cloud-native gateway route.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayRouteResponse> ModifyCloudNativeAPIGatewayRoute(ModifyCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteResponse>(req, "ModifyCloudNativeAPIGatewayRoute");
        }

        /// <summary>
        /// This API is used to modify a cloud-native gateway route.
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteResponse"/></returns>
        public ModifyCloudNativeAPIGatewayRouteResponse ModifyCloudNativeAPIGatewayRouteSync(ModifyCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteResponse>(req, "ModifyCloudNativeAPIGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the traffic throttling plugin of a cloud-native gateway (Route).
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayRouteRateLimitResponse> ModifyCloudNativeAPIGatewayRouteRateLimit(ModifyCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// This API is used to modify the traffic throttling plugin of a cloud-native gateway (Route).
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public ModifyCloudNativeAPIGatewayRouteRateLimitResponse ModifyCloudNativeAPIGatewayRouteRateLimitSync(ModifyCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a cloud-native gateway service
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayServiceResponse> ModifyCloudNativeAPIGatewayService(ModifyCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceResponse>(req, "ModifyCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// Modify a cloud-native gateway service
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceResponse"/></returns>
        public ModifyCloudNativeAPIGatewayServiceResponse ModifyCloudNativeAPIGatewayServiceSync(ModifyCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceResponse>(req, "ModifyCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the traffic throttling plugin of a cloud-native gateway (Service).
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayServiceRateLimitResponse> ModifyCloudNativeAPIGatewayServiceRateLimit(ModifyCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// This API is used to modify the traffic throttling plugin of a cloud-native gateway (Service).
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public ModifyCloudNativeAPIGatewayServiceRateLimitResponse ModifyCloudNativeAPIGatewayServiceRateLimitSync(ModifyCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the network configuration of the Konga gateway instance
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleNetworkRequest"/></param>
        /// <returns><see cref="ModifyConsoleNetworkResponse"/></returns>
        public Task<ModifyConsoleNetworkResponse> ModifyConsoleNetwork(ModifyConsoleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyConsoleNetworkResponse>(req, "ModifyConsoleNetwork");
        }

        /// <summary>
        /// Modify the network configuration of the Konga gateway instance
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleNetworkRequest"/></param>
        /// <returns><see cref="ModifyConsoleNetworkResponse"/></returns>
        public ModifyConsoleNetworkResponse ModifyConsoleNetworkSync(ModifyConsoleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyConsoleNetworkResponse>(req, "ModifyConsoleNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a lane group
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="ModifyGovernanceLaneGroupsResponse"/></returns>
        public Task<ModifyGovernanceLaneGroupsResponse> ModifyGovernanceLaneGroups(ModifyGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceLaneGroupsResponse>(req, "ModifyGovernanceLaneGroups");
        }

        /// <summary>
        /// Create a lane group
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceLaneGroupsRequest"/></param>
        /// <returns><see cref="ModifyGovernanceLaneGroupsResponse"/></returns>
        public ModifyGovernanceLaneGroupsResponse ModifyGovernanceLaneGroupsSync(ModifyGovernanceLaneGroupsRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceLaneGroupsResponse>(req, "ModifyGovernanceLaneGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the basic information of a cloud native API gateway instance group
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServerGroupResponse"/></returns>
        public Task<ModifyNativeGatewayServerGroupResponse> ModifyNativeGatewayServerGroup(ModifyNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<ModifyNativeGatewayServerGroupResponse>(req, "ModifyNativeGatewayServerGroup");
        }

        /// <summary>
        /// Modify the basic information of a cloud native API gateway instance group
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServerGroupResponse"/></returns>
        public ModifyNativeGatewayServerGroupResponse ModifyNativeGatewayServerGroupSync(ModifyNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<ModifyNativeGatewayServerGroupResponse>(req, "ModifyNativeGatewayServerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the gateway service source
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServiceSourceRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServiceSourceResponse"/></returns>
        public Task<ModifyNativeGatewayServiceSourceResponse> ModifyNativeGatewayServiceSource(ModifyNativeGatewayServiceSourceRequest req)
        {
            return InternalRequestAsync<ModifyNativeGatewayServiceSourceResponse>(req, "ModifyNativeGatewayServiceSource");
        }

        /// <summary>
        /// Modify the gateway service source
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServiceSourceRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServiceSourceResponse"/></returns>
        public ModifyNativeGatewayServiceSourceResponse ModifyNativeGatewayServiceSourceSync(ModifyNativeGatewayServiceSourceRequest req)
        {
            return InternalRequestAsync<ModifyNativeGatewayServiceSourceResponse>(req, "ModifyNativeGatewayServiceSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the access policy of the Kong cloud native API gateway instance to support allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAccessStrategyRequest"/></param>
        /// <returns><see cref="ModifyNetworkAccessStrategyResponse"/></returns>
        public Task<ModifyNetworkAccessStrategyResponse> ModifyNetworkAccessStrategy(ModifyNetworkAccessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAccessStrategyResponse>(req, "ModifyNetworkAccessStrategy");
        }

        /// <summary>
        /// Modify the access policy of the Kong cloud native API gateway instance to support allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAccessStrategyRequest"/></param>
        /// <returns><see cref="ModifyNetworkAccessStrategyResponse"/></returns>
        public ModifyNetworkAccessStrategyResponse ModifyNetworkAccessStrategySync(ModifyNetworkAccessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAccessStrategyResponse>(req, "ModifyNetworkAccessStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the basic information of a cloud native API gateway instance network, such as bandwidth and description, as well as specification upgrade. Only modification of client public network or private network information is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyNetworkBasicInfoResponse"/></returns>
        public Task<ModifyNetworkBasicInfoResponse> ModifyNetworkBasicInfo(ModifyNetworkBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyNetworkBasicInfoResponse>(req, "ModifyNetworkBasicInfo");
        }

        /// <summary>
        /// This API is used to modify the basic information of a cloud native API gateway instance network, such as bandwidth and description, as well as specification upgrade. Only modification of client public network or private network information is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyNetworkBasicInfoResponse"/></returns>
        public ModifyNetworkBasicInfoResponse ModifyNetworkBasicInfoSync(ModifyNetworkBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyNetworkBasicInfoResponse>(req, "ModifyNetworkBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the node health status of the upstream instance for the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyUpstreamNodeStatusResponse"/></returns>
        public Task<ModifyUpstreamNodeStatusResponse> ModifyUpstreamNodeStatus(ModifyUpstreamNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamNodeStatusResponse>(req, "ModifyUpstreamNodeStatus");
        }

        /// <summary>
        /// Modify the node health status of the upstream instance for the cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyUpstreamNodeStatusResponse"/></returns>
        public ModifyUpstreamNodeStatusResponse ModifyUpstreamNodeStatusSync(ModifyUpstreamNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamNodeStatusResponse>(req, "ModifyUpstreamNodeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable WAF protection
        /// </summary>
        /// <param name="req"><see cref="OpenWafProtectionRequest"/></param>
        /// <returns><see cref="OpenWafProtectionResponse"/></returns>
        public Task<OpenWafProtectionResponse> OpenWafProtection(OpenWafProtectionRequest req)
        {
            return InternalRequestAsync<OpenWafProtectionResponse>(req, "OpenWafProtection");
        }

        /// <summary>
        /// Enable WAF protection
        /// </summary>
        /// <param name="req"><see cref="OpenWafProtectionRequest"/></param>
        /// <returns><see cref="OpenWafProtectionResponse"/></returns>
        public OpenWafProtectionResponse OpenWafProtectionSync(OpenWafProtectionRequest req)
        {
            return InternalRequestAsync<OpenWafProtectionResponse>(req, "OpenWafProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Unbind gateway groupings in batch with auto scaling policy
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoScalerResourceStrategyFromGroupsRequest"/></param>
        /// <returns><see cref="UnbindAutoScalerResourceStrategyFromGroupsResponse"/></returns>
        public Task<UnbindAutoScalerResourceStrategyFromGroupsResponse> UnbindAutoScalerResourceStrategyFromGroups(UnbindAutoScalerResourceStrategyFromGroupsRequest req)
        {
            return InternalRequestAsync<UnbindAutoScalerResourceStrategyFromGroupsResponse>(req, "UnbindAutoScalerResourceStrategyFromGroups");
        }

        /// <summary>
        /// Unbind gateway groupings in batch with auto scaling policy
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoScalerResourceStrategyFromGroupsRequest"/></param>
        /// <returns><see cref="UnbindAutoScalerResourceStrategyFromGroupsResponse"/></returns>
        public UnbindAutoScalerResourceStrategyFromGroupsResponse UnbindAutoScalerResourceStrategyFromGroupsSync(UnbindAutoScalerResourceStrategyFromGroupsRequest req)
        {
            return InternalRequestAsync<UnbindAutoScalerResourceStrategyFromGroupsResponse>(req, "UnbindAutoScalerResourceStrategyFromGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the certificate information of a cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewayCertificateInfoRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewayCertificateInfoResponse"/></returns>
        public Task<UpdateCloudNativeAPIGatewayCertificateInfoResponse> UpdateCloudNativeAPIGatewayCertificateInfo(UpdateCloudNativeAPIGatewayCertificateInfoRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewayCertificateInfoResponse>(req, "UpdateCloudNativeAPIGatewayCertificateInfo");
        }

        /// <summary>
        /// Modify the certificate information of a cloud-native gateway
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewayCertificateInfoRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewayCertificateInfoResponse"/></returns>
        public UpdateCloudNativeAPIGatewayCertificateInfoResponse UpdateCloudNativeAPIGatewayCertificateInfoSync(UpdateCloudNativeAPIGatewayCertificateInfoRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewayCertificateInfoResponse>(req, "UpdateCloudNativeAPIGatewayCertificateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the node specification information of a cloud native API gateway instance, such as node scaling or specification adjustment
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewaySpecRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewaySpecResponse"/></returns>
        public Task<UpdateCloudNativeAPIGatewaySpecResponse> UpdateCloudNativeAPIGatewaySpec(UpdateCloudNativeAPIGatewaySpecRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewaySpecResponse>(req, "UpdateCloudNativeAPIGatewaySpec");
        }

        /// <summary>
        /// Modify the node specification information of a cloud native API gateway instance, such as node scaling or specification adjustment
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewaySpecRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewaySpecResponse"/></returns>
        public UpdateCloudNativeAPIGatewaySpecResponse UpdateCloudNativeAPIGatewaySpecSync(UpdateCloudNativeAPIGatewaySpecRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewaySpecResponse>(req, "UpdateCloudNativeAPIGatewaySpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the health check configuration of the cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="UpdateUpstreamHealthCheckConfigResponse"/></returns>
        public Task<UpdateUpstreamHealthCheckConfigResponse> UpdateUpstreamHealthCheckConfig(UpdateUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamHealthCheckConfigResponse>(req, "UpdateUpstreamHealthCheckConfig");
        }

        /// <summary>
        /// This API is used to update the health check configuration of the cloud-native gateway.
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="UpdateUpstreamHealthCheckConfigResponse"/></returns>
        public UpdateUpstreamHealthCheckConfigResponse UpdateUpstreamHealthCheckConfigSync(UpdateUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamHealthCheckConfigResponse>(req, "UpdateUpstreamHealthCheckConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refresh the upstream instance list of the gateway, only supported for the IPList service type
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamTargetsRequest"/></param>
        /// <returns><see cref="UpdateUpstreamTargetsResponse"/></returns>
        public Task<UpdateUpstreamTargetsResponse> UpdateUpstreamTargets(UpdateUpstreamTargetsRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamTargetsResponse>(req, "UpdateUpstreamTargets");
        }

        /// <summary>
        /// Refresh the upstream instance list of the gateway, only supported for the IPList service type
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamTargetsRequest"/></param>
        /// <returns><see cref="UpdateUpstreamTargetsResponse"/></returns>
        public UpdateUpstreamTargetsResponse UpdateUpstreamTargetsSync(UpdateUpstreamTargetsRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamTargetsResponse>(req, "UpdateUpstreamTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
