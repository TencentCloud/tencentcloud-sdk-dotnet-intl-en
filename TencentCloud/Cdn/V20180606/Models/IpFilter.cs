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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpFilter : AbstractModel
    {
        
        /// <summary>
        /// IP blocklist/allowlist configuration switch
        /// `on`: Enable
        /// `off`: Disable
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist type
        /// `whitelist`: IP allowlist
        /// `blacklist`: IP blocklist
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist
        /// Supports IPs in X.X.X.X format, or IP ranges in /8, /16, /24 format.
        /// Up to 50 whitelists or blacklists can be entered
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist path-based configuration. This feature is only available to selected beta customers.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FilterRules")]
        public IpFilterPathRule[] FilterRules{ get; set; }

        /// <summary>
        /// [Unavailable soon] The code returned when the IP blocklist/allowlist verification fails.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
        }
    }
}

