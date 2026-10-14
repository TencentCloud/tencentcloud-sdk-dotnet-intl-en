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

    public class WorkflowTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Media processing task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task flow status. Valid values: </p><li>PROCESSING: Processing; </li><li>FINISH: Completed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Returns a non-zero error code when a source error occurs. If 0 is returned, use the ErrCode of each specific task.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// <p>Returns the corresponding error Message when a source error occurs. Otherwise, use the Message of each specific task.</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>Target file information of media processing.</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>Metadata of the original video.</p>
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// <p>Execution status and result of the media processing task.</p>
        /// </summary>
        [JsonProperty("MediaProcessResultSet")]
        public MediaProcessTaskResult[] MediaProcessResultSet{ get; set; }

        /// <summary>
        /// <p>Execution status and results of the video content review task.</p>
        /// </summary>
        [JsonProperty("AiContentReviewResultSet")]
        public AiContentReviewResult[] AiContentReviewResultSet{ get; set; }

        /// <summary>
        /// <p>Execution status and results of the video content analysis task.</p>
        /// </summary>
        [JsonProperty("AiAnalysisResultSet")]
        public AiAnalysisResult[] AiAnalysisResultSet{ get; set; }

        /// <summary>
        /// <p>Execution status and results of the video content recognition task.</p>
        /// </summary>
        [JsonProperty("AiRecognitionResultSet")]
        public AiRecognitionResult[] AiRecognitionResultSet{ get; set; }

        /// <summary>
        /// <p>Execution status and results of a media quality inspection task.</p>
        /// </summary>
        [JsonProperty("AiQualityControlTaskResult")]
        public ScheduleQualityControlTaskResult AiQualityControlTaskResult{ get; set; }

        /// <summary>
        /// <p>Execution result of the smart subtitle task</p>
        /// </summary>
        [JsonProperty("SmartSubtitlesTaskResult")]
        public SmartSubtitlesResult[] SmartSubtitlesTaskResult{ get; set; }

        /// <summary>
        /// <p>Outcome of the intelligent erasure task</p>
        /// </summary>
        [JsonProperty("SmartEraseTaskResult")]
        public SmartEraseTaskResult SmartEraseTaskResult{ get; set; }

        /// <summary>
        /// <p>Outcome of the AI dubbing task.</p>
        /// </summary>
        [JsonProperty("AiDubbingTaskResult")]
        public AIDubbingTaskResult AiDubbingTaskResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamArrayObj(map, prefix + "MediaProcessResultSet.", this.MediaProcessResultSet);
            this.SetParamArrayObj(map, prefix + "AiContentReviewResultSet.", this.AiContentReviewResultSet);
            this.SetParamArrayObj(map, prefix + "AiAnalysisResultSet.", this.AiAnalysisResultSet);
            this.SetParamArrayObj(map, prefix + "AiRecognitionResultSet.", this.AiRecognitionResultSet);
            this.SetParamObj(map, prefix + "AiQualityControlTaskResult.", this.AiQualityControlTaskResult);
            this.SetParamArrayObj(map, prefix + "SmartSubtitlesTaskResult.", this.SmartSubtitlesTaskResult);
            this.SetParamObj(map, prefix + "SmartEraseTaskResult.", this.SmartEraseTaskResult);
            this.SetParamObj(map, prefix + "AiDubbingTaskResult.", this.AiDubbingTaskResult);
        }
    }
}

