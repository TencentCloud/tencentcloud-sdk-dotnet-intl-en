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

    public class ComposeSubtitleStyle : AbstractModel
    {
        
        /// <summary>
        /// The subtitle height. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the height as a percentage of the canvas height. For example, `10%` means that the height is 10% of the canvas height. </li>
        /// u200c<li>If the value ends with px, it specifies the height in pixels. For example, `100px` means that the height is 100 pixels. </li>
        /// The default value is the value of `FontSize`.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// The bottom margin. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the margin as a percentage of the canvas height. For example, `10%` means that the margin is 10% of the canvas height. </li>
        /// u200c<li>If the value ends with px, it specifies the margin in pixels. For example, `100px` means that the margin is 100 pixels. </li>
        /// Default value: `0px`.
        /// </summary>
        [JsonProperty("MarginBottom")]
        public string MarginBottom{ get; set; }

        /// <summary>
        /// The font type. Valid values:
        /// <li>`SimHei`(default): Chinese font Heiti. </li>
        /// <Li>`SimSun`: Chinese font Songti. </li>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// The font size. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the size as a percentage of the canvas height. For example, `10%` means that the size is 10% of the canvas height. </li>
        /// u200c<li>If the value ends with px, it specifies the size in pixels. For example, `100px` means that the size is 100 pixels. </li>
        /// Default value: `2%`.
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// Whether to bold the text (some fonts may not support bold). Valid values:
        /// <li>`0` (default): No. </li>
        /// <li>`1`: Yes. </li>
        /// </summary>
        [JsonProperty("FontBold")]
        public long? FontBold{ get; set; }

        /// <summary>
        /// Whether to italicize the text (some fonts may not support italics). Valid values:
        /// <li>`0` (default): No. </li>
        /// <li>`1`: Yes. </li>
        /// </summary>
        [JsonProperty("FontItalic")]
        public long? FontItalic{ get; set; }

        /// <summary>
        /// The font color (#RRGGBBAA).  
        /// Default value: `0x000000FF` (black).  
        /// Note: `AA` in the color notation defines the opacity of the color. It's optional.
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// The text alignment. Valid values:
        /// <li>`Center`(default) </li>
        /// <li>`Left` </li>
        /// <li>`Right` </li>
        /// </summary>
        [JsonProperty("FontAlign")]
        public string FontAlign{ get; set; }

        /// <summary>
        /// The margin for left/right align.
        /// <li>If `FontAlign` is `Left`, this parameter specifies the left margin of the subtitles. </li>
        /// <li>If `FontAlign` is `Right`, this parameter specifies the right margin of the subtitles. </li>
        /// Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the margin as a percentage of the canvas width. For example, `10%` means that the margin is 10% of the canvas width. </li>
        /// u200c<li>If the value ends with px, it specifies the margin in pixels. For example, `100px` means that the margin is 100 pixels. </li>
        /// </summary>
        [JsonProperty("FontAlignMargin")]
        public string FontAlignMargin{ get; set; }

        /// <summary>
        /// The subtitle border width. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the width as a percentage of the canvas height. For example, `10%` means that the width is 10% of the canvas height. </li>
        /// u200c<li>If the value ends with px, it specifies the width in pixels. For example, `100px` means that the width is 100 pixels. </li>
        /// The default value is `0`, which means the subtitles will have no borders.
        /// </summary>
        [JsonProperty("BorderWidth")]
        public string BorderWidth{ get; set; }

        /// <summary>
        /// The border color, whose format is the same as that for `FontColor`. This parameter is valid if `BorderWidth` is not `0`.
        /// </summary>
        [JsonProperty("BorderColor")]
        public string BorderColor{ get; set; }

        /// <summary>
        /// The text background color, whose format is the same as that for `FontColor`.  
        /// The default value is an empty string, which means the subtitles will not have a background color.
        /// </summary>
        [JsonProperty("BottomColor")]
        public string BottomColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "MarginBottom", this.MarginBottom);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontBold", this.FontBold);
            this.SetParamSimple(map, prefix + "FontItalic", this.FontItalic);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlign", this.FontAlign);
            this.SetParamSimple(map, prefix + "FontAlignMargin", this.FontAlignMargin);
            this.SetParamSimple(map, prefix + "BorderWidth", this.BorderWidth);
            this.SetParamSimple(map, prefix + "BorderColor", this.BorderColor);
            this.SetParamSimple(map, prefix + "BottomColor", this.BottomColor);
        }
    }
}

