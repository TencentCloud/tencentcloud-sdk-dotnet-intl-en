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

namespace TencentCloud.Domain.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Domain.V20180808.Models;

   public class DomainClient : AbstractClient{

       private const string endpoint = "domain.tencentcloudapi.com";
       private const string version = "2018-08-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DomainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DomainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to bulk modify DNS servers for domains.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainDNSRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainDNSResponse"/></returns>
        public async Task<BatchModifyIntlDomainDNSResponse> BatchModifyIntlDomainDNS(BatchModifyIntlDomainDNSRequest req)
        {
             JsonResponseModel<BatchModifyIntlDomainDNSResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyIntlDomainDNS");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyIntlDomainDNSResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk modify DNS servers for domains.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainDNSRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainDNSResponse"/></returns>
        public BatchModifyIntlDomainDNSResponse BatchModifyIntlDomainDNSSync(BatchModifyIntlDomainDNSRequest req)
        {
             JsonResponseModel<BatchModifyIntlDomainDNSResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyIntlDomainDNS");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyIntlDomainDNSResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk modify registrant information.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainInfoResponse"/></returns>
        public async Task<BatchModifyIntlDomainInfoResponse> BatchModifyIntlDomainInfo(BatchModifyIntlDomainInfoRequest req)
        {
             JsonResponseModel<BatchModifyIntlDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyIntlDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyIntlDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk modify registrant information.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainInfoResponse"/></returns>
        public BatchModifyIntlDomainInfoResponse BatchModifyIntlDomainInfoSync(BatchModifyIntlDomainInfoRequest req)
        {
             JsonResponseModel<BatchModifyIntlDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyIntlDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyIntlDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether a domain is available for registration.
        /// </summary>
        /// <param name="req"><see cref="CheckIntlDomainNewRequest"/></param>
        /// <returns><see cref="CheckIntlDomainNewResponse"/></returns>
        public async Task<CheckIntlDomainNewResponse> CheckIntlDomainNew(CheckIntlDomainNewRequest req)
        {
             JsonResponseModel<CheckIntlDomainNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIntlDomainNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIntlDomainNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether a domain is available for registration.
        /// </summary>
        /// <param name="req"><see cref="CheckIntlDomainNewRequest"/></param>
        /// <returns><see cref="CheckIntlDomainNewResponse"/></returns>
        public CheckIntlDomainNewResponse CheckIntlDomainNewSync(CheckIntlDomainNewRequest req)
        {
             JsonResponseModel<CheckIntlDomainNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIntlDomainNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIntlDomainNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk register domains.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlDomainBatchRequest"/></param>
        /// <returns><see cref="CreateIntlDomainBatchResponse"/></returns>
        public async Task<CreateIntlDomainBatchResponse> CreateIntlDomainBatch(CreateIntlDomainBatchRequest req)
        {
             JsonResponseModel<CreateIntlDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntlDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntlDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk register domains.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlDomainBatchRequest"/></param>
        /// <returns><see cref="CreateIntlDomainBatchResponse"/></returns>
        public CreateIntlDomainBatchResponse CreateIntlDomainBatchSync(CreateIntlDomainBatchRequest req)
        {
             JsonResponseModel<CreateIntlDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntlDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntlDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a mobile number or an email address via a verification code.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="CreateIntlPhoneEmailResponse"/></returns>
        public async Task<CreateIntlPhoneEmailResponse> CreateIntlPhoneEmail(CreateIntlPhoneEmailRequest req)
        {
             JsonResponseModel<CreateIntlPhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntlPhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntlPhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a mobile number or an email address via a verification code.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="CreateIntlPhoneEmailResponse"/></returns>
        public CreateIntlPhoneEmailResponse CreateIntlPhoneEmailSync(CreateIntlPhoneEmailRequest req)
        {
             JsonResponseModel<CreateIntlPhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntlPhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntlPhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlTemplateRequest"/></param>
        /// <returns><see cref="CreateIntlTemplateResponse"/></returns>
        public async Task<CreateIntlTemplateResponse> CreateIntlTemplate(CreateIntlTemplateRequest req)
        {
             JsonResponseModel<CreateIntlTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntlTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntlTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlTemplateRequest"/></param>
        /// <returns><see cref="CreateIntlTemplateResponse"/></returns>
        public CreateIntlTemplateResponse CreateIntlTemplateSync(CreateIntlTemplateRequest req)
        {
             JsonResponseModel<CreateIntlTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntlTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntlTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="DeleteIntlPhoneEmailResponse"/></returns>
        public async Task<DeleteIntlPhoneEmailResponse> DeleteIntlPhoneEmail(DeleteIntlPhoneEmailRequest req)
        {
             JsonResponseModel<DeleteIntlPhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntlPhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntlPhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="DeleteIntlPhoneEmailResponse"/></returns>
        public DeleteIntlPhoneEmailResponse DeleteIntlPhoneEmailSync(DeleteIntlPhoneEmailRequest req)
        {
             JsonResponseModel<DeleteIntlPhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntlPhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntlPhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlTemplateRequest"/></param>
        /// <returns><see cref="DeleteIntlTemplateResponse"/></returns>
        public async Task<DeleteIntlTemplateResponse> DeleteIntlTemplate(DeleteIntlTemplateRequest req)
        {
             JsonResponseModel<DeleteIntlTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntlTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntlTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlTemplateRequest"/></param>
        /// <returns><see cref="DeleteIntlTemplateResponse"/></returns>
        public DeleteIntlTemplateResponse DeleteIntlTemplateSync(DeleteIntlTemplateRequest req)
        {
             JsonResponseModel<DeleteIntlTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntlTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntlTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of a bulk task.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchDetailStatusRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchDetailStatusResponse"/></returns>
        public async Task<DescribeIntlBatchDetailStatusResponse> DescribeIntlBatchDetailStatus(DescribeIntlBatchDetailStatusRequest req)
        {
             JsonResponseModel<DescribeIntlBatchDetailStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlBatchDetailStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlBatchDetailStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of a bulk task.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchDetailStatusRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchDetailStatusResponse"/></returns>
        public DescribeIntlBatchDetailStatusResponse DescribeIntlBatchDetailStatusSync(DescribeIntlBatchDetailStatusRequest req)
        {
             JsonResponseModel<DescribeIntlBatchDetailStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlBatchDetailStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlBatchDetailStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the logs of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchOperationLogsResponse"/></returns>
        public async Task<DescribeIntlBatchOperationLogsResponse> DescribeIntlBatchOperationLogs(DescribeIntlBatchOperationLogsRequest req)
        {
             JsonResponseModel<DescribeIntlBatchOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlBatchOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlBatchOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the logs of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchOperationLogsResponse"/></returns>
        public DescribeIntlBatchOperationLogsResponse DescribeIntlBatchOperationLogsSync(DescribeIntlBatchOperationLogsRequest req)
        {
             JsonResponseModel<DescribeIntlBatchOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlBatchOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlBatchOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query domain information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainResponse"/></returns>
        public async Task<DescribeIntlDomainResponse> DescribeIntlDomain(DescribeIntlDomainRequest req)
        {
             JsonResponseModel<DescribeIntlDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query domain information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainResponse"/></returns>
        public DescribeIntlDomainResponse DescribeIntlDomainSync(DescribeIntlDomainRequest req)
        {
             JsonResponseModel<DescribeIntlDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the log details of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainBatchDetailsRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainBatchDetailsResponse"/></returns>
        public async Task<DescribeIntlDomainBatchDetailsResponse> DescribeIntlDomainBatchDetails(DescribeIntlDomainBatchDetailsRequest req)
        {
             JsonResponseModel<DescribeIntlDomainBatchDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlDomainBatchDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainBatchDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the log details of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainBatchDetailsRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainBatchDetailsResponse"/></returns>
        public DescribeIntlDomainBatchDetailsResponse DescribeIntlDomainBatchDetailsSync(DescribeIntlDomainBatchDetailsRequest req)
        {
             JsonResponseModel<DescribeIntlDomainBatchDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlDomainBatchDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainBatchDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the "My domains" list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainListResponse"/></returns>
        public async Task<DescribeIntlDomainListResponse> DescribeIntlDomainList(DescribeIntlDomainListRequest req)
        {
             JsonResponseModel<DescribeIntlDomainListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the "My domains" list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainListResponse"/></returns>
        public DescribeIntlDomainListResponse DescribeIntlDomainListSync(DescribeIntlDomainListRequest req)
        {
             JsonResponseModel<DescribeIntlDomainListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the price list by domain suffix.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainPriceNewListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainPriceNewListResponse"/></returns>
        public async Task<DescribeIntlDomainPriceNewListResponse> DescribeIntlDomainPriceNewList(DescribeIntlDomainPriceNewListRequest req)
        {
             JsonResponseModel<DescribeIntlDomainPriceNewListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlDomainPriceNewList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainPriceNewListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the price list by domain suffix.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainPriceNewListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainPriceNewListResponse"/></returns>
        public DescribeIntlDomainPriceNewListResponse DescribeIntlDomainPriceNewListSync(DescribeIntlDomainPriceNewListRequest req)
        {
             JsonResponseModel<DescribeIntlDomainPriceNewListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlDomainPriceNewList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlDomainPriceNewListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of verified mobile numbers and email addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlPhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribeIntlPhoneEmailListResponse"/></returns>
        public async Task<DescribeIntlPhoneEmailListResponse> DescribeIntlPhoneEmailList(DescribeIntlPhoneEmailListRequest req)
        {
             JsonResponseModel<DescribeIntlPhoneEmailListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlPhoneEmailList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlPhoneEmailListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of verified mobile numbers and email addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlPhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribeIntlPhoneEmailListResponse"/></returns>
        public DescribeIntlPhoneEmailListResponse DescribeIntlPhoneEmailListSync(DescribeIntlPhoneEmailListRequest req)
        {
             JsonResponseModel<DescribeIntlPhoneEmailListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlPhoneEmailList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlPhoneEmailListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateResponse"/></returns>
        public async Task<DescribeIntlTemplateResponse> DescribeIntlTemplate(DescribeIntlTemplateRequest req)
        {
             JsonResponseModel<DescribeIntlTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateResponse"/></returns>
        public DescribeIntlTemplateResponse DescribeIntlTemplateSync(DescribeIntlTemplateRequest req)
        {
             JsonResponseModel<DescribeIntlTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of registrant profiles.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateListRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateListResponse"/></returns>
        public async Task<DescribeIntlTemplateListResponse> DescribeIntlTemplateList(DescribeIntlTemplateListRequest req)
        {
             JsonResponseModel<DescribeIntlTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntlTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of registrant profiles.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateListRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateListResponse"/></returns>
        public DescribeIntlTemplateListResponse DescribeIntlTemplateListSync(DescribeIntlTemplateListRequest req)
        {
             JsonResponseModel<DescribeIntlTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntlTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntlTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk transfer domains to another account.
        /// </summary>
        /// <param name="req"><see cref="ModifyOwnerIntlBatchRequest"/></param>
        /// <returns><see cref="ModifyOwnerIntlBatchResponse"/></returns>
        public async Task<ModifyOwnerIntlBatchResponse> ModifyOwnerIntlBatch(ModifyOwnerIntlBatchRequest req)
        {
             JsonResponseModel<ModifyOwnerIntlBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyOwnerIntlBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOwnerIntlBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk transfer domains to another account.
        /// </summary>
        /// <param name="req"><see cref="ModifyOwnerIntlBatchRequest"/></param>
        /// <returns><see cref="ModifyOwnerIntlBatchResponse"/></returns>
        public ModifyOwnerIntlBatchResponse ModifyOwnerIntlBatchSync(ModifyOwnerIntlBatchRequest req)
        {
             JsonResponseModel<ModifyOwnerIntlBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyOwnerIntlBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOwnerIntlBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk renew domains.
        /// </summary>
        /// <param name="req"><see cref="RenewIntlDomainBatchRequest"/></param>
        /// <returns><see cref="RenewIntlDomainBatchResponse"/></returns>
        public async Task<RenewIntlDomainBatchResponse> RenewIntlDomainBatch(RenewIntlDomainBatchRequest req)
        {
             JsonResponseModel<RenewIntlDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewIntlDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewIntlDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk renew domains.
        /// </summary>
        /// <param name="req"><see cref="RenewIntlDomainBatchRequest"/></param>
        /// <returns><see cref="RenewIntlDomainBatchResponse"/></returns>
        public RenewIntlDomainBatchResponse RenewIntlDomainBatchSync(RenewIntlDomainBatchRequest req)
        {
             JsonResponseModel<RenewIntlDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewIntlDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewIntlDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a verification code to a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="SendIntlPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendIntlPhoneEmailCodeResponse"/></returns>
        public async Task<SendIntlPhoneEmailCodeResponse> SendIntlPhoneEmailCode(SendIntlPhoneEmailCodeRequest req)
        {
             JsonResponseModel<SendIntlPhoneEmailCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendIntlPhoneEmailCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendIntlPhoneEmailCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a verification code to a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="SendIntlPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendIntlPhoneEmailCodeResponse"/></returns>
        public SendIntlPhoneEmailCodeResponse SendIntlPhoneEmailCodeSync(SendIntlPhoneEmailCodeRequest req)
        {
             JsonResponseModel<SendIntlPhoneEmailCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendIntlPhoneEmailCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendIntlPhoneEmailCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetIntlDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetIntlDomainAutoRenewResponse"/></returns>
        public async Task<SetIntlDomainAutoRenewResponse> SetIntlDomainAutoRenew(SetIntlDomainAutoRenewRequest req)
        {
             JsonResponseModel<SetIntlDomainAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetIntlDomainAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetIntlDomainAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetIntlDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetIntlDomainAutoRenewResponse"/></returns>
        public SetIntlDomainAutoRenewResponse SetIntlDomainAutoRenewSync(SetIntlDomainAutoRenewRequest req)
        {
             JsonResponseModel<SetIntlDomainAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetIntlDomainAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetIntlDomainAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk transfer domains in.
        /// </summary>
        /// <param name="req"><see cref="TransferInIntlDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInIntlDomainBatchResponse"/></returns>
        public async Task<TransferInIntlDomainBatchResponse> TransferInIntlDomainBatch(TransferInIntlDomainBatchRequest req)
        {
             JsonResponseModel<TransferInIntlDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferInIntlDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferInIntlDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk transfer domains in.
        /// </summary>
        /// <param name="req"><see cref="TransferInIntlDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInIntlDomainBatchResponse"/></returns>
        public TransferInIntlDomainBatchResponse TransferInIntlDomainBatchSync(TransferInIntlDomainBatchRequest req)
        {
             JsonResponseModel<TransferInIntlDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferInIntlDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferInIntlDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk set transfer prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionIntlBatchResponse"/></returns>
        public async Task<TransferProhibitionIntlBatchResponse> TransferProhibitionIntlBatch(TransferProhibitionIntlBatchRequest req)
        {
             JsonResponseModel<TransferProhibitionIntlBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferProhibitionIntlBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferProhibitionIntlBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk set transfer prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionIntlBatchResponse"/></returns>
        public TransferProhibitionIntlBatchResponse TransferProhibitionIntlBatchSync(TransferProhibitionIntlBatchRequest req)
        {
             JsonResponseModel<TransferProhibitionIntlBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferProhibitionIntlBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferProhibitionIntlBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk set update prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionIntlBatchResponse"/></returns>
        public async Task<UpdateProhibitionIntlBatchResponse> UpdateProhibitionIntlBatch(UpdateProhibitionIntlBatchRequest req)
        {
             JsonResponseModel<UpdateProhibitionIntlBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProhibitionIntlBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProhibitionIntlBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bulk set update prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionIntlBatchResponse"/></returns>
        public UpdateProhibitionIntlBatchResponse UpdateProhibitionIntlBatchSync(UpdateProhibitionIntlBatchRequest req)
        {
             JsonResponseModel<UpdateProhibitionIntlBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProhibitionIntlBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProhibitionIntlBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
