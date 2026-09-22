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

    public class AiAnalysisResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// <li>Classification: intelligent classification.</li>
        /// <li>Cover: intelligent cover</li>
        /// <li>Tag: intelligent tag</li>
        /// <li>FrameTag: intelligent frame-by-frame tagging.</li>
        /// <li>Highlight: intelligent highlights</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Query result of the video content analysis intelligent categorization task. Valid when the task type is `Classification`.
        /// </summary>
        [JsonProperty("ClassificationTask")]
        public AiAnalysisTaskClassificationResult ClassificationTask{ get; set; }

        /// <summary>
        /// Query result of the video content analysis Intelligent Cover Task. Valid when the task type is `Cover`.
        /// </summary>
        [JsonProperty("CoverTask")]
        public AiAnalysisTaskCoverResult CoverTask{ get; set; }

        /// <summary>
        /// Query result of the video content analysis intelligent tag task. Valid when the task type is `Tag`.
        /// </summary>
        [JsonProperty("TagTask")]
        public AiAnalysisTaskTagResult TagTask{ get; set; }

        /// <summary>
        /// Query result of the intelligent frame-specific tagging task for video content analysis. Valid when TaskType is `FrameTag`.
        /// </summary>
        [JsonProperty("FrameTagTask")]
        public AiAnalysisTaskFrameTagResult FrameTagTask{ get; set; }

        /// <summary>
        /// Query result of the video content analysis intelligent highlight task. Valid when the task type is `Highlight`.
        /// </summary>
        [JsonProperty("HighlightTask")]
        public AiAnalysisTaskHighlightResult HighlightTask{ get; set; }


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
        }
    }
}

