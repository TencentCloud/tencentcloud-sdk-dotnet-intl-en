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

    public class ExtractRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Key name for the time field. TikeKey and TimeFormat must appear in pairsNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// Time field format. For more information, please see the output parameters of the time format description of the `strftime` function in C language
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// Delimiter for log type. Valid only when LogType is delimiter_logNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// Full log matching rule. Valid only if LogType is fullregex_logNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// Line beginning matching rule, valid only if LogType is multiline_log or fullregex_logNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BeginRegex")]
        public string BeginRegex{ get; set; }

        /// <summary>
        /// Key name of each extracted field. An empty key indicates discarding the field. Valid only if LogType is delimiter_log. json_log logs use the key of JSON itself. Limited to 100.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// Log filter rule list (previous version), keys to be filtered in the log and their corresponding regex.Note: For LogListener version 2.9.3 and later, it is recommended to use the AdvanceFilterRules configuration for log filtering.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilterKeyRegex")]
        public KeyRegexInfo[] FilterKeyRegex{ get; set; }

        /// <summary>
        /// Whether to upload the logs that failed to be parsed. Valid values: `true`: yes; `false`: no
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnMatchUpLoadSwitch")]
        public bool? UnMatchUpLoadSwitch{ get; set; }

        /// <summary>
        /// Unmatched log key
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// Backtracking data volume under incremental collection pattern, default -1 indicates full collection; other non-negative numbers indicate incremental collection (collect logs backward from the latest position by ${Backtracking} bytes) with a maximum support of 1073741824 (1G).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Backtracking")]
        public long? Backtracking{ get; set; }

        /// <summary>
        /// Whether to be encoded in GBK format. Valid values: `0` (No) and `1` (Yes).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsGBK")]
        public long? IsGBK{ get; set; }

        /// <summary>
        /// Whether to be formatted as JSON (standard). Valid values: `0` (No) and `1` (Yes).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JsonStandard")]
        public long? JsonStandard{ get; set; }

        /// <summary>
        /// Syslog protocol. Valid values: `tcp`, `udp`.
        /// This field can be used when you create or modify collection rule configurations.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Listening address and port specified by the syslog collection. Format: [ip]:[port]. Example: 127.0.0.1:9000.
        /// This field can be used when you create or modify collection rule configurations.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// `rfc3164`: Resolve logs by using the RFC 3164 protocol during the syslog collection.
        /// `rfc5424`: Resolve logs by using the RFC 5424 protocol during the syslog collection.
        /// `auto`: Automatically match either the RFC 3164 or RFC 5424 protocol.
        /// This field can be used when you create or modify collection rule configurations.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParseProtocol")]
        public string ParseProtocol{ get; set; }

        /// <summary>
        /// Metadata type. Valid values:
        /// 0: Do not use metadata.
        /// 1: Use machine group metadata.
        /// 2: Use user-defined metadata.
        /// 3: Use the collection path to extract metadata.
        /// </summary>
        [JsonProperty("MetadataType")]
        public long? MetadataType{ get; set; }

        /// <summary>
        /// Regular expression of the collection configuration path, which is required when `MetadataType` is set to `3`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PathRegex")]
        public string PathRegex{ get; set; }

        /// <summary>
        /// User-defined metadata, which is required when `MetadataType` is set to `2`.
        /// </summary>
        [JsonProperty("MetaTags")]
        public MetaTagInfo[] MetaTags{ get; set; }

        /// <summary>
        /// Windows event log collection
        /// </summary>
        [JsonProperty("EventLogRules")]
        public EventLog[] EventLogRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "BeginRegex", this.BeginRegex);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamArrayObj(map, prefix + "FilterKeyRegex.", this.FilterKeyRegex);
            this.SetParamSimple(map, prefix + "UnMatchUpLoadSwitch", this.UnMatchUpLoadSwitch);
            this.SetParamSimple(map, prefix + "UnMatchLogKey", this.UnMatchLogKey);
            this.SetParamSimple(map, prefix + "Backtracking", this.Backtracking);
            this.SetParamSimple(map, prefix + "IsGBK", this.IsGBK);
            this.SetParamSimple(map, prefix + "JsonStandard", this.JsonStandard);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "ParseProtocol", this.ParseProtocol);
            this.SetParamSimple(map, prefix + "MetadataType", this.MetadataType);
            this.SetParamSimple(map, prefix + "PathRegex", this.PathRegex);
            this.SetParamArrayObj(map, prefix + "MetaTags.", this.MetaTags);
            this.SetParamArrayObj(map, prefix + "EventLogRules.", this.EventLogRules);
        }
    }
}

