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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MergeTableResult : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// If table merging is successful, `null` will be returned
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// Comparison results of tables
        /// </summary>
        [JsonProperty("Table")]
        public CompareTablesInfo Table{ get; set; }

        /// <summary>
        /// Application ID
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamObj(map, prefix + "Table.", this.Table);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
        }
    }
}

