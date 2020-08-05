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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EncodeParams : AbstractModel
    {
        
        /// <summary>
        /// Output stream audio sample rate for stream mix. Valid values: 48000, 44100, 32000,24000, 22050, 16000, 12000, 11025, 8000.
        /// </summary>
        [JsonProperty("AudioSampleRate")]
        public ulong? AudioSampleRate{ get; set; }

        /// <summary>
        /// Output stream audio bitrate in Kbps for On-Cloud MixTranscoding. Value range: [8, 500].
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// Number of output stream audio sound channels for On-Cloud MixTranscoding. Value range: [1, 2].
        /// </summary>
        [JsonProperty("AudioChannels")]
        public ulong? AudioChannels{ get; set; }

        /// <summary>
        /// Output stream width in pixels for On-Cloud MixTranscoding, which is required for audio/video output. Value range: [0, 1920].
        /// </summary>
        [JsonProperty("VideoWidth")]
        public ulong? VideoWidth{ get; set; }

        /// <summary>
        /// Output stream height in pixels for On-Cloud MixTranscoding, which is required for audio/video output. Value range: [0, 1080].
        /// </summary>
        [JsonProperty("VideoHeight")]
        public ulong? VideoHeight{ get; set; }

        /// <summary>
        /// Output stream bitrate in Kbps for On-Cloud MixTranscoding, which is required for audio/video output. Value range: [1, 10000].
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// Output stream frame rate for On-Cloud MixTranscoding, which is required for audio/video output. Value range: [6, 12, 15, 24, 30, 48, 60]. If the frame rate lies outside the valid value range, it will be automatically modified to a value within the range.
        /// </summary>
        [JsonProperty("VideoFramerate")]
        public ulong? VideoFramerate{ get; set; }

        /// <summary>
        /// Output stream GOP in seconds for On-Cloud MixTranscoding, which is required for audio/video output. Value range: [1, 5].
        /// </summary>
        [JsonProperty("VideoGop")]
        public ulong? VideoGop{ get; set; }

        /// <summary>
        /// Output stream background color for On-Cloud MixTranscoding.
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public ulong? BackgroundColor{ get; set; }

        /// <summary>
        /// Output stream background image for stream mix. Its value is the ID of image uploaded through the TRTC Console.
        /// </summary>
        [JsonProperty("BackgroundImageId")]
        public ulong? BackgroundImageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioSampleRate", this.AudioSampleRate);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "AudioChannels", this.AudioChannels);
            this.SetParamSimple(map, prefix + "VideoWidth", this.VideoWidth);
            this.SetParamSimple(map, prefix + "VideoHeight", this.VideoHeight);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "VideoFramerate", this.VideoFramerate);
            this.SetParamSimple(map, prefix + "VideoGop", this.VideoGop);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
            this.SetParamSimple(map, prefix + "BackgroundImageId", this.BackgroundImageId);
        }
    }
}

