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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCcnRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// The CCN instance ID, such as `ccn-gree226l`.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// The unique ID of the CCN routing policy, such as `ccnr-f49l6u0z`.
        /// </summary>
        [JsonProperty("RouteIds")]
        public string[] RouteIds{ get; set; }

        /// <summary>
        /// Filter condition. `RouteIds` and `Filters` cannot be specified at the same time.
        /// <li>route-id - String - (Filter condition) Routing policy ID.</li>
        /// <li>cidr-block - String - (Filter condition) Destination port.</li>
        /// <li>instance-type - String - (Filter condition) The next hop type.</li>
        /// <li>instance-region - String - (Filter condition) The next hop region.</li>
        /// <li>instance-type - String - (Filter condition) The instance ID of the next hop.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The returned quantity
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArraySimple(map, prefix + "RouteIds.", this.RouteIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

