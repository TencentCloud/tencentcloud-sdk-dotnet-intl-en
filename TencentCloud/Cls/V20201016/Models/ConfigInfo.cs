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

    public class ConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// Collection rule configuration ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// Collection rule configuration name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Log formatting method
        /// </summary>
        [JsonProperty("LogFormat")]
        public string LogFormat{ get; set; }

        /// <summary>
        /// log collection path
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Type of log collected.
        /// -json_log represents JSON file logs (see [Use JSON extraction mode to collect logs](https://www.tencentcloud.com/document/product/614/17419?from_cn_redirect=1)).
        /// -delimiter_log represents: delimiter-file logs (see [use delimiter extraction mode to collect logs](https://www.tencentcloud.com/document/product/614/17420?from_cn_redirect=1)).
        /// -minimalist_log represents single-line full-text file logs (see [use single-line full-text extraction mode to collect logs](https://www.tencentcloud.com/document/product/614/17421?from_cn_redirect=1)).
        /// -fullregex_log represents single-line full regex-file logs (see [Collect logs using single-line full regex extraction mode](https://www.tencentcloud.com/document/product/614/52365?from_cn_redirect=1)).
        /// -multiline_log represents multi-line full-text file logs (see [use multi-line full-text extraction mode to collect logs](https://www.tencentcloud.com/document/product/614/17422?from_cn_redirect=1)).
        /// -multiline_fullregex_log represents: Multiline full regex-file log (see [Collect logs using multiline-full regex extraction mode](https://www.tencentcloud.com/document/product/614/52366?from_cn_redirect=1));
        /// -user_define_log represents: combined parsing mode (suitable for logs with multiple nested formats, see [Collecting logs using combined parsing extraction mode](https://www.tencentcloud.com/document/product/614/61310?from_cn_redirect=1));
        /// -service_syslog represents syslog collection (see [Collect Syslog](https://www.tencentcloud.com/document/product/614/81454?from_cn_redirect=1)).
        /// - windows_event_log: Windows event log (see [Collecting Windows Event Logs](https://www.tencentcloud.com/document/product/614/96678?from_cn_redirect=1)).
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Extraction rule. If ExtractRule is set, then LogType must be set.
        /// </summary>
        [JsonProperty("ExtractRule")]
        public ExtractRuleInfo ExtractRule{ get; set; }

        /// <summary>
        /// Collection path blocklist
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExcludePaths")]
        public ExcludePathInfo[] ExcludePaths{ get; set; }

        /// <summary>
        /// Log topic ID (TopicId) of collection configuration
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Update time
        /// -Time format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// -Time format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Custom parsing string. For more information, see [Collecting logs using combined parsing extraction mode](https://www.tencentcloud.com/document/product/614/61310?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }

        /// <summary>
        /// Advanced collection configuration. Json string, Key/Value is defined as follows:
        /// -ClsAgentFileTimeout (timeout attribute). Value ranges from 0 to integer. 0 means no timeout.
        /// -ClsAgentMaxDepth (maximum directory depth), value ranges from 0 to integer
        /// -ClsAgentParseFailMerge (merge parsing failure logs). Value ranges from true to false.
        /// Example:
        /// `{\"ClsAgentFileTimeout\":0,\"ClsAgentMaxDepth\":10,\"ClsAgentParseFailMerge\":true}`
        /// 
        /// Default placeholder value in console: `{\"ClsAgentDefault\":0}`
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public string AdvancedConfig{ get; set; }

        /// <summary>
        /// Log input type (<span style="color:red; font-weight:bold">Note: required for Windows scenario and only supports file and windows_event event type</span>)
        /// -file type collection
        /// -windows event collection
        /// -syslog: System log collection
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LogFormat", this.LogFormat);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
            this.SetParamSimple(map, prefix + "AdvancedConfig", this.AdvancedConfig);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
        }
    }
}

