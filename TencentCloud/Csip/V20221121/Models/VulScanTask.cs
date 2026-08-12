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

    public class VulScanTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>Associated user appid of the task</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Task type</p><p>Enumeration value:</p><ul><li>0: One-click scan</li><li>1: Period scanning</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// <p>Vulnerability type</p><p>Enumeration value:</p><ul><li>LINUX: Linux software vulnerability</li><li>WINDOWS: Windows system patch</li><li>WEB_CMS: Web-CMS vulnerability</li><li>APPLICATION: Application vulnerability</li><li>EMERGENCY: Emergency vulnerability</li></ul>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// <p>Vulnerability name</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string[] VulName{ get; set; }

        /// <summary>
        /// <p>kb name.</p>
        /// </summary>
        [JsonProperty("KbName")]
        public string[] KbName{ get; set; }

        /// <summary>
        /// <p>Whether an emergency vulnerability</p><p>Enumeration value:</p><ul><li>0: No</li><li>1: Yes</li></ul>
        /// </summary>
        [JsonProperty("Emergency")]
        public ulong? Emergency{ get; set; }

        /// <summary>
        /// <p>Number of accounts to scan (0: all accounts, others: number of accounts)</p>
        /// </summary>
        [JsonProperty("Account")]
        public ulong? Account{ get; set; }

        /// <summary>
        /// <p>Scan start time</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Scan end time</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Scan status (INITIALIZING: Initialization, SCANNING: Scanning, SUCCESS: Scan successful, TOTAL_FAIL: Total scan failure)</p><p>Enumeration value:</p><ul><li>STOPPED: Stopped</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Vulnerability threat level</p><p>Enumeration value:</p><ul><li>LOW: Low risk</li><li>MEDIUM: Medium risk</li><li>HIGH: High risk</li><li>CRITICAL: Critical</li></ul>
        /// </summary>
        [JsonProperty("Level")]
        public string[] Level{ get; set; }

        /// <summary>
        /// <p>Scanning method</p><p>Enumeration value:</p><ul><li>VersionCompare: version comparison</li><li>POC: POC detection</li><li>VersionComparePOC: version comparison+POC detection</li></ul>
        /// </summary>
        [JsonProperty("Method")]
        public string[] Method{ get; set; }

        /// <summary>
        /// <p>Asset list</p>
        /// </summary>
        [JsonProperty("AssetList")]
        public string[] AssetList{ get; set; }

        /// <summary>
        /// <p>Asset scope</p><p>Enumeration value:</p><ul><li>0: All assets</li><li>1: Custom assets</li><li>2: Selected excluded assets</li></ul>
        /// </summary>
        [JsonProperty("AssetRange")]
        public ulong? AssetRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "VulCategory.", this.VulCategory);
            this.SetParamArraySimple(map, prefix + "VulName.", this.VulName);
            this.SetParamArraySimple(map, prefix + "KbName.", this.KbName);
            this.SetParamSimple(map, prefix + "Emergency", this.Emergency);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Level.", this.Level);
            this.SetParamArraySimple(map, prefix + "Method.", this.Method);
            this.SetParamArraySimple(map, prefix + "AssetList.", this.AssetList);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
        }
    }
}

