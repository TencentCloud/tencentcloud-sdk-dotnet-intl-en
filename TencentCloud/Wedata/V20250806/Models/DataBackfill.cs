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

    public class DataBackfill : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Data supplement plan id.
        /// </summary>
        [JsonProperty("DataBackfillPlanId")]
        public string DataBackfillPlanId{ get; set; }

        /// <summary>
        /// Data supplement plan name.
        /// </summary>
        [JsonProperty("DataBackfillPlanName")]
        public string DataBackfillPlanName{ get; set; }

        /// <summary>
        /// Supplementary task collection.
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// Backfill task data configuration list.
        /// </summary>
        [JsonProperty("DataBackfillRangeList")]
        public DataBackfillRange[] DataBackfillRangeList{ get; set; }

        /// <summary>
        /// Check parent task type. valid values: NONE (do not check ALL), ALL (check ALL upstream parent tasks), MAKE_SCOPE (check only in the selected tasks of the present replenishment plan).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// Specifies whether to ignore event dependency during backfill.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// Custom instance run degree of concurrency. return null or do not return indicates task original self-dependent.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedefineParallelNum")]
        public ulong? RedefineParallelNum{ get; set; }

        /// <summary>
        /// Custom workflow self-dependency, yes or no. if not configured, use the existing workflow self-dependency.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedefineSelfWorkflowDependency")]
        public string RedefineSelfWorkflowDependency{ get; set; }

        /// <summary>
        /// Scheduling resource group id.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SchedulerResourceGroupId")]
        public string SchedulerResourceGroupId{ get; set; }

        /// <summary>
        /// Integration resource group id.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntegrationResourceGroupId")]
        public string IntegrationResourceGroupId{ get; set; }

        /// <summary>
        /// Backfill custom generation cycle.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedefineCycleType")]
        public string RedefineCycleType{ get; set; }

        /// <summary>
        /// Custom parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedefineParamList")]
        public KVPair[] RedefineParamList{ get; set; }

        /// <summary>
        /// Execution start time of the backfill task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Backfill task execution end time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Create a user id.
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Percentage of supplementary plan instances completed.
        /// </summary>
        [JsonProperty("CompletePercent")]
        public ulong? CompletePercent{ get; set; }

        /// <summary>
        /// Percentage of supplementary plan instances successful.
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public ulong? SuccessPercent{ get; set; }

        /// <summary>
        /// Backfill follows the instance data time sequence and must meet two conditions to take effect: 1. must be tasks in the same cycle 2. execute based on dependencies, or execute based on configured execution ORDER without dependency impact  available values: - NORMAL: leave unset - ORDER: sequence - REVERSE: descending ORDER  if not set, the default is NORMAL.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataTimeOrder")]
        public string DataTimeOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DataBackfillPlanId", this.DataBackfillPlanId);
            this.SetParamSimple(map, prefix + "DataBackfillPlanName", this.DataBackfillPlanName);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamArrayObj(map, prefix + "DataBackfillRangeList.", this.DataBackfillRangeList);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "RedefineParallelNum", this.RedefineParallelNum);
            this.SetParamSimple(map, prefix + "RedefineSelfWorkflowDependency", this.RedefineSelfWorkflowDependency);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupId", this.SchedulerResourceGroupId);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupId", this.IntegrationResourceGroupId);
            this.SetParamSimple(map, prefix + "RedefineCycleType", this.RedefineCycleType);
            this.SetParamArrayObj(map, prefix + "RedefineParamList.", this.RedefineParamList);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "CompletePercent", this.CompletePercent);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "DataTimeOrder", this.DataTimeOrder);
        }
    }
}

