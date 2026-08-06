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

namespace TencentCloud.Tmt.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tmt.V20180321.Models;

   public class TmtClient : AbstractClient{

       private const string endpoint = "tmt.intl.tencentcloudapi.com";
       private const string version = "2018-03-21";
       private const string sdkVersion = "SDK_NET_3.0.1369";

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
        /// This API is used to provide translation service for images in 18 languages. It can automatically recognize text content in images and translate it into the target language. The recognized text is translated line by line, and a version that supports paragraph translation will be offered subsequently.
        /// 
        /// -Input image format: png, jpg, jpeg and other common image formats. gif animation is not supported.
        /// -Output image format: jpg.
        /// 
        /// Notification: For general developers, we recommend prioritizing SDK integration to simplify development. For SDK usage introduction, directly view the 5. Developer Resources part.
        /// </summary>
        /// <param name="req"><see cref="ImageTranslateLLMRequest"/></param>
        /// <returns><see cref="ImageTranslateLLMResponse"/></returns>
        public Task<ImageTranslateLLMResponse> ImageTranslateLLM(ImageTranslateLLMRequest req)
        {
            return InternalRequestAsync<ImageTranslateLLMResponse>(req, "ImageTranslateLLM");
        }

        /// <summary>
        /// This API is used to provide translation service for images in 18 languages. It can automatically recognize text content in images and translate it into the target language. The recognized text is translated line by line, and a version that supports paragraph translation will be offered subsequently.
        /// 
        /// -Input image format: png, jpg, jpeg and other common image formats. gif animation is not supported.
        /// -Output image format: jpg.
        /// 
        /// Notification: For general developers, we recommend prioritizing SDK integration to simplify development. For SDK usage introduction, directly view the 5. Developer Resources part.
        /// </summary>
        /// <param name="req"><see cref="ImageTranslateLLMRequest"/></param>
        /// <returns><see cref="ImageTranslateLLMResponse"/></returns>
        public ImageTranslateLLMResponse ImageTranslateLLMSync(ImageTranslateLLMRequest req)
        {
            return InternalRequestAsync<ImageTranslateLLMResponse>(req, "ImageTranslateLLM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
