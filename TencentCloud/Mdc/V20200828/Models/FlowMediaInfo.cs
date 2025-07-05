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

    public class FlowMediaInfo : AbstractModel
    {
        
        /// <summary>
        /// The timestamp (seconds).
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// The total bandwidth.
        /// </summary>
        [JsonProperty("Network")]
        public long? Network{ get; set; }

        /// <summary>
        /// The video data of the flow.
        /// </summary>
        [JsonProperty("Video")]
        public FlowMediaVideo[] Video{ get; set; }

        /// <summary>
        /// The audio data of the flow.
        /// </summary>
        [JsonProperty("Audio")]
        public FlowMediaAudio[] Audio{ get; set; }

        /// <summary>
        /// The ID of a push session.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The client IP.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamArrayObj(map, prefix + "Video.", this.Video);
            this.SetParamArrayObj(map, prefix + "Audio.", this.Audio);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
        }
    }
}

