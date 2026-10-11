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

    public class CloudResource : AbstractModel
    {
        
        /// <summary>
        /// <p>Component role name.</p>
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// <p>Number of Pod requests.</p>
        /// </summary>
        [JsonProperty("PodNumber")]
        public long? PodNumber{ get; set; }

        /// <summary>
        /// <p>Maximum number of CPU requests.</p>
        /// </summary>
        [JsonProperty("LimitCpu")]
        public long? LimitCpu{ get; set; }

        /// <summary>
        /// <p>Maximum number of memory requests.</p>
        /// </summary>
        [JsonProperty("LimitMemory")]
        public long? LimitMemory{ get; set; }

        /// <summary>
        /// <p>Service name, for example, HIVE.</p>
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// <p>Data volume directory settings.</p>
        /// </summary>
        [JsonProperty("VolumeDir")]
        public VolumeSetting VolumeDir{ get; set; }

        /// <summary>
        /// <p>External access settings for the component.</p>
        /// </summary>
        [JsonProperty("ExternalAccess")]
        public ExternalAccess ExternalAccess{ get; set; }

        /// <summary>
        /// <p>Node affinity settings.</p>
        /// </summary>
        [JsonProperty("Affinity")]
        public NodeAffinity Affinity{ get; set; }

        /// <summary>
        /// <p>Selected data disk information.</p>
        /// </summary>
        [JsonProperty("Disks")]
        public Disk[] Disks{ get; set; }

        /// <summary>
        /// <p>Toleration.</p>
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// <p>Pod affinity.</p>
        /// </summary>
        [JsonProperty("PodAffinity")]
        public PodAffinitySpec PodAffinity{ get; set; }

        /// <summary>
        /// <p>Pod anti-affinity.</p>
        /// </summary>
        [JsonProperty("PodAntiAffinity")]
        public PodAffinitySpec PodAntiAffinity{ get; set; }

        /// <summary>
        /// <p>Topology distribution constraint.</p>
        /// </summary>
        [JsonProperty("TopologySpreadConstraints")]
        public TopologySpreadConstraint[] TopologySpreadConstraints{ get; set; }

        /// <summary>
        /// <p>Pod tag.</p>
        /// </summary>
        [JsonProperty("PodLabels")]
        public StringMap[] PodLabels{ get; set; }

        /// <summary>
        /// <p>Whether the default Ray cluster is created.</p>
        /// </summary>
        [JsonProperty("EnableDefaultRayCluster")]
        public bool? EnableDefaultRayCluster{ get; set; }

        /// <summary>
        /// <p>Custom image.</p>
        /// </summary>
        [JsonProperty("ImageInfoV2")]
        public ImageInfoV2 ImageInfoV2{ get; set; }

        /// <summary>
        /// <p>Specifies the dynamic instance parameter to be created.</p>
        /// </summary>
        [JsonProperty("DynamicInstanceForm")]
        public DynamicInstanceForm DynamicInstanceForm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "PodNumber", this.PodNumber);
            this.SetParamSimple(map, prefix + "LimitCpu", this.LimitCpu);
            this.SetParamSimple(map, prefix + "LimitMemory", this.LimitMemory);
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamObj(map, prefix + "VolumeDir.", this.VolumeDir);
            this.SetParamObj(map, prefix + "ExternalAccess.", this.ExternalAccess);
            this.SetParamObj(map, prefix + "Affinity.", this.Affinity);
            this.SetParamArrayObj(map, prefix + "Disks.", this.Disks);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamObj(map, prefix + "PodAffinity.", this.PodAffinity);
            this.SetParamObj(map, prefix + "PodAntiAffinity.", this.PodAntiAffinity);
            this.SetParamArrayObj(map, prefix + "TopologySpreadConstraints.", this.TopologySpreadConstraints);
            this.SetParamArrayObj(map, prefix + "PodLabels.", this.PodLabels);
            this.SetParamSimple(map, prefix + "EnableDefaultRayCluster", this.EnableDefaultRayCluster);
            this.SetParamObj(map, prefix + "ImageInfoV2.", this.ImageInfoV2);
            this.SetParamObj(map, prefix + "DynamicInstanceForm.", this.DynamicInstanceForm);
        }
    }
}

