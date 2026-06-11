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

    public class ClusterCheckItem : AbstractModel
    {
        
        /// <summary>
        /// Unique Check Item ID
        /// </summary>
        [JsonProperty("CheckItemId")]
        public long? CheckItemId{ get; set; }

        /// <summary>
        /// Name of the risk item
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Check Item Details
        /// </summary>
        [JsonProperty("ItemDetail")]
        public string ItemDetail{ get; set; }

        /// <summary>
        /// Threat Level: Serious, High, Medium, Hint
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Check Object and Risk Object: Runc, Kubelet, Containerd, and Pods
        /// </summary>
        [JsonProperty("RiskTarget")]
        public string RiskTarget{ get; set; }

        /// <summary>
        /// Risk Category. CVERisk: Vulnerability Risk; ConfigRisk: Configuration Risk
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// Risk Type of Check Item. PrivilegePromotion: Privilege Promotion; RefuseService: Refuse of Service; DirectoryEscape: Directory Traversal; UnauthorizedAccess: Unauthorized Access; PrivilegeAndAccessControl: Permission and Access Control Issues; SensitiveInfoLeak: Sensitive Information Leakage
        /// </summary>
        [JsonProperty("RiskAttribute")]
        public string RiskAttribute{ get; set; }

        /// <summary>
        /// Risk Characteristics Tag
        /// ExistEXP: With EXP
        /// ExistPOC: With POD
        /// NoNeedReboot: No Need of Reboot
        /// ServerRestart: Service Reboot
        /// RemoteInfoLeak: Remote Information Leakage
        /// RemoteRefuseService: Remote Refuse Service
        /// RemoteExploit: Remote Exploitation
        /// RemoteExecute: Remote Execution
        /// </summary>
        [JsonProperty("RiskProperty")]
        public string RiskProperty{ get; set; }

        /// <summary>
        /// CVE id
        /// </summary>
        [JsonProperty("CVENumber")]
        public string CVENumber{ get; set; }

        /// <summary>
        /// Disclosure time
        /// </summary>
        [JsonProperty("DiscoverTime")]
        public string DiscoverTime{ get; set; }

        /// <summary>
        /// Solution
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// CVSS Information, Used for Drawing
        /// </summary>
        [JsonProperty("CVSS")]
        public string CVSS{ get; set; }

        /// <summary>
        /// CVSS score
        /// </summary>
        [JsonProperty("CVSSScore")]
        public string CVSSScore{ get; set; }

        /// <summary>
        /// Reference link
        /// </summary>
        [JsonProperty("RelateLink")]
        public string RelateLink{ get; set; }

        /// <summary>
        /// Impact Type: Node or Workload
        /// </summary>
        [JsonProperty("AffectedType")]
        public string AffectedType{ get; set; }

        /// <summary>
        /// Affected Version Information
        /// </summary>
        [JsonProperty("AffectedVersion")]
        public string AffectedVersion{ get; set; }

        /// <summary>
        /// Number of Ignored Assets
        /// </summary>
        [JsonProperty("IgnoredAssetNum")]
        public long? IgnoredAssetNum{ get; set; }

        /// <summary>
        /// Whether to Ignore the Check Item
        /// </summary>
        [JsonProperty("IsIgnored")]
        public bool? IsIgnored{ get; set; }

        /// <summary>
        /// Affected Critique
        /// </summary>
        [JsonProperty("RiskAssessment")]
        public string RiskAssessment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckItemId", this.CheckItemId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ItemDetail", this.ItemDetail);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskTarget", this.RiskTarget);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "RiskAttribute", this.RiskAttribute);
            this.SetParamSimple(map, prefix + "RiskProperty", this.RiskProperty);
            this.SetParamSimple(map, prefix + "CVENumber", this.CVENumber);
            this.SetParamSimple(map, prefix + "DiscoverTime", this.DiscoverTime);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "CVSSScore", this.CVSSScore);
            this.SetParamSimple(map, prefix + "RelateLink", this.RelateLink);
            this.SetParamSimple(map, prefix + "AffectedType", this.AffectedType);
            this.SetParamSimple(map, prefix + "AffectedVersion", this.AffectedVersion);
            this.SetParamSimple(map, prefix + "IgnoredAssetNum", this.IgnoredAssetNum);
            this.SetParamSimple(map, prefix + "IsIgnored", this.IsIgnored);
            this.SetParamSimple(map, prefix + "RiskAssessment", this.RiskAssessment);
        }
    }
}

