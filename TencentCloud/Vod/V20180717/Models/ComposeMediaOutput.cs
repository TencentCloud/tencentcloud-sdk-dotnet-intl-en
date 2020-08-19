/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Filename of up to 64 characters.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Description, which can contain up to 128 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Category ID, which is used to categorize the media for management. A category can be created and its ID can be obtained by using the [category creating](https://intl.cloud.tencent.com/document/product/266/7812?from_cn_redirect=1) API.
        /// <li>Default value: 0, which means "Other".</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Expiration time of output media file in ISO 8601 format, after which the file will be deleted. Files will never expire by default. For more information, please see [Notes on ISO Date Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Container. Valid values: mp4, mp3. mp3 is for audio files.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// Information of output video.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoStream")]
        public OutputVideoStream VideoStream{ get; set; }

        /// <summary>
        /// Information of output audio.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioStream")]
        public OutputAudioStream AudioStream{ get; set; }

        /// <summary>
        /// Whether to remove video data. Valid values:
        /// <li>0: retain</li>
        /// <li>1: remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Whether to remove audio data. Valid values:
        /// <li>0: retain</li>
        /// <li>1: remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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

