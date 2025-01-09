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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyCardVerificationRequest : AbstractModel
    {
        
        /// <summary>
        /// Please select the country code of ID document.
        /// IDN: Indonesia
        /// HKG: Hong Kong
        /// THA: Thailand
        /// MYS: Malaysia
        /// SGP: Singapore
        /// JPN: Japan
        /// TWN:Taiwan
        /// BGD:Bangladesh 
        /// NGA:Nigeria
        /// PAK:Pakistan
        /// AUTO: Automatic Identification
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Please select the type of ID document. The supported options are:
        /// ID_CARD
        /// PASSPORT
        /// DRIVING_LICENSE
        /// AUTO
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// Base64 value for the front of the document. Supported image formats: PNG, JPEG. 
        /// GIF format is not supported yet. Supported image size: The downloaded image cannot exceed 5M after Base64 encoding.
        /// The image download takes no more than 3 seconds. Supported image resolution: 8000*8000. One of ImageUrlFront and ImageBase64 Front of the image must be provided. If both are provided, only ImageUrlFront will be used.
        /// </summary>
        [JsonProperty("ImageBase64Front")]
        public string ImageBase64Front{ get; set; }

        /// <summary>
        /// Base64 value of the reverse side of the document. Supported image formats: PNG, JPEG. 
        /// GIF format is not supported yet. Supported image size: The downloaded image cannot exceed 5M after Base64 encoding. The image download takes no more than 3 seconds. Maximum supported image resolution: 8000*8000. For some certificates, one of ImageUrlBack and ImageBase64Back must be provided. If both are provided, only ImageUrlBack will be used.
        /// </summary>
        [JsonProperty("ImageBase64Back")]
        public string ImageBase64Back{ get; set; }

        /// <summary>
        /// The URL value on the back of the certificate. Supported image formats: PNG, JPEG. 
        /// GIF format is not supported yet. Supported image size: The downloaded image cannot exceed 5M after Base64 encoding. The image download takes no more than 3 seconds. Maximum supported image resolution: 8000*8000. One of ImageUrlFront and ImageBase64Front of the image must be provided. If both are provided, only ImageUrlFront will be used.
        /// </summary>
        [JsonProperty("ImageUrlFront")]
        public string ImageUrlFront{ get; set; }

        /// <summary>
        /// The URL value on the back of the certificate. Supported image formats: PNG, JPEG. 
        /// GIF format is not supported yet. Supported image size: The downloaded image cannot exceed 5M after Base64 encoding. The image download takes no more than 3 seconds. Maximum supported image resolution: 8000*8000. For some certificates, one of ImageUrlBack and ImageBase64Back must be provided. If both are provided, only ImageUrlBack will be used.
        /// </summary>
        [JsonProperty("ImageUrlBack")]
        public string ImageUrlBack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "ImageBase64Front", this.ImageBase64Front);
            this.SetParamSimple(map, prefix + "ImageBase64Back", this.ImageBase64Back);
            this.SetParamSimple(map, prefix + "ImageUrlFront", this.ImageUrlFront);
            this.SetParamSimple(map, prefix + "ImageUrlBack", this.ImageUrlBack);
        }
    }
}

