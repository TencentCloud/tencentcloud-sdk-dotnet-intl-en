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

    public class SplitMediaTaskSegmentInfo : AbstractModel
    {
        
        /// <summary>
        /// Input information of the video splitting task.
        /// </summary>
        [JsonProperty("Input")]
        public SplitMediaTaskInput Input{ get; set; }

        /// <summary>
        /// Output information of the video splitting task.
        /// </summary>
        [JsonProperty("Output")]
        public TaskOutputMediaInfo Output{ get; set; }

        /// <summary>
        /// Task ID of the `Procedure` task type. If a task flow template (`ProcedureName`) is specified in the video split task information list when initiating a video splitting task (https://www.tencentcloud.com/document/api/266/51098?from_cn_redirect=1), the task is initiated when the task flow template specifies one or more of `MediaProcessTask`, `AiAnalysisTask`, and `AiRecognitionTask`.
        /// </summary>
        [JsonProperty("ProcedureTaskId")]
        public string ProcedureTaskId{ get; set; }

        /// <summary>
        /// Task ID of the `ReviewAudioVideo` type. If a task flow template (`ProcedureName`) is specified in the video split task information list when initiating a [video splitting](https://www.tencentcloud.com/document/api/266/51098?from_cn_redirect=1) task, the task is triggered when `ReviewAudioVideoTask` is specified in the task flow template.
        /// </summary>
        [JsonProperty("ReviewAudioVideoTaskId")]
        public string ReviewAudioVideoTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ProcedureTaskId", this.ProcedureTaskId);
            this.SetParamSimple(map, prefix + "ReviewAudioVideoTaskId", this.ReviewAudioVideoTaskId);
        }
    }
}

