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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Availability Zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// UID of the VPC where the instance resides
        /// </summary>
        [JsonProperty("VpcUid")]
        public string VpcUid{ get; set; }

        /// <summary>
        /// UID of the subnet where the instance resides
        /// </summary>
        [JsonProperty("SubnetUid")]
        public string SubnetUid{ get; set; }

        /// <summary>
        /// Instance status. `0`: Processing; `1`: Normal; `-1`: `Stopped`; `-2`: Being terminated; `-3`: Terminated; `2`: Initializing during the cluster creation.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// This parameter is not used on the global website
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Instance billing method. Valid values: POSTPAID_BY_HOUR (pay-as-you-go hourly); CDHPAID (billed based on CDH, i.e., only CDH is billed but not the instances on CDH)
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// This parameter is not used on the global website
        /// </summary>
        [JsonProperty("ChargePeriod")]
        public ulong? ChargePeriod{ get; set; }

        /// <summary>
        /// Node specification <li>ES.S1.SMALL2: 1-core 2 GB </li><li>ES.S1.MEDIUM4: 2-core 4 GB </li><li>ES.S1.MEDIUM8: 2-core 8 GB </li><li>ES.S1.LARGE16: 4-core 16 GB </li><li>ES.S1.2XLARGE32: 8-core 32 GB </li><li>ES.S1.4XLARGE32: 16-core 32 GB </li><li>ES.S1.4XLARGE64: 16-core 64 GB </li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// Number of CPU cores of the node
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// Node memory size in GB
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// Node disk type
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Node disk size in GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// ES domain name
        /// </summary>
        [JsonProperty("EsDomain")]
        public string EsDomain{ get; set; }

        /// <summary>
        /// ES VIP
        /// </summary>
        [JsonProperty("EsVip")]
        public string EsVip{ get; set; }

        /// <summary>
        /// ES port
        /// </summary>
        [JsonProperty("EsPort")]
        public ulong? EsPort{ get; set; }

        /// <summary>
        /// Kibana access URL
        /// </summary>
        [JsonProperty("KibanaUrl")]
        public string KibanaUrl{ get; set; }

        /// <summary>
        /// ES version number
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// ES configuration item
        /// </summary>
        [JsonProperty("EsConfig")]
        public string EsConfig{ get; set; }

        /// <summary>
        /// Kibana access control configuration
        /// </summary>
        [JsonProperty("EsAcl")]
        public EsAcl EsAcl{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time of the instance
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// This parameter is not used on the global website
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// Instance type (instance type identifier, which can be only 1 or 2 currently)
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// IK analyzer configuration
        /// </summary>
        [JsonProperty("IkConfig")]
        public EsDictionaryInfo IkConfig{ get; set; }

        /// <summary>
        /// Dedicated primary node configuration
        /// </summary>
        [JsonProperty("MasterNodeInfo")]
        public MasterNodeInfo MasterNodeInfo{ get; set; }

        /// <summary>
        /// Auto-backup to COS configuration
        /// </summary>
        [JsonProperty("CosBackup")]
        public CosBackup CosBackup{ get; set; }

        /// <summary>
        /// Whether to allow auto-backup to COS
        /// </summary>
        [JsonProperty("AllowCosBackup")]
        public bool? AllowCosBackup{ get; set; }

        /// <summary>
        /// List of tags owned by the instance
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// License type <li>oss: Open Source Edition </li><li>basic: Basic Edition </li><li>platinum: Platinum Edition </li>Default value: Platinum
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Whether it is a hot/warm cluster <li>true: yes </li><li>false: no</li>
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableHotWarmMode")]
        public bool? EnableHotWarmMode{ get; set; }

        /// <summary>
        /// Warm node specification <li>ES.S1.SMALL2: 1-core 2 GB </li><li>ES.S1.MEDIUM4: 2-core 4 GB </li><li>ES.S1.MEDIUM8: 2-core 8 GB </li><li>ES.S1.LARGE16: 4-core 16 GB </li><li>ES.S1.2XLARGE32: 8-core 32 GB </li><li>ES.S1.4XLARGE32: 16-core 32 GB </li><li>ES.S1.4XLARGE64: 16-core 64 GB </li>
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WarmNodeType")]
        public string WarmNodeType{ get; set; }

        /// <summary>
        /// Number of warm nodes
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WarmNodeNum")]
        public ulong? WarmNodeNum{ get; set; }

        /// <summary>
        /// Number of warm node CPU cores
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WarmCpuNum")]
        public ulong? WarmCpuNum{ get; set; }

        /// <summary>
        /// Warm node memory size (in GB)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WarmMemSize")]
        public ulong? WarmMemSize{ get; set; }

        /// <summary>
        /// Warm node disk type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WarmDiskType")]
        public string WarmDiskType{ get; set; }

        /// <summary>
        /// Warm node disk size (in GB)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WarmDiskSize")]
        public ulong? WarmDiskSize{ get; set; }

        /// <summary>
        /// Cluster node information list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// ES public IP address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EsPublicUrl")]
        public string EsPublicUrl{ get; set; }

        /// <summary>
        /// Multi-AZ network information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// Deployment mode <li>0: single-AZ </li><li>1: multi-AZ</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployMode")]
        public ulong? DeployMode{ get; set; }

        /// <summary>
        /// ES public access status <li>OPEN: enabled </li><li>CLOSE: disabled
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicAccess")]
        public string PublicAccess{ get; set; }

        /// <summary>
        /// ES public access control configuration
        /// </summary>
        [JsonProperty("EsPublicAcl")]
        public EsAcl EsPublicAcl{ get; set; }

        /// <summary>
        /// Kibana private IP address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KibanaPrivateUrl")]
        public string KibanaPrivateUrl{ get; set; }

        /// <summary>
        /// Kibana public access status <li>OPEN: enabled </li><li>CLOSE: disabled
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KibanaPublicAccess")]
        public string KibanaPublicAccess{ get; set; }

        /// <summary>
        /// Kibana private access status <li>OPEN: enabled </li><li>CLOSE: disabled
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KibanaPrivateAccess")]
        public string KibanaPrivateAccess{ get; set; }

        /// <summary>
        /// Whether to enable X-Pack security authentication in Basic Edition 6.8 (and above) <li>1: disabled </li><li>2: enabled</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityType")]
        public ulong? SecurityType{ get; set; }

        /// <summary>
        /// Scenario template type. 0: not enabled; 1: general scenario; 2: log scenario; 3: search scenario
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// Kibana configuration item.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KibanaConfig")]
        public string KibanaConfig{ get; set; }

        /// <summary>
        /// Kibana node information
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("KibanaNodeInfo")]
        public KibanaNodeInfo KibanaNodeInfo{ get; set; }

        /// <summary>
        /// Visual node configuration
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// JDK type. Valid values: `oracle`, `kona`
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Jdk")]
        public string Jdk{ get; set; }

        /// <summary>
        /// Cluster network communication protocol
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Security group ID
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// Cold node specification <li>ES.S1.SMALL2: 1-core 2 GB </li><li>ES.S1.MEDIUM4: 2-core 4 GB </li><li>ES.S1.MEDIUM8: 2-core 8 GB </li><li>ES.S1.LARGE16: 4-core 16 GB </li><li>ES.S1.2XLARGE32: 8-core 32 GB </li><li>ES.S1.4XLARGE32: 16-core 32 GB </li><li>ES.S1.4XLARGE64: 16-core 64 GB </li>
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColdNodeType")]
        public string ColdNodeType{ get; set; }

        /// <summary>
        /// Number of cold nodes
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColdNodeNum")]
        public ulong? ColdNodeNum{ get; set; }

        /// <summary>
        /// Number of cold node CPU cores
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColdCpuNum")]
        public ulong? ColdCpuNum{ get; set; }

        /// <summary>
        /// Cold node memory size (in GB)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColdMemSize")]
        public ulong? ColdMemSize{ get; set; }

        /// <summary>
        /// Cold node disk type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColdDiskType")]
        public string ColdDiskType{ get; set; }

        /// <summary>
        /// Cold node disk size (in GB)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColdDiskSize")]
        public ulong? ColdDiskSize{ get; set; }

        /// <summary>
        /// Frozen node specification <li>ES.S1.SMALL2: 1-core 2 GB </li><li>ES.S1.MEDIUM4: 2-core 4 GB </li><li>ES.S1.MEDIUM8: 2-core 8 GB </li><li>ES.S1.LARGE16: 4-core 16 GB </li><li>ES.S1.2XLARGE32: 8-core 32 GB </li><li>ES.S1.4XLARGE32: 16-core 32 GB </li><li>ES.S1.4XLARGE64: 16-core 64 GB </li>
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FrozenNodeType")]
        public string FrozenNodeType{ get; set; }

        /// <summary>
        /// Number of frozen nodes
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FrozenNodeNum")]
        public ulong? FrozenNodeNum{ get; set; }

        /// <summary>
        /// Number of frozen node CPU cores
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FrozenCpuNum")]
        public ulong? FrozenCpuNum{ get; set; }

        /// <summary>
        /// Frozen node memory size (GB)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FrozenMemSize")]
        public ulong? FrozenMemSize{ get; set; }

        /// <summary>
        /// Frozen node disk type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FrozenDiskType")]
        public string FrozenDiskType{ get; set; }

        /// <summary>
        /// Frozen node disk size (in GB)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FrozenDiskSize")]
        public ulong? FrozenDiskSize{ get; set; }

        /// <summary>
        /// Cluster health status. `-1`: Unknown; `0`: Green; `1`: Yellow; `2`: Red
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("HealthStatus")]
        public long? HealthStatus{ get; set; }

        /// <summary>
        /// Private URL of the HTTPS cluster
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EsPrivateUrl")]
        public string EsPrivateUrl{ get; set; }

        /// <summary>
        /// Private domain of the HTTPS cluster
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EsPrivateDomain")]
        public string EsPrivateDomain{ get; set; }

        /// <summary>
        /// Configuration set info of the cluster.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EsConfigSets")]
        public EsConfigSetInfo[] EsConfigSets{ get; set; }

        /// <summary>
        /// The maintenance time slot of the cluster
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDuration OperationDuration{ get; set; }

        /// <summary>
        /// Web node list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OptionalWebServiceInfos")]
        public OptionalWebServiceInfo[] OptionalWebServiceInfos{ get; set; }

        /// <summary>
        /// Autonomous index option
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoIndexEnabled")]
        public bool? AutoIndexEnabled{ get; set; }

        /// <summary>
        /// Whether the storage-computing separation feature is enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableHybridStorage")]
        public bool? EnableHybridStorage{ get; set; }

        /// <summary>
        /// The process progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessPercent")]
        public float? ProcessPercent{ get; set; }

        /// <summary>
        /// The alerting policy of Kibana over the public network. <li>`OPEN`: Enable the policy;</li><li>`CLOSE`: Disable the policy.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KibanaAlteringPublicAccess")]
        public string KibanaAlteringPublicAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "VpcUid", this.VpcUid);
            this.SetParamSimple(map, prefix + "SubnetUid", this.SubnetUid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ChargePeriod", this.ChargePeriod);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "EsDomain", this.EsDomain);
            this.SetParamSimple(map, prefix + "EsVip", this.EsVip);
            this.SetParamSimple(map, prefix + "EsPort", this.EsPort);
            this.SetParamSimple(map, prefix + "KibanaUrl", this.KibanaUrl);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "EsConfig", this.EsConfig);
            this.SetParamObj(map, prefix + "EsAcl.", this.EsAcl);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "IkConfig.", this.IkConfig);
            this.SetParamObj(map, prefix + "MasterNodeInfo.", this.MasterNodeInfo);
            this.SetParamObj(map, prefix + "CosBackup.", this.CosBackup);
            this.SetParamSimple(map, prefix + "AllowCosBackup", this.AllowCosBackup);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "EnableHotWarmMode", this.EnableHotWarmMode);
            this.SetParamSimple(map, prefix + "WarmNodeType", this.WarmNodeType);
            this.SetParamSimple(map, prefix + "WarmNodeNum", this.WarmNodeNum);
            this.SetParamSimple(map, prefix + "WarmCpuNum", this.WarmCpuNum);
            this.SetParamSimple(map, prefix + "WarmMemSize", this.WarmMemSize);
            this.SetParamSimple(map, prefix + "WarmDiskType", this.WarmDiskType);
            this.SetParamSimple(map, prefix + "WarmDiskSize", this.WarmDiskSize);
            this.SetParamArrayObj(map, prefix + "NodeInfoList.", this.NodeInfoList);
            this.SetParamSimple(map, prefix + "EsPublicUrl", this.EsPublicUrl);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "PublicAccess", this.PublicAccess);
            this.SetParamObj(map, prefix + "EsPublicAcl.", this.EsPublicAcl);
            this.SetParamSimple(map, prefix + "KibanaPrivateUrl", this.KibanaPrivateUrl);
            this.SetParamSimple(map, prefix + "KibanaPublicAccess", this.KibanaPublicAccess);
            this.SetParamSimple(map, prefix + "KibanaPrivateAccess", this.KibanaPrivateAccess);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "KibanaConfig", this.KibanaConfig);
            this.SetParamObj(map, prefix + "KibanaNodeInfo.", this.KibanaNodeInfo);
            this.SetParamObj(map, prefix + "WebNodeTypeInfo.", this.WebNodeTypeInfo);
            this.SetParamSimple(map, prefix + "Jdk", this.Jdk);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "ColdNodeType", this.ColdNodeType);
            this.SetParamSimple(map, prefix + "ColdNodeNum", this.ColdNodeNum);
            this.SetParamSimple(map, prefix + "ColdCpuNum", this.ColdCpuNum);
            this.SetParamSimple(map, prefix + "ColdMemSize", this.ColdMemSize);
            this.SetParamSimple(map, prefix + "ColdDiskType", this.ColdDiskType);
            this.SetParamSimple(map, prefix + "ColdDiskSize", this.ColdDiskSize);
            this.SetParamSimple(map, prefix + "FrozenNodeType", this.FrozenNodeType);
            this.SetParamSimple(map, prefix + "FrozenNodeNum", this.FrozenNodeNum);
            this.SetParamSimple(map, prefix + "FrozenCpuNum", this.FrozenCpuNum);
            this.SetParamSimple(map, prefix + "FrozenMemSize", this.FrozenMemSize);
            this.SetParamSimple(map, prefix + "FrozenDiskType", this.FrozenDiskType);
            this.SetParamSimple(map, prefix + "FrozenDiskSize", this.FrozenDiskSize);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "EsPrivateUrl", this.EsPrivateUrl);
            this.SetParamSimple(map, prefix + "EsPrivateDomain", this.EsPrivateDomain);
            this.SetParamArrayObj(map, prefix + "EsConfigSets.", this.EsConfigSets);
            this.SetParamObj(map, prefix + "OperationDuration.", this.OperationDuration);
            this.SetParamArrayObj(map, prefix + "OptionalWebServiceInfos.", this.OptionalWebServiceInfos);
            this.SetParamSimple(map, prefix + "AutoIndexEnabled", this.AutoIndexEnabled);
            this.SetParamSimple(map, prefix + "EnableHybridStorage", this.EnableHybridStorage);
            this.SetParamSimple(map, prefix + "ProcessPercent", this.ProcessPercent);
            this.SetParamSimple(map, prefix + "KibanaAlteringPublicAccess", this.KibanaAlteringPublicAccess);
        }
    }
}

