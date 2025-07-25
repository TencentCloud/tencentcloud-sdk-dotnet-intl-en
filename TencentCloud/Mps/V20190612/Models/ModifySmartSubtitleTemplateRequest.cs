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

    public class ModifySmartSubtitleTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the smart subtitle template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Subtitle translation switch.
        /// ON: enable translation
        /// OFF: disable translation
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// Smart subtitle template name.
        /// Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Smart subtitle template description.
        /// Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Source language of the video with smart subtitles.
        /// Supported languages:
        /// zh: Simplified Chinese
        /// en: English
        /// ja: Japanese
        /// ko: Korean
        /// zh-PY: Chinese-English-Cantonese
        /// zh-medical: Medical Chinese
        /// yue: Cantonese
        /// vi: Vietnamese
        /// ms: Malay
        /// id: Indonesian
        /// fil: Filipino
        /// th: Thai
        /// pt: Portuguese
        /// tr: Turkish
        /// ar: Arabic
        /// es: Spanish
        /// hi: Hindi
        /// fr: French
        /// de: German
        /// zh-dialect: Chinese dialect
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// Smart subtitle file format.
        /// vtt: WebVTT format
        /// If this field is left blank, no subtitle file will be generated.
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// Smart subtitle language type.
        /// 0: source language1: target language
        /// 2: source language + target language
        /// The value can only be 0 when TranslateSwitch is set to OFF.The value can only be 1 or 2 when TranslateSwitch is set to ON.
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// ASR hotword lexicon parameter.
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// Target language for subtitle translation.
        /// This field takes effect when TranslateSwitch is set to ON.
        /// Supported languages:
        /// zh: Simplified Chinese
        /// en: English
        /// ja: Japanese
        /// ko: Korean
        /// fr: French
        /// es: Spanish
        /// it: Italian
        /// de: German
        /// tr: Turkish
        /// ru: Russian
        /// pt: Portuguese
        /// vi: Vietnamese
        /// id: Indonesian
        /// ms: Malay
        /// th: Thai
        /// ar: Arabic
        /// hi: Hindi
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "TranslateSwitch", this.TranslateSwitch);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "VideoSrcLanguage", this.VideoSrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SubtitleType", this.SubtitleType);
            this.SetParamObj(map, prefix + "AsrHotWordsConfigure.", this.AsrHotWordsConfigure);
            this.SetParamSimple(map, prefix + "TranslateDstLanguage", this.TranslateDstLanguage);
        }
    }
}

