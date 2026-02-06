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

    public class VULViewVULRiskData : AbstractModel
    {
        
        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Impact assets.
        /// </summary>
        [JsonProperty("NoHandleCount")]
        public long? NoHandleCount{ get; set; }

        /// <summary>
        /// Risk level: low - low risk, high - high risk, middle - medium risk, info - note, extreme - critical.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Component.
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// Latest Recognition Time
        /// </summary>
        [JsonProperty("RecentTime")]
        public string RecentTime{ get; set; }

        /// <summary>
        /// First Recognition Time
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

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
        /// Scan Source. See API Return Enumeration Type for details.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Front-end Index
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

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
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Emergency Vulnerability Type. 1-Emergency Vulnerability; 0-Non-emergency Vulnerability.
        /// </summary>
        [JsonProperty("EMGCVulType")]
        public long? EMGCVulType{ get; set; }

        /// <summary>
        /// CVSS score
        /// </summary>
        [JsonProperty("CVSS")]
        public float? CVSS{ get; set; }

        /// <summary>
        /// PCMGRId
        /// </summary>
        [JsonProperty("PCMGRId")]
        public string PCMGRId{ get; set; }

        /// <summary>
        /// Vulnerability tag. during searching, emergency mandatory parameter VulTag=SuggestRepair/EMGCVul.
        /// </summary>
        [JsonProperty("VulTag")]
        public string[] VulTag{ get; set; }

        /// <summary>
        /// Vulnerability disclosure time.
        /// </summary>
        [JsonProperty("DisclosureTime")]
        public string DisclosureTime{ get; set; }

        /// <summary>
        /// Attack intensity.
        /// </summary>
        [JsonProperty("AttackHeat")]
        public ulong? AttackHeat{ get; set; }

        /// <summary>
        /// Whether a mandatory vulnerability: 1 - yes; 0 - no.
        /// </summary>
        [JsonProperty("IsSuggest")]
        public long? IsSuggest{ get; set; }

        /// <summary>
        /// Disposal task id.
        /// </summary>
        [JsonProperty("HandleTaskId")]
        public string HandleTaskId{ get; set; }

        /// <summary>
        /// Engine source.
        /// </summary>
        [JsonProperty("EngineSource")]
        public string EngineSource{ get; set; }

        /// <summary>
        /// New vulnerability risk id.
        /// </summary>
        [JsonProperty("VulRiskId")]
        public string VulRiskId{ get; set; }

        /// <summary>
        /// New version vulnerability id.
        /// </summary>
        [JsonProperty("TvdID")]
        public string TvdID{ get; set; }

        /// <summary>
        /// Is it possible to perform a one-click physical examination. valid values: 1-yes, 0-not allowed.
        /// </summary>
        [JsonProperty("IsOneClick")]
        public ulong? IsOneClick{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "NoHandleCount", this.NoHandleCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "RecentTime", this.RecentTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "AffectAssetCount", this.AffectAssetCount);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "VULURL", this.VULURL);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "EMGCVulType", this.EMGCVulType);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "PCMGRId", this.PCMGRId);
            this.SetParamArraySimple(map, prefix + "VulTag.", this.VulTag);
            this.SetParamSimple(map, prefix + "DisclosureTime", this.DisclosureTime);
            this.SetParamSimple(map, prefix + "AttackHeat", this.AttackHeat);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "HandleTaskId", this.HandleTaskId);
            this.SetParamSimple(map, prefix + "EngineSource", this.EngineSource);
            this.SetParamSimple(map, prefix + "VulRiskId", this.VulRiskId);
            this.SetParamSimple(map, prefix + "TvdID", this.TvdID);
            this.SetParamSimple(map, prefix + "IsOneClick", this.IsOneClick);
        }
    }
}

