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
        /// Filter conditions. The specification of both the `SnapshotIds` and `Filters` parameters is not supported. <br><li>snapshot-id - Array of String - Required or not: No - (Filter condition) Filter by the snapshot ID. The format of the snapshot ID is as follows: `snap-11112222`. <br><li>snapshot-name - Array of String - Required or not: No - (Filter condition) Filter by the snapshot name. <br><li>snapshot-state - Array of String - Required or not: No - (Filter condition) Filter by the snapshot status (NORMAL: normal | CREATING: creating | ROLLBACKING: rolling back). <br><li>disk-usage - Array of String - Required or not: No - (Filter condition) Filter by the type of the cloud disk for which the snapshot is created (SYSTEM_DISK: system disk | DATA_DISK: data disk). <br><li>project-id - Array of String - Required or not: No - (Filter condition) Filter by ID of the project to which the cloud disk belongs. <br><li>disk-id - Array of String - Required or not: No - (Filter condition) Filter by the ID of the cloud disk for which the snapshot is created. <br><li>zone - Array of String - Required or not: No - (Filter condition) Filter by [Availability Zone](/document/product/213/15753#ZoneInfo). <br><li>encrypt - Array of String - Required or not: No - (Filter condition) According to whether it is an encrypted disk snapshot. (TRUE: indicates an encrypted disk snapshot | FALSE: indicates that it is not an encrypted disk snapshot.)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default is 0. For more information on `Offset`, please see relevant sections in API [Introduction](/document/product/362/15633).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default is 20. Maximum is 100. For more information on `Limit`, please see relevant sections in API [Introduction](/document/product/362/15633).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Outputs the ordering of the cloud disk list. Value range: <br><li>ASC: Ascending order <br><li>DESC: Descending order.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// The field by which the snapshot list is sorted. Value range: <br><li>CREATE_TIME: sorted by the creation time of the snapshots <br>By default, the snapshot list is sorted by the creation time of snapshots.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
        }
    }
}

