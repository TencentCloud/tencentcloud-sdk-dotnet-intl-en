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

    public class VulScanImageInfo : AbstractModel
    {
        
        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image size
        /// </summary>
        [JsonProperty("Size")]
        public float? Size{ get; set; }

        /// <summary>
        /// Task status. Valid values: `SCANNING` (scanning); `FAILED` (failed); `FINISHED` (completed); `CANCELED` (canceled).
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// Scan duration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanDuration")]
        public float? ScanDuration{ get; set; }

        /// <summary>
        /// Number of high-risk vulnerabilities
        /// </summary>
        [JsonProperty("HighLevelVulCount")]
        public long? HighLevelVulCount{ get; set; }

        /// <summary>
        /// Number of medium-risk vulnerabilities
        /// </summary>
        [JsonProperty("MediumLevelVulCount")]
        public long? MediumLevelVulCount{ get; set; }

        /// <summary>
        /// Number of low-risk vulnerabilities
        /// </summary>
        [JsonProperty("LowLevelVulCount")]
        public long? LowLevelVulCount{ get; set; }

        /// <summary>
        /// Number of critical vulnerabilities
        /// </summary>
        [JsonProperty("CriticalLevelVulCount")]
        public long? CriticalLevelVulCount{ get; set; }

        /// <summary>
        /// ID of the task to scan local images for vulnerabilities
        /// </summary>
        [JsonProperty("TaskID")]
        public long? TaskID{ get; set; }

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
        /// Cause of the failure. Valid values: `TIMEOUT` (timeout); `TOO_MANY` (too many tasks); `OFFLINE` (offline).
        /// </summary>
        [JsonProperty("ErrorStatus")]
        public string ErrorStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "ScanDuration", this.ScanDuration);
            this.SetParamSimple(map, prefix + "HighLevelVulCount", this.HighLevelVulCount);
            this.SetParamSimple(map, prefix + "MediumLevelVulCount", this.MediumLevelVulCount);
            this.SetParamSimple(map, prefix + "LowLevelVulCount", this.LowLevelVulCount);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCount", this.CriticalLevelVulCount);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "ErrorStatus", this.ErrorStatus);
        }
    }
}

