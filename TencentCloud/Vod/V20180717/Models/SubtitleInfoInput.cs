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

    public class SubtitleInfoInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Subtitle ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Font type.</p><p>Enumeration value:</p><ul><li>hei.ttf: Heiti</li><li>song.ttf: Song Typeface</li><li>kai.ttf (recommended) or simkai.ttf: KaiTi</li><li>msyh.ttf: Microsoft YaHei</li><li>msyhbd.ttf: Microsoft YaHei in bold</li><li>hkjgt.ttf: Hwakangangtai</li><li>dhttx.ttf: Dianheiti Ultra Light</li><li>xqgdzt.ttf: Xique Ancient Dictionary</li><li>qpcyt.ttf: Smart Splice Super Round Body</li><li>arial.ttf: only supports English</li><li>dinalternate.ttf: DIN Alternate Bold</li><li>helveticalt.ttf: Helvetica</li><li>helveticains.ttf: Helvetica Inserat</li><li>trajanpro.ttf: TrajanPro-Bold</li><li>korean.ttf: Korean</li><li>japanese.ttf: Japanese</li><li>thai.ttf: Thai</li><li>roboto.ttf: Roboto</li><li>notosans.ttf: NotoSans</li><li>notosansthai.ttf: Thai NotoSansThai</li><li>sarabun.ttf: Thai Sarabun</li><li>kanit.ttf: Thai Kanit</li><li>charmonman.ttf: Thai Charmonman</li><li>notonaskharabic.ttf: Arabic NotoNaskhArabic</li><li>notosansdevanagari.ttf: India NotoSansDevanagari</li><li>notosanstc.ttf: Cantonese NotoSansTC</li><li>notosanskr.ttf: Korean NotoSansKR</li><li>gothica1.ttf: Korean GothicA1</li><li>nanummyeongjo.ttf: Korean NanumMyeongjo</li><li>notosansjp.ttf: Japanese NotoSansJP</li><li>notoserifjp.ttf: Japanese NotoSerifJP</li><li>shipporimincho.ttf: Japanese ShipporiMincho</li></ul><p>Default value: hei.ttf Heiti</p>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// <p>Font size. If not specified, the font size in the subtitle file applies. Pixel and percentage formats are supported:</p><ul><li>Pixel: Npx, where N ranges from (0,4096].</li><li>Percentage: N%, where N ranges from (0,100]. For example, 10% means the subtitle font size equals 10% of the source video height. If left blank and the subtitle file has no settings, the default is 5% of the source video height.</li></ul>
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// <p>Font color, format: 0xRRGGBB.</p><p>Default value: 0xFFFFFF (white).</p>
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// <p>Text opacity. Value ranges from 0 to 1.</p><ul><li>0: completely transparent;</li><li>1: completely opaque</li></ul><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// <p>Subtitle Y-coordinate position. Specify this parameter to ignore the built-in coordinates in the subtitle file. Supports pixel and percentage formats:</p><ul><li>Pixel: Npx, where N ranges from [0,4096].</li><li>Percentage: N%, where N ranges from [0,100]. For example, 10% means the subtitle Y-coordinate = 10% * source video height. Default value: source video height * 4%.<br>Note: The coordinate axis origin is at the bottom of the central axis of the source video, and the subtitle reference point is at the bottom of the central axis of the subtitle. Refer to the figure below:<img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></li></ul>
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// <p>Subtitle background base plate Y-coordinate position. Supports pixel and percentage formats:</p><ul><li>Pixel: Npx, where N ranges from [0,4096].</li><li>Percentage: N%, where N ranges from [0,100]. For example, 10% means the subtitle background base plate Y-coordinate = 10% * source video height. If not specified, the subtitle background base plate is disabled.<br>Note: The coordinate axis origin is located at the bottom of the central axis of the source video, and the reference point of the subtitle background base plate is at the bottom of its central axis. Refer to the figure below:<img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></li></ul>
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// <p>Width of the base plate, a positive integer.</p><ul><li>Pixel: Npx, where N is in the range of [0,4096].</li><li>Percentage: N%, where N ranges from 0 to 100. If background is enabled and this parameter is not specified, the default width is 90% of the source video width.</li></ul>
        /// </summary>
        [JsonProperty("BoardWidth")]
        public string BoardWidth{ get; set; }

        /// <summary>
        /// <p>Height of the base plate, a positive integer.</p><ul><li>Pixel: Npx, where N ranges from 0 to 4096.</li><li>Percentage: N%, where N ranges from 0 to 100. If background is enabled and this parameter is not specified, the default height is 15% of the source video height.</li></ul>
        /// </summary>
        [JsonProperty("BoardHeight")]
        public string BoardHeight{ get; set; }

        /// <summary>
        /// <p>Base plate color. Format: 0xRRGGBB.</p><p>Default value: 0x000000 (black).</p>
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// <p>Subtitle background transparency. Value range: [0, 1].</p><ul><li>0: completely transparent;</li><li>1: completely opaque.</li></ul><p>Default value: 0.8.</p>
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }

        /// <summary>
        /// <p>Alignment mode.</p><p>Enumeration values:</p><ul><li>top: top alignment. The top position of subtitles is fixed, while the bottom position changes according to the line count.</li><li>bottom: bottom alignment. The bottom position of subtitles is fixed, while the top position changes according to the line count.</li></ul><p>Default value: bottom</p>
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }

        /// <summary>
        /// <p>Stroke width. Floating-point number.</p><ul><li>Pixel: Npx, where N is in the range of [0,1000].</li><li>Percentage: N%, where N ranges from 0 to 100.</li></ul><p>By default if left blank, it is 0.3% of the source video height.</p>
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public string OutlineWidth{ get; set; }

        /// <summary>
        /// <p>Border color. Format: 0xRRGGBB.</p><p>Default value: 0x000000 (black).</p>
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// <p>Stroke transparency. The value should be a positive floating-point number in the range of (0, 1].</p><ul><li>0: completely transparent;</li><li>1: completely opaque.</li></ul><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }

        /// <summary>
        /// <p>Shadow width. Floating-point number.</p><ul><li>Pixel: Npx, N value ranges from 0 to 1000.</li><li>Percentage: N%, N value ranges from 0 to 100. No shading by default if left blank.</li></ul>
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public string ShadowWidth{ get; set; }

        /// <summary>
        /// <p>Shadow color. Format: 0xRRGGBB.</p><p>Default value: 0x000000 (black) when shadow has set.</p>
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// <p>Shadow transparency. The value should be a positive floating-point number in the range of (0, 1].</p><ul><li>0: completely transparent;</li><li>1: completely opaque.</li></ul><p>Default value: 1, completely opaque, with shadow configured.</p>
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }

        /// <summary>
        /// <p>Line spacing. Positive integer.</p><ul><li>Pixel: Npx, N value ranges from 0 to 1000.</li><li>Percentage: N%, N value ranges from 0 to 100.</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("LineSpacing")]
        public string LineSpacing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
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
            this.SetParamSimple(map, prefix + "Alignment", this.Alignment);
            this.SetParamSimple(map, prefix + "OutlineWidth", this.OutlineWidth);
            this.SetParamSimple(map, prefix + "OutlineColor", this.OutlineColor);
            this.SetParamSimple(map, prefix + "OutlineAlpha", this.OutlineAlpha);
            this.SetParamSimple(map, prefix + "ShadowWidth", this.ShadowWidth);
            this.SetParamSimple(map, prefix + "ShadowColor", this.ShadowColor);
            this.SetParamSimple(map, prefix + "ShadowAlpha", this.ShadowAlpha);
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
        }
    }
}

