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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAutoSnapshotPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of scheduled snapshot policy IDs to be queried. The parameter does not support specifying both `SnapshotIds` and `Filters`.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyIds")]
        public string[] AutoSnapshotPolicyIds{ get; set; }

        /// <summary>
        /// Filter criteria. AutoSnapshotPolicyIds and Filters cannot be specified at the same time.
        /// <li>auto-snapshot-policy-id - Array of String - required: no - (filter condition) filter by regular snapshot policy id. regular snapshot policy id such as: `asp-3stvwfxx`.</li>.
        /// <li>AutoSnapshotPolicyState - Array of String - required: no - (filter condition) filters by the status of the regular snapshot policy. regular snapshot policy ID format: `asp-3stvwfxx`. (NORMAL: NORMAL | ISOLATED: ISOLATED).</li>.
        /// <li>AutoSnapshotPolicyName - Array of String - required: no - (filter condition) filters by the name of the regular snapshot policy.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default is 20. Maximum is 100. For more information on `Limit`, please see relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/product/362/15633?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default is 0. For more information on `Offset`, please see relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/product/362/15633?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Specifies the output order of the regular snapshot list. valid values: <br><li>ASC: ascending order<br></li><li>DESC: descending order.</li>.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// The sorting filter applied to the scheduled snapshot list. Value range: <Sort by creation time of scheduled snapshot. By default, this is sorted by creation time.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AutoSnapshotPolicyIds.", this.AutoSnapshotPolicyIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
        }
    }
}

