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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamAiReviewVoicePornResult : AbstractModel
    {
        
        /// <summary>
        /// Start PTS time of a suspected segment in seconds.
        /// </summary>
        [JsonProperty("StartPtsTime")]
        public float? StartPtsTime{ get; set; }

        /// <summary>
        /// End PTS time of a suspected segment in seconds.
        /// </summary>
        [JsonProperty("EndPtsTime")]
        public float? EndPtsTime{ get; set; }

        /// <summary>
        /// Score of a suspected porn segment.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Suggestion for porn information detection of a suspected segment. Valid values:
        /// <li>pass</li>
        /// <li>review</li>
        /// <li>block</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Tag of the detected porn information in video. Valid values:
        /// <li>sexual_moan: Sexual moans.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartPtsTime", this.StartPtsTime);
            this.SetParamSimple(map, prefix + "EndPtsTime", this.EndPtsTime);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
        }
    }
}

