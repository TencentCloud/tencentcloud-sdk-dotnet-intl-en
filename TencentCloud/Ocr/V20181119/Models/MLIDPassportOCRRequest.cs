/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MLIDPassportOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded image data. The image must be no larger than 7 MB after Base64 encoding. A resolution of at least 500x800 is recommended. Supported image formats: PNG, JPG, JPEG, BMP, and PDF. The document should occupy more than 2/3 of the image area.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Whether to return an image. 
        /// Default value: false.
        /// </summary>
        [JsonProperty("RetImage")]
        public bool? RetImage{ get; set; }

        /// <summary>
        /// URL of the image. The downloaded image must be no larger than 7 MB after Base64 encoding. A resolution of at least 500x800 is recommended. Supported image formats: PNG, JPG, JPEG, BMP, and PDF. The document should occupy more than 2/3 of the image area. Image download must complete within 3 seconds. We recommend storing images in Tencent Cloud for higher download speed and stability. The speed and stability of URLs from non-Tencent Cloud storage may be affected. Note: This field is not supported outside the Chinese mainland region.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "RetImage", this.RetImage);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
        }
    }
}

