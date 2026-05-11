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
        /// <p>Unique identifier of the smart subtitle template.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Smart subtitle template name.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Smart subtitle template description.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Template type. Valid values:</p><ul><li>Preset: preset template.</li><li>Custom: custom template.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>ASR hotword lexicon parameters.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// <p>Name of the hotword lexicon associated with the template.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrHotWordsLibraryName")]
        public string AsrHotWordsLibraryName{ get; set; }

        /// <summary>
        /// <p>Video source language list for smart subtitle:</p><p><code>zh</code>: Simplified Chinese<br><code>yue</code>: Cantonese<br><code>zh-PY</code>: Chinese, English, and Cantonese<br><code>zh_medical</code>: Chinese healthcare<br><code>zh_dialect</code>: Chinese dialect<br><code>prime_zh</code>: Chinese and English dialects<br><code>zh_en</code>: Chinese and English<br><code>en</code>: English<br><code>ja</code>: Japanese<br><code>ko</code>: Korean<br><code>fr</code>: French<br><code>es</code>: Spanish<br><code>it</code>: Italian<br><code>de</code>: German<br><code>tr</code>: Turkish<br><code>ru</code>: Russian<br><code>pt</code>: Portuguese (Brazil)<br><code>pt-PT</code>: Portuguese (Portugal)<br><code>vi</code>: Vietnamese<br><code>id</code>: Indonesian<br><code>ms</code>: Malay<br><code>th</code>: Thai<br><code>ar</code>: Arabic<br><code>hi</code>: Hindi<br><code>fil</code>: Filipino<br><code>auto</code>: Automatic identification (only supported for subtitle translation)</p>
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// <p>Smart subtitle file format.</p><ul><li>vtt: WebVTT.</li><li>srt: SRT.</li><li>original: same as the source subtitle file (for subtitle translation templates).</li><li>Not specified or empty: no subtitle file generated.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// <p>Smart subtitle language type.<br>0: source language.<br>1: target language.<br>2: source language and target language.<br>Only 0 is supported when TranslateSwitch is OFF.<br>Only 1 or 2 is supported when TranslateSwitch is ON.</p>
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// <p>Subtitle translation switch.<br>ON: enables translation.<br>OFF: disables translation.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// <p>Target language for subtitle translation.<br>This parameter takes effect when TranslateSwitch is ON.<br><code>zh</code>: Simplified Chinese<br><code>zh-TW</code>: Traditional Chinese<br><code>en</code>: English<br><code>ja</code>: Japanese<br><code>ko</code>: Korean<br><code>fr</code>: French<br><code>es</code>: Spanish<br><code>it</code>: Italian<br><code>de</code>: German<br><code>tr</code>: Turkish<br><code>ru</code>: Russian<br><code>pt</code>: Portuguese (Brazil)<br><code>pt-PT</code>: Portuguese (Portugal)<br><code>vi</code>: Vietnamese<br><code>id</code>: Indonesian<br><code>ms</code>: Malay<br><code>th</code>: Thai<br><code>ar</code>: Arabic<br><code>hi</code>: Hindi<br><code>fil</code>: Filipino</p><p><strong>Note</strong>: Use <code>/</code> to separate multiple languages, such as <code>en/ja</code>, which indicates English and Japanese.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// <p>Template creation time, in <a href="https://www.tencentcloud.com/document/product/862/37710?from_cn_redirect=1#52">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last template modification time, in <a href="https://www.tencentcloud.com/document/product/862/37710?from_cn_redirect=1#52">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Preset template alias for smart subtitle.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// <p>Subtitle processing type:</p><ul><li>0: ASR.</li><li>1: subtitle translation.</li><li>2: OCR.</li></ul>
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }

        /// <summary>
        /// <p>Area configurations for the subtitle OCR extraction box.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SelectingSubtitleAreasConfig")]
        public SelectingSubtitleAreasConfig SelectingSubtitleAreasConfig{ get; set; }

        /// <summary>
        /// <p>Subtitle burn-in template ID.</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public long? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// <p>Speaker identification mode. Valid values:<br>0: Speaker identification is disabled.<br>1: Speaker identification is enabled.<br>Default value: 0.</p>
        /// </summary>
        [JsonProperty("SpeakerMode")]
        public long? SpeakerMode{ get; set; }

        /// <summary>
        /// <p>Indicates whether to output the identified speaker to the subtitle file. Valid values:<br>0: The speaker is not output to the subtitle file.<br>1: The speaker is output to the VTT subtitle file.<br>Note: To use this parameter, the value of SpeakerMode cannot be 0.<br>Default value: 0.</p>
        /// </summary>
        [JsonProperty("SpeakerLabel")]
        public long? SpeakerLabel{ get; set; }


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
            this.SetParamObj(map, prefix + "SelectingSubtitleAreasConfig.", this.SelectingSubtitleAreasConfig);
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "SpeakerMode", this.SpeakerMode);
            this.SetParamSimple(map, prefix + "SpeakerLabel", this.SpeakerLabel);
        }
    }
}

