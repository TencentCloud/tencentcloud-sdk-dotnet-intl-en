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

    public class LLMDetectionResultItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Detection category.</p><p>Enumeration value:</p><ul><li>AIGCQualityCharacteristics: AIGC quality characteristics.</li></ul>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>Detection group.</p><p>Enumeration values:</p><ul><li>AIGCAuthenticity: AIGC authenticity, including human body plausibility, physical plausibility, and cross-frame consistency.</li><li>AIGCTechQuality: AIGC technology quality, including aspect ratio, black border, and forced portrait mode.</li></ul>
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// <p>Detection type name.</p><p>Enumeration values:</p><ul><li>BodyPoseCheck: Human body pose plausibility, which belongs to AIGCAuthenticity.</li><li>BodyDetailCheck: Human body detail plausibility, including finger count and facial symmetry, which belongs to AIGCAuthenticity.</li><li>PhysicRulesCheck: Physics rules plausibility, including perspective, lighting, and gravity, which belongs to AIGCAuthenticity.</li><li>ObjectConsistencyCheck: Cross-frame object consistency, which belongs to AIGCAuthenticity.</li><li>FormatCheck: Aspect ratio, black border, forced portrait mode, and other format issues, which belong to AIGCTechQuality.</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Overall quality score. Value range: [0, 100]. Higher values indicate better quality.</p>
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// <p>Detection confidence. Value range: [0, 100]. Higher values indicate greater certainty.</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// <p>List of issues detected. This is empty if no issue is detected.</p>
        /// </summary>
        [JsonProperty("IssueSet")]
        public LLMDetectionIssue[] IssueSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "IssueSet.", this.IssueSet);
        }
    }
}

