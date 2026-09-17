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

    public class IpFilter : AbstractModel
    {
        
        /// <summary>
        /// IP allowlist/blocklist configuration switch. Parameter value:
        /// <li>`on`: Enable;</li>
        /// <li>`off`: Cache.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// IP allowlist/blocklist type:
        /// <li>whitelist: allowlist;</li>
        /// <li>blocklist: blocklist.</li>
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// IP allowlist or blocklist. Supports IPs in the X.X.X.X format or network segments in the /8, /16, or /24 format.
        /// Fill up to 50 allowlist entries or 50 blocklist entries.
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FilterRules")]
        public IpFilterPathRule[] FilterRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
        }
    }
}

