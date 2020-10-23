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

    public class AIAnalysisTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of intelligent analysis template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Intelligent analysis template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Intelligent analysis template description.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Control parameter of intelligent categorization task.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public ClassificationConfigureInfo ClassificationConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent tagging task.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagConfigure")]
        public TagConfigureInfo TagConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent cover generating task.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public CoverConfigureInfo CoverConfigure{ get; set; }

        /// <summary>
        /// Control parameter of intelligent frame-specific tagging task.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public FrameTagConfigureInfo FrameTagConfigure{ get; set; }

        /// <summary>
        /// Control parameter of an intelligent highlight generating task.
        /// </summary>
        [JsonProperty("HighlightConfigure")]
        public HighlightsConfigureInfo HighlightConfigure{ get; set; }

        /// <summary>
        /// Creation time of template in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time of template in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


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
            this.SetParamObj(map, prefix + "HighlightConfigure.", this.HighlightConfigure);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

