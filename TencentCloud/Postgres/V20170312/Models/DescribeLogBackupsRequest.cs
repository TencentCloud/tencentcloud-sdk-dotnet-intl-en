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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// Minimum end time of a backup in the format of `2018-01-01 00:00:00`. It is 7 days ago by default.
        /// </summary>
        [JsonProperty("MinFinishTime")]
        public string MinFinishTime{ get; set; }

        /// <summary>
        /// Maximum end time of a backup in the format of `2018-01-01 00:00:00`. It is the current time by default.
        /// </summary>
        [JsonProperty("MaxFinishTime")]
        public string MaxFinishTime{ get; set; }

        /// <summary>
        /// Filter instances using one or more criteria. Valid filter names:
        /// db-instance-id: Filter by instance ID (in string format).
        /// db-instance-name: Filter by instance name (in string format).
        /// db-instance-ip: Filter by instance VPC IP (in string format).
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The maximum number of results returned per page. Value range: 1-100. Default: `10`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Data offset, which starts from 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting field. Valid values: `StartTime`, `FinishTime`, `Size`.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: `asc` (ascending), `desc` (descending).
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinFinishTime", this.MinFinishTime);
            this.SetParamSimple(map, prefix + "MaxFinishTime", this.MaxFinishTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

