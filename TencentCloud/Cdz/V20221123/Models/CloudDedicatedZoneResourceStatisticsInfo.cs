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

namespace TencentCloud.Cdz.V20221123.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudDedicatedZoneResourceStatisticsInfo : AbstractModel
    {
        
        /// <summary>
        /// Specifies the item name of resource statistics.
        /// </summary>
        [JsonProperty("Item")]
        public string Item{ get; set; }

        /// <summary>
        /// Resource statistics item measurement unit.
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Total resource amount.
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// Used resources.
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// Specifies the percentage of used resources.
        /// </summary>
        [JsonProperty("UsageRate")]
        public string UsageRate{ get; set; }

        /// <summary>
        /// Remaining resource.
        /// </summary>
        [JsonProperty("Remain")]
        public string Remain{ get; set; }

        /// <summary>
        /// Remaining resource percentage.
        /// </summary>
        [JsonProperty("RemainRate")]
        public string RemainRate{ get; set; }

        /// <summary>
        /// Resource utilization rate at midnight this monday.
        /// </summary>
        [JsonProperty("ThisMondayUsageRate")]
        public string ThisMondayUsageRate{ get; set; }

        /// <summary>
        /// Resource growth rate this week.
        /// </summary>
        [JsonProperty("ThisMondayUsageGrowthRate")]
        public string ThisMondayUsageGrowthRate{ get; set; }

        /// <summary>
        /// Resource growth rate last week.
        /// </summary>
        [JsonProperty("LastMondayUsageGrowthRate")]
        public string LastMondayUsageGrowthRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Item", this.Item);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "UsageRate", this.UsageRate);
            this.SetParamSimple(map, prefix + "Remain", this.Remain);
            this.SetParamSimple(map, prefix + "RemainRate", this.RemainRate);
            this.SetParamSimple(map, prefix + "ThisMondayUsageRate", this.ThisMondayUsageRate);
            this.SetParamSimple(map, prefix + "ThisMondayUsageGrowthRate", this.ThisMondayUsageGrowthRate);
            this.SetParamSimple(map, prefix + "LastMondayUsageGrowthRate", this.LastMondayUsageGrowthRate);
        }
    }
}

