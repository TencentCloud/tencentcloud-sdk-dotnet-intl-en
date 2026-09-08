/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

       private const string endpoint = "captcha.intl.tencentcloudapi.com";
       private const string version = "2019-07-22";
       private const string sdkVersion = "SDK_NET_3.0.1391";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CaptchaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Create a captcha: You can create multiple Captcha based on different business needs. Each verification has different client types and security policies. The limit for new Captcha is 50.
        /// </summary>
        /// <param name="req"><see cref="CreateCaptchaInfoInternationalRequest"/></param>
        /// <returns><see cref="CreateCaptchaInfoInternationalResponse"/></returns>
        public Task<CreateCaptchaInfoInternationalResponse> CreateCaptchaInfoInternational(CreateCaptchaInfoInternationalRequest req)
        {
            return InternalRequestAsync<CreateCaptchaInfoInternationalResponse>(req, "CreateCaptchaInfoInternational");
        }

        /// <summary>
        /// Create a captcha: You can create multiple Captcha based on different business needs. Each verification has different client types and security policies. The limit for new Captcha is 50.
        /// </summary>
        /// <param name="req"><see cref="CreateCaptchaInfoInternationalRequest"/></param>
        /// <returns><see cref="CreateCaptchaInfoInternationalResponse"/></returns>
        public CreateCaptchaInfoInternationalResponse CreateCaptchaInfoInternationalSync(CreateCaptchaInfoInternationalRequest req)
        {
            return InternalRequestAsync<CreateCaptchaInfoInternationalResponse>(req, "CreateCaptchaInfoInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an IP allowlist: You can create an IP allowlist based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="CreateIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="CreateIpWhiteListInternationalResponse"/></returns>
        public Task<CreateIpWhiteListInternationalResponse> CreateIpWhiteListInternational(CreateIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<CreateIpWhiteListInternationalResponse>(req, "CreateIpWhiteListInternational");
        }

        /// <summary>
        /// Create an IP allowlist: You can create an IP allowlist based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="CreateIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="CreateIpWhiteListInternationalResponse"/></returns>
        public CreateIpWhiteListInternationalResponse CreateIpWhiteListInternationalSync(CreateIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<CreateIpWhiteListInternationalResponse>(req, "CreateIpWhiteListInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an IP allowlist: You can delete an IP allowlist based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="DeleteIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="DeleteIpWhiteListInternationalResponse"/></returns>
        public Task<DeleteIpWhiteListInternationalResponse> DeleteIpWhiteListInternational(DeleteIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<DeleteIpWhiteListInternationalResponse>(req, "DeleteIpWhiteListInternational");
        }

        /// <summary>
        /// Delete an IP allowlist: You can delete an IP allowlist based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="DeleteIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="DeleteIpWhiteListInternationalResponse"/></returns>
        public DeleteIpWhiteListInternationalResponse DeleteIpWhiteListInternationalSync(DeleteIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<DeleteIpWhiteListInternationalResponse>(req, "DeleteIpWhiteListInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Captcha list to obtain all verification CaptchaAppIds, verification names, and other information internationally.
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaInfoListInternationalRequest"/></param>
        /// <returns><see cref="DescribeCaptchaInfoListInternationalResponse"/></returns>
        public Task<DescribeCaptchaInfoListInternationalResponse> DescribeCaptchaInfoListInternational(DescribeCaptchaInfoListInternationalRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaInfoListInternationalResponse>(req, "DescribeCaptchaInfoListInternational");
        }

        /// <summary>
        /// Query the Captcha list to obtain all verification CaptchaAppIds, verification names, and other information internationally.
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaInfoListInternationalRequest"/></param>
        /// <returns><see cref="DescribeCaptchaInfoListInternationalResponse"/></returns>
        public DescribeCaptchaInfoListInternationalResponse DescribeCaptchaInfoListInternationalSync(DescribeCaptchaInfoListInternationalRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaInfoListInternationalResponse>(req, "DescribeCaptchaInfoListInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of CAPTCHA ticket verification (web and app).
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public Task<DescribeCaptchaResultResponse> DescribeCaptchaResult(DescribeCaptchaResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaResultResponse>(req, "DescribeCaptchaResult");
        }

        /// <summary>
        /// This API is used to query the result of CAPTCHA ticket verification (web and app).
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public DescribeCaptchaResultResponse DescribeCaptchaResultSync(DescribeCaptchaResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaResultResponse>(req, "DescribeCaptchaResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// IP allowlist list: You can query the IP whitelist list based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="DescribeIpWhiteListInternationalResponse"/></returns>
        public Task<DescribeIpWhiteListInternationalResponse> DescribeIpWhiteListInternational(DescribeIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<DescribeIpWhiteListInternationalResponse>(req, "DescribeIpWhiteListInternational");
        }

        /// <summary>
        /// IP allowlist list: You can query the IP whitelist list based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="DescribeIpWhiteListInternationalResponse"/></returns>
        public DescribeIpWhiteListInternationalResponse DescribeIpWhiteListInternationalSync(DescribeIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<DescribeIpWhiteListInternationalResponse>(req, "DescribeIpWhiteListInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Change the captcha configuration, including basic, appearance, and security settings such as captcha name, prompt language, and validation type.
        /// </summary>
        /// <param name="req"><see cref="ModifyCaptchaInfoInternationalRequest"/></param>
        /// <returns><see cref="ModifyCaptchaInfoInternationalResponse"/></returns>
        public Task<ModifyCaptchaInfoInternationalResponse> ModifyCaptchaInfoInternational(ModifyCaptchaInfoInternationalRequest req)
        {
            return InternalRequestAsync<ModifyCaptchaInfoInternationalResponse>(req, "ModifyCaptchaInfoInternational");
        }

        /// <summary>
        /// Change the captcha configuration, including basic, appearance, and security settings such as captcha name, prompt language, and validation type.
        /// </summary>
        /// <param name="req"><see cref="ModifyCaptchaInfoInternationalRequest"/></param>
        /// <returns><see cref="ModifyCaptchaInfoInternationalResponse"/></returns>
        public ModifyCaptchaInfoInternationalResponse ModifyCaptchaInfoInternationalSync(ModifyCaptchaInfoInternationalRequest req)
        {
            return InternalRequestAsync<ModifyCaptchaInfoInternationalResponse>(req, "ModifyCaptchaInfoInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit IP allowlist: You can edit the IP allowlist based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="ModifyIpWhiteListInternationalResponse"/></returns>
        public Task<ModifyIpWhiteListInternationalResponse> ModifyIpWhiteListInternational(ModifyIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<ModifyIpWhiteListInternationalResponse>(req, "ModifyIpWhiteListInternational");
        }

        /// <summary>
        /// Edit IP allowlist: You can edit the IP allowlist based on different business needs.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpWhiteListInternationalRequest"/></param>
        /// <returns><see cref="ModifyIpWhiteListInternationalResponse"/></returns>
        public ModifyIpWhiteListInternationalResponse ModifyIpWhiteListInternationalSync(ModifyIpWhiteListInternationalRequest req)
        {
            return InternalRequestAsync<ModifyIpWhiteListInternationalResponse>(req, "ModifyIpWhiteListInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a captcha: once deleted, verification scenarios using this CaptchaAppId will fail to load the verification code on the frontend, and invoice verification will report an error on the backend. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="RemoveCaptchaInfoInternationalRequest"/></param>
        /// <returns><see cref="RemoveCaptchaInfoInternationalResponse"/></returns>
        public Task<RemoveCaptchaInfoInternationalResponse> RemoveCaptchaInfoInternational(RemoveCaptchaInfoInternationalRequest req)
        {
            return InternalRequestAsync<RemoveCaptchaInfoInternationalResponse>(req, "RemoveCaptchaInfoInternational");
        }

        /// <summary>
        /// Delete a captcha: once deleted, verification scenarios using this CaptchaAppId will fail to load the verification code on the frontend, and invoice verification will report an error on the backend. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="RemoveCaptchaInfoInternationalRequest"/></param>
        /// <returns><see cref="RemoveCaptchaInfoInternationalResponse"/></returns>
        public RemoveCaptchaInfoInternationalResponse RemoveCaptchaInfoInternationalSync(RemoveCaptchaInfoInternationalRequest req)
        {
            return InternalRequestAsync<RemoveCaptchaInfoInternationalResponse>(req, "RemoveCaptchaInfoInternational")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
