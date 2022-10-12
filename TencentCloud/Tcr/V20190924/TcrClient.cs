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

namespace TencentCloud.Tcr.V20190924
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcr.V20190924.Models;

   public class TcrClient : AbstractClient{

       private const string endpoint = "tcr.tencentcloudapi.com";
       private const string version = "2019-09-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to verify the information of the Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public async Task<CheckInstanceResponse> CheckInstance(CheckInstanceRequest req)
        {
             JsonResponseModel<CheckInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify the information of the Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public CheckInstanceResponse CheckInstanceSync(CheckInstanceRequest req)
        {
             JsonResponseModel<CheckInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether the name of the instance to be created meets the specifications.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public async Task<CheckInstanceNameResponse> CheckInstanceName(CheckInstanceNameRequest req)
        {
             JsonResponseModel<CheckInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether the name of the instance to be created meets the specifications.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public CheckInstanceNameResponse CheckInstanceNameSync(CheckInstanceNameRequest req)
        {
             JsonResponseModel<CheckInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public async Task<CreateImageAccelerationServiceResponse> CreateImageAccelerationService(CreateImageAccelerationServiceRequest req)
        {
             JsonResponseModel<CreateImageAccelerationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageAccelerationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageAccelerationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public CreateImageAccelerationServiceResponse CreateImageAccelerationServiceSync(CreateImageAccelerationServiceRequest req)
        {
             JsonResponseModel<CreateImageAccelerationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageAccelerationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageAccelerationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public async Task<CreateImmutableTagRulesResponse> CreateImmutableTagRules(CreateImmutableTagRulesRequest req)
        {
             JsonResponseModel<CreateImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public CreateImmutableTagRulesResponse CreateImmutableTagRulesSync(CreateImmutableTagRulesRequest req)
        {
             JsonResponseModel<CreateImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public async Task<CreateInstanceCustomizedDomainResponse> CreateInstanceCustomizedDomain(CreateInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<CreateInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public CreateInstanceCustomizedDomainResponse CreateInstanceCustomizedDomainSync(CreateInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<CreateInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a temporary or long-term instance access credential.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public async Task<CreateInstanceTokenResponse> CreateInstanceToken(CreateInstanceTokenRequest req)
        {
             JsonResponseModel<CreateInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a temporary or long-term instance access credential.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public CreateInstanceTokenResponse CreateInstanceTokenSync(CreateInstanceTokenRequest req)
        {
             JsonResponseModel<CreateInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple public network access allowlist policies of the TCR instance.
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public async Task<CreateMultipleSecurityPolicyResponse> CreateMultipleSecurityPolicy(CreateMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple public network access allowlist policies of the TCR instance.
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public CreateMultipleSecurityPolicyResponse CreateMultipleSecurityPolicySync(CreateMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a namespace in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a namespace in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a replication instance.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public async Task<CreateReplicationInstanceResponse> CreateReplicationInstance(CreateReplicationInstanceRequest req)
        {
             JsonResponseModel<CreateReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a replication instance.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public CreateReplicationInstanceResponse CreateReplicationInstanceSync(CreateReplicationInstanceRequest req)
        {
             JsonResponseModel<CreateReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image repository in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public async Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest req)
        {
             JsonResponseModel<CreateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image repository in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public CreateRepositoryResponse CreateRepositorySync(CreateRepositoryRequest req)
        {
             JsonResponseModel<CreateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create public network access allowlist policies for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityPoliciesResponse"/></returns>
        public async Task<CreateSecurityPoliciesResponse> CreateSecurityPolicies(CreateSecurityPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create public network access allowlist policies for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityPoliciesResponse"/></returns>
        public CreateSecurityPoliciesResponse CreateSecurityPoliciesSync(CreateSecurityPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a public network access allowlist policy for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a public network access allowlist policy for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a signature for an image tag.
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public async Task<CreateSignatureResponse> CreateSignature(CreateSignatureRequest req)
        {
             JsonResponseModel<CreateSignatureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignature");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignatureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a signature for an image tag.
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public CreateSignatureResponse CreateSignatureSync(CreateSignatureRequest req)
        {
             JsonResponseModel<CreateSignatureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignature");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignatureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image signature policy.
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public async Task<CreateSignaturePolicyResponse> CreateSignaturePolicy(CreateSignaturePolicyRequest req)
        {
             JsonResponseModel<CreateSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image signature policy.
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public CreateSignaturePolicyResponse CreateSignaturePolicySync(CreateSignaturePolicyRequest req)
        {
             JsonResponseModel<CreateSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to execute tag retention manually.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public async Task<CreateTagRetentionExecutionResponse> CreateTagRetentionExecution(CreateTagRetentionExecutionRequest req)
        {
             JsonResponseModel<CreateTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to execute tag retention manually.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public CreateTagRetentionExecutionResponse CreateTagRetentionExecutionSync(CreateTagRetentionExecutionRequest req)
        {
             JsonResponseModel<CreateTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public async Task<CreateTagRetentionRuleResponse> CreateTagRetentionRule(CreateTagRetentionRuleRequest req)
        {
             JsonResponseModel<CreateTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public CreateTagRetentionRuleResponse CreateTagRetentionRuleSync(CreateTagRetentionRuleRequest req)
        {
             JsonResponseModel<CreateTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a trigger.
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public async Task<CreateWebhookTriggerResponse> CreateWebhookTrigger(CreateWebhookTriggerRequest req)
        {
             JsonResponseModel<CreateWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a trigger.
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public CreateWebhookTriggerResponse CreateWebhookTriggerSync(CreateWebhookTriggerRequest req)
        {
             JsonResponseModel<CreateWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the specified image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public async Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the specified image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public async Task<DeleteImageAccelerateServiceResponse> DeleteImageAccelerateService(DeleteImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DeleteImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public DeleteImageAccelerateServiceResponse DeleteImageAccelerateServiceSync(DeleteImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DeleteImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to delete the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public async Task<DeleteImmutableTagRulesResponse> DeleteImmutableTagRules(DeleteImmutableTagRulesRequest req)
        {
             JsonResponseModel<DeleteImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to delete the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public DeleteImmutableTagRulesResponse DeleteImmutableTagRulesSync(DeleteImmutableTagRulesRequest req)
        {
             JsonResponseModel<DeleteImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TCR Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TCR Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public async Task<DeleteInstanceCustomizedDomainResponse> DeleteInstanceCustomizedDomain(DeleteInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DeleteInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public DeleteInstanceCustomizedDomainResponse DeleteInstanceCustomizedDomainSync(DeleteInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DeleteInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a long-term access credential.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public async Task<DeleteInstanceTokenResponse> DeleteInstanceToken(DeleteInstanceTokenRequest req)
        {
             JsonResponseModel<DeleteInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a long-term access credential.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public DeleteInstanceTokenResponse DeleteInstanceTokenSync(DeleteInstanceTokenRequest req)
        {
             JsonResponseModel<DeleteInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete multiple public network access allowlist policies of the instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public async Task<DeleteMultipleSecurityPolicyResponse> DeleteMultipleSecurityPolicy(DeleteMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete multiple public network access allowlist policies of the instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public DeleteMultipleSecurityPolicyResponse DeleteMultipleSecurityPolicySync(DeleteMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a replica instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public async Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
             JsonResponseModel<DeleteReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a replica instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
             JsonResponseModel<DeleteReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public async Task<DeleteRepositoryResponse> DeleteRepository(DeleteRepositoryRequest req)
        {
             JsonResponseModel<DeleteRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public DeleteRepositoryResponse DeleteRepositorySync(DeleteRepositoryRequest req)
        {
             JsonResponseModel<DeleteRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete repository tags in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public async Task<DeleteRepositoryTagsResponse> DeleteRepositoryTags(DeleteRepositoryTagsRequest req)
        {
             JsonResponseModel<DeleteRepositoryTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRepositoryTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete repository tags in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public DeleteRepositoryTagsResponse DeleteRepositoryTagsSync(DeleteRepositoryTagsRequest req)
        {
             JsonResponseModel<DeleteRepositoryTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRepositoryTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a public network access allowlist policy of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a public network access allowlist policy of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a namespace signing policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public async Task<DeleteSignaturePolicyResponse> DeleteSignaturePolicy(DeleteSignaturePolicyRequest req)
        {
             JsonResponseModel<DeleteSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a namespace signing policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public DeleteSignaturePolicyResponse DeleteSignaturePolicySync(DeleteSignaturePolicyRequest req)
        {
             JsonResponseModel<DeleteSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public async Task<DeleteTagRetentionRuleResponse> DeleteTagRetentionRule(DeleteTagRetentionRuleRequest req)
        {
             JsonResponseModel<DeleteTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public DeleteTagRetentionRuleResponse DeleteTagRetentionRuleSync(DeleteTagRetentionRuleRequest req)
        {
             JsonResponseModel<DeleteTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a trigger.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public async Task<DeleteWebhookTriggerResponse> DeleteWebhookTrigger(DeleteWebhookTriggerRequest req)
        {
             JsonResponseModel<DeleteWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a trigger.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public DeleteWebhookTriggerResponse DeleteWebhookTriggerSync(DeleteWebhookTriggerRequest req)
        {
             JsonResponseModel<DeleteWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the chart download information in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public async Task<DescribeChartDownloadInfoResponse> DescribeChartDownloadInfo(DescribeChartDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeChartDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChartDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChartDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the chart download information in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public DescribeChartDownloadInfoResponse DescribeChartDownloadInfoSync(DescribeChartDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeChartDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChartDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChartDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the public network access entry status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public async Task<DescribeExternalEndpointStatusResponse> DescribeExternalEndpointStatus(DescribeExternalEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeExternalEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExternalEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the public network access entry status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public DescribeExternalEndpointStatusResponse DescribeExternalEndpointStatusSync(DescribeExternalEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeExternalEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExternalEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the last ten garbage collection (GC) records.
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public async Task<DescribeGCJobsResponse> DescribeGCJobs(DescribeGCJobsRequest req)
        {
             JsonResponseModel<DescribeGCJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGCJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGCJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the last ten garbage collection (GC) records.
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public DescribeGCJobsResponse DescribeGCJobsSync(DescribeGCJobsRequest req)
        {
             JsonResponseModel<DescribeGCJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGCJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGCJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public async Task<DescribeImageAccelerateServiceResponse> DescribeImageAccelerateService(DescribeImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DescribeImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public DescribeImageAccelerateServiceResponse DescribeImageAccelerateServiceSync(DescribeImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DescribeImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the manifest information of a container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public async Task<DescribeImageManifestsResponse> DescribeImageManifests(DescribeImageManifestsRequest req)
        {
             JsonResponseModel<DescribeImageManifestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageManifests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageManifestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the manifest information of a container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public DescribeImageManifestsResponse DescribeImageManifestsSync(DescribeImageManifestsRequest req)
        {
             JsonResponseModel<DescribeImageManifestsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageManifests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageManifestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of image tags or the information of the specified container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of image tags or the information of the specified container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public async Task<DescribeImmutableTagRulesResponse> DescribeImmutableTagRules(DescribeImmutableTagRulesRequest req)
        {
             JsonResponseModel<DescribeImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public DescribeImmutableTagRulesResponse DescribeImmutableTagRulesSync(DescribeImmutableTagRulesRequest req)
        {
             JsonResponseModel<DescribeImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of all instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllResponse"/></returns>
        public async Task<DescribeInstanceAllResponse> DescribeInstanceAll(DescribeInstanceAllRequest req)
        {
             JsonResponseModel<DescribeInstanceAllResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAll");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAllResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of all instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllResponse"/></returns>
        public DescribeInstanceAllResponse DescribeInstanceAllSync(DescribeInstanceAllRequest req)
        {
             JsonResponseModel<DescribeInstanceAllResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAll");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAllResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of all instance namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public async Task<DescribeInstanceAllNamespacesResponse> DescribeInstanceAllNamespaces(DescribeInstanceAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeInstanceAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of all instance namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public DescribeInstanceAllNamespacesResponse DescribeInstanceAllNamespacesSync(DescribeInstanceAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeInstanceAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of custom domain names of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public async Task<DescribeInstanceCustomizedDomainResponse> DescribeInstanceCustomizedDomain(DescribeInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DescribeInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of custom domain names of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public DescribeInstanceCustomizedDomainResponse DescribeInstanceCustomizedDomainSync(DescribeInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DescribeInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the current status and process information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatus(DescribeInstanceStatusRequest req)
        {
             JsonResponseModel<DescribeInstanceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the current status and process information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatusSync(DescribeInstanceStatusRequest req)
        {
             JsonResponseModel<DescribeInstanceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of long-term access credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public async Task<DescribeInstanceTokenResponse> DescribeInstanceToken(DescribeInstanceTokenRequest req)
        {
             JsonResponseModel<DescribeInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of long-term access credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public DescribeInstanceTokenResponse DescribeInstanceTokenSync(DescribeInstanceTokenRequest req)
        {
             JsonResponseModel<DescribeInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public async Task<DescribeInternalEndpointsResponse> DescribeInternalEndpoints(DescribeInternalEndpointsRequest req)
        {
             JsonResponseModel<DescribeInternalEndpointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternalEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternalEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public DescribeInternalEndpointsResponse DescribeInternalEndpointsSync(DescribeInternalEndpointsRequest req)
        {
             JsonResponseModel<DescribeInternalEndpointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternalEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternalEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the namespace list or the information of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
             JsonResponseModel<DescribeNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the namespace list or the information of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
             JsonResponseModel<DescribeNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the available regions in TCR.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the available regions in TCR.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task status of creating a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public async Task<DescribeReplicationInstanceCreateTasksResponse> DescribeReplicationInstanceCreateTasks(DescribeReplicationInstanceCreateTasksRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstanceCreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task status of creating a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public DescribeReplicationInstanceCreateTasksResponse DescribeReplicationInstanceCreateTasksSync(DescribeReplicationInstanceCreateTasksRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstanceCreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the synchronization status of a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public async Task<DescribeReplicationInstanceSyncStatusResponse> DescribeReplicationInstanceSyncStatus(DescribeReplicationInstanceSyncStatusRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstanceSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the synchronization status of a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public DescribeReplicationInstanceSyncStatusResponse DescribeReplicationInstanceSyncStatusSync(DescribeReplicationInstanceSyncStatusRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstanceSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of replication instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public async Task<DescribeReplicationInstancesResponse> DescribeReplicationInstances(DescribeReplicationInstancesRequest req)
        {
             JsonResponseModel<DescribeReplicationInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of replication instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public DescribeReplicationInstancesResponse DescribeReplicationInstancesSync(DescribeReplicationInstancesRequest req)
        {
             JsonResponseModel<DescribeReplicationInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the image repository list or the information of the specified image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public async Task<DescribeRepositoriesResponse> DescribeRepositories(DescribeRepositoriesRequest req)
        {
             JsonResponseModel<DescribeRepositoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepositories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the image repository list or the information of the specified image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public DescribeRepositoriesResponse DescribeRepositoriesSync(DescribeRepositoriesRequest req)
        {
             JsonResponseModel<DescribeRepositoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepositories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the public network access allowlist policies of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public async Task<DescribeSecurityPoliciesResponse> DescribeSecurityPolicies(DescribeSecurityPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the public network access allowlist policies of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public DescribeSecurityPoliciesResponse DescribeSecurityPoliciesSync(DescribeSecurityPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag retention execution records.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public async Task<DescribeTagRetentionExecutionResponse> DescribeTagRetentionExecution(DescribeTagRetentionExecutionRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag retention execution records.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public DescribeTagRetentionExecutionResponse DescribeTagRetentionExecutionSync(DescribeTagRetentionExecutionRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag retention execution tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public async Task<DescribeTagRetentionExecutionTaskResponse> DescribeTagRetentionExecutionTask(DescribeTagRetentionExecutionTaskRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagRetentionExecutionTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag retention execution tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public DescribeTagRetentionExecutionTaskResponse DescribeTagRetentionExecutionTaskSync(DescribeTagRetentionExecutionTaskRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagRetentionExecutionTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag retention rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public async Task<DescribeTagRetentionRulesResponse> DescribeTagRetentionRules(DescribeTagRetentionRulesRequest req)
        {
             JsonResponseModel<DescribeTagRetentionRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagRetentionRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag retention rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public DescribeTagRetentionRulesResponse DescribeTagRetentionRulesSync(DescribeTagRetentionRulesRequest req)
        {
             JsonResponseModel<DescribeTagRetentionRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagRetentionRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query triggers.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public async Task<DescribeWebhookTriggerResponse> DescribeWebhookTrigger(DescribeWebhookTriggerRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query triggers.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public DescribeWebhookTriggerResponse DescribeWebhookTriggerSync(DescribeWebhookTriggerRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get trigger logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public async Task<DescribeWebhookTriggerLogResponse> DescribeWebhookTriggerLog(DescribeWebhookTriggerLogRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebhookTriggerLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get trigger logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public DescribeWebhookTriggerLogResponse DescribeWebhookTriggerLogSync(DescribeWebhookTriggerLogRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebhookTriggerLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download a Helm chart in TCR.
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public async Task<DownloadHelmChartResponse> DownloadHelmChart(DownloadHelmChartRequest req)
        {
             JsonResponseModel<DownloadHelmChartResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadHelmChart");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadHelmChartResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download a Helm chart in TCR.
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public DownloadHelmChartResponse DownloadHelmChartSync(DownloadHelmChartRequest req)
        {
             JsonResponseModel<DownloadHelmChartResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadHelmChart");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadHelmChartResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public async Task<ManageExternalEndpointResponse> ManageExternalEndpoint(ManageExternalEndpointRequest req)
        {
             JsonResponseModel<ManageExternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageExternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageExternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public ManageExternalEndpointResponse ManageExternalEndpointSync(ManageExternalEndpointRequest req)
        {
             JsonResponseModel<ManageExternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageExternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageExternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public async Task<ManageInternalEndpointResponse> ManageInternalEndpoint(ManageInternalEndpointRequest req)
        {
             JsonResponseModel<ManageInternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageInternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageInternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public ManageInternalEndpointResponse ManageInternalEndpointSync(ManageInternalEndpointRequest req)
        {
             JsonResponseModel<ManageInternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageInternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageInternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the instance synchronization rule.
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public async Task<ManageReplicationResponse> ManageReplication(ManageReplicationRequest req)
        {
             JsonResponseModel<ManageReplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the instance synchronization rule.
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public ManageReplicationResponse ManageReplicationSync(ManageReplicationRequest req)
        {
             JsonResponseModel<ManageReplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public async Task<ModifyImmutableTagRulesResponse> ModifyImmutableTagRules(ModifyImmutableTagRulesRequest req)
        {
             JsonResponseModel<ModifyImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public ModifyImmutableTagRulesResponse ModifyImmutableTagRulesSync(ModifyImmutableTagRulesRequest req)
        {
             JsonResponseModel<ModifyImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of the specified long-term access credential in an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public async Task<ModifyInstanceTokenResponse> ModifyInstanceToken(ModifyInstanceTokenRequest req)
        {
             JsonResponseModel<ModifyInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of the specified long-term access credential in an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public ModifyInstanceTokenResponse ModifyInstanceTokenSync(ModifyInstanceTokenRequest req)
        {
             JsonResponseModel<ModifyInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of a namespace. Currently, only the namespace access level can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public async Task<ModifyNamespaceResponse> ModifyNamespace(ModifyNamespaceRequest req)
        {
             JsonResponseModel<ModifyNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of a namespace. Currently, only the namespace access level can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public ModifyNamespaceResponse ModifyNamespaceSync(ModifyNamespaceRequest req)
        {
             JsonResponseModel<ModifyNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of an image repository. The repository description can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public async Task<ModifyRepositoryResponse> ModifyRepository(ModifyRepositoryRequest req)
        {
             JsonResponseModel<ModifyRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of an image repository. The repository description can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public ModifyRepositoryResponse ModifyRepositorySync(ModifyRepositoryRequest req)
        {
             JsonResponseModel<ModifyRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the public network access allowlist of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public async Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the public network access allowlist of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public async Task<ModifyTagRetentionRuleResponse> ModifyTagRetentionRule(ModifyTagRetentionRuleRequest req)
        {
             JsonResponseModel<ModifyTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public ModifyTagRetentionRuleResponse ModifyTagRetentionRuleSync(ModifyTagRetentionRuleRequest req)
        {
             JsonResponseModel<ModifyTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a trigger.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public async Task<ModifyWebhookTriggerResponse> ModifyWebhookTrigger(ModifyWebhookTriggerRequest req)
        {
             JsonResponseModel<ModifyWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a trigger.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public ModifyWebhookTriggerResponse ModifyWebhookTriggerSync(ModifyWebhookTriggerRequest req)
        {
             JsonResponseModel<ModifyWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew a prepaid instance or change the billing mode from pay-as-you-go billing to monthly subscription billing.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew a prepaid instance or change the billing mode from pay-as-you-go billing to monthly subscription billing.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
