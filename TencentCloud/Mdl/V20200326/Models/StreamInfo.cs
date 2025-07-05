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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamInfo : AbstractModel
    {
        
        /// <summary>
        /// Client IP.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Video information of pushed streams.
        /// </summary>
        [JsonProperty("Video")]
        public StreamVideoInfo[] Video{ get; set; }

        /// <summary>
        /// Audio information of pushed streams.
        /// </summary>
        [JsonProperty("Audio")]
        public StreamAudioInfo[] Audio{ get; set; }

        /// <summary>
        /// SCTE-35 information of pushed streams.
        /// </summary>
        [JsonProperty("Scte35")]
        public StreamScte35Info[] Scte35{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamArrayObj(map, prefix + "Video.", this.Video);
            this.SetParamArrayObj(map, prefix + "Audio.", this.Audio);
            this.SetParamArrayObj(map, prefix + "Scte35.", this.Scte35);
        }
    }
}

