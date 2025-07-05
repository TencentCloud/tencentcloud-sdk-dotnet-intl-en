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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryTaskCostDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria. The following filter types are supported. The parameter Name should be one of them. The maximum number of values that can be filtered by task-id is 50. The values that can be filtered by other parameter filters should not be more than 5.
        /// task-id - String - (accurate filtering of task IDs). The example of the value of task-id is e386471f-139a-4e59-877f-50ece8135b99.
        /// task-state - String - (filtering task status); valid values: 0 (initializing), 1 (running), 2 (successful), and -1 (failed).
        /// task-sql-keyword - String - (fuzzy filtering of the keywords of SQL statements); the example of the value is DROP TABLE.
        /// task-operator- string (filtering sub-UIN)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Start time, and the format is yyyy-mm-dd HH:MM:SS. It is the current moment 45 days ago by default.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time, and the format is yyyy-mm-dd HH:MM:SS. The time span is longer than 0 day but shorter than or equal to 30 days. Data within the recent 45 days can be queried. It is the current moment by default.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Data engine name, used for selecting
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// Identifier on the next page
        /// </summary>
        [JsonProperty("SearchAfter")]
        public string SearchAfter{ get; set; }

        /// <summary>
        /// Size of each page
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "SearchAfter", this.SearchAfter);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

