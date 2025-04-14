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

namespace TencentCloud.Dnspod.V20210323
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dnspod.V20210323.Models;

   public class DnspodClient : AbstractClient{

       private const string endpoint = "dnspod.intl.tencentcloudapi.com";
       private const string version = "2021-03-23";
       private const string sdkVersion = "SDK_NET_3.0.1111";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DnspodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DnspodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add a domain.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain");
        }

        /// <summary>
        /// This API is used to add a domain.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a domain alias.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAliasRequest"/></param>
        /// <returns><see cref="CreateDomainAliasResponse"/></returns>
        public Task<CreateDomainAliasResponse> CreateDomainAlias(CreateDomainAliasRequest req)
        {
            return InternalRequestAsync<CreateDomainAliasResponse>(req, "CreateDomainAlias");
        }

        /// <summary>
        /// This API is used to create a domain alias.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAliasRequest"/></param>
        /// <returns><see cref="CreateDomainAliasResponse"/></returns>
        public CreateDomainAliasResponse CreateDomainAliasSync(CreateDomainAliasRequest req)
        {
            return InternalRequestAsync<CreateDomainAliasResponse>(req, "CreateDomainAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk add domains.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public Task<CreateDomainBatchResponse> CreateDomainBatch(CreateDomainBatchRequest req)
        {
            return InternalRequestAsync<CreateDomainBatchResponse>(req, "CreateDomainBatch");
        }

        /// <summary>
        /// This API is used to bulk add domains.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public CreateDomainBatchResponse CreateDomainBatchSync(CreateDomainBatchRequest req)
        {
            return InternalRequestAsync<CreateDomainBatchResponse>(req, "CreateDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a domain group.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainGroupRequest"/></param>
        /// <returns><see cref="CreateDomainGroupResponse"/></returns>
        public Task<CreateDomainGroupResponse> CreateDomainGroup(CreateDomainGroupRequest req)
        {
            return InternalRequestAsync<CreateDomainGroupResponse>(req, "CreateDomainGroup");
        }

        /// <summary>
        /// This API is used to create a domain group.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainGroupRequest"/></param>
        /// <returns><see cref="CreateDomainGroupResponse"/></returns>
        public CreateDomainGroupResponse CreateDomainGroupSync(CreateDomainGroupRequest req)
        {
            return InternalRequestAsync<CreateDomainGroupResponse>(req, "CreateDomainGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a record.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordRequest"/></param>
        /// <returns><see cref="CreateRecordResponse"/></returns>
        public Task<CreateRecordResponse> CreateRecord(CreateRecordRequest req)
        {
            return InternalRequestAsync<CreateRecordResponse>(req, "CreateRecord");
        }

        /// <summary>
        /// This API is used to add a record.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordRequest"/></param>
        /// <returns><see cref="CreateRecordResponse"/></returns>
        public CreateRecordResponse CreateRecordSync(CreateRecordRequest req)
        {
            return InternalRequestAsync<CreateRecordResponse>(req, "CreateRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk add records.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordBatchRequest"/></param>
        /// <returns><see cref="CreateRecordBatchResponse"/></returns>
        public Task<CreateRecordBatchResponse> CreateRecordBatch(CreateRecordBatchRequest req)
        {
            return InternalRequestAsync<CreateRecordBatchResponse>(req, "CreateRecordBatch");
        }

        /// <summary>
        /// This API is used to bulk add records.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordBatchRequest"/></param>
        /// <returns><see cref="CreateRecordBatchResponse"/></returns>
        public CreateRecordBatchResponse CreateRecordBatchSync(CreateRecordBatchRequest req)
        {
            return InternalRequestAsync<CreateRecordBatchResponse>(req, "CreateRecordBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a record group.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordGroupRequest"/></param>
        /// <returns><see cref="CreateRecordGroupResponse"/></returns>
        public Task<CreateRecordGroupResponse> CreateRecordGroup(CreateRecordGroupRequest req)
        {
            return InternalRequestAsync<CreateRecordGroupResponse>(req, "CreateRecordGroup");
        }

        /// <summary>
        /// This API is used to add a record group.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordGroupRequest"/></param>
        /// <returns><see cref="CreateRecordGroupResponse"/></returns>
        public CreateRecordGroupResponse CreateRecordGroupSync(CreateRecordGroupRequest req)
        {
            return InternalRequestAsync<CreateRecordGroupResponse>(req, "CreateRecordGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a domain.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain");
        }

        /// <summary>
        /// This API is used to delete a domain.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a domain alias.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAliasRequest"/></param>
        /// <returns><see cref="DeleteDomainAliasResponse"/></returns>
        public Task<DeleteDomainAliasResponse> DeleteDomainAlias(DeleteDomainAliasRequest req)
        {
            return InternalRequestAsync<DeleteDomainAliasResponse>(req, "DeleteDomainAlias");
        }

        /// <summary>
        /// This API is used to delete a domain alias.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAliasRequest"/></param>
        /// <returns><see cref="DeleteDomainAliasResponse"/></returns>
        public DeleteDomainAliasResponse DeleteDomainAliasSync(DeleteDomainAliasRequest req)
        {
            return InternalRequestAsync<DeleteDomainAliasResponse>(req, "DeleteDomainAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete domains.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainBatchRequest"/></param>
        /// <returns><see cref="DeleteDomainBatchResponse"/></returns>
        public Task<DeleteDomainBatchResponse> DeleteDomainBatch(DeleteDomainBatchRequest req)
        {
            return InternalRequestAsync<DeleteDomainBatchResponse>(req, "DeleteDomainBatch");
        }

        /// <summary>
        /// This API is used to batch delete domains.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainBatchRequest"/></param>
        /// <returns><see cref="DeleteDomainBatchResponse"/></returns>
        public DeleteDomainBatchResponse DeleteDomainBatchSync(DeleteDomainBatchRequest req)
        {
            return InternalRequestAsync<DeleteDomainBatchResponse>(req, "DeleteDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a record.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest req)
        {
            return InternalRequestAsync<DeleteRecordResponse>(req, "DeleteRecord");
        }

        /// <summary>
        /// This API is used to delete a record.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public DeleteRecordResponse DeleteRecordSync(DeleteRecordRequest req)
        {
            return InternalRequestAsync<DeleteRecordResponse>(req, "DeleteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a record group.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordGroupRequest"/></param>
        /// <returns><see cref="DeleteRecordGroupResponse"/></returns>
        public Task<DeleteRecordGroupResponse> DeleteRecordGroup(DeleteRecordGroupRequest req)
        {
            return InternalRequestAsync<DeleteRecordGroupResponse>(req, "DeleteRecordGroup");
        }

        /// <summary>
        /// This API is used to delete a record group.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordGroupRequest"/></param>
        /// <returns><see cref="DeleteRecordGroupResponse"/></returns>
        public DeleteRecordGroupResponse DeleteRecordGroupSync(DeleteRecordGroupRequest req)
        {
            return InternalRequestAsync<DeleteRecordGroupResponse>(req, "DeleteRecordGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unshare a domain.
        /// </summary>
        /// <param name="req"><see cref="DeleteShareDomainRequest"/></param>
        /// <returns><see cref="DeleteShareDomainResponse"/></returns>
        public Task<DeleteShareDomainResponse> DeleteShareDomain(DeleteShareDomainRequest req)
        {
            return InternalRequestAsync<DeleteShareDomainResponse>(req, "DeleteShareDomain");
        }

        /// <summary>
        /// This API is used to unshare a domain.
        /// </summary>
        /// <param name="req"><see cref="DeleteShareDomainRequest"/></param>
        /// <returns><see cref="DeleteShareDomainResponse"/></returns>
        public DeleteShareDomainResponse DeleteShareDomainSync(DeleteShareDomainRequest req)
        {
            return InternalRequestAsync<DeleteShareDomainResponse>(req, "DeleteShareDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public Task<DescribeDomainResponse> DescribeDomain(DescribeDomainRequest req)
        {
            return InternalRequestAsync<DescribeDomainResponse>(req, "DescribeDomain");
        }

        /// <summary>
        /// This API is used to get the information of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public DescribeDomainResponse DescribeDomainSync(DescribeDomainRequest req)
        {
            return InternalRequestAsync<DescribeDomainResponse>(req, "DescribeDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of domain aliases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAliasListRequest"/></param>
        /// <returns><see cref="DescribeDomainAliasListResponse"/></returns>
        public Task<DescribeDomainAliasListResponse> DescribeDomainAliasList(DescribeDomainAliasListRequest req)
        {
            return InternalRequestAsync<DescribeDomainAliasListResponse>(req, "DescribeDomainAliasList");
        }

        /// <summary>
        /// This API is used to get the list of domain aliases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAliasListRequest"/></param>
        /// <returns><see cref="DescribeDomainAliasListResponse"/></returns>
        public DescribeDomainAliasListResponse DescribeDomainAliasListSync(DescribeDomainAliasListRequest req)
        {
            return InternalRequestAsync<DescribeDomainAliasListResponse>(req, "DescribeDomainAliasList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of domain groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainGroupListRequest"/></param>
        /// <returns><see cref="DescribeDomainGroupListResponse"/></returns>
        public Task<DescribeDomainGroupListResponse> DescribeDomainGroupList(DescribeDomainGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDomainGroupListResponse>(req, "DescribeDomainGroupList");
        }

        /// <summary>
        /// This API is used to get the list of domain groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainGroupListRequest"/></param>
        /// <returns><see cref="DescribeDomainGroupListResponse"/></returns>
        public DescribeDomainGroupListResponse DescribeDomainGroupListSync(DescribeDomainGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDomainGroupListResponse>(req, "DescribeDomainGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of domains.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainListRequest"/></param>
        /// <returns><see cref="DescribeDomainListResponse"/></returns>
        public Task<DescribeDomainListResponse> DescribeDomainList(DescribeDomainListRequest req)
        {
            return InternalRequestAsync<DescribeDomainListResponse>(req, "DescribeDomainList");
        }

        /// <summary>
        /// This API is used to get the list of domains.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainListRequest"/></param>
        /// <returns><see cref="DescribeDomainListResponse"/></returns>
        public DescribeDomainListResponse DescribeDomainListSync(DescribeDomainListRequest req)
        {
            return InternalRequestAsync<DescribeDomainListResponse>(req, "DescribeDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the log of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainLogListRequest"/></param>
        /// <returns><see cref="DescribeDomainLogListResponse"/></returns>
        public Task<DescribeDomainLogListResponse> DescribeDomainLogList(DescribeDomainLogListRequest req)
        {
            return InternalRequestAsync<DescribeDomainLogListResponse>(req, "DescribeDomainLogList");
        }

        /// <summary>
        /// This API is used to get the log of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainLogListRequest"/></param>
        /// <returns><see cref="DescribeDomainLogListResponse"/></returns>
        public DescribeDomainLogListResponse DescribeDomainLogListSync(DescribeDomainLogListRequest req)
        {
            return InternalRequestAsync<DescribeDomainLogListResponse>(req, "DescribeDomainLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the permissions of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPurviewRequest"/></param>
        /// <returns><see cref="DescribeDomainPurviewResponse"/></returns>
        public Task<DescribeDomainPurviewResponse> DescribeDomainPurview(DescribeDomainPurviewRequest req)
        {
            return InternalRequestAsync<DescribeDomainPurviewResponse>(req, "DescribeDomainPurview");
        }

        /// <summary>
        /// This API is used to get the permissions of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPurviewRequest"/></param>
        /// <returns><see cref="DescribeDomainPurviewResponse"/></returns>
        public DescribeDomainPurviewResponse DescribeDomainPurviewSync(DescribeDomainPurviewRequest req)
        {
            return InternalRequestAsync<DescribeDomainPurviewResponse>(req, "DescribeDomainPurview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the domain sharing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainShareInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainShareInfoResponse"/></returns>
        public Task<DescribeDomainShareInfoResponse> DescribeDomainShareInfo(DescribeDomainShareInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainShareInfoResponse>(req, "DescribeDomainShareInfo");
        }

        /// <summary>
        /// This API is used to get the domain sharing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainShareInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainShareInfoResponse"/></returns>
        public DescribeDomainShareInfoResponse DescribeDomainShareInfoSync(DescribeDomainShareInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainShareInfoResponse>(req, "DescribeDomainShareInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a record.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRequest"/></param>
        /// <returns><see cref="DescribeRecordResponse"/></returns>
        public Task<DescribeRecordResponse> DescribeRecord(DescribeRecordRequest req)
        {
            return InternalRequestAsync<DescribeRecordResponse>(req, "DescribeRecord");
        }

        /// <summary>
        /// This API is used to get the information of a record.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRequest"/></param>
        /// <returns><see cref="DescribeRecordResponse"/></returns>
        public DescribeRecordResponse DescribeRecordSync(DescribeRecordRequest req)
        {
            return InternalRequestAsync<DescribeRecordResponse>(req, "DescribeRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of DNS record groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordGroupListRequest"/></param>
        /// <returns><see cref="DescribeRecordGroupListResponse"/></returns>
        public Task<DescribeRecordGroupListResponse> DescribeRecordGroupList(DescribeRecordGroupListRequest req)
        {
            return InternalRequestAsync<DescribeRecordGroupListResponse>(req, "DescribeRecordGroupList");
        }

        /// <summary>
        /// This API is used to query the list of DNS record groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordGroupListRequest"/></param>
        /// <returns><see cref="DescribeRecordGroupListResponse"/></returns>
        public DescribeRecordGroupListResponse DescribeRecordGroupListSync(DescribeRecordGroupListRequest req)
        {
            return InternalRequestAsync<DescribeRecordGroupListResponse>(req, "DescribeRecordGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the split zones allowed by the domain level.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordLineListRequest"/></param>
        /// <returns><see cref="DescribeRecordLineListResponse"/></returns>
        public Task<DescribeRecordLineListResponse> DescribeRecordLineList(DescribeRecordLineListRequest req)
        {
            return InternalRequestAsync<DescribeRecordLineListResponse>(req, "DescribeRecordLineList");
        }

        /// <summary>
        /// This API is used to get the split zones allowed by the domain level.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordLineListRequest"/></param>
        /// <returns><see cref="DescribeRecordLineListResponse"/></returns>
        public DescribeRecordLineListResponse DescribeRecordLineListSync(DescribeRecordLineListRequest req)
        {
            return InternalRequestAsync<DescribeRecordLineListResponse>(req, "DescribeRecordLineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DNS records of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordListRequest"/></param>
        /// <returns><see cref="DescribeRecordListResponse"/></returns>
        public Task<DescribeRecordListResponse> DescribeRecordList(DescribeRecordListRequest req)
        {
            return InternalRequestAsync<DescribeRecordListResponse>(req, "DescribeRecordList");
        }

        /// <summary>
        /// This API is used to get the DNS records of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordListRequest"/></param>
        /// <returns><see cref="DescribeRecordListResponse"/></returns>
        public DescribeRecordListResponse DescribeRecordListSync(DescribeRecordListRequest req)
        {
            return InternalRequestAsync<DescribeRecordListResponse>(req, "DescribeRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the record type allowed by the domain level.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTypeRequest"/></param>
        /// <returns><see cref="DescribeRecordTypeResponse"/></returns>
        public Task<DescribeRecordTypeResponse> DescribeRecordType(DescribeRecordTypeRequest req)
        {
            return InternalRequestAsync<DescribeRecordTypeResponse>(req, "DescribeRecordType");
        }

        /// <summary>
        /// This API is used to get the record type allowed by the domain level.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTypeRequest"/></param>
        /// <returns><see cref="DescribeRecordTypeResponse"/></returns>
        public DescribeRecordTypeResponse DescribeRecordTypeSync(DescribeRecordTypeRequest req)
        {
            return InternalRequestAsync<DescribeRecordTypeResponse>(req, "DescribeRecordType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to collect statistics on the DNS query volume of a subdomain. It helps you understand the traffic and time period distribution and allows you to view statistics in the last three months. It is available only for domains under a paid plan.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubdomainAnalyticsRequest"/></param>
        /// <returns><see cref="DescribeSubdomainAnalyticsResponse"/></returns>
        public Task<DescribeSubdomainAnalyticsResponse> DescribeSubdomainAnalytics(DescribeSubdomainAnalyticsRequest req)
        {
            return InternalRequestAsync<DescribeSubdomainAnalyticsResponse>(req, "DescribeSubdomainAnalytics");
        }

        /// <summary>
        /// This API is used to collect statistics on the DNS query volume of a subdomain. It helps you understand the traffic and time period distribution and allows you to view statistics in the last three months. It is available only for domains under a paid plan.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubdomainAnalyticsRequest"/></param>
        /// <returns><see cref="DescribeSubdomainAnalyticsResponse"/></returns>
        public DescribeSubdomainAnalyticsResponse DescribeSubdomainAnalyticsSync(DescribeSubdomainAnalyticsRequest req)
        {
            return InternalRequestAsync<DescribeSubdomainAnalyticsResponse>(req, "DescribeSubdomainAnalytics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to lock a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainLockRequest"/></param>
        /// <returns><see cref="ModifyDomainLockResponse"/></returns>
        public Task<ModifyDomainLockResponse> ModifyDomainLock(ModifyDomainLockRequest req)
        {
            return InternalRequestAsync<ModifyDomainLockResponse>(req, "ModifyDomainLock");
        }

        /// <summary>
        /// This API is used to lock a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainLockRequest"/></param>
        /// <returns><see cref="ModifyDomainLockResponse"/></returns>
        public ModifyDomainLockResponse ModifyDomainLockSync(ModifyDomainLockRequest req)
        {
            return InternalRequestAsync<ModifyDomainLockResponse>(req, "ModifyDomainLock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to transfer ownership of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerResponse"/></returns>
        public Task<ModifyDomainOwnerResponse> ModifyDomainOwner(ModifyDomainOwnerRequest req)
        {
            return InternalRequestAsync<ModifyDomainOwnerResponse>(req, "ModifyDomainOwner");
        }

        /// <summary>
        /// This API is used to transfer ownership of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerResponse"/></returns>
        public ModifyDomainOwnerResponse ModifyDomainOwnerSync(ModifyDomainOwnerRequest req)
        {
            return InternalRequestAsync<ModifyDomainOwnerResponse>(req, "ModifyDomainOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the remarks of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRemarkRequest"/></param>
        /// <returns><see cref="ModifyDomainRemarkResponse"/></returns>
        public Task<ModifyDomainRemarkResponse> ModifyDomainRemark(ModifyDomainRemarkRequest req)
        {
            return InternalRequestAsync<ModifyDomainRemarkResponse>(req, "ModifyDomainRemark");
        }

        /// <summary>
        /// This API is used to set the remarks of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRemarkRequest"/></param>
        /// <returns><see cref="ModifyDomainRemarkResponse"/></returns>
        public ModifyDomainRemarkResponse ModifyDomainRemarkSync(ModifyDomainRemarkRequest req)
        {
            return InternalRequestAsync<ModifyDomainRemarkResponse>(req, "ModifyDomainRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainStatusResponse"/></returns>
        public Task<ModifyDomainStatusResponse> ModifyDomainStatus(ModifyDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainStatusResponse>(req, "ModifyDomainStatus");
        }

        /// <summary>
        /// This API is used to modify the status of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainStatusResponse"/></returns>
        public ModifyDomainStatusResponse ModifyDomainStatusSync(ModifyDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainStatusResponse>(req, "ModifyDomainStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unlock a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUnlockRequest"/></param>
        /// <returns><see cref="ModifyDomainUnlockResponse"/></returns>
        public Task<ModifyDomainUnlockResponse> ModifyDomainUnlock(ModifyDomainUnlockRequest req)
        {
            return InternalRequestAsync<ModifyDomainUnlockResponse>(req, "ModifyDomainUnlock");
        }

        /// <summary>
        /// This API is used to unlock a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUnlockRequest"/></param>
        /// <returns><see cref="ModifyDomainUnlockResponse"/></returns>
        public ModifyDomainUnlockResponse ModifyDomainUnlockSync(ModifyDomainUnlockRequest req)
        {
            return InternalRequestAsync<ModifyDomainUnlockResponse>(req, "ModifyDomainUnlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a record.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRequest"/></param>
        /// <returns><see cref="ModifyRecordResponse"/></returns>
        public Task<ModifyRecordResponse> ModifyRecord(ModifyRecordRequest req)
        {
            return InternalRequestAsync<ModifyRecordResponse>(req, "ModifyRecord");
        }

        /// <summary>
        /// This API is used to modify a record.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRequest"/></param>
        /// <returns><see cref="ModifyRecordResponse"/></returns>
        public ModifyRecordResponse ModifyRecordSync(ModifyRecordRequest req)
        {
            return InternalRequestAsync<ModifyRecordResponse>(req, "ModifyRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk modify records.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordBatchRequest"/></param>
        /// <returns><see cref="ModifyRecordBatchResponse"/></returns>
        public Task<ModifyRecordBatchResponse> ModifyRecordBatch(ModifyRecordBatchRequest req)
        {
            return InternalRequestAsync<ModifyRecordBatchResponse>(req, "ModifyRecordBatch");
        }

        /// <summary>
        /// This API is used to bulk modify records.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordBatchRequest"/></param>
        /// <returns><see cref="ModifyRecordBatchResponse"/></returns>
        public ModifyRecordBatchResponse ModifyRecordBatchSync(ModifyRecordBatchRequest req)
        {
            return InternalRequestAsync<ModifyRecordBatchResponse>(req, "ModifyRecordBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a record group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordGroupResponse"/></returns>
        public Task<ModifyRecordGroupResponse> ModifyRecordGroup(ModifyRecordGroupRequest req)
        {
            return InternalRequestAsync<ModifyRecordGroupResponse>(req, "ModifyRecordGroup");
        }

        /// <summary>
        /// This API is used to modify a record group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordGroupResponse"/></returns>
        public ModifyRecordGroupResponse ModifyRecordGroupSync(ModifyRecordGroupRequest req)
        {
            return InternalRequestAsync<ModifyRecordGroupResponse>(req, "ModifyRecordGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the remarks of a record.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRemarkRequest"/></param>
        /// <returns><see cref="ModifyRecordRemarkResponse"/></returns>
        public Task<ModifyRecordRemarkResponse> ModifyRecordRemark(ModifyRecordRemarkRequest req)
        {
            return InternalRequestAsync<ModifyRecordRemarkResponse>(req, "ModifyRecordRemark");
        }

        /// <summary>
        /// This API is used to set the remarks of a record.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRemarkRequest"/></param>
        /// <returns><see cref="ModifyRecordRemarkResponse"/></returns>
        public ModifyRecordRemarkResponse ModifyRecordRemarkSync(ModifyRecordRemarkRequest req)
        {
            return InternalRequestAsync<ModifyRecordRemarkResponse>(req, "ModifyRecordRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the DNS record status.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordStatusResponse"/></returns>
        public Task<ModifyRecordStatusResponse> ModifyRecordStatus(ModifyRecordStatusRequest req)
        {
            return InternalRequestAsync<ModifyRecordStatusResponse>(req, "ModifyRecordStatus");
        }

        /// <summary>
        /// This API is used to modify the DNS record status.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordStatusResponse"/></returns>
        public ModifyRecordStatusResponse ModifyRecordStatusSync(ModifyRecordStatusRequest req)
        {
            return InternalRequestAsync<ModifyRecordStatusResponse>(req, "ModifyRecordStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a record to a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordToGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordToGroupResponse"/></returns>
        public Task<ModifyRecordToGroupResponse> ModifyRecordToGroup(ModifyRecordToGroupRequest req)
        {
            return InternalRequestAsync<ModifyRecordToGroupResponse>(req, "ModifyRecordToGroup");
        }

        /// <summary>
        /// This API is used to add a record to a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordToGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordToGroupResponse"/></returns>
        public ModifyRecordToGroupResponse ModifyRecordToGroupSync(ModifyRecordToGroupRequest req)
        {
            return InternalRequestAsync<ModifyRecordToGroupResponse>(req, "ModifyRecordToGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
