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

    public class CreateVulScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Local image scan range type</p><p>Enumeration value:</p><ul><li>ALL: All local images</li><li>NOT_SCAN: All authorized unscanned local images</li><li>IMAGEIDS: Selected local image IDs</li><li>CLUSTER: Cluster filtering</li></ul>
        /// </summary>
        [JsonProperty("LocalImageScanType")]
        public string LocalImageScanType{ get; set; }

        /// <summary>
        /// <p>Scan by authorized local image IDs, which takes precedence over scanning by authorized local images that meet the conditions.</p>
        /// </summary>
        [JsonProperty("LocalImageIDs")]
        public string[] LocalImageIDs{ get; set; }

        /// <summary>
        /// <p>Repository image scan range type. ALL: All repository images. NOT_SCAN: Total authorized unscanned repository images. IMAGEIDS: Selected repository image IDs.</p>
        /// </summary>
        [JsonProperty("RegistryImageScanType")]
        public string RegistryImageScanType{ get; set; }

        /// <summary>
        /// <p>Scan by authorized repository image IDs, which takes precedence over scanning by authorized repository images that meet the conditions.</p>
        /// </summary>
        [JsonProperty("RegistryImageIDs")]
        public ulong?[] RegistryImageIDs{ get; set; }

        /// <summary>
        /// <p>Task ID for local image re-vulnerability scanning</p>
        /// </summary>
        [JsonProperty("LocalTaskID")]
        public long? LocalTaskID{ get; set; }

        /// <summary>
        /// <p>Task ID for repository image re-vulnerability scanning</p>
        /// </summary>
        [JsonProperty("RegistryTaskID")]
        public long? RegistryTaskID{ get; set; }

        /// <summary>
        /// <p>Local image container runtime</p>
        /// </summary>
        [JsonProperty("LocalImageContainerRunning")]
        public bool? LocalImageContainerRunning{ get; set; }

        /// <summary>
        /// <p>Image Container in repository is running</p>
        /// </summary>
        [JsonProperty("RegistryImageContainerRunning")]
        public bool? RegistryImageContainerRunning{ get; set; }

        /// <summary>
        /// <p>Whether the repository image is the latest</p>
        /// </summary>
        [JsonProperty("IsLatest")]
        public bool? IsLatest{ get; set; }

        /// <summary>
        /// <p>Local image id to remove</p>
        /// </summary>
        [JsonProperty("ExcludeLocalImageIDs")]
        public string[] ExcludeLocalImageIDs{ get; set; }

        /// <summary>
        /// <p>id of the repository image to remove</p>
        /// </summary>
        [JsonProperty("ExcludeRegistryImageIDs")]
        public ulong?[] ExcludeRegistryImageIDs{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("LocalClusterIDs")]
        public string[] LocalClusterIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalImageScanType", this.LocalImageScanType);
            this.SetParamArraySimple(map, prefix + "LocalImageIDs.", this.LocalImageIDs);
            this.SetParamSimple(map, prefix + "RegistryImageScanType", this.RegistryImageScanType);
            this.SetParamArraySimple(map, prefix + "RegistryImageIDs.", this.RegistryImageIDs);
            this.SetParamSimple(map, prefix + "LocalTaskID", this.LocalTaskID);
            this.SetParamSimple(map, prefix + "RegistryTaskID", this.RegistryTaskID);
            this.SetParamSimple(map, prefix + "LocalImageContainerRunning", this.LocalImageContainerRunning);
            this.SetParamSimple(map, prefix + "RegistryImageContainerRunning", this.RegistryImageContainerRunning);
            this.SetParamSimple(map, prefix + "IsLatest", this.IsLatest);
            this.SetParamArraySimple(map, prefix + "ExcludeLocalImageIDs.", this.ExcludeLocalImageIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeRegistryImageIDs.", this.ExcludeRegistryImageIDs);
            this.SetParamArraySimple(map, prefix + "LocalClusterIDs.", this.LocalClusterIDs);
        }
    }
}

