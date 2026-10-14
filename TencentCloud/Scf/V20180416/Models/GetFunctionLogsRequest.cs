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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFunctionLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// Function name.
        /// -To ensure compatibility of the [retrieve function execution log](https://www.tencentcloud.com/document/product/583/18583?from_cn_redirect=1) API `GetFunctionLogs`, the input parameter `FunctionName` remains an optional field, but it is recommended to fill in this parameter. Otherwise, log acquisition failure may occur.
        /// - After associating a function with CLS, it is recommended to use the relevant CLS APIs (https://www.tencentcloud.com/document/product/614/16875?from_cn_redirect=1) to get the best log retrieval experience.
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Offset of the data. Offset + Limit cannot be greater than 10000.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Length of the returned data. Offset + Limit cannot be greater than 10000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Whether to sort logs in descending or ascending order. Available values: `desc` and `asc`.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sort logs by a certain field. The following fields are supported: function_name, duration, mem_usage, start_time
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Log filter criteria. It can be used to distinguish correct and error logs. filter.RetCode=not0 means only return error logs, filter.RetCode=is0 means only return correct logs. If not passed, all logs are returned.
        /// </summary>
        [JsonProperty("Filter")]
        public LogFilter Filter{ get; set; }

        /// <summary>
        /// Namespace of the function
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Function version
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// Request ID for executing the function
        /// </summary>
        [JsonProperty("FunctionRequestId")]
        public string FunctionRequestId{ get; set; }

        /// <summary>
        /// Specific date of the query, for example: 2017-05-16 20:00:00. It must differ from endtime by no more than one day.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Specific date of the query, for example: 2017-05-16 20:59:59. It must differ from startTime by no more than one day.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// This field is offline.
        /// </summary>
        [JsonProperty("SearchContext")]
        public LogSearchContext SearchContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "FunctionRequestId", this.FunctionRequestId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamObj(map, prefix + "SearchContext.", this.SearchContext);
        }
    }
}

