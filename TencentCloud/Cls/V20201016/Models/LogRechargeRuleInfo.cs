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

    public class LogRechargeRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Import type. Valid values: `json_log` (JSON logs), `minimalist_log` (single-line full text), and fullregex_log u200d(single-line full regex)
        /// </summary>
        [JsonProperty("RechargeType")]
        public string RechargeType{ get; set; }

        /// <summary>
        /// Encoding format. Valid values: 0 (default, UTF-8) and 1 GBK).
        /// </summary>
        [JsonProperty("EncodingFormat")]
        public ulong? EncodingFormat{ get; set; }

        /// <summary>
        /// Whether to use the default time. Valid values: `true` (default) and `false`.
        /// </summary>
        [JsonProperty("DefaultTimeSwitch")]
        public bool? DefaultTimeSwitch{ get; set; }

        /// <summary>
        /// Full log matching rule, which is valid only if `RechargeType` is `fullregex_log`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// Whether to upload the logs that failed to be parsed. Valid values: `true` and `false`.
        /// </summary>
        [JsonProperty("UnMatchLogSwitch")]
        public bool? UnMatchLogSwitch{ get; set; }

        /// <summary>
        /// Key of the log that failed to be parsed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// Time source of the log that failed to be parsed. Valid values: 0 (current system time) and 1 (Kafka message timestamp).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnMatchLogTimeSrc")]
        public ulong? UnMatchLogTimeSrc{ get; set; }

        /// <summary>
        /// Default time source. Valid values: 0 (current system time) and 1 (Kafka message timestamp).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultTimeSrc")]
        public ulong? DefaultTimeSrc{ get; set; }

        /// <summary>
        /// Time field
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// Time regular expression
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeRegex")]
        public string TimeRegex{ get; set; }

        /// <summary>
        /// Time field format
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// Time zone
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// Metadata information. Kafka supports import of kafka_topic, kafka_partition, kafka_offset, and kafka_timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Metadata")]
        public string[] Metadata{ get; set; }

        /// <summary>
        /// List of log keys, which is required when `RechargeType` is set to `full_regex_log`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }


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
        }
    }
}

