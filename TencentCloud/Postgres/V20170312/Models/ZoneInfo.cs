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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// AZ abbreviation
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// AZ number
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Availability status. Valid values:
        /// `UNAVAILABLE`.
        /// `AVAILABLE`.
        /// `SELLOUT`.
        /// `SUPPORTMODIFYONLY` (supports configuration adjustment).
        /// </summary>
        [JsonProperty("ZoneState")]
        public string ZoneState{ get; set; }

        /// <summary>
        /// Whether the AZ supports IPv6 address access
        /// </summary>
        [JsonProperty("ZoneSupportIpv6")]
        public ulong? ZoneSupportIpv6{ get; set; }

        /// <summary>
        /// AZs that can be used as standby when this AZ is primary
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandbyZoneSet")]
        public string[] StandbyZoneSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneState", this.ZoneState);
            this.SetParamSimple(map, prefix + "ZoneSupportIpv6", this.ZoneSupportIpv6);
            this.SetParamArraySimple(map, prefix + "StandbyZoneSet.", this.StandbyZoneSet);
        }
    }
}

