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

    public class SubtitleEmbedConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Font type, supports:</p><li>hei.ttf: Heiti</li><li>song.ttf: Song Typeface</li><li>kai.ttf (recommended) or simkai.ttf: KaiTi</li><li>msyh.ttf: Microsoft YaHei</li><li>msyhbd.ttf: Microsoft YaHei in bold</li><li>hkjgt.ttf: Hwakangangtai</li><li>dhttx.ttf: Dianheiti Ultra Light</li><li>xqgdzt.ttf: Xique Ancient Dictionary</li><li>qpcyt.ttf: Smart Splice Super Round Body</li><li>arial.ttf: only supports English</li><li>dinalternate.ttf: DIN Alternate Bold</li><li>helveticalt.ttf: Helvetica</li><li>helveticains.ttf: Helvetica Inserat</li><li>trajanpro.ttf: TrajanPro-Bold</li><li>korean.ttf: Korean</li><li>japanese.ttf: Japanese</li><li>thai.ttf: Thai</li><li>roboto.ttf: Roboto</li><li>notosans.ttf: NotoSans</li><li>notosansthai.ttf: Thai NotoSansThai</li><li>sarabun.ttf: Thai Sarabun</li><li>kanit.ttf: Thai Kanit</li><li>charmonman.ttf: Thai Charmonman</li><li>notonaskharabic.ttf: Arabic NotoNaskhArabic</li><li>notosansdevanagari.ttf: India NotoSansDevanagari</li><li>notosanstc.ttf: Cantonese NotoSansTC</li><li>notosanskr.ttf: Korean NotoSansKR</li><li>gothica1.ttf: Korean GothicA1</li><li>nanummyeongjo.ttf: Korean NanumMyeongjo</li><li>notosansjp.ttf: Japanese NotoSansJP</li><li>notoserifjp.ttf: Japanese NotoSerifJP</li><li>shipporimincho.ttf: Japanese ShipporiMincho</li>Default: hei.ttf Heiti.<br>Note:<li>KaiTi is recommended for use with kai.ttf</li><li>FontPath takes precedence when filled</li>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// <p>Custom font file url address, either this or CosInputInfo</p>
        /// </summary>
        [JsonProperty("FontPath")]
        public string FontPath{ get; set; }

        /// <summary>
        /// <p>Custom font file cos bucket address</p>
        /// </summary>
        [JsonProperty("CosInputInfo")]
        public CosInputInfo CosInputInfo{ get; set; }

        /// <summary>
        /// <p>Font size. If not specified, the font size of the subtitle file applies. Pixel and percentage formats are supported:</p><ul><li>Pixel: Npx, where N ranges from (0,4096].</li><li>Percentage: N%, where N ranges from (0,100]. For example, 10% means the subtitle font size equals 10% of the source video height.</li></ul><p>If left blank and the subtitle file has no settings, the default is 5% of the source video height.</p>
        /// </summary>
        [JsonProperty("FontSize")]
        public long? FontSize{ get; set; }

        /// <summary>
        /// <p>FontSize unit, 0 pixel, 1 percentage, defaults to 0, pixel</p>
        /// </summary>
        [JsonProperty("FontSizeUnit")]
        public long? FontSizeUnit{ get; set; }

        /// <summary>
        /// <p>Font color. Format: 0xRRGGBB. Default value: 0xFFFFFF (white).</p>
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// <p>Text opacity, value ranges from 0 to 1.</p><li>0: completely transparent</li><li>1: completely opaque</li>Default value: 1.
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// <p>The X-coordinate position of subtitles. Specifying this parameter will ignore the built-in coordinates in the subtitle file. Supports pixel and percentage formats:</p><ul><li>Pixel: Npx, where N ranges from [-4096, 4096].</li><li>Percentage: N%, where N ranges from [-100, 100]; for example, 10% means the X-coordinate of the subtitle equals 10% of the source video width.</li></ul><p>Default value: 0px.<br>Note: The origin of the coordinate axes is at the bottom of the central axis of the source video, and the subtitle reference position is at the bottom of the central axis of the subtitles, as shown in the figure below:<br><img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></p>
        /// </summary>
        [JsonProperty("PosX")]
        public long? PosX{ get; set; }

        /// <summary>
        /// <p>PosX unit, 0 pixel, 1 percentage, defaults to 0, pixel</p>
        /// </summary>
        [JsonProperty("PosXUnit")]
        public long? PosXUnit{ get; set; }

        /// <summary>
        /// <p>Subtitle Y-coordinate position. Specify this parameter to ignore the built-in coordinates in the subtitle file. Supports pixel and percentage formats:</p><ul><li>Pixel: Npx, where N ranges from [0,4096].</li><li>Percentage: N%, where N ranges from [0,100]. For example, 10% means the subtitle Y-coordinate = 10% * source video height.</li></ul><p>Default value: source video height * 4%.<br>Note: The coordinate axis origin is at the bottom of the central axis of the source video, and the subtitle reference point is at the bottom of the central axis of the subtitle. Refer to the figure below:<br><img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></p>
        /// </summary>
        [JsonProperty("PosY")]
        public long? PosY{ get; set; }

        /// <summary>
        /// <p>PosY measurement unit, 0 pixel, 1 percentage, defaults to 0, pixel</p>
        /// </summary>
        [JsonProperty("PosYUnit")]
        public long? PosYUnit{ get; set; }

        /// <summary>
        /// <p>Background configuration</p>
        /// </summary>
        [JsonProperty("SubtitleBoardConfig")]
        public SubtitleBoardConfig SubtitleBoardConfig{ get; set; }

        /// <summary>
        /// <p>Column configuration</p>
        /// </summary>
        [JsonProperty("SubtitleLayoutConfig")]
        public SubtitleLayoutConfig SubtitleLayoutConfig{ get; set; }

        /// <summary>
        /// <p>Text stroke configuration</p>
        /// </summary>
        [JsonProperty("SubtitleOutlineConfig")]
        public SubtitleOutlineConfig SubtitleOutlineConfig{ get; set; }

        /// <summary>
        /// <p>Text shadow configuration</p>
        /// </summary>
        [JsonProperty("SubtitleShadowConfig")]
        public SubtitleShadowConfig SubtitleShadowConfig{ get; set; }

        /// <summary>
        /// <p>Width of the source video dimensions, in pixels</p>
        /// </summary>
        [JsonProperty("SampleWidth")]
        public long? SampleWidth{ get; set; }

        /// <summary>
        /// <p>Height of the source video dimensions, in unit pixel</p>
        /// </summary>
        [JsonProperty("SampleHeight")]
        public long? SampleHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontPath", this.FontPath);
            this.SetParamObj(map, prefix + "CosInputInfo.", this.CosInputInfo);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontSizeUnit", this.FontSizeUnit);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "PosX", this.PosX);
            this.SetParamSimple(map, prefix + "PosXUnit", this.PosXUnit);
            this.SetParamSimple(map, prefix + "PosY", this.PosY);
            this.SetParamSimple(map, prefix + "PosYUnit", this.PosYUnit);
            this.SetParamObj(map, prefix + "SubtitleBoardConfig.", this.SubtitleBoardConfig);
            this.SetParamObj(map, prefix + "SubtitleLayoutConfig.", this.SubtitleLayoutConfig);
            this.SetParamObj(map, prefix + "SubtitleOutlineConfig.", this.SubtitleOutlineConfig);
            this.SetParamObj(map, prefix + "SubtitleShadowConfig.", this.SubtitleShadowConfig);
            this.SetParamSimple(map, prefix + "SampleWidth", this.SampleWidth);
            this.SetParamSimple(map, prefix + "SampleHeight", this.SampleHeight);
        }
    }
}

