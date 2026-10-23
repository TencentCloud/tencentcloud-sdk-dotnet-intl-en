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

    public class CustomVariableOperationRuleBranch : AbstractModel
    {
        
        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/1552/90438?from_cn_redirect=1#33f65828-c6c6-4b66-a011-25a20b548d5d">Match condition</a>.</p>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/1552/90438?from_cn_redirect=1#c7bd7e02-9247-4a72-b0e4-11c27cadb198">Operate</a>.<br>Note: Actions and SubRules cannot be empty at the same time.</p>
        /// </summary>
        [JsonProperty("Actions")]
        public CustomVariableOperationRuleAction[] Actions{ get; set; }

        /// <summary>
        /// <p>Sub-rule list. If there are multiple rules in the list, they are executed in order from top to bottom.<br>Note: SubRules and Actions cannot be empty at the same time. Currently only support filling one level of SubRules.</p>
        /// </summary>
        [JsonProperty("SubRules")]
        public CustomVariableOperationSubRule[] SubRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamArrayObj(map, prefix + "Actions.", this.Actions);
            this.SetParamArrayObj(map, prefix + "SubRules.", this.SubRules);
        }
    }
}

