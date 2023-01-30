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

    public class ModifyVirusScanSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable scheduled scan
        /// </summary>
        [JsonProperty("EnableScan")]
        public bool? EnableScan{ get; set; }

        /// <summary>
        /// Check cycle in days. Valid values: `1`, `3`, `7`.
        /// </summary>
        [JsonProperty("Cycle")]
        public ulong? Cycle{ get; set; }

        /// <summary>
        /// Scan start time
        /// </summary>
        [JsonProperty("BeginScanAt")]
        public string BeginScanAt{ get; set; }

        /// <summary>
        /// Scan all paths. Valid values: `true` (all); `false` (specified).
        /// </summary>
        [JsonProperty("ScanPathAll")]
        public bool? ScanPathAll{ get; set; }

        /// <summary>
        /// Valid when `ScanPathAll` is `true`. Valid values of `ScanPathAll`: `0` (scan the following paths); `1` (scan all paths except the following).
        /// </summary>
        [JsonProperty("ScanPathType")]
        public ulong? ScanPathType{ get; set; }

        /// <summary>
        /// Timeout period in hours. Value range: 5-24.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

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
        /// ID of the specified container or server to be scanned, which is based on `ScanRangeType`.
        /// </summary>
        [JsonProperty("ScanIds")]
        public string[] ScanIds{ get; set; }

        /// <summary>
        /// Scanned path
        /// </summary>
        [JsonProperty("ScanPath")]
        public string[] ScanPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamSimple(map, prefix + "Cycle", this.Cycle);
            this.SetParamSimple(map, prefix + "BeginScanAt", this.BeginScanAt);
            this.SetParamSimple(map, prefix + "ScanPathAll", this.ScanPathAll);
            this.SetParamSimple(map, prefix + "ScanPathType", this.ScanPathType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ScanRangeType", this.ScanRangeType);
            this.SetParamSimple(map, prefix + "ScanRangeAll", this.ScanRangeAll);
            this.SetParamArraySimple(map, prefix + "ScanIds.", this.ScanIds);
            this.SetParamArraySimple(map, prefix + "ScanPath.", this.ScanPath);
        }
    }
}

