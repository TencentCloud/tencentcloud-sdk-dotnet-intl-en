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

    public class RecognizeBrazilCommonOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64 value of the image. supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. supported image size: no more than 7M after encoding. image download time: no more than 3 seconds.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The Url of the image. supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. supported image size: no more than 7M after Base64 encoding. image download time is no more than 3 seconds. urls stored in tencent cloud guarantee higher download speed and stability. it is advisable to store images in tencent cloud. urls not stored in tencent cloud may possibly be impacted in speed and stability.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The Base64 value of the back side of the card. supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. supported image size: no more than 7M after encoding. image download time: not more than 3 seconds. either ImageUrl or ImageBase64 must be provided. if both are provided, only use ImageUrl.
        /// </summary>
        [JsonProperty("BackImageBase64")]
        public string BackImageBase64{ get; set; }

        /// <summary>
        /// The Url address of the back side of the card. supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. supported image size: no more than 7M after Base64 encoding. image download time is no more than 3 seconds. urls stored in tencent cloud guarantee higher download speed and stability. it is recommended to store images in tencent cloud. speed and stability of non-tencent cloud storage urls may be impacted.
        /// </summary>
        [JsonProperty("BackImageUrl")]
        public string BackImageUrl{ get; set; }

        /// <summary>
        /// Specifies whether to return the portrait photo.
        /// </summary>
        [JsonProperty("ReturnHeadImage")]
        public bool? ReturnHeadImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "BackImageBase64", this.BackImageBase64);
            this.SetParamSimple(map, prefix + "BackImageUrl", this.BackImageUrl);
            this.SetParamSimple(map, prefix + "ReturnHeadImage", this.ReturnHeadImage);
        }
    }
}

