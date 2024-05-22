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

namespace TencentCloud.Antiddos.V20200309
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Antiddos.V20200309.Models;

   public class AntiddosClient : AbstractClient{

       private const string endpoint = "antiddos.tencentcloudapi.com";
       private const string version = "2020-03-09";
       private const string sdkVersion = "SDK_NET_3.0.903";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AntiddosClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind an EIP to an Anti-DDoS Advanced instance or a specified private IP of an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public Task<AssociateDDoSEipAddressResponse> AssociateDDoSEipAddress(AssociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipAddressResponse>(req, "AssociateDDoSEipAddress");
        }

        /// <summary>
        /// This API is used to bind an EIP to an Anti-DDoS Advanced instance or a specified private IP of an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public AssociateDDoSEipAddressResponse AssociateDDoSEipAddressSync(AssociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipAddressResponse>(req, "AssociateDDoSEipAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an Anti-DDoS EIP to the specified private IP of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public Task<AssociateDDoSEipLoadBalancerResponse> AssociateDDoSEipLoadBalancer(AssociateDDoSEipLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipLoadBalancerResponse>(req, "AssociateDDoSEipLoadBalancer");
        }

        /// <summary>
        /// This API is used to bind an Anti-DDoS EIP to the specified private IP of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public AssociateDDoSEipLoadBalancerResponse AssociateDDoSEipLoadBalancerSync(AssociateDDoSEipLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipLoadBalancerResponse>(req, "AssociateDDoSEipLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public Task<CreateBlackWhiteIpListResponse> CreateBlackWhiteIpList(CreateBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateBlackWhiteIpListResponse>(req, "CreateBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public CreateBlackWhiteIpListResponse CreateBlackWhiteIpListSync(CreateBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateBlackWhiteIpListResponse>(req, "CreateBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance Both single IP instances and multi-IP instances are available. Note that you should wait until the current binding or unbinding completes before using this async API for new operations.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP");
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance Both single IP instances and multi-IP instances are available. Note that you should wait until the current binding or unbinding completes before using this async API for new operations.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public Task<CreateCCPrecisionPolicyResponse> CreateCCPrecisionPolicy(CreateCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCPrecisionPolicyResponse>(req, "CreateCCPrecisionPolicy");
        }

        /// <summary>
        /// This API is used to create a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public CreateCCPrecisionPolicyResponse CreateCCPrecisionPolicySync(CreateCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCPrecisionPolicyResponse>(req, "CreateCCPrecisionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CC frequency limit policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public Task<CreateCCReqLimitPolicyResponse> CreateCCReqLimitPolicy(CreateCCReqLimitPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCReqLimitPolicyResponse>(req, "CreateCCReqLimitPolicy");
        }

        /// <summary>
        /// This API is used to create a CC frequency limit policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public CreateCCReqLimitPolicyResponse CreateCCReqLimitPolicySync(CreateCCReqLimitPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCReqLimitPolicyResponse>(req, "CreateCCReqLimitPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a layer 4 access control list to prevent CC attacks.
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public Task<CreateCcBlackWhiteIpListResponse> CreateCcBlackWhiteIpList(CreateCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateCcBlackWhiteIpListResponse>(req, "CreateCcBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to create a layer 4 access control list to prevent CC attacks.
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public CreateCcBlackWhiteIpListResponse CreateCcBlackWhiteIpListSync(CreateCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateCcBlackWhiteIpListResponse>(req, "CreateCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public Task<CreateCcGeoIPBlockConfigResponse> CreateCcGeoIPBlockConfig(CreateCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateCcGeoIPBlockConfigResponse>(req, "CreateCcGeoIPBlockConfig");
        }

        /// <summary>
        /// This API is used to create a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public CreateCcGeoIPBlockConfigResponse CreateCcGeoIPBlockConfigSync(CreateCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateCcGeoIPBlockConfigResponse>(req, "CreateCcGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public Task<CreateDDoSAIResponse> CreateDDoSAI(CreateDDoSAIRequest req)
        {
            return InternalRequestAsync<CreateDDoSAIResponse>(req, "CreateDDoSAI");
        }

        /// <summary>
        /// This API is used to set Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public CreateDDoSAIResponse CreateDDoSAISync(CreateDDoSAIRequest req)
        {
            return InternalRequestAsync<CreateDDoSAIResponse>(req, "CreateDDoSAI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS region blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<CreateDDoSGeoIPBlockConfigResponse> CreateDDoSGeoIPBlockConfig(CreateDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSGeoIPBlockConfigResponse>(req, "CreateDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS region blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public CreateDDoSGeoIPBlockConfigResponse CreateDDoSGeoIPBlockConfigSync(CreateDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSGeoIPBlockConfigResponse>(req, "CreateDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public Task<CreateDDoSSpeedLimitConfigResponse> CreateDDoSSpeedLimitConfig(CreateDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSSpeedLimitConfigResponse>(req, "CreateDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// This API is used to add Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public CreateDDoSSpeedLimitConfigResponse CreateDDoSSpeedLimitConfigSync(CreateDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSSpeedLimitConfigResponse>(req, "CreateDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public Task<CreateDefaultAlarmThresholdResponse> CreateDefaultAlarmThreshold(CreateDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateDefaultAlarmThresholdResponse>(req, "CreateDefaultAlarmThreshold");
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public CreateDefaultAlarmThresholdResponse CreateDefaultAlarmThresholdSync(CreateDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateDefaultAlarmThresholdResponse>(req, "CreateDefaultAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public Task<CreateIPAlarmThresholdConfigResponse> CreateIPAlarmThresholdConfig(CreateIPAlarmThresholdConfigRequest req)
        {
            return InternalRequestAsync<CreateIPAlarmThresholdConfigResponse>(req, "CreateIPAlarmThresholdConfig");
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public CreateIPAlarmThresholdConfigResponse CreateIPAlarmThresholdConfigSync(CreateIPAlarmThresholdConfigRequest req)
        {
            return InternalRequestAsync<CreateIPAlarmThresholdConfigResponse>(req, "CreateIPAlarmThresholdConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure certificates with layer-7 forwarding rules in a batch for SSL testing.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public Task<CreateL7RuleCertsResponse> CreateL7RuleCerts(CreateL7RuleCertsRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertsResponse>(req, "CreateL7RuleCerts");
        }

        /// <summary>
        /// This API is used to configure certificates with layer-7 forwarding rules in a batch for SSL testing.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public CreateL7RuleCertsResponse CreateL7RuleCertsSync(CreateL7RuleCertsRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertsResponse>(req, "CreateL7RuleCerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public Task<CreateNewL7RulesResponse> CreateNewL7Rules(CreateNewL7RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesResponse>(req, "CreateNewL7Rules");
        }

        /// <summary>
        /// This API is used to add layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public CreateNewL7RulesResponse CreateNewL7RulesSync(CreateNewL7RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesResponse>(req, "CreateNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public Task<CreatePacketFilterConfigResponse> CreatePacketFilterConfig(CreatePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<CreatePacketFilterConfigResponse>(req, "CreatePacketFilterConfig");
        }

        /// <summary>
        /// This API is used to add Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public CreatePacketFilterConfigResponse CreatePacketFilterConfigSync(CreatePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<CreatePacketFilterConfigResponse>(req, "CreatePacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public Task<CreateProtocolBlockConfigResponse> CreateProtocolBlockConfig(CreateProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateProtocolBlockConfigResponse>(req, "CreateProtocolBlockConfig");
        }

        /// <summary>
        /// This API is used to set Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public CreateProtocolBlockConfigResponse CreateProtocolBlockConfigSync(CreateProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateProtocolBlockConfigResponse>(req, "CreateProtocolBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a domain name for IP scheduling and switching.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public Task<CreateSchedulingDomainResponse> CreateSchedulingDomain(CreateSchedulingDomainRequest req)
        {
            return InternalRequestAsync<CreateSchedulingDomainResponse>(req, "CreateSchedulingDomain");
        }

        /// <summary>
        /// This API is used to create a domain name for IP scheduling and switching.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public CreateSchedulingDomainResponse CreateSchedulingDomainSync(CreateSchedulingDomainRequest req)
        {
            return InternalRequestAsync<CreateSchedulingDomainResponse>(req, "CreateSchedulingDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public Task<CreateWaterPrintConfigResponse> CreateWaterPrintConfig(CreateWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintConfigResponse>(req, "CreateWaterPrintConfig");
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public CreateWaterPrintConfigResponse CreateWaterPrintConfigSync(CreateWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintConfigResponse>(req, "CreateWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public Task<CreateWaterPrintKeyResponse> CreateWaterPrintKey(CreateWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintKeyResponse>(req, "CreateWaterPrintKey");
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public CreateWaterPrintKeyResponse CreateWaterPrintKeySync(CreateWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintKeyResponse>(req, "CreateWaterPrintKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a level-defining policy of CC attacks. 
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public Task<DeleteCCLevelPolicyResponse> DeleteCCLevelPolicy(DeleteCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCLevelPolicyResponse>(req, "DeleteCCLevelPolicy");
        }

        /// <summary>
        /// This API is used to delete a level-defining policy of CC attacks. 
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public DeleteCCLevelPolicyResponse DeleteCCLevelPolicySync(DeleteCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCLevelPolicyResponse>(req, "DeleteCCLevelPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public Task<DeleteCCPrecisionPolicyResponse> DeleteCCPrecisionPolicy(DeleteCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCPrecisionPolicyResponse>(req, "DeleteCCPrecisionPolicy");
        }

        /// <summary>
        /// This API is used to delete a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public DeleteCCPrecisionPolicyResponse DeleteCCPrecisionPolicySync(DeleteCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCPrecisionPolicyResponse>(req, "DeleteCCPrecisionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CC cleansing threshold policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public Task<DeleteCCThresholdPolicyResponse> DeleteCCThresholdPolicy(DeleteCCThresholdPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCThresholdPolicyResponse>(req, "DeleteCCThresholdPolicy");
        }

        /// <summary>
        /// This API is used to delete a CC cleansing threshold policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public DeleteCCThresholdPolicyResponse DeleteCCThresholdPolicySync(DeleteCCThresholdPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCThresholdPolicyResponse>(req, "DeleteCCThresholdPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public Task<DeleteCcBlackWhiteIpListResponse> DeleteCcBlackWhiteIpList(DeleteCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DeleteCcBlackWhiteIpListResponse>(req, "DeleteCcBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to delete a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public DeleteCcBlackWhiteIpListResponse DeleteCcBlackWhiteIpListSync(DeleteCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DeleteCcBlackWhiteIpListResponse>(req, "DeleteCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public Task<DeleteCcGeoIPBlockConfigResponse> DeleteCcGeoIPBlockConfig(DeleteCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteCcGeoIPBlockConfigResponse>(req, "DeleteCcGeoIPBlockConfig");
        }

        /// <summary>
        /// This API is used to delete a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public DeleteCcGeoIPBlockConfigResponse DeleteCcGeoIPBlockConfigSync(DeleteCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteCcGeoIPBlockConfigResponse>(req, "DeleteCcGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<DeleteDDoSGeoIPBlockConfigResponse> DeleteDDoSGeoIPBlockConfig(DeleteDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSGeoIPBlockConfigResponse>(req, "DeleteDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public DeleteDDoSGeoIPBlockConfigResponse DeleteDDoSGeoIPBlockConfigSync(DeleteDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSGeoIPBlockConfigResponse>(req, "DeleteDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public Task<DeleteDDoSSpeedLimitConfigResponse> DeleteDDoSSpeedLimitConfig(DeleteDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSSpeedLimitConfigResponse>(req, "DeleteDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public DeleteDDoSSpeedLimitConfigResponse DeleteDDoSSpeedLimitConfigSync(DeleteDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSSpeedLimitConfigResponse>(req, "DeleteDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public Task<DeletePacketFilterConfigResponse> DeletePacketFilterConfig(DeletePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DeletePacketFilterConfigResponse>(req, "DeletePacketFilterConfig");
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public DeletePacketFilterConfigResponse DeletePacketFilterConfigSync(DeletePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DeletePacketFilterConfigResponse>(req, "DeletePacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public Task<DeleteWaterPrintConfigResponse> DeleteWaterPrintConfig(DeleteWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintConfigResponse>(req, "DeleteWaterPrintConfig");
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public DeleteWaterPrintConfigResponse DeleteWaterPrintConfigSync(DeleteWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintConfigResponse>(req, "DeleteWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public Task<DeleteWaterPrintKeyResponse> DeleteWaterPrintKey(DeleteWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintKeyResponse>(req, "DeleteWaterPrintKey");
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public DeleteWaterPrintKeyResponse DeleteWaterPrintKeySync(DeleteWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintKeyResponse>(req, "DeleteWaterPrintKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to querying the status of Anti-DDoS IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public Task<DescribeBasicDeviceStatusResponse> DescribeBasicDeviceStatus(DescribeBasicDeviceStatusRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceStatusResponse>(req, "DescribeBasicDeviceStatus");
        }

        /// <summary>
        /// This API is used to querying the status of Anti-DDoS IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public DescribeBasicDeviceStatusResponse DescribeBasicDeviceStatusSync(DescribeBasicDeviceStatusRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceStatusResponse>(req, "DescribeBasicDeviceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain Anti-DDoS Pro traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public Task<DescribeBgpBizTrendResponse> DescribeBgpBizTrend(DescribeBgpBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBgpBizTrendResponse>(req, "DescribeBgpBizTrend");
        }

        /// <summary>
        /// This API is used to obtain Anti-DDoS Pro traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public DescribeBgpBizTrendResponse DescribeBgpBizTrendSync(DescribeBgpBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBgpBizTrendResponse>(req, "DescribeBgpBizTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the statistics on the status codes of business traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public Task<DescribeBizHttpStatusResponse> DescribeBizHttpStatus(DescribeBizHttpStatusRequest req)
        {
            return InternalRequestAsync<DescribeBizHttpStatusResponse>(req, "DescribeBizHttpStatus");
        }

        /// <summary>
        /// This API is used to get the statistics on the status codes of business traffic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public DescribeBizHttpStatusResponse DescribeBizHttpStatusSync(DescribeBizHttpStatusRequest req)
        {
            return InternalRequestAsync<DescribeBizHttpStatusResponse>(req, "DescribeBizHttpStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the traffic flow data collected in the specified period.
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public Task<DescribeBizTrendResponse> DescribeBizTrend(DescribeBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizTrendResponse>(req, "DescribeBizTrend");
        }

        /// <summary>
        /// This API is used to get the traffic flow data collected in the specified period.
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public DescribeBizTrendResponse DescribeBizTrendSync(DescribeBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizTrendResponse>(req, "DescribeBizTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public Task<DescribeBlackWhiteIpListResponse> DescribeBlackWhiteIpList(DescribeBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeBlackWhiteIpListResponse>(req, "DescribeBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to get an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public DescribeBlackWhiteIpListResponse DescribeBlackWhiteIpListSync(DescribeBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeBlackWhiteIpListResponse>(req, "DescribeBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the list of CC protection levels
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public Task<DescribeCCLevelListResponse> DescribeCCLevelList(DescribeCCLevelListRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelListResponse>(req, "DescribeCCLevelList");
        }

        /// <summary>
        /// Gets the list of CC protection levels
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public DescribeCCLevelListResponse DescribeCCLevelListSync(DescribeCCLevelListRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelListResponse>(req, "DescribeCCLevelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used the query a level-defining policy of CC attacks
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public Task<DescribeCCLevelPolicyResponse> DescribeCCLevelPolicy(DescribeCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelPolicyResponse>(req, "DescribeCCLevelPolicy");
        }

        /// <summary>
        /// This API is used the query a level-defining policy of CC attacks
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public DescribeCCLevelPolicyResponse DescribeCCLevelPolicySync(DescribeCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelPolicyResponse>(req, "DescribeCCLevelPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of CC precise protection policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public Task<DescribeCCPrecisionPlyListResponse> DescribeCCPrecisionPlyList(DescribeCCPrecisionPlyListRequest req)
        {
            return InternalRequestAsync<DescribeCCPrecisionPlyListResponse>(req, "DescribeCCPrecisionPlyList");
        }

        /// <summary>
        /// This API is used to obtain the list of CC precise protection policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public DescribeCCPrecisionPlyListResponse DescribeCCPrecisionPlyListSync(DescribeCCPrecisionPlyListRequest req)
        {
            return InternalRequestAsync<DescribeCCPrecisionPlyListResponse>(req, "DescribeCCPrecisionPlyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of CC cleansing thresholds.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public Task<DescribeCCThresholdListResponse> DescribeCCThresholdList(DescribeCCThresholdListRequest req)
        {
            return InternalRequestAsync<DescribeCCThresholdListResponse>(req, "DescribeCCThresholdList");
        }

        /// <summary>
        /// This API is used to query the list of CC cleansing thresholds.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public DescribeCCThresholdListResponse DescribeCCThresholdListSync(DescribeCCThresholdListRequest req)
        {
            return InternalRequestAsync<DescribeCCThresholdListResponse>(req, "DescribeCCThresholdList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get CC attack data, including total QPS peaks, attack QPS, total number of requests and number of attack requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend");
        }

        /// <summary>
        /// This API is used to get CC attack data, including total QPS peaks, attack QPS, total number of requests and number of attack requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public Task<DescribeCcBlackWhiteIpListResponse> DescribeCcBlackWhiteIpList(DescribeCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeCcBlackWhiteIpListResponse>(req, "DescribeCcBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to obtain the layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public DescribeCcBlackWhiteIpListResponse DescribeCcBlackWhiteIpListSync(DescribeCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeCcBlackWhiteIpListResponse>(req, "DescribeCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a list of regional blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public Task<DescribeCcGeoIPBlockConfigListResponse> DescribeCcGeoIPBlockConfigList(DescribeCcGeoIPBlockConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCcGeoIPBlockConfigListResponse>(req, "DescribeCcGeoIPBlockConfigList");
        }

        /// <summary>
        /// This API is used to obtain a list of regional blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public DescribeCcGeoIPBlockConfigListResponse DescribeCcGeoIPBlockConfigListSync(DescribeCcGeoIPBlockConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCcGeoIPBlockConfigListResponse>(req, "DescribeCcGeoIPBlockConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get DDoS attack traffic bandwidth and attack packet rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend");
        }

        /// <summary>
        /// This API is used to get DDoS attack traffic bandwidth and attack packet rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public Task<DescribeDefaultAlarmThresholdResponse> DescribeDefaultAlarmThreshold(DescribeDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDefaultAlarmThresholdResponse>(req, "DescribeDefaultAlarmThreshold");
        }

        /// <summary>
        /// This API is used to get the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public DescribeDefaultAlarmThresholdResponse DescribeDefaultAlarmThresholdSync(DescribeDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDefaultAlarmThresholdResponse>(req, "DescribeDefaultAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query layer-7 rules matched with certificate IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public Task<DescribeL7RulesBySSLCertIdResponse> DescribeL7RulesBySSLCertId(DescribeL7RulesBySSLCertIdRequest req)
        {
            return InternalRequestAsync<DescribeL7RulesBySSLCertIdResponse>(req, "DescribeL7RulesBySSLCertId");
        }

        /// <summary>
        /// This API is used to query layer-7 rules matched with certificate IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public DescribeL7RulesBySSLCertIdResponse DescribeL7RulesBySSLCertIdSync(DescribeL7RulesBySSLCertIdRequest req)
        {
            return InternalRequestAsync<DescribeL7RulesBySSLCertIdResponse>(req, "DescribeL7RulesBySSLCertId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Advanced instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public Task<DescribeListBGPIPInstancesResponse> DescribeListBGPIPInstances(DescribeListBGPIPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPIPInstancesResponse>(req, "DescribeListBGPIPInstances");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Advanced instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public DescribeListBGPIPInstancesResponse DescribeListBGPIPInstancesSync(DescribeListBGPIPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPIPInstancesResponse>(req, "DescribeListBGPIPInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of Anti-DDoS Pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public Task<DescribeListBGPInstancesResponse> DescribeListBGPInstances(DescribeListBGPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPInstancesResponse>(req, "DescribeListBGPInstances");
        }

        /// <summary>
        /// This API is used to get the list of Anti-DDoS Pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public DescribeListBGPInstancesResponse DescribeListBGPInstancesSync(DescribeListBGPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPInstancesResponse>(req, "DescribeListBGPInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS IP blocklists/allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public Task<DescribeListBlackWhiteIpListResponse> DescribeListBlackWhiteIpList(DescribeListBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeListBlackWhiteIpListResponse>(req, "DescribeListBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS IP blocklists/allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public DescribeListBlackWhiteIpListResponse DescribeListBlackWhiteIpListSync(DescribeListBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeListBlackWhiteIpListResponse>(req, "DescribeListBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public Task<DescribeListDDoSAIResponse> DescribeListDDoSAI(DescribeListDDoSAIRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSAIResponse>(req, "DescribeListDDoSAI");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public DescribeListDDoSAIResponse DescribeListDDoSAISync(DescribeListDDoSAIRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSAIResponse>(req, "DescribeListDDoSAI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<DescribeListDDoSGeoIPBlockConfigResponse> DescribeListDDoSGeoIPBlockConfig(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSGeoIPBlockConfigResponse>(req, "DescribeListDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public DescribeListDDoSGeoIPBlockConfigResponse DescribeListDDoSGeoIPBlockConfigSync(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSGeoIPBlockConfigResponse>(req, "DescribeListDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public Task<DescribeListDDoSSpeedLimitConfigResponse> DescribeListDDoSSpeedLimitConfig(DescribeListDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSSpeedLimitConfigResponse>(req, "DescribeListDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public DescribeListDDoSSpeedLimitConfigResponse DescribeListDDoSSpeedLimitConfigSync(DescribeListDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSSpeedLimitConfigResponse>(req, "DescribeListDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of IP alarm threshold configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public Task<DescribeListIPAlarmConfigResponse> DescribeListIPAlarmConfig(DescribeListIPAlarmConfigRequest req)
        {
            return InternalRequestAsync<DescribeListIPAlarmConfigResponse>(req, "DescribeListIPAlarmConfig");
        }

        /// <summary>
        /// This API is used to get a list of IP alarm threshold configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public DescribeListIPAlarmConfigResponse DescribeListIPAlarmConfigSync(DescribeListIPAlarmConfigRequest req)
        {
            return InternalRequestAsync<DescribeListIPAlarmConfigResponse>(req, "DescribeListIPAlarmConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of forwarding listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public Task<DescribeListListenerResponse> DescribeListListener(DescribeListListenerRequest req)
        {
            return InternalRequestAsync<DescribeListListenerResponse>(req, "DescribeListListener");
        }

        /// <summary>
        /// This API is used to get a list of forwarding listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public DescribeListListenerResponse DescribeListListenerSync(DescribeListListenerRequest req)
        {
            return InternalRequestAsync<DescribeListListenerResponse>(req, "DescribeListListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public Task<DescribeListPacketFilterConfigResponse> DescribeListPacketFilterConfig(DescribeListPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DescribeListPacketFilterConfigResponse>(req, "DescribeListPacketFilterConfig");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public DescribeListPacketFilterConfigResponse DescribeListPacketFilterConfigSync(DescribeListPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DescribeListPacketFilterConfigResponse>(req, "DescribeListPacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of protection threshold configurations for AI protection switch, protection level, and CC threshold switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public Task<DescribeListProtectThresholdConfigResponse> DescribeListProtectThresholdConfig(DescribeListProtectThresholdConfigRequest req)
        {
            return InternalRequestAsync<DescribeListProtectThresholdConfigResponse>(req, "DescribeListProtectThresholdConfig");
        }

        /// <summary>
        /// This API is used to get a list of protection threshold configurations for AI protection switch, protection level, and CC threshold switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public DescribeListProtectThresholdConfigResponse DescribeListProtectThresholdConfigSync(DescribeListProtectThresholdConfigRequest req)
        {
            return InternalRequestAsync<DescribeListProtectThresholdConfigResponse>(req, "DescribeListProtectThresholdConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public Task<DescribeListProtocolBlockConfigResponse> DescribeListProtocolBlockConfig(DescribeListProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListProtocolBlockConfigResponse>(req, "DescribeListProtocolBlockConfig");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public DescribeListProtocolBlockConfigResponse DescribeListProtocolBlockConfigSync(DescribeListProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListProtocolBlockConfigResponse>(req, "DescribeListProtocolBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public Task<DescribeListSchedulingDomainResponse> DescribeListSchedulingDomain(DescribeListSchedulingDomainRequest req)
        {
            return InternalRequestAsync<DescribeListSchedulingDomainResponse>(req, "DescribeListSchedulingDomain");
        }

        /// <summary>
        /// This API is used to get a list of intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public DescribeListSchedulingDomainResponse DescribeListSchedulingDomainSync(DescribeListSchedulingDomainRequest req)
        {
            return InternalRequestAsync<DescribeListSchedulingDomainResponse>(req, "DescribeListSchedulingDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public Task<DescribeListWaterPrintConfigResponse> DescribeListWaterPrintConfig(DescribeListWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DescribeListWaterPrintConfigResponse>(req, "DescribeListWaterPrintConfig");
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public DescribeListWaterPrintConfigResponse DescribeListWaterPrintConfigSync(DescribeListWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DescribeListWaterPrintConfigResponse>(req, "DescribeListWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public Task<DescribeNewL7RulesResponse> DescribeNewL7Rules(DescribeNewL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesResponse>(req, "DescribeNewL7Rules");
        }

        /// <summary>
        /// This API is used to obtain layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public DescribeNewL7RulesResponse DescribeNewL7RulesSync(DescribeNewL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesResponse>(req, "DescribeNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to getting the exception results of the health check on layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public Task<DescribeNewL7RulesErrHealthResponse> DescribeNewL7RulesErrHealth(DescribeNewL7RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesErrHealthResponse>(req, "DescribeNewL7RulesErrHealth");
        }

        /// <summary>
        /// This API is used to getting the exception results of the health check on layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public DescribeNewL7RulesErrHealthResponse DescribeNewL7RulesErrHealthSync(DescribeNewL7RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesErrHealthResponse>(req, "DescribeNewL7RulesErrHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public Task<DescribeOverviewDDoSEventListResponse> DescribeOverviewDDoSEventList(DescribeOverviewDDoSEventListRequest req)
        {
            return InternalRequestAsync<DescribeOverviewDDoSEventListResponse>(req, "DescribeOverviewDDoSEventList");
        }

        /// <summary>
        /// This API is used to obtain the list of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public DescribeOverviewDDoSEventListResponse DescribeOverviewDDoSEventListSync(DescribeOverviewDDoSEventListRequest req)
        {
            return InternalRequestAsync<DescribeOverviewDDoSEventListResponse>(req, "DescribeOverviewDDoSEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of pending risks at the account level.
        /// </summary>
        /// <param name="req"><see cref="DescribePendingRiskInfoRequest"/></param>
        /// <returns><see cref="DescribePendingRiskInfoResponse"/></returns>
        public Task<DescribePendingRiskInfoResponse> DescribePendingRiskInfo(DescribePendingRiskInfoRequest req)
        {
            return InternalRequestAsync<DescribePendingRiskInfoResponse>(req, "DescribePendingRiskInfo");
        }

        /// <summary>
        /// This API is used to query the information of pending risks at the account level.
        /// </summary>
        /// <param name="req"><see cref="DescribePendingRiskInfoRequest"/></param>
        /// <returns><see cref="DescribePendingRiskInfoResponse"/></returns>
        public DescribePendingRiskInfoResponse DescribePendingRiskInfoSync(DescribePendingRiskInfoRequest req)
        {
            return InternalRequestAsync<DescribePendingRiskInfoResponse>(req, "DescribePendingRiskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an Anti-DDoS EIP.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public Task<DisassociateDDoSEipAddressResponse> DisassociateDDoSEipAddress(DisassociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<DisassociateDDoSEipAddressResponse>(req, "DisassociateDDoSEipAddress");
        }

        /// <summary>
        /// This API is used to unbind an Anti-DDoS EIP.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public DisassociateDDoSEipAddressResponse DisassociateDDoSEipAddressSync(DisassociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<DisassociateDDoSEipAddressResponse>(req, "DisassociateDDoSEipAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public Task<ModifyCCPrecisionPolicyResponse> ModifyCCPrecisionPolicy(ModifyCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCPrecisionPolicyResponse>(req, "ModifyCCPrecisionPolicy");
        }

        /// <summary>
        /// This API is used to modify a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public ModifyCCPrecisionPolicyResponse ModifyCCPrecisionPolicySync(ModifyCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCPrecisionPolicyResponse>(req, "ModifyCCPrecisionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public Task<ModifyCcBlackWhiteIpListResponse> ModifyCcBlackWhiteIpList(ModifyCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<ModifyCcBlackWhiteIpListResponse>(req, "ModifyCcBlackWhiteIpList");
        }

        /// <summary>
        /// This API is used to modify a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public ModifyCcBlackWhiteIpListResponse ModifyCcBlackWhiteIpListSync(ModifyCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<ModifyCcBlackWhiteIpListResponse>(req, "ModifyCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<ModifyDDoSGeoIPBlockConfigResponse> ModifyDDoSGeoIPBlockConfig(ModifyDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSGeoIPBlockConfigResponse>(req, "ModifyDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public ModifyDDoSGeoIPBlockConfigResponse ModifyDDoSGeoIPBlockConfigSync(ModifyDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSGeoIPBlockConfigResponse>(req, "ModifyDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public Task<ModifyDDoSSpeedLimitConfigResponse> ModifyDDoSSpeedLimitConfig(ModifyDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSpeedLimitConfigResponse>(req, "ModifyDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public ModifyDDoSSpeedLimitConfigResponse ModifyDDoSSpeedLimitConfigSync(ModifyDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSpeedLimitConfigResponse>(req, "ModifyDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public Task<ModifyDomainUsrNameResponse> ModifyDomainUsrName(ModifyDomainUsrNameRequest req)
        {
            return InternalRequestAsync<ModifyDomainUsrNameResponse>(req, "ModifyDomainUsrName");
        }

        /// <summary>
        /// This API is used to modify intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public ModifyDomainUsrNameResponse ModifyDomainUsrNameSync(ModifyDomainUsrNameRequest req)
        {
            return InternalRequestAsync<ModifyDomainUsrNameResponse>(req, "ModifyDomainUsrName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public Task<ModifyNewDomainRulesResponse> ModifyNewDomainRules(ModifyNewDomainRulesRequest req)
        {
            return InternalRequestAsync<ModifyNewDomainRulesResponse>(req, "ModifyNewDomainRules");
        }

        /// <summary>
        /// This API is used to modify layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public ModifyNewDomainRulesResponse ModifyNewDomainRulesSync(ModifyNewDomainRulesRequest req)
        {
            return InternalRequestAsync<ModifyNewDomainRulesResponse>(req, "ModifyNewDomainRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public Task<ModifyPacketFilterConfigResponse> ModifyPacketFilterConfig(ModifyPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<ModifyPacketFilterConfigResponse>(req, "ModifyPacketFilterConfig");
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public ModifyPacketFilterConfigResponse ModifyPacketFilterConfigSync(ModifyPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<ModifyPacketFilterConfigResponse>(req, "ModifyPacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public Task<SwitchWaterPrintConfigResponse> SwitchWaterPrintConfig(SwitchWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<SwitchWaterPrintConfigResponse>(req, "SwitchWaterPrintConfig");
        }

        /// <summary>
        /// This API is used to enable or disable Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public SwitchWaterPrintConfigResponse SwitchWaterPrintConfigSync(SwitchWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<SwitchWaterPrintConfigResponse>(req, "SwitchWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
