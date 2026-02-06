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

    public class CsipRiskCenterStatistics : AbstractModel
    {
        
        /// <summary>
        /// Total Number of Port Risks
        /// </summary>
        [JsonProperty("PortTotal")]
        public ulong? PortTotal{ get; set; }

        /// <summary>
        /// High Port Risk Count
        /// </summary>
        [JsonProperty("PortHighLevel")]
        public ulong? PortHighLevel{ get; set; }

        /// <summary>
        /// 	Total number of weak password risks.
        /// </summary>
        [JsonProperty("WeakPasswordTotal")]
        public ulong? WeakPasswordTotal{ get; set; }

        /// <summary>
        /// High Weak Password Risk Count
        /// </summary>
        [JsonProperty("WeakPasswordHighLevel")]
        public ulong? WeakPasswordHighLevel{ get; set; }

        /// <summary>
        /// Website Risk Count
        /// </summary>
        [JsonProperty("WebsiteTotal")]
        public ulong? WebsiteTotal{ get; set; }

        /// <summary>
        /// Number of High Risks on Websites
        /// </summary>
        [JsonProperty("WebsiteHighLevel")]
        public ulong? WebsiteHighLevel{ get; set; }

        /// <summary>
        /// Time of the Latest Scan
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Number of vulnerability risks.
        /// </summary>
        [JsonProperty("VULTotal")]
        public long? VULTotal{ get; set; }

        /// <summary>
        /// Number of High-Risk Vulnerability Risks
        /// </summary>
        [JsonProperty("VULHighLevel")]
        public long? VULHighLevel{ get; set; }

        /// <summary>
        /// Number of Configuration Item Risks
        /// </summary>
        [JsonProperty("CFGTotal")]
        public long? CFGTotal{ get; set; }

        /// <summary>
        /// Number of High-Risk Configuration Item Risks
        /// </summary>
        [JsonProperty("CFGHighLevel")]
        public long? CFGHighLevel{ get; set; }

        /// <summary>
        /// Mapping Service Risk Count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerTotal")]
        public long? ServerTotal{ get; set; }

        /// <summary>
        /// High Mapping Service Risk Count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerHighLevel")]
        public long? ServerHighLevel{ get; set; }

        /// <summary>
        /// Number of host baseline risks.
        /// </summary>
        [JsonProperty("HostBaseLineRiskTotal")]
        public long? HostBaseLineRiskTotal{ get; set; }

        /// <summary>
        /// Number of high-risk risks.
        /// </summary>
        [JsonProperty("HostBaseLineRiskHighLevel")]
        public long? HostBaseLineRiskHighLevel{ get; set; }

        /// <summary>
        /// Baseline risk count of the container.
        /// </summary>
        [JsonProperty("PodBaseLineRiskTotal")]
        public long? PodBaseLineRiskTotal{ get; set; }

        /// <summary>
        /// Number of high-risk baseline risks in the container.
        /// </summary>
        [JsonProperty("PodBaseLineRiskHighLevel")]
        public long? PodBaseLineRiskHighLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PortTotal", this.PortTotal);
            this.SetParamSimple(map, prefix + "PortHighLevel", this.PortHighLevel);
            this.SetParamSimple(map, prefix + "WeakPasswordTotal", this.WeakPasswordTotal);
            this.SetParamSimple(map, prefix + "WeakPasswordHighLevel", this.WeakPasswordHighLevel);
            this.SetParamSimple(map, prefix + "WebsiteTotal", this.WebsiteTotal);
            this.SetParamSimple(map, prefix + "WebsiteHighLevel", this.WebsiteHighLevel);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "VULTotal", this.VULTotal);
            this.SetParamSimple(map, prefix + "VULHighLevel", this.VULHighLevel);
            this.SetParamSimple(map, prefix + "CFGTotal", this.CFGTotal);
            this.SetParamSimple(map, prefix + "CFGHighLevel", this.CFGHighLevel);
            this.SetParamSimple(map, prefix + "ServerTotal", this.ServerTotal);
            this.SetParamSimple(map, prefix + "ServerHighLevel", this.ServerHighLevel);
            this.SetParamSimple(map, prefix + "HostBaseLineRiskTotal", this.HostBaseLineRiskTotal);
            this.SetParamSimple(map, prefix + "HostBaseLineRiskHighLevel", this.HostBaseLineRiskHighLevel);
            this.SetParamSimple(map, prefix + "PodBaseLineRiskTotal", this.PodBaseLineRiskTotal);
            this.SetParamSimple(map, prefix + "PodBaseLineRiskHighLevel", this.PodBaseLineRiskHighLevel);
        }
    }
}

