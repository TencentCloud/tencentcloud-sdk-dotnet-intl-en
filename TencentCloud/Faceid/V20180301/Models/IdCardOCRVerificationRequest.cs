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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IdCardOCRVerificationRequest : AbstractModel
    {
        
        /// <summary>
        /// Identity card number.
        /// -Name, identity card number, ImageBase64, or ImageUrl must provide one of the three.
        /// -If both are provided, proceed to use parameters according to the priority of name and identity card number > ImageBase64 > ImageUrl.
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Base64 value of the ID card portrait side.
        /// -Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported.
        /// -Supported image size: The downloaded image after Base64 encoding is no more than 3M. Please use the standard Base64 encoding method (with = padding). Refer to RFC4648 for the coding specification.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Url of the ID card portrait side.
        /// -Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported.
        /// -Supported image size: The downloaded image is no more than 3M after Base64 encoding. Image download time is no more than 3 seconds.
        /// -Images stored on Tencent Cloud's Url guarantee higher download speed and stability. It is advisable to store images on Tencent Cloud.
        /// -The speed and stability of non-Tencent Cloud Storage URLs may be impacted.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Sensitive data encryption info.
        /// -Users with encryption requirements for incoming information (name, identity card number) can use this parameter. For details, please click the left-side link.
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

