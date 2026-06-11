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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageDenyRuleDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule Type. RULE_RISK: Risk; RULE_PRIVILEGE: Privilege
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Number of Effective Images
        /// </summary>
        [JsonProperty("EffectImageCount")]
        public long? EffectImageCount{ get; set; }

        /// <summary>
        /// Application to All Scanned Images. 0: Select All Images; 1: Custom Images
        /// </summary>
        [JsonProperty("IsEffectAllImage")]
        public long? IsEffectAllImage{ get; set; }

        /// <summary>
        /// Rule Effective Start Time
        /// </summary>
        [JsonProperty("EffectTime")]
        public string EffectTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("OperationUin")]
        public string OperationUin{ get; set; }

        /// <summary>
        /// Effective Status. IN_THE_TEST: Observing; IN_EFFECT: Effective
        /// </summary>
        [JsonProperty("EffectStatus")]
        public string EffectStatus{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("RuleDescription")]
        public string RuleDescription{ get; set; }

        /// <summary>
        /// Enable Status. 0: Enabled; 1: Disabled
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Vulnerability. 0: Not Selected; 1: Selected
        /// </summary>
        [JsonProperty("Vul")]
        public long? Vul{ get; set; }

        /// <summary>
        /// CVE ID
        /// </summary>
        [JsonProperty("CVEIDSet")]
        public string[] CVEIDSet{ get; set; }

        /// <summary>
        /// Component ID
        /// </summary>
        [JsonProperty("ComponentSet")]
        public string[] ComponentSet{ get; set; }

        /// <summary>
        /// Vulnerability category
        /// </summary>
        [JsonProperty("VulClassSet")]
        public string[] VulClassSet{ get; set; }

        /// <summary>
        /// Vulnerability level
        /// </summary>
        [JsonProperty("VulLevelSet")]
        public string[] VulLevelSet{ get; set; }

        /// <summary>
        /// vulnerability tag
        /// </summary>
        [JsonProperty("VulLabelSet")]
        public string[] VulLabelSet{ get; set; }

        /// <summary>
        /// Trojan. 0: Not Selected; 1: Selected
        /// </summary>
        [JsonProperty("Virus")]
        public long? Virus{ get; set; }

        /// <summary>
        /// Trojan MD5 List
        /// </summary>
        [JsonProperty("VirusMD5Set")]
        public string[] VirusMD5Set{ get; set; }

        /// <summary>
        /// Trojan Level
        /// </summary>
        [JsonProperty("VirusLevelSet")]
        public string[] VirusLevelSet{ get; set; }

        /// <summary>
        /// Virus name
        /// </summary>
        [JsonProperty("VirusName")]
        public string[] VirusName{ get; set; }

        /// <summary>
        /// Sensitive Information. 0: Not Selected; 1: Selected
        /// </summary>
        [JsonProperty("Risk")]
        public long? Risk{ get; set; }

        /// <summary>
        /// Sensitivity Level
        /// </summary>
        [JsonProperty("RiskLevelSet")]
        public string[] RiskLevelSet{ get; set; }

        /// <summary>
        /// Sensitive Information Classification
        /// </summary>
        [JsonProperty("RiskType")]
        public string[] RiskType{ get; set; }

        /// <summary>
        /// Privileged Startup. 0: Not Allowed; 1: Allowed
        /// </summary>
        [JsonProperty("PrivilegeRun")]
        public long? PrivilegeRun{ get; set; }

        /// <summary>
        /// Privilege type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivilegeDetail")]
        public string[] PrivilegeDetail{ get; set; }

        /// <summary>
        /// Image ID List
        /// </summary>
        [JsonProperty("EffectImageSet")]
        public string[] EffectImageSet{ get; set; }

        /// <summary>
        /// Effective After X Days
        /// </summary>
        [JsonProperty("EffectDay")]
        public ulong? EffectDay{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

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
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "EffectImageCount", this.EffectImageCount);
            this.SetParamSimple(map, prefix + "IsEffectAllImage", this.IsEffectAllImage);
            this.SetParamSimple(map, prefix + "EffectTime", this.EffectTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperationUin", this.OperationUin);
            this.SetParamSimple(map, prefix + "EffectStatus", this.EffectStatus);
            this.SetParamSimple(map, prefix + "RuleDescription", this.RuleDescription);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vul", this.Vul);
            this.SetParamArraySimple(map, prefix + "CVEIDSet.", this.CVEIDSet);
            this.SetParamArraySimple(map, prefix + "ComponentSet.", this.ComponentSet);
            this.SetParamArraySimple(map, prefix + "VulClassSet.", this.VulClassSet);
            this.SetParamArraySimple(map, prefix + "VulLevelSet.", this.VulLevelSet);
            this.SetParamArraySimple(map, prefix + "VulLabelSet.", this.VulLabelSet);
            this.SetParamSimple(map, prefix + "Virus", this.Virus);
            this.SetParamArraySimple(map, prefix + "VirusMD5Set.", this.VirusMD5Set);
            this.SetParamArraySimple(map, prefix + "VirusLevelSet.", this.VirusLevelSet);
            this.SetParamArraySimple(map, prefix + "VirusName.", this.VirusName);
            this.SetParamSimple(map, prefix + "Risk", this.Risk);
            this.SetParamArraySimple(map, prefix + "RiskLevelSet.", this.RiskLevelSet);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "PrivilegeRun", this.PrivilegeRun);
            this.SetParamArraySimple(map, prefix + "PrivilegeDetail.", this.PrivilegeDetail);
            this.SetParamArraySimple(map, prefix + "EffectImageSet.", this.EffectImageSet);
            this.SetParamSimple(map, prefix + "EffectDay", this.EffectDay);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

