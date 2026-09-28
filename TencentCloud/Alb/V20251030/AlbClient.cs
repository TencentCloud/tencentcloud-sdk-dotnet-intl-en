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

namespace TencentCloud.Alb.V20251030
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Alb.V20251030.Models;

   public class AlbClient : AbstractClient{

       private const string endpoint = "alb.intl.tencentcloudapi.com";
       private const string version = "2025-10-30";
       private const string sdkVersion = "SDK_NET_3.0.1402";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AlbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AlbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Add a backend service in the target group.
        /// </summary>
        /// <param name="req"><see cref="AddTargetsToTargetGroupRequest"/></param>
        /// <returns><see cref="AddTargetsToTargetGroupResponse"/></returns>
        public Task<AddTargetsToTargetGroupResponse> AddTargetsToTargetGroup(AddTargetsToTargetGroupRequest req)
        {
            return InternalRequestAsync<AddTargetsToTargetGroupResponse>(req, "AddTargetsToTargetGroup");
        }

        /// <summary>
        /// Add a backend service in the target group.
        /// </summary>
        /// <param name="req"><see cref="AddTargetsToTargetGroupRequest"/></param>
        /// <returns><see cref="AddTargetsToTargetGroupResponse"/></returns>
        public AddTargetsToTargetGroupResponse AddTargetsToTargetGroupSync(AddTargetsToTargetGroupRequest req)
        {
            return InternalRequestAsync<AddTargetsToTargetGroupResponse>(req, "AddTargetsToTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bind a Bandwidth Package to an application CLB instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateBandwidthPackageWithLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateBandwidthPackageWithLoadBalancerResponse"/></returns>
        public Task<AssociateBandwidthPackageWithLoadBalancerResponse> AssociateBandwidthPackageWithLoadBalancer(AssociateBandwidthPackageWithLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateBandwidthPackageWithLoadBalancerResponse>(req, "AssociateBandwidthPackageWithLoadBalancer");
        }

        /// <summary>
        /// Bind a Bandwidth Package to an application CLB instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateBandwidthPackageWithLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateBandwidthPackageWithLoadBalancerResponse"/></returns>
        public AssociateBandwidthPackageWithLoadBalancerResponse AssociateBandwidthPackageWithLoadBalancerSync(AssociateBandwidthPackageWithLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateBandwidthPackageWithLoadBalancerResponse>(req, "AssociateBandwidthPackageWithLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AssociateListenerAdditionalCertificates is an async API. The system returns a request ID, but the additional cert is not yet successfully added. The add task is still in progress in the system backend. You can call the DescribeListenerCertificates API to query the add status of the additional cert.
        /// When HTTPS and QUIC listeners are in Associating status, it means certificate expansion is ongoing.
        /// When HTTPS and QUIC listeners are in the Associated status, the extension cert is successfully added.
        /// </summary>
        /// <param name="req"><see cref="AssociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="AssociateListenerAdditionalCertificatesResponse"/></returns>
        public Task<AssociateListenerAdditionalCertificatesResponse> AssociateListenerAdditionalCertificates(AssociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<AssociateListenerAdditionalCertificatesResponse>(req, "AssociateListenerAdditionalCertificates");
        }

        /// <summary>
        /// AssociateListenerAdditionalCertificates is an async API. The system returns a request ID, but the additional cert is not yet successfully added. The add task is still in progress in the system backend. You can call the DescribeListenerCertificates API to query the add status of the additional cert.
        /// When HTTPS and QUIC listeners are in Associating status, it means certificate expansion is ongoing.
        /// When HTTPS and QUIC listeners are in the Associated status, the extension cert is successfully added.
        /// </summary>
        /// <param name="req"><see cref="AssociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="AssociateListenerAdditionalCertificatesResponse"/></returns>
        public AssociateListenerAdditionalCertificatesResponse AssociateListenerAdditionalCertificatesSync(AssociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<AssociateListenerAdditionalCertificatesResponse>(req, "AssociateListenerAdditionalCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a health check Template.
        /// </summary>
        /// <param name="req"><see cref="CreateHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="CreateHealthCheckTemplateResponse"/></returns>
        public Task<CreateHealthCheckTemplateResponse> CreateHealthCheckTemplate(CreateHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<CreateHealthCheckTemplateResponse>(req, "CreateHealthCheckTemplate");
        }

        /// <summary>
        /// This API is used to create a health check Template.
        /// </summary>
        /// <param name="req"><see cref="CreateHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="CreateHealthCheckTemplateResponse"/></returns>
        public CreateHealthCheckTemplateResponse CreateHealthCheckTemplateSync(CreateHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<CreateHealthCheckTemplateResponse>(req, "CreateHealthCheckTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a listener.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// This API is used to create a listener.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **CreateLoadBalancer** is an async API. The system returns an instance ID, but the application CLB instance is not created successfully yet, and the creation task is still in progress in the system backend. You can call [DescribeLoadBalancerDetail](https://www.tencentcloud.com/document/api/1822/133711) to query the creation status of the application CLB instance.
        /// - When an application CLB instance is in the **Provisioning** status, it means the application CLB instance is being created.
        /// -When an application CLB instance is in the **Active** status, the application CLB instance is successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// **CreateLoadBalancer** is an async API. The system returns an instance ID, but the application CLB instance is not created successfully yet, and the creation task is still in progress in the system backend. You can call [DescribeLoadBalancerDetail](https://www.tencentcloud.com/document/api/1822/133711) to query the creation status of the application CLB instance.
        /// - When an application CLB instance is in the **Provisioning** status, it means the application CLB instance is being created.
        /// -When an application CLB instance is in the **Active** status, the application CLB instance is successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create forwarding rules. It is an async API. After returning successfully, call the DescribeAsyncJobs API with the returned RequestID as an input parameter to check whether this task is successful.
        /// A rule supports up to 10 forward Conditions and 5 forward Actions.
        /// </summary>
        /// <param name="req"><see cref="CreateRulesRequest"/></param>
        /// <returns><see cref="CreateRulesResponse"/></returns>
        public Task<CreateRulesResponse> CreateRules(CreateRulesRequest req)
        {
            return InternalRequestAsync<CreateRulesResponse>(req, "CreateRules");
        }

        /// <summary>
        /// This API is used to create forwarding rules. It is an async API. After returning successfully, call the DescribeAsyncJobs API with the returned RequestID as an input parameter to check whether this task is successful.
        /// A rule supports up to 10 forward Conditions and 5 forward Actions.
        /// </summary>
        /// <param name="req"><see cref="CreateRulesRequest"/></param>
        /// <returns><see cref="CreateRulesResponse"/></returns>
        public CreateRulesResponse CreateRulesSync(CreateRulesRequest req)
        {
            return InternalRequestAsync<CreateRulesResponse>(req, "CreateRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a custom security policy for configuring the TLS protocol version and encryption suite of an HTTPS listener. With a security policy, you can flexibly control the security level of HTTPS communication between clients and load balancing.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy");
        }

        /// <summary>
        /// Create a custom security policy for configuring the TLS protocol version and encryption suite of an HTTPS listener. With a security policy, you can flexibly control the security level of HTTPS communication between clients and load balancing.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Target Group APIs
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup");
        }

        /// <summary>
        /// Target Group APIs
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a health check Template
        /// </summary>
        /// <param name="req"><see cref="DeleteHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DeleteHealthCheckTemplatesResponse"/></returns>
        public Task<DeleteHealthCheckTemplatesResponse> DeleteHealthCheckTemplates(DeleteHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteHealthCheckTemplatesResponse>(req, "DeleteHealthCheckTemplates");
        }

        /// <summary>
        /// Deletes a health check Template
        /// </summary>
        /// <param name="req"><see cref="DeleteHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DeleteHealthCheckTemplatesResponse"/></returns>
        public DeleteHealthCheckTemplatesResponse DeleteHealthCheckTemplatesSync(DeleteHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteHealthCheckTemplatesResponse>(req, "DeleteHealthCheckTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a listener
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// Delete a listener
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The **DeleteLoadBalancers** API is an async API. The system returns a request ID, but the application CLB instance is not yet deleted successfully. The deletion task is still in progress in the system backend. You can call [DescribeLoadBalancerDetail](https://www.tencentcloud.com/document/api/1822/133711) to query the deletion status of the application CLB instance.
        /// - When an application CLB instance is in the **Deleting** status, it means the application CLB instance is being deleted.
        /// -If the specified application CLB instance cannot be queried, the application CLB instance has been deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancersResponse"/></returns>
        public Task<DeleteLoadBalancersResponse> DeleteLoadBalancers(DeleteLoadBalancersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancersResponse>(req, "DeleteLoadBalancers");
        }

        /// <summary>
        /// The **DeleteLoadBalancers** API is an async API. The system returns a request ID, but the application CLB instance is not yet deleted successfully. The deletion task is still in progress in the system backend. You can call [DescribeLoadBalancerDetail](https://www.tencentcloud.com/document/api/1822/133711) to query the deletion status of the application CLB instance.
        /// - When an application CLB instance is in the **Deleting** status, it means the application CLB instance is being deleted.
        /// -If the specified application CLB instance cannot be queried, the application CLB instance has been deleted successfully.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancersResponse"/></returns>
        public DeleteLoadBalancersResponse DeleteLoadBalancersSync(DeleteLoadBalancersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancersResponse>(req, "DeleteLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteRules deletes forwarding rules. This is an async API. After returning successfully, call the DescribeAsyncJobs API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules");
        }

        /// <summary>
        /// DeleteRules deletes forwarding rules. This is an async API. After returning successfully, call the DescribeAsyncJobs API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete one or more custom security policies. Before deletion, please ensure the policy hasn't been referenced by any HTTPS listener, otherwise the deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy");
        }

        /// <summary>
        /// Delete one or more custom security policies. Before deletion, please ensure the policy hasn't been referenced by any HTTPS listener, otherwise the deletion will fail.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a target group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups");
        }

        /// <summary>
        /// Delete a target group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query API for async tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncJobsRequest"/></param>
        /// <returns><see cref="DescribeAsyncJobsResponse"/></returns>
        public Task<DescribeAsyncJobsResponse> DescribeAsyncJobs(DescribeAsyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeAsyncJobsResponse>(req, "DescribeAsyncJobs");
        }

        /// <summary>
        /// Query API for async tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncJobsRequest"/></param>
        /// <returns><see cref="DescribeAsyncJobsResponse"/></returns>
        public DescribeAsyncJobsResponse DescribeAsyncJobsSync(DescribeAsyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeAsyncJobsResponse>(req, "DescribeAsyncJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the health check template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckTemplatesResponse"/></returns>
        public Task<DescribeHealthCheckTemplatesResponse> DescribeHealthCheckTemplates(DescribeHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckTemplatesResponse>(req, "DescribeHealthCheckTemplates");
        }

        /// <summary>
        /// This API is used to query the health check template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckTemplatesResponse"/></returns>
        public DescribeHealthCheckTemplatesResponse DescribeHealthCheckTemplatesSync(DescribeHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckTemplatesResponse>(req, "DescribeHealthCheckTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of certificates bound to a specified listener by instance id and listener id.
        /// If `CertificateType` is set to `SVR`, the information of the extended server certificate and the default server certificate is returned.
        /// If CertificateType is set to CA, the default CA certificate info is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerCertificatesRequest"/></param>
        /// <returns><see cref="DescribeListenerCertificatesResponse"/></returns>
        public Task<DescribeListenerCertificatesResponse> DescribeListenerCertificates(DescribeListenerCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeListenerCertificatesResponse>(req, "DescribeListenerCertificates");
        }

        /// <summary>
        /// This API is used to query the list of certificates bound to a specified listener by instance id and listener id.
        /// If `CertificateType` is set to `SVR`, the information of the extended server certificate and the default server certificate is returned.
        /// If CertificateType is set to CA, the default CA certificate info is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerCertificatesRequest"/></param>
        /// <returns><see cref="DescribeListenerCertificatesResponse"/></returns>
        public DescribeListenerCertificatesResponse DescribeListenerCertificatesSync(DescribeListenerCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeListenerCertificatesResponse>(req, "DescribeListenerCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries details of one listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerDetailRequest"/></param>
        /// <returns><see cref="DescribeListenerDetailResponse"/></returns>
        public Task<DescribeListenerDetailResponse> DescribeListenerDetail(DescribeListenerDetailRequest req)
        {
            return InternalRequestAsync<DescribeListenerDetailResponse>(req, "DescribeListenerDetail");
        }

        /// <summary>
        /// Queries details of one listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerDetailRequest"/></param>
        /// <returns><see cref="DescribeListenerDetailResponse"/></returns>
        public DescribeListenerDetailResponse DescribeListenerDetailSync(DescribeListenerDetailRequest req)
        {
            return InternalRequestAsync<DescribeListenerDetailResponse>(req, "DescribeListenerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the health status of a listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeListenerHealthStatusResponse"/></returns>
        public Task<DescribeListenerHealthStatusResponse> DescribeListenerHealthStatus(DescribeListenerHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeListenerHealthStatusResponse>(req, "DescribeListenerHealthStatus");
        }

        /// <summary>
        /// Queries the health status of a listener.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeListenerHealthStatusResponse"/></returns>
        public DescribeListenerHealthStatusResponse DescribeListenerHealthStatusSync(DescribeListenerHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeListenerHealthStatusResponse>(req, "DescribeListenerHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the listener list
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// Queries the listener list
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries detailed information of a specified load balancing instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerDetailResponse"/></returns>
        public Task<DescribeLoadBalancerDetailResponse> DescribeLoadBalancerDetail(DescribeLoadBalancerDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerDetailResponse>(req, "DescribeLoadBalancerDetail");
        }

        /// <summary>
        /// Queries detailed information of a specified load balancing instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerDetailResponse"/></returns>
        public DescribeLoadBalancerDetailResponse DescribeLoadBalancerDetailSync(DescribeLoadBalancerDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerDetailResponse>(req, "DescribeLoadBalancerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// Query instance configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the ALB quota configuration of the current account. It supports querying by quota type and allows you to pass a resource ID to query resource-level quotas. You can use DisplayFields to return the used amount and remaining available quantity as needed.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota");
        }

        /// <summary>
        /// Queries the ALB quota configuration of the current account. It supports querying by quota type and allows you to pass a resource ID to query resource-level quotas. You can use DisplayFields to return the used amount and remaining available quantity as needed.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public DescribeQuotaResponse DescribeQuotaSync(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// This API is used to query forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the custom security policy list, supports filtering by security policy ID, name, or tag, and supports paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public Task<DescribeSecurityPoliciesResponse> DescribeSecurityPolicies(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies");
        }

        /// <summary>
        /// Queries the custom security policy list, supports filtering by security policy ID, name, or tag, and supports paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public DescribeSecurityPoliciesResponse DescribeSecurityPoliciesSync(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the security policy configuration capacity supported in the current region, including optional TLS protocol versions and the encryption suite list for each version. Before creating or modifying a custom security policy, call this API to get available configuration options.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyCapabilitiesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyCapabilitiesResponse"/></returns>
        public Task<DescribeSecurityPolicyCapabilitiesResponse> DescribeSecurityPolicyCapabilities(DescribeSecurityPolicyCapabilitiesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyCapabilitiesResponse>(req, "DescribeSecurityPolicyCapabilities");
        }

        /// <summary>
        /// Query the security policy configuration capacity supported in the current region, including optional TLS protocol versions and the encryption suite list for each version. Before creating or modifying a custom security policy, call this API to get available configuration options.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyCapabilitiesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyCapabilitiesResponse"/></returns>
        public DescribeSecurityPolicyCapabilitiesResponse DescribeSecurityPolicyCapabilitiesSync(DescribeSecurityPolicyCapabilitiesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyCapabilitiesResponse>(req, "DescribeSecurityPolicyCapabilities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the relationship between a security policy and the HTTPS listeners that refer to it. Before deleting or modifying a security policy, it is advisable to call this API to confirm the impact.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRelationsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRelationsResponse"/></returns>
        public Task<DescribeSecurityPolicyRelationsResponse> DescribeSecurityPolicyRelations(DescribeSecurityPolicyRelationsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyRelationsResponse>(req, "DescribeSecurityPolicyRelations");
        }

        /// <summary>
        /// Query the relationship between a security policy and the HTTPS listeners that refer to it. Before deleting or modifying a security policy, it is advisable to call this API to confirm the impact.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRelationsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRelationsResponse"/></returns>
        public DescribeSecurityPolicyRelationsResponse DescribeSecurityPolicyRelationsSync(DescribeSecurityPolicyRelationsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyRelationsResponse>(req, "DescribeSecurityPolicyRelations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries system security policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSystemSecurityPoliciesResponse"/></returns>
        public Task<DescribeSystemSecurityPoliciesResponse> DescribeSystemSecurityPolicies(DescribeSystemSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSystemSecurityPoliciesResponse>(req, "DescribeSystemSecurityPolicies");
        }

        /// <summary>
        /// Queries system security policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSystemSecurityPoliciesResponse"/></returns>
        public DescribeSystemSecurityPoliciesResponse DescribeSystemSecurityPoliciesSync(DescribeSystemSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSystemSecurityPoliciesResponse>(req, "DescribeSystemSecurityPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries backend services in the target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupTargetsResponse"/></returns>
        public Task<DescribeTargetGroupTargetsResponse> DescribeTargetGroupTargets(DescribeTargetGroupTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupTargetsResponse>(req, "DescribeTargetGroupTargets");
        }

        /// <summary>
        /// Queries backend services in the target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupTargetsResponse"/></returns>
        public DescribeTargetGroupTargetsResponse DescribeTargetGroupTargetsSync(DescribeTargetGroupTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupTargetsResponse>(req, "DescribeTargetGroupTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups");
        }

        /// <summary>
        /// Query the target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query bound target groups based on the slave machine.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsByTargetRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsByTargetResponse"/></returns>
        public Task<DescribeTargetGroupsByTargetResponse> DescribeTargetGroupsByTarget(DescribeTargetGroupsByTargetRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsByTargetResponse>(req, "DescribeTargetGroupsByTarget");
        }

        /// <summary>
        /// Query bound target groups based on the slave machine.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsByTargetRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsByTargetResponse"/></returns>
        public DescribeTargetGroupsByTargetResponse DescribeTargetGroupsByTargetSync(DescribeTargetGroupsByTargetRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsByTargetResponse>(req, "DescribeTargetGroupsByTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying Availability Zones
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// Querying Availability Zones
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Unbind a Bandwidth Package from an application CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateBandwidthPackageFromLoadBalancerRequest"/></param>
        /// <returns><see cref="DisassociateBandwidthPackageFromLoadBalancerResponse"/></returns>
        public Task<DisassociateBandwidthPackageFromLoadBalancerResponse> DisassociateBandwidthPackageFromLoadBalancer(DisassociateBandwidthPackageFromLoadBalancerRequest req)
        {
            return InternalRequestAsync<DisassociateBandwidthPackageFromLoadBalancerResponse>(req, "DisassociateBandwidthPackageFromLoadBalancer");
        }

        /// <summary>
        /// Unbind a Bandwidth Package from an application CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateBandwidthPackageFromLoadBalancerRequest"/></param>
        /// <returns><see cref="DisassociateBandwidthPackageFromLoadBalancerResponse"/></returns>
        public DisassociateBandwidthPackageFromLoadBalancerResponse DisassociateBandwidthPackageFromLoadBalancerSync(DisassociateBandwidthPackageFromLoadBalancerRequest req)
        {
            return InternalRequestAsync<DisassociateBandwidthPackageFromLoadBalancerResponse>(req, "DisassociateBandwidthPackageFromLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DisassociateListenerAdditionalCertificates is an async API. The system returns a request ID, but the additional cert is not yet unbound. The unbinding task is still in progress in the system backend. You can call the DescribeListenerCertificates API to query the cert unbinding status. If the cert is in Disassociating status, it is being unbound.
        /// </summary>
        /// <param name="req"><see cref="DisassociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="DisassociateListenerAdditionalCertificatesResponse"/></returns>
        public Task<DisassociateListenerAdditionalCertificatesResponse> DisassociateListenerAdditionalCertificates(DisassociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<DisassociateListenerAdditionalCertificatesResponse>(req, "DisassociateListenerAdditionalCertificates");
        }

        /// <summary>
        /// DisassociateListenerAdditionalCertificates is an async API. The system returns a request ID, but the additional cert is not yet unbound. The unbinding task is still in progress in the system backend. You can call the DescribeListenerCertificates API to query the cert unbinding status. If the cert is in Disassociating status, it is being unbound.
        /// </summary>
        /// <param name="req"><see cref="DisassociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="DisassociateListenerAdditionalCertificatesResponse"/></returns>
        public DisassociateListenerAdditionalCertificatesResponse DisassociateListenerAdditionalCertificatesSync(DisassociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<DisassociateListenerAdditionalCertificatesResponse>(req, "DisassociateListenerAdditionalCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for creating a load balancer.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateLoadBalancerResponse"/></returns>
        public Task<InquirePriceCreateLoadBalancerResponse> InquirePriceCreateLoadBalancer(InquirePriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateLoadBalancerResponse>(req, "InquirePriceCreateLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the price for creating a load balancer.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateLoadBalancerResponse"/></returns>
        public InquirePriceCreateLoadBalancerResponse InquirePriceCreateLoadBalancerSync(InquirePriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateLoadBalancerResponse>(req, "InquirePriceCreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a health check template
        /// </summary>
        /// <param name="req"><see cref="ModifyHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="ModifyHealthCheckTemplateResponse"/></returns>
        public Task<ModifyHealthCheckTemplateResponse> ModifyHealthCheckTemplate(ModifyHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHealthCheckTemplateResponse>(req, "ModifyHealthCheckTemplate");
        }

        /// <summary>
        /// Modify a health check template
        /// </summary>
        /// <param name="req"><see cref="ModifyHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="ModifyHealthCheckTemplateResponse"/></returns>
        public ModifyHealthCheckTemplateResponse ModifyHealthCheckTemplateSync(ModifyHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHealthCheckTemplateResponse>(req, "ModifyHealthCheckTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies listener properties.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerAttributesRequest"/></param>
        /// <returns><see cref="ModifyListenerAttributesResponse"/></returns>
        public Task<ModifyListenerAttributesResponse> ModifyListenerAttributes(ModifyListenerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyListenerAttributesResponse>(req, "ModifyListenerAttributes");
        }

        /// <summary>
        /// Modifies listener properties.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerAttributesRequest"/></param>
        /// <returns><see cref="ModifyListenerAttributesResponse"/></returns>
        public ModifyListenerAttributesResponse ModifyListenerAttributesSync(ModifyListenerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyListenerAttributesResponse>(req, "ModifyListenerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **Prerequisite:**
        /// You have created an application CLB instance. For detailed operations, please see CreateLoadBalancer.
        /// When you need to change the network type of an application CLB instance from private network to public network through this API, you need to create an Elastic IP first.
        /// **Instructions:**
        /// The ModifyLoadBalancerAddressType API is an async API. The system returns a request ID, but the network type of the application CLB instance has not been changed yet. The change task is still in progress in the system backend. You can call DescribeLoadBalancerDetail to query the change status of the network type of the application CLB instance.
        /// When an application CLB instance is in the Configuring status, it means the network type of the instance is changing.
        /// When an application CLB instance is in the Active status, the network type change of the instance is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAddressTypeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAddressTypeResponse"/></returns>
        public Task<ModifyLoadBalancerAddressTypeResponse> ModifyLoadBalancerAddressType(ModifyLoadBalancerAddressTypeRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAddressTypeResponse>(req, "ModifyLoadBalancerAddressType");
        }

        /// <summary>
        /// **Prerequisite:**
        /// You have created an application CLB instance. For detailed operations, please see CreateLoadBalancer.
        /// When you need to change the network type of an application CLB instance from private network to public network through this API, you need to create an Elastic IP first.
        /// **Instructions:**
        /// The ModifyLoadBalancerAddressType API is an async API. The system returns a request ID, but the network type of the application CLB instance has not been changed yet. The change task is still in progress in the system backend. You can call DescribeLoadBalancerDetail to query the change status of the network type of the application CLB instance.
        /// When an application CLB instance is in the Configuring status, it means the network type of the instance is changing.
        /// When an application CLB instance is in the Active status, the network type change of the instance is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAddressTypeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAddressTypeResponse"/></returns>
        public ModifyLoadBalancerAddressTypeResponse ModifyLoadBalancerAddressTypeSync(ModifyLoadBalancerAddressTypeRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAddressTypeResponse>(req, "ModifyLoadBalancerAddressType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The **ModifyLoadBalancerAttributes** API is an async API. It returns a request ID, but the application CLB instance attribute has not been modified yet. The modifying task is still in progress in the system backend. You can call [DescribeLoadBalancerDetail](https://www.tencentcloud.com/document/api/1822/133711) to query the modification status of the application CLB instance attribute.
        /// -When the application CLB instance attribute is in the **Configuring** status, it means the application CLB instance attribute is being modified.
        /// - When the application CLB instance attribute is in the **Active** status, it means the application CLB instance attribute was modified successfully.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// The **ModifyLoadBalancerAttributes** API is an async API. It returns a request ID, but the application CLB instance attribute has not been modified yet. The modifying task is still in progress in the system backend. You can call [DescribeLoadBalancerDetail](https://www.tencentcloud.com/document/api/1822/133711) to query the modification status of the application CLB instance attribute.
        /// -When the application CLB instance attribute is in the **Configuring** status, it means the application CLB instance attribute is being modified.
        /// - When the application CLB instance attribute is in the **Active** status, it means the application CLB instance attribute was modified successfully.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set load balancing instance modification protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerModificationProtectionRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerModificationProtectionResponse"/></returns>
        public Task<ModifyLoadBalancerModificationProtectionResponse> ModifyLoadBalancerModificationProtection(ModifyLoadBalancerModificationProtectionRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerModificationProtectionResponse>(req, "ModifyLoadBalancerModificationProtection");
        }

        /// <summary>
        /// Set load balancing instance modification protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerModificationProtectionRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerModificationProtectionResponse"/></returns>
        public ModifyLoadBalancerModificationProtectionResponse ModifyLoadBalancerModificationProtectionSync(ModifyLoadBalancerModificationProtectionRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerModificationProtectionResponse>(req, "ModifyLoadBalancerModificationProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify forwarding rule attributes. This is an async API. After the API return succeeds, you can call the DescribeAsyncJobs API with the returned RequestID as an input parameter to check whether this task is successful.
        /// A rule supports up to 10 forward Conditions and 5 forward Actions.
        /// </summary>
        /// <param name="req"><see cref="ModifyRulesAttributesRequest"/></param>
        /// <returns><see cref="ModifyRulesAttributesResponse"/></returns>
        public Task<ModifyRulesAttributesResponse> ModifyRulesAttributes(ModifyRulesAttributesRequest req)
        {
            return InternalRequestAsync<ModifyRulesAttributesResponse>(req, "ModifyRulesAttributes");
        }

        /// <summary>
        /// This API is used to modify forwarding rule attributes. This is an async API. After the API return succeeds, you can call the DescribeAsyncJobs API with the returned RequestID as an input parameter to check whether this task is successful.
        /// A rule supports up to 10 forward Conditions and 5 forward Actions.
        /// </summary>
        /// <param name="req"><see cref="ModifyRulesAttributesRequest"/></param>
        /// <returns><see cref="ModifyRulesAttributesResponse"/></returns>
        public ModifyRulesAttributesResponse ModifyRulesAttributesSync(ModifyRulesAttributesRequest req)
        {
            return InternalRequestAsync<ModifyRulesAttributesResponse>(req, "ModifyRulesAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the properties of a custom security policy, including the policy name, TLS protocol version, and encryption suite. The modified configuration will be applied to all HTTPS listeners associated with this policy immediately.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyAttributesRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyAttributesResponse"/></returns>
        public Task<ModifySecurityPolicyAttributesResponse> ModifySecurityPolicyAttributes(ModifySecurityPolicyAttributesRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyAttributesResponse>(req, "ModifySecurityPolicyAttributes");
        }

        /// <summary>
        /// Modify the properties of a custom security policy, including the policy name, TLS protocol version, and encryption suite. The modified configuration will be applied to all HTTPS listeners associated with this policy immediately.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyAttributesRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyAttributesResponse"/></returns>
        public ModifySecurityPolicyAttributesResponse ModifySecurityPolicyAttributesSync(ModifySecurityPolicyAttributesRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyAttributesResponse>(req, "ModifySecurityPolicyAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the target group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributesRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributesResponse"/></returns>
        public Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributesResponse>(req, "ModifyTargetGroupAttributes");
        }

        /// <summary>
        /// Modify the target group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributesRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributesResponse"/></returns>
        public ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributesSync(ModifyTargetGroupAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributesResponse>(req, "ModifyTargetGroupAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies backend service information in the target group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetsInTargetGroupRequest"/></param>
        /// <returns><see cref="ModifyTargetsInTargetGroupResponse"/></returns>
        public Task<ModifyTargetsInTargetGroupResponse> ModifyTargetsInTargetGroup(ModifyTargetsInTargetGroupRequest req)
        {
            return InternalRequestAsync<ModifyTargetsInTargetGroupResponse>(req, "ModifyTargetsInTargetGroup");
        }

        /// <summary>
        /// Modifies backend service information in the target group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetsInTargetGroupRequest"/></param>
        /// <returns><see cref="ModifyTargetsInTargetGroupResponse"/></returns>
        public ModifyTargetsInTargetGroupResponse ModifyTargetsInTargetGroupSync(ModifyTargetsInTargetGroupRequest req)
        {
            return InternalRequestAsync<ModifyTargetsInTargetGroupResponse>(req, "ModifyTargetsInTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Notify load balancing to unbind real servers
        /// </summary>
        /// <param name="req"><see cref="NotifyUnbindTargetRequest"/></param>
        /// <returns><see cref="NotifyUnbindTargetResponse"/></returns>
        public Task<NotifyUnbindTargetResponse> NotifyUnbindTarget(NotifyUnbindTargetRequest req)
        {
            return InternalRequestAsync<NotifyUnbindTargetResponse>(req, "NotifyUnbindTarget");
        }

        /// <summary>
        /// Notify load balancing to unbind real servers
        /// </summary>
        /// <param name="req"><see cref="NotifyUnbindTargetRequest"/></param>
        /// <returns><see cref="NotifyUnbindTargetResponse"/></returns>
        public NotifyUnbindTargetResponse NotifyUnbindTargetSync(NotifyUnbindTargetRequest req)
        {
            return InternalRequestAsync<NotifyUnbindTargetResponse>(req, "NotifyUnbindTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Removes a backend service from the target group
        /// </summary>
        /// <param name="req"><see cref="RemoveTargetsFromTargetGroupRequest"/></param>
        /// <returns><see cref="RemoveTargetsFromTargetGroupResponse"/></returns>
        public Task<RemoveTargetsFromTargetGroupResponse> RemoveTargetsFromTargetGroup(RemoveTargetsFromTargetGroupRequest req)
        {
            return InternalRequestAsync<RemoveTargetsFromTargetGroupResponse>(req, "RemoveTargetsFromTargetGroup");
        }

        /// <summary>
        /// Removes a backend service from the target group
        /// </summary>
        /// <param name="req"><see cref="RemoveTargetsFromTargetGroupRequest"/></param>
        /// <returns><see cref="RemoveTargetsFromTargetGroupResponse"/></returns>
        public RemoveTargetsFromTargetGroupResponse RemoveTargetsFromTargetGroupSync(RemoveTargetsFromTargetGroupRequest req)
        {
            return InternalRequestAsync<RemoveTargetsFromTargetGroupResponse>(req, "RemoveTargetsFromTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The SetLoadBalancerSecurityGroups API supports setting (binding and unbinding) security groups for a public network load balancing instance. To query the security groups currently bound to a load balancing instance, use the DescribeLoadBalancerDetail API (https://www.tencentcloud.com/document/api/1822/133711?from_cn_redirect=1). This API uses SET semantics.
        /// For the binding operation, input parameters need to be passed in for all security groups that should be bound to the load balancing instance (bound + new binding).
        /// During unbinding, input parameters need to pass in all security groups bound to a CLB instance after unbinding. To unbind all security groups, omit this parameter or specify an empty array.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// The SetLoadBalancerSecurityGroups API supports setting (binding and unbinding) security groups for a public network load balancing instance. To query the security groups currently bound to a load balancing instance, use the DescribeLoadBalancerDetail API (https://www.tencentcloud.com/document/api/1822/133711?from_cn_redirect=1). This API uses SET semantics.
        /// For the binding operation, input parameters need to be passed in for all security groups that should be bound to the load balancing instance (bound + new binding).
        /// During unbinding, input parameters need to pass in all security groups bound to a CLB instance after unbinding. To unbind all security groups, omit this parameter or specify an empty array.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
