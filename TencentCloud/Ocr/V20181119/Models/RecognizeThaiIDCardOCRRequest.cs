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

    public class RecognizeThaiIDCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64-encoded value of an image. The image cannot exceed 7 MB after being Base64-encoded. A resolution above 500 x 800 is recommended. PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupy more than 2/3 area of the image.
        /// Either `ImageUrl` or `ImageBase64` of the image must be provided. If both are provided, `ImageUrl` is used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Base64 value of the image on the back of the card. Supported image formats: PNG, JPG, JPEG. GIF format is not supported yet. Supported image size: The downloaded image does not exceed 7M after Base64 encoding. The image download takes no more than 3 seconds. One of ImageUrl and ImageBase64 of the image must be provided. If both are provided, only ImageUrl will be used.
        /// </summary>
        [JsonProperty("BackImageBase64")]
        public string BackImageBase64{ get; set; }

        /// <summary>
        /// The URL of the image. The image cannot exceed 7 MB after being Base64-encoded. A resolution above 500 x 800 is recommended. PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupy more than 2/3 area of the image.
        /// We recommend that you store the image in Tencent Cloud for higher download speed and stability.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The URL address of the image on the back of the card. Supported image formats: PNG, JPG, JPEG. GIF format is not supported yet. Supported image size: The downloaded image does not exceed 7M after Base64 encoding. The image download takes no more than 3 seconds. Storing images in Tencent Cloud URLs can ensure higher download speed and stability. It is recommended that images be stored in Tencent Cloud. The URL speed and stability of non-Tencent cloud storage may be affected to a certain extent.
        /// </summary>
        [JsonProperty("BackImageUrl")]
        public string BackImageUrl{ get; set; }

        /// <summary>
        /// Whether to crop the profile photo. The default value is `false`, meaning not to return the Base64-encoded value of the profile photo on the Thai identity card.
        /// When this parameter is set to `true`, the Base64-encoded value of the profile photo on the Thai identity card after rotation correction is returned.
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

