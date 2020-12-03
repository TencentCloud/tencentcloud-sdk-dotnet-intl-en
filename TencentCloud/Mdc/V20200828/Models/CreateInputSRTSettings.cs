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

    public class CreateInputSRTSettings : AbstractModel
    {
        
        /// <summary>
        /// Stream ID, which can contain 0 to 512 letters, digits, and special characters (.#!:&,=_-).
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Latency in ms. Default value: 0. Value range: [0, 3000].
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// Receive latency in ms. Default value: 120. Value range: [0, 3000].
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// Peer latency in ms. Default value: 0. Value range: [0, 3000].
        /// </summary>
        [JsonProperty("PeerLatency")]
        public long? PeerLatency{ get; set; }

        /// <summary>
        /// Peer timeout period in ms. Default value: 5000. Value range: [1000, 10000].
        /// </summary>
        [JsonProperty("PeerIdleTimeout")]
        public long? PeerIdleTimeout{ get; set; }

        /// <summary>
        /// Decryption key, which is empty by default, indicating not to encrypt. Only ASCII codes can be filled. Length: [10, 79].
        /// </summary>
        [JsonProperty("Passphrase")]
        public string Passphrase{ get; set; }

        /// <summary>
        /// Key length. Default value: 0. Valid values: 0, 16, 24, 32.
        /// </summary>
        [JsonProperty("PbKeyLen")]
        public long? PbKeyLen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
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

