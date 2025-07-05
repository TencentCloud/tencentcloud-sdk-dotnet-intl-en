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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFormat : AbstractModel
    {
        
        /// <summary>
        /// Predefined output format for log shipping. Valid values:
        /// <li>json: Use JSON Lines as the predefined log output format. In each log entry, fields are displayed as key-value pairs.</li>
        /// <li>csv: Use the predefined log output format csv, where each log entry only is presented as field values only, excluding field names. </li>
        /// </summary>
        [JsonProperty("FormatType")]
        public string FormatType{ get; set; }

        /// <summary>
        /// A string added before each log delivery batch. Each log delivery batch may contain multiple log records.
        /// </summary>
        [JsonProperty("BatchPrefix")]
        public string BatchPrefix{ get; set; }

        /// <summary>
        /// A string appended after each log delivery batch.
        /// </summary>
        [JsonProperty("BatchSuffix")]
        public string BatchSuffix{ get; set; }

        /// <summary>
        /// A string added before each log record.
        /// </summary>
        [JsonProperty("RecordPrefix")]
        public string RecordPrefix{ get; set; }

        /// <summary>
        /// A string appended after each log record.
        /// </summary>
        [JsonProperty("RecordSuffix")]
        public string RecordSuffix{ get; set; }

        /// <summary>
        /// A string inserted between log records as a separator. Valid values:
        /// <li>\n: line break;</li>
        /// <li>\t: tab character;</li>
        /// <li>,: Half-width comma. </li>
        /// </summary>
        [JsonProperty("RecordDelimiter")]
        public string RecordDelimiter{ get; set; }

        /// <summary>
        /// A string inserted between fields as a separator within a single log record. Valid values:
        /// <li>\t: tab character;</li>
        /// <li>,: half-width comma;</li>
        /// <li>;: Half-width semicolon. </li>
        /// </summary>
        [JsonProperty("FieldDelimiter")]
        public string FieldDelimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FormatType", this.FormatType);
            this.SetParamSimple(map, prefix + "BatchPrefix", this.BatchPrefix);
            this.SetParamSimple(map, prefix + "BatchSuffix", this.BatchSuffix);
            this.SetParamSimple(map, prefix + "RecordPrefix", this.RecordPrefix);
            this.SetParamSimple(map, prefix + "RecordSuffix", this.RecordSuffix);
            this.SetParamSimple(map, prefix + "RecordDelimiter", this.RecordDelimiter);
            this.SetParamSimple(map, prefix + "FieldDelimiter", this.FieldDelimiter);
        }
    }
}

