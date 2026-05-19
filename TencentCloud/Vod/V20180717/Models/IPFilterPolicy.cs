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
        /// IP access restriction status. Available values:
        /// <li>Enabled: enabled;</li>
        /// <li>Disabled: Disabled.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// IP access restriction Type: <li>Black: blocklist method verification. Only IP requests that come from IPList in the list be intercepted.</li>
        /// <li>White: Whitelist method verification. Only IP requests from the IPList are allowed.</li>When the Status value is Enabled, the FilterType must be assigned a value.
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// IP list, supports IPV4 addresses in X.X.X.X format, IPV6 addresses in X:X:X:X:X:X:X:X format, or ranges in /N format (IPV4:1≤N≤32; IPV6:1≤N≤128). Up to 200 IPs or ranges can be filled. When Status value is Enabled, IPList must assign value.
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

