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

    public class RelateTask : AbstractModel
    {
        
        /// <summary>
        /// Task type
        /// 
        /// -OfflineIntegration --- offline integration task.
        /// -RealtimeIntegration --- real-time integration task.
        /// -DataDevelopment - data development task.
        /// -DataQuality - data quality tasks.
        /// -DataService - data service task.
        /// -MetadataCollection --- metadata collection task.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Number of Tasks
        /// </summary>
        [JsonProperty("TaskNum")]
        public long? TaskNum{ get; set; }

        /// <summary>
        /// Task details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskList")]
        public BriefTask[] TaskList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskNum", this.TaskNum);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
        }
    }
}

