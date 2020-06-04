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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSNetEvInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type (`net`: Anti-DDoS Ultimate)
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Attack start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Attack end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Number of TCP attack packets
        /// </summary>
        [JsonProperty("TcpPacketSum")]
        public ulong? TcpPacketSum{ get; set; }

        /// <summary>
        /// Traffic of TCP attacks in KB
        /// </summary>
        [JsonProperty("TcpKBSum")]
        public ulong? TcpKBSum{ get; set; }

        /// <summary>
        /// Number of UDP attack packets
        /// </summary>
        [JsonProperty("UdpPacketSum")]
        public ulong? UdpPacketSum{ get; set; }

        /// <summary>
        /// Traffic of UDP attacks in KB
        /// </summary>
        [JsonProperty("UdpKBSum")]
        public ulong? UdpKBSum{ get; set; }

        /// <summary>
        /// Number of ICMP attack packets
        /// </summary>
        [JsonProperty("IcmpPacketSum")]
        public ulong? IcmpPacketSum{ get; set; }

        /// <summary>
        /// Traffic of ICMP attacks in KB
        /// </summary>
        [JsonProperty("IcmpKBSum")]
        public ulong? IcmpKBSum{ get; set; }

        /// <summary>
        /// Number of other attack packets
        /// </summary>
        [JsonProperty("OtherPacketSum")]
        public ulong? OtherPacketSum{ get; set; }

        /// <summary>
        /// Traffic of other attacks in KB
        /// </summary>
        [JsonProperty("OtherKBSum")]
        public ulong? OtherKBSum{ get; set; }

        /// <summary>
        /// Total attack traffic in KB
        /// </summary>
        [JsonProperty("TotalTraffic")]
        public ulong? TotalTraffic{ get; set; }

        /// <summary>
        /// Attack traffic bandwidth peak
        /// </summary>
        [JsonProperty("Mbps")]
        public ulong? Mbps{ get; set; }

        /// <summary>
        /// Attack packet rate peak
        /// </summary>
        [JsonProperty("Pps")]
        public ulong? Pps{ get; set; }

        /// <summary>
        /// PCAP file download link
        /// </summary>
        [JsonProperty("PcapUrl")]
        public string[] PcapUrl{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TcpPacketSum", this.TcpPacketSum);
            this.SetParamSimple(map, prefix + "TcpKBSum", this.TcpKBSum);
            this.SetParamSimple(map, prefix + "UdpPacketSum", this.UdpPacketSum);
            this.SetParamSimple(map, prefix + "UdpKBSum", this.UdpKBSum);
            this.SetParamSimple(map, prefix + "IcmpPacketSum", this.IcmpPacketSum);
            this.SetParamSimple(map, prefix + "IcmpKBSum", this.IcmpKBSum);
            this.SetParamSimple(map, prefix + "OtherPacketSum", this.OtherPacketSum);
            this.SetParamSimple(map, prefix + "OtherKBSum", this.OtherKBSum);
            this.SetParamSimple(map, prefix + "TotalTraffic", this.TotalTraffic);
            this.SetParamSimple(map, prefix + "Mbps", this.Mbps);
            this.SetParamSimple(map, prefix + "Pps", this.Pps);
            this.SetParamArraySimple(map, prefix + "PcapUrl.", this.PcapUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

