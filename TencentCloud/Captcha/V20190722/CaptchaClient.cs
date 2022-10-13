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

namespace TencentCloud.Captcha.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Captcha.V20190722.Models;

   public class CaptchaClient : AbstractClient{

       private const string endpoint = "captcha.tencentcloudapi.com";
       private const string version = "2019-07-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CaptchaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CaptchaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to query the result of CAPTCHA ticket verification (web and app).
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public async Task<DescribeCaptchaResultResponse> DescribeCaptchaResult(DescribeCaptchaResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of CAPTCHA ticket verification (web and app).
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public DescribeCaptchaResultResponse DescribeCaptchaResultSync(DescribeCaptchaResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}