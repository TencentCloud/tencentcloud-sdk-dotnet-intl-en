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

    public class ModifyAIAnalysisTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of video content analysis template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Video content analysis template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Video content analysis template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Control parameter of intelligent categorization task.
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public ClassificationConfigureInfoForUpdate ClassificationConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent tagging task.
        /// </summary>
        [JsonProperty("TagConfigure")]
        public TagConfigureInfoForUpdate TagConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent cover generating task.
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public CoverConfigureInfoForUpdate CoverConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent frame-specific tagging task.
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public FrameTagConfigureInfoForUpdate FrameTagConfigure{ get; set; }


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
        }
    }
}

