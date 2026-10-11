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

    public class DynamicInstanceGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>Resource group type.</p>
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// <p>Resource group name.</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>Number of Pod CPU cores.</p>
        /// </summary>
        [JsonProperty("PodCpu")]
        public ulong? PodCpu{ get; set; }

        /// <summary>
        /// <p>Pod memory size (GB).</p>
        /// </summary>
        [JsonProperty("PodMem")]
        public ulong? PodMem{ get; set; }

        /// <summary>
        /// <p>Pod GPU type.</p>
        /// </summary>
        [JsonProperty("PodGpuType")]
        public string PodGpuType{ get; set; }

        /// <summary>
        /// <p>Number of Pod GPUs.</p>
        /// </summary>
        [JsonProperty("PodGpu")]
        public ulong? PodGpu{ get; set; }

        /// <summary>
        /// <p>Number of Pods.</p>
        /// </summary>
        [JsonProperty("PodNum")]
        public ulong? PodNum{ get; set; }

        /// <summary>
        /// <p>Minimum number of elastic Pods.</p>
        /// </summary>
        [JsonProperty("MinPodNum")]
        public ulong? MinPodNum{ get; set; }

        /// <summary>
        /// <p>Maximum number of elastic Pods. When MaxPodNum &gt; MinPodNum, auto scaling is enabled by default and scaling is performed within the range.</p>
        /// </summary>
        [JsonProperty("MaxPodNum")]
        public ulong? MaxPodNum{ get; set; }

        /// <summary>
        /// <p>Whether to support storage configuration.</p>
        /// </summary>
        [JsonProperty("SupportPV")]
        public bool? SupportPV{ get; set; }

        /// <summary>
        /// <p>CBS storage volume list.</p>
        /// </summary>
        [JsonProperty("CBSVolumes")]
        public CBSVolume[] CBSVolumes{ get; set; }

        /// <summary>
        /// <p>CFS storage volume list.</p>
        /// </summary>
        [JsonProperty("CFSVolumes")]
        public CFSVolume[] CFSVolumes{ get; set; }

        /// <summary>
        /// <p>COS storage volume list.</p>
        /// </summary>
        [JsonProperty("COSVolumes")]
        public COSVolume[] COSVolumes{ get; set; }

        /// <summary>
        /// <p>Mount volume list.</p>
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// <p>Pod label.</p>
        /// </summary>
        [JsonProperty("Labels")]
        public TkeLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>Tolerations definition.</p>
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// <p>Environment variable.</p>
        /// </summary>
        [JsonProperty("Envs")]
        public NameValue[] Envs{ get; set; }

        /// <summary>
        /// <p>Node scheduling policy.</p>
        /// </summary>
        [JsonProperty("SchedulingPolicy")]
        public string SchedulingPolicy{ get; set; }

        /// <summary>
        /// <p>Resource label.</p>
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public string ResourceLabel{ get; set; }

        /// <summary>
        /// <p>GPU resource vendor key.</p>
        /// </summary>
        [JsonProperty("PodGpuResourceKey")]
        public string PodGpuResourceKey{ get; set; }

        /// <summary>
        /// <p>CFS Turbo mount list.</p>
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }

        /// <summary>
        /// <p>GooseFS disk.</p>
        /// </summary>
        [JsonProperty("GooseFSVolumes")]
        public GooseFSVolume[] GooseFSVolumes{ get; set; }

        /// <summary>
        /// <p>Pre-start command.</p>
        /// </summary>
        [JsonProperty("PreStartCommand")]
        public string PreStartCommand{ get; set; }

        /// <summary>
        /// <p>Ray pre-start command.</p>
        /// </summary>
        [JsonProperty("RayStartParams")]
        public string RayStartParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "PodCpu", this.PodCpu);
            this.SetParamSimple(map, prefix + "PodMem", this.PodMem);
            this.SetParamSimple(map, prefix + "PodGpuType", this.PodGpuType);
            this.SetParamSimple(map, prefix + "PodGpu", this.PodGpu);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
            this.SetParamSimple(map, prefix + "MinPodNum", this.MinPodNum);
            this.SetParamSimple(map, prefix + "MaxPodNum", this.MaxPodNum);
            this.SetParamSimple(map, prefix + "SupportPV", this.SupportPV);
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamSimple(map, prefix + "SchedulingPolicy", this.SchedulingPolicy);
            this.SetParamSimple(map, prefix + "ResourceLabel", this.ResourceLabel);
            this.SetParamSimple(map, prefix + "PodGpuResourceKey", this.PodGpuResourceKey);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
            this.SetParamArrayObj(map, prefix + "GooseFSVolumes.", this.GooseFSVolumes);
            this.SetParamSimple(map, prefix + "PreStartCommand", this.PreStartCommand);
            this.SetParamSimple(map, prefix + "RayStartParams", this.RayStartParams);
        }
    }
}

