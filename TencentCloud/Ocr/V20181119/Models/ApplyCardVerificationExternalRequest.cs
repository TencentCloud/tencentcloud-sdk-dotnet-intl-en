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

    public class ApplyCardVerificationExternalRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the country of the document.
        /// ARG:Argentina
        /// AUS:Australia
        /// KHM:Cambodia
        /// CAN:Canada
        /// SGP:Singapore
        /// CHL:Chile
        /// DEU:Germany
        /// MEX:Mexico
        /// MMR:Myanmar
        /// NZL:New Zealand
        /// BGD:Bangladesh
        /// NGA:Nigeria
        /// PAK:Pakistan
        /// RUS:Russia
        /// IDN:Indonesia
        /// HKG:Hong Kong, China
        /// THA:Thailand
        /// MYS:Malaysia
        /// JPN:Japan
        /// PHL:Philippines
        /// MAC:Macao, China
        /// CHN:ChinaPermit
        /// TWN:Taiwan, China
        /// BGD:Bangladesh
        /// NGA:Nigeria 
        /// PAK:Pakistan
        /// 
        /// AUTO: supports cards and documents from 200+ countries
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Document type.
        /// ID_CARD
        /// PASSPORT
        /// DRIVING_LICENSE
        /// RESIDENCE_PERMIT (Supported in certain countries/regions, including Australia, Canada, Germany, New Zealand, Nigeria, Singapore).
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// The Base64 value of the document Front. supported image formats: PNG, JPG/JPEG. 
        /// Supported image size: the downloaded image after Base64 encoding must be no more than 2M. image download time must be no more than 5 seconds. 
        /// Supported image resolution: between 256 \* 256 and 4096 \* 4096. For some documents, either ImageUrlBack or ImageBase64Back must be provided. If both are provided, only ImageUrlFront will be used.
        /// </summary>
        [JsonProperty("ImageBase64Front")]
        public string ImageBase64Front{ get; set; }

        /// <summary>
        /// The Base64 value of the reverse side of the document. Supported image formats: PNG, JPG/JPEG. 
        /// Supported image size: the downloaded image after Base64 encoding must be no more than 2M. image download time must be no more than 5 seconds. 
        /// Supported image resolution: between 256 \* 256 and 4096 \* 4096. For some documents, either ImageUrlBack or ImageBase64Back must be provided. If both are provided, only ImageUrlBack is used.
        /// </summary>
        [JsonProperty("ImageBase64Back")]
        public string ImageBase64Back{ get; set; }

        /// <summary>
        /// Url of the document Front. supported image formats: PNG, JPG/JPEG. 
        /// Supported image size: the downloaded image after Base64 encoding must be no more than 2M. image download time must be no more than 5 seconds. 
        /// Supported image resolution: between 256 \* 256 and 4096 \* 4096. For some documents, either ImageUrlBack or ImageBase64Back must be provided. If both are provided, only ImageUrlFront will be used.
        /// </summary>
        [JsonProperty("ImageUrlFront")]
        public string ImageUrlFront{ get; set; }

        /// <summary>
        /// Specifies the Url of the document Back. supported image formats: PNG, JPG/JPEG
        /// Supported image size: no more than 2M after Base64 encoding. image download time should not exceed 5 seconds. 
        /// Supported image resolution: between 256 \* 256 and 4096 \* 4096. For some documents, either ImageUrlBack or ImageBase64Back must be provided. If both are provided, only use ImageUrlBack.
        /// </summary>
        [JsonProperty("ImageUrlBack")]
        public string ImageUrlBack{ get; set; }

        /// <summary>
        /// Whether to extract the ID portrait. Default value: false.
        /// </summary>
        [JsonProperty("ReturnHeadImage")]
        public bool? ReturnHeadImage{ get; set; }


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
            this.SetParamSimple(map, prefix + "ReturnHeadImage", this.ReturnHeadImage);
        }
    }
}

