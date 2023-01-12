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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrafficPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// Traffic package IDs. Multiple values can be used.
        /// </summary>
        [JsonProperty("TrafficPackageIds")]
        public string[] TrafficPackageIds{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters`. `TrafficPackageIds` and `Filters` cannot be specified at the same time. The specific filter conditions are as follows:
        /// <li> `traffic-package_id` - String - Optional - Filter by the traffic package ID.</li>
        /// <li> `traffic-package-name` - String - Optional - Filter by the traffic package name. Fuzzy match is not supported.</li>
        /// <li> `status` - String - Optional - Filter by the traffic package status. Values: [AVAILABLE|EXPIRED|EXHAUSTED].</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Pagination parameter
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Pagination parameter
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TrafficPackageIds.", this.TrafficPackageIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

