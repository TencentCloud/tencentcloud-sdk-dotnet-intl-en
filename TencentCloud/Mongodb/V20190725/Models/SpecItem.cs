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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpecItem : AbstractModel
    {
        
        /// <summary>
        /// Specification information identifier
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// Specification purchasable flag. Valid values: 0 (not purchasable), 1 (purchasable)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Specification purchasable flag. Valid values: 0 (not purchasable), 1 (purchasable)
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Memory size in MB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Default disk size in MB
        /// </summary>
        [JsonProperty("DefaultStorage")]
        public ulong? DefaultStorage{ get; set; }

        /// <summary>
        /// Maximum disk size in MB
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// Minimum disk size in MB
        /// </summary>
        [JsonProperty("MinStorage")]
        public ulong? MinStorage{ get; set; }

        /// <summary>
        /// Maximum QPS
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// Maximum number of connections
        /// </summary>
        [JsonProperty("Conns")]
        public ulong? Conns{ get; set; }

        /// <summary>
        /// MongoDB version information of an instance
        /// </summary>
        [JsonProperty("MongoVersionCode")]
        public string MongoVersionCode{ get; set; }

        /// <summary>
        /// MongoDB version number of an instance
        /// </summary>
        [JsonProperty("MongoVersionValue")]
        public ulong? MongoVersionValue{ get; set; }

        /// <summary>
        /// MongoDB version number of an instance (short)
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Storage engine
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// Cluster type. Valid values: 1 (sharding cluster), 0 (replica set cluster)
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// Minimum number of slave nodes in a replica set
        /// </summary>
        [JsonProperty("MinNodeNum")]
        public ulong? MinNodeNum{ get; set; }

        /// <summary>
        /// Maximum number of slave nodes in a replica set
        /// </summary>
        [JsonProperty("MaxNodeNum")]
        public ulong? MaxNodeNum{ get; set; }

        /// <summary>
        /// Minimum number of shards
        /// </summary>
        [JsonProperty("MinReplicateSetNum")]
        public ulong? MinReplicateSetNum{ get; set; }

        /// <summary>
        /// Maximum number of shards
        /// </summary>
        [JsonProperty("MaxReplicateSetNum")]
        public ulong? MaxReplicateSetNum{ get; set; }

        /// <summary>
        /// Minimum number of slave nodes in a shard
        /// </summary>
        [JsonProperty("MinReplicateSetNodeNum")]
        public ulong? MinReplicateSetNodeNum{ get; set; }

        /// <summary>
        /// Maximum number of slave nodes in a shard
        /// </summary>
        [JsonProperty("MaxReplicateSetNodeNum")]
        public ulong? MaxReplicateSetNodeNum{ get; set; }

        /// <summary>
        /// Server type. Valid values: 0 (HIO), 4 (HIO10G)
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "DefaultStorage", this.DefaultStorage);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "MinStorage", this.MinStorage);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Conns", this.Conns);
            this.SetParamSimple(map, prefix + "MongoVersionCode", this.MongoVersionCode);
            this.SetParamSimple(map, prefix + "MongoVersionValue", this.MongoVersionValue);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "MinNodeNum", this.MinNodeNum);
            this.SetParamSimple(map, prefix + "MaxNodeNum", this.MaxNodeNum);
            this.SetParamSimple(map, prefix + "MinReplicateSetNum", this.MinReplicateSetNum);
            this.SetParamSimple(map, prefix + "MaxReplicateSetNum", this.MaxReplicateSetNum);
            this.SetParamSimple(map, prefix + "MinReplicateSetNodeNum", this.MinReplicateSetNodeNum);
            this.SetParamSimple(map, prefix + "MaxReplicateSetNodeNum", this.MaxReplicateSetNodeNum);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
        }
    }
}

