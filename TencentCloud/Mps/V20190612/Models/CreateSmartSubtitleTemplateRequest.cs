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
        /// <p>Intelligent subtitle template name<br>Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Smart subtitling video source language.</p><p>For ASR and subtitle translation parameter values, see <a href="https://www.tencentcloud.com/document/product/862/116243?from_cn_redirect=1#ASRlanguages">ASR Languages</a>.</p><p>The following lists some commonly used values:</p><p><code>auto</code>: automatic identification. <code>zh</code>: Simplified Chinese. <code>en</code>: English. <code>ja</code>: Japanese. <code>ko</code>: Korean. <code>zh-PY</code>: Chinese, English, and Cantonese. <code>zh_medical</code>: Chinese health care. <code>vi</code>: Vietnamese. <code>ms</code>: Malay. <code>id</code>: Indonesian. <code>fil</code>: Filipino. <code>th</code>: Thai. <code>pt</code>: Portuguese. <code>tr</code>: Turkish. <code>ar</code>: Arabic. <code>es</code>: Spanish. <code>hi</code>: Hindi. <code>fr</code>: French. <code>de</code>: German. <code>it</code>: Italian. <code>zh_dialect</code>: Chinese dialect. <code>zh_en</code>: Chinese and English. <code>yue</code>: Cantonese. <code>ru</code>: Russian. <code>prime_zh</code>: Chinese and English dialects.</p><p>OCR only supports the following values:</p><p><code>zh_en</code>: Chinese and English<br><code>multi</code>: others</p><p>For languages supported by different values, see <a href="https://www.tencentcloud.com/document/product/862/116243?from_cn_redirect=1#OCRlanguages">OCR Languages</a></p>
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// <p>Intelligent caption subtitle language type<br>0: Source language<br>1: Target language<br>2: Source language + target language<br>Only 0 is supported when TranslateSwitch is OFF<br>Only 1 or 2 is supported when TranslateSwitch is ON</p>
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// <p>Intelligent caption template description information<br>Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Intelligent subtitle file format:</p><ul><li>For ASR recognition translation processing type:<ul><li>vtt: WebVTT format subtitle</li><li>srt: SRT format subtitle</li><li>Leave blank or fill in the blank: no subtitle file generated</li></ul></li><li>For pure subtitle translation processing type:<ul><li>original: consistent with the source file</li><li>vtt: WebVTT format subtitle</li><li>srt: SRT format subtitle</li></ul></li><li>For OCR recognition translation processing type:<ul><li>vtt: WebVTT format subtitle</li><li>srt: SRT format subtitle</li></ul></li></ul><p><strong>Note</strong>:</p><ul><li>For ASR recognition method, do not leave blank or not pass when translating 2 or more languages.</li><li>For pure subtitle translation method, do not leave blank or not pass.</li><li>For OCR tasks, it is allowed to leave blank or not pass when suppression is enabled.</li></ul>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// <p>ASR hot word lexicon parameter</p>
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// <p>Subtitle translation switch<br><code>ON</code>: Enable translation<br><code>OFF</code>: Disable translation</p><p><strong>Note</strong>: For pure subtitle translation mode, the default value is enabled if the field is unspecified. The field cannot be left blank or set to <code>OFF</code>.</p>
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// <p>This parameter takes effect when the value of TranslateSwitch is ON. Valid translation languages:</p><p>For ASR extraction and translation, see <a href="https://www.tencentcloud.com/document/product/862/116243?from_cn_redirect=1#ASRlanguages">ASR Translation Languages</a>.<br>For OCR extraction and translation, see <a href="https://www.tencentcloud.com/document/product/862/116243?from_cn_redirect=1#OCRlanguages">OCR Translation Languages</a>.</p><p><strong>Note</strong>: Use <code>/</code> to separate multiple languages, such as <code>en/ja</code>, which indicates English and Japanese.</p><p>Examples of some commonly used languages:</p><p><code>ar</code>: Arabic<br><code>en</code>: English<br><code>fr</code>: French<br><code>it</code>: Italian<br><code>ja</code>: Japanese<br><code>ko</code>: Korean<br><code>ru</code>: Russian<br><code>th</code>: Thai<br><code>tr</code>: Turkish<br><code>vi</code>: Vietnamese<br><code>yue</code>: Cantonese<br><code>zh</code>: Simplified Chinese<br><code>zh-TW</code>: Traditional Chinese</p>
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// <p>Subtitle processing type:</p><ul><li>0: ASR recognition subtitle</li><li>1: Pure caption translation</li><li>2: OCR recognition subtitle</li></ul><p><strong>Note</strong>: The default type is ASR recognition subtitle if the field is unspecified.</p>
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }

        /// <summary>
        /// <p>Area configurations for the subtitle OCR extraction box</p>
        /// </summary>
        [JsonProperty("SelectingSubtitleAreasConfig")]
        public SelectingSubtitleAreasConfig SelectingSubtitleAreasConfig{ get; set; }

        /// <summary>
        /// <p>Suppression Template id. Only allowed to fill in when ProcessType is 0 or 2 (task type is ASR or OCR). Cannot fill in when multiple target languages are enabled.</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public long? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// <p>Speaker identification switch. Valid values:<br>0: Speaker identification is disabled.<br>1: Speaker identification is enabled.<br>By default, speaker identification is disabled.</p>
        /// </summary>
        [JsonProperty("SpeakerMode")]
        public long? SpeakerMode{ get; set; }

        /// <summary>
        /// <p>Indicates whether to output the identified speaker to the subtitle file. Valid values:<br>0: The speaker is not output to the subtitle file.<br>1: The speaker is output to the VTT subtitle file.<br>Note: To use this parameter, the value of SpeakerMode cannot be 0.<br>By default, the speaker is not output to the subtitle file.</p>
        /// </summary>
        [JsonProperty("SpeakerLabel")]
        public long? SpeakerLabel{ get; set; }


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
            this.SetParamObj(map, prefix + "SelectingSubtitleAreasConfig.", this.SelectingSubtitleAreasConfig);
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "SpeakerMode", this.SpeakerMode);
            this.SetParamSimple(map, prefix + "SpeakerLabel", this.SpeakerLabel);
        }
    }
}

