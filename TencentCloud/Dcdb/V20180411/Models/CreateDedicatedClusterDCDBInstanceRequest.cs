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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDedicatedClusterDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of created instances
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// Shard count
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// Shard memory size in GB
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// Shard disk size in GB
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }

        /// <summary>
        /// UUID of the dedicated cluster
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// (Disused) AZ
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// (Disused) Number of CPU cores
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// (Disused) Shard model
        /// </summary>
        [JsonProperty("ShardMachine")]
        public string ShardMachine{ get; set; }

        /// <summary>
        /// Number of shard nodes
        /// </summary>
        [JsonProperty("ShardNodeNum")]
        public long? ShardNodeNum{ get; set; }

        /// <summary>
        /// (Disused) Number of node CPU cores. Value range: 1-100.
        /// </summary>
        [JsonProperty("ShardNodeCpu")]
        public long? ShardNodeCpu{ get; set; }

        /// <summary>
        /// (Disused) Node memory size in GB
        /// </summary>
        [JsonProperty("ShardNodeMemory")]
        public long? ShardNodeMemory{ get; set; }

        /// <summary>
        /// (Disused) Node disk size in GB
        /// </summary>
        [JsonProperty("ShardNodeStorage")]
        public long? ShardNodeStorage{ get; set; }

        /// <summary>
        /// Database version
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// Security group ID
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// List of security group IDs
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// DCN source instance ID
        /// </summary>
        [JsonProperty("DcnInstanceId")]
        public string DcnInstanceId{ get; set; }

        /// <summary>
        /// Region of DCN source instance
        /// </summary>
        [JsonProperty("DcnRegion")]
        public string DcnRegion{ get; set; }

        /// <summary>
        /// Custom instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// Whether IPv6 flag is supported. Valid values: `1` (yes), `0` (no).
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public long? Ipv6Flag{ get; set; }

        /// <summary>
        /// (Disused) Pid, which can be queried by the `DescribeSpecInfo` API.
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// List of parameters. Valid values: `character_set_server` (character set; required), `lower_case_table_names` (table name case sensitivity; required; `0`: case-sensitive; `1`: case-insensitive), `innodb_page_size` (InnoDB data page; default size: 16 KB), `sync_mode` (sync mode; `0`: async; `1`: strong sync; `2`: downgradable strong sync. Default value: `2`).
        /// </summary>
        [JsonProperty("InitParams")]
        public DBParamValue[] InitParams{ get; set; }

        /// <summary>
        /// Specified UUID for the source node. If left empty, it will be assigned by the system randomly.
        /// </summary>
        [JsonProperty("MasterHostId")]
        public string MasterHostId{ get; set; }

        /// <summary>
        /// Specified UUID for the replica node. If left empty, it will be assigned by the system randomly.
        /// </summary>
        [JsonProperty("SlaveHostIds")]
        public string[] SlaveHostIds{ get; set; }

        /// <summary>
        /// ID of the source instance to be rolled back
        /// </summary>
        [JsonProperty("RollbackInstanceId")]
        public string RollbackInstanceId{ get; set; }

        /// <summary>
        /// Rollback time
        /// </summary>
        [JsonProperty("RollbackTime")]
        public string RollbackTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DcnSyncMode")]
        public long? DcnSyncMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ShardMachine", this.ShardMachine);
            this.SetParamSimple(map, prefix + "ShardNodeNum", this.ShardNodeNum);
            this.SetParamSimple(map, prefix + "ShardNodeCpu", this.ShardNodeCpu);
            this.SetParamSimple(map, prefix + "ShardNodeMemory", this.ShardNodeMemory);
            this.SetParamSimple(map, prefix + "ShardNodeStorage", this.ShardNodeStorage);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "DcnInstanceId", this.DcnInstanceId);
            this.SetParamSimple(map, prefix + "DcnRegion", this.DcnRegion);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamSimple(map, prefix + "MasterHostId", this.MasterHostId);
            this.SetParamArraySimple(map, prefix + "SlaveHostIds.", this.SlaveHostIds);
            this.SetParamSimple(map, prefix + "RollbackInstanceId", this.RollbackInstanceId);
            this.SetParamSimple(map, prefix + "RollbackTime", this.RollbackTime);
            this.SetParamSimple(map, prefix + "DcnSyncMode", this.DcnSyncMode);
        }
    }
}

