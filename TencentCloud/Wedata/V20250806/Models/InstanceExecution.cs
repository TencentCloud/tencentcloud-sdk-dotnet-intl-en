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

    public class InstanceExecution : AbstractModel
    {
        
        /// <summary>
        /// Instance unique identifier.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// **Instance lifecycle number, identifies one-time execution of the instance.**.
        /// 
        /// For example, the first run of a periodic instance is numbered 0. if the user reruns the instance subsequently, the second execution is numbered 1.
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

        /// <summary>
        /// **Instance status**.
        /// -WAIT_EVENT: specifies the wait for event.
        /// -WAIT_UPSTREAM: waiting for upstream.
        /// - WAIT_RUN: awaiting execution.
        /// - RUNNING: indicates the instance is RUNNING.
        /// - SKIP_RUNNING: SKIP RUNNING.
        /// - FAILED_RETRY: RETRY on failure.
        /// - EXPIRED: failed.
        /// -COMPLETED: success.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// **Trigger type for instance running**.
        /// 
        /// -RERUN indicates a rerun.
        /// -ADDITION indicates supplementary recording.
        /// -PERIODIC indicates a period.
        /// -APERIODIC indicates non-periodic.
        /// -RERUN_SKIP_RUN indicates rerun - empty run.
        /// -ADDITION_SKIP_RUN indicates a supplementary empty run.
        /// -PERIODIC_SKIP_RUN indicates cycle - empty run.
        /// -APERIODIC_SKIP_RUN indicates non-periodic empty run.
        /// -MANUAL_TRIGGER indicates manual triggering.
        /// -RERUN_MANUAL_TRIGGER indicates manual triggering - rerun.
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// Specifies the number of retry attempts on failure.
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// **Specifies the lifecycle list for instance execution.**.
        /// </summary>
        [JsonProperty("ExecutionPhaseList")]
        public InstanceExecutionPhase[] ExecutionPhaseList{ get; set; }

        /// <summary>
        /// Time spent, in milliseconds.
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "ExecutionPhaseList.", this.ExecutionPhaseList);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
        }
    }
}

