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

    public class SecurityPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Custom rule configuration.</p>
        /// </summary>
        [JsonProperty("CustomRules")]
        public CustomRules CustomRules{ get; set; }

        /// <summary>
        /// <p>Managed rule configuration.</p>
        /// </summary>
        [JsonProperty("ManagedRules")]
        public ManagedRules ManagedRules{ get; set; }

        /// <summary>
        /// <p>HTTP DDoS protection configuration.</p>
        /// </summary>
        [JsonProperty("HttpDDoSProtection")]
        public HttpDDoSProtection HttpDDoSProtection{ get; set; }

        /// <summary>
        /// <p>Rate limiting rule configuration.</p>
        /// </summary>
        [JsonProperty("RateLimitingRules")]
        public RateLimitingRules RateLimitingRules{ get; set; }

        /// <summary>
        /// <p>Exception rule configuration.</p>
        /// </summary>
        [JsonProperty("ExceptionRules")]
        public ExceptionRules ExceptionRules{ get; set; }

        /// <summary>
        /// <p>Bot management configuration.</p>
        /// </summary>
        [JsonProperty("BotManagement")]
        public BotManagement BotManagement{ get; set; }

        /// <summary>
        /// <p>Basic Bot management configuration.</p>
        /// </summary>
        [JsonProperty("BotManagementLite")]
        public BotManagementLite BotManagementLite{ get; set; }

        /// <summary>
        /// <p>Default block action configuration.</p>
        /// </summary>
        [JsonProperty("DefaultDenySecurityActionParameters")]
        public DefaultDenySecurityActionParameters DefaultDenySecurityActionParameters{ get; set; }

        /// <summary>
        /// <p>Security headers to include in requests to the origin. After the configuration takes effect, request headers with the corresponding `keyname` will be sent to the origin.</p>
        /// </summary>
        [JsonProperty("SecurityHeadersToOrigin")]
        public SecurityHeadersToOrigin SecurityHeadersToOrigin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CustomRules.", this.CustomRules);
            this.SetParamObj(map, prefix + "ManagedRules.", this.ManagedRules);
            this.SetParamObj(map, prefix + "HttpDDoSProtection.", this.HttpDDoSProtection);
            this.SetParamObj(map, prefix + "RateLimitingRules.", this.RateLimitingRules);
            this.SetParamObj(map, prefix + "ExceptionRules.", this.ExceptionRules);
            this.SetParamObj(map, prefix + "BotManagement.", this.BotManagement);
            this.SetParamObj(map, prefix + "BotManagementLite.", this.BotManagementLite);
            this.SetParamObj(map, prefix + "DefaultDenySecurityActionParameters.", this.DefaultDenySecurityActionParameters);
            this.SetParamObj(map, prefix + "SecurityHeadersToOrigin.", this.SecurityHeadersToOrigin);
        }
    }
}

