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

    public class RecognizeGeneralCardVerificationRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64 value of the front document image. Supported formats: PNG, JPG, JPEG. The Base64 encoded size shall not exceed 7 MB. One of ImageUrl, ImageBase64, BackImageUrl, BackImageBase64 must be provided. If both URL and Base64 are passed, URL will be used preferentially. Image download timeout is 3 seconds.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// URL address of the front side image of the card. Refer to the description of ImageBase64 for image requirements.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Base64-encoded value of the back side image of the card. Refer to the description of ImageBase64 for image requirements.
        /// </summary>
        [JsonProperty("BackImageBase64")]
        public string BackImageBase64{ get; set; }

        /// <summary>
        /// URL address of the back side image of the card. Refer to the description of ImageBase64 for image requirements.
        /// </summary>
        [JsonProperty("BackImageUrl")]
        public string BackImageUrl{ get; set; }

        /// <summary>
        /// Specifies the target document type for this verification. Each element is a full card type enum in the format {CountryOrRegionCode}_{CardType}, such as THA_ID_CARD and PHL_UMID. For passports, use the single value PASSPORT regardless of the issuing country. Wildcards are supported: * indicates all supported card types, and {CountryCode}_* indicates all card types of a country/region, such as PHL_*. If this parameter is not specified or an empty array is passed, the server performs automatic classification across all supported card types. An unsupported card type returns InvalidParameterValueLimit, and the unsupported values are listed in the error message.
        /// </summary>
        [JsonProperty("CardTypes")]
        public string[] CardTypes{ get; set; }

        /// <summary>
        /// Whether to return the Base64-encoded portrait image of the card. Default: false.
        /// </summary>
        [JsonProperty("ReturnHeadImage")]
        public bool? ReturnHeadImage{ get; set; }

        /// <summary>
        /// Card verification configuration.
        /// </summary>
        [JsonProperty("VerificationConfig")]
        public CardVerificationConfig VerificationConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "BackImageBase64", this.BackImageBase64);
            this.SetParamSimple(map, prefix + "BackImageUrl", this.BackImageUrl);
            this.SetParamArraySimple(map, prefix + "CardTypes.", this.CardTypes);
            this.SetParamSimple(map, prefix + "ReturnHeadImage", this.ReturnHeadImage);
            this.SetParamObj(map, prefix + "VerificationConfig.", this.VerificationConfig);
        }
    }
}

