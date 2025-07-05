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
        /// Package ID list.
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
        /// <li>bundle-id</li>Filter by the **bundle ID**.
        /// Type: String
        /// Required: No
        /// <li>`support-platform-type`<li>Filter by the **system type**.
        /// Values: `LINUX_UNIX` (Linux/Unix), `WINDOWS` (Windows).
        /// Type: String
        /// Required: No
        /// <li>bundle-type</li>Filter by the **bundle type**.
        /// Values: `GENERAL_BUNDLE` (General bundle), `STORAGE_BUNDLE` (Storage bundle), `ENTERPRISE_BUNDLE` (Enterprise bundle), `EXCLUSIVE_BUNDLE` (Dedicated bundle), `BEFAST_BUNDLE` (BeFast bundle), `STARTER_BUNDLE` (Beginner bundle); `CAREFREE_BUNDLE` (Carefree bundle);
        /// Type: String
        /// Required: No
        /// <li>bundle-state</li>Filter by the **bundle status**.
        /// Values: `ONLINE`, `OFFLINE`
        /// Type: String
        /// Required: No
        /// Each request can contain up to 10 `Filters` and 5 `Filter.Values`. You cannot specify both `BundleIds` and `Filters` at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// AZ list, which contains all AZs by default.
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

