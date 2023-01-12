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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HorizontalAutoscaler : AbstractModel
    {
        
        /// <summary>
        /// (Optional) Minimum number of instances
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// (Optional) Maximum number of instances
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// Metric measurement
        /// `CPU`: CPU utilization (%)
        /// `MEMORY`: Memory utilization (%)
        /// `CPU_CORE_USED`: CPU usage (core)
        /// `MEMORY_SIZE_USED`: Memory usage (MiB)
        /// `NETWORK_BANDWIDTH_RECEIVE`: Network bandwidth in (Mbps)
        /// `NETWORK_BANDWIDTH_TRANSMIT`: Network bandwidth out (Mbps)
        /// `NETWORK_TRAFFIC_RECEIVE`: Network traffic in (MiB/s)
        /// `NETWORK_TRAFFIC_TRANSMIT`: Network traffic  out (MiB/s)
        /// `NETWORK_PACKETS_RECEIVE`: Network packets in (packets/sec)
        /// `NETWORK_PACKETS_TRANSMIT`: Network packets out (packets/sec)
        /// `FS_IOPS_WRITE`: Disk writes (count/sec)
        /// `FS_IOPS_READ`: Disk reads (count/sec)
        /// `FS_SIZE_WRITE`: Disk write size (MiB/s)
        /// `FS_SIZE_READ`: Disk read size (MiB/s)
        /// </summary>
        [JsonProperty("Metrics")]
        public string Metrics{ get; set; }

        /// <summary>
        /// The value of threshold (integer)
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }

        /// <summary>
        /// Whether it is enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// The value of threshold (demical)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DoubleThreshold")]
        public float? DoubleThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "Metrics", this.Metrics);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DoubleThreshold", this.DoubleThreshold);
        }
    }
}

