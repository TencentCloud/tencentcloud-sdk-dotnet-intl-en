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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InsightResult : AbstractModel
    {
        
        /// <summary>
        /// When Type is HIVE, the value is Hive query ID; when Type is MAPREDUCE, SPARK or TEZ, the value is YarnAppID.
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// Insight application type. Value values: HIVE, SPARK, MAPREDUCE, and TEZ.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Insight rule ID.
        /// HIVE-ScanManyMeta: too much scanned metadata.
        /// HIVE-ScanManyPartition: large table scanning.
        /// HIVE-SlowCompile: compilation duration too long.
        /// HIVE-UnSuitableConfig: improper parameter.
        /// MAPREDUCE-MapperDataSkew: Map data skew.
        /// MAPREDUCE-MapperMemWaste: MapMemory resource waste.
        /// MAPREDUCE-MapperSlowTask: slow map task.
        /// MAPREDUCE-MapperTaskGC:MapperTaskGC
        /// MAPREDUCE-MemExceeded: peak memory exceeded.
        /// MAPREDUCE-ReducerDataSkew: Reduce data skew.
        /// MAPREDUCE-ReducerMemWaste: ReduceMemory resource waste.
        /// MAPREDUCE-ReducerSlowTask: slow reduce task.
        /// MAPREDUCE-ReducerTaskGC:ReducerTaskGC
        /// MAPREDUCE-SchedulingDelay: scheduling delay.
        /// SPARK-CpuWaste: CPU resource waste.
        /// SPARK-DataSkew: data skew.
        /// SPARK-ExecutorGC:ExecutorGC
        /// SPARK-MemExceeded: peak memory exceeded.
        /// SPARK-MemWaste: Memory resource waste.
        /// SPARK-ScheduleOverhead:ScheduleOverhead
        /// SPARK-ScheduleSkew: scheduling skew.
        /// SPARK-SlowTask: slow task.
        /// TEZ-DataSkew: data skew.
        /// TEZ-MapperDataSkew: Map data skew.
        /// TEZ-ReducerDataSkew: Reduce data skew.
        /// TEZ-TezMemWaste: Memory resource waste.
        /// TEZ-TezSlowTask: slow task.
        /// TEZ-TezTaskGC:TasksGC
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// Insight rule name. Refer to the description of RuleID.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Insight rules interpretation.
        /// </summary>
        [JsonProperty("RuleExplain")]
        public string RuleExplain{ get; set; }

        /// <summary>
        /// Details.
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// Recommended message.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Anomaly metrics measure insight severity. Higher values indicate greater severity within the same insight category. Metrics across different insight types cannot be meaningfully compared.
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// Scheduling task execution ID.
        /// </summary>
        [JsonProperty("ScheduleTaskExecID")]
        public string ScheduleTaskExecID{ get; set; }

        /// <summary>
        /// Scheduling flow, DAG.
        /// </summary>
        [JsonProperty("ScheduleFlowName")]
        public string ScheduleFlowName{ get; set; }

        /// <summary>
        /// A Task node in the scheduling flow.
        /// </summary>
        [JsonProperty("ScheduleTaskName")]
        public string ScheduleTaskName{ get; set; }

        /// <summary>
        /// Core configurations for Yarn tasks.
        /// </summary>
        [JsonProperty("JobConf")]
        public string JobConf{ get; set; }

        /// <summary>
        /// Insight structure information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleExplain", this.RuleExplain);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ScheduleTaskExecID", this.ScheduleTaskExecID);
            this.SetParamSimple(map, prefix + "ScheduleFlowName", this.ScheduleFlowName);
            this.SetParamSimple(map, prefix + "ScheduleTaskName", this.ScheduleTaskName);
            this.SetParamSimple(map, prefix + "JobConf", this.JobConf);
            this.SetParamSimple(map, prefix + "Context", this.Context);
        }
    }
}

