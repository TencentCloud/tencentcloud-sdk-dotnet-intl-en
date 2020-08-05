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

    public class ClusterAsGroupOption : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable scale-in
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsScaleDownEnabled")]
        public bool? IsScaleDownEnabled{ get; set; }

        /// <summary>
        /// The scale-out method when there are multiple scaling groups. `random`: select a random scaling group. `most-pods`: choose the scaling group that can schedule the most pods. `least-waste`: select the scaling group that can ensure the fewest remaining resources after Pod scheduling.. The default value is `random`.)
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Expander")]
        public string Expander{ get; set; }

        /// <summary>
        /// Max concurrent scale-in volume
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("MaxEmptyBulkDelete")]
        public long? MaxEmptyBulkDelete{ get; set; }

        /// <summary>
        /// Number of minutes after cluster scale-out when the system starts judging whether to perform scale-in
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ScaleDownDelay")]
        public long? ScaleDownDelay{ get; set; }

        /// <summary>
        /// Number of consecutive minutes of idleness after which the node is subject to scale-in (default value: 10)
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ScaleDownUnneededTime")]
        public long? ScaleDownUnneededTime{ get; set; }

        /// <summary>
        /// Percentage of node resource usage below which the node is considered to be idle (default value: 50)
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ScaleDownUtilizationThreshold")]
        public long? ScaleDownUtilizationThreshold{ get; set; }

        /// <summary>
        /// During scale-in, ignore nodes with local storage pods (default value: False)
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SkipNodesWithLocalStorage")]
        public bool? SkipNodesWithLocalStorage{ get; set; }

        /// <summary>
        /// During scale-in, ignore nodes with pods in the kube-system namespace that are not managed by DaemonSet (default value: False)
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SkipNodesWithSystemPods")]
        public bool? SkipNodesWithSystemPods{ get; set; }

        /// <summary>
        /// Whether to ignore DaemonSet pods by default when calculating resource usage (default value: False: do not ignore)
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IgnoreDaemonSetsUtilization")]
        public bool? IgnoreDaemonSetsUtilization{ get; set; }

        /// <summary>
        /// Number at which CA health detection is triggered (default value: 3). After the number specified in OkTotalUnreadyCount is exceeded, CA will perform health detection.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OkTotalUnreadyCount")]
        public long? OkTotalUnreadyCount{ get; set; }

        /// <summary>
        /// Max percentage of unready nodes. After the max percentage is exceeded, CA will stop operation.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("MaxTotalUnreadyPercentage")]
        public long? MaxTotalUnreadyPercentage{ get; set; }

        /// <summary>
        /// Amount of time before unready nodes become eligible for scale-in
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ScaleDownUnreadyTime")]
        public long? ScaleDownUnreadyTime{ get; set; }

        /// <summary>
        /// Waiting time before CA deletes nodes that are not registered in Kubernetes
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UnregisteredNodeRemovalTime")]
        public long? UnregisteredNodeRemovalTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsScaleDownEnabled", this.IsScaleDownEnabled);
            this.SetParamSimple(map, prefix + "Expander", this.Expander);
            this.SetParamSimple(map, prefix + "MaxEmptyBulkDelete", this.MaxEmptyBulkDelete);
            this.SetParamSimple(map, prefix + "ScaleDownDelay", this.ScaleDownDelay);
            this.SetParamSimple(map, prefix + "ScaleDownUnneededTime", this.ScaleDownUnneededTime);
            this.SetParamSimple(map, prefix + "ScaleDownUtilizationThreshold", this.ScaleDownUtilizationThreshold);
            this.SetParamSimple(map, prefix + "SkipNodesWithLocalStorage", this.SkipNodesWithLocalStorage);
            this.SetParamSimple(map, prefix + "SkipNodesWithSystemPods", this.SkipNodesWithSystemPods);
            this.SetParamSimple(map, prefix + "IgnoreDaemonSetsUtilization", this.IgnoreDaemonSetsUtilization);
            this.SetParamSimple(map, prefix + "OkTotalUnreadyCount", this.OkTotalUnreadyCount);
            this.SetParamSimple(map, prefix + "MaxTotalUnreadyPercentage", this.MaxTotalUnreadyPercentage);
            this.SetParamSimple(map, prefix + "ScaleDownUnreadyTime", this.ScaleDownUnreadyTime);
            this.SetParamSimple(map, prefix + "UnregisteredNodeRemovalTime", this.UnregisteredNodeRemovalTime);
        }
    }
}

