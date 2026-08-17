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
        /// Task type. Valid values:
        /// <li>Classification: intelligent classification.</li>
        /// <li>Cover: intelligent cover</li>
        /// <li>Tag: intelligent tagging.</li>
        /// <li>FrameTag: intelligent frame tagging.</li>
        /// <li>Highlight: Intelligent Highlights</li>
        /// <li>DeLogo: intelligent removal.</li>
        /// <li>Description: large model summarization.</li>
        /// <li>Dubbing: Intelligent Dubbing</li>
        /// <li>VideoRemake: Video deduplication</li>
        /// <li>VideoComprehension: video (audio) recognition.</li>
        /// <li>Cutout: Video matting</li>
        /// <li>Reel: intelligent video editing.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClassificationTask")]
        public AiAnalysisTaskClassificationResult ClassificationTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CoverTask")]
        public AiAnalysisTaskCoverResult CoverTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TagTask")]
        public AiAnalysisTaskTagResult TagTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FrameTagTask")]
        public AiAnalysisTaskFrameTagResult FrameTagTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HighlightTask")]
        public AiAnalysisTaskHighlightResult HighlightTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeLogoTask")]
        public AiAnalysisTaskDelLogoResult DeLogoTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiAnalysisTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiAnalysisTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DescriptionTask")]
        public AiAnalysisTaskDescriptionResult DescriptionTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HorizontalToVerticalTask")]
        public AiAnalysisTaskHorizontalToVerticalResult HorizontalToVerticalTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DubbingTask")]
        public AiAnalysisTaskDubbingResult DubbingTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoRemakeTask")]
        public AiAnalysisTaskVideoRemakeResult VideoRemakeTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoComprehensionTask")]
        public AiAnalysisTaskVideoComprehensionResult VideoComprehensionTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CutoutTask")]
        public AiAnalysisTaskCutoutResult CutoutTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReelTask")]
        public AiAnalysisTaskReelResult ReelTask{ get; set; }


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
        }
    }
}

