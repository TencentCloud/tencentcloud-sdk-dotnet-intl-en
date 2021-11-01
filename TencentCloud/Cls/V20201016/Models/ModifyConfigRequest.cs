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

    public class ModifyConfigRequest : AbstractModel
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
        /// Log collection path containing the filename
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Type of the log to be collected. Valid values: `json_log`: log in JSON format; `delimiter_log`: log in delimited format; `minimalist_log`: minimalist log; `multiline_log`: log in multi-line format; `fullregex_log`: log in full regex format. Default value: `minimalist_log`
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Extraction rule. If `ExtractRule` is set, `LogType` must be set.
        /// </summary>
        [JsonProperty("ExtractRule")]
        public ExtractRuleInfo ExtractRule{ get; set; }

        /// <summary>
        /// Collection path blocklist
        /// </summary>
        [JsonProperty("ExcludePaths")]
        public ExcludePathInfo[] ExcludePaths{ get; set; }

        /// <summary>
        /// Log topic (TopicId) associated with collection configuration
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Custom parsing string, which is a serialized JSON string
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
        }
    }
}

