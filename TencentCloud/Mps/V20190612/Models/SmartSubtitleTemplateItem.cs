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

    public class SmartSubtitleTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the smart subtitle template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Smart subtitle template name.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Smart subtitle template description.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Template type. Valid values:
        /// * Preset: system preset template
        /// * Custom: user-defined template
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ASR hotword lexicon parameter.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// Name of the hotword lexicon associated with the template.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AsrHotWordsLibraryName")]
        public string AsrHotWordsLibraryName{ get; set; }

        /// <summary>
        /// List of source languages of the video with smart subtitles.
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
        /// Smart subtitle file format:
        /// - vtt: WebVTT format.
        /// - srt: SRT format.
        /// - original: consistent with the source subtitle file (it is used for the pure subtitle translation template).
        /// - If this field is unspecified or left blank, no subtitle file will be generated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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
        /// Subtitle translation switch.
        /// ON: enable translation
        /// OFF: disable translation
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// Target language for subtitle translation.
        /// This field is valid when the value of TranslateSwitch is ON.
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
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// Template creation time in [ISO datetime format](https://intl.cloud.tencent.com/document/product/862/37710?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modification time of the template in [ISO datetime format](https://intl.cloud.tencent.com/document/product/862/37710?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Alias of the preset smart subtitle template.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Subtitle processing type.
        /// - 0: ASR recognition subtitle.
        /// - 1: pure subtitle translation.
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "AsrHotWordsConfigure.", this.AsrHotWordsConfigure);
            this.SetParamSimple(map, prefix + "AsrHotWordsLibraryName", this.AsrHotWordsLibraryName);
            this.SetParamSimple(map, prefix + "VideoSrcLanguage", this.VideoSrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SubtitleType", this.SubtitleType);
            this.SetParamSimple(map, prefix + "TranslateSwitch", this.TranslateSwitch);
            this.SetParamSimple(map, prefix + "TranslateDstLanguage", this.TranslateDstLanguage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
        }
    }
}

