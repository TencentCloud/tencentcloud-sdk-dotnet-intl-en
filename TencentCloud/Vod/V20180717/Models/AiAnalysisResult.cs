/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// <li>Classification: intelligent categorization</li>
        /// <li>Cover: intelligent cover generating</li>
        /// <li>Tag: intelligent tagging</li>
        /// <li>FrameTag: intelligent frame tagging</li>
        /// <li>Highlight: intelligent highlight generating</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Query result of intelligent categorization task in video content analysis, which is valid if task type is `Classification`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClassificationTask")]
        public AiAnalysisTaskClassificationResult ClassificationTask{ get; set; }

        /// <summary>
        /// Query result of intelligent cover generating task in video content analysis, which is valid if task type is `Cover`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverTask")]
        public AiAnalysisTaskCoverResult CoverTask{ get; set; }

        /// <summary>
        /// Query result of intelligent tagging task in video content analysis, which is valid if task type is `Tag`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagTask")]
        public AiAnalysisTaskTagResult TagTask{ get; set; }

        /// <summary>
        /// Query result of intelligent frame-specific tagging task in video content analysis, which is valid if task type is `FrameTag`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FrameTagTask")]
        public AiAnalysisTaskFrameTagResult FrameTagTask{ get; set; }

        /// <summary>
        /// Query result of an intelligent highlight generating task in video content analysis, which is valid when task type is `Highlight`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
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

