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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoCalloutTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Task Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Number of calls.
        /// </summary>
        [JsonProperty("CalleeCount")]
        public ulong? CalleeCount{ get; set; }

        /// <summary>
        /// List of calling numbers.
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// Start timestamp.
        /// </summary>
        [JsonProperty("NotBefore")]
        public long? NotBefore{ get; set; }

        /// <summary>
        /// End timestamp.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotAfter")]
        public long? NotAfter{ get; set; }

        /// <summary>
        /// IvrId used by the task.
        /// </summary>
        [JsonProperty("IvrId")]
        public ulong? IvrId{ get; set; }

        /// <summary>
        /// Task status:
        /// 0 Initial: Task created, calling not started
        /// 1 Running
        /// 2  Completed: All calls in the task are completed
        /// 3 Ending: The task is due, but some calls are still not finished
        /// 4 Ended: Task terminated due to expiration
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CalleeCount", this.CalleeCount);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "NotBefore", this.NotBefore);
            this.SetParamSimple(map, prefix + "NotAfter", this.NotAfter);
            this.SetParamSimple(map, prefix + "IvrId", this.IvrId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

