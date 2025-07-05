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

    public class DescribeOpsWorkflowsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Task Product Type Name List, separated by ','
        /// </summary>
        [JsonProperty("ProductNameList")]
        public string ProductNameList{ get; set; }

        /// <summary>
        /// File ID list, separated by ','
        /// </summary>
        [JsonProperty("FolderIdList")]
        public string FolderIdList{ get; set; }

        /// <summary>
        /// Workflow ID, separated by ','
        /// </summary>
        [JsonProperty("WorkFlowIdList")]
        public string WorkFlowIdList{ get; set; }

        /// <summary>
        /// Workflow Name List, separated by ','
        /// </summary>
        [JsonProperty("WorkFlowNameList")]
        public string WorkFlowNameList{ get; set; }

        /// <summary>
        /// Task Name List, separated by ','
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string TaskNameList{ get; set; }

        /// <summary>
        /// Task ID list, separated by ','
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string TaskIdList{ get; set; }

        /// <summary>
        /// Status List, separated by ','
        /// </summary>
        [JsonProperty("StatusList")]
        public string StatusList{ get; set; }

        /// <summary>
        /// Person in Charge List, separated by ','
        /// </summary>
        [JsonProperty("InChargeList")]
        public string InChargeList{ get; set; }

        /// <summary>
        /// Page number
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Sorting Item
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// Sort Method, DESC or ASC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProductNameList", this.ProductNameList);
            this.SetParamSimple(map, prefix + "FolderIdList", this.FolderIdList);
            this.SetParamSimple(map, prefix + "WorkFlowIdList", this.WorkFlowIdList);
            this.SetParamSimple(map, prefix + "WorkFlowNameList", this.WorkFlowNameList);
            this.SetParamSimple(map, prefix + "TaskNameList", this.TaskNameList);
            this.SetParamSimple(map, prefix + "TaskIdList", this.TaskIdList);
            this.SetParamSimple(map, prefix + "StatusList", this.StatusList);
            this.SetParamSimple(map, prefix + "InChargeList", this.InChargeList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

