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
        /// L7 acceleration domain name activation in origin protection mode.
        /// <li>`all`: enable layer-7 acceleration domain names for the site.</li>.
        /// <Li>Specific: enable for the site's designated layer-7 acceleration domain name.</li>when no parameter is defined, the default is specific.
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// Enable the list of layer-7 acceleration domain names with origin protection. this parameter is valid only when L7EnableMode is set to specific. when L7EnableMode is set to all, retain this parameter as empty. only supports up to 200 layer-7 acceleration domain names in a single operation.
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// Specifies the origin protection mode of the l4 proxy instance.
        /// <Li>ALL: enable for all l4 proxy instances under the site.</li>.
        /// <Li>Specific: enable for the designated layer 4 proxy instance of the site.</li>when no parameter is defined, the default is specific.
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// The list of L4 proxy instances with origin protection enabled. this parameter is valid only when L4EnableMode is set to specific. retain this parameter empty when L4EnableMode is set to all. only supports up to 100 layer-4 proxy instances per operation.
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }


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
        }
    }
}

