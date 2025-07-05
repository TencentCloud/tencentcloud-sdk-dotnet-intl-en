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

    public class AnalysisDimensional : AbstractModel
    {
        
        /// <summary>
        /// Analysis name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Type of data being analyzed. Valid values: `query`, `field`, `original`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Analysis content
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Multi-dimensional analysis configuration.
        /// 
        /// Supported when the type field of Analysis is query (custom){
        /// "Key": "SyntaxRule", // Syntax rules"Value": "1" // 0: Lucene syntax, 1: CQL syntax}
        /// 
        /// Supported when the Type field of Analysis is field (top5) {
        ///     "Key": "QueryIndex",
        /// "Value": "-1" // -1: Custom, 1: Execute Statement 1, 2: Execute Statement 2},{
        /// "Key": "CustomQuery", // Search statement. Valid and required when QueryIndex is -1    "Value": "* | select count(*) as count"
        /// },{
        /// "Key": "SyntaxRule", // If this field cannot be found, it's assumed to be the legacy syntax (Lucene)
        ///     "Value": "0"//0:Lucene, 1:CQL
        /// }       
        /// 
        /// When the Type field of Analysis is original (original log), it supports
        /// {
        ///     "Key": "Fields",
        ///     "Value": "__SOURCE__,__HOSTNAME__,__TIMESTAMP__,__PKG_LOGID__,__TAG__.pod_ip"
        /// }, {
        ///     "Key": "QueryIndex",
        /// "Value": "-1" // -1: Custom, 1: Execute Statement 1, 2: Execute Statement 2},{
        /// "Key": "CustomQuery", // //Search statement. Valid and required when QueryIndex is -1    "Value": "* | select count(*) as count"
        /// },{
        /// "Key": "Format", // Display format. 1: One log per line, 2: One field per line for each log    "Value": "2"
        /// },
        /// {
        /// "Key": "Limit", // Maximum number of logs    "Value": "5"
        /// },{
        /// "Key": "SyntaxRule", // If this field cannot be found, it's considered the legacy syntax
        ///     "Value": "0"//0:Lucene, 1:CQL
        /// }
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConfigInfo")]
        public AlarmAnalysisConfig[] ConfigInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "ConfigInfo.", this.ConfigInfo);
        }
    }
}

