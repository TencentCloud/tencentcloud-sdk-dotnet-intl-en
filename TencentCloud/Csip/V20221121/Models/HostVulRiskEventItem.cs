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

    public class HostVulRiskEventItem : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of a vulnerability risk record.
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// Risk record ID
        /// </summary>
        [JsonProperty("RiskID")]
        public ulong? RiskID{ get; set; }

        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulID")]
        public ulong? VulID{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// CVE No.
        /// Parameter format: such as CVE-2024-12345
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// Vulnerability category
        /// Enumeration values:
        /// LINUX: Linux software vulnerability
        /// WINDOWS: Windows system patch
        /// WEB_CMS: Web-CMS vulnerability
        /// APPLICATION: Application vulnerability
        /// EMERGENCY: Urgent vulnerability
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Vulnerability severity level
        /// Enumeration values:
        /// UNKNOWN: invalid
        /// LOW: low-risk
        /// MEDIUM: Medium risk
        /// HIGH: High risk
        /// CRITICAL: Critical
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// VPR repair priority
        /// Enumeration values:
        /// DEFERRABLE: Can be repaired later
        /// PLANNED: Planned repair
        /// SOON: Fix as soon as possible
        /// URGENT: urgent repair
        /// </summary>
        [JsonProperty("VPRLevel")]
        public string VPRLevel{ get; set; }

        /// <summary>
        /// Detection mode
        /// Enumeration values:
        /// VersionCompare: version comparison
        /// POC: POC detection
        /// VersionComparePOC: version comparison + POC
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// Risk status
        /// Enumeration value:
        /// PENDING: to be processed.
        /// HANDLED: processed
        /// FIXED: Fixed
        /// SCANNING: Rechecking
        /// IGNORED: ignored
        /// NOT_REQUIRED: No action is required
        /// DELETED: Deleted
        /// FIXING: In remediation
        /// NEED_REBOOT: Fixed and pending restart
        /// FIX_FAILURE: FIX failure
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// Whether one-click repair is supported
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// Last scan time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// Cloud host instance ID
        /// Parameter format: such as ins-xxxxxxxx
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Account AppID
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "VulID", this.VulID);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "VPRLevel", this.VPRLevel);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
        }
    }
}

