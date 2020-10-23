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

    public class ProductConf : AbstractModel
    {
        
        /// <summary>
        /// Product type. 2: Redis primary-secondary edition; 3: CKV primary-secondary edition; 4: CKV cluster edition; 5: Redis standalone edition; 7: Redis cluster edition
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Product name: Redis primary-secondary edition, CKV primary-secondary edition, CKV cluster edition, Redis standalone edition, or Redis cluster edition
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// Minimum purchasable quantity
        /// </summary>
        [JsonProperty("MinBuyNum")]
        public long? MinBuyNum{ get; set; }

        /// <summary>
        /// Maximum purchasable quantity
        /// </summary>
        [JsonProperty("MaxBuyNum")]
        public long? MaxBuyNum{ get; set; }

        /// <summary>
        /// Whether a product is sold out
        /// </summary>
        [JsonProperty("Saleout")]
        public bool? Saleout{ get; set; }

        /// <summary>
        /// Product engine: Tencent Cloud CKV or Redis community edition
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// Compatible version: Redis 2.8, Redis 3.2, or Redis 4.0
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Total capacity in GB
        /// </summary>
        [JsonProperty("TotalSize")]
        public string[] TotalSize{ get; set; }

        /// <summary>
        /// Shard size in GB
        /// </summary>
        [JsonProperty("ShardSize")]
        public string[] ShardSize{ get; set; }

        /// <summary>
        /// Number of replicas
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public string[] ReplicaNum{ get; set; }

        /// <summary>
        /// Number of shards
        /// </summary>
        [JsonProperty("ShardNum")]
        public string[] ShardNum{ get; set; }

        /// <summary>
        /// Supported billing method. 1: monthly subscription; 0: pay-as-you-go
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Whether to support read-only replicas
        /// </summary>
        [JsonProperty("EnableRepicaReadOnly")]
        public bool? EnableRepicaReadOnly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "MinBuyNum", this.MinBuyNum);
            this.SetParamSimple(map, prefix + "MaxBuyNum", this.MaxBuyNum);
            this.SetParamSimple(map, prefix + "Saleout", this.Saleout);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArraySimple(map, prefix + "TotalSize.", this.TotalSize);
            this.SetParamArraySimple(map, prefix + "ShardSize.", this.ShardSize);
            this.SetParamArraySimple(map, prefix + "ReplicaNum.", this.ReplicaNum);
            this.SetParamArraySimple(map, prefix + "ShardNum.", this.ShardNum);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "EnableRepicaReadOnly", this.EnableRepicaReadOnly);
        }
    }
}

