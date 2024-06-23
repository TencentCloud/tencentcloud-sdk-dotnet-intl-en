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

    public class CreateOpsMakePlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Supplemental Plan Name
        /// </summary>
        [JsonProperty("MakeName")]
        public string MakeName{ get; set; }

        /// <summary>
        /// Supplementary Task Collection
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// Supplementary Plan Date Range
        /// </summary>
        [JsonProperty("MakeDatetimeList")]
        public CreateMakeDatetimeInfo[] MakeDatetimeList{ get; set; }

        /// <summary>
        /// Project Identifier
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// Check Parent Task Status for Supplement, default is not to check. Not recommended for use, will be deprecated, recommend using CheckParentType.
        /// </summary>
        [JsonProperty("CheckParent")]
        public bool? CheckParent{ get; set; }

        /// <summary>
        /// Check Parent Task Type for Supplementary. Value range:
        /// <li> NONE: Do not check any </li>
        /// <li> ALL: Check all upstream parent tasks </li>
        /// <li> MAKE_SCOPE: Check only within the selected tasks of (the current supplementary plan) </li>
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Deprecated. Task Self-Dependency Type: parallel, serial (unordered parallel), orderly (ordered serial)
        /// </summary>
        [JsonProperty("SelfDependence")]
        public string SelfDependence{ get; set; }

        /// <summary>
        /// Parallelism
        /// </summary>
        [JsonProperty("ParallelNum")]
        public long? ParallelNum{ get; set; }

        /// <summary>
        /// Is the generation cycle of the supplementary instance the same as the original cycle, default is true
        /// </summary>
        [JsonProperty("SameCycle")]
        public bool? SameCycle{ get; set; }

        /// <summary>
        /// Supplementary Instance Target Cycle Type
        /// </summary>
        [JsonProperty("TargetTaskCycle")]
        public string TargetTaskCycle{ get; set; }

        /// <summary>
        /// Specified Time for Supplementary Instance Target Cycle Type
        /// </summary>
        [JsonProperty("TargetTaskAction")]
        public long? TargetTaskAction{ get; set; }

        /// <summary>
        /// Custom Parameters for Supplement Instance
        /// </summary>
        [JsonProperty("MapParamList")]
        public StrToStrMap[] MapParamList{ get; set; }

        /// <summary>
        /// Creator ID
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Supplementary Plan Description
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Use Original Self-Dependency Configuration of Task, default is true
        /// </summary>
        [JsonProperty("SameSelfDependType")]
        public bool? SameSelfDependType{ get; set; }

        /// <summary>
        /// Supplementary Instance Original Cycle Type
        /// </summary>
        [JsonProperty("SourceTaskCycle")]
        public string SourceTaskCycle{ get; set; }

        /// <summary>
        /// If no specified scheduling resource group (ID) is provided, the original task scheduling execution resource group will be used
        /// </summary>
        [JsonProperty("SchedulerResourceGroup")]
        public string SchedulerResourceGroup{ get; set; }

        /// <summary>
        /// If no specified integration resource group (ID) is provided, the original task integration execution resource group will be used
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }

        /// <summary>
        /// If no specified scheduling resource group name is provided, the original task scheduling execution resource group will be used
        /// </summary>
        [JsonProperty("SchedulerResourceGroupName")]
        public string SchedulerResourceGroupName{ get; set; }

        /// <summary>
        /// If no specified integration resource group name is provided, the original task integration execution resource group will be used
        /// </summary>
        [JsonProperty("IntegrationResourceGroupName")]
        public string IntegrationResourceGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MakeName", this.MakeName);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArrayObj(map, prefix + "MakeDatetimeList.", this.MakeDatetimeList);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "CheckParent", this.CheckParent);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "SelfDependence", this.SelfDependence);
            this.SetParamSimple(map, prefix + "ParallelNum", this.ParallelNum);
            this.SetParamSimple(map, prefix + "SameCycle", this.SameCycle);
            this.SetParamSimple(map, prefix + "TargetTaskCycle", this.TargetTaskCycle);
            this.SetParamSimple(map, prefix + "TargetTaskAction", this.TargetTaskAction);
            this.SetParamArrayObj(map, prefix + "MapParamList.", this.MapParamList);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SameSelfDependType", this.SameSelfDependType);
            this.SetParamSimple(map, prefix + "SourceTaskCycle", this.SourceTaskCycle);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroup", this.SchedulerResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupName", this.SchedulerResourceGroupName);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupName", this.IntegrationResourceGroupName);
        }
    }
}

