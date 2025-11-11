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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Maximum disk of the cluster (unit: GB).
        /// </summary>
        [JsonProperty("MaxDiskSize")]
        public long? MaxDiskSize{ get; set; }

        /// <summary>
        /// Maximum bandwidth of the cluster. unit: MB/s.
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public long? MaxBandWidth{ get; set; }

        /// <summary>
        /// Current availability of cluster disk (unit: GB).
        /// </summary>
        [JsonProperty("AvailableDiskSize")]
        public long? AvailableDiskSize{ get; set; }

        /// <summary>
        /// Available bandwidth of the cluster. unit: MB/s.
        /// </summary>
        [JsonProperty("AvailableBandWidth")]
        public long? AvailableBandWidth{ get; set; }

        /// <summary>
        /// Indicates the AZ to which the cluster belongs.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// The AZ where the cluster nodes are located. If the cluster is a cross-AZ cluster, it includes multiple AZs where the cluster nodes are located.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "MaxDiskSize", this.MaxDiskSize);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "AvailableDiskSize", this.AvailableDiskSize);
            this.SetParamSimple(map, prefix + "AvailableBandWidth", this.AvailableBandWidth);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
        }
    }
}

