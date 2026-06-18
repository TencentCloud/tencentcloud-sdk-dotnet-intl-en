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

    public class CVMAssetVO : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset name.
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Asset type.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Protection status
        /// </summary>
        [JsonProperty("CWPStatus")]
        public ulong? CWPStatus{ get; set; }

        /// <summary>
        /// Asset creation time.
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Private IP.
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC Name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// App ID information
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Nickname.
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Availability zone
        /// </summary>
        [JsonProperty("AvailableArea")]
        public string AvailableArea{ get; set; }

        /// <summary>
        /// Core or Not
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Subnet Name
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// CWP Agent UUID.
        /// </summary>
        [JsonProperty("InstanceUuid")]
        public string InstanceUuid{ get; set; }

        /// <summary>
        /// CVM host UUID.
        /// </summary>
        [JsonProperty("InstanceQUuid")]
        public string InstanceQUuid{ get; set; }

        /// <summary>
        /// OS Name
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Partition
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// CPU Information
        /// </summary>
        [JsonProperty("CPUInfo")]
        public string CPUInfo{ get; set; }

        /// <summary>
        /// CPU Size
        /// </summary>
        [JsonProperty("CPUSize")]
        public ulong? CPUSize{ get; set; }

        /// <summary>
        /// CPU Load
        /// </summary>
        [JsonProperty("CPULoad")]
        public string CPULoad{ get; set; }

        /// <summary>
        /// Memory size.
        /// </summary>
        [JsonProperty("MemorySize")]
        public string MemorySize{ get; set; }

        /// <summary>
        /// Memory Load
        /// </summary>
        [JsonProperty("MemoryLoad")]
        public string MemoryLoad{ get; set; }

        /// <summary>
        /// Hard disk size.
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// Hard Disk Load
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// Number of Accounts
        /// </summary>
        [JsonProperty("AccountCount")]
        public string AccountCount{ get; set; }

        /// <summary>
        /// Number of Processes
        /// </summary>
        [JsonProperty("ProcessCount")]
        public string ProcessCount{ get; set; }

        /// <summary>
        /// Software application.
        /// </summary>
        [JsonProperty("AppCount")]
        public string AppCount{ get; set; }

        /// <summary>
        /// Listening port
        /// </summary>
        [JsonProperty("PortCount")]
        public ulong? PortCount{ get; set; }

        /// <summary>
        /// Network attack.
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// Network access.
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// Network Interception
        /// </summary>
        [JsonProperty("Intercept")]
        public ulong? Intercept{ get; set; }

        /// <summary>
        /// Inbound peak bandwidth.
        /// </summary>
        [JsonProperty("InBandwidth")]
        public string InBandwidth{ get; set; }

        /// <summary>
        /// Outbound peak bandwidth.
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public string OutBandwidth{ get; set; }

        /// <summary>
        /// Total inbound traffic.
        /// </summary>
        [JsonProperty("InFlow")]
        public string InFlow{ get; set; }

        /// <summary>
        /// Outbound cumulative traffic.
        /// </summary>
        [JsonProperty("OutFlow")]
        public string OutFlow{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Malicious outgoing request.
        /// </summary>
        [JsonProperty("NetWorkOut")]
        public ulong? NetWorkOut{ get; set; }

        /// <summary>
        /// Port risk.
        /// </summary>
        [JsonProperty("PortRisk")]
        public ulong? PortRisk{ get; set; }

        /// <summary>
        /// Vulnerability risk.
        /// </summary>
        [JsonProperty("VulnerabilityRisk")]
        public ulong? VulnerabilityRisk{ get; set; }

        /// <summary>
        /// Configuration risk.
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        public ulong? ConfigurationRisk{ get; set; }

        /// <summary>
        /// Scan Task Count
        /// </summary>
        [JsonProperty("ScanTask")]
        public ulong? ScanTask{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// memberId
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// Full OS Name
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// Risk service exposure.
        /// </summary>
        [JsonProperty("RiskExposure")]
        public long? RiskExposure{ get; set; }

        /// <summary>
        /// Simulated Attack Tool Status. 0 indicates not installed. 1 indicates installed. 2 indicates offline.
        /// </summary>
        [JsonProperty("BASAgentStatus")]
        public long? BASAgentStatus{ get; set; }

        /// <summary>
        /// 1-New Asset; 0-Not a New Asset
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// 0: not installed; 1: install; 2: installing.
        /// </summary>
        [JsonProperty("CVMAgentStatus")]
        public long? CVMAgentStatus{ get; set; }

        /// <summary>
        /// 1: enable 0: not enabled.
        /// </summary>
        [JsonProperty("CVMStatus")]
        public long? CVMStatus{ get; set; }

        /// <summary>
        /// 1: client installed 0: not installed 2: Agentless.
        /// </summary>
        [JsonProperty("DefenseModel")]
        public long? DefenseModel{ get; set; }

        /// <summary>
        /// 1: installed 0: not installed.
        /// </summary>
        [JsonProperty("TatStatus")]
        public long? TatStatus{ get; set; }

        /// <summary>
        /// cpu trend chart.
        /// </summary>
        [JsonProperty("CpuTrend")]
        public Element[] CpuTrend{ get; set; }

        /// <summary>
        /// Memory trend chart.
        /// </summary>
        [JsonProperty("MemoryTrend")]
        public Element[] MemoryTrend{ get; set; }

        /// <summary>
        /// 1: agent online 0: agent offline 2: host offline.
        /// </summary>
        [JsonProperty("AgentStatus")]
        public long? AgentStatus{ get; set; }

        /// <summary>
        /// Number of shutdowns this month.
        /// </summary>
        [JsonProperty("CloseDefenseCount")]
        public long? CloseDefenseCount{ get; set; }

        /// <summary>
        /// Running state.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Security group data.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Physical memory occupied KB.
        /// </summary>
        [JsonProperty("AgentMemRss")]
        public long? AgentMemRss{ get; set; }

        /// <summary>
        /// CPU utilization percentage.
        /// </summary>
        [JsonProperty("AgentCpuPer")]
        public float? AgentCpuPer{ get; set; }

        /// <summary>
        /// Actual appid belonging to cvm.
        /// </summary>
        [JsonProperty("RealAppid")]
        public long? RealAppid{ get; set; }

        /// <summary>
        /// Cloud asset type: 0: tencent cloud, 1: aws, 2: azure.
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// Host protection status enumeration.
        /// 0: not installed.
        /// Basic edition protection.
        /// 2: inclusive edition protection.
        /// 3: protection by pro edition.
        /// 4: ultimate edition protection.
        /// 5: offline.
        /// 6: shutdown.
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public long? ProtectStatus{ get; set; }

        /// <summary>
        /// Last offline time.
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "CVMAgentStatus", this.CVMAgentStatus);
            this.SetParamSimple(map, prefix + "CVMStatus", this.CVMStatus);
            this.SetParamSimple(map, prefix + "DefenseModel", this.DefenseModel);
            this.SetParamSimple(map, prefix + "TatStatus", this.TatStatus);
            this.SetParamArrayObj(map, prefix + "CpuTrend.", this.CpuTrend);
            this.SetParamArrayObj(map, prefix + "MemoryTrend.", this.MemoryTrend);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "CloseDefenseCount", this.CloseDefenseCount);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "AgentMemRss", this.AgentMemRss);
            this.SetParamSimple(map, prefix + "AgentCpuPer", this.AgentCpuPer);
            this.SetParamSimple(map, prefix + "RealAppid", this.RealAppid);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
        }
    }
}

