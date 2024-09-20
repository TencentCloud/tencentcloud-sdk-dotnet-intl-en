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

namespace TencentCloud.Tmt.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tmt.V20180321.Models;

   public class TmtClient : AbstractClient{

       private const string endpoint = "tmt.tencentcloudapi.com";
       private const string version = "2018-03-21";
       private const string sdkVersion = "SDK_NET_3.0.982";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TmtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TmtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to translate text in multiple language pairs, such as Chinese-English.<br />
        /// Note: We recommend that you simplify your development with the SDK integration mode. For how to use the SDK, see Section 5 "Developer Resources".
        /// </summary>
        /// <param name="req"><see cref="TextTranslateRequest"/></param>
        /// <returns><see cref="TextTranslateResponse"/></returns>
        public Task<TextTranslateResponse> TextTranslate(TextTranslateRequest req)
        {
            return InternalRequestAsync<TextTranslateResponse>(req, "TextTranslate");
        }

        /// <summary>
        /// This API is used to translate text in multiple language pairs, such as Chinese-English.<br />
        /// Note: We recommend that you simplify your development with the SDK integration mode. For how to use the SDK, see Section 5 "Developer Resources".
        /// </summary>
        /// <param name="req"><see cref="TextTranslateRequest"/></param>
        /// <returns><see cref="TextTranslateResponse"/></returns>
        public TextTranslateResponse TextTranslateSync(TextTranslateRequest req)
        {
            return InternalRequestAsync<TextTranslateResponse>(req, "TextTranslate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
