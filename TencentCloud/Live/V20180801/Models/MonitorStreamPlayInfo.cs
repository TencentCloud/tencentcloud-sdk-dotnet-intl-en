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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorStreamPlayInfo : AbstractModel
    {
        
        /// <summary>
        /// The playback domain.
        /// </summary>
        [JsonProperty("PlayDomain")]
        public string PlayDomain{ get; set; }

        /// <summary>
        /// The stream ID.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// The playback bitrate. `0` indicates the original bitrate.
        /// </summary>
        [JsonProperty("Rate")]
        public ulong? Rate{ get; set; }

        /// <summary>
        /// The playback protocol. Valid values: `Unknown`, `Flv`, `Hls`, `Rtmp`, `Huyap2p`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The bandwidth (Mbps).
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// The number of online users, which is represented by the number of TCP connections (data collected every minute).
        /// </summary>
        [JsonProperty("Online")]
        public ulong? Online{ get; set; }

        /// <summary>
        /// The number of requests.
        /// </summary>
        [JsonProperty("Request")]
        public ulong? Request{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlayDomain", this.PlayDomain);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "Request", this.Request);
        }
    }
}

