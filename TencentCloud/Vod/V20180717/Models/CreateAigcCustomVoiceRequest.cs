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

    public class CreateAigcCustomVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>On-demand <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled with the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Timbre name. The text content can contain up to 20 characters.</p>
        /// </summary>
        [JsonProperty("VoiceName")]
        public string VoiceName{ get; set; }

        /// <summary>
        /// <p>Access link for voice type data files, supporting audio/video files in .mp3 / .wav / .mp4 / .mov formats. The voice in the audio must be clean and noiseless, with only one voice, and a duration of no less than 5 seconds and no more than 30 seconds.</p>
        /// </summary>
        [JsonProperty("VoiceUrl")]
        public string VoiceUrl{ get; set; }

        /// <summary>
        /// <p>Historic works ID, which can provide audio material by referring to historic works.</p>
        /// </summary>
        [JsonProperty("VideoId")]
        public string VideoId{ get; set; }

        /// <summary>
        /// <p>If the overseas custom timbre library is enabled, you can pass in <code>True</code> to use it.</p><p>Enumeration values:</p><ul><li>True: Use the overseas custom timbre library.</li><li>False: Do not use the overseas custom timbre library.</li></ul>
        /// </summary>
        [JsonProperty("DisableModeration")]
        public string DisableModeration{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The task completion callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "VoiceName", this.VoiceName);
            this.SetParamSimple(map, prefix + "VoiceUrl", this.VoiceUrl);
            this.SetParamSimple(map, prefix + "VideoId", this.VideoId);
            this.SetParamSimple(map, prefix + "DisableModeration", this.DisableModeration);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

