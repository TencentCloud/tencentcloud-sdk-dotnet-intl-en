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

    public class CreatePlanForZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Type of the package to purchase. Valid values:
        /// <li> sta: Global content delivery network (excluding Chinese mainland) Standard Edition Plan; </li>
        /// <li> sta_with_bot: Standard Edition Plan of the global content delivery network (excluding Chinese mainland) with bundled bot management;</li>
        /// <li> sta_cm: CDN Standard Edition Plan for the Chinese mainland; </li>
        /// <li> sta_cm_with_bot: CDN Standard Edition Plan on the Chinese mainland with bundled bot management;</li>
        /// <li> sta_global: Global content delivery network (including Chinese mainland) Standard Edition Plan; </li>
        /// <li> sta_global_with_bot: Standard Edition Plan of global content delivery network (including Chinese mainland) with bundled bot management;</li>
        /// <li> ent: Enterprise plan for global content delivery network (excluding Chinese mainland); </li>
        /// <li> ent_with_bot: Enterprise package of global content delivery network (excluding Chinese mainland) with bundled bot management;</li>
        /// <li> ent_cm: CDN enterprise plan for the Chinese mainland; </li>
        /// <li> ent_cm_with_bot: CDN enterprise plan on the Chinese mainland with bundled bot management.</li>
        /// <li> ent_global: Enterprise package for global content delivery network (including Chinese mainland); </li>
        /// <li> ent_global_with_bot: Enterprise package of global content delivery network (including Chinese mainland) with bundled bot management.</li>For the package types available for the current account, refer to the response of <a href="https://www.tencentcloud.com/document/product/1552/80606?from_cn_redirect=1">DescribeAvailablePlans</a>.
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
        }
    }
}

