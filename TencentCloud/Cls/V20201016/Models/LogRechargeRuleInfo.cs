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
        /// Import type. Valid values: `json_log` (JSON logs), `minimalist_log` (single-line full text), and fullregex_log (single-line full regex)
        /// </summary>
        [JsonProperty("RechargeType")]
        public string RechargeType{ get; set; }

        /// <summary>
        /// Encoding format. Valid values: 0 (default, UTF-8) and 1 GBK).
        /// </summary>
        [JsonProperty("EncodingFormat")]
        public ulong? EncodingFormat{ get; set; }

        /// <summary>
        /// Use default time status. true: when enabled, current system time or Kafka message timestamp will be used as log timestamp. false: when disabled, time field in the log will be used as log timestamp. Default: true.
        /// </summary>
        [JsonProperty("DefaultTimeSwitch")]
        public bool? DefaultTimeSwitch{ get; set; }

        /// <summary>
        /// Full log matching rule. It is valid only when RechargeType is fullregex_log.
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// Whether to upload the logs that failed to be parsed. Valid values: `true` and `false`.
        /// </summary>
        [JsonProperty("UnMatchLogSwitch")]
        public bool? UnMatchLogSwitch{ get; set; }

        /// <summary>
        /// key name of parsing-failed logs
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// Time source for parsing failure logs. 0: current time of the system; 1: Kafka message timestamp.
        /// </summary>
        [JsonProperty("UnMatchLogTimeSrc")]
        public ulong? UnMatchLogTimeSrc{ get; set; }

        /// <summary>
        /// Default time source. 0: Current system time; 1: Kafka message timestamp.
        /// </summary>
        [JsonProperty("DefaultTimeSrc")]
        public ulong? DefaultTimeSrc{ get; set; }

        /// <summary>
        /// Time field. Field name representing time in logs.
        /// 
        /// -When DefaultTimeSwitch is false and RechargeType data extraction mode is `json_log` JSON file log or `fullregex_log` single-line full regex file log, TimeKey cannot be empty.
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// Time extraction regular expression.
        /// -When DefaultTimeSwitch is false and the data extraction mode of RechargeType is `minimalist_log` (single-line full text - file log), TimeRegex cannot be empty.
        /// -Only need to input the regular expression representing the time field in logs. If multiple fields are matched to, the first will be used.
        /// Example: The original log is "message with time 2022-08-08 14:20:20". You can set the retrieval time regex to \d\d\d\d-\d\d-\d\d \d\d:\d\d:\d\d.
        /// </summary>
        [JsonProperty("TimeRegex")]
        public string TimeRegex{ get; set; }

        /// <summary>
        /// Time field format.
        /// -When DefaultTimeSwitch is false, TimeFormat cannot be empty.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// Time field time zone.
        /// -When DefaultTimeSwitch is false, TimeZone cannot be empty.
        /// -Time zone format rule
        /// Prefix: Use GMT or UTC as the time zone benchmark.
        /// Offset:
        /// -`-` indicates a western time zone (later than the benchmark time).
        /// -`+` means the east time zone (earlier than the benchmark time).
        /// -Format ±HH:MM (hr:min)
        /// 
        /// -Currently supported:
        /// ```
        /// "GMT-12:00" 
        /// "GMT-11:00" 
        /// "GMT-10:00" 
        /// "GMT-09:30" 
        /// "GMT-09:00" 
        /// "GMT-08:00" 
        /// "GMT-07:00" 
        /// "GMT-06:00" 
        /// "GMT-05:00" 
        /// "GMT-04:00" 
        /// "GMT-03:30" 
        /// "GMT-03:00" 
        /// "GMT-02:00" 
        /// "GMT-01:00" 
        /// "GMT+00:00"
        /// "GMT+01:00"
        /// "GMT+02:00"
        /// "GMT+03:30"
        /// "GMT+04:00"
        /// "GMT+04:30"
        /// "GMT+05:00"
        /// "GMT+05:30"
        /// "GMT+05:45"
        /// "GMT+06:00"
        /// "GMT+06:30"
        /// "GMT+07:00"
        /// "GMT+08:00"
        /// "GMT+09:00"
        /// "GMT+09:30"
        /// "GMT+10:00"
        /// "GMT+10:30"
        /// "GMT+11:00"
        /// "GMT+11:30"
        /// "GMT+12:00"
        /// "GMT+12:45"
        /// "GMT+13:00"
        /// "GMT+14:00"
        /// "UTC-11:00"
        /// "UTC-10:00"
        /// "UTC-09:00"
        /// "UTC-08:00"
        /// "UTC-12:00"
        /// "UTC-07:00"
        /// "UTC-06:00"
        /// "UTC-05:00"
        /// "UTC-04:30"
        /// "UTC-04:00"
        /// "UTC-03:30"
        /// "UTC-03:00"
        /// "UTC-02:00"
        /// "UTC-01:00"
        /// "UTC+00:00"
        /// "UTC+01:00"
        /// "UTC+02:00"
        /// "UTC+03:00"
        /// "UTC+03:30"
        /// "UTC+04:00"
        /// "UTC+04:30"
        /// "UTC+05:00"
        /// "UTC+05:45"
        /// "UTC+06:00"
        /// "UTC+06:30"
        /// "UTC+07:00"
        /// "UTC+08:00"
        /// "UTC+09:00"
        /// "UTC+09:30"
        /// "UTC+10:00"
        /// "UTC+11:00"
        /// "UTC+12:00"
        /// "UTC+13:00"
        /// ```
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// Metadata information. Kafka import supports kafka_topic, kafka_partition, kafka_offset, and kafka_timestamp.
        /// </summary>
        [JsonProperty("Metadata")]
        public string[] Metadata{ get; set; }

        /// <summary>
        /// log Key list. It is required when RechargeType is full_regex_log or delimiter_log.
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// JSON parsing mode. The first-level data parsing is enabled.
        /// </summary>
        [JsonProperty("ParseArray")]
        public bool? ParseArray{ get; set; }

        /// <summary>
        /// Delimiter parsing mode - Separator
        /// This field is required when the parsing format is delimiter extraction.
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }


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
        }
    }
}

