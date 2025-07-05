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

    public class CreateVirusScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to scan all paths
        /// </summary>
        [JsonProperty("ScanPathAll")]
        public bool? ScanPathAll{ get; set; }

        /// <summary>
        /// Scanning scope. Valid values: `0` (container); `1` (server).
        /// </summary>
        [JsonProperty("ScanRangeType")]
        public ulong? ScanRangeType{ get; set; }

        /// <summary>
        /// Valid values: `true` (all); `false` (specified).
        /// </summary>
        [JsonProperty("ScanRangeAll")]
        public bool? ScanRangeAll{ get; set; }

        /// <summary>
        /// Timeout period in hours
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// Valid when `ScanPathAll` is `false`. Valid values: `0` (scan the following paths); `1` (scan all paths except the following).
        /// </summary>
        [JsonProperty("ScanPathType")]
        public ulong? ScanPathType{ get; set; }

        /// <summary>
        /// ID of the specified container or server to be scanned, which is based on `ScanRangeType`.
        /// </summary>
        [JsonProperty("ScanIds")]
        public string[] ScanIds{ get; set; }

        /// <summary>
        /// Specified path to be excluded or scanned
        /// </summary>
        [JsonProperty("ScanPath")]
        public string[] ScanPath{ get; set; }

        /// <summary>
        /// Path scanning mode: 
        /// `SCAN_PATH_ALL`: Scan all paths
        /// `SCAN_PATH_DEFAULT`: Scan the default path
        /// `SCAN_PATH_USER_DEFINE`: Scan the custom path
        /// </summary>
        [JsonProperty("ScanPathMode")]
        public string ScanPathMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanPathAll", this.ScanPathAll);
            this.SetParamSimple(map, prefix + "ScanRangeType", this.ScanRangeType);
            this.SetParamSimple(map, prefix + "ScanRangeAll", this.ScanRangeAll);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ScanPathType", this.ScanPathType);
            this.SetParamArraySimple(map, prefix + "ScanIds.", this.ScanIds);
            this.SetParamArraySimple(map, prefix + "ScanPath.", this.ScanPath);
            this.SetParamSimple(map, prefix + "ScanPathMode", this.ScanPathMode);
        }
    }
}

