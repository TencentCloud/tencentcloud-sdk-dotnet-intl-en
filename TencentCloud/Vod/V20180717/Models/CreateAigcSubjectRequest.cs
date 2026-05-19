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
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled with the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Subject name.</p>
        /// </summary>
        [JsonProperty("SubjectName")]
        public string SubjectName{ get; set; }

        /// <summary>
        /// <p>Subject image. Upload at least 1 subject image. * Note 1: Support passing image URL (ensure it is accessible); * Note 2: Input limit of 3 images; * Note 3: Image format supports png, jpeg, jpg, webp; * Note 4: Image ratio must be less than 1:4 or 4:1; * Note 5: Image size no more than 50 MB;</p>
        /// </summary>
        [JsonProperty("SubjectImages")]
        public string[] SubjectImages{ get; set; }

        /// <summary>
        /// <p>The video reference allows uploading 1 main video.</p><ul><li>Note 1: Only the reference viduq2-pro model supports using the video subject.</li><li>Note 2: A maximum of 1 video of 5 seconds is supported.</li><li>Note 3: The video supports mp4, avi, or mov format.</li><li>Note 4: The video pixel cannot be less than 128*128, the ratio must be less than 1:4 or 4:1, and the size must be no more than 100M.</li></ul>
        /// </summary>
        [JsonProperty("SubjectVideos")]
        public string[] SubjectVideos{ get; set; }

        /// <summary>
        /// <p>Voice type Id. This information is used when creating an audio and video direct output task.</p><ul><li>Note 1: If no voice type Id is provided when generating an audio and video direct output task, the system will automatically recommend a voice type.</li><li>Note 2: Voice type Id cannot be used in q2-pro.</li></ul>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass through user request information. The task complete callback returns the value of this field. The maximum length is 1000 characters.</p>
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

