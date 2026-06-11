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
        /// -srcTopicName is filtered by [source log topic name] with fuzzy matching. Type: String. Required: No. Example: business log topic 1. Get the log topic name by [get log topic list](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// -Filter dstTopicName by [target log topic name] with fuzzy matching. Type: String. Required: No. Example: Business log topic 2. Get the log topic name by [getting the log topic list](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// - srcTopicId is filtered by [source log topic ID]. Type: String. Required: No. Example: a4478687-2382-4486-9692-de7986350f6b. Get the log topic id by [get log topic list](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// -dstTopicId is filtered by [target log topic ID]. Type: String. Required: No. Example: bd4d3375-d72a-4cd2-988d-d8eda2bd62b0. Get log topic ID by [get log topic list](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// -bizType is filtered by [topic type], 0: log topic; 1: metric topic. Type: String. Required: No.
        /// -Status is filtered by [task status]: 1: running; 2: stop; 3: exception. Type: String. Required: no.
        /// -Filter the taskName by [task name] with fuzzy matching. Type: String. Required: No. Example: metricTask. Search the task name by [retrieving the scheduled SQL analysis task list](https://www.tencentcloud.com/document/product/614/95519?from_cn_redirect=1).
        /// -taskId is filtered by [task ID] with fuzzy matching. Type: String. Required: No. Example: 9c64f9c1-a14e-4b59-b074-5b73cac3dd66. Obtain the task ID by [retrieving the scheduled SQL analysis task list](https://www.tencentcloud.com/document/product/614/95519?from_cn_redirect=1).
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

