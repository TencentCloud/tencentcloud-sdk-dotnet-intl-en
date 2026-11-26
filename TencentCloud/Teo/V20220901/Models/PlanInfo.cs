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

    public class PlanInfo : AbstractModel
    {
        
        /// <summary>
        /// Settlement currency type. Valid values:
        /// <li> CNY: settlement in RMB; </li>
        /// <li> USD: Dollar settlement.</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Total traffic included in the package. This value is the sum of security acceleration traffic, content acceleration traffic, and smart acceleration traffic (unit: byte).
        /// </summary>
        [JsonProperty("Flux")]
        public ulong? Flux{ get; set; }

        /// <summary>
        /// Billing cycle. Valid values:
        /// <li> y: settle by year; </li>
        /// <li> m: monthly settlement;</li>
        /// <li> h: settled by hour; </li>
        /// <li> M: settle by minute;</li>
        /// <li> s: settle by second. </li>
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// Package type. Valid values:
        /// <li> sta: Global content delivery network (excluding Chinese mainland) Standard Edition Plan; </li>
        /// <li> sta_with_bot: Standard Edition Plan of the global content delivery network (excluding Chinese mainland) with bundled bot management;</li>
        /// <li> sta_cm: CDN Standard Edition Plan for the Chinese mainland; </li>
        /// <li> sta_cm_with_bot: CDN Standard Edition Plan for Chinese mainland with bundled bot management;</li>
        /// <li> sta_global: Global content delivery network (including Chinese mainland) Standard Edition Plan; </li>
        /// <li> sta_global_with_bot: Standard Edition Plan for global content delivery network (including Chinese mainland) with bundled bot management;</li>
        /// <li> ent: Enterprise plan of the global content delivery network (excluding Chinese mainland); </li>
        /// <li> ent_with_bot: Global content delivery network (excluding Chinese mainland) enterprise package with bundled bot management;</li>
        /// <li> ent_cm: Enterprise edition package for CDN in Chinese mainland; </li>
        /// <li> ent_cm_with_bot: CDN enterprise package with bundled bot management in the Chinese mainland;</li>
        /// <li> ent_global: global content delivery network (including Chinese mainland) enterprise package; </li>
        /// <li> ent_global_with_bot: Global content delivery network (including Chinese mainland) enterprise package with bundled bot management.</li>
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// Package pricing (unit: cent).
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// Request count included in the package. This is the security acceleration request count. (Unit: count).
        /// </summary>
        [JsonProperty("Request")]
        public ulong? Request{ get; set; }

        /// <summary>
        /// Number of sites that can be bound to the package.
        /// </summary>
        [JsonProperty("SiteNumber")]
        public ulong? SiteNumber{ get; set; }

        /// <summary>
        /// Acceleration region type of the package. Valid values:
        /// <li>mainland: Chinese mainland;</li>
        /// <li>overseas: global (excluding the Chinese mainland);</li>
        /// <li> global: worldwide (including Chinese mainland). </li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "SiteNumber", this.SiteNumber);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

