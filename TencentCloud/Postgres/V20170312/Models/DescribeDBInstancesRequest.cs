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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Query using one or more filter criteria. Filter criteria currently supported include:
        /// db-instance-id: filter by instance ID (in string format)
        /// db-instance-name: filter by instance name (in string format)
        /// db-project-id: filter by project ID (in string format)
        /// db-pay-mode: filter by instance billing mode (in string format)
        /// db-tag-key: filter by tag key (in string format)
        /// db-private-ip: filter by instance VPC IP (in string format)
        /// db-public-address: filter by instance public network address (in string format)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The maximum number of results returned per page. Value range: 1-100. Default: `10`
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Data offset, which starts from 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting metric, such as instance name or creation time. Valid values: DBInstanceId, CreateTime, Name, EndTime
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: `asc` (ascending), `desc` (descending)
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

