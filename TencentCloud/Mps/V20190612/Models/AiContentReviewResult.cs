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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// <li>Porn: image porn detection.</li>
        /// <li>Terrorism: sensitive image</li>
        /// <li>Political: sensitive image</li>
        /// <li>Porn.Asr: ASR text-based porn detection</li>
        /// <li>Porn.Ocr: OCR text-based porn detection</li>
        /// <li>Political.Asr: ASR text sensitive</li>
        /// <li>Political.Ocr: OCR text sensitivity</li>
        /// <li>Terrorism.Ocr: OCR text sensitivity</li>
        /// <li>Prohibited.Asr: ASR text prohibited information recognition</li>
        /// <li>Prohibited.Ocr: OCR text prohibited information recognition</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Sampling frequency, i.e., the number of frames captured per second from the video for review.
        /// </summary>
        [JsonProperty("SampleRate")]
        public float? SampleRate{ get; set; }

        /// <summary>
        /// Video duration reviewed, in seconds.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Query result of the intelligent porn detection in image task for video content review. Valid when the task type is Porn.
        /// </summary>
        [JsonProperty("PornTask")]
        public AiReviewTaskPornResult PornTask{ get; set; }

        /// <summary>
        /// Query result of sensitive tasks for intelligent screen in video content review. Valid when the task type is `Terrorism`.
        /// </summary>
        [JsonProperty("TerrorismTask")]
        public AiReviewTaskTerrorismResult TerrorismTask{ get; set; }

        /// <summary>
        /// Query result of sensitive tasks for intelligent screen in video content review. Valid when the task type is Political.
        /// </summary>
        [JsonProperty("PoliticalTask")]
        public AiReviewTaskPoliticalResult PoliticalTask{ get; set; }

        /// <summary>
        /// Query result of the ASR text pornography detection task for video content review. Valid when TaskType is Porn.Asr.
        /// </summary>
        [JsonProperty("PornAsrTask")]
        public AiReviewTaskPornAsrResult PornAsrTask{ get; set; }

        /// <summary>
        /// Query result of the OCR text pornography detection task for video content review. Valid when the task type is Porn.Ocr.
        /// </summary>
        [JsonProperty("PornOcrTask")]
        public AiReviewTaskPornOcrResult PornOcrTask{ get; set; }

        /// <summary>
        /// Query result of the sensitive task for ASR text in video content review. Valid when the task type is Political.Asr.
        /// </summary>
        [JsonProperty("PoliticalAsrTask")]
        public AiReviewTaskPoliticalAsrResult PoliticalAsrTask{ get; set; }

        /// <summary>
        /// Query result of sensitive tasks for OCR text in video content review. Valid when the task type is Political.Ocr.
        /// </summary>
        [JsonProperty("PoliticalOcrTask")]
        public AiReviewTaskPoliticalOcrResult PoliticalOcrTask{ get; set; }

        /// <summary>
        /// Query result of the OCR text sensitive task for video content review. Valid when the task type is Terrorism.Ocr.
        /// </summary>
        [JsonProperty("TerrorismOcrTask")]
        public AiReviewTaskTerrorismOcrResult TerrorismOcrTask{ get; set; }

        /// <summary>
        /// Query result of the ASR text prohibited content detection task for video content review. Valid when TaskType is Prohibited.Asr.
        /// </summary>
        [JsonProperty("ProhibitedAsrTask")]
        public AiReviewTaskProhibitedAsrResult ProhibitedAsrTask{ get; set; }

        /// <summary>
        /// Query result of the OCR text prohibited content detection task for video content review. Valid when the task type is Prohibited.Ocr.
        /// </summary>
        [JsonProperty("ProhibitedOcrTask")]
        public AiReviewTaskProhibitedOcrResult ProhibitedOcrTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
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

