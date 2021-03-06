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
        /// Output audio sample rate (Hz) for On-Cloud MixTranscoding. Valid values: 48000, 44100, 32000, 24000, 16000, 8000
        /// </summary>
        [JsonProperty("AudioSampleRate")]
        public ulong? AudioSampleRate{ get; set; }

        /// <summary>
        /// Output audio bitrate (Kbps) for On-Cloud MixTranscoding. Value range: 8-500
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// Number of sound channels of output stream for On-Cloud MixTranscoding. Valid values: 1, 2. 1 represents mono-channel, and 2 represents dual-channel.
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
        /// Output bitrate (Kbps) for On-Cloud MixTranscoding, which is required for audio-video output. Value range: 1-10000
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// Output stream frame rate for On-Cloud MixTranscoding in FPS. This parameter is required for audio/video outputs. Value range: [1, 60].
        /// </summary>
        [JsonProperty("VideoFramerate")]
        public ulong? VideoFramerate{ get; set; }

        /// <summary>
        /// Output stream GOP in seconds for On-Cloud MixTranscoding, which is required for audio/video output. Value range: [1, 5].
        /// </summary>
        [JsonProperty("VideoGop")]
        public ulong? VideoGop{ get; set; }

        /// <summary>
        /// Output background color for On-Cloud MixTranscoding. Valid values: decimal integers. Commonly used colors include:
        /// Red: 0xff0000, whose decimal number is 16724736
        /// Yellow: 0xffff00, whose decimal number is 16776960
        /// Green: 0x33cc00, whose decimal number is 3394560
        /// Blue: 0x0066ff, whose decimal number is 26367
        /// Black: 0x000000, whose decimal number is 0
        /// White: 0xFFFFFF, whose decimal number is 16777215
        /// Grey: 0x999999, whose decimal number is 10066329
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public ulong? BackgroundColor{ get; set; }

        /// <summary>
        /// Output stream background image for stream mix. Its value is the ID of image uploaded through the TRTC Console.
        /// </summary>
        [JsonProperty("BackgroundImageId")]
        public ulong? BackgroundImageId{ get; set; }

        /// <summary>
        /// Output audio codec for On-Cloud MixTranscoding. Valid values: 0, 1, 2. 0 (default): LC-AAC; 1: HE-AAC; 2: HE-AACv2. If this parameter is set to 2 (HE-AACv2), On-Cloud MixTranscoding can produce only dual-channel streams. If it is set to 1 (HE-AAC) or 2 (HE-AACv2), the valid values for the audio sample rate of output streams are 48000, 44100, 32000, 24000, and 16000.
        /// </summary>
        [JsonProperty("AudioCodec")]
        public ulong? AudioCodec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "AudioCodec", this.AudioCodec);
        }
    }
}

