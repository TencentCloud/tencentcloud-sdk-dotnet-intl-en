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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance type. Valid values: `2` (Redis 2.8 Memory Edition in standard architecture), `3` (CKV 3.2 Memory Edition in standard architecture), `4` (CKV 3.2 Memory Edition in cluster architecture), `6` (Redis 4.0 Memory Edition in standard architecture), `7` (Redis 4.0 Memory Edition in cluster architecture), `8` (Redis 5.0 Memory Edition in standard architecture), `9` (Redis 5.0 Memory Edition in cluster architecture), `15` (Redis 6.0 Memory Edition in standard architecture), `16` (Redis 6.0 Memory Edition in cluster architecture)
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// Memory capacity in MB, which must be a multiple of 1,024. It is subject to the purchasable specifications returned by the [DescribeProductInfo API](https://intl.cloud.tencent.com/document/api/239/30600?from_cn_redirect=1).
        /// If `TypeId` is the standard architecture, `MemSize` indicates the total memory capacity of the instance; if `TypeId` is the cluster architecture, `MemSize` indicates the memory capacity per shard.
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// Number of instances. The actual quantity purchasable at a time is subject to the specifications returned by the [DescribeProductInfo API](https://intl.cloud.tencent.com/document/api/239/30600?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// Length of purchase in months, which is required when creating a monthly subscribed instance. Valid values: [1,2,3,4,5,6,7,8,9,10,11,12,24,36]. For pay-as-you-go instances, set the parameter to `1`.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Billing mode. 0: pay-as-you-go
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// ID of the AZ where the instance resides. For more information, see [Regions and AZs](https://intl.cloud.tencent.com/document/product/239/4106?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Instance password. If the input parameter `NoAuth` is `true` and a VPC is used, the `Password` is optional; otherwise, it is required.
        /// If the instance `TypeId` is Redis 2.8, 4.0, or 5.0, the password cannot start with "/" and must contain 8–30 characters in at least two of the following character types: lowercase letters, uppercase letters, digits, and special symbols (()`~!@#$%^&*-+=_|{}[]:;<>,.?/).
        /// If the instance `TypeId` is CKV 3.2, the password can contain 8–30 letters and digits.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// VPC ID such as vpc-sad23jfdfk. If this parameter is not passed in, the classic network will be selected by default. Use the VPC list querying API to query.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// In the classic network, `subnetId` is invalid. In a VPC subnet, the value is the subnet ID, such as subnet-fdj24n34j2.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Project ID. The value is subject to the `projectId` returned by user account > user account querying APIs > project list.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Auto-renewal flag. 0: default status (manual renewal); 1: auto-renewal enabled; 2: auto-renewal disabled
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// Array of security group IDs.
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// User-defined port. If this parameter is left empty, 6379 will be used by default. Value range: [1024,65535].
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// Number of shards in an instance. This parameter is required for Cluster Edition instances. Valid values: [3,5,8,12,16,24,32,64,96,128].
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// Number of replicas in the instance. Redis 2.8 Standard Edition and CKV Standard Edition support 1 replica. Standard/Cluster Edition 4.0 and 5.0 support 1–5 replicas.
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// Whether to support read-only replicas. Neither Redis 2.8 Standard Edition nor CKV Standard Edition supports read-only replicas. Read/write separation will be automatically enabled for an instance after it enables read-only replicas. Write requests will be directed to the master node and read requests will be distributed to replica nodes. To enable read-only replicas, we recommend you create two or more replicas.
        /// </summary>
        [JsonProperty("ReplicasReadonly")]
        public bool? ReplicasReadonly{ get; set; }

        /// <summary>
        /// Instance name, which can contain up to 60 letters, digits, underscores, or hyphens.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Whether to support the password-free feature. Valid values: true (password-free instance), false (password-enabled instance). Default value: false. Only instances in a VPC support the password-free access.
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// Node information of the instance. Currently, information about the node type (master or replica) and node AZ can be passed in. This parameter is not required for single-AZ deployed instances.
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// Tag bound to the instance to be purchased
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// Name of the AZ where the instance resides. For more information, see [Regions and AZs](https://intl.cloud.tencent.com/document/product/239/4106?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// ID of the parameter template applied to the created instance. If this parameter is left blank, the default parameter template will be applied.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// false: send a normal request and create an instance directly after the check is passed (default value); true: send a check request without creating an instance.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Valid values: `local` (local disk edition), `cloud` (cloud disk edition), `cdc` (dedicated cluster edition). Default value: `local` (local disk edition)
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// Dedicated cluster ID, which is required when `ProductVersion` is "cdc".
        /// </summary>
        [JsonProperty("RedisClusterId")]
        public string RedisClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdList.", this.SecurityGroupIdList);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "ReplicasReadonly", this.ReplicasReadonly);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "RedisClusterId", this.RedisClusterId);
        }
    }
}

