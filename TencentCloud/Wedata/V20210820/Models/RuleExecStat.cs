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

    public class RuleExecStat : AbstractModel
    {
        
        /// <summary>
        /// Total Rule Executions
        /// </summary>
        [JsonProperty("TotalCnt")]
        public ulong? TotalCnt{ get; set; }

        /// <summary>
        /// Quarter-over-quarter total rule executions
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastTotalCnt")]
        public ulong? LastTotalCnt{ get; set; }

        /// <summary>
        /// Percentage of total rule executions
        /// </summary>
        [JsonProperty("TotalCntRatio")]
        public float? TotalCntRatio{ get; set; }

        /// <summary>
        /// Quarter-over-quarter change in total rule executions
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastTotalCntRatio")]
        public float? LastTotalCntRatio{ get; set; }

        /// <summary>
        /// Number of rule triggers
        /// </summary>
        [JsonProperty("TriggerCnt")]
        public ulong? TriggerCnt{ get; set; }

        /// <summary>
        /// Quarter-over-quarter number of rule triggers
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastTriggerCnt")]
        public ulong? LastTriggerCnt{ get; set; }

        /// <summary>
        /// Percentage of triggers in total
        /// </summary>
        [JsonProperty("TriggerCntRatio")]
        public float? TriggerCntRatio{ get; set; }

        /// <summary>
        /// Quarter-over-quarter change in rule triggers
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastTriggerCntRatio")]
        public float? LastTriggerCntRatio{ get; set; }

        /// <summary>
        /// Number of rule alerts
        /// </summary>
        [JsonProperty("AlarmCnt")]
        public ulong? AlarmCnt{ get; set; }

        /// <summary>
        /// Quarter-over-quarter number of rule alerts
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastAlarmCnt")]
        public ulong? LastAlarmCnt{ get; set; }

        /// <summary>
        /// Percentage of alerts in total
        /// </summary>
        [JsonProperty("AlarmCntRatio")]
        public float? AlarmCntRatio{ get; set; }

        /// <summary>
        /// Quarter-over-quarter change in alert numbers
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastAlarmCntRatio")]
        public float? LastAlarmCntRatio{ get; set; }

        /// <summary>
        /// Number of block occurrences
        /// </summary>
        [JsonProperty("PipelineCnt")]
        public ulong? PipelineCnt{ get; set; }

        /// <summary>
        /// Quarter-over-quarter number of block occurrences
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastPipelineCnt")]
        public ulong? LastPipelineCnt{ get; set; }

        /// <summary>
        /// Percentage of blocks in total
        /// </summary>
        [JsonProperty("PipelineCntRatio")]
        public float? PipelineCntRatio{ get; set; }

        /// <summary>
        /// Quarter-over-quarter change in block occurrences
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastPipelineCntRatio")]
        public float? LastPipelineCntRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCnt", this.TotalCnt);
            this.SetParamSimple(map, prefix + "LastTotalCnt", this.LastTotalCnt);
            this.SetParamSimple(map, prefix + "TotalCntRatio", this.TotalCntRatio);
            this.SetParamSimple(map, prefix + "LastTotalCntRatio", this.LastTotalCntRatio);
            this.SetParamSimple(map, prefix + "TriggerCnt", this.TriggerCnt);
            this.SetParamSimple(map, prefix + "LastTriggerCnt", this.LastTriggerCnt);
            this.SetParamSimple(map, prefix + "TriggerCntRatio", this.TriggerCntRatio);
            this.SetParamSimple(map, prefix + "LastTriggerCntRatio", this.LastTriggerCntRatio);
            this.SetParamSimple(map, prefix + "AlarmCnt", this.AlarmCnt);
            this.SetParamSimple(map, prefix + "LastAlarmCnt", this.LastAlarmCnt);
            this.SetParamSimple(map, prefix + "AlarmCntRatio", this.AlarmCntRatio);
            this.SetParamSimple(map, prefix + "LastAlarmCntRatio", this.LastAlarmCntRatio);
            this.SetParamSimple(map, prefix + "PipelineCnt", this.PipelineCnt);
            this.SetParamSimple(map, prefix + "LastPipelineCnt", this.LastPipelineCnt);
            this.SetParamSimple(map, prefix + "PipelineCntRatio", this.PipelineCntRatio);
            this.SetParamSimple(map, prefix + "LastPipelineCntRatio", this.LastPipelineCntRatio);
        }
    }
}

