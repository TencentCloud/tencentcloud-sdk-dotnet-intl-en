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

    public class RuleEngineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule status. Valid values: <li> enable: Enable; </li><li> disable: Disabled.</li></p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Rule ID. The unique identifier of a rule. This parameter is required when calling ModifyL7AccRule.</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Rule name. The name can contain no more than 255 characters.</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Rule note. Multiple notes can be filled.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string[] Description{ get; set; }

        /// <summary>
        /// <p>List of rule-level custom variables. CustomVariable.Name requires the use of user.rule. as a prefix. Variables are initialized sequentially in the array order. InitialValue supports referencing site-level custom variables and rule-level custom variables before the current variable. It does not support referencing the current variable itself or rule-level custom variables after it. Site-level custom variables can be queried through the DescribeZoneCustomVariables API. When Branches is empty, CustomVariable cannot be filled in, and any entry is invalid.</p>
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>Operation details of rule-level custom variables. You can reference site-level custom variables and rule-level custom variables defined in the current rule during operations. Site-level custom variables can be queried through the DescribeZoneCustomVariables API. This list currently only supports filling in one rule; additional entries are invalid. When Branches is empty, CustomVariableOperations is not allowed to be filled in, and any entry will be invalid.</p>
        /// </summary>
        [JsonProperty("CustomVariableOperations")]
        public CustomVariableOperation[] CustomVariableOperations{ get; set; }

        /// <summary>
        /// <p>Sub-rule branch. This list currently only supports filling in one rule. Additional rules are invalid.</p>
        /// </summary>
        [JsonProperty("Branches")]
        public RuleBranch[] Branches{ get; set; }

        /// <summary>
        /// <p>Rule priority. Output only.</p>
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArraySimple(map, prefix + "Description.", this.Description);
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamArrayObj(map, prefix + "CustomVariableOperations.", this.CustomVariableOperations);
            this.SetParamArrayObj(map, prefix + "Branches.", this.Branches);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
        }
    }
}

