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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagedRules : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether managed rules are enabled. Valid values: <li>on: enabled. All managed rules take effect as configured.</li><li>off: disabled. No managed rules take effect.</li></p>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// <p>Whether evaluation mode is enabled. This parameter is valid only when the `Enabled` parameter is set to `on`. Valid values: <li>on: enabled. All managed rules take effect in observation mode.</li><li>off: disabled. All managed rules take effect as configured.</li></p>
        /// </summary>
        [JsonProperty("DetectionOnly")]
        public string DetectionOnly{ get; set; }

        /// <summary>
        /// <p>Whether the deep analysis option for managed rules is enabled. This parameter is valid only when the `Enabled` parameter is set to `on`. Valid values: <li>on: enabled. Requests are processed after deep analysis.</li><li>off: disabled. Requests are processed directly without deep analysis.</li> <br>This parameter is to be deprecated. The switch for deep analysis rules is migrated to the `SemanticAnalysisRules.Enabled` parameter.</p>
        /// </summary>
        [JsonProperty("SemanticAnalysis")]
        public string SemanticAnalysis{ get; set; }

        /// <summary>
        /// <p>Deep analysis configuration option. Identifies malicious behaviors in requests (such as SQL injection and XSS attacks), and logs and blocks malicious requests.</p>
        /// </summary>
        [JsonProperty("SemanticAnalysisRules")]
        public SemanticAnalysisRules SemanticAnalysisRules{ get; set; }

        /// <summary>
        /// <p>Auto-update option for managed rules.</p>
        /// </summary>
        [JsonProperty("AutoUpdate")]
        public ManagedRuleAutoUpdate AutoUpdate{ get; set; }

        /// <summary>
        /// <p>Configuration of managed rule groups. If an empty array is passed for this structure or `GroupId` is not included in the list, the default processing method is used.</p>
        /// </summary>
        [JsonProperty("ManagedRuleGroups")]
        public ManagedRuleGroup[] ManagedRuleGroups{ get; set; }

        /// <summary>
        /// <p>High-frequency scan protection configuration option. When a visitor's requests frequently trigger managed rules configured as block, all requests from this visitor are blocked for a period of time.</p>
        /// </summary>
        [JsonProperty("FrequentScanningProtection")]
        public FrequentScanningProtection FrequentScanningProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DetectionOnly", this.DetectionOnly);
            this.SetParamSimple(map, prefix + "SemanticAnalysis", this.SemanticAnalysis);
            this.SetParamObj(map, prefix + "SemanticAnalysisRules.", this.SemanticAnalysisRules);
            this.SetParamObj(map, prefix + "AutoUpdate.", this.AutoUpdate);
            this.SetParamArrayObj(map, prefix + "ManagedRuleGroups.", this.ManagedRuleGroups);
            this.SetParamObj(map, prefix + "FrequentScanningProtection.", this.FrequentScanningProtection);
        }
    }
}

