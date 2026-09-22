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

    public class WatermarkTemplate : AbstractModel
    {
        
        /// <summary>
        /// Watermark template unique identifier.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Watermark type. Valid values:
        /// <li>image: image watermark;</li>
        /// <li>text: text watermark.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Watermark template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description information.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Horizontal position of the watermark image origin point relative to the video origin point.
        /// <li>If a string ends with %, it indicates that the `Left` of a watermark is a position at a specified percentage of a video's width. For example, `10%` means that `Left` is 10% of a video's width.</li>
        /// <li>If a string ends with px, it means the watermark Left is at the position of the specified pixel of the video width. For example, 100px means Left is 100 pixels.</li>
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the watermark image origin point relative to the video image origin point.
        /// <li>If a string ends with %, it indicates that the `Top` of a watermark is a position at a specified percentage of a video's height. For example, `10%` means that `Top` is 10% of a video's height.</li>
        /// <li>If a string ends with px, it means the watermark Top is at the position specified in pixels from the video height. For example, 100px means the Top is 100 pixels.</li>
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Image watermark template. This field is valid only when Type is image.
        /// </summary>
        [JsonProperty("ImageTemplate")]
        public ImageWatermarkTemplate ImageTemplate{ get; set; }

        /// <summary>
        /// Text watermarking template. This field is valid only when Type is text.
        /// </summary>
        [JsonProperty("TextTemplate")]
        public TextWatermarkTemplateInput TextTemplate{ get; set; }

        /// <summary>
        /// SVG watermark template. This field is valid when Type is `svg`.
        /// </summary>
        [JsonProperty("SvgTemplate")]
        public SvgWatermarkInput SvgTemplate{ get; set; }

        /// <summary>
        /// Template creation time, in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Template last modified time, use [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Origin position. Valid values:
        /// <li>topLeft: indicates that the coordinate origin is at the top left corner of the video image and the watermark origin is at the top left corner of the image or text.</li>
        /// <li>topRight: indicates that the coordinate origin is at the top right corner of the video image and the watermark origin is at the top right corner of the image or text.</li>
        /// <li>bottomLeft: indicates that the coordinate origin is at the bottom-left corner of the video image and the watermark origin is at the bottom-left corner of the image or text.</li>
        /// <li>bottomRight: indicates that the coordinate origin is at the bottom right corner of the video image and the watermark origin is at the lower-right of the image or text.;</li>
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamObj(map, prefix + "ImageTemplate.", this.ImageTemplate);
            this.SetParamObj(map, prefix + "TextTemplate.", this.TextTemplate);
            this.SetParamObj(map, prefix + "SvgTemplate.", this.SvgTemplate);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
        }
    }
}

