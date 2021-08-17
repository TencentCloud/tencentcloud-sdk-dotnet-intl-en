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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PacketFilterConfig : AbstractModel
    {
        
        /// <summary>
        /// Protocol. Valid values: `tcp`, `udp`, `icmp`, `all`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Start source port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// End source port. Value range: 0–65535. The value also should be greater than or equal to that of the start source port.
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// Start destination port
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// End destination port. Value range: 1–65535. The value also should be greater than or equal to that of the start source port.
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// Minimum message length. Value range: 1–1500.
        /// </summary>
        [JsonProperty("PktlenMin")]
        public long? PktlenMin{ get; set; }

        /// <summary>
        /// Maximum message length. Value range: 1–1500. The value also should be greater than or equal to that of the minimum message length.
        /// </summary>
        [JsonProperty("PktlenMax")]
        public long? PktlenMax{ get; set; }

        /// <summary>
        /// Action. Valid values:
        /// `drop`: discards the request.
        /// `transmit`: allows the request.
        /// `drop_black`: discards the request and adds the IP to blocklist.
        /// `drop_rst`: blocks the request.
        /// `drop_black_rst`: blocks the request and adds the IP to blocklist.
        /// `forward`: continues protection.
        /// ]
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Detection location:
        /// `begin_l3`: IP header
        /// `begin_l4`: TCP/UDP header
        /// `begin_l5`: T load
        /// `no_match`: no match
        /// ]
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// Detection type:
        /// `sunday`: keyword
        /// `pcre`: regular expression
        /// ]
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// Detection value. Should be in key string or regular expression. 
        /// When the `MatchType` is `sunday`, enter a string or a string in hexadecimal byte code representation. For example, a string "123" corresponds to the hexadecimal byte code "\x313233".
        /// When the `MatchType` is `pcre`, enter a regular expression.
        /// ]
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// Detection depth starting from the detection position. Value range: [0, 1500].
        /// </summary>
        [JsonProperty("Depth")]
        public long? Depth{ get; set; }

        /// <summary>
        /// Offset starting from the detection position. Value range: [0, Depth].
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Whether the detection value is included:
        /// `0`: included
        /// `1`: excluded
        /// ]
        /// </summary>
        [JsonProperty("IsNot")]
        public long? IsNot{ get; set; }

        /// <summary>
        /// Relationship between the first and second detection conditions:
        /// `and`: under both the first and second detection conditions
        /// `none`: under only the first detection condition
        /// ]
        /// </summary>
        [JsonProperty("MatchLogic")]
        public string MatchLogic{ get; set; }

        /// <summary>
        /// The second detection position:
        /// `begin_l5`: load
        /// `no_match`: no match
        /// ]
        /// </summary>
        [JsonProperty("MatchBegin2")]
        public string MatchBegin2{ get; set; }

        /// <summary>
        /// The second detection type:
        /// `sunday`: keyword
        /// `pcre`: regular expression
        /// ]
        /// </summary>
        [JsonProperty("MatchType2")]
        public string MatchType2{ get; set; }

        /// <summary>
        /// The second detection value. Should be in key string or regular expression.
        /// When the `MatchType` is `sunday`, enter a string or a string in hexadecimal byte code representation. For example, a string "123" corresponds to the hexadecimal byte code "\x313233".
        /// When the `MatchType` is `pcre`, enter a regular expression.
        /// ]
        /// </summary>
        [JsonProperty("Str2")]
        public string Str2{ get; set; }

        /// <summary>
        /// Detection depth starting from the second detection position. Value range: [0, 1500].
        /// </summary>
        [JsonProperty("Depth2")]
        public long? Depth2{ get; set; }

        /// <summary>
        /// Offset starting from the second detection position. Value range: [0, Depth2].
        /// </summary>
        [JsonProperty("Offset2")]
        public long? Offset2{ get; set; }

        /// <summary>
        /// Whether the second detection value is included:
        /// `0`: included
        /// `1`: excluded
        /// ]
        /// </summary>
        [JsonProperty("IsNot2")]
        public long? IsNot2{ get; set; }

        /// <summary>
        /// A rule ID is generated after a feature filtering configuration is added successfully. Leave this field empty when adding a new feature filtering configuration.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "PktlenMin", this.PktlenMin);
            this.SetParamSimple(map, prefix + "PktlenMax", this.PktlenMax);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "MatchLogic", this.MatchLogic);
            this.SetParamSimple(map, prefix + "MatchBegin2", this.MatchBegin2);
            this.SetParamSimple(map, prefix + "MatchType2", this.MatchType2);
            this.SetParamSimple(map, prefix + "Str2", this.Str2);
            this.SetParamSimple(map, prefix + "Depth2", this.Depth2);
            this.SetParamSimple(map, prefix + "Offset2", this.Offset2);
            this.SetParamSimple(map, prefix + "IsNot2", this.IsNot2);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

