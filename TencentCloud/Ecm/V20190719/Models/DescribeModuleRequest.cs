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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter.
        /// module-name - string - Required: no - (Filter) Filter by module name.
        /// module-id - string - Required: no - (Filter) Filter by module ID.
        /// image-id      String      Required: no      (Filter) Filter by image ID.
        /// instance-family      String      Required: no      (Filter) Filter by model family.
        /// security-group-id - string Required: no - (Filter) Filter by ID of the security group bound to the module.
        /// Each request can contain up to 10 `Filters` and 5 `Filter.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section of the API overview.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section of the API overview.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Specified sort by field. Currently, valid values are as follows:
        /// instance-num: sort by the number of instances.
        /// node-num: sort by the number of nodes.
        /// timestamp: sort by instance creation time.
        /// If this parameter is not specified, instances will be sorted by creation time by default.
        /// </summary>
        [JsonProperty("OrderByField")]
        public string OrderByField{ get; set; }

        /// <summary>
        /// Sorting order. 0: descending; 1: ascending. If this parameter is not specified, it will be descending by default.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public long? OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByField", this.OrderByField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

