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

    public class RuleBranch : AbstractModel
    {
        
        /// <summary>
        /// [Match condition](https://www.tencentcloud.com/document/product/1145/54759).
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// [Operations](Https://Cloud.Tencent.Com/Document/Product/1552/90438#C7bd7e02-9247-4a72-B0e4-11c27cadb198).<Br>Note: actions and subrules cannot both be empty.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Actions")]
        public RuleEngineAction[] Actions{ get; set; }

        /// <summary>
        /// List of sub-rules. multiple rules exist in this list and are executed sequentially from top to bottom.<br>note: subrules and actions cannot both be empty. currently, only one layer of subrules is supported.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("SubRules")]
        public RuleEngineSubRule[] SubRules{ get; set; }


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

