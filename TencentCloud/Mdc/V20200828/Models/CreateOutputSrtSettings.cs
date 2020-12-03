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

    public class CreateOutputSrtSettings : AbstractModel
    {
        
        /// <summary>
        /// Push destination address. Please configure one or two addresses.
        /// </summary>
        [JsonProperty("Destinations")]
        public CreateOutputSrtSettingsDestinations[] Destinations{ get; set; }

        /// <summary>
        /// Stream ID of SRT push.
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Total latency of SRT push.
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// Receive latency of SRT push.
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// Peer latency of SRT push.
        /// </summary>
        [JsonProperty("PeerLatency")]
        public long? PeerLatency{ get; set; }

        /// <summary>
        /// Peer idle timeout period of SRT push.
        /// </summary>
        [JsonProperty("PeerIdleTimeout")]
        public long? PeerIdleTimeout{ get; set; }

        /// <summary>
        /// Encryption key of SRT push.
        /// </summary>
        [JsonProperty("Passphrase")]
        public string Passphrase{ get; set; }

        /// <summary>
        /// Key length of SRT push.
        /// </summary>
        [JsonProperty("PbKeyLen")]
        public long? PbKeyLen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RecvLatency", this.RecvLatency);
            this.SetParamSimple(map, prefix + "PeerLatency", this.PeerLatency);
            this.SetParamSimple(map, prefix + "PeerIdleTimeout", this.PeerIdleTimeout);
            this.SetParamSimple(map, prefix + "Passphrase", this.Passphrase);
            this.SetParamSimple(map, prefix + "PbKeyLen", this.PbKeyLen);
        }
    }
}

