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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMetricOverviewListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Dashboard domain. Required. Determines which domain's KPI data to return.</p><table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>RESOURCE_TYPE_UNSPECIFIED</td><td>0</td><td></td></tr><tr><td>RESOURCE_TYPE_MODEL</td><td>1</td><td>Model usage</td></tr><tr><td>RESOURCE_TYPE_PLUGIN</td><td>2</td><td>Plug-in usage</td></tr><tr><td>RESOURCE_TYPE_PLATFORM</td><td>3</td><td>Platform feature usage</td></tr><tr><td>RESOURCE_TYPE_MODEL_CONCURRENCY</td><td>4</td><td>Model concurrency limit exceeded</td></tr><tr><td>RESOURCE_TYPE_KB_CAPACITY</td><td>5</td><td>Knowledge base capacity</td></tr><tr><td>RESOURCE_TYPE_USAGE_SUMMARY</td><td>6</td><td>Usage summary</td></tr><tr><td>RESOURCE_TYPE_RESOURCE_CONSUME</td><td>7</td><td>Resource consumption (billing details)</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// <p>Query time range (Unix seconds).</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public TimeRange TimeRange{ get; set; }

        /// <summary>
        /// <p>View scope: corporate view / space view</p>
        /// </summary>
        [JsonProperty("ViewScope")]
        public ViewScope ViewScope{ get; set; }

        /// <summary>
        /// <p>Extended filtering (resource_type=MODEL). Filter combination rule: multiple items use AND, AND value_list within the same item uses OR. Supported Names: MODEL_Name (MODEL Name), user_id (uid), space_id (space id), resource_id/source_id (source id), metric_source_type (metric_source_type_* Enumeration Name OR integer)</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "TimeRange.", this.TimeRange);
            this.SetParamObj(map, prefix + "ViewScope.", this.ViewScope);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
        }
    }
}

