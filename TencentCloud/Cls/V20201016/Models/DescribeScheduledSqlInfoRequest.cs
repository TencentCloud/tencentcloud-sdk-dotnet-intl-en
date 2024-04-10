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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScheduledSqlInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <li>srcTopicName: Filter by Source Log Topic Name, fuzzy match. Type: String. Required: No</li><li>dstTopicName: Filter by Destination Log Topic Name, fuzzy match. Type: String. Required: No</li><li>srcTopicId: Filter by Source Log Topic ID. Type: String. Required: No</li><li>dstTopicId: Filter by Destination Log Topic ID. Type: String. Required: No</li><li>bizType: Filter by Topic Type, 0: log topic; 1: metric topic. Type: String. Required: No</li><li>status: Filter by Task Status, 1: running; 2: stopped. Type: String. Required: No</li><li>taskName: Filter by Task Name, fuzzy match. Type: String. Required: No</li><li>taskId: Filter by Task ID, fuzzy match. Type: String. Required: No</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

