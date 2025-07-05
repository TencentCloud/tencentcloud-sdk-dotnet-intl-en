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
        /// Unique ID of the check item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckItemId")]
        public long? CheckItemId{ get; set; }

        /// <summary>
        /// Name of the risk item
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Detailed description of the check item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ItemDetail")]
        public string ItemDetail{ get; set; }

        /// <summary>
        /// Severity. Valid values: `Serious` (critical); `High` (high); `Middle` (medium); `Hint` (prompt).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Check target and risky target. Valid values: `Runc`, `Kubelet`, `Containerd`, `Pods`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskTarget")]
        public string RiskTarget{ get; set; }

        /// <summary>
        /// Risk type. Valid values: `CVERisk` (vulnerability risk); `ConfigRisk` (configuration risk).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// Risk type of the check item. Valid values: `PrivilegePromotion` (privilege escalation); `RefuseService` (service rejected); `DirectoryEscape` (directory traversal); `UnauthorizedAccess` (unauthorized access); `PrivilegeAndAccessControl` (permissions, privileges, and access controls); `SensitiveInfoLeak` (sensitive data leakage).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskAttribute")]
        public string RiskAttribute{ get; set; }

        /// <summary>
        /// Risk characteristic and tag. Valid values: `ExistEXP` (an EXP exists); `ExistPOC` (a POC exists); `NoNeedReboot` (restart not required); `ServerRestart` (service restart); `RemoteInfoLeak` (remote information leakage); `RemoteRefuseService` (remote denial of service); `RemoteExploit` (remote exploit); `RemoteExecute` (remote execution).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskProperty")]
        public string RiskProperty{ get; set; }

        /// <summary>
        /// CVE No.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVENumber")]
        public string CVENumber{ get; set; }

        /// <summary>
        /// Disclosure time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiscoverTime")]
        public string DiscoverTime{ get; set; }

        /// <summary>
        /// Solution
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// CVSS information, which is used for drawing.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVSS")]
        public string CVSS{ get; set; }

        /// <summary>
        /// CVSS score
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVSSScore")]
        public string CVSSScore{ get; set; }

        /// <summary>
        /// Reference link
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelateLink")]
        public string RelateLink{ get; set; }

        /// <summary>
        /// Affected type. Valid values: `Node`, `Workload`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AffectedType")]
        public string AffectedType{ get; set; }

        /// <summary>
        /// Affected version information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AffectedVersion")]
        public string AffectedVersion{ get; set; }

        /// <summary>
        /// Number of ignored assets
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoredAssetNum")]
        public long? IgnoredAssetNum{ get; set; }

        /// <summary>
        /// Whether to ignore the check item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsIgnored")]
        public bool? IsIgnored{ get; set; }

        /// <summary>
        /// Impact assessment
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

