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
        /// The URL of the subtitles to add to the video.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Specifies the subtitle track for embedding subtitles into the video. the Streamindex parameter takes value starting from 0, where 0 indicates usage of the first subtitle track in the source video. if Path is specified, use Path preferentially. either Path or Streamindex should be specified.
        /// 
        /// -Note: StreamIndex must match the subtitle track index in the source file. for example, if the subtitle track in the source file is stream#0:3, StreamIndex should be 3. otherwise, task processing failed.
        /// 
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// Input information on the subtitle file to be embedded into the video. Currently, only subtitle files stored in COS are supported.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubtitleFileInput")]
        public MediaInputInfo SubtitleFileInput{ get; set; }

        /// <summary>
        /// Font type. valid values:.
        /// <li>hei.ttf: simhei.</li>.
        /// <li>song.ttf: simsun.</li>.
        /// <Li>Kai.Ttf (recommend) or simkai.ttf: kaiti.</li>.
        /// <li>msyh.ttf: microsoft yahei</li>.
        /// <li>msyhbd.ttf: microsoft yahei in bold.</li>.
        /// <li>hkjgt.ttf: dynafont king gothic</li>.
        /// <li>dhttx.ttf: dianheitexiti.</li>.
        /// <li>xqgdzt.ttf: xiqueguzidianti</li>.
        /// <li>qpcyt.ttf: smart splice super round body.</li>.
        /// <li>arial.ttf: english only.</li>.
        /// <li>dinalternate.ttf:DIN Alternate Bold</li>
        /// <li>helveticalt.ttf:Helvetica</li>
        /// <li>helveticains.ttf:Helvetica Inserat</li>
        /// <li>trajanpro.ttf:TrajanPro-Bold</li>
        /// <li>korean.ttf: specifies the korean language.</li>.
        /// <li>japanese.ttf: specifies the japanese language.</li>.
        /// <li>thai.ttf: specifies the thai language.</li>.
        /// Default: hei.ttf (heiti). note: kaiti is recommended for use with kai.ttf.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// Font size. Format: Npx, where N is a numerical value. If it is not specified, the font size of the subtitle file applies.
        /// It is 5% of the source video height by default.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// Font color. Format: 0xRRGGBB. Default value: 0xFFFFFF (white).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// The text transparency. Value range: 0-1.
        /// <li>`0`: Fully transparent.</li>
        /// <li>`1`: Fully opaque.</li>
        /// Default value: 1.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// Subtitle position on the Y-axis. If this parameter is specified, the built-in coordinates in the subtitle file will be ignored. The pixel and percentage formats are supported.
        /// 
        ///  - Pixel: Npx. Value range of N: [0,4096].
        ///  - Percentage: N%. Value range of N: [0,100]. For example, 10% indicates that the subtitle position on the Y-axis is 10% of the video height.
        /// 
        /// By default, the position is 4% of the source video height.
        /// Note: The origin of the coordinate axes is at the bottom of the central axis of the source video, and the subtitle reference position is at the bottom of the central axis of the subtitles, as shown in the figure below.
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Subtitle background position on the Y-axis. Pixel and percentage formats are supported.
        /// 
        ///  - Pixel: Npx. Value range of N: [0,4096].
        ///  - Percentage: N%. Value range of N: [0,100]. For example, 10% indicates that the subtitle background position on the Y-axis is 10% of the video height.
        /// 
        /// If this parameter is not specified, the subtitle background is disabled.
        /// Note: The origin of the coordinate axes is at the bottom of the central axis of the source video, and the reference position of the subtitle background is at the bottom of the central axis of the source video, as shown in the figure below.
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// Board width. Unit: pixels. Value range: [0,4096].
        /// It is 90% of the source video width by default.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// Board height. Unit: pixels. Value range: [0,4096].
        /// It is 15% of the source video height by default.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// Board color. Format: 0xRRGGBB.
        /// Default value: 0x000000 (black).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// Subtitle background transparency. Value range: [0, 1].
        /// <li>0: completely transparent.</li>
        /// <li>1: completely opaque.</li>
        /// Default value: 0.8.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }

        /// <summary>
        /// Stroke width.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public float? OutlineWidth{ get; set; }

        /// <summary>
        /// Stroke color. The value should be a 6-digit hexadecimal RGB value.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// Stroke transparency. The value should be a positive floating-point number in the range of (0, 1].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }

        /// <summary>
        /// Shadow width. The value should be a floating-point number in the range of [0, 1000].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public float? ShadowWidth{ get; set; }

        /// <summary>
        /// Shadow color. The value should be a 6-digit hexadecimal RGB value.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// Shadow transparency. The value should be a positive floating-point number in the range of (0, 1].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }

        /// <summary>
        /// Line spacing. The value should be a positive integer in the range of [0, 1000].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LineSpacing")]
        public long? LineSpacing{ get; set; }

        /// <summary>
        /// Alignment mode. Valid values: top alignment. The top position of subtitles is fixed, while the bottom position changes according to the number of lines. bottom: bottom alignment. The bottom position of subtitles is fixed, while the top position changes according to the number of lines.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "StreamIndex", this.StreamIndex);
            this.SetParamObj(map, prefix + "SubtitleFileInput.", this.SubtitleFileInput);
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
        }
    }
}

