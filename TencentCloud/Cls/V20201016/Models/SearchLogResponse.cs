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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchLogResponse : AbstractModel
    {
        
        /// <summary>
        /// You can pass through the `Context` value (validity: 1 hour) returned by this API to continue to get more logs.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// Whether to return all raw log query results. If not, you can use `Context` to continue to get logs.
        /// Note: This parameter is valid only when the query statement (`Query`) does not contain an SQL statement.
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// Whether the returned data is the analysis (SQL) result
        /// </summary>
        [JsonProperty("Analysis")]
        public bool? Analysis{ get; set; }

        /// <summary>
        /// Raw logs that meet the search conditions
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Results")]
        public LogInfo[] Results{ get; set; }

        /// <summary>
        /// Column names of log analysis
        /// This parameter is valid only when `UseNewAnalysis` is `false`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColNames")]
        public string[] ColNames{ get; set; }

        /// <summary>
        /// Log analysis result
        /// This parameter is valid only when `UseNewAnalysis` is `false`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AnalysisResults")]
        public LogItems[] AnalysisResults{ get; set; }

        /// <summary>
        /// Log analysis result
        /// This parameter is valid only when `UseNewAnalysis` is `true`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AnalysisRecords")]
        public string[] AnalysisRecords{ get; set; }

        /// <summary>
        /// Column attributes of log analysis
        /// This parameter is valid only when `UseNewAnalysis` is `true`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// Sample rate used in this statistical analysis
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SamplingRate")]
        public float? SamplingRate{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "ListOver", this.ListOver);
            this.SetParamSimple(map, prefix + "Analysis", this.Analysis);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamArraySimple(map, prefix + "ColNames.", this.ColNames);
            this.SetParamArrayObj(map, prefix + "AnalysisResults.", this.AnalysisResults);
            this.SetParamArraySimple(map, prefix + "AnalysisRecords.", this.AnalysisRecords);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "SamplingRate", this.SamplingRate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

