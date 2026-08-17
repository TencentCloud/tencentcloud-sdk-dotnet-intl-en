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
        /// <p>Instance type. - 2: Redis 2.8 memory edition (standard architecture). - 6: Redis 4.0 memory edition (standard architecture). - 7: Redis 4.0 memory edition (cluster architecture). - 8: Redis 5.0 memory edition (standard architecture). - 9: Redis 5.0 memory edition (cluster architecture). - 15: Redis 6.2 memory edition (standard architecture). - 16: Redis 6.2 memory edition (cluster architecture). - 17: Redis 7.0 memory edition (standard architecture). - 18: Redis 7.0 memory edition (cluster architecture). - 200: Memcached 1.6 memory edition (cluster architecture).</p>
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// <p>Memory capacity, measured in MB, must be a multiple of 1024. For specific specifications, refer to the specifications returned by <a href="https://www.tencentcloud.com/document/api/239/30600?from_cn_redirect=1">query product sales specifications</a>. When TypeId is standard architecture, MemSize is the total memory capacity of the instance. When TypeId is cluster architecture, MemSize is the sharded memory capacity.</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// <p>Instance count. The number of instances to purchase at a time is subject to the specifications returned by <a href="https://www.tencentcloud.com/document/api/239/30600?from_cn_redirect=1">query product sales specifications</a>.</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>Purchase period needs to be filled in when creating an annual and monthly subscription instance. For pay-as-you-go instances, just fill in 1. Unit: month. Value ranges from 1 to 36 [1,2,3,4,5,6,7,8,9,10,11,12,24,36].</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>Payment method. - 0: Pay-As-You-Go. - 1: Monthly Subscription.</p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// <p>ID of the AZ to which the instance belongs. See <a href="https://www.tencentcloud.com/document/product/239/4106?from_cn_redirect=1">Regions and AZs</a>.<strong>Note</strong>: Please specify at least one parameter in <strong>ZoneId</strong> and <strong>ZoneName</strong>.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>Number of instance shards. - The shard number should be set to 1 for the standard architecture. - The number of shards can be set to 1, 3, 5, 8, 12, 16, 24, 32, 40, 48, 64, 80, 96, or 128 for the cluster architecture.</p>
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// <p>Number of instance replicas. Valid values: 1, 2, 3, 4, and 5.</p>
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// <p>Whether replica read-only is supported. For Redis 2.8 standard architecture and CKV standard architecture, this parameter is not required. - true: replica read-only not required. - false: read-only replica supported.</p>
        /// </summary>
        [JsonProperty("ReplicasReadonly")]
        public bool? ReplicasReadonly{ get; set; }

        /// <summary>
        /// <p>Name of the availability zone to which the instance belongs. See <a href="https://www.tencentcloud.com/document/product/239/4106?from_cn_redirect=1">Regions and Availability Zones</a>. <strong>Description</strong>: Please specify at least one parameter in <strong>ZoneId</strong> and <strong>ZoneName</strong>.</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>Deployment method. - local: local disk, defaults to local. - cloud: cloud disk. - cdc: dedicated cluster edition.</p>
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

