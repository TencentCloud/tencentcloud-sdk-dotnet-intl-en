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
       private const string sdkVersion = "SDK_NET_3.0.903";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DomainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bulk modify DNS servers for domains.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainDNSRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainDNSResponse"/></returns>
        public Task<BatchModifyIntlDomainDNSResponse> BatchModifyIntlDomainDNS(BatchModifyIntlDomainDNSRequest req)
        {
            return InternalRequestAsync<BatchModifyIntlDomainDNSResponse>(req, "BatchModifyIntlDomainDNS");
        }

        /// <summary>
        /// This API is used to bulk modify DNS servers for domains.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainDNSRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainDNSResponse"/></returns>
        public BatchModifyIntlDomainDNSResponse BatchModifyIntlDomainDNSSync(BatchModifyIntlDomainDNSRequest req)
        {
            return InternalRequestAsync<BatchModifyIntlDomainDNSResponse>(req, "BatchModifyIntlDomainDNS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk modify registrant information.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainInfoResponse"/></returns>
        public Task<BatchModifyIntlDomainInfoResponse> BatchModifyIntlDomainInfo(BatchModifyIntlDomainInfoRequest req)
        {
            return InternalRequestAsync<BatchModifyIntlDomainInfoResponse>(req, "BatchModifyIntlDomainInfo");
        }

        /// <summary>
        /// This API is used to bulk modify registrant information.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyIntlDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyIntlDomainInfoResponse"/></returns>
        public BatchModifyIntlDomainInfoResponse BatchModifyIntlDomainInfoSync(BatchModifyIntlDomainInfoRequest req)
        {
            return InternalRequestAsync<BatchModifyIntlDomainInfoResponse>(req, "BatchModifyIntlDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether a domain is available for registration.
        /// </summary>
        /// <param name="req"><see cref="CheckIntlDomainNewRequest"/></param>
        /// <returns><see cref="CheckIntlDomainNewResponse"/></returns>
        public Task<CheckIntlDomainNewResponse> CheckIntlDomainNew(CheckIntlDomainNewRequest req)
        {
            return InternalRequestAsync<CheckIntlDomainNewResponse>(req, "CheckIntlDomainNew");
        }

        /// <summary>
        /// This API is used to check whether a domain is available for registration.
        /// </summary>
        /// <param name="req"><see cref="CheckIntlDomainNewRequest"/></param>
        /// <returns><see cref="CheckIntlDomainNewResponse"/></returns>
        public CheckIntlDomainNewResponse CheckIntlDomainNewSync(CheckIntlDomainNewRequest req)
        {
            return InternalRequestAsync<CheckIntlDomainNewResponse>(req, "CheckIntlDomainNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk register domains.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlDomainBatchRequest"/></param>
        /// <returns><see cref="CreateIntlDomainBatchResponse"/></returns>
        public Task<CreateIntlDomainBatchResponse> CreateIntlDomainBatch(CreateIntlDomainBatchRequest req)
        {
            return InternalRequestAsync<CreateIntlDomainBatchResponse>(req, "CreateIntlDomainBatch");
        }

        /// <summary>
        /// This API is used to bulk register domains.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlDomainBatchRequest"/></param>
        /// <returns><see cref="CreateIntlDomainBatchResponse"/></returns>
        public CreateIntlDomainBatchResponse CreateIntlDomainBatchSync(CreateIntlDomainBatchRequest req)
        {
            return InternalRequestAsync<CreateIntlDomainBatchResponse>(req, "CreateIntlDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a mobile number or an email address via a verification code.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="CreateIntlPhoneEmailResponse"/></returns>
        public Task<CreateIntlPhoneEmailResponse> CreateIntlPhoneEmail(CreateIntlPhoneEmailRequest req)
        {
            return InternalRequestAsync<CreateIntlPhoneEmailResponse>(req, "CreateIntlPhoneEmail");
        }

        /// <summary>
        /// This API is used to verify a mobile number or an email address via a verification code.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="CreateIntlPhoneEmailResponse"/></returns>
        public CreateIntlPhoneEmailResponse CreateIntlPhoneEmailSync(CreateIntlPhoneEmailRequest req)
        {
            return InternalRequestAsync<CreateIntlPhoneEmailResponse>(req, "CreateIntlPhoneEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlTemplateRequest"/></param>
        /// <returns><see cref="CreateIntlTemplateResponse"/></returns>
        public Task<CreateIntlTemplateResponse> CreateIntlTemplate(CreateIntlTemplateRequest req)
        {
            return InternalRequestAsync<CreateIntlTemplateResponse>(req, "CreateIntlTemplate");
        }

        /// <summary>
        /// This API is used to add a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="CreateIntlTemplateRequest"/></param>
        /// <returns><see cref="CreateIntlTemplateResponse"/></returns>
        public CreateIntlTemplateResponse CreateIntlTemplateSync(CreateIntlTemplateRequest req)
        {
            return InternalRequestAsync<CreateIntlTemplateResponse>(req, "CreateIntlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="DeleteIntlPhoneEmailResponse"/></returns>
        public Task<DeleteIntlPhoneEmailResponse> DeleteIntlPhoneEmail(DeleteIntlPhoneEmailRequest req)
        {
            return InternalRequestAsync<DeleteIntlPhoneEmailResponse>(req, "DeleteIntlPhoneEmail");
        }

        /// <summary>
        /// This API is used to delete a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlPhoneEmailRequest"/></param>
        /// <returns><see cref="DeleteIntlPhoneEmailResponse"/></returns>
        public DeleteIntlPhoneEmailResponse DeleteIntlPhoneEmailSync(DeleteIntlPhoneEmailRequest req)
        {
            return InternalRequestAsync<DeleteIntlPhoneEmailResponse>(req, "DeleteIntlPhoneEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlTemplateRequest"/></param>
        /// <returns><see cref="DeleteIntlTemplateResponse"/></returns>
        public Task<DeleteIntlTemplateResponse> DeleteIntlTemplate(DeleteIntlTemplateRequest req)
        {
            return InternalRequestAsync<DeleteIntlTemplateResponse>(req, "DeleteIntlTemplate");
        }

        /// <summary>
        /// This API is used to delete a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DeleteIntlTemplateRequest"/></param>
        /// <returns><see cref="DeleteIntlTemplateResponse"/></returns>
        public DeleteIntlTemplateResponse DeleteIntlTemplateSync(DeleteIntlTemplateRequest req)
        {
            return InternalRequestAsync<DeleteIntlTemplateResponse>(req, "DeleteIntlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of a bulk task.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchDetailStatusRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchDetailStatusResponse"/></returns>
        public Task<DescribeIntlBatchDetailStatusResponse> DescribeIntlBatchDetailStatus(DescribeIntlBatchDetailStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntlBatchDetailStatusResponse>(req, "DescribeIntlBatchDetailStatus");
        }

        /// <summary>
        /// This API is used to query the status of a bulk task.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchDetailStatusRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchDetailStatusResponse"/></returns>
        public DescribeIntlBatchDetailStatusResponse DescribeIntlBatchDetailStatusSync(DescribeIntlBatchDetailStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntlBatchDetailStatusResponse>(req, "DescribeIntlBatchDetailStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the logs of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchOperationLogsResponse"/></returns>
        public Task<DescribeIntlBatchOperationLogsResponse> DescribeIntlBatchOperationLogs(DescribeIntlBatchOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeIntlBatchOperationLogsResponse>(req, "DescribeIntlBatchOperationLogs");
        }

        /// <summary>
        /// This API is used to query the logs of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeIntlBatchOperationLogsResponse"/></returns>
        public DescribeIntlBatchOperationLogsResponse DescribeIntlBatchOperationLogsSync(DescribeIntlBatchOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeIntlBatchOperationLogsResponse>(req, "DescribeIntlBatchOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query domain information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainResponse"/></returns>
        public Task<DescribeIntlDomainResponse> DescribeIntlDomain(DescribeIntlDomainRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainResponse>(req, "DescribeIntlDomain");
        }

        /// <summary>
        /// This API is used to query domain information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainResponse"/></returns>
        public DescribeIntlDomainResponse DescribeIntlDomainSync(DescribeIntlDomainRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainResponse>(req, "DescribeIntlDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the log details of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainBatchDetailsRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainBatchDetailsResponse"/></returns>
        public Task<DescribeIntlDomainBatchDetailsResponse> DescribeIntlDomainBatchDetails(DescribeIntlDomainBatchDetailsRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainBatchDetailsResponse>(req, "DescribeIntlDomainBatchDetails");
        }

        /// <summary>
        /// This API is used to get the log details of bulk domain purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainBatchDetailsRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainBatchDetailsResponse"/></returns>
        public DescribeIntlDomainBatchDetailsResponse DescribeIntlDomainBatchDetailsSync(DescribeIntlDomainBatchDetailsRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainBatchDetailsResponse>(req, "DescribeIntlDomainBatchDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the "My domains" list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainListResponse"/></returns>
        public Task<DescribeIntlDomainListResponse> DescribeIntlDomainList(DescribeIntlDomainListRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainListResponse>(req, "DescribeIntlDomainList");
        }

        /// <summary>
        /// This API is used to query the "My domains" list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainListResponse"/></returns>
        public DescribeIntlDomainListResponse DescribeIntlDomainListSync(DescribeIntlDomainListRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainListResponse>(req, "DescribeIntlDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the price list by domain suffix.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainPriceNewListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainPriceNewListResponse"/></returns>
        public Task<DescribeIntlDomainPriceNewListResponse> DescribeIntlDomainPriceNewList(DescribeIntlDomainPriceNewListRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainPriceNewListResponse>(req, "DescribeIntlDomainPriceNewList");
        }

        /// <summary>
        /// This API is used to get the price list by domain suffix.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlDomainPriceNewListRequest"/></param>
        /// <returns><see cref="DescribeIntlDomainPriceNewListResponse"/></returns>
        public DescribeIntlDomainPriceNewListResponse DescribeIntlDomainPriceNewListSync(DescribeIntlDomainPriceNewListRequest req)
        {
            return InternalRequestAsync<DescribeIntlDomainPriceNewListResponse>(req, "DescribeIntlDomainPriceNewList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of verified mobile numbers and email addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlPhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribeIntlPhoneEmailListResponse"/></returns>
        public Task<DescribeIntlPhoneEmailListResponse> DescribeIntlPhoneEmailList(DescribeIntlPhoneEmailListRequest req)
        {
            return InternalRequestAsync<DescribeIntlPhoneEmailListResponse>(req, "DescribeIntlPhoneEmailList");
        }

        /// <summary>
        /// This API is used to get the list of verified mobile numbers and email addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlPhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribeIntlPhoneEmailListResponse"/></returns>
        public DescribeIntlPhoneEmailListResponse DescribeIntlPhoneEmailListSync(DescribeIntlPhoneEmailListRequest req)
        {
            return InternalRequestAsync<DescribeIntlPhoneEmailListResponse>(req, "DescribeIntlPhoneEmailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateResponse"/></returns>
        public Task<DescribeIntlTemplateResponse> DescribeIntlTemplate(DescribeIntlTemplateRequest req)
        {
            return InternalRequestAsync<DescribeIntlTemplateResponse>(req, "DescribeIntlTemplate");
        }

        /// <summary>
        /// This API is used to get the details of a registrant profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateResponse"/></returns>
        public DescribeIntlTemplateResponse DescribeIntlTemplateSync(DescribeIntlTemplateRequest req)
        {
            return InternalRequestAsync<DescribeIntlTemplateResponse>(req, "DescribeIntlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of registrant profiles.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateListRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateListResponse"/></returns>
        public Task<DescribeIntlTemplateListResponse> DescribeIntlTemplateList(DescribeIntlTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeIntlTemplateListResponse>(req, "DescribeIntlTemplateList");
        }

        /// <summary>
        /// This API is used to get the list of registrant profiles.
        /// </summary>
        /// <param name="req"><see cref="DescribeIntlTemplateListRequest"/></param>
        /// <returns><see cref="DescribeIntlTemplateListResponse"/></returns>
        public DescribeIntlTemplateListResponse DescribeIntlTemplateListSync(DescribeIntlTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeIntlTemplateListResponse>(req, "DescribeIntlTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk transfer domains to another account.
        /// </summary>
        /// <param name="req"><see cref="ModifyOwnerIntlBatchRequest"/></param>
        /// <returns><see cref="ModifyOwnerIntlBatchResponse"/></returns>
        public Task<ModifyOwnerIntlBatchResponse> ModifyOwnerIntlBatch(ModifyOwnerIntlBatchRequest req)
        {
            return InternalRequestAsync<ModifyOwnerIntlBatchResponse>(req, "ModifyOwnerIntlBatch");
        }

        /// <summary>
        /// This API is used to bulk transfer domains to another account.
        /// </summary>
        /// <param name="req"><see cref="ModifyOwnerIntlBatchRequest"/></param>
        /// <returns><see cref="ModifyOwnerIntlBatchResponse"/></returns>
        public ModifyOwnerIntlBatchResponse ModifyOwnerIntlBatchSync(ModifyOwnerIntlBatchRequest req)
        {
            return InternalRequestAsync<ModifyOwnerIntlBatchResponse>(req, "ModifyOwnerIntlBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk renew domains.
        /// </summary>
        /// <param name="req"><see cref="RenewIntlDomainBatchRequest"/></param>
        /// <returns><see cref="RenewIntlDomainBatchResponse"/></returns>
        public Task<RenewIntlDomainBatchResponse> RenewIntlDomainBatch(RenewIntlDomainBatchRequest req)
        {
            return InternalRequestAsync<RenewIntlDomainBatchResponse>(req, "RenewIntlDomainBatch");
        }

        /// <summary>
        /// This API is used to bulk renew domains.
        /// </summary>
        /// <param name="req"><see cref="RenewIntlDomainBatchRequest"/></param>
        /// <returns><see cref="RenewIntlDomainBatchResponse"/></returns>
        public RenewIntlDomainBatchResponse RenewIntlDomainBatchSync(RenewIntlDomainBatchRequest req)
        {
            return InternalRequestAsync<RenewIntlDomainBatchResponse>(req, "RenewIntlDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a verification code to a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="SendIntlPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendIntlPhoneEmailCodeResponse"/></returns>
        public Task<SendIntlPhoneEmailCodeResponse> SendIntlPhoneEmailCode(SendIntlPhoneEmailCodeRequest req)
        {
            return InternalRequestAsync<SendIntlPhoneEmailCodeResponse>(req, "SendIntlPhoneEmailCode");
        }

        /// <summary>
        /// This API is used to send a verification code to a mobile number or an email address.
        /// </summary>
        /// <param name="req"><see cref="SendIntlPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendIntlPhoneEmailCodeResponse"/></returns>
        public SendIntlPhoneEmailCodeResponse SendIntlPhoneEmailCodeSync(SendIntlPhoneEmailCodeRequest req)
        {
            return InternalRequestAsync<SendIntlPhoneEmailCodeResponse>(req, "SendIntlPhoneEmailCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetIntlDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetIntlDomainAutoRenewResponse"/></returns>
        public Task<SetIntlDomainAutoRenewResponse> SetIntlDomainAutoRenew(SetIntlDomainAutoRenewRequest req)
        {
            return InternalRequestAsync<SetIntlDomainAutoRenewResponse>(req, "SetIntlDomainAutoRenew");
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetIntlDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetIntlDomainAutoRenewResponse"/></returns>
        public SetIntlDomainAutoRenewResponse SetIntlDomainAutoRenewSync(SetIntlDomainAutoRenewRequest req)
        {
            return InternalRequestAsync<SetIntlDomainAutoRenewResponse>(req, "SetIntlDomainAutoRenew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk transfer domains in.
        /// </summary>
        /// <param name="req"><see cref="TransferInIntlDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInIntlDomainBatchResponse"/></returns>
        public Task<TransferInIntlDomainBatchResponse> TransferInIntlDomainBatch(TransferInIntlDomainBatchRequest req)
        {
            return InternalRequestAsync<TransferInIntlDomainBatchResponse>(req, "TransferInIntlDomainBatch");
        }

        /// <summary>
        /// This API is used to bulk transfer domains in.
        /// </summary>
        /// <param name="req"><see cref="TransferInIntlDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInIntlDomainBatchResponse"/></returns>
        public TransferInIntlDomainBatchResponse TransferInIntlDomainBatchSync(TransferInIntlDomainBatchRequest req)
        {
            return InternalRequestAsync<TransferInIntlDomainBatchResponse>(req, "TransferInIntlDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk set transfer prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionIntlBatchResponse"/></returns>
        public Task<TransferProhibitionIntlBatchResponse> TransferProhibitionIntlBatch(TransferProhibitionIntlBatchRequest req)
        {
            return InternalRequestAsync<TransferProhibitionIntlBatchResponse>(req, "TransferProhibitionIntlBatch");
        }

        /// <summary>
        /// This API is used to bulk set transfer prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionIntlBatchResponse"/></returns>
        public TransferProhibitionIntlBatchResponse TransferProhibitionIntlBatchSync(TransferProhibitionIntlBatchRequest req)
        {
            return InternalRequestAsync<TransferProhibitionIntlBatchResponse>(req, "TransferProhibitionIntlBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bulk set update prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionIntlBatchResponse"/></returns>
        public Task<UpdateProhibitionIntlBatchResponse> UpdateProhibitionIntlBatch(UpdateProhibitionIntlBatchRequest req)
        {
            return InternalRequestAsync<UpdateProhibitionIntlBatchResponse>(req, "UpdateProhibitionIntlBatch");
        }

        /// <summary>
        /// This API is used to bulk set update prohibition for domains.
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionIntlBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionIntlBatchResponse"/></returns>
        public UpdateProhibitionIntlBatchResponse UpdateProhibitionIntlBatchSync(UpdateProhibitionIntlBatchRequest req)
        {
            return InternalRequestAsync<UpdateProhibitionIntlBatchResponse>(req, "UpdateProhibitionIntlBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
