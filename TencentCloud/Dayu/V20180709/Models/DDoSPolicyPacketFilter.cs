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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSPolicyPacketFilter : AbstractModel
    {
        
        /// <summary>
        /// Protocol. Valid values: [tcp, udp, icmp, all]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Start source port. Value range: [0,65535]
        /// </summary>
        [JsonProperty("SportStart")]
        public ulong? SportStart{ get; set; }

        /// <summary>
        /// End source port. Value range: [0,65535]
        /// </summary>
        [JsonProperty("SportEnd")]
        public ulong? SportEnd{ get; set; }

        /// <summary>
        /// Start destination port. Value range: [0,65535]
        /// </summary>
        [JsonProperty("DportStart")]
        public ulong? DportStart{ get; set; }

        /// <summary>
        /// End destination port. Value range: [0,65535]
        /// </summary>
        [JsonProperty("DportEnd")]
        public ulong? DportEnd{ get; set; }

        /// <summary>
        /// Minimum packet length. Value range: [0,1500]
        /// </summary>
        [JsonProperty("PktlenMin")]
        public ulong? PktlenMin{ get; set; }

        /// <summary>
        /// Maximum packet length. Value range: [0,1500]
        /// </summary>
        [JsonProperty("PktlenMax")]
        public ulong? PktlenMax{ get; set; }

        /// <summary>
        /// Whether to detect the payload. Valid values: [
        /// begin_l3 (IP header)
        /// begin_l4 (TCP header)
        /// begin_l5 (payload)
        /// no_match (no check)
        /// ]
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// Whether it is a regular expression. Valid values: [sunday (keyword), pcre (regular expression)]
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// Keyword or regular expression
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// Detection depth. Value range: [0,1500]
        /// </summary>
        [JsonProperty("Depth")]
        public ulong? Depth{ get; set; }

        /// <summary>
        /// Detection offset. Value range: [0,1500]
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Whether to include. Valid values: [0 (no), 1 (yes)]
        /// </summary>
        [JsonProperty("IsNot")]
        public ulong? IsNot{ get; set; }

        /// <summary>
        /// Policy action. Valid values: [drop, drop_black, drop_rst, drop_black_rst, transmit]
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


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
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

