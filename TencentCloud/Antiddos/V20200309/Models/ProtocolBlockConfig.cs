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

    public class ProtocolBlockConfig : AbstractModel
    {
        
        /// <summary>
        /// TCP blocking. Valid values: `0` (disabled), `1`(enabled).
        /// </summary>
        [JsonProperty("DropTcp")]
        public long? DropTcp{ get; set; }

        /// <summary>
        /// UDP blocking. Valid values: `0` (disabled), `1`(enabled).
        /// </summary>
        [JsonProperty("DropUdp")]
        public long? DropUdp{ get; set; }

        /// <summary>
        /// ICMP blocking. Valid values: `0` (disabled), `1`(enabled).
        /// </summary>
        [JsonProperty("DropIcmp")]
        public long? DropIcmp{ get; set; }

        /// <summary>
        /// Other protocol blocking. Valid values: `0` (disabled), `1`(enabled).
        /// </summary>
        [JsonProperty("DropOther")]
        public long? DropOther{ get; set; }

        /// <summary>
        /// Null connection protection. Valid values: `0` (disabled), `1` (enabled).
        /// </summary>
        [JsonProperty("CheckExceptNullConnect")]
        public long? CheckExceptNullConnect{ get; set; }

        /// <summary>
        /// PoD protection. Values: `0` (disable), `1` (enable).
        /// </summary>
        [JsonProperty("PingOfDeath")]
        public long? PingOfDeath{ get; set; }

        /// <summary>
        /// Teardrop protection. Values: `0` (disable), `1` (enable).
        /// </summary>
        [JsonProperty("TearDrop")]
        public long? TearDrop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropTcp", this.DropTcp);
            this.SetParamSimple(map, prefix + "DropUdp", this.DropUdp);
            this.SetParamSimple(map, prefix + "DropIcmp", this.DropIcmp);
            this.SetParamSimple(map, prefix + "DropOther", this.DropOther);
            this.SetParamSimple(map, prefix + "CheckExceptNullConnect", this.CheckExceptNullConnect);
            this.SetParamSimple(map, prefix + "PingOfDeath", this.PingOfDeath);
            this.SetParamSimple(map, prefix + "TearDrop", this.TearDrop);
        }
    }
}

