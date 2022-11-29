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
        /// The module to be activated. Values:
        /// <li>`waf`: Managed rules</li>
        /// <li>`cc`: Rate limiting rules</li>
        /// <li>`bot`: bot protection</li>
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Modules")]
        public string[] Modules{ get; set; }

        /// <summary>
        /// Module settings of the exception rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PartialModules")]
        public PartialModule[] PartialModules{ get; set; }

        /// <summary>
        /// Condition settings of the exception rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
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

