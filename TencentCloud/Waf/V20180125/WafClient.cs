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

namespace TencentCloud.Waf.V20180125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Waf.V20180125.Models;

   public class WafClient : AbstractClient{

       private const string endpoint = "waf.tencentcloudapi.com";
       private const string version = "2018-01-25";
       private const string sdkVersion = "SDK_NET_3.0.1052";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WafClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WafClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Add tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="AddAntiFakeUrlRequest"/></param>
        /// <returns><see cref="AddAntiFakeUrlResponse"/></returns>
        public Task<AddAntiFakeUrlResponse> AddAntiFakeUrl(AddAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<AddAntiFakeUrlResponse>(req, "AddAntiFakeUrl");
        }

        /// <summary>
        /// Add tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="AddAntiFakeUrlRequest"/></param>
        /// <returns><see cref="AddAntiFakeUrlResponse"/></returns>
        public AddAntiFakeUrlResponse AddAntiFakeUrlSync(AddAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<AddAntiFakeUrlResponse>(req, "AddAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add information leakage prevention rule
        /// </summary>
        /// <param name="req"><see cref="AddAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="AddAntiInfoLeakRulesResponse"/></returns>
        public Task<AddAntiInfoLeakRulesResponse> AddAntiInfoLeakRules(AddAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<AddAntiInfoLeakRulesResponse>(req, "AddAntiInfoLeakRules");
        }

        /// <summary>
        /// Add information leakage prevention rule
        /// </summary>
        /// <param name="req"><see cref="AddAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="AddAntiInfoLeakRulesResponse"/></returns>
        public AddAntiInfoLeakRulesResponse AddAntiInfoLeakRulesSync(AddAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<AddAntiInfoLeakRulesResponse>(req, "AddAntiInfoLeakRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add access control (from custom policy)
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public Task<AddCustomRuleResponse> AddCustomRule(AddCustomRuleRequest req)
        {
            return InternalRequestAsync<AddCustomRuleResponse>(req, "AddCustomRule");
        }

        /// <summary>
        /// Add access control (from custom policy)
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public AddCustomRuleResponse AddCustomRuleSync(AddCustomRuleRequest req)
        {
            return InternalRequestAsync<AddCustomRuleResponse>(req, "AddCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add precision allowlist rules
        /// </summary>
        /// <param name="req"><see cref="AddCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="AddCustomWhiteRuleResponse"/></returns>
        public Task<AddCustomWhiteRuleResponse> AddCustomWhiteRule(AddCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddCustomWhiteRuleResponse>(req, "AddCustomWhiteRule");
        }

        /// <summary>
        /// Add precision allowlist rules
        /// </summary>
        /// <param name="req"><see cref="AddCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="AddCustomWhiteRuleResponse"/></returns>
        public AddCustomWhiteRuleResponse AddCustomWhiteRuleSync(AddCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddCustomWhiteRuleResponse>(req, "AddCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add SaaS WAF protection domain
        /// </summary>
        /// <param name="req"><see cref="AddSpartaProtectionRequest"/></param>
        /// <returns><see cref="AddSpartaProtectionResponse"/></returns>
        public Task<AddSpartaProtectionResponse> AddSpartaProtection(AddSpartaProtectionRequest req)
        {
            return InternalRequestAsync<AddSpartaProtectionResponse>(req, "AddSpartaProtection");
        }

        /// <summary>
        /// Add SaaS WAF protection domain
        /// </summary>
        /// <param name="req"><see cref="AddSpartaProtectionRequest"/></param>
        /// <returns><see cref="AddSpartaProtectionResponse"/></returns>
        public AddSpartaProtectionResponse AddSpartaProtectionSync(AddSpartaProtectionRequest req)
        {
            return InternalRequestAsync<AddSpartaProtectionResponse>(req, "AddSpartaProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Billing Resource Purchase, Renewal Order API
        /// </summary>
        /// <param name="req"><see cref="CreateDealsRequest"/></param>
        /// <returns><see cref="CreateDealsResponse"/></returns>
        public Task<CreateDealsResponse> CreateDeals(CreateDealsRequest req)
        {
            return InternalRequestAsync<CreateDealsResponse>(req, "CreateDeals");
        }

        /// <summary>
        /// Billing Resource Purchase, Renewal Order API
        /// </summary>
        /// <param name="req"><see cref="CreateDealsRequest"/></param>
        /// <returns><see cref="CreateDealsResponse"/></returns>
        public CreateDealsResponse CreateDealsSync(CreateDealsRequest req)
        {
            return InternalRequestAsync<CreateDealsResponse>(req, "CreateDeals")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add a protection domain in CLB-WAF
        /// </summary>
        /// <param name="req"><see cref="CreateHostRequest"/></param>
        /// <returns><see cref="CreateHostResponse"/></returns>
        public Task<CreateHostResponse> CreateHost(CreateHostRequest req)
        {
            return InternalRequestAsync<CreateHostResponse>(req, "CreateHost");
        }

        /// <summary>
        /// Add a protection domain in CLB-WAF
        /// </summary>
        /// <param name="req"><see cref="CreateHostRequest"/></param>
        /// <returns><see cref="CreateHostResponse"/></returns>
        public CreateHostResponse CreateHostSync(CreateHostRequest req)
        {
            return InternalRequestAsync<CreateHostResponse>(req, "CreateHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add WAF IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="CreateIpAccessControlRequest"/></param>
        /// <returns><see cref="CreateIpAccessControlResponse"/></returns>
        public Task<CreateIpAccessControlResponse> CreateIpAccessControl(CreateIpAccessControlRequest req)
        {
            return InternalRequestAsync<CreateIpAccessControlResponse>(req, "CreateIpAccessControl");
        }

        /// <summary>
        /// This API is used to add WAF IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="CreateIpAccessControlRequest"/></param>
        /// <returns><see cref="CreateIpAccessControlResponse"/></returns>
        public CreateIpAccessControlResponse CreateIpAccessControlSync(CreateIpAccessControlRequest req)
        {
            return InternalRequestAsync<CreateIpAccessControlResponse>(req, "CreateIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DeleteAntiFakeUrlResponse"/></returns>
        public Task<DeleteAntiFakeUrlResponse> DeleteAntiFakeUrl(DeleteAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<DeleteAntiFakeUrlResponse>(req, "DeleteAntiFakeUrl");
        }

        /// <summary>
        /// Delete tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DeleteAntiFakeUrlResponse"/></returns>
        public DeleteAntiFakeUrlResponse DeleteAntiFakeUrlSync(DeleteAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<DeleteAntiFakeUrlResponse>(req, "DeleteAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete information leakage prevention rule
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiInfoLeakRuleRequest"/></param>
        /// <returns><see cref="DeleteAntiInfoLeakRuleResponse"/></returns>
        public Task<DeleteAntiInfoLeakRuleResponse> DeleteAntiInfoLeakRule(DeleteAntiInfoLeakRuleRequest req)
        {
            return InternalRequestAsync<DeleteAntiInfoLeakRuleResponse>(req, "DeleteAntiInfoLeakRule");
        }

        /// <summary>
        /// Delete information leakage prevention rule
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiInfoLeakRuleRequest"/></param>
        /// <returns><see cref="DeleteAntiInfoLeakRuleResponse"/></returns>
        public DeleteAntiInfoLeakRuleResponse DeleteAntiInfoLeakRuleSync(DeleteAntiInfoLeakRuleRequest req)
        {
            return InternalRequestAsync<DeleteAntiInfoLeakRuleResponse>(req, "DeleteAntiInfoLeakRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF CC V2 deletion API
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRuleRequest"/></param>
        /// <returns><see cref="DeleteCCRuleResponse"/></returns>
        public Task<DeleteCCRuleResponse> DeleteCCRule(DeleteCCRuleRequest req)
        {
            return InternalRequestAsync<DeleteCCRuleResponse>(req, "DeleteCCRule");
        }

        /// <summary>
        /// WAF CC V2 deletion API
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRuleRequest"/></param>
        /// <returns><see cref="DeleteCCRuleResponse"/></returns>
        public DeleteCCRuleResponse DeleteCCRuleSync(DeleteCCRuleRequest req)
        {
            return InternalRequestAsync<DeleteCCRuleResponse>(req, "DeleteCCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete custom rule
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomRuleResponse"/></returns>
        public Task<DeleteCustomRuleResponse> DeleteCustomRule(DeleteCustomRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomRuleResponse>(req, "DeleteCustomRule");
        }

        /// <summary>
        /// Delete custom rule
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomRuleResponse"/></returns>
        public DeleteCustomRuleResponse DeleteCustomRuleSync(DeleteCustomRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomRuleResponse>(req, "DeleteCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete precision allowlist rules
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomWhiteRuleResponse"/></returns>
        public Task<DeleteCustomWhiteRuleResponse> DeleteCustomWhiteRule(DeleteCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomWhiteRuleResponse>(req, "DeleteCustomWhiteRule");
        }

        /// <summary>
        /// Delete precision allowlist rules
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomWhiteRuleResponse"/></returns>
        public DeleteCustomWhiteRuleResponse DeleteCustomWhiteRuleSync(DeleteCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomWhiteRuleResponse>(req, "DeleteCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a domain name protected by CLB WAF. Batch operation is supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteHostRequest"/></param>
        /// <returns><see cref="DeleteHostResponse"/></returns>
        public Task<DeleteHostResponse> DeleteHost(DeleteHostRequest req)
        {
            return InternalRequestAsync<DeleteHostResponse>(req, "DeleteHost");
        }

        /// <summary>
        /// This API is used to delete a domain name protected by CLB WAF. Batch operation is supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteHostRequest"/></param>
        /// <returns><see cref="DeleteHostResponse"/></returns>
        public DeleteHostResponse DeleteHostSync(DeleteHostRequest req)
        {
            return InternalRequestAsync<DeleteHostResponse>(req, "DeleteHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete latest versions of WAF IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlV2Request"/></param>
        /// <returns><see cref="DeleteIpAccessControlV2Response"/></returns>
        public Task<DeleteIpAccessControlV2Response> DeleteIpAccessControlV2(DeleteIpAccessControlV2Request req)
        {
            return InternalRequestAsync<DeleteIpAccessControlV2Response>(req, "DeleteIpAccessControlV2");
        }

        /// <summary>
        /// This API is used to delete latest versions of WAF IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlV2Request"/></param>
        /// <returns><see cref="DeleteIpAccessControlV2Response"/></returns>
        public DeleteIpAccessControlV2Response DeleteIpAccessControlV2Sync(DeleteIpAccessControlV2Request req)
        {
            return InternalRequestAsync<DeleteIpAccessControlV2Response>(req, "DeleteIpAccessControlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete CC attack session settings
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public Task<DeleteSessionResponse> DeleteSession(DeleteSessionRequest req)
        {
            return InternalRequestAsync<DeleteSessionResponse>(req, "DeleteSession");
        }

        /// <summary>
        /// Delete CC attack session settings
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public DeleteSessionResponse DeleteSessionSync(DeleteSessionRequest req)
        {
            return InternalRequestAsync<DeleteSessionResponse>(req, "DeleteSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a domain name protected by SaaS WAF.
        /// </summary>
        /// <param name="req"><see cref="DeleteSpartaProtectionRequest"/></param>
        /// <returns><see cref="DeleteSpartaProtectionResponse"/></returns>
        public Task<DeleteSpartaProtectionResponse> DeleteSpartaProtection(DeleteSpartaProtectionRequest req)
        {
            return InternalRequestAsync<DeleteSpartaProtectionResponse>(req, "DeleteSpartaProtection");
        }

        /// <summary>
        /// This API is used to delete a domain name protected by SaaS WAF.
        /// </summary>
        /// <param name="req"><see cref="DeleteSpartaProtectionRequest"/></param>
        /// <returns><see cref="DeleteSpartaProtectionResponse"/></returns>
        public DeleteSpartaProtectionResponse DeleteSpartaProtectionSync(DeleteSpartaProtectionRequest req)
        {
            return InternalRequestAsync<DeleteSpartaProtectionResponse>(req, "DeleteSpartaProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain a tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeRulesResponse"/></returns>
        public Task<DescribeAntiFakeRulesResponse> DescribeAntiFakeRules(DescribeAntiFakeRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiFakeRulesResponse>(req, "DescribeAntiFakeRules");
        }

        /// <summary>
        /// Obtain a tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeRulesResponse"/></returns>
        public DescribeAntiFakeRulesResponse DescribeAntiFakeRulesSync(DescribeAntiFakeRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiFakeRulesResponse>(req, "DescribeAntiFakeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the information leakage prevention rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakageRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakageRulesResponse"/></returns>
        public Task<DescribeAntiInfoLeakageRulesResponse> DescribeAntiInfoLeakageRules(DescribeAntiInfoLeakageRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiInfoLeakageRulesResponse>(req, "DescribeAntiInfoLeakageRules");
        }

        /// <summary>
        /// Obtain the information leakage prevention rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakageRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakageRulesResponse"/></returns>
        public DescribeAntiInfoLeakageRulesResponse DescribeAntiInfoLeakageRulesSync(DescribeAntiInfoLeakageRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiInfoLeakageRulesResponse>(req, "DescribeAntiInfoLeakageRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe the attack overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackOverviewRequest"/></param>
        /// <returns><see cref="DescribeAttackOverviewResponse"/></returns>
        public Task<DescribeAttackOverviewResponse> DescribeAttackOverview(DescribeAttackOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAttackOverviewResponse>(req, "DescribeAttackOverview");
        }

        /// <summary>
        /// This API is used to describe the attack overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackOverviewRequest"/></param>
        /// <returns><see cref="DescribeAttackOverviewResponse"/></returns>
        public DescribeAttackOverviewResponse DescribeAttackOverviewSync(DescribeAttackOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAttackOverviewResponse>(req, "DescribeAttackOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the top N attack types for a specified domain
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTypeRequest"/></param>
        /// <returns><see cref="DescribeAttackTypeResponse"/></returns>
        public Task<DescribeAttackTypeResponse> DescribeAttackType(DescribeAttackTypeRequest req)
        {
            return InternalRequestAsync<DescribeAttackTypeResponse>(req, "DescribeAttackType");
        }

        /// <summary>
        /// Query the top N attack types for a specified domain
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTypeRequest"/></param>
        /// <returns><see cref="DescribeAttackTypeResponse"/></returns>
        public DescribeAttackTypeResponse DescribeAttackTypeSync(DescribeAttackTypeRequest req)
        {
            return InternalRequestAsync<DescribeAttackTypeResponse>(req, "DescribeAttackType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the IP blocklist and allowlist for WAF batch protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeBatchIpAccessControlResponse"/></returns>
        public Task<DescribeBatchIpAccessControlResponse> DescribeBatchIpAccessControl(DescribeBatchIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeBatchIpAccessControlResponse>(req, "DescribeBatchIpAccessControl");
        }

        /// <summary>
        /// This API is used to query the IP blocklist and allowlist for WAF batch protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeBatchIpAccessControlResponse"/></returns>
        public DescribeBatchIpAccessControlResponse DescribeBatchIpAccessControlSync(DescribeBatchIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeBatchIpAccessControlResponse>(req, "DescribeBatchIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF CC V2 query API
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleRequest"/></param>
        /// <returns><see cref="DescribeCCRuleResponse"/></returns>
        public Task<DescribeCCRuleResponse> DescribeCCRule(DescribeCCRuleRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleResponse>(req, "DescribeCCRule");
        }

        /// <summary>
        /// WAF CC V2 query API
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleRequest"/></param>
        /// <returns><see cref="DescribeCCRuleResponse"/></returns>
        public DescribeCCRuleResponse DescribeCCRuleSync(DescribeCCRuleRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleResponse>(req, "DescribeCCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query CC rules based on multiple conditions
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleListRequest"/></param>
        /// <returns><see cref="DescribeCCRuleListResponse"/></returns>
        public Task<DescribeCCRuleListResponse> DescribeCCRuleList(DescribeCCRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleListResponse>(req, "DescribeCCRuleList");
        }

        /// <summary>
        /// Query CC rules based on multiple conditions
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleListRequest"/></param>
        /// <returns><see cref="DescribeCCRuleListResponse"/></returns>
        public DescribeCCRuleListResponse DescribeCCRuleListSync(DescribeCCRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleListResponse>(req, "DescribeCCRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain certificate inspection result
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateVerifyResultResponse"/></returns>
        public Task<DescribeCertificateVerifyResultResponse> DescribeCertificateVerifyResult(DescribeCertificateVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateVerifyResultResponse>(req, "DescribeCertificateVerifyResult");
        }

        /// <summary>
        /// Obtain certificate inspection result
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateVerifyResultResponse"/></returns>
        public DescribeCertificateVerifyResultResponse DescribeCertificateVerifyResultSync(DescribeCertificateVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateVerifyResultResponse>(req, "DescribeCertificateVerifyResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query SaaS WAF cipher suite information
        /// </summary>
        /// <param name="req"><see cref="DescribeCiphersDetailRequest"/></param>
        /// <returns><see cref="DescribeCiphersDetailResponse"/></returns>
        public Task<DescribeCiphersDetailResponse> DescribeCiphersDetail(DescribeCiphersDetailRequest req)
        {
            return InternalRequestAsync<DescribeCiphersDetailResponse>(req, "DescribeCiphersDetail");
        }

        /// <summary>
        /// Query SaaS WAF cipher suite information
        /// </summary>
        /// <param name="req"><see cref="DescribeCiphersDetailRequest"/></param>
        /// <returns><see cref="DescribeCiphersDetailResponse"/></returns>
        public DescribeCiphersDetailResponse DescribeCiphersDetailSync(DescribeCiphersDetailRequest req)
        {
            return InternalRequestAsync<DescribeCiphersDetailResponse>(req, "DescribeCiphersDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the access control policy list in the protection configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleListRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleListResponse"/></returns>
        public Task<DescribeCustomRuleListResponse> DescribeCustomRuleList(DescribeCustomRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCustomRuleListResponse>(req, "DescribeCustomRuleList");
        }

        /// <summary>
        /// Obtain the access control policy list in the protection configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleListRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleListResponse"/></returns>
        public DescribeCustomRuleListResponse DescribeCustomRuleListSync(DescribeCustomRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCustomRuleListResponse>(req, "DescribeCustomRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the precision allowlist policy list in the protection configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeCustomWhiteRuleResponse"/></returns>
        public Task<DescribeCustomWhiteRuleResponse> DescribeCustomWhiteRule(DescribeCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeCustomWhiteRuleResponse>(req, "DescribeCustomWhiteRule");
        }

        /// <summary>
        /// Obtain the precision allowlist policy list in the protection configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeCustomWhiteRuleResponse"/></returns>
        public DescribeCustomWhiteRuleResponse DescribeCustomWhiteRuleSync(DescribeCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeCustomWhiteRuleResponse>(req, "DescribeCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain domain overview
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCountInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainCountInfoResponse"/></returns>
        public Task<DescribeDomainCountInfoResponse> DescribeDomainCountInfo(DescribeDomainCountInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainCountInfoResponse>(req, "DescribeDomainCountInfo");
        }

        /// <summary>
        /// Obtain domain overview
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCountInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainCountInfoResponse"/></returns>
        public DescribeDomainCountInfoResponse DescribeDomainCountInfoSync(DescribeDomainCountInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainCountInfoResponse>(req, "DescribeDomainCountInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain CLB WAF domain details
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsClbRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsClbResponse"/></returns>
        public Task<DescribeDomainDetailsClbResponse> DescribeDomainDetailsClb(DescribeDomainDetailsClbRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsClbResponse>(req, "DescribeDomainDetailsClb");
        }

        /// <summary>
        /// Obtain CLB WAF domain details
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsClbRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsClbResponse"/></returns>
        public DescribeDomainDetailsClbResponse DescribeDomainDetailsClbSync(DescribeDomainDetailsClbRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsClbResponse>(req, "DescribeDomainDetailsClb")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query individual SaaS WAF domain details
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsSaasRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsSaasResponse"/></returns>
        public Task<DescribeDomainDetailsSaasResponse> DescribeDomainDetailsSaas(DescribeDomainDetailsSaasRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsSaasResponse>(req, "DescribeDomainDetailsSaas");
        }

        /// <summary>
        /// Query individual SaaS WAF domain details
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsSaasRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsSaasResponse"/></returns>
        public DescribeDomainDetailsSaasResponse DescribeDomainDetailsSaasSync(DescribeDomainDetailsSaasRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsSaasResponse>(req, "DescribeDomainDetailsSaas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the result of adding domain operation
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeDomainVerifyResultResponse"/></returns>
        public Task<DescribeDomainVerifyResultResponse> DescribeDomainVerifyResult(DescribeDomainVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeDomainVerifyResultResponse>(req, "DescribeDomainVerifyResult");
        }

        /// <summary>
        /// Obtain the result of adding domain operation
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeDomainVerifyResultResponse"/></returns>
        public DescribeDomainVerifyResultResponse DescribeDomainVerifyResultSync(DescribeDomainVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeDomainVerifyResultResponse>(req, "DescribeDomainVerifyResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query detailed information of all user domains
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// Query detailed information of all user domains
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain discovered domain name list API
        /// </summary>
        /// <param name="req"><see cref="DescribeFindDomainListRequest"/></param>
        /// <returns><see cref="DescribeFindDomainListResponse"/></returns>
        public Task<DescribeFindDomainListResponse> DescribeFindDomainList(DescribeFindDomainListRequest req)
        {
            return InternalRequestAsync<DescribeFindDomainListResponse>(req, "DescribeFindDomainList");
        }

        /// <summary>
        /// Obtain discovered domain name list API
        /// </summary>
        /// <param name="req"><see cref="DescribeFindDomainListRequest"/></param>
        /// <returns><see cref="DescribeFindDomainListResponse"/></returns>
        public DescribeFindDomainListResponse DescribeFindDomainListSync(DescribeFindDomainListRequest req)
        {
            return InternalRequestAsync<DescribeFindDomainListResponse>(req, "DescribeFindDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query various conditions of cluster analysis
        /// </summary>
        /// <param name="req"><see cref="DescribeHistogramRequest"/></param>
        /// <returns><see cref="DescribeHistogramResponse"/></returns>
        public Task<DescribeHistogramResponse> DescribeHistogram(DescribeHistogramRequest req)
        {
            return InternalRequestAsync<DescribeHistogramResponse>(req, "DescribeHistogram");
        }

        /// <summary>
        /// Query various conditions of cluster analysis
        /// </summary>
        /// <param name="req"><see cref="DescribeHistogramRequest"/></param>
        /// <returns><see cref="DescribeHistogramResponse"/></returns>
        public DescribeHistogramResponse DescribeHistogramSync(DescribeHistogramRequest req)
        {
            return InternalRequestAsync<DescribeHistogramResponse>(req, "DescribeHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain protection domain details in CLB-WAF
        /// </summary>
        /// <param name="req"><see cref="DescribeHostRequest"/></param>
        /// <returns><see cref="DescribeHostResponse"/></returns>
        public Task<DescribeHostResponse> DescribeHost(DescribeHostRequest req)
        {
            return InternalRequestAsync<DescribeHostResponse>(req, "DescribeHost");
        }

        /// <summary>
        /// Obtain protection domain details in CLB-WAF
        /// </summary>
        /// <param name="req"><see cref="DescribeHostRequest"/></param>
        /// <returns><see cref="DescribeHostResponse"/></returns>
        public DescribeHostResponse DescribeHostSync(DescribeHostRequest req)
        {
            return InternalRequestAsync<DescribeHostResponse>(req, "DescribeHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Firstly verify when adding a domain whether a package has been purchased, whether the limit of purchased package has not been reached, and whether the domain has already been added
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLimitRequest"/></param>
        /// <returns><see cref="DescribeHostLimitResponse"/></returns>
        public Task<DescribeHostLimitResponse> DescribeHostLimit(DescribeHostLimitRequest req)
        {
            return InternalRequestAsync<DescribeHostLimitResponse>(req, "DescribeHostLimit");
        }

        /// <summary>
        /// Firstly verify when adding a domain whether a package has been purchased, whether the limit of purchased package has not been reached, and whether the domain has already been added
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLimitRequest"/></param>
        /// <returns><see cref="DescribeHostLimitResponse"/></returns>
        public DescribeHostLimitResponse DescribeHostLimitSync(DescribeHostLimitRequest req)
        {
            return InternalRequestAsync<DescribeHostLimitResponse>(req, "DescribeHostLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain protection domain list in CLB-WAF
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public Task<DescribeHostsResponse> DescribeHosts(DescribeHostsRequest req)
        {
            return InternalRequestAsync<DescribeHostsResponse>(req, "DescribeHosts");
        }

        /// <summary>
        /// Obtain protection domain list in CLB-WAF
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public DescribeHostsResponse DescribeHostsSync(DescribeHostsRequest req)
        {
            return InternalRequestAsync<DescribeHostsResponse>(req, "DescribeHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query detailed information of all user instances
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// Query detailed information of all user instances
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF IP blocklist/allowlist query
        /// </summary>
        /// <param name="req"><see cref="DescribeIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeIpAccessControlResponse"/></returns>
        public Task<DescribeIpAccessControlResponse> DescribeIpAccessControl(DescribeIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeIpAccessControlResponse>(req, "DescribeIpAccessControl");
        }

        /// <summary>
        /// WAF IP blocklist/allowlist query
        /// </summary>
        /// <param name="req"><see cref="DescribeIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeIpAccessControlResponse"/></returns>
        public DescribeIpAccessControlResponse DescribeIpAccessControlSync(DescribeIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeIpAccessControlResponse>(req, "DescribeIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the switch status of each WAF basic security module, check if each module is enabled
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleStatusRequest"/></param>
        /// <returns><see cref="DescribeModuleStatusResponse"/></returns>
        public Task<DescribeModuleStatusResponse> DescribeModuleStatus(DescribeModuleStatusRequest req)
        {
            return InternalRequestAsync<DescribeModuleStatusResponse>(req, "DescribeModuleStatus");
        }

        /// <summary>
        /// Query the switch status of each WAF basic security module, check if each module is enabled
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleStatusRequest"/></param>
        /// <returns><see cref="DescribeModuleStatusResponse"/></returns>
        public DescribeModuleStatusResponse DescribeModuleStatusSync(DescribeModuleStatusRequest req)
        {
            return InternalRequestAsync<DescribeModuleStatusResponse>(req, "DescribeModuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View protected object list
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectsRequest"/></param>
        /// <returns><see cref="DescribeObjectsResponse"/></returns>
        public Task<DescribeObjectsResponse> DescribeObjects(DescribeObjectsRequest req)
        {
            return InternalRequestAsync<DescribeObjectsResponse>(req, "DescribeObjects");
        }

        /// <summary>
        /// View protected object list
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectsRequest"/></param>
        /// <returns><see cref="DescribeObjectsResponse"/></returns>
        public DescribeObjectsResponse DescribeObjectsSync(DescribeObjectsRequest req)
        {
            return InternalRequestAsync<DescribeObjectsResponse>(req, "DescribeObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query business and attack summary trends
        /// </summary>
        /// <param name="req"><see cref="DescribePeakPointsRequest"/></param>
        /// <returns><see cref="DescribePeakPointsResponse"/></returns>
        public Task<DescribePeakPointsResponse> DescribePeakPoints(DescribePeakPointsRequest req)
        {
            return InternalRequestAsync<DescribePeakPointsResponse>(req, "DescribePeakPoints");
        }

        /// <summary>
        /// Query business and attack summary trends
        /// </summary>
        /// <param name="req"><see cref="DescribePeakPointsRequest"/></param>
        /// <returns><see cref="DescribePeakPointsResponse"/></returns>
        public DescribePeakPointsResponse DescribePeakPointsSync(DescribePeakPointsRequest req)
        {
            return InternalRequestAsync<DescribePeakPointsResponse>(req, "DescribePeakPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain protection status and the effective instance ID
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyStatusRequest"/></param>
        /// <returns><see cref="DescribePolicyStatusResponse"/></returns>
        public Task<DescribePolicyStatusResponse> DescribePolicyStatus(DescribePolicyStatusRequest req)
        {
            return InternalRequestAsync<DescribePolicyStatusResponse>(req, "DescribePolicyStatus");
        }

        /// <summary>
        /// Obtain protection status and the effective instance ID
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyStatusRequest"/></param>
        /// <returns><see cref="DescribePolicyStatusResponse"/></returns>
        public DescribePolicyStatusResponse DescribePolicyStatusSync(DescribePolicyStatusRequest req)
        {
            return InternalRequestAsync<DescribePolicyStatusResponse>(req, "DescribePolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the SaaS-type WAF protection port list
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public Task<DescribePortsResponse> DescribePorts(DescribePortsRequest req)
        {
            return InternalRequestAsync<DescribePortsResponse>(req, "DescribePorts");
        }

        /// <summary>
        /// Obtain the SaaS-type WAF protection port list
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public DescribePortsResponse DescribePortsSync(DescribePortsRequest req)
        {
            return InternalRequestAsync<DescribePortsResponse>(req, "DescribePorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain specific specification limits for each module
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleLimitRequest"/></param>
        /// <returns><see cref="DescribeRuleLimitResponse"/></returns>
        public Task<DescribeRuleLimitResponse> DescribeRuleLimit(DescribeRuleLimitRequest req)
        {
            return InternalRequestAsync<DescribeRuleLimitResponse>(req, "DescribeRuleLimit");
        }

        /// <summary>
        /// Obtain specific specification limits for each module
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleLimitRequest"/></param>
        /// <returns><see cref="DescribeRuleLimitResponse"/></returns>
        public DescribeRuleLimitResponse DescribeRuleLimitSync(DescribeRuleLimitRequest req)
        {
            return InternalRequestAsync<DescribeRuleLimitResponse>(req, "DescribeRuleLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF session definition query API
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public Task<DescribeSessionResponse> DescribeSession(DescribeSessionRequest req)
        {
            return InternalRequestAsync<DescribeSessionResponse>(req, "DescribeSession");
        }

        /// <summary>
        /// WAF session definition query API
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public DescribeSessionResponse DescribeSessionSync(DescribeSessionRequest req)
        {
            return InternalRequestAsync<DescribeSessionResponse>(req, "DescribeSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF Sparta - Obtain protection domain information
        /// </summary>
        /// <param name="req"><see cref="DescribeSpartaProtectionInfoRequest"/></param>
        /// <returns><see cref="DescribeSpartaProtectionInfoResponse"/></returns>
        public Task<DescribeSpartaProtectionInfoResponse> DescribeSpartaProtectionInfo(DescribeSpartaProtectionInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpartaProtectionInfoResponse>(req, "DescribeSpartaProtectionInfo");
        }

        /// <summary>
        /// WAF Sparta - Obtain protection domain information
        /// </summary>
        /// <param name="req"><see cref="DescribeSpartaProtectionInfoRequest"/></param>
        /// <returns><see cref="DescribeSpartaProtectionInfoResponse"/></returns>
        public DescribeSpartaProtectionInfoResponse DescribeSpartaProtectionInfoSync(DescribeSpartaProtectionInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpartaProtectionInfoResponse>(req, "DescribeSpartaProtectionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query TLS versions supported by SaaS WAF.
        /// </summary>
        /// <param name="req"><see cref="DescribeTlsVersionRequest"/></param>
        /// <returns><see cref="DescribeTlsVersionResponse"/></returns>
        public Task<DescribeTlsVersionResponse> DescribeTlsVersion(DescribeTlsVersionRequest req)
        {
            return InternalRequestAsync<DescribeTlsVersionResponse>(req, "DescribeTlsVersion");
        }

        /// <summary>
        /// This API is used to query TLS versions supported by SaaS WAF.
        /// </summary>
        /// <param name="req"><see cref="DescribeTlsVersionRequest"/></param>
        /// <returns><see cref="DescribeTlsVersionResponse"/></returns>
        public DescribeTlsVersionResponse DescribeTlsVersionSync(DescribeTlsVersionRequest req)
        {
            return InternalRequestAsync<DescribeTlsVersionResponse>(req, "DescribeTlsVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query top 5 attack domains
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackDomainRequest"/></param>
        /// <returns><see cref="DescribeTopAttackDomainResponse"/></returns>
        public Task<DescribeTopAttackDomainResponse> DescribeTopAttackDomain(DescribeTopAttackDomainRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackDomainResponse>(req, "DescribeTopAttackDomain");
        }

        /// <summary>
        /// Query top 5 attack domains
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackDomainRequest"/></param>
        /// <returns><see cref="DescribeTopAttackDomainResponse"/></returns>
        public DescribeTopAttackDomainResponse DescribeTopAttackDomainSync(DescribeTopAttackDomainRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackDomainResponse>(req, "DescribeTopAttackDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// During the addition and modification of Domain Configuration for CLB-type WAF, it is required to display the supported region list for CLB-type WAF (clb-waf) through DescribeUserClbWafRegions to obtain the currently available region list for the customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public Task<DescribeUserClbWafRegionsResponse> DescribeUserClbWafRegions(DescribeUserClbWafRegionsRequest req)
        {
            return InternalRequestAsync<DescribeUserClbWafRegionsResponse>(req, "DescribeUserClbWafRegions");
        }

        /// <summary>
        /// During the addition and modification of Domain Configuration for CLB-type WAF, it is required to display the supported region list for CLB-type WAF (clb-waf) through DescribeUserClbWafRegions to obtain the currently available region list for the customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public DescribeUserClbWafRegionsResponse DescribeUserClbWafRegionsSync(DescribeUserClbWafRegionsRequest req)
        {
            return InternalRequestAsync<DescribeUserClbWafRegionsResponse>(req, "DescribeUserClbWafRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Domain Information for SaaS and CLB
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeUserDomainInfoResponse"/></returns>
        public Task<DescribeUserDomainInfoResponse> DescribeUserDomainInfo(DescribeUserDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserDomainInfoResponse>(req, "DescribeUserDomainInfo");
        }

        /// <summary>
        /// Query Domain Information for SaaS and CLB
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeUserDomainInfoResponse"/></returns>
        public DescribeUserDomainInfoResponse DescribeUserDomainInfoSync(DescribeUserDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserDomainInfoResponse>(req, "DescribeUserDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the user protection rule level
        /// </summary>
        /// <param name="req"><see cref="DescribeUserLevelRequest"/></param>
        /// <returns><see cref="DescribeUserLevelResponse"/></returns>
        public Task<DescribeUserLevelResponse> DescribeUserLevel(DescribeUserLevelRequest req)
        {
            return InternalRequestAsync<DescribeUserLevelResponse>(req, "DescribeUserLevel");
        }

        /// <summary>
        /// Obtain the user protection rule level
        /// </summary>
        /// <param name="req"><see cref="DescribeUserLevelRequest"/></param>
        /// <returns><see cref="DescribeUserLevelResponse"/></returns>
        public DescribeUserLevelResponse DescribeUserLevelSync(DescribeUserLevelRequest req)
        {
            return InternalRequestAsync<DescribeUserLevelResponse>(req, "DescribeUserLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query VIP information based on filter criteria
        /// </summary>
        /// <param name="req"><see cref="DescribeVipInfoRequest"/></param>
        /// <returns><see cref="DescribeVipInfoResponse"/></returns>
        public Task<DescribeVipInfoResponse> DescribeVipInfo(DescribeVipInfoRequest req)
        {
            return InternalRequestAsync<DescribeVipInfoResponse>(req, "DescribeVipInfo");
        }

        /// <summary>
        /// Query VIP information based on filter criteria
        /// </summary>
        /// <param name="req"><see cref="DescribeVipInfoRequest"/></param>
        /// <returns><see cref="DescribeVipInfoResponse"/></returns>
        public DescribeVipInfoResponse DescribeVipInfoSync(DescribeVipInfoRequest req)
        {
            return InternalRequestAsync<DescribeVipInfoResponse>(req, "DescribeVipInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the webshell status of a domain
        /// </summary>
        /// <param name="req"><see cref="DescribeWebshellStatusRequest"/></param>
        /// <returns><see cref="DescribeWebshellStatusResponse"/></returns>
        public Task<DescribeWebshellStatusResponse> DescribeWebshellStatus(DescribeWebshellStatusRequest req)
        {
            return InternalRequestAsync<DescribeWebshellStatusResponse>(req, "DescribeWebshellStatus");
        }

        /// <summary>
        /// Obtain the webshell status of a domain
        /// </summary>
        /// <param name="req"><see cref="DescribeWebshellStatusRequest"/></param>
        /// <returns><see cref="DescribeWebshellStatusResponse"/></returns>
        public DescribeWebshellStatusResponse DescribeWebshellStatusSync(DescribeWebshellStatusRequest req)
        {
            return InternalRequestAsync<DescribeWebshellStatusResponse>(req, "DescribeWebshellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refresh a tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="FreshAntiFakeUrlRequest"/></param>
        /// <returns><see cref="FreshAntiFakeUrlResponse"/></returns>
        public Task<FreshAntiFakeUrlResponse> FreshAntiFakeUrl(FreshAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<FreshAntiFakeUrlResponse>(req, "FreshAntiFakeUrl");
        }

        /// <summary>
        /// Refresh a tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="FreshAntiFakeUrlRequest"/></param>
        /// <returns><see cref="FreshAntiFakeUrlResponse"/></returns>
        public FreshAntiFakeUrlResponse FreshAntiFakeUrlSync(FreshAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<FreshAntiFakeUrlResponse>(req, "FreshAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Billing Resource Purchase, Renewal Order API
        /// </summary>
        /// <param name="req"><see cref="GenerateDealsAndPayNewRequest"/></param>
        /// <returns><see cref="GenerateDealsAndPayNewResponse"/></returns>
        public Task<GenerateDealsAndPayNewResponse> GenerateDealsAndPayNew(GenerateDealsAndPayNewRequest req)
        {
            return InternalRequestAsync<GenerateDealsAndPayNewResponse>(req, "GenerateDealsAndPayNew");
        }

        /// <summary>
        /// Billing Resource Purchase, Renewal Order API
        /// </summary>
        /// <param name="req"><see cref="GenerateDealsAndPayNewRequest"/></param>
        /// <returns><see cref="GenerateDealsAndPayNewResponse"/></returns>
        public GenerateDealsAndPayNewResponse GenerateDealsAndPayNewSync(GenerateDealsAndPayNewRequest req)
        {
            return InternalRequestAsync<GenerateDealsAndPayNewResponse>(req, "GenerateDealsAndPayNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a bar chart for the generation time of attack logs.
        /// </summary>
        /// <param name="req"><see cref="GetAttackHistogramRequest"/></param>
        /// <returns><see cref="GetAttackHistogramResponse"/></returns>
        public Task<GetAttackHistogramResponse> GetAttackHistogram(GetAttackHistogramRequest req)
        {
            return InternalRequestAsync<GetAttackHistogramResponse>(req, "GetAttackHistogram");
        }

        /// <summary>
        /// This API is used to generate a bar chart for the generation time of attack logs.
        /// </summary>
        /// <param name="req"><see cref="GetAttackHistogramRequest"/></param>
        /// <returns><see cref="GetAttackHistogramResponse"/></returns>
        public GetAttackHistogramResponse GetAttackHistogramSync(GetAttackHistogramRequest req)
        {
            return InternalRequestAsync<GetAttackHistogramResponse>(req, "GetAttackHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Display total attack count by querying based on conditions
        /// </summary>
        /// <param name="req"><see cref="GetAttackTotalCountRequest"/></param>
        /// <returns><see cref="GetAttackTotalCountResponse"/></returns>
        public Task<GetAttackTotalCountResponse> GetAttackTotalCount(GetAttackTotalCountRequest req)
        {
            return InternalRequestAsync<GetAttackTotalCountResponse>(req, "GetAttackTotalCount");
        }

        /// <summary>
        /// Display total attack count by querying based on conditions
        /// </summary>
        /// <param name="req"><see cref="GetAttackTotalCountRequest"/></param>
        /// <returns><see cref="GetAttackTotalCountResponse"/></returns>
        public GetAttackTotalCountResponse GetAttackTotalCountSync(GetAttackTotalCountRequest req)
        {
            return InternalRequestAsync<GetAttackTotalCountResponse>(req, "GetAttackTotalCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the elastic QPS limit of package instances
        /// </summary>
        /// <param name="req"><see cref="GetInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="GetInstanceQpsLimitResponse"/></returns>
        public Task<GetInstanceQpsLimitResponse> GetInstanceQpsLimit(GetInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<GetInstanceQpsLimitResponse>(req, "GetInstanceQpsLimit");
        }

        /// <summary>
        /// Obtain the elastic QPS limit of package instances
        /// </summary>
        /// <param name="req"><see cref="GetInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="GetInstanceQpsLimitResponse"/></returns>
        public GetInstanceQpsLimitResponse GetInstanceQpsLimitSync(GetInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<GetInstanceQpsLimitResponse>(req, "GetInstanceQpsLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="ImportIpAccessControlRequest"/></param>
        /// <returns><see cref="ImportIpAccessControlResponse"/></returns>
        public Task<ImportIpAccessControlResponse> ImportIpAccessControl(ImportIpAccessControlRequest req)
        {
            return InternalRequestAsync<ImportIpAccessControlResponse>(req, "ImportIpAccessControl");
        }

        /// <summary>
        /// This API is used to import IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="ImportIpAccessControlRequest"/></param>
        /// <returns><see cref="ImportIpAccessControlResponse"/></returns>
        public ImportIpAccessControlResponse ImportIpAccessControlSync(ImportIpAccessControlRequest req)
        {
            return InternalRequestAsync<ImportIpAccessControlResponse>(req, "ImportIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit a tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlResponse"/></returns>
        public Task<ModifyAntiFakeUrlResponse> ModifyAntiFakeUrl(ModifyAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlResponse>(req, "ModifyAntiFakeUrl");
        }

        /// <summary>
        /// Edit a tamper-proof URL
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlResponse"/></returns>
        public ModifyAntiFakeUrlResponse ModifyAntiFakeUrlSync(ModifyAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlResponse>(req, "ModifyAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Toggle tamper-proof switch
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlStatusResponse"/></returns>
        public Task<ModifyAntiFakeUrlStatusResponse> ModifyAntiFakeUrlStatus(ModifyAntiFakeUrlStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlStatusResponse>(req, "ModifyAntiFakeUrlStatus");
        }

        /// <summary>
        /// Toggle tamper-proof switch
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlStatusResponse"/></returns>
        public ModifyAntiFakeUrlStatusResponse ModifyAntiFakeUrlStatusSync(ModifyAntiFakeUrlStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlStatusResponse>(req, "ModifyAntiFakeUrlStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Information leakage prevention toggle rule switch
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRuleStatusResponse"/></returns>
        public Task<ModifyAntiInfoLeakRuleStatusResponse> ModifyAntiInfoLeakRuleStatus(ModifyAntiInfoLeakRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRuleStatusResponse>(req, "ModifyAntiInfoLeakRuleStatus");
        }

        /// <summary>
        /// Information leakage prevention toggle rule switch
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRuleStatusResponse"/></returns>
        public ModifyAntiInfoLeakRuleStatusResponse ModifyAntiInfoLeakRuleStatusSync(ModifyAntiInfoLeakRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRuleStatusResponse>(req, "ModifyAntiInfoLeakRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit an information leakage prevention rule
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRulesResponse"/></returns>
        public Task<ModifyAntiInfoLeakRulesResponse> ModifyAntiInfoLeakRules(ModifyAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRulesResponse>(req, "ModifyAntiInfoLeakRules");
        }

        /// <summary>
        /// Edit an information leakage prevention rule
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRulesResponse"/></returns>
        public ModifyAntiInfoLeakRulesResponse ModifyAntiInfoLeakRulesSync(ModifyAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRulesResponse>(req, "ModifyAntiInfoLeakRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API analysis page switch
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAnalyzeStatusRequest"/></param>
        /// <returns><see cref="ModifyApiAnalyzeStatusResponse"/></returns>
        public Task<ModifyApiAnalyzeStatusResponse> ModifyApiAnalyzeStatus(ModifyApiAnalyzeStatusRequest req)
        {
            return InternalRequestAsync<ModifyApiAnalyzeStatusResponse>(req, "ModifyApiAnalyzeStatus");
        }

        /// <summary>
        /// API analysis page switch
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAnalyzeStatusRequest"/></param>
        /// <returns><see cref="ModifyApiAnalyzeStatusResponse"/></returns>
        public ModifyApiAnalyzeStatusResponse ModifyApiAnalyzeStatusSync(ModifyApiAnalyzeStatusRequest req)
        {
            return InternalRequestAsync<ModifyApiAnalyzeStatusResponse>(req, "ModifyApiAnalyzeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bot_V2 bot master switch update
        /// </summary>
        /// <param name="req"><see cref="ModifyBotStatusRequest"/></param>
        /// <returns><see cref="ModifyBotStatusResponse"/></returns>
        public Task<ModifyBotStatusResponse> ModifyBotStatus(ModifyBotStatusRequest req)
        {
            return InternalRequestAsync<ModifyBotStatusResponse>(req, "ModifyBotStatus");
        }

        /// <summary>
        /// Bot_V2 bot master switch update
        /// </summary>
        /// <param name="req"><see cref="ModifyBotStatusRequest"/></param>
        /// <returns><see cref="ModifyBotStatusResponse"/></returns>
        public ModifyBotStatusResponse ModifyBotStatusSync(ModifyBotStatusRequest req)
        {
            return InternalRequestAsync<ModifyBotStatusResponse>(req, "ModifyBotStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a custom rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public Task<ModifyCustomRuleResponse> ModifyCustomRule(ModifyCustomRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleResponse>(req, "ModifyCustomRule");
        }

        /// <summary>
        /// This API is used to edit a custom rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public ModifyCustomRuleResponse ModifyCustomRuleSync(ModifyCustomRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleResponse>(req, "ModifyCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable or disable access control (from custom policy)
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public Task<ModifyCustomRuleStatusResponse> ModifyCustomRuleStatus(ModifyCustomRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleStatusResponse>(req, "ModifyCustomRuleStatus");
        }

        /// <summary>
        /// Enable or disable access control (from custom policy)
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public ModifyCustomRuleStatusResponse ModifyCustomRuleStatusSync(ModifyCustomRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleStatusResponse>(req, "ModifyCustomRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a precise allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleResponse"/></returns>
        public Task<ModifyCustomWhiteRuleResponse> ModifyCustomWhiteRule(ModifyCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleResponse>(req, "ModifyCustomWhiteRule");
        }

        /// <summary>
        /// This API is used to edit a precise allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleResponse"/></returns>
        public ModifyCustomWhiteRuleResponse ModifyCustomWhiteRuleSync(ModifyCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleResponse>(req, "ModifyCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable or disable a precision allowlist
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleStatusResponse"/></returns>
        public Task<ModifyCustomWhiteRuleStatusResponse> ModifyCustomWhiteRuleStatus(ModifyCustomWhiteRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleStatusResponse>(req, "ModifyCustomWhiteRuleStatus");
        }

        /// <summary>
        /// Enable or disable a precision allowlist
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleStatusResponse"/></returns>
        public ModifyCustomWhiteRuleStatusResponse ModifyCustomWhiteRuleStatusSync(ModifyCustomWhiteRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleStatusResponse>(req, "ModifyCustomWhiteRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Toggle the IPv6 switch
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainIpv6StatusRequest"/></param>
        /// <returns><see cref="ModifyDomainIpv6StatusResponse"/></returns>
        public Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6Status(ModifyDomainIpv6StatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainIpv6StatusResponse>(req, "ModifyDomainIpv6Status");
        }

        /// <summary>
        /// Toggle the IPv6 switch
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainIpv6StatusRequest"/></param>
        /// <returns><see cref="ModifyDomainIpv6StatusResponse"/></returns>
        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6StatusSync(ModifyDomainIpv6StatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainIpv6StatusResponse>(req, "ModifyDomainIpv6Status")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the domain shipping status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainPostActionRequest"/></param>
        /// <returns><see cref="ModifyDomainPostActionResponse"/></returns>
        public Task<ModifyDomainPostActionResponse> ModifyDomainPostAction(ModifyDomainPostActionRequest req)
        {
            return InternalRequestAsync<ModifyDomainPostActionResponse>(req, "ModifyDomainPostAction");
        }

        /// <summary>
        /// This API is used to modify the domain shipping status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainPostActionRequest"/></param>
        /// <returns><see cref="ModifyDomainPostActionResponse"/></returns>
        public ModifyDomainPostActionResponse ModifyDomainPostActionSync(ModifyDomainPostActionRequest req)
        {
            return InternalRequestAsync<ModifyDomainPostActionResponse>(req, "ModifyDomainPostAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable or disable access log for domain list
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainsCLSStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainsCLSStatusResponse"/></returns>
        public Task<ModifyDomainsCLSStatusResponse> ModifyDomainsCLSStatus(ModifyDomainsCLSStatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainsCLSStatusResponse>(req, "ModifyDomainsCLSStatus");
        }

        /// <summary>
        /// Enable or disable access log for domain list
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainsCLSStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainsCLSStatusResponse"/></returns>
        public ModifyDomainsCLSStatusResponse ModifyDomainsCLSStatusSync(ModifyDomainsCLSStatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainsCLSStatusResponse>(req, "ModifyDomainsCLSStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the configuration of domain names protected by CLB WAF.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostRequest"/></param>
        /// <returns><see cref="ModifyHostResponse"/></returns>
        public Task<ModifyHostResponse> ModifyHost(ModifyHostRequest req)
        {
            return InternalRequestAsync<ModifyHostResponse>(req, "ModifyHost");
        }

        /// <summary>
        /// This API is used to edit the configuration of domain names protected by CLB WAF.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostRequest"/></param>
        /// <returns><see cref="ModifyHostResponse"/></returns>
        public ModifyHostResponse ModifyHostSync(ModifyHostRequest req)
        {
            return InternalRequestAsync<ModifyHostResponse>(req, "ModifyHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the traffic mode for domain names protected by CLB WAF. The mode can be mirror mode or cleaning mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostFlowModeRequest"/></param>
        /// <returns><see cref="ModifyHostFlowModeResponse"/></returns>
        public Task<ModifyHostFlowModeResponse> ModifyHostFlowMode(ModifyHostFlowModeRequest req)
        {
            return InternalRequestAsync<ModifyHostFlowModeResponse>(req, "ModifyHostFlowMode");
        }

        /// <summary>
        /// This API is used to set the traffic mode for domain names protected by CLB WAF. The mode can be mirror mode or cleaning mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostFlowModeRequest"/></param>
        /// <returns><see cref="ModifyHostFlowModeResponse"/></returns>
        public ModifyHostFlowModeResponse ModifyHostFlowModeSync(ModifyHostFlowModeRequest req)
        {
            return InternalRequestAsync<ModifyHostFlowModeResponse>(req, "ModifyHostFlowMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set CLB WAF protection domain status
        /// </summary>
        /// <param name="req"><see cref="ModifyHostModeRequest"/></param>
        /// <returns><see cref="ModifyHostModeResponse"/></returns>
        public Task<ModifyHostModeResponse> ModifyHostMode(ModifyHostModeRequest req)
        {
            return InternalRequestAsync<ModifyHostModeResponse>(req, "ModifyHostMode");
        }

        /// <summary>
        /// Set CLB WAF protection domain status
        /// </summary>
        /// <param name="req"><see cref="ModifyHostModeRequest"/></param>
        /// <returns><see cref="ModifyHostModeResponse"/></returns>
        public ModifyHostModeResponse ModifyHostModeSync(ModifyHostModeRequest req)
        {
            return InternalRequestAsync<ModifyHostModeResponse>(req, "ModifyHostMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable CLB WAF for a protected domain name.
        /// Batch operation is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostStatusRequest"/></param>
        /// <returns><see cref="ModifyHostStatusResponse"/></returns>
        public Task<ModifyHostStatusResponse> ModifyHostStatus(ModifyHostStatusRequest req)
        {
            return InternalRequestAsync<ModifyHostStatusResponse>(req, "ModifyHostStatus");
        }

        /// <summary>
        /// This API is used to enable or disable CLB WAF for a protected domain name.
        /// Batch operation is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostStatusRequest"/></param>
        /// <returns><see cref="ModifyHostStatusResponse"/></returns>
        public ModifyHostStatusResponse ModifyHostStatusSync(ModifyHostStatusRequest req)
        {
            return InternalRequestAsync<ModifyHostStatusResponse>(req, "ModifyHostStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the QPS elastic billing switch for an instance
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceElasticModeRequest"/></param>
        /// <returns><see cref="ModifyInstanceElasticModeResponse"/></returns>
        public Task<ModifyInstanceElasticModeResponse> ModifyInstanceElasticMode(ModifyInstanceElasticModeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceElasticModeResponse>(req, "ModifyInstanceElasticMode");
        }

        /// <summary>
        /// Modify the QPS elastic billing switch for an instance
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceElasticModeRequest"/></param>
        /// <returns><see cref="ModifyInstanceElasticModeResponse"/></returns>
        public ModifyInstanceElasticModeResponse ModifyInstanceElasticModeSync(ModifyInstanceElasticModeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceElasticModeResponse>(req, "ModifyInstanceElasticMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify instance name
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName");
        }

        /// <summary>
        /// Modify instance name
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set elastic QPS limit for package instances
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="ModifyInstanceQpsLimitResponse"/></returns>
        public Task<ModifyInstanceQpsLimitResponse> ModifyInstanceQpsLimit(ModifyInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<ModifyInstanceQpsLimitResponse>(req, "ModifyInstanceQpsLimit");
        }

        /// <summary>
        /// Set elastic QPS limit for package instances
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="ModifyInstanceQpsLimitResponse"/></returns>
        public ModifyInstanceQpsLimitResponse ModifyInstanceQpsLimitSync(ModifyInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<ModifyInstanceQpsLimitResponse>(req, "ModifyInstanceQpsLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable or disable auto-renewal for instance
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstanceRenewFlagResponse"/></returns>
        public Task<ModifyInstanceRenewFlagResponse> ModifyInstanceRenewFlag(ModifyInstanceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceRenewFlagResponse>(req, "ModifyInstanceRenewFlag");
        }

        /// <summary>
        /// Enable or disable auto-renewal for instance
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstanceRenewFlagResponse"/></returns>
        public ModifyInstanceRenewFlagResponse ModifyInstanceRenewFlagSync(ModifyInstanceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceRenewFlagResponse>(req, "ModifyInstanceRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit WAF IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpAccessControlRequest"/></param>
        /// <returns><see cref="ModifyIpAccessControlResponse"/></returns>
        public Task<ModifyIpAccessControlResponse> ModifyIpAccessControl(ModifyIpAccessControlRequest req)
        {
            return InternalRequestAsync<ModifyIpAccessControlResponse>(req, "ModifyIpAccessControl");
        }

        /// <summary>
        /// This API is used to edit WAF IP allowlists/blocklists.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpAccessControlRequest"/></param>
        /// <returns><see cref="ModifyIpAccessControlResponse"/></returns>
        public ModifyIpAccessControlResponse ModifyIpAccessControlSync(ModifyIpAccessControlRequest req)
        {
            return InternalRequestAsync<ModifyIpAccessControlResponse>(req, "ModifyIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set the switch for the basic security module under a certain domain
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleStatusRequest"/></param>
        /// <returns><see cref="ModifyModuleStatusResponse"/></returns>
        public Task<ModifyModuleStatusResponse> ModifyModuleStatus(ModifyModuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyModuleStatusResponse>(req, "ModifyModuleStatus");
        }

        /// <summary>
        /// Set the switch for the basic security module under a certain domain
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleStatusRequest"/></param>
        /// <returns><see cref="ModifyModuleStatusResponse"/></returns>
        public ModifyModuleStatusResponse ModifyModuleStatusSync(ModifyModuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyModuleStatusResponse>(req, "ModifyModuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify protection object
        /// </summary>
        /// <param name="req"><see cref="ModifyObjectRequest"/></param>
        /// <returns><see cref="ModifyObjectResponse"/></returns>
        public Task<ModifyObjectResponse> ModifyObject(ModifyObjectRequest req)
        {
            return InternalRequestAsync<ModifyObjectResponse>(req, "ModifyObject");
        }

        /// <summary>
        /// Modify protection object
        /// </summary>
        /// <param name="req"><see cref="ModifyObjectRequest"/></param>
        /// <returns><see cref="ModifyObjectResponse"/></returns>
        public ModifyObjectResponse ModifyObjectSync(ModifyObjectRequest req)
        {
            return InternalRequestAsync<ModifyObjectResponse>(req, "ModifyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the enabling status of the basic security protection module of WAF.
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionStatusRequest"/></param>
        /// <returns><see cref="ModifyProtectionStatusResponse"/></returns>
        public Task<ModifyProtectionStatusResponse> ModifyProtectionStatus(ModifyProtectionStatusRequest req)
        {
            return InternalRequestAsync<ModifyProtectionStatusResponse>(req, "ModifyProtectionStatus");
        }

        /// <summary>
        /// This API is used to obtain the enabling status of the basic security protection module of WAF.
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionStatusRequest"/></param>
        /// <returns><see cref="ModifyProtectionStatusResponse"/></returns>
        public ModifyProtectionStatusResponse ModifyProtectionStatusSync(ModifyProtectionStatusRequest req)
        {
            return InternalRequestAsync<ModifyProtectionStatusResponse>(req, "ModifyProtectionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the configuration of domain names protected by SaaS WAF.
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionResponse"/></returns>
        public Task<ModifySpartaProtectionResponse> ModifySpartaProtection(ModifySpartaProtectionRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionResponse>(req, "ModifySpartaProtection");
        }

        /// <summary>
        /// This API is used to edit the configuration of domain names protected by SaaS WAF.
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionResponse"/></returns>
        public ModifySpartaProtectionResponse ModifySpartaProtectionSync(ModifySpartaProtectionRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionResponse>(req, "ModifySpartaProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set WAF protection status
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionModeRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionModeResponse"/></returns>
        public Task<ModifySpartaProtectionModeResponse> ModifySpartaProtectionMode(ModifySpartaProtectionModeRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionModeResponse>(req, "ModifySpartaProtectionMode");
        }

        /// <summary>
        /// Set WAF protection status
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionModeRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionModeResponse"/></returns>
        public ModifySpartaProtectionModeResponse ModifySpartaProtectionModeSync(ModifySpartaProtectionModeRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionModeResponse>(req, "ModifySpartaProtectionMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the user protection rule level
        /// </summary>
        /// <param name="req"><see cref="ModifyUserLevelRequest"/></param>
        /// <returns><see cref="ModifyUserLevelResponse"/></returns>
        public Task<ModifyUserLevelResponse> ModifyUserLevel(ModifyUserLevelRequest req)
        {
            return InternalRequestAsync<ModifyUserLevelResponse>(req, "ModifyUserLevel");
        }

        /// <summary>
        /// Modify the user protection rule level
        /// </summary>
        /// <param name="req"><see cref="ModifyUserLevelRequest"/></param>
        /// <returns><see cref="ModifyUserLevelResponse"/></returns>
        public ModifyUserLevelResponse ModifyUserLevelSync(ModifyUserLevelRequest req)
        {
            return InternalRequestAsync<ModifyUserLevelResponse>(req, "ModifyUserLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify user protection rules, turn on/off specific rules
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleResponse"/></returns>
        public Task<ModifyUserSignatureRuleResponse> ModifyUserSignatureRule(ModifyUserSignatureRuleRequest req)
        {
            return InternalRequestAsync<ModifyUserSignatureRuleResponse>(req, "ModifyUserSignatureRule");
        }

        /// <summary>
        /// Modify user protection rules, turn on/off specific rules
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleResponse"/></returns>
        public ModifyUserSignatureRuleResponse ModifyUserSignatureRuleSync(ModifyUserSignatureRuleRequest req)
        {
            return InternalRequestAsync<ModifyUserSignatureRuleResponse>(req, "ModifyUserSignatureRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set the Webshell status of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebshellStatusRequest"/></param>
        /// <returns><see cref="ModifyWebshellStatusResponse"/></returns>
        public Task<ModifyWebshellStatusResponse> ModifyWebshellStatus(ModifyWebshellStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebshellStatusResponse>(req, "ModifyWebshellStatus");
        }

        /// <summary>
        /// Set the Webshell status of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebshellStatusRequest"/></param>
        /// <returns><see cref="ModifyWebshellStatusResponse"/></returns>
        public ModifyWebshellStatusResponse ModifyWebshellStatusSync(ModifyWebshellStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebshellStatusResponse>(req, "ModifyWebshellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refresh integration check results. The backend will generate integration check tasks
        /// </summary>
        /// <param name="req"><see cref="RefreshAccessCheckResultRequest"/></param>
        /// <returns><see cref="RefreshAccessCheckResultResponse"/></returns>
        public Task<RefreshAccessCheckResultResponse> RefreshAccessCheckResult(RefreshAccessCheckResultRequest req)
        {
            return InternalRequestAsync<RefreshAccessCheckResultResponse>(req, "RefreshAccessCheckResult");
        }

        /// <summary>
        /// Refresh integration check results. The backend will generate integration check tasks
        /// </summary>
        /// <param name="req"><see cref="RefreshAccessCheckResultRequest"/></param>
        /// <returns><see cref="RefreshAccessCheckResultResponse"/></returns>
        public RefreshAccessCheckResultResponse RefreshAccessCheckResultSync(RefreshAccessCheckResultRequest req)
        {
            return InternalRequestAsync<RefreshAccessCheckResultResponse>(req, "RefreshAccessCheckResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The new version of the CLS API has parameter changes, with query changed to query_string to support Lucene syntax for API search queries.
        /// </summary>
        /// <param name="req"><see cref="SearchAttackLogRequest"/></param>
        /// <returns><see cref="SearchAttackLogResponse"/></returns>
        public Task<SearchAttackLogResponse> SearchAttackLog(SearchAttackLogRequest req)
        {
            return InternalRequestAsync<SearchAttackLogResponse>(req, "SearchAttackLog");
        }

        /// <summary>
        /// The new version of the CLS API has parameter changes, with query changed to query_string to support Lucene syntax for API search queries.
        /// </summary>
        /// <param name="req"><see cref="SearchAttackLogRequest"/></param>
        /// <returns><see cref="SearchAttackLogResponse"/></returns>
        public SearchAttackLogResponse SearchAttackLogSync(SearchAttackLogRequest req)
        {
            return InternalRequestAsync<SearchAttackLogResponse>(req, "SearchAttackLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Toggle elasticity switch
        /// </summary>
        /// <param name="req"><see cref="SwitchElasticModeRequest"/></param>
        /// <returns><see cref="SwitchElasticModeResponse"/></returns>
        public Task<SwitchElasticModeResponse> SwitchElasticMode(SwitchElasticModeRequest req)
        {
            return InternalRequestAsync<SwitchElasticModeResponse>(req, "SwitchElasticMode");
        }

        /// <summary>
        /// Toggle elasticity switch
        /// </summary>
        /// <param name="req"><see cref="SwitchElasticModeRequest"/></param>
        /// <returns><see cref="SwitchElasticModeResponse"/></returns>
        public SwitchElasticModeResponse SwitchElasticModeSync(SwitchElasticModeRequest req)
        {
            return InternalRequestAsync<SwitchElasticModeResponse>(req, "SwitchElasticMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF CC V2 upsert API
        /// </summary>
        /// <param name="req"><see cref="UpsertCCRuleRequest"/></param>
        /// <returns><see cref="UpsertCCRuleResponse"/></returns>
        public Task<UpsertCCRuleResponse> UpsertCCRule(UpsertCCRuleRequest req)
        {
            return InternalRequestAsync<UpsertCCRuleResponse>(req, "UpsertCCRule");
        }

        /// <summary>
        /// WAF CC V2 upsert API
        /// </summary>
        /// <param name="req"><see cref="UpsertCCRuleRequest"/></param>
        /// <returns><see cref="UpsertCCRuleResponse"/></returns>
        public UpsertCCRuleResponse UpsertCCRuleSync(UpsertCCRuleRequest req)
        {
            return InternalRequestAsync<UpsertCCRuleResponse>(req, "UpsertCCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WAF session definition upsert API
        /// </summary>
        /// <param name="req"><see cref="UpsertSessionRequest"/></param>
        /// <returns><see cref="UpsertSessionResponse"/></returns>
        public Task<UpsertSessionResponse> UpsertSession(UpsertSessionRequest req)
        {
            return InternalRequestAsync<UpsertSessionResponse>(req, "UpsertSession");
        }

        /// <summary>
        /// WAF session definition upsert API
        /// </summary>
        /// <param name="req"><see cref="UpsertSessionRequest"/></param>
        /// <returns><see cref="UpsertSessionResponse"/></returns>
        public UpsertSessionResponse UpsertSessionSync(UpsertSessionRequest req)
        {
            return InternalRequestAsync<UpsertSessionResponse>(req, "UpsertSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
