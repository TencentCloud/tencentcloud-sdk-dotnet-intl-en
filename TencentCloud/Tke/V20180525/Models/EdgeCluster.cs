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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdgeCluster : AbstractModel
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
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Cluster Pod CIDR block
        /// </summary>
        [JsonProperty("PodCIDR")]
        public string PodCIDR{ get; set; }

        /// <summary>
        /// Cluster service CIDR block
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("K8SVersion")]
        public string K8SVersion{ get; set; }

        /// <summary>
        /// Cluster status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Cluster description
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// Cluster creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Edge cluster version
        /// </summary>
        [JsonProperty("EdgeClusterVersion")]
        public string EdgeClusterVersion{ get; set; }

        /// <summary>
        /// Maximum number of Pods on the node
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public long? MaxNodePodNum{ get; set; }

        /// <summary>
        /// Cluster advanced settings
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterAdvancedSettings")]
        public EdgeClusterAdvancedSettings ClusterAdvancedSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "PodCIDR", this.PodCIDR);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamSimple(map, prefix + "K8SVersion", this.K8SVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "EdgeClusterVersion", this.EdgeClusterVersion);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamObj(map, prefix + "ClusterAdvancedSettings.", this.ClusterAdvancedSettings);
        }
    }
}

