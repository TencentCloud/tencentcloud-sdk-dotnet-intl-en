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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// Engine task id.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineTaskId")]
        public string EngineTaskId{ get; set; }

        /// <summary>
        /// Engine execution status, enumerate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineExeStatus")]
        public string EngineExeStatus{ get; set; }

        /// <summary>
        /// Engine execution start time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineExeStartTime")]
        public string EngineExeStartTime{ get; set; }

        /// <summary>
        /// Engine execution end time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineExeEndTime")]
        public string EngineExeEndTime{ get; set; }

        /// <summary>
        /// Task type id.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// Business information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusinessInfo")]
        public string BusinessInfo{ get; set; }

        /// <summary>
        /// Engine task information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineTaskInfo")]
        public EngineTaskInfo EngineTaskInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineTaskId", this.EngineTaskId);
            this.SetParamSimple(map, prefix + "EngineExeStatus", this.EngineExeStatus);
            this.SetParamSimple(map, prefix + "EngineExeStartTime", this.EngineExeStartTime);
            this.SetParamSimple(map, prefix + "EngineExeEndTime", this.EngineExeEndTime);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "BusinessInfo", this.BusinessInfo);
            this.SetParamObj(map, prefix + "EngineTaskInfo.", this.EngineTaskInfo);
        }
    }
}

