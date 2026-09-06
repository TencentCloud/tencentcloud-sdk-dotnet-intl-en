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

    public class TextToSpeechSyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Text for the synthesis. This is required for text to speech. The text cannot exceed 2000 bytes in length.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Voice Id. Fill in when synthesizing with a specified timbre. System, designed, and cloned timbres are supported.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>VOD application ID. Customers who activate on-demand services on or after December 25, 2023 must fill in this field with the application ID when accessing resources in VOD applications, whether in the default application or a newly created application.</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// <p>Language enhancement, such as "zh" "en" "auto", default "auto"</p>
        /// </summary>
        [JsonProperty("LanguageBoost")]
        public string LanguageBoost{ get; set; }

        /// <summary>
        /// <p>Output parameters.</p><p>Specifies the output format, etc. The default output audio format is base64.</p>
        /// </summary>
        [JsonProperty("Output")]
        public TextToSpeechSyncOutputOption Output{ get; set; }

        /// <summary>
        /// <p>Synchronous speech synthesis expansion parameters. Fields supported by <code>ExtParam</code>:</p><ul>  <li><code>model</code> (string): Synthesis model. Options: <code>minimax-speech-2.8-hd</code>, <code>minimax-speech-2.8-turbo</code>, <code>minimax-speech-2.6-hd</code>, <code>minimax-speech-2.6-turbo</code>, <code>minimax-speech-02-hd</code>, <code>minimax-speech-02-turbo</code>. Default: <code>minimax-speech-2.8-hd</code>.</li>  <li><code>voice_setting</code> (object): Fine adjustment of voice type. Optional fields:    <ul>      <li><code>speed</code> (float): Speech speed, <code>[0.5, 2.0]</code>. Default: <code>1.0</code>.</li>      <li><code>vol</code> (float): Volume, <code>(0, 10]</code>. Default: <code>1.0</code>.</li>      <li><code>pitch</code> (int): Pitch, <code>[-12, 12]</code>. Default: <code>0</code>.</li>      <li><code>emotion</code> (string): Emotion. Options: <code>happy</code> / <code>sad</code> / <code>angry</code> / <code>fearful</code> / <code>disgusted</code> / <code>surprised</code> / <code>calm</code> / <code>fluent</code> / <code>whisper</code>.</li>    </ul>  </li>  <li><code>audio_setting</code> (object): Audio output parameter. Optional fields:    <ul>      <li><code>sample_rate</code> (int): Sampling rate. Options: <code>8000</code> / <code>16000</code> / <code>22050</code> / <code>24000</code> / <code>32000</code> / <code>44100</code>. Default: <code>16000</code>.</li>      <li><code>format</code> (string): Audio format. Options: <code>mp3</code> / <code>wav</code>. Default: <code>wav</code>.</li>      <li><code>duration</code> (float): Target duration (seconds).</li>      <li><code>cut_silence</code> (bool): Whether to trim silence segments.</li>    </ul>  </li></ul>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

