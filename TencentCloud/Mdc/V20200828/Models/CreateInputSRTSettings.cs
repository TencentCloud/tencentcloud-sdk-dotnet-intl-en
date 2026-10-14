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

    public class CreateInputSRTSettings : AbstractModel
    {
        
        /// <summary>
        /// SRT mode. Options: [LISTENER|CALLER]. Default value: LISTENER.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Stream Id. It can contain upper- and lower-case letters, digits, and special characters (.#!:&,=_-), with a length of 0 to 512. For the specific format, see: https://github.com/Haivision/srt/blob/master/docs/features/access-control.md#standard-keys.	
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Delay. Default value: 0. Unit: ms. Range: [0, 3000].
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// Receive latency. Default value: 120. Unit: ms. Range: [0, 3000].
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// Peer delay. Default value: 0. Unit: ms. Range: [0, 3000].
        /// </summary>
        [JsonProperty("PeerLatency")]
        public long? PeerLatency{ get; set; }

        /// <summary>
        /// Peer timeout. Default value: 5000 ms. Range: [1000, 10000].
        /// </summary>
        [JsonProperty("PeerIdleTimeout")]
        public long? PeerIdleTimeout{ get; set; }

        /// <summary>
        /// Decryption key. Empty by default, which means not encrypted. Only ascii characters are supported. Length range: [10, 79].
        /// </summary>
        [JsonProperty("Passphrase")]
        public string Passphrase{ get; set; }

        /// <summary>
        /// Key length. Default value: 0. Options: [0|16|24|32].
        /// </summary>
        [JsonProperty("PbKeyLen")]
        public long? PbKeyLen{ get; set; }

        /// <summary>
        /// SRT peer address. Required when Mode is CALLER, and can only contain 1 group.
        /// </summary>
        [JsonProperty("SourceAddresses")]
        public SRTSourceAddressReq[] SourceAddresses{ get; set; }

        /// <summary>
        /// SRT FEC settings
        /// </summary>
        [JsonProperty("FEC")]
        public SRTFECSimpleOptions FEC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RecvLatency", this.RecvLatency);
            this.SetParamSimple(map, prefix + "PeerLatency", this.PeerLatency);
            this.SetParamSimple(map, prefix + "PeerIdleTimeout", this.PeerIdleTimeout);
            this.SetParamSimple(map, prefix + "Passphrase", this.Passphrase);
            this.SetParamSimple(map, prefix + "PbKeyLen", this.PbKeyLen);
            this.SetParamArrayObj(map, prefix + "SourceAddresses.", this.SourceAddresses);
            this.SetParamObj(map, prefix + "FEC.", this.FEC);
        }
    }
}

