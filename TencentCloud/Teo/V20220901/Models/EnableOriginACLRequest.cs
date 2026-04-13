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

    public class EnableOriginACLRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// When first enabling origin protection for a site, configure the layer-7 acceleration domain name in specific IP range mode.
        /// <li>ALL: Target all layer-7 acceleration domain names under the current site. When the number of domains exceeds 200, please go through first in specific mode to enable 200 domain names, and enable the remaining resource via the ModifyOriginACL API.</li>
        /// <li>Specific: Enables layer-7 acceleration for the site's designated domain name.</li>Note: When no parameter is defined, the default is specific. For subsequent addition of layer-7 acceleration domain names or layer-4 proxy instances, configure them via the ModifyOriginACL API.
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// Enable the list of layer-7 acceleration domain names with origin protection. this parameter is valid only when L7EnableMode is set to specific. when L7EnableMode is set to all, retain this parameter as empty. only supports up to 200 layer-7 acceleration domain names in a single operation.
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// When first enabling origin protection for a site, configure the Layer 4 Proxy Instance Configuration in specific IP range mode.
        /// <li>ALL: Enable all L4 proxy instances under the current site. When the instance count exceeds 100, please go through specific mode to enable 100 domain names first. Enable the remaining resources via the ModifyOriginACL API.</li>
        /// <li>specific: Enable for the designated L4 proxy instance under the site.</li>Note: When no parameter is defined, the default is specific. Configure subsequent addition of L7 acceleration domains/L4 proxy instances via the ModifyOriginACL API.
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// The list of L4 proxy instances with origin protection enabled. this parameter is valid only when L4EnableMode is set to specific. retain this parameter empty when L4EnableMode is set to all. only supports up to 100 layer-4 proxy instances per operation.
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// The origin protection back-to-origin ACL control domain. If left empty, the standard global control domain is used by default. Available control domain information can be obtained through the DescribeAvailableOriginACLFamily API query.
        /// Valid values are as follows:
        /// <li>gaz: Standard global availability zone control domain;</li>
        /// <li>mlc: Standard Chinese mainland availability zone control domain;</li>
        /// <li>emc: Standard global (exclude Chinese mainland) availability zone control domain;</li>
        /// <li>plat-gaz: Simplify global availability zone control domain;</li>
        /// <li>plat-mlc: Simplified Chinese mainland availability zone control domain;</li>
        /// <li>plat-emc: Simplify the global (excluding Chinese mainland) availability zone control domain;</li>
        /// </summary>
        [JsonProperty("OriginACLFamily")]
        public string OriginACLFamily{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "L7EnableMode", this.L7EnableMode);
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

