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

    public class DDosProtectionConfig : AbstractModel
    {
        
        /// <summary>
        /// Dedicated anti-DDoS specifications in the Chinese mainland. For details, refer to [Dedicated Anti-DDoS Related Fees](https://intl.cloud.tencent.com/document/product/1552/94162?from_cn_redirect=1).
        /// <li>PLATFORM: uses the default protection. Dedicated anti-DDoS is not enabled;</li>
        /// <li>BASE30_MAX300: uses dedicated anti-DDoS, which provides 30 Gbps guaranteed protection bandwidth and up to 300 Gbps elastic protection bandwidth;</li>
        /// <li>BASE60_MAX600: uses dedicated anti-DDoS, which provides 60 Gbps guaranteed protection bandwidth and up to 600 Gbps elastic protection bandwidth. </li>If this field is not specified, the default value 'PLATFORM' will be used.
        /// </summary>
        [JsonProperty("LevelMainland")]
        public string LevelMainland{ get; set; }

        /// <summary>
        /// Configuration of elastic protection bandwidth for exclusive DDoS protection in the Chinese mainland.Valid only when exclusive DDoS protection in the Chinese mainland is enabled (refer to the LevelMainland parameter configuration), and the value has the following limitations:<li>When exclusive DDoS protection is enabled in the Chinese mainland and the 30 Gbps baseline protection bandwidth is used (the LevelMainland parameter value is BASE30_MAX300): the value range is 30 to 300 in Gbps;</li><li>When exclusive DDoS protection is enabled in the Chinese mainland and the 60 Gbps baseline protection bandwidth is used (the LevelMainland parameter value is BASE60_MAX600): the value range is 60 to 600 in Gbps;</li><li>When the default protection of the platform is used (the LevelMainland parameter value is PLATFORM): configuration is not supported, and the value of this parameter is invalid.</li>
        /// </summary>
        [JsonProperty("MaxBandwidthMainland")]
        public ulong? MaxBandwidthMainland{ get; set; }

        /// <summary>
        /// Dedicated anti-DDoS specifications in global regions (excluding the Chinese mainland).
        /// <li>PLATFORM: uses the default protection. Dedicated anti-DDoS is not enabled;</li>
        /// <li>ANYCAST300: uses dedicated anti-DDoS, which provides 300 Gbps protection bandwidth;</li>
        /// <li>ANYCAST_ALLIN: uses dedicated anti-DDoS, which provides all available protection resources. </li>If this field is not specified, the default value 'PLATFORM' will be used.
        /// </summary>
        [JsonProperty("LevelOverseas")]
        public string LevelOverseas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LevelMainland", this.LevelMainland);
            this.SetParamSimple(map, prefix + "MaxBandwidthMainland", this.MaxBandwidthMainland);
            this.SetParamSimple(map, prefix + "LevelOverseas", this.LevelOverseas);
        }
    }
}

