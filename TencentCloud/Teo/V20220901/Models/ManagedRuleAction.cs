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

    public class ManagedRuleAction : AbstractModel
    {
        
        /// <summary>
        /// Specific items under ManagedRuleGroup, used to rewrite the configuration of this individual rule item, refer to product documentation for details.	
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Action for the managed rule item specified by RuleId, the SecurityAction Name parameter supports: <li>`Deny`: block and respond with an block page;</li> <li>`Monitor`: observe, do not process the request and record the security event in logs;</li> <li>`Disabled`: disabled, do not scan the request and skip this rule.</li>.
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamObj(map, prefix + "Action.", this.Action);
        }
    }
}

