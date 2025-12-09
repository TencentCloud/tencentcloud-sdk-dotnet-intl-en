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

    public class CreateTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Target group name (up to 50 characters)
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// Specifies the vpc id attribute of the target group. uses the default vpc if left empty.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Specifies the default Port of the target group. the default Port can be used when servers are added subsequently. this parameter is not supported for full-listen target groups. for non-full-listen target groups, either Port or Port in TargetGroupInstances.N is required.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Specifies the real servers bound to the target group. supports up to 50 at a time.
        /// </summary>
        [JsonProperty("TargetGroupInstances")]
        public TargetGroupInstance[] TargetGroupInstances{ get; set; }

        /// <summary>
        /// Target group type, currently supported v1 (legacy version target group) and v2 (new version target group), defaults to v1 (legacy version target group).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Backend forwarding protocol of the target group. this field is required for the new version (v2) target group. currently supports TCP, UDP, HTTP, HTTPS, GRPC.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Health check.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Scheduling algorithm. this parameter is valid only for target groups of the new version V2 when the backend forwarding protocol is HTTP, HTTPS, or GRPC. available values:.
        /// <ur><li>WRR: weighted round-robin.</li><li>LEAST_CONN: LEAST connection.</li><li>IP_HASH: based on IP HASH.</li><li>default is WRR.</li></ur>.
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Specifies the default weight of the backend service. among them:.
        /// <ul><li>Value ranges from 0 to 100.</li><li>after setting this value, when adding a backend service to the target group, if the backend service does not set Weight separately, use the default Weight here.</li><li>Weight parameter settings not supported for v1 target group type.</li></ul>.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Full listen target group flag. valid values: true (yes), false (no). only target groups of the new version V2 event type support this parameter.
        /// </summary>
        [JsonProperty("FullListenSwitch")]
        public bool? FullListenSwitch{ get; set; }

        /// <summary>
        /// Specifies whether to enable the persistent connection feature. this parameter applies only to HTTP and HTTPS target groups. 0: disable; 1: enable. this feature is off by default.
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public bool? KeepaliveEnable{ get; set; }

        /// <summary>
        /// Session hold time, unit: second. value range: 30-3600. default: 0, disabled. this parameter is supported only for target groups with HTTP/HTTPS/GRPC backend forwarding protocol in the new version V2.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public ulong? SessionExpireTime{ get; set; }

        /// <summary>
        /// IP version type.
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "TargetGroupInstances.", this.TargetGroupInstances);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "FullListenSwitch", this.FullListenSwitch);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
        }
    }
}

