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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcAudioTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task status. Valid values: <li>PROCESSING: Processing; </li><li>FINISH: Completed.</li></p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Error code. A non-zero error code is returned when a source error occurs. If 0 is returned, use the ErrCode of each specific task.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// <p>Extended error code. An empty string indicates success, and other values indicate failure.</p><p>Enumeration values:</p><ul><li>RequestLimitExceeded: The call exceeds the concurrency limit.</li><li>InvalidParameter.VoilationContent: The input prompt violates the Content Security Policy.</li><li>InvalidParameterValue: Parameter value error.</li><li>FailedOperation: Model tasks accumulate.</li><li>InternalError: Internal error.</li><li>InvalidParameter: Invalid parameter.</li><li>InvalidParameter.MediaFormat: Invalid media format.</li><li>ContentModerationFailed: Content moderation failed.</li><li>ResourceInsufficient: Insufficient resources.</li><li>ModelGenerateFailed: Model generation failed.</li><li>ResourceNotFound: Resource not found.</li><li>OperationCanceled: Operation canceled.</li><li>TaskTimeout: Task timeout.</li></ul>
        /// </summary>
        [JsonProperty("ErrCodeExt")]
        public string ErrCodeExt{ get; set; }

        /// <summary>
        /// <p>Error message.</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>Task progress. Value range: 0–100.</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// <p>Input information of the AIGC audio task.</p>
        /// </summary>
        [JsonProperty("Input")]
        public AigcAudioTaskInput Input{ get; set; }

        /// <summary>
        /// <p>Output information of AIGC audio tasks.</p>
        /// </summary>
        [JsonProperty("Output")]
        public AigcAudioTaskOutput Output{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrCodeExt", this.ErrCodeExt);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
        }
    }
}

