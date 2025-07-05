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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkClusterInfoItem : AbstractModel
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
        /// Cluster version
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Cluster OS
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// Cluster type
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Cluster region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Cluster network plugin
        /// </summary>
        [JsonProperty("NetworkPolicyPlugin")]
        public string NetworkPolicyPlugin{ get; set; }

        /// <summary>
        /// Cluster status
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// Total number of policies
        /// </summary>
        [JsonProperty("TotalRuleCount")]
        public long? TotalRuleCount{ get; set; }

        /// <summary>
        /// Number of enabled policies
        /// </summary>
        [JsonProperty("EnableRuleCount")]
        public long? EnableRuleCount{ get; set; }

        /// <summary>
        /// Status of the cluster network plugin. Valid values: `Running` (normal); `Error` (abnormal).
        /// </summary>
        [JsonProperty("NetworkPolicyPluginStatus")]
        public string NetworkPolicyPluginStatus{ get; set; }

        /// <summary>
        /// Error message of the cluster network plugin
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkPolicyPluginError")]
        public string NetworkPolicyPluginError{ get; set; }

        /// <summary>
        /// Cluster network plugin
        /// Note: This field may return·`null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterNetworkSettings")]
        public string ClusterNetworkSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "NetworkPolicyPlugin", this.NetworkPolicyPlugin);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "TotalRuleCount", this.TotalRuleCount);
            this.SetParamSimple(map, prefix + "EnableRuleCount", this.EnableRuleCount);
            this.SetParamSimple(map, prefix + "NetworkPolicyPluginStatus", this.NetworkPolicyPluginStatus);
            this.SetParamSimple(map, prefix + "NetworkPolicyPluginError", this.NetworkPolicyPluginError);
            this.SetParamSimple(map, prefix + "ClusterNetworkSettings", this.ClusterNetworkSettings);
        }
    }
}

