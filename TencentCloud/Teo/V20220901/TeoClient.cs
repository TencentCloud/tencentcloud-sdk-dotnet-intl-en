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

namespace TencentCloud.Teo.V20220901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Teo.V20220901.Models;

   public class TeoClient : AbstractClient{

       private const string endpoint = "teo.intl.tencentcloudapi.com";
       private const string version = "2022-09-01";
       private const string sdkVersion = "SDK_NET_3.0.1142";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TeoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TeoClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind/unbind a domain name to/from a specific policy template. 
        /// </summary>
        /// <param name="req"><see cref="BindSecurityTemplateToEntityRequest"/></param>
        /// <returns><see cref="BindSecurityTemplateToEntityResponse"/></returns>
        public Task<BindSecurityTemplateToEntityResponse> BindSecurityTemplateToEntity(BindSecurityTemplateToEntityRequest req)
        {
            return InternalRequestAsync<BindSecurityTemplateToEntityResponse>(req, "BindSecurityTemplateToEntity");
        }

        /// <summary>
        /// This API is used to bind/unbind a domain name to/from a specific policy template. 
        /// </summary>
        /// <param name="req"><see cref="BindSecurityTemplateToEntityRequest"/></param>
        /// <returns><see cref="BindSecurityTemplateToEntityResponse"/></returns>
        public BindSecurityTemplateToEntityResponse BindSecurityTemplateToEntitySync(BindSecurityTemplateToEntityRequest req)
        {
            return InternalRequestAsync<BindSecurityTemplateToEntityResponse>(req, "BindSecurityTemplateToEntity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind/unbind a domain name to/from a shared CNAME. It is now only available to beta users.
        /// </summary>
        /// <param name="req"><see cref="BindSharedCNAMERequest"/></param>
        /// <returns><see cref="BindSharedCNAMEResponse"/></returns>
        public Task<BindSharedCNAMEResponse> BindSharedCNAME(BindSharedCNAMERequest req)
        {
            return InternalRequestAsync<BindSharedCNAMEResponse>(req, "BindSharedCNAME");
        }

        /// <summary>
        /// This API is used to bind/unbind a domain name to/from a shared CNAME. It is now only available to beta users.
        /// </summary>
        /// <param name="req"><see cref="BindSharedCNAMERequest"/></param>
        /// <returns><see cref="BindSharedCNAMEResponse"/></returns>
        public BindSharedCNAMEResponse BindSharedCNAMESync(BindSharedCNAMERequest req)
        {
            return InternalRequestAsync<BindSharedCNAMEResponse>(req, "BindSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a site to a plan.
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public Task<BindZoneToPlanResponse> BindZoneToPlan(BindZoneToPlanRequest req)
        {
            return InternalRequestAsync<BindZoneToPlanResponse>(req, "BindZoneToPlan");
        }

        /// <summary>
        /// This API is used to bind a site to a plan.
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public BindZoneToPlanResponse BindZoneToPlanSync(BindZoneToPlanRequest req)
        {
            return InternalRequestAsync<BindZoneToPlanResponse>(req, "BindZoneToPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CNAME status of a domain name.
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public Task<CheckCnameStatusResponse> CheckCnameStatus(CheckCnameStatusRequest req)
        {
            return InternalRequestAsync<CheckCnameStatusResponse>(req, "CheckCnameStatus");
        }

        /// <summary>
        /// This API is used to query the CNAME status of a domain name.
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public CheckCnameStatusResponse CheckCnameStatusSync(CheckCnameStatusRequest req)
        {
            return InternalRequestAsync<CheckCnameStatusResponse>(req, "CheckCnameStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an acceleration domain name. 
        /// 
        /// For sites connected via the CNAME, if you have not verified the ownership of the domain name, the ownership verification information of the domain name is returned. To verify your ownership of the domain name, see [Ownership Verification](https://intl.cloud.tencent.com/document/product/1552/70789?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerationDomainRequest"/></param>
        /// <returns><see cref="CreateAccelerationDomainResponse"/></returns>
        public Task<CreateAccelerationDomainResponse> CreateAccelerationDomain(CreateAccelerationDomainRequest req)
        {
            return InternalRequestAsync<CreateAccelerationDomainResponse>(req, "CreateAccelerationDomain");
        }

        /// <summary>
        /// This API is used to create an acceleration domain name. 
        /// 
        /// For sites connected via the CNAME, if you have not verified the ownership of the domain name, the ownership verification information of the domain name is returned. To verify your ownership of the domain name, see [Ownership Verification](https://intl.cloud.tencent.com/document/product/1552/70789?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerationDomainRequest"/></param>
        /// <returns><see cref="CreateAccelerationDomainResponse"/></returns>
        public CreateAccelerationDomainResponse CreateAccelerationDomainSync(CreateAccelerationDomainRequest req)
        {
            return InternalRequestAsync<CreateAccelerationDomainResponse>(req, "CreateAccelerationDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public Task<CreateAliasDomainResponse> CreateAliasDomain(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain");
        }

        /// <summary>
        /// This API is used to create an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public CreateAliasDomainResponse CreateAliasDomainSync(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version [CreateL4Proxy] (https://intl.cloud.tencent.com/document/product/1552/103417?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public Task<CreateApplicationProxyResponse> CreateApplicationProxy(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version [CreateL4Proxy] (https://intl.cloud.tencent.com/document/product/1552/103417?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public CreateApplicationProxyResponse CreateApplicationProxySync(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [CreateL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103416?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public Task<CreateApplicationProxyRuleResponse> CreateApplicationProxyRule(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [CreateL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103416?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public CreateApplicationProxyRuleResponse CreateApplicationProxyRuleSync(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create key-value indexes for relevant delivered log fields in the corresponding Tencent Cloud CLS log topic for a specified real-time log delivery task (task-id). If such indexes have been created in CLS, this API will append indexes through merging.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSIndexRequest"/></param>
        /// <returns><see cref="CreateCLSIndexResponse"/></returns>
        public Task<CreateCLSIndexResponse> CreateCLSIndex(CreateCLSIndexRequest req)
        {
            return InternalRequestAsync<CreateCLSIndexResponse>(req, "CreateCLSIndex");
        }

        /// <summary>
        /// This API is used to create key-value indexes for relevant delivered log fields in the corresponding Tencent Cloud CLS log topic for a specified real-time log delivery task (task-id). If such indexes have been created in CLS, this API will append indexes through merging.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSIndexRequest"/></param>
        /// <returns><see cref="CreateCLSIndexResponse"/></returns>
        public CreateCLSIndexResponse CreateCLSIndexSync(CreateCLSIndexRequest req)
        {
            return InternalRequestAsync<CreateCLSIndexResponse>(req, "CreateCLSIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a new version for the specified configuration group in version management mode. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigGroupVersionRequest"/></param>
        /// <returns><see cref="CreateConfigGroupVersionResponse"/></returns>
        public Task<CreateConfigGroupVersionResponse> CreateConfigGroupVersion(CreateConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<CreateConfigGroupVersionResponse>(req, "CreateConfigGroupVersion");
        }

        /// <summary>
        /// This API is used to create a new version for the specified configuration group in version management mode. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigGroupVersionRequest"/></param>
        /// <returns><see cref="CreateConfigGroupVersionResponse"/></returns>
        public CreateConfigGroupVersionResponse CreateConfigGroupVersionSync(CreateConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<CreateConfigGroupVersionResponse>(req, "CreateConfigGroupVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create content identifiers, where you can set descriptions, tags, and other information. It is also necessary to bind an enterprise edition package for billing data statistics. A content identifier can only bind one billing package, while a billing package can bind multiple content identifiers. This feature is only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateContentIdentifierRequest"/></param>
        /// <returns><see cref="CreateContentIdentifierResponse"/></returns>
        public Task<CreateContentIdentifierResponse> CreateContentIdentifier(CreateContentIdentifierRequest req)
        {
            return InternalRequestAsync<CreateContentIdentifierResponse>(req, "CreateContentIdentifier");
        }

        /// <summary>
        /// This API is used to create content identifiers, where you can set descriptions, tags, and other information. It is also necessary to bind an enterprise edition package for billing data statistics. A content identifier can only bind one billing package, while a billing package can bind multiple content identifiers. This feature is only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateContentIdentifierRequest"/></param>
        /// <returns><see cref="CreateContentIdentifierResponse"/></returns>
        public CreateContentIdentifierResponse CreateContentIdentifierSync(CreateContentIdentifierRequest req)
        {
            return InternalRequestAsync<CreateContentIdentifierResponse>(req, "CreateContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom response page.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizeErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomizeErrorPageResponse"/></returns>
        public Task<CreateCustomizeErrorPageResponse> CreateCustomizeErrorPage(CreateCustomizeErrorPageRequest req)
        {
            return InternalRequestAsync<CreateCustomizeErrorPageResponse>(req, "CreateCustomizeErrorPage");
        }

        /// <summary>
        /// This API is used to create a custom response page.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizeErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomizeErrorPageResponse"/></returns>
        public CreateCustomizeErrorPageResponse CreateCustomizeErrorPageSync(CreateCustomizeErrorPageRequest req)
        {
            return InternalRequestAsync<CreateCustomizeErrorPageResponse>(req, "CreateCustomizeErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After creating a site and the site is accessed in NS mode, you can create DNS records through this API.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public Task<CreateDnsRecordResponse> CreateDnsRecord(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord");
        }

        /// <summary>
        /// After creating a site and the site is accessed in NS mode, you can create DNS records through this API.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public CreateDnsRecordResponse CreateDnsRecordSync(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and deploy an edge function to EdgeOne edge nodes.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public Task<CreateFunctionResponse> CreateFunction(CreateFunctionRequest req)
        {
            return InternalRequestAsync<CreateFunctionResponse>(req, "CreateFunction");
        }

        /// <summary>
        /// This API is used to create and deploy an edge function to EdgeOne edge nodes.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public CreateFunctionResponse CreateFunctionSync(CreateFunctionRequest req)
        {
            return InternalRequestAsync<CreateFunctionResponse>(req, "CreateFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a trigger rule for an edge function.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRuleRequest"/></param>
        /// <returns><see cref="CreateFunctionRuleResponse"/></returns>
        public Task<CreateFunctionRuleResponse> CreateFunctionRule(CreateFunctionRuleRequest req)
        {
            return InternalRequestAsync<CreateFunctionRuleResponse>(req, "CreateFunctionRule");
        }

        /// <summary>
        /// This API is used to create a trigger rule for an edge function.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRuleRequest"/></param>
        /// <returns><see cref="CreateFunctionRuleResponse"/></returns>
        public CreateFunctionRuleResponse CreateFunctionRuleSync(CreateFunctionRuleRequest req)
        {
            return InternalRequestAsync<CreateFunctionRuleResponse>(req, "CreateFunctionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Layer 4 proxy instances.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRequest"/></param>
        /// <returns><see cref="CreateL4ProxyResponse"/></returns>
        public Task<CreateL4ProxyResponse> CreateL4Proxy(CreateL4ProxyRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyResponse>(req, "CreateL4Proxy");
        }

        /// <summary>
        /// This API is used to create Layer 4 proxy instances.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRequest"/></param>
        /// <returns><see cref="CreateL4ProxyResponse"/></returns>
        public CreateL4ProxyResponse CreateL4ProxySync(CreateL4ProxyRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyResponse>(req, "CreateL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Layer 4 proxy instance rules, supporting both individual and batch creation.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRulesRequest"/></param>
        /// <returns><see cref="CreateL4ProxyRulesResponse"/></returns>
        public Task<CreateL4ProxyRulesResponse> CreateL4ProxyRules(CreateL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyRulesResponse>(req, "CreateL4ProxyRules");
        }

        /// <summary>
        /// This API is used to create Layer 4 proxy instance rules, supporting both individual and batch creation.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRulesRequest"/></param>
        /// <returns><see cref="CreateL4ProxyRulesResponse"/></returns>
        public CreateL4ProxyRulesResponse CreateL4ProxyRulesSync(CreateL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyRulesResponse>(req, "CreateL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create rules in the [rule engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1). Batch creation is supported.
        /// </summary>
        /// <param name="req"><see cref="CreateL7AccRulesRequest"/></param>
        /// <returns><see cref="CreateL7AccRulesResponse"/></returns>
        public Task<CreateL7AccRulesResponse> CreateL7AccRules(CreateL7AccRulesRequest req)
        {
            return InternalRequestAsync<CreateL7AccRulesResponse>(req, "CreateL7AccRules");
        }

        /// <summary>
        /// This API is used to create rules in the [rule engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1). Batch creation is supported.
        /// </summary>
        /// <param name="req"><see cref="CreateL7AccRulesRequest"/></param>
        /// <returns><see cref="CreateL7AccRulesResponse"/></returns>
        public CreateL7AccRulesResponse CreateL7AccRulesSync(CreateL7AccRulesRequest req)
        {
            return InternalRequestAsync<CreateL7AccRulesResponse>(req, "CreateL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a LoadBalancer. For details, see [Quickly Create Load Balancers](https://intl.cloud.tencent.com/document/product/1552/104223?from_cn_redirect=1). The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// This API is used to create a LoadBalancer. For details, see [Quickly Create Load Balancers](https://intl.cloud.tencent.com/document/product/1552/104223?from_cn_redirect=1). The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an origin group for easy management. The created origin server group can be used for **adding acceleration domain names** and **layer-4 proxy configuration**.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public Task<CreateOriginGroupResponse> CreateOriginGroup(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup");
        }

        /// <summary>
        /// This API is used to create an origin group for easy management. The created origin server group can be used for **adding acceleration domain names** and **layer-4 proxy configuration**.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public CreateOriginGroupResponse CreateOriginGroupSync(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// If you need to use the EdgeOne product, you must create a billing plan through this interface.
        /// > After creating a plan, you need to complete the process of creating a site and binding the plan through [CreateZone](https://intl.cloud.tencent.com/document/product/1552/80719?from_cn_redirect=1), so that the EdgeOne can provide services properly.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanRequest"/></param>
        /// <returns><see cref="CreatePlanResponse"/></returns>
        public Task<CreatePlanResponse> CreatePlan(CreatePlanRequest req)
        {
            return InternalRequestAsync<CreatePlanResponse>(req, "CreatePlan");
        }

        /// <summary>
        /// If you need to use the EdgeOne product, you must create a billing plan through this interface.
        /// > After creating a plan, you need to complete the process of creating a site and binding the plan through [CreateZone](https://intl.cloud.tencent.com/document/product/1552/80719?from_cn_redirect=1), so that the EdgeOne can provide services properly.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanRequest"/></param>
        /// <returns><see cref="CreatePlanResponse"/></returns>
        public CreatePlanResponse CreatePlanSync(CreatePlanRequest req)
        {
            return InternalRequestAsync<CreatePlanResponse>(req, "CreatePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase a plan for a new site.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public Task<CreatePlanForZoneResponse> CreatePlanForZone(CreatePlanForZoneRequest req)
        {
            return InternalRequestAsync<CreatePlanForZoneResponse>(req, "CreatePlanForZone");
        }

        /// <summary>
        /// This API is used to purchase a plan for a new site.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public CreatePlanForZoneResponse CreatePlanForZoneSync(CreatePlanForZoneRequest req)
        {
            return InternalRequestAsync<CreatePlanForZoneResponse>(req, "CreatePlanForZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a pre-warming task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public Task<CreatePrefetchTaskResponse> CreatePrefetchTask(CreatePrefetchTaskRequest req)
        {
            return InternalRequestAsync<CreatePrefetchTaskResponse>(req, "CreatePrefetchTask");
        }

        /// <summary>
        /// This API is used to create a pre-warming task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public CreatePrefetchTaskResponse CreatePrefetchTaskSync(CreatePrefetchTaskRequest req)
        {
            return InternalRequestAsync<CreatePrefetchTaskResponse>(req, "CreatePrefetchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When there are resources updated on the origin with the TTL remaining valid, users cannot access the latest resources. In this case, you can purge the cache using this API. There are two methods: <li>Delete: This method deletes the node cache without verification and retrieves the latest resources from the origin when receiving a request.</li><li>Invalidate: This method marks the node cache as invalid and sends a request with the If-None-Match and If-Modified-Since headers to the origin. If the origin responses with 200, the latest resources are retrieved to be cached on the node. If a 304 response is returned, the latest resources are not cached on the node.
        /// 
        /// </li>For more details, see [Cache Purge](https://intl.cloud.tencent.com/document/product/1552/70759?from_cn_redirect=1). </li>
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public Task<CreatePurgeTaskResponse> CreatePurgeTask(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask");
        }

        /// <summary>
        /// When there are resources updated on the origin with the TTL remaining valid, users cannot access the latest resources. In this case, you can purge the cache using this API. There are two methods: <li>Delete: This method deletes the node cache without verification and retrieves the latest resources from the origin when receiving a request.</li><li>Invalidate: This method marks the node cache as invalid and sends a request with the If-None-Match and If-Modified-Since headers to the origin. If the origin responses with 200, the latest resources are retrieved to be cached on the node. If a 304 response is returned, the latest resources are not cached on the node.
        /// 
        /// </li>For more details, see [Cache Purge](https://intl.cloud.tencent.com/document/product/1552/70759?from_cn_redirect=1). </li>
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public CreatePurgeTaskResponse CreatePurgeTaskSync(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a real-time log delivery task. The following limits apply:
        /// An entity (a Layer 7 domain name or a Layer 4 proxy instance) under the combination of the same data delivery type (LogType) and data delivery area (Area) can be added to only one real-time log delivery task. It is recommended to first query the real-time log delivery task list by entity through the [DescribeRealtimeLogDeliveryTasks](https://intl.cloud.tencent.com/document/product/1552/104110?from_cn_redirect=1) API to check whether the entity has been added to another real-time log delivery task.
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<CreateRealtimeLogDeliveryTaskResponse> CreateRealtimeLogDeliveryTask(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// This API is used to create a real-time log delivery task. The following limits apply:
        /// An entity (a Layer 7 domain name or a Layer 4 proxy instance) under the combination of the same data delivery type (LogType) and data delivery area (Area) can be added to only one real-time log delivery task. It is recommended to first query the real-time log delivery task list by entity through the [DescribeRealtimeLogDeliveryTasks](https://intl.cloud.tencent.com/document/product/1552/104110?from_cn_redirect=1) API to check whether the entity has been added to another real-time log delivery task.
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public CreateRealtimeLogDeliveryTaskResponse CreateRealtimeLogDeliveryTaskSync(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [CreateL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115822?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [CreateL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115822?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a security IP group.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public Task<CreateSecurityIPGroupResponse> CreateSecurityIPGroup(CreateSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityIPGroupResponse>(req, "CreateSecurityIPGroup");
        }

        /// <summary>
        /// This API is used to create a security IP group.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public CreateSecurityIPGroupResponse CreateSecurityIPGroupSync(CreateSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityIPGroupResponse>(req, "CreateSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a shared CNAME. It is now only available to beta users.
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public Task<CreateSharedCNAMEResponse> CreateSharedCNAME(CreateSharedCNAMERequest req)
        {
            return InternalRequestAsync<CreateSharedCNAMEResponse>(req, "CreateSharedCNAME");
        }

        /// <summary>
        /// This API is used to create a shared CNAME. It is now only available to beta users.
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public CreateSharedCNAMEResponse CreateSharedCNAMESync(CreateSharedCNAMERequest req)
        {
            return InternalRequestAsync<CreateSharedCNAMEResponse>(req, "CreateSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a site. After you create the site, you can connect it to EdgeOne via the CNAME or NS (see [Quick Start](https://intl.cloud.tencent.com/document/product/1552/87601?from_cn_redirect=1)), or connect it without a domain name (see [Quick Access to L4 Proxy Service](https://intl.cloud.tencent.com/document/product/1552/96051?from_cn_redirect=1)).
        /// 
        /// If there are already EdgeOne plans under the current account, it is recommended to pass in the `PlanId` to bind the site with the plan directly. If `PlanId` is not passed in, the created site is not activated. You need to call [BindZoneToPlan](https://intl.cloud.tencent.com/document/product/1552/83042?from_cn_redirect=1) to bind the site with a plan. To purchase a plan, please go to the EdgeOne console.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone");
        }

        /// <summary>
        /// This API is used to create a site. After you create the site, you can connect it to EdgeOne via the CNAME or NS (see [Quick Start](https://intl.cloud.tencent.com/document/product/1552/87601?from_cn_redirect=1)), or connect it without a domain name (see [Quick Access to L4 Proxy Service](https://intl.cloud.tencent.com/document/product/1552/96051?from_cn_redirect=1)).
        /// 
        /// If there are already EdgeOne plans under the current account, it is recommended to pass in the `PlanId` to bind the site with the plan directly. If `PlanId` is not passed in, the created site is not activated. You need to call [BindZoneToPlan](https://intl.cloud.tencent.com/document/product/1552/83042?from_cn_redirect=1) to bind the site with a plan. To purchase a plan, please go to the EdgeOne console.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch remove accelerated domain names.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public Task<DeleteAccelerationDomainsResponse> DeleteAccelerationDomains(DeleteAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DeleteAccelerationDomainsResponse>(req, "DeleteAccelerationDomains");
        }

        /// <summary>
        /// This API is used to batch remove accelerated domain names.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public DeleteAccelerationDomainsResponse DeleteAccelerationDomainsSync(DeleteAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DeleteAccelerationDomainsResponse>(req, "DeleteAccelerationDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public Task<DeleteAliasDomainResponse> DeleteAliasDomain(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain");
        }

        /// <summary>
        /// This API is used to delete an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public DeleteAliasDomainResponse DeleteAliasDomainSync(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [DeleteL4Proxy] (https://intl.cloud.tencent.com/document/product/1552/103415?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public Task<DeleteApplicationProxyResponse> DeleteApplicationProxy(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [DeleteL4Proxy] (https://intl.cloud.tencent.com/document/product/1552/103415?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public DeleteApplicationProxyResponse DeleteApplicationProxySync(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [DeleteL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103414?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public Task<DeleteApplicationProxyRuleResponse> DeleteApplicationProxyRule(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [DeleteL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103414?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public DeleteApplicationProxyRuleResponse DeleteApplicationProxyRuleSync(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the specified content identifier. This feature is only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentIdentifierRequest"/></param>
        /// <returns><see cref="DeleteContentIdentifierResponse"/></returns>
        public Task<DeleteContentIdentifierResponse> DeleteContentIdentifier(DeleteContentIdentifierRequest req)
        {
            return InternalRequestAsync<DeleteContentIdentifierResponse>(req, "DeleteContentIdentifier");
        }

        /// <summary>
        /// Delete the specified content identifier. This feature is only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentIdentifierRequest"/></param>
        /// <returns><see cref="DeleteContentIdentifierResponse"/></returns>
        public DeleteContentIdentifierResponse DeleteContentIdentifierSync(DeleteContentIdentifierRequest req)
        {
            return InternalRequestAsync<DeleteContentIdentifierResponse>(req, "DeleteContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a custom response page.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomErrorPageRequest"/></param>
        /// <returns><see cref="DeleteCustomErrorPageResponse"/></returns>
        public Task<DeleteCustomErrorPageResponse> DeleteCustomErrorPage(DeleteCustomErrorPageRequest req)
        {
            return InternalRequestAsync<DeleteCustomErrorPageResponse>(req, "DeleteCustomErrorPage");
        }

        /// <summary>
        /// This API is used to delete a custom response page.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomErrorPageRequest"/></param>
        /// <returns><see cref="DeleteCustomErrorPageResponse"/></returns>
        public DeleteCustomErrorPageResponse DeleteCustomErrorPageSync(DeleteCustomErrorPageRequest req)
        {
            return InternalRequestAsync<DeleteCustomErrorPageResponse>(req, "DeleteCustomErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can use this API to batch delete DNS records.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public Task<DeleteDnsRecordsResponse> DeleteDnsRecords(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords");
        }

        /// <summary>
        /// You can use this API to batch delete DNS records.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public DeleteDnsRecordsResponse DeleteDnsRecordsSync(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an edge function. Once deleted, the function cannot be recovered, and associated trigger rules are also deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction");
        }

        /// <summary>
        /// This API is used to delete an edge function. Once deleted, the function cannot be recovered, and associated trigger rules are also deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a trigger rule for an edge function.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRulesRequest"/></param>
        /// <returns><see cref="DeleteFunctionRulesResponse"/></returns>
        public Task<DeleteFunctionRulesResponse> DeleteFunctionRules(DeleteFunctionRulesRequest req)
        {
            return InternalRequestAsync<DeleteFunctionRulesResponse>(req, "DeleteFunctionRules");
        }

        /// <summary>
        /// This API is used to delete a trigger rule for an edge function.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRulesRequest"/></param>
        /// <returns><see cref="DeleteFunctionRulesResponse"/></returns>
        public DeleteFunctionRulesResponse DeleteFunctionRulesSync(DeleteFunctionRulesRequest req)
        {
            return InternalRequestAsync<DeleteFunctionRulesResponse>(req, "DeleteFunctionRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyResponse"/></returns>
        public Task<DeleteL4ProxyResponse> DeleteL4Proxy(DeleteL4ProxyRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyResponse>(req, "DeleteL4Proxy");
        }

        /// <summary>
        /// This API is used to delete a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyResponse"/></returns>
        public DeleteL4ProxyResponse DeleteL4ProxySync(DeleteL4ProxyRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyResponse>(req, "DeleteL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Layer 4 proxy forwarding rules, supporting both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyRulesResponse"/></returns>
        public Task<DeleteL4ProxyRulesResponse> DeleteL4ProxyRules(DeleteL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyRulesResponse>(req, "DeleteL4ProxyRules");
        }

        /// <summary>
        /// This API is used to delete Layer 4 proxy forwarding rules, supporting both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyRulesResponse"/></returns>
        public DeleteL4ProxyRulesResponse DeleteL4ProxyRulesSync(DeleteL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyRulesResponse>(req, "DeleteL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete rules of the [rule engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1), supporting batch deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7AccRulesRequest"/></param>
        /// <returns><see cref="DeleteL7AccRulesResponse"/></returns>
        public Task<DeleteL7AccRulesResponse> DeleteL7AccRules(DeleteL7AccRulesRequest req)
        {
            return InternalRequestAsync<DeleteL7AccRulesResponse>(req, "DeleteL7AccRules");
        }

        /// <summary>
        /// This API is used to delete rules of the [rule engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1), supporting batch deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7AccRulesRequest"/></param>
        /// <returns><see cref="DeleteL7AccRulesResponse"/></returns>
        public DeleteL7AccRulesResponse DeleteL7AccRulesSync(DeleteL7AccRulesRequest req)
        {
            return InternalRequestAsync<DeleteL7AccRulesResponse>(req, "DeleteL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a LoadBalancer. If the LoadBalancer is referenced by other services (for example, Layer-4 proxy), the LoadBalancer cannot be deleted until the reference relationship is removed. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// This API is used to delete a LoadBalancer. If the LoadBalancer is referenced by other services (for example, Layer-4 proxy), the LoadBalancer cannot be deleted until the reference relationship is removed. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an origin group. Note that an origin group can not be deleted if it is referenced by services (e.g. L4 Proxy, domain name service, load balancing, rule engines). 
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public Task<DeleteOriginGroupResponse> DeleteOriginGroup(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup");
        }

        /// <summary>
        /// This API is used to delete an origin group. Note that an origin group can not be deleted if it is referenced by services (e.g. L4 Proxy, domain name service, load balancing, rule engines). 
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public DeleteOriginGroupResponse DeleteOriginGroupSync(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a real-time log delivery task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="DeleteRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<DeleteRealtimeLogDeliveryTaskResponse> DeleteRealtimeLogDeliveryTask(DeleteRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteRealtimeLogDeliveryTaskResponse>(req, "DeleteRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// This API is used to delete a real-time log delivery task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="DeleteRealtimeLogDeliveryTaskResponse"/></returns>
        public DeleteRealtimeLogDeliveryTaskResponse DeleteRealtimeLogDeliveryTaskSync(DeleteRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteRealtimeLogDeliveryTaskResponse>(req, "DeleteRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [DeleteL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115821?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules");
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [DeleteL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115821?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified security IP group. Note that the security IP group cannot be deleted if it is referenced in a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public Task<DeleteSecurityIPGroupResponse> DeleteSecurityIPGroup(DeleteSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityIPGroupResponse>(req, "DeleteSecurityIPGroup");
        }

        /// <summary>
        /// This API is used to delete a specified security IP group. Note that the security IP group cannot be deleted if it is referenced in a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public DeleteSecurityIPGroupResponse DeleteSecurityIPGroupSync(DeleteSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityIPGroupResponse>(req, "DeleteSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a shared CNAME. It is now only available to beta users.
        /// </summary>
        /// <param name="req"><see cref="DeleteSharedCNAMERequest"/></param>
        /// <returns><see cref="DeleteSharedCNAMEResponse"/></returns>
        public Task<DeleteSharedCNAMEResponse> DeleteSharedCNAME(DeleteSharedCNAMERequest req)
        {
            return InternalRequestAsync<DeleteSharedCNAMEResponse>(req, "DeleteSharedCNAME");
        }

        /// <summary>
        /// This API is used to delete a shared CNAME. It is now only available to beta users.
        /// </summary>
        /// <param name="req"><see cref="DeleteSharedCNAMERequest"/></param>
        /// <returns><see cref="DeleteSharedCNAMEResponse"/></returns>
        public DeleteSharedCNAMEResponse DeleteSharedCNAMESync(DeleteSharedCNAMERequest req)
        {
            return InternalRequestAsync<DeleteSharedCNAMEResponse>(req, "DeleteSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public Task<DeleteZoneResponse> DeleteZone(DeleteZoneRequest req)
        {
            return InternalRequestAsync<DeleteZoneResponse>(req, "DeleteZone");
        }

        /// <summary>
        /// This API is used to delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public DeleteZoneResponse DeleteZoneSync(DeleteZoneRequest req)
        {
            return InternalRequestAsync<DeleteZoneResponse>(req, "DeleteZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release versions in version management mode. Users can deploy the version to either the testing environment or the production environment by specifying the EnvId parameter. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DeployConfigGroupVersionRequest"/></param>
        /// <returns><see cref="DeployConfigGroupVersionResponse"/></returns>
        public Task<DeployConfigGroupVersionResponse> DeployConfigGroupVersion(DeployConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<DeployConfigGroupVersionResponse>(req, "DeployConfigGroupVersion");
        }

        /// <summary>
        /// This API is used to release versions in version management mode. Users can deploy the version to either the testing environment or the production environment by specifying the EnvId parameter. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DeployConfigGroupVersionRequest"/></param>
        /// <returns><see cref="DeployConfigGroupVersionResponse"/></returns>
        public DeployConfigGroupVersionResponse DeployConfigGroupVersionSync(DeployConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<DeployConfigGroupVersionResponse>(req, "DeployConfigGroupVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query domain name information of a site, including the acceleration domain name, origin, and domain name status. You can query the information of all domain names, or specific domain names by specifying filters information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public Task<DescribeAccelerationDomainsResponse> DescribeAccelerationDomains(DescribeAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerationDomainsResponse>(req, "DescribeAccelerationDomains");
        }

        /// <summary>
        /// This API is used to query domain name information of a site, including the acceleration domain name, origin, and domain name status. You can query the information of all domain names, or specific domain names by specifying filters information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public DescribeAccelerationDomainsResponse DescribeAccelerationDomainsSync(DescribeAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerationDomainsResponse>(req, "DescribeAccelerationDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of alias domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public Task<DescribeAliasDomainsResponse> DescribeAliasDomains(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains");
        }

        /// <summary>
        /// This API is used to query the information of alias domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public DescribeAliasDomainsResponse DescribeAliasDomainsSync(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. In the latest version, this API has been split into two APIs: one for querying the Layer 4 proxy instance list and the other for querying Layer 4 forwarding rules. For details, see [DescribeL4Proxy] (https://intl.cloud.tencent.com/document/product/1552/103413?from_cn_redirect=1) and [DescribeL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103412?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public Task<DescribeApplicationProxiesResponse> DescribeApplicationProxies(DescribeApplicationProxiesRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxiesResponse>(req, "DescribeApplicationProxies");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. In the latest version, this API has been split into two APIs: one for querying the Layer 4 proxy instance list and the other for querying Layer 4 forwarding rules. For details, see [DescribeL4Proxy] (https://intl.cloud.tencent.com/document/product/1552/103413?from_cn_redirect=1) and [DescribeL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103412?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public DescribeApplicationProxiesResponse DescribeApplicationProxiesSync(DescribeApplicationProxiesRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxiesResponse>(req, "DescribeApplicationProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query plan options available for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public Task<DescribeAvailablePlansResponse> DescribeAvailablePlans(DescribeAvailablePlansRequest req)
        {
            return InternalRequestAsync<DescribeAvailablePlansResponse>(req, "DescribeAvailablePlans");
        }

        /// <summary>
        /// This API is used to query plan options available for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public DescribeAvailablePlansResponse DescribeAvailablePlansSync(DescribeAvailablePlansRequest req)
        {
            return InternalRequestAsync<DescribeAvailablePlansResponse>(req, "DescribeAvailablePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query billing data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData");
        }

        /// <summary>
        /// This API is used to query billing data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain detailed information about a version in version management mode. The response includes the version ID, description, status, creation time, configuration group information, and the content of the version configuration file. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionDetailRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionDetailResponse"/></returns>
        public Task<DescribeConfigGroupVersionDetailResponse> DescribeConfigGroupVersionDetail(DescribeConfigGroupVersionDetailRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionDetailResponse>(req, "DescribeConfigGroupVersionDetail");
        }

        /// <summary>
        /// This API is used to obtain detailed information about a version in version management mode. The response includes the version ID, description, status, creation time, configuration group information, and the content of the version configuration file. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionDetailRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionDetailResponse"/></returns>
        public DescribeConfigGroupVersionDetailResponse DescribeConfigGroupVersionDetailSync(DescribeConfigGroupVersionDetailRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionDetailResponse>(req, "DescribeConfigGroupVersionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the version list for the specified configuration group in version management mode. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionsResponse"/></returns>
        public Task<DescribeConfigGroupVersionsResponse> DescribeConfigGroupVersions(DescribeConfigGroupVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionsResponse>(req, "DescribeConfigGroupVersions");
        }

        /// <summary>
        /// This API is used to query the version list for the specified configuration group in version management mode. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionsResponse"/></returns>
        public DescribeConfigGroupVersionsResponse DescribeConfigGroupVersionsSync(DescribeConfigGroupVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionsResponse>(req, "DescribeConfigGroupVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch query content identifiers, which can be filtered by ID, description, status, or Tag. Deleted content identifiers queried by status are retained for only three months. This feature is only open to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentIdentifiersRequest"/></param>
        /// <returns><see cref="DescribeContentIdentifiersResponse"/></returns>
        public Task<DescribeContentIdentifiersResponse> DescribeContentIdentifiers(DescribeContentIdentifiersRequest req)
        {
            return InternalRequestAsync<DescribeContentIdentifiersResponse>(req, "DescribeContentIdentifiers");
        }

        /// <summary>
        /// Batch query content identifiers, which can be filtered by ID, description, status, or Tag. Deleted content identifiers queried by status are retained for only three months. This feature is only open to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentIdentifiersRequest"/></param>
        /// <returns><see cref="DescribeContentIdentifiersResponse"/></returns>
        public DescribeContentIdentifiersResponse DescribeContentIdentifiersSync(DescribeContentIdentifiersRequest req)
        {
            return InternalRequestAsync<DescribeContentIdentifiersResponse>(req, "DescribeContentIdentifiers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query content management quotas.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public Task<DescribeContentQuotaResponse> DescribeContentQuota(DescribeContentQuotaRequest req)
        {
            return InternalRequestAsync<DescribeContentQuotaResponse>(req, "DescribeContentQuota");
        }

        /// <summary>
        /// This API is used to query content management quotas.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public DescribeContentQuotaResponse DescribeContentQuotaSync(DescribeContentQuotaRequest req)
        {
            return InternalRequestAsync<DescribeContentQuotaResponse>(req, "DescribeContentQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the custom response page list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomErrorPagesRequest"/></param>
        /// <returns><see cref="DescribeCustomErrorPagesResponse"/></returns>
        public Task<DescribeCustomErrorPagesResponse> DescribeCustomErrorPages(DescribeCustomErrorPagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomErrorPagesResponse>(req, "DescribeCustomErrorPages");
        }

        /// <summary>
        /// This API is used to query the custom response page list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomErrorPagesRequest"/></param>
        /// <returns><see cref="DescribeCustomErrorPagesResponse"/></returns>
        public DescribeCustomErrorPagesResponse DescribeCustomErrorPagesSync(DescribeCustomErrorPagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomErrorPagesResponse>(req, "DescribeCustomErrorPages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time-series data of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public Task<DescribeDDoSAttackDataResponse> DescribeDDoSAttackData(DescribeDDoSAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackDataResponse>(req, "DescribeDDoSAttackData");
        }

        /// <summary>
        /// This API is used to query the time-series data of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public DescribeDDoSAttackDataResponse DescribeDDoSAttackDataSync(DescribeDDoSAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackDataResponse>(req, "DescribeDDoSAttackData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public Task<DescribeDDoSAttackEventResponse> DescribeDDoSAttackEvent(DescribeDDoSAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackEventResponse>(req, "DescribeDDoSAttackEvent");
        }

        /// <summary>
        /// This API is used to query DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public DescribeDDoSAttackEventResponse DescribeDDoSAttackEventSync(DescribeDDoSAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackEventResponse>(req, "DescribeDDoSAttackEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top-ranked DDoS attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public Task<DescribeDDoSAttackTopDataResponse> DescribeDDoSAttackTopData(DescribeDDoSAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackTopDataResponse>(req, "DescribeDDoSAttackTopData");
        }

        /// <summary>
        /// This API is used to query the top-ranked DDoS attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public DescribeDDoSAttackTopDataResponse DescribeDDoSAttackTopDataSync(DescribeDDoSAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackTopDataResponse>(req, "DescribeDDoSAttackTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a list of default certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public Task<DescribeDefaultCertificatesResponse> DescribeDefaultCertificates(DescribeDefaultCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDefaultCertificatesResponse>(req, "DescribeDefaultCertificates");
        }

        /// <summary>
        /// This API is used to query a list of default certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public DescribeDefaultCertificatesResponse DescribeDefaultCertificatesSync(DescribeDefaultCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDefaultCertificatesResponse>(req, "DescribeDefaultCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the release history of versions in the production or test environment in version management mode. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeployHistoryResponse"/></returns>
        public Task<DescribeDeployHistoryResponse> DescribeDeployHistory(DescribeDeployHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeployHistoryResponse>(req, "DescribeDeployHistory");
        }

        /// <summary>
        /// This API is used to query the release history of versions in the production or test environment in version management mode. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeployHistoryResponse"/></returns>
        public DescribeDeployHistoryResponse DescribeDeployHistorySync(DescribeDeployHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeployHistoryResponse>(req, "DescribeDeployHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view DNS record information under a site, including DNS record name, record type, and record content. It supports querying specific DNS record information by specifying filter conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public Task<DescribeDnsRecordsResponse> DescribeDnsRecords(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords");
        }

        /// <summary>
        /// This API is used to view DNS record information under a site, including DNS record name, record type, and record content. It supports querying specific DNS record information by specifying filter conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public DescribeDnsRecordsResponse DescribeDnsRecordsSync(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query environment information in version management mode. The response includes the environment ID, type, and current effective version. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// This API is used to query environment information in version management mode. The response includes the environment ID, type, and current effective version. The version management feature is currently undergoing beta testing and is accessible only to users on the whitelist.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of trigger rules for an edge function. It supports filtering by rule ID, function ID, rule description, and so on.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRulesRequest"/></param>
        /// <returns><see cref="DescribeFunctionRulesResponse"/></returns>
        public Task<DescribeFunctionRulesResponse> DescribeFunctionRules(DescribeFunctionRulesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRulesResponse>(req, "DescribeFunctionRules");
        }

        /// <summary>
        /// This API is used to query the list of trigger rules for an edge function. It supports filtering by rule ID, function ID, rule description, and so on.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRulesRequest"/></param>
        /// <returns><see cref="DescribeFunctionRulesResponse"/></returns>
        public DescribeFunctionRulesResponse DescribeFunctionRulesSync(DescribeFunctionRulesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRulesResponse>(req, "DescribeFunctionRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the runtime environment of an edge function, including environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeFunctionRuntimeEnvironmentResponse"/></returns>
        public Task<DescribeFunctionRuntimeEnvironmentResponse> DescribeFunctionRuntimeEnvironment(DescribeFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRuntimeEnvironmentResponse>(req, "DescribeFunctionRuntimeEnvironment");
        }

        /// <summary>
        /// This API is used to query the runtime environment of an edge function, including environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeFunctionRuntimeEnvironmentResponse"/></returns>
        public DescribeFunctionRuntimeEnvironmentResponse DescribeFunctionRuntimeEnvironmentSync(DescribeFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRuntimeEnvironmentResponse>(req, "DescribeFunctionRuntimeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of edge functions. It supports filtering by function ID, name, description, and so on.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionsRequest"/></param>
        /// <returns><see cref="DescribeFunctionsResponse"/></returns>
        public Task<DescribeFunctionsResponse> DescribeFunctions(DescribeFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionsResponse>(req, "DescribeFunctions");
        }

        /// <summary>
        /// This API is used to query the list of edge functions. It supports filtering by function ID, name, description, and so on.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionsRequest"/></param>
        /// <returns><see cref="DescribeFunctionsResponse"/></returns>
        public DescribeFunctionsResponse DescribeFunctionsSync(DescribeFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionsResponse>(req, "DescribeFunctions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an old version. EdgeOne has fully upgraded the APIs related to the rule engine. You can obtain detailed configurations of domain names through [DescribeL7AccSetting](https://intl.cloud.tencent.com/document/product/1552/115819?from_cn_redirect=1) and [DescribeL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115820?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting");
        }

        /// <summary>
        /// This API is an old version. EdgeOne has fully upgraded the APIs related to the rule engine. You can obtain detailed configurations of domain names through [DescribeL7AccSetting](https://intl.cloud.tencent.com/document/product/1552/115819?from_cn_redirect=1) and [DescribeL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115820?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public DescribeHostsSettingResponse DescribeHostsSettingSync(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check if the IP is an EdgeOne IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPRegionRequest"/></param>
        /// <returns><see cref="DescribeIPRegionResponse"/></returns>
        public Task<DescribeIPRegionResponse> DescribeIPRegion(DescribeIPRegionRequest req)
        {
            return InternalRequestAsync<DescribeIPRegionResponse>(req, "DescribeIPRegion");
        }

        /// <summary>
        /// This API is used to check if the IP is an EdgeOne IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPRegionRequest"/></param>
        /// <returns><see cref="DescribeIPRegionResponse"/></returns>
        public DescribeIPRegionResponse DescribeIPRegionSync(DescribeIPRegionRequest req)
        {
            return InternalRequestAsync<DescribeIPRegionResponse>(req, "DescribeIPRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the verification information of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public Task<DescribeIdentificationsResponse> DescribeIdentifications(DescribeIdentificationsRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationsResponse>(req, "DescribeIdentifications");
        }

        /// <summary>
        /// This API is used to query the verification information of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public DescribeIdentificationsResponse DescribeIdentificationsSync(DescribeIdentificationsRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationsResponse>(req, "DescribeIdentifications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a Layer 4 proxy instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyResponse"/></returns>
        public Task<DescribeL4ProxyResponse> DescribeL4Proxy(DescribeL4ProxyRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyResponse>(req, "DescribeL4Proxy");
        }

        /// <summary>
        /// This API is used to query a Layer 4 proxy instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyResponse"/></returns>
        public DescribeL4ProxyResponse DescribeL4ProxySync(DescribeL4ProxyRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyResponse>(req, "DescribeL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the forwarding rule list under a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyRulesResponse"/></returns>
        public Task<DescribeL4ProxyRulesResponse> DescribeL4ProxyRules(DescribeL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyRulesResponse>(req, "DescribeL4ProxyRules");
        }

        /// <summary>
        /// This API is used to query the forwarding rule list under a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyRulesResponse"/></returns>
        public DescribeL4ProxyRulesResponse DescribeL4ProxyRulesSync(DescribeL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyRulesResponse>(req, "DescribeL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rule list of the rule engine (https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccRulesRequest"/></param>
        /// <returns><see cref="DescribeL7AccRulesResponse"/></returns>
        public Task<DescribeL7AccRulesResponse> DescribeL7AccRules(DescribeL7AccRulesRequest req)
        {
            return InternalRequestAsync<DescribeL7AccRulesResponse>(req, "DescribeL7AccRules");
        }

        /// <summary>
        /// This API is used to query the rule list of the rule engine (https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccRulesRequest"/></param>
        /// <returns><see cref="DescribeL7AccRulesResponse"/></returns>
        public DescribeL7AccRulesResponse DescribeL7AccRulesSync(DescribeL7AccRulesRequest req)
        {
            return InternalRequestAsync<DescribeL7AccRulesResponse>(req, "DescribeL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the global configuration of [Site Acceleration](https://intl.cloud.tencent.com/document/product/1552/96193?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccSettingRequest"/></param>
        /// <returns><see cref="DescribeL7AccSettingResponse"/></returns>
        public Task<DescribeL7AccSettingResponse> DescribeL7AccSetting(DescribeL7AccSettingRequest req)
        {
            return InternalRequestAsync<DescribeL7AccSettingResponse>(req, "DescribeL7AccSetting");
        }

        /// <summary>
        /// This API is used to query the global configuration of [Site Acceleration](https://intl.cloud.tencent.com/document/product/1552/96193?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccSettingRequest"/></param>
        /// <returns><see cref="DescribeL7AccSettingResponse"/></returns>
        public DescribeL7AccSettingResponse DescribeL7AccSettingSync(DescribeL7AccSettingRequest req)
        {
            return InternalRequestAsync<DescribeL7AccSettingResponse>(req, "DescribeL7AccSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the LoadBalancer list. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListResponse"/></returns>
        public Task<DescribeLoadBalancerListResponse> DescribeLoadBalancerList(DescribeLoadBalancerListRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListResponse>(req, "DescribeLoadBalancerList");
        }

        /// <summary>
        /// This API is used to query the LoadBalancer list. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListResponse"/></returns>
        public DescribeLoadBalancerListResponse DescribeLoadBalancerListSync(DescribeLoadBalancerListRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListResponse>(req, "DescribeLoadBalancerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a list of origin groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public Task<DescribeOriginGroupResponse> DescribeOriginGroup(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup");
        }

        /// <summary>
        /// This API is used to obtain a list of origin groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public DescribeOriginGroupResponse DescribeOriginGroupSync(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the health status of origin server groups under a LoadBalancer. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupHealthStatusResponse"/></returns>
        public Task<DescribeOriginGroupHealthStatusResponse> DescribeOriginGroupHealthStatus(DescribeOriginGroupHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupHealthStatusResponse>(req, "DescribeOriginGroupHealthStatus");
        }

        /// <summary>
        /// This API is used to query the health status of origin server groups under a LoadBalancer. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupHealthStatusResponse"/></returns>
        public DescribeOriginGroupHealthStatusResponse DescribeOriginGroupHealthStatusSync(DescribeOriginGroupHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupHealthStatusResponse>(req, "DescribeOriginGroupHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the origin protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public Task<DescribeOriginProtectionResponse> DescribeOriginProtection(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection");
        }

        /// <summary>
        /// This API is used to query the origin protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public DescribeOriginProtectionResponse DescribeOriginProtectionSync(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time sequence traffic data of the monitoring category in L7. This API is to be discarded. Please use the API <a href="https://intl.cloud.tencent.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a>.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public Task<DescribeOverviewL7DataResponse> DescribeOverviewL7Data(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data");
        }

        /// <summary>
        /// This API is used to query the time sequence traffic data of the monitoring category in L7. This API is to be discarded. Please use the API <a href="https://intl.cloud.tencent.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a>.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public DescribeOverviewL7DataResponse DescribeOverviewL7DataSync(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePrefetchTasks is used to query the submission history and execution progress of preheating tasks. This interface can be used to query the tasks submitted by the CreatePrefetchTasks interface.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public Task<DescribePrefetchTasksResponse> DescribePrefetchTasks(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks");
        }

        /// <summary>
        /// DescribePrefetchTasks is used to query the submission history and execution progress of preheating tasks. This interface can be used to query the tasks submitted by the CreatePrefetchTasks interface.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public DescribePrefetchTasksResponse DescribePrefetchTasksSync(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePurgeTasks is used to query the submitted URL refreshing and directory refreshing records and execution progress. This interface can be used to query the tasks submitted by the CreatePurgeTasks API.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// DescribePurgeTasks is used to query the submitted URL refreshing and directory refreshing records and execution progress. This interface can be used to query the tasks submitted by the CreatePurgeTasks API.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time log delivery task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeLogDeliveryTasksRequest"/></param>
        /// <returns><see cref="DescribeRealtimeLogDeliveryTasksResponse"/></returns>
        public Task<DescribeRealtimeLogDeliveryTasksResponse> DescribeRealtimeLogDeliveryTasks(DescribeRealtimeLogDeliveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeRealtimeLogDeliveryTasksResponse>(req, "DescribeRealtimeLogDeliveryTasks");
        }

        /// <summary>
        /// This API is used to query the real-time log delivery task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeLogDeliveryTasksRequest"/></param>
        /// <returns><see cref="DescribeRealtimeLogDeliveryTasksResponse"/></returns>
        public DescribeRealtimeLogDeliveryTasksResponse DescribeRealtimeLogDeliveryTasksSync(DescribeRealtimeLogDeliveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeRealtimeLogDeliveryTasksResponse>(req, "DescribeRealtimeLogDeliveryTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [DescribeL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115820?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [DescribeL7AccRules](https://intl.cloud.tencent.com/document/product/1552/115820?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [RuleEngineAction](https://intl.cloud.tencent.com/document/product/1552/80721?from_cn_redirect=1#RuleEngineAction).
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public Task<DescribeRulesSettingResponse> DescribeRulesSetting(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting");
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [RuleEngineAction](https://intl.cloud.tencent.com/document/product/1552/80721?from_cn_redirect=1#RuleEngineAction).
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public DescribeRulesSettingResponse DescribeRulesSettingSync(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration information of a security IP group, including the ID, name, and content of the security IP group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public Task<DescribeSecurityIPGroupResponse> DescribeSecurityIPGroup(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup");
        }

        /// <summary>
        /// This API is used to query the configuration information of a security IP group, including the ID, name, and content of the security IP group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public DescribeSecurityIPGroupResponse DescribeSecurityIPGroupSync(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API is deprecated and will be discontinued on June 30, 2024. Please use the API [DescribeSecurityIPGroup
        /// ](https://intl.cloud.tencent.com/document/product/1552/105866?from_cn_redirect=1).
        /// 
        /// This API is used to query the configuration information of an IP group, including the IP group name, IP group content, and the site the IP group belongs to.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupInfoResponse"/></returns>
        public Task<DescribeSecurityIPGroupInfoResponse> DescribeSecurityIPGroupInfo(DescribeSecurityIPGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupInfoResponse>(req, "DescribeSecurityIPGroupInfo");
        }

        /// <summary>
        /// The API is deprecated and will be discontinued on June 30, 2024. Please use the API [DescribeSecurityIPGroup
        /// ](https://intl.cloud.tencent.com/document/product/1552/105866?from_cn_redirect=1).
        /// 
        /// This API is used to query the configuration information of an IP group, including the IP group name, IP group content, and the site the IP group belongs to.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupInfoResponse"/></returns>
        public DescribeSecurityIPGroupInfoResponse DescribeSecurityIPGroupInfoSync(DescribeSecurityIPGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupInfoResponse>(req, "DescribeSecurityIPGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the web and security protection configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicy(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy");
        }

        /// <summary>
        /// This API is used to query the web and security protection configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public DescribeSecurityPolicyResponse DescribeSecurityPolicySync(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query bindings of a policy template.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTemplateBindingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTemplateBindingsResponse"/></returns>
        public Task<DescribeSecurityTemplateBindingsResponse> DescribeSecurityTemplateBindings(DescribeSecurityTemplateBindingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTemplateBindingsResponse>(req, "DescribeSecurityTemplateBindings");
        }

        /// <summary>
        /// This API is used to query bindings of a policy template.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTemplateBindingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTemplateBindingsResponse"/></returns>
        public DescribeSecurityTemplateBindingsResponse DescribeSecurityTemplateBindingsSync(DescribeSecurityTemplateBindingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTemplateBindingsResponse>(req, "DescribeSecurityTemplateBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of L4 traffic data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public Task<DescribeTimingL4DataResponse> DescribeTimingL4Data(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data");
        }

        /// <summary>
        /// This API is used to query the list of L4 traffic data recorded over time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public DescribeTimingL4DataResponse DescribeTimingL4DataSync(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time series data of the L7 domain name. Note that there is a delay of about 10 minutes for this API. It is recommended to pull data from 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData");
        }

        /// <summary>
        /// This API is used to query the time series data of the L7 domain name. Note that there is a delay of about 10 minutes for this API. It is recommended to pull data from 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time series traffic data of the L7 cache analysis. It will be deprecated. Use the <a href="https://intl.cloud.tencent.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a> API instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData");
        }

        /// <summary>
        /// This API is used to query the time series traffic data of the L7 cache analysis. It will be deprecated. Use the <a href="https://intl.cloud.tencent.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a> API instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top N data of the L7 domain name by a specified dimension. Note that there is a delay of about 10 minutes for this API. It is recommended to pull data from 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData");
        }

        /// <summary>
        /// This API is used to query the top N data of the L7 domain name by a specified dimension. Note that there is a delay of about 10 minutes for this API. It is recommended to pull data from 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top N data of the L7 cache analysis. It will be deprecated. Use the <a href="https://intl.cloud.tencent.com/document/product/1552/80646?from_cn_redirect=1"> DescribeTopL7AnalysisData</a> API instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData");
        }

        /// <summary>
        /// This API is used to query the top N data of the L7 cache analysis. It will be deprecated. Use the <a href="https://intl.cloud.tencent.com/document/product/1552/80646?from_cn_redirect=1"> DescribeTopL7AnalysisData</a> API instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the results of site configuration import via API (ImportZoneConfig). This feature only supports the sites in the plans of the Standard Edition and the Enterprise Edition.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneConfigImportResultRequest"/></param>
        /// <returns><see cref="DescribeZoneConfigImportResultResponse"/></returns>
        public Task<DescribeZoneConfigImportResultResponse> DescribeZoneConfigImportResult(DescribeZoneConfigImportResultRequest req)
        {
            return InternalRequestAsync<DescribeZoneConfigImportResultResponse>(req, "DescribeZoneConfigImportResult");
        }

        /// <summary>
        /// This API is used to query the results of site configuration import via API (ImportZoneConfig). This feature only supports the sites in the plans of the Standard Edition and the Enterprise Edition.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneConfigImportResultRequest"/></param>
        /// <returns><see cref="DescribeZoneConfigImportResultResponse"/></returns>
        public DescribeZoneConfigImportResultResponse DescribeZoneConfigImportResultSync(DescribeZoneConfigImportResultRequest req)
        {
            return InternalRequestAsync<DescribeZoneConfigImportResultResponse>(req, "DescribeZoneConfigImportResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an old version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [DescribeL7AccSetting](https://intl.cloud.tencent.com/document/product/1552/115819?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting");
        }

        /// <summary>
        /// This API is an old version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [DescribeL7AccSetting](https://intl.cloud.tencent.com/document/product/1552/115819?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public DescribeZoneSettingResponse DescribeZoneSettingSync(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of sites that you have access to. You can filter sites based on different query criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query the information of sites that you have access to. You can filter sites based on different query criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// To stop billing for your EdgeOne plan, you can use this interface to terminate the billing plan.
        /// > Terminating a billing plan requires the following conditions:
        ///     1. The plan has expired (except for the Enterprise Edition Plan);
        ///     2. All sites under the plan have been either shut down or deleted.
        /// 
        /// > The site status can be queried through the [Query Site List](https://intl.cloud.tencent.com/document/product/1552/80713?from_cn_redirect=1) interface.
        /// A site can be deactivated by switching the site to a closed status through the [Switch Site Status](https://intl.cloud.tencent.com/document/product/1552/80707?from_cn_redirect=1) interface.
        /// A site can be deleted by using the [Delete Site](https://intl.cloud.tencent.com/document/product/1552/80717?from_cn_redirect=1) interface.
        /// </summary>
        /// <param name="req"><see cref="DestroyPlanRequest"/></param>
        /// <returns><see cref="DestroyPlanResponse"/></returns>
        public Task<DestroyPlanResponse> DestroyPlan(DestroyPlanRequest req)
        {
            return InternalRequestAsync<DestroyPlanResponse>(req, "DestroyPlan");
        }

        /// <summary>
        /// To stop billing for your EdgeOne plan, you can use this interface to terminate the billing plan.
        /// > Terminating a billing plan requires the following conditions:
        ///     1. The plan has expired (except for the Enterprise Edition Plan);
        ///     2. All sites under the plan have been either shut down or deleted.
        /// 
        /// > The site status can be queried through the [Query Site List](https://intl.cloud.tencent.com/document/product/1552/80713?from_cn_redirect=1) interface.
        /// A site can be deactivated by switching the site to a closed status through the [Switch Site Status](https://intl.cloud.tencent.com/document/product/1552/80707?from_cn_redirect=1) interface.
        /// A site can be deleted by using the [Delete Site](https://intl.cloud.tencent.com/document/product/1552/80717?from_cn_redirect=1) interface.
        /// </summary>
        /// <param name="req"><see cref="DestroyPlanRequest"/></param>
        /// <returns><see cref="DestroyPlanResponse"/></returns>
        public DestroyPlanResponse DestroyPlanSync(DestroyPlanRequest req)
        {
            return InternalRequestAsync<DestroyPlanResponse>(req, "DestroyPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download L4 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public Task<DownloadL4LogsResponse> DownloadL4Logs(DownloadL4LogsRequest req)
        {
            return InternalRequestAsync<DownloadL4LogsResponse>(req, "DownloadL4Logs");
        }

        /// <summary>
        /// This API is used to download L4 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public DownloadL4LogsResponse DownloadL4LogsSync(DownloadL4LogsRequest req)
        {
            return InternalRequestAsync<DownloadL4LogsResponse>(req, "DownloadL4Logs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download L7 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public Task<DownloadL7LogsResponse> DownloadL7Logs(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs");
        }

        /// <summary>
        /// This API is used to download L7 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public DownloadL7LogsResponse DownloadL7LogsSync(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export site configuration . The exported configuration is used for import via the API (ImportZoneConfig). This feature only supports the sites in the plans of the Standard Edition and the Enterprise Edition.
        /// </summary>
        /// <param name="req"><see cref="ExportZoneConfigRequest"/></param>
        /// <returns><see cref="ExportZoneConfigResponse"/></returns>
        public Task<ExportZoneConfigResponse> ExportZoneConfig(ExportZoneConfigRequest req)
        {
            return InternalRequestAsync<ExportZoneConfigResponse>(req, "ExportZoneConfig");
        }

        /// <summary>
        /// This API is used to export site configuration . The exported configuration is used for import via the API (ImportZoneConfig). This feature only supports the sites in the plans of the Standard Edition and the Enterprise Edition.
        /// </summary>
        /// <param name="req"><see cref="ExportZoneConfigRequest"/></param>
        /// <returns><see cref="ExportZoneConfigResponse"/></returns>
        public ExportZoneConfigResponse ExportZoneConfigSync(ExportZoneConfigRequest req)
        {
            return InternalRequestAsync<ExportZoneConfigResponse>(req, "ExportZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to operate the runtime environment of an edge function. It supports related settings for environment variables.
        /// After the environment variables are set, they can be used in the function code. For details, see [Edge Functions Referencing Environment Variables](https://intl.cloud.tencent.com/document/product/1552/109151?from_cn_redirect=1#0151fd9a-8b0e-407b-ae37-54553a60ded6).
        /// </summary>
        /// <param name="req"><see cref="HandleFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="HandleFunctionRuntimeEnvironmentResponse"/></returns>
        public Task<HandleFunctionRuntimeEnvironmentResponse> HandleFunctionRuntimeEnvironment(HandleFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<HandleFunctionRuntimeEnvironmentResponse>(req, "HandleFunctionRuntimeEnvironment");
        }

        /// <summary>
        /// This API is used to operate the runtime environment of an edge function. It supports related settings for environment variables.
        /// After the environment variables are set, they can be used in the function code. For details, see [Edge Functions Referencing Environment Variables](https://intl.cloud.tencent.com/document/product/1552/109151?from_cn_redirect=1#0151fd9a-8b0e-407b-ae37-54553a60ded6).
        /// </summary>
        /// <param name="req"><see cref="HandleFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="HandleFunctionRuntimeEnvironmentResponse"/></returns>
        public HandleFunctionRuntimeEnvironmentResponse HandleFunctionRuntimeEnvironmentSync(HandleFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<HandleFunctionRuntimeEnvironmentResponse>(req, "HandleFunctionRuntimeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify ownership of the site.
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public Task<IdentifyZoneResponse> IdentifyZone(IdentifyZoneRequest req)
        {
            return InternalRequestAsync<IdentifyZoneResponse>(req, "IdentifyZone");
        }

        /// <summary>
        /// This API is used to verify ownership of the site.
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public IdentifyZoneResponse IdentifyZoneSync(IdentifyZoneRequest req)
        {
            return InternalRequestAsync<IdentifyZoneResponse>(req, "IdentifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to quickly import site configuration files. After the import is initiated, the API will return the corresponding task ID (TaskId). Users need to use the site configuration import result query API (DescribeZoneConfigImportResult) to obtain the results of this import task. This feature only supports the sites in the plans of the Standard Edition and the Enterprise Edition.
        /// </summary>
        /// <param name="req"><see cref="ImportZoneConfigRequest"/></param>
        /// <returns><see cref="ImportZoneConfigResponse"/></returns>
        public Task<ImportZoneConfigResponse> ImportZoneConfig(ImportZoneConfigRequest req)
        {
            return InternalRequestAsync<ImportZoneConfigResponse>(req, "ImportZoneConfig");
        }

        /// <summary>
        /// This API is used to quickly import site configuration files. After the import is initiated, the API will return the corresponding task ID (TaskId). Users need to use the site configuration import result query API (DescribeZoneConfigImportResult) to obtain the results of this import task. This feature only supports the sites in the plans of the Standard Edition and the Enterprise Edition.
        /// </summary>
        /// <param name="req"><see cref="ImportZoneConfigRequest"/></param>
        /// <returns><see cref="ImportZoneConfigResponse"/></returns>
        public ImportZoneConfigResponse ImportZoneConfigSync(ImportZoneConfigRequest req)
        {
            return InternalRequestAsync<ImportZoneConfigResponse>(req, "ImportZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When the number of sites bound to your plan, the number of rules under "Web Protection - Custom Rules - Precision Matching Policy", or the number of rules under "Web Protection - Rate Limiting - Precision Rate Limiting Module" reaches the plan's quota, you can use this interface to purchase additional quotas.
        /// > This interface only supports the Enterprise Edition Plan.
        /// </summary>
        /// <param name="req"><see cref="IncreasePlanQuotaRequest"/></param>
        /// <returns><see cref="IncreasePlanQuotaResponse"/></returns>
        public Task<IncreasePlanQuotaResponse> IncreasePlanQuota(IncreasePlanQuotaRequest req)
        {
            return InternalRequestAsync<IncreasePlanQuotaResponse>(req, "IncreasePlanQuota");
        }

        /// <summary>
        /// When the number of sites bound to your plan, the number of rules under "Web Protection - Custom Rules - Precision Matching Policy", or the number of rules under "Web Protection - Rate Limiting - Precision Rate Limiting Module" reaches the plan's quota, you can use this interface to purchase additional quotas.
        /// > This interface only supports the Enterprise Edition Plan.
        /// </summary>
        /// <param name="req"><see cref="IncreasePlanQuotaRequest"/></param>
        /// <returns><see cref="IncreasePlanQuotaResponse"/></returns>
        public IncreasePlanQuotaResponse IncreasePlanQuotaSync(IncreasePlanQuotaRequest req)
        {
            return InternalRequestAsync<IncreasePlanQuotaResponse>(req, "IncreasePlanQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an accelerated domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public Task<ModifyAccelerationDomainResponse> ModifyAccelerationDomain(ModifyAccelerationDomainRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainResponse>(req, "ModifyAccelerationDomain");
        }

        /// <summary>
        /// This API is used to modify an accelerated domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public ModifyAccelerationDomainResponse ModifyAccelerationDomainSync(ModifyAccelerationDomainRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainResponse>(req, "ModifyAccelerationDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify the status of accelerated domains.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public Task<ModifyAccelerationDomainStatusesResponse> ModifyAccelerationDomainStatuses(ModifyAccelerationDomainStatusesRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainStatusesResponse>(req, "ModifyAccelerationDomainStatuses");
        }

        /// <summary>
        /// This API is used to batch modify the status of accelerated domains.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public ModifyAccelerationDomainStatusesResponse ModifyAccelerationDomainStatusesSync(ModifyAccelerationDomainStatusesRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainStatusesResponse>(req, "ModifyAccelerationDomainStatuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public Task<ModifyAliasDomainResponse> ModifyAliasDomain(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain");
        }

        /// <summary>
        /// This API is used to modify an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public ModifyAliasDomainResponse ModifyAliasDomainSync(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public Task<ModifyAliasDomainStatusResponse> ModifyAliasDomainStatus(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus");
        }

        /// <summary>
        /// This API is used to modify the status of an alias domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public ModifyAliasDomainStatusResponse ModifyAliasDomainStatusSync(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4Proxy
        /// ] (https://intl.cloud.tencent.com/document/product/1552/103411?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public Task<ModifyApplicationProxyResponse> ModifyApplicationProxy(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4Proxy
        /// ] (https://intl.cloud.tencent.com/document/product/1552/103411?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public ModifyApplicationProxyResponse ModifyApplicationProxySync(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103410?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public Task<ModifyApplicationProxyRuleResponse> ModifyApplicationProxyRule(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4ProxyRules] (https://intl.cloud.tencent.com/document/product/1552/103410?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public ModifyApplicationProxyRuleResponse ModifyApplicationProxyRuleSync(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4ProxyRulesStatus
        /// ] (https://intl.cloud.tencent.com/document/product/1552/103409?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public Task<ModifyApplicationProxyRuleStatusResponse> ModifyApplicationProxyRuleStatus(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4ProxyRulesStatus
        /// ] (https://intl.cloud.tencent.com/document/product/1552/103409?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public ModifyApplicationProxyRuleStatusResponse ModifyApplicationProxyRuleStatusSync(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4ProxyStatus] (https://intl.cloud.tencent.com/document/product/1552/103408?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public Task<ModifyApplicationProxyStatusResponse> ModifyApplicationProxyStatus(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, please switch to the latest version. For details, see [ModifyL4ProxyStatus] (https://intl.cloud.tencent.com/document/product/1552/103408?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public ModifyApplicationProxyStatusResponse ModifyApplicationProxyStatusSync(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify content identifier, only description modification is supported. This feature is only open to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentIdentifierRequest"/></param>
        /// <returns><see cref="ModifyContentIdentifierResponse"/></returns>
        public Task<ModifyContentIdentifierResponse> ModifyContentIdentifier(ModifyContentIdentifierRequest req)
        {
            return InternalRequestAsync<ModifyContentIdentifierResponse>(req, "ModifyContentIdentifier");
        }

        /// <summary>
        /// Modify content identifier, only description modification is supported. This feature is only open to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentIdentifierRequest"/></param>
        /// <returns><see cref="ModifyContentIdentifierResponse"/></returns>
        public ModifyContentIdentifierResponse ModifyContentIdentifierSync(ModifyContentIdentifierRequest req)
        {
            return InternalRequestAsync<ModifyContentIdentifierResponse>(req, "ModifyContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom response page.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomErrorPageRequest"/></param>
        /// <returns><see cref="ModifyCustomErrorPageResponse"/></returns>
        public Task<ModifyCustomErrorPageResponse> ModifyCustomErrorPage(ModifyCustomErrorPageRequest req)
        {
            return InternalRequestAsync<ModifyCustomErrorPageResponse>(req, "ModifyCustomErrorPage");
        }

        /// <summary>
        /// This API is used to modify a custom response page.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomErrorPageRequest"/></param>
        /// <returns><see cref="ModifyCustomErrorPageResponse"/></returns>
        public ModifyCustomErrorPageResponse ModifyCustomErrorPageSync(ModifyCustomErrorPageRequest req)
        {
            return InternalRequestAsync<ModifyCustomErrorPageResponse>(req, "ModifyCustomErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsResponse"/></returns>
        public Task<ModifyDnsRecordsResponse> ModifyDnsRecords(ModifyDnsRecordsRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsResponse>(req, "ModifyDnsRecords");
        }

        /// <summary>
        /// This API is used to bulk modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsResponse"/></returns>
        public ModifyDnsRecordsResponse ModifyDnsRecordsSync(ModifyDnsRecordsRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsResponse>(req, "ModifyDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can batch modify the status of DNS records through this API, enabling and disabling records in bulk.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsStatusResponse"/></returns>
        public Task<ModifyDnsRecordsStatusResponse> ModifyDnsRecordsStatus(ModifyDnsRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsStatusResponse>(req, "ModifyDnsRecordsStatus");
        }

        /// <summary>
        /// You can batch modify the status of DNS records through this API, enabling and disabling records in bulk.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsStatusResponse"/></returns>
        public ModifyDnsRecordsStatusResponse ModifyDnsRecordsStatusSync(ModifyDnsRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsStatusResponse>(req, "ModifyDnsRecordsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an edge function. It supports modifying the function content and description. The function will take effect immediately after modification and redeployment.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRequest"/></param>
        /// <returns><see cref="ModifyFunctionResponse"/></returns>
        public Task<ModifyFunctionResponse> ModifyFunction(ModifyFunctionRequest req)
        {
            return InternalRequestAsync<ModifyFunctionResponse>(req, "ModifyFunction");
        }

        /// <summary>
        /// This API is used to modify an edge function. It supports modifying the function content and description. The function will take effect immediately after modification and redeployment.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRequest"/></param>
        /// <returns><see cref="ModifyFunctionResponse"/></returns>
        public ModifyFunctionResponse ModifyFunctionSync(ModifyFunctionRequest req)
        {
            return InternalRequestAsync<ModifyFunctionResponse>(req, "ModifyFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a trigger rule for an edge function. It supports modifying rule conditions, execution functions, and description.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRuleRequest"/></param>
        /// <returns><see cref="ModifyFunctionRuleResponse"/></returns>
        public Task<ModifyFunctionRuleResponse> ModifyFunctionRule(ModifyFunctionRuleRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRuleResponse>(req, "ModifyFunctionRule");
        }

        /// <summary>
        /// This API is used to modify a trigger rule for an edge function. It supports modifying rule conditions, execution functions, and description.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRuleRequest"/></param>
        /// <returns><see cref="ModifyFunctionRuleResponse"/></returns>
        public ModifyFunctionRuleResponse ModifyFunctionRuleSync(ModifyFunctionRuleRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRuleResponse>(req, "ModifyFunctionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the priority of trigger rules for an edge function.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyFunctionRulePriorityResponse"/></returns>
        public Task<ModifyFunctionRulePriorityResponse> ModifyFunctionRulePriority(ModifyFunctionRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRulePriorityResponse>(req, "ModifyFunctionRulePriority");
        }

        /// <summary>
        /// This API is used to modify the priority of trigger rules for an edge function.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyFunctionRulePriorityResponse"/></returns>
        public ModifyFunctionRulePriorityResponse ModifyFunctionRulePrioritySync(ModifyFunctionRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRulePriorityResponse>(req, "ModifyFunctionRulePriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the certificate of a site. You can use your own certificate or [apply for a free certificate](https://intl.cloud.tencent.com/document/product/1552/90437?from_cn_redirect=1).
        /// To use an external certificate, upload the certificate to [SSL Certificates Console](https://console.cloud.tencent.com/certoview) first, and then input the certificate ID in this API. For details, see [Deploying Own Certificates to EdgeOne Domains](https://intl.cloud.tencent.com/document/product/1552/88874?from_cn_redirect=1).
        ///  
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public Task<ModifyHostsCertificateResponse> ModifyHostsCertificate(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate");
        }

        /// <summary>
        /// This API is used to configure the certificate of a site. You can use your own certificate or [apply for a free certificate](https://intl.cloud.tencent.com/document/product/1552/90437?from_cn_redirect=1).
        /// To use an external certificate, upload the certificate to [SSL Certificates Console](https://console.cloud.tencent.com/certoview) first, and then input the certificate ID in this API. For details, see [Deploying Own Certificates to EdgeOne Domains](https://intl.cloud.tencent.com/document/product/1552/88874?from_cn_redirect=1).
        ///  
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public ModifyHostsCertificateResponse ModifyHostsCertificateSync(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyResponse"/></returns>
        public Task<ModifyL4ProxyResponse> ModifyL4Proxy(ModifyL4ProxyRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyResponse>(req, "ModifyL4Proxy");
        }

        /// <summary>
        /// This API is used to modify the configuration of a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyResponse"/></returns>
        public ModifyL4ProxyResponse ModifyL4ProxySync(ModifyL4ProxyRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyResponse>(req, "ModifyL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Layer 4 proxy forwarding rules, supporting both individual and batch modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesResponse"/></returns>
        public Task<ModifyL4ProxyRulesResponse> ModifyL4ProxyRules(ModifyL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesResponse>(req, "ModifyL4ProxyRules");
        }

        /// <summary>
        /// This API is used to modify Layer 4 proxy forwarding rules, supporting both individual and batch modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesResponse"/></returns>
        public ModifyL4ProxyRulesResponse ModifyL4ProxyRulesSync(ModifyL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesResponse>(req, "ModifyL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start or stop Layer 4 proxy forwarding rules, supporting both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesStatusResponse"/></returns>
        public Task<ModifyL4ProxyRulesStatusResponse> ModifyL4ProxyRulesStatus(ModifyL4ProxyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesStatusResponse>(req, "ModifyL4ProxyRulesStatus");
        }

        /// <summary>
        /// This API is used to start or stop Layer 4 proxy forwarding rules, supporting both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesStatusResponse"/></returns>
        public ModifyL4ProxyRulesStatusResponse ModifyL4ProxyRulesStatusSync(ModifyL4ProxyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesStatusResponse>(req, "ModifyL4ProxyRulesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyStatusResponse"/></returns>
        public Task<ModifyL4ProxyStatusResponse> ModifyL4ProxyStatus(ModifyL4ProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyStatusResponse>(req, "ModifyL4ProxyStatus");
        }

        /// <summary>
        /// This API is used to enable or disable a Layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyStatusResponse"/></returns>
        public ModifyL4ProxyStatusResponse ModifyL4ProxyStatusSync(ModifyL4ProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyStatusResponse>(req, "ModifyL4ProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify rules in the [rule engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1), supporting only one rule modification per request.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRuleRequest"/></param>
        /// <returns><see cref="ModifyL7AccRuleResponse"/></returns>
        public Task<ModifyL7AccRuleResponse> ModifyL7AccRule(ModifyL7AccRuleRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRuleResponse>(req, "ModifyL7AccRule");
        }

        /// <summary>
        /// This API is used to modify rules in the [rule engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1), supporting only one rule modification per request.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRuleRequest"/></param>
        /// <returns><see cref="ModifyL7AccRuleResponse"/></returns>
        public ModifyL7AccRuleResponse ModifyL7AccRuleSync(ModifyL7AccRuleRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRuleResponse>(req, "ModifyL7AccRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface is used to modify the priority of the rule list in the [Rule Engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1). This interface requires the complete rule ID list under the site ID to be passed in. The rule ID list can be obtained through the [Query Seven-Layer Acceleration Rules](https://intl.cloud.tencent.com/document/product/1552/115820?from_cn_redirect=1) interface. The final priority order will be adjusted to the order of the rule ID list, and will be executed from front to back.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyL7AccRulePriorityResponse"/></returns>
        public Task<ModifyL7AccRulePriorityResponse> ModifyL7AccRulePriority(ModifyL7AccRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRulePriorityResponse>(req, "ModifyL7AccRulePriority");
        }

        /// <summary>
        /// This interface is used to modify the priority of the rule list in the [Rule Engine](https://intl.cloud.tencent.com/document/product/1552/70901?from_cn_redirect=1). This interface requires the complete rule ID list under the site ID to be passed in. The rule ID list can be obtained through the [Query Seven-Layer Acceleration Rules](https://intl.cloud.tencent.com/document/product/1552/115820?from_cn_redirect=1) interface. The final priority order will be adjusted to the order of the rule ID list, and will be executed from front to back.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyL7AccRulePriorityResponse"/></returns>
        public ModifyL7AccRulePriorityResponse ModifyL7AccRulePrioritySync(ModifyL7AccRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRulePriorityResponse>(req, "ModifyL7AccRulePriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the global configuration of [Site Acceleration](https://intl.cloud.tencent.com/document/product/1552/96193?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccSettingRequest"/></param>
        /// <returns><see cref="ModifyL7AccSettingResponse"/></returns>
        public Task<ModifyL7AccSettingResponse> ModifyL7AccSetting(ModifyL7AccSettingRequest req)
        {
            return InternalRequestAsync<ModifyL7AccSettingResponse>(req, "ModifyL7AccSetting");
        }

        /// <summary>
        /// This API is used to modify the global configuration of [Site Acceleration](https://intl.cloud.tencent.com/document/product/1552/96193?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccSettingRequest"/></param>
        /// <returns><see cref="ModifyL7AccSettingResponse"/></returns>
        public ModifyL7AccSettingResponse ModifyL7AccSettingSync(ModifyL7AccSettingRequest req)
        {
            return InternalRequestAsync<ModifyL7AccSettingResponse>(req, "ModifyL7AccSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify LoadBalancer configuration. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public Task<ModifyLoadBalancerResponse> ModifyLoadBalancer(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer");
        }

        /// <summary>
        /// This API is used to modify LoadBalancer configuration. The load balancing feature is in beta test. If you need to use it, [contact us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public ModifyLoadBalancerResponse ModifyLoadBalancerSync(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of an origin group. The original configuration will be overwritten. 
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public Task<ModifyOriginGroupResponse> ModifyOriginGroup(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup");
        }

        /// <summary>
        /// This API is used to modify the configuration of an origin group. The original configuration will be overwritten. 
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public ModifyOriginGroupResponse ModifyOriginGroupSync(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the plan settings. Currently, only the auto-renewal switch of prepaid plans can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyPlanRequest"/></param>
        /// <returns><see cref="ModifyPlanResponse"/></returns>
        public Task<ModifyPlanResponse> ModifyPlan(ModifyPlanRequest req)
        {
            return InternalRequestAsync<ModifyPlanResponse>(req, "ModifyPlan");
        }

        /// <summary>
        /// Modify the plan settings. Currently, only the auto-renewal switch of prepaid plans can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyPlanRequest"/></param>
        /// <returns><see cref="ModifyPlanResponse"/></returns>
        public ModifyPlanResponse ModifyPlanSync(ModifyPlanRequest req)
        {
            return InternalRequestAsync<ModifyPlanResponse>(req, "ModifyPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the real-time log delivery task configuration. This API has the following restrictions:<li>Does not support modifying the destination type of the real-time log delivery task (TaskType);</li><li>Does not support modifying the data delivery type (LogType);</li><li>Does not support modifying the data delivery area (Area);</li><li>Does not support modifying the detailed destination configuration, such as log set and log topic, when the destination of the original real-time log delivery task is Tencent Cloud CLS.</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="ModifyRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<ModifyRealtimeLogDeliveryTaskResponse> ModifyRealtimeLogDeliveryTask(ModifyRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyRealtimeLogDeliveryTaskResponse>(req, "ModifyRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// This API is used to modify the real-time log delivery task configuration. This API has the following restrictions:<li>Does not support modifying the destination type of the real-time log delivery task (TaskType);</li><li>Does not support modifying the data delivery type (LogType);</li><li>Does not support modifying the data delivery area (Area);</li><li>Does not support modifying the detailed destination configuration, such as log set and log topic, when the destination of the original real-time log delivery task is Tencent Cloud CLS.</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="ModifyRealtimeLogDeliveryTaskResponse"/></returns>
        public ModifyRealtimeLogDeliveryTaskResponse ModifyRealtimeLogDeliveryTaskSync(ModifyRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyRealtimeLogDeliveryTaskResponse>(req, "ModifyRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [ModifyL7AccRule](https://intl.cloud.tencent.com/document/product/1552/115818?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [ModifyL7AccRule](https://intl.cloud.tencent.com/document/product/1552/115818?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a security IP group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public Task<ModifySecurityIPGroupResponse> ModifySecurityIPGroup(ModifySecurityIPGroupRequest req)
        {
            return InternalRequestAsync<ModifySecurityIPGroupResponse>(req, "ModifySecurityIPGroup");
        }

        /// <summary>
        /// This API is used to modify a security IP group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public ModifySecurityIPGroupResponse ModifySecurityIPGroupSync(ModifySecurityIPGroupRequest req)
        {
            return InternalRequestAsync<ModifySecurityIPGroupResponse>(req, "ModifySecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the web and bot security configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy");
        }

        /// <summary>
        /// This API is used to modify the web and bot security configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public Task<ModifyZoneResponse> ModifyZone(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone");
        }

        /// <summary>
        /// This API is used to modify a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public ModifyZoneResponse ModifyZoneSync(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [ModifyL7AccSetting](https://intl.cloud.tencent.com/document/product/1552/115817?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting");
        }

        /// <summary>
        /// This API is an older version. EdgeOne has fully upgraded the APIs related to the rule engine. For details, please refer to [ModifyL7AccSetting](https://intl.cloud.tencent.com/document/product/1552/115817?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public ModifyZoneSettingResponse ModifyZoneSettingSync(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the site status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public Task<ModifyZoneStatusResponse> ModifyZoneStatus(ModifyZoneStatusRequest req)
        {
            return InternalRequestAsync<ModifyZoneStatusResponse>(req, "ModifyZoneStatus");
        }

        /// <summary>
        /// This API is used to change the site status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public ModifyZoneStatusResponse ModifyZoneStatusSync(ModifyZoneStatusRequest req)
        {
            return InternalRequestAsync<ModifyZoneStatusResponse>(req, "ModifyZoneStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When your plan needs to be extended, you can use this interface to renew it. Plan renewal is only supported for the Personal, Basic, and Standard Editions.
        /// > For cost details, refer to [Plan Fees](https://intl.cloud.tencent.com/document/product/1552/94158?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="RenewPlanRequest"/></param>
        /// <returns><see cref="RenewPlanResponse"/></returns>
        public Task<RenewPlanResponse> RenewPlan(RenewPlanRequest req)
        {
            return InternalRequestAsync<RenewPlanResponse>(req, "RenewPlan");
        }

        /// <summary>
        /// When your plan needs to be extended, you can use this interface to renew it. Plan renewal is only supported for the Personal, Basic, and Standard Editions.
        /// > For cost details, refer to [Plan Fees](https://intl.cloud.tencent.com/document/product/1552/94158?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="RenewPlanRequest"/></param>
        /// <returns><see cref="RenewPlanResponse"/></returns>
        public RenewPlanResponse RenewPlanSync(RenewPlanRequest req)
        {
            return InternalRequestAsync<RenewPlanResponse>(req, "RenewPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When you need features available only in higher-tier plans, you can upgrade your plan through this interface. Upgrades are only supported for Personal and Basic Edition Plans.
        /// > For differences between EdgeOne billing plans, refer to [Comparison of EdgeOne Plans](https://intl.cloud.tencent.com/document/product/1552/94165?from_cn_redirect=1).
        /// For EdgeOne plan upgrade rules and pricing details, refer to [EdgeOne Plan Upgrade Guide](https://intl.cloud.tencent.com/document/product/1552/95291?from_cn_redirect=1).
        /// If your plan needs to upgrade to the Enterprise Edition, [Contact Us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="UpgradePlanRequest"/></param>
        /// <returns><see cref="UpgradePlanResponse"/></returns>
        public Task<UpgradePlanResponse> UpgradePlan(UpgradePlanRequest req)
        {
            return InternalRequestAsync<UpgradePlanResponse>(req, "UpgradePlan");
        }

        /// <summary>
        /// When you need features available only in higher-tier plans, you can upgrade your plan through this interface. Upgrades are only supported for Personal and Basic Edition Plans.
        /// > For differences between EdgeOne billing plans, refer to [Comparison of EdgeOne Plans](https://intl.cloud.tencent.com/document/product/1552/94165?from_cn_redirect=1).
        /// For EdgeOne plan upgrade rules and pricing details, refer to [EdgeOne Plan Upgrade Guide](https://intl.cloud.tencent.com/document/product/1552/95291?from_cn_redirect=1).
        /// If your plan needs to upgrade to the Enterprise Edition, [Contact Us](https://intl.cloud.tencent.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="UpgradePlanRequest"/></param>
        /// <returns><see cref="UpgradePlanResponse"/></returns>
        public UpgradePlanResponse UpgradePlanSync(UpgradePlanRequest req)
        {
            return InternalRequestAsync<UpgradePlanResponse>(req, "UpgradePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify your ownership of a site or domain name. It's required in the CNAME access mode. After a site is verified, you don't need to verify the ownership again for domain names added to it in the future. For details, see [Ownership Verification](https://intl.cloud.tencent.com/document/product/1552/70789?from_cn_redirect=1).
        /// 
        /// For sites connected via the NS, you can query whether the NS is successfully switched through this API. For details, see [Modifying DNS Servers](https://intl.cloud.tencent.com/document/product/1552/90452?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="VerifyOwnershipRequest"/></param>
        /// <returns><see cref="VerifyOwnershipResponse"/></returns>
        public Task<VerifyOwnershipResponse> VerifyOwnership(VerifyOwnershipRequest req)
        {
            return InternalRequestAsync<VerifyOwnershipResponse>(req, "VerifyOwnership");
        }

        /// <summary>
        /// This API is used to verify your ownership of a site or domain name. It's required in the CNAME access mode. After a site is verified, you don't need to verify the ownership again for domain names added to it in the future. For details, see [Ownership Verification](https://intl.cloud.tencent.com/document/product/1552/70789?from_cn_redirect=1).
        /// 
        /// For sites connected via the NS, you can query whether the NS is successfully switched through this API. For details, see [Modifying DNS Servers](https://intl.cloud.tencent.com/document/product/1552/90452?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="VerifyOwnershipRequest"/></param>
        /// <returns><see cref="VerifyOwnershipResponse"/></returns>
        public VerifyOwnershipResponse VerifyOwnershipSync(VerifyOwnershipRequest req)
        {
            return InternalRequestAsync<VerifyOwnershipResponse>(req, "VerifyOwnership")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
