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

    public class AudioTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Audio stream encoding format.
        /// When the outer parameter Container is mp3, optional values:
        /// <li>libmp3lame.</li>
        /// When the outer parameter Container is ogg or flac, optional values:
        /// <li>flac.</li>
        /// When the outer parameter Container is m4a, valid values are:
        /// <li>libfdk_aac;</li>
        /// <li>libmp3lame;</li>
        /// <li>ac3.</li>
        /// When the outer parameter Container is mp4 or flv, valid values are:
        /// <li>libfdk_aac: more suitable for mp4;</li>
        /// <li>libmp3lame: more suitable for flv;</li>
        /// <li>mp2.</li>
        /// When the outer parameter Container is hls, valid values are:
        /// <li>libfdk_aac.</li>
        /// When the outer parameter Format is HLS or MPEG-DASH, valid values are:
        /// <li>libfdk_aac.</li>
        /// When the outer parameter Container is wav, valid values are:
        /// <li>pcm16.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Bitrate of the audio stream. Value range: 0 and [26, 256]. Unit: kbps.
        /// When the value is 0, it means VOD automatically sets the bitrate.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Sampling rate of the audio stream. Available values:
        /// <li>16000, selectable only when Codec is pcm16.</li>
        /// <li>32000</li>
        /// <li>44100</li>
        /// <li>48000</li>
        /// Unit: Hz.
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// Audio channel. Valid values:
        /// <li>1: single channel.</li>
        /// <li>2: dual channel.</li>
        /// <li>6: Stereo.</li>
        /// <li>0: The number of audio channels remains the same as the original audio</li>
        /// When the media encapsulation format is audio (flac, ogg, mp3, and m4a), the number of channels cannot be set to stereo.
        /// Default value: 2.
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
        }
    }
}

