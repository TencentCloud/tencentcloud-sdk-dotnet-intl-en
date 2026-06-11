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

    public class ExtractRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>key name for the time field. TimeKey and TimeFormat must appear in pairs</p>
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// <p>Time field format. Refer to the strftime function in C language for time format description output parameter</p><ul><li>See <a href="https://www.tencentcloud.com/document/product/614/38614?from_cn_redirect=1">configure time format</a> document</li></ul>
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// <p>Delimiter for log type. Only valid when LogType is delimiter_log</p>
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// <p>The whole log matching rule is only valid when LogType is fullregex_log</p>
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// <p>First-line matching rule. Valid only when LogType is multiline_log or fullregex_log.</p>
        /// </summary>
        [JsonProperty("BeginRegex")]
        public string BeginRegex{ get; set; }

        /// <summary>
        /// <p>The key name of each field. An empty key means to discard the field. Valid only when LogType is delimiter_log. For json_log, use the key in the json itself. Limited to 100.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// <p>Log filtering rule list (legacy version), keys to be filtered, and corresponding regex.<br> Note: For LogListener 2.9.3 and above versions, it is recommended to use log filtering rules configuration.</p>
        /// </summary>
        [JsonProperty("FilterKeyRegex")]
        public KeyRegexInfo[] FilterKeyRegex{ get; set; }

        /// <summary>
        /// <p>Whether to upload logs that failed to be parsed, true for upload, false for not uploading</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnMatchUpLoadSwitch")]
        public bool? UnMatchUpLoadSwitch{ get; set; }

        /// <summary>
        /// <p>key of the failure log, required when UnMatchUpLoadSwitch is true</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// <p>Backtracking data volume in incremental collection mode. Default: -1 (full collection). Other non-negative numbers indicate incremental collection (backward collection of ${Backtracking} Byte logs from the newest position). Supports up to 1073741824 (1G).<br>Note:</p><ul><li>COS import does not support this field.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Backtracking")]
        public long? Backtracking{ get; set; }

        /// <summary>
        /// <p>Whether it is Gbk encoding. 0: No; 1: Yes.<br>Note</p><ul><li>Currently, a value of 0 indicates UTF-8 encoding.</li><li>COS import does not support this field.</li></ul>
        /// </summary>
        [JsonProperty("IsGBK")]
        public long? IsGBK{ get; set; }

        /// <summary>
        /// <p>Whether it is standard json. 0: No; 1: Yes.</p><ul><li>Standard json means the collector uses industry-standard open-source parsers for json parsing. Non-standard json means the collector uses CLS self-developed json parsers. There is no essential difference between the two parsers. We recommend customers use standard json for parsing.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JsonStandard")]
        public long? JsonStandard{ get; set; }

        /// <summary>
        /// <p>syslog transport protocol, valid values: tcp, udp, this parameter is valid only when LogType is service_syslog, not required for other types.<br>Note:</p><ul><li>This field applies to: create collection rule configuration, modify collection rule configuration.</li><li>COS import does not support this field.</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>syslog system log collection specifies the address and port listened to by the collector, format: [ip]:[port]. This parameter is valid only when LogType is service_syslog. No need to specify for other types.<br>Note:</p><ul><li>This field applies to: create collection rule configuration, modify collection rule configuration.</li><li>COS import does not support this field.</li></ul>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>rfc3164: Specify system log collection using RFC3164 protocol parsing.<br>rfc5424: Specify system log collection using RFC5424 protocol parsing.<br>auto: Automatically match either RFC3164 or RFC5424 protocol.<br>This parameter is valid only when LogType is service_syslog. Not required for other types.<br>Note:</p><ul><li>This field is applicable to: create collection rule configuration, modify collection rule configuration.</li><li>COS import does not support this field.</li></ul>
        /// </summary>
        [JsonProperty("ParseProtocol")]
        public string ParseProtocol{ get; set; }

        /// <summary>
        /// <p>Metadata type. 0: Not use metadata information; 1: Use machine group metadata; 2: Using custom metadata; 3: Use collection configuration path.<br>Note:</p><ul><li>COS import does not support this field.</li></ul>
        /// </summary>
        [JsonProperty("MetadataType")]
        public long? MetadataType{ get; set; }

        /// <summary>
        /// <p>Collection configuration path regular expression.</p><p><pre><code>Use "()" to identify the regular expression corresponding to the target field in the path. During parsing, "()" is considered as a capture group and reported together with logs in the form of __TAG__.{i}:{target field name}, where i is the serial number of the capture group. If you do not want to use the serial number as the key name, you can define a custom key name through the named capturing group "(?&lt;{key name}&gt;{regular expression})" and report it together with logs in the form of __TAG__.{key name}:{target field name}. Supports up to 5 capture groups.</code></pre></p><p>Note:</p><ul><li>Required when MetadataType is 3.</li><li>This field is not supported in COS import.</li></ul>
        /// </summary>
        [JsonProperty("PathRegex")]
        public string PathRegex{ get; set; }

        /// <summary>
        /// <p>User-defined metadata information.<br>Note:</p><ul><li>Required when MetadataType is 2.</li><li>This field is not supported for COS import.</li></ul>
        /// </summary>
        [JsonProperty("MetaTags")]
        public MetaTagInfo[] MetaTags{ get; set; }

        /// <summary>
        /// <p>The Windows Event Log Collection rule is valid only when LogType is windows_event_log. No need to specify for other types.</p>
        /// </summary>
        [JsonProperty("EventLogRules")]
        public EventLog[] EventLogRules{ get; set; }

        /// <summary>
        /// <p>Log filtering rule list (new version).<br>Note:</p><ul><li>LogListener versions below 2.9.3 do not support this. Please use FilterKeyRegex to configure log filter rules.</li><li>Self-built k8s collection configuration (CreateConfigExtra, ModifyConfigExtra) does not support this field.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdvanceFilterRules")]
        public AdvanceFilterRuleInfo[] AdvanceFilterRules{ get; set; }

        /// <summary>
        /// <p>Key name of raw logs. All raw logs are uploaded with the Key name you specified, and the original log content as Value. If left empty, raw log upload is disabled.</p><ul><li>COS import does not support this field.</li></ul>
        /// </summary>
        [JsonProperty("RawLogKey")]
        public string RawLogKey{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "AdvanceFilterRules.", this.AdvanceFilterRules);
            this.SetParamSimple(map, prefix + "RawLogKey", this.RawLogKey);
        }
    }
}

