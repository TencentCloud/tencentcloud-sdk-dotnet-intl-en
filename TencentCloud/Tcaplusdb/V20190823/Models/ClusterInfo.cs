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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Cluster data description language type, such as `PROTO`, `TDR`, or `MIX`
        /// </summary>
        [JsonProperty("IdlType")]
        public string IdlType{ get; set; }

        /// <summary>
        /// Network type
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// ID of the VPC instance with which a cluster is associated
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// ID of the subnet instance with which a cluster is associated
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Cluster password
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Password status
        /// </summary>
        [JsonProperty("PasswordStatus")]
        public string PasswordStatus{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter: access ID
        /// </summary>
        [JsonProperty("ApiAccessId")]
        public string ApiAccessId{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter: access address
        /// </summary>
        [JsonProperty("ApiAccessIp")]
        public string ApiAccessIp{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter: access port
        /// </summary>
        [JsonProperty("ApiAccessPort")]
        public long? ApiAccessPort{ get; set; }

        /// <summary>
        /// If the value of PasswordStatus is unmodifiable, it indicates that the old password has not expired. This field will display the expiration time of the old password; otherwise, the value is null.
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }

        /// <summary>
        /// TencentDB for TcaplusDB (TcaplusDB) SDK connection parameters, which are used to access the IPv6 address.
        /// </summary>
        [JsonProperty("ApiAccessIpv6")]
        public string ApiAccessIpv6{ get; set; }

        /// <summary>
        /// Cluster type. 0,1: shared cluster; 2: independent cluster.
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// Cluster status. 0: indicates normal operation; 1: indicates frozen isolation (usually due to arrears); 2: indicates to be recycled (usually when the user proactively triggers deletion); 3: pending release (indicating that resources occupied by this table can be released); 4: changing.
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// Read CU.
        /// </summary>
        [JsonProperty("ReadCapacityUnit")]
        public long? ReadCapacityUnit{ get; set; }

        /// <summary>
        /// Write CU.
        /// </summary>
        [JsonProperty("WriteCapacityUnit")]
        public long? WriteCapacityUnit{ get; set; }

        /// <summary>
        /// Disk capacity.
        /// </summary>
        [JsonProperty("DiskVolume")]
        public long? DiskVolume{ get; set; }

        /// <summary>
        /// Information about the dedicated server.
        /// </summary>
        [JsonProperty("ServerList")]
        public ServerDetailInfo[] ServerList{ get; set; }

        /// <summary>
        /// Information about the dedicated proxy server.
        /// </summary>
        [JsonProperty("ProxyList")]
        public ProxyDetailInfo[] ProxyList{ get; set; }

        /// <summary>
        /// Whether the cluster operation approval feature is enabled. Valid values: `0` (disabled), `1` (enabled)
        /// </summary>
        [JsonProperty("Censorship")]
        public long? Censorship{ get; set; }

        /// <summary>
        /// Approver UIN list.
        /// </summary>
        [JsonProperty("DbaUins")]
        public string[] DbaUins{ get; set; }

        /// <summary>
        /// Whether data subscription is enabled.
        /// </summary>
        [JsonProperty("DataFlowStatus")]
        public long? DataFlowStatus{ get; set; }

        /// <summary>
        /// Kafka information for data subscription.
        /// </summary>
        [JsonProperty("KafkaInfo")]
        public KafkaInfo KafkaInfo{ get; set; }

        /// <summary>
        /// Retention period for the Txh backup file of the cluster before expiration and deletion.
        /// </summary>
        [JsonProperty("TxhBackupExpireDay")]
        public ulong? TxhBackupExpireDay{ get; set; }

        /// <summary>
        /// Retention period for the Ulog backup file of the cluster before expiration and deletion.
        /// </summary>
        [JsonProperty("UlogBackupExpireDay")]
        public ulong? UlogBackupExpireDay{ get; set; }

        /// <summary>
        /// Whether the expiration policy for the Ulog backup file of the cluster is read-only. 0: UlogBackupExpire is read-only and cannot be modified; 1: UlogBackupExpire can be modified.
        /// </summary>
        [JsonProperty("IsReadOnlyUlogBackupExpireDay")]
        public ulong? IsReadOnlyUlogBackupExpireDay{ get; set; }

        /// <summary>
        /// restproxy status.
        /// </summary>
        [JsonProperty("RestProxyStatus")]
        public long? RestProxyStatus{ get; set; }

        /// <summary>
        /// Total number of shards in the cluster.
        /// </summary>
        [JsonProperty("ShardTotalNum")]
        public long? ShardTotalNum{ get; set; }

        /// <summary>
        /// Total number of used shards.
        /// </summary>
        [JsonProperty("ShardUsedNum")]
        public long? ShardUsedNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdlType", this.IdlType);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PasswordStatus", this.PasswordStatus);
            this.SetParamSimple(map, prefix + "ApiAccessId", this.ApiAccessId);
            this.SetParamSimple(map, prefix + "ApiAccessIp", this.ApiAccessIp);
            this.SetParamSimple(map, prefix + "ApiAccessPort", this.ApiAccessPort);
            this.SetParamSimple(map, prefix + "OldPasswordExpireTime", this.OldPasswordExpireTime);
            this.SetParamSimple(map, prefix + "ApiAccessIpv6", this.ApiAccessIpv6);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ReadCapacityUnit", this.ReadCapacityUnit);
            this.SetParamSimple(map, prefix + "WriteCapacityUnit", this.WriteCapacityUnit);
            this.SetParamSimple(map, prefix + "DiskVolume", this.DiskVolume);
            this.SetParamArrayObj(map, prefix + "ServerList.", this.ServerList);
            this.SetParamArrayObj(map, prefix + "ProxyList.", this.ProxyList);
            this.SetParamSimple(map, prefix + "Censorship", this.Censorship);
            this.SetParamArraySimple(map, prefix + "DbaUins.", this.DbaUins);
            this.SetParamSimple(map, prefix + "DataFlowStatus", this.DataFlowStatus);
            this.SetParamObj(map, prefix + "KafkaInfo.", this.KafkaInfo);
            this.SetParamSimple(map, prefix + "TxhBackupExpireDay", this.TxhBackupExpireDay);
            this.SetParamSimple(map, prefix + "UlogBackupExpireDay", this.UlogBackupExpireDay);
            this.SetParamSimple(map, prefix + "IsReadOnlyUlogBackupExpireDay", this.IsReadOnlyUlogBackupExpireDay);
            this.SetParamSimple(map, prefix + "RestProxyStatus", this.RestProxyStatus);
            this.SetParamSimple(map, prefix + "ShardTotalNum", this.ShardTotalNum);
            this.SetParamSimple(map, prefix + "ShardUsedNum", this.ShardUsedNum);
        }
    }
}

