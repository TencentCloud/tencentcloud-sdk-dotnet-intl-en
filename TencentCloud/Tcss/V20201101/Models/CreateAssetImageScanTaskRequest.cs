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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAssetImageScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to scan all images; select one from all images, image list, and filter by condition.</p>
        /// </summary>
        [JsonProperty("All")]
        [System.Obsolete]
        public bool? All{ get; set; }

        /// <summary>
        /// <p>List of images to scan; choose one from all images, image list, and filter by condition.</p>
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// <p>Scan vulnerabilities; select one from vulnerability, Trojan, and risk.</p>
        /// </summary>
        [JsonProperty("ScanVul")]
        public bool? ScanVul{ get; set; }

        /// <summary>
        /// <p>Scan for trojans; select either vulnerability, Trojan or risk.</p>
        /// </summary>
        [JsonProperty("ScanVirus")]
        public bool? ScanVirus{ get; set; }

        /// <summary>
        /// <p>Scan risk; select one from vulnerability, Trojan, and risk.</p>
        /// </summary>
        [JsonProperty("ScanRisk")]
        public bool? ScanRisk{ get; set; }

        /// <summary>
        /// <p>Filter images by conditions; select one from all images, image list, and filter by condition.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// <p>Filter images by conditions and exclude individual images</p>
        /// </summary>
        [JsonProperty("ExcludeImageIds")]
        public string[] ExcludeImageIds{ get; set; }

        /// <summary>
        /// <p>Whether the image has running containers</p>
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public bool? ContainerRunning{ get; set; }

        /// <summary>
        /// <p>Scan range 0 all authorized images, 1 selected images, 2 recommended scan, 3 cluster scan</p><p>Value ranges from 0 to 3</p><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("ScanScope")]
        public ulong? ScanScope{ get; set; }

        /// <summary>
        /// <p>Task timeout duration unit seconds, default 1 hour.</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>One-click scan task. Default false indicates non-one-click scan, true one-click scan.</p>
        /// </summary>
        [JsonProperty("IsOneClickScanningTask")]
        public bool? IsOneClickScanningTask{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterIDs")]
        public string[] ClusterIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ScanVul", this.ScanVul);
            this.SetParamSimple(map, prefix + "ScanVirus", this.ScanVirus);
            this.SetParamSimple(map, prefix + "ScanRisk", this.ScanRisk);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ExcludeImageIds.", this.ExcludeImageIds);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "ScanScope", this.ScanScope);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "IsOneClickScanningTask", this.IsOneClickScanningTask);
            this.SetParamArraySimple(map, prefix + "ClusterIDs.", this.ClusterIDs);
        }
    }
}

