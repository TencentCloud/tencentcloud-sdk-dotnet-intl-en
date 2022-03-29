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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the task ID (in the `Results` parameter) returned after a video moderation task is created. It is used to identify the moderation task for which to query the details.
        /// <br>Note: the query API can query up to **20 tasks at a time**.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// This boolean field indicates whether to display all video segments. Valid values: True (yes), False (display only video segments that hit the moderation rule). Default value: False.
        /// </summary>
        [JsonProperty("ShowAllSegments")]
        public bool? ShowAllSegments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ShowAllSegments", this.ShowAllSegments);
        }
    }
}

