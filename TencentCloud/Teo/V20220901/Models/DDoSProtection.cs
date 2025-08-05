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
        /// Specifies the protection scope of standalone DDoS. valid values:.
        /// <li>protect_all_domains: specifies exclusive Anti-DDoS protection for all domain names in the site. newly added domain names automatically enable exclusive Anti-DDoS protection. when this parameter is specified, DomainDDoSProtections will not be processed.</li>.
        /// <li>protect_specified_domains: only applicable to specified domains. specific scope can be set via DomainDDoSProtection parameter.</li>.
        /// </summary>
        [JsonProperty("ProtectionOption")]
        public string ProtectionOption{ get; set; }

        /// <summary>
        /// Anti-DDoS configuration of the domain. specifies the exclusive ddos protection settings for the domain in request parameters.
        /// <li>When ProtectionOption remains protect_specified_domains, the domain names not filled in keep their exclusive Anti-DDoS protection configuration unchanged, while explicitly specified domain names are updated according to the input parameters.</li>.
        /// <li>When ProtectionOption switches from protect_all_domains to protect_specified_domains: if DomainDDoSProtections is empty, disable exclusive DDoS protection for all domains under the site; if DomainDDoSProtections is not empty, disable or maintain exclusive DDoS protection for the domain names specified in the parameter, and disable exclusive DDoS protection for other unlisted domain names.</li>.
        /// </summary>
        [JsonProperty("DomainDDoSProtections")]
        public DomainDDoSProtection[] DomainDDoSProtections{ get; set; }

        /// <summary>
        /// Specifies the exclusive DDoS protection configuration of a shared CNAME. used as an output parameter.
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

