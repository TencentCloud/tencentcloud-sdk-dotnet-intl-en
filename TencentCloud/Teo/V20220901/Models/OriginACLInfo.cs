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

    public class OriginACLInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Origin protection mode for layer-7 acceleration domain names. Valid values: <li>all: automatic protection mode. All layer-7 acceleration domain names in the site are included in the origin protection list, including newly added layer-7 acceleration domain names;</li><li>specific: specified protection mode. Only bound layer-7 acceleration domain names are protected.</li></p>
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// <p>List of layer-7 acceleration domain names that have origin-pull from specific origin IP ranges enabled. Empty when origin protection is not enabled.</p>
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// <p>Origin protection mode for layer-4 proxy instances. Valid values: <li>all: automatic protection mode. All layer-4 proxy instances in the site are included in the origin protection list, including newly added layer-4 proxy instances;</li><li>specific: specified protection mode. Only bound layer-4 proxy instances are protected.</li></p>
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// <p>List of layer-4 proxy instances that have origin-pull from specific origin IP ranges enabled. Empty when origin protection is not enabled.</p>
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// <p>Currently effective origin IP range. Empty when origin protection is not enabled.</p>
        /// </summary>
        [JsonProperty("CurrentOriginACL")]
        public CurrentOriginACL CurrentOriginACL{ get; set; }

        /// <summary>
        /// <p>When the origin IP range is updated, this field returns the origin IP range that will take effect in the next version, including a comparison with the current origin IP range. Empty when there is no update or origin protection is not enabled.</p>
        /// </summary>
        [JsonProperty("NextOriginACL")]
        public NextOriginACL NextOriginACL{ get; set; }

        /// <summary>
        /// <p>Origin protection status. Valid values:</p><li>online: Effective;</li><li>offline: Disabled;</li><li>updating: Configuration being deployed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Origin protection origin-pull ACL control domain.</p>
        /// </summary>
        [JsonProperty("OriginACLFamily")]
        public string OriginACLFamily{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "L7EnableMode", this.L7EnableMode);
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamObj(map, prefix + "CurrentOriginACL.", this.CurrentOriginACL);
            this.SetParamObj(map, prefix + "NextOriginACL.", this.NextOriginACL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

