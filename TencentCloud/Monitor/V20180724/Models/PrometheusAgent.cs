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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusAgent : AbstractModel
    {
        
        /// <summary>
        /// Agent name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Agent ID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Agent IP
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv4")]
        public string Ipv4{ get; set; }

        /// <summary>
        /// Heartbeat time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeartbeatTime")]
        public string HeartbeatTime{ get; set; }

        /// <summary>
        /// Last error
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastError")]
        public string LastError{ get; set; }

        /// <summary>
        /// Agent version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// Agent status
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ipv4", this.Ipv4);
            this.SetParamSimple(map, prefix + "HeartbeatTime", this.HeartbeatTime);
            this.SetParamSimple(map, prefix + "LastError", this.LastError);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

