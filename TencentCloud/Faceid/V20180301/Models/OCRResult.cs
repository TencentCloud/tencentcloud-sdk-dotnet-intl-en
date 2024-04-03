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

    public class OCRResult : AbstractModel
    {
        
        /// <summary>
        /// Is the indentity verification or OCR process passed
        /// </summary>
        [JsonProperty("IsPass")]
        public bool? IsPass{ get; set; }

        /// <summary>
        /// The Base64 of ID card image
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CardImageBase64")]
        public string CardImageBase64{ get; set; }

        /// <summary>
        /// OCR result of the ID card.
        /// </summary>
        [JsonProperty("CardInfo")]
        public CardInfo CardInfo{ get; set; }

        /// <summary>
        /// The request id
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// Base64 of cropped image of ID card
        /// </summary>
        [JsonProperty("CardCutImageBase64")]
        public string CardCutImageBase64{ get; set; }

        /// <summary>
        /// Base64 of the cropped image on the reverse side of the ID card
        /// </summary>
        [JsonProperty("CardBackCutImageBase64")]
        public string CardBackCutImageBase64{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamSimple(map, prefix + "CardImageBase64", this.CardImageBase64);
            this.SetParamObj(map, prefix + "CardInfo.", this.CardInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "CardCutImageBase64", this.CardCutImageBase64);
            this.SetParamSimple(map, prefix + "CardBackCutImageBase64", this.CardBackCutImageBase64);
        }
    }
}

