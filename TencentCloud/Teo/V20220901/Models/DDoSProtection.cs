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

    public class DDoSProtection : AbstractModel
    {
        
        /// <summary>
        /// Specify the protection scope of standalone DDoS. Value:
        /// <li> protect_all_domains: exclusive DDoS protection takes effect for all domains in the site. Newly added domain names automatically enable exclusive DDoS protection. When the input parameter is protect_all_domains, the input parameter DomainDDoSProtections will not be processed;</li>
        /// <li> protect_specified_domains: only applicable to specified domains. The specific scope can be specified via the DomainDDoSProtection parameter.</li>
        /// </summary>
        [JsonProperty("ProtectionOption")]
        public string ProtectionOption{ get; set; }

        /// <summary>
        /// Exclusive DDoS protection configuration of the domain. In the input parameter scenario:
        /// <li> When ProtectionOption remains protect_specified_domains: domains not filled in keep their exclusive DDoS protection configuration unchanged, and explicitly specified domains are updated based on the input parameter;</li>
        /// <li> When ProtectionOption is switched from protect_all_domains to protect_specified_domains: if DomainDDoSProtections is empty, exclusive DDoS protection is disabled for all domain names under the site; if DomainDDoSProtections is not empty, exclusive DDoS protection is disabled or retained for the specified domain names in the parameter, and exclusive DDoS protection is disabled for the rest of the unlisted domain names.</li>
        /// </summary>
        [JsonProperty("DomainDDoSProtections")]
        public DomainDDoSProtection[] DomainDDoSProtections{ get; set; }

        /// <summary>
        /// Configuration of exclusive DDoS protection with a shared CNAME. Used only as an output parameter.
        /// </summary>
        [JsonProperty("SharedCNAMEDDoSProtections")]
        public DomainDDoSProtection[] SharedCNAMEDDoSProtections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectionOption", this.ProtectionOption);
            this.SetParamArrayObj(map, prefix + "DomainDDoSProtections.", this.DomainDDoSProtections);
            this.SetParamArrayObj(map, prefix + "SharedCNAMEDDoSProtections.", this.SharedCNAMEDDoSProtections);
        }
    }
}

