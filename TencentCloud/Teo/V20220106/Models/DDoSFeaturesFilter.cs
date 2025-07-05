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

    public class DDoSFeaturesFilter : AbstractModel
    {
        
        /// <summary>
        /// Action. `drop`: Drop the request; `transmit`: Allow the request; `drop_block`: Drop the request and block it; `forward`: Continue to offer protection.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Sets how far from the first search position
        /// </summary>
        [JsonProperty("Depth")]
        public long? Depth{ get; set; }

        /// <summary>
        /// Sets how far from the second search position
        /// </summary>
        [JsonProperty("Depth2")]
        public long? Depth2{ get; set; }

        /// <summary>
        /// End of the destination port
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// Start of the destination port
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// Whether to match string 1 that does not contain all the specified elements
        /// </summary>
        [JsonProperty("IsNot")]
        public long? IsNot{ get; set; }

        /// <summary>
        /// Whether to match string 2 that does not contain all the specified elements
        /// </summary>
        [JsonProperty("IsNot2")]
        public long? IsNot2{ get; set; }

        /// <summary>
        /// Logical operator that combines two conditions. Values: `none`, `and` and `or`. If there is only one condition, pass in `none` for this condition only.
        /// </summary>
        [JsonProperty("MatchLogic")]
        public string MatchLogic{ get; set; }

        /// <summary>
        /// Matching method of the first condition. `pcre`: Regex match; `sunday`: String match.
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// Matching method of the second condition. `pcre`: Regex match; `sunday`: String match.
        /// </summary>
        [JsonProperty("MatchType2")]
        public string MatchType2{ get; set; }

        /// <summary>
        /// Offset from the first search position
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Offset from the second search position
        /// </summary>
        [JsonProperty("Offset2")]
        public long? Offset2{ get; set; }

        /// <summary>
        /// Maximum packet length
        /// </summary>
        [JsonProperty("PacketMax")]
        public long? PacketMax{ get; set; }

        /// <summary>
        /// Minimum packet length
        /// </summary>
        [JsonProperty("PacketMin")]
        public long? PacketMin{ get; set; }

        /// <summary>
        /// Protocol. Values: `tcp`, `udp`, `icmp` and `all`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// End of the source port
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// Start of the source port
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// String in the first condition
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// String in the second condition
        /// </summary>
        [JsonProperty("Str2")]
        public string Str2{ get; set; }

        /// <summary>
        /// Layer at which each match starts. Values: `begin_l5`, `no_match`, `begin_l3` and `begin_l4`.
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// Layer at which each match starts. Values: `begin_l5`, `no_match`, `begin_l3` and `begin_l4`.
        /// </summary>
        [JsonProperty("MatchBegin2")]
        public string MatchBegin2{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "Depth2", this.Depth2);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "IsNot2", this.IsNot2);
            this.SetParamSimple(map, prefix + "MatchLogic", this.MatchLogic);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "MatchType2", this.MatchType2);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Offset2", this.Offset2);
            this.SetParamSimple(map, prefix + "PacketMax", this.PacketMax);
            this.SetParamSimple(map, prefix + "PacketMin", this.PacketMin);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "Str2", this.Str2);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "MatchBegin2", this.MatchBegin2);
        }
    }
}

