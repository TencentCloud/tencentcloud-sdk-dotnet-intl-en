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

namespace TencentCloud.Privatedns.V20201028
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Privatedns.V20201028.Models;

   public class PrivatednsClient : AbstractClient{

       private const string endpoint = "privatedns.tencentcloudapi.com";
       private const string version = "2020-10-28";
       private const string sdkVersion = "SDK_NET_3.0.1060";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PrivatednsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PrivatednsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateEndPointRequest"/></param>
        /// <returns><see cref="CreateEndPointResponse"/></returns>
        public Task<CreateEndPointResponse> CreateEndPoint(CreateEndPointRequest req)
        {
            return InternalRequestAsync<CreateEndPointResponse>(req, "CreateEndPoint");
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateEndPointRequest"/></param>
        /// <returns><see cref="CreateEndPointResponse"/></returns>
        public CreateEndPointResponse CreateEndPointSync(CreateEndPointRequest req)
        {
            return InternalRequestAsync<CreateEndPointResponse>(req, "CreateEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an endpoint and an endpoint service simultaneously.
        /// </summary>
        /// <param name="req"><see cref="CreateEndPointAndEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateEndPointAndEndPointServiceResponse"/></returns>
        public Task<CreateEndPointAndEndPointServiceResponse> CreateEndPointAndEndPointService(CreateEndPointAndEndPointServiceRequest req)
        {
            return InternalRequestAsync<CreateEndPointAndEndPointServiceResponse>(req, "CreateEndPointAndEndPointService");
        }

        /// <summary>
        /// This API is used to create an endpoint and an endpoint service simultaneously.
        /// </summary>
        /// <param name="req"><see cref="CreateEndPointAndEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateEndPointAndEndPointServiceResponse"/></returns>
        public CreateEndPointAndEndPointServiceResponse CreateEndPointAndEndPointServiceSync(CreateEndPointAndEndPointServiceRequest req)
        {
            return InternalRequestAsync<CreateEndPointAndEndPointServiceResponse>(req, "CreateEndPointAndEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateExtendEndpointRequest"/></param>
        /// <returns><see cref="CreateExtendEndpointResponse"/></returns>
        public Task<CreateExtendEndpointResponse> CreateExtendEndpoint(CreateExtendEndpointRequest req)
        {
            return InternalRequestAsync<CreateExtendEndpointResponse>(req, "CreateExtendEndpoint");
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateExtendEndpointRequest"/></param>
        /// <returns><see cref="CreateExtendEndpointResponse"/></returns>
        public CreateExtendEndpointResponse CreateExtendEndpointSync(CreateExtendEndpointRequest req)
        {
            return InternalRequestAsync<CreateExtendEndpointResponse>(req, "CreateExtendEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a custom forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateForwardRuleRequest"/></param>
        /// <returns><see cref="CreateForwardRuleResponse"/></returns>
        public Task<CreateForwardRuleResponse> CreateForwardRule(CreateForwardRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardRuleResponse>(req, "CreateForwardRule");
        }

        /// <summary>
        /// This API is used to create a custom forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="CreateForwardRuleRequest"/></param>
        /// <returns><see cref="CreateForwardRuleResponse"/></returns>
        public CreateForwardRuleResponse CreateForwardRuleSync(CreateForwardRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardRuleResponse>(req, "CreateForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="CreatePrivateDNSAccountResponse"/></returns>
        public Task<CreatePrivateDNSAccountResponse> CreatePrivateDNSAccount(CreatePrivateDNSAccountRequest req)
        {
            return InternalRequestAsync<CreatePrivateDNSAccountResponse>(req, "CreatePrivateDNSAccount");
        }

        /// <summary>
        /// This API is used to create a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="CreatePrivateDNSAccountResponse"/></returns>
        public CreatePrivateDNSAccountResponse CreatePrivateDNSAccountSync(CreatePrivateDNSAccountRequest req)
        {
            return InternalRequestAsync<CreatePrivateDNSAccountResponse>(req, "CreatePrivateDNSAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public Task<CreatePrivateZoneResponse> CreatePrivateZone(CreatePrivateZoneRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneResponse>(req, "CreatePrivateZone");
        }

        /// <summary>
        /// This API is used to create a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public CreatePrivateZoneResponse CreatePrivateZoneSync(CreatePrivateZoneRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneResponse>(req, "CreatePrivateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public Task<CreatePrivateZoneRecordResponse> CreatePrivateZoneRecord(CreatePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneRecordResponse>(req, "CreatePrivateZoneRecord");
        }

        /// <summary>
        /// This API is used to add a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public CreatePrivateZoneRecordResponse CreatePrivateZoneRecordSync(CreatePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneRecordResponse>(req, "CreatePrivateZoneRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an endpoint
        /// </summary>
        /// <param name="req"><see cref="DeleteEndPointRequest"/></param>
        /// <returns><see cref="DeleteEndPointResponse"/></returns>
        public Task<DeleteEndPointResponse> DeleteEndPoint(DeleteEndPointRequest req)
        {
            return InternalRequestAsync<DeleteEndPointResponse>(req, "DeleteEndPoint");
        }

        /// <summary>
        /// Deletes an endpoint
        /// </summary>
        /// <param name="req"><see cref="DeleteEndPointRequest"/></param>
        /// <returns><see cref="DeleteEndPointResponse"/></returns>
        public DeleteEndPointResponse DeleteEndPointSync(DeleteEndPointRequest req)
        {
            return InternalRequestAsync<DeleteEndPointResponse>(req, "DeleteEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a forwarding rule and stop forwarding.
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardRuleResponse"/></returns>
        public Task<DeleteForwardRuleResponse> DeleteForwardRule(DeleteForwardRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardRuleResponse>(req, "DeleteForwardRule");
        }

        /// <summary>
        /// This API is used to delete a forwarding rule and stop forwarding.
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardRuleResponse"/></returns>
        public DeleteForwardRuleResponse DeleteForwardRuleSync(DeleteForwardRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardRuleResponse>(req, "DeleteForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneRecordResponse"/></returns>
        public Task<DeletePrivateZoneRecordResponse> DeletePrivateZoneRecord(DeletePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<DeletePrivateZoneRecordResponse>(req, "DeletePrivateZoneRecord");
        }

        /// <summary>
        /// This API is used to delete a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneRecordResponse"/></returns>
        public DeletePrivateZoneRecordResponse DeletePrivateZoneRecordSync(DeletePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<DeletePrivateZoneRecordResponse>(req, "DeletePrivateZoneRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the VPC list of a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountVpcListRequest"/></param>
        /// <returns><see cref="DescribeAccountVpcListResponse"/></returns>
        public Task<DescribeAccountVpcListResponse> DescribeAccountVpcList(DescribeAccountVpcListRequest req)
        {
            return InternalRequestAsync<DescribeAccountVpcListResponse>(req, "DescribeAccountVpcList");
        }

        /// <summary>
        /// This API is used to get the VPC list of a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountVpcListRequest"/></param>
        /// <returns><see cref="DescribeAccountVpcListResponse"/></returns>
        public DescribeAccountVpcListResponse DescribeAccountVpcListSync(DescribeAccountVpcListRequest req)
        {
            return InternalRequestAsync<DescribeAccountVpcListResponse>(req, "DescribeAccountVpcList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public Task<DescribeAuditLogResponse> DescribeAuditLog(DescribeAuditLogRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogResponse>(req, "DescribeAuditLog");
        }

        /// <summary>
        /// This API is used to get the list of operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public DescribeAuditLogResponse DescribeAuditLogSync(DescribeAuditLogRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogResponse>(req, "DescribeAuditLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the overview of private DNS records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public Task<DescribeDashboardResponse> DescribeDashboard(DescribeDashboardRequest req)
        {
            return InternalRequestAsync<DescribeDashboardResponse>(req, "DescribeDashboard");
        }

        /// <summary>
        /// This API is used to get the overview of private DNS records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public DescribeDashboardResponse DescribeDashboardSync(DescribeDashboardRequest req)
        {
            return InternalRequestAsync<DescribeDashboardResponse>(req, "DescribeDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEndPointListRequest"/></param>
        /// <returns><see cref="DescribeEndPointListResponse"/></returns>
        public Task<DescribeEndPointListResponse> DescribeEndPointList(DescribeEndPointListRequest req)
        {
            return InternalRequestAsync<DescribeEndPointListResponse>(req, "DescribeEndPointList");
        }

        /// <summary>
        /// This API is used to obtain the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEndPointListRequest"/></param>
        /// <returns><see cref="DescribeEndPointListResponse"/></returns>
        public DescribeEndPointListResponse DescribeEndPointListSync(DescribeEndPointListRequest req)
        {
            return InternalRequestAsync<DescribeEndPointListResponse>(req, "DescribeEndPointList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the regions where the endpoint is enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeEndPointRegionRequest"/></param>
        /// <returns><see cref="DescribeEndPointRegionResponse"/></returns>
        public Task<DescribeEndPointRegionResponse> DescribeEndPointRegion(DescribeEndPointRegionRequest req)
        {
            return InternalRequestAsync<DescribeEndPointRegionResponse>(req, "DescribeEndPointRegion");
        }

        /// <summary>
        /// This API is used to query the regions where the endpoint is enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeEndPointRegionRequest"/></param>
        /// <returns><see cref="DescribeEndPointRegionResponse"/></returns>
        public DescribeEndPointRegionResponse DescribeEndPointRegionSync(DescribeEndPointRegionRequest req)
        {
            return InternalRequestAsync<DescribeEndPointRegionResponse>(req, "DescribeEndPointRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExtendEndpointListRequest"/></param>
        /// <returns><see cref="DescribeExtendEndpointListResponse"/></returns>
        public Task<DescribeExtendEndpointListResponse> DescribeExtendEndpointList(DescribeExtendEndpointListRequest req)
        {
            return InternalRequestAsync<DescribeExtendEndpointListResponse>(req, "DescribeExtendEndpointList");
        }

        /// <summary>
        /// This API is used to obtain the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExtendEndpointListRequest"/></param>
        /// <returns><see cref="DescribeExtendEndpointListResponse"/></returns>
        public DescribeExtendEndpointListResponse DescribeExtendEndpointListSync(DescribeExtendEndpointListRequest req)
        {
            return InternalRequestAsync<DescribeExtendEndpointListResponse>(req, "DescribeExtendEndpointList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleResponse"/></returns>
        public Task<DescribeForwardRuleResponse> DescribeForwardRule(DescribeForwardRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardRuleResponse>(req, "DescribeForwardRule");
        }

        /// <summary>
        /// This API is used to query forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleResponse"/></returns>
        public DescribeForwardRuleResponse DescribeForwardRuleSync(DescribeForwardRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardRuleResponse>(req, "DescribeForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the forwarding rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleListRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleListResponse"/></returns>
        public Task<DescribeForwardRuleListResponse> DescribeForwardRuleList(DescribeForwardRuleListRequest req)
        {
            return InternalRequestAsync<DescribeForwardRuleListResponse>(req, "DescribeForwardRuleList");
        }

        /// <summary>
        /// This API is used to query the forwarding rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleListRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleListResponse"/></returns>
        public DescribeForwardRuleListResponse DescribeForwardRuleListSync(DescribeForwardRuleListRequest req)
        {
            return InternalRequestAsync<DescribeForwardRuleListResponse>(req, "DescribeForwardRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of Private DNS accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateDNSAccountListRequest"/></param>
        /// <returns><see cref="DescribePrivateDNSAccountListResponse"/></returns>
        public Task<DescribePrivateDNSAccountListResponse> DescribePrivateDNSAccountList(DescribePrivateDNSAccountListRequest req)
        {
            return InternalRequestAsync<DescribePrivateDNSAccountListResponse>(req, "DescribePrivateDNSAccountList");
        }

        /// <summary>
        /// This API is used to get the list of Private DNS accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateDNSAccountListRequest"/></param>
        /// <returns><see cref="DescribePrivateDNSAccountListResponse"/></returns>
        public DescribePrivateDNSAccountListResponse DescribePrivateDNSAccountListSync(DescribePrivateDNSAccountListRequest req)
        {
            return InternalRequestAsync<DescribePrivateDNSAccountListResponse>(req, "DescribePrivateDNSAccountList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the private domain list.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneListResponse"/></returns>
        public Task<DescribePrivateZoneListResponse> DescribePrivateZoneList(DescribePrivateZoneListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneListResponse>(req, "DescribePrivateZoneList");
        }

        /// <summary>
        /// This API is used to obtain the private domain list.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneListResponse"/></returns>
        public DescribePrivateZoneListResponse DescribePrivateZoneListSync(DescribePrivateZoneListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneListResponse>(req, "DescribePrivateZoneList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of records for a private domain.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRecordListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneRecordListResponse"/></returns>
        public Task<DescribePrivateZoneRecordListResponse> DescribePrivateZoneRecordList(DescribePrivateZoneRecordListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneRecordListResponse>(req, "DescribePrivateZoneRecordList");
        }

        /// <summary>
        /// This API is used to get the list of records for a private domain.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRecordListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneRecordListResponse"/></returns>
        public DescribePrivateZoneRecordListResponse DescribePrivateZoneRecordListSync(DescribePrivateZoneRecordListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneRecordListResponse>(req, "DescribePrivateZoneRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Private DNS activation status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public Task<DescribePrivateZoneServiceResponse> DescribePrivateZoneService(DescribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneServiceResponse>(req, "DescribePrivateZoneService");
        }

        /// <summary>
        /// This API is used to query the Private DNS activation status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public DescribePrivateZoneServiceResponse DescribePrivateZoneServiceSync(DescribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneServiceResponse>(req, "DescribePrivateZoneService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query quota usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeQuotaUsageResponse"/></returns>
        public Task<DescribeQuotaUsageResponse> DescribeQuotaUsage(DescribeQuotaUsageRequest req)
        {
            return InternalRequestAsync<DescribeQuotaUsageResponse>(req, "DescribeQuotaUsage");
        }

        /// <summary>
        /// This API is used to query quota usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeQuotaUsageResponse"/></returns>
        public DescribeQuotaUsageResponse DescribeQuotaUsageSync(DescribeQuotaUsageRequest req)
        {
            return InternalRequestAsync<DescribeQuotaUsageResponse>(req, "DescribeQuotaUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DNS request volume of a private domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public Task<DescribeRequestDataResponse> DescribeRequestData(DescribeRequestDataRequest req)
        {
            return InternalRequestAsync<DescribeRequestDataResponse>(req, "DescribeRequestData");
        }

        /// <summary>
        /// This API is used to get the DNS request volume of a private domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public DescribeRequestDataResponse DescribeRequestDataSync(DescribeRequestDataRequest req)
        {
            return InternalRequestAsync<DescribeRequestDataResponse>(req, "DescribeRequestData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardRuleResponse"/></returns>
        public Task<ModifyForwardRuleResponse> ModifyForwardRule(ModifyForwardRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardRuleResponse>(req, "ModifyForwardRule");
        }

        /// <summary>
        /// This API is used to modify a forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardRuleResponse"/></returns>
        public ModifyForwardRuleResponse ModifyForwardRuleSync(ModifyForwardRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardRuleResponse>(req, "ModifyForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public Task<ModifyPrivateZoneResponse> ModifyPrivateZone(ModifyPrivateZoneRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneResponse>(req, "ModifyPrivateZone");
        }

        /// <summary>
        /// This API is used to modify a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public ModifyPrivateZoneResponse ModifyPrivateZoneSync(ModifyPrivateZoneRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneResponse>(req, "ModifyPrivateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public Task<ModifyPrivateZoneRecordResponse> ModifyPrivateZoneRecord(ModifyPrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneRecordResponse>(req, "ModifyPrivateZoneRecord");
        }

        /// <summary>
        /// This API is used to modify a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public ModifyPrivateZoneRecordResponse ModifyPrivateZoneRecordSync(ModifyPrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneRecordResponse>(req, "ModifyPrivateZoneRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the VPC associated with a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public Task<ModifyPrivateZoneVpcResponse> ModifyPrivateZoneVpc(ModifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneVpcResponse>(req, "ModifyPrivateZoneVpc");
        }

        /// <summary>
        /// This API is used to modify the VPC associated with a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public ModifyPrivateZoneVpcResponse ModifyPrivateZoneVpcSync(ModifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneVpcResponse>(req, "ModifyPrivateZoneVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the DNS record status.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordsStatusResponse"/></returns>
        public Task<ModifyRecordsStatusResponse> ModifyRecordsStatus(ModifyRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRecordsStatusResponse>(req, "ModifyRecordsStatus");
        }

        /// <summary>
        /// This API is used to modify the DNS record status.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordsStatusResponse"/></returns>
        public ModifyRecordsStatusResponse ModifyRecordsStatusSync(ModifyRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRecordsStatusResponse>(req, "ModifyRecordsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to activate the Private DNS service.
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public Task<SubscribePrivateZoneServiceResponse> SubscribePrivateZoneService(SubscribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<SubscribePrivateZoneServiceResponse>(req, "SubscribePrivateZoneService");
        }

        /// <summary>
        /// This API is used to activate the Private DNS service.
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public SubscribePrivateZoneServiceResponse SubscribePrivateZoneServiceSync(SubscribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<SubscribePrivateZoneServiceResponse>(req, "SubscribePrivateZoneService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
