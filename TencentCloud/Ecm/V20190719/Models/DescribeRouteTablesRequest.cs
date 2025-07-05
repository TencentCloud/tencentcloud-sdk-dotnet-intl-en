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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRouteTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// Route table instance ID, such as `rtb-azd4dt1c`.
        /// </summary>
        [JsonProperty("RouteTableIds")]
        public string[] RouteTableIds{ get; set; }

        /// <summary>
        /// Filter. `RouteTableIds` and `Filters` cannot be specified at the same time.
        /// route-table-id - String - (Filter) Route table instance ID.
        /// route-table-name - String - (Filter) Route table name.
        /// vpc-id - String - (Filter) VPC instance ID, such as `vpc-f49l6u0z`.
        /// association.main - String - (Filter) Whether it is the main route table.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Limit
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// ECM region. If this parameter is left empty or not specified, it will indicate all regions.
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RouteTableIds.", this.RouteTableIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
        }
    }
}

