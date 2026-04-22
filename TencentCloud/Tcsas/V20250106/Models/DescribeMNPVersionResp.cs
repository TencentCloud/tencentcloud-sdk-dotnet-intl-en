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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPVersionResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Mini program appid</p>
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// <p>Task ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Valid values: 1: Pending; 20: Running; 30: Failed; 60: Succeeded</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// <p>Task status information</p>
        /// </summary>
        [JsonProperty("TaskMsg")]
        public string TaskMsg{ get; set; }

        /// <summary>
        /// <p>Mini program version ID (returned upon successful compilation)</p>
        /// </summary>
        [JsonProperty("MNPVersionId")]
        public long? MNPVersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskMsg", this.TaskMsg);
            this.SetParamSimple(map, prefix + "MNPVersionId", this.MNPVersionId);
        }
    }
}

