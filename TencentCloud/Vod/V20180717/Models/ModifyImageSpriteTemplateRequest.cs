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

    public class ModifyImageSpriteTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Sprite template unique identifier.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Sprite image template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Width of small images in sprite image. Value range: [32, 4096]. Unit: px.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Height of small images in sprite image. Value range: [32, 4096]. Unit: px.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaptation. Available values:
        /// <li>open: enable. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: closed. At this point, Width represents the video width, and Height indicates the video height.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Sampling type. Valid values:
        /// <li>Percent: by percent.</li>
        /// <li>Time: by time interval. </li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval.
        /// <li>When SampleType is Percent, specify the percentage of the sampling interval.</li>
        /// <li>When SampleType is Time, specify the sampling interval in seconds.</li>
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
        /// Filling mode. When the video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "filling". Optional filling modes: <li>stretch: stretch each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched";</li><li>black: keep black edges, maintain video aspect ratio, and fill the remaining edge part with black.</li><li>white: keep white edges, maintain video aspect ratio, and fill the remaining edge part with white.</li><li>gauss: Gaussian blur, maintain video aspect ratio, and apply Gaussian blur to the remaining edge part.</li>Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Image format. Value:
        /// <li> jpg: jpg format;</li>
        /// <li> png: PNG format;</li>
        /// <li> webp: webp format.</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ColumnCount", this.ColumnCount);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}

