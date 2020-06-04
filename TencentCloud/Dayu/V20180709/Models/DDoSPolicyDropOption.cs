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

    public class DDoSPolicyDropOption : AbstractModel
    {
        
        /// <summary>
        /// Blocks all TCP traffic. Valid values: [0,1]
        /// </summary>
        [JsonProperty("DropTcp")]
        public ulong? DropTcp{ get; set; }

        /// <summary>
        /// Blocks all UDP traffic. Valid values: [0,1]
        /// </summary>
        [JsonProperty("DropUdp")]
        public ulong? DropUdp{ get; set; }

        /// <summary>
        /// Blocks all ICMP traffic. Valid values: [0,1]
        /// </summary>
        [JsonProperty("DropIcmp")]
        public ulong? DropIcmp{ get; set; }

        /// <summary>
        /// Blocks traffic of other protocols. Valid values: [0,1]
        /// </summary>
        [JsonProperty("DropOther")]
        public ulong? DropOther{ get; set; }

        /// <summary>
        /// Rejects traffic from outside Mainland China. Valid values: [0,1]
        /// </summary>
        [JsonProperty("DropAbroad")]
        public ulong? DropAbroad{ get; set; }

        /// <summary>
        /// Null session protection. Valid values: [0,1]
        /// </summary>
        [JsonProperty("CheckSyncConn")]
        public ulong? CheckSyncConn{ get; set; }

        /// <summary>
        /// New connection suppression based on source IP and destination IP. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("SdNewLimit")]
        public ulong? SdNewLimit{ get; set; }

        /// <summary>
        /// New connection suppression based on destination IP. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("DstNewLimit")]
        public ulong? DstNewLimit{ get; set; }

        /// <summary>
        /// Concurrent connection suppression based on source IP and destination IP. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("SdConnLimit")]
        public ulong? SdConnLimit{ get; set; }

        /// <summary>
        /// Concurrent connection suppression based on destination IP. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("DstConnLimit")]
        public ulong? DstConnLimit{ get; set; }

        /// <summary>
        /// Threshold for triggering connection suppression. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("BadConnThreshold")]
        public ulong? BadConnThreshold{ get; set; }

        /// <summary>
        /// Exceptional connection detection condition: null session protection status. Valid values: [0,1]
        /// </summary>
        [JsonProperty("NullConnEnable")]
        public ulong? NullConnEnable{ get; set; }

        /// <summary>
        /// Exceptional connection detection condition: connection timeout. Valid values: [0,65535]
        /// </summary>
        [JsonProperty("ConnTimeout")]
        public ulong? ConnTimeout{ get; set; }

        /// <summary>
        /// Exceptional connection detection condition: percentage of SYN out of ACK. Valid values: [0,100]
        /// </summary>
        [JsonProperty("SynRate")]
        public ulong? SynRate{ get; set; }

        /// <summary>
        /// Exceptional connection detection condition: SYN threshold. Valid values: [0,100]
        /// </summary>
        [JsonProperty("SynLimit")]
        public ulong? SynLimit{ get; set; }

        /// <summary>
        /// TCP speed limit. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("DTcpMbpsLimit")]
        public ulong? DTcpMbpsLimit{ get; set; }

        /// <summary>
        /// UDP speed limit. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("DUdpMbpsLimit")]
        public ulong? DUdpMbpsLimit{ get; set; }

        /// <summary>
        /// ICMP speed limit. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("DIcmpMbpsLimit")]
        public ulong? DIcmpMbpsLimit{ get; set; }

        /// <summary>
        /// Other protocol speed limit. Value range: [0,4294967295]
        /// </summary>
        [JsonProperty("DOtherMbpsLimit")]
        public ulong? DOtherMbpsLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropTcp", this.DropTcp);
            this.SetParamSimple(map, prefix + "DropUdp", this.DropUdp);
            this.SetParamSimple(map, prefix + "DropIcmp", this.DropIcmp);
            this.SetParamSimple(map, prefix + "DropOther", this.DropOther);
            this.SetParamSimple(map, prefix + "DropAbroad", this.DropAbroad);
            this.SetParamSimple(map, prefix + "CheckSyncConn", this.CheckSyncConn);
            this.SetParamSimple(map, prefix + "SdNewLimit", this.SdNewLimit);
            this.SetParamSimple(map, prefix + "DstNewLimit", this.DstNewLimit);
            this.SetParamSimple(map, prefix + "SdConnLimit", this.SdConnLimit);
            this.SetParamSimple(map, prefix + "DstConnLimit", this.DstConnLimit);
            this.SetParamSimple(map, prefix + "BadConnThreshold", this.BadConnThreshold);
            this.SetParamSimple(map, prefix + "NullConnEnable", this.NullConnEnable);
            this.SetParamSimple(map, prefix + "ConnTimeout", this.ConnTimeout);
            this.SetParamSimple(map, prefix + "SynRate", this.SynRate);
            this.SetParamSimple(map, prefix + "SynLimit", this.SynLimit);
            this.SetParamSimple(map, prefix + "DTcpMbpsLimit", this.DTcpMbpsLimit);
            this.SetParamSimple(map, prefix + "DUdpMbpsLimit", this.DUdpMbpsLimit);
            this.SetParamSimple(map, prefix + "DIcmpMbpsLimit", this.DIcmpMbpsLimit);
            this.SetParamSimple(map, prefix + "DOtherMbpsLimit", this.DOtherMbpsLimit);
        }
    }
}

