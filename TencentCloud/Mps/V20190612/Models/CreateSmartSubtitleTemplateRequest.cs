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

    public class CreateSmartSubtitleTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Smart subtitle template name.
        /// Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Source language of the video with smart subtitles.
        /// Currently, the following languages are supported:
        /// `zh`: Simplified Chinese.
        /// `yue`: Cantonese.
        /// `zh-PY`: Chinese, English, and Cantonese.
        /// `zh_medical`: Chinese (medical scenario).
        /// `zh_dialect`: Chinese dialect.
        /// `prime_zh`: Chinese, English, and Chinese dialects.
        /// `zh_en`: Chinese and English.
        /// `en`: English.
        /// `ja`: Japanese.
        /// `ko`: Korean.
        /// `fr`: French.
        /// `es`: Spanish.
        /// `it`: Italian.
        /// `de`: German.
        /// `tr`: Turkish.
        /// `ru`: Russian.
        /// `pt`: Portuguese (Brazil).
        /// `pt-PT`: Portuguese (Portugal).
        /// `vi`: Vietnamese.
        /// `id`: Indonesian.
        /// `ms`: Malay.
        /// `th`: Thai.
        /// `ar`: Arabic.
        /// `hi`: Hindi.
        /// `fil`: Filipino.
        /// `auto`: automatic recognition (it is only supported in pure subtitle translation).
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// Smart subtitle language type.
        /// 0: source language
        /// 1: target language
        /// 2: source language + target language
        /// The value can only be 0 when TranslateSwitch is set to OFF. The value can only be 1 or 2 when TranslateSwitch is set to ON.
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// Smart subtitle template description.
        /// Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Smart subtitle file format:
        /// - Under the ASR recognition and translation processing type:
        ///      - vtt: WebVTT format subtitle.
        ///      - srt: SRT format subtitle.
        ///      - If this field is unspecified or left blank, no subtitle file will be generated.
        /// - Under the pure subtitle translation processing type:
        ///     - original: consistent with the source file.
        ///     - vtt: WebVTT format subtitle.
        ///     - srt: SRT format subtitle.
        /// **Note**:
        /// - For ASR recognition mode, when 2 or more languages are involved in translation, this field cannot be unspecified or left blank.
        /// - For pure subtitle translation mode, this field cannot be unspecified or left blank.
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// ASR hotword lexicon parameter.
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// Subtitle translation switch.
        /// `ON`: translation enabled.
        /// `OFF`: translation disabled.
        /// **Note**: For pure subtitle translation mode, the default value is enabled if the field is unspecified. The field cannot be left blank or set to `OFF`.
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// Subtitle translation target language. This field is valid when the value of TranslateSwitch is `ON`.
        /// Currently, the following languages are supported:
        /// `zh`: Simplified Chinese.
        /// `zh-TW`: Traditional Chinese.
        /// `en`: English.
        /// `ja`: Japanese.
        /// `ko`: Korean.
        /// `fr`: French.
        /// `es`: Spanish.
        /// `it`: Italian.
        /// `de`: German.
        /// `tr`: Turkish.
        /// `ru`: Russian.
        /// `pt`: Portuguese (Brazil).
        /// `pt-PT`: Portuguese (Portugal).
        /// `vi`: Vietnamese.
        /// `id`: Indonesian.
        /// `ms`: Malay.
        /// `th`: Thai.
        /// `ar`: Arabic.
        /// `hi`: Hindi.
        /// `fil`: Filipino.
        /// **Note**: Use `/` to separate multiple languages, such as `en/ja`, which indicates English and Japanese.
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// Subtitle processing type:
        /// - 0: ASR recognition subtitle.
        /// - 1: pure subtitle translation.
        /// **Note**: The default processing type is ASR recognition subtitle if the field is unspecified.
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VideoSrcLanguage", this.VideoSrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleType", this.SubtitleType);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamObj(map, prefix + "AsrHotWordsConfigure.", this.AsrHotWordsConfigure);
            this.SetParamSimple(map, prefix + "TranslateSwitch", this.TranslateSwitch);
            this.SetParamSimple(map, prefix + "TranslateDstLanguage", this.TranslateDstLanguage);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
        }
    }
}

