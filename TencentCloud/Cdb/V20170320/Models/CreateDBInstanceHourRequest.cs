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

    public class CreateDBInstanceHourRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance count. Default value is 1, minimum value 1, maximum value 100.</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// <p>Instance memory size. Unit: MB. Please use the <a href="https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to obtain creatable memory specifications.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Instance disk size, unit: GB. Please use the <a href="https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to get the creatable disk range.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// <p>MySQL version, including 5.5, 5.6, 5.7, and 8.0. Please use the <a href="https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to get the instance version created.<br>Note: When creating a non-cloud disk edition instance, specify the instance version as needed (recommend 5.7 or 8.0). If this parameter is left blank, the default value is 8.0. If creating a cloud disk edition instance, this parameter can only be set to 5.7 or 8.0.</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// <p>VPC ID. Please use <a href="/document/api/215/15778">Querying VPC List</a>.<br>Description: If you create a cloud disk edition instance, this item is required and must be VPC type. If this item is left blank, the system will select the default VPC by default.</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID in the private network. If UniqVpcId is set up, UniqSubnetId is required. Please use <a href="/document/api/215/15784">query subnet list</a>.<br>Description: If this item is not filled, the system will select the default subnet in the Default VPC.</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Project ID. If this is left empty, the default project will be used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>For AZ information, please use the <a href="https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1">Obtain the Purchasable Specifications of Cloud Databases</a> API to obtain the availability zones where instances can be created.</p><p>If you create a single-node, two-node, three-node, or four-node instance, this parameter is required. Specify an availability zone. If no availability zone is specified, the system will automatically select one (possibly not the availability zone you want to deploy in). If you create a cloud disk-based cluster instance, leave this parameter blank and configure the availability zones for RWNode and read-only nodes with parameter ClusterTopology.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Instance ID, required when you purchase a read-only instance or disaster recovery instance. This field represents the primary instance ID of the read-only instance or disaster recovery instance. Please use the <a href="https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1">Query Instance List</a> API to query the cloud database instance ID.</p>
        /// </summary>
        [JsonProperty("MasterInstanceId")]
        public string MasterInstanceId{ get; set; }

        /// <summary>
        /// <p>Instance type. Supported values include: master - primary instance, dr - disaster recovery instance, ro - read-only instance.<br>Description: Select instance type. master is selected by default if left blank.</p>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// <p>Region of the primary instance. This field is required when you purchase a disaster recovery or RO instance.</p>
        /// </summary>
        [JsonProperty("MasterRegion")]
        public string MasterRegion{ get; set; }

        /// <summary>
        /// <p>Custom port. Supported range: [1024-65535].<br>Description: If left blank, it defaults to 3306.</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Set the root account password. The password must contain 8 to 64 characters and at least two of the following: letters, digits, or characters (supported characters: _+-&amp;=!@#$%^*()). You can specify this parameter when purchasing a primary instance. This parameter is invalid when purchasing a read-only instance or disaster recovery instance.</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Parameter list. The parameter format is ParamList.0.Name=auto_increment&amp;ParamList.0.Value=1.</p><p>Query the configurable parameters by referring to <a href="https://www.tencentcloud.com/document/api/236/32662?from_cn_redirect=1">querying the default configurable parameter list</a>.<br>Note: table Name case sensitivity can be enabled or disabled with the parameter lower_case_table_names. a parameter Value of 0 means enabling, and a Value of 1 means disabling. If not set, the default Value is 0. If you create a MySQL 8.0 edition instance, you need to set the lower_case_table_names parameter when creating the instance to enable or disable table Name case sensitivity. After the instance is created, the parameter cannot be modified, meaning table Name case sensitivity cannot be changed once created. Instances of other database versions support modifying the lower_case_table_names parameter after creation. For the function invocation method to set table Name case sensitivity when creating an instance, please see examples in this document.</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamInfo[] ParamList{ get; set; }

        /// <summary>
        /// <p>Data replication method, defaults to 0. Supported values include: 0 - means async replication, 1 - means semi-sync replication, 2 - means strong sync replication. You can specify this parameter when purchasing a primary instance. This parameter is invalid when purchasing a read-only instance or disaster recovery instance.</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>Multiple Availability Zones, defaults to 0. Supported values include: 0 - means single availability zone, 1 - means multi-availability zone. Specify this parameter when purchasing the primary instance. This parameter is invalid when purchasing a read-only instance or disaster recovery instance.</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// <p>AZ information of standby database 1.</p><p>For two-node, three-node, or four-node instances, specify this parameter. If not specified, it defaults to the Zone value. For cloud disk edition instances, this parameter is optional. Configure the AZ for read-write and read-only nodes with parameter ClusterTopology. Single-node instances are in a single availability zone, so no need to specify this parameter.</p>
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// <p>AZ information of standby 2, empty by default.</p><p>Specify this parameter when you proceed to purchase a three-node primary instance or a four-node primary instance.</p>
        /// </summary>
        [JsonProperty("BackupZone")]
        public string BackupZone{ get; set; }

        /// <summary>
        /// <p>Security group parameters. Use the API <a href="https://www.tencentcloud.com/document/api/236/15850?from_cn_redirect=1">Query Project Security Group Information</a> to query security group details of a certain project.</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// <p>Read-only instance information. This parameter is required when you purchase a read-only instance.</p>
        /// </summary>
        [JsonProperty("RoGroup")]
        public RoGroup RoGroup{ get; set; }

        /// <summary>
        /// <p>This field is meaningless for pay-as-you-go instances.</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>Instance name. When you purchase multiple instances only once, suffix numbers are used for case-sensitive instance naming. For example, instanceName=db and goodsNum=3, the instance names are db1, db2, and db3 respectively.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Tag information of the instance.</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Placement group ID.</p>
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// <p>String used to ensure request idempotency. This string is generated by the customer and must be unique between different requests within 48 hours, with a maximum value of 64 ASCII characters. If not specified, request idempotency cannot be guaranteed.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Instance isolation type.</p><p>Enumeration values:</p><ul><li><p>UNIVERSAL: General-purpose instance</p></li><li><p>EXCLUSIVE: Dedicated instance</p></li><li><p>CLOUD_NATIVE_CLUSTER: Standard type of cloud disk edition</p></li><li><p>CLOUD_NATIVE_CLUSTER_EXCLUSIVE: Enhanced type of cloud disk edition</p></li><li><p>CLOUD_NATIVE_CLUSTER_ULTRA: Premium type of cloud disk edition</p></li><li><p>If this parameter is not specified, it defaults to general-purpose instance.</p></li><li><p>Required if you create a cloud disk edition instance.</p></li><li><p>If you create a single-node instance, fill in this parameter as CLOUD_NATIVE_CLUSTER and specify parameter InstanceNodes equal to 1.</p></li></ul>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Parameter template ID.<br>Remark: If you use a custom parameter template ID, you can input the custom parameter template ID. If you plan to use the default parameter template, the input ID is invalid and you need to set ParamTemplateType.</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>Array of alarm policy IDs. OriginId returned by the Tencent Cloud observability platform DescribeAlarmPolicy API.</p>
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public long?[] AlarmPolicyList{ get; set; }

        /// <summary>
        /// <p>Number of instance nodes.</p><p>For RO and single-node instances, the default value is 1. To purchase a three-node instance, set this value to 3 or specify the BackupZone parameter. When purchasing a primary instance without specifying this parameter or the BackupZone parameter, the default value is 2, meaning a dual-node instance will be purchased. To purchase a four-node instance, set this value to 4 or specify the FourthZone parameter.</p>
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// <p>Number of Cpu cores of the instance.</p><p>When multiple Cpu configurations exist for the Memory specification (for example, 64000MB Memory corresponds to 8-core/16-core/32-core), the Cpu parameter must be provided.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Whether to automatically initiate disaster recovery sync. This parameter only takes effect when purchasing a disaster recovery instance. Available values are: 0 - Do not automatically initiate disaster recovery sync; 1 - Automatically initiate disaster recovery sync. The default is 0.</p>
        /// </summary>
        [JsonProperty("AutoSyncFlag")]
        public long? AutoSyncFlag{ get; set; }

        /// <summary>
        /// <p>Financial Enclosure ID.</p>
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// <p>Default parameter template type. Supported values include "HIGH_STABILITY" - HIGH-STABILITY template, "HIGH_PERFORMANCE" - HIGH-PERFORMANCE template. Default value is "HIGH_STABILITY".<br>Remark: If you need to use the cloud database MySQL default parameter template, set up ParamTemplateType.</p>
        /// </summary>
        [JsonProperty("ParamTemplateType")]
        public string ParamTemplateType{ get; set; }

        /// <summary>
        /// <p>Alarm policy name array, such as ["policy-uyoee9wg"]. This parameter is invalid when AlarmPolicyList is not empty.</p>
        /// </summary>
        [JsonProperty("AlarmPolicyIdList")]
        public string[] AlarmPolicyIdList{ get; set; }

        /// <summary>
        /// <p>Whether to only pre-check this request. true: Send a check request without creating an instance. Check items include required parameters, request format, and service limits. If the check fails, return the corresponding error code; if the check passes, return RequestId. Default false: Send a normal request and create the instance directly after passing the check.</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>Instance engine type, defaults to "InnoDB". Supported values include "InnoDB" and "RocksDB".</p>
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// <p>Specify the IP list of the instance. Only the primary instance is supported. Process by instance sequence. Handle as unspecified if insufficient.</p>
        /// </summary>
        [JsonProperty("Vips")]
        public string[] Vips{ get; set; }

        /// <summary>
        /// <p>The data protection space size of the cloud disk edition instance, in GB, has a setting range of 1 - 10.</p>
        /// </summary>
        [JsonProperty("DataProtectVolume")]
        public long? DataProtectVolume{ get; set; }

        /// <summary>
        /// <p>Topology configuration for cloud disk edition nodes.<br>Description: If a cloud disk edition instance is purchased, this parameter is required. Set the topology for RW and RO nodes of the cloud disk edition instance. The node scope for RO nodes is 1-5. Set at least 1 RO node.</p>
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }

        /// <summary>
        /// <p>Disk type. This parameter can be specified for single-node (cloud disk) or cloud disk edition instances. CLOUD_SSD means SSD Cloud Block Storage, CLOUD_HSSD means enhanced SSD cloud disk, and CLOUD_PREMIUM means high-performance cloud block storage.<br>Note: The supported regions for disk types of single-node (cloud disk) and cloud disk edition instances vary slightly. For specific support situation, refer to <a href="https://www.tencentcloud.com/document/product/236/8458?from_cn_redirect=1">Regions and Availability Zones</a>.</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>ClusterType: cage-Financial Enclosure, cdc-CDB ON CDC; dedicate-dedicated cluster</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>Turn on or off instance destruction protection. on - turn on, off - turn off.</p>
        /// </summary>
        [JsonProperty("DestroyProtect")]
        public string DestroyProtect{ get; set; }

        /// <summary>
        /// <p>AZ information of standby 3, empty by default. Specify this parameter when you proceed to purchase a four-node primary instance.</p>
        /// </summary>
        [JsonProperty("FourthZone")]
        public string FourthZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "MasterInstanceId", this.MasterInstanceId);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "MasterRegion", this.MasterRegion);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamSimple(map, prefix + "BackupZone", this.BackupZone);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamObj(map, prefix + "RoGroup.", this.RoGroup);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
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
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "DestroyProtect", this.DestroyProtect);
            this.SetParamSimple(map, prefix + "FourthZone", this.FourthZone);
        }
    }
}

