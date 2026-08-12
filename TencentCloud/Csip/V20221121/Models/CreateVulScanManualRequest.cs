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

    public class CreateVulScanManualRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Timeout period (seconds)</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>Asset scope (0-all assets, 1-Custom assets, 2-remove asset, 3-automatic asset match)</p>
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// <p>Scanning method (VersionCompare: version comparison, POC: POC detection, VersionComparePOC: version comparison + POC detection)</p>
        /// </summary>
        [JsonProperty("Method")]
        public string[] Method{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Vulnerability id</p>
        /// </summary>
        [JsonProperty("VulId")]
        public ulong?[] VulId{ get; set; }

        /// <summary>
        /// <p>kb No.</p>
        /// </summary>
        [JsonProperty("KbNo")]
        public string[] KbNo{ get; set; }

        /// <summary>
        /// <p>Vulnerability scan type</p><p>Enumeration value:</p><ul><li>LINUX: Linux software vulnerability</li><li>WINDOWS: Windows system patch</li><li>WEB_CMS: Web-CMS vulnerability</li><li>APPLICATION: Application vulnerability</li><li>EMERGENCY: Emergency vulnerability</li></ul>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// <p>Vulnerability level (INVALID: Invalid, INFO: Notification, LOW: Low risk, MEDIUM: Medium risk, HIGH: High risk, CRITICAL: Critical)</p>
        /// </summary>
        [JsonProperty("Level")]
        public string[] Level{ get; set; }

        /// <summary>
        /// <p>Asset list (UUID list)</p>
        /// </summary>
        [JsonProperty("AssetList")]
        public string[] AssetList{ get; set; }

        /// <summary>
        /// <p>Tag id</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "Method.", this.Method);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "VulId.", this.VulId);
            this.SetParamArraySimple(map, prefix + "KbNo.", this.KbNo);
            this.SetParamArraySimple(map, prefix + "VulCategory.", this.VulCategory);
            this.SetParamArraySimple(map, prefix + "Level.", this.Level);
            this.SetParamArraySimple(map, prefix + "AssetList.", this.AssetList);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
        }
    }
}

