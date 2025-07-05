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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSSpeedLimitConfig : AbstractModel
    {
        
        /// <summary>
        /// Rate limit mode. Valid values:
        /// `1`: rate limit based on the real server IP
        /// `2`: rate limit based on the destination port
        /// ]
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Rate limit value. This field contains at least one valid rate limit type. Note that only up to one value of each type is supported.
        /// </summary>
        [JsonProperty("SpeedValues")]
        public SpeedValue[] SpeedValues{ get; set; }

        /// <summary>
        /// This field is replaced with a new field DstPortList.
        /// </summary>
        [JsonProperty("DstPortScopes")]
        public PortSegment[] DstPortScopes{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// IP protocol number. Valid values:
        /// `ALL`: all protocols
        /// `TCP`: TCP protocol
        /// `UDP`: UDP protocol
        /// `SMP`: SMP protocol
        /// `1;2–100`: user-defined protocol with up to 8 ranges
        /// ]
        /// Note: For custom protocol ranges, only protocol number is supported. Multiple ranges are separated by ";". If the value is `ALL`, any other protocol or protocol number should be excluded.
        /// </summary>
        [JsonProperty("ProtocolList")]
        public string ProtocolList{ get; set; }

        /// <summary>
        /// Port range list, which contains up to 8 ranges. Use ";" to separate multiple ports and "–" to indicate a range of ports, as described in the following formats: `0–65535`, `80;443;1000–2000`.
        /// </summary>
        [JsonProperty("DstPortList")]
        public string DstPortList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "SpeedValues.", this.SpeedValues);
            this.SetParamArrayObj(map, prefix + "DstPortScopes.", this.DstPortScopes);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProtocolList", this.ProtocolList);
            this.SetParamSimple(map, prefix + "DstPortList", this.DstPortList);
        }
    }
}

