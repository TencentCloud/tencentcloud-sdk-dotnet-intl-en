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

    public class CreateAssetImageRegistryScanTaskOneKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to scan all images
        /// </summary>
        [JsonProperty("All")]
        [System.Obsolete]
        public bool? All{ get; set; }

        /// <summary>
        /// List of scanned images
        /// </summary>
        [JsonProperty("Images")]
        public ImageInfo[] Images{ get; set; }

        /// <summary>
        /// Array of scan types
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// List of IDs of scanned images
        /// </summary>
        [JsonProperty("Id")]
        public ulong?[] Id{ get; set; }

        /// <summary>
        /// List of image IDs excluded from scanning.
        /// </summary>
        [JsonProperty("ExcludeIDs")]
        public ulong?[] ExcludeIDs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsLatest")]
        public bool? IsLatest{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScanScope")]
        public ulong? ScanScope{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegistryType")]
        public string[] RegistryType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Namespace")]
        public string[] Namespace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public bool? ContainerRunning{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
            this.SetParamArraySimple(map, prefix + "Id.", this.Id);
            this.SetParamArraySimple(map, prefix + "ExcludeIDs.", this.ExcludeIDs);
            this.SetParamSimple(map, prefix + "IsLatest", this.IsLatest);
            this.SetParamSimple(map, prefix + "ScanScope", this.ScanScope);
            this.SetParamArraySimple(map, prefix + "RegistryType.", this.RegistryType);
            this.SetParamArraySimple(map, prefix + "Namespace.", this.Namespace);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

