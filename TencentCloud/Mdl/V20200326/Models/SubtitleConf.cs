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

    public class SubtitleConf : AbstractModel
    {
        
        /// <summary>
        /// Template Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Name of the subtitle selector. Required when CaptionSource is set to INPUT.
        /// </summary>
        [JsonProperty("CaptionSelectorName")]
        public string CaptionSelectorName{ get; set; }

        /// <summary>
        /// Available values: INPUT (source subtitle information), ANALYSIS (intelligent voice recognition to subtitle).
        /// </summary>
        [JsonProperty("CaptionSource")]
        public string CaptionSource{ get; set; }

        /// <summary>
        /// Available values: 1 Source, 2 Source+Target, 3 Target (source language only, source language + target language, target language). When the output is WebVTT, it can only output one language.
        /// </summary>
        [JsonProperty("ContentType")]
        public ulong? ContentType{ get; set; }

        /// <summary>
        /// Output mode: 1 Burn in, 2 Embedded, 3 WebVTT. When CaptionSource is INPUT, it supports only 2. When CaptionSource is ANALYSIS, it supports 1, 3.
        /// </summary>
        [JsonProperty("TargetType")]
        public ulong? TargetType{ get; set; }

        /// <summary>
        /// Original speech languages: Chinese, English, Japanese, Korean.
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }

        /// <summary>
        /// Target languages: Chinese, English, Japanese, Korean.
        /// </summary>
        [JsonProperty("TargetLanguage")]
        public string TargetLanguage{ get; set; }

        /// <summary>
        /// Font style configuration. Required for BurnIn.
        /// </summary>
        [JsonProperty("FontStyle")]
        public SubtitleFontConf FontStyle{ get; set; }

        /// <summary>
        /// STEADY and DYNAMIC modes correspond to steady state and non-steady state respectively. Default is STEADY. Only select STEADY when the output is WebVTT.
        /// </summary>
        [JsonProperty("StateEffectMode")]
        public string StateEffectMode{ get; set; }

        /// <summary>
        /// Steady-state delay time in seconds. Value range: 10, 20. Default: 10.
        /// </summary>
        [JsonProperty("SteadyStateDelayedTime")]
        public ulong? SteadyStateDelayedTime{ get; set; }

        /// <summary>
        /// Audio selector name, required for speech recognition to generate WebVTT subtitles, can be empty
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public string AudioSelectorName{ get; set; }

        /// <summary>
        /// Format configuration for WebVTT output in speech recognition.
        /// </summary>
        [JsonProperty("WebVTTFontStyle")]
        public WebVTTFontStyle WebVTTFontStyle{ get; set; }

        /// <summary>
        /// Language code, length 2-20.
        /// </summary>
        [JsonProperty("LanguageCode")]
        public string LanguageCode{ get; set; }

        /// <summary>
        /// Language description, length less than 100.
        /// </summary>
        [JsonProperty("LanguageDescription")]
        public string LanguageDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CaptionSelectorName", this.CaptionSelectorName);
            this.SetParamSimple(map, prefix + "CaptionSource", this.CaptionSource);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
            this.SetParamSimple(map, prefix + "TargetLanguage", this.TargetLanguage);
            this.SetParamObj(map, prefix + "FontStyle.", this.FontStyle);
            this.SetParamSimple(map, prefix + "StateEffectMode", this.StateEffectMode);
            this.SetParamSimple(map, prefix + "SteadyStateDelayedTime", this.SteadyStateDelayedTime);
            this.SetParamSimple(map, prefix + "AudioSelectorName", this.AudioSelectorName);
            this.SetParamObj(map, prefix + "WebVTTFontStyle.", this.WebVTTFontStyle);
            this.SetParamSimple(map, prefix + "LanguageCode", this.LanguageCode);
            this.SetParamSimple(map, prefix + "LanguageDescription", this.LanguageDescription);
        }
    }
}

