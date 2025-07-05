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

    public class AssetBaseInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// vpc-name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Asset name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Operating system
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// Public IP
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Private IP
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// Region
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Asset type
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Asset ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Total number of accounts
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccountNum")]
        public ulong? AccountNum{ get; set; }

        /// <summary>
        /// Number of ports
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PortNum")]
        public ulong? PortNum{ get; set; }

        /// <summary>
        /// Number of processes
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessNum")]
        public ulong? ProcessNum{ get; set; }

        /// <summary>
        /// Numbernumb of software applications
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SoftApplicationNum")]
        public ulong? SoftApplicationNum{ get; set; }

        /// <summary>
        /// Number of databases
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseNum")]
        public ulong? DatabaseNum{ get; set; }

        /// <summary>
        /// Number of web applications
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebApplicationNum")]
        public ulong? WebApplicationNum{ get; set; }

        /// <summary>
        /// Number of services
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceNum")]
        public ulong? ServiceNum{ get; set; }

        /// <summary>
        /// Number of web frameworks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebFrameworkNum")]
        public ulong? WebFrameworkNum{ get; set; }

        /// <summary>
        /// Number of websites
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebSiteNum")]
        public ulong? WebSiteNum{ get; set; }

        /// <summary>
        /// Number of JAR packages
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JarPackageNum")]
        public ulong? JarPackageNum{ get; set; }

        /// <summary>
        /// Number of enabled services
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartServiceNum")]
        public ulong? StartServiceNum{ get; set; }

        /// <summary>
        /// Number of scheduled tasks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduledTaskNum")]
        public ulong? ScheduledTaskNum{ get; set; }

        /// <summary>
        /// Number of environment variables
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentVariableNum")]
        public ulong? EnvironmentVariableNum{ get; set; }

        /// <summary>
        /// Number of kernel modules
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KernelModuleNum")]
        public ulong? KernelModuleNum{ get; set; }

        /// <summary>
        /// Number of system installation packages
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SystemInstallationPackageNum")]
        public ulong? SystemInstallationPackageNum{ get; set; }

        /// <summary>
        /// Remaining service validity in days
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SurplusProtectDay")]
        public ulong? SurplusProtectDay{ get; set; }

        /// <summary>
        /// Whether the CWPP agent is installed. Values: `1` (installed) and `0` (not installed)
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CWPStatus")]
        public ulong? CWPStatus{ get; set; }

        /// <summary>
        /// Tags
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// Protection level
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProtectLevel")]
        public string ProtectLevel{ get; set; }

        /// <summary>
        /// Usage of CWPP service in days
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProtectedDay")]
        public ulong? ProtectedDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AccountNum", this.AccountNum);
            this.SetParamSimple(map, prefix + "PortNum", this.PortNum);
            this.SetParamSimple(map, prefix + "ProcessNum", this.ProcessNum);
            this.SetParamSimple(map, prefix + "SoftApplicationNum", this.SoftApplicationNum);
            this.SetParamSimple(map, prefix + "DatabaseNum", this.DatabaseNum);
            this.SetParamSimple(map, prefix + "WebApplicationNum", this.WebApplicationNum);
            this.SetParamSimple(map, prefix + "ServiceNum", this.ServiceNum);
            this.SetParamSimple(map, prefix + "WebFrameworkNum", this.WebFrameworkNum);
            this.SetParamSimple(map, prefix + "WebSiteNum", this.WebSiteNum);
            this.SetParamSimple(map, prefix + "JarPackageNum", this.JarPackageNum);
            this.SetParamSimple(map, prefix + "StartServiceNum", this.StartServiceNum);
            this.SetParamSimple(map, prefix + "ScheduledTaskNum", this.ScheduledTaskNum);
            this.SetParamSimple(map, prefix + "EnvironmentVariableNum", this.EnvironmentVariableNum);
            this.SetParamSimple(map, prefix + "KernelModuleNum", this.KernelModuleNum);
            this.SetParamSimple(map, prefix + "SystemInstallationPackageNum", this.SystemInstallationPackageNum);
            this.SetParamSimple(map, prefix + "SurplusProtectDay", this.SurplusProtectDay);
            this.SetParamSimple(map, prefix + "CWPStatus", this.CWPStatus);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProtectLevel", this.ProtectLevel);
            this.SetParamSimple(map, prefix + "ProtectedDay", this.ProtectedDay);
        }
    }
}

