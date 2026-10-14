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

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AZ.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Instance version (supported: "5.6.4", "6.4.3", "6.8.2", "7.5.1", "7.10.1")</p>
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Access password (8-16 characters, including at least two of the following: [a-z,A-Z], [0-9], and special characters in [-!@#$%&amp;^*+=_:;,.?])</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Instance name (1-50 English letters, Chinese characters, digits, hyphens -, or underscores _)</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Node quantity (2-50)</p>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>Billing type<li>PREPAID: prepaid, i.e., monthly subscription</li><li>POSTPAID_BY_HOUR: pay-as-you-go by hour</li>Default value: POSTPAID_BY_HOUR</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>Annual and monthly subscription duration (unit determined by the TimeUnit parameter)</p>
        /// </summary>
        [JsonProperty("ChargePeriod")]
        public ulong? ChargePeriod{ get; set; }

        /// <summary>
        /// <p>Auto-renewal flag<li>RENEW_FLAG_AUTO: auto renewal</li><li>RENEW_FLAG_MANUAL: no auto-renewal, user renews manually</li>This needs to be set when ChargeType is PREPAID. If this parameter is not passed, no automatic renewal by default for general users, and auto renewal for SVIP users</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Node specification<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li></p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Node disk type<li>CLOUD_SSD: ssd cloud disk</li><li>CLOUD_PREMIUM: high-performance cloud block storage</li><li>CLOUD_HSSD: enhanced SSD cloud disk</li><li>CLOUD_BSSD: universal type SSD cloud disk</li>Default value: CLOUD_SSD</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Node disk capacity (unit: GB)</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>Billing duration unit (needs to be set when ChargeType is PREPAID. Default value: "m", which means month. Currently only support "m")</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Indicates whether to use vouchers automatically<li>0: Do not use automatically.</li><li>1: Use automatically.</li>Default value: 0.</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>Voucher ID list. Only one voucher can be specified.</p>
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Whether to create a dedicated master node<li>true: enable a dedicated master node</li><li>false: disable a dedicated master node</li>Default value: false</p>
        /// </summary>
        [JsonProperty("EnableDedicatedMaster")]
        public bool? EnableDedicatedMaster{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Number of dedicated primary nodes (supports only 3 or 5. Required if EnableDedicatedMaster is true)</p>
        /// </summary>
        [JsonProperty("MasterNodeNum")]
        public ulong? MasterNodeNum{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Dedicated primary node type (required if EnableDedicatedMaster is true)<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li></p>
        /// </summary>
        [JsonProperty("MasterNodeType")]
        public string MasterNodeType{ get; set; }

        /// <summary>
        /// <p>Abandoned. Please use NodeInfoList<br>Dedicated primary node disk size (in GB, optional; if transmitted, it must be 50. Customization is not supported temporarily)</p>
        /// </summary>
        [JsonProperty("MasterNodeDiskSize")]
        public ulong? MasterNodeDiskSize{ get; set; }

        /// <summary>
        /// <p>ClusterName in the cluster configuration file (system default configuration is the instance ID, customization is not supported temporarily)</p>
        /// </summary>
        [JsonProperty("ClusterNameInConf")]
        public string ClusterNameInConf{ get; set; }

        /// <summary>
        /// <p>Cluster deployment method<li>0: single-AZ deployment</li><li>1: multi-AZ deployment, Beijing, Shanghai, Shanghai Finance, Guangzhou, Nanjing, Hong Kong, Singapore, Frankfurt (allowlist control)</li>Default value: 0</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public ulong? DeployMode{ get; set; }

        /// <summary>
        /// <p>Detailed information of availability zones in multi-AZ deployment (required when DeployMode is 1)</p>
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// <p>License type<li>oss: open source edition</li><li>basic: basic version</li><li>platinum: platinum version</li>Default value: platinum</p>
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// <p>Node information list, for description of the specification information of various types of nodes in the cluster, such as node type, number of nodes, node specification, disk type, and disk size</p>
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// <p>Node tag information list</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// <p>Whether xpack security authentication is enabled for basic version 6.8 (and above versions)<li>1: not enabled</li><li>2: enabled</li></p>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public ulong? BasicSecurityType{ get; set; }

        /// <summary>
        /// <p>Scenario template type 0: disabled 1: common 2: log 3: search</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// <p>Visualize node configuration</p>
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// <p>Create an https cluster. http is selected by default.</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>Maintenance time slot</p>
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDuration OperationDuration{ get; set; }

        /// <summary>
        /// <p>Whether storage-compute separation is enabled</p>
        /// </summary>
        [JsonProperty("EnableHybridStorage")]
        public bool? EnableHybridStorage{ get; set; }

        /// <summary>
        /// <p>Additional hard disk performance</p>
        /// </summary>
        [JsonProperty("DiskEnhance")]
        public ulong? DiskEnhance{ get; set; }

        /// <summary>
        /// <p>Whether intelligent check is enabled</p>
        /// </summary>
        [JsonProperty("EnableDiagnose")]
        public bool? EnableDiagnose{ get; set; }

        /// <summary>
        /// <p>Whether to enable automatic backup</p>
        /// </summary>
        [JsonProperty("EnableCosBackup")]
        public bool? EnableCosBackup{ get; set; }

        /// <summary>
        /// <p>cdcId, pass it when using a CDC subnet</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// <p>Placement group affinity. Value range: [0,10]. 0 indicates disabled.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupAffinity")]
        public ulong? DisasterRecoverGroupAffinity{ get; set; }

        /// <summary>
        /// <p>Enumeration values of sub-product ID: open source edition: "sp_es_io2", basic version: "sp_es_basic", platinum version: "sp_es_platinum", enterprise edition: "sp_es_enterprise", CDC platinum version: "sp_es_CDC_platinum", Log Enhancement Edition: "sp_es_enlogging", tsearch: "sp_tsearch_io2", logstash: "sp_es_logstash". It can be empty. When it is empty, the backend maps this field based on LicenseType.</p>
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// <p>Read-write separation mode: 0: not enabled; 1: local read/write separation; 2: remote read/write separation.</p>
        /// </summary>
        [JsonProperty("ReadWriteMode")]
        public long? ReadWriteMode{ get; set; }

        /// <summary>
        /// <p>Whether the placement group has asynchronous tasks enabled</p>
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// <p>Maintenance time slot for enabling async tasks in a placement group</p>
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }

        /// <summary>
        /// <p>Auto capacity expansion parameter list</p>
        /// </summary>
        [JsonProperty("AutoScaleDiskInfoList")]
        public AutoScaleDiskInfo[] AutoScaleDiskInfoList{ get; set; }

        /// <summary>
        /// <p>Whether to enable public network access to kibana. Enabled by default if not passed</p>
        /// </summary>
        [JsonProperty("EnableKibanaPublicAccess")]
        public string EnableKibanaPublicAccess{ get; set; }

        /// <summary>
        /// <p>Existing cloud monitoring and alarm policy ID</p>
        /// </summary>
        [JsonProperty("AlarmPolicyIds")]
        public string[] AlarmPolicyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ChargePeriod", this.ChargePeriod);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "EnableDedicatedMaster", this.EnableDedicatedMaster);
            this.SetParamSimple(map, prefix + "MasterNodeNum", this.MasterNodeNum);
            this.SetParamSimple(map, prefix + "MasterNodeType", this.MasterNodeType);
            this.SetParamSimple(map, prefix + "MasterNodeDiskSize", this.MasterNodeDiskSize);
            this.SetParamSimple(map, prefix + "ClusterNameInConf", this.ClusterNameInConf);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamArrayObj(map, prefix + "NodeInfoList.", this.NodeInfoList);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamObj(map, prefix + "WebNodeTypeInfo.", this.WebNodeTypeInfo);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "OperationDuration.", this.OperationDuration);
            this.SetParamSimple(map, prefix + "EnableHybridStorage", this.EnableHybridStorage);
            this.SetParamSimple(map, prefix + "DiskEnhance", this.DiskEnhance);
            this.SetParamSimple(map, prefix + "EnableDiagnose", this.EnableDiagnose);
            this.SetParamSimple(map, prefix + "EnableCosBackup", this.EnableCosBackup);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupAffinity", this.DisasterRecoverGroupAffinity);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "ReadWriteMode", this.ReadWriteMode);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
            this.SetParamArrayObj(map, prefix + "AutoScaleDiskInfoList.", this.AutoScaleDiskInfoList);
            this.SetParamSimple(map, prefix + "EnableKibanaPublicAccess", this.EnableKibanaPublicAccess);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyIds.", this.AlarmPolicyIds);
        }
    }
}

