/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CVMAssetVO : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Asset type
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Region
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Protection status
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CWPStatus")]
        public ulong? CWPStatus{ get; set; }

        /// <summary>
        /// Asset creation time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// App ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// User `uin`
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// User name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Availability zone
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailableArea")]
        public string AvailableArea{ get; set; }

        /// <summary>
        /// Whether it's a critical asset
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// Subnet ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Subnet name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// UUID of the instance
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceUuid")]
        public string InstanceUuid{ get; set; }

        /// <summary>
        /// QUuid of the instance
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceQUuid")]
        public string InstanceQUuid{ get; set; }

        /// <summary>
        /// OS name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Number of partitions
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// CPU information
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CPUInfo")]
        public string CPUInfo{ get; set; }

        /// <summary>
        /// CPU size
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CPUSize")]
        public ulong? CPUSize{ get; set; }

        /// <summary>
        /// CPU load
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CPULoad")]
        public string CPULoad{ get; set; }

        /// <summary>
        /// Memory size
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemorySize")]
        public string MemorySize{ get; set; }

        /// <summary>
        /// Memory load
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemoryLoad")]
        public string MemoryLoad{ get; set; }

        /// <summary>
        /// Disk size.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// Disk load
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// Number of accounts
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccountCount")]
        public string AccountCount{ get; set; }

        /// <summary>
        /// Number of processes
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessCount")]
        public string ProcessCount{ get; set; }

        /// <summary>
        /// Number of applications
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppCount")]
        public string AppCount{ get; set; }

        /// <summary>
        /// Number of listened ports.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PortCount")]
        public ulong? PortCount{ get; set; }

        /// <summary>
        /// Network attacks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// Network access
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// Network interception
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Intercept")]
        public ulong? Intercept{ get; set; }

        /// <summary>
        /// Inbound peak bandwidth
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InBandwidth")]
        public string InBandwidth{ get; set; }

        /// <summary>
        /// OutInbound peak bandwidth
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public string OutBandwidth{ get; set; }

        /// <summary>
        /// Total inbound traffic
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InFlow")]
        public string InFlow{ get; set; }

        /// <summary>
        /// Total outbound traffic
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutFlow")]
        public string OutFlow{ get; set; }

        /// <summary>
        /// Last scan time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Proactive malicious outgoing requests
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetWorkOut")]
        public ulong? NetWorkOut{ get; set; }

        /// <summary>
        /// Port risks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PortRisk")]
        public ulong? PortRisk{ get; set; }

        /// <summary>
        /// Vulnerabilities
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulnerabilityRisk")]
        public ulong? VulnerabilityRisk{ get; set; }

        /// <summary>
        /// Configuraiton risks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        public ulong? ConfigurationRisk{ get; set; }

        /// <summary>
        /// Number of scan tasks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanTask")]
        public ulong? ScanTask{ get; set; }

        /// <summary>
        /// Tags
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// Member ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// Full name of the operating system
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// Risk exposure
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskExposure")]
        public long? RiskExposure{ get; set; }

        /// <summary>
        /// BAS toolkit status. `0`: Not installed; `1`: Installed; `2`: Offline.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BASAgentStatus")]
        public long? BASAgentStatus{ get; set; }

        /// <summary>
        /// `1`: New asset; `0`: Not a new asset
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CWPStatus", this.CWPStatus);
            this.SetParamSimple(map, prefix + "AssetCreateTime", this.AssetCreateTime);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "AvailableArea", this.AvailableArea);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "InstanceUuid", this.InstanceUuid);
            this.SetParamSimple(map, prefix + "InstanceQUuid", this.InstanceQUuid);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "CPUInfo", this.CPUInfo);
            this.SetParamSimple(map, prefix + "CPUSize", this.CPUSize);
            this.SetParamSimple(map, prefix + "CPULoad", this.CPULoad);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "MemoryLoad", this.MemoryLoad);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskLoad", this.DiskLoad);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "ProcessCount", this.ProcessCount);
            this.SetParamSimple(map, prefix + "AppCount", this.AppCount);
            this.SetParamSimple(map, prefix + "PortCount", this.PortCount);
            this.SetParamSimple(map, prefix + "Attack", this.Attack);
            this.SetParamSimple(map, prefix + "Access", this.Access);
            this.SetParamSimple(map, prefix + "Intercept", this.Intercept);
            this.SetParamSimple(map, prefix + "InBandwidth", this.InBandwidth);
            this.SetParamSimple(map, prefix + "OutBandwidth", this.OutBandwidth);
            this.SetParamSimple(map, prefix + "InFlow", this.InFlow);
            this.SetParamSimple(map, prefix + "OutFlow", this.OutFlow);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "NetWorkOut", this.NetWorkOut);
            this.SetParamSimple(map, prefix + "PortRisk", this.PortRisk);
            this.SetParamSimple(map, prefix + "VulnerabilityRisk", this.VulnerabilityRisk);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "ScanTask", this.ScanTask);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "RiskExposure", this.RiskExposure);
            this.SetParamSimple(map, prefix + "BASAgentStatus", this.BASAgentStatus);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
        }
    }
}

