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

    public class CloneVoiceAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AudioFileId")]
        public string AudioFileId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LanguageBoost")]
        public string LanguageBoost{ get; set; }

        /// <summary>
        /// <p>Voice clone expansion parameters. Fields supported by <code>ExtParam</code>:</p><ul>  <li><code>text</code> (string): Audition synthesis text, up to <code>1000</code> characters. When not empty, <code>tts_model</code> must be passed simultaneously. After the clone is successful, the audition audio <code>DemoAudio</code> is returned.</li>  <li><code>model</code> (string): Clone model. Default: <code>minimax-voice-clone</code>.</li>  <li><code>tts_model</code> (string): Model used to synthesize the audition audio. Options: <code>minimax-speech-2.8-hd</code>, <code>minimax-speech-2.8-turbo</code>, <code>minimax-speech-2.6-hd</code>, <code>minimax-speech-2.6-turbo</code>, <code>minimax-speech-02-hd</code>, <code>minimax-speech-02-turbo</code>. Required when <code>text</code> is not empty.</li>  <li><code>text_lang</code> (string): Language of the audition text.</li>  <li><code>voice_profile</code> (object): Voice profile. Optional fields:    <ul>      <li><code>name</code> (string): Timbre name.</li>      <li><code>description</code> (string): Timbre description.</li>      <li><code>gender</code> (string): Gender. Options: <code>male</code> / <code>female</code> / <code>unknown</code>.</li>      <li><code>age</code> (string): Age segment. Options: <code>child</code> / <code>teenager</code> / <code>youth</code> / <code>middle_aged</code> / <code>senior</code> / <code>unknown</code>.</li>      <li><code>languages</code> (string[]): Supported languages, such as <code>["zh", "en"]</code>.</li>      <li><code>labels</code> (string[]): Timbre tags, such as <code>["magnetic"]</code>.</li>      <li><code>scenes</code> (string[]): Application scenarios, such as <code>["commentate"]</code>.</li>    </ul>  </li></ul>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


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
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

