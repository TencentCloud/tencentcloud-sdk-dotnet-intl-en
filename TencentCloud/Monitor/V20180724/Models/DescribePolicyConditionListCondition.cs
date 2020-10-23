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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyConditionListCondition : AbstractModel
    {
        
        /// <summary>
        /// Policy view name.
        /// </summary>
        [JsonProperty("PolicyViewName")]
        public string PolicyViewName{ get; set; }

        /// <summary>
        /// Event alarm conditions.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventMetrics")]
        public DescribePolicyConditionListEventMetric[] EventMetrics{ get; set; }

        /// <summary>
        /// Whether to support multiple regions.
        /// </summary>
        [JsonProperty("IsSupportMultiRegion")]
        public bool? IsSupportMultiRegion{ get; set; }

        /// <summary>
        /// Metric alarm conditions.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Metrics")]
        public DescribePolicyConditionListMetric[] Metrics{ get; set; }

        /// <summary>
        /// Policy type name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Sorting ID.
        /// </summary>
        [JsonProperty("SortId")]
        public long? SortId{ get; set; }

        /// <summary>
        /// Whether to support default policies.
        /// </summary>
        [JsonProperty("SupportDefault")]
        public bool? SupportDefault{ get; set; }

        /// <summary>
        /// List of regions that support this policy type.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SupportRegions")]
        public string[] SupportRegions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyViewName", this.PolicyViewName);
            this.SetParamArrayObj(map, prefix + "EventMetrics.", this.EventMetrics);
            this.SetParamSimple(map, prefix + "IsSupportMultiRegion", this.IsSupportMultiRegion);
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SortId", this.SortId);
            this.SetParamSimple(map, prefix + "SupportDefault", this.SupportDefault);
            this.SetParamArraySimple(map, prefix + "SupportRegions.", this.SupportRegions);
        }
    }
}

