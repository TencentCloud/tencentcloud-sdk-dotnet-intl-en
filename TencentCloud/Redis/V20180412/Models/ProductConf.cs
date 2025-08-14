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

    public class ProductConf : AbstractModel
    {
        
        /// <summary>
        /// Product type
        /// - `2`: Redis 2.8 Memory Edition (Standard Architecture).
        /// - `3`: CKV 3.2 Memory Edition (Standard Architecture).
        /// - `4`: CKV 3.2 Memory Edition (Cluster Architecture).
        /// - `5`: Redis 2.8 Memory Edition (Standalone).
        /// - `6`: Redis 4.0 Memory Edition (Standard Architecture).
        /// - `7`: Redis 4.0 Memory Edition (Cluster Architecture).
        /// - `8`: Redis 5.0 Memory Edition (Standard Architecture).
        /// - `9`: Redis 5.0 Memory Edition (Cluster Architecture).
        /// - `15`: Redis 6.2 Memory Edition (Standard Architecture).
        /// - `16`: Redis 6.2 Memory Edition (Cluster Architecture).
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Product names, including Redis Master-Replica Edition, Redis Standalone Edition, Redis 4.0 Cluster Edition, CKV Master-Replica Edition, and CKV Standalone Edition.
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
        /// - `true`: Sold out.
        /// - `false`: Not sold out.
        /// </summary>
        [JsonProperty("Saleout")]
        public bool? Saleout{ get; set; }

        /// <summary>
        /// Product engine. Valid values: Redis and CKV.
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// Compatible versions, including Redis 2.8, 3.2, 4.0, 5.0, and 6.2.
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
        /// Quantity of replicas
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public string[] ReplicaNum{ get; set; }

        /// <summary>
        /// Quantity of shards
        /// </summary>
        [JsonProperty("ShardNum")]
        public string[] ShardNum{ get; set; }

        /// <summary>
        /// Supported billing modes
        /// - `1`: Monthly subscription.
        /// - `0`: Pay-as-you-go.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Due to spelling inconsistency in this parameter name, it is recommended to use the **EnableReplicaReadOnly** parameter instead. Its meaning refers to whether the Read-Only Replica is supported.
        /// - true: Supported.
        /// - false: Not supported.
        /// </summary>
        [JsonProperty("EnableRepicaReadOnly")]
        [System.Obsolete]
        public bool? EnableRepicaReadOnly{ get; set; }

        /// <summary>
        /// Whether read-only replica is supported.
        ///  - true: read-only replica supported.
        ///  - false: not supported.
        /// </summary>
        [JsonProperty("EnableReplicaReadOnly")]
        public bool? EnableReplicaReadOnly{ get; set; }


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
            this.SetParamSimple(map, prefix + "EnableReplicaReadOnly", this.EnableReplicaReadOnly);
        }
    }
}

