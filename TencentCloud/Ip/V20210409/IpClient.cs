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

    }
}
