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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Availability Zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance version ("5.6.4", "6.4.3", "6.8.2", or "7.5.1")
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Access password, which must contain 8 to 16 characters, and include at least two of the following three types of characters: [a-z,A-Z], [0-9] and [-!@#$%&^*+=_:;,.?]
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Instance name, which can contain 1 to 50 English letters, Chinese characters, digits, dashes (-), or underscores (_)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Number of nodes (2-50)
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// Billing mode <li>POSTPAID_BY_HOUR: Pay-as-you-go hourly </li>Default value: POSTPAID_BY_HOUR
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// This parameter is not used on the global website
        /// </summary>
        [JsonProperty("ChargePeriod")]
        public ulong? ChargePeriod{ get; set; }

        /// <summary>
        /// This parameter is not used on the global website
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Node specification <li>ES.S1.SMALL2: 1-core 2 GB </li><li>ES.S1.MEDIUM4: 2-core 4 GB </li><li>ES.S1.MEDIUM8: 2-core 8 GB </li><li>ES.S1.LARGE16: 4-core 16 GB </li><li>ES.S1.2XLARGE32: 8-core 32 GB </li><li>ES.S1.4XLARGE32: 16-core 32 GB </li><li>ES.S1.4XLARGE64: 16-core 64 GB </li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Node storage type <li>CLOUD_SSD: SSD cloud storage </li><li>CLOUD_PREMIUM: premium cloud storage </li>Default value: CLOUD_SSD
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Node disk size in GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// This parameter is not used on the global website
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Whether to automatically use vouchers <li>0: No </li><li>1: Yes </li>Default value: 0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// List of voucher IDs (only one voucher can be specified at a time currently)
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Whether to create a dedicated primary node <li>true: yes </li><li>false: no </li>Default value: false
        /// </summary>
        [JsonProperty("EnableDedicatedMaster")]
        public bool? EnableDedicatedMaster{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Number of dedicated primary nodes (only 3 and 5 are supported. This value must be passed in if `EnableDedicatedMaster` is `true`)
        /// </summary>
        [JsonProperty("MasterNodeNum")]
        public ulong? MasterNodeNum{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Dedicated primary node type, which must be passed in if `EnableDedicatedMaster` is `true` <li>ES.S1.SMALL2: 1-core 2 GB</li><li>ES.S1.MEDIUM4: 2-core 4 GB</li><li>ES.S1.MEDIUM8: 2-core 8 GB</li><li>ES.S1.LARGE16: 4-core 16 GB</li><li>ES.S1.2XLARGE32: 8-core 32 GB</li><li>ES.S1.4XLARGE32: 16-core 32 GB</li><li>ES.S1.4XLARGE64: 16-core 64 GB</li>
        /// </summary>
        [JsonProperty("MasterNodeType")]
        public string MasterNodeType{ get; set; }

        /// <summary>
        /// This parameter has been disused. Please use `NodeInfoList`
        /// Dedicated primary node disk size in GB, which is optional. If passed in, it can only be 50 and cannot be customized currently
        /// </summary>
        [JsonProperty("MasterNodeDiskSize")]
        public ulong? MasterNodeDiskSize{ get; set; }

        /// <summary>
        /// ClusterName in the cluster configuration file, which is the instance ID by default and currently cannot be customized
        /// </summary>
        [JsonProperty("ClusterNameInConf")]
        public string ClusterNameInConf{ get; set; }

        /// <summary>
        /// Cluster deployment mode <li>0: single-AZ deployment </li><li>1: multi-AZ deployment </li>Default value: 0
        /// </summary>
        [JsonProperty("DeployMode")]
        public ulong? DeployMode{ get; set; }

        /// <summary>
        /// Details of AZs in multi-AZ deployment mode (which is required when DeployMode is 1)
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// License type <li>oss: Open Source Edition </li><li>basic: Basic Edition </li><li>platinum: Platinum Edition </li>Default value: Platinum
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Node information list, which is used to describe the specification information of various types of nodes in the cluster, such as node type, node quantity, node specification, disk type, and disk size
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// Node tag information list
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// Whether to enable X-Pack security authentication in Basic Edition 6.8 (and above) <li>1: disabled </li><li>2: enabled</li>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public ulong? BasicSecurityType{ get; set; }

        /// <summary>
        /// Scenario template type. 0: not enabled; 1: general; 2: log; 3: search
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }


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
        }
    }
}

