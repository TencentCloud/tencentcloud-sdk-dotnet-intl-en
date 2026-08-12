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

    public class ModifyVulScanPeriodicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Period scanning switch (0-off, 1-on)</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Vulnerability type</p><p>Enumeration value:</p><ul><li>LINUX: Linux software vulnerability</li><li>WINDOWS: Windows system patch</li><li>WEB_CMS: Web-CMS vulnerability</li><li>APPLICATION: Application vulnerability</li><li>EMERGENCY: Emergency vulnerability</li></ul>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// <p>Vulnerability level</p><p>Enumeration value:</p><ul><li>LOW: Low risk</li><li>MEDIUM: Medium risk</li><li>HIGH: High risk</li><li>CRITICAL: Critical</li></ul>
        /// </summary>
        [JsonProperty("Level")]
        public string[] Level{ get; set; }

        /// <summary>
        /// <p>Scanning method (VersionCompare: version comparison, POC: POC detection, VersionComparePOC: version comparison+POC detection)</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>Start time (09:00:00)</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time (18:00:00)</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Asset scope (0-All assets, 1-Custom assets, 2-Remove asset, 3-Automatic asset match)</p>
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// <p>Period scanning type</p><p>Enumeration value:</p><ul><li>1: Daily</li><li>2: Weekly</li><li>3: Per month</li></ul>
        /// </summary>
        [JsonProperty("CycleType")]
        public ulong? CycleType{ get; set; }

        /// <summary>
        /// <p>Scan timeout duration</p><p>Measurement unit: second</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>Cycle value</p><p>Value ranges from 1 to 31</p><p>Measurement unit: day of the week or per month</p>
        /// </summary>
        [JsonProperty("CycleValue")]
        public ulong?[] CycleValue{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Asset list (instance_id list)</p>
        /// </summary>
        [JsonProperty("AssetList")]
        public string[] AssetList{ get; set; }

        /// <summary>
        /// <p>Whether to run the synchronize configuration 0-not allowed, 1-allowed</p>
        /// </summary>
        [JsonProperty("AllowSync")]
        public ulong? AllowSync{ get; set; }

        /// <summary>
        /// <p>Whether the admin account has enabled the auto sync configuration switch 0-Off, 1-On</p>
        /// </summary>
        [JsonProperty("EnableSync")]
        public ulong? EnableSync{ get; set; }

        /// <summary>
        /// <p>Configuration sync to which account appid</p>
        /// </summary>
        [JsonProperty("SyncTo")]
        public ulong?[] SyncTo{ get; set; }

        /// <summary>
        /// <p>Tag ID</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "VulCategory.", this.VulCategory);
            this.SetParamArraySimple(map, prefix + "Level.", this.Level);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArraySimple(map, prefix + "CycleValue.", this.CycleValue);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "AssetList.", this.AssetList);
            this.SetParamSimple(map, prefix + "AllowSync", this.AllowSync);
            this.SetParamSimple(map, prefix + "EnableSync", this.EnableSync);
            this.SetParamArraySimple(map, prefix + "SyncTo.", this.SyncTo);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
        }
    }
}

