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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceLog : AbstractModel
    {
        
        /// <summary>
        /// Instance unique id.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// Project ID.
        /// 
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Specifies the code content to run.
        /// </summary>
        [JsonProperty("CodeContent")]
        public string CodeContent{ get; set; }

        /// <summary>
        /// log information
        /// </summary>
        [JsonProperty("LogInfo")]
        public string LogInfo{ get; set; }

        /// <summary>
        /// Used for paginated log queries; has no specific business meaning.
        /// 
        /// For the first query, set the value to null.
        /// 
        /// For subsequent queries, use the NextCursor value returned from the previous query.
        /// </summary>
        [JsonProperty("NextCursor")]
        public string NextCursor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CodeContent", this.CodeContent);
            this.SetParamSimple(map, prefix + "LogInfo", this.LogInfo);
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
        }
    }
}

