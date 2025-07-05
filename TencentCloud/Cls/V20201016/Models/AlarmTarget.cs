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

    public class AlarmTarget : AbstractModel
    {
        
        /// <summary>
        /// Log topic IDNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Query statementNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Serial number of alarm object, which is incremental from 1.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }

        /// <summary>
        /// Offset of the query start time from the alarm execution time in minutes. The value cannot be positive. Maximum value: 0. Minimum value: -1440.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public long? StartTimeOffset{ get; set; }

        /// <summary>
        /// Offset of the query end time from the alarm execution time in minutes. The value cannot be positive and must be greater than StartTimeOffset. Maximum value: 0. Minimum value: -1440.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public long? EndTimeOffset{ get; set; }

        /// <summary>
        /// Logset IDNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// Search syntax rules; default value: 0.0: Lucene syntax; 1: CQL syntax.For detailed instructions, see <a href="https://intl.cloud.tencent.com/document/product/614/47044?from_cn_redirect=1#RetrievesConditionalRules" target="_blank">Search Condition Syntax Rules</a>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
        }
    }
}

