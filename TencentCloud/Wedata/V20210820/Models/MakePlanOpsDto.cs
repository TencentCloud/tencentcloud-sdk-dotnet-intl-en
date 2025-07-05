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

    public class MakePlanOpsDto : AbstractModel
    {
        
        /// <summary>
        /// Supplement Plan ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Supplement Plan Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MakeName")]
        public string MakeName{ get; set; }

        /// <summary>
        /// Project ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Check Parent Task Status for Supplement
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CheckParent")]
        public bool? CheckParent{ get; set; }

        /// <summary>
        /// Use Original Task Self-Dependency Configuration
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SameSelfDependType")]
        public bool? SameSelfDependType{ get; set; }

        /// <summary>
        /// Concurrency, effective when SameSelfDependType is false
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ParallelNum")]
        public long? ParallelNum{ get; set; }

        /// <summary>
        /// Modify Supplement Instance Generation Period
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SameCycle")]
        public bool? SameCycle{ get; set; }

        /// <summary>
        /// Scheduling Cycle Conversion Method - Original Cycle Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceTaskCycle")]
        public string SourceTaskCycle{ get; set; }

        /// <summary>
        /// Scheduling Cycle Conversion Method - Target Cycle Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetTaskCycle")]
        public string TargetTaskCycle{ get; set; }

        /// <summary>
        /// Scheduling Cycle Conversion Method - Specific Time for Target Cycle Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetTaskAction")]
        public long? TargetTaskAction{ get; set; }

        /// <summary>
        /// Supplement Instance From Definition Parameters
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MapParamList")]
        public StrToStrMap[] MapParamList{ get; set; }

        /// <summary>
        /// Creator ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// Creator
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Creation TimeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Supplementary Task ID Collection
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// Supplementary Plan Date Range
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MakeDatetimeList")]
        public CreateMakeDatetimeInfo[] MakeDatetimeList{ get; set; }

        /// <summary>
        /// Supplementary Plan Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Supplementary Designated Scheduling Resource Group (ID)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SchedulerResourceGroup")]
        public string SchedulerResourceGroup{ get; set; }

        /// <summary>
        /// Supplementary Scheduled Resource Group Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SchedulerResourceGroupName")]
        public string SchedulerResourceGroupName{ get; set; }

        /// <summary>
        /// Supplementary Designated Integration Resource Group (ID)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }

        /// <summary>
        /// Supplementary Integrated Resource Group Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IntegrationResourceGroupName")]
        public string IntegrationResourceGroupName{ get; set; }

        /// <summary>
        /// Number of Supplementary Plan Tasks
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// Percentage of Supplementary Plan Instances Completed
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompletePercent")]
        public long? CompletePercent{ get; set; }

        /// <summary>
        /// Percentage of Supplementary Plan Instances Successful
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public long? SuccessPercent{ get; set; }

        /// <summary>
        /// Check Parent Task Type for Supplementary. Value range:
        /// <li> NONE: Do not check any </li>
        /// <li> ALL: Check all upstream parent tasks </li>
        /// <li> MAKE_SCOPE: Check only within the selected tasks of (the current supplementary plan) </li>
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "MakeName", this.MakeName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CheckParent", this.CheckParent);
            this.SetParamSimple(map, prefix + "SameSelfDependType", this.SameSelfDependType);
            this.SetParamSimple(map, prefix + "ParallelNum", this.ParallelNum);
            this.SetParamSimple(map, prefix + "SameCycle", this.SameCycle);
            this.SetParamSimple(map, prefix + "SourceTaskCycle", this.SourceTaskCycle);
            this.SetParamSimple(map, prefix + "TargetTaskCycle", this.TargetTaskCycle);
            this.SetParamSimple(map, prefix + "TargetTaskAction", this.TargetTaskAction);
            this.SetParamArrayObj(map, prefix + "MapParamList.", this.MapParamList);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArrayObj(map, prefix + "MakeDatetimeList.", this.MakeDatetimeList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroup", this.SchedulerResourceGroup);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupName", this.SchedulerResourceGroupName);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupName", this.IntegrationResourceGroupName);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "CompletePercent", this.CompletePercent);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
        }
    }
}

