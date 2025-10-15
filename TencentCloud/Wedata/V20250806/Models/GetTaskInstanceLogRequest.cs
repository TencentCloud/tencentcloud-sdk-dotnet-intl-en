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

    public class GetTaskInstanceLogRequest : AbstractModel
    {
        
        /// <summary>
        /// **Project ID**. specifies the project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **Instance unique id**.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// **Instance Lifecycle Number** - Identifies a specific execution of an instance.
        /// For example: the first run of a cyclic instance has a lifecycle number of 0. If the user reruns that instance later, the second execution will have a lifecycle number of 1;
        /// By default, the latest execution is used.
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

        /// <summary>
        /// **Log level** default All - Info - Debug - Warn - Error - All.
        /// </summary>
        [JsonProperty("LogLevel")]
        public string LogLevel{ get; set; }

        /// <summary>
        /// **Used when performing paginated log queries; has no specific business meaning.**
        /// 
        /// For the first query, the value is null.
        /// 
        /// For subsequent queries, use the value of the NextCursor field returned from the previous query.
        /// </summary>
        [JsonProperty("NextCursor")]
        public string NextCursor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
        }
    }
}

