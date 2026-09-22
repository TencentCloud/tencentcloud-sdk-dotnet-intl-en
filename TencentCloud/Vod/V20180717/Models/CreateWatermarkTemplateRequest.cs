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

    public class CreateWatermarkTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Watermark type. Valid values:
        /// <li>image: image watermark;</li>
        /// <li>Text: text watermark.</li>
        /// <li>svg: SVG watermark.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Watermark template name. The length cannot exceed 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Origin position. Valid values:
        /// <li>TopLeft: indicates that the coordinate origin is at the top left corner of the video image and the watermark origin is at the top left corner of the image or text.</li>
        /// <li>TopRight: indicates that the coordinate origin is at the top right corner of the video image and the watermark origin is at the top right corner of the image or text.</li>
        /// <li>BottomLeft: indicates that the coordinate origin is at the bottom left corner of the video image and the watermark origin is at the bottom left corner of the image or text.</li>
        /// <li>BottomRight: indicates that the coordinate origin is at the bottom right corner of the video image and the watermark origin is at the bottom right corner of the image or text.</li>
        /// Default value: TopLeft.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// Horizontal position of the watermark origin relative to the origin of coordinates of the video image. Supports two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `XPos` of a watermark is a specified percentage of a video's width. For example, `10%` means that `XPos` is 10% of a video's width.</li>
        /// <li>If a string ends with px, it means the watermark XPos is specified in pixels. For example, 100px means XPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the watermark origin relative to the origin of coordinates of the video image. Supports two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `YPos` of a watermark is a specified percentage of a video's height. For example, `10%` means that `YPos` is 10% of a video's height.</li>
        /// <li>If a string ends with px, it means the watermark YPos is specified in pixels. For example, 100px means YPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Image watermark template. If `Type` is `image`, this field is required. If `Type` is `text`, this field is invalid.
        /// </summary>
        [JsonProperty("ImageTemplate")]
        public ImageWatermarkInput ImageTemplate{ get; set; }

        /// <summary>
        /// Text watermarking template. This field is required when Type is text and invalid when Type is image.
        /// </summary>
        [JsonProperty("TextTemplate")]
        public TextWatermarkTemplateInput TextTemplate{ get; set; }

        /// <summary>
        /// SVG watermark template. This field is required when Type is svg. This field is invalid when Type is image or text.
        /// </summary>
        [JsonProperty("SvgTemplate")]
        public SvgWatermarkInput SvgTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamObj(map, prefix + "ImageTemplate.", this.ImageTemplate);
            this.SetParamObj(map, prefix + "TextTemplate.", this.TextTemplate);
            this.SetParamObj(map, prefix + "SvgTemplate.", this.SvgTemplate);
        }
    }
}

