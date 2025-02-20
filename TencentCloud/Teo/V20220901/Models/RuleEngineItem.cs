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

    public class RuleEngineItem : AbstractModel
    {
        
        /// <summary>
        /// Rule status. values: <li>`enable`: enabled</li> <li>`disable`: disabled</li>.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Rule id. a unique identifier for the rule. this parameter is required when calling `modifyl7accrules`.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Rule name. name length limit: 255 characters.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule annotation. multiple annotations can be added.
        /// </summary>
        [JsonProperty("Description")]
        public string[] Description{ get; set; }

        /// <summary>
        /// Sub-Rule branch. this list currently supports filling in only one rule; multiple entries are invalid.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Branches")]
        public RuleBranch[] Branches{ get; set; }

        /// <summary>
        /// Rule priority. only used as an output parameter.
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
            this.SetParamArrayObj(map, prefix + "Branches.", this.Branches);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
        }
    }
}

