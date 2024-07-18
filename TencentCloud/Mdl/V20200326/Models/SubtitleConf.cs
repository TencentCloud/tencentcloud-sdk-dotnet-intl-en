/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Optional values: INPUT (source subtitle information), ANALYSIS (intelligent speech recognition to subtitles, currently only supports this option).
        /// </summary>
        [JsonProperty("CaptionSource")]
        public string CaptionSource{ get; set; }

        /// <summary>
        /// Optional values: 1 Source, 2 Source+Target, 3 Target (original language only, original language + translation language, translation language).
        /// </summary>
        [JsonProperty("ContentType")]
        public ulong? ContentType{ get; set; }

        /// <summary>
        /// Output mode: 1 Burn in (currently only this option is supported).
        /// </summary>
        [JsonProperty("TargetType")]
        public ulong? TargetType{ get; set; }

        /// <summary>
        /// Original phonetic language.
        /// Optional values: Chinese, English, Japanese, Korean.
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }

        /// <summary>
        /// Target language.
        /// Optional values: Chinese, English, Japanese, Korean.
        /// </summary>
        [JsonProperty("TargetLanguage")]
        public string TargetLanguage{ get; set; }

        /// <summary>
        /// Font style configuration.
        /// </summary>
        [JsonProperty("FontStyle")]
        public SubtitleFontConf FontStyle{ get; set; }

        /// <summary>
        /// There are two modes: STEADY and DYNAMIC, corresponding to steady state and unstable state respectively; the default is STEADY.
        /// </summary>
        [JsonProperty("StateEffectMode")]
        public string StateEffectMode{ get; set; }

        /// <summary>
        /// Steady-state delay time, unit seconds; optional values: 10, 20, default 10.
        /// </summary>
        [JsonProperty("SteadyStateDelayedTime")]
        public ulong? SteadyStateDelayedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CaptionSource", this.CaptionSource);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
            this.SetParamSimple(map, prefix + "TargetLanguage", this.TargetLanguage);
            this.SetParamObj(map, prefix + "FontStyle.", this.FontStyle);
            this.SetParamSimple(map, prefix + "StateEffectMode", this.StateEffectMode);
            this.SetParamSimple(map, prefix + "SteadyStateDelayedTime", this.SteadyStateDelayedTime);
        }
    }
}

