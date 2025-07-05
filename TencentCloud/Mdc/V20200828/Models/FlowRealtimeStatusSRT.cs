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

namespace TencentCloud.Mdc.V20200828.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowRealtimeStatusSRT : AbstractModel
    {
        
        /// <summary>
        /// The latency (ms).
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// RTT (ms).
        /// </summary>
        [JsonProperty("RTT")]
        public long? RTT{ get; set; }

        /// <summary>
        /// The number of packets sent or received.
        /// </summary>
        [JsonProperty("Packets")]
        public long? Packets{ get; set; }

        /// <summary>
        /// The packet loss rate.
        /// </summary>
        [JsonProperty("PacketLossRate")]
        public float? PacketLossRate{ get; set; }

        /// <summary>
        /// The retransmission rate.
        /// </summary>
        [JsonProperty("RetransmitRate")]
        public float? RetransmitRate{ get; set; }

        /// <summary>
        /// The number of packets dropped.
        /// </summary>
        [JsonProperty("DroppedPackets")]
        public long? DroppedPackets{ get; set; }

        /// <summary>
        /// Whether to encrypt the stream. Valid values: On, Off.
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RTT", this.RTT);
            this.SetParamSimple(map, prefix + "Packets", this.Packets);
            this.SetParamSimple(map, prefix + "PacketLossRate", this.PacketLossRate);
            this.SetParamSimple(map, prefix + "RetransmitRate", this.RetransmitRate);
            this.SetParamSimple(map, prefix + "DroppedPackets", this.DroppedPackets);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
        }
    }
}

