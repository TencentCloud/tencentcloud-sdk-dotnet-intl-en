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

    public class AiAnalysisResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Task type. Valid values:</p><li>Classification: intelligent classification</li><li>Cover: intelligent cover</li><li>Tag: intelligent tag</li><li>FrameTag: intelligent frame tagging</li><li>Highlight: intelligent highlights</li><li>DeLogo: smart erasing</li><li>Description: LLM summarization</li><li>Dubbing: intelligent dubbing</li><li>VideoRemake: video deduplication</li><li>VideoComprehension: video (audio) understanding</li><li>Cutout: video matting</li><li>Reel: intelligent video creation</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis intelligent categorization task. Valid when the task type is Classification.</p>
        /// </summary>
        [JsonProperty("ClassificationTask")]
        public AiAnalysisTaskClassificationResult ClassificationTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis Intelligent Cover Task. Valid when the task type is Cover.</p>
        /// </summary>
        [JsonProperty("CoverTask")]
        public AiAnalysisTaskCoverResult CoverTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis intelligent tag task. Valid when the task type is Tag.</p>
        /// </summary>
        [JsonProperty("TagTask")]
        public AiAnalysisTaskTagResult TagTask{ get; set; }

        /// <summary>
        /// <p>Query result of the intelligent frame tagging task for video content analysis. Valid when the task type is FrameTag.</p>
        /// </summary>
        [JsonProperty("FrameTagTask")]
        public AiAnalysisTaskFrameTagResult FrameTagTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis highlight task. Valid when the task type is Highlight.</p>
        /// </summary>
        [JsonProperty("HighlightTask")]
        public AiAnalysisTaskHighlightResult HighlightTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis smart erasing task. Valid when the task type is DeLogo.</p>
        /// </summary>
        [JsonProperty("DeLogoTask")]
        public AiAnalysisTaskDelLogoResult DeLogoTask{ get; set; }

        /// <summary>
        /// <p>The query result of a splitting task for video analysis, which is valid when the task type is SegmentRecognition.</p>
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiAnalysisTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// <p>The query result of an opening and closing segments recognition task for video analysis, which is valid when the task type is HeadTailRecognition.</p>
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiAnalysisTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// <p>The query result of a video content analysis summary task, valid when the task type is Description.</p>
        /// </summary>
        [JsonProperty("DescriptionTask")]
        public AiAnalysisTaskDescriptionResult DescriptionTask{ get; set; }

        /// <summary>
        /// <p>The query result of a landscape-to-portrait task for video content analysis, which is valid when the task type is HorizontalToVertical.</p>
        /// </summary>
        [JsonProperty("HorizontalToVerticalTask")]
        public AiAnalysisTaskHorizontalToVerticalResult HorizontalToVerticalTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis dubbing task. Valid when the task type is Dubbing.</p>
        /// </summary>
        [JsonProperty("DubbingTask")]
        public AiAnalysisTaskDubbingResult DubbingTask{ get; set; }

        /// <summary>
        /// <p>The query result of a deduplication task for video content analysis, which is valid when the task type is VideoRemake.</p>
        /// </summary>
        [JsonProperty("VideoRemakeTask")]
        public AiAnalysisTaskVideoRemakeResult VideoRemakeTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video (audio) understanding task. This parameter is valid when the task type is VideoComprehension.</p>
        /// </summary>
        [JsonProperty("VideoComprehensionTask")]
        public AiAnalysisTaskVideoComprehensionResult VideoComprehensionTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis intelligent image masking task. Valid when the task type is Cutout.</p>
        /// </summary>
        [JsonProperty("CutoutTask")]
        public AiAnalysisTaskCutoutResult CutoutTask{ get; set; }

        /// <summary>
        /// <p>Query result of the video content analysis AI narration and video re-creation task. Valid when the task type is Reel.</p>
        /// </summary>
        [JsonProperty("ReelTask")]
        public AiAnalysisTaskReelResult ReelTask{ get; set; }

        /// <summary>
        /// <p>Query result of the intelligent analysis common task. Valid when the task type is Generic.</p>
        /// </summary>
        [JsonProperty("GenericTask")]
        public AiAnalysisTaskGenericResult GenericTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "ClassificationTask.", this.ClassificationTask);
            this.SetParamObj(map, prefix + "CoverTask.", this.CoverTask);
            this.SetParamObj(map, prefix + "TagTask.", this.TagTask);
            this.SetParamObj(map, prefix + "FrameTagTask.", this.FrameTagTask);
            this.SetParamObj(map, prefix + "HighlightTask.", this.HighlightTask);
            this.SetParamObj(map, prefix + "DeLogoTask.", this.DeLogoTask);
            this.SetParamObj(map, prefix + "SegmentTask.", this.SegmentTask);
            this.SetParamObj(map, prefix + "HeadTailTask.", this.HeadTailTask);
            this.SetParamObj(map, prefix + "DescriptionTask.", this.DescriptionTask);
            this.SetParamObj(map, prefix + "HorizontalToVerticalTask.", this.HorizontalToVerticalTask);
            this.SetParamObj(map, prefix + "DubbingTask.", this.DubbingTask);
            this.SetParamObj(map, prefix + "VideoRemakeTask.", this.VideoRemakeTask);
            this.SetParamObj(map, prefix + "VideoComprehensionTask.", this.VideoComprehensionTask);
            this.SetParamObj(map, prefix + "CutoutTask.", this.CutoutTask);
            this.SetParamObj(map, prefix + "ReelTask.", this.ReelTask);
            this.SetParamObj(map, prefix + "GenericTask.", this.GenericTask);
        }
    }
}

