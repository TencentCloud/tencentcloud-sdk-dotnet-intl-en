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

    public class DescribeBandwidthPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique ID list of bandwidth packages.
        /// </summary>
        [JsonProperty("BandwidthPackageIds")]
        public string[] BandwidthPackageIds{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters`. parameters do not support specifying `BandwidthPackageIds` and `Filters` at the same time. detailed filter criteria are as follows:.
        /// <li>bandwidth-package-id - String - required: no - (filter condition) filter by the unique id of the bandwidth package.</li>.
        /// <li>bandwidth-package-name - String - required: no - (filter criteria) filter by bandwidth package name. fuzzy filtering is not supported.</li>.
        /// <li>network-type - String - required: no - (filter condition) filter by bandwidth package type. network type can be found in [BandwidthPackage](https://intl.cloud.tencent.com/document/api/215/15824?from_cn_redirect=1#BandwidthPackage).</li>.
        /// <li>- charge-type - String - required: no - (filter condition) filter by the billing type of the bandwidth package. the billing type can be found in BandwidthPackage (https://intl.cloud.tencent.com/document/api/215/15824?from_cn_redirect=1#BandwidthPackage).</li>.
        /// <li>resource.resource-type - String - required: no - (filter criteria) filter by bandwidth package resource type. resource types include 'Address' and 'LoadBalance'.</li>.
        /// <li>resource.resource-id - String - required: no - (filter criteria) filter by bandwidth package resource id. resource id is in the format of 'eip-xxxx','lb-xxxx'.</li>.
        /// <li>resource.address-ip - String - required: no - filter by bandwidth package resource ip.</li>.
        /// <li>tag-key - String - required: no - (filter condition) filter according to the tag key.</li>.
        /// <li>`tag-value` - String - Optional - Filter by the tag value.</li>
        /// 
        /// <li>tag:tag-key - String - required: no - (filter condition) filter by tag key-value pair. replace tag-key with a specific tag key.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. This value defaults to 0. For more information on Offset, see the relevant section in the API [Introduction](https://www.tencentcloud.com/document/api/213/15688).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of bandwidth packages returned. This value defaults to 20. The maximum is 100. For more information on Limit, see the relevant section in the API [Introduction](https://www.tencentcloud.com/document/api/213/15688).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BandwidthPackageIds.", this.BandwidthPackageIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

