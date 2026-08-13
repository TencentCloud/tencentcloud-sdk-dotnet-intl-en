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
        /// Subtitle file URL to be suppressed in the video.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Specifies the subtitle track for embedding subtitles into the video. The Streamindex value starts from 0, where 0 indicates usage of the first subtitle track in the source video. If Path is specified, use Path preferentially. Specify at least one of Path or Streamindex.
        /// 
        /// -Note: StreamIndex must be consistent with the subtitle track index in the source file. For example, if the subtitle track in the source file is stream#0:3, StreamIndex should be 3. Otherwise, task processing may fail.
        /// 
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// Input information on the subtitle file to be embedded in the video. Currently, only subtitle files stored in COS are supported.
        /// </summary>
        [JsonProperty("SubtitleFileInput")]
        public MediaInputInfo SubtitleFileInput{ get; set; }

        /// <summary>
        /// Input information of the font file of the burned-in subtitle. URL and COS are supported. If both are specified, the URL information is used. If FontFileInput is specified, FontFileInput takes precedence over FontType.
        /// </summary>
        [JsonProperty("FontFileInput")]
        public MediaInputInfo FontFileInput{ get; set; }

        /// <summary>
        /// Font type. Valid values:
        /// <li>hei.ttf: SimHei</li>
        /// <li>song.ttf: Song Typeface.</li>
        /// <li>kai.ttf (recommend) or simkai.ttf: KaiTi.</li>
        /// <li>msyh.ttf: Microsoft YaHei.</li>
        /// <li>msyhbd.ttf: Microsoft YaHei Bold.</li>
        /// <li>hkjgt.ttf: DynaFont King Gothic.</li>
        /// <li>dhttx.ttf: DianHei Extra Light.</li>
        /// <li>xqgdzt.ttf: XiQue GuZiDian.</li>
        /// <li>qpcyt.ttf: Smart Splice Super Round Body</li>
        /// <li>arial.ttf: English only.</li>
        /// <li>dinalternate.ttf:DIN Alternate Bold</li>
        /// <li>helveticalt.ttf:Helvetica</li>
        /// <li>helveticains.ttf:Helvetica Inserat</li>
        /// <li>trajanpro.ttf:TrajanPro-Bold</li>
        /// <li>korean.ttf: Korean.</li>
        /// <li>japanese.ttf: Japanese.</li>
        /// <li>thai.ttf: Thai.</li>
        /// <li>roboto.ttf:Roboto</li>
        /// <li>notosans.ttf:NotoSans</li>
        /// <li>notosansthai.ttf: Thai NotoSansThai</li>
        /// <li>sarabun.ttf: Thai Sarabun</li>
        /// <li>kanit.ttf: Thai Kanit</li>
        /// <li>charmonman.ttf: Thai Charmonman.</li>
        /// <li>notonaskharabic.ttf: Arabic NotoNaskhArabic.</li>
        /// <li>notosansdevanagari.ttf: NotoSansDevanagari for India.</li>
        /// <li>notosanstc.ttf: Cantonese Source Han Sans NotoSansTC</li>
        /// <li>notosanskr.ttf: Korean NotoSansKR.</li>
        /// <li>gothica1.ttf: Korean GothicA1.</li>
        /// <li>nanummyeongjo.ttf: Korean NanumMyeongjo.</li>
        /// <li>notosansjp.ttf: Japanese NotoSansJP.</li>
        /// <li>notoserifjp.ttf: Japanese NotoSerifJP.</li>
        /// <li>shipporimincho.ttf: Japanese ShipporiMincho.</li>
        /// Default value: hei.ttf.
        /// <br>Note:
        /// <li>kai.ttf is recommended for SimKai.</li>
        /// <li>FontFileInput takes precedence when specified.</li>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// Font size. If not specified, the font size of the subtitle file applies. Pixel and percentage formats are supported.
        /// 
        /// -.
        /// - Percentage: N%. Value range of N: (0,100]. For example, 10% means the subtitle font size is 10% of the source video height.
        /// 
        /// The default size is 5% of the source video height if this parameter is not specified or the font size is not configured in the subtitle file.
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// Font color. Format: 0xRRGGBB. Default value: 0xFFFFFF (white).
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// Text opacity, value ranges from 0 to 1.
        /// <li>0: completely transparent.</li>
        /// <li>1: completely opaque.</li>
        /// Default value: 1.
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// Subtitle y-axis coordinate position. Specify this parameter to ignore the built-in coordinates of the subtitle file. Support pixel and percentage format.
        /// 
        /// -.
        /// -Percentage: N%, N range: [0,100]; for example, 10% means subtitle y-coordinate = 10% * source video height.
        /// 
        /// By default, the position is 4% of the source video height.
        /// Note: The origin of the coordinate axes is at the bottom of the central axis of the source video, and the subtitle reference position is at the bottom of the central axis of the subtitles, see the following diagram.
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// y-axis coordinate position of the subtitle background base plate; Support pixel and percentage format:
        /// 
        /// -.
        /// -Percentage: N%, N range: [0,100]; for example, 10% means the y-coordinate of the subtitle background base plate = 10% * video height.
        /// 
        /// If this parameter is not specified, the subtitle background is disabled.
        /// Note: The origin of the coordinate axes is at the bottom of the central axis of the source video, and the reference point of the subtitle background base plate is at the bottom of its central axis. Refer to the figure below.
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// Background width. The value should be a positive integer.
        /// - Value range for pixels: [0,4096].
        /// - Value range for percentages: [0, 100].
        /// If background is enabled and this parameter is not specified, the default width is 90% of the source video width.
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// Background height. The value should be a positive integer.
        /// - Value range for pixels: [0,4096].
        /// - Value range for percentages: [0, 100].
        /// If background is enabled and this parameter is not specified, the default height is 15% of the source video height.
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// Board color. Format: 0xRRGGBB.
        /// Default value: 0x000000 (black).
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// Subtitle background transparency. Value range: [0, 1].
        /// <li>0: completely transparent.</li>
        /// <li>1: completely opaque.</li>
        /// Default value: 0.8.
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }

        /// <summary>
        /// Stroke width. The value should be a floating-point number.
        /// - Value range for pixels: [0, 1000].
        /// - Value range for percentages: [0, 100].
        /// If this is not specified, the default width is 0.3% of the source video height.
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public float? OutlineWidth{ get; set; }

        /// <summary>
        /// Stroke color. The value should be a 6-digit hexadecimal RGB value. If this is not specified, the default color is black.
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// Stroke transparency. The value should be a positive floating-point number in the range of (0, 1]. If this is not specified, the default value is 1, which means completely opaque.
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }

        /// <summary>
        /// Shadow width. The value should be a floating-point number.
        /// - Value range for pixels: [0, 1000].
        /// - Value range for percentages: [0, 100].
        /// If this is not specified, no shadow is applied by default.
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public float? ShadowWidth{ get; set; }

        /// <summary>
        /// Shadow color. The value should be a 6-digit hexadecimal RGB value. If this is not specified, the default color is black (with shadow configured).
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
        /// Default value is 0. If this is set to 1, the value of LineSpacing is a percentage based on the video height.
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

