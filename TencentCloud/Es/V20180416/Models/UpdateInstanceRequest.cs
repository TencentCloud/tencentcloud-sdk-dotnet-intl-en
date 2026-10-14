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

    public class UpdateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name (1-50 English letters, Chinese characters, digits, hyphens -, or underscores _)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Abandoned. Please use NodeInfoList.
        /// Number of nodes (2-50).
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// ES configuration item (JSON format string)
        /// </summary>
        [JsonProperty("EsConfig")]
        public string EsConfig{ get; set; }

        /// <summary>
        /// Password of the default user elastic (8–16 characters, including at least two of the following: [a-z,A-Z], [0-9], and special characters [-!@#$%&^*+=_:;,.?])
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Public access policy for visualization components (Kibana and Cerebro)
        /// </summary>
        [JsonProperty("EsAcl")]
        public EsAcl EsAcl{ get; set; }

        /// <summary>
        /// Abandoned. Please use NodeInfoList.
        /// Disk size in GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Abandoned. Please use NodeInfoList.
        /// Node specification<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Abandoned. Please use NodeInfoList.
        /// Number of dedicated primary nodes (supports only 3 or 5)
        /// </summary>
        [JsonProperty("MasterNodeNum")]
        public ulong? MasterNodeNum{ get; set; }

        /// <summary>
        /// Abandoned. Please use NodeInfoList.
        /// Dedicated primary node specification<li>ES.S1.SMALL2: 1-core 2GB</li><li>ES.S1.MEDIUM4: 2-core 4GB</li><li>ES.S1.MEDIUM8: 2-core 8GB</li><li>ES.S1.LARGE16: 4-core 16GB</li><li>ES.S1.2XLARGE32: 8-core 32GB</li><li>ES.S1.4XLARGE32: 16-core 32GB</li><li>ES.S1.4XLARGE64: 16-core 64GB</li>
        /// </summary>
        [JsonProperty("MasterNodeType")]
        public string MasterNodeType{ get; set; }

        /// <summary>
        /// Abandoned. Please use NodeInfoList.
        /// Dedicated primary node disk size (in GB. The system default configuration is 50 GB. Customization is temporarily not supported.)
        /// </summary>
        [JsonProperty("MasterNodeDiskSize")]
        public ulong? MasterNodeDiskSize{ get; set; }

        /// <summary>
        /// Whether to force restart when updating the configuration <li>true: force restart</li><li>false: do not force restart</li>Currently, this needs to be set only when updating EsConfig. The default value is false.
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// COS auto backup information
        /// </summary>
        [JsonProperty("CosBackup")]
        public CosBackup CosBackup{ get; set; }

        /// <summary>
        /// Node information list. You can transmit only the node to be updated and its corresponding specification information. Supported operations include <li>modifying the count of a node type</li><li>modifying the node specification and disk size of a node type</li><li>adding a node type (you need to simultaneously specify the node type, count, specification, disk, and other information)</li>. You can perform only one of the above operations at a time, and the disk type cannot be modified.
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// Public access status of the ES cluster
        /// OPEN: enabled.
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("PublicAccess")]
        public string PublicAccess{ get; set; }

        /// <summary>
        /// Public network access control list
        /// </summary>
        [JsonProperty("EsPublicAcl")]
        public EsPublicAcl EsPublicAcl{ get; set; }

        /// <summary>
        /// Kibana public access status
        /// OPEN: enabled.
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("KibanaPublicAccess")]
        public string KibanaPublicAccess{ get; set; }

        /// <summary>
        /// Kibana internal access status
        /// OPEN: enabled.
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("KibanaPrivateAccess")]
        public string KibanaPrivateAccess{ get; set; }

        /// <summary>
        /// Turn on or off user authentication for the basic version of ES 6.8 and above
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public long? BasicSecurityType{ get; set; }

        /// <summary>
        /// Kibana private network port
        /// </summary>
        [JsonProperty("KibanaPrivatePort")]
        public ulong? KibanaPrivatePort{ get; set; }

        /// <summary>
        /// 0: Scale out via blue-green change without restarting the cluster (default) 1: Scale out by unmounting disks with a cluster rolling restart
        /// </summary>
        [JsonProperty("ScaleType")]
        public long? ScaleType{ get; set; }

        /// <summary>
        /// Multi-AZ deployment
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// Scenario template type. -1: not enabled. 1: common. 2: log. 3: search
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// Kibana configuration item (JSON format string)
        /// </summary>
        [JsonProperty("KibanaConfig")]
        public string KibanaConfig{ get; set; }

        /// <summary>
        /// Visualize node configuration
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// Switch to the new network architecture
        /// </summary>
        [JsonProperty("SwitchPrivateLink")]
        public string SwitchPrivateLink{ get; set; }

        /// <summary>
        /// Enable Cerebro
        /// </summary>
        [JsonProperty("EnableCerebro")]
        public bool? EnableCerebro{ get; set; }

        /// <summary>
        /// Cerebro public access status
        /// OPEN: enabled.
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("CerebroPublicAccess")]
        public string CerebroPublicAccess{ get; set; }

        /// <summary>
        /// Cerebro private network access status
        /// OPEN: enabled.
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("CerebroPrivateAccess")]
        public string CerebroPrivateAccess{ get; set; }

        /// <summary>
        /// Newly-added or modified configuration group information
        /// </summary>
        [JsonProperty("EsConfigSet")]
        public EsConfigSetInfo EsConfigSet{ get; set; }

        /// <summary>
        /// Maintenance time slot.
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDurationUpdated OperationDuration{ get; set; }

        /// <summary>
        /// Whether Alerting public network alert output is enabled:
        /// OPEN: enabled.
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("KibanaAlteringPublicAccess")]
        public string KibanaAlteringPublicAccess{ get; set; }

        /// <summary>
        /// Custom domain name of kibana on the private network
        /// </summary>
        [JsonProperty("KibanaPrivateDomain")]
        public string KibanaPrivateDomain{ get; set; }

        /// <summary>
        /// Custom domain name of cerebro on the private network
        /// </summary>
        [JsonProperty("CerebroPrivateDomain")]
        public string CerebroPrivateDomain{ get; set; }

        /// <summary>
        /// Change to an https cluster. http is selected by default.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Outbound access details of the node
        /// </summary>
        [JsonProperty("OutboundPublicAcls")]
        public OutboundPublicAcl[] OutboundPublicAcls{ get; set; }

        /// <summary>
        /// Outbound access operations of the node
        /// OPEN
        /// -CLOSE: disabled.
        /// </summary>
        [JsonProperty("OutboundPublicAccess")]
        public string OutboundPublicAccess{ get; set; }

        /// <summary>
        /// Parameter for delayed cvm launch
        /// </summary>
        [JsonProperty("CvmDelayOnlineTime")]
        public ulong? CvmDelayOnlineTime{ get; set; }

        /// <summary>
        /// Number of concurrent shard migrations
        /// </summary>
        [JsonProperty("ShardAllocationConcurrents")]
        public ulong? ShardAllocationConcurrents{ get; set; }

        /// <summary>
        /// Shard migration concurrency speed
        /// </summary>
        [JsonProperty("ShardAllocationBytes")]
        public ulong? ShardAllocationBytes{ get; set; }

        /// <summary>
        /// Read-write separation mode: -1: not enabled; 1: local read/write separation; 2: remote read/write separation.
        /// </summary>
        [JsonProperty("ReadWriteMode")]
        public long? ReadWriteMode{ get; set; }

        /// <summary>
        /// Whether to enable the placement group async task
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// Placement group async task maintenance time slot
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }

        /// <summary>
        /// Cluster protection: OPEN: enable, CLOSE: disable
        /// </summary>
        [JsonProperty("EnableDestroyProtection")]
        public string EnableDestroyProtection{ get; set; }

        /// <summary>
        /// Auto capacity expansion parameter
        /// </summary>
        [JsonProperty("AutoScaleDiskInfoList")]
        public AutoScaleDiskInfo[] AutoScaleDiskInfoList{ get; set; }

        /// <summary>
        /// Auto-expansion delete parameter
        /// </summary>
        [JsonProperty("AutoScaleDiskDeleteNodeTypeList")]
        public string[] AutoScaleDiskDeleteNodeTypeList{ get; set; }

        /// <summary>
        /// Other additional configuration, jvm or yml.
        /// </summary>
        [JsonProperty("OtherConfig")]
        public OtherConfig OtherConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "EsConfig", this.EsConfig);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamObj(map, prefix + "EsAcl.", this.EsAcl);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "MasterNodeNum", this.MasterNodeNum);
            this.SetParamSimple(map, prefix + "MasterNodeType", this.MasterNodeType);
            this.SetParamSimple(map, prefix + "MasterNodeDiskSize", this.MasterNodeDiskSize);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamObj(map, prefix + "CosBackup.", this.CosBackup);
            this.SetParamArrayObj(map, prefix + "NodeInfoList.", this.NodeInfoList);
            this.SetParamSimple(map, prefix + "PublicAccess", this.PublicAccess);
            this.SetParamObj(map, prefix + "EsPublicAcl.", this.EsPublicAcl);
            this.SetParamSimple(map, prefix + "KibanaPublicAccess", this.KibanaPublicAccess);
            this.SetParamSimple(map, prefix + "KibanaPrivateAccess", this.KibanaPrivateAccess);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "KibanaPrivatePort", this.KibanaPrivatePort);
            this.SetParamSimple(map, prefix + "ScaleType", this.ScaleType);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "KibanaConfig", this.KibanaConfig);
            this.SetParamObj(map, prefix + "WebNodeTypeInfo.", this.WebNodeTypeInfo);
            this.SetParamSimple(map, prefix + "SwitchPrivateLink", this.SwitchPrivateLink);
            this.SetParamSimple(map, prefix + "EnableCerebro", this.EnableCerebro);
            this.SetParamSimple(map, prefix + "CerebroPublicAccess", this.CerebroPublicAccess);
            this.SetParamSimple(map, prefix + "CerebroPrivateAccess", this.CerebroPrivateAccess);
            this.SetParamObj(map, prefix + "EsConfigSet.", this.EsConfigSet);
            this.SetParamObj(map, prefix + "OperationDuration.", this.OperationDuration);
            this.SetParamSimple(map, prefix + "KibanaAlteringPublicAccess", this.KibanaAlteringPublicAccess);
            this.SetParamSimple(map, prefix + "KibanaPrivateDomain", this.KibanaPrivateDomain);
            this.SetParamSimple(map, prefix + "CerebroPrivateDomain", this.CerebroPrivateDomain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "OutboundPublicAcls.", this.OutboundPublicAcls);
            this.SetParamSimple(map, prefix + "OutboundPublicAccess", this.OutboundPublicAccess);
            this.SetParamSimple(map, prefix + "CvmDelayOnlineTime", this.CvmDelayOnlineTime);
            this.SetParamSimple(map, prefix + "ShardAllocationConcurrents", this.ShardAllocationConcurrents);
            this.SetParamSimple(map, prefix + "ShardAllocationBytes", this.ShardAllocationBytes);
            this.SetParamSimple(map, prefix + "ReadWriteMode", this.ReadWriteMode);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
            this.SetParamSimple(map, prefix + "EnableDestroyProtection", this.EnableDestroyProtection);
            this.SetParamArrayObj(map, prefix + "AutoScaleDiskInfoList.", this.AutoScaleDiskInfoList);
            this.SetParamArraySimple(map, prefix + "AutoScaleDiskDeleteNodeTypeList.", this.AutoScaleDiskDeleteNodeTypeList);
            this.SetParamObj(map, prefix + "OtherConfig.", this.OtherConfig);
        }
    }
}

