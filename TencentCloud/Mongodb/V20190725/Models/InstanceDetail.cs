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

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Billing type. Valid value: 0 (pay-as-you-go)
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Cluster type. Valid values: `0` (replica set instance), `1` (sharded instance).
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// Region information
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// AZ information
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Network type. Valid values: 0 (basic network), 1 (VPC)
        /// </summary>
        [JsonProperty("NetType")]
        public ulong? NetType{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID of VPC
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Instance status. Valid values: 0: creating; 1: processing; 2: running; -2: expired.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Instance IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        [JsonProperty("Vport")]
        public ulong? Vport{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Instance expiration time
        /// </summary>
        [JsonProperty("DeadLine")]
        public string DeadLine{ get; set; }

        /// <summary>
        /// Instance version information
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// Instance memory size in MB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Instance disk size in MB
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// Number of CPU cores of an instance
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// Instance machine type
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Number of secondary nodes of an instance
        /// </summary>
        [JsonProperty("SecondaryNum")]
        public ulong? SecondaryNum{ get; set; }

        /// <summary>
        /// Number of instance shards
        /// </summary>
        [JsonProperty("ReplicationSetNum")]
        public ulong? ReplicationSetNum{ get; set; }

        /// <summary>
        /// Instance auto-renewal flag. Valid values: `0` (manual renewal), `1` (auto-renewal), `2` (no renewal upon expiration)
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Used capacity in MB
        /// </summary>
        [JsonProperty("UsedVolume")]
        public ulong? UsedVolume{ get; set; }

        /// <summary>
        /// Start time of the maintenance time
        /// </summary>
        [JsonProperty("MaintenanceStart")]
        public string MaintenanceStart{ get; set; }

        /// <summary>
        /// End time of the maintenance time
        /// </summary>
        [JsonProperty("MaintenanceEnd")]
        public string MaintenanceEnd{ get; set; }

        /// <summary>
        /// Shard information
        /// </summary>
        [JsonProperty("ReplicaSets")]
        public ShardInfo[] ReplicaSets{ get; set; }

        /// <summary>
        /// Information of read-only instances
        /// </summary>
        [JsonProperty("ReadonlyInstances")]
        public DBInstanceInfo[] ReadonlyInstances{ get; set; }

        /// <summary>
        /// Information of disaster recovery instances
        /// </summary>
        [JsonProperty("StandbyInstances")]
        public DBInstanceInfo[] StandbyInstances{ get; set; }

        /// <summary>
        /// Information of temp instances
        /// </summary>
        [JsonProperty("CloneInstances")]
        public DBInstanceInfo[] CloneInstances{ get; set; }

        /// <summary>
        /// Information of associated instances. For a regular instance, this field represents the information of its temp instance; for a temp instance, this field represents the information of its regular instance; and for a read-only instance or a disaster recovery instance, this field represents the information of its primary instance.
        /// </summary>
        [JsonProperty("RelatedInstance")]
        public DBInstanceInfo RelatedInstance{ get; set; }

        /// <summary>
        /// Instance tag information set
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Instance version
        /// </summary>
        [JsonProperty("InstanceVer")]
        public ulong? InstanceVer{ get; set; }

        /// <summary>
        /// Instance version
        /// </summary>
        [JsonProperty("ClusterVer")]
        public ulong? ClusterVer{ get; set; }

        /// <summary>
        /// Protocol information. Valid values: `1` (mongodb), `2` (dynamodb).
        /// </summary>
        [JsonProperty("Protocol")]
        public ulong? Protocol{ get; set; }

        /// <summary>
        /// Instance type. Valid values: 1 (promoted instance), 2 (temp instance), 3 (read-only instance), 4 (disaster recovery instance)
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// Instance status description
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// Physical instance ID. For an instance that has been rolled back and replaced, its InstanceId and RealInstanceId are different. The physical instance ID is needed in such scenarios as getting monitoring data from Barad
        /// </summary>
        [JsonProperty("RealInstanceId")]
        public string RealInstanceId{ get; set; }

        /// <summary>
        /// Number of Mongos nodes.
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }

        /// <summary>
        /// Mongos node memory.
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// Number of Mongos node CPU cores.
        /// </summary>
        [JsonProperty("MongosCpuNum")]
        public ulong? MongosCpuNum{ get; set; }

        /// <summary>
        /// Number of ConfigServer nodes.
        /// </summary>
        [JsonProperty("ConfigServerNodeNum")]
        public ulong? ConfigServerNodeNum{ get; set; }

        /// <summary>
        /// ConfigServer node memory.
        /// </summary>
        [JsonProperty("ConfigServerMemory")]
        public ulong? ConfigServerMemory{ get; set; }

        /// <summary>
        /// ConfigServer node disk size.
        /// </summary>
        [JsonProperty("ConfigServerVolume")]
        public ulong? ConfigServerVolume{ get; set; }

        /// <summary>
        /// Number of ConfigServer node CPU cores.
        /// </summary>
        [JsonProperty("ConfigServerCpuNum")]
        public ulong? ConfigServerCpuNum{ get; set; }

        /// <summary>
        /// Number of read-only nodes.
        /// </summary>
        [JsonProperty("ReadonlyNodeNum")]
        public ulong? ReadonlyNodeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeadLine", this.DeadLine);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "SecondaryNum", this.SecondaryNum);
            this.SetParamSimple(map, prefix + "ReplicationSetNum", this.ReplicationSetNum);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "UsedVolume", this.UsedVolume);
            this.SetParamSimple(map, prefix + "MaintenanceStart", this.MaintenanceStart);
            this.SetParamSimple(map, prefix + "MaintenanceEnd", this.MaintenanceEnd);
            this.SetParamArrayObj(map, prefix + "ReplicaSets.", this.ReplicaSets);
            this.SetParamArrayObj(map, prefix + "ReadonlyInstances.", this.ReadonlyInstances);
            this.SetParamArrayObj(map, prefix + "StandbyInstances.", this.StandbyInstances);
            this.SetParamArrayObj(map, prefix + "CloneInstances.", this.CloneInstances);
            this.SetParamObj(map, prefix + "RelatedInstance.", this.RelatedInstance);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceVer", this.InstanceVer);
            this.SetParamSimple(map, prefix + "ClusterVer", this.ClusterVer);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamSimple(map, prefix + "RealInstanceId", this.RealInstanceId);
            this.SetParamSimple(map, prefix + "MongosNodeNum", this.MongosNodeNum);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamSimple(map, prefix + "MongosCpuNum", this.MongosCpuNum);
            this.SetParamSimple(map, prefix + "ConfigServerNodeNum", this.ConfigServerNodeNum);
            this.SetParamSimple(map, prefix + "ConfigServerMemory", this.ConfigServerMemory);
            this.SetParamSimple(map, prefix + "ConfigServerVolume", this.ConfigServerVolume);
            this.SetParamSimple(map, prefix + "ConfigServerCpuNum", this.ConfigServerCpuNum);
            this.SetParamSimple(map, prefix + "ReadonlyNodeNum", this.ReadonlyNodeNum);
        }
    }
}

