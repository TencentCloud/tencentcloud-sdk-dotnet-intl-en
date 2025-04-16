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

namespace TencentCloud.Cdn.V20180606
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdn.V20180606.Models;

   public class CdnClient : AbstractClient{

       private const string endpoint = "cdn.intl.tencentcloudapi.com";
       private const string version = "2018-06-06";
       private const string sdkVersion = "SDK_NET_3.0.1112";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add one or more domains to a specified log topic.
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public Task<AddCLSTopicDomainsResponse> AddCLSTopicDomains(AddCLSTopicDomainsRequest req)
        {
            return InternalRequestAsync<AddCLSTopicDomainsResponse>(req, "AddCLSTopicDomains");
        }

        /// <summary>
        /// This API is used to add one or more domains to a specified log topic.
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public AddCLSTopicDomainsResponse AddCLSTopicDomainsSync(AddCLSTopicDomainsRequest req)
        {
            return InternalRequestAsync<AddCLSTopicDomainsResponse>(req, "AddCLSTopicDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a CDN acceleration domain name. Up to 100 domain names can be added per minute.
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public Task<AddCdnDomainResponse> AddCdnDomain(AddCdnDomainRequest req)
        {
            return InternalRequestAsync<AddCdnDomainResponse>(req, "AddCdnDomain");
        }

        /// <summary>
        /// This API is used to add a CDN acceleration domain name. Up to 100 domain names can be added per minute.
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public AddCdnDomainResponse AddCdnDomainSync(AddCdnDomainRequest req)
        {
            return InternalRequestAsync<AddCdnDomainResponse>(req, "AddCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a log topic. Up to 10 log topics can be created under one logset.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public Task<CreateClsLogTopicResponse> CreateClsLogTopic(CreateClsLogTopicRequest req)
        {
            return InternalRequestAsync<CreateClsLogTopicResponse>(req, "CreateClsLogTopic");
        }

        /// <summary>
        /// This API is used to create a log topic. Up to 10 log topics can be created under one logset.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public CreateClsLogTopicResponse CreateClsLogTopicSync(CreateClsLogTopicRequest req)
        {
            return InternalRequestAsync<CreateClsLogTopicResponse>(req, "CreateClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recreate a failed event log task.
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public Task<CreateScdnFailedLogTaskResponse> CreateScdnFailedLogTask(CreateScdnFailedLogTaskRequest req)
        {
            return InternalRequestAsync<CreateScdnFailedLogTaskResponse>(req, "CreateScdnFailedLogTask");
        }

        /// <summary>
        /// This API is used to recreate a failed event log task.
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public CreateScdnFailedLogTaskResponse CreateScdnFailedLogTaskSync(CreateScdnFailedLogTaskRequest req)
        {
            return InternalRequestAsync<CreateScdnFailedLogTaskResponse>(req, "CreateScdnFailedLogTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a specified acceleration domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public Task<DeleteCdnDomainResponse> DeleteCdnDomain(DeleteCdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteCdnDomainResponse>(req, "DeleteCdnDomain");
        }

        /// <summary>
        /// This API is used to delete a specified acceleration domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public DeleteCdnDomainResponse DeleteCdnDomainSync(DeleteCdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteCdnDomainResponse>(req, "DeleteCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a log topic. Note: when a log topic is deleted, all logs of the domain names bound to it will no longer be published to the topic, and the logs previously published to the topic will be deleted. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public Task<DeleteClsLogTopicResponse> DeleteClsLogTopic(DeleteClsLogTopicRequest req)
        {
            return InternalRequestAsync<DeleteClsLogTopicResponse>(req, "DeleteClsLogTopic");
        }

        /// <summary>
        /// This API is used to delete a log topic. Note: when a log topic is deleted, all logs of the domain names bound to it will no longer be published to the topic, and the logs previously published to the topic will be deleted. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public DeleteClsLogTopicResponse DeleteClsLogTopicSync(DeleteClsLogTopicRequest req)
        {
            return InternalRequestAsync<DeleteClsLogTopicResponse>(req, "DeleteClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query billing data details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData");
        }

        /// <summary>
        /// This API is used to query billing data details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Number of hit requests
        /// + Request hit rate (in %)
        /// + Hit traffic (in bytes)
        /// + Traffic hit rate (in %)
        /// + Aggregate list of 2xx status codes and the details of status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx status codes and the details of status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx status codes and the details of status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx status codes and the details of status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public Task<DescribeCdnDataResponse> DescribeCdnData(DescribeCdnDataRequest req)
        {
            return InternalRequestAsync<DescribeCdnDataResponse>(req, "DescribeCdnData");
        }

        /// <summary>
        /// This API is used to query CDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Number of hit requests
        /// + Request hit rate (in %)
        /// + Hit traffic (in bytes)
        /// + Traffic hit rate (in %)
        /// + Aggregate list of 2xx status codes and the details of status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx status codes and the details of status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx status codes and the details of status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx status codes and the details of status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public DescribeCdnDataResponse DescribeCdnDataSync(DescribeCdnDataRequest req)
        {
            return InternalRequestAsync<DescribeCdnDataResponse>(req, "DescribeCdnData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download link of an access log. You can use this API for access logs in the last 30 days either within or outside Mainland China.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnDomainLogsResponse>(req, "DescribeCdnDomainLogs");
        }

        /// <summary>
        /// This API is used to query the download link of an access log. You can use this API for access logs in the last 30 days either within or outside Mainland China.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsSync(DescribeCdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnDomainLogsResponse>(req, "DescribeCdnDomainLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CDN IP ownership.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public Task<DescribeCdnIpResponse> DescribeCdnIp(DescribeCdnIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnIpResponse>(req, "DescribeCdnIp");
        }

        /// <summary>
        /// This API is used to query CDN IP ownership.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public DescribeCdnIpResponse DescribeCdnIpSync(DescribeCdnIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnIpResponse>(req, "DescribeCdnIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the IP information of CDN intermediate nodes. Note: this API will be deactivated soon and no longer be maintained. Please call `DescribeIpStatus` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public Task<DescribeCdnOriginIpResponse> DescribeCdnOriginIp(DescribeCdnOriginIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnOriginIpResponse>(req, "DescribeCdnOriginIp");
        }

        /// <summary>
        /// This API is used to query the IP information of CDN intermediate nodes. Note: this API will be deactivated soon and no longer be maintained. Please call `DescribeIpStatus` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public DescribeCdnOriginIpResponse DescribeCdnOriginIpSync(DescribeCdnOriginIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnOriginIpResponse>(req, "DescribeCdnOriginIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a SSL certificate and obtain its domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public Task<DescribeCertDomainsResponse> DescribeCertDomains(DescribeCertDomainsRequest req)
        {
            return InternalRequestAsync<DescribeCertDomainsResponse>(req, "DescribeCertDomains");
        }

        /// <summary>
        /// This API is used to verify a SSL certificate and obtain its domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public DescribeCertDomainsResponse DescribeCertDomainsSync(DescribeCertDomainsRequest req)
        {
            return InternalRequestAsync<DescribeCertDomainsResponse>(req, "DescribeCertDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the basic configuration information of CDN acceleration domain names (inside and outside mainland China), including the project ID, service status, service type, creation time, and update time, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// This API is used to query the basic configuration information of CDN acceleration domain names (inside and outside mainland China), including the project ID, service status, service type, creation time, and update time, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the complete configuration information of CDN acceleration domain names (inside and outside mainland China).
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public Task<DescribeDomainsConfigResponse> DescribeDomainsConfig(DescribeDomainsConfigRequest req)
        {
            return InternalRequestAsync<DescribeDomainsConfigResponse>(req, "DescribeDomainsConfig");
        }

        /// <summary>
        /// This API is used to query the complete configuration information of CDN acceleration domain names (inside and outside mainland China).
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public DescribeDomainsConfigResponse DescribeDomainsConfigSync(DescribeDomainsConfigRequest req)
        {
            return InternalRequestAsync<DescribeDomainsConfigResponse>(req, "DescribeDomainsConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the IP details of edge nodes (available soon) and intermediate nodes. Note that there is a certain delay in data availability.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41954?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public Task<DescribeIpStatusResponse> DescribeIpStatus(DescribeIpStatusRequest req)
        {
            return InternalRequestAsync<DescribeIpStatusResponse>(req, "DescribeIpStatus");
        }

        /// <summary>
        /// This API is used to query the IP details of edge nodes (available soon) and intermediate nodes. Note that there is a certain delay in data availability.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41954?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public DescribeIpStatusResponse DescribeIpStatusSync(DescribeIpStatusRequest req)
        {
            return InternalRequestAsync<DescribeIpStatusResponse>(req, "DescribeIpStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeIpVisit) is used to query the number of users who remain active for 5 minutes and the detailed number of daily active users.
        /// 
        /// + Number of users who remain active for 5 minutes: Collects deduplicated statistics based on client IP addresses in the log with the 5-minute granularity.
        /// + Number of daily active users: Collects deduplicated statistics based on client IP addresses in the log with the 1-day granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public Task<DescribeIpVisitResponse> DescribeIpVisit(DescribeIpVisitRequest req)
        {
            return InternalRequestAsync<DescribeIpVisitResponse>(req, "DescribeIpVisit");
        }

        /// <summary>
        /// This API (DescribeIpVisit) is used to query the number of users who remain active for 5 minutes and the detailed number of daily active users.
        /// 
        /// + Number of users who remain active for 5 minutes: Collects deduplicated statistics based on client IP addresses in the log with the 5-minute granularity.
        /// + Number of daily active users: Collects deduplicated statistics based on client IP addresses in the log with the 1-day granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public DescribeIpVisitResponse DescribeIpVisitSync(DescribeIpVisitRequest req)
        {
            return InternalRequestAsync<DescribeIpVisitResponse>(req, "DescribeIpVisit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeMapInfo) is used to query the IDs of districts or ISPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public Task<DescribeMapInfoResponse> DescribeMapInfo(DescribeMapInfoRequest req)
        {
            return InternalRequestAsync<DescribeMapInfoResponse>(req, "DescribeMapInfo");
        }

        /// <summary>
        /// This API (DescribeMapInfo) is used to query the IDs of districts or ISPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public DescribeMapInfoResponse DescribeMapInfoSync(DescribeMapInfoRequest req)
        {
            return InternalRequestAsync<DescribeMapInfoResponse>(req, "DescribeMapInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CDN real-time origin-pull monitoring data and supports the following metrics:
        /// 
        /// + Origin-pull traffic (in bytes)
        /// + Origin-pull bandwidth (in bps)
        /// + Number of origin-pull requests
        /// + Number of failed origin-pull requests
        /// + Origin-pull failure rate (in % with two decimal digits)
        /// + Aggregate list of 2xx origin-pull status codes and the details of origin-pull status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx origin-pull status codes and the details of origin-pull status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx origin-pull status codes and the details of origin-pull status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx origin-pull status codes and the details of origin-pull status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public Task<DescribeOriginDataResponse> DescribeOriginData(DescribeOriginDataRequest req)
        {
            return InternalRequestAsync<DescribeOriginDataResponse>(req, "DescribeOriginData");
        }

        /// <summary>
        /// This API is used to query CDN real-time origin-pull monitoring data and supports the following metrics:
        /// 
        /// + Origin-pull traffic (in bytes)
        /// + Origin-pull bandwidth (in bps)
        /// + Number of origin-pull requests
        /// + Number of failed origin-pull requests
        /// + Origin-pull failure rate (in % with two decimal digits)
        /// + Aggregate list of 2xx origin-pull status codes and the details of origin-pull status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx origin-pull status codes and the details of origin-pull status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx origin-pull status codes and the details of origin-pull status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx origin-pull status codes and the details of origin-pull status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public DescribeOriginDataResponse DescribeOriginDataSync(DescribeOriginDataRequest req)
        {
            return InternalRequestAsync<DescribeOriginDataResponse>(req, "DescribeOriginData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribePayType) is used to query billing information of the current account, such as billing mode and billing cycle.
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public Task<DescribePayTypeResponse> DescribePayType(DescribePayTypeRequest req)
        {
            return InternalRequestAsync<DescribePayTypeResponse>(req, "DescribePayType");
        }

        /// <summary>
        /// This API (DescribePayType) is used to query billing information of the current account, such as billing mode and billing cycle.
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public DescribePayTypeResponse DescribePayTypeSync(DescribePayTypeRequest req)
        {
            return InternalRequestAsync<DescribePayTypeResponse>(req, "DescribePayType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the purge usage quota and daily available usage for an account.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public Task<DescribePurgeQuotaResponse> DescribePurgeQuota(DescribePurgeQuotaRequest req)
        {
            return InternalRequestAsync<DescribePurgeQuotaResponse>(req, "DescribePurgeQuota");
        }

        /// <summary>
        /// This API is used to query the purge usage quota and daily available usage for an account.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public DescribePurgeQuotaResponse DescribePurgeQuotaSync(DescribePurgeQuotaRequest req)
        {
            return InternalRequestAsync<DescribePurgeQuotaResponse>(req, "DescribePurgeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the record and progress of URL or directory purge tasks submitted via the `PurgePathCache` or `PurgeUrlsCache` APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// This API is used to query the record and progress of URL or directory purge tasks submitted via the `PurgePathCache` or `PurgeUrlsCache` APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the prefetch quota and daily available usage.
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public Task<DescribePushQuotaResponse> DescribePushQuota(DescribePushQuotaRequest req)
        {
            return InternalRequestAsync<DescribePushQuotaResponse>(req, "DescribePushQuota");
        }

        /// <summary>
        /// This API is used to query the prefetch quota and daily available usage.
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public DescribePushQuotaResponse DescribePushQuotaSync(DescribePushQuotaRequest req)
        {
            return InternalRequestAsync<DescribePushQuotaResponse>(req, "DescribePushQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the submission record and progress of prefetch tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public Task<DescribePushTasksResponse> DescribePushTasks(DescribePushTasksRequest req)
        {
            return InternalRequestAsync<DescribePushTasksResponse>(req, "DescribePushTasks");
        }

        /// <summary>
        /// This API is used to query the submission record and progress of prefetch tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public DescribePushTasksResponse DescribePushTasksSync(DescribePushTasksRequest req)
        {
            return InternalRequestAsync<DescribePushTasksResponse>(req, "DescribePushTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the daily/weekly/monthly report data at domain name/project levels.
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public Task<DescribeReportDataResponse> DescribeReportData(DescribeReportDataRequest req)
        {
            return InternalRequestAsync<DescribeReportDataResponse>(req, "DescribeReportData");
        }

        /// <summary>
        /// This API is used to query the daily/weekly/monthly report data at domain name/project levels.
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public DescribeReportDataResponse DescribeReportDataSync(DescribeReportDataRequest req)
        {
            return InternalRequestAsync<DescribeReportDataResponse>(req, "DescribeReportData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of domain name URLs containing regulation-violating content scanned and detected by the CDN system, and the current status of the URLs.
        /// It corresponds to the **Pornography Detection** page on the CDN Console.
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public Task<DescribeUrlViolationsResponse> DescribeUrlViolations(DescribeUrlViolationsRequest req)
        {
            return InternalRequestAsync<DescribeUrlViolationsResponse>(req, "DescribeUrlViolations");
        }

        /// <summary>
        /// This API is used to query the list of domain name URLs containing regulation-violating content scanned and detected by the CDN system, and the current status of the URLs.
        /// It corresponds to the **Pornography Detection** page on the CDN Console.
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public DescribeUrlViolationsResponse DescribeUrlViolationsSync(DescribeUrlViolationsRequest req)
        {
            return InternalRequestAsync<DescribeUrlViolationsResponse>(req, "DescribeUrlViolations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to block access to a specific URL on CDN. When a URL is blocked, error 403 will be returned for requests from the Chinese mainland. URL blocking is not permanent. Note that this API is only available to beta users now. 
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public Task<DisableCachesResponse> DisableCaches(DisableCachesRequest req)
        {
            return InternalRequestAsync<DisableCachesResponse>(req, "DisableCaches");
        }

        /// <summary>
        /// This API is used to block access to a specific URL on CDN. When a URL is blocked, error 403 will be returned for requests from the Chinese mainland. URL blocking is not permanent. Note that this API is only available to beta users now. 
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public DisableCachesResponse DisableCachesSync(DisableCachesRequest req)
        {
            return InternalRequestAsync<DisableCachesResponse>(req, "DisableCaches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop publishing to a log topic. Note: after a log topic is disabled, all logs of the domain names bound to it will no longer be published to the topic, and the logs that have already been published will be retained. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public Task<DisableClsLogTopicResponse> DisableClsLogTopic(DisableClsLogTopicRequest req)
        {
            return InternalRequestAsync<DisableClsLogTopicResponse>(req, "DisableClsLogTopic");
        }

        /// <summary>
        /// This API is used to stop publishing to a log topic. Note: after a log topic is disabled, all logs of the domain names bound to it will no longer be published to the topic, and the logs that have already been published will be retained. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public DisableClsLogTopicResponse DisableClsLogTopicSync(DisableClsLogTopicRequest req)
        {
            return InternalRequestAsync<DisableClsLogTopicResponse>(req, "DisableClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (EnableCaches) is used to unblock manually blocked URLs. After a URL is successfully unblocked, it takes about 5 to 10 minutes to take effect across the entire network. (This API is during beta test and not fully available now.)
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public Task<EnableCachesResponse> EnableCaches(EnableCachesRequest req)
        {
            return InternalRequestAsync<EnableCachesResponse>(req, "EnableCaches");
        }

        /// <summary>
        /// This API (EnableCaches) is used to unblock manually blocked URLs. After a URL is successfully unblocked, it takes about 5 to 10 minutes to take effect across the entire network. (This API is during beta test and not fully available now.)
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public EnableCachesResponse EnableCachesSync(EnableCachesRequest req)
        {
            return InternalRequestAsync<EnableCachesResponse>(req, "EnableCaches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start publishing to a log topic. Note: after a log topic is enabled, all logs of the domain names bound to the topic will be published to it. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public Task<EnableClsLogTopicResponse> EnableClsLogTopic(EnableClsLogTopicRequest req)
        {
            return InternalRequestAsync<EnableClsLogTopicResponse>(req, "EnableClsLogTopic");
        }

        /// <summary>
        /// This API is used to start publishing to a log topic. Note: after a log topic is enabled, all logs of the domain names bound to the topic will be published to it. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public EnableClsLogTopicResponse EnableClsLogTopicSync(EnableClsLogTopicRequest req)
        {
            return InternalRequestAsync<EnableClsLogTopicResponse>(req, "EnableClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the resource blocking history and the current URL status. (This API is in beta test and not generally available yet.)
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public Task<GetDisableRecordsResponse> GetDisableRecords(GetDisableRecordsRequest req)
        {
            return InternalRequestAsync<GetDisableRecordsResponse>(req, "GetDisableRecords");
        }

        /// <summary>
        /// This API is used to query the resource blocking history and the current URL status. (This API is in beta test and not generally available yet.)
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public GetDisableRecordsResponse GetDisableRecordsSync(GetDisableRecordsRequest req)
        {
            return InternalRequestAsync<GetDisableRecordsResponse>(req, "GetDisableRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display the list of log topics. Note: a logset can contain up to 10 log topics.
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public Task<ListClsLogTopicsResponse> ListClsLogTopics(ListClsLogTopicsRequest req)
        {
            return InternalRequestAsync<ListClsLogTopicsResponse>(req, "ListClsLogTopics");
        }

        /// <summary>
        /// This API is used to display the list of log topics. Note: a logset can contain up to 10 log topics.
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public ListClsLogTopicsResponse ListClsLogTopicsSync(ListClsLogTopicsRequest req)
        {
            return InternalRequestAsync<ListClsLogTopicsResponse>(req, "ListClsLogTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public Task<ListClsTopicDomainsResponse> ListClsTopicDomains(ListClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ListClsTopicDomainsResponse>(req, "ListClsTopicDomains");
        }

        /// <summary>
        /// This API is used to get the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public ListClsTopicDomainsResponse ListClsTopicDomainsSync(ListClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ListClsTopicDomainsResponse>(req, "ListClsTopicDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list data sorted the following ways by using different combinations of the Metric and Filter input parameters:
        /// 
        /// + It sorts access URLs by total traffic and total requests, and returns the top 1,000 URLs in descending order.
        /// + It sorts client districts by total traffic and total requests, and returns the list of districts in descending order.
        /// + It sorts client ISPs by total traffic and total requests, and returns the list of ISPs in descending order.
        /// + It sorts domain names by total traffic, peak bandwidth, total requests, average hit rate, and 2XX/3XX/4XX/5XX status codes, and returns the list of domain names in descending order.
        /// + It sorts domain names by total origin-pull traffic, peak origin-pull bandwidth, total origin-pull requests, average origin-pull failure rate, and 2XX/3XX/4XX/5XX origin-pull status codes, and returns the list of domain names in descending order.
        /// 
        /// Note: only data from the last 90 days will be queried.
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public Task<ListTopDataResponse> ListTopData(ListTopDataRequest req)
        {
            return InternalRequestAsync<ListTopDataResponse>(req, "ListTopData");
        }

        /// <summary>
        /// This API is used to list data sorted the following ways by using different combinations of the Metric and Filter input parameters:
        /// 
        /// + It sorts access URLs by total traffic and total requests, and returns the top 1,000 URLs in descending order.
        /// + It sorts client districts by total traffic and total requests, and returns the list of districts in descending order.
        /// + It sorts client ISPs by total traffic and total requests, and returns the list of ISPs in descending order.
        /// + It sorts domain names by total traffic, peak bandwidth, total requests, average hit rate, and 2XX/3XX/4XX/5XX status codes, and returns the list of domain names in descending order.
        /// + It sorts domain names by total origin-pull traffic, peak origin-pull bandwidth, total origin-pull requests, average origin-pull failure rate, and 2XX/3XX/4XX/5XX origin-pull status codes, and returns the list of domain names in descending order.
        /// 
        /// Note: only data from the last 90 days will be queried.
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public ListTopDataResponse ListTopDataSync(ListTopDataRequest req)
        {
            return InternalRequestAsync<ListTopDataResponse>(req, "ListTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public Task<ManageClsTopicDomainsResponse> ManageClsTopicDomains(ManageClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ManageClsTopicDomainsResponse>(req, "ManageClsTopicDomains");
        }

        /// <summary>
        /// This API is used to manage the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public ManageClsTopicDomainsResponse ManageClsTopicDomainsSync(ManageClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ManageClsTopicDomainsResponse>(req, "ManageClsTopicDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of a CDN acceleration domain name in a finer manner than `UpdateDomainConfig`.
        /// Notes:
        /// In `Route`, separate values by dots (.). The last value is called a leaf node. For non-leaf nodes, keep the configuration unchanged.
        /// The Value field is serialized to a JSON string {key:value}, where **key** is fixed to `update` and **value** is used to specify the value of the configuration parameter. To specify configurations with complex types, see https://intl.cloud.tencent.com/document/product/228/41116.?from_cn_redirect=1
        /// The input parameters of this API are not reported to CloudAudit as it may contain sensitive data, such as keys and secrets.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyDomainConfigResponse"/></returns>
        public Task<ModifyDomainConfigResponse> ModifyDomainConfig(ModifyDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyDomainConfigResponse>(req, "ModifyDomainConfig");
        }

        /// <summary>
        /// This API is used to modify the configuration of a CDN acceleration domain name in a finer manner than `UpdateDomainConfig`.
        /// Notes:
        /// In `Route`, separate values by dots (.). The last value is called a leaf node. For non-leaf nodes, keep the configuration unchanged.
        /// The Value field is serialized to a JSON string {key:value}, where **key** is fixed to `update` and **value** is used to specify the value of the configuration parameter. To specify configurations with complex types, see https://intl.cloud.tencent.com/document/product/228/41116.?from_cn_redirect=1
        /// The input parameters of this API are not reported to CloudAudit as it may contain sensitive data, such as keys and secrets.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyDomainConfigResponse"/></returns>
        public ModifyDomainConfigResponse ModifyDomainConfigSync(ModifyDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyDomainConfigResponse>(req, "ModifyDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
            return InternalRequestAsync<PurgePathCacheResponse>(req, "PurgePathCache");
        }

        /// <summary>
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
            return InternalRequestAsync<PurgePathCacheResponse>(req, "PurgePathCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit multiple URL purge tasks, which are carried out according to the current acceleration region of the domain names in the URLs.
        /// By default, a maximum of 10,000 URLs can be purged per day for acceleration regions either within or outside Mainland China, and up to 1,000 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public Task<PurgeUrlsCacheResponse> PurgeUrlsCache(PurgeUrlsCacheRequest req)
        {
            return InternalRequestAsync<PurgeUrlsCacheResponse>(req, "PurgeUrlsCache");
        }

        /// <summary>
        /// This API is used to submit multiple URL purge tasks, which are carried out according to the current acceleration region of the domain names in the URLs.
        /// By default, a maximum of 10,000 URLs can be purged per day for acceleration regions either within or outside Mainland China, and up to 1,000 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public PurgeUrlsCacheResponse PurgeUrlsCacheSync(PurgeUrlsCacheRequest req)
        {
            return InternalRequestAsync<PurgeUrlsCacheResponse>(req, "PurgeUrlsCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1000 URLs can be prefetched per day for regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time. Note that resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public Task<PushUrlsCacheResponse> PushUrlsCache(PushUrlsCacheRequest req)
        {
            return InternalRequestAsync<PushUrlsCacheResponse>(req, "PushUrlsCache");
        }

        /// <summary>
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1000 URLs can be prefetched per day for regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time. Note that resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public PushUrlsCacheResponse PushUrlsCacheSync(PushUrlsCacheRequest req)
        {
            return InternalRequestAsync<PushUrlsCacheResponse>(req, "PushUrlsCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for CLS logs. Search filters can be set to today, 24 hours (one of the last 7 days), and the last 7 days.
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public Task<SearchClsLogResponse> SearchClsLog(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog");
        }

        /// <summary>
        /// This API is used to search for CLS logs. Search filters can be set to today, 24 hours (one of the last 7 days), and the last 7 days.
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public SearchClsLogResponse SearchClsLogSync(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the acceleration service for a disabled domain name.
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public Task<StartCdnDomainResponse> StartCdnDomain(StartCdnDomainRequest req)
        {
            return InternalRequestAsync<StartCdnDomainResponse>(req, "StartCdnDomain");
        }

        /// <summary>
        /// This API is used to enable the acceleration service for a disabled domain name.
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public StartCdnDomainResponse StartCdnDomainSync(StartCdnDomainRequest req)
        {
            return InternalRequestAsync<StartCdnDomainResponse>(req, "StartCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to suspend the acceleration service for a domain name.
        /// Note: after the acceleration service has been suspended, requests to the cache node will return a 404 error. In order to avoid impact to your business, please move the domain name to another service before suspending the acceleration service.
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public Task<StopCdnDomainResponse> StopCdnDomain(StopCdnDomainRequest req)
        {
            return InternalRequestAsync<StopCdnDomainResponse>(req, "StopCdnDomain");
        }

        /// <summary>
        /// This API is used to suspend the acceleration service for a domain name.
        /// Note: after the acceleration service has been suspended, requests to the cache node will return a 404 error. In order to avoid impact to your business, please move the domain name to another service before suspending the acceleration service.
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public StopCdnDomainResponse StopCdnDomainSync(StopCdnDomainRequest req)
        {
            return InternalRequestAsync<StopCdnDomainResponse>(req, "StopCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of CDN acceleration domain names.
        /// Note: To update complex configuration items, all attributes of the object must be specified, or the default values are used. We recommend calling the querying API to get attributes before modifying and passing them to this API.
        /// The input parameters of this API are not reported to CloudAudit as it may contain sensitive data, such as keys and secrets.
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public Task<UpdateDomainConfigResponse> UpdateDomainConfig(UpdateDomainConfigRequest req)
        {
            return InternalRequestAsync<UpdateDomainConfigResponse>(req, "UpdateDomainConfig");
        }

        /// <summary>
        /// This API is used to modify the configuration of CDN acceleration domain names.
        /// Note: To update complex configuration items, all attributes of the object must be specified, or the default values are used. We recommend calling the querying API to get attributes before modifying and passing them to this API.
        /// The input parameters of this API are not reported to CloudAudit as it may contain sensitive data, such as keys and secrets.
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public UpdateDomainConfigResponse UpdateDomainConfigSync(UpdateDomainConfigRequest req)
        {
            return InternalRequestAsync<UpdateDomainConfigResponse>(req, "UpdateDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the billing mode of an account. At present, the billing mode of accounts on a monthly billing cycle and sub-accounts cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public Task<UpdatePayTypeResponse> UpdatePayType(UpdatePayTypeRequest req)
        {
            return InternalRequestAsync<UpdatePayTypeResponse>(req, "UpdatePayType");
        }

        /// <summary>
        /// This API is used to modify the billing mode of an account. At present, the billing mode of accounts on a monthly billing cycle and sub-accounts cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public UpdatePayTypeResponse UpdatePayTypeSync(UpdatePayTypeRequest req)
        {
            return InternalRequestAsync<UpdatePayTypeResponse>(req, "UpdatePayType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify security configurations of SCDN acceleration domain names.
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public Task<UpdateScdnDomainResponse> UpdateScdnDomain(UpdateScdnDomainRequest req)
        {
            return InternalRequestAsync<UpdateScdnDomainResponse>(req, "UpdateScdnDomain");
        }

        /// <summary>
        /// This API is used to modify security configurations of SCDN acceleration domain names.
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public UpdateScdnDomainResponse UpdateScdnDomainSync(UpdateScdnDomainRequest req)
        {
            return InternalRequestAsync<UpdateScdnDomainResponse>(req, "UpdateScdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
