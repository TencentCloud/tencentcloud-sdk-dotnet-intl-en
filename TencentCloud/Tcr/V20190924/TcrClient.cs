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
       private const string sdkVersion = "SDK_NET_3.0.917";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to verify the information of the Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public Task<CheckInstanceResponse> CheckInstance(CheckInstanceRequest req)
        {
            return InternalRequestAsync<CheckInstanceResponse>(req, "CheckInstance");
        }

        /// <summary>
        /// This API is used to verify the information of the Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public CheckInstanceResponse CheckInstanceSync(CheckInstanceRequest req)
        {
            return InternalRequestAsync<CheckInstanceResponse>(req, "CheckInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the name of the instance to be created meets the specifications.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public Task<CheckInstanceNameResponse> CheckInstanceName(CheckInstanceNameRequest req)
        {
            return InternalRequestAsync<CheckInstanceNameResponse>(req, "CheckInstanceName");
        }

        /// <summary>
        /// This API is used to check whether the name of the instance to be created meets the specifications.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public CheckInstanceNameResponse CheckInstanceNameSync(CheckInstanceNameRequest req)
        {
            return InternalRequestAsync<CheckInstanceNameResponse>(req, "CheckInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public Task<CreateImageAccelerationServiceResponse> CreateImageAccelerationService(CreateImageAccelerationServiceRequest req)
        {
            return InternalRequestAsync<CreateImageAccelerationServiceResponse>(req, "CreateImageAccelerationService");
        }

        /// <summary>
        /// This API is used to create an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public CreateImageAccelerationServiceResponse CreateImageAccelerationServiceSync(CreateImageAccelerationServiceRequest req)
        {
            return InternalRequestAsync<CreateImageAccelerationServiceResponse>(req, "CreateImageAccelerationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public Task<CreateImmutableTagRulesResponse> CreateImmutableTagRules(CreateImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<CreateImmutableTagRulesResponse>(req, "CreateImmutableTagRules");
        }

        /// <summary>
        /// This API is used to create the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public CreateImmutableTagRulesResponse CreateImmutableTagRulesSync(CreateImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<CreateImmutableTagRulesResponse>(req, "CreateImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// This API is used to create an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public Task<CreateInstanceCustomizedDomainResponse> CreateInstanceCustomizedDomain(CreateInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<CreateInstanceCustomizedDomainResponse>(req, "CreateInstanceCustomizedDomain");
        }

        /// <summary>
        /// This API is used to create a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public CreateInstanceCustomizedDomainResponse CreateInstanceCustomizedDomainSync(CreateInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<CreateInstanceCustomizedDomainResponse>(req, "CreateInstanceCustomizedDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a temporary or long-term instance access credential.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public Task<CreateInstanceTokenResponse> CreateInstanceToken(CreateInstanceTokenRequest req)
        {
            return InternalRequestAsync<CreateInstanceTokenResponse>(req, "CreateInstanceToken");
        }

        /// <summary>
        /// This API is used to create a temporary or long-term instance access credential.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public CreateInstanceTokenResponse CreateInstanceTokenSync(CreateInstanceTokenRequest req)
        {
            return InternalRequestAsync<CreateInstanceTokenResponse>(req, "CreateInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create multiple public network access allowlist policies of the TCR instance.
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public Task<CreateMultipleSecurityPolicyResponse> CreateMultipleSecurityPolicy(CreateMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateMultipleSecurityPolicyResponse>(req, "CreateMultipleSecurityPolicy");
        }

        /// <summary>
        /// This API is used to create multiple public network access allowlist policies of the TCR instance.
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public CreateMultipleSecurityPolicyResponse CreateMultipleSecurityPolicySync(CreateMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateMultipleSecurityPolicyResponse>(req, "CreateMultipleSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a namespace in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace");
        }

        /// <summary>
        /// This API is used to create a namespace in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a replication instance.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public Task<CreateReplicationInstanceResponse> CreateReplicationInstance(CreateReplicationInstanceRequest req)
        {
            return InternalRequestAsync<CreateReplicationInstanceResponse>(req, "CreateReplicationInstance");
        }

        /// <summary>
        /// This API is used to create a replication instance.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public CreateReplicationInstanceResponse CreateReplicationInstanceSync(CreateReplicationInstanceRequest req)
        {
            return InternalRequestAsync<CreateReplicationInstanceResponse>(req, "CreateReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image repository in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest req)
        {
            return InternalRequestAsync<CreateRepositoryResponse>(req, "CreateRepository");
        }

        /// <summary>
        /// This API is used to create an image repository in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public CreateRepositoryResponse CreateRepositorySync(CreateRepositoryRequest req)
        {
            return InternalRequestAsync<CreateRepositoryResponse>(req, "CreateRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a public network access allowlist policy for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy");
        }

        /// <summary>
        /// This API is used to create a public network access allowlist policy for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a service level account.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceAccountRequest"/></param>
        /// <returns><see cref="CreateServiceAccountResponse"/></returns>
        public Task<CreateServiceAccountResponse> CreateServiceAccount(CreateServiceAccountRequest req)
        {
            return InternalRequestAsync<CreateServiceAccountResponse>(req, "CreateServiceAccount");
        }

        /// <summary>
        /// This API is used to create a service level account.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceAccountRequest"/></param>
        /// <returns><see cref="CreateServiceAccountResponse"/></returns>
        public CreateServiceAccountResponse CreateServiceAccountSync(CreateServiceAccountRequest req)
        {
            return InternalRequestAsync<CreateServiceAccountResponse>(req, "CreateServiceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a signature for an image tag.
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public Task<CreateSignatureResponse> CreateSignature(CreateSignatureRequest req)
        {
            return InternalRequestAsync<CreateSignatureResponse>(req, "CreateSignature");
        }

        /// <summary>
        /// This API is used to create a signature for an image tag.
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public CreateSignatureResponse CreateSignatureSync(CreateSignatureRequest req)
        {
            return InternalRequestAsync<CreateSignatureResponse>(req, "CreateSignature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image signature policy.
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public Task<CreateSignaturePolicyResponse> CreateSignaturePolicy(CreateSignaturePolicyRequest req)
        {
            return InternalRequestAsync<CreateSignaturePolicyResponse>(req, "CreateSignaturePolicy");
        }

        /// <summary>
        /// This API is used to create an image signature policy.
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public CreateSignaturePolicyResponse CreateSignaturePolicySync(CreateSignaturePolicyRequest req)
        {
            return InternalRequestAsync<CreateSignaturePolicyResponse>(req, "CreateSignaturePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to execute tag retention manually.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public Task<CreateTagRetentionExecutionResponse> CreateTagRetentionExecution(CreateTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionExecutionResponse>(req, "CreateTagRetentionExecution");
        }

        /// <summary>
        /// This API is used to execute tag retention manually.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public CreateTagRetentionExecutionResponse CreateTagRetentionExecutionSync(CreateTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionExecutionResponse>(req, "CreateTagRetentionExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public Task<CreateTagRetentionRuleResponse> CreateTagRetentionRule(CreateTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionRuleResponse>(req, "CreateTagRetentionRule");
        }

        /// <summary>
        /// This API is used to create a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public CreateTagRetentionRuleResponse CreateTagRetentionRuleSync(CreateTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionRuleResponse>(req, "CreateTagRetentionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a trigger.
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public Task<CreateWebhookTriggerResponse> CreateWebhookTrigger(CreateWebhookTriggerRequest req)
        {
            return InternalRequestAsync<CreateWebhookTriggerResponse>(req, "CreateWebhookTrigger");
        }

        /// <summary>
        /// This API is used to create a trigger.
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public CreateWebhookTriggerResponse CreateWebhookTriggerSync(CreateWebhookTriggerRequest req)
        {
            return InternalRequestAsync<CreateWebhookTriggerResponse>(req, "CreateWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the specified image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage");
        }

        /// <summary>
        /// This API is used to delete the specified image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public Task<DeleteImageAccelerateServiceResponse> DeleteImageAccelerateService(DeleteImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DeleteImageAccelerateServiceResponse>(req, "DeleteImageAccelerateService");
        }

        /// <summary>
        /// This API is used to delete an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public DeleteImageAccelerateServiceResponse DeleteImageAccelerateServiceSync(DeleteImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DeleteImageAccelerateServiceResponse>(req, "DeleteImageAccelerateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to delete the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public Task<DeleteImmutableTagRulesResponse> DeleteImmutableTagRules(DeleteImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DeleteImmutableTagRulesResponse>(req, "DeleteImmutableTagRules");
        }

        /// <summary>
        ///  This API is used to delete the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public DeleteImmutableTagRulesResponse DeleteImmutableTagRulesSync(DeleteImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DeleteImmutableTagRulesResponse>(req, "DeleteImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TCR Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// This API is used to delete a TCR Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public Task<DeleteInstanceCustomizedDomainResponse> DeleteInstanceCustomizedDomain(DeleteInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DeleteInstanceCustomizedDomainResponse>(req, "DeleteInstanceCustomizedDomain");
        }

        /// <summary>
        /// This API is used to delete a custom domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public DeleteInstanceCustomizedDomainResponse DeleteInstanceCustomizedDomainSync(DeleteInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DeleteInstanceCustomizedDomainResponse>(req, "DeleteInstanceCustomizedDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a long-term access credential.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public Task<DeleteInstanceTokenResponse> DeleteInstanceToken(DeleteInstanceTokenRequest req)
        {
            return InternalRequestAsync<DeleteInstanceTokenResponse>(req, "DeleteInstanceToken");
        }

        /// <summary>
        /// This API is used to delete a long-term access credential.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public DeleteInstanceTokenResponse DeleteInstanceTokenSync(DeleteInstanceTokenRequest req)
        {
            return InternalRequestAsync<DeleteInstanceTokenResponse>(req, "DeleteInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete multiple public network access allowlist policies of the instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public Task<DeleteMultipleSecurityPolicyResponse> DeleteMultipleSecurityPolicy(DeleteMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteMultipleSecurityPolicyResponse>(req, "DeleteMultipleSecurityPolicy");
        }

        /// <summary>
        /// This API is used to delete multiple public network access allowlist policies of the instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public DeleteMultipleSecurityPolicyResponse DeleteMultipleSecurityPolicySync(DeleteMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteMultipleSecurityPolicyResponse>(req, "DeleteMultipleSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace");
        }

        /// <summary>
        /// This API is used to delete a namespace.
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a replica instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance");
        }

        /// <summary>
        /// This API is used to delete a replica instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an image repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public Task<DeleteRepositoryResponse> DeleteRepository(DeleteRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryResponse>(req, "DeleteRepository");
        }

        /// <summary>
        /// This API is used to delete an image repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public DeleteRepositoryResponse DeleteRepositorySync(DeleteRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryResponse>(req, "DeleteRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete repository tags in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public Task<DeleteRepositoryTagsResponse> DeleteRepositoryTags(DeleteRepositoryTagsRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryTagsResponse>(req, "DeleteRepositoryTags");
        }

        /// <summary>
        /// This API is used to batch delete repository tags in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public DeleteRepositoryTagsResponse DeleteRepositoryTagsSync(DeleteRepositoryTagsRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryTagsResponse>(req, "DeleteRepositoryTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a public network access allow policy.
        /// 
        /// Note: When both `PolicyIndex` and `CidrBlock` are specified, `CidrBlock` takes the higher priority
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy");
        }

        /// <summary>
        /// This API is used to delete a public network access allow policy.
        /// 
        /// Note: When both `PolicyIndex` and `CidrBlock` are specified, `CidrBlock` takes the higher priority
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a service account.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceAccountRequest"/></param>
        /// <returns><see cref="DeleteServiceAccountResponse"/></returns>
        public Task<DeleteServiceAccountResponse> DeleteServiceAccount(DeleteServiceAccountRequest req)
        {
            return InternalRequestAsync<DeleteServiceAccountResponse>(req, "DeleteServiceAccount");
        }

        /// <summary>
        /// This API is used to delete a service account.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceAccountRequest"/></param>
        /// <returns><see cref="DeleteServiceAccountResponse"/></returns>
        public DeleteServiceAccountResponse DeleteServiceAccountSync(DeleteServiceAccountRequest req)
        {
            return InternalRequestAsync<DeleteServiceAccountResponse>(req, "DeleteServiceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a namespace signing policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public Task<DeleteSignaturePolicyResponse> DeleteSignaturePolicy(DeleteSignaturePolicyRequest req)
        {
            return InternalRequestAsync<DeleteSignaturePolicyResponse>(req, "DeleteSignaturePolicy");
        }

        /// <summary>
        /// This API is used to delete a namespace signing policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public DeleteSignaturePolicyResponse DeleteSignaturePolicySync(DeleteSignaturePolicyRequest req)
        {
            return InternalRequestAsync<DeleteSignaturePolicyResponse>(req, "DeleteSignaturePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public Task<DeleteTagRetentionRuleResponse> DeleteTagRetentionRule(DeleteTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<DeleteTagRetentionRuleResponse>(req, "DeleteTagRetentionRule");
        }

        /// <summary>
        /// This API is used to delete a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public DeleteTagRetentionRuleResponse DeleteTagRetentionRuleSync(DeleteTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<DeleteTagRetentionRuleResponse>(req, "DeleteTagRetentionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a trigger.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public Task<DeleteWebhookTriggerResponse> DeleteWebhookTrigger(DeleteWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DeleteWebhookTriggerResponse>(req, "DeleteWebhookTrigger");
        }

        /// <summary>
        /// This API is used to delete a trigger.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public DeleteWebhookTriggerResponse DeleteWebhookTriggerSync(DeleteWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DeleteWebhookTriggerResponse>(req, "DeleteWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the chart download information in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public Task<DescribeChartDownloadInfoResponse> DescribeChartDownloadInfo(DescribeChartDownloadInfoRequest req)
        {
            return InternalRequestAsync<DescribeChartDownloadInfoResponse>(req, "DescribeChartDownloadInfo");
        }

        /// <summary>
        /// This API is used to return the chart download information in an Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public DescribeChartDownloadInfoResponse DescribeChartDownloadInfoSync(DescribeChartDownloadInfoRequest req)
        {
            return InternalRequestAsync<DescribeChartDownloadInfoResponse>(req, "DescribeChartDownloadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the public network access entry status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public Task<DescribeExternalEndpointStatusResponse> DescribeExternalEndpointStatus(DescribeExternalEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeExternalEndpointStatusResponse>(req, "DescribeExternalEndpointStatus");
        }

        /// <summary>
        /// This API is used to query the public network access entry status of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public DescribeExternalEndpointStatusResponse DescribeExternalEndpointStatusSync(DescribeExternalEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeExternalEndpointStatusResponse>(req, "DescribeExternalEndpointStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the last ten garbage collection (GC) records.
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public Task<DescribeGCJobsResponse> DescribeGCJobs(DescribeGCJobsRequest req)
        {
            return InternalRequestAsync<DescribeGCJobsResponse>(req, "DescribeGCJobs");
        }

        /// <summary>
        /// This API is used to query the last ten garbage collection (GC) records.
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public DescribeGCJobsResponse DescribeGCJobsSync(DescribeGCJobsRequest req)
        {
            return InternalRequestAsync<DescribeGCJobsResponse>(req, "DescribeGCJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public Task<DescribeImageAccelerateServiceResponse> DescribeImageAccelerateService(DescribeImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DescribeImageAccelerateServiceResponse>(req, "DescribeImageAccelerateService");
        }

        /// <summary>
        /// This API is used to query the status of an image acceleration service.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public DescribeImageAccelerateServiceResponse DescribeImageAccelerateServiceSync(DescribeImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DescribeImageAccelerateServiceResponse>(req, "DescribeImageAccelerateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the manifest information of a container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public Task<DescribeImageManifestsResponse> DescribeImageManifests(DescribeImageManifestsRequest req)
        {
            return InternalRequestAsync<DescribeImageManifestsResponse>(req, "DescribeImageManifests");
        }

        /// <summary>
        /// This API is used to query the manifest information of a container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public DescribeImageManifestsResponse DescribeImageManifestsSync(DescribeImageManifestsRequest req)
        {
            return InternalRequestAsync<DescribeImageManifestsResponse>(req, "DescribeImageManifests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image tags or the information of the specified container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// This API is used to query the list of image tags or the information of the specified container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public Task<DescribeImmutableTagRulesResponse> DescribeImmutableTagRules(DescribeImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeImmutableTagRulesResponse>(req, "DescribeImmutableTagRules");
        }

        /// <summary>
        /// This API is used to list the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public DescribeImmutableTagRulesResponse DescribeImmutableTagRulesSync(DescribeImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeImmutableTagRulesResponse>(req, "DescribeImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of all namespaces in an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public Task<DescribeInstanceAllNamespacesResponse> DescribeInstanceAllNamespaces(DescribeInstanceAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAllNamespacesResponse>(req, "DescribeInstanceAllNamespaces");
        }

        /// <summary>
        /// This API is used to query the list of all namespaces in an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public DescribeInstanceAllNamespacesResponse DescribeInstanceAllNamespacesSync(DescribeInstanceAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAllNamespacesResponse>(req, "DescribeInstanceAllNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of custom domain names of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public Task<DescribeInstanceCustomizedDomainResponse> DescribeInstanceCustomizedDomain(DescribeInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCustomizedDomainResponse>(req, "DescribeInstanceCustomizedDomain");
        }

        /// <summary>
        /// This API is used to query the list of custom domain names of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public DescribeInstanceCustomizedDomainResponse DescribeInstanceCustomizedDomainSync(DescribeInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCustomizedDomainResponse>(req, "DescribeInstanceCustomizedDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the current status and process information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public Task<DescribeInstanceStatusResponse> DescribeInstanceStatus(DescribeInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStatusResponse>(req, "DescribeInstanceStatus");
        }

        /// <summary>
        /// This API is used to query the current status and process information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatusSync(DescribeInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStatusResponse>(req, "DescribeInstanceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of long-term access credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public Task<DescribeInstanceTokenResponse> DescribeInstanceToken(DescribeInstanceTokenRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTokenResponse>(req, "DescribeInstanceToken");
        }

        /// <summary>
        /// This API is used to query the information of long-term access credentials.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public DescribeInstanceTokenResponse DescribeInstanceTokenSync(DescribeInstanceTokenRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTokenResponse>(req, "DescribeInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public Task<DescribeInternalEndpointsResponse> DescribeInternalEndpoints(DescribeInternalEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInternalEndpointsResponse>(req, "DescribeInternalEndpoints");
        }

        /// <summary>
        /// This API is used to query the VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public DescribeInternalEndpointsResponse DescribeInternalEndpointsSync(DescribeInternalEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInternalEndpointsResponse>(req, "DescribeInternalEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the namespace list or the information of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces");
        }

        /// <summary>
        /// This API is used to query the namespace list or the information of the specified namespace.
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the available regions in TCR.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to get the available regions in TCR.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task status of creating a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public Task<DescribeReplicationInstanceCreateTasksResponse> DescribeReplicationInstanceCreateTasks(DescribeReplicationInstanceCreateTasksRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceCreateTasksResponse>(req, "DescribeReplicationInstanceCreateTasks");
        }

        /// <summary>
        /// This API is used to query the task status of creating a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public DescribeReplicationInstanceCreateTasksResponse DescribeReplicationInstanceCreateTasksSync(DescribeReplicationInstanceCreateTasksRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceCreateTasksResponse>(req, "DescribeReplicationInstanceCreateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the synchronization status of a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public Task<DescribeReplicationInstanceSyncStatusResponse> DescribeReplicationInstanceSyncStatus(DescribeReplicationInstanceSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceSyncStatusResponse>(req, "DescribeReplicationInstanceSyncStatus");
        }

        /// <summary>
        /// This API is used to query the synchronization status of a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public DescribeReplicationInstanceSyncStatusResponse DescribeReplicationInstanceSyncStatusSync(DescribeReplicationInstanceSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceSyncStatusResponse>(req, "DescribeReplicationInstanceSyncStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of replication instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public Task<DescribeReplicationInstancesResponse> DescribeReplicationInstances(DescribeReplicationInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstancesResponse>(req, "DescribeReplicationInstances");
        }

        /// <summary>
        /// This API is used to query the list of replication instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public DescribeReplicationInstancesResponse DescribeReplicationInstancesSync(DescribeReplicationInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstancesResponse>(req, "DescribeReplicationInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image repository list or the information of the specified image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public Task<DescribeRepositoriesResponse> DescribeRepositories(DescribeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeRepositoriesResponse>(req, "DescribeRepositories");
        }

        /// <summary>
        /// This API is used to query the image repository list or the information of the specified image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public DescribeRepositoriesResponse DescribeRepositoriesSync(DescribeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeRepositoriesResponse>(req, "DescribeRepositories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the public network access allowlist policies of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public Task<DescribeSecurityPoliciesResponse> DescribeSecurityPolicies(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies");
        }

        /// <summary>
        /// This API is used to query the public network access allowlist policies of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public DescribeSecurityPoliciesResponse DescribeSecurityPoliciesSync(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query service accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAccountsRequest"/></param>
        /// <returns><see cref="DescribeServiceAccountsResponse"/></returns>
        public Task<DescribeServiceAccountsResponse> DescribeServiceAccounts(DescribeServiceAccountsRequest req)
        {
            return InternalRequestAsync<DescribeServiceAccountsResponse>(req, "DescribeServiceAccounts");
        }

        /// <summary>
        /// This API is used to query service accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAccountsRequest"/></param>
        /// <returns><see cref="DescribeServiceAccountsResponse"/></returns>
        public DescribeServiceAccountsResponse DescribeServiceAccountsSync(DescribeServiceAccountsRequest req)
        {
            return InternalRequestAsync<DescribeServiceAccountsResponse>(req, "DescribeServiceAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag retention execution records.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public Task<DescribeTagRetentionExecutionResponse> DescribeTagRetentionExecution(DescribeTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionResponse>(req, "DescribeTagRetentionExecution");
        }

        /// <summary>
        /// This API is used to query tag retention execution records.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public DescribeTagRetentionExecutionResponse DescribeTagRetentionExecutionSync(DescribeTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionResponse>(req, "DescribeTagRetentionExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag retention execution tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public Task<DescribeTagRetentionExecutionTaskResponse> DescribeTagRetentionExecutionTask(DescribeTagRetentionExecutionTaskRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionTaskResponse>(req, "DescribeTagRetentionExecutionTask");
        }

        /// <summary>
        /// This API is used to query tag retention execution tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public DescribeTagRetentionExecutionTaskResponse DescribeTagRetentionExecutionTaskSync(DescribeTagRetentionExecutionTaskRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionTaskResponse>(req, "DescribeTagRetentionExecutionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag retention rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public Task<DescribeTagRetentionRulesResponse> DescribeTagRetentionRules(DescribeTagRetentionRulesRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionRulesResponse>(req, "DescribeTagRetentionRules");
        }

        /// <summary>
        /// This API is used to query tag retention rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public DescribeTagRetentionRulesResponse DescribeTagRetentionRulesSync(DescribeTagRetentionRulesRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionRulesResponse>(req, "DescribeTagRetentionRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query triggers.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public Task<DescribeWebhookTriggerResponse> DescribeWebhookTrigger(DescribeWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerResponse>(req, "DescribeWebhookTrigger");
        }

        /// <summary>
        /// This API is used to query triggers.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public DescribeWebhookTriggerResponse DescribeWebhookTriggerSync(DescribeWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerResponse>(req, "DescribeWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get trigger logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public Task<DescribeWebhookTriggerLogResponse> DescribeWebhookTriggerLog(DescribeWebhookTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerLogResponse>(req, "DescribeWebhookTriggerLog");
        }

        /// <summary>
        /// This API is used to get trigger logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public DescribeWebhookTriggerLogResponse DescribeWebhookTriggerLogSync(DescribeWebhookTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerLogResponse>(req, "DescribeWebhookTriggerLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download a Helm chart in TCR.
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public Task<DownloadHelmChartResponse> DownloadHelmChart(DownloadHelmChartRequest req)
        {
            return InternalRequestAsync<DownloadHelmChartResponse>(req, "DownloadHelmChart");
        }

        /// <summary>
        /// This API is used to download a Helm chart in TCR.
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public DownloadHelmChartResponse DownloadHelmChartSync(DownloadHelmChartRequest req)
        {
            return InternalRequestAsync<DownloadHelmChartResponse>(req, "DownloadHelmChart")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to duplicate the Enterprise Edition repository image version.
        /// </summary>
        /// <param name="req"><see cref="DuplicateImageRequest"/></param>
        /// <returns><see cref="DuplicateImageResponse"/></returns>
        public Task<DuplicateImageResponse> DuplicateImage(DuplicateImageRequest req)
        {
            return InternalRequestAsync<DuplicateImageResponse>(req, "DuplicateImage");
        }

        /// <summary>
        /// This API is used to duplicate the Enterprise Edition repository image version.
        /// </summary>
        /// <param name="req"><see cref="DuplicateImageRequest"/></param>
        /// <returns><see cref="DuplicateImageResponse"/></returns>
        public DuplicateImageResponse DuplicateImageSync(DuplicateImageRequest req)
        {
            return InternalRequestAsync<DuplicateImageResponse>(req, "DuplicateImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public Task<ManageExternalEndpointResponse> ManageExternalEndpoint(ManageExternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageExternalEndpointResponse>(req, "ManageExternalEndpoint");
        }

        /// <summary>
        /// This API is used to manage the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public ManageExternalEndpointResponse ManageExternalEndpointSync(ManageExternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageExternalEndpointResponse>(req, "ManageExternalEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public Task<ManageInternalEndpointResponse> ManageInternalEndpoint(ManageInternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageInternalEndpointResponse>(req, "ManageInternalEndpoint");
        }

        /// <summary>
        /// This API is used to manage VPC URLs for private network access to an instance.
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public ManageInternalEndpointResponse ManageInternalEndpointSync(ManageInternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageInternalEndpointResponse>(req, "ManageInternalEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage the instance synchronization rule.
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public Task<ManageReplicationResponse> ManageReplication(ManageReplicationRequest req)
        {
            return InternalRequestAsync<ManageReplicationResponse>(req, "ManageReplication");
        }

        /// <summary>
        /// This API is used to manage the instance synchronization rule.
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public ManageReplicationResponse ManageReplicationSync(ManageReplicationRequest req)
        {
            return InternalRequestAsync<ManageReplicationResponse>(req, "ManageReplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public Task<ModifyImmutableTagRulesResponse> ModifyImmutableTagRules(ModifyImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<ModifyImmutableTagRulesResponse>(req, "ModifyImmutableTagRules");
        }

        /// <summary>
        /// This API is used to update the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public ModifyImmutableTagRulesResponse ModifyImmutableTagRulesSync(ModifyImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<ModifyImmutableTagRulesResponse>(req, "ModifyImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to update instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the status of the specified long-term access credential in an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public Task<ModifyInstanceTokenResponse> ModifyInstanceToken(ModifyInstanceTokenRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTokenResponse>(req, "ModifyInstanceToken");
        }

        /// <summary>
        /// This API is used to update the status of the specified long-term access credential in an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public ModifyInstanceTokenResponse ModifyInstanceTokenSync(ModifyInstanceTokenRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTokenResponse>(req, "ModifyInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the information of a namespace. Currently, only the namespace access level can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public Task<ModifyNamespaceResponse> ModifyNamespace(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace");
        }

        /// <summary>
        /// This API is used to update the information of a namespace. Currently, only the namespace access level can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public ModifyNamespaceResponse ModifyNamespaceSync(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the information of an image repository. The repository description can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public Task<ModifyRepositoryResponse> ModifyRepository(ModifyRepositoryRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryResponse>(req, "ModifyRepository");
        }

        /// <summary>
        /// This API is used to update the information of an image repository. The repository description can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public ModifyRepositoryResponse ModifyRepositorySync(ModifyRepositoryRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryResponse>(req, "ModifyRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the public network access allowlist of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy");
        }

        /// <summary>
        /// This API is used to update the public network access allowlist of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a service account.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountResponse"/></returns>
        public Task<ModifyServiceAccountResponse> ModifyServiceAccount(ModifyServiceAccountRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountResponse>(req, "ModifyServiceAccount");
        }

        /// <summary>
        /// This API is used to update a service account.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountResponse"/></returns>
        public ModifyServiceAccountResponse ModifyServiceAccountSync(ModifyServiceAccountRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountResponse>(req, "ModifyServiceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the password for a service level account.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountPasswordResponse"/></returns>
        public Task<ModifyServiceAccountPasswordResponse> ModifyServiceAccountPassword(ModifyServiceAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountPasswordResponse>(req, "ModifyServiceAccountPassword");
        }

        /// <summary>
        /// This API is used to update the password for a service level account.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountPasswordResponse"/></returns>
        public ModifyServiceAccountPasswordResponse ModifyServiceAccountPasswordSync(ModifyServiceAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountPasswordResponse>(req, "ModifyServiceAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public Task<ModifyTagRetentionRuleResponse> ModifyTagRetentionRule(ModifyTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<ModifyTagRetentionRuleResponse>(req, "ModifyTagRetentionRule");
        }

        /// <summary>
        /// This API is used to update a tag retention rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public ModifyTagRetentionRuleResponse ModifyTagRetentionRuleSync(ModifyTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<ModifyTagRetentionRuleResponse>(req, "ModifyTagRetentionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a trigger.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public Task<ModifyWebhookTriggerResponse> ModifyWebhookTrigger(ModifyWebhookTriggerRequest req)
        {
            return InternalRequestAsync<ModifyWebhookTriggerResponse>(req, "ModifyWebhookTrigger");
        }

        /// <summary>
        /// This API is used to update a trigger.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public ModifyWebhookTriggerResponse ModifyWebhookTriggerSync(ModifyWebhookTriggerRequest req)
        {
            return InternalRequestAsync<ModifyWebhookTriggerResponse>(req, "ModifyWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew a prepaid instance or change the billing mode from pay-as-you-go billing to monthly subscription billing.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance");
        }

        /// <summary>
        /// This API is used to renew a prepaid instance or change the billing mode from pay-as-you-go billing to monthly subscription billing.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
