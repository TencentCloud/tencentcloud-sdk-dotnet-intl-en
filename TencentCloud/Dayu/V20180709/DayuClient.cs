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
       private const string sdkVersion = "SDK_NET_3.0.876";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DayuClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to set the DDoS alarm threshold for Anti-DDoS Basic, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public Task<CreateBasicDDoSAlarmThresholdResponse> CreateBasicDDoSAlarmThreshold(CreateBasicDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateBasicDDoSAlarmThresholdResponse>(req, "CreateBasicDDoSAlarmThreshold");
        }

        /// <summary>
        /// This API is used to set the DDoS alarm threshold for Anti-DDoS Basic, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public CreateBasicDDoSAlarmThresholdResponse CreateBasicDDoSAlarmThresholdSync(CreateBasicDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateBasicDDoSAlarmThresholdResponse>(req, "CreateBasicDDoSAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance, which supports both single IP instances and multi-IP instances. It should be noted that this API is async; therefore, if a binding/unbinding operation is in progress, new binding/unbinding operations cannot be initiated.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP");
        }

        /// <summary>
        /// This API is used to bind an IP to an Anti-DDoS Pro instance, which supports both single IP instances and multi-IP instances. It should be noted that this API is async; therefore, if a binding/unbinding operation is in progress, new binding/unbinding operations cannot be initiated.
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="CreateCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="CreateCCFrequencyRulesResponse"/></returns>
        public Task<CreateCCFrequencyRulesResponse> CreateCCFrequencyRules(CreateCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<CreateCCFrequencyRulesResponse>(req, "CreateCCFrequencyRules");
        }

        /// <summary>
        /// This API is used to add an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="CreateCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="CreateCCFrequencyRulesResponse"/></returns>
        public CreateCCFrequencyRulesResponse CreateCCFrequencyRulesSync(CreateCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<CreateCCFrequencyRulesResponse>(req, "CreateCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public Task<CreateCCSelfDefinePolicyResponse> CreateCCSelfDefinePolicy(CreateCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<CreateCCSelfDefinePolicyResponse>(req, "CreateCCSelfDefinePolicy");
        }

        /// <summary>
        /// This API is used to create a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public CreateCCSelfDefinePolicyResponse CreateCCSelfDefinePolicySync(CreateCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<CreateCCSelfDefinePolicyResponse>(req, "CreateCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public Task<CreateDDoSPolicyResponse> CreateDDoSPolicy(CreateDDoSPolicyRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyResponse>(req, "CreateDDoSPolicy");
        }

        /// <summary>
        /// This API is used to add an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public CreateDDoSPolicyResponse CreateDDoSPolicySync(CreateDDoSPolicyRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyResponse>(req, "CreateDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public Task<CreateDDoSPolicyCaseResponse> CreateDDoSPolicyCase(CreateDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyCaseResponse>(req, "CreateDDoSPolicyCase");
        }

        /// <summary>
        /// This API is used to add a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public CreateDDoSPolicyCaseResponse CreateDDoSPolicyCaseSync(CreateDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyCaseResponse>(req, "CreateDDoSPolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a resource instance, which supports single IP instances, multi-IP instances, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public Task<CreateInstanceNameResponse> CreateInstanceName(CreateInstanceNameRequest req)
        {
            return InternalRequestAsync<CreateInstanceNameResponse>(req, "CreateInstanceName");
        }

        /// <summary>
        /// This API is used to rename a resource instance, which supports single IP instances, multi-IP instances, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public CreateInstanceNameResponse CreateInstanceNameSync(CreateInstanceNameRequest req)
        {
            return InternalRequestAsync<CreateInstanceNameResponse>(req, "CreateInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public Task<CreateL4HealthConfigResponse> CreateL4HealthConfig(CreateL4HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL4HealthConfigResponse>(req, "CreateL4HealthConfig");
        }

        /// <summary>
        /// This API is used to upload layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public CreateL4HealthConfigResponse CreateL4HealthConfigSync(CreateL4HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL4HealthConfigResponse>(req, "CreateL4HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public Task<CreateL4RulesResponse> CreateL4Rules(CreateL4RulesRequest req)
        {
            return InternalRequestAsync<CreateL4RulesResponse>(req, "CreateL4Rules");
        }

        /// <summary>
        /// This API is used to add a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public CreateL4RulesResponse CreateL4RulesSync(CreateL4RulesRequest req)
        {
            return InternalRequestAsync<CreateL4RulesResponse>(req, "CreateL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a custom frequency control rule for layer-7 CC access (it works in the IP + Host dimension and does not support specific URIs). As it has been disused, please call the new `CreateCCFrequencyRules` API, which supports both IP + Host and URI.
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public Task<CreateL7CCRuleResponse> CreateL7CCRule(CreateL7CCRuleRequest req)
        {
            return InternalRequestAsync<CreateL7CCRuleResponse>(req, "CreateL7CCRule");
        }

        /// <summary>
        /// This API is used to add a custom frequency control rule for layer-7 CC access (it works in the IP + Host dimension and does not support specific URIs). As it has been disused, please call the new `CreateCCFrequencyRules` API, which supports both IP + Host and URI.
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public CreateL7CCRuleResponse CreateL7CCRuleSync(CreateL7CCRuleRequest req)
        {
            return InternalRequestAsync<CreateL7CCRuleResponse>(req, "CreateL7CCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public Task<CreateL7HealthConfigResponse> CreateL7HealthConfig(CreateL7HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL7HealthConfigResponse>(req, "CreateL7HealthConfig");
        }

        /// <summary>
        /// This API is used to upload layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public CreateL7HealthConfigResponse CreateL7HealthConfigSync(CreateL7HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL7HealthConfigResponse>(req, "CreateL7HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure a certificate for a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public Task<CreateL7RuleCertResponse> CreateL7RuleCert(CreateL7RuleCertRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertResponse>(req, "CreateL7RuleCert");
        }

        /// <summary>
        /// This API is used to configure a certificate for a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public CreateL7RuleCertResponse CreateL7RuleCertSync(CreateL7RuleCertRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertResponse>(req, "CreateL7RuleCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a layer-7 (website) forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public Task<CreateL7RulesResponse> CreateL7Rules(CreateL7RulesRequest req)
        {
            return InternalRequestAsync<CreateL7RulesResponse>(req, "CreateL7Rules");
        }

        /// <summary>
        /// This API is used to add a layer-7 (website) forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public CreateL7RulesResponse CreateL7RulesSync(CreateL7RulesRequest req)
        {
            return InternalRequestAsync<CreateL7RulesResponse>(req, "CreateL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload layer-7 forwarding rules in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public Task<CreateL7RulesUploadResponse> CreateL7RulesUpload(CreateL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateL7RulesUploadResponse>(req, "CreateL7RulesUpload");
        }

        /// <summary>
        /// This API is used to upload layer-7 forwarding rules in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public CreateL7RulesUploadResponse CreateL7RulesUploadSync(CreateL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateL7RulesUploadResponse>(req, "CreateL7RulesUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch to the real server in Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateNetReturnRequest"/></param>
        /// <returns><see cref="CreateNetReturnResponse"/></returns>
        public Task<CreateNetReturnResponse> CreateNetReturn(CreateNetReturnRequest req)
        {
            return InternalRequestAsync<CreateNetReturnResponse>(req, "CreateNetReturn");
        }

        /// <summary>
        /// This API is used to switch to the real server in Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="CreateNetReturnRequest"/></param>
        /// <returns><see cref="CreateNetReturnResponse"/></returns>
        public CreateNetReturnResponse CreateNetReturnSync(CreateNetReturnRequest req)
        {
            return InternalRequestAsync<CreateNetReturnResponse>(req, "CreateNetReturn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch upload Layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesUploadResponse"/></returns>
        public Task<CreateNewL7RulesUploadResponse> CreateNewL7RulesUpload(CreateNewL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesUploadResponse>(req, "CreateNewL7RulesUpload");
        }

        /// <summary>
        /// This API is used to batch upload Layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesUploadResponse"/></returns>
        public CreateNewL7RulesUploadResponse CreateNewL7RulesUploadSync(CreateNewL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesUploadResponse>(req, "CreateNewL7RulesUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unblock an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public Task<CreateUnblockIpResponse> CreateUnblockIp(CreateUnblockIpRequest req)
        {
            return InternalRequestAsync<CreateUnblockIpResponse>(req, "CreateUnblockIp");
        }

        /// <summary>
        /// This API is used to unblock an IP.
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public CreateUnblockIpResponse CreateUnblockIpSync(CreateUnblockIpRequest req)
        {
            return InternalRequestAsync<CreateUnblockIpResponse>(req, "CreateUnblockIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DeleteCCFrequencyRulesResponse"/></returns>
        public Task<DeleteCCFrequencyRulesResponse> DeleteCCFrequencyRules(DeleteCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DeleteCCFrequencyRulesResponse>(req, "DeleteCCFrequencyRules");
        }

        /// <summary>
        /// This API is used to delete an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DeleteCCFrequencyRulesResponse"/></returns>
        public DeleteCCFrequencyRulesResponse DeleteCCFrequencyRulesSync(DeleteCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DeleteCCFrequencyRulesResponse>(req, "DeleteCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public Task<DeleteCCSelfDefinePolicyResponse> DeleteCCSelfDefinePolicy(DeleteCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCSelfDefinePolicyResponse>(req, "DeleteCCSelfDefinePolicy");
        }

        /// <summary>
        /// This API is used to delete a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public DeleteCCSelfDefinePolicyResponse DeleteCCSelfDefinePolicySync(DeleteCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCSelfDefinePolicyResponse>(req, "DeleteCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an advanced DDoS protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public Task<DeleteDDoSPolicyResponse> DeleteDDoSPolicy(DeleteDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyResponse>(req, "DeleteDDoSPolicy");
        }

        /// <summary>
        /// This API is used to delete an advanced DDoS protection policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public DeleteDDoSPolicyResponse DeleteDDoSPolicySync(DeleteDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyResponse>(req, "DeleteDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public Task<DeleteDDoSPolicyCaseResponse> DeleteDDoSPolicyCase(DeleteDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyCaseResponse>(req, "DeleteDDoSPolicyCase");
        }

        /// <summary>
        /// This API is used to delete a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public DeleteDDoSPolicyCaseResponse DeleteDDoSPolicyCaseSync(DeleteDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyCaseResponse>(req, "DeleteDDoSPolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public Task<DeleteL4RulesResponse> DeleteL4Rules(DeleteL4RulesRequest req)
        {
            return InternalRequestAsync<DeleteL4RulesResponse>(req, "DeleteL4Rules");
        }

        /// <summary>
        /// This API is used to delete one or more layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public DeleteL4RulesResponse DeleteL4RulesSync(DeleteL4RulesRequest req)
        {
            return InternalRequestAsync<DeleteL4RulesResponse>(req, "DeleteL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public Task<DeleteL7RulesResponse> DeleteL7Rules(DeleteL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteL7RulesResponse>(req, "DeleteL7Rules");
        }

        /// <summary>
        /// This API is used to delete one or more layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public DeleteL7RulesResponse DeleteL7RulesSync(DeleteL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteL7RulesResponse>(req, "DeleteL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public Task<DescribeActionLogResponse> DescribeActionLog(DescribeActionLogRequest req)
        {
            return InternalRequestAsync<DescribeActionLogResponse>(req, "DescribeActionLog");
        }

        /// <summary>
        /// This API is used to get operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public DescribeActionLogResponse DescribeActionLogSync(DescribeActionLogRequest req)
        {
            return InternalRequestAsync<DescribeActionLogResponse>(req, "DescribeActionLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the maximum number of layer-7 rules that can be added for Anti-DDoS Advanced.
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RuleMaxCntRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RuleMaxCntResponse"/></returns>
        public Task<DescribeBGPIPL7RuleMaxCntResponse> DescribeBGPIPL7RuleMaxCnt(DescribeBGPIPL7RuleMaxCntRequest req)
        {
            return InternalRequestAsync<DescribeBGPIPL7RuleMaxCntResponse>(req, "DescribeBGPIPL7RuleMaxCnt");
        }

        /// <summary>
        /// This API is used to get the maximum number of layer-7 rules that can be added for Anti-DDoS Advanced.
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RuleMaxCntRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RuleMaxCntResponse"/></returns>
        public DescribeBGPIPL7RuleMaxCntResponse DescribeBGPIPL7RuleMaxCntSync(DescribeBGPIPL7RuleMaxCntRequest req)
        {
            return InternalRequestAsync<DescribeBGPIPL7RuleMaxCntResponse>(req, "DescribeBGPIPL7RuleMaxCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to provide business forwarding metric data of Anti-DDoS services.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public Task<DescribeBaradDataResponse> DescribeBaradData(DescribeBaradDataRequest req)
        {
            return InternalRequestAsync<DescribeBaradDataResponse>(req, "DescribeBaradData");
        }

        /// <summary>
        /// This API is used to provide business forwarding metric data of Anti-DDoS services.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public DescribeBaradDataResponse DescribeBaradDataSync(DescribeBaradDataRequest req)
        {
            return InternalRequestAsync<DescribeBaradDataResponse>(req, "DescribeBaradData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CC protection threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicCCThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicCCThresholdResponse"/></returns>
        public Task<DescribeBasicCCThresholdResponse> DescribeBasicCCThreshold(DescribeBasicCCThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicCCThresholdResponse>(req, "DescribeBasicCCThreshold");
        }

        /// <summary>
        /// This API is used to get the CC protection threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicCCThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicCCThresholdResponse"/></returns>
        public DescribeBasicCCThresholdResponse DescribeBasicCCThresholdSync(DescribeBasicCCThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicCCThresholdResponse>(req, "DescribeBasicCCThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the blackhole threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public Task<DescribeBasicDeviceThresholdResponse> DescribeBasicDeviceThreshold(DescribeBasicDeviceThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceThresholdResponse>(req, "DescribeBasicDeviceThreshold");
        }

        /// <summary>
        /// This API is used to get the blackhole threshold of Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public DescribeBasicDeviceThresholdResponse DescribeBasicDeviceThresholdSync(DescribeBasicDeviceThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceThresholdResponse>(req, "DescribeBasicDeviceThreshold")
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
        /// This API is used to get the alarm notification threshold set for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public Task<DescribeCCAlarmThresholdResponse> DescribeCCAlarmThreshold(DescribeCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeCCAlarmThresholdResponse>(req, "DescribeCCAlarmThreshold");
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public DescribeCCAlarmThresholdResponse DescribeCCAlarmThresholdSync(DescribeCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeCCAlarmThresholdResponse>(req, "DescribeCCAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CC attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public Task<DescribeCCEvListResponse> DescribeCCEvList(DescribeCCEvListRequest req)
        {
            return InternalRequestAsync<DescribeCCEvListResponse>(req, "DescribeCCEvList");
        }

        /// <summary>
        /// This API is used to get the CC attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public DescribeCCEvListResponse DescribeCCEvListSync(DescribeCCEvListRequest req)
        {
            return InternalRequestAsync<DescribeCCEvListResponse>(req, "DescribeCCEvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DescribeCCFrequencyRulesResponse"/></returns>
        public Task<DescribeCCFrequencyRulesResponse> DescribeCCFrequencyRules(DescribeCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DescribeCCFrequencyRulesResponse>(req, "DescribeCCFrequencyRules");
        }

        /// <summary>
        /// This API is used to get an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DescribeCCFrequencyRulesResponse"/></returns>
        public DescribeCCFrequencyRulesResponse DescribeCCFrequencyRulesSync(DescribeCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DescribeCCFrequencyRulesResponse>(req, "DescribeCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CC IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public Task<DescribeCCIpAllowDenyResponse> DescribeCCIpAllowDeny(DescribeCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<DescribeCCIpAllowDenyResponse>(req, "DescribeCCIpAllowDeny");
        }

        /// <summary>
        /// This API is used to get the CC IP blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public DescribeCCIpAllowDenyResponse DescribeCCIpAllowDenySync(DescribeCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<DescribeCCIpAllowDenyResponse>(req, "DescribeCCIpAllowDeny")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public Task<DescribeCCSelfDefinePolicyResponse> DescribeCCSelfDefinePolicy(DescribeCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCSelfDefinePolicyResponse>(req, "DescribeCCSelfDefinePolicy");
        }

        /// <summary>
        /// This API is used to get a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public DescribeCCSelfDefinePolicyResponse DescribeCCSelfDefinePolicySync(DescribeCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCSelfDefinePolicyResponse>(req, "DescribeCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get CC attack metric data, including total requests peak (QPS) and attack requests (QPS).
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend");
        }

        /// <summary>
        /// This API is used to get CC attack metric data, including total requests peak (QPS) and attack requests (QPS).
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CC URL allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public Task<DescribeCCUrlAllowResponse> DescribeCCUrlAllow(DescribeCCUrlAllowRequest req)
        {
            return InternalRequestAsync<DescribeCCUrlAllowResponse>(req, "DescribeCCUrlAllow");
        }

        /// <summary>
        /// This API is used to get the CC URL allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public DescribeCCUrlAllowResponse DescribeCCUrlAllowSync(DescribeCCUrlAllowRequest req)
        {
            return InternalRequestAsync<DescribeCCUrlAllowResponse>(req, "DescribeCCUrlAllow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public Task<DescribeDDoSAlarmThresholdResponse> DescribeDDoSAlarmThreshold(DescribeDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAlarmThresholdResponse>(req, "DescribeDDoSAlarmThreshold");
        }

        /// <summary>
        /// This API is used to get the alarm notification threshold set for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public DescribeDDoSAlarmThresholdResponse DescribeDDoSAlarmThresholdSync(DescribeDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAlarmThresholdResponse>(req, "DescribeDDoSAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the geographical distribution map of DDoS attack source IPs. It supports display by global regions and Chinese provinces.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackIPRegionMapRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackIPRegionMapResponse"/></returns>
        public Task<DescribeDDoSAttackIPRegionMapResponse> DescribeDDoSAttackIPRegionMap(DescribeDDoSAttackIPRegionMapRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackIPRegionMapResponse>(req, "DescribeDDoSAttackIPRegionMap");
        }

        /// <summary>
        /// This API is used to get the geographical distribution map of DDoS attack source IPs. It supports display by global regions and Chinese provinces.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackIPRegionMapRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackIPRegionMapResponse"/></returns>
        public DescribeDDoSAttackIPRegionMapResponse DescribeDDoSAttackIPRegionMapSync(DescribeDDoSAttackIPRegionMapRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackIPRegionMapResponse>(req, "DescribeDDoSAttackIPRegionMap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack source list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public Task<DescribeDDoSAttackSourceResponse> DescribeDDoSAttackSource(DescribeDDoSAttackSourceRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackSourceResponse>(req, "DescribeDDoSAttackSource");
        }

        /// <summary>
        /// This API is used to get the DDoS attack source list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public DescribeDDoSAttackSourceResponse DescribeDDoSAttackSourceSync(DescribeDDoSAttackSourceRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackSourceResponse>(req, "DescribeDDoSAttackSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public Task<DescribeDDoSCountResponse> DescribeDDoSCount(DescribeDDoSCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSCountResponse>(req, "DescribeDDoSCount");
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public DescribeDDoSCountResponse DescribeDDoSCountSync(DescribeDDoSCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSCountResponse>(req, "DescribeDDoSCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS protection status (temporarily disabled status). It is supported for Anti-DDoS Basic, single IP instance, multi-IP instance, Anti-DDoS Advanced, and Anti-DDoS Ultimate. It is used to query whether DDoS protection is temporarily disabled, and if yes, return parameters such as temporary disablement duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public Task<DescribeDDoSDefendStatusResponse> DescribeDDoSDefendStatus(DescribeDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<DescribeDDoSDefendStatusResponse>(req, "DescribeDDoSDefendStatus");
        }

        /// <summary>
        /// This API is used to get the DDoS protection status (temporarily disabled status). It is supported for Anti-DDoS Basic, single IP instance, multi-IP instance, Anti-DDoS Advanced, and Anti-DDoS Ultimate. It is used to query whether DDoS protection is temporarily disabled, and if yes, return parameters such as temporary disablement duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public DescribeDDoSDefendStatusResponse DescribeDDoSDefendStatusSync(DescribeDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<DescribeDDoSDefendStatusResponse>(req, "DescribeDDoSDefendStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get details of a specific DDoS attack.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public Task<DescribeDDoSEvInfoResponse> DescribeDDoSEvInfo(DescribeDDoSEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvInfoResponse>(req, "DescribeDDoSEvInfo");
        }

        /// <summary>
        /// This API is used to get details of a specific DDoS attack.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public DescribeDDoSEvInfoResponse DescribeDDoSEvInfoSync(DescribeDDoSEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvInfoResponse>(req, "DescribeDDoSEvInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public Task<DescribeDDoSEvListResponse> DescribeDDoSEvList(DescribeDDoSEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvListResponse>(req, "DescribeDDoSEvList");
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public DescribeDDoSEvListResponse DescribeDDoSEvListSync(DescribeDDoSEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvListResponse>(req, "DescribeDDoSEvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a DDoS IP attack log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public Task<DescribeDDoSIpLogResponse> DescribeDDoSIpLog(DescribeDDoSIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSIpLogResponse>(req, "DescribeDDoSIpLog");
        }

        /// <summary>
        /// This API is used to get a DDoS IP attack log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public DescribeDDoSIpLogResponse DescribeDDoSIpLogSync(DescribeDDoSIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSIpLogResponse>(req, "DescribeDDoSIpLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis for an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public Task<DescribeDDoSNetCountResponse> DescribeDDoSNetCount(DescribeDDoSNetCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetCountResponse>(req, "DescribeDDoSNetCount");
        }

        /// <summary>
        /// This API is used to get the DDoS attack proportion analysis for an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public DescribeDDoSNetCountResponse DescribeDDoSNetCountSync(DescribeDDoSNetCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetCountResponse>(req, "DescribeDDoSNetCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack event details of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public Task<DescribeDDoSNetEvInfoResponse> DescribeDDoSNetEvInfo(DescribeDDoSNetEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvInfoResponse>(req, "DescribeDDoSNetEvInfo");
        }

        /// <summary>
        /// This API is used to get the DDoS attack event details of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public DescribeDDoSNetEvInfoResponse DescribeDDoSNetEvInfoSync(DescribeDDoSNetEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvInfoResponse>(req, "DescribeDDoSNetEvInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public Task<DescribeDDoSNetEvListResponse> DescribeDDoSNetEvList(DescribeDDoSNetEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvListResponse>(req, "DescribeDDoSNetEvList");
        }

        /// <summary>
        /// This API is used to get the DDoS attack event list of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public DescribeDDoSNetEvListResponse DescribeDDoSNetEvListSync(DescribeDDoSNetEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvListResponse>(req, "DescribeDDoSNetEvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS IP attack logs of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public Task<DescribeDDoSNetIpLogResponse> DescribeDDoSNetIpLog(DescribeDDoSNetIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetIpLogResponse>(req, "DescribeDDoSNetIpLog");
        }

        /// <summary>
        /// This API is used to get the DDoS IP attack logs of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public DescribeDDoSNetIpLogResponse DescribeDDoSNetIpLogSync(DescribeDDoSNetIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetIpLogResponse>(req, "DescribeDDoSNetIpLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DDoS attack metric data of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public Task<DescribeDDoSNetTrendResponse> DescribeDDoSNetTrend(DescribeDDoSNetTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetTrendResponse>(req, "DescribeDDoSNetTrend");
        }

        /// <summary>
        /// This API is used to get the DDoS attack metric data of an Anti-DDoS Ultimate resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public DescribeDDoSNetTrendResponse DescribeDDoSNetTrendSync(DescribeDDoSNetTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetTrendResponse>(req, "DescribeDDoSNetTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSPolicyResponse>(req, "DescribeDDoSPolicy");
        }

        /// <summary>
        /// This API is used to get an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSPolicyResponse>(req, "DescribeDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the data of DDoS attack traffic bandwidth and attack packet rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend");
        }

        /// <summary>
        /// This API is used to get the data of DDoS attack traffic bandwidth and attack packet rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count the number of days of Anti-DDoS resource use and number of DDoS attacks defended against.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public Task<DescribeDDoSUsedStatisResponse> DescribeDDoSUsedStatis(DescribeDDoSUsedStatisRequest req)
        {
            return InternalRequestAsync<DescribeDDoSUsedStatisResponse>(req, "DescribeDDoSUsedStatis");
        }

        /// <summary>
        /// This API is used to count the number of days of Anti-DDoS resource use and number of DDoS attacks defended against.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public DescribeDDoSUsedStatisResponse DescribeDDoSUsedStatisSync(DescribeDDoSUsedStatisRequest req)
        {
            return InternalRequestAsync<DescribeDDoSUsedStatisResponse>(req, "DescribeDDoSUsedStatis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the Tencent Cloud asset information corresponding to an IP of a single IP instance or multi-IP instance, which is supported only for IPs of single IP instances and multi-IP instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public Task<DescribeIPProductInfoResponse> DescribeIPProductInfo(DescribeIPProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeIPProductInfoResponse>(req, "DescribeIPProductInfo");
        }

        /// <summary>
        /// This API is used to get the Tencent Cloud asset information corresponding to an IP of a single IP instance or multi-IP instance, which is supported only for IPs of single IP instances and multi-IP instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public DescribeIPProductInfoResponse DescribeIPProductInfoSync(DescribeIPProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeIPProductInfoResponse>(req, "DescribeIPProductInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the guarantee package list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public Task<DescribeInsurePacksResponse> DescribeInsurePacks(DescribeInsurePacksRequest req)
        {
            return InternalRequestAsync<DescribeInsurePacksResponse>(req, "DescribeInsurePacks");
        }

        /// <summary>
        /// This API is used to get the guarantee package list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public DescribeInsurePacksResponse DescribeInsurePacksSync(DescribeInsurePacksRequest req)
        {
            return InternalRequestAsync<DescribeInsurePacksResponse>(req, "DescribeInsurePacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the blocked IP list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public Task<DescribeIpBlockListResponse> DescribeIpBlockList(DescribeIpBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpBlockListResponse>(req, "DescribeIpBlockList");
        }

        /// <summary>
        /// This API is used to get the blocked IP list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public DescribeIpBlockListResponse DescribeIpBlockListSync(DescribeIpBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpBlockListResponse>(req, "DescribeIpBlockList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the IP unblocking records.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public Task<DescribeIpUnBlockListResponse> DescribeIpUnBlockList(DescribeIpUnBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpUnBlockListResponse>(req, "DescribeIpUnBlockList");
        }

        /// <summary>
        /// This API is used to get the IP unblocking records.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public DescribeIpUnBlockListResponse DescribeIpUnBlockListSync(DescribeIpUnBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpUnBlockListResponse>(req, "DescribeIpUnBlockList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public Task<DescribeL4HealthConfigResponse> DescribeL4HealthConfig(DescribeL4HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL4HealthConfigResponse>(req, "DescribeL4HealthConfig");
        }

        /// <summary>
        /// This API is used to export the layer-4 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public DescribeL4HealthConfigResponse DescribeL4HealthConfigSync(DescribeL4HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL4HealthConfigResponse>(req, "DescribeL4HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the exception result of a layer-4 forwarding rule health check.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public Task<DescribeL4RulesErrHealthResponse> DescribeL4RulesErrHealth(DescribeL4RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeL4RulesErrHealthResponse>(req, "DescribeL4RulesErrHealth");
        }

        /// <summary>
        /// This API is used to get the exception result of a layer-4 forwarding rule health check.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public DescribeL4RulesErrHealthResponse DescribeL4RulesErrHealthSync(DescribeL4RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeL4RulesErrHealthResponse>(req, "DescribeL4RulesErrHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public Task<DescribeL7HealthConfigResponse> DescribeL7HealthConfig(DescribeL7HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL7HealthConfigResponse>(req, "DescribeL7HealthConfig");
        }

        /// <summary>
        /// This API is used to export the layer-7 health check configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public DescribeL7HealthConfigResponse DescribeL7HealthConfigSync(DescribeL7HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL7HealthConfigResponse>(req, "DescribeL7HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the product overview statistics. It is supported for Anti-DDoS Pro, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public Task<DescribePackIndexResponse> DescribePackIndex(DescribePackIndexRequest req)
        {
            return InternalRequestAsync<DescribePackIndexResponse>(req, "DescribePackIndex");
        }

        /// <summary>
        /// This API is used to get the product overview statistics. It is supported for Anti-DDoS Pro, Anti-DDoS Advanced, and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public DescribePackIndexResponse DescribePackIndexSync(DescribePackIndexRequest req)
        {
            return InternalRequestAsync<DescribePackIndexResponse>(req, "DescribePackIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download the PCAP packet of an attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public Task<DescribePcapResponse> DescribePcap(DescribePcapRequest req)
        {
            return InternalRequestAsync<DescribePcapResponse>(req, "DescribePcap");
        }

        /// <summary>
        /// This API is used to download the PCAP packet of an attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public DescribePcapResponse DescribePcapSync(DescribePcapRequest req)
        {
            return InternalRequestAsync<DescribePcapResponse>(req, "DescribePcap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public Task<DescribePolicyCaseResponse> DescribePolicyCase(DescribePolicyCaseRequest req)
        {
            return InternalRequestAsync<DescribePolicyCaseResponse>(req, "DescribePolicyCase");
        }

        /// <summary>
        /// This API is used to get the policy scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public DescribePolicyCaseResponse DescribePolicyCaseSync(DescribePolicyCaseRequest req)
        {
            return InternalRequestAsync<DescribePolicyCaseResponse>(req, "DescribePolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the IP list of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public Task<DescribeResIpListResponse> DescribeResIpList(DescribeResIpListRequest req)
        {
            return InternalRequestAsync<DescribeResIpListResponse>(req, "DescribeResIpList");
        }

        /// <summary>
        /// This API is used to get the IP list of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public DescribeResIpListResponse DescribeResIpListSync(DescribeResIpListRequest req)
        {
            return InternalRequestAsync<DescribeResIpListResponse>(req, "DescribeResIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the resource list.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public Task<DescribeResourceListResponse> DescribeResourceList(DescribeResourceListRequest req)
        {
            return InternalRequestAsync<DescribeResourceListResponse>(req, "DescribeResourceList");
        }

        /// <summary>
        /// This API is used to get the resource list.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public DescribeResourceListResponse DescribeResourceListSync(DescribeResourceListRequest req)
        {
            return InternalRequestAsync<DescribeResourceListResponse>(req, "DescribeResourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the number of rules of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public Task<DescribeRuleSetsResponse> DescribeRuleSets(DescribeRuleSetsRequest req)
        {
            return InternalRequestAsync<DescribeRuleSetsResponse>(req, "DescribeRuleSets");
        }

        /// <summary>
        /// This API is used to get the number of rules of a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public DescribeRuleSetsResponse DescribeRuleSetsSync(DescribeRuleSetsRequest req)
        {
            return InternalRequestAsync<DescribeRuleSetsResponse>(req, "DescribeRuleSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get scheduling domain name list
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulingDomainListRequest"/></param>
        /// <returns><see cref="DescribeSchedulingDomainListResponse"/></returns>
        public Task<DescribeSchedulingDomainListResponse> DescribeSchedulingDomainList(DescribeSchedulingDomainListRequest req)
        {
            return InternalRequestAsync<DescribeSchedulingDomainListResponse>(req, "DescribeSchedulingDomainList");
        }

        /// <summary>
        /// Get scheduling domain name list
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulingDomainListRequest"/></param>
        /// <returns><see cref="DescribeSchedulingDomainListResponse"/></returns>
        public DescribeSchedulingDomainListResponse DescribeSchedulingDomainListSync(DescribeSchedulingDomainListRequest req)
        {
            return InternalRequestAsync<DescribeSchedulingDomainListResponse>(req, "DescribeSchedulingDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the security statistics of the current month.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public Task<DescribeSecIndexResponse> DescribeSecIndex(DescribeSecIndexRequest req)
        {
            return InternalRequestAsync<DescribeSecIndexResponse>(req, "DescribeSecIndex");
        }

        /// <summary>
        /// This API is used to get the security statistics of the current month.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public DescribeSecIndexResponse DescribeSecIndexSync(DescribeSecIndexRequest req)
        {
            return InternalRequestAsync<DescribeSecIndexResponse>(req, "DescribeSecIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the intermediate IP range. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public Task<DescribeSourceIpSegmentResponse> DescribeSourceIpSegment(DescribeSourceIpSegmentRequest req)
        {
            return InternalRequestAsync<DescribeSourceIpSegmentResponse>(req, "DescribeSourceIpSegment");
        }

        /// <summary>
        /// This API is used to get the intermediate IP range. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public DescribeSourceIpSegmentResponse DescribeSourceIpSegmentSync(DescribeSourceIpSegmentRequest req)
        {
            return InternalRequestAsync<DescribeSourceIpSegmentResponse>(req, "DescribeSourceIpSegment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the business forwarding statistics, including forwarded traffic and packet forwarding rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public Task<DescribeTransmitStatisResponse> DescribeTransmitStatis(DescribeTransmitStatisRequest req)
        {
            return InternalRequestAsync<DescribeTransmitStatisResponse>(req, "DescribeTransmitStatis");
        }

        /// <summary>
        /// This API is used to get the business forwarding statistics, including forwarded traffic and packet forwarding rate.
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public DescribeTransmitStatisResponse DescribeTransmitStatisSync(DescribeTransmitStatisRequest req)
        {
            return InternalRequestAsync<DescribeTransmitStatisResponse>(req, "DescribeTransmitStatis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the number of blackhole unblockings.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public Task<DescribeUnBlockStatisResponse> DescribeUnBlockStatis(DescribeUnBlockStatisRequest req)
        {
            return InternalRequestAsync<DescribeUnBlockStatisResponse>(req, "DescribeUnBlockStatis");
        }

        /// <summary>
        /// This API is used to get the number of blackhole unblockings.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public DescribeUnBlockStatisResponse DescribeUnBlockStatisSync(DescribeUnBlockStatisRequest req)
        {
            return InternalRequestAsync<DescribeUnBlockStatisResponse>(req, "DescribeUnBlockStatis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public Task<DescribleL4RulesResponse> DescribleL4Rules(DescribleL4RulesRequest req)
        {
            return InternalRequestAsync<DescribleL4RulesResponse>(req, "DescribleL4Rules");
        }

        /// <summary>
        /// This API is used to get a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public DescribleL4RulesResponse DescribleL4RulesSync(DescribleL4RulesRequest req)
        {
            return InternalRequestAsync<DescribleL4RulesResponse>(req, "DescribleL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public Task<DescribleL7RulesResponse> DescribleL7Rules(DescribleL7RulesRequest req)
        {
            return InternalRequestAsync<DescribleL7RulesResponse>(req, "DescribleL7Rules");
        }

        /// <summary>
        /// This API is used to get a layer-7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public DescribleL7RulesResponse DescribleL7RulesSync(DescribleL7RulesRequest req)
        {
            return InternalRequestAsync<DescribleL7RulesResponse>(req, "DescribleL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the number of resource instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public Task<DescribleRegionCountResponse> DescribleRegionCount(DescribleRegionCountRequest req)
        {
            return InternalRequestAsync<DescribleRegionCountResponse>(req, "DescribleRegionCount");
        }

        /// <summary>
        /// This API is used to get the number of resource instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public DescribleRegionCountResponse DescribleRegionCountSync(DescribleRegionCountRequest req)
        {
            return InternalRequestAsync<DescribleRegionCountResponse>(req, "DescribleRegionCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public Task<ModifyCCAlarmThresholdResponse> ModifyCCAlarmThreshold(ModifyCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCAlarmThresholdResponse>(req, "ModifyCCAlarmThreshold");
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for CC attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public ModifyCCAlarmThresholdResponse ModifyCCAlarmThresholdSync(ModifyCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCAlarmThresholdResponse>(req, "ModifyCCAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesResponse"/></returns>
        public Task<ModifyCCFrequencyRulesResponse> ModifyCCFrequencyRules(ModifyCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesResponse>(req, "ModifyCCFrequencyRules");
        }

        /// <summary>
        /// This API is used to modify an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesResponse"/></returns>
        public ModifyCCFrequencyRulesResponse ModifyCCFrequencyRulesSync(ModifyCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesResponse>(req, "ModifyCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesStatusResponse"/></returns>
        public Task<ModifyCCFrequencyRulesStatusResponse> ModifyCCFrequencyRulesStatus(ModifyCCFrequencyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesStatusResponse>(req, "ModifyCCFrequencyRulesStatus");
        }

        /// <summary>
        /// This API is used to enable or disable an access frequency control rule for CC protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesStatusResponse"/></returns>
        public ModifyCCFrequencyRulesStatusResponse ModifyCCFrequencyRulesStatusSync(ModifyCCFrequencyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesStatusResponse>(req, "ModifyCCFrequencyRulesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable CC domain name protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public Task<ModifyCCHostProtectionResponse> ModifyCCHostProtection(ModifyCCHostProtectionRequest req)
        {
            return InternalRequestAsync<ModifyCCHostProtectionResponse>(req, "ModifyCCHostProtection");
        }

        /// <summary>
        /// This API is used to enable or disable CC domain name protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public ModifyCCHostProtectionResponse ModifyCCHostProtectionSync(ModifyCCHostProtectionRequest req)
        {
            return InternalRequestAsync<ModifyCCHostProtectionResponse>(req, "ModifyCCHostProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add/remove a CC IP to/from the blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public Task<ModifyCCIpAllowDenyResponse> ModifyCCIpAllowDeny(ModifyCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<ModifyCCIpAllowDenyResponse>(req, "ModifyCCIpAllowDeny");
        }

        /// <summary>
        /// This API is used to add/remove a CC IP to/from the blocklist/allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public ModifyCCIpAllowDenyResponse ModifyCCIpAllowDenySync(ModifyCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<ModifyCCIpAllowDenyResponse>(req, "ModifyCCIpAllowDeny")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify CC protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public Task<ModifyCCLevelResponse> ModifyCCLevel(ModifyCCLevelRequest req)
        {
            return InternalRequestAsync<ModifyCCLevelResponse>(req, "ModifyCCLevel");
        }

        /// <summary>
        /// This API is used to modify CC protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public ModifyCCLevelResponse ModifyCCLevelSync(ModifyCCLevelRequest req)
        {
            return InternalRequestAsync<ModifyCCLevelResponse>(req, "ModifyCCLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public Task<ModifyCCPolicySwitchResponse> ModifyCCPolicySwitch(ModifyCCPolicySwitchRequest req)
        {
            return InternalRequestAsync<ModifyCCPolicySwitchResponse>(req, "ModifyCCPolicySwitch");
        }

        /// <summary>
        /// This API is used to enable or disable a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public ModifyCCPolicySwitchResponse ModifyCCPolicySwitchSync(ModifyCCPolicySwitchRequest req)
        {
            return InternalRequestAsync<ModifyCCPolicySwitchResponse>(req, "ModifyCCPolicySwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public Task<ModifyCCSelfDefinePolicyResponse> ModifyCCSelfDefinePolicy(ModifyCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCSelfDefinePolicyResponse>(req, "ModifyCCSelfDefinePolicy");
        }

        /// <summary>
        /// This API is used to modify a custom CC policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public ModifyCCSelfDefinePolicyResponse ModifyCCSelfDefinePolicySync(ModifyCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCSelfDefinePolicyResponse>(req, "ModifyCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the CC protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public Task<ModifyCCThresholdResponse> ModifyCCThreshold(ModifyCCThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCThresholdResponse>(req, "ModifyCCThreshold");
        }

        /// <summary>
        /// This API is used to modify the CC protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public ModifyCCThresholdResponse ModifyCCThresholdSync(ModifyCCThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCThresholdResponse>(req, "ModifyCCThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add/remove a CC URL to/from the allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public Task<ModifyCCUrlAllowResponse> ModifyCCUrlAllow(ModifyCCUrlAllowRequest req)
        {
            return InternalRequestAsync<ModifyCCUrlAllowResponse>(req, "ModifyCCUrlAllow");
        }

        /// <summary>
        /// This API is used to add/remove a CC URL to/from the allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public ModifyCCUrlAllowResponse ModifyCCUrlAllowSync(ModifyCCUrlAllowRequest req)
        {
            return InternalRequestAsync<ModifyCCUrlAllowResponse>(req, "ModifyCCUrlAllow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to read or modify DDoS AI protection status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public Task<ModifyDDoSAIStatusResponse> ModifyDDoSAIStatus(ModifyDDoSAIStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAIStatusResponse>(req, "ModifyDDoSAIStatus");
        }

        /// <summary>
        /// This API is used to read or modify DDoS AI protection status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public ModifyDDoSAIStatusResponse ModifyDDoSAIStatusSync(ModifyDDoSAIStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAIStatusResponse>(req, "ModifyDDoSAIStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public Task<ModifyDDoSAlarmThresholdResponse> ModifyDDoSAlarmThreshold(ModifyDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAlarmThresholdResponse>(req, "ModifyDDoSAlarmThreshold");
        }

        /// <summary>
        /// This API is used to set the alarm notification threshold for DDoS attacks in Anti-DDoS Pro, Anti-DDoS Advanced, Anti-DDoS Ultimate, and Chess Shield.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public ModifyDDoSAlarmThresholdResponse ModifyDDoSAlarmThresholdSync(ModifyDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAlarmThresholdResponse>(req, "ModifyDDoSAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable DDoS. It can disable DDoS protection for a period of time, which will be automatically enabled after the period of time elapses.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public Task<ModifyDDoSDefendStatusResponse> ModifyDDoSDefendStatus(ModifyDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSDefendStatusResponse>(req, "ModifyDDoSDefendStatus");
        }

        /// <summary>
        /// This API is used to enable or disable DDoS. It can disable DDoS protection for a period of time, which will be automatically enabled after the period of time elapses.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public ModifyDDoSDefendStatusResponse ModifyDDoSDefendStatusSync(ModifyDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSDefendStatusResponse>(req, "ModifyDDoSDefendStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to read or modify DDoS protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public Task<ModifyDDoSLevelResponse> ModifyDDoSLevel(ModifyDDoSLevelRequest req)
        {
            return InternalRequestAsync<ModifyDDoSLevelResponse>(req, "ModifyDDoSLevel");
        }

        /// <summary>
        /// This API is used to read or modify DDoS protection level.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public ModifyDDoSLevelResponse ModifyDDoSLevelSync(ModifyDDoSLevelRequest req)
        {
            return InternalRequestAsync<ModifyDDoSLevelResponse>(req, "ModifyDDoSLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyResponse>(req, "ModifyDDoSPolicy");
        }

        /// <summary>
        /// This API is used to modify an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyResponse>(req, "ModifyDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public Task<ModifyDDoSPolicyCaseResponse> ModifyDDoSPolicyCase(ModifyDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyCaseResponse>(req, "ModifyDDoSPolicyCase");
        }

        /// <summary>
        /// This API is used to modify a policy scenario.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public ModifyDDoSPolicyCaseResponse ModifyDDoSPolicyCaseSync(ModifyDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyCaseResponse>(req, "ModifyDDoSPolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public Task<ModifyDDoSPolicyNameResponse> ModifyDDoSPolicyName(ModifyDDoSPolicyNameRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyNameResponse>(req, "ModifyDDoSPolicyName");
        }

        /// <summary>
        /// This API is used to rename an advanced DDoS policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public ModifyDDoSPolicyNameResponse ModifyDDoSPolicyNameSync(ModifyDDoSPolicyNameRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyNameResponse>(req, "ModifyDDoSPolicyName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable DDoS protection, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public Task<ModifyDDoSSwitchResponse> ModifyDDoSSwitch(ModifyDDoSSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSwitchResponse>(req, "ModifyDDoSSwitch");
        }

        /// <summary>
        /// This API is used to enable or disable DDoS protection, which is only supported for Anti-DDoS Basic.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public ModifyDDoSSwitchResponse ModifyDDoSSwitchSync(ModifyDDoSSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSwitchResponse>(req, "ModifyDDoSSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the DDoS cleansing threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public Task<ModifyDDoSThresholdResponse> ModifyDDoSThreshold(ModifyDDoSThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSThresholdResponse>(req, "ModifyDDoSThreshold");
        }

        /// <summary>
        /// This API is used to modify the DDoS cleansing threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public ModifyDDoSThresholdResponse ModifyDDoSThresholdSync(ModifyDDoSThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSThresholdResponse>(req, "ModifyDDoSThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add, delete, enable, or disable a watermark key.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public Task<ModifyDDoSWaterKeyResponse> ModifyDDoSWaterKey(ModifyDDoSWaterKeyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSWaterKeyResponse>(req, "ModifyDDoSWaterKey");
        }

        /// <summary>
        /// This API is used to add, delete, enable, or disable a watermark key.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public ModifyDDoSWaterKeyResponse ModifyDDoSWaterKeySync(ModifyDDoSWaterKeyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSWaterKeyResponse>(req, "ModifyDDoSWaterKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the elastic protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public Task<ModifyElasticLimitResponse> ModifyElasticLimit(ModifyElasticLimitRequest req)
        {
            return InternalRequestAsync<ModifyElasticLimitResponse>(req, "ModifyElasticLimit");
        }

        /// <summary>
        /// This API is used to modify the elastic protection threshold.
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public ModifyElasticLimitResponse ModifyElasticLimitSync(ModifyElasticLimitRequest req)
        {
            return InternalRequestAsync<ModifyElasticLimitResponse>(req, "ModifyElasticLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the health check parameters of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public Task<ModifyL4HealthResponse> ModifyL4Health(ModifyL4HealthRequest req)
        {
            return InternalRequestAsync<ModifyL4HealthResponse>(req, "ModifyL4Health");
        }

        /// <summary>
        /// This API is used to modify the health check parameters of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public ModifyL4HealthResponse ModifyL4HealthSync(ModifyL4HealthRequest req)
        {
            return InternalRequestAsync<ModifyL4HealthResponse>(req, "ModifyL4Health")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the session persistence of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public Task<ModifyL4KeepTimeResponse> ModifyL4KeepTime(ModifyL4KeepTimeRequest req)
        {
            return InternalRequestAsync<ModifyL4KeepTimeResponse>(req, "ModifyL4KeepTime");
        }

        /// <summary>
        /// This API is used to modify the session persistence of a layer-4 forwarding rule. It is supported for Anti-DDoS Advanced and Anti-DDoS Ultimate.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public ModifyL4KeepTimeResponse ModifyL4KeepTimeSync(ModifyL4KeepTimeRequest req)
        {
            return InternalRequestAsync<ModifyL4KeepTimeResponse>(req, "ModifyL4KeepTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public Task<ModifyL4RulesResponse> ModifyL4Rules(ModifyL4RulesRequest req)
        {
            return InternalRequestAsync<ModifyL4RulesResponse>(req, "ModifyL4Rules");
        }

        /// <summary>
        /// This API is used to modify a layer-4 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public ModifyL4RulesResponse ModifyL4RulesSync(ModifyL4RulesRequest req)
        {
            return InternalRequestAsync<ModifyL4RulesResponse>(req, "ModifyL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public Task<ModifyL7RulesResponse> ModifyL7Rules(ModifyL7RulesRequest req)
        {
            return InternalRequestAsync<ModifyL7RulesResponse>(req, "ModifyL7Rules");
        }

        /// <summary>
        /// This API is used to modify the layer-7 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public ModifyL7RulesResponse ModifyL7RulesSync(ModifyL7RulesRequest req)
        {
            return InternalRequestAsync<ModifyL7RulesResponse>(req, "ModifyL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch a client to the real server and set the switch duration when the client is under attack or blocked.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetReturnSwitchRequest"/></param>
        /// <returns><see cref="ModifyNetReturnSwitchResponse"/></returns>
        public Task<ModifyNetReturnSwitchResponse> ModifyNetReturnSwitch(ModifyNetReturnSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNetReturnSwitchResponse>(req, "ModifyNetReturnSwitch");
        }

        /// <summary>
        /// This API is used to switch a client to the real server and set the switch duration when the client is under attack or blocked.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetReturnSwitchRequest"/></param>
        /// <returns><see cref="ModifyNetReturnSwitchResponse"/></returns>
        public ModifyNetReturnSwitchResponse ModifyNetReturnSwitchSync(ModifyNetReturnSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNetReturnSwitchResponse>(req, "ModifyNetReturnSwitch")
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
        /// This API is used to modify layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewL4RuleRequest"/></param>
        /// <returns><see cref="ModifyNewL4RuleResponse"/></returns>
        public Task<ModifyNewL4RuleResponse> ModifyNewL4Rule(ModifyNewL4RuleRequest req)
        {
            return InternalRequestAsync<ModifyNewL4RuleResponse>(req, "ModifyNewL4Rule");
        }

        /// <summary>
        /// This API is used to modify layer-4 forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNewL4RuleRequest"/></param>
        /// <returns><see cref="ModifyNewL4RuleResponse"/></returns>
        public ModifyNewL4RuleResponse ModifyNewL4RuleSync(ModifyNewL4RuleRequest req)
        {
            return InternalRequestAsync<ModifyNewL4RuleResponse>(req, "ModifyNewL4Rule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an advanced DDoS policy to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public Task<ModifyResBindDDoSPolicyResponse> ModifyResBindDDoSPolicy(ModifyResBindDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyResBindDDoSPolicyResponse>(req, "ModifyResBindDDoSPolicy");
        }

        /// <summary>
        /// This API is used to bind an advanced DDoS policy to an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public ModifyResBindDDoSPolicyResponse ModifyResBindDDoSPolicySync(ModifyResBindDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyResBindDDoSPolicyResponse>(req, "ModifyResBindDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable auto-renewal for a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public Task<ModifyResourceRenewFlagResponse> ModifyResourceRenewFlag(ModifyResourceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyResourceRenewFlagResponse>(req, "ModifyResourceRenewFlag");
        }

        /// <summary>
        /// This API is used to enable or disable auto-renewal for a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public ModifyResourceRenewFlagResponse ModifyResourceRenewFlagSync(ModifyResourceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyResourceRenewFlagResponse>(req, "ModifyResourceRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
