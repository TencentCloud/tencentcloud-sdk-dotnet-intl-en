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

namespace TencentCloud.Dayu.V20180709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dayu.V20180709.Models;

   public class DayuClient : AbstractClient{

       private const string endpoint = "dayu.tencentcloudapi.com";
       private const string version = "2018-07-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DayuClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DayuClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to set the DDoS alarm threshold for Anti-DDoS Basic, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public async Task<CreateBasicDDoSAlarmThresholdResponse> CreateBasicDDoSAlarmThreshold(CreateBasicDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBasicDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the DDoS alarm threshold for Anti-DDoS Basic, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public CreateBasicDDoSAlarmThresholdResponse CreateBasicDDoSAlarmThresholdSync(CreateBasicDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBasicDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance, which supports both single IP instances and multi-IP instances. It should be noted that this API is async; therefore, if a binding/unbinding operation is in progress, new binding/unbinding operations cannot be initiated.
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
        /// This API is used to bind an IP to an Anti-DDoS Pro instance, which supports both single IP instances and multi-IP instances. It should be noted that this API is async; therefore, if a binding/unbinding operation is in progress, new binding/unbinding operations cannot be initiated.
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
        /// This API is used to add an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="CreateCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="CreateCCFrequencyRulesResponse"/></returns>
        public async Task<CreateCCFrequencyRulesResponse> CreateCCFrequencyRules(CreateCCFrequencyRulesRequest req)
        {
             JsonResponseModel<CreateCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="CreateCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="CreateCCFrequencyRulesResponse"/></returns>
        public CreateCCFrequencyRulesResponse CreateCCFrequencyRulesSync(CreateCCFrequencyRulesRequest req)
        {
             JsonResponseModel<CreateCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public async Task<CreateCCSelfDefinePolicyResponse> CreateCCSelfDefinePolicy(CreateCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<CreateCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public CreateCCSelfDefinePolicyResponse CreateCCSelfDefinePolicySync(CreateCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<CreateCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public async Task<CreateDDoSPolicyResponse> CreateDDoSPolicy(CreateDDoSPolicyRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public CreateDDoSPolicyResponse CreateDDoSPolicySync(CreateDDoSPolicyRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public async Task<CreateDDoSPolicyCaseResponse> CreateDDoSPolicyCase(CreateDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public CreateDDoSPolicyCaseResponse CreateDDoSPolicyCaseSync(CreateDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a resource instance, which supports single IP instances, multi-IP instances, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public async Task<CreateInstanceNameResponse> CreateInstanceName(CreateInstanceNameRequest req)
        {
             JsonResponseModel<CreateInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a resource instance, which supports single IP instances, multi-IP instances, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public CreateInstanceNameResponse CreateInstanceNameSync(CreateInstanceNameRequest req)
        {
             JsonResponseModel<CreateInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public async Task<CreateL4HealthConfigResponse> CreateL4HealthConfig(CreateL4HealthConfigRequest req)
        {
             JsonResponseModel<CreateL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public CreateL4HealthConfigResponse CreateL4HealthConfigSync(CreateL4HealthConfigRequest req)
        {
             JsonResponseModel<CreateL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public async Task<CreateL4RulesResponse> CreateL4Rules(CreateL4RulesRequest req)
        {
             JsonResponseModel<CreateL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public CreateL4RulesResponse CreateL4RulesSync(CreateL4RulesRequest req)
        {
             JsonResponseModel<CreateL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a custom frequency control rule for layer-7 CC access (it works in the IP + Host dimension and does not support specific URIs). As it has been disused, please call the new `CreateCCFrequencyRules` API, which supports both IP + Host and URI.
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public async Task<CreateL7CCRuleResponse> CreateL7CCRule(CreateL7CCRuleRequest req)
        {
             JsonResponseModel<CreateL7CCRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7CCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7CCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a custom frequency control rule for layer-7 CC access (it works in the IP + Host dimension and does not support specific URIs). As it has been disused, please call the new `CreateCCFrequencyRules` API, which supports both IP + Host and URI.
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public CreateL7CCRuleResponse CreateL7CCRuleSync(CreateL7CCRuleRequest req)
        {
             JsonResponseModel<CreateL7CCRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7CCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7CCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public async Task<CreateL7HealthConfigResponse> CreateL7HealthConfig(CreateL7HealthConfigRequest req)
        {
             JsonResponseModel<CreateL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public CreateL7HealthConfigResponse CreateL7HealthConfigSync(CreateL7HealthConfigRequest req)
        {
             JsonResponseModel<CreateL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a certificate for a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public async Task<CreateL7RuleCertResponse> CreateL7RuleCert(CreateL7RuleCertRequest req)
        {
             JsonResponseModel<CreateL7RuleCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RuleCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure a certificate for a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public CreateL7RuleCertResponse CreateL7RuleCertSync(CreateL7RuleCertRequest req)
        {
             JsonResponseModel<CreateL7RuleCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RuleCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a layer-7 (website) forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public async Task<CreateL7RulesResponse> CreateL7Rules(CreateL7RulesRequest req)
        {
             JsonResponseModel<CreateL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a layer-7 (website) forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public CreateL7RulesResponse CreateL7RulesSync(CreateL7RulesRequest req)
        {
             JsonResponseModel<CreateL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload layer-7 forwarding rules in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public async Task<CreateL7RulesUploadResponse> CreateL7RulesUpload(CreateL7RulesUploadRequest req)
        {
             JsonResponseModel<CreateL7RulesUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RulesUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload layer-7 forwarding rules in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public CreateL7RulesUploadResponse CreateL7RulesUploadSync(CreateL7RulesUploadRequest req)
        {
             JsonResponseModel<CreateL7RulesUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RulesUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch to the real server in Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateNetReturnRequest"/></param>
        /// <returns><see cref="CreateNetReturnResponse"/></returns>
        public async Task<CreateNetReturnResponse> CreateNetReturn(CreateNetReturnRequest req)
        {
             JsonResponseModel<CreateNetReturnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetReturn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetReturnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch to the real server in Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateNetReturnRequest"/></param>
        /// <returns><see cref="CreateNetReturnResponse"/></returns>
        public CreateNetReturnResponse CreateNetReturnSync(CreateNetReturnRequest req)
        {
             JsonResponseModel<CreateNetReturnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetReturn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetReturnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch upload Layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesUploadResponse"/></returns>
        public async Task<CreateNewL7RulesUploadResponse> CreateNewL7RulesUpload(CreateNewL7RulesUploadRequest req)
        {
             JsonResponseModel<CreateNewL7RulesUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNewL7RulesUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewL7RulesUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch upload Layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesUploadResponse"/></returns>
        public CreateNewL7RulesUploadResponse CreateNewL7RulesUploadSync(CreateNewL7RulesUploadRequest req)
        {
             JsonResponseModel<CreateNewL7RulesUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNewL7RulesUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewL7RulesUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unblock an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public async Task<CreateUnblockIpResponse> CreateUnblockIp(CreateUnblockIpRequest req)
        {
             JsonResponseModel<CreateUnblockIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUnblockIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnblockIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unblock an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public CreateUnblockIpResponse CreateUnblockIpSync(CreateUnblockIpRequest req)
        {
             JsonResponseModel<CreateUnblockIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUnblockIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnblockIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DeleteCCFrequencyRulesResponse"/></returns>
        public async Task<DeleteCCFrequencyRulesResponse> DeleteCCFrequencyRules(DeleteCCFrequencyRulesRequest req)
        {
             JsonResponseModel<DeleteCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DeleteCCFrequencyRulesResponse"/></returns>
        public DeleteCCFrequencyRulesResponse DeleteCCFrequencyRulesSync(DeleteCCFrequencyRulesRequest req)
        {
             JsonResponseModel<DeleteCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public async Task<DeleteCCSelfDefinePolicyResponse> DeleteCCSelfDefinePolicy(DeleteCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DeleteCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public DeleteCCSelfDefinePolicyResponse DeleteCCSelfDefinePolicySync(DeleteCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DeleteCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an advanced DDoS protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public async Task<DeleteDDoSPolicyResponse> DeleteDDoSPolicy(DeleteDDoSPolicyRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an advanced DDoS protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public DeleteDDoSPolicyResponse DeleteDDoSPolicySync(DeleteDDoSPolicyRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public async Task<DeleteDDoSPolicyCaseResponse> DeleteDDoSPolicyCase(DeleteDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public DeleteDDoSPolicyCaseResponse DeleteDDoSPolicyCaseSync(DeleteDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public async Task<DeleteL4RulesResponse> DeleteL4Rules(DeleteL4RulesRequest req)
        {
             JsonResponseModel<DeleteL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public DeleteL4RulesResponse DeleteL4RulesSync(DeleteL4RulesRequest req)
        {
             JsonResponseModel<DeleteL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public async Task<DeleteL7RulesResponse> DeleteL7Rules(DeleteL7RulesRequest req)
        {
             JsonResponseModel<DeleteL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public DeleteL7RulesResponse DeleteL7RulesSync(DeleteL7RulesRequest req)
        {
             JsonResponseModel<DeleteL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public async Task<DescribeActionLogResponse> DescribeActionLog(DescribeActionLogRequest req)
        {
             JsonResponseModel<DescribeActionLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeActionLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActionLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public DescribeActionLogResponse DescribeActionLogSync(DescribeActionLogRequest req)
        {
             JsonResponseModel<DescribeActionLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeActionLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActionLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the maximum number of layer-7 rules that can be added for Anti-DDoS Advanced.
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RuleMaxCntRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RuleMaxCntResponse"/></returns>
        public async Task<DescribeBGPIPL7RuleMaxCntResponse> DescribeBGPIPL7RuleMaxCnt(DescribeBGPIPL7RuleMaxCntRequest req)
        {
             JsonResponseModel<DescribeBGPIPL7RuleMaxCntResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBGPIPL7RuleMaxCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBGPIPL7RuleMaxCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the maximum number of layer-7 rules that can be added for Anti-DDoS Advanced.
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RuleMaxCntRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RuleMaxCntResponse"/></returns>
        public DescribeBGPIPL7RuleMaxCntResponse DescribeBGPIPL7RuleMaxCntSync(DescribeBGPIPL7RuleMaxCntRequest req)
        {
             JsonResponseModel<DescribeBGPIPL7RuleMaxCntResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBGPIPL7RuleMaxCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBGPIPL7RuleMaxCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to provide business forwarding metric data of Anti-DDoS services.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public async Task<DescribeBaradDataResponse> DescribeBaradData(DescribeBaradDataRequest req)
        {
             JsonResponseModel<DescribeBaradDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaradData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaradDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to provide business forwarding metric data of Anti-DDoS services.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public DescribeBaradDataResponse DescribeBaradDataSync(DescribeBaradDataRequest req)
        {
             JsonResponseModel<DescribeBaradDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaradData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaradDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC protection threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicCCThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicCCThresholdResponse"/></returns>
        public async Task<DescribeBasicCCThresholdResponse> DescribeBasicCCThreshold(DescribeBasicCCThresholdRequest req)
        {
             JsonResponseModel<DescribeBasicCCThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicCCThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicCCThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC protection threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicCCThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicCCThresholdResponse"/></returns>
        public DescribeBasicCCThresholdResponse DescribeBasicCCThresholdSync(DescribeBasicCCThresholdRequest req)
        {
             JsonResponseModel<DescribeBasicCCThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicCCThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicCCThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the blackhole threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public async Task<DescribeBasicDeviceThresholdResponse> DescribeBasicDeviceThreshold(DescribeBasicDeviceThresholdRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicDeviceThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the blackhole threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public DescribeBasicDeviceThresholdResponse DescribeBasicDeviceThresholdSync(DescribeBasicDeviceThresholdRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicDeviceThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public async Task<DescribeCCAlarmThresholdResponse> DescribeCCAlarmThreshold(DescribeCCAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public DescribeCCAlarmThresholdResponse DescribeCCAlarmThresholdSync(DescribeCCAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public async Task<DescribeCCEvListResponse> DescribeCCEvList(DescribeCCEvListRequest req)
        {
             JsonResponseModel<DescribeCCEvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public DescribeCCEvListResponse DescribeCCEvListSync(DescribeCCEvListRequest req)
        {
             JsonResponseModel<DescribeCCEvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DescribeCCFrequencyRulesResponse"/></returns>
        public async Task<DescribeCCFrequencyRulesResponse> DescribeCCFrequencyRules(DescribeCCFrequencyRulesRequest req)
        {
             JsonResponseModel<DescribeCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DescribeCCFrequencyRulesResponse"/></returns>
        public DescribeCCFrequencyRulesResponse DescribeCCFrequencyRulesSync(DescribeCCFrequencyRulesRequest req)
        {
             JsonResponseModel<DescribeCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public async Task<DescribeCCIpAllowDenyResponse> DescribeCCIpAllowDeny(DescribeCCIpAllowDenyRequest req)
        {
             JsonResponseModel<DescribeCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public DescribeCCIpAllowDenyResponse DescribeCCIpAllowDenySync(DescribeCCIpAllowDenyRequest req)
        {
             JsonResponseModel<DescribeCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public async Task<DescribeCCSelfDefinePolicyResponse> DescribeCCSelfDefinePolicy(DescribeCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DescribeCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public DescribeCCSelfDefinePolicyResponse DescribeCCSelfDefinePolicySync(DescribeCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DescribeCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get CC attack metric data, including total requests peak (QPS) and attack requests (QPS).
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
        /// This API is used to get CC attack metric data, including total requests peak (QPS) and attack requests (QPS).
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
        /// This API is used to get the CC URL allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public async Task<DescribeCCUrlAllowResponse> DescribeCCUrlAllow(DescribeCCUrlAllowRequest req)
        {
             JsonResponseModel<DescribeCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CC URL allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public DescribeCCUrlAllowResponse DescribeCCUrlAllowSync(DescribeCCUrlAllowRequest req)
        {
             JsonResponseModel<DescribeCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public async Task<DescribeDDoSAlarmThresholdResponse> DescribeDDoSAlarmThreshold(DescribeDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public DescribeDDoSAlarmThresholdResponse DescribeDDoSAlarmThresholdSync(DescribeDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the geographical distribution map of DDoS attack source IPs. It supports display by global regions and Chinese provinces.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackIPRegionMapRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackIPRegionMapResponse"/></returns>
        public async Task<DescribeDDoSAttackIPRegionMapResponse> DescribeDDoSAttackIPRegionMap(DescribeDDoSAttackIPRegionMapRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackIPRegionMapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackIPRegionMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackIPRegionMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the geographical distribution map of DDoS attack source IPs. It supports display by global regions and Chinese provinces.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackIPRegionMapRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackIPRegionMapResponse"/></returns>
        public DescribeDDoSAttackIPRegionMapResponse DescribeDDoSAttackIPRegionMapSync(DescribeDDoSAttackIPRegionMapRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackIPRegionMapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackIPRegionMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackIPRegionMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack source list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public async Task<DescribeDDoSAttackSourceResponse> DescribeDDoSAttackSource(DescribeDDoSAttackSourceRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack source list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public DescribeDDoSAttackSourceResponse DescribeDDoSAttackSourceSync(DescribeDDoSAttackSourceRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public async Task<DescribeDDoSCountResponse> DescribeDDoSCount(DescribeDDoSCountRequest req)
        {
             JsonResponseModel<DescribeDDoSCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public DescribeDDoSCountResponse DescribeDDoSCountSync(DescribeDDoSCountRequest req)
        {
             JsonResponseModel<DescribeDDoSCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS protection status (temporarily disabled status). It is supported for Anti-DDoS Basic, single IP instance, multi-IP instance, Anti-DDoS Advanced, and Anti-DDoS Ultimate. It is used to query whether DDoS protection is temporarily disabled, and if yes, return parameters such as temporary disablement duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public async Task<DescribeDDoSDefendStatusResponse> DescribeDDoSDefendStatus(DescribeDDoSDefendStatusRequest req)
        {
             JsonResponseModel<DescribeDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS protection status (temporarily disabled status). It is supported for Anti-DDoS Basic, single IP instance, multi-IP instance, Anti-DDoS Advanced, and Anti-DDoS Ultimate. It is used to query whether DDoS protection is temporarily disabled, and if yes, return parameters such as temporary disablement duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public DescribeDDoSDefendStatusResponse DescribeDDoSDefendStatusSync(DescribeDDoSDefendStatusRequest req)
        {
             JsonResponseModel<DescribeDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get details of a specific DDoS attack.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public async Task<DescribeDDoSEvInfoResponse> DescribeDDoSEvInfo(DescribeDDoSEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSEvInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get details of a specific DDoS attack.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public DescribeDDoSEvInfoResponse DescribeDDoSEvInfoSync(DescribeDDoSEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSEvInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public async Task<DescribeDDoSEvListResponse> DescribeDDoSEvList(DescribeDDoSEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSEvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public DescribeDDoSEvListResponse DescribeDDoSEvListSync(DescribeDDoSEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSEvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a DDoS IP attack log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public async Task<DescribeDDoSIpLogResponse> DescribeDDoSIpLog(DescribeDDoSIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSIpLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a DDoS IP attack log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public DescribeDDoSIpLogResponse DescribeDDoSIpLogSync(DescribeDDoSIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSIpLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis for an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public async Task<DescribeDDoSNetCountResponse> DescribeDDoSNetCount(DescribeDDoSNetCountRequest req)
        {
             JsonResponseModel<DescribeDDoSNetCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis for an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public DescribeDDoSNetCountResponse DescribeDDoSNetCountSync(DescribeDDoSNetCountRequest req)
        {
             JsonResponseModel<DescribeDDoSNetCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack event details of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public async Task<DescribeDDoSNetEvInfoResponse> DescribeDDoSNetEvInfo(DescribeDDoSNetEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack event details of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public DescribeDDoSNetEvInfoResponse DescribeDDoSNetEvInfoSync(DescribeDDoSNetEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public async Task<DescribeDDoSNetEvListResponse> DescribeDDoSNetEvList(DescribeDDoSNetEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public DescribeDDoSNetEvListResponse DescribeDDoSNetEvListSync(DescribeDDoSNetEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS IP attack logs of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public async Task<DescribeDDoSNetIpLogResponse> DescribeDDoSNetIpLog(DescribeDDoSNetIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSNetIpLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS IP attack logs of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public DescribeDDoSNetIpLogResponse DescribeDDoSNetIpLogSync(DescribeDDoSNetIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSNetIpLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack metric data of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public async Task<DescribeDDoSNetTrendResponse> DescribeDDoSNetTrend(DescribeDDoSNetTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSNetTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DDoS attack metric data of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public DescribeDDoSNetTrendResponse DescribeDDoSNetTrendSync(DescribeDDoSNetTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSNetTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public async Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the data of DDoS attack traffic bandwidth and attack packet rate.
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
        /// This API is used to get the data of DDoS attack traffic bandwidth and attack packet rate.
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
        /// This API is used to count the number of days of Anti-DDoS resource use and number of DDoS attacks defended against.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public async Task<DescribeDDoSUsedStatisResponse> DescribeDDoSUsedStatis(DescribeDDoSUsedStatisRequest req)
        {
             JsonResponseModel<DescribeDDoSUsedStatisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSUsedStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSUsedStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to count the number of days of Anti-DDoS resource use and number of DDoS attacks defended against.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public DescribeDDoSUsedStatisResponse DescribeDDoSUsedStatisSync(DescribeDDoSUsedStatisRequest req)
        {
             JsonResponseModel<DescribeDDoSUsedStatisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSUsedStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSUsedStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the Tencent Cloud asset information corresponding to an IP of a single IP instance or multi-IP instance, which is supported only for IPs of single IP instances and multi-IP instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public async Task<DescribeIPProductInfoResponse> DescribeIPProductInfo(DescribeIPProductInfoRequest req)
        {
             JsonResponseModel<DescribeIPProductInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the Tencent Cloud asset information corresponding to an IP of a single IP instance or multi-IP instance, which is supported only for IPs of single IP instances and multi-IP instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public DescribeIPProductInfoResponse DescribeIPProductInfoSync(DescribeIPProductInfoRequest req)
        {
             JsonResponseModel<DescribeIPProductInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the guarantee package list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public async Task<DescribeInsurePacksResponse> DescribeInsurePacks(DescribeInsurePacksRequest req)
        {
             JsonResponseModel<DescribeInsurePacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInsurePacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInsurePacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the guarantee package list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public DescribeInsurePacksResponse DescribeInsurePacksSync(DescribeInsurePacksRequest req)
        {
             JsonResponseModel<DescribeInsurePacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInsurePacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInsurePacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the blocked IP list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public async Task<DescribeIpBlockListResponse> DescribeIpBlockList(DescribeIpBlockListRequest req)
        {
             JsonResponseModel<DescribeIpBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the blocked IP list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public DescribeIpBlockListResponse DescribeIpBlockListSync(DescribeIpBlockListRequest req)
        {
             JsonResponseModel<DescribeIpBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the IP unblocking records.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public async Task<DescribeIpUnBlockListResponse> DescribeIpUnBlockList(DescribeIpUnBlockListRequest req)
        {
             JsonResponseModel<DescribeIpUnBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpUnBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpUnBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the IP unblocking records.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public DescribeIpUnBlockListResponse DescribeIpUnBlockListSync(DescribeIpUnBlockListRequest req)
        {
             JsonResponseModel<DescribeIpUnBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpUnBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpUnBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to export the layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public async Task<DescribeL4HealthConfigResponse> DescribeL4HealthConfig(DescribeL4HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to export the layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public DescribeL4HealthConfigResponse DescribeL4HealthConfigSync(DescribeL4HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the exception result of a layer-4 forwarding rule health check.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public async Task<DescribeL4RulesErrHealthResponse> DescribeL4RulesErrHealth(DescribeL4RulesErrHealthRequest req)
        {
             JsonResponseModel<DescribeL4RulesErrHealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4RulesErrHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4RulesErrHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the exception result of a layer-4 forwarding rule health check.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public DescribeL4RulesErrHealthResponse DescribeL4RulesErrHealthSync(DescribeL4RulesErrHealthRequest req)
        {
             JsonResponseModel<DescribeL4RulesErrHealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4RulesErrHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4RulesErrHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to export the layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public async Task<DescribeL7HealthConfigResponse> DescribeL7HealthConfig(DescribeL7HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to export the layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public DescribeL7HealthConfigResponse DescribeL7HealthConfigSync(DescribeL7HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the product overview statistics. It is supported for Anti-DDoS Pro, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public async Task<DescribePackIndexResponse> DescribePackIndex(DescribePackIndexRequest req)
        {
             JsonResponseModel<DescribePackIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the product overview statistics. It is supported for Anti-DDoS Pro, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public DescribePackIndexResponse DescribePackIndexSync(DescribePackIndexRequest req)
        {
             JsonResponseModel<DescribePackIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download the PCAP packet of an attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public async Task<DescribePcapResponse> DescribePcap(DescribePcapRequest req)
        {
             JsonResponseModel<DescribePcapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePcap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePcapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download the PCAP packet of an attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public DescribePcapResponse DescribePcapSync(DescribePcapRequest req)
        {
             JsonResponseModel<DescribePcapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePcap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePcapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public async Task<DescribePolicyCaseResponse> DescribePolicyCase(DescribePolicyCaseRequest req)
        {
             JsonResponseModel<DescribePolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public DescribePolicyCaseResponse DescribePolicyCaseSync(DescribePolicyCaseRequest req)
        {
             JsonResponseModel<DescribePolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the IP list of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public async Task<DescribeResIpListResponse> DescribeResIpList(DescribeResIpListRequest req)
        {
             JsonResponseModel<DescribeResIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the IP list of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public DescribeResIpListResponse DescribeResIpListSync(DescribeResIpListRequest req)
        {
             JsonResponseModel<DescribeResIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the resource list.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public async Task<DescribeResourceListResponse> DescribeResourceList(DescribeResourceListRequest req)
        {
             JsonResponseModel<DescribeResourceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the resource list.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public DescribeResourceListResponse DescribeResourceListSync(DescribeResourceListRequest req)
        {
             JsonResponseModel<DescribeResourceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of rules of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public async Task<DescribeRuleSetsResponse> DescribeRuleSets(DescribeRuleSetsRequest req)
        {
             JsonResponseModel<DescribeRuleSetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of rules of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public DescribeRuleSetsResponse DescribeRuleSetsSync(DescribeRuleSetsRequest req)
        {
             JsonResponseModel<DescribeRuleSetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Get scheduling domain name list
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulingDomainListRequest"/></param>
        /// <returns><see cref="DescribeSchedulingDomainListResponse"/></returns>
        public async Task<DescribeSchedulingDomainListResponse> DescribeSchedulingDomainList(DescribeSchedulingDomainListRequest req)
        {
             JsonResponseModel<DescribeSchedulingDomainListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSchedulingDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSchedulingDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Get scheduling domain name list
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulingDomainListRequest"/></param>
        /// <returns><see cref="DescribeSchedulingDomainListResponse"/></returns>
        public DescribeSchedulingDomainListResponse DescribeSchedulingDomainListSync(DescribeSchedulingDomainListRequest req)
        {
             JsonResponseModel<DescribeSchedulingDomainListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSchedulingDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSchedulingDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the security statistics of the current month.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public async Task<DescribeSecIndexResponse> DescribeSecIndex(DescribeSecIndexRequest req)
        {
             JsonResponseModel<DescribeSecIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the security statistics of the current month.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public DescribeSecIndexResponse DescribeSecIndexSync(DescribeSecIndexRequest req)
        {
             JsonResponseModel<DescribeSecIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the intermediate IP range. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public async Task<DescribeSourceIpSegmentResponse> DescribeSourceIpSegment(DescribeSourceIpSegmentRequest req)
        {
             JsonResponseModel<DescribeSourceIpSegmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSourceIpSegment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceIpSegmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the intermediate IP range. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public DescribeSourceIpSegmentResponse DescribeSourceIpSegmentSync(DescribeSourceIpSegmentRequest req)
        {
             JsonResponseModel<DescribeSourceIpSegmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSourceIpSegment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceIpSegmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the business forwarding statistics, including forwarded traffic and packet forwarding rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public async Task<DescribeTransmitStatisResponse> DescribeTransmitStatis(DescribeTransmitStatisRequest req)
        {
             JsonResponseModel<DescribeTransmitStatisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTransmitStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTransmitStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the business forwarding statistics, including forwarded traffic and packet forwarding rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public DescribeTransmitStatisResponse DescribeTransmitStatisSync(DescribeTransmitStatisRequest req)
        {
             JsonResponseModel<DescribeTransmitStatisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTransmitStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTransmitStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of blackhole unblockings.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public async Task<DescribeUnBlockStatisResponse> DescribeUnBlockStatis(DescribeUnBlockStatisRequest req)
        {
             JsonResponseModel<DescribeUnBlockStatisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnBlockStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnBlockStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of blackhole unblockings.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public DescribeUnBlockStatisResponse DescribeUnBlockStatisSync(DescribeUnBlockStatisRequest req)
        {
             JsonResponseModel<DescribeUnBlockStatisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnBlockStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnBlockStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public async Task<DescribleL4RulesResponse> DescribleL4Rules(DescribleL4RulesRequest req)
        {
             JsonResponseModel<DescribleL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribleL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public DescribleL4RulesResponse DescribleL4RulesSync(DescribleL4RulesRequest req)
        {
             JsonResponseModel<DescribleL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribleL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public async Task<DescribleL7RulesResponse> DescribleL7Rules(DescribleL7RulesRequest req)
        {
             JsonResponseModel<DescribleL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribleL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public DescribleL7RulesResponse DescribleL7RulesSync(DescribleL7RulesRequest req)
        {
             JsonResponseModel<DescribleL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribleL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of resource instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public async Task<DescribleRegionCountResponse> DescribleRegionCount(DescribleRegionCountRequest req)
        {
             JsonResponseModel<DescribleRegionCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribleRegionCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleRegionCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of resource instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public DescribleRegionCountResponse DescribleRegionCountSync(DescribleRegionCountRequest req)
        {
             JsonResponseModel<DescribleRegionCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribleRegionCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleRegionCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public async Task<ModifyCCAlarmThresholdResponse> ModifyCCAlarmThreshold(ModifyCCAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public ModifyCCAlarmThresholdResponse ModifyCCAlarmThresholdSync(ModifyCCAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesResponse"/></returns>
        public async Task<ModifyCCFrequencyRulesResponse> ModifyCCFrequencyRules(ModifyCCFrequencyRulesRequest req)
        {
             JsonResponseModel<ModifyCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesResponse"/></returns>
        public ModifyCCFrequencyRulesResponse ModifyCCFrequencyRulesSync(ModifyCCFrequencyRulesRequest req)
        {
             JsonResponseModel<ModifyCCFrequencyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCFrequencyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCFrequencyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesStatusResponse"/></returns>
        public async Task<ModifyCCFrequencyRulesStatusResponse> ModifyCCFrequencyRulesStatus(ModifyCCFrequencyRulesStatusRequest req)
        {
             JsonResponseModel<ModifyCCFrequencyRulesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCFrequencyRulesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCFrequencyRulesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesStatusResponse"/></returns>
        public ModifyCCFrequencyRulesStatusResponse ModifyCCFrequencyRulesStatusSync(ModifyCCFrequencyRulesStatusRequest req)
        {
             JsonResponseModel<ModifyCCFrequencyRulesStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCFrequencyRulesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCFrequencyRulesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable CC domain name protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public async Task<ModifyCCHostProtectionResponse> ModifyCCHostProtection(ModifyCCHostProtectionRequest req)
        {
             JsonResponseModel<ModifyCCHostProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCHostProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCHostProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable CC domain name protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public ModifyCCHostProtectionResponse ModifyCCHostProtectionSync(ModifyCCHostProtectionRequest req)
        {
             JsonResponseModel<ModifyCCHostProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCHostProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCHostProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add/remove a CC IP to/from the blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public async Task<ModifyCCIpAllowDenyResponse> ModifyCCIpAllowDeny(ModifyCCIpAllowDenyRequest req)
        {
             JsonResponseModel<ModifyCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add/remove a CC IP to/from the blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public ModifyCCIpAllowDenyResponse ModifyCCIpAllowDenySync(ModifyCCIpAllowDenyRequest req)
        {
             JsonResponseModel<ModifyCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify CC protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public async Task<ModifyCCLevelResponse> ModifyCCLevel(ModifyCCLevelRequest req)
        {
             JsonResponseModel<ModifyCCLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify CC protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public ModifyCCLevelResponse ModifyCCLevelSync(ModifyCCLevelRequest req)
        {
             JsonResponseModel<ModifyCCLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public async Task<ModifyCCPolicySwitchResponse> ModifyCCPolicySwitch(ModifyCCPolicySwitchRequest req)
        {
             JsonResponseModel<ModifyCCPolicySwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCPolicySwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPolicySwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public ModifyCCPolicySwitchResponse ModifyCCPolicySwitchSync(ModifyCCPolicySwitchRequest req)
        {
             JsonResponseModel<ModifyCCPolicySwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCPolicySwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPolicySwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public async Task<ModifyCCSelfDefinePolicyResponse> ModifyCCSelfDefinePolicy(ModifyCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<ModifyCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public ModifyCCSelfDefinePolicyResponse ModifyCCSelfDefinePolicySync(ModifyCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<ModifyCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the CC protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public async Task<ModifyCCThresholdResponse> ModifyCCThreshold(ModifyCCThresholdRequest req)
        {
             JsonResponseModel<ModifyCCThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the CC protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public ModifyCCThresholdResponse ModifyCCThresholdSync(ModifyCCThresholdRequest req)
        {
             JsonResponseModel<ModifyCCThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add/remove a CC URL to/from the allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public async Task<ModifyCCUrlAllowResponse> ModifyCCUrlAllow(ModifyCCUrlAllowRequest req)
        {
             JsonResponseModel<ModifyCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add/remove a CC URL to/from the allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public ModifyCCUrlAllowResponse ModifyCCUrlAllowSync(ModifyCCUrlAllowRequest req)
        {
             JsonResponseModel<ModifyCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read or modify DDoS AI protection status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public async Task<ModifyDDoSAIStatusResponse> ModifyDDoSAIStatus(ModifyDDoSAIStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSAIStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSAIStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAIStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read or modify DDoS AI protection status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public ModifyDDoSAIStatusResponse ModifyDDoSAIStatusSync(ModifyDDoSAIStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSAIStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSAIStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAIStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public async Task<ModifyDDoSAlarmThresholdResponse> ModifyDDoSAlarmThreshold(ModifyDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public ModifyDDoSAlarmThresholdResponse ModifyDDoSAlarmThresholdSync(ModifyDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable DDoS. It can disable DDoS protection for a period of time, which will be automatically enabled after the period of time elapses.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public async Task<ModifyDDoSDefendStatusResponse> ModifyDDoSDefendStatus(ModifyDDoSDefendStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable DDoS. It can disable DDoS protection for a period of time, which will be automatically enabled after the period of time elapses.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public ModifyDDoSDefendStatusResponse ModifyDDoSDefendStatusSync(ModifyDDoSDefendStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read or modify DDoS protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public async Task<ModifyDDoSLevelResponse> ModifyDDoSLevel(ModifyDDoSLevelRequest req)
        {
             JsonResponseModel<ModifyDDoSLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read or modify DDoS protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public ModifyDDoSLevelResponse ModifyDDoSLevelSync(ModifyDDoSLevelRequest req)
        {
             JsonResponseModel<ModifyDDoSLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public async Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public async Task<ModifyDDoSPolicyCaseResponse> ModifyDDoSPolicyCase(ModifyDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public ModifyDDoSPolicyCaseResponse ModifyDDoSPolicyCaseSync(ModifyDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public async Task<ModifyDDoSPolicyNameResponse> ModifyDDoSPolicyName(ModifyDDoSPolicyNameRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicyName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public ModifyDDoSPolicyNameResponse ModifyDDoSPolicyNameSync(ModifyDDoSPolicyNameRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicyName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable DDoS protection, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public async Task<ModifyDDoSSwitchResponse> ModifyDDoSSwitch(ModifyDDoSSwitchRequest req)
        {
             JsonResponseModel<ModifyDDoSSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable DDoS protection, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public ModifyDDoSSwitchResponse ModifyDDoSSwitchSync(ModifyDDoSSwitchRequest req)
        {
             JsonResponseModel<ModifyDDoSSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the DDoS cleansing threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public async Task<ModifyDDoSThresholdResponse> ModifyDDoSThreshold(ModifyDDoSThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the DDoS cleansing threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public ModifyDDoSThresholdResponse ModifyDDoSThresholdSync(ModifyDDoSThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add, delete, enable, or disable a watermark key.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public async Task<ModifyDDoSWaterKeyResponse> ModifyDDoSWaterKey(ModifyDDoSWaterKeyRequest req)
        {
             JsonResponseModel<ModifyDDoSWaterKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSWaterKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSWaterKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add, delete, enable, or disable a watermark key.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public ModifyDDoSWaterKeyResponse ModifyDDoSWaterKeySync(ModifyDDoSWaterKeyRequest req)
        {
             JsonResponseModel<ModifyDDoSWaterKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSWaterKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSWaterKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the elastic protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public async Task<ModifyElasticLimitResponse> ModifyElasticLimit(ModifyElasticLimitRequest req)
        {
             JsonResponseModel<ModifyElasticLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyElasticLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyElasticLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the elastic protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public ModifyElasticLimitResponse ModifyElasticLimitSync(ModifyElasticLimitRequest req)
        {
             JsonResponseModel<ModifyElasticLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyElasticLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyElasticLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the health check parameters of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public async Task<ModifyL4HealthResponse> ModifyL4Health(ModifyL4HealthRequest req)
        {
             JsonResponseModel<ModifyL4HealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4Health");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4HealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the health check parameters of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public ModifyL4HealthResponse ModifyL4HealthSync(ModifyL4HealthRequest req)
        {
             JsonResponseModel<ModifyL4HealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4Health");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4HealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the session persistence of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public async Task<ModifyL4KeepTimeResponse> ModifyL4KeepTime(ModifyL4KeepTimeRequest req)
        {
             JsonResponseModel<ModifyL4KeepTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4KeepTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4KeepTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the session persistence of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public ModifyL4KeepTimeResponse ModifyL4KeepTimeSync(ModifyL4KeepTimeRequest req)
        {
             JsonResponseModel<ModifyL4KeepTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4KeepTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4KeepTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public async Task<ModifyL4RulesResponse> ModifyL4Rules(ModifyL4RulesRequest req)
        {
             JsonResponseModel<ModifyL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public ModifyL4RulesResponse ModifyL4RulesSync(ModifyL4RulesRequest req)
        {
             JsonResponseModel<ModifyL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public async Task<ModifyL7RulesResponse> ModifyL7Rules(ModifyL7RulesRequest req)
        {
             JsonResponseModel<ModifyL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public ModifyL7RulesResponse ModifyL7RulesSync(ModifyL7RulesRequest req)
        {
             JsonResponseModel<ModifyL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch a client to the real server and set the switch duration when the client is under attack or blocked.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetReturnSwitchRequest"/></param>
        /// <returns><see cref="ModifyNetReturnSwitchResponse"/></returns>
        public async Task<ModifyNetReturnSwitchResponse> ModifyNetReturnSwitch(ModifyNetReturnSwitchRequest req)
        {
             JsonResponseModel<ModifyNetReturnSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetReturnSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetReturnSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch a client to the real server and set the switch duration when the client is under attack or blocked.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetReturnSwitchRequest"/></param>
        /// <returns><see cref="ModifyNetReturnSwitchResponse"/></returns>
        public ModifyNetReturnSwitchResponse ModifyNetReturnSwitchSync(ModifyNetReturnSwitchRequest req)
        {
             JsonResponseModel<ModifyNetReturnSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetReturnSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetReturnSwitchResponse>>(strResp);
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
        /// This API is used to modify layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewL4RuleRequest"/></param>
        /// <returns><see cref="ModifyNewL4RuleResponse"/></returns>
        public async Task<ModifyNewL4RuleResponse> ModifyNewL4Rule(ModifyNewL4RuleRequest req)
        {
             JsonResponseModel<ModifyNewL4RuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNewL4Rule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewL4RuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewL4RuleRequest"/></param>
        /// <returns><see cref="ModifyNewL4RuleResponse"/></returns>
        public ModifyNewL4RuleResponse ModifyNewL4RuleSync(ModifyNewL4RuleRequest req)
        {
             JsonResponseModel<ModifyNewL4RuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNewL4Rule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewL4RuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an advanced DDoS policy to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public async Task<ModifyResBindDDoSPolicyResponse> ModifyResBindDDoSPolicy(ModifyResBindDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyResBindDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResBindDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResBindDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an advanced DDoS policy to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public ModifyResBindDDoSPolicyResponse ModifyResBindDDoSPolicySync(ModifyResBindDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyResBindDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResBindDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResBindDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable auto-renewal for a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public async Task<ModifyResourceRenewFlagResponse> ModifyResourceRenewFlag(ModifyResourceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyResourceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable auto-renewal for a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public ModifyResourceRenewFlagResponse ModifyResourceRenewFlagSync(ModifyResourceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyResourceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
