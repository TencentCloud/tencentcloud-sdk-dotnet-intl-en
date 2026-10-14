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

    public class CreateOutputSrtSettings : AbstractModel
    {
        
        /// <summary>
        /// Target address for push. Required when Mode is CALLER. Only 1 group can be filled in.
        /// </summary>
        [JsonProperty("Destinations")]
        public CreateOutputSrtSettingsDestinations[] Destinations{ get; set; }

        /// <summary>
        /// SRT mode. Valid values: `LISTENER` and `CALLER`. Default value: `CALLER`.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Stream Id for SRT retransmission. It can contain upper- and lower-case letters, digits, and special characters (.#!:&,=_-), with a length of 0 to 512.
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Total delay for SRT retransmission. Default value: 0. Unit: ms. Range: [0, 3000]. This parameter simultaneously sets the sender and recipient delays (recvlatency and peerlatency) to the same value. Recommended configuration: at least 3 times the RTT to ensure effective handling of packet retransmission and confirmation during network congestion.
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// Receive latency for SRT relay. Default value: 120. Unit: ms. Range: [0, 3000].
        /// This parameter indicates the time length for the recipient to cache data packets.
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// Peer delay for SRT retransmission. Default value: 0. Unit: ms. Range: [0, 3000].
        /// This parameter is set by the sender to inform the recipient of the expected buffer time for delay.
        /// </summary>
        [JsonProperty("PeerLatency")]
        public long? PeerLatency{ get; set; }

        /// <summary>
        /// Idle timeout for SRT relay. Default value: 5000 ms. Range: [1000, 10000].
        /// If there is no activity on a connection within the set timeout period, it will be closed.
        /// </summary>
        [JsonProperty("PeerIdleTimeout")]
        public long? PeerIdleTimeout{ get; set; }

        /// <summary>
        /// Encryption key for SRT retweet. It is empty by default, indicating not encrypted. Only ascii characters are allowed, with a length of [10, 79].
        /// </summary>
        [JsonProperty("Passphrase")]
        public string Passphrase{ get; set; }

        /// <summary>
        /// Key length for SRT retransmission. Default value: 0. Options: [0|16|24|32].
        /// </summary>
        [JsonProperty("PbKeyLen")]
        public long? PbKeyLen{ get; set; }

        /// <summary>
        /// SRT FEC settings
        /// </summary>
        [JsonProperty("FEC")]
        public SRTFECFullOptions FEC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RecvLatency", this.RecvLatency);
            this.SetParamSimple(map, prefix + "PeerLatency", this.PeerLatency);
            this.SetParamSimple(map, prefix + "PeerIdleTimeout", this.PeerIdleTimeout);
            this.SetParamSimple(map, prefix + "Passphrase", this.Passphrase);
            this.SetParamSimple(map, prefix + "PbKeyLen", this.PbKeyLen);
            this.SetParamObj(map, prefix + "FEC.", this.FEC);
        }
    }
}

