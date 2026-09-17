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

    public class MediaMetaData : AbstractModel
    {
        
        /// <summary>
        /// Size of the uploaded media file (for HLS videos, the size is the sum of the m3u8 and ts file sizes), unit: byte.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// Container type, for example, m4a, mp4.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// Sum of the mean video stream bitrate and mean audio stream bitrate, in bps.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Maximum video stream height in px.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Maximum video stream width in px.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Video duration, unit: seconds.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Selection angle during video shooting. Unit: degree.
        /// </summary>
        [JsonProperty("Rotate")]
        public long? Rotate{ get; set; }

        /// <summary>
        /// Video stream information.
        /// </summary>
        [JsonProperty("VideoStreamSet")]
        public MediaVideoStreamItem[] VideoStreamSet{ get; set; }

        /// <summary>
        /// Audio stream information.
        /// </summary>
        [JsonProperty("AudioStreamSet")]
        public MediaAudioStreamItem[] AudioStreamSet{ get; set; }

        /// <summary>
        /// Video duration, unit: seconds.
        /// </summary>
        [JsonProperty("VideoDuration")]
        public float? VideoDuration{ get; set; }

        /// <summary>
        /// Audio duration, in seconds.
        /// </summary>
        [JsonProperty("AudioDuration")]
        public float? AudioDuration{ get; set; }

        /// <summary>
        /// Md5 value of the media file.
        /// <li><font color=red>Note</font>: To get the Md5 of a media file, call the DescribeFileAttributes API and get it after the task is completed.</li>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
            this.SetParamArrayObj(map, prefix + "VideoStreamSet.", this.VideoStreamSet);
            this.SetParamArrayObj(map, prefix + "AudioStreamSet.", this.AudioStreamSet);
            this.SetParamSimple(map, prefix + "VideoDuration", this.VideoDuration);
            this.SetParamSimple(map, prefix + "AudioDuration", this.AudioDuration);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
        }
    }
}

