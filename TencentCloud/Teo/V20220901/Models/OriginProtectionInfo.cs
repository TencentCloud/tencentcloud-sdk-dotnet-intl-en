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

    public class OriginProtectionInfo : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// List of domain names.
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// List of proxy IDs.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// The existing intermediate IPs.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentIPWhitelist")]
        public IPWhitelist CurrentIPWhitelist{ get; set; }

        /// <summary>
        /// Whether the intermediate IP update is needed for the site. Values:
        /// <li>`true`: Update needed;</li>
        /// <li>`false`: Update not needed.</li>
        /// </summary>
        [JsonProperty("NeedUpdate")]
        public bool? NeedUpdate{ get; set; }

        /// <summary>
        /// Status of the origin protection configuration. Values:
        /// <li>`online`: Origin protection is activated;</li>
        /// <li>`offline`: Origin protection is disabled.</li>
        /// <li>`nonactivate`: Origin protection is not activated. This value is returned only when the feature is not activated before it’s used.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether origin protection is supported in the plan. Values:
        /// <li>`true`: Origin protection supported;</li>
        /// <li>`false`: Origin protection not supported.</li>
        /// </summary>
        [JsonProperty("PlanSupport")]
        public bool? PlanSupport{ get; set; }

        /// <summary>
        /// Differences between the latest and existing intermediate IPs.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
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

