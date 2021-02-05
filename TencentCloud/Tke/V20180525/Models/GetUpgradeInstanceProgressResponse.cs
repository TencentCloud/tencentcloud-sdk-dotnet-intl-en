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

    public class GetUpgradeInstanceProgressResponse : AbstractModel
    {
        
        /// <summary>
        /// Total nodes to upgrade
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// Total upgraded nodes
        /// </summary>
        [JsonProperty("Done")]
        public long? Done{ get; set; }

        /// <summary>
        /// The lifecycle of the upgrade task
        /// process: running
        /// paused: stopped
        /// pausing: stopping
        /// done: completed
        /// timeout: timed out
        /// aborted: canceled
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// Details of upgrade progress of each node
        /// </summary>
        [JsonProperty("Instances")]
        public InstanceUpgradeProgressItem[] Instances{ get; set; }

        /// <summary>
        /// Current cluster status
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public InstanceUpgradeClusterStatus ClusterStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Done", this.Done);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamObj(map, prefix + "ClusterStatus.", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

