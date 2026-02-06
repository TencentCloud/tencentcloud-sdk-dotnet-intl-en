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

    public class VULBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// Risk level.
        /// High - high risk, middle - medium risk, low - low risk, info - Note.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Component.
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// Release date.
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Number of Affected Assets
        /// </summary>
        [JsonProperty("AffectAssetCount")]
        public ulong? AffectAssetCount{ get; set; }

        /// <summary>
        /// Risk ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// Vulnerability type.
        /// </summary>
        [JsonProperty("VULType")]
        public string VULType{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VULName")]
        public string VULName{ get; set; }

        /// <summary>
        /// cve
        /// </summary>
        [JsonProperty("CVE")]
        public string CVE{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Vulnerability Payload
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// Vulnerability impact component.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Technology reference.
        /// </summary>
        [JsonProperty("References")]
        public string References{ get; set; }

        /// <summary>
        /// Vulnerability impact version.
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// Risks.
        /// </summary>
        [JsonProperty("VULURL")]
        public string VULURL{ get; set; }

        /// <summary>
        /// User Nickname
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// User appid.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Fixing suggestion
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// Emergency Vulnerability Type. 1-Emergency Vulnerability; 0-Non-emergency Vulnerability.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EMGCVulType")]
        public long? EMGCVulType{ get; set; }

        /// <summary>
        /// CVSS score
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVSS")]
        public float? CVSS{ get; set; }

        /// <summary>
        /// Attack intensity.
        /// 0/1/2/3 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackHeat")]
        public long? AttackHeat{ get; set; }

        /// <summary>
        /// Detection status 0 unscanned 1 scan in progress 2 scan complete.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// 1/0 whether compulsory.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSuggest")]
        public long? IsSuggest{ get; set; }

        /// <summary>
        /// Tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulTag")]
        public string[] VulTag{ get; set; }

        /// <summary>
        /// Support products: "cfw_waf_virtual", "cwp_detect", "cwp_defense", "cwp_fix" (comma-separated).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportProduct")]
        public string SupportProduct{ get; set; }

        /// <summary>
        /// Vulnerability detection task id.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Primary key
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// Vulnerability id old version.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PcmgrID")]
        public string PcmgrID{ get; set; }

        /// <summary>
        /// Vulnerability id new version.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TvdID")]
        public string TvdID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "AffectAssetCount", this.AffectAssetCount);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "References", this.References);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "VULURL", this.VULURL);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "EMGCVulType", this.EMGCVulType);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "AttackHeat", this.AttackHeat);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamArraySimple(map, prefix + "VulTag.", this.VulTag);
            this.SetParamSimple(map, prefix + "SupportProduct", this.SupportProduct);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "PcmgrID", this.PcmgrID);
            this.SetParamSimple(map, prefix + "TvdID", this.TvdID);
        }
    }
}

