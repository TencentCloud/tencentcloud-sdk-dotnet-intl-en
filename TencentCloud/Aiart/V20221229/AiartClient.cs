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

namespace TencentCloud.Aiart.V20221229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Aiart.V20221229.Models;

   public class AiartClient : AbstractClient{

       private const string endpoint = "aiart.intl.tencentcloudapi.com";
       private const string version = "2022-12-29";
       private const string sdkVersion = "SDK_NET_3.0.1115";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AiartClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AiartClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to transfer the image style based on the image to image technology. Images with small figures, complex gestures or too many figures are not recommended.
        /// It supports 3 concurrency by default, which means that up to 3 submitted tasks can be processed simultaneously. Subsequent tasks can be processed only after ongoing ones are completed.
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public Task<ImageToImageResponse> ImageToImage(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage");
        }

        /// <summary>
        /// This API is used to transfer the image style based on the image to image technology. Images with small figures, complex gestures or too many figures are not recommended.
        /// It supports 3 concurrency by default, which means that up to 3 submitted tasks can be processed simultaneously. Subsequent tasks can be processed only after ongoing ones are completed.
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public ImageToImageResponse ImageToImageSync(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
