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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmIdentifyComplianceRuleRelation : AbstractModel
    {
        
        /// <summary>
        /// <p>Data item ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// <p>Data item name.</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Level ID</p>
        /// </summary>
        [JsonProperty("LevelId")]
        public ulong? LevelId{ get; set; }

        /// <summary>
        /// <p>Level name</p>
        /// </summary>
        [JsonProperty("LevelName")]
        public string LevelName{ get; set; }

        /// <summary>
        /// <p>Level</p><p>Unit: score</p>
        /// </summary>
        [JsonProperty("LevelScore")]
        public ulong? LevelScore{ get; set; }

        /// <summary>
        /// <p>Structured rule status</p><p>Enumeration values:</p><ul><li>0: Unconfigured</li><li>1: Configured</li></ul>
        /// </summary>
        [JsonProperty("StructuredStatus")]
        public ulong? StructuredStatus{ get; set; }

        /// <summary>
        /// <p>Unstructured rule status</p><p>Enumeration values:</p><ul><li>0: no configuration</li><li>1: configured</li></ul>
        /// </summary>
        [JsonProperty("UnStructuredStatus")]
        public ulong? UnStructuredStatus{ get; set; }

        /// <summary>
        /// <p>Data item status</p><p>Enumeration values:</p><ul><li>0: Not enabled</li><li>1: Enabled</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "LevelName", this.LevelName);
            this.SetParamSimple(map, prefix + "LevelScore", this.LevelScore);
            this.SetParamSimple(map, prefix + "StructuredStatus", this.StructuredStatus);
            this.SetParamSimple(map, prefix + "UnStructuredStatus", this.UnStructuredStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

