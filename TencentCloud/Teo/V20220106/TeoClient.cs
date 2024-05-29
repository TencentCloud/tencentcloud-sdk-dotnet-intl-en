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

namespace TencentCloud.Teo.V20220106
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Teo.V20220106.Models;

   public class TeoClient : AbstractClient{

       private const string endpoint = "teo.tencentcloudapi.com";
       private const string version = "2022-01-06";
       private const string sdkVersion = "SDK_NET_3.0.908";

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
        /// This API is used to verify a certificate.
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateRequest"/></param>
        /// <returns><see cref="CheckCertificateResponse"/></returns>
        public Task<CheckCertificateResponse> CheckCertificate(CheckCertificateRequest req)
        {
            return InternalRequestAsync<CheckCertificateResponse>(req, "CheckCertificate");
        }

        /// <summary>
        /// This API is used to verify a certificate.
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateRequest"/></param>
        /// <returns><see cref="CheckCertificateResponse"/></returns>
        public CheckCertificateResponse CheckCertificateSync(CheckCertificateRequest req)
        {
            return InternalRequestAsync<CheckCertificateResponse>(req, "CheckCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application proxy.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public Task<CreateApplicationProxyResponse> CreateApplicationProxy(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy");
        }

        /// <summary>
        /// This API is used to create an application proxy.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public CreateApplicationProxyResponse CreateApplicationProxySync(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public Task<CreateApplicationProxyRuleResponse> CreateApplicationProxyRule(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule");
        }

        /// <summary>
        /// This API is used to create an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public CreateApplicationProxyRuleResponse CreateApplicationProxyRuleSync(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch create application proxy rules.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRulesRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRulesResponse"/></returns>
        public Task<CreateApplicationProxyRulesResponse> CreateApplicationProxyRules(CreateApplicationProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRulesResponse>(req, "CreateApplicationProxyRules");
        }

        /// <summary>
        /// This API is used to batch create application proxy rules.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRulesRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRulesResponse"/></returns>
        public CreateApplicationProxyRulesResponse CreateApplicationProxyRulesSync(CreateApplicationProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRulesResponse>(req, "CreateApplicationProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom error page.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomErrorPageResponse"/></returns>
        public Task<CreateCustomErrorPageResponse> CreateCustomErrorPage(CreateCustomErrorPageRequest req)
        {
            return InternalRequestAsync<CreateCustomErrorPageResponse>(req, "CreateCustomErrorPage");
        }

        /// <summary>
        /// This API is used to create a custom error page.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomErrorPageResponse"/></returns>
        public CreateCustomErrorPageResponse CreateCustomErrorPageSync(CreateCustomErrorPageRequest req)
        {
            return InternalRequestAsync<CreateCustomErrorPageResponse>(req, "CreateCustomErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a DNS record.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public Task<CreateDnsRecordResponse> CreateDnsRecord(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord");
        }

        /// <summary>
        /// This API is used to create a DNS record.
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public CreateDnsRecordResponse CreateDnsRecordSync(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancingRequest"/></param>
        /// <returns><see cref="CreateLoadBalancingResponse"/></returns>
        public Task<CreateLoadBalancingResponse> CreateLoadBalancing(CreateLoadBalancingRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancingResponse>(req, "CreateLoadBalancing");
        }

        /// <summary>
        /// This API is used to create a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancingRequest"/></param>
        /// <returns><see cref="CreateLoadBalancingResponse"/></returns>
        public CreateLoadBalancingResponse CreateLoadBalancingSync(CreateLoadBalancingRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancingResponse>(req, "CreateLoadBalancing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an origin group.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public Task<CreateOriginGroupResponse> CreateOriginGroup(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup");
        }

        /// <summary>
        /// This API is used to create an origin group.
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public CreateOriginGroupResponse CreateOriginGroupSync(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup")
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
        /// This API is used to create a cache purging task.
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public Task<CreatePurgeTaskResponse> CreatePurgeTask(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask");
        }

        /// <summary>
        /// This API is used to create a cache purging task.
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public CreatePurgeTaskResponse CreatePurgeTaskSync(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access a new site.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone");
        }

        /// <summary>
        /// This API is used to access a new site.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an application proxy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public Task<DeleteApplicationProxyResponse> DeleteApplicationProxy(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy");
        }

        /// <summary>
        /// This API is used to delete an application proxy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public DeleteApplicationProxyResponse DeleteApplicationProxySync(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public Task<DeleteApplicationProxyRuleResponse> DeleteApplicationProxyRule(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule");
        }

        /// <summary>
        /// This API is used to delete an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public DeleteApplicationProxyRuleResponse DeleteApplicationProxyRuleSync(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete DNS records.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public Task<DeleteDnsRecordsResponse> DeleteDnsRecords(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords");
        }

        /// <summary>
        /// This API is used to batch delete DNS records.
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public DeleteDnsRecordsResponse DeleteDnsRecordsSync(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancingRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancingResponse"/></returns>
        public Task<DeleteLoadBalancingResponse> DeleteLoadBalancing(DeleteLoadBalancingRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancingResponse>(req, "DeleteLoadBalancing");
        }

        /// <summary>
        /// This API is used to delete a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancingRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancingResponse"/></returns>
        public DeleteLoadBalancingResponse DeleteLoadBalancingSync(DeleteLoadBalancingRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancingResponse>(req, "DeleteLoadBalancing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an origin group.
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public Task<DeleteOriginGroupResponse> DeleteOriginGroup(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup");
        }

        /// <summary>
        /// This API is used to delete an origin group.
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public DeleteOriginGroupResponse DeleteOriginGroupSync(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup")
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
        /// This API is used to obtain a list of application proxies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyResponse"/></returns>
        public Task<DescribeApplicationProxyResponse> DescribeApplicationProxy(DescribeApplicationProxyRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxyResponse>(req, "DescribeApplicationProxy");
        }

        /// <summary>
        /// This API is used to obtain a list of application proxies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyResponse"/></returns>
        public DescribeApplicationProxyResponse DescribeApplicationProxySync(DescribeApplicationProxyRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxyResponse>(req, "DescribeApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the details of an application proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyDetailResponse"/></returns>
        public Task<DescribeApplicationProxyDetailResponse> DescribeApplicationProxyDetail(DescribeApplicationProxyDetailRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxyDetailResponse>(req, "DescribeApplicationProxyDetail");
        }

        /// <summary>
        /// This API is used to obtain the details of an application proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyDetailResponse"/></returns>
        public DescribeApplicationProxyDetailResponse DescribeApplicationProxyDetailSync(DescribeApplicationProxyDetailRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxyDetailResponse>(req, "DescribeApplicationProxyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query bot attack logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotLogRequest"/></param>
        /// <returns><see cref="DescribeBotLogResponse"/></returns>
        public Task<DescribeBotLogResponse> DescribeBotLog(DescribeBotLogRequest req)
        {
            return InternalRequestAsync<DescribeBotLogResponse>(req, "DescribeBotLog");
        }

        /// <summary>
        /// This API is used to query bot attack logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotLogRequest"/></param>
        /// <returns><see cref="DescribeBotLogResponse"/></returns>
        public DescribeBotLogResponse DescribeBotLogSync(DescribeBotLogRequest req)
        {
            return InternalRequestAsync<DescribeBotLogResponse>(req, "DescribeBotLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query bot managed rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeBotManagedRulesResponse"/></returns>
        public Task<DescribeBotManagedRulesResponse> DescribeBotManagedRules(DescribeBotManagedRulesRequest req)
        {
            return InternalRequestAsync<DescribeBotManagedRulesResponse>(req, "DescribeBotManagedRules");
        }

        /// <summary>
        /// This API is used to query bot managed rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeBotManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeBotManagedRulesResponse"/></returns>
        public DescribeBotManagedRulesResponse DescribeBotManagedRulesSync(DescribeBotManagedRulesRequest req)
        {
            return InternalRequestAsync<DescribeBotManagedRulesResponse>(req, "DescribeBotManagedRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CNAME status of a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCnameStatusRequest"/></param>
        /// <returns><see cref="DescribeCnameStatusResponse"/></returns>
        public Task<DescribeCnameStatusResponse> DescribeCnameStatus(DescribeCnameStatusRequest req)
        {
            return InternalRequestAsync<DescribeCnameStatusResponse>(req, "DescribeCnameStatus");
        }

        /// <summary>
        /// This API is used to query the CNAME status of a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCnameStatusRequest"/></param>
        /// <returns><see cref="DescribeCnameStatusResponse"/></returns>
        public DescribeCnameStatusResponse DescribeCnameStatusSync(DescribeCnameStatusRequest req)
        {
            return InternalRequestAsync<DescribeCnameStatusResponse>(req, "DescribeCnameStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the DDoS protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSPolicyResponse>(req, "DescribeDDoSPolicy");
        }

        /// <summary>
        /// This API is used to query the DDoS protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSPolicyResponse>(req, "DescribeDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the DDoS attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackDataResponse"/></returns>
        public Task<DescribeDDosAttackDataResponse> DescribeDDosAttackData(DescribeDDosAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackDataResponse>(req, "DescribeDDosAttackData");
        }

        /// <summary>
        /// This API is used to query the DDoS attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackDataResponse"/></returns>
        public DescribeDDosAttackDataResponse DescribeDDosAttackDataSync(DescribeDDosAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackDataResponse>(req, "DescribeDDosAttackData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackEventResponse"/></returns>
        public Task<DescribeDDosAttackEventResponse> DescribeDDosAttackEvent(DescribeDDosAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackEventResponse>(req, "DescribeDDosAttackEvent");
        }

        /// <summary>
        /// This API is used to query DDoS attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackEventResponse"/></returns>
        public DescribeDDosAttackEventResponse DescribeDDosAttackEventSync(DescribeDDosAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackEventResponse>(req, "DescribeDDosAttackEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DDoS attack event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackEventDetailResponse"/></returns>
        public Task<DescribeDDosAttackEventDetailResponse> DescribeDDosAttackEventDetail(DescribeDDosAttackEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackEventDetailResponse>(req, "DescribeDDosAttackEventDetail");
        }

        /// <summary>
        /// This API is used to query DDoS attack event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackEventDetailResponse"/></returns>
        public DescribeDDosAttackEventDetailResponse DescribeDDosAttackEventDetailSync(DescribeDDosAttackEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackEventDetailResponse>(req, "DescribeDDosAttackEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DDoS attack sources.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackSourceEventRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackSourceEventResponse"/></returns>
        public Task<DescribeDDosAttackSourceEventResponse> DescribeDDosAttackSourceEvent(DescribeDDosAttackSourceEventRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackSourceEventResponse>(req, "DescribeDDosAttackSourceEvent");
        }

        /// <summary>
        /// This API is used to query DDoS attack sources.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackSourceEventRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackSourceEventResponse"/></returns>
        public DescribeDDosAttackSourceEventResponse DescribeDDosAttackSourceEventSync(DescribeDDosAttackSourceEventRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackSourceEventResponse>(req, "DescribeDDosAttackSourceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top data of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackTopDataResponse"/></returns>
        public Task<DescribeDDosAttackTopDataResponse> DescribeDDosAttackTopData(DescribeDDosAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackTopDataResponse>(req, "DescribeDDosAttackTopData");
        }

        /// <summary>
        /// This API is used to query the top data of DDoS attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDosAttackTopDataResponse"/></returns>
        public DescribeDDosAttackTopDataResponse DescribeDDosAttackTopDataSync(DescribeDDosAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDosAttackTopDataResponse>(req, "DescribeDDosAttackTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the major DDoS attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosMajorAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDosMajorAttackEventResponse"/></returns>
        public Task<DescribeDDosMajorAttackEventResponse> DescribeDDosMajorAttackEvent(DescribeDDosMajorAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDosMajorAttackEventResponse>(req, "DescribeDDosMajorAttackEvent");
        }

        /// <summary>
        /// This API is used to query the major DDoS attack event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDosMajorAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDosMajorAttackEventResponse"/></returns>
        public DescribeDDosMajorAttackEventResponse DescribeDDosMajorAttackEventSync(DescribeDDosMajorAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDosMajorAttackEventResponse>(req, "DescribeDDosMajorAttackEvent")
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
        /// This API is used to obtain collected DNS requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsDataRequest"/></param>
        /// <returns><see cref="DescribeDnsDataResponse"/></returns>
        public Task<DescribeDnsDataResponse> DescribeDnsData(DescribeDnsDataRequest req)
        {
            return InternalRequestAsync<DescribeDnsDataResponse>(req, "DescribeDnsData");
        }

        /// <summary>
        /// This API is used to obtain collected DNS requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsDataRequest"/></param>
        /// <returns><see cref="DescribeDnsDataResponse"/></returns>
        public DescribeDnsDataResponse DescribeDnsDataSync(DescribeDnsDataRequest req)
        {
            return InternalRequestAsync<DescribeDnsDataResponse>(req, "DescribeDnsData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DNS records. Paging, sorting and filtering are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public Task<DescribeDnsRecordsResponse> DescribeDnsRecords(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords");
        }

        /// <summary>
        /// This API is used to query DNS records. Paging, sorting and filtering are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public DescribeDnsRecordsResponse DescribeDnsRecordsSync(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DNSSEC information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnssecRequest"/></param>
        /// <returns><see cref="DescribeDnssecResponse"/></returns>
        public Task<DescribeDnssecResponse> DescribeDnssec(DescribeDnssecRequest req)
        {
            return InternalRequestAsync<DescribeDnssecResponse>(req, "DescribeDnssec");
        }

        /// <summary>
        /// This API is used to query DNSSEC information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDnssecRequest"/></param>
        /// <returns><see cref="DescribeDnssecResponse"/></returns>
        public DescribeDnssecResponse DescribeDnssecSync(DescribeDnssecRequest req)
        {
            return InternalRequestAsync<DescribeDnssecResponse>(req, "DescribeDnssec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query certificates of domain names. Paging, sorting and filtering are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsCertificateRequest"/></param>
        /// <returns><see cref="DescribeHostsCertificateResponse"/></returns>
        public Task<DescribeHostsCertificateResponse> DescribeHostsCertificate(DescribeHostsCertificateRequest req)
        {
            return InternalRequestAsync<DescribeHostsCertificateResponse>(req, "DescribeHostsCertificate");
        }

        /// <summary>
        /// This API is used to query certificates of domain names. Paging, sorting and filtering are supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsCertificateRequest"/></param>
        /// <returns><see cref="DescribeHostsCertificateResponse"/></returns>
        public DescribeHostsCertificateResponse DescribeHostsCertificateSync(DescribeHostsCertificateRequest req)
        {
            return InternalRequestAsync<DescribeHostsCertificateResponse>(req, "DescribeHostsCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query detailed domain name configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting");
        }

        /// <summary>
        /// This API is used to query detailed domain name configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public DescribeHostsSettingResponse DescribeHostsSettingSync(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query verification results.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationRequest"/></param>
        /// <returns><see cref="DescribeIdentificationResponse"/></returns>
        public Task<DescribeIdentificationResponse> DescribeIdentification(DescribeIdentificationRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationResponse>(req, "DescribeIdentification");
        }

        /// <summary>
        /// This API is used to query verification results.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationRequest"/></param>
        /// <returns><see cref="DescribeIdentificationResponse"/></returns>
        public DescribeIdentificationResponse DescribeIdentificationSync(DescribeIdentificationRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationResponse>(req, "DescribeIdentification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a list of CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingResponse"/></returns>
        public Task<DescribeLoadBalancingResponse> DescribeLoadBalancing(DescribeLoadBalancingRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancingResponse>(req, "DescribeLoadBalancing");
        }

        /// <summary>
        /// This API is used to obtain a list of CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingResponse"/></returns>
        public DescribeLoadBalancingResponse DescribeLoadBalancingSync(DescribeLoadBalancingRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancingResponse>(req, "DescribeLoadBalancing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingDetailResponse"/></returns>
        public Task<DescribeLoadBalancingDetailResponse> DescribeLoadBalancingDetail(DescribeLoadBalancingDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancingDetailResponse>(req, "DescribeLoadBalancingDetail");
        }

        /// <summary>
        /// This API is used to query the details of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingDetailResponse"/></returns>
        public DescribeLoadBalancingDetailResponse DescribeLoadBalancingDetailSync(DescribeLoadBalancingDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancingDetailResponse>(req, "DescribeLoadBalancingDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of origin groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public Task<DescribeOriginGroupResponse> DescribeOriginGroup(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup");
        }

        /// <summary>
        /// This API is used to get the list of origin groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public DescribeOriginGroupResponse DescribeOriginGroupSync(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of the origin group.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupDetailResponse"/></returns>
        public Task<DescribeOriginGroupDetailResponse> DescribeOriginGroupDetail(DescribeOriginGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupDetailResponse>(req, "DescribeOriginGroupDetail");
        }

        /// <summary>
        /// This API is used to get the details of the origin group.
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupDetailResponse"/></returns>
        public DescribeOriginGroupDetailResponse DescribeOriginGroupDetailSync(DescribeOriginGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupDetailResponse>(req, "DescribeOriginGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the layer-7 time series traffic data for monitoring.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public Task<DescribeOverviewL7DataResponse> DescribeOverviewL7Data(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data");
        }

        /// <summary>
        /// This API is used to query the layer-7 time series traffic data for monitoring.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public DescribeOverviewL7DataResponse DescribeOverviewL7DataSync(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the pre-warming task status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public Task<DescribePrefetchTasksResponse> DescribePrefetchTasks(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks");
        }

        /// <summary>
        /// This API is used to query the pre-warming task status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public DescribePrefetchTasksResponse DescribePrefetchTasksSync(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cache purging history.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// This API is used to query the cache purging history.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicy(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy");
        }

        /// <summary>
        /// This API is used to query the security protection configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public DescribeSecurityPolicyResponse DescribeSecurityPolicySync(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all protected subdomain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyListRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyListResponse"/></returns>
        public Task<DescribeSecurityPolicyListResponse> DescribeSecurityPolicyList(DescribeSecurityPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyListResponse>(req, "DescribeSecurityPolicyList");
        }

        /// <summary>
        /// This API is used to query all protected subdomain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyListRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyListResponse"/></returns>
        public DescribeSecurityPolicyListResponse DescribeSecurityPolicyListSync(DescribeSecurityPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyListResponse>(req, "DescribeSecurityPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query managed rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesResponse"/></returns>
        public Task<DescribeSecurityPolicyManagedRulesResponse> DescribeSecurityPolicyManagedRules(DescribeSecurityPolicyManagedRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyManagedRulesResponse>(req, "DescribeSecurityPolicyManagedRules");
        }

        /// <summary>
        /// This API is used to query managed rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesResponse"/></returns>
        public DescribeSecurityPolicyManagedRulesResponse DescribeSecurityPolicyManagedRulesSync(DescribeSecurityPolicyManagedRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyManagedRulesResponse>(req, "DescribeSecurityPolicyManagedRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a managed rule by rule ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesIdRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesIdResponse"/></returns>
        public Task<DescribeSecurityPolicyManagedRulesIdResponse> DescribeSecurityPolicyManagedRulesId(DescribeSecurityPolicyManagedRulesIdRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyManagedRulesIdResponse>(req, "DescribeSecurityPolicyManagedRulesId");
        }

        /// <summary>
        /// This API is used to query the details of a managed rule by rule ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesIdRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesIdResponse"/></returns>
        public DescribeSecurityPolicyManagedRulesIdResponse DescribeSecurityPolicyManagedRulesIdSync(DescribeSecurityPolicyManagedRulesIdRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyManagedRulesIdResponse>(req, "DescribeSecurityPolicyManagedRulesId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information of all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRegionsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRegionsResponse"/></returns>
        public Task<DescribeSecurityPolicyRegionsResponse> DescribeSecurityPolicyRegions(DescribeSecurityPolicyRegionsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyRegionsResponse>(req, "DescribeSecurityPolicyRegions");
        }

        /// <summary>
        /// This API is used to query information of all regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRegionsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRegionsResponse"/></returns>
        public DescribeSecurityPolicyRegionsResponse DescribeSecurityPolicyRegionsSync(DescribeSecurityPolicyRegionsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyRegionsResponse>(req, "DescribeSecurityPolicyRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user profiling rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPortraitRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPortraitRulesResponse"/></returns>
        public Task<DescribeSecurityPortraitRulesResponse> DescribeSecurityPortraitRules(DescribeSecurityPortraitRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPortraitRulesResponse>(req, "DescribeSecurityPortraitRules");
        }

        /// <summary>
        /// This API is used to query user profiling rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPortraitRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPortraitRulesResponse"/></returns>
        public DescribeSecurityPortraitRulesResponse DescribeSecurityPortraitRulesSync(DescribeSecurityPortraitRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPortraitRulesResponse>(req, "DescribeSecurityPortraitRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the layer-4 time series traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public Task<DescribeTimingL4DataResponse> DescribeTimingL4Data(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data");
        }

        /// <summary>
        /// This API is used to query the layer-4 time series traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public DescribeTimingL4DataResponse DescribeTimingL4DataSync(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the layer-7 time series traffic data for data analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData");
        }

        /// <summary>
        /// This API is used to query the layer-7 time series traffic data for data analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query time-series L7 cached data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData");
        }

        /// <summary>
        /// This API is used to query time-series L7 cached data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData");
        }

        /// <summary>
        /// This API is used to query the top traffic data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top-ranked L7 cached data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData");
        }

        /// <summary>
        /// This API is used to query the top-ranked L7 cached data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query web hosting attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesAttackEventsResponse"/></returns>
        public Task<DescribeWebManagedRulesAttackEventsResponse> DescribeWebManagedRulesAttackEvents(DescribeWebManagedRulesAttackEventsRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesAttackEventsResponse>(req, "DescribeWebManagedRulesAttackEvents");
        }

        /// <summary>
        /// This API is used to query web hosting attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesAttackEventsResponse"/></returns>
        public DescribeWebManagedRulesAttackEventsResponse DescribeWebManagedRulesAttackEventsSync(DescribeWebManagedRulesAttackEventsRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesAttackEventsResponse>(req, "DescribeWebManagedRulesAttackEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the web hosting rule data.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesDataResponse"/></returns>
        public Task<DescribeWebManagedRulesDataResponse> DescribeWebManagedRulesData(DescribeWebManagedRulesDataRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesDataResponse>(req, "DescribeWebManagedRulesData");
        }

        /// <summary>
        /// This API is used to query the web hosting rule data.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesDataResponse"/></returns>
        public DescribeWebManagedRulesDataResponse DescribeWebManagedRulesDataSync(DescribeWebManagedRulesDataRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesDataResponse>(req, "DescribeWebManagedRulesData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query web hosting logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesLogRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesLogResponse"/></returns>
        public Task<DescribeWebManagedRulesLogResponse> DescribeWebManagedRulesLog(DescribeWebManagedRulesLogRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesLogResponse>(req, "DescribeWebManagedRulesLog");
        }

        /// <summary>
        /// This API is used to query web hosting logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesLogRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesLogResponse"/></returns>
        public DescribeWebManagedRulesLogResponse DescribeWebManagedRulesLogSync(DescribeWebManagedRulesLogRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesLogResponse>(req, "DescribeWebManagedRulesLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the top data of web hosting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesTopDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesTopDataResponse"/></returns>
        public Task<DescribeWebManagedRulesTopDataResponse> DescribeWebManagedRulesTopData(DescribeWebManagedRulesTopDataRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesTopDataResponse>(req, "DescribeWebManagedRulesTopData");
        }

        /// <summary>
        /// This API is used to query the top data of web hosting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesTopDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesTopDataResponse"/></returns>
        public DescribeWebManagedRulesTopDataResponse DescribeWebManagedRulesTopDataSync(DescribeWebManagedRulesTopDataRequest req)
        {
            return InternalRequestAsync<DescribeWebManagedRulesTopDataResponse>(req, "DescribeWebManagedRulesTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query web attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionAttackEventsResponse"/></returns>
        public Task<DescribeWebProtectionAttackEventsResponse> DescribeWebProtectionAttackEvents(DescribeWebProtectionAttackEventsRequest req)
        {
            return InternalRequestAsync<DescribeWebProtectionAttackEventsResponse>(req, "DescribeWebProtectionAttackEvents");
        }

        /// <summary>
        /// This API is used to query web attack events.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionAttackEventsResponse"/></returns>
        public DescribeWebProtectionAttackEventsResponse DescribeWebProtectionAttackEventsSync(DescribeWebProtectionAttackEventsRequest req)
        {
            return InternalRequestAsync<DescribeWebProtectionAttackEventsResponse>(req, "DescribeWebProtectionAttackEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the web protection data.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionDataResponse"/></returns>
        public Task<DescribeWebProtectionDataResponse> DescribeWebProtectionData(DescribeWebProtectionDataRequest req)
        {
            return InternalRequestAsync<DescribeWebProtectionDataResponse>(req, "DescribeWebProtectionData");
        }

        /// <summary>
        /// This API is used to query the web protection data.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionDataResponse"/></returns>
        public DescribeWebProtectionDataResponse DescribeWebProtectionDataSync(DescribeWebProtectionDataRequest req)
        {
            return InternalRequestAsync<DescribeWebProtectionDataResponse>(req, "DescribeWebProtectionData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query web protection logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionLogRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionLogResponse"/></returns>
        public Task<DescribeWebProtectionLogResponse> DescribeWebProtectionLog(DescribeWebProtectionLogRequest req)
        {
            return InternalRequestAsync<DescribeWebProtectionLogResponse>(req, "DescribeWebProtectionLog");
        }

        /// <summary>
        /// This API is used to query web protection logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionLogRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionLogResponse"/></returns>
        public DescribeWebProtectionLogResponse DescribeWebProtectionLogSync(DescribeWebProtectionLogRequest req)
        {
            return InternalRequestAsync<DescribeWebProtectionLogResponse>(req, "DescribeWebProtectionLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeZoneDDoSPolicyResponse"/></returns>
        public Task<DescribeZoneDDoSPolicyResponse> DescribeZoneDDoSPolicy(DescribeZoneDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeZoneDDoSPolicyResponse>(req, "DescribeZoneDDoSPolicy");
        }

        /// <summary>
        /// This API is used to query all DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeZoneDDoSPolicyResponse"/></returns>
        public DescribeZoneDDoSPolicyResponse DescribeZoneDDoSPolicySync(DescribeZoneDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeZoneDDoSPolicyResponse>(req, "DescribeZoneDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a site by site ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDetailsRequest"/></param>
        /// <returns><see cref="DescribeZoneDetailsResponse"/></returns>
        public Task<DescribeZoneDetailsResponse> DescribeZoneDetails(DescribeZoneDetailsRequest req)
        {
            return InternalRequestAsync<DescribeZoneDetailsResponse>(req, "DescribeZoneDetails");
        }

        /// <summary>
        /// This API is used to query the details of a site by site ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDetailsRequest"/></param>
        /// <returns><see cref="DescribeZoneDetailsResponse"/></returns>
        public DescribeZoneDetailsResponse DescribeZoneDetailsSync(DescribeZoneDetailsRequest req)
        {
            return InternalRequestAsync<DescribeZoneDetailsResponse>(req, "DescribeZoneDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the site configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting");
        }

        /// <summary>
        /// This API is used to query the site configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public DescribeZoneSettingResponse DescribeZoneSettingSync(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of user sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// This API is used to query the list of user sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query layer-7 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public Task<DownloadL7LogsResponse> DownloadL7Logs(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs");
        }

        /// <summary>
        /// This API is used to query layer-7 logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public DownloadL7LogsResponse DownloadL7LogsSync(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs")
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
        /// This API is used to import DNS records.
        /// </summary>
        /// <param name="req"><see cref="ImportDnsRecordsRequest"/></param>
        /// <returns><see cref="ImportDnsRecordsResponse"/></returns>
        public Task<ImportDnsRecordsResponse> ImportDnsRecords(ImportDnsRecordsRequest req)
        {
            return InternalRequestAsync<ImportDnsRecordsResponse>(req, "ImportDnsRecords");
        }

        /// <summary>
        /// This API is used to import DNS records.
        /// </summary>
        /// <param name="req"><see cref="ImportDnsRecordsRequest"/></param>
        /// <returns><see cref="ImportDnsRecordsResponse"/></returns>
        public ImportDnsRecordsResponse ImportDnsRecordsSync(ImportDnsRecordsRequest req)
        {
            return InternalRequestAsync<ImportDnsRecordsResponse>(req, "ImportDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public Task<ModifyApplicationProxyResponse> ModifyApplicationProxy(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy");
        }

        /// <summary>
        /// This API is used to modify an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public ModifyApplicationProxyResponse ModifyApplicationProxySync(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public Task<ModifyApplicationProxyRuleResponse> ModifyApplicationProxyRule(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule");
        }

        /// <summary>
        /// This API is used to modify an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public ModifyApplicationProxyRuleResponse ModifyApplicationProxyRuleSync(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public Task<ModifyApplicationProxyRuleStatusResponse> ModifyApplicationProxyRuleStatus(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus");
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public ModifyApplicationProxyRuleStatusResponse ModifyApplicationProxyRuleStatusSync(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public Task<ModifyApplicationProxyStatusResponse> ModifyApplicationProxyStatus(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus");
        }

        /// <summary>
        /// This API is used to modify the status of an application proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public ModifyApplicationProxyStatusResponse ModifyApplicationProxyStatusSync(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyResponse>(req, "ModifyDDoSPolicy");
        }

        /// <summary>
        /// This API is used to modify DDoS mitigation configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyResponse>(req, "ModifyDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable high availability for domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyHostRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyHostResponse"/></returns>
        public Task<ModifyDDoSPolicyHostResponse> ModifyDDoSPolicyHost(ModifyDDoSPolicyHostRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyHostResponse>(req, "ModifyDDoSPolicyHost");
        }

        /// <summary>
        /// This API is used to enable high availability for domain names.
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyHostRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyHostResponse"/></returns>
        public ModifyDDoSPolicyHostResponse ModifyDDoSPolicyHostSync(ModifyDDoSPolicyHostRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyHostResponse>(req, "ModifyDDoSPolicyHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of a default certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultCertificateRequest"/></param>
        /// <returns><see cref="ModifyDefaultCertificateResponse"/></returns>
        public Task<ModifyDefaultCertificateResponse> ModifyDefaultCertificate(ModifyDefaultCertificateRequest req)
        {
            return InternalRequestAsync<ModifyDefaultCertificateResponse>(req, "ModifyDefaultCertificate");
        }

        /// <summary>
        /// This API is used to modify the status of a default certificate.
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultCertificateRequest"/></param>
        /// <returns><see cref="ModifyDefaultCertificateResponse"/></returns>
        public ModifyDefaultCertificateResponse ModifyDefaultCertificateSync(ModifyDefaultCertificateRequest req)
        {
            return InternalRequestAsync<ModifyDefaultCertificateResponse>(req, "ModifyDefaultCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordResponse"/></returns>
        public Task<ModifyDnsRecordResponse> ModifyDnsRecord(ModifyDnsRecordRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordResponse>(req, "ModifyDnsRecord");
        }

        /// <summary>
        /// This API is used to modify DNS records.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordResponse"/></returns>
        public ModifyDnsRecordResponse ModifyDnsRecordSync(ModifyDnsRecordRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordResponse>(req, "ModifyDnsRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the DNSSEC status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnssecRequest"/></param>
        /// <returns><see cref="ModifyDnssecResponse"/></returns>
        public Task<ModifyDnssecResponse> ModifyDnssec(ModifyDnssecRequest req)
        {
            return InternalRequestAsync<ModifyDnssecResponse>(req, "ModifyDnssec");
        }

        /// <summary>
        /// This API is used to modify the DNSSEC status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDnssecRequest"/></param>
        /// <returns><see cref="ModifyDnssecResponse"/></returns>
        public ModifyDnssecResponse ModifyDnssecSync(ModifyDnssecRequest req)
        {
            return InternalRequestAsync<ModifyDnssecResponse>(req, "ModifyDnssec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the certificate of a domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public Task<ModifyHostsCertificateResponse> ModifyHostsCertificate(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate");
        }

        /// <summary>
        /// This API is used to modify the certificate of a domain name.
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public ModifyHostsCertificateResponse ModifyHostsCertificateSync(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingResponse"/></returns>
        public Task<ModifyLoadBalancingResponse> ModifyLoadBalancing(ModifyLoadBalancingRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancingResponse>(req, "ModifyLoadBalancing");
        }

        /// <summary>
        /// This API is used to modify a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingResponse"/></returns>
        public ModifyLoadBalancingResponse ModifyLoadBalancingSync(ModifyLoadBalancingRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancingResponse>(req, "ModifyLoadBalancing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingStatusRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingStatusResponse"/></returns>
        public Task<ModifyLoadBalancingStatusResponse> ModifyLoadBalancingStatus(ModifyLoadBalancingStatusRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancingStatusResponse>(req, "ModifyLoadBalancingStatus");
        }

        /// <summary>
        /// This API is used to modify the status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingStatusRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingStatusResponse"/></returns>
        public ModifyLoadBalancingStatusResponse ModifyLoadBalancingStatusSync(ModifyLoadBalancingStatusRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancingStatusResponse>(req, "ModifyLoadBalancingStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an origin group.
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public Task<ModifyOriginGroupResponse> ModifyOriginGroup(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup");
        }

        /// <summary>
        /// This API is used to modify an origin group.
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public ModifyOriginGroupResponse ModifyOriginGroupSync(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup")
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
        /// This API is used to modify the site information.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public Task<ModifyZoneResponse> ModifyZone(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone");
        }

        /// <summary>
        /// This API is used to modify the site information.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public ModifyZoneResponse ModifyZoneSync(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the CNAME acceleration status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCnameSpeedUpRequest"/></param>
        /// <returns><see cref="ModifyZoneCnameSpeedUpResponse"/></returns>
        public Task<ModifyZoneCnameSpeedUpResponse> ModifyZoneCnameSpeedUp(ModifyZoneCnameSpeedUpRequest req)
        {
            return InternalRequestAsync<ModifyZoneCnameSpeedUpResponse>(req, "ModifyZoneCnameSpeedUp");
        }

        /// <summary>
        /// This API is used to modify the CNAME acceleration status.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCnameSpeedUpRequest"/></param>
        /// <returns><see cref="ModifyZoneCnameSpeedUpResponse"/></returns>
        public ModifyZoneCnameSpeedUpResponse ModifyZoneCnameSpeedUpSync(ModifyZoneCnameSpeedUpRequest req)
        {
            return InternalRequestAsync<ModifyZoneCnameSpeedUpResponse>(req, "ModifyZoneCnameSpeedUp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the site configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting");
        }

        /// <summary>
        /// This API is used to modify the site configuration.
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
        /// This API is used to reclaim a site from other users after its ownership is verified.
        /// </summary>
        /// <param name="req"><see cref="ReclaimZoneRequest"/></param>
        /// <returns><see cref="ReclaimZoneResponse"/></returns>
        public Task<ReclaimZoneResponse> ReclaimZone(ReclaimZoneRequest req)
        {
            return InternalRequestAsync<ReclaimZoneResponse>(req, "ReclaimZone");
        }

        /// <summary>
        /// This API is used to reclaim a site from other users after its ownership is verified.
        /// </summary>
        /// <param name="req"><see cref="ReclaimZoneRequest"/></param>
        /// <returns><see cref="ReclaimZoneResponse"/></returns>
        public ReclaimZoneResponse ReclaimZoneSync(ReclaimZoneRequest req)
        {
            return InternalRequestAsync<ReclaimZoneResponse>(req, "ReclaimZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scan resolution records.
        /// </summary>
        /// <param name="req"><see cref="ScanDnsRecordsRequest"/></param>
        /// <returns><see cref="ScanDnsRecordsResponse"/></returns>
        public Task<ScanDnsRecordsResponse> ScanDnsRecords(ScanDnsRecordsRequest req)
        {
            return InternalRequestAsync<ScanDnsRecordsResponse>(req, "ScanDnsRecords");
        }

        /// <summary>
        /// This API is used to scan resolution records.
        /// </summary>
        /// <param name="req"><see cref="ScanDnsRecordsRequest"/></param>
        /// <returns><see cref="ScanDnsRecordsResponse"/></returns>
        public ScanDnsRecordsResponse ScanDnsRecordsSync(ScanDnsRecordsRequest req)
        {
            return InternalRequestAsync<ScanDnsRecordsResponse>(req, "ScanDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
