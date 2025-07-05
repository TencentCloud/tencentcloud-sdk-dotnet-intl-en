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

    public class InstanceApiOpsRequest : AbstractModel
    {
        
        /// <summary>
        /// Single Query Condition
        /// </summary>
        [JsonProperty("Instance")]
        public InstanceOpsDto Instance{ get; set; }

        /// <summary>
        /// Sort fields, currently includes: Retry Count, Instance Data Time, Runtime Duration
        /// </summary>
        [JsonProperty("SortCol")]
        public string SortCol{ get; set; }

        /// <summary>
        /// Task ID list
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// Fuzzy search by taskName
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string[] TaskNameList{ get; set; }

        /// <summary>
        /// Folder List
        /// </summary>
        [JsonProperty("FolderList")]
        public string[] FolderList{ get; set; }

        /// <summary>
        /// Ascending or Descending
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// Instance Status List
        /// </summary>
        [JsonProperty("StateList")]
        public long?[] StateList{ get; set; }

        /// <summary>
        /// Instance Type List
        /// </summary>
        [JsonProperty("TaskTypeList")]
        public long?[] TaskTypeList{ get; set; }

        /// <summary>
        /// Cycle Type
        /// </summary>
        [JsonProperty("CycleList")]
        public string[] CycleList{ get; set; }

        /// <summary>
        /// Person in Charge
        /// </summary>
        [JsonProperty("OwnerList")]
        public string[] OwnerList{ get; set; }

        /// <summary>
        /// Data Timestamp
        /// </summary>
        [JsonProperty("DateFrom")]
        public string DateFrom{ get; set; }

        /// <summary>
        /// Data Timestamp
        /// </summary>
        [JsonProperty("DateTo")]
        public string DateTo{ get; set; }

        /// <summary>
        /// Instance Storage Time
        /// </summary>
        [JsonProperty("CreateTimeFrom")]
        public string CreateTimeFrom{ get; set; }

        /// <summary>
        /// Instance Storage Time
        /// </summary>
        [JsonProperty("CreateTimeTo")]
        public string CreateTimeTo{ get; set; }

        /// <summary>
        /// Start Execution Time
        /// </summary>
        [JsonProperty("StartFrom")]
        public string StartFrom{ get; set; }

        /// <summary>
        /// Start Execution Time
        /// </summary>
        [JsonProperty("StartTo")]
        public string StartTo{ get; set; }

        /// <summary>
        /// Belongs to Workflow
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// Fuzzy search by workflowName
        /// </summary>
        [JsonProperty("WorkflowNameList")]
        public string[] WorkflowNameList{ get; set; }

        /// <summary>
        /// Keyword Fuzzy Search
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// searchColumns are the list of field names to search
        /// </summary>
        [JsonProperty("SearchColumns")]
        public string[] SearchColumns{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Task Type Mapping Relationship, storing Task Type ID and Task Type Description Information
        /// </summary>
        [JsonProperty("TaskTypeMap")]
        public TaskTypeMap[] TaskTypeMap{ get; set; }

        /// <summary>
        /// 0 Supplementary Entry Type 1 Periodic Instance 2 Non-periodic Instance
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Whether it is DAG
        /// </summary>
        [JsonProperty("DagDeal")]
        public bool? DagDeal{ get; set; }

        /// <summary>
        /// 1 Parent instance 2 Child instance
        /// </summary>
        [JsonProperty("DagType")]
        public string DagType{ get; set; }

        /// <summary>
        /// 1 Self-Dependency 2 Task Dependency 3 All Dependencies
        /// </summary>
        [JsonProperty("DagDependent")]
        public string DagDependent{ get; set; }

        /// <summary>
        /// DAG Depth Default to 1, value range 1-6
        /// </summary>
        [JsonProperty("DagDepth")]
        public long? DagDepth{ get; set; }

        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// Inquiry based on Current Data Time or Next Data Time, default to Current Data Time
        /// </summary>
        [JsonProperty("DataTimeCycle")]
        public string DataTimeCycle{ get; set; }

        /// <summary>
        /// Resource Group ID, multiple Resource Group IDs separated by English commas
        /// </summary>
        [JsonProperty("ExecutorGroupIdList")]
        public string[] ExecutorGroupIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Instance.", this.Instance);
            this.SetParamSimple(map, prefix + "SortCol", this.SortCol);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArraySimple(map, prefix + "TaskNameList.", this.TaskNameList);
            this.SetParamArraySimple(map, prefix + "FolderList.", this.FolderList);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamArraySimple(map, prefix + "TaskTypeList.", this.TaskTypeList);
            this.SetParamArraySimple(map, prefix + "CycleList.", this.CycleList);
            this.SetParamArraySimple(map, prefix + "OwnerList.", this.OwnerList);
            this.SetParamSimple(map, prefix + "DateFrom", this.DateFrom);
            this.SetParamSimple(map, prefix + "DateTo", this.DateTo);
            this.SetParamSimple(map, prefix + "CreateTimeFrom", this.CreateTimeFrom);
            this.SetParamSimple(map, prefix + "CreateTimeTo", this.CreateTimeTo);
            this.SetParamSimple(map, prefix + "StartFrom", this.StartFrom);
            this.SetParamSimple(map, prefix + "StartTo", this.StartTo);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamArraySimple(map, prefix + "WorkflowNameList.", this.WorkflowNameList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "SearchColumns.", this.SearchColumns);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "TaskTypeMap.", this.TaskTypeMap);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "DagDeal", this.DagDeal);
            this.SetParamSimple(map, prefix + "DagType", this.DagType);
            this.SetParamSimple(map, prefix + "DagDependent", this.DagDependent);
            this.SetParamSimple(map, prefix + "DagDepth", this.DagDepth);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "DataTimeCycle", this.DataTimeCycle);
            this.SetParamArraySimple(map, prefix + "ExecutorGroupIdList.", this.ExecutorGroupIdList);
        }
    }
}

