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

    public class IDCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64-encoded value of an image. The image cannot exceed 7 MB after being Base64-encoded. A resolution above 500 x 800 is recommended. PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupy more than 2/3 area of the image.
        /// Either `ImageUrl` or `ImageBase64` of the image must be provided. If both are provided, `ImageUrl` is used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The URL of the image. The image cannot exceed 7 MB after being Base64-encoded. A resolution above 500 x 800 is recommended. PNG, JPG, JPEG, and BMP formats are supported. It is recommended that the card part occupy more than 2/3 area of the image.
        /// We recommend that you store the image in Tencent Cloud for higher download speed and stability.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// `FRONT`: The side with the profile photo.
        /// `BACK`: The side with the national emblem.
        /// If this parameter is not specified, the system will automatically determine the ID card side.
        /// </summary>
        [JsonProperty("CardSide")]
        public string CardSide{ get; set; }

        /// <summary>
        /// The following parameters are all of `bool` type and default to `false`:
        /// `CropIdCard`: Crops the ID card photo (by removing extra edges outside the ID card and automatically correcting the shooting angle).
        /// `CropPortrait`: Crops the profile photo (by automatically cutting out the face area in the ID card).
        /// `CopyWarn`: Warns about photocopied images.
        /// `BorderCheckWarn`: Warns about border and frame occlusions.
        /// `ReshootWarn`: Warns about spoofed images.
        /// `DetectPsWarn`: Warns about photoshopped images.
        /// `TempIdWarn`: Warns about temporary ID cards.
        /// `InvalidDateWarn`: Warns about invalid ID card validity periods.
        /// `Quality`: Gets the image quality score (by evaluating the blurriness of the image).
        /// `MultiCardDetect`: Enables multi-card detection.
        /// `ReflectWarn`: Enables glare detection.
        /// 
        /// Parameter setting method via SDK:
        /// Config = Json.stringify({"CropIdCard":true,"CropPortrait":true})
        /// Parameter setting method via API 3.0 Explorer:
        /// Config = {"CropIdCard":true,"CropPortrait":true}
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "CardSide", this.CardSide);
            this.SetParamSimple(map, prefix + "Config", this.Config);
        }
    }
}

