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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Async task ID.
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public long? AsyncRequestId{ get; set; }

        /// <summary>
        /// List of all proxies of the current instance.
        /// </summary>
        [JsonProperty("InstProxyList")]
        public string[] InstProxyList{ get; set; }

        /// <summary>
        /// Total number of proxies of the current instance.
        /// </summary>
        [JsonProperty("InstProxyCount")]
        public long? InstProxyCount{ get; set; }

        /// <summary>
        /// Task creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Task start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task status. Valid values: `created` (create), `chosen` (to be executed), `running` (being executed), `failed` (failed), and `finished` (completed).
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// IDs of the proxies that have completed the session killing tasks.
        /// </summary>
        [JsonProperty("FinishedProxyList")]
        public string[] FinishedProxyList{ get; set; }

        /// <summary>
        /// IDs of the proxies that failed to execute the session killing tasks.
        /// </summary>
        [JsonProperty("FailedProxyList")]
        public string[] FailedProxyList{ get; set; }

        /// <summary>
        /// Task end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Task progress.
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamArraySimple(map, prefix + "InstProxyList.", this.InstProxyList);
            this.SetParamSimple(map, prefix + "InstProxyCount", this.InstProxyCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "FinishedProxyList.", this.FinishedProxyList);
            this.SetParamArraySimple(map, prefix + "FailedProxyList.", this.FailedProxyList);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

