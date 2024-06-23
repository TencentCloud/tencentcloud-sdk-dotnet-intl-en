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

    public class DescribeScheduleInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance List
        /// </summary>
        [JsonProperty("Instances")]
        public InstanceOpsDto[] Instances{ get; set; }

        /// <summary>
        /// Check Parent Task Type, true: Check parent task; false: Do not check parent task
        /// </summary>
        [JsonProperty("CheckFather")]
        public bool? CheckFather{ get; set; }

        /// <summary>
        /// Rerun Type, 1: Self; 3: Child; 2: Self and Child
        /// </summary>
        [JsonProperty("RerunType")]
        public string RerunType{ get; set; }

        /// <summary>
        /// Instance Dependency Mode, 1: Self-dependent; 2: Task-dependent; 3: Self and Parent-Child dependent
        /// </summary>
        [JsonProperty("DependentWay")]
        public string DependentWay{ get; set; }

        /// <summary>
        /// Rerun Ignore Event Listening or Not
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// Downstream Instance Range 1: Within the workflow 2: Within the project 3: Across all workflows dependent on the project
        /// </summary>
        [JsonProperty("SonInstanceType")]
        public string SonInstanceType{ get; set; }

        /// <summary>
        /// Query conditions
        /// </summary>
        [JsonProperty("SearchCondition")]
        public InstanceApiOpsRequest SearchCondition{ get; set; }

        /// <summary>
        /// Access type
        /// </summary>
        [JsonProperty("OptType")]
        public string OptType{ get; set; }

        /// <summary>
        /// Operator Name
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// Operator ID
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Project Identifier
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Index Page Number
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Total Data
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Basic Request Information
        /// </summary>
        [JsonProperty("RequestBaseInfo")]
        public ProjectBaseInfoOpsRequest RequestBaseInfo{ get; set; }

        /// <summary>
        /// Whether to Calculate Total
        /// </summary>
        [JsonProperty("IsCount")]
        public bool? IsCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "CheckFather", this.CheckFather);
            this.SetParamSimple(map, prefix + "RerunType", this.RerunType);
            this.SetParamSimple(map, prefix + "DependentWay", this.DependentWay);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "SonInstanceType", this.SonInstanceType);
            this.SetParamObj(map, prefix + "SearchCondition.", this.SearchCondition);
            this.SetParamSimple(map, prefix + "OptType", this.OptType);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "OperatorId", this.OperatorId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamObj(map, prefix + "RequestBaseInfo.", this.RequestBaseInfo);
            this.SetParamSimple(map, prefix + "IsCount", this.IsCount);
        }
    }
}

