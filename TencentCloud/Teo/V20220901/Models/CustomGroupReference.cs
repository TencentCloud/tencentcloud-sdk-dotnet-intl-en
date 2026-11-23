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

    public class CustomGroupReference : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Entity type.</p><p>Valid values:</p><ul><li>WebSec.ZonePolicy: Site-level protection policy</li><li>WebSec.HostPolicy: Domain-level protection policy</li><li>WebSec.Template: Policy template</li><li>WebSec.APIResource: API resource</li><li>WebSec.JSInjectionRule: Injection rule</li><li>DDoS.L4Proxy: Layer-4 proxy DDoS protection</li><li>DDoS.L3Transit: Layer-3 transit DDoS protection</li></ul>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// <p>Entity identifier, which has different meanings depending on EntityType:</p><ul><li>WebSec.ZonePolicy: Site ID</li><li>WebSec.HostPolicy: Domain</li><li>WebSec.Template: Template ID</li><li>WebSec.APIResource: API resource ID</li><li>WebSec.JSInjectionRule: JavaScript injection rule ID</li><li>DDoS.L4Proxy: Instance ID</li><li>DDoS.L3Transit: Instance ID</li></ul>
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// <p>Entity identifier, which has different meanings depending on EntityType:</p><ul><li>WebSec.ZonePolicy: Empty</li><li>WebSec.HostPolicy: Empty</li><li>WebSec.Template: Template name</li><li>WebSec.APIResource: API resource name</li><li>WebSec.JSInjectionRule: JavaScript injection rule name</li><li>DDoS.L4Proxy: Empty</li><li>DDoS.L3Transit: Empty</li></ul>
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// <p>Sub-entity type.</p><p>Valid values:</p><ul><li>WebSec.ExceptionRule: Protection exception rule</li><li>WebSec.BasicAccessRule: Basic access control</li><li>WebSec.PreciseMatchRule: Precise match rule</li><li>WebSec.RateLimitRule: Precise rate limiting</li><li>WebSec.BotCustomRule: Advanced Bot management - Custom rule</li><li>DDoS.L4Proxy.IpAccessControl: Layer-4 proxy DDoS protection - IP allowlist/blocklist</li><li>DDoS.L3Transit.IpAccessControl: Layer-3 transit DDoS protection - IP allowlist/blocklist</li></ul>
        /// </summary>
        [JsonProperty("SubEntityType")]
        public string SubEntityType{ get; set; }

        /// <summary>
        /// <p>Sub-entity identifier, which has different meanings depending on SubEntityType:</p><ul><li>WebSec.ExceptionRule: Rule ID</li><li>WebSec.BasicAccessRule: Rule ID</li><li>WebSec.PreciseMatchRule: Rule ID</li><li>WebSec.RateLimitRule: Rule ID</li><li>WebSec.BotCustomRule: Rule ID</li><li>DDoS.L4Proxy.IpAccessControl: Empty</li><li>DDoS.L3Transit.IpAccessControl: Empty</li></ul><p>EntityType and SubEntityType are in a mapping relationship. Different EntityTypes support different SubEntityTypes.<br>WebSec.ZonePolicy, WebSec.HostPolicy, and WebSec.Template support the following SubEntityTypes:</p><ul><li>WebSec.ExceptionRule</li><li>WebSec.BasicAccessRule</li><li>WebSec.PreciseMatchRule</li><li>WebSec.RateLimitRule</li><li>WebSec.BotCustomRule</li></ul>DDoS.L4Proxy supports the following SubEntityType:<ul><li>DDoS.L4Proxy.IpAccessControl</li></ul>DDoS.L3Transit supports the following SubEntityType:<ul><li>DDoS.L3Transit.IpAccessControl</li></ul>
        /// </summary>
        [JsonProperty("SubEntityId")]
        public string SubEntityId{ get; set; }

        /// <summary>
        /// <p>Sub-entity name, which has different meanings depending on SubEntityType:</p><ul><li>WebSec.ExceptionRule: Rule name</li><li>WebSec.BasicAccessRule: Rule name</li><li>WebSec.PreciseMatchRule: Rule name</li><li>WebSec.RateLimitRule: Rule name</li><li>WebSec.BotCustomRule: Rule name</li><li>DDoS.L4Proxy.IpAccessControl: Empty</li><li>DDoS.L3Transit.IpAccessControl: Empty</li></ul>
        /// </summary>
        [JsonProperty("SubEntityName")]
        public string SubEntityName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "EntityName", this.EntityName);
            this.SetParamSimple(map, prefix + "SubEntityType", this.SubEntityType);
            this.SetParamSimple(map, prefix + "SubEntityId", this.SubEntityId);
            this.SetParamSimple(map, prefix + "SubEntityName", this.SubEntityName);
        }
    }
}

