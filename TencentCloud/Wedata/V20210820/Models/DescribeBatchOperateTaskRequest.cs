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

    public class DescribeBatchOperateTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("Page")]
        public string Page{ get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Status ListDraft: 'NS','N','P','R'
        /// Running: 'Y'
        /// Stopped: 'F'
        /// Frozen: 'O'
        /// Stopping: 'T'
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }

        /// <summary>
        /// List of Responsible Persons
        /// </summary>
        [JsonProperty("OwnerNameList")]
        public string[] OwnerNameList{ get; set; }

        /// <summary>
        /// Workflow List
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// Task Name Search
        /// </summary>
        [JsonProperty("TaskNameFilter")]
        public string TaskNameFilter{ get; set; }

        /// <summary>
        /// Task Type List
        /// </summary>
        [JsonProperty("TaskTypeList")]
        public string[] TaskTypeList{ get; set; }

        /// <summary>
        /// Folder List
        /// </summary>
        [JsonProperty("FordIdList")]
        public string[] FordIdList{ get; set; }

        /// <summary>
        /// Task ID Search
        /// </summary>
        [JsonProperty("TaskIdFilter")]
        public string TaskIdFilter{ get; set; }

        /// <summary>
        /// Responsible Person Search
        /// </summary>
        [JsonProperty("OwnerNameFilter")]
        public string OwnerNameFilter{ get; set; }

        /// <summary>
        /// Sort Fields:
        /// UpdateTime
        /// CreateTime
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// asc: Ascending
        /// desc: Descending
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// Engine Type List: Three Types
        /// SparkJob
        /// SparkSql
        /// presto
        /// </summary>
        [JsonProperty("DataEngineList")]
        public string[] DataEngineList{ get; set; }

        /// <summary>
        /// Operator Name
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// Data Source ID List
        /// </summary>
        [JsonProperty("DatasourceIdList")]
        public string[] DatasourceIdList{ get; set; }

        /// <summary>
        /// Data Source Type List
        /// </summary>
        [JsonProperty("DatasourceTypeList")]
        public string[] DatasourceTypeList{ get; set; }

        /// <summary>
        /// Scheduling Unit Type List
        /// </summary>
        [JsonProperty("CycleUnitList")]
        public string[] CycleUnitList{ get; set; }

        /// <summary>
        /// Filter out tasks that can be submitted?
        /// </summary>
        [JsonProperty("CanSubmit")]
        public bool? CanSubmit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
            this.SetParamArraySimple(map, prefix + "OwnerNameList.", this.OwnerNameList);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamSimple(map, prefix + "TaskNameFilter", this.TaskNameFilter);
            this.SetParamArraySimple(map, prefix + "TaskTypeList.", this.TaskTypeList);
            this.SetParamArraySimple(map, prefix + "FordIdList.", this.FordIdList);
            this.SetParamSimple(map, prefix + "TaskIdFilter", this.TaskIdFilter);
            this.SetParamSimple(map, prefix + "OwnerNameFilter", this.OwnerNameFilter);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamArraySimple(map, prefix + "DataEngineList.", this.DataEngineList);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "OwnerId", this.OwnerId);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamArraySimple(map, prefix + "DatasourceIdList.", this.DatasourceIdList);
            this.SetParamArraySimple(map, prefix + "DatasourceTypeList.", this.DatasourceTypeList);
            this.SetParamArraySimple(map, prefix + "CycleUnitList.", this.CycleUnitList);
            this.SetParamSimple(map, prefix + "CanSubmit", this.CanSubmit);
        }
    }
}

