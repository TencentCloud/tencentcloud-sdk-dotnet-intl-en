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

    public class ModifyZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site access method. Valid values:
        /// <li>full: NS access.</li>
        /// <li>partial: CNAME access. If the site is currently accessed with no domain name, it can be switched only to CNAME access.</li>
        /// <li>dnsPodAccess: DNSPod hosted access. To use this access mode, your domain name should have been hosted on DNSPod.</li>If this parameter is not input, the original configuration is maintained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The custom name servers. The original configuration applies if this field is not specified. It is not allowed to pass this field when a site is connected without using a domain name.
        /// </summary>
        [JsonProperty("VanityNameServers")]
        public VanityNameServers VanityNameServers{ get; set; }

        /// <summary>
        /// The site alias. It can be up to 20 characters consisting of digits, letters, hyphens (-) and underscores (_).
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }

        /// <summary>
        /// The region where the site requests access. Values:
        /// <li> `global`: Global coverage</li>
        /// <li> `mainland`: Chinese mainland</li>
        /// <li> `overseas`: Outside the Chinese mainland </li>It is not allowed to pass this field when a site is connected without using a domain name.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Name of the site. This field takes effect only when the site switches from domainless access to CNAME access.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "VanityNameServers.", this.VanityNameServers);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
        }
    }
}

