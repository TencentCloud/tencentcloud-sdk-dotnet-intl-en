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

    public class UpgradeClusterInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// create: starting an upgrade task
        /// pause: pausing the task
        /// resume: continuing the task
        /// abort: stopping the task
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Upgrade type. It’s only required when `Operation` is set as `create`.
        /// reset: the reinstallation and upgrade of major version
        /// hot: the hot upgrade of minor version
        /// major: in-place upgrade of major version
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// List of nodes that need to upgrade
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// This parameter is used when the node joins the cluster again. Refer to the API of creating one or more cluster nodes.
        /// </summary>
        [JsonProperty("ResetParam")]
        public UpgradeNodeResetParam ResetParam{ get; set; }

        /// <summary>
        /// Whether to skip the pre-upgrade check of the node
        /// </summary>
        [JsonProperty("SkipPreCheck")]
        public bool? SkipPreCheck{ get; set; }

        /// <summary>
        /// The maximum tolerable proportion of unavailable pods
        /// </summary>
        [JsonProperty("MaxNotReadyPercent")]
        public float? MaxNotReadyPercent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "ResetParam.", this.ResetParam);
            this.SetParamSimple(map, prefix + "SkipPreCheck", this.SkipPreCheck);
            this.SetParamSimple(map, prefix + "MaxNotReadyPercent", this.MaxNotReadyPercent);
        }
    }
}

