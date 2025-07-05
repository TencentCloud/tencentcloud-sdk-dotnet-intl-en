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

    public class DescribeInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// Project/workspace ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// Number of items displayed per page
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Cycle List (e.g., daily, one-time), optional
        /// </summary>
        [JsonProperty("CycleList")]
        public string[] CycleList{ get; set; }

        /// <summary>
        /// Person in Charge
        /// </summary>
        [JsonProperty("OwnerList")]
        public string[] OwnerList{ get; set; }

        /// <summary>
        /// Keep consistent with previous
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Sorting Order (asc, desc)
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// Sort Column (costTime Runtime duration, startTime Start Time, state Instance status, curRunDate Data Timestamp)
        /// </summary>
        [JsonProperty("SortCol")]
        public string SortCol{ get; set; }

        /// <summary>
        /// Type List (e.g., Python Task Type: 30
        /// PySpark Task Type: 31
        /// hivesql task type:34
        /// shell task type:35
        /// sparksql task type:36 jdbcsql task type:21 dlc task type:32), optional
        /// </summary>
        [JsonProperty("TaskTypeList")]
        public long?[] TaskTypeList{ get; set; }

        /// <summary>
        /// Status list (e.g., success 2, executing 1), optional
        /// </summary>
        [JsonProperty("StateList")]
        public long?[] StateList{ get; set; }

        /// <summary>
        /// Task Name
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "CycleList.", this.CycleList);
            this.SetParamArraySimple(map, prefix + "OwnerList.", this.OwnerList);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "SortCol", this.SortCol);
            this.SetParamArraySimple(map, prefix + "TaskTypeList.", this.TaskTypeList);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

