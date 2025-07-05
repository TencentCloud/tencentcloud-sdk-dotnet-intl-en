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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteClusterAsGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// The cluster ID, obtained through the [DescribeClusters](https://www.tencentcloud.com/document/api/457/32025) API.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster scaling group ID list
        /// </summary>
        [JsonProperty("AutoScalingGroupIds")]
        public string[] AutoScalingGroupIds{ get; set; }

        /// <summary>
        /// Whether to keep nodes in the scaling group. Default to **false** (not keep)
        /// </summary>
        [JsonProperty("KeepInstance")]
        public bool? KeepInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "AutoScalingGroupIds.", this.AutoScalingGroupIds);
            this.SetParamSimple(map, prefix + "KeepInstance", this.KeepInstance);
        }
    }
}

