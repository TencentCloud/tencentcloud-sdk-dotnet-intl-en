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

    public class HostVulOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of vulnerabilities that require immediate fix (number of vulnerabilities with VPR rating of URGENT)</p>
        /// </summary>
        [JsonProperty("UrgentRepairCount")]
        public ulong? UrgentRepairCount{ get; set; }

        /// <summary>
        /// <p>Hosts with vulnerability protection enabled</p>
        /// </summary>
        [JsonProperty("DefendHostCount")]
        public ulong? DefendHostCount{ get; set; }

        /// <summary>
        /// <p>Total hosts</p>
        /// </summary>
        [JsonProperty("TotalHostCount")]
        public ulong? TotalHostCount{ get; set; }

        /// <summary>
        /// <p>Total number of times vulnerabilities have been fixed</p>
        /// </summary>
        [JsonProperty("FixedVulCount")]
        public ulong? FixedVulCount{ get; set; }

        /// <summary>
        /// <p>Linux software vulnerability count</p>
        /// </summary>
        [JsonProperty("LinuxVulCount")]
        public ulong? LinuxVulCount{ get; set; }

        /// <summary>
        /// <p>Number of Windows system patches</p>
        /// </summary>
        [JsonProperty("WindowVulCount")]
        public ulong? WindowVulCount{ get; set; }

        /// <summary>
        /// <p>Number of Web-CMS vulnerabilities</p>
        /// </summary>
        [JsonProperty("WebCMSVulCount")]
        public ulong? WebCMSVulCount{ get; set; }

        /// <summary>
        /// <p>Number of application vulnerabilities</p>
        /// </summary>
        [JsonProperty("AppVulCount")]
        public ulong? AppVulCount{ get; set; }

        /// <summary>
        /// <p>Number of emergency vulnerabilities</p>
        /// </summary>
        [JsonProperty("EmergencyCount")]
        public ulong? EmergencyCount{ get; set; }

        /// <summary>
        /// <p>Total number of vulnerability knowledge base</p>
        /// </summary>
        [JsonProperty("VulItemCount")]
        public ulong? VulItemCount{ get; set; }

        /// <summary>
        /// <p>Latest scan time.</p><p>Parameter format: YYYY-MM-DDTHH:mm:ssZ</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>Whether period scanning is enabled</p><p>Enumeration value:</p><ul><li>1: Enabled</li><li>0: Not enabled</li></ul>
        /// </summary>
        [JsonProperty("EnableTimingScan")]
        public ulong? EnableTimingScan{ get; set; }

        /// <summary>
        /// <p>Number of critical fixes</p>
        /// </summary>
        [JsonProperty("CriticalRepairCount")]
        public ulong? CriticalRepairCount{ get; set; }

        /// <summary>
        /// <p>Critical Linux vulnerability fix count</p>
        /// </summary>
        [JsonProperty("CriticalRepairLinuxVulCount")]
        public ulong? CriticalRepairLinuxVulCount{ get; set; }

        /// <summary>
        /// <p>Severe application vulnerability fix count</p>
        /// </summary>
        [JsonProperty("CriticalRepairAppVulCount")]
        public ulong? CriticalRepairAppVulCount{ get; set; }

        /// <summary>
        /// <p>Critical fix for Web-CMS vulnerabilities</p>
        /// </summary>
        [JsonProperty("CriticalRepairWebCMSVulCount")]
        public ulong? CriticalRepairWebCMSVulCount{ get; set; }

        /// <summary>
        /// <p>Critical fix emergency vulnerability count</p>
        /// </summary>
        [JsonProperty("CriticalRepairEmergencyCount")]
        public ulong? CriticalRepairEmergencyCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UrgentRepairCount", this.UrgentRepairCount);
            this.SetParamSimple(map, prefix + "DefendHostCount", this.DefendHostCount);
            this.SetParamSimple(map, prefix + "TotalHostCount", this.TotalHostCount);
            this.SetParamSimple(map, prefix + "FixedVulCount", this.FixedVulCount);
            this.SetParamSimple(map, prefix + "LinuxVulCount", this.LinuxVulCount);
            this.SetParamSimple(map, prefix + "WindowVulCount", this.WindowVulCount);
            this.SetParamSimple(map, prefix + "WebCMSVulCount", this.WebCMSVulCount);
            this.SetParamSimple(map, prefix + "AppVulCount", this.AppVulCount);
            this.SetParamSimple(map, prefix + "EmergencyCount", this.EmergencyCount);
            this.SetParamSimple(map, prefix + "VulItemCount", this.VulItemCount);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "EnableTimingScan", this.EnableTimingScan);
            this.SetParamSimple(map, prefix + "CriticalRepairCount", this.CriticalRepairCount);
            this.SetParamSimple(map, prefix + "CriticalRepairLinuxVulCount", this.CriticalRepairLinuxVulCount);
            this.SetParamSimple(map, prefix + "CriticalRepairAppVulCount", this.CriticalRepairAppVulCount);
            this.SetParamSimple(map, prefix + "CriticalRepairWebCMSVulCount", this.CriticalRepairWebCMSVulCount);
            this.SetParamSimple(map, prefix + "CriticalRepairEmergencyCount", this.CriticalRepairEmergencyCount);
        }
    }
}

