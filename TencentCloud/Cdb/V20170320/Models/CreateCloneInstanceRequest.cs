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

    public class CreateCloneInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Clone source instance ID, which can be obtained through the <a href="https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1">DescribeDBInstances</a> API.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>If necessary, specify this value when cloning an instance and rolling back to a specified time. The time format is yyyy-mm-dd hh:mm:ss.<br>Note: This parameter and the SpecifiedBackupId parameter require a choice between the two for configuration.</p>
        /// </summary>
        [JsonProperty("SpecifiedRollbackTime")]
        public string SpecifiedRollbackTime{ get; set; }

        /// <summary>
        /// <p>If necessary to clone an instance and roll back to a designated backup set, specify this value as the Id of the backup file. Please use <a href="/document/api/236/15842">query data backup file list</a>.</p><p>If it is a clone of a two-node, three-node, or four-node instance, the backup file is a physical backup. If it is a clone of a single-node or cloud disk edition instance, the backup file is a snapshot backup.</p>
        /// </summary>
        [JsonProperty("SpecifiedBackupId")]
        public long? SpecifiedBackupId{ get; set; }

        /// <summary>
        /// <p>VPC ID. Please use <a href="/document/api/215/15778">Querying VPC List</a>.</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID in the private network. If UniqVpcId is set up, UniqSubnetId is required. Please use <a href="/document/api/215/15784">query subnet list</a>.</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>Instance memory size, unit: MB, must not be less than the clone source instance. Default is same as the source instance.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Instance disk size, unit: GB, must not be less than the clone source instance. Default is same as the source instance.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// <p>Name of the newly generated clone instance. Support input of up to 60 characters.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Security group parameters. Use the API <a href="https://www.tencentcloud.com/document/api/236/15850?from_cn_redirect=1">Query Project Security Group Information</a> to query security group details of a certain project.</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// <p>Tag information of the instance.</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Instance Cpu cores, must not be less than the clone source instance. Default is same as the source instance.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Data replication method, defaults to 0. Supported values include: 0 - means async replication, 1 - means semi-sync replication, 2 - means strong sync replication.</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>Multiple Availability Zones, defaults to 0. Supported values include: 0 - means single availability zone, 1 - means multi-availability zone.</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// <p>The AZ information of the newly generated clone instance standby 1 is the same as the source instance Zone by default.</p>
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// <p>AZ information of standby 2, empty by default. Specify this parameter when you clone a strong sync primary instance.</p>
        /// </summary>
        [JsonProperty("BackupZone")]
        public string BackupZone{ get; set; }

        /// <summary>
        /// <p>Clone instance type. Supported values include: "UNIVERSAL" - general-purpose instance, "EXCLUSIVE" - dedicated instance, "CLOUD_NATIVE_CLUSTER" - standard type for CLOUD disk, "CLOUD_NATIVE_CLUSTER_EXCLUSIVE" - enhanced type for CLOUD disk. If not specified, it defaults to general-purpose instance.</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Number of nodes in the new clone instance.</p><p>To clone a three-node instance, set this value to 3 or specify the BackupZone parameter. To clone a dual-node instance, set this value to 2. By default, a dual-node instance is cloned. To clone a four-node instance, set this value to 4 or specify the FourthZone parameter.</p>
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// <p>Placement group ID.</p>
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// <p>Whether to only pre-check this request. true: Send a check request without creating an instance. Check items include required parameters, request format, and service limits. If the check fails, return the corresponding error code; if the check passes, return RequestId. Default false: Send a normal request and create the instance directly after passing the check.</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>Financial Enclosure ID.</p>
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// <p>Project ID. Default project ID 0.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>Payment type. Valid values: PRE_PAID (prepaid, also known as yearly/monthly subscription) and USED_PAID (pay-as-you-go). Default billing mode is pay-as-you-go.</p>
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// <p>Instance duration, required when PayType is PRE_PAID, measurement unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>Topology configuration for cloud disk edition nodes.</p>
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }

        /// <summary>
        /// <p>Original instance region. Required when importing a remote backup, for example: ap-guangzhou</p>
        /// </summary>
        [JsonProperty("SrcRegion")]
        public string SrcRegion{ get; set; }

        /// <summary>
        /// <p>Offsite data backup id</p>
        /// </summary>
        [JsonProperty("SpecifiedSubBackupId")]
        public long? SpecifiedSubBackupId{ get; set; }

        /// <summary>
        /// <p>The AZ information of the newly generated clone instance primary database is the same as the source instance Zone by default.</p>
        /// </summary>
        [JsonProperty("MasterZone")]
        [System.Obsolete]
        public string MasterZone{ get; set; }

        /// <summary>
        /// <p>The AZ information of the newly generated clone instance's primary database defaults to the same as the source instance's Zone.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

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
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SpecifiedRollbackTime", this.SpecifiedRollbackTime);
            this.SetParamSimple(map, prefix + "SpecifiedBackupId", this.SpecifiedBackupId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamSimple(map, prefix + "BackupZone", this.BackupZone);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceNodes", this.InstanceNodes);
            this.SetParamSimple(map, prefix + "DeployGroupId", this.DeployGroupId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamObj(map, prefix + "ClusterTopology.", this.ClusterTopology);
            this.SetParamSimple(map, prefix + "SrcRegion", this.SrcRegion);
            this.SetParamSimple(map, prefix + "SpecifiedSubBackupId", this.SpecifiedSubBackupId);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "FourthZone", this.FourthZone);
        }
    }
}

