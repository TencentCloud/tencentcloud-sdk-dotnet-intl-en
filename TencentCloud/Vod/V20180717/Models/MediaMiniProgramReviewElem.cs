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

    public class MediaMiniProgramReviewElem : AbstractModel
    {
        
        /// <summary>
        /// Audio and video moderation type. 
        /// <li>Porn: The visual involves offensive content,</li>
        /// <li>Porn.Ocr: The text involves offensive content,</li>
        /// <li>Porn.Asr: Sound involves offensive content,</li>
        /// <li>Terrorism: The visual involves unsafe information,</li>
        /// <li>Political: The visual involves inappropriate information,</li>
        /// <li>Political.Ocr: The text involves inappropriate information,</li>
        /// <li>Political.Asr: The sound involves inappropriate information.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Audio/video moderation feedback.
        /// <li>pass: confirm normal,</li>
        /// <li>block: confirmed violation,</li>
        /// <li>review: suspected violation.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Confidence of the audio/video moderation result. Value range: 0-100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

