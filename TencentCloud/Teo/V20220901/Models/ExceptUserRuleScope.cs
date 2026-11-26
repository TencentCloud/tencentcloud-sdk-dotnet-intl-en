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

    public class ExceptUserRuleScope : AbstractModel
    {
        
        /// <summary>
        /// Exception rule type. Among them, complete mode represents exceptions for full data, while partial mode represents selecting specified modules and specified fields for exceptions. The field values include:
        /// <li>complete: skip entirely mode;</li>
        /// <li>partial: Partially skip mode.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Effective module. Valid values:
        /// <li>waf: managed rules;</li>
        /// <li>rate: rate limit;</li>
        /// <li>acl: custom rule;</li>
        /// <li>cc: CC attack defense;</li>
        /// <li>bot: bot protection.</li>
        /// </summary>
        [JsonProperty("Modules")]
        public string[] Modules{ get; set; }

        /// <summary>
        /// Skip the exception rule details of some rule IDs. If it is null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("PartialModules")]
        public PartialModule[] PartialModules{ get; set; }

        /// <summary>
        /// Exception rule details for skipping specific fields during scan. If null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("SkipConditions")]
        public SkipCondition[] SkipConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Modules.", this.Modules);
            this.SetParamArrayObj(map, prefix + "PartialModules.", this.PartialModules);
            this.SetParamArrayObj(map, prefix + "SkipConditions.", this.SkipConditions);
        }
    }
}

