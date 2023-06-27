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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// AZs to deploy shard nodes. You can specify up to two AZs. When the shard specification is 1-source-2-replica, two of the nodes are deployed in the first AZ.
        /// The current purchasable AZ needs be pulled through `DescribeDCDBSaleInfo` API.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Validity period in months
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Shard memory size in GB, which can be obtained 
        ///  by querying the instance specification through `DescribeShardSpec` API.
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// Shard storage size in GB, which can be obtained
        ///  by querying the instance specification through `DescribeShardSpec` API.
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }

        /// <summary>
        /// Number of nodes in a single shard, which can be obtained
        ///  by querying the instance specification through `DescribeShardSpec` API.
        /// </summary>
        [JsonProperty("ShardNodeCount")]
        public long? ShardNodeCount{ get; set; }

        /// <summary>
        /// The number of shards in the instance. Value range: 2-8. You can increase up to 64 shards by upgrading your instance.
        /// </summary>
        [JsonProperty("ShardCount")]
        public long? ShardCount{ get; set; }

        /// <summary>
        /// The number of instances to be purchased
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Project ID, which can be obtained through the `DescribeProjects` API. If this parameter is not passed in, the instance will be associated with the default project.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// VPC ID. If this parameter is left empty or not passed in, the instance will be created on the classic network.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID, which is required when `VpcId` is specified.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Database engine version. Valid values: `5.7`, `8.0`, `10.0`, `10.1`.
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// Whether to automatically use vouchers. This option is disabled by default.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// Voucher ID list. Currently, you can specify only one voucher.
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// Security group ID
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// Custom name of the instance
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Whether IPv6 is supported. Valid values: `0` (unsupported), `1` (supported).
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public long? Ipv6Flag{ get; set; }

        /// <summary>
        /// Array of tag key-value pairs
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// List of parameters. Valid values: `character_set_server` (character set; required); `lower_case_table_names` (table name case sensitivity; required; `0`: case-sensitive; `1`: case-insensitive); `innodb_page_size` (InnoDB data page size; default size: 16 KB); `sync_mode` (sync mode; `0`: async; `1`: strong sync; `2`: downgradable strong sync; default value: `2`).
        /// </summary>
        [JsonProperty("InitParams")]
        public DBParamValue[] InitParams{ get; set; }

        /// <summary>
        /// DCN source region
        /// </summary>
        [JsonProperty("DcnRegion")]
        public string DcnRegion{ get; set; }

        /// <summary>
        /// DCN source instance ID
        /// </summary>
        [JsonProperty("DcnInstanceId")]
        public string DcnInstanceId{ get; set; }

        /// <summary>
        /// Renewal mode. Valid values: `0` (manual renewal, which is the default mode), `1` (auto-renewal), `2` (manual renewal, which is specified by users).  If no renewal is required, set it to `0`.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Security group IDs in array. This parameter is compatible with the old parameter `SecurityGroupId`.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
            this.SetParamSimple(map, prefix + "ShardNodeCount", this.ShardNodeCount);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamSimple(map, prefix + "DcnRegion", this.DcnRegion);
            this.SetParamSimple(map, prefix + "DcnInstanceId", this.DcnInstanceId);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

