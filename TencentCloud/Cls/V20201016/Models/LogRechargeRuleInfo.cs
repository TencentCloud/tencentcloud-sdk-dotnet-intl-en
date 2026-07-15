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

    public class LogRechargeRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Import type, support json_log: JSON logs, minimalist_log: single-line full-text log, fullregex_log: single-line full regular expression</p>
        /// </summary>
        [JsonProperty("RechargeType")]
        public string RechargeType{ get; set; }

        /// <summary>
        /// <p>Parse encoding format. 0: UTF-8 (default value), 1: GBK</p>
        /// </summary>
        [JsonProperty("EncodingFormat")]
        public ulong? EncodingFormat{ get; set; }

        /// <summary>
        /// <p>Use default time status. true: once enabled, current system time or Kafka message timestamp will be used as log timestamp; false: when turned off, time field in the log will be used as log timestamp. Default: true</p>
        /// </summary>
        [JsonProperty("DefaultTimeSwitch")]
        public bool? DefaultTimeSwitch{ get; set; }

        /// <summary>
        /// <p>The whole log matching rule is valid only when RechargeType is fullregex_log.</p>
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// <p>Whether to upload logs that failed to be parsed. true for upload, false for not uploading.</p>
        /// </summary>
        [JsonProperty("UnMatchLogSwitch")]
        public bool? UnMatchLogSwitch{ get; set; }

        /// <summary>
        /// <p>Key name of parsing-failed logs</p>
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// <p>Parsing failure log time source. 0: Current system time. 1: Kafka message timestamp.</p>
        /// </summary>
        [JsonProperty("UnMatchLogTimeSrc")]
        public ulong? UnMatchLogTimeSrc{ get; set; }

        /// <summary>
        /// <p>Default time source. 0: Current system time, 1: Kafka message timestamp</p>
        /// </summary>
        [JsonProperty("DefaultTimeSrc")]
        public ulong? DefaultTimeSrc{ get; set; }

        /// <summary>
        /// <p>Time field. Field name that represents time in logs.</p><ul><li>When DefaultTimeSwitch is false and the RechargeType data extraction mode is <code>json_log</code> JSON-file log or <code>fullregex_log</code> single-line full regex-file log, the TimeKey cannot be empty.</li></ul>
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// <p>Time extraction regular expression.</p><ul><li>When DefaultTimeSwitch is false and the RechargeType data extraction mode is <code>minimalist_log</code> single-line full text - file log, the TimeRegex cannot be empty.</li><li>Only need to input the regular expression for the field representing time in logs. If multiple fields are matched to, the first one will be used.<br> For example: If the original log is: message with time 2022-08-08 14:20:20, you can set the retrieval time regular expression to \d\d\d\d-\d\d-\d\d \d\d:\d\d:\d\d</li></ul>
        /// </summary>
        [JsonProperty("TimeRegex")]
        public string TimeRegex{ get; set; }

        /// <summary>
        /// <p>Time field format.</p><ul><li>When DefaultTimeSwitch is false, TimeFormat cannot be empty.</li></ul>
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// <p>Time field time zone.</p><ul><li><p>When DefaultTimeSwitch is false, TimeZone cannot be empty.</p></li><li><p>Time zone format rule<br>Prefix: Use GMT or UTC as the time zone benchmark<br>Offset:</p><ul><li><code>-</code> indicates a western time zone (later than the benchmark time)</li><li><code>+</code> indicates an eastern time zone (earlier than the benchmark time)</li><li>Format is ±HH:MM (hour:minute)</li></ul></li><li><p>Currently supported:<br><pre><code>&quot;GMT-12:00&quot; &quot;GMT-11:00&quot; &quot;GMT-10:00&quot; &quot;GMT-09:30&quot; &quot;GMT-09:00&quot; &quot;GMT-08:00&quot; &quot;GMT-07:00&quot; &quot;GMT-06:00&quot; &quot;GMT-05:00&quot; &quot;GMT-04:00&quot; &quot;GMT-03:30&quot; &quot;GMT-03:00&quot; &quot;GMT-02:00&quot; &quot;GMT-01:00&quot; &quot;GMT+00:00&quot;&quot;GMT+01:00&quot;&quot;GMT+02:00&quot;&quot;GMT+03:30&quot;&quot;GMT+04:00&quot;&quot;GMT+04:30&quot;&quot;GMT+05:00&quot;&quot;GMT+05:30&quot;&quot;GMT+05:45&quot;&quot;GMT+06:00&quot;&quot;GMT+06:30&quot;&quot;GMT+07:00&quot;&quot;GMT+08:00&quot;&quot;GMT+09:00&quot;&quot;GMT+09:30&quot;&quot;GMT+10:00&quot;&quot;GMT+10:30&quot;&quot;GMT+11:00&quot;&quot;GMT+11:30&quot;&quot;GMT+12:00&quot;&quot;GMT+12:45&quot;&quot;GMT+13:00&quot;&quot;GMT+14:00&quot;&quot;UTC-11:00&quot;&quot;UTC-10:00&quot;&quot;UTC-09:00&quot;&quot;UTC-08:00&quot;&quot;UTC-12:00&quot;&quot;UTC-07:00&quot;&quot;UTC-06:00&quot;&quot;UTC-05:00&quot;&quot;UTC-04:30&quot;&quot;UTC-04:00&quot;&quot;UTC-03:30&quot;&quot;UTC-03:00&quot;&quot;UTC-02:00&quot;&quot;UTC-01:00&quot;&quot;UTC+00:00&quot;&quot;UTC+01:00&quot;&quot;UTC+02:00&quot;&quot;UTC+03:00&quot;&quot;UTC+03:30&quot;&quot;UTC+04:00&quot;&quot;UTC+04:30&quot;&quot;UTC+05:00&quot;&quot;UTC+05:45&quot;&quot;UTC+06:00&quot;&quot;UTC+06:30&quot;&quot;UTC+07:00&quot;&quot;UTC+08:00&quot;&quot;UTC+09:00&quot;&quot;UTC+09:30&quot;&quot;UTC+10:00&quot;&quot;UTC+11:00&quot;&quot;UTC+12:00&quot;&quot;UTC+13:00&quot;</code></pre></p></li></ul>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>Metadata information, Kafka import supports kafka_topic, kafka_partition, kafka_offset, kafka_timestamp</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public string[] Metadata{ get; set; }

        /// <summary>
        /// <p>log Key list, required when RechargeType is full_regex_log or delimiter_log.</p>
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// <p>json parsing mode, enable first level data parsing</p>
        /// </summary>
        [JsonProperty("ParseArray")]
        public bool? ParseArray{ get; set; }

        /// <summary>
        /// <p>Delimiter parsing mode - Separator<br>This field is required when the parsing format is delimiter extraction.</p>
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// <p>JSON nest unfold configuration. This parameter is valid only when RechargeType is json_log. If it is not passed, it is disabled.</p>
        /// </summary>
        [JsonProperty("JsonExpand")]
        public JsonExpandInfo JsonExpand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RechargeType", this.RechargeType);
            this.SetParamSimple(map, prefix + "EncodingFormat", this.EncodingFormat);
            this.SetParamSimple(map, prefix + "DefaultTimeSwitch", this.DefaultTimeSwitch);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "UnMatchLogSwitch", this.UnMatchLogSwitch);
            this.SetParamSimple(map, prefix + "UnMatchLogKey", this.UnMatchLogKey);
            this.SetParamSimple(map, prefix + "UnMatchLogTimeSrc", this.UnMatchLogTimeSrc);
            this.SetParamSimple(map, prefix + "DefaultTimeSrc", this.DefaultTimeSrc);
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeRegex", this.TimeRegex);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "Metadata.", this.Metadata);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "ParseArray", this.ParseArray);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamObj(map, prefix + "JsonExpand.", this.JsonExpand);
        }
    }
}

