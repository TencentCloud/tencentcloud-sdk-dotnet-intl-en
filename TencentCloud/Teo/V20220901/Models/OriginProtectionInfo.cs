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

    public class OriginProtectionInfo : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Domain name list.
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// List of proxy IDs.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// IP allowlist of the current version.
        /// </summary>
        [JsonProperty("CurrentIPWhitelist")]
        public IPWhitelist CurrentIPWhitelist{ get; set; }

        /// <summary>
        /// Whether to update the origin server allowlist for this site. Valid values:
        /// <li>true: The IP allowlist needs to be updated;</li>
        /// <li>false: No need to update the IP allowlist.</li>
        /// </summary>
        [JsonProperty("NeedUpdate")]
        public bool? NeedUpdate{ get; set; }

        /// <summary>
        /// Origin protection status. Valid values:
        /// <li>online: origin protection enabled;</li>
        /// <li>offline: Origin protection disabled;</li>
        /// <li>nonactivate: Origin protection is inactive. It is only returned in calls for sites that have never used the origin protection feature.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether origin protection is supported for the site package, with values:
        /// <li>true: support;</li>
        /// <li>false: not supported.</li>
        /// </summary>
        [JsonProperty("PlanSupport")]
        public bool? PlanSupport{ get; set; }

        /// <summary>
        /// Comparison between the latest IP allowlist and the current IP allowlist.
        /// </summary>
        [JsonProperty("DiffIPWhitelist")]
        public DiffIPWhitelist DiffIPWhitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
            this.SetParamObj(map, prefix + "CurrentIPWhitelist.", this.CurrentIPWhitelist);
            this.SetParamSimple(map, prefix + "NeedUpdate", this.NeedUpdate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PlanSupport", this.PlanSupport);
            this.SetParamObj(map, prefix + "DiffIPWhitelist.", this.DiffIPWhitelist);
        }
    }
}

