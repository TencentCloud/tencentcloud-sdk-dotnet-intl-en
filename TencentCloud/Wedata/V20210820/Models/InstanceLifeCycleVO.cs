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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceLifeCycleVO : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// Instance status.
        /// 
        /// -Indicates waiting for event.
        /// -[12] indicates waiting for upstream.
        /// -[6, 7, 9, 10, 18] indicates awaiting execution.
        /// -1, 19, 22 indicate running.
        /// -21: skip running.
        /// -[3] indicates retry on failure.
        /// -[8, 4, 5, 13] indicates a failure.
        /// -[2] indicates a success.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceState")]
        public ulong? InstanceState{ get; set; }

        /// <summary>
        /// Lifecycle no.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

        /// <summary>
        /// Instance running trigger type.
        /// 
        /// -RERUN indicates rerunning.
        /// -ADDITION indicates supplementary recording.
        /// -PERIODIC indicates a period.
        /// -APERIODIC indicates non-periodic.
        /// -RERUN_SKIP_RUN means empty run for re-run.
        /// -ADDITION_SKIP_RUN indicates a supplementary run - empty run.
        /// -PERIODIC_SKIP_RUN indicates an empty run in a periodic cycle.
        /// -APERIODIC_SKIP_RUN indicates a non-periodic empty run.
        /// -MANUAL_TRIGGER indicates manual triggering.
        /// -RERUN_MANUAL_TRIGGER indicates manual triggering - rerun.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// Number of retries after failure.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// List of instance lifecycle.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LifeCycleDetailList")]
        public InstanceLifeDetailDto[] LifeCycleDetailList{ get; set; }

        /// <summary>
        /// Instance code file.
        /// The file content specifies the code used for running the execution instance this time. only some tasks support it.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CodeFileName")]
        public string CodeFileName{ get; set; }

        /// <summary>
        /// Dispatch execution ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// The execution node where the log resides.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// Log file name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// Instance log type.
        /// 
        /// -run: indicates the state of functioning. 
        /// -kill: terminates.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Time spent.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CostTime")]
        public string CostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "LifeCycleDetailList.", this.LifeCycleDetailList);
            this.SetParamSimple(map, prefix + "CodeFileName", this.CodeFileName);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
        }
    }
}

