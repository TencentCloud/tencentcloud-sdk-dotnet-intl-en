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

    public class DescribeLogInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Log type.</p><p>Enumeration value:</p><ul><li>auditLog: Audit log.</li></ul>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Size of the output task list per page.</p><ul><li>Value ranges from 1 to 100.</li><li>Default value: 20.</li></ul>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Pagination offset. Default value: 0. Value: Multiple of Limit. Calculation formula: offset=limit*(page number-1).</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Set the log filtering field to filter and return logs that meet a specified condition.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>Log subcategory.</p><p>Enumeration value:</p><ul><li>write: Write logs.</li><li>read: Read logs.</li><li>all: Read/write logs.</li></ul>
        /// </summary>
        [JsonProperty("LogSubType")]
        public string LogSubType{ get; set; }

        /// <summary>
        /// <p>Log switch.</p><p>Enumeration value:</p><ul><li>on: Enable</li><li>off: Disable</li></ul><p>Default value: off</p>
        /// </summary>
        [JsonProperty("LogSwitch")]
        public string LogSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "LogSubType", this.LogSubType);
            this.SetParamSimple(map, prefix + "LogSwitch", this.LogSwitch);
        }
    }
}

