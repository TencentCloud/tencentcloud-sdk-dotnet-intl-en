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

    public class SubtitleTemplate : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleFileInput")]
        public MediaInputInfo SubtitleFileInput{ get; set; }

        /// <summary>
        /// Input information for the subtitle font file to be suppressed. Currently only support url and cos. If both are filled, url takes precedence over cos. If FontFileInput is filled, FontFileInput takes precedence over FontType.
        /// </summary>
        [JsonProperty("FontFileInput")]
        public MediaInputInfo FontFileInput{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }

        /// <summary>
        /// Stroke width. The value should be a floating-point number.
        /// - Value range for pixels: [0, 1000].
        /// - Value range for percentages: [0, 100].
        /// 0.3% of the source video height by default if left blank.
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public float? OutlineWidth{ get; set; }

        /// <summary>
        /// Border color. 6-digit hexadecimal RGB. Black by default if left blank.
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// Stroke transparency. The value should be a positive floating-point number in the range of (0, 1]. If this is not specified, the default value is 1, which means completely opaque.
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }

        /// <summary>
        /// Shadow width. Floating-point number.
        /// - Value range for pixels: [0, 1000].
        /// - Value range for percentages: [0, 100].
        /// No shading by default if left blank.
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public float? ShadowWidth{ get; set; }

        /// <summary>
        /// Shadow color. 6-bit base RGB. Black by default if left blank (when shadow has set).
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// Shadow transparency. The value should be a positive floating-point number in the range of (0, 1]. If this is not specified, the default value is 1, which means completely opaque (with shadow configured).
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }

        /// <summary>
        /// Line spacing. The value should be a positive integer.
        /// - Value range for pixels: [0, 1000].
        /// - Value range for percentages: [0, 100]. If this is not specified, the default value is 0.
        /// </summary>
        [JsonProperty("LineSpacing")]
        public long? LineSpacing{ get; set; }

        /// <summary>
        /// Alignment mode. Valid values: top: The top position of the subtitle is fixed, while the bottom position changes according to the number of lines. bottom: The bottom position of the subtitle is fixed, while the top position changes according to the number of lines. If this is not specified, bottom alignment is used by default.
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }

        /// <summary>
        /// Default value is 0. If this is set to 1, the value of BoardWidth is a percentage based on the video width.
        /// </summary>
        [JsonProperty("BoardWidthUnit")]
        public long? BoardWidthUnit{ get; set; }

        /// <summary>
        /// Default value is 0. If this is set to 1, the value of BoardHeight is a percentage based on the video height.
        /// </summary>
        [JsonProperty("BoardHeightUnit")]
        public long? BoardHeightUnit{ get; set; }

        /// <summary>
        /// Default value is 0. If this is set to 1, the value of OutlineWidth is a percentage based on the video height.
        /// </summary>
        [JsonProperty("OutlineWidthUnit")]
        public long? OutlineWidthUnit{ get; set; }

        /// <summary>
        /// Default value is 0. If this is set to 1, the value of ShadowWidth is a percentage based on the video height.
        /// </summary>
        [JsonProperty("ShadowWidthUnit")]
        public long? ShadowWidthUnit{ get; set; }

        /// <summary>
        /// Default value: 0. If this is set to 1, the value of LineSpacing is a percentage based on the video height.
        /// </summary>
        [JsonProperty("LineSpacingUnit")]
        public long? LineSpacingUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "StreamIndex", this.StreamIndex);
            this.SetParamObj(map, prefix + "SubtitleFileInput.", this.SubtitleFileInput);
            this.SetParamObj(map, prefix + "FontFileInput.", this.FontFileInput);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "BoardWidth", this.BoardWidth);
            this.SetParamSimple(map, prefix + "BoardHeight", this.BoardHeight);
            this.SetParamSimple(map, prefix + "BoardColor", this.BoardColor);
            this.SetParamSimple(map, prefix + "BoardAlpha", this.BoardAlpha);
            this.SetParamSimple(map, prefix + "OutlineWidth", this.OutlineWidth);
            this.SetParamSimple(map, prefix + "OutlineColor", this.OutlineColor);
            this.SetParamSimple(map, prefix + "OutlineAlpha", this.OutlineAlpha);
            this.SetParamSimple(map, prefix + "ShadowWidth", this.ShadowWidth);
            this.SetParamSimple(map, prefix + "ShadowColor", this.ShadowColor);
            this.SetParamSimple(map, prefix + "ShadowAlpha", this.ShadowAlpha);
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
            this.SetParamSimple(map, prefix + "Alignment", this.Alignment);
            this.SetParamSimple(map, prefix + "BoardWidthUnit", this.BoardWidthUnit);
            this.SetParamSimple(map, prefix + "BoardHeightUnit", this.BoardHeightUnit);
            this.SetParamSimple(map, prefix + "OutlineWidthUnit", this.OutlineWidthUnit);
            this.SetParamSimple(map, prefix + "ShadowWidthUnit", this.ShadowWidthUnit);
            this.SetParamSimple(map, prefix + "LineSpacingUnit", this.LineSpacingUnit);
        }
    }
}

