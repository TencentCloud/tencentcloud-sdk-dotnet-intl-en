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

    public class AigcVideoTaskInputSubjectInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Fixed subject Id.</p><ul><li>Kling subject <strong>required</strong>;</li><li>Vidu subject selectable.</li></ul>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Fixed name.</p><ul><li>Vidu subject is <strong>required</strong>, can be used by adding [@name] in prompt. For example, when name is Xiao Ming, describe it as [@Xiao Ming] in prompt.</li><li>Kling subject is selectable.</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p><strong>Valid only for Vidu.</strong> Voice type ID is used to determine the sound timbre in the video. If left empty, the system will automatically recommend one.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p><strong>Valid for Vidu only.</strong> Temporary subject images, up to 3 images<br>Note 1: Support passing image URL (ensure it is accessible);<br>Note 2: Images support png, jpeg, jpg, webp format;<br>Note 3: Image pixel cannot be less than 128*128, and the ratio must be less than 1:4 or 4:1.</p>
        /// </summary>
        [JsonProperty("ImageUrls")]
        public string[] ImageUrls{ get; set; }

        /// <summary>
        /// <p><strong>Valid for Vidu only.</strong> Temporary subject video, a maximum of one 5-second video. Note 1: Only the viduq2-pro model supports the use of video subject; Note 2: Supports up to one 5-second video upload; Note 3: Video supports mp4, avi, mov format; Note 4: Video pixel cannot be less than 128*128, and the ratio must be less than 1:4 or 4:1.</p>
        /// </summary>
        [JsonProperty("VideoUrls")]
        public string[] VideoUrls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamArraySimple(map, prefix + "ImageUrls.", this.ImageUrls);
            this.SetParamArraySimple(map, prefix + "VideoUrls.", this.VideoUrls);
        }
    }
}

