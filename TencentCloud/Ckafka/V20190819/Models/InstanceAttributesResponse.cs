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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAttributesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id.</p>.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Specifies the Name of the ckafka cluster instance.</p>.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Access point VIP list information.</p>.
        /// </summary>
        [JsonProperty("VipList")]
        public VipEntity[] VipList{ get; set; }

        /// <summary>
        /// <p>Virtual IP.</p>.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <P>Virtual port.</p>.
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// <P>Specifies the instance status. valid values: 0 (creating), 1 (running), 2 (deleting), 3 (deleted), 5 (isolated), 7 (upgrading), -1 (creation failed).</p>.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Instance bandwidth (unit: Mbps).</p>.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// <p>Specifies the instance storage size in GB.</p>.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <P>Specifies the availability zone.</p>.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>VPC ID. being empty indicates a basic network.</p>.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Specifies the subnet ID. being empty indicates the basic network.</p>.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <P>Specifies the instance health status. valid values: 1 (healthy), 2 (alarm), 3 (abnormal).</p>.
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// <P>Instance health information. currently shows disk utilization rate. maximum length is 256.</p>.
        /// </summary>
        [JsonProperty("HealthyMessage")]
        public string HealthyMessage{ get; set; }

        /// <summary>
        /// <P>Creation time.</p>.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <P>Message retention period, in minutes.</p>.
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// <p>Automatic creation Topic configuration. if this field is empty, it indicates that automatic creation is not enabled.</p>.
        /// </summary>
        [JsonProperty("Config")]
        public InstanceConfigDO Config{ get; set; }

        /// <summary>
        /// <P>Number of remaining creatable partitions.</p>.
        /// </summary>
        [JsonProperty("RemainderPartitions")]
        public long? RemainderPartitions{ get; set; }

        /// <summary>
        /// <P>Number of remaining creatable topics.</p>.
        /// </summary>
        [JsonProperty("RemainderTopics")]
        public long? RemainderTopics{ get; set; }

        /// <summary>
        /// <P>Specifies the current number of partitions created.</p>.
        /// </summary>
        [JsonProperty("CreatedPartitions")]
        public long? CreatedPartitions{ get; set; }

        /// <summary>
        /// <P>Specifies the current number of topics created.</p>.
        /// </summary>
        [JsonProperty("CreatedTopics")]
        public long? CreatedTopics{ get; set; }

        /// <summary>
        /// <P>Tag array.</p>.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <P>Specifies the expiration time.</p>.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// <P>Specifies the availability zone list.</p>.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <P>Specifies the ckafka cluster instance version.</p>.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <P>Specifies the maximum number of groups.</p>.
        /// </summary>
        [JsonProperty("MaxGroupNum")]
        public long? MaxGroupNum{ get; set; }

        /// <summary>
        /// <P>Sale type. 0: standard version; 1: pro edition.</p>.
        /// </summary>
        [JsonProperty("Cvm")]
        public long? Cvm{ get; set; }

        /// <summary>
        /// <p>Instance type. enumerates the list: profession: pro edition; standards2: standard version; premium: advanced edition; serverless: serverless edition.</p>.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Indicates the characteristics supported by the instance. FEATURE_SUBNET_ACL: indicates that the ACL policy supports setting subnets.</p>.
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// <P>Dynamic message retention policy.</p>.
        /// </summary>
        [JsonProperty("RetentionTimeConfig")]
        public DynamicRetentionTime RetentionTimeConfig{ get; set; }

        /// <summary>
        /// <P>Maximum number of connections.</p>.
        /// </summary>
        [JsonProperty("MaxConnection")]
        public ulong? MaxConnection{ get; set; }

        /// <summary>
        /// <P>Public network bandwidth.</p>.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// <P>Deprecated. no actual meaning.</p>.
        /// </summary>
        [JsonProperty("DeleteRouteTimestamp")]
        public string DeleteRouteTimestamp{ get; set; }

        /// <summary>
        /// <P>Number of remaining creatable partitions.</p>.
        /// </summary>
        [JsonProperty("RemainingPartitions")]
        public long? RemainingPartitions{ get; set; }

        /// <summary>
        /// <P>Number of remaining creatable topics.</p>.
        /// </summary>
        [JsonProperty("RemainingTopics")]
        public long? RemainingTopics{ get; set; }

        /// <summary>
        /// <P>Dynamic disk expansion policy.</p>.
        /// </summary>
        [JsonProperty("DynamicDiskConfig")]
        public DynamicDiskConfig DynamicDiskConfig{ get; set; }

        /// <summary>
        /// <P>Specifies the system maintenance time.</p>.
        /// </summary>
        [JsonProperty("SystemMaintenanceTime")]
        public string SystemMaintenanceTime{ get; set; }

        /// <summary>
        /// <P>Specifies the maximum size of instance level messages.</p>.
        /// </summary>
        [JsonProperty("MaxMessageByte")]
        public ulong? MaxMessageByte{ get; set; }

        /// <summary>
        /// <p>Specifies the instance billing type. POSTPAID_BY_HOUR: hourly billing; PREPAID: annual/monthly package.</p>.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Specifies whether to enable the elastic bandwidth allowlist. valid values: 1 (enabled), 0 (disabled).</p>.
        /// </summary>
        [JsonProperty("ElasticBandwidthSwitch")]
        public long? ElasticBandwidthSwitch{ get; set; }

        /// <summary>
        /// <P>Specifies the elastic bandwidth activation status. 1: elastic bandwidth is disabled; 16: enabling elastic bandwidth; 32: elastic bandwidth enabled successfully; 33: disabling elastic bandwidth; 34: elastic bandwidth disabled successfully; 64: failed to enable elastic bandwidth; 65: failed to disable elastic bandwidth.</p>.
        /// </summary>
        [JsonProperty("ElasticBandwidthOpenStatus")]
        public long? ElasticBandwidthOpenStatus{ get; set; }

        /// <summary>
        /// <p>ClusterType<br />CLOUD_IDC IDC cluster<br />CLOUD_CVM_SHARE CVM shared cluster<br />CLOUD_CVM_YUNTI YUNTI CVM cluster<br />CLOUD_CVM CVM cluster<br />CLOUD_CDC CDC cluster<br />CLOUD_EKS_TSE EKS cluster</p>.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <P>Specifies the number of free partitions.</p>.
        /// </summary>
        [JsonProperty("FreePartitionNumber")]
        public long? FreePartitionNumber{ get; set; }

        /// <summary>
        /// <P>Specifies the elastic bandwidth upper limit.</p>.
        /// </summary>
        [JsonProperty("ElasticFloatBandwidth")]
        public long? ElasticFloatBandwidth{ get; set; }

        /// <summary>
        /// <p>ssl custom certificate id. only returned for instance clusters with custom certificates.</p>.
        /// </summary>
        [JsonProperty("CustomCertId")]
        public string CustomCertId{ get; set; }

        /// <summary>
        /// <P>Specifies the default unclean.leader.election.enable configuration for cluster topics. valid values: 1 (enable), 0 (disable).</p>.
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// <P>Specifies the instance deletion protection switch. valid values: 1 (enabled), 0 (disabled).</p>.
        /// </summary>
        [JsonProperty("DeleteProtectionEnable")]
        public long? DeleteProtectionEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "VipList.", this.VipList);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "HealthyMessage", this.HealthyMessage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "RemainderPartitions", this.RemainderPartitions);
            this.SetParamSimple(map, prefix + "RemainderTopics", this.RemainderTopics);
            this.SetParamSimple(map, prefix + "CreatedPartitions", this.CreatedPartitions);
            this.SetParamSimple(map, prefix + "CreatedTopics", this.CreatedTopics);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "MaxGroupNum", this.MaxGroupNum);
            this.SetParamSimple(map, prefix + "Cvm", this.Cvm);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
            this.SetParamObj(map, prefix + "RetentionTimeConfig.", this.RetentionTimeConfig);
            this.SetParamSimple(map, prefix + "MaxConnection", this.MaxConnection);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "DeleteRouteTimestamp", this.DeleteRouteTimestamp);
            this.SetParamSimple(map, prefix + "RemainingPartitions", this.RemainingPartitions);
            this.SetParamSimple(map, prefix + "RemainingTopics", this.RemainingTopics);
            this.SetParamObj(map, prefix + "DynamicDiskConfig.", this.DynamicDiskConfig);
            this.SetParamSimple(map, prefix + "SystemMaintenanceTime", this.SystemMaintenanceTime);
            this.SetParamSimple(map, prefix + "MaxMessageByte", this.MaxMessageByte);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ElasticBandwidthSwitch", this.ElasticBandwidthSwitch);
            this.SetParamSimple(map, prefix + "ElasticBandwidthOpenStatus", this.ElasticBandwidthOpenStatus);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "FreePartitionNumber", this.FreePartitionNumber);
            this.SetParamSimple(map, prefix + "ElasticFloatBandwidth", this.ElasticFloatBandwidth);
            this.SetParamSimple(map, prefix + "CustomCertId", this.CustomCertId);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "DeleteProtectionEnable", this.DeleteProtectionEnable);
        }
    }
}

