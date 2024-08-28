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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAttackEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of returns. The maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        ///  Filter criteria
        /// <li>Type - String attack status. 0: attempted attack; 1: attack succeeded - required: no</li>
        /// <li>Status - String event processing status: 0: pending 1: processed; 2: allowlisted; 3: ignored; 4: deleted - required: no</li>
        /// <li>SrcIP - String source IP - required: no</li>
        /// <li>Uuids - String CWPP UUID - required: no</li>
        /// <li>Quuids - String CVM UUID - required: no</li>
        /// <li>DstPort - String attack target port - required: no</li>
        /// <li>MachineName - String host name - required: no</li>
        /// <li>InstanceID - String host instance ID - required: no</li>
        /// <li>AttackTimeBegin - String attack start time - required: no</li>
        /// <li>AttackTimeEnd - String attack end time - required: no</li>
        /// <li>VulSupportDefense - String: whether the vulnerability can be defended: 0: no;1: yes - required: no</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Sorting method: ASC, DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

