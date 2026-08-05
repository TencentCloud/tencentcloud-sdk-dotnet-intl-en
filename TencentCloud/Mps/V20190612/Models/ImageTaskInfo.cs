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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>TaskId of the image processing task.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task status.</p><p>Enumeration values: </p><ul><li>FINISH: Task completion</li><li>PROCESSING: Task processing</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Input file.</p>
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// <p>Creation time.</p><p>Parameter format: YYYY-MM-DDThh:mm:ssZ</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Processing start time.</p><p>Parameter format: YYYY-MM-DDThh:mm:ssZ</p>
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// <p>End time.</p><p>Parameter format: YYYY-MM-DDThh:mm:ssZ</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Subtask failure identifier.</p>
        /// </summary>
        [JsonProperty("SubTaskHasFailed")]
        public bool? SubTaskHasFailed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "SubTaskHasFailed", this.SubTaskHasFailed);
        }
    }
}

