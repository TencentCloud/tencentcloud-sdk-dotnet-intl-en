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

namespace TencentCloud.Dms.V20200819
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dms.V20200819.Models;

   public class DmsClient : AbstractClient{

       private const string endpoint = "dms.tencentcloudapi.com";
       private const string version = "2020-08-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to send regular emails.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public async Task<SendEmailResponse> SendEmail(SendEmailRequest req)
        {
             JsonResponseModel<SendEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send regular emails.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public SendEmailResponse SendEmailSync(SendEmailRequest req)
        {
             JsonResponseModel<SendEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send template emails.
        /// </summary>
        /// <param name="req"><see cref="SendTemplatedEmailRequest"/></param>
        /// <returns><see cref="SendTemplatedEmailResponse"/></returns>
        public async Task<SendTemplatedEmailResponse> SendTemplatedEmail(SendTemplatedEmailRequest req)
        {
             JsonResponseModel<SendTemplatedEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendTemplatedEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTemplatedEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send template emails.
        /// </summary>
        /// <param name="req"><see cref="SendTemplatedEmailRequest"/></param>
        /// <returns><see cref="SendTemplatedEmailResponse"/></returns>
        public SendTemplatedEmailResponse SendTemplatedEmailSync(SendTemplatedEmailRequest req)
        {
             JsonResponseModel<SendTemplatedEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendTemplatedEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTemplatedEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
