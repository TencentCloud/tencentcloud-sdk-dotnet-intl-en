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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePlansRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria: the maximum number of Filters.Values is 20. detailed filter criteria are as follows: <li>plan-type<br>  filter by <strong>package type</strong>.<br>  available types:<br>  plan-trial: trial package;<br>  plan-personal: personal plan;<br>  plan-basic: basic plan;<br>  plan-standard: standard edition plan;<br>  plan-enterprise: enterprise plan.</li> <li>plan-id<br>  filter by <strong>package id</strong>. the package id format is: edgeone-268z103ob0sx.</li> <li>area<br>  filter by <strong>acceleration region</strong>.</li> service area. available types:<br>  mainland: chinese mainland;<br>  overseas: worldwide (excluding chinese mainland);<br>  global: global (including chinese mainland). <li>status<br>  filter by <strong>status</strong>.<br>  available states:<br>  normal: normal status;<br>  expiring-soon: expiring soon;<br>  expired: expired;<br>  isolated: isolated.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Specifies the sorting field. valid values:.
        /// <li>enable-time: effective time;</li>.
        /// <Li> expire-time: expiration time.</li>use default value enable-time if not specified.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting order. valid values:.
        /// <Li>`Asc`: sort in ascending order</li>.
        /// <Li>`Desc`: from the largest to smallest.</li>default value: `desc`.
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// Number limit of paginated query. Default value: 20. Maximum value: 200.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// The offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

