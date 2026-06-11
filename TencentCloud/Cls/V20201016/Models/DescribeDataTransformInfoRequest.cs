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

    public class DescribeDataTransformInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// - taskName
        /// Filter by [processing task name].
        /// Type: String
        /// Required: No
        /// Example: test-task
        /// 
        /// - taskId
        /// Filter by [processing task id].
        /// Type: String
        /// Required: No
        /// Example: a3622556-6402-4942-b4ff-5ae32ec29810
        /// Data processing task ID - Search the data processing task list basic information (https://www.tencentcloud.com/document/product/614/72182?from_cn_redirect=1) to get the data processing task ID.
        /// 
        /// - topicId
        /// Filter by [source topicId].
        /// Type: String
        /// Required: No
        /// Example: 756cec3e-a0a5-44c3-85a8-090870582000
        /// Log topic ID
        /// -Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// 
        /// - status
        /// Filter by [Task running status]. 1: Preparing, 2: Running, 3: Stopping, 4: Stopped.
        /// Type: String
        /// Required: No
        /// Example: 1
        /// 
        /// - hasServiceLog
        /// Filter by [whether service logs are enabled]. 1: not enabled, 2: on.
        /// Type: String
        /// Required: No
        /// Example: 1
        /// 
        /// - dstTopicType
        /// Filter by [Target topic Type]. 1: Fixed, 2: Dynamic.
        /// Type: String
        /// Required: No
        /// Example: 1
        /// 
        /// Each request can have up to 10 Filters. The upper limit of Filter.Values is 100.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The pagination offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Task type. Valid values: 1: Get the details of a single task. 2 (default): Get the task list.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// When Type is 1, this parameter is required.
        /// Data processing task ID - Search the data processing task list basic information (https://www.tencentcloud.com/document/product/614/72182?from_cn_redirect=1) to get the data processing task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

