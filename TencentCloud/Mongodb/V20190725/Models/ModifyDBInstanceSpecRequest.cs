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
        /// <p>Instance ID. Log in to the <a href="https://console.cloud.tencent.com/mongodb">MongoDB console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Memory size after instance configuration modification. Unit: GB. The current instance memory size is used by default if this parameter is left blank. For supported memory specifications, please refer to <a href="https://www.tencentcloud.com/document/product/240/64125?from_cn_redirect=1">product specifications</a>.<br><strong>Note</strong>: Memory and disk configurations should be upgraded or downgraded at the same time, meaning that Memory and Volume should be modified at the same time.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>Hard disk size after instance configuration modification. Unit: GB. The current instance disk size is used by default if this parameter is left blank. For supported disk capacity, please refer to <a href="https://www.tencentcloud.com/document/product/240/64125?from_cn_redirect=1">product specification</a>.</p><ul><li>Memory and disk configurations should be upgraded or downgraded at the same time, meaning that Memory and Volume should be modified simultaneously.</li><li>When downgrading, the disk capacity after modification must be greater than 1.2 times the used disk capacity.</li></ul>
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// <p>(Abandoned) Please use the standalone ResizeOplog API to complete.</p><p>Oplog size after instance configuration change.</p><ul><li>Unit: GB.</li><li>Default oplog capacity used is 10% of disk space. The system allows oplog capacity settings ranging from 10% to 90% of disk space.</li></ul>
        /// </summary>
        [JsonProperty("OplogSize")]
        [System.Obsolete]
        public ulong? OplogSize{ get; set; }

        /// <summary>
        /// <p>Number of mongod nodes after instance change (excluding read-only nodes).</p><ul><li>Replica set node count: Use the MinNodeNum and MaxNodeNum parameters in the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API response to obtain the node count range.</li><li>Number of shard nodes in a sharded cluster: Use the MinReplicateSetNodeNum and MaxReplicateSetNodeNum parameters in the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API response to obtain the node count range.<br><strong>Note</strong>: When modifying the CPU or memory specifications of mongod or mongos, you may not configure this parameter or enter the current number of mongod or mongos nodes (excluding read-only nodes).</li></ul>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>Number of shards after instance change.</p><ul><li>The value range for the number of instance shards can be obtained through the response parameters <strong>MinReplicateSetNum</strong> and <strong>MaxReplicateSetNum</strong> of the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API.</li><li>Only allow adding shards, not reducing them.</li></ul>
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// <p>Switch time for instance configuration change.</p><ul><li>0: Immediately execute the configuration modification task upon completion of adjustment. Default is 0.</li><li>1: Execute the configuration modification task within the maintenance window.<br><strong>Note</strong>: Adjusting the number of nodes and shard quantity is unsupported within the <b>maintenance window</b>.</li></ul>
        /// </summary>
        [JsonProperty("InMaintenance")]
        public ulong? InMaintenance{ get; set; }

        /// <summary>
        /// <p>Memory size of mongos after sharding instance configuration change. Unit: GB. For instance support specifications, see <a href="https://www.tencentcloud.com/document/product/240/64125?from_cn_redirect=1">product specification</a>.</p>
        /// </summary>
        [JsonProperty("MongosMemory")]
        public string MongosMemory{ get; set; }

        /// <summary>
        /// <p>List of nodes to be added, containing the node type and AZ information.</p>
        /// </summary>
        [JsonProperty("AddNodeList")]
        public AddNodeList[] AddNodeList{ get; set; }

        /// <summary>
        /// <p>Delete node list.<br><strong>Note</strong>: Based on the consistency principle of sharded instance nodes, when deleting shard instance nodes, only need to specify the node corresponding to shard 0, for example: cmgo-9nl1czif_0-node-readonly0 will delete the first read-only node of each shard.</p>
        /// </summary>
        [JsonProperty("RemoveNodeList")]
        public RemoveNodeList[] RemoveNodeList{ get; set; }

        /// <summary>
        /// <p>CPU size after instance configuration changes. Unit: C. If empty, the default value is the current CPU size of the instance. For currently supported CPU specifications, see <a href="https://www.tencentcloud.com/document/product/240/64125?from_cn_redirect=1">Product Specifications</a>.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>The product specification type after instance configuration change. If empty, the default value is the current instance product specification type.<br>Currently supported product specification types are as follows:<br>Recommended product specification types:</p><ul><li>GE.LD.T1: Local disk (Common I).</li><li>GE.CD.T1: Cloud disk (Common I).</li></ul><p>Product allowlist specification types:</p><ul><li>HIO10G: Local disk (High IO 10G).</li><li>HCD: Cloud disk (Cloud Disk Edition).</li></ul><p>Note:</p><ol><li>Allowlist specification types are controlled by allowlist. If needed, <a href="https://console.cloud.tencent.com/workorder/category">submit a ticket</a> to apply.</li><li>Common I cannot be changed to allowlist specification types.</li></ol>
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }


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
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
        }
    }
}

