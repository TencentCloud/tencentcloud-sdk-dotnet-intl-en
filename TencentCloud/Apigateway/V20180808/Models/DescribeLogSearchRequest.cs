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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogSearchRequest : AbstractModel
    {
        
        /// <summary>
        /// Log start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Log end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Reserved field
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of logs to be returned at a time. Maximum value: 100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Subsequent content can be obtained based on the `ConText` returned last time. Up to 10,000 data entries can be obtained
        /// </summary>
        [JsonProperty("ConText")]
        public string ConText{ get; set; }

        /// <summary>
        /// Sorting by time. Valid values: asc (ascending), desc (descending). Default value: desc
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// Reserved field
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Search criterion. Valid values:
        /// req_id: "="
        /// api_id: "="
        /// cip: "="
        /// uip: ":"
        /// err_msg: ":"
        /// rsp_st: "=", "!=", ":", ">", "<"
        /// req_t: ">=", "<="
        /// 
        /// Note:
        /// ":" indicates included, and "!=" indicates not equal to. For the meanings of fields, please see the `LogSet` description of the output parameter
        /// </summary>
        [JsonProperty("LogQuerys")]
        public LogQuery[] LogQuerys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ConText", this.ConText);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArrayObj(map, prefix + "LogQuerys.", this.LogQuerys);
        }
    }
}

