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

namespace TencentCloud.Faceid.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Faceid.V20180301.Models;

   public class FaceidClient : AbstractClient{

       private const string endpoint = "faceid.tencentcloudapi.com";
       private const string version = "2018-03-01";
       private const string sdkVersion = "SDK_NET_3.0.898";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FaceidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the Identity Verification SDK service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public Task<ApplySdkVerificationTokenResponse> ApplySdkVerificationToken(ApplySdkVerificationTokenRequest req)
        {
            return InternalRequestAsync<ApplySdkVerificationTokenResponse>(req, "ApplySdkVerificationToken");
        }

        /// <summary>
        /// This API is used to apply for a token before calling the Identity Verification SDK service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public ApplySdkVerificationTokenResponse ApplySdkVerificationTokenSync(ApplySdkVerificationTokenRequest req)
        {
            return InternalRequestAsync<ApplySdkVerificationTokenResponse>(req, "ApplySdkVerificationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token after the SDK-based verification is completed. The token is valid for three days after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public Task<GetSdkVerificationResultResponse> GetSdkVerificationResult(GetSdkVerificationResultRequest req)
        {
            return InternalRequestAsync<GetSdkVerificationResultResponse>(req, "GetSdkVerificationResult");
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token after the SDK-based verification is completed. The token is valid for three days after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public GetSdkVerificationResultResponse GetSdkVerificationResultSync(GetSdkVerificationResultRequest req)
        {
            return InternalRequestAsync<GetSdkVerificationResultResponse>(req, "GetSdkVerificationResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
