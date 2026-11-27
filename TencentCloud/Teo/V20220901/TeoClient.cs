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
       private const string sdkVersion = "SDK_NET_3.0.1436";

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
        /// When applying for a free certificate, if you need to apply through DNS delegation verification or file verification, you can call this API to initiate the certificate application and get the corresponding verification content based on the application method. The order in which to call the API is as follows:
        /// Step 1: Call ApplyFreeCertificate to specify the verification method for the free certificate application and obtain the verification content.
        /// Step 2: Configure the content for the corresponding domain as required for verification.
        /// Step 3: Call CheckFreeCertificateVerification for verification. The free certificate application is completed after verification passes.
        /// Step 4: Call ModifyHostsCertificate to configure the domain name certificate with an EdgeOne free certificate.
        /// 
        /// For the introduction to application methods, see the referenced document: Free Certificate Application Description (https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1) 
        /// Description:
        /// -Only the CNAME access mode can call this API to specify the free certificate application method. The NS/DNSPod hosting access mode uses automatic validation to apply for a free certificate, with no need to call this API.
        /// -If you need to switch the verification method for a free certificate, you can call this API again to update it by changing the VerificationMethod field.
        /// -A domain name can only apply for one free certificate. After calling this API, the backend will trigger the free certificate application task. You need to complete the domain name verification info configuration within 2 days, and then complete certificate authentication.
        /// </summary>
        /// <param name="req"><see cref="ApplyFreeCertificateRequest"/></param>
        /// <returns><see cref="ApplyFreeCertificateResponse"/></returns>
        public Task<ApplyFreeCertificateResponse> ApplyFreeCertificate(ApplyFreeCertificateRequest req)
        {
            return InternalRequestAsync<ApplyFreeCertificateResponse>(req, "ApplyFreeCertificate");
        }

        /// <summary>
        /// When applying for a free certificate, if you need to apply through DNS delegation verification or file verification, you can call this API to initiate the certificate application and get the corresponding verification content based on the application method. The order in which to call the API is as follows:
        /// Step 1: Call ApplyFreeCertificate to specify the verification method for the free certificate application and obtain the verification content.
        /// Step 2: Configure the content for the corresponding domain as required for verification.
        /// Step 3: Call CheckFreeCertificateVerification for verification. The free certificate application is completed after verification passes.
        /// Step 4: Call ModifyHostsCertificate to configure the domain name certificate with an EdgeOne free certificate.
        /// 
        /// For the introduction to application methods, see the referenced document: Free Certificate Application Description (https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1) 
        /// Description:
        /// -Only the CNAME access mode can call this API to specify the free certificate application method. The NS/DNSPod hosting access mode uses automatic validation to apply for a free certificate, with no need to call this API.
        /// -If you need to switch the verification method for a free certificate, you can call this API again to update it by changing the VerificationMethod field.
        /// -A domain name can only apply for one free certificate. After calling this API, the backend will trigger the free certificate application task. You need to complete the domain name verification info configuration within 2 days, and then complete certificate authentication.
        /// </summary>
        /// <param name="req"><see cref="ApplyFreeCertificateRequest"/></param>
        /// <returns><see cref="ApplyFreeCertificateResponse"/></returns>
        public ApplyFreeCertificateResponse ApplyFreeCertificateSync(ApplyFreeCertificateRequest req)
        {
            return InternalRequestAsync<ApplyFreeCertificateResponse>(req, "ApplyFreeCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operate a security policy template. This API is used to bind or rebind a domain name to a designated policy template, or unbind it from a designated policy template.
        /// </summary>
        /// <param name="req"><see cref="BindSecurityTemplateToEntityRequest"/></param>
        /// <returns><see cref="BindSecurityTemplateToEntityResponse"/></returns>
        public Task<BindSecurityTemplateToEntityResponse> BindSecurityTemplateToEntity(BindSecurityTemplateToEntityRequest req)
        {
            return InternalRequestAsync<BindSecurityTemplateToEntityResponse>(req, "BindSecurityTemplateToEntity");
        }

        /// <summary>
        /// Operate a security policy template. This API is used to bind or rebind a domain name to a designated policy template, or unbind it from a designated policy template.
        /// </summary>
        /// <param name="req"><see cref="BindSecurityTemplateToEntityRequest"/></param>
        /// <returns><see cref="BindSecurityTemplateToEntityResponse"/></returns>
        public BindSecurityTemplateToEntityResponse BindSecurityTemplateToEntitySync(BindSecurityTemplateToEntityRequest req)
        {
            return InternalRequestAsync<BindSecurityTemplateToEntityResponse>(req, "BindSecurityTemplateToEntity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to bind or unbind a shared CNAME for an acceleration domain name. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="BindSharedCNAMERequest"/></param>
        /// <returns><see cref="BindSharedCNAMEResponse"/></returns>
        public Task<BindSharedCNAMEResponse> BindSharedCNAME(BindSharedCNAMERequest req)
        {
            return InternalRequestAsync<BindSharedCNAMEResponse>(req, "BindSharedCNAME");
        }

        /// <summary>
        /// Used to bind or unbind a shared CNAME for an acceleration domain name. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="BindSharedCNAMERequest"/></param>
        /// <returns><see cref="BindSharedCNAMEResponse"/></returns>
        public BindSharedCNAMEResponse BindSharedCNAMESync(BindSharedCNAMERequest req)
        {
            return InternalRequestAsync<BindSharedCNAMEResponse>(req, "BindSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bind the selected site not bound to a package to an existing package.
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public Task<BindZoneToPlanResponse> BindZoneToPlan(BindZoneToPlanRequest req)
        {
            return InternalRequestAsync<BindZoneToPlanResponse>(req, "BindZoneToPlan");
        }

        /// <summary>
        /// Bind the selected site not bound to a package to an existing package.
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public BindZoneToPlanResponse BindZoneToPlanSync(BindZoneToPlanRequest req)
        {
            return InternalRequestAsync<BindZoneToPlanResponse>(req, "BindZoneToPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When the site access type is CNAME, all domain names under the site must complete CNAME record configuration as specified by the CNAME domain assigned by EdgeOne.
        /// This API is used to obtain the CNAME domain name assigned by EdgeOne for the integrated domain name, and to validate the CNAME configuration status of the integrated domain name.
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public Task<CheckCnameStatusResponse> CheckCnameStatus(CheckCnameStatusRequest req)
        {
            return InternalRequestAsync<CheckCnameStatusResponse>(req, "CheckCnameStatus");
        }

        /// <summary>
        /// When the site access type is CNAME, all domain names under the site must complete CNAME record configuration as specified by the CNAME domain assigned by EdgeOne.
        /// This API is used to obtain the CNAME domain name assigned by EdgeOne for the integrated domain name, and to validate the CNAME configuration status of the integrated domain name.
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public CheckCnameStatusResponse CheckCnameStatusSync(CheckCnameStatusRequest req)
        {
            return InternalRequestAsync<CheckCnameStatusResponse>(req, "CheckCnameStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a free certificate and obtain the application result. If verification is passed, you can query the free certificate information for the corresponding domain through this API. If the application failed, this API will return the corresponding failure description.
        /// After triggering the free certificate application API (https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1), you can check the free certificate application result through this API. Once the free certificate application is successful, you need to configure it through the domain certificate configuration API (https://www.tencentcloud.com/document/product/1552/80764?from_cn_redirect=1) to deploy the free certificate to the acceleration domain.
        /// </summary>
        /// <param name="req"><see cref="CheckFreeCertificateVerificationRequest"/></param>
        /// <returns><see cref="CheckFreeCertificateVerificationResponse"/></returns>
        public Task<CheckFreeCertificateVerificationResponse> CheckFreeCertificateVerification(CheckFreeCertificateVerificationRequest req)
        {
            return InternalRequestAsync<CheckFreeCertificateVerificationResponse>(req, "CheckFreeCertificateVerification");
        }

        /// <summary>
        /// This API is used to verify a free certificate and obtain the application result. If verification is passed, you can query the free certificate information for the corresponding domain through this API. If the application failed, this API will return the corresponding failure description.
        /// After triggering the free certificate application API (https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1), you can check the free certificate application result through this API. Once the free certificate application is successful, you need to configure it through the domain certificate configuration API (https://www.tencentcloud.com/document/product/1552/80764?from_cn_redirect=1) to deploy the free certificate to the acceleration domain.
        /// </summary>
        /// <param name="req"><see cref="CheckFreeCertificateVerificationRequest"/></param>
        /// <returns><see cref="CheckFreeCertificateVerificationResponse"/></returns>
        public CheckFreeCertificateVerificationResponse CheckFreeCertificateVerificationSync(CheckFreeCertificateVerificationRequest req)
        {
            return InternalRequestAsync<CheckFreeCertificateVerificationResponse>(req, "CheckFreeCertificateVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to confirm that the latest origin-pull IP ranges have been updated to the origin server firewall when the origin-pull IP ranges of the multi-channel security acceleration gateway change.
        /// </summary>
        /// <param name="req"><see cref="ConfirmMultiPathGatewayOriginACLRequest"/></param>
        /// <returns><see cref="ConfirmMultiPathGatewayOriginACLResponse"/></returns>
        public Task<ConfirmMultiPathGatewayOriginACLResponse> ConfirmMultiPathGatewayOriginACL(ConfirmMultiPathGatewayOriginACLRequest req)
        {
            return InternalRequestAsync<ConfirmMultiPathGatewayOriginACLResponse>(req, "ConfirmMultiPathGatewayOriginACL");
        }

        /// <summary>
        /// This API is used to confirm that the latest origin-pull IP ranges have been updated to the origin server firewall when the origin-pull IP ranges of the multi-channel security acceleration gateway change.
        /// </summary>
        /// <param name="req"><see cref="ConfirmMultiPathGatewayOriginACLRequest"/></param>
        /// <returns><see cref="ConfirmMultiPathGatewayOriginACLResponse"/></returns>
        public ConfirmMultiPathGatewayOriginACLResponse ConfirmMultiPathGatewayOriginACLSync(ConfirmMultiPathGatewayOriginACLRequest req)
        {
            return InternalRequestAsync<ConfirmMultiPathGatewayOriginACLResponse>(req, "ConfirmMultiPathGatewayOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to confirm that the latest origin-pull IP ranges have been updated to the origin server firewall when the origin-pull IP ranges change. After confirming the update to the latest origin-pull IP ranges, related change notifications will stop being pushed.
        /// </summary>
        /// <param name="req"><see cref="ConfirmOriginACLUpdateRequest"/></param>
        /// <returns><see cref="ConfirmOriginACLUpdateResponse"/></returns>
        public Task<ConfirmOriginACLUpdateResponse> ConfirmOriginACLUpdate(ConfirmOriginACLUpdateRequest req)
        {
            return InternalRequestAsync<ConfirmOriginACLUpdateResponse>(req, "ConfirmOriginACLUpdate");
        }

        /// <summary>
        /// This API is used to confirm that the latest origin-pull IP ranges have been updated to the origin server firewall when the origin-pull IP ranges change. After confirming the update to the latest origin-pull IP ranges, related change notifications will stop being pushed.
        /// </summary>
        /// <param name="req"><see cref="ConfirmOriginACLUpdateRequest"/></param>
        /// <returns><see cref="ConfirmOriginACLUpdateResponse"/></returns>
        public ConfirmOriginACLUpdateResponse ConfirmOriginACLUpdateSync(ConfirmOriginACLUpdateRequest req)
        {
            return InternalRequestAsync<ConfirmOriginACLUpdateResponse>(req, "ConfirmOriginACLUpdate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After creating a site, you can create an acceleration domain name through this API. 
        /// 
        /// In CNAME mode, if site ownership verification is ongoing, this API will return domain ownership verification info. You can verify domain ownership separately. For details, see [Site/Domain Name Ownership Verification](https://www.tencentcloud.com/document/product/1552/70789?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerationDomainRequest"/></param>
        /// <returns><see cref="CreateAccelerationDomainResponse"/></returns>
        public Task<CreateAccelerationDomainResponse> CreateAccelerationDomain(CreateAccelerationDomainRequest req)
        {
            return InternalRequestAsync<CreateAccelerationDomainResponse>(req, "CreateAccelerationDomain");
        }

        /// <summary>
        /// After creating a site, you can create an acceleration domain name through this API. 
        /// 
        /// In CNAME mode, if site ownership verification is ongoing, this API will return domain ownership verification info. You can verify domain ownership separately. For details, see [Site/Domain Name Ownership Verification](https://www.tencentcloud.com/document/product/1552/70789?from_cn_redirect=1).
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
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public Task<CreateAliasDomainResponse> CreateAliasDomain(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain");
        }

        /// <summary>
        /// This API is used to create an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public CreateAliasDomainResponse CreateAliasDomainSync(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version to create layer 4 proxy instances (https://www.tencentcloud.com/document/product/1552/103417?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public Task<CreateApplicationProxyResponse> CreateApplicationProxy(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version to create layer 4 proxy instances (https://www.tencentcloud.com/document/product/1552/103417?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public CreateApplicationProxyResponse CreateApplicationProxySync(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see [Create Layer 4 Proxy Forwarding Rule].
        /// ](https://www.tencentcloud.com/document/product/1552/103416?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public Task<CreateApplicationProxyRuleResponse> CreateApplicationProxyRule(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see [Create Layer 4 Proxy Forwarding Rule].
        /// ](https://www.tencentcloud.com/document/product/1552/103416?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public CreateApplicationProxyRuleResponse CreateApplicationProxyRuleSync(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create key-value indexes for delivered log fields in the corresponding Tencent Cloud CLS log topic for a specified real-time log delivery task (task-id). If indexes have been created in CLS, this API will append indexes through merging.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSIndexRequest"/></param>
        /// <returns><see cref="CreateCLSIndexResponse"/></returns>
        public Task<CreateCLSIndexResponse> CreateCLSIndex(CreateCLSIndexRequest req)
        {
            return InternalRequestAsync<CreateCLSIndexResponse>(req, "CreateCLSIndex");
        }

        /// <summary>
        /// This API is used to create key-value indexes for delivered log fields in the corresponding Tencent Cloud CLS log topic for a specified real-time log delivery task (task-id). If indexes have been created in CLS, this API will append indexes through merging.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSIndexRequest"/></param>
        /// <returns><see cref="CreateCLSIndexResponse"/></returns>
        public CreateCLSIndexResponse CreateCLSIndexSync(CreateCLSIndexRequest req)
        {
            return InternalRequestAsync<CreateCLSIndexResponse>(req, "CreateCLSIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In version management mode, this API is used to create a new version of a specified configuration group.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigGroupVersionRequest"/></param>
        /// <returns><see cref="CreateConfigGroupVersionResponse"/></returns>
        public Task<CreateConfigGroupVersionResponse> CreateConfigGroupVersion(CreateConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<CreateConfigGroupVersionResponse>(req, "CreateConfigGroupVersion");
        }

        /// <summary>
        /// In version management mode, this API is used to create a new version of a specified configuration group.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigGroupVersionRequest"/></param>
        /// <returns><see cref="CreateConfigGroupVersionResponse"/></returns>
        public CreateConfigGroupVersionResponse CreateConfigGroupVersionSync(CreateConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<CreateConfigGroupVersionResponse>(req, "CreateConfigGroupVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a content identifier. You can set the description, tag, and other information. At the same time, you need to bind an enterprise package for billing data statistics. A content identifier can only be bound to one billing package, while a billing package can bind multiple content identifiers. This functionality is only available to allowlisted users.
        /// </summary>
        /// <param name="req"><see cref="CreateContentIdentifierRequest"/></param>
        /// <returns><see cref="CreateContentIdentifierResponse"/></returns>
        public Task<CreateContentIdentifierResponse> CreateContentIdentifier(CreateContentIdentifierRequest req)
        {
            return InternalRequestAsync<CreateContentIdentifierResponse>(req, "CreateContentIdentifier");
        }

        /// <summary>
        /// This API is used to create a content identifier. You can set the description, tag, and other information. At the same time, you need to bind an enterprise package for billing data statistics. A content identifier can only be bound to one billing package, while a billing package can bind multiple content identifiers. This functionality is only available to allowlisted users.
        /// </summary>
        /// <param name="req"><see cref="CreateContentIdentifierRequest"/></param>
        /// <returns><see cref="CreateContentIdentifierResponse"/></returns>
        public CreateContentIdentifierResponse CreateContentIdentifierSync(CreateContentIdentifierRequest req)
        {
            return InternalRequestAsync<CreateContentIdentifierResponse>(req, "CreateContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom group. A custom group is used to centrally manage a set of reusable matching entries. For example, you can save multiple JA3/JA4 TLS fingerprints as a TLS fingerprint group and directly reference the group in security rules, avoiding the need to maintain the same fingerprint list in multiple rules.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomGroupRequest"/></param>
        /// <returns><see cref="CreateCustomGroupResponse"/></returns>
        public Task<CreateCustomGroupResponse> CreateCustomGroup(CreateCustomGroupRequest req)
        {
            return InternalRequestAsync<CreateCustomGroupResponse>(req, "CreateCustomGroup");
        }

        /// <summary>
        /// This API is used to create a custom group. A custom group is used to centrally manage a set of reusable matching entries. For example, you can save multiple JA3/JA4 TLS fingerprints as a TLS fingerprint group and directly reference the group in security rules, avoiding the need to maintain the same fingerprint list in multiple rules.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomGroupRequest"/></param>
        /// <returns><see cref="CreateCustomGroupResponse"/></returns>
        public CreateCustomGroupResponse CreateCustomGroupSync(CreateCustomGroupRequest req)
        {
            return InternalRequestAsync<CreateCustomGroupResponse>(req, "CreateCustomGroup")
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
        /// After a site is created and accessed in NS mode, you can create DNS records through this API.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public Task<CreateDnsRecordResponse> CreateDnsRecord(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord");
        }

        /// <summary>
        /// After a site is created and accessed in NS mode, you can create DNS records through this API.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public CreateDnsRecordResponse CreateDnsRecordSync(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a KV namespace at a specified site.
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeKVNamespaceRequest"/></param>
        /// <returns><see cref="CreateEdgeKVNamespaceResponse"/></returns>
        public Task<CreateEdgeKVNamespaceResponse> CreateEdgeKVNamespace(CreateEdgeKVNamespaceRequest req)
        {
            return InternalRequestAsync<CreateEdgeKVNamespaceResponse>(req, "CreateEdgeKVNamespace");
        }

        /// <summary>
        /// This API is used to create a KV namespace at a specified site.
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeKVNamespaceRequest"/></param>
        /// <returns><see cref="CreateEdgeKVNamespaceResponse"/></returns>
        public CreateEdgeKVNamespaceResponse CreateEdgeKVNamespaceSync(CreateEdgeKVNamespaceRequest req)
        {
            return InternalRequestAsync<CreateEdgeKVNamespaceResponse>(req, "CreateEdgeKVNamespace")
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
        /// This API is used to create copies of a specified edge function. After creating copies, when client requests match the configured trigger rules or default domain name, you can access a specific function copy by adding EO-Function-Replica-Name:[copy name] to the request header. Each function supports creating two copies by default.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionReplicaRequest"/></param>
        /// <returns><see cref="CreateFunctionReplicaResponse"/></returns>
        public Task<CreateFunctionReplicaResponse> CreateFunctionReplica(CreateFunctionReplicaRequest req)
        {
            return InternalRequestAsync<CreateFunctionReplicaResponse>(req, "CreateFunctionReplica");
        }

        /// <summary>
        /// This API is used to create copies of a specified edge function. After creating copies, when client requests match the configured trigger rules or default domain name, you can access a specific function copy by adding EO-Function-Replica-Name:[copy name] to the request header. Each function supports creating two copies by default.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionReplicaRequest"/></param>
        /// <returns><see cref="CreateFunctionReplicaResponse"/></returns>
        public CreateFunctionReplicaResponse CreateFunctionReplicaSync(CreateFunctionReplicaRequest req)
        {
            return InternalRequestAsync<CreateFunctionReplicaResponse>(req, "CreateFunctionReplica")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a trigger rule for an edge function. It supports customized filter conditions to determine whether to execute a function. When a function needs to be executed, multiple ways are provided to select the target function, including directly specifying, selecting based on the client's associated region, and weight-based selection.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRuleRequest"/></param>
        /// <returns><see cref="CreateFunctionRuleResponse"/></returns>
        public Task<CreateFunctionRuleResponse> CreateFunctionRule(CreateFunctionRuleRequest req)
        {
            return InternalRequestAsync<CreateFunctionRuleResponse>(req, "CreateFunctionRule");
        }

        /// <summary>
        /// Creates a trigger rule for an edge function. It supports customized filter conditions to determine whether to execute a function. When a function needs to be executed, multiple ways are provided to select the target function, including directly specifying, selecting based on the client's associated region, and weight-based selection.
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRuleRequest"/></param>
        /// <returns><see cref="CreateFunctionRuleResponse"/></returns>
        public CreateFunctionRuleResponse CreateFunctionRuleSync(CreateFunctionRuleRequest req)
        {
            return InternalRequestAsync<CreateFunctionRuleResponse>(req, "CreateFunctionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an inference API Token for authentication when accessing the inference service. The Token content is returned only once when creating, and each site can create up to 100 tokens.
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceAPITokenRequest"/></param>
        /// <returns><see cref="CreateInferenceAPITokenResponse"/></returns>
        public Task<CreateInferenceAPITokenResponse> CreateInferenceAPIToken(CreateInferenceAPITokenRequest req)
        {
            return InternalRequestAsync<CreateInferenceAPITokenResponse>(req, "CreateInferenceAPIToken");
        }

        /// <summary>
        /// Create an inference API Token for authentication when accessing the inference service. The Token content is returned only once when creating, and each site can create up to 100 tokens.
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceAPITokenRequest"/></param>
        /// <returns><see cref="CreateInferenceAPITokenResponse"/></returns>
        public CreateInferenceAPITokenResponse CreateInferenceAPITokenSync(CreateInferenceAPITokenRequest req)
        {
            return InternalRequestAsync<CreateInferenceAPITokenResponse>(req, "CreateInferenceAPIToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an inference service domain name for accessing the inference service through a custom domain name. An inference service supports creating a maximum of 5 custom domain names.
        /// After successful creation, complete the following steps to make the domain name function normally for external access:
        /// 1. To validate the CNAME configuration status of a domain, see the CheckCnameStatus api.
        /// 2. To verify ownership, refer to the VerifyOwnership API (https://www.tencentcloud.com/document/api/1552/98879?from_cn_redirect=1);
        /// 3. To configure domain name certificates, refer to the ModifyHostsCertificate api.
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceDomainRequest"/></param>
        /// <returns><see cref="CreateInferenceDomainResponse"/></returns>
        public Task<CreateInferenceDomainResponse> CreateInferenceDomain(CreateInferenceDomainRequest req)
        {
            return InternalRequestAsync<CreateInferenceDomainResponse>(req, "CreateInferenceDomain");
        }

        /// <summary>
        /// Create an inference service domain name for accessing the inference service through a custom domain name. An inference service supports creating a maximum of 5 custom domain names.
        /// After successful creation, complete the following steps to make the domain name function normally for external access:
        /// 1. To validate the CNAME configuration status of a domain, see the CheckCnameStatus api.
        /// 2. To verify ownership, refer to the VerifyOwnership API (https://www.tencentcloud.com/document/api/1552/98879?from_cn_redirect=1);
        /// 3. To configure domain name certificates, refer to the ModifyHostsCertificate api.
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceDomainRequest"/></param>
        /// <returns><see cref="CreateInferenceDomainResponse"/></returns>
        public CreateInferenceDomainResponse CreateInferenceDomainSync(CreateInferenceDomainRequest req)
        {
            return InternalRequestAsync<CreateInferenceDomainResponse>(req, "CreateInferenceDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an inference service. You can set the service name, listening port, container image configuration, and resource configuration. An access address is provided after successful creation.
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceServiceRequest"/></param>
        /// <returns><see cref="CreateInferenceServiceResponse"/></returns>
        public Task<CreateInferenceServiceResponse> CreateInferenceService(CreateInferenceServiceRequest req)
        {
            return InternalRequestAsync<CreateInferenceServiceResponse>(req, "CreateInferenceService");
        }

        /// <summary>
        /// This API is used to create an inference service. You can set the service name, listening port, container image configuration, and resource configuration. An access address is provided after successful creation.
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceServiceRequest"/></param>
        /// <returns><see cref="CreateInferenceServiceResponse"/></returns>
        public CreateInferenceServiceResponse CreateInferenceServiceSync(CreateInferenceServiceRequest req)
        {
            return InternalRequestAsync<CreateInferenceServiceResponse>(req, "CreateInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// JIT transcoding already provides preset transcoding templates to meet most needs. For personalized transcoding requirements, you can create custom transcoding templates through this API, with up to 100 custom templates.
        /// To ensure consistency of JIT transcoding effects and avoid video output exceptions caused by template changes during EO cache or M3U8 sharding, the template cannot be modified after creation.
        /// To learn about JIT transcoding capacity, see EdgeOne Video Instant Processing Function Introduction (https://www.tencentcloud.com/document/product/1552/111927?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<CreateJustInTimeTranscodeTemplateResponse> CreateJustInTimeTranscodeTemplate(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// JIT transcoding already provides preset transcoding templates to meet most needs. For personalized transcoding requirements, you can create custom transcoding templates through this API, with up to 100 custom templates.
        /// To ensure consistency of JIT transcoding effects and avoid video output exceptions caused by template changes during EO cache or M3U8 sharding, the template cannot be modified after creation.
        /// To learn about JIT transcoding capacity, see EdgeOne Video Instant Processing Function Introduction (https://www.tencentcloud.com/document/product/1552/111927?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public CreateJustInTimeTranscodeTemplateResponse CreateJustInTimeTranscodeTemplateSync(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRequest"/></param>
        /// <returns><see cref="CreateL4ProxyResponse"/></returns>
        public Task<CreateL4ProxyResponse> CreateL4Proxy(CreateL4ProxyRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyResponse>(req, "CreateL4Proxy");
        }

        /// <summary>
        /// This API is used to create a layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRequest"/></param>
        /// <returns><see cref="CreateL4ProxyResponse"/></returns>
        public CreateL4ProxyResponse CreateL4ProxySync(CreateL4ProxyRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyResponse>(req, "CreateL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Layer 4 proxy instance rules and supports individual and batch creation.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRulesRequest"/></param>
        /// <returns><see cref="CreateL4ProxyRulesResponse"/></returns>
        public Task<CreateL4ProxyRulesResponse> CreateL4ProxyRules(CreateL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyRulesResponse>(req, "CreateL4ProxyRules");
        }

        /// <summary>
        /// This API is used to create Layer 4 proxy instance rules and supports individual and batch creation.
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRulesRequest"/></param>
        /// <returns><see cref="CreateL4ProxyRulesResponse"/></returns>
        public CreateL4ProxyRulesResponse CreateL4ProxyRulesSync(CreateL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyRulesResponse>(req, "CreateL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create rules in the [rule engine](https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1), with support for batch creation.
        /// </summary>
        /// <param name="req"><see cref="CreateL7AccRulesRequest"/></param>
        /// <returns><see cref="CreateL7AccRulesResponse"/></returns>
        public Task<CreateL7AccRulesResponse> CreateL7AccRules(CreateL7AccRulesRequest req)
        {
            return InternalRequestAsync<CreateL7AccRulesResponse>(req, "CreateL7AccRules");
        }

        /// <summary>
        /// This API is used to create rules in the [rule engine](https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1), with support for batch creation.
        /// </summary>
        /// <param name="req"><see cref="CreateL7AccRulesRequest"/></param>
        /// <returns><see cref="CreateL7AccRulesResponse"/></returns>
        public CreateL7AccRulesResponse CreateL7AccRulesSync(CreateL7AccRulesRequest req)
        {
            return InternalRequestAsync<CreateL7AccRulesResponse>(req, "CreateL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a LoadBalancer. For details, see [Quickly Create Load Balancers](https://www.tencentcloud.com/document/product/1552/104223?from_cn_redirect=1). The load balancing feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// This API is used to create a LoadBalancer. For details, see [Quickly Create Load Balancers](https://www.tencentcloud.com/document/product/1552/104223?from_cn_redirect=1). The load balancing feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a log analysis download task. After creation, you can query the download task through the DescribeLogAnalysisDownloadTasks API.
        /// Note:
        /// 1. Supports up to 50 million log entries per download.
        /// 2. Log files will be retained for 3 days.
        /// 3. If multiple tasks exist at the same time, they will be processed sequentially based on task creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateLogAnalysisDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLogAnalysisDownloadTaskResponse"/></returns>
        public Task<CreateLogAnalysisDownloadTaskResponse> CreateLogAnalysisDownloadTask(CreateLogAnalysisDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLogAnalysisDownloadTaskResponse>(req, "CreateLogAnalysisDownloadTask");
        }

        /// <summary>
        /// This API is used to create a log analysis download task. After creation, you can query the download task through the DescribeLogAnalysisDownloadTasks API.
        /// Note:
        /// 1. Supports up to 50 million log entries per download.
        /// 2. Log files will be retained for 3 days.
        /// 3. If multiple tasks exist at the same time, they will be processed sequentially based on task creation time.
        /// </summary>
        /// <param name="req"><see cref="CreateLogAnalysisDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLogAnalysisDownloadTaskResponse"/></returns>
        public CreateLogAnalysisDownloadTaskResponse CreateLogAnalysisDownloadTaskSync(CreateLogAnalysisDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLogAnalysisDownloadTaskResponse>(req, "CreateLogAnalysisDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a multi-channel security acceleration gateway, including Cloud Gateway and Private Gateway. Use the DescribeMultiPathGateway interface to query the status. If the status is online, the creation succeeded.
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayResponse"/></returns>
        public Task<CreateMultiPathGatewayResponse> CreateMultiPathGateway(CreateMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayResponse>(req, "CreateMultiPathGateway");
        }

        /// <summary>
        /// This API is used to create a multi-channel security acceleration gateway, including Cloud Gateway and Private Gateway. Use the DescribeMultiPathGateway interface to query the status. If the status is online, the creation succeeded.
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayResponse"/></returns>
        public CreateMultiPathGatewayResponse CreateMultiPathGatewaySync(CreateMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayResponse>(req, "CreateMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create lines for integrating with the multi-channel security acceleration gateway, including EdgeOne Layer 4 proxy lines and custom lines.
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayLineResponse"/></returns>
        public Task<CreateMultiPathGatewayLineResponse> CreateMultiPathGatewayLine(CreateMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayLineResponse>(req, "CreateMultiPathGatewayLine");
        }

        /// <summary>
        /// This API is used to create lines for integrating with the multi-channel security acceleration gateway, including EdgeOne Layer 4 proxy lines and custom lines.
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayLineResponse"/></returns>
        public CreateMultiPathGatewayLineResponse CreateMultiPathGatewayLineSync(CreateMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayLineResponse>(req, "CreateMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a key for integrating with a multi-channel security acceleration gateway. Customers integrate with the multi-channel security acceleration gateway based on key signatures. Each site contains only one key, which can be used to integrate all gateways under the site. The key can be queried through the DescribeMultiPathGatewaySecretKey API.
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<CreateMultiPathGatewaySecretKeyResponse> CreateMultiPathGatewaySecretKey(CreateMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewaySecretKeyResponse>(req, "CreateMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// This API is used to create a key for integrating with a multi-channel security acceleration gateway. Customers integrate with the multi-channel security acceleration gateway based on key signatures. Each site contains only one key, which can be used to integrate all gateways under the site. The key can be queried through the DescribeMultiPathGatewaySecretKey API.
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewaySecretKeyResponse"/></returns>
        public CreateMultiPathGatewaySecretKeyResponse CreateMultiPathGatewaySecretKeySync(CreateMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewaySecretKeyResponse>(req, "CreateMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an origin server group to manage origin servers by group. The origin server group configured here can be referenced in features such as **adding an acceleration domain name** and **Layer 4 proxy**.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public Task<CreateOriginGroupResponse> CreateOriginGroup(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup");
        }

        /// <summary>
        /// Create an origin server group to manage origin servers by group. The origin server group configured here can be referenced in features such as **adding an acceleration domain name** and **Layer 4 proxy**.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public CreateOriginGroupResponse CreateOriginGroupSync(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// If you need to use the Edgeone product, you need to create a billing plan through this interface.
        /// > After creating a package, you need to complete creating a site and binding the plan through [CreateZone](https://www.tencentcloud.com/document/product/1552/80719?from_cn_redirect=1) before Edgeone can provide services properly.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanRequest"/></param>
        /// <returns><see cref="CreatePlanResponse"/></returns>
        public Task<CreatePlanResponse> CreatePlan(CreatePlanRequest req)
        {
            return InternalRequestAsync<CreatePlanResponse>(req, "CreatePlan");
        }

        /// <summary>
        /// If you need to use the Edgeone product, you need to create a billing plan through this interface.
        /// > After creating a package, you need to complete creating a site and binding the plan through [CreateZone](https://www.tencentcloud.com/document/product/1552/80719?from_cn_redirect=1) before Edgeone can provide services properly.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanRequest"/></param>
        /// <returns><see cref="CreatePlanResponse"/></returns>
        public CreatePlanResponse CreatePlanSync(CreatePlanRequest req)
        {
            return InternalRequestAsync<CreatePlanResponse>(req, "CreatePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Purchase a package for the selected site not bound to a package.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public Task<CreatePlanForZoneResponse> CreatePlanForZone(CreatePlanForZoneRequest req)
        {
            return InternalRequestAsync<CreatePlanForZoneResponse>(req, "CreatePlanForZone");
        }

        /// <summary>
        /// Purchase a package for the selected site not bound to a package.
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public CreatePlanForZoneResponse CreatePlanForZoneSync(CreatePlanForZoneRequest req)
        {
            return InternalRequestAsync<CreatePlanForZoneResponse>(req, "CreatePlanForZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a preheating task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public Task<CreatePrefetchTaskResponse> CreatePrefetchTask(CreatePrefetchTaskRequest req)
        {
            return InternalRequestAsync<CreatePrefetchTaskResponse>(req, "CreatePrefetchTask");
        }

        /// <summary>
        /// This API is used to create a preheating task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public CreatePrefetchTaskResponse CreatePrefetchTaskSync(CreatePrefetchTaskRequest req)
        {
            return InternalRequestAsync<CreatePrefetchTaskResponse>(req, "CreatePrefetchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When origin server resources update but the node cache TTL has not expired, users still access old resources. At this point, use this API to update node resources. The following two methods can trigger updates: <li>Direct deletion: Delete the node cache without any validation. User requests trigger origin-pull.</li><li>Mark expiration: Mark node resources as expired. User requests trigger back-to-origin validation, which sends HTTP conditional requests with If-None-Match and If-Modified-Since headers. If the origin server responds with 200, the node fetches new resources from the origin and updates the cache. If the origin server responds with 304, the cache will not be updated.</li>
        /// 
        /// For details on purging cache tasks, see [Purge Cache](https://www.tencentcloud.com/document/product/1552/70759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public Task<CreatePurgeTaskResponse> CreatePurgeTask(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask");
        }

        /// <summary>
        /// When origin server resources update but the node cache TTL has not expired, users still access old resources. At this point, use this API to update node resources. The following two methods can trigger updates: <li>Direct deletion: Delete the node cache without any validation. User requests trigger origin-pull.</li><li>Mark expiration: Mark node resources as expired. User requests trigger back-to-origin validation, which sends HTTP conditional requests with If-None-Match and If-Modified-Since headers. If the origin server responds with 200, the node fetches new resources from the origin and updates the cache. If the origin server responds with 304, the cache will not be updated.</li>
        /// 
        /// For details on purging cache tasks, see [Purge Cache](https://www.tencentcloud.com/document/product/1552/70759?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public CreatePurgeTaskResponse CreatePurgeTaskSync(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a real-time log delivery task.
        /// 
        /// **Restrictions**
        /// 
        /// An entity (a Layer 7 domain name, a Layer 4 proxy instance, or an Edge Function instance) under the same combination of `LogType` and `Area` can only have one task created for each `TaskType`. The mutual exclusion rules for different `LogType` values are as follows:
        /// 
        /// | LogType | Conflicting TaskType |
        /// |---|---|
        /// | Layer 4 proxy logs, Edge Function execution logs | Choose one of `custom_endpoint`, `s3`, and `aws_s3` |
        /// 
        /// When `TaskType` is `log_analysis`:
        /// 
        /// <ul>
        /// <li>Only `LogType` = `l7-access-logs` or `web-attack` is supported.</li>
        /// <li>Under the same combination of `ZoneId` and `Area`, only one task can be created for each `LogType`.</li>
        /// </ul>
        /// 
        /// **Recommendation**: Before creating a task, call the [DescribeRealtimeLogDeliveryTasks](https://www.tencentcloud.com/document/product/1145/59503) API to query existing tasks and avoid duplicate additions.
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<CreateRealtimeLogDeliveryTaskResponse> CreateRealtimeLogDeliveryTask(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// This API is used to create a real-time log delivery task.
        /// 
        /// **Restrictions**
        /// 
        /// An entity (a Layer 7 domain name, a Layer 4 proxy instance, or an Edge Function instance) under the same combination of `LogType` and `Area` can only have one task created for each `TaskType`. The mutual exclusion rules for different `LogType` values are as follows:
        /// 
        /// | LogType | Conflicting TaskType |
        /// |---|---|
        /// | Layer 4 proxy logs, Edge Function execution logs | Choose one of `custom_endpoint`, `s3`, and `aws_s3` |
        /// 
        /// When `TaskType` is `log_analysis`:
        /// 
        /// <ul>
        /// <li>Only `LogType` = `l7-access-logs` or `web-attack` is supported.</li>
        /// <li>Under the same combination of `ZoneId` and `Area`, only one task can be created for each `LogType`.</li>
        /// </ul>
        /// 
        /// **Recommendation**: Before creating a task, call the [DescribeRealtimeLogDeliveryTasks](https://www.tencentcloud.com/document/product/1145/59503) API to query existing tasks and avoid duplicate additions.
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public CreateRealtimeLogDeliveryTaskResponse CreateRealtimeLogDeliveryTaskSync(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version for creating rule engine APIs. EdgeOne comprehensively upgraded the rule engine APIs on January 21, 2025. For details on the new API for creating layer-7 acceleration rules, refer to [CreateL7AccRules](https://www.tencentcloud.com/document/product/1552/115822?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the old version APIs will stop update and iteration. New features will only be provided by the latest version interface. The existing capacity supported by the old version APIs will not be affected. To avoid data field conflicts when using the old version APIs, migrate to the new version rule engine APIs as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API is on an earlier version for creating rule engine APIs. EdgeOne comprehensively upgraded the rule engine APIs on January 21, 2025. For details on the new API for creating layer-7 acceleration rules, refer to [CreateL7AccRules](https://www.tencentcloud.com/document/product/1552/115822?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the old version APIs will stop update and iteration. New features will only be provided by the latest version interface. The existing capacity supported by the old version APIs will not be affected. To avoid data field conflicts when using the old version APIs, migrate to the new version rule engine APIs as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to create API resources.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIResourceResponse"/></returns>
        public Task<CreateSecurityAPIResourceResponse> CreateSecurityAPIResource(CreateSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIResourceResponse>(req, "CreateSecurityAPIResource");
        }

        /// <summary>
        /// Used to create API resources.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIResourceResponse"/></returns>
        public CreateSecurityAPIResourceResponse CreateSecurityAPIResourceSync(CreateSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIResourceResponse>(req, "CreateSecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to create an API service.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIServiceResponse"/></returns>
        public Task<CreateSecurityAPIServiceResponse> CreateSecurityAPIService(CreateSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIServiceResponse>(req, "CreateSecurityAPIService");
        }

        /// <summary>
        /// Used to create an API service.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIServiceResponse"/></returns>
        public CreateSecurityAPIServiceResponse CreateSecurityAPIServiceSync(CreateSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIServiceResponse>(req, "CreateSecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create client authentication options.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="CreateSecurityClientAttesterResponse"/></returns>
        public Task<CreateSecurityClientAttesterResponse> CreateSecurityClientAttester(CreateSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<CreateSecurityClientAttesterResponse>(req, "CreateSecurityClientAttester");
        }

        /// <summary>
        /// Create client authentication options.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="CreateSecurityClientAttesterResponse"/></returns>
        public CreateSecurityClientAttesterResponse CreateSecurityClientAttesterSync(CreateSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<CreateSecurityClientAttesterResponse>(req, "CreateSecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a security IP group
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public Task<CreateSecurityIPGroupResponse> CreateSecurityIPGroup(CreateSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityIPGroupResponse>(req, "CreateSecurityIPGroup");
        }

        /// <summary>
        /// Create a security IP group
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public CreateSecurityIPGroupResponse CreateSecurityIPGroupSync(CreateSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityIPGroupResponse>(req, "CreateSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="CreateSecurityJSInjectionRuleResponse"/></returns>
        public Task<CreateSecurityJSInjectionRuleResponse> CreateSecurityJSInjectionRule(CreateSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<CreateSecurityJSInjectionRuleResponse>(req, "CreateSecurityJSInjectionRule");
        }

        /// <summary>
        /// This API is used to create JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="CreateSecurityJSInjectionRuleResponse"/></returns>
        public CreateSecurityJSInjectionRuleResponse CreateSecurityJSInjectionRuleSync(CreateSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<CreateSecurityJSInjectionRuleResponse>(req, "CreateSecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to create a shared CNAME. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public Task<CreateSharedCNAMEResponse> CreateSharedCNAME(CreateSharedCNAMERequest req)
        {
            return InternalRequestAsync<CreateSharedCNAMEResponse>(req, "CreateSharedCNAME");
        }

        /// <summary>
        /// Used to create a shared CNAME. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public CreateSharedCNAMEResponse CreateSharedCNAMESync(CreateSharedCNAMERequest req)
        {
            return InternalRequestAsync<CreateSharedCNAMEResponse>(req, "CreateSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a security policy configuration template
        /// </summary>
        /// <param name="req"><see cref="CreateWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="CreateWebSecurityTemplateResponse"/></returns>
        public Task<CreateWebSecurityTemplateResponse> CreateWebSecurityTemplate(CreateWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<CreateWebSecurityTemplateResponse>(req, "CreateWebSecurityTemplate");
        }

        /// <summary>
        /// Create a security policy configuration template
        /// </summary>
        /// <param name="req"><see cref="CreateWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="CreateWebSecurityTemplateResponse"/></returns>
        public CreateWebSecurityTemplateResponse CreateWebSecurityTemplateSync(CreateWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<CreateWebSecurityTemplateResponse>(req, "CreateWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EdgeOne offers three access methods: CNAME, NS, and domainless access. You need to finalize site creation through this API first. For CNAME and NS connected site scenarios, see [Quickly access EdgeOne from scratch](https://www.tencentcloud.com/document/product/1552/87601?from_cn_redirect=1). For domainless access scenarios, see [Quickly enable layer 4 proxy service](https://www.tencentcloud.com/document/product/1552/96051?from_cn_redirect=1).
        /// 
        /// > It is recommended to call this API to create a site when a package already exists under the account. Please input `PlanId` in the parameter to directly bind the site to the package. If `PlanId` is not input, the created site will be inactive and unable to provide normal services. You need to complete package binding through [BindZoneToPlan](https://www.tencentcloud.com/document/product/1552/83042?from_cn_redirect=1) before the site can provide services normally. If you currently have no bindable package, go to the console to purchase a package to finalize site creation.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone");
        }

        /// <summary>
        /// EdgeOne offers three access methods: CNAME, NS, and domainless access. You need to finalize site creation through this API first. For CNAME and NS connected site scenarios, see [Quickly access EdgeOne from scratch](https://www.tencentcloud.com/document/product/1552/87601?from_cn_redirect=1). For domainless access scenarios, see [Quickly enable layer 4 proxy service](https://www.tencentcloud.com/document/product/1552/96051?from_cn_redirect=1).
        /// 
        /// > It is recommended to call this API to create a site when a package already exists under the account. Please input `PlanId` in the parameter to directly bind the site to the package. If `PlanId` is not input, the created site will be inactive and unable to provide normal services. You need to complete package binding through [BindZoneToPlan](https://www.tencentcloud.com/document/product/1552/83042?from_cn_redirect=1) before the site can provide services normally. If you currently have no bindable package, go to the console to purchase a package to finalize site creation.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete acceleration domain names in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public Task<DeleteAccelerationDomainsResponse> DeleteAccelerationDomains(DeleteAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DeleteAccelerationDomainsResponse>(req, "DeleteAccelerationDomains");
        }

        /// <summary>
        /// Delete acceleration domain names in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public DeleteAccelerationDomainsResponse DeleteAccelerationDomainsSync(DeleteAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DeleteAccelerationDomainsResponse>(req, "DeleteAccelerationDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public Task<DeleteAliasDomainResponse> DeleteAliasDomain(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain");
        }

        /// <summary>
        /// Delete an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public DeleteAliasDomainResponse DeleteAliasDomainSync(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Deleting a Layer 4 Proxy Instance.
        /// ](https://www.tencentcloud.com/document/product/1552/103415?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public Task<DeleteApplicationProxyResponse> DeleteApplicationProxy(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Deleting a Layer 4 Proxy Instance.
        /// ](https://www.tencentcloud.com/document/product/1552/103415?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public DeleteApplicationProxyResponse DeleteApplicationProxySync(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Deleting L4 Proxy Rules (https://www.tencentcloud.com/document/product/1552/103414?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public Task<DeleteApplicationProxyRuleResponse> DeleteApplicationProxyRule(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Deleting L4 Proxy Rules (https://www.tencentcloud.com/document/product/1552/103414?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public DeleteApplicationProxyRuleResponse DeleteApplicationProxyRuleSync(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the specified content identifier. The feature is open only in the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteContentIdentifierRequest"/></param>
        /// <returns><see cref="DeleteContentIdentifierResponse"/></returns>
        public Task<DeleteContentIdentifierResponse> DeleteContentIdentifier(DeleteContentIdentifierRequest req)
        {
            return InternalRequestAsync<DeleteContentIdentifierResponse>(req, "DeleteContentIdentifier");
        }

        /// <summary>
        /// Delete the specified content identifier. The feature is open only in the allowlist.
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
        /// This API is used to delete a specified custom group. If the group is referenced by a rule, deletion is not allowed. Remove the reference first.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomGroupRequest"/></param>
        /// <returns><see cref="DeleteCustomGroupResponse"/></returns>
        public Task<DeleteCustomGroupResponse> DeleteCustomGroup(DeleteCustomGroupRequest req)
        {
            return InternalRequestAsync<DeleteCustomGroupResponse>(req, "DeleteCustomGroup");
        }

        /// <summary>
        /// This API is used to delete a specified custom group. If the group is referenced by a rule, deletion is not allowed. Remove the reference first.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomGroupRequest"/></param>
        /// <returns><see cref="DeleteCustomGroupResponse"/></returns>
        public DeleteCustomGroupResponse DeleteCustomGroupSync(DeleteCustomGroupRequest req)
        {
            return InternalRequestAsync<DeleteCustomGroupResponse>(req, "DeleteCustomGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can use this API to delete DNS records in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public Task<DeleteDnsRecordsResponse> DeleteDnsRecords(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords");
        }

        /// <summary>
        /// You can use this API to delete DNS records in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public DeleteDnsRecordsResponse DeleteDnsRecordsSync(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified KV namespace. After deletion, all key-value pair data in the namespace will be cleared and cannot be recovered. If the namespace is referenced by an edge function, unbind the relationship before deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeKVNamespaceRequest"/></param>
        /// <returns><see cref="DeleteEdgeKVNamespaceResponse"/></returns>
        public Task<DeleteEdgeKVNamespaceResponse> DeleteEdgeKVNamespace(DeleteEdgeKVNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteEdgeKVNamespaceResponse>(req, "DeleteEdgeKVNamespace");
        }

        /// <summary>
        /// This API is used to delete a specified KV namespace. After deletion, all key-value pair data in the namespace will be cleared and cannot be recovered. If the namespace is referenced by an edge function, unbind the relationship before deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeKVNamespaceRequest"/></param>
        /// <returns><see cref="DeleteEdgeKVNamespaceResponse"/></returns>
        public DeleteEdgeKVNamespaceResponse DeleteEdgeKVNamespaceSync(DeleteEdgeKVNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteEdgeKVNamespaceResponse>(req, "DeleteEdgeKVNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an edge function. Once deleted, the function cannot be recovered, and associated trigger rules, environment variables, and replicas are also deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction");
        }

        /// <summary>
        /// This API is used to delete an edge function. Once deleted, the function cannot be recovered, and associated trigger rules, environment variables, and replicas are also deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified edge function replica.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionReplicaRequest"/></param>
        /// <returns><see cref="DeleteFunctionReplicaResponse"/></returns>
        public Task<DeleteFunctionReplicaResponse> DeleteFunctionReplica(DeleteFunctionReplicaRequest req)
        {
            return InternalRequestAsync<DeleteFunctionReplicaResponse>(req, "DeleteFunctionReplica");
        }

        /// <summary>
        /// This API is used to delete a specified edge function replica.
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionReplicaRequest"/></param>
        /// <returns><see cref="DeleteFunctionReplicaResponse"/></returns>
        public DeleteFunctionReplicaResponse DeleteFunctionReplicaSync(DeleteFunctionReplicaRequest req)
        {
            return InternalRequestAsync<DeleteFunctionReplicaResponse>(req, "DeleteFunctionReplica")
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
        /// Delete an inference API Token. Once deleted, the Token expires immediately, and requests using it to access the inference service will not pass authentication.
        /// </summary>
        /// <param name="req"><see cref="DeleteInferenceAPITokenRequest"/></param>
        /// <returns><see cref="DeleteInferenceAPITokenResponse"/></returns>
        public Task<DeleteInferenceAPITokenResponse> DeleteInferenceAPIToken(DeleteInferenceAPITokenRequest req)
        {
            return InternalRequestAsync<DeleteInferenceAPITokenResponse>(req, "DeleteInferenceAPIToken");
        }

        /// <summary>
        /// Delete an inference API Token. Once deleted, the Token expires immediately, and requests using it to access the inference service will not pass authentication.
        /// </summary>
        /// <param name="req"><see cref="DeleteInferenceAPITokenRequest"/></param>
        /// <returns><see cref="DeleteInferenceAPITokenResponse"/></returns>
        public DeleteInferenceAPITokenResponse DeleteInferenceAPITokenSync(DeleteInferenceAPITokenRequest req)
        {
            return InternalRequestAsync<DeleteInferenceAPITokenResponse>(req, "DeleteInferenceAPIToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a just in time transcoding template based on the unique template identifier under the site ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DeleteJustInTimeTranscodeTemplatesResponse> DeleteJustInTimeTranscodeTemplates(DeleteJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplatesResponse>(req, "DeleteJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// Delete a just in time transcoding template based on the unique template identifier under the site ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplatesResponse"/></returns>
        public DeleteJustInTimeTranscodeTemplatesResponse DeleteJustInTimeTranscodeTemplatesSync(DeleteJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplatesResponse>(req, "DeleteJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyResponse"/></returns>
        public Task<DeleteL4ProxyResponse> DeleteL4Proxy(DeleteL4ProxyRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyResponse>(req, "DeleteL4Proxy");
        }

        /// <summary>
        /// This API is used to delete a layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyResponse"/></returns>
        public DeleteL4ProxyResponse DeleteL4ProxySync(DeleteL4ProxyRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyResponse>(req, "DeleteL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete l4 proxy rules and supports both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyRulesResponse"/></returns>
        public Task<DeleteL4ProxyRulesResponse> DeleteL4ProxyRules(DeleteL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyRulesResponse>(req, "DeleteL4ProxyRules");
        }

        /// <summary>
        /// This API is used to delete l4 proxy rules and supports both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyRulesResponse"/></returns>
        public DeleteL4ProxyRulesResponse DeleteL4ProxyRulesSync(DeleteL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyRulesResponse>(req, "DeleteL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete rules from the rule engine (https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1). Batch deletion supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7AccRulesRequest"/></param>
        /// <returns><see cref="DeleteL7AccRulesResponse"/></returns>
        public Task<DeleteL7AccRulesResponse> DeleteL7AccRules(DeleteL7AccRulesRequest req)
        {
            return InternalRequestAsync<DeleteL7AccRulesResponse>(req, "DeleteL7AccRules");
        }

        /// <summary>
        /// This API is used to delete rules from the rule engine (https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1). Batch deletion supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteL7AccRulesRequest"/></param>
        /// <returns><see cref="DeleteL7AccRulesResponse"/></returns>
        public DeleteL7AccRulesResponse DeleteL7AccRulesSync(DeleteL7AccRulesRequest req)
        {
            return InternalRequestAsync<DeleteL7AccRulesResponse>(req, "DeleteL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a load balancing instance. If the load balancing instance is referenced by other services, such as a Layer 4 proxy, it cannot be deleted. Remove the reference relationship first. The load balancer feature is in beta test. If you need to use it, contact us (https://www.tencentcloud.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// This API is used to delete a load balancing instance. If the load balancing instance is referenced by other services, such as a Layer 4 proxy, it cannot be deleted. Remove the reference relationship first. The load balancer feature is in beta test. If you need to use it, contact us (https://www.tencentcloud.com/online?from_cn_redirect=1-service).
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete multi-channel security acceleration gateways, including private gateways and Cloud Gateways.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayResponse"/></returns>
        public Task<DeleteMultiPathGatewayResponse> DeleteMultiPathGateway(DeleteMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayResponse>(req, "DeleteMultiPathGateway");
        }

        /// <summary>
        /// This API is used to delete multi-channel security acceleration gateways, including private gateways and Cloud Gateways.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayResponse"/></returns>
        public DeleteMultiPathGatewayResponse DeleteMultiPathGatewaySync(DeleteMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayResponse>(req, "DeleteMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete lines integrated with multi-channel security acceleration gateways. Only custom lines support deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayLineResponse"/></returns>
        public Task<DeleteMultiPathGatewayLineResponse> DeleteMultiPathGatewayLine(DeleteMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayLineResponse>(req, "DeleteMultiPathGatewayLine");
        }

        /// <summary>
        /// This API is used to delete lines integrated with multi-channel security acceleration gateways. Only custom lines support deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayLineResponse"/></returns>
        public DeleteMultiPathGatewayLineResponse DeleteMultiPathGatewayLineSync(DeleteMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayLineResponse>(req, "DeleteMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an origin group. If the origin group is still referenced by a service (for example, Layer 4 proxy, DNS, load balancing, or a rule), deletion is not allowed.
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public Task<DeleteOriginGroupResponse> DeleteOriginGroup(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup");
        }

        /// <summary>
        /// Delete an origin group. If the origin group is still referenced by a service (for example, Layer 4 proxy, DNS, load balancing, or a rule), deletion is not allowed.
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
        /// This API is on an earlier version for deleting rule engine APIs. EdgeOne completed a comprehensive upgrade of rule engine APIs on January 21, 2025. For details on the new API for deleting L7 acceleration rules, see [DeleteL7AccRules](https://www.tencentcloud.com/document/product/1552/115821?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the old version API will stop update and iteration. New features will only be provided in the new version API, and the existing capabilities supported by the old version API will not be affected. To avoid data field conflicts when using the old version API, migrate to the new version rule engine API as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules");
        }

        /// <summary>
        /// This API is on an earlier version for deleting rule engine APIs. EdgeOne completed a comprehensive upgrade of rule engine APIs on January 21, 2025. For details on the new API for deleting L7 acceleration rules, see [DeleteL7AccRules](https://www.tencentcloud.com/document/product/1552/115821?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the old version API will stop update and iteration. New features will only be provided in the new version API, and the existing capabilities supported by the old version API will not be affected. To avoid data field conflicts when using the old version API, migrate to the new version rule engine API as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to delete API resources.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIResourceResponse"/></returns>
        public Task<DeleteSecurityAPIResourceResponse> DeleteSecurityAPIResource(DeleteSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIResourceResponse>(req, "DeleteSecurityAPIResource");
        }

        /// <summary>
        /// Used to delete API resources.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIResourceResponse"/></returns>
        public DeleteSecurityAPIResourceResponse DeleteSecurityAPIResourceSync(DeleteSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIResourceResponse>(req, "DeleteSecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to delete an API service.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIServiceResponse"/></returns>
        public Task<DeleteSecurityAPIServiceResponse> DeleteSecurityAPIService(DeleteSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIServiceResponse>(req, "DeleteSecurityAPIService");
        }

        /// <summary>
        /// Used to delete an API service.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIServiceResponse"/></returns>
        public DeleteSecurityAPIServiceResponse DeleteSecurityAPIServiceSync(DeleteSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIServiceResponse>(req, "DeleteSecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete client authentication options.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DeleteSecurityClientAttesterResponse"/></returns>
        public Task<DeleteSecurityClientAttesterResponse> DeleteSecurityClientAttester(DeleteSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DeleteSecurityClientAttesterResponse>(req, "DeleteSecurityClientAttester");
        }

        /// <summary>
        /// Delete client authentication options.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DeleteSecurityClientAttesterResponse"/></returns>
        public DeleteSecurityClientAttesterResponse DeleteSecurityClientAttesterSync(DeleteSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DeleteSecurityClientAttesterResponse>(req, "DeleteSecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a specified IP group. If a rule references the IP group, deletion is not allowed.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public Task<DeleteSecurityIPGroupResponse> DeleteSecurityIPGroup(DeleteSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityIPGroupResponse>(req, "DeleteSecurityIPGroup");
        }

        /// <summary>
        /// Delete a specified IP group. If a rule references the IP group, deletion is not allowed.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public DeleteSecurityIPGroupResponse DeleteSecurityIPGroupSync(DeleteSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityIPGroupResponse>(req, "DeleteSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityJSInjectionRuleResponse"/></returns>
        public Task<DeleteSecurityJSInjectionRuleResponse> DeleteSecurityJSInjectionRule(DeleteSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityJSInjectionRuleResponse>(req, "DeleteSecurityJSInjectionRule");
        }

        /// <summary>
        /// This API is used to delete JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityJSInjectionRuleResponse"/></returns>
        public DeleteSecurityJSInjectionRuleResponse DeleteSecurityJSInjectionRuleSync(DeleteSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityJSInjectionRuleResponse>(req, "DeleteSecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to delete a shared CNAME. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="DeleteSharedCNAMERequest"/></param>
        /// <returns><see cref="DeleteSharedCNAMEResponse"/></returns>
        public Task<DeleteSharedCNAMEResponse> DeleteSharedCNAME(DeleteSharedCNAMERequest req)
        {
            return InternalRequestAsync<DeleteSharedCNAMEResponse>(req, "DeleteSharedCNAME");
        }

        /// <summary>
        /// Used to delete a shared CNAME. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="DeleteSharedCNAMERequest"/></param>
        /// <returns><see cref="DeleteSharedCNAMEResponse"/></returns>
        public DeleteSharedCNAMEResponse DeleteSharedCNAMESync(DeleteSharedCNAMERequest req)
        {
            return InternalRequestAsync<DeleteSharedCNAMEResponse>(req, "DeleteSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a security policy configuration template
        /// </summary>
        /// <param name="req"><see cref="DeleteWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DeleteWebSecurityTemplateResponse"/></returns>
        public Task<DeleteWebSecurityTemplateResponse> DeleteWebSecurityTemplate(DeleteWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWebSecurityTemplateResponse>(req, "DeleteWebSecurityTemplate");
        }

        /// <summary>
        /// Delete a security policy configuration template
        /// </summary>
        /// <param name="req"><see cref="DeleteWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DeleteWebSecurityTemplateResponse"/></returns>
        public DeleteWebSecurityTemplateResponse DeleteWebSecurityTemplateSync(DeleteWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWebSecurityTemplateResponse>(req, "DeleteWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public Task<DeleteZoneResponse> DeleteZone(DeleteZoneRequest req)
        {
            return InternalRequestAsync<DeleteZoneResponse>(req, "DeleteZone");
        }

        /// <summary>
        /// Delete a site.
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public DeleteZoneResponse DeleteZoneSync(DeleteZoneRequest req)
        {
            return InternalRequestAsync<DeleteZoneResponse>(req, "DeleteZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In version management mode, this API is used for version release. You can release a version to the testing environment or production environment by EnvId. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeployConfigGroupVersionRequest"/></param>
        /// <returns><see cref="DeployConfigGroupVersionResponse"/></returns>
        public Task<DeployConfigGroupVersionResponse> DeployConfigGroupVersion(DeployConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<DeployConfigGroupVersionResponse>(req, "DeployConfigGroupVersion");
        }

        /// <summary>
        /// In version management mode, this API is used for version release. You can release a version to the testing environment or production environment by EnvId. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeployConfigGroupVersionRequest"/></param>
        /// <returns><see cref="DeployConfigGroupVersionResponse"/></returns>
        public DeployConfigGroupVersionResponse DeployConfigGroupVersionSync(DeployConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<DeployConfigGroupVersionResponse>(req, "DeployConfigGroupVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view domain information under a site, including acceleration domain names, origin servers, and domain name status. You can view information of all domains under a site, or specify filter conditions to query specific domain information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public Task<DescribeAccelerationDomainsResponse> DescribeAccelerationDomains(DescribeAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerationDomainsResponse>(req, "DescribeAccelerationDomains");
        }

        /// <summary>
        /// This API is used to view domain information under a site, including acceleration domain names, origin servers, and domain name status. You can view information of all domains under a site, or specify filter conditions to query specific domain information.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public DescribeAccelerationDomainsResponse DescribeAccelerationDomainsSync(DescribeAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerationDomainsResponse>(req, "DescribeAccelerationDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of alias domain names.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public Task<DescribeAliasDomainsResponse> DescribeAliasDomains(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains");
        }

        /// <summary>
        /// Query the list of alias domain names.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public DescribeAliasDomainsResponse DescribeAliasDomainsSync(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. The latest version splits into two APIs: one for querying the Layer 4 proxy instance list and the other for querying Layer 4 forwarding rules. For details, see [Query Layer 4 Proxy Instance List](https://www.tencentcloud.com/document/product/1552/103413?from_cn_redirect=1) and [Query Layer 4 Proxy Forwarding Rule List](https://www.tencentcloud.com/document/product/1552/103412?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public Task<DescribeApplicationProxiesResponse> DescribeApplicationProxies(DescribeApplicationProxiesRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxiesResponse>(req, "DescribeApplicationProxies");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. The latest version splits into two APIs: one for querying the Layer 4 proxy instance list and the other for querying Layer 4 forwarding rules. For details, see [Query Layer 4 Proxy Instance List](https://www.tencentcloud.com/document/product/1552/103413?from_cn_redirect=1) and [Query Layer 4 Proxy Forwarding Rule List](https://www.tencentcloud.com/document/product/1552/103412?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public DescribeApplicationProxiesResponse DescribeApplicationProxiesSync(DescribeApplicationProxiesRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxiesResponse>(req, "DescribeApplicationProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of available custom configurations for site rule engine operations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCustomActionsForRuleEngineRequest"/></param>
        /// <returns><see cref="DescribeAvailableCustomActionsForRuleEngineResponse"/></returns>
        public Task<DescribeAvailableCustomActionsForRuleEngineResponse> DescribeAvailableCustomActionsForRuleEngine(DescribeAvailableCustomActionsForRuleEngineRequest req)
        {
            return InternalRequestAsync<DescribeAvailableCustomActionsForRuleEngineResponse>(req, "DescribeAvailableCustomActionsForRuleEngine");
        }

        /// <summary>
        /// Queries the list of available custom configurations for site rule engine operations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCustomActionsForRuleEngineRequest"/></param>
        /// <returns><see cref="DescribeAvailableCustomActionsForRuleEngineResponse"/></returns>
        public DescribeAvailableCustomActionsForRuleEngineResponse DescribeAvailableCustomActionsForRuleEngineSync(DescribeAvailableCustomActionsForRuleEngineRequest req)
        {
            return InternalRequestAsync<DescribeAvailableCustomActionsForRuleEngineResponse>(req, "DescribeAvailableCustomActionsForRuleEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query detailed information about the origin protection IP range control domain, including the version number and specific IP range information.
        /// The main difference between standard control domain and streamlined control domain is the number of IP ranges provided. The latter has fewer IP ranges, but has some usage restrictions. For specific restrictions, consult the product. The format description is as follows:
        /// Standard control domain:
        /// <li>gaz: standard global control domain;</li>
        /// <li>mlc: Standard China control domain;</li>
        /// <li>emc: standard overseas (worldwide excluding China) control domain;</li>
        /// Streamline the control domain.
        /// <li>plat-gaz: simplified global control domain;</li>
        /// <li>plat-mlc: Simplified China control domain;</li>
        /// <li>plat-emc: Simplified overseas (global excluding China) control domain;</li>
        /// <li>plat-specific-gaz: custom edition global availability zone control domain;</li>
        /// <li>plat-specific-mlc: custom edition for controlling the Chinese mainland availability zone control domain;</li>
        /// <li>plat-specific-emc: custom edition control domain for availability zones worldwide (excluding Chinese mainland);</li>
        /// Abbreviation description:
        /// <li>gaz:Global AZ Availability Zone;</li>
        /// <li>mlc:mainlandChina;</li>
        /// <li>emc:Exclude mainlandChina.</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableOriginACLFamilyRequest"/></param>
        /// <returns><see cref="DescribeAvailableOriginACLFamilyResponse"/></returns>
        public Task<DescribeAvailableOriginACLFamilyResponse> DescribeAvailableOriginACLFamily(DescribeAvailableOriginACLFamilyRequest req)
        {
            return InternalRequestAsync<DescribeAvailableOriginACLFamilyResponse>(req, "DescribeAvailableOriginACLFamily");
        }

        /// <summary>
        /// This API is used to query detailed information about the origin protection IP range control domain, including the version number and specific IP range information.
        /// The main difference between standard control domain and streamlined control domain is the number of IP ranges provided. The latter has fewer IP ranges, but has some usage restrictions. For specific restrictions, consult the product. The format description is as follows:
        /// Standard control domain:
        /// <li>gaz: standard global control domain;</li>
        /// <li>mlc: Standard China control domain;</li>
        /// <li>emc: standard overseas (worldwide excluding China) control domain;</li>
        /// Streamline the control domain.
        /// <li>plat-gaz: simplified global control domain;</li>
        /// <li>plat-mlc: Simplified China control domain;</li>
        /// <li>plat-emc: Simplified overseas (global excluding China) control domain;</li>
        /// <li>plat-specific-gaz: custom edition global availability zone control domain;</li>
        /// <li>plat-specific-mlc: custom edition for controlling the Chinese mainland availability zone control domain;</li>
        /// <li>plat-specific-emc: custom edition control domain for availability zones worldwide (excluding Chinese mainland);</li>
        /// Abbreviation description:
        /// <li>gaz:Global AZ Availability Zone;</li>
        /// <li>mlc:mainlandChina;</li>
        /// <li>emc:Exclude mainlandChina.</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableOriginACLFamilyRequest"/></param>
        /// <returns><see cref="DescribeAvailableOriginACLFamilyResponse"/></returns>
        public DescribeAvailableOriginACLFamilyResponse DescribeAvailableOriginACLFamilySync(DescribeAvailableOriginACLFamilyRequest req)
        {
            return InternalRequestAsync<DescribeAvailableOriginACLFamilyResponse>(req, "DescribeAvailableOriginACLFamily")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of available package information for the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public Task<DescribeAvailablePlansResponse> DescribeAvailablePlans(DescribeAvailablePlansRequest req)
        {
            return InternalRequestAsync<DescribeAvailablePlansResponse>(req, "DescribeAvailablePlans");
        }

        /// <summary>
        /// Query the list of available package information for the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public DescribeAvailablePlansResponse DescribeAvailablePlansSync(DescribeAvailablePlansRequest req)
        {
            return InternalRequestAsync<DescribeAvailablePlansResponse>(req, "DescribeAvailablePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query billing data via this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData");
        }

        /// <summary>
        /// Query billing data via this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In version management mode, this API is used to obtain detailed version information, including version ID, description, status, creation time, associated configuration group information, and the content of the version configuration file. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionDetailRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionDetailResponse"/></returns>
        public Task<DescribeConfigGroupVersionDetailResponse> DescribeConfigGroupVersionDetail(DescribeConfigGroupVersionDetailRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionDetailResponse>(req, "DescribeConfigGroupVersionDetail");
        }

        /// <summary>
        /// In version management mode, this API is used to obtain detailed version information, including version ID, description, status, creation time, associated configuration group information, and the content of the version configuration file. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionDetailRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionDetailResponse"/></returns>
        public DescribeConfigGroupVersionDetailResponse DescribeConfigGroupVersionDetailSync(DescribeConfigGroupVersionDetailRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionDetailResponse>(req, "DescribeConfigGroupVersionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In version management mode, this API is used to query the version list of a specified configuration group. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionsResponse"/></returns>
        public Task<DescribeConfigGroupVersionsResponse> DescribeConfigGroupVersions(DescribeConfigGroupVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionsResponse>(req, "DescribeConfigGroupVersions");
        }

        /// <summary>
        /// In version management mode, this API is used to query the version list of a specified configuration group. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionsResponse"/></returns>
        public DescribeConfigGroupVersionsResponse DescribeConfigGroupVersionsSync(DescribeConfigGroupVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionsResponse>(req, "DescribeConfigGroupVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query content identifiers in batches. They can be filtered by ID, description, status, or tags. Deleted content identifiers queried by status are only retained for three months. This feature is only open in the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentIdentifiersRequest"/></param>
        /// <returns><see cref="DescribeContentIdentifiersResponse"/></returns>
        public Task<DescribeContentIdentifiersResponse> DescribeContentIdentifiers(DescribeContentIdentifiersRequest req)
        {
            return InternalRequestAsync<DescribeContentIdentifiersResponse>(req, "DescribeContentIdentifiers");
        }

        /// <summary>
        /// This API is used to query content identifiers in batches. They can be filtered by ID, description, status, or tags. Deleted content identifiers queried by status are only retained for three months. This feature is only open in the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeContentIdentifiersRequest"/></param>
        /// <returns><see cref="DescribeContentIdentifiersResponse"/></returns>
        public DescribeContentIdentifiersResponse DescribeContentIdentifiersSync(DescribeContentIdentifiersRequest req)
        {
            return InternalRequestAsync<DescribeContentIdentifiersResponse>(req, "DescribeContentIdentifiers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the content management API quota
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public Task<DescribeContentQuotaResponse> DescribeContentQuota(DescribeContentQuotaRequest req)
        {
            return InternalRequestAsync<DescribeContentQuotaResponse>(req, "DescribeContentQuota");
        }

        /// <summary>
        /// Query the content management API quota
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public DescribeContentQuotaResponse DescribeContentQuotaSync(DescribeContentQuotaRequest req)
        {
            return InternalRequestAsync<DescribeContentQuotaResponse>(req, "DescribeContentQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the custom error page list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomErrorPagesRequest"/></param>
        /// <returns><see cref="DescribeCustomErrorPagesResponse"/></returns>
        public Task<DescribeCustomErrorPagesResponse> DescribeCustomErrorPages(DescribeCustomErrorPagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomErrorPagesResponse>(req, "DescribeCustomErrorPages");
        }

        /// <summary>
        /// This API is used to query the custom error page list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomErrorPagesRequest"/></param>
        /// <returns><see cref="DescribeCustomErrorPagesResponse"/></returns>
        public DescribeCustomErrorPagesResponse DescribeCustomErrorPagesSync(DescribeCustomErrorPagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomErrorPagesResponse>(req, "DescribeCustomErrorPages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the detailed information of a custom group, including all entries in the group (returned with pagination via Limit/Offset). The DescribeCustomGroups list API returns up to the first 500 entries for each group. To obtain all entries, use this API. The GroupId can be obtained from the response of CreateCustomGroup or by querying DescribeCustomGroups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupResponse"/></returns>
        public Task<DescribeCustomGroupResponse> DescribeCustomGroup(DescribeCustomGroupRequest req)
        {
            return InternalRequestAsync<DescribeCustomGroupResponse>(req, "DescribeCustomGroup");
        }

        /// <summary>
        /// This API is used to query the detailed information of a custom group, including all entries in the group (returned with pagination via Limit/Offset). The DescribeCustomGroups list API returns up to the first 500 entries for each group. To obtain all entries, use this API. The GroupId can be obtained from the response of CreateCustomGroup or by querying DescribeCustomGroups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupResponse"/></returns>
        public DescribeCustomGroupResponse DescribeCustomGroupSync(DescribeCustomGroupRequest req)
        {
            return InternalRequestAsync<DescribeCustomGroupResponse>(req, "DescribeCustomGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security policy configuration that uses a custom group.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupReferencesResponse"/></returns>
        public Task<DescribeCustomGroupReferencesResponse> DescribeCustomGroupReferences(DescribeCustomGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeCustomGroupReferencesResponse>(req, "DescribeCustomGroupReferences");
        }

        /// <summary>
        /// This API is used to obtain the security policy configuration that uses a custom group.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupReferencesResponse"/></returns>
        public DescribeCustomGroupReferencesResponse DescribeCustomGroupReferencesSync(DescribeCustomGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeCustomGroupReferencesResponse>(req, "DescribeCustomGroupReferences")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of custom groups under a specified site. This API returns only the first 500 entries of each custom group. To query all entries in a group, use the DescribeSecurityCustomGroup API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupsRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupsResponse"/></returns>
        public Task<DescribeCustomGroupsResponse> DescribeCustomGroups(DescribeCustomGroupsRequest req)
        {
            return InternalRequestAsync<DescribeCustomGroupsResponse>(req, "DescribeCustomGroups");
        }

        /// <summary>
        /// This API is used to query the list of custom groups under a specified site. This API returns only the first 500 entries of each custom group. To query all entries in a group, use the DescribeSecurityCustomGroup API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomGroupsRequest"/></param>
        /// <returns><see cref="DescribeCustomGroupsResponse"/></returns>
        public DescribeCustomGroupsResponse DescribeCustomGroupsSync(DescribeCustomGroupsRequest req)
        {
            return InternalRequestAsync<DescribeCustomGroupsResponse>(req, "DescribeCustomGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DDoS attack time-series data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public Task<DescribeDDoSAttackDataResponse> DescribeDDoSAttackData(DescribeDDoSAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackDataResponse>(req, "DescribeDDoSAttackData");
        }

        /// <summary>
        /// This API is used to query DDoS attack time-series data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public DescribeDDoSAttackDataResponse DescribeDDoSAttackDataSync(DescribeDDoSAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackDataResponse>(req, "DescribeDDoSAttackData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public Task<DescribeDDoSAttackEventResponse> DescribeDDoSAttackEvent(DescribeDDoSAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackEventResponse>(req, "DescribeDDoSAttackEvent");
        }

        /// <summary>
        /// This API is used to query the list of DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public DescribeDDoSAttackEventResponse DescribeDDoSAttackEventSync(DescribeDDoSAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackEventResponse>(req, "DescribeDDoSAttackEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Top-ranked data of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public Task<DescribeDDoSAttackTopDataResponse> DescribeDDoSAttackTopData(DescribeDDoSAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackTopDataResponse>(req, "DescribeDDoSAttackTopData");
        }

        /// <summary>
        /// This API is used to query Top-ranked data of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public DescribeDDoSAttackTopDataResponse DescribeDDoSAttackTopDataSync(DescribeDDoSAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackTopDataResponse>(req, "DescribeDDoSAttackTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query exclusive DDoS protection info of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSProtectionRequest"/></param>
        /// <returns><see cref="DescribeDDoSProtectionResponse"/></returns>
        public Task<DescribeDDoSProtectionResponse> DescribeDDoSProtection(DescribeDDoSProtectionRequest req)
        {
            return InternalRequestAsync<DescribeDDoSProtectionResponse>(req, "DescribeDDoSProtection");
        }

        /// <summary>
        /// This API is used to query exclusive DDoS protection info of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSProtectionRequest"/></param>
        /// <returns><see cref="DescribeDDoSProtectionResponse"/></returns>
        public DescribeDDoSProtectionResponse DescribeDDoSProtectionSync(DescribeDDoSProtectionRequest req)
        {
            return InternalRequestAsync<DescribeDDoSProtectionResponse>(req, "DescribeDDoSProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the default certificate list
        /// <p style="color: red;">Note: This earlier version interface is no longer updated. New features will only be provided in the latest version interface. Existing capacities supported by the earlier version interface will not be affected. To query the cert configured for a domain name, please use DescribeAccelerationDomains.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public Task<DescribeDefaultCertificatesResponse> DescribeDefaultCertificates(DescribeDefaultCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDefaultCertificatesResponse>(req, "DescribeDefaultCertificates");
        }

        /// <summary>
        /// Query the default certificate list
        /// <p style="color: red;">Note: This earlier version interface is no longer updated. New features will only be provided in the latest version interface. Existing capacities supported by the earlier version interface will not be affected. To query the cert configured for a domain name, please use DescribeAccelerationDomains.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public DescribeDefaultCertificatesResponse DescribeDefaultCertificatesSync(DescribeDefaultCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDefaultCertificatesResponse>(req, "DescribeDefaultCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In version management mode, this API is used to query the version release history of production/test environments. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeployHistoryResponse"/></returns>
        public Task<DescribeDeployHistoryResponse> DescribeDeployHistory(DescribeDeployHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeployHistoryResponse>(req, "DescribeDeployHistory");
        }

        /// <summary>
        /// In version management mode, this API is used to query the version release history of production/test environments. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeployHistoryResponse"/></returns>
        public DescribeDeployHistoryResponse DescribeDeployHistorySync(DescribeDeployHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeployHistoryResponse>(req, "DescribeDeployHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view DNS records under a site, including DNS record names, record types, and record content. It supports specifying filter conditions to query specific DNS records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public Task<DescribeDnsRecordsResponse> DescribeDnsRecords(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords");
        }

        /// <summary>
        /// This API is used to view DNS records under a site, including DNS record names, record types, and record content. It supports specifying filter conditions to query specific DNS records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public DescribeDnsRecordsResponse DescribeDnsRecordsSync(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the KV namespace list under a specified site. Supports pagination, sorting, and conditional filtering. Returns basic namespace info, storage capacity utilization, and reference relationships. If no data is found, an empty array is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeKVNamespacesRequest"/></param>
        /// <returns><see cref="DescribeEdgeKVNamespacesResponse"/></returns>
        public Task<DescribeEdgeKVNamespacesResponse> DescribeEdgeKVNamespaces(DescribeEdgeKVNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeKVNamespacesResponse>(req, "DescribeEdgeKVNamespaces");
        }

        /// <summary>
        /// Queries the KV namespace list under a specified site. Supports pagination, sorting, and conditional filtering. Returns basic namespace info, storage capacity utilization, and reference relationships. If no data is found, an empty array is returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeKVNamespacesRequest"/></param>
        /// <returns><see cref="DescribeEdgeKVNamespacesResponse"/></returns>
        public DescribeEdgeKVNamespacesResponse DescribeEdgeKVNamespacesSync(DescribeEdgeKVNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeKVNamespacesResponse>(req, "DescribeEdgeKVNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In version management mode, this API is used to query environment information, including the environment ID, type, and current effective version. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// In version management mode, this API is used to query environment information, including the environment ID, type, and current effective version. The version management feature is in beta test and currently only available to the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the component binding list of a specified edge function. It supports pagination and conditional filtering, and returns detailed information such as the bound component type, variable name, and configuration parameters. The currently supported binding component type is KV namespace (kv_namespace).
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionComponentBindingsRequest"/></param>
        /// <returns><see cref="DescribeFunctionComponentBindingsResponse"/></returns>
        public Task<DescribeFunctionComponentBindingsResponse> DescribeFunctionComponentBindings(DescribeFunctionComponentBindingsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionComponentBindingsResponse>(req, "DescribeFunctionComponentBindings");
        }

        /// <summary>
        /// This API is used to query the component binding list of a specified edge function. It supports pagination and conditional filtering, and returns detailed information such as the bound component type, variable name, and configuration parameters. The currently supported binding component type is KV namespace (kv_namespace).
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionComponentBindingsRequest"/></param>
        /// <returns><see cref="DescribeFunctionComponentBindingsResponse"/></returns>
        public DescribeFunctionComponentBindingsResponse DescribeFunctionComponentBindingsSync(DescribeFunctionComponentBindingsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionComponentBindingsResponse>(req, "DescribeFunctionComponentBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the replica list of edge functions.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionReplicasRequest"/></param>
        /// <returns><see cref="DescribeFunctionReplicasResponse"/></returns>
        public Task<DescribeFunctionReplicasResponse> DescribeFunctionReplicas(DescribeFunctionReplicasRequest req)
        {
            return InternalRequestAsync<DescribeFunctionReplicasResponse>(req, "DescribeFunctionReplicas");
        }

        /// <summary>
        /// This API is used to query the replica list of edge functions.
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionReplicasRequest"/></param>
        /// <returns><see cref="DescribeFunctionReplicasResponse"/></returns>
        public DescribeFunctionReplicasResponse DescribeFunctionReplicasSync(DescribeFunctionReplicasRequest req)
        {
            return InternalRequestAsync<DescribeFunctionReplicasResponse>(req, "DescribeFunctionReplicas")
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
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. You can use [DescribeL7AccSetting](https://www.tencentcloud.com/document/product/1552/115819?from_cn_redirect=1) and [DescribeL7AccRules](https://www.tencentcloud.com/document/product/1552/115820?from_cn_redirect=1) to obtain detailed configuration of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting");
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. You can use [DescribeL7AccSetting](https://www.tencentcloud.com/document/product/1552/115819?from_cn_redirect=1) and [DescribeL7AccRules](https://www.tencentcloud.com/document/product/1552/115820?from_cn_redirect=1) to obtain detailed configuration of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public DescribeHostsSettingResponse DescribeHostsSettingSync(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain policy settings that use IP grouping.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeIPGroupReferencesResponse"/></returns>
        public Task<DescribeIPGroupReferencesResponse> DescribeIPGroupReferences(DescribeIPGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeIPGroupReferencesResponse>(req, "DescribeIPGroupReferences");
        }

        /// <summary>
        /// This API is used to obtain policy settings that use IP grouping.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeIPGroupReferencesResponse"/></returns>
        public DescribeIPGroupReferencesResponse DescribeIPGroupReferencesSync(DescribeIPGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeIPGroupReferencesResponse>(req, "DescribeIPGroupReferences")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query if the IP is an EdgeOne IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPRegionRequest"/></param>
        /// <returns><see cref="DescribeIPRegionResponse"/></returns>
        public Task<DescribeIPRegionResponse> DescribeIPRegion(DescribeIPRegionRequest req)
        {
            return InternalRequestAsync<DescribeIPRegionResponse>(req, "DescribeIPRegion");
        }

        /// <summary>
        /// This API is used to query if the IP is an EdgeOne IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPRegionRequest"/></param>
        /// <returns><see cref="DescribeIPRegionResponse"/></returns>
        public DescribeIPRegionResponse DescribeIPRegionSync(DescribeIPRegionRequest req)
        {
            return InternalRequestAsync<DescribeIPRegionResponse>(req, "DescribeIPRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries verification information of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public Task<DescribeIdentificationsResponse> DescribeIdentifications(DescribeIdentificationsRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationsResponse>(req, "DescribeIdentifications");
        }

        /// <summary>
        /// Queries verification information of a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public DescribeIdentificationsResponse DescribeIdentificationsSync(DescribeIdentificationsRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationsResponse>(req, "DescribeIdentifications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of reasoning API tokens and returns the Token ID, name, content, and creation time. Paging query is supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceAPITokensRequest"/></param>
        /// <returns><see cref="DescribeInferenceAPITokensResponse"/></returns>
        public Task<DescribeInferenceAPITokensResponse> DescribeInferenceAPITokens(DescribeInferenceAPITokensRequest req)
        {
            return InternalRequestAsync<DescribeInferenceAPITokensResponse>(req, "DescribeInferenceAPITokens");
        }

        /// <summary>
        /// Queries the list of reasoning API tokens and returns the Token ID, name, content, and creation time. Paging query is supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceAPITokensRequest"/></param>
        /// <returns><see cref="DescribeInferenceAPITokensResponse"/></returns>
        public DescribeInferenceAPITokensResponse DescribeInferenceAPITokensSync(DescribeInferenceAPITokensRequest req)
        {
            return InternalRequestAsync<DescribeInferenceAPITokensResponse>(req, "DescribeInferenceAPITokens")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the inference service domain name list and return the Cname address, ownership verification, and certificate information of the domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceDomainsRequest"/></param>
        /// <returns><see cref="DescribeInferenceDomainsResponse"/></returns>
        public Task<DescribeInferenceDomainsResponse> DescribeInferenceDomains(DescribeInferenceDomainsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceDomainsResponse>(req, "DescribeInferenceDomains");
        }

        /// <summary>
        /// This API is used to query the inference service domain name list and return the Cname address, ownership verification, and certificate information of the domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceDomainsRequest"/></param>
        /// <returns><see cref="DescribeInferenceDomainsResponse"/></returns>
        public DescribeInferenceDomainsResponse DescribeInferenceDomainsSync(DescribeInferenceDomainsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceDomainsResponse>(req, "DescribeInferenceDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the inference hardware specification list and return the CPU, memory, GPU, and video memory configurations of each specification. You can select the required specification from the list when creating a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceHardwareSpecificationsRequest"/></param>
        /// <returns><see cref="DescribeInferenceHardwareSpecificationsResponse"/></returns>
        public Task<DescribeInferenceHardwareSpecificationsResponse> DescribeInferenceHardwareSpecifications(DescribeInferenceHardwareSpecificationsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceHardwareSpecificationsResponse>(req, "DescribeInferenceHardwareSpecifications");
        }

        /// <summary>
        /// This API is used to query the inference hardware specification list and return the CPU, memory, GPU, and video memory configurations of each specification. You can select the required specification from the list when creating a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceHardwareSpecificationsRequest"/></param>
        /// <returns><see cref="DescribeInferenceHardwareSpecificationsResponse"/></returns>
        public DescribeInferenceHardwareSpecificationsResponse DescribeInferenceHardwareSpecificationsSync(DescribeInferenceHardwareSpecificationsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceHardwareSpecificationsResponse>(req, "DescribeInferenceHardwareSpecifications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the logs of a specified deployment of an inference service, return log content and generation time, and support time range search, pagination, and sorting.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServiceDeploymentLogsRequest"/></param>
        /// <returns><see cref="DescribeInferenceServiceDeploymentLogsResponse"/></returns>
        public Task<DescribeInferenceServiceDeploymentLogsResponse> DescribeInferenceServiceDeploymentLogs(DescribeInferenceServiceDeploymentLogsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServiceDeploymentLogsResponse>(req, "DescribeInferenceServiceDeploymentLogs");
        }

        /// <summary>
        /// This API is used to query the logs of a specified deployment of an inference service, return log content and generation time, and support time range search, pagination, and sorting.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServiceDeploymentLogsRequest"/></param>
        /// <returns><see cref="DescribeInferenceServiceDeploymentLogsResponse"/></returns>
        public DescribeInferenceServiceDeploymentLogsResponse DescribeInferenceServiceDeploymentLogsSync(DescribeInferenceServiceDeploymentLogsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServiceDeploymentLogsResponse>(req, "DescribeInferenceServiceDeploymentLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the deployment history list of an inference service. It returns the operation type, status, duration, configuration snapshot, and whether it is the currently effective configuration for each deployment. Pagination and sorting are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServiceDeploymentRecordsRequest"/></param>
        /// <returns><see cref="DescribeInferenceServiceDeploymentRecordsResponse"/></returns>
        public Task<DescribeInferenceServiceDeploymentRecordsResponse> DescribeInferenceServiceDeploymentRecords(DescribeInferenceServiceDeploymentRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServiceDeploymentRecordsResponse>(req, "DescribeInferenceServiceDeploymentRecords");
        }

        /// <summary>
        /// This API is used to query the deployment history list of an inference service. It returns the operation type, status, duration, configuration snapshot, and whether it is the currently effective configuration for each deployment. Pagination and sorting are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServiceDeploymentRecordsRequest"/></param>
        /// <returns><see cref="DescribeInferenceServiceDeploymentRecordsResponse"/></returns>
        public DescribeInferenceServiceDeploymentRecordsResponse DescribeInferenceServiceDeploymentRecordsSync(DescribeInferenceServiceDeploymentRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServiceDeploymentRecordsResponse>(req, "DescribeInferenceServiceDeploymentRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the monitoring data of inference services, supporting indicators such as CPU, memory, GPU, video memory utilization, and instance count. You can specify the time range and aggregation granularity, and query data from the most recent 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServiceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeInferenceServiceMonitorDataResponse"/></returns>
        public Task<DescribeInferenceServiceMonitorDataResponse> DescribeInferenceServiceMonitorData(DescribeInferenceServiceMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServiceMonitorDataResponse>(req, "DescribeInferenceServiceMonitorData");
        }

        /// <summary>
        /// This API is used to query the monitoring data of inference services, supporting indicators such as CPU, memory, GPU, video memory utilization, and instance count. You can specify the time range and aggregation granularity, and query data from the most recent 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServiceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeInferenceServiceMonitorDataResponse"/></returns>
        public DescribeInferenceServiceMonitorDataResponse DescribeInferenceServiceMonitorDataSync(DescribeInferenceServiceMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServiceMonitorDataResponse>(req, "DescribeInferenceServiceMonitorData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the inference service list, support filtering by service name, service ID, and status, and return the service configuration, running state, number of instances, and inference access address.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServicesRequest"/></param>
        /// <returns><see cref="DescribeInferenceServicesResponse"/></returns>
        public Task<DescribeInferenceServicesResponse> DescribeInferenceServices(DescribeInferenceServicesRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServicesResponse>(req, "DescribeInferenceServices");
        }

        /// <summary>
        /// This API is used to query the inference service list, support filtering by service name, service ID, and status, and return the service configuration, running state, number of instances, and inference access address.
        /// </summary>
        /// <param name="req"><see cref="DescribeInferenceServicesRequest"/></param>
        /// <returns><see cref="DescribeInferenceServicesResponse"/></returns>
        public DescribeInferenceServicesResponse DescribeInferenceServicesSync(DescribeInferenceServicesRequest req)
        {
            return InternalRequestAsync<DescribeInferenceServicesResponse>(req, "DescribeInferenceServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the transcoding template detail list based on the just in time transcoding template name, template type, or unique ID. The returned results include all eligible custom templates and preset templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeJustInTimeTranscodeTemplatesResponse> DescribeJustInTimeTranscodeTemplates(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// This API is used to retrieve the transcoding template detail list based on the just in time transcoding template name, template type, or unique ID. The returned results include all eligible custom templates and preset templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public DescribeJustInTimeTranscodeTemplatesResponse DescribeJustInTimeTranscodeTemplatesSync(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the layer 4 proxy instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyResponse"/></returns>
        public Task<DescribeL4ProxyResponse> DescribeL4Proxy(DescribeL4ProxyRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyResponse>(req, "DescribeL4Proxy");
        }

        /// <summary>
        /// This API is used to query the layer 4 proxy instance list.
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
        /// This API is used to query the rule list of the [rule engine](https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccRulesRequest"/></param>
        /// <returns><see cref="DescribeL7AccRulesResponse"/></returns>
        public Task<DescribeL7AccRulesResponse> DescribeL7AccRules(DescribeL7AccRulesRequest req)
        {
            return InternalRequestAsync<DescribeL7AccRulesResponse>(req, "DescribeL7AccRules");
        }

        /// <summary>
        /// This API is used to query the rule list of the [rule engine](https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccRulesRequest"/></param>
        /// <returns><see cref="DescribeL7AccRulesResponse"/></returns>
        public DescribeL7AccRulesResponse DescribeL7AccRulesSync(DescribeL7AccRulesRequest req)
        {
            return InternalRequestAsync<DescribeL7AccRulesResponse>(req, "DescribeL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the global configuration of site acceleration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccSettingRequest"/></param>
        /// <returns><see cref="DescribeL7AccSettingResponse"/></returns>
        public Task<DescribeL7AccSettingResponse> DescribeL7AccSetting(DescribeL7AccSettingRequest req)
        {
            return InternalRequestAsync<DescribeL7AccSettingResponse>(req, "DescribeL7AccSetting");
        }

        /// <summary>
        /// This API is used to query the global configuration of site acceleration.
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccSettingRequest"/></param>
        /// <returns><see cref="DescribeL7AccSettingResponse"/></returns>
        public DescribeL7AccSettingResponse DescribeL7AccSettingSync(DescribeL7AccSettingRequest req)
        {
            return InternalRequestAsync<DescribeL7AccSettingResponse>(req, "DescribeL7AccSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the load balancing instance list. The load balancer feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListResponse"/></returns>
        public Task<DescribeLoadBalancerListResponse> DescribeLoadBalancerList(DescribeLoadBalancerListRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListResponse>(req, "DescribeLoadBalancerList");
        }

        /// <summary>
        /// This API is used to query the load balancing instance list. The load balancer feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListResponse"/></returns>
        public DescribeLoadBalancerListResponse DescribeLoadBalancerListSync(DescribeLoadBalancerListRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListResponse>(req, "DescribeLoadBalancerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query log analysis details. The data comes from the log data pushed by real-time log push tasks under the site with the destination "log-analysis".
        /// </summary>
        /// <param name="req"><see cref="DescribeLogAnalysisDetailRequest"/></param>
        /// <returns><see cref="DescribeLogAnalysisDetailResponse"/></returns>
        public Task<DescribeLogAnalysisDetailResponse> DescribeLogAnalysisDetail(DescribeLogAnalysisDetailRequest req)
        {
            return InternalRequestAsync<DescribeLogAnalysisDetailResponse>(req, "DescribeLogAnalysisDetail");
        }

        /// <summary>
        /// This API is used to query log analysis details. The data comes from the log data pushed by real-time log push tasks under the site with the destination "log-analysis".
        /// </summary>
        /// <param name="req"><see cref="DescribeLogAnalysisDetailRequest"/></param>
        /// <returns><see cref="DescribeLogAnalysisDetailResponse"/></returns>
        public DescribeLogAnalysisDetailResponse DescribeLogAnalysisDetailSync(DescribeLogAnalysisDetailRequest req)
        {
            return InternalRequestAsync<DescribeLogAnalysisDetailResponse>(req, "DescribeLogAnalysisDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log download task list for log analysis. Note: Only download task records from the last three days are retained.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogAnalysisDownloadTasksRequest"/></param>
        /// <returns><see cref="DescribeLogAnalysisDownloadTasksResponse"/></returns>
        public Task<DescribeLogAnalysisDownloadTasksResponse> DescribeLogAnalysisDownloadTasks(DescribeLogAnalysisDownloadTasksRequest req)
        {
            return InternalRequestAsync<DescribeLogAnalysisDownloadTasksResponse>(req, "DescribeLogAnalysisDownloadTasks");
        }

        /// <summary>
        /// This API is used to query the log download task list for log analysis. Note: Only download task records from the last three days are retained.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogAnalysisDownloadTasksRequest"/></param>
        /// <returns><see cref="DescribeLogAnalysisDownloadTasksResponse"/></returns>
        public DescribeLogAnalysisDownloadTasksResponse DescribeLogAnalysisDownloadTasksSync(DescribeLogAnalysisDownloadTasksRequest req)
        {
            return InternalRequestAsync<DescribeLogAnalysisDownloadTasksResponse>(req, "DescribeLogAnalysisDownloadTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query log analysis statistics results. Users append an SQL aggregation statement after the query statement ([retrieval condition] | [SQL statement]). The backend executes the aggregation and returns columnar statistics results (column definition + data row).
        /// </summary>
        /// <param name="req"><see cref="DescribeLogAnalysisStatisticsRequest"/></param>
        /// <returns><see cref="DescribeLogAnalysisStatisticsResponse"/></returns>
        public Task<DescribeLogAnalysisStatisticsResponse> DescribeLogAnalysisStatistics(DescribeLogAnalysisStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeLogAnalysisStatisticsResponse>(req, "DescribeLogAnalysisStatistics");
        }

        /// <summary>
        /// This API is used to query log analysis statistics results. Users append an SQL aggregation statement after the query statement ([retrieval condition] | [SQL statement]). The backend executes the aggregation and returns columnar statistics results (column definition + data row).
        /// </summary>
        /// <param name="req"><see cref="DescribeLogAnalysisStatisticsRequest"/></param>
        /// <returns><see cref="DescribeLogAnalysisStatisticsResponse"/></returns>
        public DescribeLogAnalysisStatisticsResponse DescribeLogAnalysisStatisticsSync(DescribeLogAnalysisStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeLogAnalysisStatisticsResponse>(req, "DescribeLogAnalysisStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a multi-channel security acceleration gateway, such as name, Gateway ID, IP, port, and type.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayResponse"/></returns>
        public Task<DescribeMultiPathGatewayResponse> DescribeMultiPathGateway(DescribeMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayResponse>(req, "DescribeMultiPathGateway");
        }

        /// <summary>
        /// This API is used to query details of a multi-channel security acceleration gateway, such as name, Gateway ID, IP, port, and type.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayResponse"/></returns>
        public DescribeMultiPathGatewayResponse DescribeMultiPathGatewaySync(DescribeMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayResponse>(req, "DescribeMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query lines connected to the multi-channel security acceleration gateway, including direct connections, EdgeOne Layer 4 proxy lines, and custom lines.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayLineResponse"/></returns>
        public Task<DescribeMultiPathGatewayLineResponse> DescribeMultiPathGatewayLine(DescribeMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayLineResponse>(req, "DescribeMultiPathGatewayLine");
        }

        /// <summary>
        /// This API is used to query lines connected to the multi-channel security acceleration gateway, including direct connections, EdgeOne Layer 4 proxy lines, and custom lines.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayLineResponse"/></returns>
        public DescribeMultiPathGatewayLineResponse DescribeMultiPathGatewayLineSync(DescribeMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayLineResponse>(req, "DescribeMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the binding relationship between a multi-channel security acceleration gateway instance and origin IP ranges, as well as origin IP range details. If the MultiPathGatewayNextOriginACL field has a return value, synchronize the latest origin IP ranges to the origin server firewall settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayOriginACLRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayOriginACLResponse"/></returns>
        public Task<DescribeMultiPathGatewayOriginACLResponse> DescribeMultiPathGatewayOriginACL(DescribeMultiPathGatewayOriginACLRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayOriginACLResponse>(req, "DescribeMultiPathGatewayOriginACL");
        }

        /// <summary>
        /// This API is used to query the binding relationship between a multi-channel security acceleration gateway instance and origin IP ranges, as well as origin IP range details. If the MultiPathGatewayNextOriginACL field has a return value, synchronize the latest origin IP ranges to the origin server firewall settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayOriginACLRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayOriginACLResponse"/></returns>
        public DescribeMultiPathGatewayOriginACLResponse DescribeMultiPathGatewayOriginACLSync(DescribeMultiPathGatewayOriginACLRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayOriginACLResponse>(req, "DescribeMultiPathGatewayOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the available region list of user-created multi-channel security acceleration gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRegionsRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayRegionsResponse"/></returns>
        public Task<DescribeMultiPathGatewayRegionsResponse> DescribeMultiPathGatewayRegions(DescribeMultiPathGatewayRegionsRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayRegionsResponse>(req, "DescribeMultiPathGatewayRegions");
        }

        /// <summary>
        /// This API is used to query the available region list of user-created multi-channel security acceleration gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRegionsRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayRegionsResponse"/></returns>
        public DescribeMultiPathGatewayRegionsResponse DescribeMultiPathGatewayRegionsSync(DescribeMultiPathGatewayRegionsRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayRegionsResponse>(req, "DescribeMultiPathGatewayRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the key for integrating a multi-channel security acceleration gateway. Customers sign with the integration key to access the multi-channel security acceleration gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<DescribeMultiPathGatewaySecretKeyResponse> DescribeMultiPathGatewaySecretKey(DescribeMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaySecretKeyResponse>(req, "DescribeMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// This API is used to query the key for integrating a multi-channel security acceleration gateway. Customers sign with the integration key to access the multi-channel security acceleration gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaySecretKeyResponse"/></returns>
        public DescribeMultiPathGatewaySecretKeyResponse DescribeMultiPathGatewaySecretKeySync(DescribeMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaySecretKeyResponse>(req, "DescribeMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of user-created multi-channel security acceleration gateways. Pagination is supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaysRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaysResponse"/></returns>
        public Task<DescribeMultiPathGatewaysResponse> DescribeMultiPathGateways(DescribeMultiPathGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaysResponse>(req, "DescribeMultiPathGateways");
        }

        /// <summary>
        /// This API is used to query the list of user-created multi-channel security acceleration gateways. Pagination is supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaysRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaysResponse"/></returns>
        public DescribeMultiPathGatewaysResponse DescribeMultiPathGatewaysSync(DescribeMultiPathGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaysResponse>(req, "DescribeMultiPathGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the binding relationship between L7 acceleration domains/L4 proxy instances and origin IP ranges under a site, as well as origin IP range details. If you want to periodically get the latest version of origin IP ranges through an automation script, you can poll this API at a low frequency (once every three days is recommended). If the NextOriginACL field has a return value, synchronize the latest origin IP ranges to the origin server firewall configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginACLRequest"/></param>
        /// <returns><see cref="DescribeOriginACLResponse"/></returns>
        public Task<DescribeOriginACLResponse> DescribeOriginACL(DescribeOriginACLRequest req)
        {
            return InternalRequestAsync<DescribeOriginACLResponse>(req, "DescribeOriginACL");
        }

        /// <summary>
        /// This API is used to query the binding relationship between L7 acceleration domains/L4 proxy instances and origin IP ranges under a site, as well as origin IP range details. If you want to periodically get the latest version of origin IP ranges through an automation script, you can poll this API at a low frequency (once every three days is recommended). If the NextOriginACL field has a return value, synchronize the latest origin IP ranges to the origin server firewall configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginACLRequest"/></param>
        /// <returns><see cref="DescribeOriginACLResponse"/></returns>
        public DescribeOriginACLResponse DescribeOriginACLSync(DescribeOriginACLRequest req)
        {
            return InternalRequestAsync<DescribeOriginACLResponse>(req, "DescribeOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the origin server group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public Task<DescribeOriginGroupResponse> DescribeOriginGroup(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup");
        }

        /// <summary>
        /// This API is used to query the origin server group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public DescribeOriginGroupResponse DescribeOriginGroupSync(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the health status of origin server groups under a load balancing instance. The load balancer feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupHealthStatusResponse"/></returns>
        public Task<DescribeOriginGroupHealthStatusResponse> DescribeOriginGroupHealthStatus(DescribeOriginGroupHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupHealthStatusResponse>(req, "DescribeOriginGroupHealthStatus");
        }

        /// <summary>
        /// This API is used to query the health status of origin server groups under a load balancing instance. The load balancer feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupHealthStatusResponse"/></returns>
        public DescribeOriginGroupHealthStatusResponse DescribeOriginGroupHealthStatusSync(DescribeOriginGroupHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupHealthStatusResponse>(req, "DescribeOriginGroupHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version for origin protection queries. EdgeOne comprehensively upgraded the origin protection APIs on June 27, 2025. For details on the new version of the origin protection query API, refer to [DescribeOriginACL](https://www.tencentcloud.com/document/product/1552/120408?from_cn_redirect=1).
        /// 
        /// <p style="color: red;">Note: Starting from June 27, 2025, earlier version APIs will stop update and iteration, and new features will only be provided in the new version of APIs. To avoid data field conflicts when using earlier version APIs, migrate to the new version of origin protection APIs as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public Task<DescribeOriginProtectionResponse> DescribeOriginProtection(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection");
        }

        /// <summary>
        /// This API is on an earlier version for origin protection queries. EdgeOne comprehensively upgraded the origin protection APIs on June 27, 2025. For details on the new version of the origin protection query API, refer to [DescribeOriginACL](https://www.tencentcloud.com/document/product/1552/120408?from_cn_redirect=1).
        /// 
        /// <p style="color: red;">Note: Starting from June 27, 2025, earlier version APIs will stop update and iteration, and new features will only be provided in the new version of APIs. To avoid data field conflicts when using earlier version APIs, migrate to the new version of origin protection APIs as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public DescribeOriginProtectionResponse DescribeOriginProtectionSync(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query layer-7 monitoring time series traffic Data. This API is to be deprecated. Please use the <a href="https://www.tencentcloud.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a> API.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public Task<DescribeOverviewL7DataResponse> DescribeOverviewL7Data(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data");
        }

        /// <summary>
        /// This API is used to query layer-7 monitoring time series traffic Data. This API is to be deprecated. Please use the <a href="https://www.tencentcloud.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a> API.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public DescribeOverviewL7DataResponse DescribeOverviewL7DataSync(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the package information list with pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribePlansRequest"/></param>
        /// <returns><see cref="DescribePlansResponse"/></returns>
        public Task<DescribePlansResponse> DescribePlans(DescribePlansRequest req)
        {
            return InternalRequestAsync<DescribePlansResponse>(req, "DescribePlans");
        }

        /// <summary>
        /// Query the package information list with pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribePlansRequest"/></param>
        /// <returns><see cref="DescribePlansResponse"/></returns>
        public DescribePlansResponse DescribePlansSync(DescribePlansRequest req)
        {
            return InternalRequestAsync<DescribePlansResponse>(req, "DescribePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query origin-pull rate limits. This feature is in beta test for allowlisted users.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchOriginLimitRequest"/></param>
        /// <returns><see cref="DescribePrefetchOriginLimitResponse"/></returns>
        public Task<DescribePrefetchOriginLimitResponse> DescribePrefetchOriginLimit(DescribePrefetchOriginLimitRequest req)
        {
            return InternalRequestAsync<DescribePrefetchOriginLimitResponse>(req, "DescribePrefetchOriginLimit");
        }

        /// <summary>
        /// This API is used to query origin-pull rate limits. This feature is in beta test for allowlisted users.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchOriginLimitRequest"/></param>
        /// <returns><see cref="DescribePrefetchOriginLimitResponse"/></returns>
        public DescribePrefetchOriginLimitResponse DescribePrefetchOriginLimitSync(DescribePrefetchOriginLimitRequest req)
        {
            return InternalRequestAsync<DescribePrefetchOriginLimitResponse>(req, "DescribePrefetchOriginLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the commit history and execution progress of preheating tasks. Tasks submitted via the CreatePrefetchTasks API can be queried through this API.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public Task<DescribePrefetchTasksResponse> DescribePrefetchTasks(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks");
        }

        /// <summary>
        /// This API is used to query the commit history and execution progress of preheating tasks. Tasks submitted via the CreatePrefetchTasks API can be queried through this API.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public DescribePrefetchTasksResponse DescribePrefetchTasksSync(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query submitted URL refresh and directory refresh records and task progress. All tasks submitted via the CreatePurgeTasks API can be queried through this API.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// This API is used to query submitted URL refresh and directory refresh records and task progress. All tasks submitted via the CreatePurgeTasks API can be queried through this API.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time log delivery task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeLogDeliveryTasksRequest"/></param>
        /// <returns><see cref="DescribeRealtimeLogDeliveryTasksResponse"/></returns>
        public Task<DescribeRealtimeLogDeliveryTasksResponse> DescribeRealtimeLogDeliveryTasks(DescribeRealtimeLogDeliveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeRealtimeLogDeliveryTasksResponse>(req, "DescribeRealtimeLogDeliveryTasks");
        }

        /// <summary>
        /// This API is used to query real-time log delivery task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeLogDeliveryTasksRequest"/></param>
        /// <returns><see cref="DescribeRealtimeLogDeliveryTasksResponse"/></returns>
        public DescribeRealtimeLogDeliveryTasksResponse DescribeRealtimeLogDeliveryTasksSync(DescribeRealtimeLogDeliveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeRealtimeLogDeliveryTasksResponse>(req, "DescribeRealtimeLogDeliveryTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version for querying rule engine rules. EdgeOne comprehensively upgraded the rule engine APIs on January 21, 2025. For details on the new version API for querying L7 acceleration rules, see [DescribeL7AccRules](https://www.tencentcloud.com/document/product/1552/115820?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the legacy version API will stop update and iteration. New features will only be provided in the new version API. The existing capacity supported by the legacy version API will not be affected. To avoid data field conflicts when using the legacy version API, migrate to the new version rule engine API as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// This API is on an earlier version for querying rule engine rules. EdgeOne comprehensively upgraded the rule engine APIs on January 21, 2025. For details on the new version API for querying L7 acceleration rules, see [DescribeL7AccRules](https://www.tencentcloud.com/document/product/1552/115820?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the legacy version API will stop update and iteration. New features will only be provided in the new version API. The existing capacity supported by the legacy version API will not be affected. To avoid data field conflicts when using the legacy version API, migrate to the new version rule engine API as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. For details, see [RuleEngineAction](https://www.tencentcloud.com/document/product/1552/80721?from_cn_redirect=1#RuleEngineAction).
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public Task<DescribeRulesSettingResponse> DescribeRulesSetting(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting");
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. For details, see [RuleEngineAction](https://www.tencentcloud.com/document/product/1552/80721?from_cn_redirect=1#RuleEngineAction).
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public DescribeRulesSettingResponse DescribeRulesSettingSync(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query API resources under a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIResourceResponse"/></returns>
        public Task<DescribeSecurityAPIResourceResponse> DescribeSecurityAPIResource(DescribeSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIResourceResponse>(req, "DescribeSecurityAPIResource");
        }

        /// <summary>
        /// Query API resources under a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIResourceResponse"/></returns>
        public DescribeSecurityAPIResourceResponse DescribeSecurityAPIResourceSync(DescribeSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIResourceResponse>(req, "DescribeSecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query API services under a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIServiceResponse"/></returns>
        public Task<DescribeSecurityAPIServiceResponse> DescribeSecurityAPIService(DescribeSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIServiceResponse>(req, "DescribeSecurityAPIService");
        }

        /// <summary>
        /// Query API services under a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIServiceResponse"/></returns>
        public DescribeSecurityAPIServiceResponse DescribeSecurityAPIServiceSync(DescribeSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIServiceResponse>(req, "DescribeSecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query client authentication option configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DescribeSecurityClientAttesterResponse"/></returns>
        public Task<DescribeSecurityClientAttesterResponse> DescribeSecurityClientAttester(DescribeSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DescribeSecurityClientAttesterResponse>(req, "DescribeSecurityClientAttester");
        }

        /// <summary>
        /// Query client authentication option configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DescribeSecurityClientAttesterResponse"/></returns>
        public DescribeSecurityClientAttesterResponse DescribeSecurityClientAttesterSync(DescribeSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DescribeSecurityClientAttesterResponse>(req, "DescribeSecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration information of a security IP group, including its ID, name, and content. In the query result of this API, each IP group returns up to 2,000 IPs or CIDR blocks. If an ultra-large IP group exceeds 2,000 IPs or CIDR blocks, call DescribeSecurityIPGroupContent for paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public Task<DescribeSecurityIPGroupResponse> DescribeSecurityIPGroup(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup");
        }

        /// <summary>
        /// This API is used to query the configuration information of a security IP group, including its ID, name, and content. In the query result of this API, each IP group returns up to 2,000 IPs or CIDR blocks. If an ultra-large IP group exceeds 2,000 IPs or CIDR blocks, call DescribeSecurityIPGroupContent for paging query.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public DescribeSecurityIPGroupResponse DescribeSecurityIPGroupSync(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the IP address list in a specified IP group by page. When the number of IP addresses in an IP group exceeds 2000, you can use this API to perform a paging query to obtain the complete IP address list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupContentRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupContentResponse"/></returns>
        public Task<DescribeSecurityIPGroupContentResponse> DescribeSecurityIPGroupContent(DescribeSecurityIPGroupContentRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupContentResponse>(req, "DescribeSecurityIPGroupContent");
        }

        /// <summary>
        /// This API is used to query the IP address list in a specified IP group by page. When the number of IP addresses in an IP group exceeds 2000, you can use this API to perform a paging query to obtain the complete IP address list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupContentRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupContentResponse"/></returns>
        public DescribeSecurityIPGroupContentResponse DescribeSecurityIPGroupContentSync(DescribeSecurityIPGroupContentRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupContentResponse>(req, "DescribeSecurityIPGroupContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is deprecated and will be discontinued on June 30, 2024. Please use the API for querying security IP groups.
        /// ](https://www.tencentcloud.com/document/product/1552/105866?from_cn_redirect=1).
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
        /// This API is deprecated and will be discontinued on June 30, 2024. Please use the API for querying security IP groups.
        /// ](https://www.tencentcloud.com/document/product/1552/105866?from_cn_redirect=1).
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
        /// This API is used to query JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityJSInjectionRuleResponse"/></returns>
        public Task<DescribeSecurityJSInjectionRuleResponse> DescribeSecurityJSInjectionRule(DescribeSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityJSInjectionRuleResponse>(req, "DescribeSecurityJSInjectionRule");
        }

        /// <summary>
        /// This API is used to query JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityJSInjectionRuleResponse"/></returns>
        public DescribeSecurityJSInjectionRuleResponse DescribeSecurityJSInjectionRuleSync(DescribeSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityJSInjectionRuleResponse>(req, "DescribeSecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query security protection configuration details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicy(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy");
        }

        /// <summary>
        /// Query security protection configuration details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public DescribeSecurityPolicyResponse DescribeSecurityPolicySync(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the binding relationship list of a specified policy template.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTemplateBindingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTemplateBindingsResponse"/></returns>
        public Task<DescribeSecurityTemplateBindingsResponse> DescribeSecurityTemplateBindings(DescribeSecurityTemplateBindingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTemplateBindingsResponse>(req, "DescribeSecurityTemplateBindings");
        }

        /// <summary>
        /// This API is used to query the binding relationship list of a specified policy template.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTemplateBindingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTemplateBindingsResponse"/></returns>
        public DescribeSecurityTemplateBindingsResponse DescribeSecurityTemplateBindingsSync(DescribeSecurityTemplateBindingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTemplateBindingsResponse>(req, "DescribeSecurityTemplateBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the shared CNAME list, supporting fuzzy search, pagination, and sorting.
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedCNAMERequest"/></param>
        /// <returns><see cref="DescribeSharedCNAMEResponse"/></returns>
        public Task<DescribeSharedCNAMEResponse> DescribeSharedCNAME(DescribeSharedCNAMERequest req)
        {
            return InternalRequestAsync<DescribeSharedCNAMEResponse>(req, "DescribeSharedCNAME");
        }

        /// <summary>
        /// This API is used to query the shared CNAME list, supporting fuzzy search, pagination, and sorting.
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedCNAMERequest"/></param>
        /// <returns><see cref="DescribeSharedCNAMEResponse"/></returns>
        public DescribeSharedCNAMEResponse DescribeSharedCNAMESync(DescribeSharedCNAMERequest req)
        {
            return InternalRequestAsync<DescribeSharedCNAMEResponse>(req, "DescribeSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the time series data of edge function analysis. Note that the data queried by this API has a delay of about 10 minutes. It is recommended to pull data from at least 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingFunctionAnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingFunctionAnalysisDataResponse"/></returns>
        public Task<DescribeTimingFunctionAnalysisDataResponse> DescribeTimingFunctionAnalysisData(DescribeTimingFunctionAnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingFunctionAnalysisDataResponse>(req, "DescribeTimingFunctionAnalysisData");
        }

        /// <summary>
        /// This API is used to query the time series data of edge function analysis. Note that the data queried by this API has a delay of about 10 minutes. It is recommended to pull data from at least 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingFunctionAnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingFunctionAnalysisDataResponse"/></returns>
        public DescribeTimingFunctionAnalysisDataResponse DescribeTimingFunctionAnalysisDataSync(DescribeTimingFunctionAnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingFunctionAnalysisDataResponse>(req, "DescribeTimingFunctionAnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>This API is used to query the L4 time series Data list.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public Task<DescribeTimingL4DataResponse> DescribeTimingL4Data(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data");
        }

        /// <summary>
        /// <p>This API is used to query the L4 time series Data list.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public DescribeTimingL4DataResponse DescribeTimingL4DataSync(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query time series data of the L7 domain name business.
        /// Note:
        /// 1. This API queries data with a delay of about 10 minutes. It is advisable to pull data from 10 minutes before the current time.
        /// 2. This interface returns post-protection traffic request data by default. Users can use `Filters.mitigatedByWebSecurity` to custom query defended data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData");
        }

        /// <summary>
        /// This API is used to query time series data of the L7 domain name business.
        /// Note:
        /// 1. This API queries data with a delay of about 10 minutes. It is advisable to pull data from 10 minutes before the current time.
        /// 2. This interface returns post-protection traffic request data by default. Users can use `Filters.mitigatedByWebSecurity` to custom query defended data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query L7 cache analysis time series traffic data. This API is to be deprecated. Please use the <a href="https://www.tencentcloud.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a> API.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData");
        }

        /// <summary>
        /// This API is used to query L7 cache analysis time series traffic data. This API is to be deprecated. Please use the <a href="https://www.tencentcloud.com/document/product/1552/80648?from_cn_redirect=1">DescribeTimingL7AnalysisData</a> API.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the origin-pull time series data of an L7 domain.
        /// You can choose to group queries by specifying the query dimension <code>DimensionName</code>, which returns multiple groups of time series data. For detailed directions and usage limits, see [How to Use APIs to Implement Group Query in a Single Call](https://www.tencentcloud.com/document/product/1552/127501?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7OriginPullDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7OriginPullDataResponse"/></returns>
        public Task<DescribeTimingL7OriginPullDataResponse> DescribeTimingL7OriginPullData(DescribeTimingL7OriginPullDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7OriginPullDataResponse>(req, "DescribeTimingL7OriginPullData");
        }

        /// <summary>
        /// This API is used to query the origin-pull time series data of an L7 domain.
        /// You can choose to group queries by specifying the query dimension <code>DimensionName</code>, which returns multiple groups of time series data. For detailed directions and usage limits, see [How to Use APIs to Implement Group Query in a Single Call](https://www.tencentcloud.com/document/product/1552/127501?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7OriginPullDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7OriginPullDataResponse"/></returns>
        public DescribeTimingL7OriginPullDataResponse DescribeTimingL7OriginPullDataSync(DescribeTimingL7OriginPullDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7OriginPullDataResponse>(req, "DescribeTimingL7OriginPullData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the topN data of Edge Functions by a specified dimension. Note that the data returned by this API has a delay of about 10 minutes. We recommend that you query the data generated at least 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopFunctionAnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopFunctionAnalysisDataResponse"/></returns>
        public Task<DescribeTopFunctionAnalysisDataResponse> DescribeTopFunctionAnalysisData(DescribeTopFunctionAnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopFunctionAnalysisDataResponse>(req, "DescribeTopFunctionAnalysisData");
        }

        /// <summary>
        /// This API is used to query the topN data of Edge Functions by a specified dimension. Note that the data returned by this API has a delay of about 10 minutes. We recommend that you query the data generated at least 10 minutes before the current time.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopFunctionAnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopFunctionAnalysisDataResponse"/></returns>
        public DescribeTopFunctionAnalysisDataResponse DescribeTopFunctionAnalysisDataSync(DescribeTopFunctionAnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopFunctionAnalysisDataResponse>(req, "DescribeTopFunctionAnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top N data of the L7 domain name business by specified dimension.
        /// Note:
        /// 1. This API queries data with a delay of about 10 minutes. It is recommended to pull data from 10 minutes before the current time.
        /// 2. This interface returns post-protection traffic request data by default. Users can use `Filters.mitigatedByWebSecurity` to custom query defended data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData");
        }

        /// <summary>
        /// This API is used to query the top N data of the L7 domain name business by specified dimension.
        /// Note:
        /// 1. This API queries data with a delay of about 10 minutes. It is recommended to pull data from 10 minutes before the current time.
        /// 2. This interface returns post-protection traffic request data by default. Users can use `Filters.mitigatedByWebSecurity` to custom query defended data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query L7 cache analysis topN data. This API is to be deprecated. Please use the <a href="https://www.tencentcloud.com/document/product/1552/80646?from_cn_redirect=1"> DescribeTopL7AnalysisData</a> API.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData");
        }

        /// <summary>
        /// This API is used to query L7 cache analysis topN data. This API is to be deprecated. Please use the <a href="https://www.tencentcloud.com/document/product/1552/80646?from_cn_redirect=1"> DescribeTopL7AnalysisData</a> API.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries security policy configuration template details
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplateResponse"/></returns>
        public Task<DescribeWebSecurityTemplateResponse> DescribeWebSecurityTemplate(DescribeWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplateResponse>(req, "DescribeWebSecurityTemplate");
        }

        /// <summary>
        /// Queries security policy configuration template details
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplateResponse"/></returns>
        public DescribeWebSecurityTemplateResponse DescribeWebSecurityTemplateSync(DescribeWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplateResponse>(req, "DescribeWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the security policy configuration template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplatesResponse"/></returns>
        public Task<DescribeWebSecurityTemplatesResponse> DescribeWebSecurityTemplates(DescribeWebSecurityTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplatesResponse>(req, "DescribeWebSecurityTemplates");
        }

        /// <summary>
        /// Queries the security policy configuration template list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplatesResponse"/></returns>
        public DescribeWebSecurityTemplatesResponse DescribeWebSecurityTemplatesSync(DescribeWebSecurityTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplatesResponse>(req, "DescribeWebSecurityTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the results of site configuration item import via the site configuration import API.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneConfigImportResultRequest"/></param>
        /// <returns><see cref="DescribeZoneConfigImportResultResponse"/></returns>
        public Task<DescribeZoneConfigImportResultResponse> DescribeZoneConfigImportResult(DescribeZoneConfigImportResultRequest req)
        {
            return InternalRequestAsync<DescribeZoneConfigImportResultResponse>(req, "DescribeZoneConfigImportResult");
        }

        /// <summary>
        /// This API is used to query the results of site configuration item import via the site configuration import API.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneConfigImportResultRequest"/></param>
        /// <returns><see cref="DescribeZoneConfigImportResultResponse"/></returns>
        public DescribeZoneConfigImportResultResponse DescribeZoneConfigImportResultSync(DescribeZoneConfigImportResultRequest req)
        {
            return InternalRequestAsync<DescribeZoneConfigImportResultResponse>(req, "DescribeZoneConfigImportResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query site-level custom variable configurations, including variable definitions and variable operations. If not configured, both variable definitions and variable operations return empty lists.
        /// 
        /// If needed, call the DescribeL7AccRules API to query rule-level custom variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneCustomVariablesRequest"/></param>
        /// <returns><see cref="DescribeZoneCustomVariablesResponse"/></returns>
        public Task<DescribeZoneCustomVariablesResponse> DescribeZoneCustomVariables(DescribeZoneCustomVariablesRequest req)
        {
            return InternalRequestAsync<DescribeZoneCustomVariablesResponse>(req, "DescribeZoneCustomVariables");
        }

        /// <summary>
        /// This API is used to query site-level custom variable configurations, including variable definitions and variable operations. If not configured, both variable definitions and variable operations return empty lists.
        /// 
        /// If needed, call the DescribeL7AccRules API to query rule-level custom variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneCustomVariablesRequest"/></param>
        /// <returns><see cref="DescribeZoneCustomVariablesResponse"/></returns>
        public DescribeZoneCustomVariablesResponse DescribeZoneCustomVariablesSync(DescribeZoneCustomVariablesRequest req)
        {
            return InternalRequestAsync<DescribeZoneCustomVariablesResponse>(req, "DescribeZoneCustomVariables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. For details, see [DescribeL7AccSetting](https://www.tencentcloud.com/document/product/1552/115819?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting");
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. For details, see [DescribeL7AccSetting](https://www.tencentcloud.com/document/product/1552/115819?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public DescribeZoneSettingResponse DescribeZoneSettingSync(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query site information you have permission to access. You can filter sites based on different query conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query site information you have permission to access. You can filter sites based on different query conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a billing plan when you need to stop billing for an Edgeone plan.
        /// > The following conditions must be met to terminate a billing plan:
        /// 1. The plan has expired (except for the Enterprise Edition Plan);
        /// 2. All sites under the package have been shut down or deleted.
        /// 
        /// > The site status can be queried through the [Query Site List](https://www.tencentcloud.com/document/product/1552/80713?from_cn_redirect=1) interface.
        /// A site can be deactivated by switching the site to a closed status through the [Switch Site Status](https://www.tencentcloud.com/document/product/1552/80707?from_cn_redirect=1) interface.
        /// A site can be deleted by using the Delete Site API.
        /// </summary>
        /// <param name="req"><see cref="DestroyPlanRequest"/></param>
        /// <returns><see cref="DestroyPlanResponse"/></returns>
        public Task<DestroyPlanResponse> DestroyPlan(DestroyPlanRequest req)
        {
            return InternalRequestAsync<DestroyPlanResponse>(req, "DestroyPlan");
        }

        /// <summary>
        /// This API is used to terminate a billing plan when you need to stop billing for an Edgeone plan.
        /// > The following conditions must be met to terminate a billing plan:
        /// 1. The plan has expired (except for the Enterprise Edition Plan);
        /// 2. All sites under the package have been shut down or deleted.
        /// 
        /// > The site status can be queried through the [Query Site List](https://www.tencentcloud.com/document/product/1552/80713?from_cn_redirect=1) interface.
        /// A site can be deactivated by switching the site to a closed status through the [Switch Site Status](https://www.tencentcloud.com/document/product/1552/80707?from_cn_redirect=1) interface.
        /// A site can be deleted by using the Delete Site API.
        /// </summary>
        /// <param name="req"><see cref="DestroyPlanRequest"/></param>
        /// <returns><see cref="DestroyPlanResponse"/></returns>
        public DestroyPlanResponse DestroyPlanSync(DestroyPlanRequest req)
        {
            return InternalRequestAsync<DestroyPlanResponse>(req, "DestroyPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable origin protection for a site. Once disabled, resources related to the origin will no longer use only the origin IP range provided by origin protection to request your origin, and update notifications on origin IP ranges will stop simultaneously.
        /// </summary>
        /// <param name="req"><see cref="DisableOriginACLRequest"/></param>
        /// <returns><see cref="DisableOriginACLResponse"/></returns>
        public Task<DisableOriginACLResponse> DisableOriginACL(DisableOriginACLRequest req)
        {
            return InternalRequestAsync<DisableOriginACLResponse>(req, "DisableOriginACL");
        }

        /// <summary>
        /// This API is used to disable origin protection for a site. Once disabled, resources related to the origin will no longer use only the origin IP range provided by origin protection to request your origin, and update notifications on origin IP ranges will stop simultaneously.
        /// </summary>
        /// <param name="req"><see cref="DisableOriginACLRequest"/></param>
        /// <returns><see cref="DisableOriginACLResponse"/></returns>
        public DisableOriginACLResponse DisableOriginACLSync(DisableOriginACLRequest req)
        {
            return InternalRequestAsync<DisableOriginACLResponse>(req, "DisableOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the offline log download link for a Layer 4 proxy business.
        /// **Note:** EO stores offline logs and provides a download service only when the offline log feature is enabled. For specific features, see the [document](https://www.tencentcloud.com/document/product/1552/73660?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public Task<DownloadL4LogsResponse> DownloadL4Logs(DownloadL4LogsRequest req)
        {
            return InternalRequestAsync<DownloadL4LogsResponse>(req, "DownloadL4Logs");
        }

        /// <summary>
        /// This API is used to obtain the offline log download link for a Layer 4 proxy business.
        /// **Note:** EO stores offline logs and provides a download service only when the offline log feature is enabled. For specific features, see the [document](https://www.tencentcloud.com/document/product/1552/73660?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public DownloadL4LogsResponse DownloadL4LogsSync(DownloadL4LogsRequest req)
        {
            return InternalRequestAsync<DownloadL4LogsResponse>(req, "DownloadL4Logs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the offline log download link for an L7 domain.
        /// **Note:** EO stores offline logs and provides a download service only when the offline log feature is enabled. For specific features, see the [document](https://www.tencentcloud.com/document/product/1552/73660?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public Task<DownloadL7LogsResponse> DownloadL7Logs(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs");
        }

        /// <summary>
        /// This API is used to obtain the offline log download link for an L7 domain.
        /// **Note:** EO stores offline logs and provides a download service only when the offline log feature is enabled. For specific features, see the [document](https://www.tencentcloud.com/document/product/1552/73660?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public DownloadL7LogsResponse DownloadL7LogsSync(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to define the structure of a complete site configuration for reference only. Note: This API does not return actual data.
        /// </summary>
        /// <param name="req"><see cref="DummyParseZoneFullConfigRequest"/></param>
        /// <returns><see cref="DummyParseZoneFullConfigResponse"/></returns>
        public Task<DummyParseZoneFullConfigResponse> DummyParseZoneFullConfig(DummyParseZoneFullConfigRequest req)
        {
            return InternalRequestAsync<DummyParseZoneFullConfigResponse>(req, "DummyParseZoneFullConfig");
        }

        /// <summary>
        /// This API is used to define the structure of a complete site configuration for reference only. Note: This API does not return actual data.
        /// </summary>
        /// <param name="req"><see cref="DummyParseZoneFullConfigRequest"/></param>
        /// <returns><see cref="DummyParseZoneFullConfigResponse"/></returns>
        public DummyParseZoneFullConfigResponse DummyParseZoneFullConfigSync(DummyParseZoneFullConfigRequest req)
        {
            return InternalRequestAsync<DummyParseZoneFullConfigResponse>(req, "DummyParseZoneFullConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more key-value pair data in a specified namespace. Batch deletion supported. Data cannot be recovered after deletion.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVDeleteRequest"/></param>
        /// <returns><see cref="EdgeKVDeleteResponse"/></returns>
        public Task<EdgeKVDeleteResponse> EdgeKVDelete(EdgeKVDeleteRequest req)
        {
            return InternalRequestAsync<EdgeKVDeleteResponse>(req, "EdgeKVDelete");
        }

        /// <summary>
        /// This API is used to delete one or more key-value pair data in a specified namespace. Batch deletion supported. Data cannot be recovered after deletion.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVDeleteRequest"/></param>
        /// <returns><see cref="EdgeKVDeleteResponse"/></returns>
        public EdgeKVDeleteResponse EdgeKVDeleteSync(EdgeKVDeleteRequest req)
        {
            return InternalRequestAsync<EdgeKVDeleteResponse>(req, "EdgeKVDelete")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch read key values from a specified namespace. It supports querying up to 20 keys in a single query.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVGetRequest"/></param>
        /// <returns><see cref="EdgeKVGetResponse"/></returns>
        public Task<EdgeKVGetResponse> EdgeKVGet(EdgeKVGetRequest req)
        {
            return InternalRequestAsync<EdgeKVGetResponse>(req, "EdgeKVGet");
        }

        /// <summary>
        /// This API is used to batch read key values from a specified namespace. It supports querying up to 20 keys in a single query.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVGetRequest"/></param>
        /// <returns><see cref="EdgeKVGetResponse"/></returns>
        public EdgeKVGetResponse EdgeKVGetSync(EdgeKVGetRequest req)
        {
            return InternalRequestAsync<EdgeKVGetResponse>(req, "EdgeKVGet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all keys in the specified namespace, with prefix filtering supported. Cursor-based traversal is implemented, and the next cursor is returned for continued querying. It is suitable for traversing all keys in a namespace.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVListRequest"/></param>
        /// <returns><see cref="EdgeKVListResponse"/></returns>
        public Task<EdgeKVListResponse> EdgeKVList(EdgeKVListRequest req)
        {
            return InternalRequestAsync<EdgeKVListResponse>(req, "EdgeKVList");
        }

        /// <summary>
        /// This API is used to list all keys in the specified namespace, with prefix filtering supported. Cursor-based traversal is implemented, and the next cursor is returned for continued querying. It is suitable for traversing all keys in a namespace.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVListRequest"/></param>
        /// <returns><see cref="EdgeKVListResponse"/></returns>
        public EdgeKVListResponse EdgeKVListSync(EdgeKVListRequest req)
        {
            return InternalRequestAsync<EdgeKVListResponse>(req, "EdgeKVList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to write key-value pair data to a specified namespace, with support for setting expiration time. If the key already exists, the original value is overwritten. If not, a new key-value pair is created.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVPutRequest"/></param>
        /// <returns><see cref="EdgeKVPutResponse"/></returns>
        public Task<EdgeKVPutResponse> EdgeKVPut(EdgeKVPutRequest req)
        {
            return InternalRequestAsync<EdgeKVPutResponse>(req, "EdgeKVPut");
        }

        /// <summary>
        /// This API is used to write key-value pair data to a specified namespace, with support for setting expiration time. If the key already exists, the original value is overwritten. If not, a new key-value pair is created.
        /// </summary>
        /// <param name="req"><see cref="EdgeKVPutRequest"/></param>
        /// <returns><see cref="EdgeKVPutResponse"/></returns>
        public EdgeKVPutResponse EdgeKVPutSync(EdgeKVPutRequest req)
        {
            return InternalRequestAsync<EdgeKVPutResponse>(req, "EdgeKVPut")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable origin protection for a site for the first time. After it is enabled, EdgeOne will use specific origin-pull IP ranges to pull from the origin for layer-7 acceleration domains/layer-4 proxy instances.
        /// This API supports two modes: **Automatic Protection Mode** and **Specified Protection Mode**. <li>When **Automatic Protection Mode** is used (L7EnableMode/L4EnableMode is set to all), the acceleration domain list and layer-4 proxy instances under the site will be automatically added to the origin protection list in real time without manual intervention;</li><li>When **Specified Protection Mode** is used (L7EnableMode/L4EnableMode is set to specific), you need to manually specify the resources to be added to origin protection. Unspecified resources will not be added to the origin protection list. If resource adjustment is required, you need to actively call the ModifyOriginACL API to make adjustments.</li>
        /// 
        /// Instructions for using the Specified Protection Mode:
        /// <li>The maximum number of layer-7 acceleration domains that can be submitted at a time is 200, and the maximum number of layer-4 proxy instances is 100. Mixed submission of layer-7 acceleration domains/layer-4 proxy instances is supported, with a maximum total of 200 instances;</li>
        /// <li>When more than 200 resources need to be enabled, you need to first configure the resources of the first shard through this API, and then configure the remaining shards through the ModifyOriginACL API. For example, if 500 layer-7 acceleration domains need to be added, first use this API to set 200 domains, and then use the ModifyOriginACL API to configure the remaining 300 domains in two batches, with no more than 200 domains per batch.</li>
        /// 
        /// Note:
        /// - When enabling, accounts on the allowlist can select other origin-pull IP range versions, such as the simplified version, to achieve the effect of pulling from the origin with fewer IP ranges.
        /// - Calling this API is deemed as your agreement to the [Special Agreement on Enabling Origin Protection](https://www.tencentcloud.com/document/product/1552/120141?from_cn_redirect=1);
        /// - Origin-pull IP ranges are subject to change from time to time. EdgeOne will send notifications 14 days, 7 days, 3 days, and 1 day before the change through one or more methods such as in-site messages, SMS, and emails. To ensure that you can receive notifications of origin-pull IP range changes, make sure that you have selected message notifications related to the EdgeOne product in the [Tencent Cloud Message Center Console](https://console.cloud.tencent.com/message) and configured the correct message recipients. For configuration methods, refer to [Message Subscription Management](https://www.tencentcloud.com/document/product/567/43476?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="EnableOriginACLRequest"/></param>
        /// <returns><see cref="EnableOriginACLResponse"/></returns>
        public Task<EnableOriginACLResponse> EnableOriginACL(EnableOriginACLRequest req)
        {
            return InternalRequestAsync<EnableOriginACLResponse>(req, "EnableOriginACL");
        }

        /// <summary>
        /// This API is used to enable origin protection for a site for the first time. After it is enabled, EdgeOne will use specific origin-pull IP ranges to pull from the origin for layer-7 acceleration domains/layer-4 proxy instances.
        /// This API supports two modes: **Automatic Protection Mode** and **Specified Protection Mode**. <li>When **Automatic Protection Mode** is used (L7EnableMode/L4EnableMode is set to all), the acceleration domain list and layer-4 proxy instances under the site will be automatically added to the origin protection list in real time without manual intervention;</li><li>When **Specified Protection Mode** is used (L7EnableMode/L4EnableMode is set to specific), you need to manually specify the resources to be added to origin protection. Unspecified resources will not be added to the origin protection list. If resource adjustment is required, you need to actively call the ModifyOriginACL API to make adjustments.</li>
        /// 
        /// Instructions for using the Specified Protection Mode:
        /// <li>The maximum number of layer-7 acceleration domains that can be submitted at a time is 200, and the maximum number of layer-4 proxy instances is 100. Mixed submission of layer-7 acceleration domains/layer-4 proxy instances is supported, with a maximum total of 200 instances;</li>
        /// <li>When more than 200 resources need to be enabled, you need to first configure the resources of the first shard through this API, and then configure the remaining shards through the ModifyOriginACL API. For example, if 500 layer-7 acceleration domains need to be added, first use this API to set 200 domains, and then use the ModifyOriginACL API to configure the remaining 300 domains in two batches, with no more than 200 domains per batch.</li>
        /// 
        /// Note:
        /// - When enabling, accounts on the allowlist can select other origin-pull IP range versions, such as the simplified version, to achieve the effect of pulling from the origin with fewer IP ranges.
        /// - Calling this API is deemed as your agreement to the [Special Agreement on Enabling Origin Protection](https://www.tencentcloud.com/document/product/1552/120141?from_cn_redirect=1);
        /// - Origin-pull IP ranges are subject to change from time to time. EdgeOne will send notifications 14 days, 7 days, 3 days, and 1 day before the change through one or more methods such as in-site messages, SMS, and emails. To ensure that you can receive notifications of origin-pull IP range changes, make sure that you have selected message notifications related to the EdgeOne product in the [Tencent Cloud Message Center Console](https://console.cloud.tencent.com/message) and configured the correct message recipients. For configuration methods, refer to [Message Subscription Management](https://www.tencentcloud.com/document/product/567/43476?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="EnableOriginACLRequest"/></param>
        /// <returns><see cref="EnableOriginACLResponse"/></returns>
        public EnableOriginACLResponse EnableOriginACLSync(EnableOriginACLRequest req)
        {
            return InternalRequestAsync<EnableOriginACLResponse>(req, "EnableOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export site configuration by users based on desired configuration items. The exported configuration is used for import via the site configuration import API.
        /// </summary>
        /// <param name="req"><see cref="ExportZoneConfigRequest"/></param>
        /// <returns><see cref="ExportZoneConfigResponse"/></returns>
        public Task<ExportZoneConfigResponse> ExportZoneConfig(ExportZoneConfigRequest req)
        {
            return InternalRequestAsync<ExportZoneConfigResponse>(req, "ExportZoneConfig");
        }

        /// <summary>
        /// This API is used to export site configuration by users based on desired configuration items. The exported configuration is used for import via the site configuration import API.
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
        /// After the environment variables are set, they can be used in the function code and function replica code. For details, see [Edge Functions Referencing Environment Variables](https://www.tencentcloud.com/document/product/1552/109151?from_cn_redirect=1#0151fd9a-8b0e-407b-ae37-54553a60ded6).
        /// </summary>
        /// <param name="req"><see cref="HandleFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="HandleFunctionRuntimeEnvironmentResponse"/></returns>
        public Task<HandleFunctionRuntimeEnvironmentResponse> HandleFunctionRuntimeEnvironment(HandleFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<HandleFunctionRuntimeEnvironmentResponse>(req, "HandleFunctionRuntimeEnvironment");
        }

        /// <summary>
        /// This API is used to operate the runtime environment of an edge function. It supports related settings for environment variables.
        /// After the environment variables are set, they can be used in the function code and function replica code. For details, see [Edge Functions Referencing Environment Variables](https://www.tencentcloud.com/document/product/1552/109151?from_cn_redirect=1#0151fd9a-8b0e-407b-ae37-54553a60ded6).
        /// </summary>
        /// <param name="req"><see cref="HandleFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="HandleFunctionRuntimeEnvironmentResponse"/></returns>
        public HandleFunctionRuntimeEnvironmentResponse HandleFunctionRuntimeEnvironmentSync(HandleFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<HandleFunctionRuntimeEnvironmentResponse>(req, "HandleFunctionRuntimeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to verify site ownership.
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public Task<IdentifyZoneResponse> IdentifyZone(IdentifyZoneRequest req)
        {
            return InternalRequestAsync<IdentifyZoneResponse>(req, "IdentifyZone");
        }

        /// <summary>
        /// Used to verify site ownership.
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public IdentifyZoneResponse IdentifyZoneSync(IdentifyZoneRequest req)
        {
            return InternalRequestAsync<IdentifyZoneResponse>(req, "IdentifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to quickly import site configuration files. After the import is initiated, the API will return the corresponding task ID (TaskId). Users need to use the site configuration import result query API to obtain the results of this import task.
        /// </summary>
        /// <param name="req"><see cref="ImportZoneConfigRequest"/></param>
        /// <returns><see cref="ImportZoneConfigResponse"/></returns>
        public Task<ImportZoneConfigResponse> ImportZoneConfig(ImportZoneConfigRequest req)
        {
            return InternalRequestAsync<ImportZoneConfigResponse>(req, "ImportZoneConfig");
        }

        /// <summary>
        /// This API is used to quickly import site configuration files. After the import is initiated, the API will return the corresponding task ID (TaskId). Users need to use the site configuration import result query API to obtain the results of this import task.
        /// </summary>
        /// <param name="req"><see cref="ImportZoneConfigRequest"/></param>
        /// <returns><see cref="ImportZoneConfigResponse"/></returns>
        public ImportZoneConfigResponse ImportZoneConfigSync(ImportZoneConfigRequest req)
        {
            return InternalRequestAsync<ImportZoneConfigResponse>(req, "ImportZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase additional quotas when the number of sites bound to your plan, the number of rules under "Web Protection - Custom Rules - Precision Matching Policy", or the rules under "Web Protection - Rate Limiting - Precision Rate Limiting Module" reach the plan's quota limit.
        /// > This interface only supports the Enterprise Edition Plan.
        /// </summary>
        /// <param name="req"><see cref="IncreasePlanQuotaRequest"/></param>
        /// <returns><see cref="IncreasePlanQuotaResponse"/></returns>
        public Task<IncreasePlanQuotaResponse> IncreasePlanQuota(IncreasePlanQuotaRequest req)
        {
            return InternalRequestAsync<IncreasePlanQuotaResponse>(req, "IncreasePlanQuota");
        }

        /// <summary>
        /// This API is used to purchase additional quotas when the number of sites bound to your plan, the number of rules under "Web Protection - Custom Rules - Precision Matching Policy", or the rules under "Web Protection - Rate Limiting - Precision Rate Limiting Module" reach the plan's quota limit.
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
        /// Modify acceleration domain name information
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public Task<ModifyAccelerationDomainResponse> ModifyAccelerationDomain(ModifyAccelerationDomainRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainResponse>(req, "ModifyAccelerationDomain");
        }

        /// <summary>
        /// Modify acceleration domain name information
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public ModifyAccelerationDomainResponse ModifyAccelerationDomainSync(ModifyAccelerationDomainRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainResponse>(req, "ModifyAccelerationDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify accelerated domain status
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public Task<ModifyAccelerationDomainStatusesResponse> ModifyAccelerationDomainStatuses(ModifyAccelerationDomainStatusesRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainStatusesResponse>(req, "ModifyAccelerationDomainStatuses");
        }

        /// <summary>
        /// Batch modify accelerated domain status
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public ModifyAccelerationDomainStatusesResponse ModifyAccelerationDomainStatusesSync(ModifyAccelerationDomainStatusesRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainStatusesResponse>(req, "ModifyAccelerationDomainStatuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public Task<ModifyAliasDomainResponse> ModifyAliasDomain(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain");
        }

        /// <summary>
        /// Modify an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public ModifyAliasDomainResponse ModifyAliasDomainSync(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the status of an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public Task<ModifyAliasDomainStatusResponse> ModifyAliasDomainStatus(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus");
        }

        /// <summary>
        /// Modify the status of an alias domain name.
        /// This feature is only supported in the enterprise plan and is currently in beta test. To use it, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public ModifyAliasDomainStatusResponse ModifyAliasDomainStatusSync(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, refer to [Modify Layer 4 Proxy Instance].
        /// ](https://www.tencentcloud.com/document/product/1552/103411?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public Task<ModifyApplicationProxyResponse> ModifyApplicationProxy(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, refer to [Modify Layer 4 Proxy Instance].
        /// ](https://www.tencentcloud.com/document/product/1552/103411?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public ModifyApplicationProxyResponse ModifyApplicationProxySync(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Modifying Layer 4 Proxy Forwarding Rules.
        /// ](https://www.tencentcloud.com/document/product/1552/103410?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public Task<ModifyApplicationProxyRuleResponse> ModifyApplicationProxyRule(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Modifying Layer 4 Proxy Forwarding Rules.
        /// ](https://www.tencentcloud.com/document/product/1552/103410?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public ModifyApplicationProxyRuleResponse ModifyApplicationProxyRuleSync(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Modifying Layer 4 Proxy Forwarding Rule Status.
        /// ](https://www.tencentcloud.com/document/product/1552/103409?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public Task<ModifyApplicationProxyRuleStatusResponse> ModifyApplicationProxyRuleStatus(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see Modifying Layer 4 Proxy Forwarding Rule Status.
        /// ](https://www.tencentcloud.com/document/product/1552/103409?from_cn_redirect=1) .
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public ModifyApplicationProxyRuleStatusResponse ModifyApplicationProxyRuleStatusSync(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see [modify layer 4 proxy instance status](https://www.tencentcloud.com/document/product/1552/103408?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public Task<ModifyApplicationProxyStatusResponse> ModifyApplicationProxyStatus(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus");
        }

        /// <summary>
        /// This API is on an earlier version. If you want to call it, switch to the latest version. For details, see [modify layer 4 proxy instance status](https://www.tencentcloud.com/document/product/1552/103408?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public ModifyApplicationProxyStatusResponse ModifyApplicationProxyStatusSync(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modification content identifier. Only description modification is supported. The feature is open in the allowlist only.
        /// </summary>
        /// <param name="req"><see cref="ModifyContentIdentifierRequest"/></param>
        /// <returns><see cref="ModifyContentIdentifierResponse"/></returns>
        public Task<ModifyContentIdentifierResponse> ModifyContentIdentifier(ModifyContentIdentifierRequest req)
        {
            return InternalRequestAsync<ModifyContentIdentifierResponse>(req, "ModifyContentIdentifier");
        }

        /// <summary>
        /// Modification content identifier. Only description modification is supported. The feature is open in the allowlist only.
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
        /// This API is used to modify the content of a custom group. GroupType cannot be modified after creation. When modifying entries in the group, you can specify replacement, append, or removal operations through GroupItemOperation.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomGroupRequest"/></param>
        /// <returns><see cref="ModifyCustomGroupResponse"/></returns>
        public Task<ModifyCustomGroupResponse> ModifyCustomGroup(ModifyCustomGroupRequest req)
        {
            return InternalRequestAsync<ModifyCustomGroupResponse>(req, "ModifyCustomGroup");
        }

        /// <summary>
        /// This API is used to modify the content of a custom group. GroupType cannot be modified after creation. When modifying entries in the group, you can specify replacement, append, or removal operations through GroupItemOperation.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomGroupRequest"/></param>
        /// <returns><see cref="ModifyCustomGroupResponse"/></returns>
        public ModifyCustomGroupResponse ModifyCustomGroupSync(ModifyCustomGroupRequest req)
        {
            return InternalRequestAsync<ModifyCustomGroupResponse>(req, "ModifyCustomGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify exclusive DDoS protection for a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSProtectionRequest"/></param>
        /// <returns><see cref="ModifyDDoSProtectionResponse"/></returns>
        public Task<ModifyDDoSProtectionResponse> ModifyDDoSProtection(ModifyDDoSProtectionRequest req)
        {
            return InternalRequestAsync<ModifyDDoSProtectionResponse>(req, "ModifyDDoSProtection");
        }

        /// <summary>
        /// Modify exclusive DDoS protection for a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSProtectionRequest"/></param>
        /// <returns><see cref="ModifyDDoSProtectionResponse"/></returns>
        public ModifyDDoSProtectionResponse ModifyDDoSProtectionSync(ModifyDDoSProtectionRequest req)
        {
            return InternalRequestAsync<ModifyDDoSProtectionResponse>(req, "ModifyDDoSProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can use this API to batch modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsResponse"/></returns>
        public Task<ModifyDnsRecordsResponse> ModifyDnsRecords(ModifyDnsRecordsRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsResponse>(req, "ModifyDnsRecords");
        }

        /// <summary>
        /// You can use this API to batch modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsResponse"/></returns>
        public ModifyDnsRecordsResponse ModifyDnsRecordsSync(ModifyDnsRecordsRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsResponse>(req, "ModifyDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// You can use this API to batch modify the status of DNS records and enable or disable records in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsStatusResponse"/></returns>
        public Task<ModifyDnsRecordsStatusResponse> ModifyDnsRecordsStatus(ModifyDnsRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsStatusResponse>(req, "ModifyDnsRecordsStatus");
        }

        /// <summary>
        /// You can use this API to batch modify the status of DNS records and enable or disable records in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsStatusResponse"/></returns>
        public ModifyDnsRecordsStatusResponse ModifyDnsRecordsStatusSync(ModifyDnsRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsStatusResponse>(req, "ModifyDnsRecordsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attribute information of a specified KV namespace. Currently, only namespace description modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeKVNamespaceRequest"/></param>
        /// <returns><see cref="ModifyEdgeKVNamespaceResponse"/></returns>
        public Task<ModifyEdgeKVNamespaceResponse> ModifyEdgeKVNamespace(ModifyEdgeKVNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyEdgeKVNamespaceResponse>(req, "ModifyEdgeKVNamespace");
        }

        /// <summary>
        /// This API is used to modify the attribute information of a specified KV namespace. Currently, only namespace description modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeKVNamespaceRequest"/></param>
        /// <returns><see cref="ModifyEdgeKVNamespaceResponse"/></returns>
        public ModifyEdgeKVNamespaceResponse ModifyEdgeKVNamespaceSync(ModifyEdgeKVNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyEdgeKVNamespaceResponse>(req, "ModifyEdgeKVNamespace")
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
        /// Modify the binding relationship between edge functions and components. Four operation modes are supported: bind, bind-override, unbind, and rebind. Manage function component binding relationships by specifying the operation type and component list.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionComponentBindingsRequest"/></param>
        /// <returns><see cref="ModifyFunctionComponentBindingsResponse"/></returns>
        public Task<ModifyFunctionComponentBindingsResponse> ModifyFunctionComponentBindings(ModifyFunctionComponentBindingsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionComponentBindingsResponse>(req, "ModifyFunctionComponentBindings");
        }

        /// <summary>
        /// Modify the binding relationship between edge functions and components. Four operation modes are supported: bind, bind-override, unbind, and rebind. Manage function component binding relationships by specifying the operation type and component list.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionComponentBindingsRequest"/></param>
        /// <returns><see cref="ModifyFunctionComponentBindingsResponse"/></returns>
        public ModifyFunctionComponentBindingsResponse ModifyFunctionComponentBindingsSync(ModifyFunctionComponentBindingsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionComponentBindingsResponse>(req, "ModifyFunctionComponentBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the content and description of a specified edge function replica.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionReplicaRequest"/></param>
        /// <returns><see cref="ModifyFunctionReplicaResponse"/></returns>
        public Task<ModifyFunctionReplicaResponse> ModifyFunctionReplica(ModifyFunctionReplicaRequest req)
        {
            return InternalRequestAsync<ModifyFunctionReplicaResponse>(req, "ModifyFunctionReplica");
        }

        /// <summary>
        /// This API is used to modify the content and description of a specified edge function replica.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionReplicaRequest"/></param>
        /// <returns><see cref="ModifyFunctionReplicaResponse"/></returns>
        public ModifyFunctionReplicaResponse ModifyFunctionReplicaSync(ModifyFunctionReplicaRequest req)
        {
            return InternalRequestAsync<ModifyFunctionReplicaResponse>(req, "ModifyFunctionReplica")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a trigger rule for an edge function. It supports modifying rule conditions, execution functions, and description. You can first use the DescribeFunctionRules API to get the RuleId of the rule to be modified, then input the modified rule content. The original rule content will be overwritten.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRuleRequest"/></param>
        /// <returns><see cref="ModifyFunctionRuleResponse"/></returns>
        public Task<ModifyFunctionRuleResponse> ModifyFunctionRule(ModifyFunctionRuleRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRuleResponse>(req, "ModifyFunctionRule");
        }

        /// <summary>
        /// This API is used to modify a trigger rule for an edge function. It supports modifying rule conditions, execution functions, and description. You can first use the DescribeFunctionRules API to get the RuleId of the rule to be modified, then input the modified rule content. The original rule content will be overwritten.
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
        /// After domain name creation is completed, you can configure a self-owned certificate for the domain name, or alternatively use the free certificate (https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1) offered by EdgeOne.
        /// If you need to configure a self-owned certificate, upload the certificate to the [SSL certificate console](https://console.cloud.tencent.com/certoverview) first, then import the corresponding certificate ID in this API. For details, see [Deploy self-owned certificates to EdgeOne domain names].
        /// ](https://www.tencentcloud.com/document/product/1552/88874?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public Task<ModifyHostsCertificateResponse> ModifyHostsCertificate(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate");
        }

        /// <summary>
        /// After domain name creation is completed, you can configure a self-owned certificate for the domain name, or alternatively use the free certificate (https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1) offered by EdgeOne.
        /// If you need to configure a self-owned certificate, upload the certificate to the [SSL certificate console](https://console.cloud.tencent.com/certoverview) first, then import the corresponding certificate ID in this API. For details, see [Deploy self-owned certificates to EdgeOne domain names].
        /// ](https://www.tencentcloud.com/document/product/1552/88874?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public ModifyHostsCertificateResponse ModifyHostsCertificateSync(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify an inference service to support updates to the listening port, request path, container image, resource configuration, and description. Only passed parameters will be modified, while unpassed parameters remain unchanged.
        /// </summary>
        /// <param name="req"><see cref="ModifyInferenceServiceRequest"/></param>
        /// <returns><see cref="ModifyInferenceServiceResponse"/></returns>
        public Task<ModifyInferenceServiceResponse> ModifyInferenceService(ModifyInferenceServiceRequest req)
        {
            return InternalRequestAsync<ModifyInferenceServiceResponse>(req, "ModifyInferenceService");
        }

        /// <summary>
        /// Modify an inference service to support updates to the listening port, request path, container image, resource configuration, and description. Only passed parameters will be modified, while unpassed parameters remain unchanged.
        /// </summary>
        /// <param name="req"><see cref="ModifyInferenceServiceRequest"/></param>
        /// <returns><see cref="ModifyInferenceServiceResponse"/></returns>
        public ModifyInferenceServiceResponse ModifyInferenceServiceSync(ModifyInferenceServiceRequest req)
        {
            return InternalRequestAsync<ModifyInferenceServiceResponse>(req, "ModifyInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of a layer 4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyResponse"/></returns>
        public Task<ModifyL4ProxyResponse> ModifyL4Proxy(ModifyL4ProxyRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyResponse>(req, "ModifyL4Proxy");
        }

        /// <summary>
        /// This API is used to modify the configuration of a layer 4 proxy instance.
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
        /// This API is used to enable or disable the status of layer-4 proxy rules, supporting both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesStatusResponse"/></returns>
        public Task<ModifyL4ProxyRulesStatusResponse> ModifyL4ProxyRulesStatus(ModifyL4ProxyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesStatusResponse>(req, "ModifyL4ProxyRulesStatus");
        }

        /// <summary>
        /// This API is used to enable or disable the status of layer-4 proxy rules, supporting both individual and batch operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesStatusResponse"/></returns>
        public ModifyL4ProxyRulesStatusResponse ModifyL4ProxyRulesStatusSync(ModifyL4ProxyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesStatusResponse>(req, "ModifyL4ProxyRulesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable an L4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyStatusResponse"/></returns>
        public Task<ModifyL4ProxyStatusResponse> ModifyL4ProxyStatus(ModifyL4ProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyStatusResponse>(req, "ModifyL4ProxyStatus");
        }

        /// <summary>
        /// This API is used to enable or disable an L4 proxy instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyStatusResponse"/></returns>
        public ModifyL4ProxyStatusResponse ModifyL4ProxyStatusSync(ModifyL4ProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyStatusResponse>(req, "ModifyL4ProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a rule in the [rule engine](https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1). Only one rule can be modified at a time.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRuleRequest"/></param>
        /// <returns><see cref="ModifyL7AccRuleResponse"/></returns>
        public Task<ModifyL7AccRuleResponse> ModifyL7AccRule(ModifyL7AccRuleRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRuleResponse>(req, "ModifyL7AccRule");
        }

        /// <summary>
        /// This API is used to modify a rule in the [rule engine](https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1). Only one rule can be modified at a time.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRuleRequest"/></param>
        /// <returns><see cref="ModifyL7AccRuleResponse"/></returns>
        public ModifyL7AccRuleResponse ModifyL7AccRuleSync(ModifyL7AccRuleRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRuleResponse>(req, "ModifyL7AccRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the priority of the rule list in the rule engine (https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1). It requires the input of the complete rule ID list under the site ID. The rule ID list can be obtained through the API for querying layer-7 acceleration rules (https://www.tencentcloud.com/document/product/1552/115820?from_cn_redirect=1). The final priority order will be adjusted to the order of the rule ID list, executed from front to back.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyL7AccRulePriorityResponse"/></returns>
        public Task<ModifyL7AccRulePriorityResponse> ModifyL7AccRulePriority(ModifyL7AccRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRulePriorityResponse>(req, "ModifyL7AccRulePriority");
        }

        /// <summary>
        /// This API is used to modify the priority of the rule list in the rule engine (https://www.tencentcloud.com/document/product/1552/70901?from_cn_redirect=1). It requires the input of the complete rule ID list under the site ID. The rule ID list can be obtained through the API for querying layer-7 acceleration rules (https://www.tencentcloud.com/document/product/1552/115820?from_cn_redirect=1). The final priority order will be adjusted to the order of the rule ID list, executed from front to back.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyL7AccRulePriorityResponse"/></returns>
        public ModifyL7AccRulePriorityResponse ModifyL7AccRulePrioritySync(ModifyL7AccRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRulePriorityResponse>(req, "ModifyL7AccRulePriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the global configuration of site acceleration.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccSettingRequest"/></param>
        /// <returns><see cref="ModifyL7AccSettingResponse"/></returns>
        public Task<ModifyL7AccSettingResponse> ModifyL7AccSetting(ModifyL7AccSettingRequest req)
        {
            return InternalRequestAsync<ModifyL7AccSettingResponse>(req, "ModifyL7AccSetting");
        }

        /// <summary>
        /// This API is used to modify the global configuration of site acceleration.
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccSettingRequest"/></param>
        /// <returns><see cref="ModifyL7AccSettingResponse"/></returns>
        public ModifyL7AccSettingResponse ModifyL7AccSettingSync(ModifyL7AccSettingRequest req)
        {
            return InternalRequestAsync<ModifyL7AccSettingResponse>(req, "ModifyL7AccSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify LoadBalancer configuration. The load balancing feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public Task<ModifyLoadBalancerResponse> ModifyLoadBalancer(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer");
        }

        /// <summary>
        /// This API is used to modify LoadBalancer configuration. The load balancing feature is in beta test. If you need to use it, [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public ModifyLoadBalancerResponse ModifyLoadBalancerSync(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify multi-channel security acceleration gateway information, such as name, gateway ID, IP, and port.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayResponse"/></returns>
        public Task<ModifyMultiPathGatewayResponse> ModifyMultiPathGateway(ModifyMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayResponse>(req, "ModifyMultiPathGateway");
        }

        /// <summary>
        /// This API is used to modify multi-channel security acceleration gateway information, such as name, gateway ID, IP, and port.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayResponse"/></returns>
        public ModifyMultiPathGatewayResponse ModifyMultiPathGatewaySync(ModifyMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayResponse>(req, "ModifyMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration for connecting lines to the multi-channel security acceleration gateway, including EdgeOne Layer 4 proxy lines and custom lines.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayLineResponse"/></returns>
        public Task<ModifyMultiPathGatewayLineResponse> ModifyMultiPathGatewayLine(ModifyMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayLineResponse>(req, "ModifyMultiPathGatewayLine");
        }

        /// <summary>
        /// This API is used to modify the configuration for connecting lines to the multi-channel security acceleration gateway, including EdgeOne Layer 4 proxy lines and custom lines.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayLineResponse"/></returns>
        public ModifyMultiPathGatewayLineResponse ModifyMultiPathGatewayLineSync(ModifyMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayLineResponse>(req, "ModifyMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the key for integrating a multi-channel security acceleration gateway. Customers sign with the integration key to access the multi-channel security acceleration gateway. After modification, the original key becomes invalid.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<ModifyMultiPathGatewaySecretKeyResponse> ModifyMultiPathGatewaySecretKey(ModifyMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewaySecretKeyResponse>(req, "ModifyMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// This API is used to modify the key for integrating a multi-channel security acceleration gateway. Customers sign with the integration key to access the multi-channel security acceleration gateway. After modification, the original key becomes invalid.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewaySecretKeyResponse"/></returns>
        public ModifyMultiPathGatewaySecretKeyResponse ModifyMultiPathGatewaySecretKeySync(ModifyMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewaySecretKeyResponse>(req, "ModifyMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the multi-channel security gateway status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayStatusRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayStatusResponse"/></returns>
        public Task<ModifyMultiPathGatewayStatusResponse> ModifyMultiPathGatewayStatus(ModifyMultiPathGatewayStatusRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayStatusResponse>(req, "ModifyMultiPathGatewayStatus");
        }

        /// <summary>
        /// This API is used to update the multi-channel security gateway status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayStatusRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayStatusResponse"/></returns>
        public ModifyMultiPathGatewayStatusResponse ModifyMultiPathGatewayStatusSync(ModifyMultiPathGatewayStatusRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayStatusResponse>(req, "ModifyMultiPathGatewayStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the origin protection configuration of a site. The following operations are supported: <li>**Resource addition and deletion**: enable or disable origin-pull from specific origin IP ranges for layer-7 accelerated domains/layer-4 proxy instances. This applies to resource adjustment in **specified protection mode**, and unspecified resources will not change;</li><li>**Mode switching**: adjust the origin protection mode of layer-7 accelerated domains/layer-4 proxy instances. After switching to all, the list of accelerated domains or layer-4 proxy instances under the site will be automatically added to the origin protection list in real time, and subsequent resource changes will also be automatically adjusted without manual intervention; after switching to specific, only the mode is changed, and resources already included in protection remain unchanged;</li><li>**IP range version switching**: for whitelisted customers, it supports switching to other available origin protection IP range versions, such as the simplified version, to reduce origin-pull IP ranges.</li>
        /// 
        /// Instructions for specified protection mode:
        /// <li>The maximum number of layer-7 accelerated domains that can be submitted at a time is 200, and the maximum number of layer-4 proxy instances is 100. Mixed submission of layer-7 accelerated domains/layer-4 proxy instances is supported, with a maximum total of 200 instances;</li>
        /// <li>When more than 200 resources need to be changed, submit them in batches through this API. For example, to add 500 layer-7 accelerated domains, first submit 200 domains through this API, and then submit the remaining 300 domains in two batches, with no more than 200 domains each time.</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginACLRequest"/></param>
        /// <returns><see cref="ModifyOriginACLResponse"/></returns>
        public Task<ModifyOriginACLResponse> ModifyOriginACL(ModifyOriginACLRequest req)
        {
            return InternalRequestAsync<ModifyOriginACLResponse>(req, "ModifyOriginACL");
        }

        /// <summary>
        /// This API is used to modify the origin protection configuration of a site. The following operations are supported: <li>**Resource addition and deletion**: enable or disable origin-pull from specific origin IP ranges for layer-7 accelerated domains/layer-4 proxy instances. This applies to resource adjustment in **specified protection mode**, and unspecified resources will not change;</li><li>**Mode switching**: adjust the origin protection mode of layer-7 accelerated domains/layer-4 proxy instances. After switching to all, the list of accelerated domains or layer-4 proxy instances under the site will be automatically added to the origin protection list in real time, and subsequent resource changes will also be automatically adjusted without manual intervention; after switching to specific, only the mode is changed, and resources already included in protection remain unchanged;</li><li>**IP range version switching**: for whitelisted customers, it supports switching to other available origin protection IP range versions, such as the simplified version, to reduce origin-pull IP ranges.</li>
        /// 
        /// Instructions for specified protection mode:
        /// <li>The maximum number of layer-7 accelerated domains that can be submitted at a time is 200, and the maximum number of layer-4 proxy instances is 100. Mixed submission of layer-7 accelerated domains/layer-4 proxy instances is supported, with a maximum total of 200 instances;</li>
        /// <li>When more than 200 resources need to be changed, submit them in batches through this API. For example, to add 500 layer-7 accelerated domains, first submit 200 domains through this API, and then submit the remaining 300 domains in two batches, with no more than 200 domains each time.</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginACLRequest"/></param>
        /// <returns><see cref="ModifyOriginACLResponse"/></returns>
        public ModifyOriginACLResponse ModifyOriginACLSync(ModifyOriginACLRequest req)
        {
            return InternalRequestAsync<ModifyOriginACLResponse>(req, "ModifyOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify origin group configuration. Newly submitted origin records will overwrite the original origin records in the origin group.
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public Task<ModifyOriginGroupResponse> ModifyOriginGroup(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup");
        }

        /// <summary>
        /// Modify origin group configuration. Newly submitted origin records will overwrite the original origin records in the origin group.
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
        /// This API is used to configure origin-pull rate limiting. This feature is in allowlist beta test.
        /// This API is used to create, modify, and delete preheated origin-pull rate limits. Each account supports up to 100 limits.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrefetchOriginLimitRequest"/></param>
        /// <returns><see cref="ModifyPrefetchOriginLimitResponse"/></returns>
        public Task<ModifyPrefetchOriginLimitResponse> ModifyPrefetchOriginLimit(ModifyPrefetchOriginLimitRequest req)
        {
            return InternalRequestAsync<ModifyPrefetchOriginLimitResponse>(req, "ModifyPrefetchOriginLimit");
        }

        /// <summary>
        /// This API is used to configure origin-pull rate limiting. This feature is in allowlist beta test.
        /// This API is used to create, modify, and delete preheated origin-pull rate limits. Each account supports up to 100 limits.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrefetchOriginLimitRequest"/></param>
        /// <returns><see cref="ModifyPrefetchOriginLimitResponse"/></returns>
        public ModifyPrefetchOriginLimitResponse ModifyPrefetchOriginLimitSync(ModifyPrefetchOriginLimitRequest req)
        {
            return InternalRequestAsync<ModifyPrefetchOriginLimitResponse>(req, "ModifyPrefetchOriginLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of a real-time log delivery task. It has the following limits:
        /// <ul>
        /// <li>The destination type (`TaskType`) of a real-time log delivery task cannot be modified;</li>
        /// <li>The data delivery type (`LogType`) cannot be modified;</li>
        /// <li>The data delivery region (`Area`) cannot be modified;</li>
        /// <li>When the destination of the original real-time log delivery task is Tencent Cloud CLS, the destination details such as the log set and log topic cannot be modified.</li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="ModifyRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="ModifyRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<ModifyRealtimeLogDeliveryTaskResponse> ModifyRealtimeLogDeliveryTask(ModifyRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyRealtimeLogDeliveryTaskResponse>(req, "ModifyRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// This API is used to modify the configuration of a real-time log delivery task. It has the following limits:
        /// <ul>
        /// <li>The destination type (`TaskType`) of a real-time log delivery task cannot be modified;</li>
        /// <li>The data delivery type (`LogType`) cannot be modified;</li>
        /// <li>The data delivery region (`Area`) cannot be modified;</li>
        /// <li>When the destination of the original real-time log delivery task is Tencent Cloud CLS, the destination details such as the log set and log topic cannot be modified.</li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="ModifyRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="ModifyRealtimeLogDeliveryTaskResponse"/></returns>
        public ModifyRealtimeLogDeliveryTaskResponse ModifyRealtimeLogDeliveryTaskSync(ModifyRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyRealtimeLogDeliveryTaskResponse>(req, "ModifyRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version for modifying rule engine APIs. EdgeOne comprehensively upgraded rule engine-related APIs on January 21, 2025. For details on the new version API for modifying layer-7 acceleration rules, refer to [ModifyL7AccRule](https://www.tencentcloud.com/document/product/1552/115818?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the legacy version API will stop update and iteration. New features will only be provided in the latest version API. The existing capacity supported by the legacy version API will not be affected. To avoid data field conflict when using the legacy version API, migrate to the latest version rule engine API as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// This API is on an earlier version for modifying rule engine APIs. EdgeOne comprehensively upgraded rule engine-related APIs on January 21, 2025. For details on the new version API for modifying layer-7 acceleration rules, refer to [ModifyL7AccRule](https://www.tencentcloud.com/document/product/1552/115818?from_cn_redirect=1).
        /// <p style="color: red;">Note: Starting from January 21, 2025, the legacy version API will stop update and iteration. New features will only be provided in the latest version API. The existing capacity supported by the legacy version API will not be affected. To avoid data field conflict when using the legacy version API, migrate to the latest version rule engine API as soon as possible.</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify API resources.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIResourceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIResourceResponse"/></returns>
        public Task<ModifySecurityAPIResourceResponse> ModifySecurityAPIResource(ModifySecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIResourceResponse>(req, "ModifySecurityAPIResource");
        }

        /// <summary>
        /// This API is used to modify API resources.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIResourceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIResourceResponse"/></returns>
        public ModifySecurityAPIResourceResponse ModifySecurityAPIResourceSync(ModifySecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIResourceResponse>(req, "ModifySecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify API services.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIServiceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIServiceResponse"/></returns>
        public Task<ModifySecurityAPIServiceResponse> ModifySecurityAPIService(ModifySecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIServiceResponse>(req, "ModifySecurityAPIService");
        }

        /// <summary>
        /// This API is used to modify API services.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIServiceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIServiceResponse"/></returns>
        public ModifySecurityAPIServiceResponse ModifySecurityAPIServiceSync(ModifySecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIServiceResponse>(req, "ModifySecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify client authentication options.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityClientAttesterRequest"/></param>
        /// <returns><see cref="ModifySecurityClientAttesterResponse"/></returns>
        public Task<ModifySecurityClientAttesterResponse> ModifySecurityClientAttester(ModifySecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<ModifySecurityClientAttesterResponse>(req, "ModifySecurityClientAttester");
        }

        /// <summary>
        /// Modify client authentication options.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityClientAttesterRequest"/></param>
        /// <returns><see cref="ModifySecurityClientAttesterResponse"/></returns>
        public ModifySecurityClientAttesterResponse ModifySecurityClientAttesterSync(ModifySecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<ModifySecurityClientAttesterResponse>(req, "ModifySecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies a security IP group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public Task<ModifySecurityIPGroupResponse> ModifySecurityIPGroup(ModifySecurityIPGroupRequest req)
        {
            return InternalRequestAsync<ModifySecurityIPGroupResponse>(req, "ModifySecurityIPGroup");
        }

        /// <summary>
        /// Modifies a security IP group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public ModifySecurityIPGroupResponse ModifySecurityIPGroupSync(ModifySecurityIPGroupRequest req)
        {
            return InternalRequestAsync<ModifySecurityIPGroupResponse>(req, "ModifySecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityJSInjectionRuleResponse"/></returns>
        public Task<ModifySecurityJSInjectionRuleResponse> ModifySecurityJSInjectionRule(ModifySecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityJSInjectionRuleResponse>(req, "ModifySecurityJSInjectionRule");
        }

        /// <summary>
        /// This API is used to modify JavaScript injection rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityJSInjectionRuleResponse"/></returns>
        public ModifySecurityJSInjectionRuleResponse ModifySecurityJSInjectionRuleSync(ModifySecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityJSInjectionRuleResponse>(req, "ModifySecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Web & Bot security configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy");
        }

        /// <summary>
        /// Modify Web & Bot security configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a shared CNAME. Currently, it only supports modifying the description and settings of a shared CNAME, and associating an IP SSL domain name with an IP SSL shared CNAME. Once created, a shared CNAME itself cannot be modified. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="ModifySharedCNAMERequest"/></param>
        /// <returns><see cref="ModifySharedCNAMEResponse"/></returns>
        public Task<ModifySharedCNAMEResponse> ModifySharedCNAME(ModifySharedCNAMERequest req)
        {
            return InternalRequestAsync<ModifySharedCNAMEResponse>(req, "ModifySharedCNAME");
        }

        /// <summary>
        /// This API is used to modify a shared CNAME. Currently, it only supports modifying the description and settings of a shared CNAME, and associating an IP SSL domain name with an IP SSL shared CNAME. Once created, a shared CNAME itself cannot be modified. This feature is in beta test.
        /// </summary>
        /// <param name="req"><see cref="ModifySharedCNAMERequest"/></param>
        /// <returns><see cref="ModifySharedCNAMEResponse"/></returns>
        public ModifySharedCNAMEResponse ModifySharedCNAMESync(ModifySharedCNAMERequest req)
        {
            return InternalRequestAsync<ModifySharedCNAMEResponse>(req, "ModifySharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies a security policy configuration template
        /// </summary>
        /// <param name="req"><see cref="ModifyWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="ModifyWebSecurityTemplateResponse"/></returns>
        public Task<ModifyWebSecurityTemplateResponse> ModifyWebSecurityTemplate(ModifyWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWebSecurityTemplateResponse>(req, "ModifyWebSecurityTemplate");
        }

        /// <summary>
        /// Modifies a security policy configuration template
        /// </summary>
        /// <param name="req"><see cref="ModifyWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="ModifyWebSecurityTemplateResponse"/></returns>
        public ModifyWebSecurityTemplateResponse ModifyWebSecurityTemplateSync(ModifyWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWebSecurityTemplateResponse>(req, "ModifyWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies site information.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public Task<ModifyZoneResponse> ModifyZone(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone");
        }

        /// <summary>
        /// Modifies site information.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public ModifyZoneResponse ModifyZoneSync(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage site-level custom variables, supporting the creation, modification, and deletion of variable definitions and variable operations. The submitted list will override the corresponding existing configuration. To clear the configuration, pass in an empty list. Configuration items not passed in remain unchanged. The default values for variable definitions and variable operations are both empty.
        /// 
        /// For rule-level custom variable related operations, call the CreateL7AccRules or ModifyL7AccRule API.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCustomVariablesRequest"/></param>
        /// <returns><see cref="ModifyZoneCustomVariablesResponse"/></returns>
        public Task<ModifyZoneCustomVariablesResponse> ModifyZoneCustomVariables(ModifyZoneCustomVariablesRequest req)
        {
            return InternalRequestAsync<ModifyZoneCustomVariablesResponse>(req, "ModifyZoneCustomVariables");
        }

        /// <summary>
        /// This API is used to manage site-level custom variables, supporting the creation, modification, and deletion of variable definitions and variable operations. The submitted list will override the corresponding existing configuration. To clear the configuration, pass in an empty list. Configuration items not passed in remain unchanged. The default values for variable definitions and variable operations are both empty.
        /// 
        /// For rule-level custom variable related operations, call the CreateL7AccRules or ModifyL7AccRule API.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCustomVariablesRequest"/></param>
        /// <returns><see cref="ModifyZoneCustomVariablesResponse"/></returns>
        public ModifyZoneCustomVariablesResponse ModifyZoneCustomVariablesSync(ModifyZoneCustomVariablesRequest req)
        {
            return InternalRequestAsync<ModifyZoneCustomVariablesResponse>(req, "ModifyZoneCustomVariables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. For details, see [ModifyL7AccSetting](https://www.tencentcloud.com/document/product/1552/115817?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting");
        }

        /// <summary>
        /// This API is on an earlier version. EdgeOne has completed a comprehensive upgrade of rule engine APIs. For details, see [ModifyL7AccSetting](https://www.tencentcloud.com/document/product/1552/115817?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public ModifyZoneSettingResponse ModifyZoneSettingSync(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to enable or disable a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public Task<ModifyZoneStatusResponse> ModifyZoneStatus(ModifyZoneStatusRequest req)
        {
            return InternalRequestAsync<ModifyZoneStatusResponse>(req, "ModifyZoneStatus");
        }

        /// <summary>
        /// Used to enable or disable a site.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public ModifyZoneStatusResponse ModifyZoneStatusSync(ModifyZoneStatusRequest req)
        {
            return InternalRequestAsync<ModifyZoneStatusResponse>(req, "ModifyZoneStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the working mode of each configuration module under a site. Each configuration module of a site can enable version management mode or immediate effect mode by configuration group dimension. For details, see Version Management (https://www.tencentcloud.com/document/product/1552/113690?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneWorkModeRequest"/></param>
        /// <returns><see cref="ModifyZoneWorkModeResponse"/></returns>
        public Task<ModifyZoneWorkModeResponse> ModifyZoneWorkMode(ModifyZoneWorkModeRequest req)
        {
            return InternalRequestAsync<ModifyZoneWorkModeResponse>(req, "ModifyZoneWorkMode");
        }

        /// <summary>
        /// This API is used to modify the working mode of each configuration module under a site. Each configuration module of a site can enable version management mode or immediate effect mode by configuration group dimension. For details, see Version Management (https://www.tencentcloud.com/document/product/1552/113690?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneWorkModeRequest"/></param>
        /// <returns><see cref="ModifyZoneWorkModeResponse"/></returns>
        public ModifyZoneWorkModeResponse ModifyZoneWorkModeSync(ModifyZoneWorkModeRequest req)
        {
            return InternalRequestAsync<ModifyZoneWorkModeResponse>(req, "ModifyZoneWorkMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operate an inference service domain name. You can stop, enable, and delete it. Resources cannot be recovered after deletion.
        /// </summary>
        /// <param name="req"><see cref="OperateInferenceDomainRequest"/></param>
        /// <returns><see cref="OperateInferenceDomainResponse"/></returns>
        public Task<OperateInferenceDomainResponse> OperateInferenceDomain(OperateInferenceDomainRequest req)
        {
            return InternalRequestAsync<OperateInferenceDomainResponse>(req, "OperateInferenceDomain");
        }

        /// <summary>
        /// Operate an inference service domain name. You can stop, enable, and delete it. Resources cannot be recovered after deletion.
        /// </summary>
        /// <param name="req"><see cref="OperateInferenceDomainRequest"/></param>
        /// <returns><see cref="OperateInferenceDomainResponse"/></returns>
        public OperateInferenceDomainResponse OperateInferenceDomainSync(OperateInferenceDomainRequest req)
        {
            return InternalRequestAsync<OperateInferenceDomainResponse>(req, "OperateInferenceDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operate an inference service. You can stop, start, and delete it. Resources cannot be recovered after deletion.
        /// </summary>
        /// <param name="req"><see cref="OperateInferenceServiceRequest"/></param>
        /// <returns><see cref="OperateInferenceServiceResponse"/></returns>
        public Task<OperateInferenceServiceResponse> OperateInferenceService(OperateInferenceServiceRequest req)
        {
            return InternalRequestAsync<OperateInferenceServiceResponse>(req, "OperateInferenceService");
        }

        /// <summary>
        /// Operate an inference service. You can stop, start, and delete it. Resources cannot be recovered after deletion.
        /// </summary>
        /// <param name="req"><see cref="OperateInferenceServiceRequest"/></param>
        /// <returns><see cref="OperateInferenceServiceResponse"/></returns>
        public OperateInferenceServiceResponse OperateInferenceServiceSync(OperateInferenceServiceRequest req)
        {
            return InternalRequestAsync<OperateInferenceServiceResponse>(req, "OperateInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refresh the key of a multi-channel security acceleration gateway. Customers integrate with the multi-channel security acceleration gateway based on key signatures. Each site contains only one key, which can be used to integrate all gateways under the site. After the key is refreshed, the original key becomes invalid.
        /// </summary>
        /// <param name="req"><see cref="RefreshMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="RefreshMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<RefreshMultiPathGatewaySecretKeyResponse> RefreshMultiPathGatewaySecretKey(RefreshMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<RefreshMultiPathGatewaySecretKeyResponse>(req, "RefreshMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// This API is used to refresh the key of a multi-channel security acceleration gateway. Customers integrate with the multi-channel security acceleration gateway based on key signatures. Each site contains only one key, which can be used to integrate all gateways under the site. After the key is refreshed, the original key becomes invalid.
        /// </summary>
        /// <param name="req"><see cref="RefreshMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="RefreshMultiPathGatewaySecretKeyResponse"/></returns>
        public RefreshMultiPathGatewaySecretKeyResponse RefreshMultiPathGatewaySecretKeySync(RefreshMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<RefreshMultiPathGatewaySecretKeyResponse>(req, "RefreshMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// When your plan needs to be extended, you can use this API to renew it. Plan renewal is only supported for the Personal, Basic, and Standard Editions.
        /// > For cost details, refer to [Plan Cost](https://www.tencentcloud.com/document/product/1552/94158?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="RenewPlanRequest"/></param>
        /// <returns><see cref="RenewPlanResponse"/></returns>
        public Task<RenewPlanResponse> RenewPlan(RenewPlanRequest req)
        {
            return InternalRequestAsync<RenewPlanResponse>(req, "RenewPlan");
        }

        /// <summary>
        /// When your plan needs to be extended, you can use this API to renew it. Plan renewal is only supported for the Personal, Basic, and Standard Editions.
        /// > For cost details, refer to [Plan Cost](https://www.tencentcloud.com/document/product/1552/94158?from_cn_redirect=1).
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
        /// > For differences between different types of Edgeone billing plans, see Edgeone billing plan comparison (https://www.tencentcloud.com/document/product/1552/94165?from_cn_redirect=1)
        /// For billing package upgrade rules and pricing details, see Edgeone billing package upgrade instructions (https://www.tencentcloud.com/document/product/1552/95291?from_cn_redirect=1)
        /// If your plan needs to upgrade to the Enterprise Edition, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="UpgradePlanRequest"/></param>
        /// <returns><see cref="UpgradePlanResponse"/></returns>
        public Task<UpgradePlanResponse> UpgradePlan(UpgradePlanRequest req)
        {
            return InternalRequestAsync<UpgradePlanResponse>(req, "UpgradePlan");
        }

        /// <summary>
        /// When you need features available only in higher-tier plans, you can upgrade your plan through this interface. Upgrades are only supported for Personal and Basic Edition Plans.
        /// > For differences between different types of Edgeone billing plans, see Edgeone billing plan comparison (https://www.tencentcloud.com/document/product/1552/94165?from_cn_redirect=1)
        /// For billing package upgrade rules and pricing details, see Edgeone billing package upgrade instructions (https://www.tencentcloud.com/document/product/1552/95291?from_cn_redirect=1)
        /// If your plan needs to upgrade to the Enterprise Edition, please [contact us](https://www.tencentcloud.com/contact-us).
        /// </summary>
        /// <param name="req"><see cref="UpgradePlanRequest"/></param>
        /// <returns><see cref="UpgradePlanResponse"/></returns>
        public UpgradePlanResponse UpgradePlanSync(UpgradePlanRequest req)
        {
            return InternalRequestAsync<UpgradePlanResponse>(req, "UpgradePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// In CNAME access mode, you need to verify the ownership of the site or domain name. This API is used to trigger the verification. If the site passes ownership verification, no need to verify again when adding domains subsequently. For details, see [Site/Domain Name Ownership Verification](https://www.tencentcloud.com/document/product/1552/70789?from_cn_redirect=1).
        /// 
        /// In NS access mode, you can also query through this API whether the NS server switch is successful. For details, see [Modify DNS Server](https://www.tencentcloud.com/document/product/1552/90452?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="VerifyOwnershipRequest"/></param>
        /// <returns><see cref="VerifyOwnershipResponse"/></returns>
        public Task<VerifyOwnershipResponse> VerifyOwnership(VerifyOwnershipRequest req)
        {
            return InternalRequestAsync<VerifyOwnershipResponse>(req, "VerifyOwnership");
        }

        /// <summary>
        /// In CNAME access mode, you need to verify the ownership of the site or domain name. This API is used to trigger the verification. If the site passes ownership verification, no need to verify again when adding domains subsequently. For details, see [Site/Domain Name Ownership Verification](https://www.tencentcloud.com/document/product/1552/70789?from_cn_redirect=1).
        /// 
        /// In NS access mode, you can also query through this API whether the NS server switch is successful. For details, see [Modify DNS Server](https://www.tencentcloud.com/document/product/1552/90452?from_cn_redirect=1).
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
