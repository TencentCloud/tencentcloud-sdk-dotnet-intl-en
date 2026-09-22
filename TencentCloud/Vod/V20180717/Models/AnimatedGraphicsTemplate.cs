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

    public class AnimatedGraphicsTemplate : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier for rotation diagram template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Template type. Valid values:
        /// <li>Preset: system-preset template;</li>
        /// <li>Custom: custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Rotating image template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Animated image template description information.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Maximum value of the animated gif width (or long edge) in px. Value range: 0 and [128, 4096].
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the animated gif height (or short side). Value range: 0 and [128, 4096]. Unit: px.
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaptation. Available values:
        /// <li>open: enable. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: closed. At this point, Width represents the width of the video, and Height indicates the height of the video.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Animated image file format.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Frame rate.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Image quality.
        /// </summary>
        [JsonProperty("Quality")]
        public float? Quality{ get; set; }

        /// <summary>
        /// Template creation time in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Template last modified time in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Quality", this.Quality);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

