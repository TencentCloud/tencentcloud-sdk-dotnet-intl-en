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

    public class CreateAigcSubjectRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate VOD services from December 25, 2023, this field must be filled with the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Subject name.</p>
        /// </summary>
        [JsonProperty("SubjectName")]
        public string SubjectName{ get; set; }

        /// <summary>
        /// <p>Main image. Upload at least 1 main image. * Note 1: You can pass an image URL (make sure it is accessible); * Note 2: Input limit: 3 images; * Note 3: Supported formats: png, jpeg, jpg, webp; * Note 4: The image ratio must be less than 1:4 or 4:1; * Note 5: The image size must not exceed 50 MB;</p>
        /// </summary>
        [JsonProperty("SubjectImages")]
        public string[] SubjectImages{ get; set; }

        /// <summary>
        /// <p>Video reference allows uploading 1 subject video</p><ul><li>Note 1: For reference only, the viduq2-pro model supports the use of video subjects</li><li>Note 2: Allows uploading up to 1 video of 5 seconds</li><li>Note 3: Video supports mp4, avi, mov formats</li><li>Note 4: Video pixel cannot be less than 128*128, and the ratio must be less than 1:4 or 4:1, and the size no more than 100M.</li></ul>
        /// </summary>
        [JsonProperty("SubjectVideos")]
        public string[] SubjectVideos{ get; set; }

        /// <summary>
        /// <p>Main voice type Id. This information is used only when creating an audio and video direct output task.</p><ul><li>Note 1: If no voice type Id is passed when generating an audio and video direct output task, the system will automatically recommend a voice type.</li><li>Note 2: q2-pro does not support using a voice type Id.</li></ul>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

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
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If left blank, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SubjectName", this.SubjectName);
            this.SetParamArraySimple(map, prefix + "SubjectImages.", this.SubjectImages);
            this.SetParamArraySimple(map, prefix + "SubjectVideos.", this.SubjectVideos);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

