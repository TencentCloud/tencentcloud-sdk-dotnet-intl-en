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
        ///  - Specifies the number of primary and secondary nodes for each replica set during replica set instance creation. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain the maximum and minimum number of nodes supported for each replica set.
        ///  - Specifies the number of primary and secondary nodes for each shard during sharded cluster instance creation. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain the maximum and minimum number of nodes supported for each shard.
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// Instance memory size. Unit: GB. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain specific saleable memory specifications.
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Instance disk size. Unit: GB. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain the maximum and minimum disk sizes corresponding to each CPU specification.
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// Refers to version information. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API can be called to obtain detailed information about the supported versions.
        /// - MONGO_40_WT: version of the MongoDB 4.0 WiredTiger storage engine.
        /// - MONGO_42_WT: version of the MongoDB 4.2 WiredTiger storage engine.
        /// - MONGO_44_WT: version of the MongoDB 4.4 WiredTiger storage engine.
        /// - MONGO_50_WT: version of the MongoDB 5.0 WiredTiger storage engine.
        /// - MONGO_60_WT: version of the MongoDB 6.0 WiredTiger storage engine.
        /// - MONGO_70_WT: version of the MongoDB 7.0 WiredTiger storage engine.
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// Number of instances. The minimum value is 1, and the maximum value is 30.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// AZ information. Format: ap-guangzhou-2.
        ///  - Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain the specific information.
        ///  - This parameter indicates the primary AZ. If multi-AZ deployment is adopted, the value of Zone should be one of the values of AvailabilityZoneList.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Specifies the purchase duration during the instance purchase, in months. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, and 36.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Product specification type.
        ///  - HIO10G: general high-I/O 10GE type.
        ///  - HCD: cloud disk type.
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// Instance architecture type.
        ///  - REPLSET: replica set.
        ///  - SHARD: sharded cluster.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        ///  - Specifies the number of replica sets during replica set instance creation. This parameter can only be set to 1.
        ///  - Specifies the number of shards during sharded cluster instance creation. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to query the range of shard quantity. The parameters MinReplicateSetNum and MaxReplicateSetNum in the returned data structure SpecItems correspond to the minimum value and maximum value, respectively.
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// Project ID.  - The default project is used if this parameter is not specified.
        ///  - The project ID can be obtained on the [project management page in the TencentDB for MongoDB console](https://console.cloud.tencent.com/project).
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// VPC ID.
        /// - Only VPC configuration is supported, and a VPC in the same region as the instance should be selected. Log in to the [VPC console](https://console.cloud.tencent.com/vpc) to obtain the available VPC ID.
        /// - After successful instance creation, VPCs can be changed. For detailed operations, see [Changing the Network](https://www.tencentcloud.com/document/product/239/30910?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID of the VPC.
        /// - A subnet should be specified within the selected VPC. Log in to the [VPC console](https://console.cloud.tencent.com/vpc) to obtain the available subnet ID.
        /// - After successful instance creation, VPCs and subnets can be changed. For detailed operations, see [Changing the Network](https://www.tencentcloud.com/document/product/239/30910?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Instance password. The requirements are as follows:
        ///  - The number of characters should be in the range of [8, 32].
        ///  - Characters within the ranges [A,Z], [a,z], and [0,9] are allowed.
        ///  - Special characters that can be entered include exclamation marks (!), at signs (@), number signs (#), percent signs (%), carets (^), asterisks (\*), brackets (()), and underscores (_).
        ///  - It cannot contain only the same letters or digits.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Instance tag information.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Automatic renewal flag.
        ///  - 0: no automatic renewal.
        ///  - 1: automatic renewal.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Whether to automatically select a voucher.
        ///  - 1: yes.
        ///  - 0: no. Default value: 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// Instance type.
        /// - 1: formal instance.
        /// - 3: read-only instance.
        /// - 4: disaster recovery instance.
        /// - 5: cloned instance. Note: For a cloned instance, RestoreTime is required.
        /// </summary>
        [JsonProperty("Clone")]
        public long? Clone{ get; set; }

        /// <summary>
        /// Parent instance ID.
        /// - This parameter is required when the value of the **Clone** parameter is set to 3 or 4, indicating a read-only or disaster recovery instance.
        /// - Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the parent instance ID from the instance list.
        /// </summary>
        [JsonProperty("Father")]
        public string Father{ get; set; }

        /// <summary>
        /// Security group ID. Log in to the [security group console](https://console.cloud.tencent.com/vpc/security-group) to obtain the ID of the security group in the same region as the database instance.
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// Rollback time of the cloned instance. It is required when the Clone value is 5 or 6. - This parameter is required for cloned instances. Format: 2021-08-13 16:30:00. - Rollback time range: Only data within the last 7 days can be rolled back.
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// Instance name. Only Chinese characters, letters, digits, underscores (_), and delimiters (-) are supported, with a length of 128 characters. When database instances are purchased in batches, the automatic ascending feature is supported through the custom naming pattern string and numeric suffix to set instance names efficiently.
        /// - Basic mode: prefix + automatic ascending number (starting from 1 by default). Only a custom instance name prefix is required for **lnstanceName**. For example, it can be set to cmgo. If the purchase quantity is set to 5, after purchase, the instances will be sequentially named cmgo1, cmgo2, cmgo3, cmgo4, and cmgo5, respectively.
        /// - Custom starting number mode: prefix + {R:x} (x is the custom starting number). Prefix{R:x} is required for **InstanceName**. For example, cmgo{R:3}. If the purchase quantity is set to 5, the instance names will be sequentially named cmgo3, cmgo4, cmgo5, cmgo6, and cmgo7.
        /// - Composite pattern string: prefix 1{R:x} + prefix 2{R:y}+ ⋯ + fixed suffix, where x and y are the starting numbers of each prefix. A composite pattern string is required for **instanceName**. For example, cmgo{R:10}\_node{R:12}\_db. If the batch purchase quantity is set to 5, the instances will be sequentially named cmgo10\_node12\_db, cmgo11\_node13\_db, cmgo12\_node14\_db, cmgo13\_node15\_db, and cmgo14\_node16\_db.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Specifies the list of AZs during multi-AZ deployment of TencentDB for MongoDB instances.
        ///  - For instances in multi-AZ deployment mode, the **Zone** parameter specifies the primary AZ, and **AvailabilityZoneList** specifies all AZs, including the primary AZ. Format: [ap-guangzhou-2,ap-guangzhou-3,ap-guangzhou-4].
        ///  - The [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API can be called to obtain AZs planned for TencentDB for MongoDB instances in different regions, helping you specify valid AZs.
        ///  - Nodes in multi-AZ deployment mode can only be deployed in 3 different AZs. Deploying most nodes of a cluster in the same AZ is not supported. For example, a 3-node cluster does not support deploying 2 nodes in the same AZ.
        /// </summary>
        [JsonProperty("AvailabilityZoneList")]
        public string[] AvailabilityZoneList{ get; set; }

        /// <summary>
        /// Number of Mongos node CPU cores. Valid values: 1, 2, 4, 8, and 16. This parameter is required during sharded cluster instance purchase.
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// Mongos node memory size.
        ///  - This parameter is required during sharded cluster instance purchase.
        ///  - Unit: GB. 1-core 2GB, 2-core 4GB, 4-core 8GB, 8-core 16GB, and 16-core 32GB are supported.
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// Number of Mongos nodes. This parameter is required during sharded cluster instance purchase.
        ///  - For instances in single-AZ deployment mode, the value range is [3,32].
        ///  - For instances in multi-AZ deployment mode, the value range is [6,32].
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }

        /// <summary>
        /// Number of read-only nodes. Value ranges: [0,5].
        /// </summary>
        [JsonProperty("ReadonlyNodeNum")]
        public ulong? ReadonlyNodeNum{ get; set; }

        /// <summary>
        /// Array of AZs of read-only nodes. This parameter is required for instances in multi-AZ deployment mode when **ReadonlyNodeNum** is not set to **0**.
        /// </summary>
        [JsonProperty("ReadonlyNodeAvailabilityZoneList")]
        public string[] ReadonlyNodeAvailabilityZoneList{ get; set; }

        /// <summary>
        /// AZ of the hidden node. This parameter is required for instances in multi-AZ deployment mode.
        /// </summary>
        [JsonProperty("HiddenZone")]
        public string HiddenZone{ get; set; }

        /// <summary>
        /// Parameter template ID.
        /// - A parameter template is a collection of predefined parameter values that can be used to quickly configure new MongoDB instances. Proper use of parameter templates can significantly enhance the deployment efficiency and operational performance of the database.
        /// - The [DescribeDBInstanceParamTpl](https://www.tencentcloud.com/document/product/240/109155?from_cn_redirect=1) API can be called to obtain the parameter template ID. Select the parameter template ID corresponding to the instance version and architecture.
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }


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
        }
    }
}

