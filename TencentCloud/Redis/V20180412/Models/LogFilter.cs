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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>Filter criterion name.</p><p>Enumeration value:</p><ul><li>Timestamp: Creation time (format: 2006-01-02 15:04:05.000)</li><li>UserName: User name</li><li>CacheCode: Cache code, backend redis node</li><li>ClientAddr: Client IP address</li><li>CommandDetail: Command details</li><li>CommandLatency: Command delay (ms)</li><li>CommandType: Command type</li><li>DBId: Database ID</li><li>ErrMsg: Error information</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Condition match type.</p><p>Enumeration value:</p><ul><li>INC: Include, multiple values have a || relationship before</li><li>EXC: Exclude, multiple values have a || relationship before</li><li>EQS: Equal, multiple values have a || relationship before</li><li>NEQ: Not equal, multiple values have a && relationship before</li><li>RA: Range</li></ul>
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// <p>Matching value of the filter condition. When Compare=RA, for example: ["1-100","200-300"].</p>
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

