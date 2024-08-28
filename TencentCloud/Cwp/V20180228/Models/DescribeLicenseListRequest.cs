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

    public class DescribeLicenseListRequest : AbstractModel
    {
        
        /// <summary>
        /// Take the intersection when filtering with multiple conditions.
        /// <li> LicenseStatus authorization status information: 0 - not used; 1 - partially used; 2 - used up; 3 - unavailable; 4 - available</li>
        /// <li> BuyTime: time of purchase</li>
        /// <li> LicenseType authorization type. 0: Pro Edition-pay-as-you-go; 1: Pro Edition-monthly subscription; 2: Ultimate Edition-monthly subscription</li>
        /// <li>DeadlineStatus expiration status: NotExpired -not expired; expire - expired (including terminated); nearexpiry - about to expire</li>
        /// <li>ResourceId resource ID</li>
        /// <li>Keywords IP filtering</li>
        /// <li>PayMode payment mode. 0: pay-as-you-go; 1: monthly subscription</li>
        /// <li>OrderStatus order status. 1: normal; 2: isolated; 3: terminated</li>
        /// <li>DealNames sub-order number, with a maximum length of 10, exceeding this will result in a failure.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Limit number, 10 by default.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset, which is 0 by default.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Tag filtering; filter by the platform's tag capabilities. In this case, you should pass in the tag key and tag value as an object.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

