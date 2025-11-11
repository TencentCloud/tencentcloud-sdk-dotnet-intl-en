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
        /// The ckafka cluster instance Id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the Name of the ckafka cluster instance.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// VIP list information of access point
        /// </summary>
        [JsonProperty("VipList")]
        public VipEntity[] VipList{ get; set; }

        /// <summary>
        /// Virtual IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Virtual port
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// Instance status. 0: creating, 1: running, 2: deleting, 3: deleted, 5: isolated, 7: upgrading, -1: creation failed.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Instance bandwidth in Mbps
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Instance storage capacity in GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// AZ
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// VPC ID. If this parameter is empty, it means the basic network
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID. If this parameter is empty, it means the basic network
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Instance health status. 1: healthy, 2: alarmed, 3: exceptional
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// Instance health information. Currently, the disk utilization is displayed with a maximum length of 256
        /// </summary>
        [JsonProperty("HealthyMessage")]
        public string HealthyMessage{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Message retention period in minutes
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// Configuration for automatic topic creation. If this field is empty, it means that automatic creation is not enabled
        /// </summary>
        [JsonProperty("Config")]
        public InstanceConfigDO Config{ get; set; }

        /// <summary>
        /// Number of remaining creatable partitions
        /// </summary>
        [JsonProperty("RemainderPartitions")]
        public long? RemainderPartitions{ get; set; }

        /// <summary>
        /// Number of remaining creatable topics
        /// </summary>
        [JsonProperty("RemainderTopics")]
        public long? RemainderTopics{ get; set; }

        /// <summary>
        /// Number of partitions already created
        /// </summary>
        [JsonProperty("CreatedPartitions")]
        public long? CreatedPartitions{ get; set; }

        /// <summary>
        /// Number of topics already created
        /// </summary>
        [JsonProperty("CreatedTopics")]
        public long? CreatedTopics{ get; set; }

        /// <summary>
        /// Tag array
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// Availability Zone List
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Specifies the ckafka cluster instance version.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Maximum number of groups.
        /// </summary>
        [JsonProperty("MaxGroupNum")]
        public long? MaxGroupNum{ get; set; }

        /// <summary>
        /// Sale type. valid values: 0 (standard version), 1 (pro edition).
        /// </summary>
        [JsonProperty("Cvm")]
        public long? Cvm{ get; set; }

        /// <summary>
        /// Instance type. valid values:. 
        /// Specifies the pro edition.    
        /// Standard version.
        /// premium. specifies the advanced edition.
        /// Specifies the serverless version.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Indicates the characteristics supported by the instance. FEATURE_SUBNET_ACL means the policy support for configuring subnets.
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// Dynamic message retention policy.
        /// </summary>
        [JsonProperty("RetentionTimeConfig")]
        public DynamicRetentionTime RetentionTimeConfig{ get; set; }

        /// <summary>
        /// Maximum number of connections.
        /// </summary>
        [JsonProperty("MaxConnection")]
        public ulong? MaxConnection{ get; set; }

        /// <summary>
        /// Public network bandwidth
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// Specifies the deprecated field with no actual meaning.
        /// </summary>
        [JsonProperty("DeleteRouteTimestamp")]
        public string DeleteRouteTimestamp{ get; set; }

        /// <summary>
        /// Number of remaining creatable partitions.
        /// </summary>
        [JsonProperty("RemainingPartitions")]
        public long? RemainingPartitions{ get; set; }

        /// <summary>
        /// Number of remaining creatable topics.
        /// </summary>
        [JsonProperty("RemainingTopics")]
        public long? RemainingTopics{ get; set; }

        /// <summary>
        /// Scaling policy for dynamic disk.
        /// </summary>
        [JsonProperty("DynamicDiskConfig")]
        public DynamicDiskConfig DynamicDiskConfig{ get; set; }

        /// <summary>
        /// Specifies the instance billing type. POSTPAID_BY_HOUR: hourly billing; PREPAID: annual/monthly package.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Whether to enable the elastic bandwidth allowlist.   
        /// Indicates the allowlist feature with elastic bandwidth enabled.
        /// 0: elastic bandwidth allowlist feature is disabled.
        /// </summary>
        [JsonProperty("ElasticBandwidthSwitch")]
        public long? ElasticBandwidthSwitch{ get; set; }

        /// <summary>
        /// Indicates the elastic bandwidth activation status.
        /// 1: indicates elastic bandwidth is disabled.
        /// Enable elastic bandwidth.
        /// Enable elastic bandwidth successfully.
        /// 33: disabling elastic bandwidth.
        /// Indicates that the elastic bandwidth is successfully disabled.
        /// Enable elastic bandwidth failed.
        /// Bandwidth failure.
        /// </summary>
        [JsonProperty("ElasticBandwidthOpenStatus")]
        public long? ElasticBandwidthOpenStatus{ get; set; }

        /// <summary>
        /// Cluster type.  
        /// CLOUD_IDC idc cluster.
        /// CLOUD_CVM_SHARE shared cluster.
        /// CLOUD_CVM_YUNTI yunti cvm cluster.
        /// CLOUD_CVM. specifies the cvm cluster.
        /// CLOUD_CDC cdc cluster.
        /// CLOUD_EKS_TSE eks cluster.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Number of free partitions.
        /// </summary>
        [JsonProperty("FreePartitionNumber")]
        public long? FreePartitionNumber{ get; set; }

        /// <summary>
        /// Specifies the elastic bandwidth upper limit.
        /// </summary>
        [JsonProperty("ElasticFloatBandwidth")]
        public long? ElasticFloatBandwidth{ get; set; }

        /// <summary>
        /// ssl custom certificate id. only returned for instance clusters with custom certificates.
        /// </summary>
        [JsonProperty("CustomCertId")]
        public string CustomCertId{ get; set; }

        /// <summary>
        /// Default unclean.leader.election.enable configuration for cluster topic: 1 enable 0 disable.
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// Instance deletion protection switch. 1: enabled; 0: disabled.
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

