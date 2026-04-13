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

    public class FunctionRule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Rule condition list. There is an OR relationship between items in the list.
        /// </summary>
        [JsonProperty("FunctionRuleConditions")]
        public FunctionRuleCondition[] FunctionRuleConditions{ get; set; }

        /// <summary>
        /// Function selection configuration type.
        /// <Li>Direct: specifies the execution function directly.</li>.
        /// <Li>Weight: selects the function based on weight ratio.</li>.
        /// <li> region: specifies the country/region selection function based on client IP.</li>.
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// Specifies the function ID to be executed. valid only when TriggerType is direct.
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// Specifies the name of the function executed.
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Function selection configuration based on client IP country/region.
        /// </summary>
        [JsonProperty("RegionMappingSelections")]
        public FunctionRegionSelection[] RegionMappingSelections{ get; set; }

        /// <summary>
        /// Describes the function selection configuration based on weight.
        /// </summary>
        [JsonProperty("WeightedSelections")]
        public FunctionWeightedSelection[] WeightedSelections{ get; set; }

        /// <summary>
        /// Priority of a trigger rule for a function. The larger the value, the higher the priority.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Rule description.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time, which adopts Coordinated Universal Time (UTC) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time, which adopts Coordinated Universal Time (UTC) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "FunctionRuleConditions.", this.FunctionRuleConditions);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamArrayObj(map, prefix + "RegionMappingSelections.", this.RegionMappingSelections);
            this.SetParamArrayObj(map, prefix + "WeightedSelections.", this.WeightedSelections);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

