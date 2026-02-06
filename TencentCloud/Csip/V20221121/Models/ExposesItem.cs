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

    public class ExposesItem : AbstractModel
    {
        
        /// <summary>
        /// Cloud service provider.
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// Cloud account.
        /// </summary>
        [JsonProperty("CloudAccountId")]
        public string CloudAccountId{ get; set; }

        /// <summary>
        /// Domain
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Port or port range.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Open.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Risk type.
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// acl type.
        /// </summary>
        [JsonProperty("AclType")]
        public string AclType{ get; set; }

        /// <summary>
        /// ACL list.
        /// </summary>
        [JsonProperty("AclList")]
        public string AclList{ get; set; }

        /// <summary>
        /// Asset ID.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Asset type.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Port service quantity.
        /// </summary>
        [JsonProperty("PortServiceCount")]
        public ulong? PortServiceCount{ get; set; }

        /// <summary>
        /// Number of high-risk ports.
        /// </summary>
        [JsonProperty("HighRiskPortServiceCount")]
        public ulong? HighRiskPortServiceCount{ get; set; }

        /// <summary>
        /// Number of web applications.
        /// </summary>
        [JsonProperty("WebAppCount")]
        public ulong? WebAppCount{ get; set; }

        /// <summary>
        /// Number of web applications at risk.
        /// </summary>
        [JsonProperty("RiskWebAppCount")]
        public ulong? RiskWebAppCount{ get; set; }

        /// <summary>
        /// Number of Weak Passwords
        /// </summary>
        [JsonProperty("WeakPasswordCount")]
        public ulong? WeakPasswordCount{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// First detection time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Instance Type Name
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// Open status.
        /// </summary>
        [JsonProperty("DisplayStatus")]
        public string DisplayStatus{ get; set; }

        /// <summary>
        /// Port status.
        /// </summary>
        [JsonProperty("DisplayRiskType")]
        public string DisplayRiskType{ get; set; }

        /// <summary>
        /// Scan task status.
        /// </summary>
        [JsonProperty("ScanTaskStatus")]
        public string ScanTaskStatus{ get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Whether a security check has been performed.
        /// </summary>
        [JsonProperty("HasScan")]
        public string HasScan{ get; set; }

        /// <summary>
        /// Tenant ID.
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Tenant ID string.
        /// </summary>
        [JsonProperty("AppIdStr")]
        public string AppIdStr{ get; set; }

        /// <summary>
        /// Record ID
        /// </summary>
        [JsonProperty("ExposureID")]
        public ulong? ExposureID{ get; set; }

        /// <summary>
        /// Number of ports open.
        /// </summary>
        [JsonProperty("PortDetectCount")]
        public ulong? PortDetectCount{ get; set; }

        /// <summary>
        /// Port exposure result.
        /// </summary>
        [JsonProperty("PortDetectResult")]
        public string PortDetectResult{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Number of risks to be governed.
        /// </summary>
        [JsonProperty("ToGovernedRiskCount")]
        public ulong? ToGovernedRiskCount{ get; set; }

        /// <summary>
        /// Risk content to be governed.
        /// </summary>
        [JsonProperty("ToGovernedRiskContent")]
        public string ToGovernedRiskContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "CloudAccountName", this.CloudAccountName);
            this.SetParamSimple(map, prefix + "CloudAccountId", this.CloudAccountId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "AclType", this.AclType);
            this.SetParamSimple(map, prefix + "AclList", this.AclList);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PortServiceCount", this.PortServiceCount);
            this.SetParamSimple(map, prefix + "HighRiskPortServiceCount", this.HighRiskPortServiceCount);
            this.SetParamSimple(map, prefix + "WebAppCount", this.WebAppCount);
            this.SetParamSimple(map, prefix + "RiskWebAppCount", this.RiskWebAppCount);
            this.SetParamSimple(map, prefix + "WeakPasswordCount", this.WeakPasswordCount);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AssetTypeName", this.AssetTypeName);
            this.SetParamSimple(map, prefix + "DisplayStatus", this.DisplayStatus);
            this.SetParamSimple(map, prefix + "DisplayRiskType", this.DisplayRiskType);
            this.SetParamSimple(map, prefix + "ScanTaskStatus", this.ScanTaskStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "HasScan", this.HasScan);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppIdStr", this.AppIdStr);
            this.SetParamSimple(map, prefix + "ExposureID", this.ExposureID);
            this.SetParamSimple(map, prefix + "PortDetectCount", this.PortDetectCount);
            this.SetParamSimple(map, prefix + "PortDetectResult", this.PortDetectResult);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ToGovernedRiskCount", this.ToGovernedRiskCount);
            this.SetParamSimple(map, prefix + "ToGovernedRiskContent", this.ToGovernedRiskContent);
        }
    }
}

