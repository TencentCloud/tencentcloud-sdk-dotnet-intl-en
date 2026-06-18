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
        /// <p>Cloud vendor</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>Cloud account name</p>
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// <p>Cloud Account</p>
        /// </summary>
        [JsonProperty("CloudAccountId")]
        public string CloudAccountId{ get; set; }

        /// <summary>
        /// <p>Domain name</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>IP</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>Port or port range</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>Open</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Risk type</p>
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// <p>acl type</p>
        /// </summary>
        [JsonProperty("AclType")]
        public string AclType{ get; set; }

        /// <summary>
        /// <p>acl list</p>
        /// </summary>
        [JsonProperty("AclList")]
        public string AclList{ get; set; }

        /// <summary>
        /// <p>Asset ID</p>
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Asset type</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>Number of port services</p>
        /// </summary>
        [JsonProperty("PortServiceCount")]
        public ulong? PortServiceCount{ get; set; }

        /// <summary>
        /// <p>Number of high-risk ports</p>
        /// </summary>
        [JsonProperty("HighRiskPortServiceCount")]
        public ulong? HighRiskPortServiceCount{ get; set; }

        /// <summary>
        /// <p>Number of web applications</p>
        /// </summary>
        [JsonProperty("WebAppCount")]
        public ulong? WebAppCount{ get; set; }

        /// <summary>
        /// <p>Number of web applications at risk</p>
        /// </summary>
        [JsonProperty("RiskWebAppCount")]
        public ulong? RiskWebAppCount{ get; set; }

        /// <summary>
        /// <p>Number of weak passwords.</p>
        /// </summary>
        [JsonProperty("WeakPasswordCount")]
        public ulong? WeakPasswordCount{ get; set; }

        /// <summary>
        /// <p>Vulnerability count</p>
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// <p>First discovery time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Latest update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Instance Type Name</p>
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// <p>Open status</p>
        /// </summary>
        [JsonProperty("DisplayStatus")]
        public string DisplayStatus{ get; set; }

        /// <summary>
        /// <p>Port status</p>
        /// </summary>
        [JsonProperty("DisplayRiskType")]
        public string DisplayRiskType{ get; set; }

        /// <summary>
        /// <p>Scan task status</p>
        /// </summary>
        [JsonProperty("ScanTaskStatus")]
        public string ScanTaskStatus{ get; set; }

        /// <summary>
        /// <p>uuid</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>Whether a security check has been performed</p>
        /// </summary>
        [JsonProperty("HasScan")]
        public string HasScan{ get; set; }

        /// <summary>
        /// <p>Tenant ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Tenant ID string</p>
        /// </summary>
        [JsonProperty("AppIdStr")]
        public string AppIdStr{ get; set; }

        /// <summary>
        /// <p>Record ID</p>
        /// </summary>
        [JsonProperty("ExposureID")]
        public ulong? ExposureID{ get; set; }

        /// <summary>
        /// <p>Number of open ports</p>
        /// </summary>
        [JsonProperty("PortDetectCount")]
        public ulong? PortDetectCount{ get; set; }

        /// <summary>
        /// <p>Port exposure result</p>
        /// </summary>
        [JsonProperty("PortDetectResult")]
        public string PortDetectResult{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>Remark</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Number of risks to be governed</p>
        /// </summary>
        [JsonProperty("ToGovernedRiskCount")]
        public ulong? ToGovernedRiskCount{ get; set; }

        /// <summary>
        /// <p>Risk content to be governed</p>
        /// </summary>
        [JsonProperty("ToGovernedRiskContent")]
        public string ToGovernedRiskContent{ get; set; }

        /// <summary>
        /// <p>Type icon of asset</p>
        /// </summary>
        [JsonProperty("AssetTypeIconURL")]
        public string AssetTypeIconURL{ get; set; }

        /// <summary>
        /// <p>Asset type 3D icon</p>
        /// </summary>
        [JsonProperty("AssetTypeIconSolidURL")]
        public string AssetTypeIconSolidURL{ get; set; }


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
            this.SetParamSimple(map, prefix + "AssetTypeIconURL", this.AssetTypeIconURL);
            this.SetParamSimple(map, prefix + "AssetTypeIconSolidURL", this.AssetTypeIconSolidURL);
        }
    }
}

