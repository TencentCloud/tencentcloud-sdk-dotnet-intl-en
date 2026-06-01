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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Public network status. Possible returned values: 0 - External network not enabled; 1 - Public network enabled; 2 - Public network disabled</p>
        /// </summary>
        [JsonProperty("WanStatus")]
        public long? WanStatus{ get; set; }

        /// <summary>
        /// <p>AZ information</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Initialization flag. Possible returned values: 0 - uninitialized; 1 - initialized.</p>
        /// </summary>
        [JsonProperty("InitFlag")]
        public long? InitFlag{ get; set; }

        /// <summary>
        /// <p>Read-only vip information. This field is available only for read-only instances with separate instance access enabled.</p>
        /// </summary>
        [JsonProperty("RoVipInfo")]
        public RoVipInfo RoVipInfo{ get; set; }

        /// <summary>
        /// <p>Memory capacity, in MB.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Instance status. Valid values: 0: creating; 1: running; 4: isolation operation in progress; 5: isolated.</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>VPC ID, for example: 51102</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// <p>Secondary server information</p>
        /// </summary>
        [JsonProperty("SlaveInfo")]
        public SlaveInfo SlaveInfo{ get; set; }

        /// <summary>
        /// <p>Instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Disk capacity, in GB.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// <p>Auto-renewal flag. Possible returned values: 0 - auto-renewal is not enabled; 1 - auto-renewal is enabled; 2 - automatic renewal is disabled.</p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// <p>Data replication mode. 0 - async replication; 1 - semi-sync replication; 2 - strong sync replication</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>Read-only group detailed information</p>
        /// </summary>
        [JsonProperty("RoGroups")]
        public RoGroup[] RoGroups{ get; set; }

        /// <summary>
        /// <p>Subnet ID, for example: 2333</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// <p>Instance type. Possible returned values: 1 - Primary instance; 2 - Disaster recovery instance; 3 - Read-only instance.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Regional information</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Instance expiration time</p>
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// <p>Availability Zone Deployment method. Valid values: 0 - single availability zone; 1 - multi-availability zone.</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// <p>Instance task status. 0 - No tasks, 1 - Upgrading, 2 - Data import, 3 - Opening Slave, 4 - Public network access enabling, 5 - Batch operation executing, 6 - Rolling back, 7 - Public network access disabling, 8 - Password modification, 9 - Renaming instance, 10 - Restarting, 12 - Self-built migration, 13 - Database deletion, 14 - Disaster recovery instance creation sync, 15 - Upgrade pending switch, 16 - Upgrade and switch, 17 - Upgrade and switch completed</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// <p>Detailed information about the primary instance.</p>
        /// </summary>
        [JsonProperty("MasterInfo")]
        public MasterInfo MasterInfo{ get; set; }

        /// <summary>
        /// <p>Instance type</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Kernel version</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Disaster recovery instance details</p>
        /// </summary>
        [JsonProperty("DrInfo")]
        public DrInfo[] DrInfo{ get; set; }

        /// <summary>
        /// <p>public network domain name</p>
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// <p>Public network port number</p>
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// <p>Instance creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Instance IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Port number</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>Whether disk write is locked (data write volume of the instance exceeds disk quota). 0 - Unlocked 1 - Locked</p>
        /// </summary>
        [JsonProperty("CdbError")]
        public long? CdbError{ get; set; }

        /// <summary>
        /// <p>Private network descriptor, for example: "vpc-5v8wn9mg"</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Subnet descriptor, such as "subnet-1typ0s7d"</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>Physical ID</p>
        /// </summary>
        [JsonProperty("PhysicalId")]
        public string PhysicalId{ get; set; }

        /// <summary>
        /// <p>Core count</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Queries per second.</p>
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// <p>Chinese Name of Availability Zone</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>Physical machine model</p>
        /// </summary>
        [JsonProperty("DeviceClass")]
        public string DeviceClass{ get; set; }

        /// <summary>
        /// <p>Placement group ID</p>
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// <p>Availability zone ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>Number of nodes</p>
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// <p>Tag list</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfoItem[] TagList{ get; set; }

        /// <summary>
        /// <p>Engine type</p>
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// <p>Maximum delay threshold</p>
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public long? MaxDelayTime{ get; set; }

        /// <summary>
        /// <p>Instance disk type. Only CLOUD disk edition and single-node (CLOUD disk) instances will return a valid value.<br>Description:</p><ol><li>If "DiskType": "CLOUD_HSSD" is returned, it indicates that the instance disk type is enhanced SSD CLOUD disk.</li><li>If "DiskType": "CLOUD_SSD" is returned, it indicates that the instance disk type is SSD CLOUD Block Storage.</li><li>If "DiskType": "" is returned and the DeviceType parameter value is UNIVERSAL or EXCLUSIVE, it means that the instance uses local SSD.</li></ol>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Current number of CPU cores for scale-out.</p>
        /// </summary>
        [JsonProperty("ExpandCpu")]
        public long? ExpandCpu{ get; set; }

        /// <summary>
        /// <p>Cloud Disk Edition instance node information</p>
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo[] ClusterInfo{ get; set; }

        /// <summary>
        /// <p>Analysis engine node list</p>
        /// </summary>
        [JsonProperty("AnalysisNodeInfos")]
        public AnalysisNodeInfo[] AnalysisNodeInfos{ get; set; }

        /// <summary>
        /// <p>Device bandwidth, in G. This parameter is valid only when DeviceClass is not empty. For example, 25 means the current device bandwidth is 25G; 10 means the current device bandwidth is 10G.</p>
        /// </summary>
        [JsonProperty("DeviceBandwidth")]
        public ulong? DeviceBandwidth{ get; set; }

        /// <summary>
        /// <p>Instance termination protection status. on indicates enabled; otherwise, the protection is disabled.</p>
        /// </summary>
        [JsonProperty("DestroyProtect")]
        public string DestroyProtect{ get; set; }

        /// <summary>
        /// <p>TDSQL engine parameters</p>
        /// </summary>
        [JsonProperty("CpuModel")]
        public string CpuModel{ get; set; }

        /// <summary>
        /// <p>Analysis engine instance version upgrade information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnalysisUpgradeVersionInfo")]
        public UpgradeAnalysisInstanceVersionInfo AnalysisUpgradeVersionInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InitFlag", this.InitFlag);
            this.SetParamObj(map, prefix + "RoVipInfo.", this.RoVipInfo);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamObj(map, prefix + "SlaveInfo.", this.SlaveInfo);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamArrayObj(map, prefix + "RoGroups.", this.RoGroups);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamObj(map, prefix + "MasterInfo.", this.MasterInfo);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "DrInfo.", this.DrInfo);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "CdbError", this.CdbError);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "PhysicalId", this.PhysicalId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "DeviceClass", this.DeviceClass);
            this.SetParamSimple(map, prefix + "DeployGroupId", this.DeployGroupId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "InstanceNodes", this.InstanceNodes);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "ExpandCpu", this.ExpandCpu);
            this.SetParamArrayObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamArrayObj(map, prefix + "AnalysisNodeInfos.", this.AnalysisNodeInfos);
            this.SetParamSimple(map, prefix + "DeviceBandwidth", this.DeviceBandwidth);
            this.SetParamSimple(map, prefix + "DestroyProtect", this.DestroyProtect);
            this.SetParamSimple(map, prefix + "CpuModel", this.CpuModel);
            this.SetParamObj(map, prefix + "AnalysisUpgradeVersionInfo.", this.AnalysisUpgradeVersionInfo);
        }
    }
}

