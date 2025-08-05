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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSAttackTopDataRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time. the query time range (`EndTime` - `StartTime`) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// The statistical metric. Values:
        /// <li>`ddos_attackFlux_protocol`: Rank protocols by the attack traffic.</li>
        /// <li>`ddos_attackPackageNum_protocol`: Rank protocols by the number of attack packets.</li>
        /// <li>`ddos_attackNum_attackType`: Rank attack types by the number of attacks.</li>
        /// <li>`ddos_attackNum_sregion`: Rank attacker regions by the number of attacks.</li>
        /// <li>`ddos_attackFlux_sip`: Rank attacker IPs by the number of attacks.</li>
        /// <li>`ddos_attackFlux_sregion`: Rank attacker regions by the number of attacks.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Site ID set. this parameter is required. a maximum of 100 site ids can be imported. use `*` to query data for all sites under the tencent cloud root account. to query account-level data, you must have resource permissions for all sites in this api.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// The list of DDoS policy IDs to be specified. All policies will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// The attack type. Values:
        /// <li>`flood`: Flood;</li>
        /// <li>`icmpFlood`: ICMP flood;</li>
        /// <li>`all`: All attack types.</li>This field will be set to the default value `all` if not specified.
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// The protocol type. Values:
        /// <li>`tcp`: TCP protocol;</li>
        /// <li>`udp`: UDP protocol;</li>
        /// <li>`all`: All protocol types.</li>This field will be set to the default value `all` if not specified.
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// The port number.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Queries the top n rows of data. Top 10 rows of data will be queried if this field is not specified.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Data storage region. Values:
        /// <li>`overseas`: Global (outside the Chinese mainland);</li>
        /// <li>`mainland`: Chinese mainland.</li>If this field is not specified, the data storage region will be determined based on the user's location.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

