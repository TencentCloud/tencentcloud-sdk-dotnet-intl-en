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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTargetGroupAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Target group ID
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// New name of target group
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// The new default port of the target group. this parameter is not supported for full listen target groups.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Scheduling algorithm. this parameter is valid only for target groups of the new version V2 when the backend forwarding protocol is HTTP, HTTPS, or GRPC. available values:.
        /// <ur><li>WRR: weighted round-robin.</li><li>LEAST_CONN: LEAST connection.</li><li>IP_HASH: based on IP HASH.</li><li>default is WRR.</li></ur>.
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// Health check details.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Default Weight for backend service. among them: <ul><li>value ranges from 0 to 100.</li><li>after setting this value, when adding a backend service to the target group, if the backend service does not set Weight separately, use the default Weight here.</li><li>Weight parameter settings not supported for v1 target group type.</li></ul>.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Specifies whether to enable the persistent connection feature. this parameter applies only to HTTP and HTTPS target groups. true: disable; false: enable. this feature is off by default.
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public bool? KeepaliveEnable{ get; set; }

        /// <summary>
        /// Specifies the session persistence time in seconds. value range: 30-3600. default: 0 (disabled). this parameter is unsupported for TCP/UDP target groups.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public ulong? SessionExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
        }
    }
}

