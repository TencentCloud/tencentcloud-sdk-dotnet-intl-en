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

    public class RemoveWorkflowDsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Workflow ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Whether to delete the script
        /// </summary>
        [JsonProperty("DeleteScript")]
        public string DeleteScript{ get; set; }

        /// <summary>
        /// Notify downstream if deleted
        /// </summary>
        [JsonProperty("OperateIsInform")]
        public string OperateIsInform{ get; set; }

        /// <summary>
        /// Whether to terminate ongoing tasks
        /// </summary>
        [JsonProperty("DeleteMode")]
        public string DeleteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "DeleteScript", this.DeleteScript);
            this.SetParamSimple(map, prefix + "OperateIsInform", this.OperateIsInform);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
        }
    }
}

