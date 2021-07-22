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

    public class BGPIPInstanceSpecification : AbstractModel
    {
        
        /// <summary>
        /// Base protection bandwidth (in Gbps)
        /// </summary>
        [JsonProperty("ProtectBandwidth")]
        public ulong? ProtectBandwidth{ get; set; }

        /// <summary>
        /// CC protection bandwidth (in QPS)
        /// </summary>
        [JsonProperty("ProtectCCQPS")]
        public ulong? ProtectCCQPS{ get; set; }

        /// <summary>
        /// Normal application bandwidth (in Mbps)
        /// </summary>
        [JsonProperty("NormalBandwidth")]
        public ulong? NormalBandwidth{ get; set; }

        /// <summary>
        /// Number of forwarding rules
        /// </summary>
        [JsonProperty("ForwardRulesLimit")]
        public ulong? ForwardRulesLimit{ get; set; }

        /// <summary>
        /// Auto-renewal status. Valid values:
        /// `0`: disabled
        /// `1`: enabled
        /// ]
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Anti-DDoS Advanced line. Valid values:
        /// `1`: BGP
        /// `2`: China Telecom
        /// `3`: China Unicom
        /// `4`: China Mobile
        /// `99`: third-party line
        /// ]
        /// </summary>
        [JsonProperty("Line")]
        public ulong? Line{ get; set; }

        /// <summary>
        /// Elastic protection bandwidth (in Gbps)
        /// </summary>
        [JsonProperty("ElasticBandwidth")]
        public ulong? ElasticBandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectBandwidth", this.ProtectBandwidth);
            this.SetParamSimple(map, prefix + "ProtectCCQPS", this.ProtectCCQPS);
            this.SetParamSimple(map, prefix + "NormalBandwidth", this.NormalBandwidth);
            this.SetParamSimple(map, prefix + "ForwardRulesLimit", this.ForwardRulesLimit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "ElasticBandwidth", this.ElasticBandwidth);
        }
    }
}

