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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start time for logs to be searched and analyzed, <strong>Unix timestamp (ms)</strong></p>
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// <p>End time for logs to be searched and analyzed, <strong>Unix timestamp (ms)</strong></p>
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// <p>The retrieval analysis statement has a maximum length of 12KB.<br>The statement consists of <a href="https://www.tencentcloud.com/document/product/614/47044?from_cn_redirect=1" target="_blank">[retrieval condition]</a> | <a href="https://www.tencentcloud.com/document/product/614/44061?from_cn_redirect=1" target="_blank">[SQL statement]</a>. When there is no need to perform statistical analysis on logs, the pipe character <code> | </code> and SQL statement can be omitted.<br>Use * or an empty string to search all logs.</p><p>Default value: empty string</p>
        /// </summary>
        [JsonProperty("QueryString")]
        public string QueryString{ get; set; }

        /// <summary>
        /// <p>Search syntax rules. Default value is 1. Recommended for use is 1.</p><ul><li>0: Lucene syntax</li><li>1: CQL syntax (CLS Query Language, dedicated retrieval syntax for log service)</li></ul><p>For details, see <a href="https://www.tencentcloud.com/document/product/614/47044?from_cn_redirect=1#RetrievesConditionalRules" target="_blank">retrieval condition syntax rules</a>.</p><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("QuerySyntax")]
        public ulong? QuerySyntax{ get; set; }

        /// <summary>
        /// <ul><li>Log topic ID to be retrieved and analyzed. Only one can be specified.</li><li>If needed to retrieve multiple log topics at the same time, please use the Topics parameter.</li><li>TopicId and Topics cannot include both. Only select one in a single request.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <ul><li>Log topic list for retrieval and analysis supports a maximum of 50 log topics.</li><li>Use TopicId to retrieve a single log topic.</li><li>TopicId and Topics cannot be used simultaneously. Only select one in a single request.</li></ul>
        /// </summary>
        [JsonProperty("Topics")]
        public MultiTopicSearchInformation[] Topics{ get; set; }

        /// <summary>
        /// <p>Whether raw logs are returned in time sequence. Value range: asc (ascending), desc (descending). Default is desc.<br>Note:</p><ul><li>Only valid when the search and analysis statement (Query) does not contain SQL.</li><li>For SQL result sorting, see <a href="https://www.tencentcloud.com/document/product/614/58978?from_cn_redirect=1" target="_blank">SQL ORDER BY syntax</a>.</li></ul>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// <p>Number of raw logs returned in a single query. Default is 100, maximum value is 1000.<br>Note:</p><ul><li>Only valid when the search and analysis statement (Query) does not contain SQL.</li><li>For the method for specifying SQL result count, see <a href="https://www.tencentcloud.com/document/product/614/58977?from_cn_redirect=1" target="_blank">SQL LIMIT syntax</a>.</li></ul><p>There are two methods to retrieve more logs:</p><ul><li>Context: Pass the Context value returned by the last API call to retrieve more logs. The total number of raw logs that can be obtained is up to 10,000 entries.</li><li>Offset: The offset refers to the line number from which raw logs start to return. There is no log entry limit.</li></ul>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Offset of the raw log Query, indicating the line number from which the raw log starts to return, defaults to 0.<br>Note:</p><ul><li>Valid only when the retrieval statement (Query) does not contain SQL</li><li>Cannot be used with Context parameter simultaneously</li><li>Applicable only for single log topic retrieval</li></ul>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Pass the Context value returned by the last API call to obtain more logs later. The total number of raw logs that can be retrieved is up to 10,000 entries, with an expiration time of 1 hour.<br>Note:</p><ul><li>When passing this parameter, do not modify other parameters except this one.</li><li>Applicable only for single log topic retrieval. To retrieve multiple log topics, use the Context in Topics.</li><li>Valid only when the search and analysis statement (Query) does not contain SQL. For SQL to obtain follow-up results, see <a href="https://www.tencentcloud.com/document/product/614/58977?from_cn_redirect=1" target="_blank">SQL LIMIT syntax</a>.</li></ul>
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// <p>Whether to sample raw logs first and then perform statistical analysis when executing statistical analysis (SQL included in Query).<br>0: auto-sample;<br>0–1: sample at the specified sampling rate, such as 0.02;<br>1: indicates no sampling, that is, precise analysis.<br>The default value is 1.</p>
        /// </summary>
        [JsonProperty("SamplingRate")]
        public float? SamplingRate{ get; set; }

        /// <summary>
        /// <p>true means using the new retrieval result return method, and output parameters AnalysisRecords and Columns are valid.<br>false means using the old retrieval result return method, and output AnalysisResults and ColNames are valid.<br>There is a slight difference in encoding format between the two return methods. Recommend using true.</p>
        /// </summary>
        [JsonProperty("UseNewAnalysis")]
        public bool? UseNewAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether to highlight keywords that meet retrieval criteria, generally used for highlighting. Only key-value retrieval is supported, full-text retrieval is not supported.</p>
        /// </summary>
        [JsonProperty("HighLight")]
        public bool? HighLight{ get; set; }

        /// <summary>
        /// <p><strong>The Query field is deprecated. Please use the QueryString field.</strong><br>Field differences: When the syntax rule is not specified, Query uses Lucene syntax by default, while QueryString uses CQL syntax. For syntax differences, see <a href="https://www.tencentcloud.com/document/product/614/47044?from_cn_redirect=1#RetrievesConditionalRules">Syntax Rule</a>.</p>
        /// </summary>
        [JsonProperty("Query")]
        [System.Obsolete]
        public string Query{ get; set; }

        /// <summary>
        /// <p><strong>The SyntaxRule field is deprecated. Please use the QuerySyntax field.</strong></p><p>Field differences:</p><ul><li>SyntaxRule is used in conjunction with the Query field and uses Lucene syntax by default.</li><li>QuerySyntax is used in conjunction with the QueryString field and uses CQL syntax by default.</li></ul><p>SyntaxRule parameter description:</p><ul><li>0: Lucene syntax</li><li>1: CQL syntax (CLS Query Language, a dedicated retrieval syntax for log service)</li></ul>
        /// </summary>
        [JsonProperty("SyntaxRule")]
        [System.Obsolete]
        public ulong? SyntaxRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "QueryString", this.QueryString);
            this.SetParamSimple(map, prefix + "QuerySyntax", this.QuerySyntax);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamArrayObj(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "SamplingRate", this.SamplingRate);
            this.SetParamSimple(map, prefix + "UseNewAnalysis", this.UseNewAnalysis);
            this.SetParamSimple(map, prefix + "HighLight", this.HighLight);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
        }
    }
}

