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

    public class WorkflowRunBrief : AbstractModel
    {
        
        /// <summary>
        /// Workflow running ID
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// Start time in milliseconds.
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// <p>RUNNING state. CREATE("initialization"), QUEUED("Waiting"), PENDING("preparing"), RUNNING("RUNNING"), SKIPPED("skip RUNNING"), SUCCESS("SUCCESS"), FAILED("failure"), TERMINATING("TERMINATING"), TERMINATED("termination"), CANCELLED("manual termination"), etc.</p>
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// Runtime error code
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
        }
    }
}

