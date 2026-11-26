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

    public class ModifySecurityPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Security policy configuration.<li>When ExceptionRules in the SecurityPolicy parameter is set, ExceptConfig in the SecurityConfig parameter will be ignored;</li><li>When CustomRules in the SecurityPolicy parameter is set, AclConfig and IpTableConfig in the SecurityConfig parameter will be ignored;</li><li>When HttpDDoSProtection and RateLimitingRules in the SecurityPolicy parameter are set, RateLimitConfig in the SecurityConfig parameter will be ignored;</li><li>When ManagedRule in the SecurityPolicy parameter is set, WafConfig in the SecurityConfig parameter will be ignored;</li><li>When BotManagement in the SecurityPolicy parameter is set, BotConfig in the SecurityConfig parameter will be ignored;</li><li>For exception rules, custom rules, rate limits, managed rules, and bot management policies, it is recommended to use the SecurityPolicy parameter for configuration.</li>
        /// </summary>
        [JsonProperty("SecurityConfig")]
        public SecurityConfig SecurityConfig{ get; set; }

        /// <summary>
        /// Security policy configuration. For Web exception rules, custom protection policies, rate rules, managed rules, and Bot management configuration, we recommend using expression syntax to configure security policies.
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public SecurityPolicy SecurityPolicy{ get; set; }

        /// <summary>
        /// Security policy type. The following parameter values are available: <li>ZoneDefaultPolicy: used to specify a site-level policy;</li><li>Template: used to specify a policy template. You need to simultaneously specify the TemplateId parameter;</li><li>Host: used to specify a domain-level policy (Note: when using a domain name to specify a domain name service policy, only DNS that has already applied a domain-level policy or policy template is supported).</li>
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }

        /// <summary>
        /// Specified domain name. When the value of the `Entity` parameter is `Host`, use this parameter to specify a domain-level policy. For example, use `www.example.com` to configure the domain-level policy for that domain name.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Specify the policy template ID. When the Entity parameter value is Template, use this parameter to specify the policy template ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "SecurityConfig.", this.SecurityConfig);
            this.SetParamObj(map, prefix + "SecurityPolicy.", this.SecurityPolicy);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

