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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostVulScanStatus : AbstractModel
    {
        
        /// <summary>
        /// Whether vulnerability scanning has been initiated
        /// Enumeration values:
        /// true: Vulnerability scanning initiated
        /// false: vulnerability scanning not initiated
        /// </summary>
        [JsonProperty("HasScanned")]
        public bool? HasScanned{ get; set; }

        /// <summary>
        /// If it is the first vulnerability scanning judgment scenario
        /// Enumeration values:
        /// true: is in the first-time vulnerability scanning judgment scenario
        /// false: not in the first vulnerability scanning judgment scenario
        /// </summary>
        [JsonProperty("IsFirstScan")]
        public bool? IsFirstScan{ get; set; }

        /// <summary>
        /// Status of the last scan task
        /// Enumeration values:
        /// SCANNING: scan in progress
        /// SUCCESS: Scan successful
        /// PARTIAL_FAILED: Partial scan failure
        /// ALL_FAILED: All scans failed
        /// STOPPED: Stop scanning
        /// </summary>
        [JsonProperty("ScanTaskStatus")]
        public string ScanTaskStatus{ get; set; }

        /// <summary>
        /// Business status of the page
        /// Enumeration values:
        /// NEVER_SCANNED: Never scanned for vulnerabilities
        /// SCANNING: scan in progress
        /// FIRST_SCAN_FAILED: Vulnerability scanning failed for the first time
        /// FIRST_SCAN_HAS_FIXABLE_VUL: First scan complete, fixable vulnerabilities exist
        /// FIRST_SCAN_NO_FIXABLE_VUL: First scan completed. Vulnerabilities exist but none can be fixed.
        /// FIRST_SCAN_NO_VUL: First scan complete, no vulnerabilities
        /// SCANNED_HAS_FIXABLE_VUL: Not the first scan, fixable vulnerabilities exist
        /// SCANNED_NO_FIXABLE_VUL: Not the first scan. Vulnerabilities exist but none can be fixed.
        /// SCANNED_NO_VUL: Not the first scan, no vulnerabilities
        /// </summary>
        [JsonProperty("ScanScene")]
        public string ScanScene{ get; set; }

        /// <summary>
        /// Last scan time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
        /// Returns an empty string if unscanned.
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// Current total count of pending vulnerabilities
        /// Contains common host vulnerabilities and pending risks of the latest Windows KB.
        /// </summary>
        [JsonProperty("TotalVulCount")]
        public long? TotalVulCount{ get; set; }

        /// <summary>
        /// Current number of fixable vulnerabilities
        /// Contains ordinary host vulnerabilities that support one-click repair and the latest pending Windows KB risks.
        /// </summary>
        [JsonProperty("FixableVulCount")]
        public long? FixableVulCount{ get; set; }

        /// <summary>
        /// Current number of repairable emergency vulnerabilities
        /// Urgent vulnerabilities are prioritized for categorization: urgent vulnerabilities are only counted into this field and no longer included in the Linux software vulnerability count.
        /// </summary>
        [JsonProperty("FixableEmergencyCount")]
        public long? FixableEmergencyCount{ get; set; }

        /// <summary>
        /// Current number of repairable Linux software vulnerabilities
        /// Only non-emergency Linux software vulnerabilities are counted.
        /// </summary>
        [JsonProperty("FixableLinuxVulCount")]
        public long? FixableLinuxVulCount{ get; set; }

        /// <summary>
        /// Number of currently repairable patches for Windows systems
        /// Statistics of the latest pending Windows KB risks.
        /// </summary>
        [JsonProperty("FixableWindowVulCount")]
        public long? FixableWindowVulCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HasScanned", this.HasScanned);
            this.SetParamSimple(map, prefix + "IsFirstScan", this.IsFirstScan);
            this.SetParamSimple(map, prefix + "ScanTaskStatus", this.ScanTaskStatus);
            this.SetParamSimple(map, prefix + "ScanScene", this.ScanScene);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "TotalVulCount", this.TotalVulCount);
            this.SetParamSimple(map, prefix + "FixableVulCount", this.FixableVulCount);
            this.SetParamSimple(map, prefix + "FixableEmergencyCount", this.FixableEmergencyCount);
            this.SetParamSimple(map, prefix + "FixableLinuxVulCount", this.FixableLinuxVulCount);
            this.SetParamSimple(map, prefix + "FixableWindowVulCount", this.FixableWindowVulCount);
        }
    }
}

