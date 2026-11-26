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

    public class ConfigGroupRuleEngineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule name. The name must be no more than 255 characters.</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Rule note. Multiple notes can be filled.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string[] Description{ get; set; }

        /// <summary>
        /// <p>Sub-rule branch. This list currently only supports filling in one rule. Additional entries are invalid.</p>
        /// </summary>
        [JsonProperty("Branches")]
        public RuleBranch[] Branches{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArraySimple(map, prefix + "Description.", this.Description);
            this.SetParamArrayObj(map, prefix + "Branches.", this.Branches);
        }
    }
}

