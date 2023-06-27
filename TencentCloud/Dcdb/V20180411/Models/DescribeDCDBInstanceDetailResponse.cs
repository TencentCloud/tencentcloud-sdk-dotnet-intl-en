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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDCDBInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, such as dcdbt-7oaxtcb7.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance status. Valid values: `0` (creating), `1` (running task), `2` (running), `3` (uninitialized), `-1` (isolated).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Current status of the instance
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// Instance private IP address
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Private port of instance
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// Number of instance nodes. Valid values: `2` (1-source-1-replica), `3` (1-source-2-replica).
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// Instance region, such as ap-guangzhou.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance VPC ID, such as vpc-r9jr0de3.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID of an instance, such as subnet-6rqs61o2.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Public network status. Valid values: `0` (not enabled), `1` (enabled), `2` (disabled), `3`: (enabling), `4` (disabling).
        /// </summary>
        [JsonProperty("WanStatus")]
        public long? WanStatus{ get; set; }

        /// <summary>
        /// Domain name for public network access, which can be resolved by the public network.
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// Public IP address, which can be accessed over the public network.
        /// </summary>
        [JsonProperty("WanVip")]
        public string WanVip{ get; set; }

        /// <summary>
        /// Public network access port
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// Project ID of the instance
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Automatic renewal flag for an instance. Valid values: `0` (normal renewal), `1` (auto-renewal), `3` (no renewal upon expiration).
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Dedicated cluster ID
        /// </summary>
        [JsonProperty("ExclusterId")]
        public string ExclusterId{ get; set; }

        /// <summary>
        /// Billing mode. Valid values: `prepaid` (monthly subscription), `postpaid` (pay-as-you-go).
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Creation time of the instance in the format of 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Expiration time of the instance in the format of 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// Database version information
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// Whether the instance supports audit. Valid values: `1` (yes), `0` (no).
        /// </summary>
        [JsonProperty("IsAuditSupported")]
        public long? IsAuditSupported{ get; set; }

        /// <summary>
        /// Whether data encryption is supported for an instance. Valid values: `1` (yes), `0` (no).
        /// </summary>
        [JsonProperty("IsEncryptSupported")]
        public long? IsEncryptSupported{ get; set; }

        /// <summary>
        /// Instance machine model
        /// </summary>
        [JsonProperty("Machine")]
        public string Machine{ get; set; }

        /// <summary>
        /// Instance memory size in GB, which is the sum of the memory of all shards.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance disk storage size in GB, which is the sum of the disk size of all shards.
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Instance storage space utilization. It is calculated by dividing the sum of the used disk size of all shards by the total disk size of all shards.
        /// </summary>
        [JsonProperty("StorageUsage")]
        public float? StorageUsage{ get; set; }

        /// <summary>
        /// Size of log storage space in GB
        /// </summary>
        [JsonProperty("LogStorage")]
        public long? LogStorage{ get; set; }

        /// <summary>
        /// Product type ID
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// Source AZ
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// Replica AZ
        /// </summary>
        [JsonProperty("SlaveZones")]
        public string[] SlaveZones{ get; set; }

        /// <summary>
        /// Shard information
        /// </summary>
        [JsonProperty("Shards")]
        public ShardBriefInfo[] Shards{ get; set; }

        /// <summary>
        /// Private network IPv6 address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// Number of CPU cores of an instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Instance QPS
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// Database engine
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbEngine")]
        public string DbEngine{ get; set; }

        /// <summary>
        /// Whether IPv6 is supported.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public long? Ipv6Flag{ get; set; }

        /// <summary>
        /// Public IPv6 address, which can be accessed over the public network
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WanVipv6")]
        public string WanVipv6{ get; set; }

        /// <summary>
        /// Public network status. Valid values: `0` (not enabled), `1` (enabled), `2` (disabled), `3`: (enabling), `4` (disabling).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WanStatusIpv6")]
        public long? WanStatusIpv6{ get; set; }

        /// <summary>
        /// Public network IPv6 port
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WanPortIpv6")]
        public long? WanPortIpv6{ get; set; }

        /// <summary>
        /// Tag information
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// DCN type. Valid values: `0` (N/A), `1` (source instance), `2` (disaster recovery read-only instance)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DcnFlag")]
        public long? DcnFlag{ get; set; }

        /// <summary>
        /// DCN status. Valid values: `0` (N/A), `1` (creating), `2` (syncing), `3` (disconnected).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DcnStatus")]
        public long? DcnStatus{ get; set; }

        /// <summary>
        /// The number of DCN disaster recovery instances
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DcnDstNum")]
        public long? DcnDstNum{ get; set; }

        /// <summary>
        /// Instance type. Valid values: `1` (dedicated primary instance), `2` (non-dedicated primary instance), `3` (non-dedicated disaster recovery read-only instance), `4` (dedicated disaster recovery read-only instance)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// Whether the instance supports setting the connection limit, which is not supported for kernel version 10.1.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsMaxUserConnectionsSupported")]
        public bool? IsMaxUserConnectionsSupported{ get; set; }

        /// <summary>
        /// The displayed database version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// Encryption status. Valid values: `0` (disabled), `1` (enabled).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptStatus")]
        public long? EncryptStatus{ get; set; }

        /// <summary>
        /// Type of dedicated cluster. Valid values: `0` (public cloud), `1` (finance cage), `2` (CDC cluster).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExclusterType")]
        public long? ExclusterType{ get; set; }

        /// <summary>
        /// Nearby VPC access
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RsAccessStrategy")]
        public long? RsAccessStrategy{ get; set; }

        /// <summary>
        /// Unclaimed network resource
        /// </summary>
        [JsonProperty("ReservedNetResources")]
        public ReservedNetResource[] ReservedNetResources{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsPhysicalReplicationSupported")]
        public bool? IsPhysicalReplicationSupported{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanVip", this.WanVip);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ExclusterId", this.ExclusterId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "IsAuditSupported", this.IsAuditSupported);
            this.SetParamSimple(map, prefix + "IsEncryptSupported", this.IsEncryptSupported);
            this.SetParamSimple(map, prefix + "Machine", this.Machine);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageUsage", this.StorageUsage);
            this.SetParamSimple(map, prefix + "LogStorage", this.LogStorage);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamArraySimple(map, prefix + "SlaveZones.", this.SlaveZones);
            this.SetParamArrayObj(map, prefix + "Shards.", this.Shards);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "DbEngine", this.DbEngine);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "WanVipv6", this.WanVipv6);
            this.SetParamSimple(map, prefix + "WanStatusIpv6", this.WanStatusIpv6);
            this.SetParamSimple(map, prefix + "WanPortIpv6", this.WanPortIpv6);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DcnFlag", this.DcnFlag);
            this.SetParamSimple(map, prefix + "DcnStatus", this.DcnStatus);
            this.SetParamSimple(map, prefix + "DcnDstNum", this.DcnDstNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "IsMaxUserConnectionsSupported", this.IsMaxUserConnectionsSupported);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "EncryptStatus", this.EncryptStatus);
            this.SetParamSimple(map, prefix + "ExclusterType", this.ExclusterType);
            this.SetParamSimple(map, prefix + "RsAccessStrategy", this.RsAccessStrategy);
            this.SetParamArrayObj(map, prefix + "ReservedNetResources.", this.ReservedNetResources);
            this.SetParamSimple(map, prefix + "IsPhysicalReplicationSupported", this.IsPhysicalReplicationSupported);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

