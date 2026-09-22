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

    public class ImageSpriteTemplate : AbstractModel
    {
        
        /// <summary>
        /// Sprite template unique identifier.
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
        /// Sprite sheet template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Maximum width (or long side) of small images in sprite image. Value range: 0 and [128, 4096]. Unit: px.
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum height (or short side) of small images in the sprite image. Value range: 0 and [128, 4096]. Unit: px.
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
        /// <li>open: enable. At this point, Width represents the long side of the video, and Height represents the short side.</li>
        /// <li>close: closed. At this point, Width represents the video width, and Height indicates the video height.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Sampling type.
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval.
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// Number of rows of small images in the sprite image.
        /// </summary>
        [JsonProperty("RowCount")]
        public ulong? RowCount{ get; set; }

        /// <summary>
        /// Number of columns of small images in the sprite image.
        /// </summary>
        [JsonProperty("ColumnCount")]
        public ulong? ColumnCount{ get; set; }

        /// <summary>
        /// Template creation time. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Template last modified time in ISO date format (https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Filling method. When the aspect ratio of the video stream configuration width and height parameters is inconsistent with that of the original video, the processing method for transcoding is "padding". Optional filling methods:
        /// <li> stretch: Stretch each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched";</li>
        /// <li>black: Fill with black. Maintain the video aspect ratio and fill the remaining edges with black.</li>
        /// Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// Template description information.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Image format.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ColumnCount", this.ColumnCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}

