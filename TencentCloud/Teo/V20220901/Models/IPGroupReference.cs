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

    public class IPGroupReference : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Entity type.</p><p>Enumeration values:</p><ul><li>WebSec.ZonePolicy: site-level security policy</li><li>WebSec.HostPolicy: domain-level security policy</li><li>WebSec.Template: policy template</li><li>DDoS.L4Proxy: Layer 4 proxy DDoS protection</li><li>DDoS.L3Transit: layer-3 anycast DDoS protection</li></ul>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// <p>Entity identification, representing different meanings based on EntityType:</p><ul><li>WebSec.ZonePolicy: site ID;</li><li>WebSec.HostPolicy: domain name;</li><li>WebSec.Template: template ID;</li><li>DDoS.L4Proxy: instance ID;</li><li>DDoS.L3Transit: instance ID.</li></ul>
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// <p>Entity identifier. Its meaning varies based on EntityType:</p><ul><li>WebSec.ZonePolicy: empty;</li><li>WebSec.HostPolicy: empty;</li><li>WebSec.Template: Template name;</li><li>DDoS.L4Proxy: empty;</li><li>DDoS.L3Transit: empty.</li></ul>
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// <p>Sub-entity type.</p><p>Enumeration values:</p><ul><li>WebSec.ExceptionRule: protection exception rule</li><li>WebSec.BasicAccessRule: basic access control</li><li>WebSec.PreciseMatchRule: exact match rule</li><li>WebSec.RateLimitRule: precision rate limiting</li><li>WebSec.BotCustomRule: advanced bot management - custom rule</li><li>DDoS.L4Proxy.IpAccessControl: Layer 4 proxy DDoS protection - IP blocklist/allowlist</li><li>DDoS.L3Transit.IpAccessControl: layer-3 transit DDoS protection - IP blocklist/allowlist</li></ul>
        /// </summary>
        [JsonProperty("SubEntityType")]
        public string SubEntityType{ get; set; }

        /// <summary>
        /// <p>Sub-entity identifier. It represents different meanings based on SubEntityType:</p><ul><li>WebSec.ExceptionRule: rule ID;</li><li>WebSec.BasicAccessRule: rule ID;</li><li>WebSec.PreciseMatchRule: rule ID;</li><li>WebSec.RateLimitRule: rule ID;</li><li>WebSec.BotCustomRule: rule ID;</li><li>DDoS.L4Proxy.IpAccessControl: empty;</li><li>DDoS.L3Transit.IpAccessControl: empty.</li></ul><p>EntityType corresponds to SubEntityType. Different EntityType supports different SubEntityType.<br>WebSec.ZonePolicy, WebSec.HostPolicy, and WebSec.Template support the following SubEntityType:</p><ul><li>WebSec.ExceptionRule;</li><li>WebSec.BasicAccessRule;</li><li>WebSec.PreciseMatchRule;</li><li>WebSec.RateLimitRule;</li><li>WebSec.BotCustomRule.</li></ul>DDoS.L4Proxy supports the following SubEntityType:<ul><li>DDoS.L4Proxy.IpAccessControl;</li></ul>DDoS.L3Transit supports the following SubEntityType:<ul><li>DDoS.L3Transit.IpAccessControl.</li></ul>
        /// </summary>
        [JsonProperty("SubEntityId")]
        public string SubEntityId{ get; set; }

        /// <summary>
        /// <p>Sub-entity name, which represents different meanings according to SubEntityType:</p><ul><li>WebSec.ExceptionRule: rule name;</li><li>WebSec.BasicAccessRule: rule name;</li><li>WebSec.PreciseMatchRule: rule name;</li><li>WebSec.RateLimitRule: rule name;</li><li>WebSec.BotCustomRule: rule name;</li><li>DDoS.L4Proxy.IpAccessControl: rule name, where block means blocklist and allow means allowlist;</li><li>DDoS.L3Transit.IpAccessControl: rule name, where block means blocklist and allow means allowlist.</li></ul>
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

