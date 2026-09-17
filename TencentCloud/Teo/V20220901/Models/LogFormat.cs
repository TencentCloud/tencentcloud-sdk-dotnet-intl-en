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
        /// <p>Log output format. Valid values:</p><ul><li>json: Use the predefined log output format JSON Lines, where each log entry is presented as key-value pairs;</li><li>csv: Use the predefined log output format CSV, where each log entry presents only field values, not field names.</li><li>template: Use a user-customized output template. Each log entry supports custom layout and concatenation based on the custom template, in conjunction with the RecordTemplate field.</li></ul>
        /// </summary>
        [JsonProperty("FormatType")]
        public string FormatType{ get; set; }

        /// <summary>
        /// <p>A string added before each log delivery batch. Each log delivery batch may contain multiple log records.</p>
        /// </summary>
        [JsonProperty("BatchPrefix")]
        public string BatchPrefix{ get; set; }

        /// <summary>
        /// <p>A string appended after each log delivery batch.</p>
        /// </summary>
        [JsonProperty("BatchSuffix")]
        public string BatchSuffix{ get; set; }

        /// <summary>
        /// <p>Log prefix, a string added before each log record.</p>
        /// </summary>
        [JsonProperty("RecordPrefix")]
        public string RecordPrefix{ get; set; }

        /// <summary>
        /// <p>Single-line log suffix, a string appended after each log record.</p>
        /// </summary>
        [JsonProperty("RecordSuffix")]
        public string RecordSuffix{ get; set; }

        /// <summary>
        /// <p>Log separator, a string inserted between log records as a separator. Valid values:</p><ul><li>\n: line break;</li><li>\t: tab character;</li><li>,: half-width comma.</li></ul>
        /// </summary>
        [JsonProperty("RecordDelimiter")]
        public string RecordDelimiter{ get; set; }

        /// <summary>
        /// <p>Log template, output template for a single log, length limited to 4KB, takes effect only when FormatType = template. Supports custom layout and concatenation of configured push fields according to the template.</p>
        /// </summary>
        [JsonProperty("RecordTemplate")]
        public string RecordTemplate{ get; set; }

        /// <summary>
        /// <p>Field separator, a string inserted between fields within a single log record as a separator. It takes effect only when FormatType = csv. Valid values:</p><ul><li>\t: tab character;</li><li>,: half-width comma;</li><li>;: half-width semicolon.</li></ul>
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
            this.SetParamSimple(map, prefix + "RecordTemplate", this.RecordTemplate);
            this.SetParamSimple(map, prefix + "FieldDelimiter", this.FieldDelimiter);
        }
    }
}

