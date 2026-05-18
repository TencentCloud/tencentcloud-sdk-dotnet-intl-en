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

    public class CreateDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <ul><li>Specifies the number of primary and secondary nodes for each replica set during replica set instance creation. Call the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to obtain the maximum and minimum number of nodes supported for each replica set.</li><li>Specifies the number of primary and secondary nodes for each shard during sharded cluster instance creation. Call the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to obtain the maximum and minimum number of nodes supported for each shard.</li></ul>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>Instance memory size. Unit: GB. Call the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to obtain specific saleable memory specifications.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>Instance disk size. Unit: GB. Call the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to obtain the maximum and minimum disk sizes corresponding to each CPU specification.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// <p>Refers to version information. For supported versions, use the interface <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> to query.</p><ul><li>MONGO_40_WT: MongoDB 4.0 WiredTiger engine version.</li><li>MONGO_42_WT: MongoDB 4.2 WiredTiger engine version.</li><li>MONGO_44_WT: MongoDB 4.4 WiredTiger engine version.</li><li>MONGO_50_WT: MongoDB 5.0 WiredTiger engine version.</li><li>MONGO_60_WT: MongoDB 6.0 WiredTiger engine version.</li><li>MONGO_70_WT: MongoDB 7.0 WiredTiger engine version.</li><li>MONGO_80_WT: MongoDB 8.0 WiredTiger engine version.</li></ul>
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// <p>Number of instances. The minimum value is 1, and the maximum value is 30.</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>AZ information. The input format must be ap-guangzhou-2.</p><ul><li>For details, use the interface <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> to obtain them.</li><li>This parameter is the primary AZ. If multi-AZ deployment is used, Zone must be one of AvailabilityZoneList.</li></ul>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Specifies the purchase duration during instance purchase. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, and 36. Unit: months.</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>Recommended product specification types:</p><ul><li>GE.LD.T1: Local disk (Common I).</li><li>GE.CD.T1: Cloud disk (Common I).</li></ul><p>Product allowlist specification types:</p><ul><li>HIO10G: Local disk (High IO 10G).</li><li>HCD: Cloud disk (Cloud disk edition).</li></ul><p>Note: Allowlist specification types are under allowlist control. If needed, <a href="https://console.cloud.tencent.com/workorder/category">submit a ticket</a> to apply.</p>
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// <p>Instance architecture type.</p><ul><li>REPLSET (replica set)</li><li>SHARD (sharded cluster)</li></ul>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <ul><li>Specifies the number of replica sets during replica set instance creation. This parameter can only be 1.</li><li>Specifies the number of shards during sharded cluster instance creation. Call the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to query the range of shard quantity. The parameters MinReplicateSetNum and MaxReplicateSetNum in the returned data structure SpecItems correspond to the minimum value and maximum value, respectively.</li></ul>
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// <p>Project ID.</p><ul><li>If this parameter is not set, the default project is used.</li><li>You can obtain the project ID on the <a href="https://console.cloud.tencent.com/project">MongoDB console project management</a> page.</li></ul>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>VPC ID.</p><ul><li>Only private networks can be configured, and a private network in the same region as the instance must be selected. Log in to the <a href="https://console.cloud.tencent.com/vpc">VPC console</a> to obtain a used private network ID.</li><li>After successful instance creation, VPC replacement is allowed. For detailed operations, see <a href="https://www.tencentcloud.com/document/product/239/30910?from_cn_redirect=1">Changing the Network</a>.</li></ul>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID of the VPC.</p><ul><li>You must specify a subnet within the selected private network. Log in to the <a href="https://console.cloud.tencent.com/vpc">VPC console</a> to obtain the subnet ID.</li><li>After the instance is successfully created, replacement of the private network and subnet is allowed. For detailed operations, please refer to <a href="https://www.tencentcloud.com/document/product/239/30910?from_cn_redirect=1">Network Change</a>.</li></ul>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Instance password. The requirements are as follows:</p><ul><li>Character count is [8,32].</li><li>Enter characters within [A,Z], [a,z], [0,9].</li><li>Special characters include: exclamation mark "!", at "@", pound sign "#", percent sign "%", caret "^", asterisk "*", brackets "()", underscore "_".</li><li>Cannot set a single letter or number.</li></ul>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Instance tag information.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Auto-renewal flag.</p><ul><li>0: no auto-renewal.</li><li>1: auto-renewal.</li></ul>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>Indicates whether to automatically select voucher.</p><ul><li>1: Yes.</li><li>0: No. Default is 0.</li></ul>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>Instance type.</p><ul><li>1: Formal instance.</li><li>3: Read-only instance.</li><li>4: Disaster recovery instance.</li><li>5: Clone instance. Note: RestoreTime is a required item when you clone an instance.</li></ul>
        /// </summary>
        [JsonProperty("Clone")]
        public long? Clone{ get; set; }

        /// <summary>
        /// <p>Parent instance ID.</p><ul><li>When the <strong>Clone</strong> parameter is 3 or 4, that is, the instance is read-only or a disaster recovery instance, this parameter must be configured.</li><li>Log in to the <a href="https://console.cloud.tencent.com/mongodb">MongoDB console</a> and copy the parent instance ID in the instance list.</li></ul>
        /// </summary>
        [JsonProperty("Father")]
        public string Father{ get; set; }

        /// <summary>
        /// <p>Security group ID. Log in to the <a href="https://console.cloud.tencent.com/vpc/security-group">security group console</a> to obtain the ID of the security group within the same region as the database instance.</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// <p>Rollback time of the cloned instance. It is required when the Clone value is 5 or 6. - This parameter is required for cloned instances. Format: 2021-08-13 16:30:00. - Rollback time range: Only data within the last 7 days can be rolled back.</p>
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// <p>Instance name. Only Chinese, English, digits, underscores (_), and hyphens (-) are supported, with a maximum length of 128 characters. When purchasing database instances in batches, you can efficiently set instance names by using custom pattern strings and automatically ascending numeric suffixes.</p><ul><li>Basic mode: prefix + automatic ascending number (starting from 1 by default). Only a custom instance name prefix is required for <strong>lnstanceName</strong>. For example, it can be set to cmgo. If the purchase quantity is set to 5, after purchase, the instances will be sequentially named cmgo1, cmgo2, cmgo3, cmgo4, and cmgo5, respectively.</li><li>Custom starting number mode: prefix + {R:x} (x is the custom starting number). <strong>InstanceName</strong> requires "prefix{R:x}". For example, cmgo{R:3}. If the purchase quantity is set to 5, the instance names will be cmgo3, cmgo4, cmgo5, cmgo6, and cmgo7.</li><li>Composite pattern string: prefix1{R:x} + prefix2{R:y} + ⋯ + fixed suffix, where x and y are the starting numbers for each prefix. <strong>InstanceName</strong> requires a composite pattern string. For example, cmgo{R:10}_node{R:12}_db. If the batch purchase quantity is set to 5, the instance names will be cmgo10_node12_db, cmgo11_node13_db, cmgo12_node14_db, cmgo13_node15_db, and cmgo14_node16_db.</li></ul>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>For cloud database instances in multi-AZ deployment, specify the availability zone list.</p><ul><li>For instances in multi-AZ deployment mode, the <strong>Zone</strong> parameter specifies the primary AZ, and <strong>AvailabilityZoneList</strong> specifies all AZs, including the primary AZ. Format: [ap-guangzhou-2,ap-guangzhou-3,ap-guangzhou-4].</li><li>Use the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to access cloud databases and obtain availability zone information planned for different regions, so that you can assign valid AZs.</li><li>Nodes in multi-AZ deployment can only be deployed in 3 different availability zones. Deploying most nodes of a cluster in the same availability zone is not supported. For example, a 3-node cluster does not support deploying 2 nodes in the same zone.</li></ul>
        /// </summary>
        [JsonProperty("AvailabilityZoneList")]
        public string[] AvailabilityZoneList{ get; set; }

        /// <summary>
        /// <p>Number of Mongos node CPU cores. Valid values: 1, 2, 4, 8, and 16. This parameter is required during sharded cluster instance purchase.</p>
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// <p>Mongos node memory size.</p><ul><li>This parameter is required during sharded cluster instance purchase.</li><li>Unit: GB. Valid values: 2 (for 1 core), 4 (for 2 cores), 8 (for 4 cores), 16 (for 8 cores), and 32 (for 16 cores).</li></ul>
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// <p>Number of Mongos nodes. This parameter is required during sharded cluster instance purchase.</p><ul><li>For single-AZ deployment instances, the quantity range is [3,32].</li><li>For instances deployed across multiple availability zones, the quantity range is [6,32].</li></ul>
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }

        /// <summary>
        /// <p>Number of read-only nodes. Value ranges from 0 to 5.</p>
        /// </summary>
        [JsonProperty("ReadonlyNodeNum")]
        public ulong? ReadonlyNodeNum{ get; set; }

        /// <summary>
        /// <p>Array of AZs of read-only nodes. This parameter is required for instances in multi-AZ deployment mode when <strong>ReadonlyNodeNum</strong> is not set to <strong>0</strong>.</p>
        /// </summary>
        [JsonProperty("ReadonlyNodeAvailabilityZoneList")]
        public string[] ReadonlyNodeAvailabilityZoneList{ get; set; }

        /// <summary>
        /// <p>Availability zone of the Hidden node. To deploy instances across availability zones, you must configure this parameter.</p>
        /// </summary>
        [JsonProperty("HiddenZone")]
        public string HiddenZone{ get; set; }

        /// <summary>
        /// <p>Parameter template ID.</p><ul><li>A parameter template is a collection of preset specific parameters applicable to quick configuration of new MongoDB instances. Proper use of parameter templates can effectively improve database deployment efficiency and operating performance.</li><li>The parameter template ID can be obtained through the <a href="https://www.tencentcloud.com/document/product/240/109155?from_cn_redirect=1">DescribeDBInstanceParamTpl</a> API. Please select the parameter template ID corresponding to your instance version and architecture.</li></ul>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>Instance CPU core size. Unit: C. Call the <a href="https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1">DescribeSpecInfo</a> API to obtain specific saleable CPU specifications.<br>Note: CPU size must be set for common I Instance Type.</p>
        /// </summary>
        [JsonProperty("CpuCore")]
        public long? CpuCore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "Clone", this.Clone);
            this.SetParamSimple(map, prefix + "Father", this.Father);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "RestoreTime", this.RestoreTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "AvailabilityZoneList.", this.AvailabilityZoneList);
            this.SetParamSimple(map, prefix + "MongosCpu", this.MongosCpu);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamSimple(map, prefix + "MongosNodeNum", this.MongosNodeNum);
            this.SetParamSimple(map, prefix + "ReadonlyNodeNum", this.ReadonlyNodeNum);
            this.SetParamArraySimple(map, prefix + "ReadonlyNodeAvailabilityZoneList.", this.ReadonlyNodeAvailabilityZoneList);
            this.SetParamSimple(map, prefix + "HiddenZone", this.HiddenZone);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "CpuCore", this.CpuCore);
        }
    }
}

