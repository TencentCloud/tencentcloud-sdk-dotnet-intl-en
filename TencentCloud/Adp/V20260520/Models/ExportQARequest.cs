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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportQARequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the knowledge base it belongs to</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Filter conditions (multiple Filters are in an AND relationship, and multiple Values of the same Filter are in an OR relationship): Status-QA status, enumeration value, exact match; CategoryId-category ID, exact match; SourceType-QA source type, enumeration value, exact match; EffectiveDomain-application scope, exact match; DocId-associated document ID, exact match; CreateTime-creation time, Unix seconds, BETWEEN passes [start second, end second]; UpdateTime-update time, Unix seconds, BETWEEN passes [start second, end second]; QaId-QA ID list, exact match, supports multiple values</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Query condition (keyword + query scope), consistent with DescribeQASummaryList</p>
        /// </summary>
        [JsonProperty("Query")]
        public QAQuery Query{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamObj(map, prefix + "Query.", this.Query);
        }
    }
}

