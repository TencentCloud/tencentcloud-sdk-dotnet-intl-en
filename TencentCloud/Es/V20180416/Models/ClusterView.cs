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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterView : AbstractModel
    {
        
        /// <summary>
        /// Cluster health status
        /// </summary>
        [JsonProperty("Health")]
        public float? Health{ get; set; }

        /// <summary>
        /// Whether the cluster is visible
        /// </summary>
        [JsonProperty("Visible")]
        public float? Visible{ get; set; }

        /// <summary>
        /// Whether the cluster encounters circuit breaking
        /// </summary>
        [JsonProperty("Break")]
        public float? Break{ get; set; }

        /// <summary>
        /// Average disk usage
        /// </summary>
        [JsonProperty("AvgDiskUsage")]
        public float? AvgDiskUsage{ get; set; }

        /// <summary>
        /// Average memory usage
        /// </summary>
        [JsonProperty("AvgMemUsage")]
        public float? AvgMemUsage{ get; set; }

        /// <summary>
        /// Average CPU usage
        /// </summary>
        [JsonProperty("AvgCpuUsage")]
        public float? AvgCpuUsage{ get; set; }

        /// <summary>
        /// Total disk size of the cluster
        /// </summary>
        [JsonProperty("TotalDiskSize")]
        public ulong? TotalDiskSize{ get; set; }

        /// <summary>
        /// Types of nodes to receive client requests
        /// </summary>
        [JsonProperty("TargetNodeTypes")]
        public string[] TargetNodeTypes{ get; set; }

        /// <summary>
        /// Number of online nodes
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// Total number of nodes
        /// </summary>
        [JsonProperty("TotalNodeNum")]
        public long? TotalNodeNum{ get; set; }

        /// <summary>
        /// Number of data nodes
        /// </summary>
        [JsonProperty("DataNodeNum")]
        public long? DataNodeNum{ get; set; }

        /// <summary>
        /// Number of indices
        /// </summary>
        [JsonProperty("IndexNum")]
        public long? IndexNum{ get; set; }

        /// <summary>
        /// Number of documents
        /// </summary>
        [JsonProperty("DocNum")]
        public long? DocNum{ get; set; }

        /// <summary>
        /// Used disk size (in bytes)
        /// </summary>
        [JsonProperty("DiskUsedInBytes")]
        public long? DiskUsedInBytes{ get; set; }

        /// <summary>
        /// Number of shards
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// Number of primary shards
        /// </summary>
        [JsonProperty("PrimaryShardNum")]
        public long? PrimaryShardNum{ get; set; }

        /// <summary>
        /// Number of relocating shards
        /// </summary>
        [JsonProperty("RelocatingShardNum")]
        public long? RelocatingShardNum{ get; set; }

        /// <summary>
        /// Number of initializing shards
        /// </summary>
        [JsonProperty("InitializingShardNum")]
        public long? InitializingShardNum{ get; set; }

        /// <summary>
        /// Number of unassigned shards
        /// </summary>
        [JsonProperty("UnassignedShardNum")]
        public long? UnassignedShardNum{ get; set; }

        /// <summary>
        /// Total COS storage of an enterprise cluster, in GB
        /// </summary>
        [JsonProperty("TotalCosStorage")]
        public long? TotalCosStorage{ get; set; }

        /// <summary>
        /// Name of the COS bucket that stores searchable snapshots of an enterprise cluster
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SearchableSnapshotCosBucket")]
        public string SearchableSnapshotCosBucket{ get; set; }

        /// <summary>
        /// COS app ID of the searchable snapshots of an enterprise cluster
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SearchableSnapshotCosAppId")]
        public string SearchableSnapshotCosAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Health", this.Health);
            this.SetParamSimple(map, prefix + "Visible", this.Visible);
            this.SetParamSimple(map, prefix + "Break", this.Break);
            this.SetParamSimple(map, prefix + "AvgDiskUsage", this.AvgDiskUsage);
            this.SetParamSimple(map, prefix + "AvgMemUsage", this.AvgMemUsage);
            this.SetParamSimple(map, prefix + "AvgCpuUsage", this.AvgCpuUsage);
            this.SetParamSimple(map, prefix + "TotalDiskSize", this.TotalDiskSize);
            this.SetParamArraySimple(map, prefix + "TargetNodeTypes.", this.TargetNodeTypes);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "TotalNodeNum", this.TotalNodeNum);
            this.SetParamSimple(map, prefix + "DataNodeNum", this.DataNodeNum);
            this.SetParamSimple(map, prefix + "IndexNum", this.IndexNum);
            this.SetParamSimple(map, prefix + "DocNum", this.DocNum);
            this.SetParamSimple(map, prefix + "DiskUsedInBytes", this.DiskUsedInBytes);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "PrimaryShardNum", this.PrimaryShardNum);
            this.SetParamSimple(map, prefix + "RelocatingShardNum", this.RelocatingShardNum);
            this.SetParamSimple(map, prefix + "InitializingShardNum", this.InitializingShardNum);
            this.SetParamSimple(map, prefix + "UnassignedShardNum", this.UnassignedShardNum);
            this.SetParamSimple(map, prefix + "TotalCosStorage", this.TotalCosStorage);
            this.SetParamSimple(map, prefix + "SearchableSnapshotCosBucket", this.SearchableSnapshotCosBucket);
            this.SetParamSimple(map, prefix + "SearchableSnapshotCosAppId", this.SearchableSnapshotCosAppId);
        }
    }
}

