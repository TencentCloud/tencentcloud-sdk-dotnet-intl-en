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

    public class CreateAIAnalysisTemplateRequest : AbstractModel
    {
        
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
        public ClassificationConfigureInfo ClassificationConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent tagging task.
        /// </summary>
        [JsonProperty("TagConfigure")]
        public TagConfigureInfo TagConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent cover generating task.
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public CoverConfigureInfo CoverConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent frame-specific tagging task.
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public FrameTagConfigureInfo FrameTagConfigure{ get; set; }

        /// <summary>
        /// Control parameter of an intelligent highlight generating task.
        /// </summary>
        [JsonProperty("HighlightConfigure")]
        public HighlightsConfigureInfo HighlightConfigure{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "ClassificationConfigure.", this.ClassificationConfigure);
            this.SetParamObj(map, prefix + "TagConfigure.", this.TagConfigure);
            this.SetParamObj(map, prefix + "CoverConfigure.", this.CoverConfigure);
            this.SetParamObj(map, prefix + "FrameTagConfigure.", this.FrameTagConfigure);
            this.SetParamObj(map, prefix + "HighlightConfigure.", this.HighlightConfigure);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

