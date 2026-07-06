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

    public class RecognizeDetectCardCoordsRequest : AbstractModel
    {
        
        /// <summary>
        /// URL of the image. Supported image formats: PNG, JPG, JPEG. GIF is not supported. The downloaded image must be no larger than 7 MB after Base64 encoding. Image download must complete within 3 seconds. Images stored in Tencent Cloud offer higher download speed and stability. We recommend storing images in Tencent Cloud. The speed and stability of URLs from non-Tencent Cloud storage may be affected.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Base64-encoded image data. Supported image formats: PNG, JPG, JPEG. GIF is not supported. The image must be no larger than 7 MB after Base64 encoding. Image download must complete within 3 seconds. You must provide either ImageUrl or ImageBase64. If both are provided, ImageUrl will be used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
        }
    }
}

