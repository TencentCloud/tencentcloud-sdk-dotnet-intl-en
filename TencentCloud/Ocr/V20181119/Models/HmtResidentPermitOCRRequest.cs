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

    public class HmtResidentPermitOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Base64 value of the image. Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. Supported image size: no more than 7M after the downloaded image is Base64-encoded. The image download must complete within 3 seconds.Either ImageUrl or ImageBase64 must be provided. If both are provided, only ImageUrl is used.</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>Image URL.Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported. Supported image size: no more than 7M after Base64 encoding. Image download time no more than 3 seconds. URLs stored in Tencent Cloud guarantee higher download speed and stability. It is recommended to store images in Tencent Cloud. Speed and stability may be impacted for URLs not stored in Tencent Cloud.</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>FRONT: the side with a photo (portrait side),<br>BACK: the side without a photo (national emblem side),<br>if this parameter is left empty or incorrect, the front or back side is automatically determined for you.</p>
        /// </summary>
        [JsonProperty("CardSide")]
        public string CardSide{ get; set; }

        /// <summary>
        /// Whether to return the portrait image and position coordinates
        /// </summary>
        [JsonProperty("CropPortrait")]
        public bool? CropPortrait{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "CardSide", this.CardSide);
            this.SetParamSimple(map, prefix + "CropPortrait", this.CropPortrait);
        }
    }
}

