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

    public class AiReviewTerrorismTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// The confidence score for the detection of sensitive information. Value range: 0-100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// The suggestion for handling the sensitive information detected. Valid values:
        /// <li>pass</li>
        /// <li>review</li>
        /// <li>block</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// The labels for the detected sensitive content. Valid values:
        /// <li>guns</li>
        /// <li>crowd</li>
        /// <li>police</li>
        /// <li>bloody</li>
        /// <li>banners (sensitive flags)</li>
        /// <li>militant</li>
        /// <li>explosion</li>
        /// <li>terrorists</li>
        /// <li>scenario (sensitive scenes) </li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// The video segments that contain sensitive information.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public MediaContentReviewSegmentItem[] SegmentSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
        }
    }
}

