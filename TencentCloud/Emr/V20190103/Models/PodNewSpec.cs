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

    public class PodNewSpec : AbstractModel
    {
        
        /// <summary>
        /// Identifier of the external resource provider, for example, "cls-a1cd23fa".
        /// </summary>
        [JsonProperty("ResourceProviderIdentifier")]
        public string ResourceProviderIdentifier{ get; set; }

        /// <summary>
        /// Type of the external resource provider, for example, "tke". Currently, only "tke" is supported.
        /// </summary>
        [JsonProperty("ResourceProviderType")]
        public string ResourceProviderType{ get; set; }

        /// <summary>
        /// Purpose of the resource, that is, the node type. Currently only "TASK" is supported.
        /// </summary>
        [JsonProperty("NodeFlag")]
        public string NodeFlag{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Memory size (GB).
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// CPU type for the EKS cluster, currently supporting intel and amd.
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// Mounting information of the node data directory on Pod.
        /// </summary>
        [JsonProperty("PodVolumes")]
        public PodVolume[] PodVolumes{ get; set; }

        /// <summary>
        /// Whether it is a floating specification. Default: false. Valid values:
        /// <li>true: yes</li>
        /// <li>false: no</li>
        /// </summary>
        [JsonProperty("EnableDynamicSpecFlag")]
        public bool? EnableDynamicSpecFlag{ get; set; }

        /// <summary>
        /// Floating specification.
        /// </summary>
        [JsonProperty("DynamicPodSpec")]
        public DynamicPodSpec DynamicPodSpec{ get; set; }

        /// <summary>
        /// Unique ID of the VPC.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Unique ID of the VPC subnet.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// pod name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Other account authorization information.
        /// </summary>
        [JsonProperty("OtherAccountInfo")]
        public OtherAccountInfo OtherAccountInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceProviderIdentifier", this.ResourceProviderIdentifier);
            this.SetParamSimple(map, prefix + "ResourceProviderType", this.ResourceProviderType);
            this.SetParamSimple(map, prefix + "NodeFlag", this.NodeFlag);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamArrayObj(map, prefix + "PodVolumes.", this.PodVolumes);
            this.SetParamSimple(map, prefix + "EnableDynamicSpecFlag", this.EnableDynamicSpecFlag);
            this.SetParamObj(map, prefix + "DynamicPodSpec.", this.DynamicPodSpec);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamObj(map, prefix + "OtherAccountInfo.", this.OtherAccountInfo);
        }
    }
}

