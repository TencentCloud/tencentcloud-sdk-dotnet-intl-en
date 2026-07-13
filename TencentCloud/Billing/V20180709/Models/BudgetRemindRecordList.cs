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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BudgetRemindRecordList : AbstractModel
    {
        
        /// <summary>
        /// Optimize COUNT SQL automatically if encounter unresolved jSqlParser case, set the parameter to false
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OptimizeCountSql")]
        public bool? OptimizeCountSql{ get; set; }

        /// <summary>
        /// Pagination
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Pages")]
        public ulong? Pages{ get; set; }

        /// <summary>
        /// Sorting field information. When allowing frontend input, be aware of SQL injection issue. Use SqlInjectionUtils.check(...) to check the text.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Orders")]
        public OrderDto[] Orders{ get; set; }

        /// <summary>
        /// The statementId for a custom count query in xml can also be set without specifying it. Just add _mpCount after the pagination statementId. For example, for the pagination selectPageById, set the count query statementId to selectPageById_mpCount. The SQL execution can then be found by default.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CountId")]
        public string CountId{ get; set; }

        /// <summary>
        /// Pagination size.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// total amount
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// Number of items per page limit
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxLimit")]
        public string MaxLimit{ get; set; }

        /// <summary>
        /// Querying the data list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Records")]
        public BudgetRemindRecords[] Records{ get; set; }

        /// <summary>
        /// Current Page
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Current")]
        public ulong? Current{ get; set; }

        /// <summary>
        /// Whether to perform a count query. If you only want to query the list and do not query the total record count, set the parameter to false.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SearchCount")]
        public bool? SearchCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OptimizeCountSql", this.OptimizeCountSql);
            this.SetParamSimple(map, prefix + "Pages", this.Pages);
            this.SetParamArrayObj(map, prefix + "Orders.", this.Orders);
            this.SetParamSimple(map, prefix + "CountId", this.CountId);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "MaxLimit", this.MaxLimit);
            this.SetParamArrayObj(map, prefix + "Records.", this.Records);
            this.SetParamSimple(map, prefix + "Current", this.Current);
            this.SetParamSimple(map, prefix + "SearchCount", this.SearchCount);
        }
    }
}

