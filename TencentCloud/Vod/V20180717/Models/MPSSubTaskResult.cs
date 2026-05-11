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

    public class MPSSubTaskResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Specific subtask type in the MPS WorkflowTask structure. Value:
        /// <li>MediaProcess.Transcode: audio and video transcoding task.</li>
        /// <li>AiAnalysis.DeLogo: intelligent erasure task.</li>
        /// <li>AiAnalysis.ClassificationTask: intelligent classification task.</li>
        /// <li>AiAnalysis.CoverTask: intelligent thumbnail generating.</li>
        /// <li>AiAnalysis.TagTask: intelligent tag task.</li>
        /// <li>AiAnalysis.FrameTagTask: intelligent frame-by-frame tagging task.</li>
        /// <li>AiAnalysis.HighlightTask: Intelligent highlight task.</li>
        /// <li>AiAnalysis.SegmentTask: Intelligent video splitting task.</li>
        /// <li>AiAnalysis.HeadTailTask: Intelligent opening and closing credits task.</li>
        /// <li>AiAnalysis.DescriptionTask: Intelligent summary task.</li>
        /// <li>AiAnalysis.HorizontalToVerticalTask: Intelligent Landscape to Portrait Task.</li>
        /// <li>AiAnalysis.DubbingTask: Intelligent dubbing task.</li>
        /// <li>AiAnalysis.VideoRemakeTask: Intelligent deduplication task.</li>
        /// <li>AiAnalysis.VideoComprehensionTask: Video understanding task.</li>
        /// <li>SmartSubtitle.AsrFullTextTask: intelligent speech full-text recognition task.</li>
        /// <li>SmartSubtitle.TransTextTask: Translation result.</li>
        /// <li>SmartSubtitle.PureSubtitleTransTask: Returns the translation result of the pure subtitle file.</li>
        /// <li>SmartSubtitle.OcrFullTextTask: Intelligent text extraction subtitle task.</li>
        /// <li>SmartErase: intelligent erasure task.</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task status, including PROCESSING, SUCCESS, and FAIL.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error code. 0 indicates success, others indicate failure.
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// MPS video processing task input. This field corresponds to the Input result returned by the MPS task in JSON format.
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// MPS video processing task output.
        /// </summary>
        [JsonProperty("Output")]
        public MPSTaskOutput Output{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
        }
    }
}

