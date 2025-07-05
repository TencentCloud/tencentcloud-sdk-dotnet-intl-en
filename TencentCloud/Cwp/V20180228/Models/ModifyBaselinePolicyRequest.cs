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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBaselinePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("Data")]
        public BaselinePolicy Data{ get; set; }

        /// <summary>
        /// <li>RuleName - String - required: no - rule name</li>
        /// <li>CategoryId - int64 - required: no - customized filtering: -1 - rule category</li>
        /// <li>RuleType - int - required: no - 0: system default; 1: customized - rule type</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Whether to select all based on the filtering criteria
        /// </summary>
        [JsonProperty("SelectAll")]
        public long? SelectAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
        }
    }
}

