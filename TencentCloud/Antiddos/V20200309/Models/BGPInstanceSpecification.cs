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

    public class BGPInstanceSpecification : AbstractModel
    {
        
        /// <summary>
        /// Base protection bandwidth (in Gbps)
        /// </summary>
        [JsonProperty("ProtectBandwidth")]
        public ulong? ProtectBandwidth{ get; set; }

        /// <summary>
        /// Number of protection chances
        /// </summary>
        [JsonProperty("ProtectCountLimit")]
        public ulong? ProtectCountLimit{ get; set; }

        /// <summary>
        /// Number of protected IPs
        /// </summary>
        [JsonProperty("ProtectIPNumberLimit")]
        public ulong? ProtectIPNumberLimit{ get; set; }

        /// <summary>
        /// Auto-renewal status. Values:
        /// `0`: Disabled
        /// `1`: Enabled
        /// ]
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Protection type of Anti-DDoS Pro. Valid values: `0` (general protection) and `1` (Lighthouse-based protection).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnionPackFlag")]
        public ulong? UnionPackFlag{ get; set; }

        /// <summary>
        /// Application bandwidth
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceBandWidth")]
        public ulong? ServiceBandWidth{ get; set; }

        /// <summary>
        /// Whether it’s an Anti-DDoS Pro Premium edition. Values: `0` (General edition); `1` (Premium edition).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BattleEditionFlag")]
        public ulong? BattleEditionFlag{ get; set; }

        /// <summary>
        /// Whether it’s an Anti-DDoS Pro Standard edition. Values: `0` (General edition); `1` (Standard edition).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChannelEditionFlag")]
        public ulong? ChannelEditionFlag{ get; set; }

        /// <summary>
        /// Whether it’s an Anti-DDoS Pro Enterprise edition. Values: `0` (General edition); `1` (Enterprise edition).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnterpriseFlag")]
        public ulong? EnterpriseFlag{ get; set; }

        /// <summary>
        /// Elastic bandwidth threshold of the Anti-DDoS Pro Enterprise edition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public ulong? ElasticLimit{ get; set; }

        /// <summary>
        /// Protection bandwidth after the plan downgrade, in Gbps. 
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DownGradeProtect")]
        public ulong? DownGradeProtect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectBandwidth", this.ProtectBandwidth);
            this.SetParamSimple(map, prefix + "ProtectCountLimit", this.ProtectCountLimit);
            this.SetParamSimple(map, prefix + "ProtectIPNumberLimit", this.ProtectIPNumberLimit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "UnionPackFlag", this.UnionPackFlag);
            this.SetParamSimple(map, prefix + "ServiceBandWidth", this.ServiceBandWidth);
            this.SetParamSimple(map, prefix + "BattleEditionFlag", this.BattleEditionFlag);
            this.SetParamSimple(map, prefix + "ChannelEditionFlag", this.ChannelEditionFlag);
            this.SetParamSimple(map, prefix + "EnterpriseFlag", this.EnterpriseFlag);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
            this.SetParamSimple(map, prefix + "DownGradeProtect", this.DownGradeProtect);
        }
    }
}

