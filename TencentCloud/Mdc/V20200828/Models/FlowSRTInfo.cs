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
        /// <p>Timestamp in seconds.</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// <p>Packet loss rate on transmitting.</p>
        /// </summary>
        [JsonProperty("SendPacketLossRate")]
        public long? SendPacketLossRate{ get; set; }

        /// <summary>
        /// <p>Retransmission rate.</p>
        /// </summary>
        [JsonProperty("SendRetransmissionRate")]
        public long? SendRetransmissionRate{ get; set; }

        /// <summary>
        /// <p>Packet loss rate on receiving.</p>
        /// </summary>
        [JsonProperty("RecvPacketLossRate")]
        public long? RecvPacketLossRate{ get; set; }

        /// <summary>
        /// <p>Receiving retransmission rate.</p>
        /// </summary>
        [JsonProperty("RecvRetransmissionRate")]
        public long? RecvRetransmissionRate{ get; set; }

        /// <summary>
        /// <p>RTT latency to the peer.</p>
        /// </summary>
        [JsonProperty("RTT")]
        public long? RTT{ get; set; }

        /// <summary>
        /// <p>Flag the same streaming session.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Number of discarded packets on sending.</p>
        /// </summary>
        [JsonProperty("SendPacketDropNumber")]
        public long? SendPacketDropNumber{ get; set; }

        /// <summary>
        /// <p>Number of received dropped packets.</p>
        /// </summary>
        [JsonProperty("RecvPacketDropNumber")]
        public long? RecvPacketDropNumber{ get; set; }

        /// <summary>
        /// <p>Bandwidth.</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// <p>Transmit bandwidth</p>
        /// </summary>
        [JsonProperty("SendBandwidth")]
        public float? SendBandwidth{ get; set; }

        /// <summary>
        /// <p>Receiving bandwidth</p>
        /// </summary>
        [JsonProperty("RecvBandwidth")]
        public float? RecvBandwidth{ get; set; }

        /// <summary>
        /// <p>Sent packet count</p>
        /// </summary>
        [JsonProperty("SendPackets")]
        public long? SendPackets{ get; set; }

        /// <summary>
        /// <p>Number of received packets</p>
        /// </summary>
        [JsonProperty("RecvPackets")]
        public long? RecvPackets{ get; set; }

        /// <summary>
        /// <p>Sending lost packets</p>
        /// </summary>
        [JsonProperty("SendLostPackets")]
        public long? SendLostPackets{ get; set; }

        /// <summary>
        /// <p>Accept lost packets</p>
        /// </summary>
        [JsonProperty("RecvLostPackets")]
        public long? RecvLostPackets{ get; set; }

        /// <summary>
        /// <p>Sent retransmission packet count</p>
        /// </summary>
        [JsonProperty("SendRetransmitPackets")]
        public long? SendRetransmitPackets{ get; set; }

        /// <summary>
        /// <p>Number of received retransmission packets</p>
        /// </summary>
        [JsonProperty("RecvRetransmitPackets")]
        public long? RecvRetransmitPackets{ get; set; }

        /// <summary>
        /// <p>Flight window size</p>
        /// </summary>
        [JsonProperty("FlightSize")]
        public long? FlightSize{ get; set; }

        /// <summary>
        /// <p>Congestion window.</p>
        /// </summary>
        [JsonProperty("CongestionWindow")]
        public long? CongestionWindow{ get; set; }

        /// <summary>
        /// <p>Sending buffer (ms)</p>
        /// </summary>
        [JsonProperty("SendBuffer")]
        public long? SendBuffer{ get; set; }

        /// <summary>
        /// <p>Receive buffer (ms)</p>
        /// </summary>
        [JsonProperty("RecvBuffer")]
        public long? RecvBuffer{ get; set; }

        /// <summary>
        /// <p>Sending delay</p>
        /// </summary>
        [JsonProperty("SendLatency")]
        public long? SendLatency{ get; set; }

        /// <summary>
        /// <p>Receive latency</p>
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// <p>Sent NAK packet count</p>
        /// </summary>
        [JsonProperty("SendNAKPackets")]
        public long? SendNAKPackets{ get; set; }

        /// <summary>
        /// <p>Number of received NAK packets</p>
        /// </summary>
        [JsonProperty("RecvNAKPackets")]
        public long? RecvNAKPackets{ get; set; }


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
            this.SetParamSimple(map, prefix + "SendNAKPackets", this.SendNAKPackets);
            this.SetParamSimple(map, prefix + "RecvNAKPackets", this.RecvNAKPackets);
        }
    }
}

