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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateResourceGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource group ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// **Change configuration (cannot include both modification, renewal, and resource package quantity changes). configuration changes cannot modify the resource group type.**.
        /// 
        /// Real-Time integration resource group.  
        /// -i32c (real-time data sync - 16c64G).
        /// 
        /// Offline integration resource group.
        /// -integrated (offline data sync-8C16G).
        /// -i16 (offline data sync-8C32G).
        /// 
        /// Scheduling resource group.
        /// -test specification.
        /// -S_small (basic specification).
        /// -S_medium (general specifications).
        /// -S_large (professional specification).
        /// 
        /// Data service resource group.
        /// -Test specification.
        /// -ds_s(Basic specification).
        /// -ds_m (general specifications).
        /// -ds_l (professional specification).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Renewal period, unit month (cannot include both modification, renewal, and resource package quantity changes).
        /// </summary>
        [JsonProperty("PurchasePeriod")]
        public long? PurchasePeriod{ get; set; }

        /// <summary>
        /// Add or reduce the number of resource packages (modification, renewal, and changing the number of resource packages cannot include both).
        /// </summary>
        [JsonProperty("Number")]
        public ResourceNumber Number{ get; set; }

        /// <summary>
        /// Auto-Renewal or not. the renewal parameters take effect when PurchasePeriod is not empty.
        /// </summary>
        [JsonProperty("AutoRenewEnabled")]
        public bool? AutoRenewEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PurchasePeriod", this.PurchasePeriod);
            this.SetParamObj(map, prefix + "Number.", this.Number);
            this.SetParamSimple(map, prefix + "AutoRenewEnabled", this.AutoRenewEnabled);
        }
    }
}

