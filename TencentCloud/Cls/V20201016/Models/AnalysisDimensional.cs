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
        /// Analysis Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Analysis type: query (custom retrieval and analysis), field (TOP5 fields and proportion statistics), original (related raw logs)
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Analysis content
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Multi-dimensional analysis configuration.
        /// 
        /// When the Type field of Analysis is query (custom), support
        /// {
        /// "Key": "SyntaxRule",  // Syntax rule
        /// "Value": "1"  //0: Lucene syntax, 1: CQL syntax
        /// }
        /// 
        /// When the Type field of Analysis is field (top5), it supports
        ///  {
        ///     "Key": "QueryIndex",
        /// "Value": "-1" // -1: Custom, 1: Execute statement 1, 2: Execute statement 2
        /// },{
        /// "Key": "CustomQuery", //Query statement. Required and valid when QueryIndex is -1.
        ///     "Value": "* | select count(*) as count"
        /// },{
        /// "Key": "SyntaxRule", // If this field cannot be found, it's assumed to be the legacy syntax (Lucene)
        ///     "Value": "0"//0:Lucene, 1:CQL
        /// }       
        /// 
        /// When the Type field of Analysis is original (raw log), it supports
        /// {
        ///     "Key": "Fields",
        ///     "Value": "__SOURCE__,__HOSTNAME__,__TIMESTAMP__,__PKG_LOGID__,__TAG__.pod_ip"
        /// }, {
        ///     "Key": "QueryIndex",
        /// "Value": "-1" // -1: Custom, 1: Execute statement 1, 2: Execute statement 2
        /// },{
        /// "Key": "CustomQuery", // Retrieval statement. Required and valid when QueryIndex is -1.
        ///     "Value": "* | select count(*) as count"
        /// },{
        /// "Key": "Format", //Display format. 1: one log per line, 2: one field per line for each log entry
        ///     "Value": "2"
        /// },
        /// {
        /// "Key": "Limit", //Maximum number of logs
        ///     "Value": "5"
        /// },{
        /// "Key": "SyntaxRule", // If this field is not found, it's also the old syntax
        ///     "Value": "0"//0:Lucene, 1:CQL
        /// }
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

