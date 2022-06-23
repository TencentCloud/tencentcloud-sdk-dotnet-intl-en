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
        /// Number of protection IPs
        /// </summary>
        [JsonProperty("ProtectIPNumberLimit")]
        public ulong? ProtectIPNumberLimit{ get; set; }

        /// <summary>
        /// Auto-renewal status. Valid values:
        /// `0`: disabled
        /// `1`: enabled
        /// ]
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Protection type of Anti-DDoS Pro. Valid values: `0` (general protection) and `1` (Lighthouse-based protection).
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnionPackFlag")]
        public ulong? UnionPackFlag{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ServiceBandWidth")]
        public ulong? ServiceBandWidth{ get; set; }


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
        }
    }
}

