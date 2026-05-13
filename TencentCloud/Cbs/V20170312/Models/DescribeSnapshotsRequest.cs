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

    public class DescribeSnapshotsRequest : AbstractModel
    {
        
        /// <summary>
        /// List of snapshot IDs to be queried. The parameter does not support specifying both `SnapshotIds` and `Filters`.
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }

        /// <summary>
        /// Filter criteria. parameters `SnapshotIds` and `Filters` cannot be specified at the same time.<br><ul><li>snapshot-id<ul><li>filter by cloud disk snapshot id</li><li>type: String</li><li>required: no</li></ul></li><li>snapshot-name<ul><li>filter by cloud disk snapshot name</li><li>type: String</li><li>required: no</li></ul></li><li>snapshot-state<ul><li>filter by cloud disk snapshot status</li><li>type: String</li><li>required: no</li><li>value ranges FROM:<ul><li><code>NORMAL</code>: NORMAL</li><li><code>CREATING</code>: CREATING</li><li><code>ROLLBACKING</code>: rolling back</li><li><code>COPYING_FROM_REMOTE</code>: cross geo-replication in progress</li><li><code>CHECKING_COPIED</code>: COPYING check in progress</li><li><code>TORECYCLE</code>: pending recycling</li></ul></li></ul></li><li>disk-usage<ul><li>filter by cloud disk usage purpose</li><li>type: String</li><li>required: no</li><li>value ranges FROM:<ul><li><code>SYSTEM_disk</code>: represent SYSTEM disk</li><li><code>DATA_disk</code>: represent DATA disk</li></ul></li></ul></li><li>project-id<ul><li>filter by cloud disk project id</li><li>type: String</li><li>required: no</li></ul></li><li>disk-id<ul><li>filter by cloud disk id. up to 10 values can be specified</li><li>type: String</li><li>required: no</li></ul></li><li>encrypt<ul><li>filter by whether encrypted or not</li><li>type: String</li><li>required: no</li></ul></li><li>snapshot-type<ul><li>query by snapshot ownership type</li><li>type: String</li><li>required: no</li><li>value ranges FROM:<ul><li><code>SHARED_snapshot</code>: refer to SHARED snapshot</li><li><code>PRIVATE_snapshot</code>: refer to own PRIVATE snapshot</li></ul></li></ul></li></ul>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default is 20. Maximum is 100. For more information on `Limit`, please see relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/product/362/15633?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Field based on which the snapshot list is sorted. valid values:.
        /// <ul>
        /// <Li>CREATE_TIME: specifies to sort by snapshot creation time.</li>.
        /// <Li>Sort by creation time by default.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Offset. Default is 0. For more information on `Offset`, please see relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/product/362/15633?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Outputs the sorting order of the cloud disk list. valid values:.
        /// <ul>
        /// <Li>ASC: specifies ascending order.</li>.
        /// <Li>DESC: specifies sorting in descending order.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

