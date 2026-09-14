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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GlobalAcceleratorAccessLog : AbstractModel
    {
        
        /// <summary>
        /// <p>Log Unique Id</p>
        /// </summary>
        [JsonProperty("LogPushTaskId")]
        public string LogPushTaskId{ get; set; }

        /// <summary>
        /// <p>Unique Id of the GA instance.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Unique Id of the listener</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>Unique Id of the terminal node group</p>
        /// </summary>
        [JsonProperty("EndpointGroupId")]
        public string EndpointGroupId{ get; set; }

        /// <summary>
        /// <p>Log task description</p>
        /// </summary>
        [JsonProperty("FlowLogDescription")]
        public string FlowLogDescription{ get; set; }

        /// <summary>
        /// <p>Region where the logs are located.</p>
        /// </summary>
        [JsonProperty("CloudRegion")]
        public string CloudRegion{ get; set; }

        /// <summary>
        /// <p>Log topic Id</p>
        /// </summary>
        [JsonProperty("CloudLogId")]
        public string CloudLogId{ get; set; }

        /// <summary>
        /// <p>Log Set Id</p>
        /// </summary>
        [JsonProperty("CloudLogSetId")]
        public string CloudLogSetId{ get; set; }

        /// <summary>
        /// <p>Select log data collection field</p>
        /// </summary>
        [JsonProperty("FieldKeys")]
        public string[] FieldKeys{ get; set; }

        /// <summary>
        /// <p>Log task status</p><p>Enumeration values:</p><ul><li>active: Running</li><li>stopped: Suspended</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogPushTaskId", this.LogPushTaskId);
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "EndpointGroupId", this.EndpointGroupId);
            this.SetParamSimple(map, prefix + "FlowLogDescription", this.FlowLogDescription);
            this.SetParamSimple(map, prefix + "CloudRegion", this.CloudRegion);
            this.SetParamSimple(map, prefix + "CloudLogId", this.CloudLogId);
            this.SetParamSimple(map, prefix + "CloudLogSetId", this.CloudLogSetId);
            this.SetParamArraySimple(map, prefix + "FieldKeys.", this.FieldKeys);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

