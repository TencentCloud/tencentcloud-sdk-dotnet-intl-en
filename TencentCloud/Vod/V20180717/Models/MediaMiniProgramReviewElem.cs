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

    public class MediaMiniProgramReviewElem : AbstractModel
    {
        
        /// <summary>
        /// Audit type. 
        /// <li>Porn: porn image,</li>
        /// <li>Porn.Ocr: porn text,</li>
        /// <li>Porn.Asr: porn speech,</li>
        /// <li>Terrorism: terrorism image,</li>
        /// <li>Political: politically sensitive image,</li>
        /// <li>Political.Ocr: politically sensitive text</li>
        /// <li>Political.Asr: politically sensitive speech</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Audit suggestion.
        /// <li>pass: normal,</li>
        /// <li>block: violating,</li>
        /// <li>review: suspected of violation.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Confidence of audit result between 0 and 100.
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

