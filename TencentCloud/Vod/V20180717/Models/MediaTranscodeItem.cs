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

    public class MediaTranscodeItem : AbstractModel
    {
        
        /// <summary>
        /// <p>File URL of the transcoded video.</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Transcoding specification ID. Please refer to <a href="https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1">transcoding parameter template</a>.<br><font color="red">Note: A value of 0 means the raw file.</font></p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Sum of the mean bitrate of a stream and the mean audio stream bit rate, unit: bps.</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// <p>Maximum value of video stream height. Unit: px.</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>Maximum value of video stream width. Unit: px.</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>Total size of media files, measurement unit: byte.</p><li>When the media file is HLS, the size is the sum of m3u8 and ts file sizes.</li>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>Video duration, in seconds.</p>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>md5 value of the video.</p>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// <p>Container type, such as m4a, mp4.</p>
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <p>Video stream information.</p>
        /// </summary>
        [JsonProperty("VideoStreamSet")]
        public MediaVideoStreamItem[] VideoStreamSet{ get; set; }

        /// <summary>
        /// <p>Audio stream information.</p>
        /// </summary>
        [JsonProperty("AudioStreamSet")]
        public MediaAudioStreamItem[] AudioStreamSet{ get; set; }

        /// <summary>
        /// <p>Digital watermark type. Available values:</p><li>Trace means transit watermark processing;</li><li>CopyRight means copyright watermark processing;</li><li>None means no digital watermark processing.</li>
        /// </summary>
        [JsonProperty("DigitalWatermarkType")]
        public string DigitalWatermarkType{ get; set; }

        /// <summary>
        /// <p>Copyright information.</p>
        /// </summary>
        [JsonProperty("CopyRightWatermarkText")]
        public string CopyRightWatermarkText{ get; set; }

        /// <summary>
        /// <p>Digital watermark template id.</p>
        /// </summary>
        [JsonProperty("BlindWatermarkDefinition")]
        public long? BlindWatermarkDefinition{ get; set; }

        /// <summary>
        /// <p>Generated new FileId for transcoding. Valid when requesting to enable independence media output.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamArrayObj(map, prefix + "VideoStreamSet.", this.VideoStreamSet);
            this.SetParamArrayObj(map, prefix + "AudioStreamSet.", this.AudioStreamSet);
            this.SetParamSimple(map, prefix + "DigitalWatermarkType", this.DigitalWatermarkType);
            this.SetParamSimple(map, prefix + "CopyRightWatermarkText", this.CopyRightWatermarkText);
            this.SetParamSimple(map, prefix + "BlindWatermarkDefinition", this.BlindWatermarkDefinition);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

