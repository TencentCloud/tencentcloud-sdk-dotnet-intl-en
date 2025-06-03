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

namespace TencentCloud.Intlpartnersmgt.V20220928
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Intlpartnersmgt.V20220928.Models;

   public class IntlpartnersmgtClient : AbstractClient{

       private const string endpoint = "intlpartnersmgt.intl.tencentcloudapi.com";
       private const string version = "2022-09-28";
       private const string sdkVersion = "SDK_NET_3.0.1143";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IntlpartnersmgtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IntlpartnersmgtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to allocate credit pools to second-level resellers by distributors.
        /// Callable roles: Distributor
        /// </summary>
        /// <param name="req"><see cref="AllocateCreditPoolRequest"/></param>
        /// <returns><see cref="AllocateCreditPoolResponse"/></returns>
        public Task<AllocateCreditPoolResponse> AllocateCreditPool(AllocateCreditPoolRequest req)
        {
            return InternalRequestAsync<AllocateCreditPoolResponse>(req, "AllocateCreditPool");
        }

        /// <summary>
        /// This API is used to allocate credit pools to second-level resellers by distributors.
        /// Callable roles: Distributor
        /// </summary>
        /// <param name="req"><see cref="AllocateCreditPoolRequest"/></param>
        /// <returns><see cref="AllocateCreditPoolResponse"/></returns>
        public AllocateCreditPoolResponse AllocateCreditPoolSync(AllocateCreditPoolRequest req)
        {
            return InternalRequestAsync<AllocateCreditPoolResponse>(req, "AllocateCreditPool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for a partner to set credit for a customer, such as increasing or lowering the credit and setting it to 0.
        /// 1. The credit is valid permanently and will not be zeroed regularly.
        /// 2. The customer's service will be suspended when its available credit is set to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increment of the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates that it will be repossessed. The available credit can be set to 0 at the minimum.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public Task<AllocateCustomerCreditResponse> AllocateCustomerCredit(AllocateCustomerCreditRequest req)
        {
            return InternalRequestAsync<AllocateCustomerCreditResponse>(req, "AllocateCustomerCredit");
        }

        /// <summary>
        /// This API is used for a partner to set credit for a customer, such as increasing or lowering the credit and setting it to 0.
        /// 1. The credit is valid permanently and will not be zeroed regularly.
        /// 2. The customer's service will be suspended when its available credit is set to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increment of the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates that it will be repossessed. The available credit can be set to 0 at the minimum.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public AllocateCustomerCreditResponse AllocateCustomerCreditSync(AllocateCustomerCreditRequest req)
        {
            return InternalRequestAsync<AllocateCustomerCreditResponse>(req, "AllocateCustomerCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: This API is used by resellers to review applications to become sub-customers. Note: This API is used to apply for the allowlist. If needed, please contact your business representative.
        /// 
        /// Callable roles: Reseller, Distributer, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="ApproveClientApplyRequest"/></param>
        /// <returns><see cref="ApproveClientApplyResponse"/></returns>
        public Task<ApproveClientApplyResponse> ApproveClientApply(ApproveClientApplyRequest req)
        {
            return InternalRequestAsync<ApproveClientApplyResponse>(req, "ApproveClientApply");
        }

        /// <summary>
        /// Description: This API is used by resellers to review applications to become sub-customers. Note: This API is used to apply for the allowlist. If needed, please contact your business representative.
        /// 
        /// Callable roles: Reseller, Distributer, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="ApproveClientApplyRequest"/></param>
        /// <returns><see cref="ApproveClientApplyResponse"/></returns>
        public ApproveClientApplyResponse ApproveClientApplySync(ApproveClientApplyRequest req)
        {
            return InternalRequestAsync<ApproveClientApplyResponse>(req, "ApproveClientApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to approve applications for second-level resellers.
        /// Invocation Role: Distributor.
        /// </summary>
        /// <param name="req"><see cref="ApproveSubAgentApplyRequest"/></param>
        /// <returns><see cref="ApproveSubAgentApplyResponse"/></returns>
        public Task<ApproveSubAgentApplyResponse> ApproveSubAgentApply(ApproveSubAgentApplyRequest req)
        {
            return InternalRequestAsync<ApproveSubAgentApplyResponse>(req, "ApproveSubAgentApply");
        }

        /// <summary>
        /// This API is used to approve applications for second-level resellers.
        /// Invocation Role: Distributor.
        /// </summary>
        /// <param name="req"><see cref="ApproveSubAgentApplyRequest"/></param>
        /// <returns><see cref="ApproveSubAgentApplyResponse"/></returns>
        public ApproveSubAgentApplyResponse ApproveSubAgentApplySync(ApproveSubAgentApplyRequest req)
        {
            return InternalRequestAsync<ApproveSubAgentApplyResponse>(req, "ApproveSubAgentApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Tencent Cloud customer accounts for distributor/second-level resellers.After the account is created, it will be automatically bound to the partner account.Note:
        /// 1. Create a Tencent Cloud account. The entered email address and mobile phone number need to be verified by the partner for validity.
        /// 2. Customers need to add personal information when logging in for the first time.
        /// 3. This interface needs to be applied for allowlist usage. Please contact the channel manager to initiate the application process.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// This API is used to create Tencent Cloud customer accounts for distributor/second-level resellers.After the account is created, it will be automatically bound to the partner account.Note:
        /// 1. Create a Tencent Cloud account. The entered email address and mobile phone number need to be verified by the partner for validity.
        /// 2. Customers need to add personal information when logging in for the first time.
        /// 3. This interface needs to be applied for allowlist usage. Please contact the channel manager to initiate the application process.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform operations. Application for allowlist is required before usage. If needed, contact your business representative to request allowlisting. The specific usage process is as follows;.
        /// This API is used to create an invitation link. You can send the invitation link to your designated email address.
        /// 2. Customers need to click the invitation link in the mailbox, fill in and submit relevant information.
        /// 3. After customer submission, you can view the application of this sub-customer on the customer management page and review it.
        /// 
        /// This API is used to handle cases where if the designated mailbox does not receive the invitation link, you can send the invitation link returned by the API to the customer manually.
        /// Invocation roles: resellers, distributors, second-level reseller.
        /// </summary>
        /// <param name="req"><see cref="CreateAndSendClientInvitationMailRequest"/></param>
        /// <returns><see cref="CreateAndSendClientInvitationMailResponse"/></returns>
        public Task<CreateAndSendClientInvitationMailResponse> CreateAndSendClientInvitationMail(CreateAndSendClientInvitationMailRequest req)
        {
            return InternalRequestAsync<CreateAndSendClientInvitationMailResponse>(req, "CreateAndSendClientInvitationMail");
        }

        /// <summary>
        /// This API is used to perform operations. Application for allowlist is required before usage. If needed, contact your business representative to request allowlisting. The specific usage process is as follows;.
        /// This API is used to create an invitation link. You can send the invitation link to your designated email address.
        /// 2. Customers need to click the invitation link in the mailbox, fill in and submit relevant information.
        /// 3. After customer submission, you can view the application of this sub-customer on the customer management page and review it.
        /// 
        /// This API is used to handle cases where if the designated mailbox does not receive the invitation link, you can send the invitation link returned by the API to the customer manually.
        /// Invocation roles: resellers, distributors, second-level reseller.
        /// </summary>
        /// <param name="req"><see cref="CreateAndSendClientInvitationMailRequest"/></param>
        /// <returns><see cref="CreateAndSendClientInvitationMailResponse"/></returns>
        public CreateAndSendClientInvitationMailResponse CreateAndSendClientInvitationMailSync(CreateAndSendClientInvitationMailRequest req)
        {
            return InternalRequestAsync<CreateAndSendClientInvitationMailResponse>(req, "CreateAndSendClientInvitationMail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: End-customer queries its own bill details.
        /// Callable role: End-customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public Task<DescribeBillDetailResponse> DescribeBillDetail(DescribeBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailResponse>(req, "DescribeBillDetail");
        }

        /// <summary>
        /// Description: End-customer queries its own bill details.
        /// Callable role: End-customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public DescribeBillDetailResponse DescribeBillDetailSync(DescribeBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailResponse>(req, "DescribeBillDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: This API is used to download billing files and return billing file URLs for sub-customers.
        /// Callable role: Enb-customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public Task<DescribeBillDownloadUrlResponse> DescribeBillDownloadUrl(DescribeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBillDownloadUrlResponse>(req, "DescribeBillDownloadUrl");
        }

        /// <summary>
        /// Description: This API is used to download billing files and return billing file URLs for sub-customers.
        /// Callable role: Enb-customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public DescribeBillDownloadUrlResponse DescribeBillDownloadUrlSync(DescribeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBillDownloadUrlResponse>(req, "DescribeBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: External API for L1 billing of Sub-customer billing center.
        /// Callable role: End-customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public Task<DescribeBillSummaryResponse> DescribeBillSummary(DescribeBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryResponse>(req, "DescribeBillSummary");
        }

        /// <summary>
        /// Description: External API for L1 billing of Sub-customer billing center.
        /// Callable role: End-customer.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public DescribeBillSummaryResponse DescribeBillSummarySync(DescribeBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryResponse>(req, "DescribeBillSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the total amount of customer bills by payment mode.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public Task<DescribeBillSummaryByPayModeResponse> DescribeBillSummaryByPayMode(DescribeBillSummaryByPayModeRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByPayModeResponse>(req, "DescribeBillSummaryByPayMode");
        }

        /// <summary>
        /// This API is used to obtain the total amount of customer bills by payment mode.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public DescribeBillSummaryByPayModeResponse DescribeBillSummaryByPayModeSync(DescribeBillSummaryByPayModeRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByPayModeResponse>(req, "DescribeBillSummaryByPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: Obtain the summarized value of sub - account bills by product dimension.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public Task<DescribeBillSummaryByProductResponse> DescribeBillSummaryByProduct(DescribeBillSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProductResponse>(req, "DescribeBillSummaryByProduct");
        }

        /// <summary>
        /// Description: Obtain the summarized value of sub - account bills by product dimension.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public DescribeBillSummaryByProductResponse DescribeBillSummaryByProductSync(DescribeBillSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProductResponse>(req, "DescribeBillSummaryByProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: Obtain the summarized value of sub - account bills by region through API.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public Task<DescribeBillSummaryByRegionResponse> DescribeBillSummaryByRegion(DescribeBillSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByRegionResponse>(req, "DescribeBillSummaryByRegion");
        }

        /// <summary>
        /// Description: Obtain the summarized value of sub - account bills by region through API.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public DescribeBillSummaryByRegionResponse DescribeBillSummaryByRegionSync(DescribeBillSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByRegionResponse>(req, "DescribeBillSummaryByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the customer bill details by resellers.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillDetailResponse"/></returns>
        public Task<DescribeCustomerBillDetailResponse> DescribeCustomerBillDetail(DescribeCustomerBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeCustomerBillDetailResponse>(req, "DescribeCustomerBillDetail");
        }

        /// <summary>
        /// This API is used to query the customer bill details by resellers.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillDetailResponse"/></returns>
        public DescribeCustomerBillDetailResponse DescribeCustomerBillDetailSync(DescribeCustomerBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeCustomerBillDetailResponse>(req, "DescribeCustomerBillDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the URL for downloading the customer bill file by reseller. The download conditions are as follows:
        /// 1. Detailed bills (billDetail and billDetailPack) can be downloaded starting from June 2022; resource bills (billResource and billResourcePack) can be downloaded starting from November 2023.
        /// 2. Bill packages (billDetailPack and billResourcePack) can only be downloaded after billing.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillDownloadUrlResponse"/></returns>
        public Task<DescribeCustomerBillDownloadUrlResponse> DescribeCustomerBillDownloadUrl(DescribeCustomerBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeCustomerBillDownloadUrlResponse>(req, "DescribeCustomerBillDownloadUrl");
        }

        /// <summary>
        /// This API is used to get the URL for downloading the customer bill file by reseller. The download conditions are as follows:
        /// 1. Detailed bills (billDetail and billDetailPack) can be downloaded starting from June 2022; resource bills (billResource and billResourcePack) can be downloaded starting from November 2023.
        /// 2. Bill packages (billDetailPack and billResourcePack) can only be downloaded after billing.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillDownloadUrlResponse"/></returns>
        public DescribeCustomerBillDownloadUrlResponse DescribeCustomerBillDownloadUrlSync(DescribeCustomerBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeCustomerBillDownloadUrlResponse>(req, "DescribeCustomerBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the total amount of customer bills.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillSummaryResponse"/></returns>
        public Task<DescribeCustomerBillSummaryResponse> DescribeCustomerBillSummary(DescribeCustomerBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCustomerBillSummaryResponse>(req, "DescribeCustomerBillSummary");
        }

        /// <summary>
        /// This API is used to query the total amount of customer bills.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillSummaryResponse"/></returns>
        public DescribeCustomerBillSummaryResponse DescribeCustomerBillSummarySync(DescribeCustomerBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCustomerBillSummaryResponse>(req, "DescribeCustomerBillSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sub-customer information.
        /// Invocation roles: reseller, first-level distributor.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerInfoRequest"/></param>
        /// <returns><see cref="DescribeCustomerInfoResponse"/></returns>
        public Task<DescribeCustomerInfoResponse> DescribeCustomerInfo(DescribeCustomerInfoRequest req)
        {
            return InternalRequestAsync<DescribeCustomerInfoResponse>(req, "DescribeCustomerInfo");
        }

        /// <summary>
        /// This API is used to query sub-customer information.
        /// Invocation roles: reseller, first-level distributor.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerInfoRequest"/></param>
        /// <returns><see cref="DescribeCustomerInfoResponse"/></returns>
        public DescribeCustomerInfoResponse DescribeCustomerInfoSync(DescribeCustomerInfoRequest req)
        {
            return InternalRequestAsync<DescribeCustomerInfoResponse>(req, "DescribeCustomerInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of customer UINs.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerUinRequest"/></param>
        /// <returns><see cref="DescribeCustomerUinResponse"/></returns>
        public Task<DescribeCustomerUinResponse> DescribeCustomerUin(DescribeCustomerUinRequest req)
        {
            return InternalRequestAsync<DescribeCustomerUinResponse>(req, "DescribeCustomerUin");
        }

        /// <summary>
        /// This API is used to query the list of customer UINs.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerUinRequest"/></param>
        /// <returns><see cref="DescribeCustomerUinResponse"/></returns>
        public DescribeCustomerUinResponse DescribeCustomerUinSync(DescribeCustomerUinRequest req)
        {
            return InternalRequestAsync<DescribeCustomerUinResponse>(req, "DescribeCustomerUin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download the commission bill file by resellers/agents. The file URL is returned.
        /// Resellers/Agents can call this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeRebateDownloadUrlResponse"/></returns>
        public Task<DescribeRebateDownloadUrlResponse> DescribeRebateDownloadUrl(DescribeRebateDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeRebateDownloadUrlResponse>(req, "DescribeRebateDownloadUrl");
        }

        /// <summary>
        /// This API is used to download the commission bill file by resellers/agents. The file URL is returned.
        /// Resellers/Agents can call this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeRebateDownloadUrlResponse"/></returns>
        public DescribeRebateDownloadUrlResponse DescribeRebateDownloadUrlSync(DescribeRebateDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeRebateDownloadUrlResponse>(req, "DescribeRebateDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Forced Service Suspension settings and cancellation can be used only after the reseller is whitelisted.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="ForceQNRequest"/></param>
        /// <returns><see cref="ForceQNResponse"/></returns>
        public Task<ForceQNResponse> ForceQN(ForceQNRequest req)
        {
            return InternalRequestAsync<ForceQNResponse>(req, "ForceQN");
        }

        /// <summary>
        /// Forced Service Suspension settings and cancellation can be used only after the reseller is whitelisted.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="ForceQNRequest"/></param>
        /// <returns><see cref="ForceQNResponse"/></returns>
        public ForceQNResponse ForceQNSync(ForceQNRequest req)
        {
            return InternalRequestAsync<ForceQNResponse>(req, "ForceQN")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain country/region codes.
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public Task<GetCountryCodesResponse> GetCountryCodes(GetCountryCodesRequest req)
        {
            return InternalRequestAsync<GetCountryCodesResponse>(req, "GetCountryCodes");
        }

        /// <summary>
        /// This API is used to obtain country/region codes.
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public GetCountryCodesResponse GetCountryCodesSync(GetCountryCodesRequest req)
        {
            return InternalRequestAsync<GetCountryCodesResponse>(req, "GetCountryCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query industry information, including layer-1 industry and layer-2 industry.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller,End-customer
        /// </summary>
        /// <param name="req"><see cref="GetTradeConfigListRequest"/></param>
        /// <returns><see cref="GetTradeConfigListResponse"/></returns>
        public Task<GetTradeConfigListResponse> GetTradeConfigList(GetTradeConfigListRequest req)
        {
            return InternalRequestAsync<GetTradeConfigListResponse>(req, "GetTradeConfigList");
        }

        /// <summary>
        /// This API is used to query industry information, including layer-1 industry and layer-2 industry.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller,End-customer
        /// </summary>
        /// <param name="req"><see cref="GetTradeConfigListRequest"/></param>
        /// <returns><see cref="GetTradeConfigListResponse"/></returns>
        public GetTradeConfigListResponse GetTradeConfigListSync(GetTradeConfigListRequest req)
        {
            return InternalRequestAsync<GetTradeConfigListResponse>(req, "GetTradeConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify customer remarks.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRemarkRequest"/></param>
        /// <returns><see cref="ModifyClientRemarkResponse"/></returns>
        public Task<ModifyClientRemarkResponse> ModifyClientRemark(ModifyClientRemarkRequest req)
        {
            return InternalRequestAsync<ModifyClientRemarkResponse>(req, "ModifyClientRemark");
        }

        /// <summary>
        /// This API is used to modify customer remarks.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRemarkRequest"/></param>
        /// <returns><see cref="ModifyClientRemarkResponse"/></returns>
        public ModifyClientRemarkResponse ModifyClientRemarkSync(ModifyClientRemarkRequest req)
        {
            return InternalRequestAsync<ModifyClientRemarkResponse>(req, "ModifyClientRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the account verification status.
        /// Callable roles: Distributor, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryAccountVerificationStatusRequest"/></param>
        /// <returns><see cref="QueryAccountVerificationStatusResponse"/></returns>
        public Task<QueryAccountVerificationStatusResponse> QueryAccountVerificationStatus(QueryAccountVerificationStatusRequest req)
        {
            return InternalRequestAsync<QueryAccountVerificationStatusResponse>(req, "QueryAccountVerificationStatus");
        }

        /// <summary>
        /// This API is used to query the account verification status.
        /// Callable roles: Distributor, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryAccountVerificationStatusRequest"/></param>
        /// <returns><see cref="QueryAccountVerificationStatusResponse"/></returns>
        public QueryAccountVerificationStatusResponse QueryAccountVerificationStatusSync(QueryAccountVerificationStatusRequest req)
        {
            return InternalRequestAsync<QueryAccountVerificationStatusResponse>(req, "QueryAccountVerificationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all the credit allocation records of a single customer.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public Task<QueryCreditAllocationHistoryResponse> QueryCreditAllocationHistory(QueryCreditAllocationHistoryRequest req)
        {
            return InternalRequestAsync<QueryCreditAllocationHistoryResponse>(req, "QueryCreditAllocationHistory");
        }

        /// <summary>
        /// This API is used to query all the credit allocation records of a single customer.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public QueryCreditAllocationHistoryResponse QueryCreditAllocationHistorySync(QueryCreditAllocationHistoryRequest req)
        {
            return InternalRequestAsync<QueryCreditAllocationHistoryResponse>(req, "QueryCreditAllocationHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the credit of users in the list.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryCreditByUinListRequest"/></param>
        /// <returns><see cref="QueryCreditByUinListResponse"/></returns>
        public Task<QueryCreditByUinListResponse> QueryCreditByUinList(QueryCreditByUinListRequest req)
        {
            return InternalRequestAsync<QueryCreditByUinListResponse>(req, "QueryCreditByUinList");
        }

        /// <summary>
        /// This API is used to query the credit of users in the list.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryCreditByUinListRequest"/></param>
        /// <returns><see cref="QueryCreditByUinListResponse"/></returns>
        public QueryCreditByUinListResponse QueryCreditByUinListSync(QueryCreditByUinListRequest req)
        {
            return InternalRequestAsync<QueryCreditByUinListResponse>(req, "QueryCreditByUinList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: This API is used for a sub-customer to real-time query its own total credit and remaining credit in USD.
        /// 
        /// Callable roles: Sub-customer
        /// </summary>
        /// <param name="req"><see cref="QueryCustomerBillingQuotaRequest"/></param>
        /// <returns><see cref="QueryCustomerBillingQuotaResponse"/></returns>
        public Task<QueryCustomerBillingQuotaResponse> QueryCustomerBillingQuota(QueryCustomerBillingQuotaRequest req)
        {
            return InternalRequestAsync<QueryCustomerBillingQuotaResponse>(req, "QueryCustomerBillingQuota");
        }

        /// <summary>
        /// Description: This API is used for a sub-customer to real-time query its own total credit and remaining credit in USD.
        /// 
        /// Callable roles: Sub-customer
        /// </summary>
        /// <param name="req"><see cref="QueryCustomerBillingQuotaRequest"/></param>
        /// <returns><see cref="QueryCustomerBillingQuotaResponse"/></returns>
        public QueryCustomerBillingQuotaResponse QueryCustomerBillingQuotaSync(QueryCustomerBillingQuotaRequest req)
        {
            return InternalRequestAsync<QueryCustomerBillingQuotaResponse>(req, "QueryCustomerBillingQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for a partner to the credits and basic information of cutomers.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public Task<QueryCustomersCreditResponse> QueryCustomersCredit(QueryCustomersCreditRequest req)
        {
            return InternalRequestAsync<QueryCustomersCreditResponse>(req, "QueryCustomersCredit");
        }

        /// <summary>
        /// This API is used for a partner to the credits and basic information of cutomers.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public QueryCustomersCreditResponse QueryCustomersCreditSync(QueryCustomersCreditRequest req)
        {
            return InternalRequestAsync<QueryCustomersCreditResponse>(req, "QueryCustomersCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the credits of direct customers.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryDirectCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryDirectCustomersCreditResponse"/></returns>
        public Task<QueryDirectCustomersCreditResponse> QueryDirectCustomersCredit(QueryDirectCustomersCreditRequest req)
        {
            return InternalRequestAsync<QueryDirectCustomersCreditResponse>(req, "QueryDirectCustomersCredit");
        }

        /// <summary>
        /// This API is used to query the credits of direct customers.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryDirectCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryDirectCustomersCreditResponse"/></returns>
        public QueryDirectCustomersCreditResponse QueryDirectCustomersCreditSync(QueryDirectCustomersCreditRequest req)
        {
            return InternalRequestAsync<QueryDirectCustomersCreditResponse>(req, "QueryDirectCustomersCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query usage information of invitation link. Once created, the data will only be retained for 60 days, and the system will automatically delete the invitation link after 60 days.
        /// Invokable role types: Distributor, Second-level reseller, Reseller.
        /// </summary>
        /// <param name="req"><see cref="QueryInvitationInfoRequest"/></param>
        /// <returns><see cref="QueryInvitationInfoResponse"/></returns>
        public Task<QueryInvitationInfoResponse> QueryInvitationInfo(QueryInvitationInfoRequest req)
        {
            return InternalRequestAsync<QueryInvitationInfoResponse>(req, "QueryInvitationInfo");
        }

        /// <summary>
        /// Query usage information of invitation link. Once created, the data will only be retained for 60 days, and the system will automatically delete the invitation link after 60 days.
        /// Invokable role types: Distributor, Second-level reseller, Reseller.
        /// </summary>
        /// <param name="req"><see cref="QueryInvitationInfoRequest"/></param>
        /// <returns><see cref="QueryInvitationInfoResponse"/></returns>
        public QueryInvitationInfoResponse QueryInvitationInfoSync(QueryInvitationInfoRequest req)
        {
            return InternalRequestAsync<QueryInvitationInfoResponse>(req, "QueryInvitationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public Task<QueryPartnerCreditResponse> QueryPartnerCredit(QueryPartnerCreditRequest req)
        {
            return InternalRequestAsync<QueryPartnerCreditResponse>(req, "QueryPartnerCredit");
        }

        /// <summary>
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public QueryPartnerCreditResponse QueryPartnerCreditSync(QueryPartnerCreditRequest req)
        {
            return InternalRequestAsync<QueryPartnerCreditResponse>(req, "QueryPartnerCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Description: This API is used by resellers to query the list of sub-customers pending review. Note: This API is used to apply for the allowlist. If needed, please contact your business representative.
        /// 
        /// Callable roles: Reseller, Distributer, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryPendingClientsV2Request"/></param>
        /// <returns><see cref="QueryPendingClientsV2Response"/></returns>
        public Task<QueryPendingClientsV2Response> QueryPendingClientsV2(QueryPendingClientsV2Request req)
        {
            return InternalRequestAsync<QueryPendingClientsV2Response>(req, "QueryPendingClientsV2");
        }

        /// <summary>
        /// Description: This API is used by resellers to query the list of sub-customers pending review. Note: This API is used to apply for the allowlist. If needed, please contact your business representative.
        /// 
        /// Callable roles: Reseller, Distributer, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryPendingClientsV2Request"/></param>
        /// <returns><see cref="QueryPendingClientsV2Response"/></returns>
        public QueryPendingClientsV2Response QueryPendingClientsV2Sync(QueryPendingClientsV2Request req)
        {
            return InternalRequestAsync<QueryPendingClientsV2Response>(req, "QueryPendingClientsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information of second-level resellers in application.
        /// Invocation Role: Distributor.
        /// </summary>
        /// <param name="req"><see cref="QueryPendingSubAgentsV2Request"/></param>
        /// <returns><see cref="QueryPendingSubAgentsV2Response"/></returns>
        public Task<QueryPendingSubAgentsV2Response> QueryPendingSubAgentsV2(QueryPendingSubAgentsV2Request req)
        {
            return InternalRequestAsync<QueryPendingSubAgentsV2Response>(req, "QueryPendingSubAgentsV2");
        }

        /// <summary>
        /// This API is used to query information of second-level resellers in application.
        /// Invocation Role: Distributor.
        /// </summary>
        /// <param name="req"><see cref="QueryPendingSubAgentsV2Request"/></param>
        /// <returns><see cref="QueryPendingSubAgentsV2Response"/></returns>
        public QueryPendingSubAgentsV2Response QueryPendingSubAgentsV2Sync(QueryPendingSubAgentsV2Request req)
        {
            return InternalRequestAsync<QueryPendingSubAgentsV2Response>(req, "QueryPendingSubAgentsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the product list information within the specified policy range. To call this API, contact your business manager to apply for adding it to the allowlist.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryPolicyProductListByCodeRequest"/></param>
        /// <returns><see cref="QueryPolicyProductListByCodeResponse"/></returns>
        public Task<QueryPolicyProductListByCodeResponse> QueryPolicyProductListByCode(QueryPolicyProductListByCodeRequest req)
        {
            return InternalRequestAsync<QueryPolicyProductListByCodeResponse>(req, "QueryPolicyProductListByCode");
        }

        /// <summary>
        /// This API is used to query the product list information within the specified policy range. To call this API, contact your business manager to apply for adding it to the allowlist.
        /// Callable roles: Distributor, Second-level reseller, Reseller
        /// </summary>
        /// <param name="req"><see cref="QueryPolicyProductListByCodeRequest"/></param>
        /// <returns><see cref="QueryPolicyProductListByCodeResponse"/></returns>
        public QueryPolicyProductListByCodeResponse QueryPolicyProductListByCodeSync(QueryPolicyProductListByCodeRequest req)
        {
            return InternalRequestAsync<QueryPolicyProductListByCodeResponse>(req, "QueryPolicyProductListByCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information of second-level resellers.
        /// Invocation Role:Distributor.
        /// </summary>
        /// <param name="req"><see cref="QuerySubAgentsDetailV2Request"/></param>
        /// <returns><see cref="QuerySubAgentsDetailV2Response"/></returns>
        public Task<QuerySubAgentsDetailV2Response> QuerySubAgentsDetailV2(QuerySubAgentsDetailV2Request req)
        {
            return InternalRequestAsync<QuerySubAgentsDetailV2Response>(req, "QuerySubAgentsDetailV2");
        }

        /// <summary>
        /// This API is used to query information of second-level resellers.
        /// Invocation Role:Distributor.
        /// </summary>
        /// <param name="req"><see cref="QuerySubAgentsDetailV2Request"/></param>
        /// <returns><see cref="QuerySubAgentsDetailV2Response"/></returns>
        public QuerySubAgentsDetailV2Response QuerySubAgentsDetailV2Sync(QuerySubAgentsDetailV2Request req)
        {
            return InternalRequestAsync<QuerySubAgentsDetailV2Response>(req, "QuerySubAgentsDetailV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the indirect sub-customers of a distributor.
        /// Invokable role type: Distributor
        /// </summary>
        /// <param name="req"><see cref="QueryT1IndirectCustomersDetailRequest"/></param>
        /// <returns><see cref="QueryT1IndirectCustomersDetailResponse"/></returns>
        public Task<QueryT1IndirectCustomersDetailResponse> QueryT1IndirectCustomersDetail(QueryT1IndirectCustomersDetailRequest req)
        {
            return InternalRequestAsync<QueryT1IndirectCustomersDetailResponse>(req, "QueryT1IndirectCustomersDetail");
        }

        /// <summary>
        /// This API is used to query the indirect sub-customers of a distributor.
        /// Invokable role type: Distributor
        /// </summary>
        /// <param name="req"><see cref="QueryT1IndirectCustomersDetailRequest"/></param>
        /// <returns><see cref="QueryT1IndirectCustomersDetailResponse"/></returns>
        public QueryT1IndirectCustomersDetailResponse QueryT1IndirectCustomersDetailSync(QueryT1IndirectCustomersDetailRequest req)
        {
            return InternalRequestAsync<QueryT1IndirectCustomersDetailResponse>(req, "QueryT1IndirectCustomersDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used by primary/secondary resellers to query the voucher quota based on the customer UIN.
        /// Callable roles: Reseller, Distributor, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherAmountByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherAmountByUinResponse"/></returns>
        public Task<QueryVoucherAmountByUinResponse> QueryVoucherAmountByUin(QueryVoucherAmountByUinRequest req)
        {
            return InternalRequestAsync<QueryVoucherAmountByUinResponse>(req, "QueryVoucherAmountByUin");
        }

        /// <summary>
        /// This API is used by primary/secondary resellers to query the voucher quota based on the customer UIN.
        /// Callable roles: Reseller, Distributor, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherAmountByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherAmountByUinResponse"/></returns>
        public QueryVoucherAmountByUinResponse QueryVoucherAmountByUinSync(QueryVoucherAmountByUinRequest req)
        {
            return InternalRequestAsync<QueryVoucherAmountByUinResponse>(req, "QueryVoucherAmountByUin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used by primary/secondary resellers to query the voucher list based on the customer UIN.
        /// Callable roles: Reseller, Distributor, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherListByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherListByUinResponse"/></returns>
        public Task<QueryVoucherListByUinResponse> QueryVoucherListByUin(QueryVoucherListByUinRequest req)
        {
            return InternalRequestAsync<QueryVoucherListByUinResponse>(req, "QueryVoucherListByUin");
        }

        /// <summary>
        /// This API is used by primary/secondary resellers to query the voucher list based on the customer UIN.
        /// Callable roles: Reseller, Distributor, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherListByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherListByUinResponse"/></returns>
        public QueryVoucherListByUinResponse QueryVoucherListByUinSync(QueryVoucherListByUinRequest req)
        {
            return InternalRequestAsync<QueryVoucherListByUinResponse>(req, "QueryVoucherListByUin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used by primary/secondary resellers to query the voucher quota pool.
        /// Callable roles: Distributor, First-level reseller, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherPoolRequest"/></param>
        /// <returns><see cref="QueryVoucherPoolResponse"/></returns>
        public Task<QueryVoucherPoolResponse> QueryVoucherPool(QueryVoucherPoolRequest req)
        {
            return InternalRequestAsync<QueryVoucherPoolResponse>(req, "QueryVoucherPool");
        }

        /// <summary>
        /// This API is used by primary/secondary resellers to query the voucher quota pool.
        /// Callable roles: Distributor, First-level reseller, Second-level reseller
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherPoolRequest"/></param>
        /// <returns><see cref="QueryVoucherPoolResponse"/></returns>
        public QueryVoucherPoolResponse QueryVoucherPoolSync(QueryVoucherPoolRequest req)
        {
            return InternalRequestAsync<QueryVoucherPoolResponse>(req, "QueryVoucherPool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a verification code for account registration.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller,End-customer
        /// </summary>
        /// <param name="req"><see cref="SendVerifyCodeRequest"/></param>
        /// <returns><see cref="SendVerifyCodeResponse"/></returns>
        public Task<SendVerifyCodeResponse> SendVerifyCode(SendVerifyCodeRequest req)
        {
            return InternalRequestAsync<SendVerifyCodeResponse>(req, "SendVerifyCode");
        }

        /// <summary>
        /// This API is used to send a verification code for account registration.
        /// 
        /// Callable roles: Distributor, Second-level reseller, Reseller,End-customer
        /// </summary>
        /// <param name="req"><see cref="SendVerifyCodeRequest"/></param>
        /// <returns><see cref="SendVerifyCodeResponse"/></returns>
        public SendVerifyCodeResponse SendVerifyCodeSync(SendVerifyCodeRequest req)
        {
            return InternalRequestAsync<SendVerifyCodeResponse>(req, "SendVerifyCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
