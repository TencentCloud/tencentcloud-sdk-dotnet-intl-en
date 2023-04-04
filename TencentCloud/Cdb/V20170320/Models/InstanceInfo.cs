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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// Public network access status. Value range: 0 (not enabled), 1 (enabled), 2 (disabled)
        /// </summary>
        [JsonProperty("WanStatus")]
        public long? WanStatus{ get; set; }

        /// <summary>
        /// AZ information
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Initialization flag. Value range: 0 (not initialized), 1 (initialized)
        /// </summary>
        [JsonProperty("InitFlag")]
        public long? InitFlag{ get; set; }

        /// <summary>
        /// VIP information of a read-only instance. This field is exclusive to read-only instances where read-only access is enabled separately
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoVipInfo")]
        public RoVipInfo RoVipInfo{ get; set; }

        /// <summary>
        /// Memory capacity in MB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance status. Valid values: `0` (creating), `1` (running), `4` (isolating), `5` (isolated).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// VPC ID, such as 51102
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// Information of a secondary server
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SlaveInfo")]
        public SlaveInfo SlaveInfo{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Disk capacity in GB
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// Auto-renewal flag. Value range: 0 (auto-renewal not enabled), 1 (auto-renewal enabled), 2 (auto-renewal disabled)
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// Data replication mode. Valid values: 0 (async), 1 (semi-sync), 2 (strong sync)
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// Details of a read-only group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoGroups")]
        public RoGroup[] RoGroups{ get; set; }

        /// <summary>
        /// Subnet ID, such as 2333
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// Instance type. Value range: 1 (primary), 2 (disaster recovery), 3 (read-only)
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Region information
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance expiration time
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// AZ deployment mode. Valid values: 0 (single-AZ), 1 (multi-AZ)
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// Instance task status. 0 - no task; 1 - upgrading; 2 - importing data; 3 - activating secondary; 4 - enabling public network access; 5 - batch operation in progress; 6 - rolling back; 7 - disabling public network access; 8 - changing password; 9 - renaming instance; 10 - restarting; 12 - migrating self-built instance; 13 - dropping table; 14 - creating and syncing disaster recovery instance; 15 - pending upgrade and switch; 16 - upgrade and switch in progress; 17 - upgrade and switch completed
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// Details of a primary instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterInfo")]
        public MasterInfo MasterInfo{ get; set; }

        /// <summary>
        /// Instance type
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Kernel version
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Details of a disaster recovery instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DrInfo")]
        public DrInfo[] DrInfo{ get; set; }

        /// <summary>
        /// Public domain name
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// Public network port number
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Instance IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// Whether the disk write is locked (It depends on whether the instance data in disk exceeds its quota). Valid values: `0` (unlocked), `1` (locked).
        /// </summary>
        [JsonProperty("CdbError")]
        public long? CdbError{ get; set; }

        /// <summary>
        /// VPC descriptor, such as "vpc-5v8wn9mg"
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Subnet descriptor, such as "subnet-1typ0s7d"
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Physical ID
        /// </summary>
        [JsonProperty("PhysicalId")]
        public string PhysicalId{ get; set; }

        /// <summary>
        /// Number of cores
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Queries per second
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Physical machine model
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeviceClass")]
        public string DeviceClass{ get; set; }

        /// <summary>
        /// Placement group ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// AZ ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// List of tags
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfoItem[] TagList{ get; set; }

        /// <summary>
        /// Engine type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// Maximum delay threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public long? MaxDelayTime{ get; set; }

        /// <summary>
        /// Instance disk type, which is returned only for the instances of cloud disk edition. Valid values: `CLOUD_SSD` (SSD), `CLOUD_HSSD` (Enhanced SSD).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }


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
        }
    }
}

