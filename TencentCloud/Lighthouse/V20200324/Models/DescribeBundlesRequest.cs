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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBundlesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of bundle ids. the maximum is 100 per request for batch packages. you can get the BundleId in the return value from the API [DescribeBundles](https://www.tencentcloud.com/document/product/1207/47575?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("BundleIds")]
        public string[] BundleIds{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, please see the relevant section in [Overview](https://intl.cloud.tencent.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, please see the relevant section in the API [Overview](https://intl.cloud.tencent.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter list.
        /// <li>bundle-id</li>Filter by [bundle id].
        /// Type: String.
        /// Required: No
        /// <li>`support-platform-type`</li>Filter by the system type.
        /// Value: LINUX_UNIX (LINUX/UNIX system); WINDOWS (WINDOWS systems).
        /// Type: String.
        /// Required: No
        /// <li>bundle-type</li>Filter by [package type].
        /// Valid values: GENERAL_BUNDLE (GENERAL BUNDLE); STORAGE_BUNDLE (STORAGE BUNDLE); ENTERPRISE_BUNDLE (ENTERPRISE BUNDLE); EXCLUSIVE_BUNDLE (dedicated BUNDLE); BEFAST_BUNDLE (SPEED BUNDLE); STARTER_BUNDLE (STARTER BUNDLE); CAREFREE_BUNDLE (CAREFREE BUNDLE); RAZOR_SPEED_BUNDLE (RAZOR SPEED BUNDLE).
        /// Type: String.
        /// Required: No
        /// <li>bundle-state</li>Filter by [package status].
        /// Valid values: ONLINE, OFFLINE.
        /// Type: String.
        /// Required: No
        /// The maximum number of `Filters` per request is 10, and the maximum number of `Filter.Values` is 5. the parameter does not support specifying both `BundleIds` and `Filters`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// AZ list. default to all availability zones.
        /// <li>AZs can be queried through the API [DescribeZones](https://www.tencentcloud.com/document/product/1207/57513?from_cn_redirect=1)</li>.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BundleIds.", this.BundleIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
        }
    }
}

