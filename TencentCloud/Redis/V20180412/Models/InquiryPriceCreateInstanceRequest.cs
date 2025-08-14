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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceCreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance type.
        /// 
        /// - 2: Redis 2.8 memory edition (standard architecture).
        /// - 6: Redis 4.0 memory edition (standard architecture).
        /// - 7: Redis 4.0 memory edition (cluster architecture).
        /// - 8: Redis 5.0 memory edition (standard architecture).
        /// - 9: Redis 5.0 memory edition (cluster architecture).
        /// - 15: Redis 6.2 memory edition (standard architecture).
        /// - 16: Redis 6.2 memory edition (cluster architecture).
        /// - 17: Redis 7.0 memory edition (standard architecture).
        /// - 18: Redis 7.0 memory edition (cluster architecture).
        /// - 200: Memcached 1.6 memory edition (cluster architecture).
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// Memory capacity in MB, which must be a multiple of 1,024. It is subject to the purchasable specifications returned by the [DescribeProductInfo API](https://intl.cloud.tencent.com/document/api/239/30600?from_cn_redirect=1).
        /// If `TypeId` indicates the standard architecture, `MemSize` indicates the total memory capacity of an instance; if `TypeId` indicates the cluster architecture, `MemSize` indicates the memory capacity per shard.
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// Number of instances. The actual quantity purchasable at a time is subject to the specifications returned by the [DescribeProductInfo API](https://intl.cloud.tencent.com/document/api/239/30600?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// Length of purchase in months, which is required when creating a monthly-subscribed instance. Value range: [1,2,3,4,5,6,7,8,9,10,11,12,24,36]. For pay-as-you-go instances, set the parameter to `1`.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Billing mode.
        /// - 0: pay-as-you-go.
        /// - 1: monthly subscription.
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// ID of the AZ where the instance resides. For more information, see [Regions and AZs](https://intl.cloud.tencent.com/document/product/239/4106?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Number of instance shards. For the standard architecture of 2.8, the number of shards does not need to be configured. For the standard architecture of other versions, the number of shards should be set to 1. For the cluster architecture, the number of shards to be purchased needs to be specified.
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// Number of instance replicas. For the standard architecture of 2.8, the number of replicas does not need to be configured.
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// Whether replica read-only is supported. For the standard architecture of Redis 2.8 and CKV, this parameter does not need to be configured.
        /// - true: Replica read-only is not required.
        /// - false: Replica read-only is required.
        /// </summary>
        [JsonProperty("ReplicasReadonly")]
        public bool? ReplicasReadonly{ get; set; }

        /// <summary>
        /// Name of the AZ where the instance resides. For more information, see [Regions and AZs](https://intl.cloud.tencent.com/document/product/239/4106?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Deployment mode.
        /// - local: local disk. This is the default value.
        /// - cloud: cloud disk.
        /// - cdc: CDC.
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }


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
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "ReplicasReadonly", this.ReplicasReadonly);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
        }
    }
}

