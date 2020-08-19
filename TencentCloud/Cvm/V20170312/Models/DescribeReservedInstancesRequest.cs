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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReservedInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Dry run. The default is false.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Offset. The default value is 0. For more information on `Offset`, see the relevant sections in API [Overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. The default value is 20. The maximum is 100. For more information on `Limit`, see the relevant sections in API [Overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <li><strong>zone</strong></li>
        /// <p style="padding-left: 30px;">Filters by the **<strong>availability zones</strong>** in which reserved instances can be purchased. For example, "ap-guangzhou-1".</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: <a href="https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1">list of availability zones</a></p>
        /// <li><strong>duration</strong></li>
        /// <p style="padding-left: 30px;">Filters by reserved instance **<strong>validity</strong>** (in seconds). For example, 31536000.</p><p style="padding-left: 30px;">Type: Integer</p><p style="padding-left: 30px;">Unit: second</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: 31536000 (1 year) | 94608000 (3 years)</p>
        /// <li><strong>instance-type</strong></li>
        /// <p style="padding-left: 30px;">Filters by **<strong>specifications of reserved instances</strong>**. For example, "S3.MEDIUM4".</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: <a href="https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1">list of reserved instance specifiations</a></p>
        /// <li><strong>offering-type</strong></li>
        /// <p style="padding-left: 30px;">Filters by **<strong>payment method</strong>**. For example, "All Upfront".</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid value: All Upfront</p>
        /// <li><strong>product-description</strong></li>
        /// <p style="padding-left: 30px;">Filters by the **<strong>operating system</strong>** of the reserved instance. For example, "linux".</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid value: linux</p>
        /// <li><strong>reserved-instances-id</strong></li>
        /// <p style="padding-left: 30px;">Filters by **<strong>reserved instance ID</strong>. Reserved instance IDs take the form "650c138f-ae7e-4750-952a-96841d6e9fc1".</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p>
        /// <li><strong>state</strong></li>
        /// <p style="padding-left: 30px;">Filters by **<strong>reserved instance status</strong>. For example, "active".</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required</p><p style="padding-left: 30px;">Valid values: "active" (created) | "pending" (waiting to be created) | "retired" (expired)</p>
        /// Each request can have up to 10 `Filters` and 5 `Filters.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

