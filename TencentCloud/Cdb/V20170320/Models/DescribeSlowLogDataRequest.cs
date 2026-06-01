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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowLogDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Session start timestamp. For example, 1585142640.
        /// Description: This parameter is a timestamp in seconds.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// End timestamp. Example: 1585142640.
        /// Description: This parameter is a timestamp in seconds.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Client `Host` list.
        /// </summary>
        [JsonProperty("UserHosts")]
        public string[] UserHosts{ get; set; }

        /// <summary>
        /// Client username list.
        /// </summary>
        [JsonProperty("UserNames")]
        public string[] UserNames{ get; set; }

        /// <summary>
        /// Accessed database list.
        /// </summary>
        [JsonProperty("DataBases")]
        public string[] DataBases{ get; set; }

        /// <summary>
        /// Sorting field. Currently supported fields and their meanings are as follows. Default value is Timestamp.
        /// 1. Timestamp: SQL execution time
        /// 2. QueryTime: SQL execution duration (seconds)
        /// 3. LockTime: Lock duration (seconds)
        /// 4. RowsExamined: Number of scanned rows
        /// 5. RowsSent: Result set row count
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// Ascending or descending order. Valid values: "ASC" - Ascending order, "DESC" - Descending order. Default value: "ASC".
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Offset. The default is 0, and the maximum is 9999.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The number of records returned in a single use, default is 100, maximum is 800.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// This parameter is valid only for source or disaster recovery instances. Valid value: `slave`, which indicates pulling logs from the replica.
        /// </summary>
        [JsonProperty("InstType")]
        public string InstType{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("OpResourceId")]
        public string OpResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "UserHosts.", this.UserHosts);
            this.SetParamArraySimple(map, prefix + "UserNames.", this.UserNames);
            this.SetParamArraySimple(map, prefix + "DataBases.", this.DataBases);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "InstType", this.InstType);
            this.SetParamSimple(map, prefix + "OpResourceId", this.OpResourceId);
        }
    }
}

