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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePurgeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Purge type to be queried. url: query URL purge records; path: query directory purge records.
        /// </summary>
        [JsonProperty("PurgeType")]
        public string PurgeType{ get; set; }

        /// <summary>
        /// Start time, such as 2018-08-08 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time, such as 2018-08-08 23:59:59
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Task ID returned during submission. Either `TaskId` or start time must be specified for a query.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Pagination offset. Default value: 0 (starting from entry 0).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Pagination limit. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Query keyword. Please enter a domain name or full URL beginning with `http(s)://`.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Specified task status to be queried. fail: failed, done: succeeded, process: purging.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PurgeType", this.PurgeType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

