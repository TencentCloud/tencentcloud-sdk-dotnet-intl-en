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
        /// <p>Entity type.</p><p>Enumeration value:</p><ul><li>WebSec.ZonePolicy: Site-level protection strategy</li><li>WebSec.HostPolicy: Domain-level security policy</li><li>WebSec.Template: Policy template</li><li>DDoS.L4Proxy: Layer 4 proxy DDoS protection</li><li>DDoS.L3Transit: Layer-3 transit DDoS protection</li></ul>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// <p>The physical identification represents different meanings based on EntityType:</p><ul><li>WebSec.ZonePolicy: site ID;</li><li>WebSec.HostPolicy: domain name;</li><li>WebSec.Template: template ID;</li><li>DDoS.L4Proxy: instance ID;</li><li>DDoS.L3Transit: instance ID.</li></ul>
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// <p>Entity identification represents different meanings based on EntityType:</p><ul><li>WebSec.ZonePolicy: empty;</li><li>WebSec.HostPolicy: empty;</li><li>WebSec.Template: template name;</li><li>DDoS.L4Proxy: empty;</li><li>DDoS.L3Transit: empty.</li></ul>
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// <p>Sub-entity type.</p><p>Enumeration value:</p><ul><li>WebSec.ExceptionRule: Protection exception rule</li><li>WebSec.BasicAccessRule: Basic access control</li><li>WebSec.PreciseMatchRule: Precise matching rule</li><li>WebSec.RateLimitRule: Precision rate limiting</li><li>WebSec.BotCustomRule: Advanced bot management - custom rule</li><li>DDoS.L4Proxy.IpAccessControl: Layer 4 proxy ddos protection - IP blocklist and allowlist</li><li>DDoS.L3Transit.IpAccessControl: Layer-3 transit ddos protection - IP blocklist and allowlist</li></ul>
        /// </summary>
        [JsonProperty("SubEntityType")]
        public string SubEntityType{ get; set; }

        /// <summary>
        /// <p>Sub-entity ID, which represents different meanings according to SubEntityType:</p><ul><li>WebSec.ExceptionRule: rule ID;</li><li>WebSec.BasicAccessRule: rule ID;</li><li>WebSec.PreciseMatchRule: rule ID;</li><li>WebSec.RateLimitRule: rule ID;</li><li>WebSec.BotCustomRule: rule ID;</li><li>DDoS.L4Proxy.IpAccessControl: null;</li><li>DDoS.L3Transit.IpAccessControl: null. </li></ul><p>EntityType and SubEntityType are correspondences, and different EntityTypes support different SubEntityTypes. <br>WebSec.ZonePolicy, WebSec.HostPolicy, and WebSec.Template support the following SubEntityTypes:</p><ul><li>WebSec.ExceptionRule;</li><li>WebSec.BasicAccessRule;</li><li>WebSec.PreciseMatchRule;</li><li>WebSec.RateLimitRule;</li><li>WebSec.BotCustomRule. </li></ul>DDoS.L4Proxy supports the following SubEntityTypes: <ul><li>DDoS.L4Proxy.IpAccessControl;</li></ul> DDoS.L3Transit supports the following SubEntityTypes: <ul><li>DDoS.L3Transit.IpAccessControl. </li></ul>
        /// </summary>
        [JsonProperty("SubEntityId")]
        public string SubEntityId{ get; set; }

        /// <summary>
        /// <p>Sub-entity name. It represents different meanings based on SubEntityType:</p><ul><li>WebSec.ExceptionRule: rule name;</li><li>WebSec.BasicAccessRule: rule name;</li><li>WebSec.PreciseMatchRule: rule name;</li><li>WebSec.RateLimitRule: rule name;</li><li>WebSec.BotCustomRule: rule name;</li><li>DDoS.L4Proxy.IpAccessControl: rule name, block indicates blocklist, allow indicates allowlist;</li><li>DDoS.L3Transit.IpAccessControl: rule name, block indicates blocklist, allow indicates allowlist.</li></ul>
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

