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
       private const string sdkVersion = "SDK_NET_3.0.849";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used for a partner to set credit for a customer, such as increasing or lowering the credit and setting it to 0.
        /// 1. The credit is valid permanently and will not be zeroed regularly.
        /// 2. The customer's service will be suspended when its available credit sets to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increase to the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates to repossess it. The available credit can be set to 0 at the minimum.
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
        /// 2. The customer's service will be suspended when its available credit sets to 0, so caution should be exercised with this operation.
        /// 3. To prevent the customer from making new purchases without affecting their use of previously purchased products, the partner can set their available credit to 0 after obtaining the non-stop feature privilege from the channel manager.
        /// 4. The set credit is an increase to the current available credit and cannot exceed the remaining allocable credit. Setting the credit to a negative value indicates to repossess it. The available credit can be set to 0 at the minimum.
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public AllocateCustomerCreditResponse AllocateCustomerCreditSync(AllocateCustomerCreditRequest req)
        {
            return InternalRequestAsync<AllocateCustomerCreditResponse>(req, "AllocateCustomerCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
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
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain country and region codes.
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public Task<GetCountryCodesResponse> GetCountryCodes(GetCountryCodesRequest req)
        {
            return InternalRequestAsync<GetCountryCodesResponse>(req, "GetCountryCodes");
        }

        /// <summary>
        /// This API is used to obtain country and region codes.
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public GetCountryCodesResponse GetCountryCodesSync(GetCountryCodesRequest req)
        {
            return InternalRequestAsync<GetCountryCodesResponse>(req, "GetCountryCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all the credit allocation records of a single customer.
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public Task<QueryCreditAllocationHistoryResponse> QueryCreditAllocationHistory(QueryCreditAllocationHistoryRequest req)
        {
            return InternalRequestAsync<QueryCreditAllocationHistoryResponse>(req, "QueryCreditAllocationHistory");
        }

        /// <summary>
        /// This API is used to query all the credit allocation records of a single customer.
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public QueryCreditAllocationHistoryResponse QueryCreditAllocationHistorySync(QueryCreditAllocationHistoryRequest req)
        {
            return InternalRequestAsync<QueryCreditAllocationHistoryResponse>(req, "QueryCreditAllocationHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for a partner to query a customer's credit and basic information.
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public Task<QueryCustomersCreditResponse> QueryCustomersCredit(QueryCustomersCreditRequest req)
        {
            return InternalRequestAsync<QueryCustomersCreditResponse>(req, "QueryCustomersCredit");
        }

        /// <summary>
        /// This API is used for a partner to query a customer's credit and basic information.
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public QueryCustomersCreditResponse QueryCustomersCreditSync(QueryCustomersCreditRequest req)
        {
            return InternalRequestAsync<QueryCustomersCreditResponse>(req, "QueryCustomersCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public Task<QueryPartnerCreditResponse> QueryPartnerCredit(QueryPartnerCreditRequest req)
        {
            return InternalRequestAsync<QueryPartnerCreditResponse>(req, "QueryPartnerCredit");
        }

        /// <summary>
        /// This API is used for a partner to query its own total credit, available credit, and used credit in USD.
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public QueryPartnerCreditResponse QueryPartnerCreditSync(QueryPartnerCreditRequest req)
        {
            return InternalRequestAsync<QueryPartnerCreditResponse>(req, "QueryPartnerCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
