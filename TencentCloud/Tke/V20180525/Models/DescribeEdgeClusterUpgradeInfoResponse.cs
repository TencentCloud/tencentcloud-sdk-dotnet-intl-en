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

    public class DescribeEdgeClusterUpgradeInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Upgradeable cluster component
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ComponentVersion")]
        public string ComponentVersion{ get; set; }

        /// <summary>
        /// Current version of the edge cluster
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EdgeVersionCurrent")]
        public string EdgeVersionCurrent{ get; set; }

        /// <summary>
        /// Prefix of the image registry of an edge component (including domain name and namespace)
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RegistryPrefix")]
        public string RegistryPrefix{ get; set; }

        /// <summary>
        /// Cluster upgrade status. Valid values: `Running`, `Updating`, `Failed`
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterUpgradeStatus")]
        public string ClusterUpgradeStatus{ get; set; }

        /// <summary>
        /// Reason for `Updating` or `Failed`
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterUpgradeStatusReason")]
        public string ClusterUpgradeStatusReason{ get; set; }

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
            this.SetParamSimple(map, prefix + "ComponentVersion", this.ComponentVersion);
            this.SetParamSimple(map, prefix + "EdgeVersionCurrent", this.EdgeVersionCurrent);
            this.SetParamSimple(map, prefix + "RegistryPrefix", this.RegistryPrefix);
            this.SetParamSimple(map, prefix + "ClusterUpgradeStatus", this.ClusterUpgradeStatus);
            this.SetParamSimple(map, prefix + "ClusterUpgradeStatusReason", this.ClusterUpgradeStatusReason);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

