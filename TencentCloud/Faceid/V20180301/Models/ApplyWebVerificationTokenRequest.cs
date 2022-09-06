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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyWebVerificationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// The web redirect URL after the verification is completed.
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// The COS URL of the image for face comparison, which can be obtained with one of the following methods:
        /// 1. Call the `CreateUploadUrl` API to generate a URL and call it again after the image is successfully uploaded.
        /// 2. Use an existing COS URL. For a private bucket, grant the download permission with a pre-signed URL. The corresponding COS bucket must be in the same region as the input parameter `Region`.
        /// </summary>
        [JsonProperty("CompareImageUrl")]
        public string CompareImageUrl{ get; set; }

        /// <summary>
        /// The MD5 hash values of the image for face comparison (CompareImageUrl).
        /// </summary>
        [JsonProperty("CompareImageMd5")]
        public string CompareImageMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamSimple(map, prefix + "CompareImageUrl", this.CompareImageUrl);
            this.SetParamSimple(map, prefix + "CompareImageMd5", this.CompareImageMd5);
        }
    }
}

