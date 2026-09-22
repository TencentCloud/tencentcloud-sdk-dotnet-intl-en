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

    public class CreateAigcAudioCloneRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>On-demand <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Original audio file (ensure it is accessible). The model will use the voice type of the audio passed in this parameter as an example to clone the voice type.  </p><p>Input limitations: Note 1: Supported audio formats: mp3, m4a, wav; Note 2: The duration of the uploaded audio file should be at least 10 seconds and no more than 5 minutes; Note 3: The uploaded audio file size must not exceed 20 mb; Note 4: The audio content must not involve copyright, otherwise it will be removed or terminated.</p>
        /// </summary>
        [JsonProperty("AudioFileInfo")]
        public AigcAudioCloneInputFileInfo AudioFileInfo{ get; set; }

        /// <summary>
        /// <p>Custom voice ID, for example: "vidu01".</p><p>Input limitations:</p><ul><li>Length range of a custom voice_ID: [8,256];</li><li>The first character must be an English letter;</li><li>Numbers, letters, hyphens, and underscores are allowed;</li><li>The last character cannot be - or _</li><li>voice_ID cannot duplicate an existing ID, otherwise an error will occur.</li></ul>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Replicate audition parameters.</p><p>Parameter format: up to 1000 characters. The model will use the cloned voice type to read aloud the text content and return an audition audio link. Note: Audition will be charged based on the number of characters for text to speech.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Sample audio for voice replication. Providing this parameter will help in enhancing the voice similarity and stability of text to speech. If you use this parameter, you need to upload a short sample audio at the same time.</p><p>Input limitations: Note 1: Audio formats supported: mp3, m4a, wav; Note 2: The duration of the uploaded audio file should be less than 8 seconds; Note 3: The uploaded audio file size should be no more than 20 mb.</p>
        /// </summary>
        [JsonProperty("PromptAudioFileInfo")]
        public AigcAudioCloneInputFileInfo PromptAudioFileInfo{ get; set; }

        /// <summary>
        /// <p>The text content corresponding to the sample audio must match the audio content, and punctuation is required at the end of each sentence.</p>
        /// </summary>
        [JsonProperty("PromptText")]
        public string PromptText{ get; set; }

        /// <summary>
        /// <p>Pass-through parameter. Input parameter limit: without any processing, only data transmission. Note: up to 1048576 characters</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The audio and video quality revival complete callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purposes.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "AudioFileInfo.", this.AudioFileInfo);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "PromptAudioFileInfo.", this.PromptAudioFileInfo);
            this.SetParamSimple(map, prefix + "PromptText", this.PromptText);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

