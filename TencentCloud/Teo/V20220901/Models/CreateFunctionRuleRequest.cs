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

    public class CreateFunctionRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Rule condition list. There is an OR relationship between different conditions of the same trigger rule.
        /// </summary>
        [JsonProperty("FunctionRuleConditions")]
        public FunctionRuleCondition[] FunctionRuleConditions{ get; set; }

        /// <summary>
        /// Function selection configuration type.
        /// <Li>Direct: specifies the execution function directly.</li>.
        /// <Li>Weight: selects the function based on weight ratio.</li>.
        /// <li> region: specifies the country/region selection function based on client IP.</li>.
        /// Specifies the default value as direct when left blank.
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// Specifies the function ID to be executed. this parameter is valid only when TriggerType is direct or left empty.
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// Function selection configuration based on client IP country/region. this parameter is valid only when TriggerType is region and RegionMappingSelections is required. RegionMappingSelections must include at least one configuration with Regions set to Default.
        /// </summary>
        [JsonProperty("RegionMappingSelections")]
        public FunctionRegionSelection[] RegionMappingSelections{ get; set; }

        /// <summary>
        /// Weighted function selection configuration. this parameter is valid only when TriggerType is weight and WeightedSelections is required. the sum of all weights in WeightedSelections need to be 100.
        /// </summary>
        [JsonProperty("WeightedSelections")]
        public FunctionWeightedSelection[] WeightedSelections{ get; set; }

        /// <summary>
        /// Rule description, which can contain up to 60 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "FunctionRuleConditions.", this.FunctionRuleConditions);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "RegionMappingSelections.", this.RegionMappingSelections);
            this.SetParamArrayObj(map, prefix + "WeightedSelections.", this.WeightedSelections);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

