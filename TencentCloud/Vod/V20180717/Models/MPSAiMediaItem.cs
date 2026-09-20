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

    public class MPSAiMediaItem : AbstractModel
    {
        
        /// <summary>
        /// MPS intelligent processing task type. Valid values:
        /// <li>AiAnalysis.ClassificationTask: intelligent classification task.</li>
        /// <li>AiAnalysis.CoverTask: Intelligent Cover Task.</li>
        /// <li>AiAnalysis.TagTask: intelligent tag task.</li>
        /// <li>AiAnalysis.FrameTagTask: intelligent frame-specific tagging task.</li>
        /// <li>AiAnalysis.HighlightTask: intelligent highlight task.</li>
        /// <li>AiAnalysis.SegmentTask: intelligent splitting task.</li>
        /// <li>AiAnalysis.HeadTailTask: intelligent opening and closing credits task.</li>
        /// <li>AiAnalysis.DescriptionTask: intelligent summarization task.</li>
        /// <li>AiAnalysis.HorizontalToVerticalTask: Intelligent Landscape to Portrait Task.</li>
        /// <li>AiAnalysis.DubbingTask: intelligent dubbing task.</li>
        /// <li>AiAnalysis.VideoRemakeTask: Intelligent deduplication task.</li>
        /// <li>AiAnalysis.VideoComprehensionTask: video understanding task.</li>
        /// <li>SmartSubtitle.AsrFullTextTask: intelligent speech full-text recognition task.</li>
        /// <li>SmartSubtitle.TransTextTask: Translation result.</li>
        /// <li>SmartSubtitle.PureSubtitleTransTask: return the translation result of a pure subtitle file.</li>
        /// <li>SmartSubtitle.OcrFullTextTask: intelligent text extraction subtitle task.</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// MPS intelligent processing task result set
        /// </summary>
        [JsonProperty("AiMediaTasks")]
        public MPSAiMediaTask[] AiMediaTasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "AiMediaTasks.", this.AiMediaTasks);
        }
    }
}

