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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InnerWorkflowTaskRunIterationBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>Task running ID</p>
        /// </summary>
        [JsonProperty("WorkflowTaskRunId")]
        public string WorkflowTaskRunId{ get; set; }

        /// <summary>
        /// <p>Iteration serial number</p>
        /// </summary>
        [JsonProperty("IterationIndex")]
        public string IterationIndex{ get; set; }

        /// <summary>
        /// <p>Start time in milliseconds.</p>
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// <p>Running end time, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// <p>Running state</p>
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// <p>Running time, unit: seconds</p>
        /// </summary>
        [JsonProperty("RunCostTime")]
        public string RunCostTime{ get; set; }

        /// <summary>
        /// <p>Running parameter</p>
        /// </summary>
        [JsonProperty("TaskParams")]
        public string TaskParams{ get; set; }

        /// <summary>
        /// <p>Error code</p>
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowTaskRunId", this.WorkflowTaskRunId);
            this.SetParamSimple(map, prefix + "IterationIndex", this.IterationIndex);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamSimple(map, prefix + "RunCostTime", this.RunCostTime);
            this.SetParamSimple(map, prefix + "TaskParams", this.TaskParams);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
        }
    }
}

