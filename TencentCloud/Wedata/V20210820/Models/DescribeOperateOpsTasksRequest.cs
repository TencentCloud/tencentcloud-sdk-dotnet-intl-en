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

    public class DescribeOperateOpsTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Folder ID, multiple folders separated by commas
        /// </summary>
        [JsonProperty("FolderIdList")]
        public string FolderIdList{ get; set; }

        /// <summary>
        /// Workflow ID, multiple Workflow IDs separated by English commas
        /// </summary>
        [JsonProperty("WorkFlowIdList")]
        public string WorkFlowIdList{ get; set; }

        /// <summary>
        /// Workflow name, multiple Workflow names separated by English commas
        /// </summary>
        [JsonProperty("WorkFlowNameList")]
        public string WorkFlowNameList{ get; set; }

        /// <summary>
        /// Task Name, multiple Task Names separated by English commas
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string TaskNameList{ get; set; }

        /// <summary>
        /// Task ID, multiple Task IDs separated by English commas
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string TaskIdList{ get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("PageNumber")]
        public string PageNumber{ get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// Sort Fields, supported fields are FirstSubmitTime and FirstRunTime, indicating the most recent submission and the first execution event
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// Sort Type. Two values DESC,ASC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// Person in Charge, multiple Persons in Charge separated by English commas
        /// </summary>
        [JsonProperty("InChargeList")]
        public string InChargeList{ get; set; }

        /// <summary>
        /// Task Type ID String, multiple Task Type IDs separated by English commas
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public string TaskTypeIdList{ get; set; }

        /// <summary>
        /// Task Status String, multiple Task Statuses separated by English commas
        /// </summary>
        [JsonProperty("StatusList")]
        public string StatusList{ get; set; }

        /// <summary>
        /// Task Cycle Type String, multiple Task Cycles separated by English commas
        /// </summary>
        [JsonProperty("TaskCycleUnitList")]
        public string TaskCycleUnitList{ get; set; }

        /// <summary>
        /// Task Belonging Product Type
        /// </summary>
        [JsonProperty("ProductNameList")]
        public string ProductNameList{ get; set; }

        /// <summary>
        /// Data Source ID or (only for offline sync tasks) Source Data Source ID
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// Data Source Type or (only for offline sync tasks) Source Data Source Type
        /// </summary>
        [JsonProperty("SourceServiceType")]
        public string SourceServiceType{ get; set; }

        /// <summary>
        /// (Only for offline sync tasks) Target Data Source ID
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// (Only for offline sync tasks) Target Data Source Type
        /// </summary>
        [JsonProperty("TargetServiceType")]
        public string TargetServiceType{ get; set; }

        /// <summary>
        /// Alarm Type, multiple types separated by commas
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// Resource Group ID, multiple Resource Group IDs separated by English commas
        /// </summary>
        [JsonProperty("ExecutorGroupIdList")]
        public string ExecutorGroupIdList{ get; set; }

        /// <summary>
        /// Task tag
        /// </summary>
        [JsonProperty("TaskTags")]
        public TaskTag[] TaskTags{ get; set; }

        /// <summary>
        /// Query Keyword
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }

        /// <summary>
        /// Instance Generation Method
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// Additional Requested Resource Types
        /// </summary>
        [JsonProperty("RequestResourceTypes")]
        public string[] RequestResourceTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FolderIdList", this.FolderIdList);
            this.SetParamSimple(map, prefix + "WorkFlowIdList", this.WorkFlowIdList);
            this.SetParamSimple(map, prefix + "WorkFlowNameList", this.WorkFlowNameList);
            this.SetParamSimple(map, prefix + "TaskNameList", this.TaskNameList);
            this.SetParamSimple(map, prefix + "TaskIdList", this.TaskIdList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "InChargeList", this.InChargeList);
            this.SetParamSimple(map, prefix + "TaskTypeIdList", this.TaskTypeIdList);
            this.SetParamSimple(map, prefix + "StatusList", this.StatusList);
            this.SetParamSimple(map, prefix + "TaskCycleUnitList", this.TaskCycleUnitList);
            this.SetParamSimple(map, prefix + "ProductNameList", this.ProductNameList);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "SourceServiceType", this.SourceServiceType);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceType", this.TargetServiceType);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "ExecutorGroupIdList", this.ExecutorGroupIdList);
            this.SetParamArrayObj(map, prefix + "TaskTags.", this.TaskTags);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
            this.SetParamArraySimple(map, prefix + "RequestResourceTypes.", this.RequestResourceTypes);
        }
    }
}

