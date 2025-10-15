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

    public class WorkflowDetail : AbstractModel
    {
        
        /// <summary>
        /// Workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Owner ID.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Creator ID.
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Workflow type. Valid values: cycle or manual.
        /// </summary>
        [JsonProperty("WorkflowType")]
        public string WorkflowType{ get; set; }

        /// <summary>
        /// Workflow parameter array.
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public ParamInfo[] WorkflowParams{ get; set; }

        /// <summary>
        /// Unified scheduling parameter.
        /// .
        /// </summary>
        [JsonProperty("WorkflowSchedulerConfiguration")]
        public WorkflowSchedulerConfiguration WorkflowSchedulerConfiguration{ get; set; }

        /// <summary>
        /// Workflow description.
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// Workflow path.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// BundleId item.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// BundleInfo item. specifies the bundle information.
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "WorkflowType", this.WorkflowType);
            this.SetParamArrayObj(map, prefix + "WorkflowParams.", this.WorkflowParams);
            this.SetParamObj(map, prefix + "WorkflowSchedulerConfiguration.", this.WorkflowSchedulerConfiguration);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

