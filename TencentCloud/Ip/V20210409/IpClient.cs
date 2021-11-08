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

namespace TencentCloud.Ip.V20210409
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ip.V20210409.Models;

   public class IpClient : AbstractClient{

       private const string endpoint = "ip.tencentcloudapi.com";
       private const string version = "2021-04-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used for a partner to set credit for a customer, such as increasing or lowering the credit and setting it to 0.
        /// 1. The credit is valid permanently and will not be zeroed regularly.
        /// 2. The customer's service will be suspended when its available credit sets to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increase to the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates to repossess it. The available credit can be set to 0 at the minimum.
        /// </summary>
        /// <param name="req"><see cref="AssignClientCreditRequest"/></param>
        /// <returns><see cref="AssignClientCreditResponse"/></returns>
        public async Task<AssignClientCreditResponse> AssignClientCredit(AssignClientCreditRequest req)
        {
             JsonResponseModel<AssignClientCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignClientCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignClientCreditResponse>>(strResp);
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
        /// 2. The customer's service will be suspended when its available credit sets to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increase to the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates to repossess it. The available credit can be set to 0 at the minimum.
        /// </summary>
        /// <param name="req"><see cref="AssignClientCreditRequest"/></param>
        /// <returns><see cref="AssignClientCreditResponse"/></returns>
        public AssignClientCreditResponse AssignClientCreditSync(AssignClientCreditRequest req)
        {
             JsonResponseModel<AssignClientCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignClientCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignClientCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Tencent Cloud account in the International Partner platform for a customer. After registration, the customer will be automatically bound to the partner account.
        /// 
        /// Notes:<br>
        /// 1. To create the Tencent Cloud account, the partner should enter and verify the customer’s email address and mobile number.<br>
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
        /// This API is used to create a Tencent Cloud account in the International Partner platform for a customer. After registration, the customer will be automatically bound to the partner account.
        /// 
        /// Notes:<br>
        /// 1. To create the Tencent Cloud account, the partner should enter and verify the customer’s email address and mobile number.<br>
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
        /// This API is used to obtain country and region codes.
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
        /// This API is used to obtain country and region codes.
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
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// </summary>
        /// <param name="req"><see cref="QueryAgentCreditRequest"/></param>
        /// <returns><see cref="QueryAgentCreditResponse"/></returns>
        public async Task<QueryAgentCreditResponse> QueryAgentCredit(QueryAgentCreditRequest req)
        {
             JsonResponseModel<QueryAgentCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAgentCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAgentCreditResponse>>(strResp);
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
        /// <param name="req"><see cref="QueryAgentCreditRequest"/></param>
        /// <returns><see cref="QueryAgentCreditResponse"/></returns>
        public QueryAgentCreditResponse QueryAgentCreditSync(QueryAgentCreditRequest req)
        {
             JsonResponseModel<QueryAgentCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAgentCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAgentCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to query a customer's credit and basic information.
        /// </summary>
        /// <param name="req"><see cref="QueryClientListRequest"/></param>
        /// <returns><see cref="QueryClientListResponse"/></returns>
        public async Task<QueryClientListResponse> QueryClientList(QueryClientListRequest req)
        {
             JsonResponseModel<QueryClientListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryClientList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryClientListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for a partner to query a customer's credit and basic information.
        /// </summary>
        /// <param name="req"><see cref="QueryClientListRequest"/></param>
        /// <returns><see cref="QueryClientListResponse"/></returns>
        public QueryClientListResponse QueryClientListSync(QueryClientListRequest req)
        {
             JsonResponseModel<QueryClientListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryClientList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryClientListResponse>>(strResp);
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
        /// <param name="req"><see cref="QueryCreditHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditHistoryResponse"/></returns>
        public async Task<QueryCreditHistoryResponse> QueryCreditHistory(QueryCreditHistoryRequest req)
        {
             JsonResponseModel<QueryCreditHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCreditHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditHistoryResponse>>(strResp);
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
        /// <param name="req"><see cref="QueryCreditHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditHistoryResponse"/></returns>
        public QueryCreditHistoryResponse QueryCreditHistorySync(QueryCreditHistoryRequest req)
        {
             JsonResponseModel<QueryCreditHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCreditHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
