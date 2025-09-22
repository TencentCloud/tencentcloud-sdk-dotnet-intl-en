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
        /// Task type. valid values:.
        /// <Li>Classification: intelligent classification.</li>.
        /// <Li>Cover: specifies the intelligent cover.</li>.
        /// <Li>Tag: intelligent tag.</li>.
        /// <Li>FrameTag: specifies intelligent frame-by-frame tagging.</li>.
        /// <Li>Highlight: intelligent highlights</li>.
        /// <Li>DeLogo: intelligent removal.</li>.
        /// <li>Description: large model summarization.</li>
        /// 
        /// <Li>Dubbing: intelligent dubbing.</li>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Query result of intelligent categorization task in video content analysis, which is valid if task type is `Classification`.
        /// </summary>
        [JsonProperty("ClassificationTask")]
        public AiAnalysisTaskClassificationResult ClassificationTask{ get; set; }

        /// <summary>
        /// Query result of intelligent cover generating task in video content analysis, which is valid if task type is `Cover`.
        /// </summary>
        [JsonProperty("CoverTask")]
        public AiAnalysisTaskCoverResult CoverTask{ get; set; }

        /// <summary>
        /// Query result of intelligent tagging task in video content analysis, which is valid if task type is `Tag`.
        /// </summary>
        [JsonProperty("TagTask")]
        public AiAnalysisTaskTagResult TagTask{ get; set; }

        /// <summary>
        /// Query result of intelligent frame-specific tagging task in video content analysis, which is valid if task type is `FrameTag`.
        /// </summary>
        [JsonProperty("FrameTagTask")]
        public AiAnalysisTaskFrameTagResult FrameTagTask{ get; set; }

        /// <summary>
        /// The result of a highlight generation task. This parameter is valid if `Type` is `Highlight`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HighlightTask")]
        public AiAnalysisTaskHighlightResult HighlightTask{ get; set; }

        /// <summary>
        /// The query result of an intelligent removal task for video analysis, which is valid when the task type is DeLogo.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeLogoTask")]
        public AiAnalysisTaskDelLogoResult DeLogoTask{ get; set; }

        /// <summary>
        /// The query result of a splitting task for video analysis, which is valid when the task type is SegmentRecognition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiAnalysisTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// The query result of an opening and closing segments recognition task for video analysis, which is valid when the task type is HeadTailRecognition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiAnalysisTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// The query result of a video analysis summarization task, which is valid when the task type is Description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DescriptionTask")]
        public AiAnalysisTaskDescriptionResult DescriptionTask{ get; set; }

        /// <summary>
        /// The query result of a landscape-to-portrait task for video analysis, which is valid when the task type is HorizontalToVertical.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HorizontalToVerticalTask")]
        public AiAnalysisTaskHorizontalToVerticalResult HorizontalToVerticalTask{ get; set; }

        /// <summary>
        /// The query result of a Dubbing task for video content analysis, which is valid when the task type is Dubbing.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DubbingTask")]
        public AiAnalysisTaskDubbingResult DubbingTask{ get; set; }


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
        }
    }
}

