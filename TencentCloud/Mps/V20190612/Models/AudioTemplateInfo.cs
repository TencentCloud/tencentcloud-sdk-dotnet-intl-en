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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Audio stream encoding format.
        /// When audio transcoding is not needed, the value is:
        /// <li>copy.</li>
        /// When the outer parameter Container is mp3, the value is:
        /// <li>mp3.</li>
        /// When the outer parameter Container is ogg or flac, the value is:
        /// <li>flac.</li>
        /// When the outer parameter Container is m4a, valid values are:
        /// <li>aac;</li>
        /// <li>ac3.</li>
        /// When the outer parameter Container is mp4 or flv, valid values are:
        /// <li>aac: more suitable for mp4;</li>
        /// <li>mp3: more suitable for flv;</li>
        /// <li>mp2.</li>
        /// When the outer parameter Container is hls, valid values are:
        /// <li>aac;</li>
        /// <li>mp3.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Audio stream bitrate in Kbps. Value range: 0 and [26, 256].
        /// If the value is 0, the bitrate of the audio stream will be the same as that of the original audio.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Audio stream sample rate. Valid values:
        /// <li>32,000</li>
        /// <li>44,100</li>
        /// <li>48,000</li>
        /// In Hz.
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// Audio channel mode. Valid values:
        /// <li>1: single channel.</li>
        /// <li>2: dual channel.</li>
        /// <li>6: 5.1 surround sound.</li>
        /// When the media encapsulation format is audio (flac, ogg, mp3, and m4a), the number of channels cannot be set to 5.1 surround sound.
        /// Default value: 2.
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// Merge audio track information.
        /// This field only takes effec in adaptive bitrate transcoding.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TrackChannelInfo")]
        public AudioTrackChannelInfo TrackChannelInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamObj(map, prefix + "TrackChannelInfo.", this.TrackChannelInfo);
        }
    }
}

