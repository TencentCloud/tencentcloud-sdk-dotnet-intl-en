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

    public class PulsarProClusterInfo : AbstractModel
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
        /// Description
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Cluster status. Valid values: `0` (Creating), `1` (Normal), `2` (Isolated).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Cluster version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Node distribution
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NodeDistribution")]
        public InstanceNodeDistribution[] NodeDistribution{ get; set; }

        /// <summary>
        /// Max storage capacity in MB
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// Whether the route can be modified
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CanEditRoute")]
        public bool? CanEditRoute{ get; set; }

        /// <summary>
        /// Specifies different billing specifications for pro edition and small-scale professional edition: PULSAR.P1 fixed storage and PULSAR.P2 elastic storage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BillingLabelVersion")]
        public string BillingLabelVersion{ get; set; }

        /// <summary>
        /// Instance expiration timestamp, accurate to the millisecond level.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// Whether to enable automatic topic creation.
        /// true indicates enabled. false indicates disabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoCreateTopicStatus")]
        public bool? AutoCreateTopicStatus{ get; set; }

        /// <summary>
        /// Specifies the default number of partitions for automatic topic creation. valid values: 0 if not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultPartitionNumber")]
        public long? DefaultPartitionNumber{ get; set; }

        /// <summary>
        /// User-Defined tenant alias. if there is no, reuse the professional cluster ID.
        /// </summary>
        [JsonProperty("Tenant")]
        public string Tenant{ get; set; }

        /// <summary>
        /// Deletion protection switch flag.
        /// </summary>
        [JsonProperty("DeleteProtection")]
        public long? DeleteProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "NodeDistribution.", this.NodeDistribution);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "CanEditRoute", this.CanEditRoute);
            this.SetParamSimple(map, prefix + "BillingLabelVersion", this.BillingLabelVersion);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoCreateTopicStatus", this.AutoCreateTopicStatus);
            this.SetParamSimple(map, prefix + "DefaultPartitionNumber", this.DefaultPartitionNumber);
            this.SetParamSimple(map, prefix + "Tenant", this.Tenant);
            this.SetParamSimple(map, prefix + "DeleteProtection", this.DeleteProtection);
        }
    }
}

