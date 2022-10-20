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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSFeaturesFilter : AbstractModel
    {
        
        /// <summary>
        /// Action to be executed. Valid values:
        /// <li>`drop`: Discard</li>
        /// <li>`transmit`: Allow</li>
        /// <li>`drop_block`: Discard and block</li>
        /// <li>`forward`: Continue protection</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The protocol. Values:
        /// <li>`tcp`: TCP protocol</li>
        /// <li>`udp`: UDP protocol</li>
        /// <li>`icmp`: ICMP protocol</li>
        /// <li>`all`: All protocols</li>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Start of the destination port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// End of the destination port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// Minimum packet length. Value range: 0–1500.
        /// </summary>
        [JsonProperty("PacketMin")]
        public long? PacketMin{ get; set; }

        /// <summary>
        /// Maximum packet length. Value range: 0–1500.
        /// </summary>
        [JsonProperty("PacketMax")]
        public long? PacketMax{ get; set; }

        /// <summary>
        /// Start of the source port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// End of the source port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// Matching method 1 of **feature 1**. Values:
        /// <li>`pcre`: Regular expression match</li>
        /// <li>`sunday`: String match</li>An empty string is used by default.
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// Whether the pattern in **feature 1** is matched. This parameter is used together with `MatchType`. Values:
        /// <li>`0`: Matched</li>
        /// <li>`1`: Not matched</li>
        /// </summary>
        [JsonProperty("IsNot")]
        public long? IsNot{ get; set; }

        /// <summary>
        /// Offset 1 of **feature 1**. Value range: 0–1500.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The depth to inspect **feature 1** in the packet. Value range: 1–1500.
        /// </summary>
        [JsonProperty("Depth")]
        public long? Depth{ get; set; }

        /// <summary>
        /// The layer from which each match starts. Values:
        /// <li>`begin_l5`: Start from the payload.</li>
        /// <li>`begin_l4`: Start from the TCP/UDP header.</li>
        /// <li>`begin_l3`: Start from the IP header.</li>
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// The match content of **feature 1**.
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// Matching method 2 of **feature 2**. Values:
        /// <li>`pcre`: Regular expression match</li>
        /// <li>`sunday`: String match</li>An empty string is used by default.
        /// </summary>
        [JsonProperty("MatchType2")]
        public string MatchType2{ get; set; }

        /// <summary>
        /// Whether the pattern in **feature 2** is matched. This parameter is used together with `MatchType2`. Values:
        /// <li>`0`: Matched</li>
        /// <li>`1`: Not matched</li>
        /// </summary>
        [JsonProperty("IsNot2")]
        public long? IsNot2{ get; set; }

        /// <summary>
        /// Offset 2 of **feature 2**. Value range: 0–1500.
        /// </summary>
        [JsonProperty("Offset2")]
        public long? Offset2{ get; set; }

        /// <summary>
        /// The depth to inspect **feature 2** in the packet. Value range: 1–1500.
        /// </summary>
        [JsonProperty("Depth2")]
        public long? Depth2{ get; set; }

        /// <summary>
        /// The layer from which each match starts. Values:
        /// <li>`begin_l5`: Start from the payload.</li>
        /// <li>`begin_l4`: Start from the TCP/UDP header.</li>
        /// <li>`begin_l3`: Start from the IP header.</li>
        /// </summary>
        [JsonProperty("MatchBegin2")]
        public string MatchBegin2{ get; set; }

        /// <summary>
        /// The match content of **feature 2**.
        /// </summary>
        [JsonProperty("Str2")]
        public string Str2{ get; set; }

        /// <summary>
        /// Multi-feature relationship. Enter `none` if only **feature 1** is configured. If **feature 2** exists, you can leave this parameter empty.
        /// </summary>
        [JsonProperty("MatchLogic")]
        public string MatchLogic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "PacketMin", this.PacketMin);
            this.SetParamSimple(map, prefix + "PacketMax", this.PacketMax);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "MatchType2", this.MatchType2);
            this.SetParamSimple(map, prefix + "IsNot2", this.IsNot2);
            this.SetParamSimple(map, prefix + "Offset2", this.Offset2);
            this.SetParamSimple(map, prefix + "Depth2", this.Depth2);
            this.SetParamSimple(map, prefix + "MatchBegin2", this.MatchBegin2);
            this.SetParamSimple(map, prefix + "Str2", this.Str2);
            this.SetParamSimple(map, prefix + "MatchLogic", this.MatchLogic);
        }
    }
}

