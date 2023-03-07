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

       private const string endpoint = "intlpartnersmgt.tencentcloudapi.com";
       private const string version = "2022-09-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IntlpartnersmgtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used for a partner to set credit for a customer, such as increasing or lowering the credit and setting it to 0.
        /// 1. The credit is valid permanently and will not be zeroed regularly.
        /// 2. The customer's service will be suspended when its available credit is set to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increment of the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates that it will be repossessed. The available credit can be set to 0 at the minimum.
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public async Task<AllocateCustomerCreditResponse> AllocateCustomerCredit(AllocateCustomerCreditRequest req)
        {
             JsonResponseModel<AllocateCustomerCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateCustomerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateCustomerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to set credit for a customer, such as increasing or lowering the credit and setting it to 0.
        /// 1. The credit is valid permanently and will not be zeroed regularly.
        /// 2. The customer's service will be suspended when its available credit is set to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increment of the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates that it will be repossessed. The available credit can be set to 0 at the minimum.
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public AllocateCustomerCreditResponse AllocateCustomerCreditSync(AllocateCustomerCreditRequest req)
        {
             JsonResponseModel<AllocateCustomerCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateCustomerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateCustomerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Tencent Cloud account on the partner platform for a customer. After registration, the customer will be automatically bound to the partner account.
        /// 
        /// Notes:<br>
        /// 1. The partner should verify the entered email address and mobile number for creating a Tencent Cloud account.<br>
        /// 2. The customer needs to complete personal information after the first login.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Tencent Cloud account on the partner platform for a customer. After registration, the customer will be automatically bound to the partner account.
        /// 
        /// Notes:<br>
        /// 1. The partner should verify the entered email address and mobile number for creating a Tencent Cloud account.<br>
        /// 2. The customer needs to complete personal information after the first login.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the customer bill details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillDetailResponse"/></returns>
        public async Task<DescribeCustomerBillDetailResponse> DescribeCustomerBillDetail(DescribeCustomerBillDetailRequest req)
        {
             JsonResponseModel<DescribeCustomerBillDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the customer bill details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillDetailResponse"/></returns>
        public DescribeCustomerBillDetailResponse DescribeCustomerBillDetailSync(DescribeCustomerBillDetailRequest req)
        {
             JsonResponseModel<DescribeCustomerBillDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomerBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the total amount of customer bills.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillSummaryResponse"/></returns>
        public async Task<DescribeCustomerBillSummaryResponse> DescribeCustomerBillSummary(DescribeCustomerBillSummaryRequest req)
        {
             JsonResponseModel<DescribeCustomerBillSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerBillSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerBillSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the total amount of customer bills.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeCustomerBillSummaryResponse"/></returns>
        public DescribeCustomerBillSummaryResponse DescribeCustomerBillSummarySync(DescribeCustomerBillSummaryRequest req)
        {
             JsonResponseModel<DescribeCustomerBillSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomerBillSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerBillSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain country/region codes.
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public async Task<GetCountryCodesResponse> GetCountryCodes(GetCountryCodesRequest req)
        {
             JsonResponseModel<GetCountryCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCountryCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCountryCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain country/region codes.
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public GetCountryCodesResponse GetCountryCodesSync(GetCountryCodesRequest req)
        {
             JsonResponseModel<GetCountryCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCountryCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCountryCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all the credit allocation records of a single customer.
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public async Task<QueryCreditAllocationHistoryResponse> QueryCreditAllocationHistory(QueryCreditAllocationHistoryRequest req)
        {
             JsonResponseModel<QueryCreditAllocationHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCreditAllocationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditAllocationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all the credit allocation records of a single customer.
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public QueryCreditAllocationHistoryResponse QueryCreditAllocationHistorySync(QueryCreditAllocationHistoryRequest req)
        {
             JsonResponseModel<QueryCreditAllocationHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCreditAllocationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditAllocationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the credit of users in the list.
        /// </summary>
        /// <param name="req"><see cref="QueryCreditByUinListRequest"/></param>
        /// <returns><see cref="QueryCreditByUinListResponse"/></returns>
        public async Task<QueryCreditByUinListResponse> QueryCreditByUinList(QueryCreditByUinListRequest req)
        {
             JsonResponseModel<QueryCreditByUinListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCreditByUinList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditByUinListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the credit of users in the list.
        /// </summary>
        /// <param name="req"><see cref="QueryCreditByUinListRequest"/></param>
        /// <returns><see cref="QueryCreditByUinListResponse"/></returns>
        public QueryCreditByUinListResponse QueryCreditByUinListSync(QueryCreditByUinListRequest req)
        {
             JsonResponseModel<QueryCreditByUinListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCreditByUinList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditByUinListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to the credits and basic information of cutomers.
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public async Task<QueryCustomersCreditResponse> QueryCustomersCredit(QueryCustomersCreditRequest req)
        {
             JsonResponseModel<QueryCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to the credits and basic information of cutomers.
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public QueryCustomersCreditResponse QueryCustomersCreditSync(QueryCustomersCreditRequest req)
        {
             JsonResponseModel<QueryCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the credits of direct customers.
        /// </summary>
        /// <param name="req"><see cref="QueryDirectCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryDirectCustomersCreditResponse"/></returns>
        public async Task<QueryDirectCustomersCreditResponse> QueryDirectCustomersCredit(QueryDirectCustomersCreditRequest req)
        {
             JsonResponseModel<QueryDirectCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDirectCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDirectCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the credits of direct customers.
        /// </summary>
        /// <param name="req"><see cref="QueryDirectCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryDirectCustomersCreditResponse"/></returns>
        public QueryDirectCustomersCreditResponse QueryDirectCustomersCreditSync(QueryDirectCustomersCreditRequest req)
        {
             JsonResponseModel<QueryDirectCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDirectCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDirectCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public async Task<QueryPartnerCreditResponse> QueryPartnerCredit(QueryPartnerCreditRequest req)
        {
             JsonResponseModel<QueryPartnerCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryPartnerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPartnerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public QueryPartnerCreditResponse QueryPartnerCreditSync(QueryPartnerCreditRequest req)
        {
             JsonResponseModel<QueryPartnerCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryPartnerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPartnerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the voucher quota based on the customer UIN.
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherAmountByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherAmountByUinResponse"/></returns>
        public async Task<QueryVoucherAmountByUinResponse> QueryVoucherAmountByUin(QueryVoucherAmountByUinRequest req)
        {
             JsonResponseModel<QueryVoucherAmountByUinResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVoucherAmountByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherAmountByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the voucher quota based on the customer UIN.
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherAmountByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherAmountByUinResponse"/></returns>
        public QueryVoucherAmountByUinResponse QueryVoucherAmountByUinSync(QueryVoucherAmountByUinRequest req)
        {
             JsonResponseModel<QueryVoucherAmountByUinResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVoucherAmountByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherAmountByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the voucher list based on the customer UIN.
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherListByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherListByUinResponse"/></returns>
        public async Task<QueryVoucherListByUinResponse> QueryVoucherListByUin(QueryVoucherListByUinRequest req)
        {
             JsonResponseModel<QueryVoucherListByUinResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVoucherListByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherListByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the voucher list based on the customer UIN.
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherListByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherListByUinResponse"/></returns>
        public QueryVoucherListByUinResponse QueryVoucherListByUinSync(QueryVoucherListByUinRequest req)
        {
             JsonResponseModel<QueryVoucherListByUinResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVoucherListByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherListByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the voucher quota pool.
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherPoolRequest"/></param>
        /// <returns><see cref="QueryVoucherPoolResponse"/></returns>
        public async Task<QueryVoucherPoolResponse> QueryVoucherPool(QueryVoucherPoolRequest req)
        {
             JsonResponseModel<QueryVoucherPoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVoucherPool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherPoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the voucher quota pool.
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherPoolRequest"/></param>
        /// <returns><see cref="QueryVoucherPoolResponse"/></returns>
        public QueryVoucherPoolResponse QueryVoucherPoolSync(QueryVoucherPoolRequest req)
        {
             JsonResponseModel<QueryVoucherPoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVoucherPool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherPoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
