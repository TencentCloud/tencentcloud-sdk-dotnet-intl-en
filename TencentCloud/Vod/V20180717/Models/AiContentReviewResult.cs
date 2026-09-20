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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// <li>Porn: whether image recognition involves offensive content</li>
        /// <li>Terrorism: image recognition of whether unsafe information is involved</li>
        /// <li>Political: Whether image recognition involves inappropriate information</li>
        /// <li>Porn.Asr: ASR text (text in audio) authentication for whether it involves offensive content</li>
        /// <li>Porn.Ocr: whether Ocr text identification involves offensive content</li>
        /// <li>Political.Asr: ASR text (text in audio) authentication for whether it involves inappropriate information</li>
        /// <li>Political.Ocr: Ocr text identification, whether it involves inappropriate information</li>
        /// <li>Terrorism.Ocr: whether Ocr text identification involves unsafe information</li>
        /// <li>Prohibited.Asr: Prohibited information recognition in ASR text (text in audio)</li>
        /// <li>Prohibited.Ocr: OCR text prohibited information recognition</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (frames involving offensive content). Valid when the task type is Porn.
        /// </summary>
        [JsonProperty("PornTask")]
        public AiReviewTaskPornResult PornTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (visuals involve unsafe information). Valid when the task type is Terrorism.
        /// </summary>
        [JsonProperty("TerrorismTask")]
        public AiReviewTaskTerrorismResult TerrorismTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (frames involving inappropriate information). Valid when the task type is Political.
        /// </summary>
        [JsonProperty("PoliticalTask")]
        public AiReviewTaskPoliticalResult PoliticalTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (ASR text involves offensive content). Valid when the task type is Porn.Asr.
        /// </summary>
        [JsonProperty("PornAsrTask")]
        public AiReviewTaskPornAsrResult PornAsrTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (OCR text involving offensive content). Valid when the task type is Porn.Ocr.
        /// </summary>
        [JsonProperty("PornOcrTask")]
        public AiReviewTaskPornOcrResult PornOcrTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (ASR text involving inappropriate information). Valid when the task type is Political.Asr.
        /// </summary>
        [JsonProperty("PoliticalAsrTask")]
        public AiReviewTaskPoliticalAsrResult PoliticalAsrTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (OCR text involves inappropriate information). Valid when the task type is Political.Ocr.
        /// </summary>
        [JsonProperty("PoliticalOcrTask")]
        public AiReviewTaskPoliticalOcrResult PoliticalOcrTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation task (OCR text involving unsafe information). Valid when the task type is Terrorism.Ocr.
        /// </summary>
        [JsonProperty("TerrorismOcrTask")]
        public AiReviewTaskTerrorismOcrResult TerrorismOcrTask{ get; set; }

        /// <summary>
        /// Query result of a video audio/video moderation OCR text prohibited task. Valid when the task type is Prohibited.Ocr.
        /// </summary>
        [JsonProperty("ProhibitedOcrTask")]
        public AiReviewTaskProhibitedOcrResult ProhibitedOcrTask{ get; set; }

        /// <summary>
        /// Query result of the ASR text prohibited moderation task for video and audio. Valid when the task type is Prohibited.Asr.
        /// </summary>
        [JsonProperty("ProhibitedAsrTask")]
        public AiReviewTaskProhibitedAsrResult ProhibitedAsrTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamObj(map, prefix + "ProhibitedOcrTask.", this.ProhibitedOcrTask);
            this.SetParamObj(map, prefix + "ProhibitedAsrTask.", this.ProhibitedAsrTask);
        }
    }
}

