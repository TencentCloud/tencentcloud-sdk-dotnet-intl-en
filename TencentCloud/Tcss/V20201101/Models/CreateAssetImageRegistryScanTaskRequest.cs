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

    public class CreateAssetImageRegistryScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to scan all images.</p>
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// <p>List of images to be scanned.</p>
        /// </summary>
        [JsonProperty("Images")]
        public ImageInfo[] Images{ get; set; }

        /// <summary>
        /// <p>Scan type array.</p>
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// <p>List of images to be scanned.</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong?[] Id{ get; set; }

        /// <summary>
        /// <p>Filter conditions.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// <p>List of images that do not need to be scanned, used in conjunction with Filters.</p>
        /// </summary>
        [JsonProperty("ExcludeImageList")]
        public ulong?[] ExcludeImageList{ get; set; }

        /// <summary>
        /// <p>Whether to scan only the latest version of the image in each repository, used in conjunction with Filters.</p>
        /// </summary>
        [JsonProperty("OnlyScanLatest")]
        public bool? OnlyScanLatest{ get; set; }

        /// <summary>
        /// <p>Task timeout duration.</p><p>Unit: seconds.</p>
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
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ExcludeImageList.", this.ExcludeImageList);
            this.SetParamSimple(map, prefix + "OnlyScanLatest", this.OnlyScanLatest);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

