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

    public class FlowSRTInfo : AbstractModel
    {
        
        /// <summary>
        /// The timestamp (seconds).
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// The packet loss rate for sending.
        /// </summary>
        [JsonProperty("SendPacketLossRate")]
        public long? SendPacketLossRate{ get; set; }

        /// <summary>
        /// The retry rate for sending.
        /// </summary>
        [JsonProperty("SendRetransmissionRate")]
        public long? SendRetransmissionRate{ get; set; }

        /// <summary>
        /// The packet loss rate for receiving.
        /// </summary>
        [JsonProperty("RecvPacketLossRate")]
        public long? RecvPacketLossRate{ get; set; }

        /// <summary>
        /// The retry rate for receiving.
        /// </summary>
        [JsonProperty("RecvRetransmissionRate")]
        public long? RecvRetransmissionRate{ get; set; }

        /// <summary>
        /// The peer RTT.
        /// </summary>
        [JsonProperty("RTT")]
        public long? RTT{ get; set; }

        /// <summary>
        /// The ID of a push session.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The number of dropped packets for sending.
        /// </summary>
        [JsonProperty("SendPacketDropNumber")]
        public long? SendPacketDropNumber{ get; set; }

        /// <summary>
        /// The number of dropped packets for receiving.
        /// </summary>
        [JsonProperty("RecvPacketDropNumber")]
        public long? RecvPacketDropNumber{ get; set; }

        /// <summary>
        /// Bandwidth
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// transmit bandwidth
        /// </summary>
        [JsonProperty("SendBandwidth")]
        public float? SendBandwidth{ get; set; }

        /// <summary>
        /// Receiving bandwidth
        /// </summary>
        [JsonProperty("RecvBandwidth")]
        public float? RecvBandwidth{ get; set; }

        /// <summary>
        /// Sent packet count
        /// </summary>
        [JsonProperty("SendPackets")]
        public long? SendPackets{ get; set; }

        /// <summary>
        /// Received packets
        /// </summary>
        [JsonProperty("RecvPackets")]
        public long? RecvPackets{ get; set; }

        /// <summary>
        /// Sent lost packets
        /// </summary>
        [JsonProperty("SendLostPackets")]
        public long? SendLostPackets{ get; set; }

        /// <summary>
        /// accept lost packets
        /// </summary>
        [JsonProperty("RecvLostPackets")]
        public long? RecvLostPackets{ get; set; }

        /// <summary>
        /// Retransmitted packet count
        /// </summary>
        [JsonProperty("SendRetransmitPackets")]
        public long? SendRetransmitPackets{ get; set; }

        /// <summary>
        /// Retransmitted packets received
        /// </summary>
        [JsonProperty("RecvRetransmitPackets")]
        public long? RecvRetransmitPackets{ get; set; }

        /// <summary>
        /// Window size
        /// </summary>
        [JsonProperty("FlightSize")]
        public long? FlightSize{ get; set; }

        /// <summary>
        /// Congestion window
        /// </summary>
        [JsonProperty("CongestionWindow")]
        public long? CongestionWindow{ get; set; }

        /// <summary>
        /// Sending buffer (ms)
        /// </summary>
        [JsonProperty("SendBuffer")]
        public long? SendBuffer{ get; set; }

        /// <summary>
        /// Receive buffer (ms)
        /// </summary>
        [JsonProperty("RecvBuffer")]
        public long? RecvBuffer{ get; set; }

        /// <summary>
        /// Send delay
        /// </summary>
        [JsonProperty("SendLatency")]
        public long? SendLatency{ get; set; }

        /// <summary>
        /// receive latency
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "SendPacketLossRate", this.SendPacketLossRate);
            this.SetParamSimple(map, prefix + "SendRetransmissionRate", this.SendRetransmissionRate);
            this.SetParamSimple(map, prefix + "RecvPacketLossRate", this.RecvPacketLossRate);
            this.SetParamSimple(map, prefix + "RecvRetransmissionRate", this.RecvRetransmissionRate);
            this.SetParamSimple(map, prefix + "RTT", this.RTT);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SendPacketDropNumber", this.SendPacketDropNumber);
            this.SetParamSimple(map, prefix + "RecvPacketDropNumber", this.RecvPacketDropNumber);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "SendBandwidth", this.SendBandwidth);
            this.SetParamSimple(map, prefix + "RecvBandwidth", this.RecvBandwidth);
            this.SetParamSimple(map, prefix + "SendPackets", this.SendPackets);
            this.SetParamSimple(map, prefix + "RecvPackets", this.RecvPackets);
            this.SetParamSimple(map, prefix + "SendLostPackets", this.SendLostPackets);
            this.SetParamSimple(map, prefix + "RecvLostPackets", this.RecvLostPackets);
            this.SetParamSimple(map, prefix + "SendRetransmitPackets", this.SendRetransmitPackets);
            this.SetParamSimple(map, prefix + "RecvRetransmitPackets", this.RecvRetransmitPackets);
            this.SetParamSimple(map, prefix + "FlightSize", this.FlightSize);
            this.SetParamSimple(map, prefix + "CongestionWindow", this.CongestionWindow);
            this.SetParamSimple(map, prefix + "SendBuffer", this.SendBuffer);
            this.SetParamSimple(map, prefix + "RecvBuffer", this.RecvBuffer);
            this.SetParamSimple(map, prefix + "SendLatency", this.SendLatency);
            this.SetParamSimple(map, prefix + "RecvLatency", this.RecvLatency);
        }
    }
}

