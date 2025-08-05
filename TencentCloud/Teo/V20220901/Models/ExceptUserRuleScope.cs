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
        /// Exception mode. Values:
        /// <li>`complete`: Skip the exception rule for full requests.</li>
        /// <li>`partial`: Skip the exception rule for partial requests.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Effective module. the field value can be:.
        /// <li>`waf`: tencent cloud-managed rules</li>.
        /// <Li>`Rate`: rate limit</li>.
        /// <li>`acl`: custom rule</li>.
        /// <Li>`Cc`: cc attack defense</li>.
        /// <Li>`Bot`: bot protection</li>.
        /// </summary>
        [JsonProperty("Modules")]
        public string[] Modules{ get; set; }

        /// <summary>
        /// Skip exception rule details for some rule ids. if null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("PartialModules")]
        public PartialModule[] PartialModules{ get; set; }

        /// <summary>
        /// Details of the exception rule for skipping specific fields. if null, use the last set configuration by default.
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

