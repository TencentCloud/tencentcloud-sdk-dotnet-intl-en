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

    public class Sv : AbstractModel
    {
        
        /// <summary>
        /// Price inquiry parameter key.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Quotation parameter value.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Quota for inquiry parameter mapping. Valid values:
        /// <li>zone: sites;</li>
        /// <li>custom-rule: number of custom rules;</li>
        /// <li>rate-limiting-rule: rate limiting rule;</li>
        /// <li>l4-proxy-instance: number of L4 proxy instances.</li>
        /// </summary>
        [JsonProperty("Pack")]
        public string Pack{ get; set; }

        /// <summary>
        /// L4 proxy instance Id mapped to the price inquiry parameter.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Inquiry parameter corresponding to the protection level.
        /// Valid values: <li> cm_30G: 30 Gbps baseline protection for the Chinese mainland acceleration area;</li><li> cm_60G: 60 Gbps baseline protection for the Chinese mainland acceleration area;</li><li> cm_100G: 100 Gbps baseline protection for the Chinese mainland acceleration area;</li><li> anycast_300G: 300 Gbps anycast joint protection for the global acceleration region (outside Chinese mainland);</li><li> anycast_unlimited: unlimited anycast full protection for the global acceleration region (outside Chinese mainland);</li><li> cm_30G_anycast_300G: 30 Gbps baseline protection for the Chinese mainland acceleration area, 300 Gbps anycast joint protection for the global acceleration region (outside Chinese mainland);</li><li> cm_30G_anycast_unlimited: 30 Gbps baseline protection for the Chinese mainland acceleration area, unlimited anycast full protection for the global acceleration region (outside Chinese mainland);</li><li> cm_60G_anycast_300G: 60 Gbps baseline protection for the Chinese mainland acceleration area, 300 Gbps anycast joint protection for the global acceleration region (outside Chinese mainland);</li><li> cm_60G_anycast_unlimited: 60 Gbps baseline protection for the Chinese mainland acceleration area, unlimited anycast full protection for the global acceleration region (outside Chinese mainland);</li><li> cm_100G_anycast_300G: 100 Gbps baseline protection for the Chinese mainland acceleration area, 300 Gbps anycast joint protection for the global acceleration region (outside Chinese mainland);</li><li> cm_100G_anycast_unlimited: 100 Gbps baseline protection for the Chinese mainland acceleration area, unlimited anycast full protection for the global acceleration region (outside Chinese mainland).</li>
        /// </summary>
        [JsonProperty("ProtectionSpecs")]
        public string ProtectionSpecs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Pack", this.Pack);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProtectionSpecs", this.ProtectionSpecs);
        }
    }
}

