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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PrivatednsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to create a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="CreatePrivateDNSAccountResponse"/></returns>
        public async Task<CreatePrivateDNSAccountResponse> CreatePrivateDNSAccount(CreatePrivateDNSAccountRequest req)
        {
             JsonResponseModel<CreatePrivateDNSAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateDNSAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateDNSAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="CreatePrivateDNSAccountResponse"/></returns>
        public CreatePrivateDNSAccountResponse CreatePrivateDNSAccountSync(CreatePrivateDNSAccountRequest req)
        {
             JsonResponseModel<CreatePrivateDNSAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateDNSAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateDNSAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public async Task<CreatePrivateZoneResponse> CreatePrivateZone(CreatePrivateZoneRequest req)
        {
             JsonResponseModel<CreatePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public CreatePrivateZoneResponse CreatePrivateZoneSync(CreatePrivateZoneRequest req)
        {
             JsonResponseModel<CreatePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public async Task<CreatePrivateZoneRecordResponse> CreatePrivateZoneRecord(CreatePrivateZoneRecordRequest req)
        {
             JsonResponseModel<CreatePrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public CreatePrivateZoneRecordResponse CreatePrivateZoneRecordSync(CreatePrivateZoneRecordRequest req)
        {
             JsonResponseModel<CreatePrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the VPC list of a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountVpcListRequest"/></param>
        /// <returns><see cref="DescribeAccountVpcListResponse"/></returns>
        public async Task<DescribeAccountVpcListResponse> DescribeAccountVpcList(DescribeAccountVpcListRequest req)
        {
             JsonResponseModel<DescribeAccountVpcListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountVpcList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountVpcListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the VPC list of a Private DNS account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountVpcListRequest"/></param>
        /// <returns><see cref="DescribeAccountVpcListResponse"/></returns>
        public DescribeAccountVpcListResponse DescribeAccountVpcListSync(DescribeAccountVpcListRequest req)
        {
             JsonResponseModel<DescribeAccountVpcListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountVpcList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountVpcListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public async Task<DescribeAuditLogResponse> DescribeAuditLog(DescribeAuditLogRequest req)
        {
             JsonResponseModel<DescribeAuditLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuditLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of operation logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public DescribeAuditLogResponse DescribeAuditLogSync(DescribeAuditLogRequest req)
        {
             JsonResponseModel<DescribeAuditLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuditLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the overview of private DNS records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public async Task<DescribeDashboardResponse> DescribeDashboard(DescribeDashboardRequest req)
        {
             JsonResponseModel<DescribeDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the overview of private DNS records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public DescribeDashboardResponse DescribeDashboardSync(DescribeDashboardRequest req)
        {
             JsonResponseModel<DescribeDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of Private DNS accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateDNSAccountListRequest"/></param>
        /// <returns><see cref="DescribePrivateDNSAccountListResponse"/></returns>
        public async Task<DescribePrivateDNSAccountListResponse> DescribePrivateDNSAccountList(DescribePrivateDNSAccountListRequest req)
        {
             JsonResponseModel<DescribePrivateDNSAccountListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateDNSAccountList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateDNSAccountListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of Private DNS accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateDNSAccountListRequest"/></param>
        /// <returns><see cref="DescribePrivateDNSAccountListResponse"/></returns>
        public DescribePrivateDNSAccountListResponse DescribePrivateDNSAccountListSync(DescribePrivateDNSAccountListRequest req)
        {
             JsonResponseModel<DescribePrivateDNSAccountListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateDNSAccountList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateDNSAccountListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the Private DNS activation status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public async Task<DescribePrivateZoneServiceResponse> DescribePrivateZoneService(DescribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<DescribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the Private DNS activation status.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public DescribePrivateZoneServiceResponse DescribePrivateZoneServiceSync(DescribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<DescribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query quota usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeQuotaUsageResponse"/></returns>
        public async Task<DescribeQuotaUsageResponse> DescribeQuotaUsage(DescribeQuotaUsageRequest req)
        {
             JsonResponseModel<DescribeQuotaUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQuotaUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query quota usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeQuotaUsageResponse"/></returns>
        public DescribeQuotaUsageResponse DescribeQuotaUsageSync(DescribeQuotaUsageRequest req)
        {
             JsonResponseModel<DescribeQuotaUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQuotaUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DNS request volume of a private domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public async Task<DescribeRequestDataResponse> DescribeRequestData(DescribeRequestDataRequest req)
        {
             JsonResponseModel<DescribeRequestDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRequestData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRequestDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the DNS request volume of a private domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public DescribeRequestDataResponse DescribeRequestDataSync(DescribeRequestDataRequest req)
        {
             JsonResponseModel<DescribeRequestDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRequestData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRequestDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public async Task<ModifyPrivateZoneResponse> ModifyPrivateZone(ModifyPrivateZoneRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public ModifyPrivateZoneResponse ModifyPrivateZoneSync(ModifyPrivateZoneRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public async Task<ModifyPrivateZoneRecordResponse> ModifyPrivateZoneRecord(ModifyPrivateZoneRecordRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a DNS record for a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public ModifyPrivateZoneRecordResponse ModifyPrivateZoneRecordSync(ModifyPrivateZoneRecordRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC associated with a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public async Task<ModifyPrivateZoneVpcResponse> ModifyPrivateZoneVpc(ModifyPrivateZoneVpcRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateZoneVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC associated with a private domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public ModifyPrivateZoneVpcResponse ModifyPrivateZoneVpcSync(ModifyPrivateZoneVpcRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateZoneVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the DNS record status.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordsStatusResponse"/></returns>
        public async Task<ModifyRecordsStatusResponse> ModifyRecordsStatus(ModifyRecordsStatusRequest req)
        {
             JsonResponseModel<ModifyRecordsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the DNS record status.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordsStatusResponse"/></returns>
        public ModifyRecordsStatusResponse ModifyRecordsStatusSync(ModifyRecordsStatusRequest req)
        {
             JsonResponseModel<ModifyRecordsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to activate the Private DNS service.
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public async Task<SubscribePrivateZoneServiceResponse> SubscribePrivateZoneService(SubscribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<SubscribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubscribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubscribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to activate the Private DNS service.
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public SubscribePrivateZoneServiceResponse SubscribePrivateZoneServiceSync(SubscribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<SubscribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubscribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubscribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
