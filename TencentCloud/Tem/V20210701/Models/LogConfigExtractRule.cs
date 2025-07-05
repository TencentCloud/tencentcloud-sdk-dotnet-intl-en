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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogConfigExtractRule : AbstractModel
    {
        
        /// <summary>
        /// First line regex
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("BeginningRegex")]
        public string BeginningRegex{ get; set; }

        /// <summary>
        /// Withdrawl result
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// Filter keys
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FilterKeys")]
        public string[] FilterKeys{ get; set; }

        /// <summary>
        /// Filter values
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FilterRegex")]
        public string[] FilterRegex{ get; set; }

        /// <summary>
        /// Log regex
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// Time field
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// Time Format
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// - Enable the upload of the log that failed to parse
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UnMatchUpload")]
        public string UnMatchUpload{ get; set; }

        /// <summary>
        /// Key of log failed to be parsed
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UnMatchedKey")]
        public string UnMatchedKey{ get; set; }

        /// <summary>
        /// tracking
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Backtracking")]
        public string Backtracking{ get; set; }

        /// <summary>
        /// Separator
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginningRegex", this.BeginningRegex);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamArraySimple(map, prefix + "FilterKeys.", this.FilterKeys);
            this.SetParamArraySimple(map, prefix + "FilterRegex.", this.FilterRegex);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "UnMatchUpload", this.UnMatchUpload);
            this.SetParamSimple(map, prefix + "UnMatchedKey", this.UnMatchedKey);
            this.SetParamSimple(map, prefix + "Backtracking", this.Backtracking);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
        }
    }
}

