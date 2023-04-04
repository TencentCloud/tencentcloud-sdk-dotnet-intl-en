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

    public class SearchLogRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time of the log to be searched, which is a Unix timestamp in milliseconds
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// End time of the log to be searched, which is a Unix timestamp in milliseconds
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// Search and analysis statement. Maximum length: 12 KB
        /// A statement is in the format of <a href="https://intl.cloud.tencent.com/document/product/614/47044?from_cn_redirect=1" target="_blank">[search criteria]</a> | <a href="https://intl.cloud.tencent.com/document/product/614/44061?from_cn_redirect=1" target="_blank">[SQL statement]</a>. You can omit the pipe symbol <code> | </code> and SQL statement when log analysis is not required.
        /// Queries all logs using * or an empty string
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// ID of the log topic to be searched
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// The number of raw logs returned by a single query. Maximum value: 1000. You need to use `Context` to continue to get logs.
        /// Notes:
        /// * This parameter is valid only when the query statement (`Query`) does not contain an SQL statement.
        /// * To limit the number of analysis results, see <a href="https://intl.cloud.tencent.com/document/product/614/58977?from_cn_redirect=1" target="_blank">SQL LIMIT Syntax</a>.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// You can pass through the `Context` value (validity: an hour) returned by the API last time to continue to get logs (up to 10,000 raw logs).
        /// Notes:
        /// * Do not modify any other parameters while passing through the `Context` parameter.
        /// * This parameter is valid only when the query statement (`Query`) does not contain an SQL statement.
        /// * To continue to get analysis results, see <a href="https://intl.cloud.tencent.com/document/product/614/58977?from_cn_redirect=1" target="_blank">SQL LIMIT Syntax</a>.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// Time order of the logs returned. Valid values: `asc` (ascending); `desc`: (descending). Default value: `desc`
        /// Notes:
        /// * This parameter is valid only when the query statement (`Query`) does not contain an SQL statement.
        /// * To sort the analysis results, see <a href="https://intl.cloud.tencent.com/document/product/614/58978?from_cn_redirect=1" target="_blank">SQL ORDER BY Syntax</a>.
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// If the value is `true`, the new response method will be used, and the output parameters `AnalysisRecords` and `Columns` will be valid.
        /// If the value is `false`, the old response method will be used, and the output parameters `AnalysisResults` and `ColNames` will be valid.
        /// The two response methods differ slightly in terms of encoding format. You are advised to use the new method (`true`).
        /// </summary>
        [JsonProperty("UseNewAnalysis")]
        public bool? UseNewAnalysis{ get; set; }

        /// <summary>
        /// Indicates whether to sample raw logs before statistical analysis (`Query` includes SQL statements).
        /// `0`: Auto-sample.
        /// `0–1`: Sample by the specified sample rate, such as `0.02`.
        /// `1`: Precise analysis without sampling.
        /// Default value: `1`
        /// </summary>
        [JsonProperty("SamplingRate")]
        public float? SamplingRate{ get; set; }

        /// <summary>
        /// Search syntax.
        /// `0` (default): Lucene; `1`: CQL.
        /// For more information, visit https://intl.cloud.tencent.com/document/product/614/47044?from_cn_redirect=1#RetrievesConditionalRules.
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "UseNewAnalysis", this.UseNewAnalysis);
            this.SetParamSimple(map, prefix + "SamplingRate", this.SamplingRate);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
        }
    }
}

