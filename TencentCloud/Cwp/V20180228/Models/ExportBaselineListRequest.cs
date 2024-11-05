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

    public class ExportBaselineListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria:
        /// <li>StrategyId- Uint64 - baseline policy ID</li>
        /// <li>Status - Uint64 - event status: 0: failed; 1: ignored; 3: passed; 5: detecting</li>
        /// <li>BaselineName - String - baseline name</li>
        /// <li>AliasName - String - server name/server IP address</li>
        /// <li>Uuid - String - host UUID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// This parameter has been deprecated.
        /// </summary>
        [JsonProperty("IfDetail")]
        public ulong? IfDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IfDetail", this.IfDetail);
        }
    }
}
