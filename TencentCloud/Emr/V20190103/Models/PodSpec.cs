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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodSpec : AbstractModel
    {
        
        /// <summary>
        /// Identifier of external resource provider, such as "cls-a1cd23fa".
        /// </summary>
        [JsonProperty("ResourceProviderIdentifier")]
        public string ResourceProviderIdentifier{ get; set; }

        /// <summary>
        /// Type of external resource provider, such as "tke". Currently, only "tke" is supported.
        /// </summary>
        [JsonProperty("ResourceProviderType")]
        public string ResourceProviderType{ get; set; }

        /// <summary>
        /// Purpose of the resource, which means the node type and can only be "TASK".
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Number of CPUs
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Memory size in GB.
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Mount point of resources for the host. A specified mount point corresponds to the host path and is used as the data storage directory in the pod. (This parameter has been disused)
        /// </summary>
        [JsonProperty("DataVolumes")]
        public string[] DataVolumes{ get; set; }

        /// <summary>
        /// EKS cluster - CPU type. Valid values: `intel` and `amd`.
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// Data directory mounting information of the pod node.
        /// </summary>
        [JsonProperty("PodVolumes")]
        public PodVolume[] PodVolumes{ get; set; }

        /// <summary>
        /// Whether floating specification is used. `1`: Yes; `0`: No.
        /// </summary>
        [JsonProperty("IsDynamicSpec")]
        public ulong? IsDynamicSpec{ get; set; }

        /// <summary>
        /// Floating specification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DynamicPodSpec")]
        public DynamicPodSpec DynamicPodSpec{ get; set; }

        /// <summary>
        /// Unique VPC ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Unique VPC subnet ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// pod name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceProviderIdentifier", this.ResourceProviderIdentifier);
            this.SetParamSimple(map, prefix + "ResourceProviderType", this.ResourceProviderType);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamArraySimple(map, prefix + "DataVolumes.", this.DataVolumes);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamArrayObj(map, prefix + "PodVolumes.", this.PodVolumes);
            this.SetParamSimple(map, prefix + "IsDynamicSpec", this.IsDynamicSpec);
            this.SetParamObj(map, prefix + "DynamicPodSpec.", this.DynamicPodSpec);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
        }
    }
}

