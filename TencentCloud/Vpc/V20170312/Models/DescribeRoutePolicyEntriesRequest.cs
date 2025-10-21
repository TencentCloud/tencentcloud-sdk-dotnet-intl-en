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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRoutePolicyEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria. RoutePolicyEntryIds and Filters cannot be specified at the same time.
        /// <li>route-policy-id - String - (filter condition) specifies the instance id of the route reception policy, such as rrp-f49l6u0z.</li>.
        /// <li>cidr-block - String - (filter condition) cidr (subnet part before the mask), such as 10.0.0.0/8.</li>.
        /// <li>priority - Integer - filter condition. specifies the priority, such as 20.</li>.
        /// <li>gateway-type - String - (filter criteria) next hop type, such as CVM.</li>.
        /// <li>GatewayId - String - specifies the unique id of the next hop instance, such as ccn-f49l6u0z.</li>.
        /// <li>route-type - String - (filter condition) routing type. valid values: USER (USER route), NETD (route issued by network probe), CCN (CCN route).</li>.
        /// <li>action - String - (filter condition) specifies the action. valid values: DROP (DROP), DISABLE (receive and DISABLE), ACCEPT (receive and enable).</li>.
        /// <li>description - String - specifies the filter condition description, such as TEST.</li>.
        /// <li>route-policy-item-id - String - (filter condition) specifies the entry unique id of the route reception policy, such as rrpi-dq782kw7.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of request objects.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Sorting field. currently only supports the priority field.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Specifies the sorting order.
        /// ASC: ascending order.
        /// DESC: descending order.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// Specifies the routing strategy entry ID.
        /// </summary>
        [JsonProperty("RoutePolicyEntryIds")]
        public string[] RoutePolicyEntryIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamArraySimple(map, prefix + "RoutePolicyEntryIds.", this.RoutePolicyEntryIds);
        }
    }
}

