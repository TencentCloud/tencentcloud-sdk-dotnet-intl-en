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

    public class DescribeBaseBackupsRequest : AbstractModel
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
        /// Query using one or more filter criteria. filter criteria currently supported include:.
        /// db-instance-id: filter by instance id (string type).
        /// db-instance-name: specifies the instance name to filter by, supports fuzzy matching (string type).
        /// db-instance-ip: specifies the instance VPC ip for filtering (string type).
        /// base-backup-id: filter by backup set id (in string format).
        /// db-instance-status: filter by instance status (in string format). valid values refer to the DBInstanceStatus field in the DBInstance structure (https://www.tencentcloud.com/document/product/409/16778#dbinstance).
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
        /// Specifies the sorting field, supports StartTime, FinishTime, and Size. default value: StartTime.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting method, including ascending: `asc` and descending: `desc`. the default value is `desc`.
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

