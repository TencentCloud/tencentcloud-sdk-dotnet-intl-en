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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateConfigRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Trigger types, supporting up to two types.</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public TriggerType[] TriggerType{ get; set; }

        /// <summary>
        /// <p>Risk level. Valid values:<br>1: high-risk<br>2: medium-risk<br>3: low risk</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// <p>Rule ID.</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>rule name</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Input parameters.</p>
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// <p>Description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Rule evaluation region scope. The rule only applies to resources in specified regions. Supported regions are those returned by config:ListResourceRegions.</p>
        /// </summary>
        [JsonProperty("RegionsScope")]
        public string[] RegionsScope{ get; set; }

        /// <summary>
        /// <p>Rule evaluation tag scope. The rule only applies to resources bound with specified tags.</p>
        /// </summary>
        [JsonProperty("TagsScope")]
        public Tag[] TagsScope{ get; set; }

        /// <summary>
        /// <p>The rule is invalid for the specified resource ID, meaning that evaluation will not be performed on this resource.</p>
        /// </summary>
        [JsonProperty("ExcludeResourceIdsScope")]
        public string[] ExcludeResourceIdsScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TriggerType.", this.TriggerType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "RegionsScope.", this.RegionsScope);
            this.SetParamArrayObj(map, prefix + "TagsScope.", this.TagsScope);
            this.SetParamArraySimple(map, prefix + "ExcludeResourceIdsScope.", this.ExcludeResourceIdsScope);
        }
    }
}

