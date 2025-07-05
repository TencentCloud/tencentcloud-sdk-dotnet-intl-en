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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalyseConditionDetail : AbstractModel
    {
        
        /// <summary>
        /// ProductNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Business")]
        public AnalyseBusinessDetail[] Business{ get; set; }

        /// <summary>
        /// ItemNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Project")]
        public AnalyseProjectDetail[] Project{ get; set; }

        /// <summary>
        /// RegionNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public AnalyseRegionDetail[] Region{ get; set; }

        /// <summary>
        /// Billing modeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public AnalysePayModeDetail[] PayMode{ get; set; }

        /// <summary>
        /// Transaction typeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionType")]
        public AnalyseActionTypeDetail[] ActionType{ get; set; }

        /// <summary>
        /// Availability zoneNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zone")]
        public AnalyseZoneDetail[] Zone{ get; set; }

        /// <summary>
        /// Resource owner UINNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public AnalyseOwnerUinDetail[] OwnerUin{ get; set; }

        /// <summary>
        /// Fee typeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Amount")]
        public AnalyseAmountDetail[] Amount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Business.", this.Business);
            this.SetParamArrayObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Region.", this.Region);
            this.SetParamArrayObj(map, prefix + "PayMode.", this.PayMode);
            this.SetParamArrayObj(map, prefix + "ActionType.", this.ActionType);
            this.SetParamArrayObj(map, prefix + "Zone.", this.Zone);
            this.SetParamArrayObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamArrayObj(map, prefix + "Amount.", this.Amount);
        }
    }
}

