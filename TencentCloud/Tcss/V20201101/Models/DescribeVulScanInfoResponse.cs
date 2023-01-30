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

    public class DescribeVulScanInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of local images scanned this time
        /// </summary>
        [JsonProperty("LocalImageScanCount")]
        public long? LocalImageScanCount{ get; set; }

        /// <summary>
        /// Number of ignored vulnerabilities
        /// </summary>
        [JsonProperty("IgnoreVulCount")]
        public long? IgnoreVulCount{ get; set; }

        /// <summary>
        /// Start time of the vulnerability scan
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public string ScanStartTime{ get; set; }

        /// <summary>
        /// End time of the vulnerability scan
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// Number of images found to be at risk
        /// </summary>
        [JsonProperty("FoundRiskImageCount")]
        public long? FoundRiskImageCount{ get; set; }

        /// <summary>
        /// Number of vulnerabilities found in local images
        /// </summary>
        [JsonProperty("FoundVulCount")]
        public long? FoundVulCount{ get; set; }

        /// <summary>
        /// Scanning progress
        /// </summary>
        [JsonProperty("ScanProgress")]
        public float? ScanProgress{ get; set; }

        /// <summary>
        /// Total number of repository images scanned this time
        /// </summary>
        [JsonProperty("RegistryImageScanCount")]
        public long? RegistryImageScanCount{ get; set; }

        /// <summary>
        /// ID of the last task to scan local images for vulnerabilities
        /// </summary>
        [JsonProperty("LocalTaskID")]
        public long? LocalTaskID{ get; set; }

        /// <summary>
        /// Scanning status. Valid values: `NOT_SCAN` (not scanned); `SCANNING` (scanning); `SCANNED` (scanned); `CANCELED` (stopped).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Remaining time in seconds
        /// </summary>
        [JsonProperty("RemainingTime")]
        public float? RemainingTime{ get; set; }

        /// <summary>
        /// ID of the last task to scan repository images for vulnerabilities
        /// </summary>
        [JsonProperty("RegistryTaskID")]
        public long? RegistryTaskID{ get; set; }

        /// <summary>
        /// Number of vulnerabilities found in the repository
        /// </summary>
        [JsonProperty("RegistryFoundVulCount")]
        public long? RegistryFoundVulCount{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalImageScanCount", this.LocalImageScanCount);
            this.SetParamSimple(map, prefix + "IgnoreVulCount", this.IgnoreVulCount);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "FoundRiskImageCount", this.FoundRiskImageCount);
            this.SetParamSimple(map, prefix + "FoundVulCount", this.FoundVulCount);
            this.SetParamSimple(map, prefix + "ScanProgress", this.ScanProgress);
            this.SetParamSimple(map, prefix + "RegistryImageScanCount", this.RegistryImageScanCount);
            this.SetParamSimple(map, prefix + "LocalTaskID", this.LocalTaskID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RemainingTime", this.RemainingTime);
            this.SetParamSimple(map, prefix + "RegistryTaskID", this.RegistryTaskID);
            this.SetParamSimple(map, prefix + "RegistryFoundVulCount", this.RegistryFoundVulCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

