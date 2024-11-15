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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Project of the Cluster
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster description
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// Cluster specification
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// Auto-upgrades cluster specification
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public AutoUpgradeClusterLevel AutoUpgradeClusterLevel{ get; set; }

        /// <summary>
        /// Whether to enable qGPU Sharing
        /// </summary>
        [JsonProperty("QGPUShareEnable")]
        public bool? QGPUShareEnable{ get; set; }

        /// <summary>
        /// Cluster attributes
        /// </summary>
        [JsonProperty("ClusterProperty")]
        public ClusterProperty ClusterProperty{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamObj(map, prefix + "AutoUpgradeClusterLevel.", this.AutoUpgradeClusterLevel);
            this.SetParamSimple(map, prefix + "QGPUShareEnable", this.QGPUShareEnable);
            this.SetParamObj(map, prefix + "ClusterProperty.", this.ClusterProperty);
        }
    }
}

