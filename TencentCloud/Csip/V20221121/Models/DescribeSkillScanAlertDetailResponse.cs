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

    public class DescribeSkillScanAlertDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Alarm record ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Tenant AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>Host UUID</p>
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// <p>Host IP address</p>
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// <p>Instance ID<br>Parameter format: such as ins-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Asset type affiliation<br>Enumeration values:<br>HOST: Host<br>CONTAINER: Container</p>
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// <p>Skill name</p>
        /// </summary>
        [JsonProperty("SkillName")]
        public string SkillName{ get; set; }

        /// <summary>
        /// <p>Skill file path</p>
        /// </summary>
        [JsonProperty("SkillPath")]
        public string SkillPath{ get; set; }

        /// <summary>
        /// <p>Skill application scope</p>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>Skill version number</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>SHA256 hash of file content<br>Parameter format: sha256:&lt;64-digit hex&gt;</p>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// <p>Risk level<br>Enumeration values:<br>malicious: Malicious<br>suspicious: Suspicious</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>Security score<br>Value range: [0, 100]</p>
        /// </summary>
        [JsonProperty("SecurityScore")]
        public long? SecurityScore{ get; set; }

        /// <summary>
        /// <p>Main matched rule ID</p>
        /// </summary>
        [JsonProperty("PrimaryRuleID")]
        public string PrimaryRuleID{ get; set; }

        /// <summary>
        /// <p>Detection engine version number</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public long? EngineVersion{ get; set; }

        /// <summary>
        /// <p>Processing status<br>Enumeration values:<br>0: unprocessed<br>1: processed<br>2: ignored<br>3: trusted</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Alarm level<br>Enumeration values:<br>high: High risk<br>medium: Medium risk</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>First detection time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Skill feature description (engine real-time query return)</p>
        /// </summary>
        [JsonProperty("SkillDescription")]
        public string SkillDescription{ get; set; }

        /// <summary>
        /// <p>Comprehensive risk abstract summarizing the primary risks/attack chains identified in this detection (query in real time via engine). Returns copywriting in English when Language=en-US is passed.</p>
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// <p>Handling suggestions (real-time query by engine)</p>
        /// </summary>
        [JsonProperty("Mitigation")]
        public string Mitigation{ get; set; }

        /// <summary>
        /// <p>Skill capacity tag list (returned by engine real-time query)</p>
        /// </summary>
        [JsonProperty("CapabilityTags")]
        public SkillCapabilityTag[] CapabilityTags{ get; set; }

        /// <summary>
        /// <p>Fusion rule directory list (returned by engine query in real time)</p>
        /// </summary>
        [JsonProperty("RuleCatalog")]
        public SkillRuleCatalogItem[] RuleCatalog{ get; set; }

        /// <summary>
        /// <p>Scan result details list (returned by engine query in real time)</p>
        /// </summary>
        [JsonProperty("ScanItems")]
        public SkillScanEngineResult[] ScanItems{ get; set; }

        /// <summary>
        /// <p>Detection report link (returned by real-time query from the engine)</p>
        /// </summary>
        [JsonProperty("ReportURL")]
        public string ReportURL{ get; set; }

        /// <summary>
        /// <p>Scan complete time (returned by the engine in real-time query)<br>Parameter format: ISO8601 format</p>
        /// </summary>
        [JsonProperty("ScannedAt")]
        public string ScannedAt{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamSimple(map, prefix + "SkillName", this.SkillName);
            this.SetParamSimple(map, prefix + "SkillPath", this.SkillPath);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "SecurityScore", this.SecurityScore);
            this.SetParamSimple(map, prefix + "PrimaryRuleID", this.PrimaryRuleID);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SkillDescription", this.SkillDescription);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "Mitigation", this.Mitigation);
            this.SetParamArrayObj(map, prefix + "CapabilityTags.", this.CapabilityTags);
            this.SetParamArrayObj(map, prefix + "RuleCatalog.", this.RuleCatalog);
            this.SetParamArrayObj(map, prefix + "ScanItems.", this.ScanItems);
            this.SetParamSimple(map, prefix + "ReportURL", this.ReportURL);
            this.SetParamSimple(map, prefix + "ScannedAt", this.ScannedAt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

