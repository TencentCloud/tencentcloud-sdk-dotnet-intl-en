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

namespace TencentCloud.Tms.V20201229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tms.V20201229.Models;

   public class TmsClient : AbstractClient{

       private const string endpoint = "tms.tencentcloudapi.com";
       private const string version = "2020-12-29";
       private const string sdkVersion = "SDK_NET_3.0.884";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to submit text content for intelligent moderation. 
        /// 
        /// ### Notes
        /// - Before invoking this API, be sure you have activated Tencent Cloud Text Moderation System in the [Content Moderation - Text Moderation System](https://console.cloud.tencent.com/cms/text/package) console.
        /// - This is a paid API. For the billing details, see [Text Moderation System Pricing](https://intl.cloud.tencent.com/product/tms/pricing?from_cn_redirect=1).
        /// 
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        /// 
        /// ### Use limits
        /// - The submitted texts can not be longer than 10,000 unicode characters.
        /// - English letters, digits and Chinese characters are supported for moderation.
        /// - The API request frequency limit: **1,000 times/second**. 
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public Task<TextModerationResponse> TextModeration(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration");
        }

        /// <summary>
        /// This API is used to submit text content for intelligent moderation. 
        /// 
        /// ### Notes
        /// - Before invoking this API, be sure you have activated Tencent Cloud Text Moderation System in the [Content Moderation - Text Moderation System](https://console.cloud.tencent.com/cms/text/package) console.
        /// - This is a paid API. For the billing details, see [Text Moderation System Pricing](https://intl.cloud.tencent.com/product/tms/pricing?from_cn_redirect=1).
        /// 
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        /// 
        /// ### Use limits
        /// - The submitted texts can not be longer than 10,000 unicode characters.
        /// - English letters, digits and Chinese characters are supported for moderation.
        /// - The API request frequency limit: **1,000 times/second**. 
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public TextModerationResponse TextModerationSync(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
