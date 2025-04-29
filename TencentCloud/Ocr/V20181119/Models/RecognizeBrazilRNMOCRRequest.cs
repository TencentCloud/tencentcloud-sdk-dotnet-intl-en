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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeBrazilRNMOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64 value of the image. Supported image formats: PNG, JPG, JPEG, GIF format is not supported yet. Supported image size: The downloaded image should not exceed 7M after Base64 encoding. Image downloading time should not exceed 3 seconds.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// URL address of the image. Supported image formats: PNG, JPG, JPEG, GIF format is not supported yet. Supported image size: The downloaded image should not exceed 7M after Base64 encoding. Image download time should not exceed 3 seconds. URLs of images stored in Tencent Cloud can guarantee higher download speed and stability. It is recommended that images be stored in Tencent Cloud. The speed and stability of URLs not stored in Tencent Cloud may be affected to a certain extent.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Base64 value of the image on the back of the card. Supported image formats: PNG, JPG, JPEG, GIF format is not supported yet. Supported image size: The downloaded image should not exceed 7M after Base64 encoding. Image download time should not exceed 3 seconds. An ImageUrl and ImageBase64 must be provided. If both are provided, only ImageUrl will be used.
        /// </summary>
        [JsonProperty("BackImageBase64")]
        public string BackImageBase64{ get; set; }

        /// <summary>
        /// The URL address of the image on the back of the card. Supported image formats: PNG, JPG, JPEG, GIF format is not supported yet. Supported image size: The downloaded image does not exceed 7M after Base64 encoding. The image download time does not exceed 3 seconds. The URL of the image stored in Tencent Cloud can ensure higher download speed and stability. It is recommended to store the image in Tencent Cloud. The speed and stability of the URL stored outside Tencent Cloud may be affected to a certain extent.
        /// </summary>
        [JsonProperty("BackImageUrl")]
        public string BackImageUrl{ get; set; }

        /// <summary>
        /// Whether to return portrait photos.
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

