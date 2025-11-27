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

    public class TargetHealth : AbstractModel
    {
        
        /// <summary>
        /// Private IP of the target
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// Port bound to the target
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Current health status. true: healthy; false: unhealthy.
        /// </summary>
        [JsonProperty("HealthStatus")]
        public bool? HealthStatus{ get; set; }

        /// <summary>
        /// Instance ID of the target, such as ins-12345678
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// Describes the detailed information of the current health status. for example: Alive, Dead, Unknown, Close. Alive status is healthy, Dead state is abnormal, Unknown status includes not started, checking, Unknown status, Close means health check disabled or listener status stop.
        /// </summary>
        [JsonProperty("HealthStatusDetail")]
        public string HealthStatusDetail{ get; set; }

        /// <summary>
        /// (**This parameter will be disused soon. Please use `HealthStatusDetail` instead.**) Details of the current health status. Values: `Alive` (healthy), `Dead` (abnormal), `Unknown` (Health check not started/checking/unknown status)
        /// </summary>
        [JsonProperty("HealthStatusDetial")]
        [System.Obsolete]
        public string HealthStatusDetial{ get; set; }

        /// <summary>
        /// Target group unique ID.
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// Specifies the weight of the Target.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "HealthStatusDetail", this.HealthStatusDetail);
            this.SetParamSimple(map, prefix + "HealthStatusDetial", this.HealthStatusDetial);
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
        }
    }
}

