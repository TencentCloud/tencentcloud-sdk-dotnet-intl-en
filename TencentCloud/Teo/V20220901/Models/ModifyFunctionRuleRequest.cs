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

    public class ModifyFunctionRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Zone ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Rule ID. You can first use the DescribeFunctionRules API to get the RuleId of the rule that needs to be modified, then import the modified rule content. The original rule content will be overwritten.</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Rule condition list. There is an OR relationship between different conditions of the same trigger rule. If not specified, the original configuration is maintained.</p>
        /// </summary>
        [JsonProperty("FunctionRuleConditions")]
        public FunctionRuleCondition[] FunctionRuleConditions{ get; set; }

        /// <summary>
        /// <p>Function selection configuration type:</p><li> direct: directly specify the execution function;</li><li> weight: select a function based on weight ratio;</li><li> region: select a function based on the client IP country/region.</li>Defaults to direct if not specified.
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Specify the function ID to be executed. This parameter is valid only when TriggerType is direct or left empty.</p>
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// <p>Function selection configuration based on client IP country/region. This parameter is valid only when TriggerType is region, and RegionMappingSelections is required. RegionMappingSelections must contain one configuration with Regions as Default, and requires at least one other specific Region.</p>
        /// </summary>
        [JsonProperty("RegionMappingSelections")]
        public FunctionRegionSelection[] RegionMappingSelections{ get; set; }

        /// <summary>
        /// <p>Weight-based function selection configuration. This parameter is valid only when TriggerType is weight and WeightedSelections is required. The sum of all weights in WeightedSelections need to be 100.</p>
        /// </summary>
        [JsonProperty("WeightedSelections")]
        public FunctionWeightedSelection[] WeightedSelections{ get; set; }

        /// <summary>
        /// <p>Rule description, which can contain up to 60 characters. If this parameter is not input, the original configuration is maintained.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "FunctionRuleConditions.", this.FunctionRuleConditions);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "RegionMappingSelections.", this.RegionMappingSelections);
            this.SetParamArrayObj(map, prefix + "WeightedSelections.", this.WeightedSelections);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

