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

    public class SpecItem : AbstractModel
    {
        
        /// <summary>
        /// Specification information identifier. Format: mongo.HIO10G.128G. It consists of three parts: node type, specification type, and memory specification.
        ///  - Node types are as follows:
        ///  - mongo: Mongod node.
        ///  - mongos: Mongos node.
        ///  - cfgstr: ConfigServer node.
        ///  - Specification types are as follows:
        ///  - HIO10G: general high-I/O 10GE type.
        ///  - HCD: cloud disk type.
        ///  - Memory specifications are as follows:
        ///  - Valid values: 4, 8, 16, 32, 64, 128, 240, and 512.
        ///  - Unit: g, indicating GB. 128g means 128 GB.
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// Saleable specification status flag. Valid values are as follows:
        ///  - 0: selling stopped.
        ///  - 1: available for sale.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Computing resource specification, indicating the number of CPU cores.
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Memory specification. Unit: MB.
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Default disk specification. Unit: MB.
        /// </summary>
        [JsonProperty("DefaultStorage")]
        public ulong? DefaultStorage{ get; set; }

        /// <summary>
        /// Maximum disk specification. Unit: MB.
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// Minimum disk specification. Unit: MB.
        /// </summary>
        [JsonProperty("MinStorage")]
        public ulong? MinStorage{ get; set; }

        /// <summary>
        /// Maximum number of requests per second. Unit: requests/second.
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// Maximum number of connections supported for the specification.
        /// </summary>
        [JsonProperty("Conns")]
        public ulong? Conns{ get; set; }

        /// <summary>
        /// Storage engine version information on instances.
        ///  - MONGO_36_WT: version of the MongoDB 3.6 WiredTiger storage engine.
        ///  - MONGO_40_WT: version of the MongoDB 4.0 WiredTiger storage engine.
        ///  - MONGO_42_WT: version of the MongoDB 4.2 WiredTiger storage engine.
        ///  - MONGO_44_WT: version of the MongoDB 4.4 WiredTiger storage engine.
        ///  - MONGO_50_WT: version of the MongoDB 5.0 WiredTiger storage engine.
        ///  - MONGO_60_WT: version of the MongoDB 6.0 WiredTiger storage engine.
        /// </summary>
        [JsonProperty("MongoVersionCode")]
        public string MongoVersionCode{ get; set; }

        /// <summary>
        /// Digital version corresponding to the instance version.
        /// </summary>
        [JsonProperty("MongoVersionValue")]
        public ulong? MongoVersionValue{ get; set; }

        /// <summary>
        /// Instance version information. Valid values: 3.6, 4.2, 4.4, 5.0, and 6.0.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Storage engine.
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// Cluster type. Valid values are as follows:
        ///  - 1: sharded cluster.
        ///  - 0: replica set cluster.
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// Minimum number of nodes for each replica set.
        /// </summary>
        [JsonProperty("MinNodeNum")]
        public ulong? MinNodeNum{ get; set; }

        /// <summary>
        /// Maximum number of nodes for each replica set.
        /// </summary>
        [JsonProperty("MaxNodeNum")]
        public ulong? MaxNodeNum{ get; set; }

        /// <summary>
        /// Minimum number of shards.
        /// </summary>
        [JsonProperty("MinReplicateSetNum")]
        public ulong? MinReplicateSetNum{ get; set; }

        /// <summary>
        /// Maximum number of shards.
        /// </summary>
        [JsonProperty("MaxReplicateSetNum")]
        public ulong? MaxReplicateSetNum{ get; set; }

        /// <summary>
        /// Minimum number of nodes for each shard.
        /// </summary>
        [JsonProperty("MinReplicateSetNodeNum")]
        public ulong? MinReplicateSetNodeNum{ get; set; }

        /// <summary>
        /// Maximum number of nodes for each shard.
        /// </summary>
        [JsonProperty("MaxReplicateSetNodeNum")]
        public ulong? MaxReplicateSetNodeNum{ get; set; }

        /// <summary>
        /// Cluster specification type. Valid values are as follows:
        ///  - HIO10G: general high-I/O 10GE type.
        ///  - HCD: cloud disk type.
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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

