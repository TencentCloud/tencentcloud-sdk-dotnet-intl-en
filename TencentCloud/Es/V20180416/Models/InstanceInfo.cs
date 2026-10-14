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
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>AZ.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>uid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>User UIN.</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>UID of the VPC to which the instance belongs</p>
        /// </summary>
        [JsonProperty("VpcUid")]
        public string VpcUid{ get; set; }

        /// <summary>
        /// <p>UID of the subnet to which the instance belongs</p>
        /// </summary>
        [JsonProperty("SubnetUid")]
        public string SubnetUid{ get; set; }

        /// <summary>
        /// <p>Instance status. 0: processing, 1: normal, -1: stopped, -2: being destroyed, -3: terminated, -4: isolated, 2: initializing when creating a cluster</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Auto-renewal flag. Value range: <br>RENEW_FLAG_AUTO: auto renewal<br>RENEW_FLAG_MANUAL: no auto-renewal<br>Default value: <br>RENEW_FLAG_DEFAULT: no auto-renewal<br>If this parameter is set to RENEW_FLAG_AUTO, the instance will automatically renew on a monthly basis after expiration if the account balance is sufficient.</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>Instance billing mode. Value ranges: PREPAID: prepaid mode, i.e., monthly subscription. POSTPAID_BY_HOUR: postpaid, i.e., pay-as-you-go. CDHPAID: CDH-paid mode, i.e., only charges for CDH, without charging for instances on CDH.</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>Annual and monthly subscription duration, unit: month</p>
        /// </summary>
        [JsonProperty("ChargePeriod")]
        public ulong? ChargePeriod{ get; set; }

        /// <summary>
        /// <p>Node specification<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li></p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Number of nodes</p>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>Number of node CPU cores.</p>
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// <p>Node memory size (GB).</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// <p>Node disk type</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Node disk size (GB).</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>ES domain name</p>
        /// </summary>
        [JsonProperty("EsDomain")]
        public string EsDomain{ get; set; }

        /// <summary>
        /// <p>ES VIP</p>
        /// </summary>
        [JsonProperty("EsVip")]
        public string EsVip{ get; set; }

        /// <summary>
        /// <p>ES port</p>
        /// </summary>
        [JsonProperty("EsPort")]
        public ulong? EsPort{ get; set; }

        /// <summary>
        /// <p>Kibana access url</p>
        /// </summary>
        [JsonProperty("KibanaUrl")]
        public string KibanaUrl{ get; set; }

        /// <summary>
        /// <p>ES version number</p>
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// <p>ES configuration item</p>
        /// </summary>
        [JsonProperty("EsConfig")]
        public string EsConfig{ get; set; }

        /// <summary>
        /// <p>Kibana Access Control Configuration</p>
        /// </summary>
        [JsonProperty("EsAcl")]
        public EsAcl EsAcl{ get; set; }

        /// <summary>
        /// <p>Instance creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last modification time of the instance</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Instance expiration time</p>
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// <p>Instance type (instance type flag, currently only 1 and 2)</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// <p>Ik analyzer configuration</p>
        /// </summary>
        [JsonProperty("IkConfig")]
        public EsDictionaryInfo IkConfig{ get; set; }

        /// <summary>
        /// <p>Dedicated master node configuration</p>
        /// </summary>
        [JsonProperty("MasterNodeInfo")]
        public MasterNodeInfo MasterNodeInfo{ get; set; }

        /// <summary>
        /// <p>cos automatic backup configuration</p>
        /// </summary>
        [JsonProperty("CosBackup")]
        public CosBackup CosBackup{ get; set; }

        /// <summary>
        /// <p>Whether cos automatic backup is allowed</p>
        /// </summary>
        [JsonProperty("AllowCosBackup")]
        public bool? AllowCosBackup{ get; set; }

        /// <summary>
        /// <p>Tag list of the instance</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// <p>License type<li>oss: open source edition</li><li>basic: basic version</li><li>platinum: platinum version</li>Default value: platinum</p>
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// <p>License type<li>oss: open source edition</li><li>basic: basic version</li><li>platinum: platinum version</li><li>enterprise: enterprise edition</li>Default value: platinum</p>
        /// </summary>
        [JsonProperty("RealLicenseType")]
        public string RealLicenseType{ get; set; }

        /// <summary>
        /// <p>Whether it is a hot-cold cluster<li>true: Hot-cold cluster</li><li>false: Non-hot-cold cluster</li></p>
        /// </summary>
        [JsonProperty("EnableHotWarmMode")]
        public bool? EnableHotWarmMode{ get; set; }

        /// <summary>
        /// <p>Warm node specification<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li></p>
        /// </summary>
        [JsonProperty("WarmNodeType")]
        public string WarmNodeType{ get; set; }

        /// <summary>
        /// <p>Number of warm nodes</p>
        /// </summary>
        [JsonProperty("WarmNodeNum")]
        public ulong? WarmNodeNum{ get; set; }

        /// <summary>
        /// <p>Warm node CPU cores</p>
        /// </summary>
        [JsonProperty("WarmCpuNum")]
        public ulong? WarmCpuNum{ get; set; }

        /// <summary>
        /// <p>Warm node memory size (GB).</p>
        /// </summary>
        [JsonProperty("WarmMemSize")]
        public ulong? WarmMemSize{ get; set; }

        /// <summary>
        /// <p>Warm node disk type</p>
        /// </summary>
        [JsonProperty("WarmDiskType")]
        public string WarmDiskType{ get; set; }

        /// <summary>
        /// <p>Warm node disk size (GB).</p>
        /// </summary>
        [JsonProperty("WarmDiskSize")]
        public ulong? WarmDiskSize{ get; set; }

        /// <summary>
        /// <p>Cluster node information list</p>
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// <p>Es public network address</p>
        /// </summary>
        [JsonProperty("EsPublicUrl")]
        public string EsPublicUrl{ get; set; }

        /// <summary>
        /// <p>Multi-AZ network info</p>
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// <p>Deployment mode<li>0: single availability zone</li><li>1: multi-availability zone, Beijing, Shanghai, Shanghai Finance, Guangzhou, Nanjing, Hong Kong, Singapore, Frankfurt (allowlist control)</li></p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public ulong? DeployMode{ get; set; }

        /// <summary>
        /// <p>ES public access status<li>OPEN: enable</li><li>CLOSE: disable</li></p>
        /// </summary>
        [JsonProperty("PublicAccess")]
        public string PublicAccess{ get; set; }

        /// <summary>
        /// <p>ES public network access control configuration</p>
        /// </summary>
        [JsonProperty("EsPublicAcl")]
        public EsAcl EsPublicAcl{ get; set; }

        /// <summary>
        /// <p>Kibana private network address</p>
        /// </summary>
        [JsonProperty("KibanaPrivateUrl")]
        public string KibanaPrivateUrl{ get; set; }

        /// <summary>
        /// <p>Kibana public access status<li>OPEN: enabled</li><li>CLOSE: disabled</li></p>
        /// </summary>
        [JsonProperty("KibanaPublicAccess")]
        public string KibanaPublicAccess{ get; set; }

        /// <summary>
        /// <p>Kibana internal access status<li>OPEN: enable</li><li>CLOSE: disable</li></p>
        /// </summary>
        [JsonProperty("KibanaPrivateAccess")]
        public string KibanaPrivateAccess{ get; set; }

        /// <summary>
        /// <p>Whether xpack security authentication is enabled for basic version 6.8 (and above versions)<li>1: not enabled</li><li>2: enabled</li></p>
        /// </summary>
        [JsonProperty("SecurityType")]
        public ulong? SecurityType{ get; set; }

        /// <summary>
        /// <p>Scenario template type: 0, not enabled; 1, common scenarios; 2, log scenario; 3, search scenario</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// <p>Kibana configuration item</p>
        /// </summary>
        [JsonProperty("KibanaConfig")]
        public string KibanaConfig{ get; set; }

        /// <summary>
        /// <p>Kibana node information</p>
        /// </summary>
        [JsonProperty("KibanaNodeInfo")]
        public KibanaNodeInfo KibanaNodeInfo{ get; set; }

        /// <summary>
        /// <p>Visualize node configuration</p>
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// <p>JDK type. Valid values: oracle, kona</p>
        /// </summary>
        [JsonProperty("Jdk")]
        public string Jdk{ get; set; }

        /// <summary>
        /// <p>Cluster network communication protocol</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>Security group id</p>
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// <p>Cold node specification<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li></p>
        /// </summary>
        [JsonProperty("ColdNodeType")]
        public string ColdNodeType{ get; set; }

        /// <summary>
        /// <p>Number of cold nodes</p>
        /// </summary>
        [JsonProperty("ColdNodeNum")]
        public ulong? ColdNodeNum{ get; set; }

        /// <summary>
        /// <p>Cold node CPU cores</p>
        /// </summary>
        [JsonProperty("ColdCpuNum")]
        public ulong? ColdCpuNum{ get; set; }

        /// <summary>
        /// <p>Cold node memory size (GB).</p>
        /// </summary>
        [JsonProperty("ColdMemSize")]
        public ulong? ColdMemSize{ get; set; }

        /// <summary>
        /// <p>Cold node disk type</p>
        /// </summary>
        [JsonProperty("ColdDiskType")]
        public string ColdDiskType{ get; set; }

        /// <summary>
        /// <p>Cold node disk size (GB).</p>
        /// </summary>
        [JsonProperty("ColdDiskSize")]
        public ulong? ColdDiskSize{ get; set; }

        /// <summary>
        /// <p>Frozen node specification<li>ES.S1.SMALL2: 1-core 2GB</li><li>ES.S1.MEDIUM4: 2-core 4GB</li><li>ES.S1.MEDIUM8: 2-core 8GB</li><li>ES.S1.LARGE16: 4-core 16GB</li><li>ES.S1.2XLARGE32: 8-core 32GB</li><li>ES.S1.4XLARGE32: 16-core 32GB</li><li>ES.S1.4XLARGE64: 16-core 64GB</li></p>
        /// </summary>
        [JsonProperty("FrozenNodeType")]
        public string FrozenNodeType{ get; set; }

        /// <summary>
        /// <p>Number of frozen nodes</p>
        /// </summary>
        [JsonProperty("FrozenNodeNum")]
        public ulong? FrozenNodeNum{ get; set; }

        /// <summary>
        /// <p>Frozen node CPU cores</p>
        /// </summary>
        [JsonProperty("FrozenCpuNum")]
        public ulong? FrozenCpuNum{ get; set; }

        /// <summary>
        /// <p>Frozen node memory size (GB).</p>
        /// </summary>
        [JsonProperty("FrozenMemSize")]
        public ulong? FrozenMemSize{ get; set; }

        /// <summary>
        /// <p>Frozen node disk type</p>
        /// </summary>
        [JsonProperty("FrozenDiskType")]
        public string FrozenDiskType{ get; set; }

        /// <summary>
        /// <p>Frozen node disk size (GB).</p>
        /// </summary>
        [JsonProperty("FrozenDiskSize")]
        public ulong? FrozenDiskSize{ get; set; }

        /// <summary>
        /// <p>Cluster health status: -1 unknown; 0 Green; 1 Yellow; 2 Red</p>
        /// </summary>
        [JsonProperty("HealthStatus")]
        public long? HealthStatus{ get; set; }

        /// <summary>
        /// <p>Intracluster network url for https.</p>
        /// </summary>
        [JsonProperty("EsPrivateUrl")]
        public string EsPrivateUrl{ get; set; }

        /// <summary>
        /// <p>https cluster private network domain name</p>
        /// </summary>
        [JsonProperty("EsPrivateDomain")]
        public string EsPrivateDomain{ get; set; }

        /// <summary>
        /// <p>Cluster configuration group information.</p>
        /// </summary>
        [JsonProperty("EsConfigSets")]
        public EsConfigSetInfo[] EsConfigSets{ get; set; }

        /// <summary>
        /// <p>Cluster maintenance time slot</p>
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDuration OperationDuration{ get; set; }

        /// <summary>
        /// <p>web node list</p>
        /// </summary>
        [JsonProperty("OptionalWebServiceInfos")]
        public OptionalWebServiceInfo[] OptionalWebServiceInfos{ get; set; }

        /// <summary>
        /// <p>Autonomous index switch</p>
        /// </summary>
        [JsonProperty("AutoIndexEnabled")]
        public bool? AutoIndexEnabled{ get; set; }

        /// <summary>
        /// <p>Whether storage and computation separation is supported.</p>
        /// </summary>
        [JsonProperty("EnableHybridStorage")]
        public bool? EnableHybridStorage{ get; set; }

        /// <summary>
        /// <p>Process progress.</p>
        /// </summary>
        [JsonProperty("ProcessPercent")]
        public float? ProcessPercent{ get; set; }

        /// <summary>
        /// <p>Kibana alerting public network alert policy<li>OPEN: enable</li><li>CLOSE: disable</li></p>
        /// </summary>
        [JsonProperty("KibanaAlteringPublicAccess")]
        public string KibanaAlteringPublicAccess{ get; set; }

        /// <summary>
        /// <p>Whether there is a kernel update this month: false (no) and true (yes).</p>
        /// </summary>
        [JsonProperty("HasKernelUpgrade")]
        public bool? HasKernelUpgrade{ get; set; }

        /// <summary>
        /// <p>cdcId, pass it when using a CDC subnet</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// <p>kibana intranet vip</p>
        /// </summary>
        [JsonProperty("KibanaPrivateVip")]
        public string KibanaPrivateVip{ get; set; }

        /// <summary>
        /// <p>Customize the private network url of kibana</p>
        /// </summary>
        [JsonProperty("CustomKibanaPrivateUrl")]
        public string CustomKibanaPrivateUrl{ get; set; }

        /// <summary>
        /// <p>Node outbound access detailed information.</p>
        /// </summary>
        [JsonProperty("OutboundPublicAcls")]
        public OutboundPublicAcl[] OutboundPublicAcls{ get; set; }

        /// <summary>
        /// <p>Network connection solution</p>
        /// </summary>
        [JsonProperty("NetConnectScheme")]
        public string NetConnectScheme{ get; set; }

        /// <summary>
        /// <p>Placement group related parameters</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupAffinity")]
        public ulong? DisasterRecoverGroupAffinity{ get; set; }

        /// <summary>
        /// <p>Sub-product ID enumeration values: open source edition: "sp_es_io2", basic version: "sp_es_basic", platinum version: "sp_es_platinum", AI Search Enhancement Edition: "sp_es_aisearch", enterprise edition: "sp_es_enterprise", CDC platinum version: "sp_es_CDC_platinum", Log Enhancement Edition: "sp_es_enlogging", tsearch: "sp_tsearch_io2", logstash: "sp_es_logstash". It can be empty. When it is empty, the backend maps this field based on LicenseType.</p>
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// <p>Storage-compute separation cos usage, Unit: M</p>
        /// </summary>
        [JsonProperty("CosBucketStorageSize")]
        public ulong? CosBucketStorageSize{ get; set; }

        /// <summary>
        /// <p>Read-write separation mode: 0: not enabled; 1: local read/write separation; 2: remote read/write separation.</p>
        /// </summary>
        [JsonProperty("ReadWriteMode")]
        public long? ReadWriteMode{ get; set; }

        /// <summary>
        /// <p>Whether there is an asynchronous task scheduling for placement groups</p>
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// <p>The time when an asynchronous task is scheduled</p>
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }

        /// <summary>
        /// <p>Cluster protection: OPEN: enable, CLOSE: disable</p>
        /// </summary>
        [JsonProperty("EnableDestroyProtection")]
        public string EnableDestroyProtection{ get; set; }

        /// <summary>
        /// <p>kibana intranet access address</p>
        /// </summary>
        [JsonProperty("ShowKibanaIpPort")]
        public string ShowKibanaIpPort{ get; set; }

        /// <summary>
        /// <p>Whether it is a CDZLite availability zone</p>
        /// </summary>
        [JsonProperty("IsCdzLite")]
        public bool? IsCdzLite{ get; set; }

        /// <summary>
        /// <p>Cluster private network tcp address</p>
        /// </summary>
        [JsonProperty("EsPrivateTcpUrl")]
        public string EsPrivateTcpUrl{ get; set; }

        /// <summary>
        /// <p>Whether it is in the recycle bin</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("IsInRecycleBin")]
        public bool? IsInRecycleBin{ get; set; }

        /// <summary>
        /// <p>Is locked in the recycle bin</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("RecycleLockEnabled")]
        public bool? RecycleLockEnabled{ get; set; }

        /// <summary>
        /// <p>The time when termination is expected</p><p>Parameter format: YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("MayDestroyPoint")]
        public string MayDestroyPoint{ get; set; }

        /// <summary>
        /// <p>The time when termination is delayed</p><p>Unit: day</p>
        /// </summary>
        [JsonProperty("DelayDestroyInterval")]
        public long? DelayDestroyInterval{ get; set; }

        /// <summary>
        /// <p>Enable automatic replacement of unhealthy nodes. 0: disable, 1: enable</p>
        /// </summary>
        [JsonProperty("EnableAutoReplace")]
        public long? EnableAutoReplace{ get; set; }

        /// <summary>
        /// <p>Enable mtls. 0: disable, 1: enable</p>
        /// </summary>
        [JsonProperty("OpenMTLS")]
        public ulong? OpenMTLS{ get; set; }

        /// <summary>
        /// <p>Certificate type</p>
        /// </summary>
        [JsonProperty("ServerCertSource")]
        public string ServerCertSource{ get; set; }

        /// <summary>
        /// <p>VIP pending migration for the cluster</p>
        /// </summary>
        [JsonProperty("OldEsVip")]
        public string OldEsVip{ get; set; }

        /// <summary>
        /// <p>Cluster TCP address to be migrated</p>
        /// </summary>
        [JsonProperty("OldEsPrivateTcpUrl")]
        public string OldEsPrivateTcpUrl{ get; set; }

        /// <summary>
        /// <p>Whether to take old nodes offline from the VIP</p>
        /// </summary>
        [JsonProperty("NeedOfflineOldNodesNotify")]
        public bool? NeedOfflineOldNodesNotify{ get; set; }


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
            this.SetParamSimple(map, prefix + "RealLicenseType", this.RealLicenseType);
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
            this.SetParamSimple(map, prefix + "HasKernelUpgrade", this.HasKernelUpgrade);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "KibanaPrivateVip", this.KibanaPrivateVip);
            this.SetParamSimple(map, prefix + "CustomKibanaPrivateUrl", this.CustomKibanaPrivateUrl);
            this.SetParamArrayObj(map, prefix + "OutboundPublicAcls.", this.OutboundPublicAcls);
            this.SetParamSimple(map, prefix + "NetConnectScheme", this.NetConnectScheme);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupAffinity", this.DisasterRecoverGroupAffinity);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "CosBucketStorageSize", this.CosBucketStorageSize);
            this.SetParamSimple(map, prefix + "ReadWriteMode", this.ReadWriteMode);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
            this.SetParamSimple(map, prefix + "EnableDestroyProtection", this.EnableDestroyProtection);
            this.SetParamSimple(map, prefix + "ShowKibanaIpPort", this.ShowKibanaIpPort);
            this.SetParamSimple(map, prefix + "IsCdzLite", this.IsCdzLite);
            this.SetParamSimple(map, prefix + "EsPrivateTcpUrl", this.EsPrivateTcpUrl);
            this.SetParamSimple(map, prefix + "IsInRecycleBin", this.IsInRecycleBin);
            this.SetParamSimple(map, prefix + "RecycleLockEnabled", this.RecycleLockEnabled);
            this.SetParamSimple(map, prefix + "MayDestroyPoint", this.MayDestroyPoint);
            this.SetParamSimple(map, prefix + "DelayDestroyInterval", this.DelayDestroyInterval);
            this.SetParamSimple(map, prefix + "EnableAutoReplace", this.EnableAutoReplace);
            this.SetParamSimple(map, prefix + "OpenMTLS", this.OpenMTLS);
            this.SetParamSimple(map, prefix + "ServerCertSource", this.ServerCertSource);
            this.SetParamSimple(map, prefix + "OldEsVip", this.OldEsVip);
            this.SetParamSimple(map, prefix + "OldEsPrivateTcpUrl", this.OldEsPrivateTcpUrl);
            this.SetParamSimple(map, prefix + "NeedOfflineOldNodesNotify", this.NeedOfflineOldNodesNotify);
        }
    }
}

