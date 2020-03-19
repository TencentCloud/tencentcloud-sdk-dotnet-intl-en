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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// <li>Porn: porn information detection in image</li>
        /// <li>Terrorism: terrorism information detection in image</li>
        /// <li>Political: politically sensitive information detection in image</li>
        /// <li>Porn.Asr: ASR-based porn information detection in speech</li>
        /// <li>Porn.Ocr: OCR-based porn information detection in text</li>
        /// <li>Political.Asr: ASR-based politically sensitive information detection in speech</li>
        /// <li>Political.Ocr: OCR-based politically sensitive information detection in text</li>
        /// <li>Terrorism.Ocr: OCR-based terrorism information in text</li>
        /// <li>Prohibited.Asr: ASR-based prohibited information detection in speech</li>
        /// <li>Prohibited.Ocr: OCR-based prohibited information detection in text</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Query result of intelligent porn information detection in video image task in video content audit, which is valid when task type is `Porn`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PornTask")]
        public AiReviewTaskPornResult PornTask{ get; set; }

        /// <summary>
        /// Query result of intelligent terrorism information detection in video image task in video content audit, which is valid when task type is `Terrorism`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TerrorismTask")]
        public AiReviewTaskTerrorismResult TerrorismTask{ get; set; }

        /// <summary>
        /// Query result of intelligent politically sensitive information detection in video image task in video content audit, which is valid when task type is `Political`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PoliticalTask")]
        public AiReviewTaskPoliticalResult PoliticalTask{ get; set; }

        /// <summary>
        /// Query result of ASR-based porn information detection in speech task in video content audit, which is valid when task type is `Porn.Asr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PornAsrTask")]
        public AiReviewTaskPornAsrResult PornAsrTask{ get; set; }

        /// <summary>
        /// Query result of OCR-based porn information detection in text task in video content audit, which is valid when task type is `Porn.Ocr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PornOcrTask")]
        public AiReviewTaskPornOcrResult PornOcrTask{ get; set; }

        /// <summary>
        /// Query result of ASR-based politically sensitive information detection in speech task in video content audit, which is valid when task type is `Political.Asr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PoliticalAsrTask")]
        public AiReviewTaskPoliticalAsrResult PoliticalAsrTask{ get; set; }

        /// <summary>
        /// Query result of OCR-based politically sensitive information detection in text task in video content audit, which is valid when task type is `Political.Ocr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PoliticalOcrTask")]
        public AiReviewTaskPoliticalOcrResult PoliticalOcrTask{ get; set; }

        /// <summary>
        /// Query result of OCR-based terrorism information detection in text task in video content audit, which is valid when task type is `Terrorism.Ocr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TerrorismOcrTask")]
        public AiReviewTaskTerrorismOcrResult TerrorismOcrTask{ get; set; }

        /// <summary>
        /// Query result of ASR-based prohibited information detection in speech task in video content audit, which is valid when task type is `Prohibited.Asr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProhibitedAsrTask")]
        public AiReviewTaskProhibitedAsrResult ProhibitedAsrTask{ get; set; }

        /// <summary>
        /// Query result of OCR-based prohibited information detection in text task in video content audit, which is valid when task type is `Prohibited.Ocr`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProhibitedOcrTask")]
        public AiReviewTaskProhibitedOcrResult ProhibitedOcrTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PornTask.", this.PornTask);
            this.SetParamObj(map, prefix + "TerrorismTask.", this.TerrorismTask);
            this.SetParamObj(map, prefix + "PoliticalTask.", this.PoliticalTask);
            this.SetParamObj(map, prefix + "PornAsrTask.", this.PornAsrTask);
            this.SetParamObj(map, prefix + "PornOcrTask.", this.PornOcrTask);
            this.SetParamObj(map, prefix + "PoliticalAsrTask.", this.PoliticalAsrTask);
            this.SetParamObj(map, prefix + "PoliticalOcrTask.", this.PoliticalOcrTask);
            this.SetParamObj(map, prefix + "TerrorismOcrTask.", this.TerrorismOcrTask);
            this.SetParamObj(map, prefix + "ProhibitedAsrTask.", this.ProhibitedAsrTask);
            this.SetParamObj(map, prefix + "ProhibitedOcrTask.", this.ProhibitedOcrTask);
        }
    }
}

