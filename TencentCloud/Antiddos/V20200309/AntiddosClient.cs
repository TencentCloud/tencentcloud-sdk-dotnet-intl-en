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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to bind an EIP to an Anti-DDoS Advanced instance or a specified private IP of an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public async Task<AssociateDDoSEipAddressResponse> AssociateDDoSEipAddress(AssociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<AssociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to an Anti-DDoS Advanced instance or a specified private IP of an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public AssociateDDoSEipAddressResponse AssociateDDoSEipAddressSync(AssociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<AssociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an Anti-DDoS EIP to the specified private IP of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public async Task<AssociateDDoSEipLoadBalancerResponse> AssociateDDoSEipLoadBalancer(AssociateDDoSEipLoadBalancerRequest req)
        {
             JsonResponseModel<AssociateDDoSEipLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDDoSEipLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an Anti-DDoS EIP to the specified private IP of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public AssociateDDoSEipLoadBalancerResponse AssociateDDoSEipLoadBalancerSync(AssociateDDoSEipLoadBalancerRequest req)
        {
             JsonResponseModel<AssociateDDoSEipLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDDoSEipLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public async Task<CreateBlackWhiteIpListResponse> CreateBlackWhiteIpList(CreateBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public CreateBlackWhiteIpListResponse CreateBlackWhiteIpListSync(CreateBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance Both single IP instances and multi-IP instances are available. Note that you should wait until the current binding or unbinding completes before using this async API for new operations.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public async Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
             JsonResponseModel<CreateBoundIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBoundIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBoundIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance Both single IP instances and multi-IP instances are available. Note that you should wait until the current binding or unbinding completes before using this async API for new operations.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
             JsonResponseModel<CreateBoundIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBoundIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBoundIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public async Task<CreateCCPrecisionPolicyResponse> CreateCCPrecisionPolicy(CreateCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<CreateCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public CreateCCPrecisionPolicyResponse CreateCCPrecisionPolicySync(CreateCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<CreateCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CC frequency limit policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public async Task<CreateCCReqLimitPolicyResponse> CreateCCReqLimitPolicy(CreateCCReqLimitPolicyRequest req)
        {
             JsonResponseModel<CreateCCReqLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCReqLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCReqLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CC frequency limit policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public CreateCCReqLimitPolicyResponse CreateCCReqLimitPolicySync(CreateCCReqLimitPolicyRequest req)
        {
             JsonResponseModel<CreateCCReqLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCReqLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCReqLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a layer 4 access control list to prevent CC attacks.
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public async Task<CreateCcBlackWhiteIpListResponse> CreateCcBlackWhiteIpList(CreateCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a layer 4 access control list to prevent CC attacks.
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public CreateCcBlackWhiteIpListResponse CreateCcBlackWhiteIpListSync(CreateCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public async Task<CreateCcGeoIPBlockConfigResponse> CreateCcGeoIPBlockConfig(CreateCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public CreateCcGeoIPBlockConfigResponse CreateCcGeoIPBlockConfigSync(CreateCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public async Task<CreateDDoSAIResponse> CreateDDoSAI(CreateDDoSAIRequest req)
        {
             JsonResponseModel<CreateDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public CreateDDoSAIResponse CreateDDoSAISync(CreateDDoSAIRequest req)
        {
             JsonResponseModel<CreateDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS region blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<CreateDDoSGeoIPBlockConfigResponse> CreateDDoSGeoIPBlockConfig(CreateDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an Anti-DDoS region blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public CreateDDoSGeoIPBlockConfigResponse CreateDDoSGeoIPBlockConfigSync(CreateDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<CreateDDoSSpeedLimitConfigResponse> CreateDDoSSpeedLimitConfig(CreateDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<CreateDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public CreateDDoSSpeedLimitConfigResponse CreateDDoSSpeedLimitConfigSync(CreateDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<CreateDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public async Task<CreateDefaultAlarmThresholdResponse> CreateDefaultAlarmThreshold(CreateDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public CreateDefaultAlarmThresholdResponse CreateDefaultAlarmThresholdSync(CreateDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public async Task<CreateIPAlarmThresholdConfigResponse> CreateIPAlarmThresholdConfig(CreateIPAlarmThresholdConfigRequest req)
        {
             JsonResponseModel<CreateIPAlarmThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIPAlarmThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPAlarmThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public CreateIPAlarmThresholdConfigResponse CreateIPAlarmThresholdConfigSync(CreateIPAlarmThresholdConfigRequest req)
        {
             JsonResponseModel<CreateIPAlarmThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIPAlarmThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPAlarmThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure certificates with layer-7 forwarding rules in a batch for SSL testing.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public async Task<CreateL7RuleCertsResponse> CreateL7RuleCerts(CreateL7RuleCertsRequest req)
        {
             JsonResponseModel<CreateL7RuleCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RuleCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure certificates with layer-7 forwarding rules in a batch for SSL testing.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public CreateL7RuleCertsResponse CreateL7RuleCertsSync(CreateL7RuleCertsRequest req)
        {
             JsonResponseModel<CreateL7RuleCertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RuleCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public async Task<CreateNewL7RulesResponse> CreateNewL7Rules(CreateNewL7RulesRequest req)
        {
             JsonResponseModel<CreateNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public CreateNewL7RulesResponse CreateNewL7RulesSync(CreateNewL7RulesRequest req)
        {
             JsonResponseModel<CreateNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public async Task<CreatePacketFilterConfigResponse> CreatePacketFilterConfig(CreatePacketFilterConfigRequest req)
        {
             JsonResponseModel<CreatePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public CreatePacketFilterConfigResponse CreatePacketFilterConfigSync(CreatePacketFilterConfigRequest req)
        {
             JsonResponseModel<CreatePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public async Task<CreateProtocolBlockConfigResponse> CreateProtocolBlockConfig(CreateProtocolBlockConfigRequest req)
        {
             JsonResponseModel<CreateProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public CreateProtocolBlockConfigResponse CreateProtocolBlockConfigSync(CreateProtocolBlockConfigRequest req)
        {
             JsonResponseModel<CreateProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a domain name for IP scheduling and switching.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public async Task<CreateSchedulingDomainResponse> CreateSchedulingDomain(CreateSchedulingDomainRequest req)
        {
             JsonResponseModel<CreateSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a domain name for IP scheduling and switching.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public CreateSchedulingDomainResponse CreateSchedulingDomainSync(CreateSchedulingDomainRequest req)
        {
             JsonResponseModel<CreateSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public async Task<CreateWaterPrintConfigResponse> CreateWaterPrintConfig(CreateWaterPrintConfigRequest req)
        {
             JsonResponseModel<CreateWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public CreateWaterPrintConfigResponse CreateWaterPrintConfigSync(CreateWaterPrintConfigRequest req)
        {
             JsonResponseModel<CreateWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public async Task<CreateWaterPrintKeyResponse> CreateWaterPrintKey(CreateWaterPrintKeyRequest req)
        {
             JsonResponseModel<CreateWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public CreateWaterPrintKeyResponse CreateWaterPrintKeySync(CreateWaterPrintKeyRequest req)
        {
             JsonResponseModel<CreateWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a level-defining policy of CC attacks. 
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public async Task<DeleteCCLevelPolicyResponse> DeleteCCLevelPolicy(DeleteCCLevelPolicyRequest req)
        {
             JsonResponseModel<DeleteCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a level-defining policy of CC attacks. 
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public DeleteCCLevelPolicyResponse DeleteCCLevelPolicySync(DeleteCCLevelPolicyRequest req)
        {
             JsonResponseModel<DeleteCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public async Task<DeleteCCPrecisionPolicyResponse> DeleteCCPrecisionPolicy(DeleteCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<DeleteCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public DeleteCCPrecisionPolicyResponse DeleteCCPrecisionPolicySync(DeleteCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<DeleteCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CC cleansing threshold policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public async Task<DeleteCCThresholdPolicyResponse> DeleteCCThresholdPolicy(DeleteCCThresholdPolicyRequest req)
        {
             JsonResponseModel<DeleteCCThresholdPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCThresholdPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCThresholdPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CC cleansing threshold policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public DeleteCCThresholdPolicyResponse DeleteCCThresholdPolicySync(DeleteCCThresholdPolicyRequest req)
        {
             JsonResponseModel<DeleteCCThresholdPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCThresholdPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCThresholdPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public async Task<DeleteCcBlackWhiteIpListResponse> DeleteCcBlackWhiteIpList(DeleteCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public DeleteCcBlackWhiteIpListResponse DeleteCcBlackWhiteIpListSync(DeleteCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public async Task<DeleteCcGeoIPBlockConfigResponse> DeleteCcGeoIPBlockConfig(DeleteCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a regional blocking configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public DeleteCcGeoIPBlockConfigResponse DeleteCcGeoIPBlockConfigSync(DeleteCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<DeleteDDoSGeoIPBlockConfigResponse> DeleteDDoSGeoIPBlockConfig(DeleteDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public DeleteDDoSGeoIPBlockConfigResponse DeleteDDoSGeoIPBlockConfigSync(DeleteDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<DeleteDDoSSpeedLimitConfigResponse> DeleteDDoSSpeedLimitConfig(DeleteDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public DeleteDDoSSpeedLimitConfigResponse DeleteDDoSSpeedLimitConfigSync(DeleteDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public async Task<DeletePacketFilterConfigResponse> DeletePacketFilterConfig(DeletePacketFilterConfigRequest req)
        {
             JsonResponseModel<DeletePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public DeletePacketFilterConfigResponse DeletePacketFilterConfigSync(DeletePacketFilterConfigRequest req)
        {
             JsonResponseModel<DeletePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public async Task<DeleteWaterPrintConfigResponse> DeleteWaterPrintConfig(DeleteWaterPrintConfigRequest req)
        {
             JsonResponseModel<DeleteWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public DeleteWaterPrintConfigResponse DeleteWaterPrintConfigSync(DeleteWaterPrintConfigRequest req)
        {
             JsonResponseModel<DeleteWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public async Task<DeleteWaterPrintKeyResponse> DeleteWaterPrintKey(DeleteWaterPrintKeyRequest req)
        {
             JsonResponseModel<DeleteWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Anti-DDoS watermark keys.
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public DeleteWaterPrintKeyResponse DeleteWaterPrintKeySync(DeleteWaterPrintKeyRequest req)
        {
             JsonResponseModel<DeleteWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to querying the status of Anti-DDoS IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public async Task<DescribeBasicDeviceStatusResponse> DescribeBasicDeviceStatus(DescribeBasicDeviceStatusRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicDeviceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to querying the status of Anti-DDoS IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public DescribeBasicDeviceStatusResponse DescribeBasicDeviceStatusSync(DescribeBasicDeviceStatusRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicDeviceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain Anti-DDoS Pro traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public async Task<DescribeBgpBizTrendResponse> DescribeBgpBizTrend(DescribeBgpBizTrendRequest req)
        {
             JsonResponseModel<DescribeBgpBizTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBgpBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBgpBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain Anti-DDoS Pro traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public DescribeBgpBizTrendResponse DescribeBgpBizTrendSync(DescribeBgpBizTrendRequest req)
        {
             JsonResponseModel<DescribeBgpBizTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBgpBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBgpBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the traffic flow data collected in the specified period.
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public async Task<DescribeBizTrendResponse> DescribeBizTrend(DescribeBizTrendRequest req)
        {
             JsonResponseModel<DescribeBizTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the traffic flow data collected in the specified period.
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public DescribeBizTrendResponse DescribeBizTrendSync(DescribeBizTrendRequest req)
        {
             JsonResponseModel<DescribeBizTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeBlackWhiteIpListResponse> DescribeBlackWhiteIpList(DescribeBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an Anti-DDoS IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public DescribeBlackWhiteIpListResponse DescribeBlackWhiteIpListSync(DescribeBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the list of CC protection levels
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public async Task<DescribeCCLevelListResponse> DescribeCCLevelList(DescribeCCLevelListRequest req)
        {
             JsonResponseModel<DescribeCCLevelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the list of CC protection levels
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public DescribeCCLevelListResponse DescribeCCLevelListSync(DescribeCCLevelListRequest req)
        {
             JsonResponseModel<DescribeCCLevelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used the query a level-defining policy of CC attacks
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public async Task<DescribeCCLevelPolicyResponse> DescribeCCLevelPolicy(DescribeCCLevelPolicyRequest req)
        {
             JsonResponseModel<DescribeCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used the query a level-defining policy of CC attacks
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public DescribeCCLevelPolicyResponse DescribeCCLevelPolicySync(DescribeCCLevelPolicyRequest req)
        {
             JsonResponseModel<DescribeCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of CC precise protection policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public async Task<DescribeCCPrecisionPlyListResponse> DescribeCCPrecisionPlyList(DescribeCCPrecisionPlyListRequest req)
        {
             JsonResponseModel<DescribeCCPrecisionPlyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCPrecisionPlyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCPrecisionPlyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of CC precise protection policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public DescribeCCPrecisionPlyListResponse DescribeCCPrecisionPlyListSync(DescribeCCPrecisionPlyListRequest req)
        {
             JsonResponseModel<DescribeCCPrecisionPlyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCPrecisionPlyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCPrecisionPlyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CC cleansing thresholds.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public async Task<DescribeCCThresholdListResponse> DescribeCCThresholdList(DescribeCCThresholdListRequest req)
        {
             JsonResponseModel<DescribeCCThresholdListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCThresholdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCThresholdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CC cleansing thresholds.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public DescribeCCThresholdListResponse DescribeCCThresholdListSync(DescribeCCThresholdListRequest req)
        {
             JsonResponseModel<DescribeCCThresholdListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCThresholdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCThresholdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get CC attack data, including total QPS peaks, attack QPS, total number of requests and number of attack requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public async Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
             JsonResponseModel<DescribeCCTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get CC attack data, including total QPS peaks, attack QPS, total number of requests and number of attack requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
             JsonResponseModel<DescribeCCTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeCcBlackWhiteIpListResponse> DescribeCcBlackWhiteIpList(DescribeCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public DescribeCcBlackWhiteIpListResponse DescribeCcBlackWhiteIpListSync(DescribeCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a list of regional blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public async Task<DescribeCcGeoIPBlockConfigListResponse> DescribeCcGeoIPBlockConfigList(DescribeCcGeoIPBlockConfigListRequest req)
        {
             JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcGeoIPBlockConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain a list of regional blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public DescribeCcGeoIPBlockConfigListResponse DescribeCcGeoIPBlockConfigListSync(DescribeCcGeoIPBlockConfigListRequest req)
        {
             JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcGeoIPBlockConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get DDoS attack traffic bandwidth and attack packet rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public async Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get DDoS attack traffic bandwidth and attack packet rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public async Task<DescribeDefaultAlarmThresholdResponse> DescribeDefaultAlarmThreshold(DescribeDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the default alarm threshold of an IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public DescribeDefaultAlarmThresholdResponse DescribeDefaultAlarmThresholdSync(DescribeDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query layer-7 rules matched with certificate IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public async Task<DescribeL7RulesBySSLCertIdResponse> DescribeL7RulesBySSLCertId(DescribeL7RulesBySSLCertIdRequest req)
        {
             JsonResponseModel<DescribeL7RulesBySSLCertIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7RulesBySSLCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesBySSLCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query layer-7 rules matched with certificate IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public DescribeL7RulesBySSLCertIdResponse DescribeL7RulesBySSLCertIdSync(DescribeL7RulesBySSLCertIdRequest req)
        {
             JsonResponseModel<DescribeL7RulesBySSLCertIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7RulesBySSLCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesBySSLCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Advanced instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public async Task<DescribeListBGPIPInstancesResponse> DescribeListBGPIPInstances(DescribeListBGPIPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPIPInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBGPIPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPIPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Advanced instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public DescribeListBGPIPInstancesResponse DescribeListBGPIPInstancesSync(DescribeListBGPIPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPIPInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBGPIPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPIPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public async Task<DescribeListBGPInstancesResponse> DescribeListBGPInstances(DescribeListBGPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBGPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS Pro instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public DescribeListBGPInstancesResponse DescribeListBGPInstancesSync(DescribeListBGPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBGPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS IP blocklists/allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeListBlackWhiteIpListResponse> DescribeListBlackWhiteIpList(DescribeListBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeListBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS IP blocklists/allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public DescribeListBlackWhiteIpListResponse DescribeListBlackWhiteIpListSync(DescribeListBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeListBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public async Task<DescribeListDDoSAIResponse> DescribeListDDoSAI(DescribeListDDoSAIRequest req)
        {
             JsonResponseModel<DescribeListDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS AI protection switches.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public DescribeListDDoSAIResponse DescribeListDDoSAISync(DescribeListDDoSAIRequest req)
        {
             JsonResponseModel<DescribeListDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<DescribeListDDoSGeoIPBlockConfigResponse> DescribeListDDoSGeoIPBlockConfig(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public DescribeListDDoSGeoIPBlockConfigResponse DescribeListDDoSGeoIPBlockConfigSync(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<DescribeListDDoSSpeedLimitConfigResponse> DescribeListDDoSSpeedLimitConfig(DescribeListDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public DescribeListDDoSSpeedLimitConfigResponse DescribeListDDoSSpeedLimitConfigSync(DescribeListDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of IP alarm threshold configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public async Task<DescribeListIPAlarmConfigResponse> DescribeListIPAlarmConfig(DescribeListIPAlarmConfigRequest req)
        {
             JsonResponseModel<DescribeListIPAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListIPAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListIPAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of IP alarm threshold configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public DescribeListIPAlarmConfigResponse DescribeListIPAlarmConfigSync(DescribeListIPAlarmConfigRequest req)
        {
             JsonResponseModel<DescribeListIPAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListIPAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListIPAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of forwarding listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public async Task<DescribeListListenerResponse> DescribeListListener(DescribeListListenerRequest req)
        {
             JsonResponseModel<DescribeListListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of forwarding listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public DescribeListListenerResponse DescribeListListenerSync(DescribeListListenerRequest req)
        {
             JsonResponseModel<DescribeListListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public async Task<DescribeListPacketFilterConfigResponse> DescribeListPacketFilterConfig(DescribeListPacketFilterConfigRequest req)
        {
             JsonResponseModel<DescribeListPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public DescribeListPacketFilterConfigResponse DescribeListPacketFilterConfigSync(DescribeListPacketFilterConfigRequest req)
        {
             JsonResponseModel<DescribeListPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of protection threshold configurations for AI protection switch, protection level, and CC threshold switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public async Task<DescribeListProtectThresholdConfigResponse> DescribeListProtectThresholdConfig(DescribeListProtectThresholdConfigRequest req)
        {
             JsonResponseModel<DescribeListProtectThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListProtectThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtectThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of protection threshold configurations for AI protection switch, protection level, and CC threshold switch.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public DescribeListProtectThresholdConfigResponse DescribeListProtectThresholdConfigSync(DescribeListProtectThresholdConfigRequest req)
        {
             JsonResponseModel<DescribeListProtectThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListProtectThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtectThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public async Task<DescribeListProtocolBlockConfigResponse> DescribeListProtocolBlockConfig(DescribeListProtocolBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS protocol blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public DescribeListProtocolBlockConfigResponse DescribeListProtocolBlockConfigSync(DescribeListProtocolBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public async Task<DescribeListSchedulingDomainResponse> DescribeListSchedulingDomain(DescribeListSchedulingDomainRequest req)
        {
             JsonResponseModel<DescribeListSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public DescribeListSchedulingDomainResponse DescribeListSchedulingDomainSync(DescribeListSchedulingDomainRequest req)
        {
             JsonResponseModel<DescribeListSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public async Task<DescribeListWaterPrintConfigResponse> DescribeListWaterPrintConfig(DescribeListWaterPrintConfigRequest req)
        {
             JsonResponseModel<DescribeListWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a list of Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public DescribeListWaterPrintConfigResponse DescribeListWaterPrintConfigSync(DescribeListWaterPrintConfigRequest req)
        {
             JsonResponseModel<DescribeListWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public async Task<DescribeNewL7RulesResponse> DescribeNewL7Rules(DescribeNewL7RulesRequest req)
        {
             JsonResponseModel<DescribeNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public DescribeNewL7RulesResponse DescribeNewL7RulesSync(DescribeNewL7RulesRequest req)
        {
             JsonResponseModel<DescribeNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public async Task<DescribeOverviewDDoSEventListResponse> DescribeOverviewDDoSEventList(DescribeOverviewDDoSEventListRequest req)
        {
             JsonResponseModel<DescribeOverviewDDoSEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewDDoSEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewDDoSEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the list of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public DescribeOverviewDDoSEventListResponse DescribeOverviewDDoSEventListSync(DescribeOverviewDDoSEventListRequest req)
        {
             JsonResponseModel<DescribeOverviewDDoSEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewDDoSEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewDDoSEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an Anti-DDoS EIP.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public async Task<DisassociateDDoSEipAddressResponse> DisassociateDDoSEipAddress(DisassociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<DisassociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an Anti-DDoS EIP.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public DisassociateDDoSEipAddressResponse DisassociateDDoSEipAddressSync(DisassociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<DisassociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public async Task<ModifyCCPrecisionPolicyResponse> ModifyCCPrecisionPolicy(ModifyCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<ModifyCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a CC precise protection policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public ModifyCCPrecisionPolicyResponse ModifyCCPrecisionPolicySync(ModifyCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<ModifyCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public async Task<ModifyCcBlackWhiteIpListResponse> ModifyCcBlackWhiteIpList(ModifyCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<ModifyCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a layer-4 access control list.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public ModifyCcBlackWhiteIpListResponse ModifyCcBlackWhiteIpListSync(ModifyCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<ModifyCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<ModifyDDoSGeoIPBlockConfigResponse> ModifyDDoSGeoIPBlockConfig(ModifyDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS region blocking configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public ModifyDDoSGeoIPBlockConfigResponse ModifyDDoSGeoIPBlockConfigSync(ModifyDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<ModifyDDoSSpeedLimitConfigResponse> ModifyDDoSSpeedLimitConfig(ModifyDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS access rate limit configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public ModifyDDoSSpeedLimitConfigResponse ModifyDDoSSpeedLimitConfigSync(ModifyDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public async Task<ModifyDomainUsrNameResponse> ModifyDomainUsrName(ModifyDomainUsrNameRequest req)
        {
             JsonResponseModel<ModifyDomainUsrNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainUsrName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUsrNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify intelligent scheduling domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public ModifyDomainUsrNameResponse ModifyDomainUsrNameSync(ModifyDomainUsrNameRequest req)
        {
             JsonResponseModel<ModifyDomainUsrNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainUsrName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUsrNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public async Task<ModifyNewDomainRulesResponse> ModifyNewDomainRules(ModifyNewDomainRulesRequest req)
        {
             JsonResponseModel<ModifyNewDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNewDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public ModifyNewDomainRulesResponse ModifyNewDomainRulesSync(ModifyNewDomainRulesRequest req)
        {
             JsonResponseModel<ModifyNewDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNewDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public async Task<ModifyPacketFilterConfigResponse> ModifyPacketFilterConfig(ModifyPacketFilterConfigRequest req)
        {
             JsonResponseModel<ModifyPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify Anti-DDoS feature filtering rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public ModifyPacketFilterConfigResponse ModifyPacketFilterConfigSync(ModifyPacketFilterConfigRequest req)
        {
             JsonResponseModel<ModifyPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public async Task<SwitchWaterPrintConfigResponse> SwitchWaterPrintConfig(SwitchWaterPrintConfigRequest req)
        {
             JsonResponseModel<SwitchWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable Anti-DDoS watermark configurations.
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public SwitchWaterPrintConfigResponse SwitchWaterPrintConfigSync(SwitchWaterPrintConfigRequest req)
        {
             JsonResponseModel<SwitchWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
