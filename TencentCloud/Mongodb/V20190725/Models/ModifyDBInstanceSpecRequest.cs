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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. For example, cmgo-p8vn****. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/MongoDB) and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Memory size after instance configuration modification. - Unit: GB. The current instance memory size is used by default if this parameter is left blank.<br>Note: Memory and disk configurations should be upgraded or downgraded at the same time, meaning that Memory and Volume should be modified at the same time.
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Disk capacity after instance configuration modification. Unit: GB. The current instance disk capacity is used by default if this parameter is left blank.
        ///  - Memory and disk configurations should be upgraded or downgraded at the same time, meaning that Memory and Volume should be modified at the same time.
        ///  - During configuration downgrading, the disk capacity after modification should be greater than 1.2 times the used disk capacity.
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// (Deprecated) Use the independent API ResizeOplog.
        /// 
        /// Oplog size after instance configuration modification.
        ///  - Unit: GB.
        ///  - By default, the capacity occupied by Oplog is 10% of the disk capacity. The range of capacity occupied by Oplog supported by the system is [10%,90%] of the disk capacity.
        /// </summary>
        [JsonProperty("OplogSize")]
        [System.Obsolete]
        public ulong? OplogSize{ get; set; }

        /// <summary>
        /// Number of Mongod nodes after instance modification (excluding read-only nodes).
        ///  - When the CPU and memory specifications of Mongod nodes are modified, this parameter can be left blank or set to the current number of Mongod nodes (excluding read-only nodes).
        ///  - When the CPU and memory specifications of Mongos nodes are modified, this parameter can be left blank or set to the current number of Mongod nodes (excluding read-only nodes).
        ///  - During node modification (all types), this parameter can be left blank or set to the number of Mongod nodes (excluding read-only nodes) after modification.
        ///  - Number of replica set nodes: Confirm the range of the number of nodes based on the MinNodeNum and MaxNodeNum parameters returned by the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38565?from_cn_redirect=1) API for querying saleable TencenDB for MongoDB specifications.
        ///  - Number of nodes for each shard in a sharded cluster: Confirm the range of the number of nodes based on the MinReplicateSetNodeNum and MaxReplicateSetNodeNum parameters returned by the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38565?from_cn_redirect=1) API for querying saleable TencenDB for MongoDB specifications.
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// Number of shards after instance modification.
        ///  - The value range can be obtained from the **MinReplicateSetNum** and **MaxReplicateSetNum** parameters returned by the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API for querying saleable TencentDB for MongoDB specifications. - The value of this parameter can only be increased but not decreased.
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// Switch time for instance configuration modification.
        ///  - 0: Execute the configuration modification task immediately after the adjustment is completed. Default value: 0.
        ///  - 1: Execute the configuration modification task within the maintenance window.
        /// **Note**: Adjusting the number of nodes and shards is unsupported <b>within the maintenance window</b>.
        /// </summary>
        [JsonProperty("InMaintenance")]
        public ulong? InMaintenance{ get; set; }

        /// <summary>
        /// Mongos node memory size after the sharded cluster instance configuration is modified. Unit: GB.
        /// </summary>
        [JsonProperty("MongosMemory")]
        public string MongosMemory{ get; set; }

        /// <summary>
        /// List of nodes to be added, containing the node type and AZ information.
        /// </summary>
        [JsonProperty("AddNodeList")]
        public AddNodeList[] AddNodeList{ get; set; }

        /// <summary>
        /// List of nodes to be deleted. Note: According to the consistency principle for nodes of each shard on a sharded cluster instance, specify the nodes on shard 0 for node deletion from the sharded cluster instance. For example, cmgo-9nl1czif_0-node-readonly0 will delete the first read-only node of each shard.
        /// </summary>
        [JsonProperty("RemoveNodeList")]
        public RemoveNodeList[] RemoveNodeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "OplogSize", this.OplogSize);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "InMaintenance", this.InMaintenance);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamArrayObj(map, prefix + "AddNodeList.", this.AddNodeList);
            this.SetParamArrayObj(map, prefix + "RemoveNodeList.", this.RemoveNodeList);
        }
    }
}

