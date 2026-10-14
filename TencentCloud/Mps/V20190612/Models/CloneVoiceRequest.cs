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

    public class CloneVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Clone audio base64 code</p>
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// <p>Cloning audio URL. Valid when AudioData is empty.</p>
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// <p>Cloning audio language. The default language is Chinese. Supported languages are the same as those for TextLang in text to speech.</p>
        /// </summary>
        [JsonProperty("AudioLang")]
        public string AudioLang{ get; set; }

        /// <summary>
        /// <p>Voice attribute. Use timbre for querying and matching.</p>
        /// </summary>
        [JsonProperty("VoiceProfile")]
        public VoiceProfile VoiceProfile{ get; set; }

        /// <summary>
        /// <p>Trial text</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Language of the trial text. By default, it is automatically detected if left blank. The currently supported languages are the same as those for TTS.</p>
        /// </summary>
        [JsonProperty("TextLang")]
        public string TextLang{ get; set; }

        /// <summary>
        /// <p>Output parameters. You can specify the output audio format, etc. The default output audio format is base64.</p>
        /// </summary>
        [JsonProperty("Output")]
        public SyncDubbingOutputOption Output{ get; set; }

        /// <summary>
        /// <p>Extended parameters in the format of a JSON string.</p>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioLang", this.AudioLang);
            this.SetParamObj(map, prefix + "VoiceProfile.", this.VoiceProfile);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextLang", this.TextLang);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

