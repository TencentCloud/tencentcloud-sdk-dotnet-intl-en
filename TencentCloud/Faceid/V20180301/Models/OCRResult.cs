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

    public class OCRResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether the identity authentication or OCR process is successful.</p>
        /// </summary>
        [JsonProperty("IsPass")]
        public bool? IsPass{ get; set; }

        /// <summary>
        /// <p>Base64 of the front image of the identity document</p>
        /// </summary>
        [JsonProperty("CardImageBase64")]
        public string CardImageBase64{ get; set; }

        /// <summary>
        /// <p>ID document recognition result</p>
        /// </summary>
        [JsonProperty("CardInfo")]
        [System.Obsolete]
        public CardInfo CardInfo{ get; set; }

        /// <summary>
        /// <p>ID document recognition result (when CheckMode value is 4, the OriginalCardInfo field is returned; in other scenarios, the current field is returned)</p>
        /// </summary>
        [JsonProperty("NormalCardInfo")]
        public NormalCardInfo NormalCardInfo{ get; set; }

        /// <summary>
        /// <p>Request id</p>
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// <p>Base64 of the front cropped image of the identity document</p>
        /// </summary>
        [JsonProperty("CardCutImageBase64")]
        public string CardCutImageBase64{ get; set; }

        /// <summary>
        /// <p>Base64 of the edge-cropped image of the back of an identity document</p>
        /// </summary>
        [JsonProperty("CardBackCutImageBase64")]
        public string CardBackCutImageBase64{ get; set; }

        /// <summary>
        /// <p>Alarm code</p><p>Enumeration value:</p><ul><li>-9101: alarm for incomplete document border</li><li>-9102: alarm for document photocopy</li><li>-9103: alarm for document rephotographing</li><li>-9104: document PS alarm</li><li>-9107: document reflective alarm</li><li>-9108: alarm for blurry document</li><li>-9109: alarm capability not enabled</li></ul>
        /// </summary>
        [JsonProperty("WarnCardInfos")]
        public long?[] WarnCardInfos{ get; set; }

        /// <summary>
        /// <p>Original document recognition information (when CheckMode value is 4, the current field will be returned)</p>
        /// </summary>
        [JsonProperty("OriginalCardInfo")]
        public string OriginalCardInfo{ get; set; }

        /// <summary>
        /// <p>Portrait matting in the document</p>
        /// </summary>
        [JsonProperty("HeadImageBase64")]
        public string HeadImageBase64{ get; set; }

        /// <summary>
        /// <p>Base64 of the back image of the identity document</p>
        /// </summary>
        [JsonProperty("CardBackImageBase64")]
        public string CardBackImageBase64{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamSimple(map, prefix + "CardImageBase64", this.CardImageBase64);
            this.SetParamObj(map, prefix + "CardInfo.", this.CardInfo);
            this.SetParamObj(map, prefix + "NormalCardInfo.", this.NormalCardInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "CardCutImageBase64", this.CardCutImageBase64);
            this.SetParamSimple(map, prefix + "CardBackCutImageBase64", this.CardBackCutImageBase64);
            this.SetParamArraySimple(map, prefix + "WarnCardInfos.", this.WarnCardInfos);
            this.SetParamSimple(map, prefix + "OriginalCardInfo", this.OriginalCardInfo);
            this.SetParamSimple(map, prefix + "HeadImageBase64", this.HeadImageBase64);
            this.SetParamSimple(map, prefix + "CardBackImageBase64", this.CardBackImageBase64);
        }
    }
}

