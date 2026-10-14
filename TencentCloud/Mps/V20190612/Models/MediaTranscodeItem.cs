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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaTranscodeItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Target storage for the transcoded file.</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>Transcoded video file path.</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>Transcoding specification ID. Please refer to <a href="https://www.tencentcloud.com/document/product/862/37042?from_cn_redirect=1">transcoding parameter template</a>.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Sum of the mean video stream bitrate and the mean audio stream bitrate. Unit: bps.</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// <p>Maximum height of the video stream. Unit: px.</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>Maximum video stream width. Unit: px.</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>Total size of media files (for HLS videos, the size is the sum of m3u8 and ts file sizes), unit: byte.</p>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>Video duration, in seconds.</p>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>Container type, for example, m4a, mp4.</p>
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <p>md5 value of the video.</p>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// <p>Audio stream information.</p>
        /// </summary>
        [JsonProperty("AudioStreamSet")]
        public MediaAudioStreamItem[] AudioStreamSet{ get; set; }

        /// <summary>
        /// <p>Video stream information.</p>
        /// </summary>
        [JsonProperty("VideoStreamSet")]
        public MediaVideoStreamItem[] VideoStreamSet{ get; set; }

        /// <summary>
        /// <p>Video transcoding enhancement item descriptions and explanations</p><li>hdr: HDR configuration</li><li>wd_fps: Frame interpolation frame rate configuration</li><li>video_super_resolution: Super-resolution configuration</li><li>repair: Comprehensive enhancement configuration</li><li>denoise: Video noise reduction configuration</li><li>color_enhance: Color enhancement configuration</li><li>scratch: Scratches removal configuration</li><li>artifact: Artifacts removal (burrs) configuration</li><li>sharp: Detail enhancement configuration</li><li>low_light: Low-light enhancement configuration</li><li>face_enhance: Face enhancement configuration</li>
        /// </summary>
        [JsonProperty("CallBackExtInfo")]
        public string CallBackExtInfo{ get; set; }

        /// <summary>
        /// <p>MediaTranscodeItem</p>
        /// </summary>
        [JsonProperty("Usage")]
        public MediaUsageItem Usage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamArrayObj(map, prefix + "AudioStreamSet.", this.AudioStreamSet);
            this.SetParamArrayObj(map, prefix + "VideoStreamSet.", this.VideoStreamSet);
            this.SetParamSimple(map, prefix + "CallBackExtInfo", this.CallBackExtInfo);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
        }
    }
}

