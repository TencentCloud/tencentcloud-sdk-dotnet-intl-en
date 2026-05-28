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

    public class RecognizeIndonesiaIDCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64 value of the image. Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. Supported image size: the downloaded image after Base64 encoding is no more than 7M. Image download time is not more than 3 seconds. Either ImageUrl or ImageBase64 must be provided. If both are provided, only use ImageUrl.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The Url address of the image. 
        /// Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. 
        /// Supported image size: the downloaded image after Base64 encoding is no more than 7M. Image download time is no more than 3 seconds. 
        /// We recommend that you store the image in Tencent Cloud for higher download speed and stability.
        /// For a non-Tencent Cloud URL, the download speed and stability may be affected.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Whether to return the portrait photo.
        /// If selected true, image restrictions are: Image size after encoding must not exceed 5M, jpg format long side pixel cannot exceed 4000, other formats image long edge pixel maximum of 2000. Short side pixel of all format images not less than 64.
        /// Support PNG, jpg, JPEG, BMP, no support for GIF images.
        /// If portrait matting fails, return an empty string.
        /// </summary>
        [JsonProperty("ReturnHeadImage")]
        public bool? ReturnHeadImage{ get; set; }

        /// <summary>
        /// Scene parameter, default value is V1
        /// Available values:
        /// V1
        /// V2
        /// </summary>
        [JsonProperty("Scene")]
        [System.Obsolete]
        public string Scene{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ReturnHeadImage", this.ReturnHeadImage);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
        }
    }
}

