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

    public class CloneVoiceSyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>VOD application ID. Customers who activate on-demand services after December 25, 2023 must fill in this field with the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// <p>Base64-encoded audio for cloning.</p>
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// <p>Cloning audio URL. Valid when AudioData is empty.</p>
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// <p>File ID for cloning. Valid when AudioData and AudioUrl are empty</p>
        /// </summary>
        [JsonProperty("AudioFileId")]
        public string AudioFileId{ get; set; }

        /// <summary>
        /// <p>Language enhancement, such as "zh" "en" "auto", default "auto"</p>
        /// </summary>
        [JsonProperty("LanguageBoost")]
        public string LanguageBoost{ get; set; }

        /// <summary>
        /// <p>Expansion parameters for synchronous timbre clone. Supported fields of <code>ExtParam</code>:</p><ul>  <li><code>text</code> (string): Audition synthesis text, up to <code>1000</code> characters. If not empty, <code>tts_model</code> must be passed simultaneously. Returns the audition audio <code>DemoAudio</code> upon successful clone.</li>  <li><code>model</code> (string): Clone model. Default: <code>minimax-voice-clone</code>.</li>  <li><code>tts_model</code> (string): Model used to synthesize the audition audio. Options: <code>minimax-speech-2.8-hd</code>, <code>minimax-speech-2.8-turbo</code>, <code>minimax-speech-2.6-hd</code>, <code>minimax-speech-2.6-turbo</code>, <code>minimax-speech-02-hd</code>, <code>minimax-speech-02-turbo</code>. Required when <code>text</code> is not empty.</li>  <li><code>text_lang</code> (string): Audition text language.</li>  <li><code>voice_profile</code> (object): Timbre profile. Optional fields:    <ul>      <li><code>name</code> (string): Timbre name.</li>      <li><code>description</code> (string): Timbre description.</li>      <li><code>gender</code> (string): Gender. Options: <code>male</code> / <code>female</code> / <code>unknown</code>.</li>      <li><code>age</code> (string): Age segment. Options: <code>child</code> / <code>teenager</code> / <code>youth</code> / <code>middle_aged</code> / <code>senior</code> / <code>unknown</code>.</li>      <li><code>languages</code> (string[]): Supported languages, for example <code>["zh", "en"]</code>.</li>      <li><code>labels</code> (string[]): Timbre tags, for example <code>["magnetic"]</code>.</li>      <li><code>scenes</code> (string[]): Application scenarios, for example <code>["commentary"]</code>.</li>    </ul>  </li></ul>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioFileId", this.AudioFileId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

