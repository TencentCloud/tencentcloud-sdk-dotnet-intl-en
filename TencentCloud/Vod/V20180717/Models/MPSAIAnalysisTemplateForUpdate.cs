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

    public class MPSAIAnalysisTemplateForUpdate : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique identifier of a video analysis template.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Video analysis template name. The length cannot exceed 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Video analysis template description, with a length limit of 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Intelligent Classification Task Control Parameters.</p>
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public MPSAIAnalysisConfigureInfo ClassificationConfigure{ get; set; }

        /// <summary>
        /// <p>Intelligent tag task control parameter.</p>
        /// </summary>
        [JsonProperty("TagConfigure")]
        public MPSAIAnalysisConfigureInfo TagConfigure{ get; set; }

        /// <summary>
        /// <p>Parameters for the intelligent cover task.</p>
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public MPSAIAnalysisConfigureInfo CoverConfigure{ get; set; }

        /// <summary>
        /// <p>Task control parameters for intelligent frame tagging.</p>
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public MPSAIAnalysisConfigureInfo FrameTagConfigure{ get; set; }

        /// <summary>
        /// <p>Task control parameter for intelligent splitting.</p>
        /// </summary>
        [JsonProperty("SplitConfigure")]
        public MPSAIAnalysisConfigureInfo SplitConfigure{ get; set; }

        /// <summary>
        /// <p>Intelligent highlights task control parameter.</p>
        /// </summary>
        [JsonProperty("HighlightConfigure")]
        public MPSAIAnalysisConfigureInfo HighlightConfigure{ get; set; }

        /// <summary>
        /// <p>Parameters for the intelligent video opening/closing credits task.</p>
        /// </summary>
        [JsonProperty("OpeningAndEndingConfigure")]
        public MPSAIAnalysisConfigureInfo OpeningAndEndingConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "ClassificationConfigure.", this.ClassificationConfigure);
            this.SetParamObj(map, prefix + "TagConfigure.", this.TagConfigure);
            this.SetParamObj(map, prefix + "CoverConfigure.", this.CoverConfigure);
            this.SetParamObj(map, prefix + "FrameTagConfigure.", this.FrameTagConfigure);
            this.SetParamObj(map, prefix + "SplitConfigure.", this.SplitConfigure);
            this.SetParamObj(map, prefix + "HighlightConfigure.", this.HighlightConfigure);
            this.SetParamObj(map, prefix + "OpeningAndEndingConfigure.", this.OpeningAndEndingConfigure);
        }
    }
}

