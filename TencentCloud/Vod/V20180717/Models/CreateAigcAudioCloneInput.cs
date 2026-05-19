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

    public class CreateAigcAudioCloneInput : AbstractModel
    {
        
        /// <summary>
        /// <p>The original audio file. The model will clone the voice type based on the audio timbre passed in this parameter as an example.</p>
        /// </summary>
        [JsonProperty("AudioFileInfo")]
        public AigcAudioCloneInputFileInfo AudioFileInfo{ get; set; }

        /// <summary>
        /// <p>Custom voice ID.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Clone audition parameters.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Example audio for voice replication.</p>
        /// </summary>
        [JsonProperty("PromptAudioFileInfo")]
        public AigcAudioCloneInputFileInfo PromptAudioFileInfo{ get; set; }

        /// <summary>
        /// <p>Text content of the sample audio.</p>
        /// </summary>
        [JsonProperty("PromptText")]
        public string PromptText{ get; set; }

        /// <summary>
        /// <p>Pass-through parameter.</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AudioFileInfo.", this.AudioFileInfo);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "PromptAudioFileInfo.", this.PromptAudioFileInfo);
            this.SetParamSimple(map, prefix + "PromptText", this.PromptText);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
        }
    }
}

