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

    public class DescribeVpcEndPointServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// Filters. `EndPointServiceIds` and `Filters` cannot be both passed in. 
        /// <li>`service-id` - String - Unique endpoint service ID. </li>
        /// <li>`service-name` - String - Endpoint service instance name. </li>
        /// <li>`service-instance-id` - String - Unique backend service ID in the format of `lb-xxx`. </li>
        /// <li>`service-type` - String - Backend PaaS service type. It can be `CLB`, `CDB` or `CRS`. It defaults to `CLB` if not specified. </li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results per page; default value: 20; maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Endpoint service ID `EndPointServiceIds` and `Filters` cannot be both passed in. 
        /// </summary>
        [JsonProperty("EndPointServiceIds")]
        public string[] EndPointServiceIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsListAuthorizedEndPointService")]
        public bool? IsListAuthorizedEndPointService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "EndPointServiceIds.", this.EndPointServiceIds);
            this.SetParamSimple(map, prefix + "IsListAuthorizedEndPointService", this.IsListAuthorizedEndPointService);
        }
    }
}

