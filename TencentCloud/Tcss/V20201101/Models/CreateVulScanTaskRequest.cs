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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVulScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Local image scan scope. Valid values: `ALL` (all local images); `NOT_SCAN` (all licensed but not scanned local images); `IMAGEIDS` (IDs of specified local images).
        /// </summary>
        [JsonProperty("LocalImageScanType")]
        public string LocalImageScanType{ get; set; }

        /// <summary>
        /// Scan by licensed local image ID, with a higher priority than scan by licensed local image that meets the condition.
        /// </summary>
        [JsonProperty("LocalImageIDs")]
        public string[] LocalImageIDs{ get; set; }

        /// <summary>
        /// Repository image scan scope. Valid values: `ALL` (all repository images); `NOT_SCAN` (all licensed but not scanned repository images); `IMAGEIDS` (IDs of specified repository images).
        /// </summary>
        [JsonProperty("RegistryImageScanType")]
        public string RegistryImageScanType{ get; set; }

        /// <summary>
        /// Scan by licensed repository image ID, with a higher priority than scan by licensed repository image that meets the condition.
        /// </summary>
        [JsonProperty("RegistryImageIDs")]
        public ulong?[] RegistryImageIDs{ get; set; }

        /// <summary>
        /// ID of the task to scan local images again for vulnerabilities
        /// </summary>
        [JsonProperty("LocalTaskID")]
        public long? LocalTaskID{ get; set; }

        /// <summary>
        /// ID of the task to scan repository images again for vulnerabilities
        /// </summary>
        [JsonProperty("RegistryTaskID")]
        public long? RegistryTaskID{ get; set; }


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
        }
    }
}

