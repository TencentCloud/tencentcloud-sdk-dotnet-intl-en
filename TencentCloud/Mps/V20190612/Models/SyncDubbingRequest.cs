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

    public class SyncDubbingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Text for the synthesis. This is required for text to speech. The text cannot exceed 2000 characters in length.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Text language. This defaults to Chinese if left empty.<br>Supported languages:<br>zh    Chinese<br>en    English<br>ja    Japanese<br>de    German<br>fr    French<br>ko    Korean<br>ru    Russian<br>uk    Ukrainian<br>pt    Portuguese<br>it    Italian<br>es    Spanish<br>id    Indonesian<br>nl    Dutch<br>tr    Turkish<br>fil    Filipino<br>ms    Malay<br>el    Greek<br>fi    Finnish<br>hr    Croatian<br>sk    Slovak<br>pl    Polish<br>sv    Swedish<br>hi    Hindi<br>bg    Bulgarian<br>ro    Romanian<br>ar    Arabic<br>cs    Czech<br>da    Danish<br>ta    Tamil<br>hun    Hungarian<br>vi    Vietnamese<br>no    Norwegian<br>yue    Cantonese<br>th    Thai<br>he    Hebrew<br>ca    Catalan<br>nn    Nynorsk<br>af    Afrikaans<br>fa    Persian<br>sl    Slovenian</p>
        /// </summary>
        [JsonProperty("TextLang")]
        public string TextLang{ get; set; }

        /// <summary>
        /// <p>Voice ID. This is required for synthesis with a specific voice. System voice and voice cloning are supported.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

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
        /// <p>Cloning audio language. The default language is Chinese. <br>Supported languages are the same as those for TextLang.</p>
        /// </summary>
        [JsonProperty("AudioLang")]
        public string AudioLang{ get; set; }

        /// <summary>
        /// <p>Voice attribute.</p>
        /// </summary>
        [JsonProperty("VoiceProfile")]
        public VoiceProfile VoiceProfile{ get; set; }

        /// <summary>
        /// <p>Output parameters.</p><p>Specifies the output format, etc. The default output audio format is base64.</p>
        /// </summary>
        [JsonProperty("Output")]
        public SyncDubbingOutputOption Output{ get; set; }

        /// <summary>
        /// <p>Resource ID. The resource needs to be enabled. The default value is the account's primary resource ID.</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>Extended parameters in the format of a JSON string.</p>
        /// <p>
        /// 
        /// - <strong>synExt</strong>    Object;    Extended text to speech parameter.<br>
        /// - <strong>duration</strong>    Float;    Synthesized audio duration, in seconds. Example: 5.2.<br>
        /// - <strong>sampleRate</strong>    Integer;    Synthesized audio sample rate. Default value: 16000. Valid values: [8000, 16000, 22050, 24000, 32000, 44100].<br>
        /// - <strong>pitch</strong>    Integer;    Pitch. Default value: 0 (original voice output). Valid values: [-12, 12].<br>
        /// - <strong>cloneExt</strong>    Object;    Extended voice cloning parameter.<br>
        /// - <strong>timeRanges</strong>    Float;    Specifies the time ranges for audio cloning. The default value is the first 20 seconds of the audio. Example: [[5.2, 10], [45, 59.8]].
        /// 
        /// </p>
        /// 
        /// 
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextLang", this.TextLang);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioLang", this.AudioLang);
            this.SetParamObj(map, prefix + "VoiceProfile.", this.VoiceProfile);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

