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

    public class ComposeMediaOutput : AbstractModel
    {
        
        /// <summary>
        /// Filename, which contains up to 64 characters.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Description. Up to 128 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Category ID, used to categorize and manage media. You can create a category and obtain the category ID through the [create category](https://www.tencentcloud.com/document/product/266/7812) API.
        /// <li>Default value: 0, indicate other categories.</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Expiry date of the output file. The file will be deleted after this time. It never expires by default. The format follows the ISO 8601 standard. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Muxing format. Available values: mp4 and mp3. Among them, mp3 is for audio-only files.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// Output video information.
        /// </summary>
        [JsonProperty("VideoStream")]
        public OutputVideoStream VideoStream{ get; set; }

        /// <summary>
        /// Output audio content.
        /// </summary>
        [JsonProperty("AudioStream")]
        public OutputAudioStream AudioStream{ get; set; }

        /// <summary>
        /// Indicates whether to remove video data. Available values:
        /// <li>0: retention</li>
        /// <li>1: Remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Indicates whether to remove audio data. Available values:
        /// <li>0: retention</li>
        /// <li>1: Remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamObj(map, prefix + "VideoStream.", this.VideoStream);
            this.SetParamObj(map, prefix + "AudioStream.", this.AudioStream);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
        }
    }
}

