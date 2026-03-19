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

    public class CreateDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance memory size in MB. You can use the [DescribeDBZoneConfig](https://intl.cloud.tencent.com/document/api/236/17229?from_cn_redirect=1) API to query the supported memory specifications.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance disk size in GB. You can use the [DescribeDBZoneConfig](https://intl.cloud.tencent.com/document/api/236/17229?from_cn_redirect=1) API to query the supported disk specifications.
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// Instance validity period in months. Valid values: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `24`, `36`.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Number of instances. Value range: 1-100. Default value: `1`.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// For AZ information, please use the [Obtain the Purchasable Specifications of Cloud Databases](https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1) API to obtain the availability zones that can be created.
        /// Description: If you create a single-node, two-node, or three-node instance, this parameter is required. Specify an availability zone. If you do not specify an availability zone, the system will automatically select one (possibly not the availability zone you want to deploy in). If you create a cloud disk edition instance, leave this parameter empty. Configure the availability zone for the read-write node and read-only node with parameter ClusterTopology.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// VPC ID. Please use [Querying VPC list](https://www.tencentcloud.com/document/api/215/15778?from_cn_redirect=1).
        /// Description: If a cloud disk edition instance is created, this item is required and must be a VPC type. If this item is left blank, the system will select the default VPC.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Subnet ID in the private network. If UniqVpcId is set up, UniqSubnetId is required. Please use [query subnet list](https://www.tencentcloud.com/document/api/215/15784?from_cn_redirect=1).
        /// Description: If this item is left empty, the system will select the default subnet in the Default VPC.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Project ID. If this parameter is left empty, the default project will be used. When you purchase read-only instances and disaster recovery instances, the project ID is the same as that of the source instance by default.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Custom port. Port range: 1024-65535.
        /// Description: If this item is left blank, it defaults to 3306.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Instance type. Supported values include: master - indicates the primary instance, dr - indicates the disaster recovery instance, ro - indicates the read-only instance.
        /// Description: Select instance type. The master type is selected by default if left empty.
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// Instance ID, required when purchasing a read-only instance or disaster recovery instance. This field represents the primary instance ID of the read-only instance or disaster recovery instance. Please use the [Query Instance List](https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) API to query the cloud database instance ID.
        /// </summary>
        [JsonProperty("MasterInstanceId")]
        public string MasterInstanceId{ get; set; }

        /// <summary>
        /// MySQL version, including 5.5, 5.6, 5.7, and 8.0. Please use the [obtain the purchasable specifications of cloud databases](https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1) API to get the version of the instance created.
        /// Description: When creating a non-cloud disk edition instance, specify the instance version as needed (recommend 5.7 or 8.0). If this parameter is left empty, the default value is 8.0. If creating a cloud disk edition instance, this parameter can only be set to 5.7 or 8.0.
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// The root account password, which can contain 8-64 characters and must contain at least two of the following types of characters: letters, digits, and symbols `_+-&=!@#$%^*()`. This parameter applies to source instances but not to read-only or disaster recovery instances.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Data replication mode. Valid values: `0` (async replication), `1` (semi-sync replication), `2` (strong sync replication). Default value: `0`.
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// Multi-AZ or single-AZ. Valid values: `0` (single-AZ), `1` (multi-AZ). Default value: `0`.
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// AZ information of standby database 1.
        /// Description: For two-node and three-node instances, specify this parameter. If not specified, it defaults to the value of Zone. For cloud disk edition instances, this parameter is optional. Configure the availability zone for read-write nodes and read-only nodes with parameter ClusterTopology. Single-node instances are single availability zone and no need to specify this parameter.
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// Parameter list. The parameter format is ParamList.0.Name=auto_increment&ParamList.0.Value=1. You can query the configurable parameters by default by referring to [Querying the Default Configurable Parameter List](https://www.tencentcloud.com/document/api/236/32662?from_cn_redirect=1).
        /// Description: table name case sensitivity can be enabled or disabled with parameter lower_case_table_names. A parameter value of 0 means enabling, and 1 means disabling. If not set, the default value is 0. For MySQL 8.0 edition instances, you need to set the lower_case_table_names parameter when creating an instance to turn on or off table name case sensitivity. Once created, the parameter cannot be modified, meaning table name case sensitivity cannot be changed after creation. Other database versions support modifying the lower_case_table_names parameter after the instance is created. For the function invocation method to set table name case sensitivity when creating an instance, please see example 3 in this document.
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamInfo[] ParamList{ get; set; }

        /// <summary>
        /// Information of replica AZ 2, which is left empty by default. Specify this parameter when purchasing a source instance in the one-source-two-replica architecture.
        /// </summary>
        [JsonProperty("BackupZone")]
        public string BackupZone{ get; set; }

        /// <summary>
        /// Auto-renewal flag. Available values are: 0 - no auto-renewal; 1 - auto-renewal. Default is 0.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Region information of the source instance, which is required when purchasing a read-only or disaster recovery instance.
        /// </summary>
        [JsonProperty("MasterRegion")]
        public string MasterRegion{ get; set; }

        /// <summary>
        /// Security group parameter. You can use the [DescribeProjectSecurityGroups](https://intl.cloud.tencent.com/document/api/236/15850?from_cn_redirect=1) API to query the security group details of a project.
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// Read-only instance parameter. This parameter must be passed in when purchasing read-only instances.
        /// </summary>
        [JsonProperty("RoGroup")]
        public RoGroup RoGroup{ get; set; }

        /// <summary>
        /// Instance name. For multiple instances purchased at one time, they will be distinguished by the name suffix number, such as instnaceName=db and goodsNum=3, and their instance names are db1, db2, and db3, respectively.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance tag information
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// Placement group ID
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// A string unique in 48 hours, which is supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Instance isolation type. Supported values include "UNIVERSAL" - general-purpose instance, "EXCLUSIVE" - dedicated instance, "BASIC_V2" - ONTKE single-node instance, "CLOUD_NATIVE_CLUSTER" - standard type for cloud disk edition, "CLOUD_NATIVE_CLUSTER_EXCLUSIVE" - enhanced for cloud disk edition. Default to general-purpose instance if not specified.
        /// Description: If a cloud disk edition instance is created, this parameter is required.
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Parameter template id.
        /// Remark: If you use a custom parameter template ID, you can input the custom parameter template ID. If you plan to use the default parameter template, inputting the parameter template ID is invalid, and you need to set ParamTemplateType.
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// Array of alarm policy IDs, which can be obtained through the `OriginId` field in the return value of the `DescribeAlarmPolicy` API of TCOP.
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public long?[] AlarmPolicyList{ get; set; }

        /// <summary>
        /// The number of nodes of the instance. To purchase a read-only instance or a basic instance, set this parameter to `1` or leave it empty. To purchase a three-node instance, set this parameter to `3` or specify the `BackupZone` parameter. If the instance to be purchased is a source instance and both `BackupZone` and this parameter are left empty, the value `2` will be used, which indicates the source instance will have two nodes.
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// The number of the instance CPU cores. If this parameter is left empty, it will be subject to the `Memory` value.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Whether to automatically start disaster recovery synchronization. This parameter takes effect only for disaster recovery instances. Valid values: `0` (no), `1` (yes). Default value: `0`.
        /// </summary>
        [JsonProperty("AutoSyncFlag")]
        public long? AutoSyncFlag{ get; set; }

        /// <summary>
        /// Financial cage ID.
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// Default parameter template type. Supported values include: "HIGH_STABILITY" - high-stability template, "HIGH_PERFORMANCE" - high-performance template.
        /// Remark: If you need to use the TencentDB for MySQL default parameter template, set up ParamTemplateType.
        /// </summary>
        [JsonProperty("ParamTemplateType")]
        public string ParamTemplateType{ get; set; }

        /// <summary>
        /// The array of alarm policy names, such as ["policy-uyoee9wg"]. If the `AlarmPolicyList` parameter is specified, this parameter is invalid.
        /// </summary>
        [JsonProperty("AlarmPolicyIdList")]
        public string[] AlarmPolicyIdList{ get; set; }

        /// <summary>
        /// Whether to only pre-check this request. true: Send a check request without creating an instance. Check items include whether required parameters are filled, request format, and service limit. If the check failed, return the corresponding error code; if the check passed, return RequestId. false: Send a normal request and create the instance directly after passing the check.
        /// Defaults to false.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Instance engine type. Valid values: `InnoDB` (default), `RocksDB`.
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// The list of IPs for sources instances. Only one IP address can be assigned to a single source instance. If all IPs are used up, the system will automatically assign IPs to the remaining source instances that do not have one.
        /// </summary>
        [JsonProperty("Vips")]
        public string[] Vips{ get; set; }

        /// <summary>
        /// Data protection space size of the cloud disk edition instance in GB. Setting range is 1 - 10.
        /// </summary>
        [JsonProperty("DataProtectVolume")]
        public long? DataProtectVolume{ get; set; }

        /// <summary>
        /// Cloud disk edition node topology configuration.
        /// Description: If a cloud disk edition instance is purchased, this parameter is required. Set the RW and RO node topology for the cloud disk edition instance. The RO node scope is 1-5. Set at least 1 RO node.
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }

        /// <summary>
        /// Disk Type. This parameter can be specified for single-node (cloud disk edition) or cloud disk edition instance. CLOUD_SSD means SSD Cloud Block Storage, CLOUD_HSSD refers to enhanced SSD cloud disk, and CLOUD_PREMIUM indicates high-performance cloud block storage.
        /// Description: The supported regions for the hard disk type of single-node (cloud disk edition) and cloud disk edition instances vary slightly. For the specific support situation, refer to [Regions and Availability Zones](https://www.tencentcloud.com/document/product/236/8458?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Turn on or off instance destruction protection. on - enabled, off - disabled.
        /// </summary>
        [JsonProperty("DestroyProtect")]
        public string DestroyProtect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "MasterInstanceId", this.MasterInstanceId);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "BackupZone", this.BackupZone);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "MasterRegion", this.MasterRegion);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamObj(map, prefix + "RoGroup.", this.RoGroup);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DeployGroupId", this.DeployGroupId);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyList.", this.AlarmPolicyList);
            this.SetParamSimple(map, prefix + "InstanceNodes", this.InstanceNodes);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "AutoSyncFlag", this.AutoSyncFlag);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "ParamTemplateType", this.ParamTemplateType);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyIdList.", this.AlarmPolicyIdList);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamArraySimple(map, prefix + "Vips.", this.Vips);
            this.SetParamSimple(map, prefix + "DataProtectVolume", this.DataProtectVolume);
            this.SetParamObj(map, prefix + "ClusterTopology.", this.ClusterTopology);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DestroyProtect", this.DestroyProtect);
        }
    }
}

