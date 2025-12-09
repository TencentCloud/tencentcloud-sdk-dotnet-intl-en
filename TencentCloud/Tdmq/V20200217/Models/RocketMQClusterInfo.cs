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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RocketMQClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Region information
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Creation time in milliseconds
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Cluster remarks
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Public network access address
        /// </summary>
        [JsonProperty("PublicEndPoint")]
        public string PublicEndPoint{ get; set; }

        /// <summary>
        /// VPC access address
        /// </summary>
        [JsonProperty("VpcEndPoint")]
        public string VpcEndPoint{ get; set; }

        /// <summary>
        /// Whether the namespace access point is supported.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportNamespaceEndpoint")]
        public bool? SupportNamespaceEndpoint{ get; set; }

        /// <summary>
        /// VPC Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Vpcs")]
        public VpcConfig[] Vpcs{ get; set; }

        /// <summary>
        /// Whether it is an exclusive instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// TDMQ for RocketMQ cluster type flag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RocketMQFlag")]
        public bool? RocketMQFlag{ get; set; }

        /// <summary>
        /// Billing status (`1`: Normal; `2`: Service suspended; `3`: Terminated)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Service suspension time in milliseconds
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolateTime")]
        public long? IsolateTime{ get; set; }

        /// <summary>
        /// HTTP-based public network access address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpPublicEndpoint")]
        public string HttpPublicEndpoint{ get; set; }

        /// <summary>
        /// HTTP-based VPC access address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpVpcEndpoint")]
        public string HttpVpcEndpoint{ get; set; }

        /// <summary>
        /// Internal TCP access address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InternalEndpoint")]
        public string InternalEndpoint{ get; set; }

        /// <summary>
        /// Internal HTTP access address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpInternalEndpoint")]
        public string HttpInternalEndpoint{ get; set; }

        /// <summary>
        /// Whether to enable ACL authentication. For Exclusive Edition instances, ACL authentication can be disabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AclEnabled")]
        public bool? AclEnabled{ get; set; }

        /// <summary>
        /// Public network CLB instance ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicClbId")]
        public string PublicClbId{ get; set; }

        /// <summary>
        /// vip
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Specifies the VPC it belongs to.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Whether migration is supported.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportMigration")]
        public bool? SupportMigration{ get; set; }

        /// <summary>
        /// Instance status:
        /// 0: Creating
        /// 1: Normal
        /// 2: Isolating
        /// 3: Destroyed
        /// 4: Abnormal
        /// 5: Deliver failed
        /// 6: Changing the configuration
        /// 7: Configuration change failed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// Indicates the AZ to which the cluster belongs.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// The AZ where the cluster nodes are located. If the cluster is a cross-AZ cluster, it includes multiple AZs where the cluster nodes are located.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Whether it is frozen.
        /// </summary>
        [JsonProperty("IsFrozen")]
        public bool? IsFrozen{ get; set; }

        /// <summary>
        /// Whether to enable automatic topic creation.
        /// </summary>
        [JsonProperty("AutoCreateTopicEnabled")]
        public bool? AutoCreateTopicEnabled{ get; set; }

        /// <summary>
        /// Whether to enable the admin feature of the cluster.
        /// </summary>
        [JsonProperty("AdminFeatureEnabled")]
        public bool? AdminFeatureEnabled{ get; set; }

        /// <summary>
        /// Admin AK
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminAccessKey")]
        public string AdminAccessKey{ get; set; }

        /// <summary>
        /// Admin SK
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminSecretKey")]
        public string AdminSecretKey{ get; set; }

        /// <summary>
        /// Whether to enable deletion protection
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PublicEndPoint", this.PublicEndPoint);
            this.SetParamSimple(map, prefix + "VpcEndPoint", this.VpcEndPoint);
            this.SetParamSimple(map, prefix + "SupportNamespaceEndpoint", this.SupportNamespaceEndpoint);
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "RocketMQFlag", this.RocketMQFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "HttpPublicEndpoint", this.HttpPublicEndpoint);
            this.SetParamSimple(map, prefix + "HttpVpcEndpoint", this.HttpVpcEndpoint);
            this.SetParamSimple(map, prefix + "InternalEndpoint", this.InternalEndpoint);
            this.SetParamSimple(map, prefix + "HttpInternalEndpoint", this.HttpInternalEndpoint);
            this.SetParamSimple(map, prefix + "AclEnabled", this.AclEnabled);
            this.SetParamSimple(map, prefix + "PublicClbId", this.PublicClbId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SupportMigration", this.SupportMigration);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "IsFrozen", this.IsFrozen);
            this.SetParamSimple(map, prefix + "AutoCreateTopicEnabled", this.AutoCreateTopicEnabled);
            this.SetParamSimple(map, prefix + "AdminFeatureEnabled", this.AdminFeatureEnabled);
            this.SetParamSimple(map, prefix + "AdminAccessKey", this.AdminAccessKey);
            this.SetParamSimple(map, prefix + "AdminSecretKey", this.AdminSecretKey);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
        }
    }
}

