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
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled with the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>The original audio file (ensure it is accessible). The model will clone the voice type based on the audio timbre passed in this parameter as an example.</p><p>Input parameter limits: Note 1: Supported formats for audio: mp3, m4a, wav; Note 2: The duration of the uploaded audio should be no less than 10 seconds and not more than 5 minutes; Note 3: The audio file size should be no more than 20 MB; Note 4: The audio content must not involve copyright issues, otherwise it will be taken down or terminated.</p>
        /// </summary>
        [JsonProperty("AudioFileInfo")]
        public AigcAudioCloneInputFileInfo AudioFileInfo{ get; set; }

        /// <summary>
        /// <p>Custom voice ID, for example: "vidu01".</p><p>Input parameter limits:</p><ul><li>Custom voice_ID length range [8,256];</li><li>The first character must be an English letter;</li><li>Allow numbers, letters, hyphens, underscores;</li><li>The last character cannot be - or _;</li><li>voice_ID cannot duplicate existing IDs, otherwise an error will occur.</li></ul>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Clone audition parameters.</p><p>Parameter format: Character limit up to 1000. The model will read aloud the segment text content using the cloned voice type and return the audition audio link. Note: The text to speech fee will be charged based on the number of characters.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Voice replication sample audio. Providing this parameter will help enhance the similarity and stability of text to speech voice type. If you use this parameter, upload a short sample audio at the same time.</p><p>Input parameter limitation: Note 1: Formats supported for audio: mp3, m4a, wav; Note 2: Duration of the uploaded audio should be less than 8 seconds; Note 3: Audio file size should be no more than 20mb.</p>
        /// </summary>
        [JsonProperty("PromptAudioFileInfo")]
        public AigcAudioCloneInputFileInfo PromptAudioFileInfo{ get; set; }

        /// <summary>
        /// <p>The text content corresponding to the sample audio must match the audio content. Punctuation is required at the end of sentence.</p>
        /// </summary>
        [JsonProperty("PromptText")]
        public string PromptText{ get; set; }

        /// <summary>
        /// <p>Pass-through parameter. Input parameter limit: Without any processing, only data transmission. Note: Up to 1048576 characters.</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass through user request information. The audio and video quality revival complete callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Reserved field, used when special purpose.</p>
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

