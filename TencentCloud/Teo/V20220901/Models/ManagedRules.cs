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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagedRules : AbstractModel
    {
        
        /// <summary>
        /// The managed rule status. Values: <li>`on`: enabled, all managed rules take effect as configured;</li> <li>`off`: disabled, all managed rules do not take effect.</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Evaluation mode is enabled or not, it is valid only when the `Enabled` parameter is set to `on`. Values: <li>`on`: enabled, all managed rules take effect in `observe` mode.</li> <li>off: disabled, all managed rules take effect according to the specified configuration.</li>.
        /// </summary>
        [JsonProperty("DetectionOnly")]
        public string DetectionOnly{ get; set; }

        /// <summary>
        /// Managed rule semantic analysis is enabled or not, it is valid only when the `Enabled` parameter is `on`. Values: <li>`on`: enabled, perform semantic analysis  before processing requests;</li> <li>`off`: disabled, process requests directly without semantic analysis.</li> <br/>The default value is `off`.
        /// </summary>
        [JsonProperty("SemanticAnalysis")]
        public string SemanticAnalysis{ get; set; }

        /// <summary>
        /// Managed rule automatic update option.
        /// </summary>
        [JsonProperty("AutoUpdate")]
        public ManagedRuleAutoUpdate AutoUpdate{ get; set; }

        /// <summary>
        /// Configuration of the managed rule group. If this structure is passed as an empty array or the GroupId is not included in the array, it will be processed based by default.
        /// </summary>
        [JsonProperty("ManagedRuleGroups")]
        public ManagedRuleGroup[] ManagedRuleGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DetectionOnly", this.DetectionOnly);
            this.SetParamSimple(map, prefix + "SemanticAnalysis", this.SemanticAnalysis);
            this.SetParamObj(map, prefix + "AutoUpdate.", this.AutoUpdate);
            this.SetParamArrayObj(map, prefix + "ManagedRuleGroups.", this.ManagedRuleGroups);
        }
    }
}

