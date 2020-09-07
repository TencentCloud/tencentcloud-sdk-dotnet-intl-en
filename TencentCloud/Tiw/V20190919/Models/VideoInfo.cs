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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoInfo : AbstractModel
    {
        
        /// <summary>
        /// Video playback start time, in milliseconds
        /// </summary>
        [JsonProperty("VideoPlayTime")]
        public long? VideoPlayTime{ get; set; }

        /// <summary>
        /// Video size, in bytes
        /// </summary>
        [JsonProperty("VideoSize")]
        public long? VideoSize{ get; set; }

        /// <summary>
        /// Video format
        /// </summary>
        [JsonProperty("VideoFormat")]
        public string VideoFormat{ get; set; }

        /// <summary>
        /// Video playback duration, in milliseconds
        /// </summary>
        [JsonProperty("VideoDuration")]
        public long? VideoDuration{ get; set; }

        /// <summary>
        /// Video file URL
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// Video file ID
        /// </summary>
        [JsonProperty("VideoId")]
        public string VideoId{ get; set; }

        /// <summary>
        /// Video stream type - 0: camera video - 1: screen-sharing video - 2: whiteboard video - 3: mixed stream video - 4: audio-only (mp3)
        /// </summary>
        [JsonProperty("VideoType")]
        public long? VideoType{ get; set; }

        /// <summary>
        /// ID of the user to which the camera video or screen-sharing video belongs (whiteboard video: null, mixed stream video: tic_mixstream_<Room ID>_<Mixed stream layout type>, auxiliary video: tic_substream_user ID)
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Width of the video resolution.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Height of the video resolution.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoPlayTime", this.VideoPlayTime);
            this.SetParamSimple(map, prefix + "VideoSize", this.VideoSize);
            this.SetParamSimple(map, prefix + "VideoFormat", this.VideoFormat);
            this.SetParamSimple(map, prefix + "VideoDuration", this.VideoDuration);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "VideoId", this.VideoId);
            this.SetParamSimple(map, prefix + "VideoType", this.VideoType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

