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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPFilterPolicy : AbstractModel
    {
        
        /// <summary>
        /// IP access restriction status. Optional values:
        /// <li>Enabled: enable;</li>
        /// <li>Disabled: disable.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// IP access restriction type:
        /// <li>Black: blocklist-based verification. Only IP requests from the IPList will be blocked.</li>
        /// <li>White: allowlist-based verification. Only IP requests from the IPList will be allowed.</li>When Status is set to Enabled, FilterType must be assigned.
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// IP list, supporting IPV4 addresses in X.X.X.X format, IPV6 addresses in X:X:X:X:X:X:X:X format, or CIDR notation /N (IPV4: 1 ≤ N ≤ 32; IPV6: 1 ≤ N ≤ 128). A maximum of 200 IPs or CIDR blocks can be added. When Status is set to Enabled, IPList must be assigned.
        /// </summary>
        [JsonProperty("IPList")]
        public string[] IPList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "IPList.", this.IPList);
        }
    }
}

