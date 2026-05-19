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

    public class ModifyAIAnalysisTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of an audio and video content analysis template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate VOD services after December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Audio and video content analysis template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Audio/video content analysis template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Intelligent classification task control parameters.
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public ClassificationConfigureInfoForUpdate ClassificationConfigure{ get; set; }

        /// <summary>
        /// Intelligent tag task control parameter.
        /// </summary>
        [JsonProperty("TagConfigure")]
        public TagConfigureInfoForUpdate TagConfigure{ get; set; }

        /// <summary>
        /// Intelligent Cover Task Control Parameters.
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public CoverConfigureInfoForUpdate CoverConfigure{ get; set; }

        /// <summary>
        /// Intelligent frame tagging task control parameter.
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public FrameTagConfigureInfoForUpdate FrameTagConfigure{ get; set; }

        /// <summary>
        /// Intelligent Highlights Compilation Task Control Parameters.
        /// </summary>
        [JsonProperty("HighlightConfigure")]
        public HighlightsConfigureInfoForUpdate HighlightConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "ClassificationConfigure.", this.ClassificationConfigure);
            this.SetParamObj(map, prefix + "TagConfigure.", this.TagConfigure);
            this.SetParamObj(map, prefix + "CoverConfigure.", this.CoverConfigure);
            this.SetParamObj(map, prefix + "FrameTagConfigure.", this.FrameTagConfigure);
            this.SetParamObj(map, prefix + "HighlightConfigure.", this.HighlightConfigure);
        }
    }
}

