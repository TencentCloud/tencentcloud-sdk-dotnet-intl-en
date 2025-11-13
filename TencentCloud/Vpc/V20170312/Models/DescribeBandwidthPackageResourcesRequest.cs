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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBandwidthPackageResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the bandwidth package in the form of `bwp-11112222`.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters` and 5 `Filter.Values`. The specific filter conditions are as follows:
        /// <li>resource-id - String - Required: no - (Filter condition) Filters by the unique ID of resources in a bandwidth package, such as `eip-11112222`.</li>
        /// <li>resource-type - String - Required: no - (Filter condition) Filters by the type of resources in a bandwidth package. It now supports only EIP (`Address`) and load balancer (`LoadBalance`).</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The offset. Default value: 0. For more information on `Offset`, see the relevant sections in API [Introduction](https://www.tencentcloud.com/document/api/213/15688).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant sections in API [Introduction](https://www.tencentcloud.com/document/api/213/15688).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

