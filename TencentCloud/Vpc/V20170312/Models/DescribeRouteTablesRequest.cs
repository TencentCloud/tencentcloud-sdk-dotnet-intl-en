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

    public class DescribeRouteTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// The route table instance ID, such as `rtb-azd4dt1c`.
        /// </summary>
        [JsonProperty("RouteTableIds")]
        public string[] RouteTableIds{ get; set; }

        /// <summary>
        /// Filter condition. `RouteTableIds` and `Filters` cannot be speified at the same time.
        /// <li>route-table-id - String - (Filter condition) Route table instance ID.</li>
        /// <li>route-table-name - String - (Filter condition) Route table name.</li>
        /// <li>vpc-id - String - (Filter condition) VPC instance ID, such as `vpc-f49l6u0z`.</li>
        /// <li>association.main - String - (Filter condition) Whether it is the main route table.</li>
        /// <li>tag-key - String - Required: No - (Filter condition) Filter by tag key.</li>
        /// <li>tag:tag-key - String - Required: No - (Filter condition) Filter by tag key-value pair. The tag-key is replaced with the specific tag key. For usage, refer to case 2.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// The number of request objects.
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RouteTableIds.", this.RouteTableIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

