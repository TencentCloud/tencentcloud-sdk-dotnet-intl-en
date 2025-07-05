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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterLevelAttribute : AbstractModel
    {
        
        /// <summary>
        /// Cluster model
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// Number of Pods
        /// </summary>
        [JsonProperty("PodCount")]
        public ulong? PodCount{ get; set; }

        /// <summary>
        /// Number of ConfigMap
        /// </summary>
        [JsonProperty("ConfigMapCount")]
        public ulong? ConfigMapCount{ get; set; }

        /// <summary>
        /// Number of ReplicaSets
        /// </summary>
        [JsonProperty("RSCount")]
        public ulong? RSCount{ get; set; }

        /// <summary>
        /// Number of CRDs
        /// </summary>
        [JsonProperty("CRDCount")]
        public ulong? CRDCount{ get; set; }

        /// <summary>
        /// Whether it is enabled
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// Number of other resources
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OtherCount")]
        public ulong? OtherCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "ConfigMapCount", this.ConfigMapCount);
            this.SetParamSimple(map, prefix + "RSCount", this.RSCount);
            this.SetParamSimple(map, prefix + "CRDCount", this.CRDCount);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "OtherCount", this.OtherCount);
        }
    }
}

