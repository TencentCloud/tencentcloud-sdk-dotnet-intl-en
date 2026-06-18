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

    public class AssetViewVULRiskData : AbstractModel
    {
        
        /// <summary>
        /// Impact assets.
        /// </summary>
        [JsonProperty("AffectAsset")]
        public string AffectAsset{ get; set; }

        /// <summary>
        /// Risk level: low - low risk, high - high risk, middle - medium risk, info - note, extreme - serious.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Asset type.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

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
        /// Status, 0 unprocessed, 1 tagged, 2 ignored, 3 processed, 4 under disposal, 5 detecting, 6 partially processed.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Risk ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// User appid.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User Nickname
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// User UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Vulnerability type.
        /// </summary>
        [JsonProperty("VULType")]
        public string VULType{ get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

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
        /// pocid
        /// </summary>
        [JsonProperty("POCId")]
        public string POCId{ get; set; }

        /// <summary>
        /// Scan Source
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Host version.
        /// </summary>
        [JsonProperty("CWPVersion")]
        public long? CWPVersion{ get; set; }

        /// <summary>
        /// Instance UUID
        /// </summary>
        [JsonProperty("InstanceUUID")]
        public string InstanceUUID{ get; set; }

        /// <summary>
        /// Payload
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

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
        /// Frontend index id.
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// pcmgrId
        /// </summary>
        [JsonProperty("PCMGRId")]
        public string PCMGRId{ get; set; }

        /// <summary>
        /// Report ID
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Vulnerability Tag.
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
        /// Whether the vulnerability is mandatory. 1 for yes, 0 for no.
        /// </summary>
        [JsonProperty("IsSuggest")]
        public long? IsSuggest{ get; set; }

        /// <summary>
        /// Disposal task ID.
        /// </summary>
        [JsonProperty("HandleTaskId")]
        public string HandleTaskId{ get; set; }

        /// <summary>
        /// Engine source.
        /// </summary>
        [JsonProperty("EngineSource")]
        public string EngineSource{ get; set; }

        /// <summary>
        /// New vulnerability risk id (same as RiskId in the network-wide vulnerabilities table).
        /// </summary>
        [JsonProperty("VulRiskId")]
        public string VulRiskId{ get; set; }

        /// <summary>
        /// New version vulnerability id.
        /// </summary>
        [JsonProperty("TvdID")]
        public string TvdID{ get; set; }

        /// <summary>
        /// Is it possible to perform a one-click physical examination, 1 - yes, 0 - not allowed.
        /// </summary>
        [JsonProperty("IsOneClick")]
        public ulong? IsOneClick{ get; set; }

        /// <summary>
        /// Whether to perform a POC scan. valid values: 0 (not a POC), 1 (POC).
        /// </summary>
        [JsonProperty("IsPOC")]
        public ulong? IsPOC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AffectAsset", this.AffectAsset);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "RecentTime", this.RecentTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "VULURL", this.VULURL);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamSimple(map, prefix + "POCId", this.POCId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "CWPVersion", this.CWPVersion);
            this.SetParamSimple(map, prefix + "InstanceUUID", this.InstanceUUID);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "EMGCVulType", this.EMGCVulType);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "PCMGRId", this.PCMGRId);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "VulTag.", this.VulTag);
            this.SetParamSimple(map, prefix + "DisclosureTime", this.DisclosureTime);
            this.SetParamSimple(map, prefix + "AttackHeat", this.AttackHeat);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "HandleTaskId", this.HandleTaskId);
            this.SetParamSimple(map, prefix + "EngineSource", this.EngineSource);
            this.SetParamSimple(map, prefix + "VulRiskId", this.VulRiskId);
            this.SetParamSimple(map, prefix + "TvdID", this.TvdID);
            this.SetParamSimple(map, prefix + "IsOneClick", this.IsOneClick);
            this.SetParamSimple(map, prefix + "IsPOC", this.IsPOC);
        }
    }
}

