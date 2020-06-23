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

    public class DescribeBandwidthPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// The bandwidth package ID. Batch operation is supported.
        /// </summary>
        [JsonProperty("BandwidthPackageIds")]
        public string[] BandwidthPackageIds{ get; set; }

        /// <summary>
        /// The upper limit for `Filters` in each request is 10. `BandwidthPackageIds` and `Filters` cannot be specified at the same time. The specific filtering conditions are as follows:
        /// <li> bandwidth-package_id - String - Required: No - (Filter condition) Filter by the unique ID of the bandwidth package.</li>
        /// <li> bandwidth-package-name - String - Required: No - (Filter condition) Filter by the bandwidth package name. Fuzzy filtering is not supported.</li>
        /// <li> network-type - String - Required: No - (Filter condition) Filter by the bandwidth package type. Types include 'BGP', 'SINGLEISP', and 'ANYCAST'.</li>
        /// <li> charge-type - String - Required: No - (Filter condition) Filter by the bandwidth package billing type. Billing types include 'TOP5_POSTPAID_BY_MONTH' and 'PERCENT95_POSTPAID_BY_MONTH'</li>
        /// <li> resource.resource-type - String - Required: No - (Filter condition) Filter by the bandwidth package resource type. Resource types include 'Address' and 'LoadBalance'</li>
        /// <li> resource.resource-id - String - Required: No - (Filter condition) Filter by the bandwidth package resource ID, such as 'eip-xxxx', 'lb-xxxx'</li>
        /// <li> resource.address-ip - String - Required: No - (Filter condition) Filter by the bandwidth package resource IP.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Queries bandwidth package offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Queries the limit on the number of bandwidth packages
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BandwidthPackageIds.", this.BandwidthPackageIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

