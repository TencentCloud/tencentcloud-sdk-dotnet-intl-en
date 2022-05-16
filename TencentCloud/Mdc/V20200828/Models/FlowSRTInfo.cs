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
        }
    }
}

