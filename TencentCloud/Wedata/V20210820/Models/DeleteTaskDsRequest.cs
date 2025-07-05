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

    public class DeleteTaskDsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Delete script?
        /// true: delete
        /// false: do not delete
        /// Default false if not passed
        /// </summary>
        [JsonProperty("DeleteScript")]
        public bool? DeleteScript{ get; set; }

        /// <summary>
        /// Task operation: Notify downstream task owners?
        /// true: notify
        /// false: do not notify
        /// Default false if not passed
        /// </summary>
        [JsonProperty("OperateInform")]
        public bool? OperateInform{ get; set; }

        /// <summary>
        /// Task IDChoose either VirtualTaskId or
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Virtual task id
        /// Either TaskId or this field is optional
        /// </summary>
        [JsonProperty("VirtualTaskId")]
        public string VirtualTaskId{ get; set; }

        /// <summary>
        /// Virtual task flag
        /// true: It is a virtual task
        /// false: It is not a virtual task
        /// Default false if not passed
        /// </summary>
        [JsonProperty("VirtualFlag")]
        public bool? VirtualFlag{ get; set; }

        /// <summary>
        /// Task deletion method
        /// true: Do not force fail downstream task instances
        /// false: Force fail downstream task instances
        /// If not specified, the default is false
        /// </summary>
        [JsonProperty("DeleteMode")]
        public bool? DeleteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeleteScript", this.DeleteScript);
            this.SetParamSimple(map, prefix + "OperateInform", this.OperateInform);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "VirtualTaskId", this.VirtualTaskId);
            this.SetParamSimple(map, prefix + "VirtualFlag", this.VirtualFlag);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
        }
    }
}

