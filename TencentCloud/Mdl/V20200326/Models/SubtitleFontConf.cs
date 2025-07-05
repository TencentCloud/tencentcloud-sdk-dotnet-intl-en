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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleFontConf : AbstractModel
    {
        
        /// <summary>
        /// Line spacing.
        /// </summary>
        [JsonProperty("LineSpacing")]
        public ulong? LineSpacing{ get; set; }

        /// <summary>
        /// Margins.
        /// </summary>
        [JsonProperty("Margins")]
        public ulong? Margins{ get; set; }

        /// <summary>
        /// Rows.
        /// </summary>
        [JsonProperty("Lines")]
        public ulong? Lines{ get; set; }

        /// <summary>
        /// Number of characters per line.
        /// </summary>
        [JsonProperty("CharactersPerLine")]
        public ulong? CharactersPerLine{ get; set; }

        /// <summary>
        /// Original font Helvetica: simhei.ttf Song Dynasty: simsun.ttc Dynacw Diamond Black: hkjgh.ttf Helvetica font: helvetica.ttf; Need to be set in Source or Source+Target mode
        /// </summary>
        [JsonProperty("SourceTextFont")]
        public string SourceTextFont{ get; set; }

        /// <summary>
        /// Font color is represented by 6 RGB hexadecimal characters.
        /// </summary>
        [JsonProperty("TextColor")]
        public string TextColor{ get; set; }

        /// <summary>
        /// The background color is represented by 6 RGB hexadecimal characters.
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public string BackgroundColor{ get; set; }

        /// <summary>
        /// Background transparency, a number from 0-100.
        /// </summary>
        [JsonProperty("BackgroundAlpha")]
        public ulong? BackgroundAlpha{ get; set; }

        /// <summary>
        /// Preview copy.
        /// </summary>
        [JsonProperty("PreviewContent")]
        public string PreviewContent{ get; set; }

        /// <summary>
        /// Preview window height.
        /// </summary>
        [JsonProperty("PreviewWindowHeight")]
        public ulong? PreviewWindowHeight{ get; set; }

        /// <summary>
        /// Preview window width.
        /// </summary>
        [JsonProperty("PreviewWindowWidth")]
        public ulong? PreviewWindowWidth{ get; set; }

        /// <summary>
        /// Translation language font, the enumeration value is the same as Font, the fonts supported by the language need to be distinguished; TextColor needs to be set in Target or Source+Target mode
        /// </summary>
        [JsonProperty("TranslatedTextFont")]
        public string TranslatedTextFont{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
            this.SetParamSimple(map, prefix + "Margins", this.Margins);
            this.SetParamSimple(map, prefix + "Lines", this.Lines);
            this.SetParamSimple(map, prefix + "CharactersPerLine", this.CharactersPerLine);
            this.SetParamSimple(map, prefix + "SourceTextFont", this.SourceTextFont);
            this.SetParamSimple(map, prefix + "TextColor", this.TextColor);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
            this.SetParamSimple(map, prefix + "BackgroundAlpha", this.BackgroundAlpha);
            this.SetParamSimple(map, prefix + "PreviewContent", this.PreviewContent);
            this.SetParamSimple(map, prefix + "PreviewWindowHeight", this.PreviewWindowHeight);
            this.SetParamSimple(map, prefix + "PreviewWindowWidth", this.PreviewWindowWidth);
            this.SetParamSimple(map, prefix + "TranslatedTextFont", this.TranslatedTextFont);
        }
    }
}

