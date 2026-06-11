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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumerGroup : AbstractModel
    {
        
        /// <summary>
        /// Consumer group name
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// Status.
        /// 
        /// -Empty: The group has no members but has submitted offsets. All consumers left but retained offsets.
        /// -Dead: The group has no members and no submitted offsets. The group is deleted or has long-term inactivity.
        /// -Stable: Members in the group consume normally with balanced partition allocation. Normal operating status.
        /// -PreparingRebalance: The group is preparing to rebalance. New members join or existing members leave.
        /// -CompletingRebalance: The group is preparing to rebalance. New members join or existing members leave.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Partition allocation policy balancing algorithm name.
        /// 
        /// -Common load balancing algorithms are as follows:
        /// -range: Allocate by partition range
        /// -roundrobin: Poll-based allocation
        /// -sticky: Sticky assignment (avoid unnecessary rebalance)
        /// </summary>
        [JsonProperty("ProtocolName")]
        public string ProtocolName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "ProtocolName", this.ProtocolName);
        }
    }
}

