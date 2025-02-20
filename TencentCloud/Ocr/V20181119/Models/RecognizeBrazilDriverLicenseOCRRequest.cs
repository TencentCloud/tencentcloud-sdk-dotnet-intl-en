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

    public class RecognizeBrazilDriverLicenseOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64 value of the image. It is required that the image after Base64 encoding should not exceed 7M, the resolution is recommended to be 500*800 or above, and PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupies at least 2/3 of the picture. One of ImageUrl and ImageBase64 of the image must be provided. If both are provided, only ImageUrl will be used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The Base64 value of the image. It is required that the image after Base64 encoding should not exceed 7M, the resolution is recommended to be 500*800 or above, and PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupies at least 2/3 of the picture. One of ImageUrl and ImageBase64 of the image must be provided. If both are provided, only ImageUrl will be used.
        /// </summary>
        [JsonProperty("BackImageBase64")]
        public string BackImageBase64{ get; set; }

        /// <summary>
        /// The URL address of the image. It is required that the image after Base64 encoding should not exceed 7M, the resolution is recommended to be 500*800 or above, and PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupies at least 2/3 of the picture. It is recommended that images be stored in Tencent Cloud to ensure higher download speed and stability.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The URL address of the image. It is required that the image after Base64 encoding should not exceed 7M, the resolution is recommended to be 500*800 or above, and PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupies at least 2/3 of the picture. It is recommended that images be stored in Tencent Cloud to ensure higher download speed and stability.
        /// </summary>
        [JsonProperty("BackImageUrl")]
        public string BackImageUrl{ get; set; }

        /// <summary>
        /// Picture switch. The default is false, and the base64 encoding of the avatar photo is not returned. When set to true, the base64 encoding of the portrait photo is returned.
        /// </summary>
        [JsonProperty("CropPortrait")]
        public bool? CropPortrait{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "BackImageBase64", this.BackImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "BackImageUrl", this.BackImageUrl);
            this.SetParamSimple(map, prefix + "CropPortrait", this.CropPortrait);
        }
    }
}

