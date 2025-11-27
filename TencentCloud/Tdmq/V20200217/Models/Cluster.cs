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

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Number of access points
        /// </summary>
        [JsonProperty("EndPointNum")]
        public long? EndPointNum{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Whether the cluster is healthy. 1: healthy; 0: exceptional
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// Cluster health information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthyInfo")]
        public string HealthyInfo{ get; set; }

        /// <summary>
        /// Cluster status. 0: creating; 1: normal; 2: terminating; 3: deleted; 4. isolated; 5. creation failed; 6: deletion failed
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Maximum number of namespaces
        /// </summary>
        [JsonProperty("MaxNamespaceNum")]
        public long? MaxNamespaceNum{ get; set; }

        /// <summary>
        /// Maximum number of topics
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public long? MaxTopicNum{ get; set; }

        /// <summary>
        /// Maximum QPS
        /// </summary>
        [JsonProperty("MaxQps")]
        public long? MaxQps{ get; set; }

        /// <summary>
        /// Maximum message retention period in seconds
        /// </summary>
        [JsonProperty("MessageRetentionTime")]
        public long? MessageRetentionTime{ get; set; }

        /// <summary>
        /// Maximum storage capacity
        /// </summary>
        [JsonProperty("MaxStorageCapacity")]
        public long? MaxStorageCapacity{ get; set; }

        /// <summary>
        /// Cluster version
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Public network access point
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicEndPoint")]
        public string PublicEndPoint{ get; set; }

        /// <summary>
        /// VPC access point
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcEndPoint")]
        public string VpcEndPoint{ get; set; }

        /// <summary>
        /// Number of namespaces
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NamespaceNum")]
        public long? NamespaceNum{ get; set; }

        /// <summary>
        /// Limit of used storage in MB
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsedStorageBudget")]
        public long? UsedStorageBudget{ get; set; }

        /// <summary>
        /// Maximum message production rate in messages
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxPublishRateInMessages")]
        public long? MaxPublishRateInMessages{ get; set; }

        /// <summary>
        /// Maximum message push rate in messages
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxDispatchRateInMessages")]
        public long? MaxDispatchRateInMessages{ get; set; }

        /// <summary>
        /// Maximum message production rate in bytes
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxPublishRateInBytes")]
        public long? MaxPublishRateInBytes{ get; set; }

        /// <summary>
        /// Maximum message push rate in bytes
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxDispatchRateInBytes")]
        public long? MaxDispatchRateInBytes{ get; set; }

        /// <summary>
        /// Number of created topics
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// Maximum message delay in seconds
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxMessageDelayInSeconds")]
        public long? MaxMessageDelayInSeconds{ get; set; }

        /// <summary>
        /// Whether to enable public network access. If this parameter is left empty, the feature will be enabled by default
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicAccessEnabled")]
        public bool? PublicAccessEnabled{ get; set; }

        /// <summary>
        /// Tag
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Billing mode:
        /// `0`: Pay-as-you-go
        /// `1`: Monthly subscription
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Project ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Project name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Specifies whether the pro edition instance can be upgraded.
        /// </summary>
        [JsonProperty("UpgradeProInstance")]
        public bool? UpgradeProInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "EndPointNum", this.EndPointNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "HealthyInfo", this.HealthyInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MaxNamespaceNum", this.MaxNamespaceNum);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
            this.SetParamSimple(map, prefix + "MaxQps", this.MaxQps);
            this.SetParamSimple(map, prefix + "MessageRetentionTime", this.MessageRetentionTime);
            this.SetParamSimple(map, prefix + "MaxStorageCapacity", this.MaxStorageCapacity);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "PublicEndPoint", this.PublicEndPoint);
            this.SetParamSimple(map, prefix + "VpcEndPoint", this.VpcEndPoint);
            this.SetParamSimple(map, prefix + "NamespaceNum", this.NamespaceNum);
            this.SetParamSimple(map, prefix + "UsedStorageBudget", this.UsedStorageBudget);
            this.SetParamSimple(map, prefix + "MaxPublishRateInMessages", this.MaxPublishRateInMessages);
            this.SetParamSimple(map, prefix + "MaxDispatchRateInMessages", this.MaxDispatchRateInMessages);
            this.SetParamSimple(map, prefix + "MaxPublishRateInBytes", this.MaxPublishRateInBytes);
            this.SetParamSimple(map, prefix + "MaxDispatchRateInBytes", this.MaxDispatchRateInBytes);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "MaxMessageDelayInSeconds", this.MaxMessageDelayInSeconds);
            this.SetParamSimple(map, prefix + "PublicAccessEnabled", this.PublicAccessEnabled);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "UpgradeProInstance", this.UpgradeProInstance);
        }
    }
}

