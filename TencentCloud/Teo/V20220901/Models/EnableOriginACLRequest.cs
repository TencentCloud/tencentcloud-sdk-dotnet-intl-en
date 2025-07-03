/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Specifies the site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The mode of configurating origin ACLs for L7 acceleration domains.
        /// - all: configurate origin ACLs for all L7 acceleration domains under the site.
        /// - specific: configurate origin ACLs for designated L7 acceleration domains under the site.
        /// When the parameter is empty, it defaults to specific.
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// The list of L7 acceleration domains that require enabling the origin ACLs. This list must be empty when the request parameter L7EnableMode is set to 'all'. A maximum of 200 domains are supported at a time.
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// The mode of configurating origin ACLs for L4 proxy Instances.
        /// - all: configurate origin ACLs for all L4 proxy Instances under the site.
        /// - specific: configurate origin ACLs for designated  L4 proxy Instances under the site.
        /// When the parameter is empty, it defaults to specific.
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// The list of L4 proxy Instances that require enabling origin ACLs. This list must be empty when the request parameter L4EnableMode is set to 'all'. A maximum of 100 instances are supported at a time.
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

