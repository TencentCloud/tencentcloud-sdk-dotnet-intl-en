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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAntiPly : AbstractModel
    {
        
        /// <summary>
        /// Enables TCP protocol blocking. `on` (enable); `off` (disable).
        /// </summary>
        [JsonProperty("DropTcp")]
        public string DropTcp{ get; set; }

        /// <summary>
        /// Enables UDP protocol blocking. `on` (enable); `off` (disable).
        /// </summary>
        [JsonProperty("DropUdp")]
        public string DropUdp{ get; set; }

        /// <summary>
        /// Enables ICMP protocol blocking. `on` (enable); `off` (disable).
        /// </summary>
        [JsonProperty("DropIcmp")]
        public string DropIcmp{ get; set; }

        /// <summary>
        /// Enables blocking for other protocols. `on` (enable); `off` (disable).
        /// </summary>
        [JsonProperty("DropOther")]
        public string DropOther{ get; set; }

        /// <summary>
        /// Number of new connections the source port can establish. Value range: 0-4294967295.
        /// </summary>
        [JsonProperty("SourceCreateLimit")]
        public long? SourceCreateLimit{ get; set; }

        /// <summary>
        /// Number of concurrent connections the source port can establish. Value range: 0-4294967295.
        /// </summary>
        [JsonProperty("SourceConnectLimit")]
        public long? SourceConnectLimit{ get; set; }

        /// <summary>
        /// Number of new connections the destination port can establish. Value range: 0-4294967295.
        /// </summary>
        [JsonProperty("DestinationCreateLimit")]
        public long? DestinationCreateLimit{ get; set; }

        /// <summary>
        /// Number of concurrent connections the destination port can establish. Value range: 0-4294967295.
        /// </summary>
        [JsonProperty("DestinationConnectLimit")]
        public long? DestinationConnectLimit{ get; set; }

        /// <summary>
        /// Number of abnormal connections allowed. Value range: 0-4294967295.
        /// </summary>
        [JsonProperty("AbnormalConnectNum")]
        public long? AbnormalConnectNum{ get; set; }

        /// <summary>
        /// Specifies the ratio of SYN exceptions to trigger alerts. Value range: 0-100
        /// </summary>
        [JsonProperty("AbnormalSynRatio")]
        public long? AbnormalSynRatio{ get; set; }

        /// <summary>
        /// Specifies a max number of SYN packets that triggers alarms. Value range: 0-65535
        /// </summary>
        [JsonProperty("AbnormalSynNum")]
        public long? AbnormalSynNum{ get; set; }

        /// <summary>
        /// Connection timeout period. Value range: 0-65535.
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public long? ConnectTimeout{ get; set; }

        /// <summary>
        /// Whether to enable null session protection. `0`: Disable; `1`: Enable.
        /// </summary>
        [JsonProperty("EmptyConnectProtect")]
        public string EmptyConnectProtect{ get; set; }

        /// <summary>
        /// Whether to enable UDP fragmentation. `off`: Disable; `on`: Enable.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UdpShard")]
        public string UdpShard{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropTcp", this.DropTcp);
            this.SetParamSimple(map, prefix + "DropUdp", this.DropUdp);
            this.SetParamSimple(map, prefix + "DropIcmp", this.DropIcmp);
            this.SetParamSimple(map, prefix + "DropOther", this.DropOther);
            this.SetParamSimple(map, prefix + "SourceCreateLimit", this.SourceCreateLimit);
            this.SetParamSimple(map, prefix + "SourceConnectLimit", this.SourceConnectLimit);
            this.SetParamSimple(map, prefix + "DestinationCreateLimit", this.DestinationCreateLimit);
            this.SetParamSimple(map, prefix + "DestinationConnectLimit", this.DestinationConnectLimit);
            this.SetParamSimple(map, prefix + "AbnormalConnectNum", this.AbnormalConnectNum);
            this.SetParamSimple(map, prefix + "AbnormalSynRatio", this.AbnormalSynRatio);
            this.SetParamSimple(map, prefix + "AbnormalSynNum", this.AbnormalSynNum);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "EmptyConnectProtect", this.EmptyConnectProtect);
            this.SetParamSimple(map, prefix + "UdpShard", this.UdpShard);
        }
    }
}

