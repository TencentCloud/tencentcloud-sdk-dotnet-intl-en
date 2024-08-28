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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBashPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// Quantity of returned entries. The maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filtering criteria
        /// <li>Name - String - required: no - rule name</li>
        /// <li>Rule - String - required: no - rule content</li>
        /// <li>Level - Int - required: no - threat level</li>
        /// <li>White - Int - required: no - allowlist type</li>
        /// <li>Category - Int - required: no - policy type</li>
        /// <li>BashAction - Int - required: no - action</li>
        /// <li>Enable - Int - required: no - enabling status</li>
        /// <li>Id - Int - required: no - policy ID</li>
        /// <li>PolicyId - Int - required: no - policy ID</li>
        /// <li>RuleId - Int - required: no - rule ID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

