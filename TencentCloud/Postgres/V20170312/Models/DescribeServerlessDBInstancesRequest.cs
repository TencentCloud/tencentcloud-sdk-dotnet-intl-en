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

    public class DescribeServerlessDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Query criteria. Query using one or more filter criteria. Filter criteria type (specified by the name field) currently supported include: 
        /// 
        /// - db-instance-id: filter by instance ID (in string format)
        /// - db-instance-name: filter by instance name (in string format)
        /// - db-tag-key: filter by instance tag (in string format)
        /// 
        /// The value field specifies the specific instance ID/instance name/instance tag-key to filter under this type of filter criteria.
        /// </summary>
        [JsonProperty("Filter")]
        public Filter[] Filter{ get; set; }

        /// <summary>
        /// The number of queries
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The offset value
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting metric. Currently, only "CreateTime" (instance creation time) is supported.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting order. Ascending and descending are supported.
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

