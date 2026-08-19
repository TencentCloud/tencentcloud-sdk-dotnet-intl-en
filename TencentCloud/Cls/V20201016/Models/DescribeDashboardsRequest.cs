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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDashboardsRequest : AbstractModel
    {
        
        /// <summary>
        /// Page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// -dashboardId filter by [dashboard id], type: String, required: No.
        /// -Example value: dashboard-522a5609-1f41-4b11-8086-5afd1d7574f5
        /// -dashboardName: Filter by fuzzy search as dashboard name. Type: String. Required: No.
        /// -Example value: Business dashboard
        /// -dashboardRegion filter by dashboard region (compatible with legacy dashboards). This property for dashboards created via cloud API, type: String, required: No.
        /// -See [Regions and Availability Zones](https://www.tencentcloud.com/document/product/614/18940)
        /// -Example: ap-guangzhou
        /// - tagKey - String - Required: No - Filter by the tag key.
        /// -Example value:
        ///     ```
        ///     "Filters":[
        ///         {
        ///             "Key": "tagKey",
        ///             "Values": [
        ///                 "tag-key-test"
        ///             ]
        ///         }
        ///     ]
        ///     ```
        /// 
        /// -tag:tagKey Filter by [tag key-value pair]. Replace tagKey with a specific tag key. Type: String. Required: No.
        /// -Refer to Example 1 for usage.
        ///     ```
        ///     "Filters": [
        ///         {
        ///             "Key": "tag:tag-key-test",
        ///             "Values": [
        ///                 "12"
        ///             ]
        ///         }
        ///     ]
        ///     ```
        /// 
        /// Each request can have up to 10 Filters. The upper limit of Filter.Values is 100.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Filter is performed by topicId and regionId.
        /// -topicId: Log topic id.
        /// - Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/api/614/42783).
        /// -Example value: 439a5304-08f9-484b-9c4d-46ff57133816
        /// - regionId
        /// - 1: Guangzhou
        /// -4: Shanghai
        /// -5: Hong Kong (China)
        /// - 7: Shanghai Finance
        /// - 8: Beijing
        /// -9: Singapore
        /// - 11: Shenzhen Finance
        /// - 15: Silicon Valley
        /// - 16: Chengdu
        /// - 17: Frankfurt
        /// - 18: Seoul
        /// - 19: Chongqing
        /// - 22: Virginia
        /// - 23: Bangkok
        /// - 25: Tokyo
        /// - 33: Nanjing
        /// - 36: Tianjin
        /// -39: Taipei (China)
        /// - 46: Beijing Finance
        /// -72: Jakarta
        /// -74: Sao Paulo
        /// -78: Shanghai Autonomous Driving Cloud
        /// </summary>
        [JsonProperty("TopicIdRegionFilter")]
        public TopicIdAndRegion[] TopicIdRegionFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "TopicIdRegionFilter.", this.TopicIdRegionFilter);
        }
    }
}

