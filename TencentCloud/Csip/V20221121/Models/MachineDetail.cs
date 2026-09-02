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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent status</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>Agent version</p>
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// <p>Account AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Asset type name</p>
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// <p>System boot time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("BootTime")]
        public long? BootTime{ get; set; }

        /// <summary>
        /// <p>Purchase time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("BuyTime")]
        public long? BuyTime{ get; set; }

        /// <summary>
        /// <p>Cloud service provider</p>
        /// </summary>
        [JsonProperty("CloudFromEnum")]
        public string CloudFromEnum{ get; set; }

        /// <summary>
        /// <p>Cloud tag list</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// <p>Kernel version</p>
        /// </summary>
        [JsonProperty("CoreVersion")]
        public string CoreVersion{ get; set; }

        /// <summary>
        /// <p>CPU info</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public string Cpu{ get; set; }

        /// <summary>
        /// <p>CPU load</p>
        /// </summary>
        [JsonProperty("CpuLoad")]
        public string CpuLoad{ get; set; }

        /// <summary>
        /// <p>CPU cores.</p>
        /// </summary>
        [JsonProperty("CpuSize")]
        public ulong? CpuSize{ get; set; }

        /// <summary>
        /// <p>Device model</p>
        /// </summary>
        [JsonProperty("DeviceVersion")]
        public string DeviceVersion{ get; set; }

        /// <summary>
        /// <p>Disk partition information</p>
        /// </summary>
        [JsonProperty("Disks")]
        public DiskPartitionInfo[] Disks{ get; set; }

        /// <summary>
        /// <p>Expiration time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>Exposure status</p>
        /// </summary>
        [JsonProperty("ExposedStatus")]
        public string ExposedStatus{ get; set; }

        /// <summary>
        /// <p>Installation time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("InstallTime")]
        public long? InstallTime{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>Instance status</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Kernel version</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// <p>Last online time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("LatestLiveTime")]
        public long? LatestLiveTime{ get; set; }

        /// <summary>
        /// <p>Last offline time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("LatestOfflineTime")]
        public long? LatestOfflineTime{ get; set; }

        /// <summary>
        /// <p>Private IP address.</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>Operating system (cloud collection)</p>
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// <p>Host status</p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>Public IP address.</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>Memory size (MB)</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// <p>Memory usage rate</p>
        /// </summary>
        [JsonProperty("MemoryLoad")]
        public string MemoryLoad{ get; set; }

        /// <summary>
        /// <p>ENI information.</p>
        /// </summary>
        [JsonProperty("NetCards")]
        public NetworkCardInfo[] NetCards{ get; set; }

        /// <summary>
        /// <p>Operating system (client collection)</p>
        /// </summary>
        [JsonProperty("OsByAgent")]
        public string OsByAgent{ get; set; }

        /// <summary>
        /// <p>Payment mode</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Days protected</p>
        /// </summary>
        [JsonProperty("ProtectDays")]
        public ulong? ProtectDays{ get; set; }

        /// <summary>
        /// <p>Protection type</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>Host unique identifier</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>Region information.</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>Remarks.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Serial number</p>
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// <p>Asset tag list</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>Tag change information</p>
        /// </summary>
        [JsonProperty("TagModifyInfo")]
        public AssetTagModifyAssetItem TagModifyInfo{ get; set; }

        /// <summary>
        /// <p>Agent unique ID</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>VPC CIDR</p>
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>VPC name.</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>Host node type</p><p>Enumeration values:</p><ul><li>NONE: Host node</li><li>CLUSTER: Cluster node</li><li>CONTAINER: Container node</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Container protection status</p><p>Enumeration values:</p><ul><li>Enabled: Enable protection</li><li>Disabled: Disable protection</li><li>Unknown: Unknown</li></ul>
        /// </summary>
        [JsonProperty("ContainerDefendStatus")]
        public string ContainerDefendStatus{ get; set; }

        /// <summary>
        /// <p>Cluster visa md5</p>
        /// </summary>
        [JsonProperty("ClusterCaMd5")]
        public string ClusterCaMd5{ get; set; }

        /// <summary>
        /// <p>Container environment info</p>
        /// </summary>
        [JsonProperty("ContainerEnvInfo")]
        public ContainerEnvInfo ContainerEnvInfo{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AssetTypeName", this.AssetTypeName);
            this.SetParamSimple(map, prefix + "BootTime", this.BootTime);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "CloudFromEnum", this.CloudFromEnum);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "CoreVersion", this.CoreVersion);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "CpuLoad", this.CpuLoad);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "DeviceVersion", this.DeviceVersion);
            this.SetParamArrayObj(map, prefix + "Disks.", this.Disks);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExposedStatus", this.ExposedStatus);
            this.SetParamSimple(map, prefix + "InstallTime", this.InstallTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "LatestLiveTime", this.LatestLiveTime);
            this.SetParamSimple(map, prefix + "LatestOfflineTime", this.LatestOfflineTime);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemoryLoad", this.MemoryLoad);
            this.SetParamArrayObj(map, prefix + "NetCards.", this.NetCards);
            this.SetParamSimple(map, prefix + "OsByAgent", this.OsByAgent);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamObj(map, prefix + "TagModifyInfo.", this.TagModifyInfo);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ContainerDefendStatus", this.ContainerDefendStatus);
            this.SetParamSimple(map, prefix + "ClusterCaMd5", this.ClusterCaMd5);
            this.SetParamObj(map, prefix + "ContainerEnvInfo.", this.ContainerEnvInfo);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
        }
    }
}

