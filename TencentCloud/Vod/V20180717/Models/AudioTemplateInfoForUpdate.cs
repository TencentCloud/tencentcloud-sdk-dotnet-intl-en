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

    public class AudioTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// <p>Audio stream encoding format.<br>When the outer parameter Container is mp3, the valid value is:</p><li>libmp3lame.</li>When the outer parameter Container is ogg or flac, the valid value is:<li>flac.</li>When the outer parameter Container is m4a, the valid values are:<li>libfdk_aac;</li><li>libmp3lame;</li><li>ac3.</li>When the outer parameter Container is mp4 or flv, the valid values are:<li>libfdk_aac: suitable for mp4.</li><li>libmp3lame: suitable for flv.</li><li>mp2.</li>When the outer parameter Container is hls, the valid value is:<li>libfdk_aac.</li>When the outer parameter Format is HLS or MPEG-DASH, the valid value is:<li>libfdk_aac.</li>When the outer parameter Container is wav, the valid value is:<li>pcm16.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// <p>Audio stream bitrate, in kbps. Value range: 0 and [26, 256]. When the value is 0, it means the bitrate is set automatically by VOD.</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// <p>Sampling rate of the audio stream. Available values:</p><li>16000. Available only when Codec is pcm16.</li><li>32000</li><li>44100</li><li>48000</li>Unit: Hz.
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// <p>Audio channel. Available values:</p><li>1: Single channel.</li><li>2: Two channels.</li><li>6: Stereo.</li><li>0: The number of audio channels remains the same as the original audio.</li>When the media container format is an audio format (flac, ogg, mp3, m4a), the number of audio channels cannot be set to stereo.
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// <p>Specifies the retained audio tracks for output. All source tracks are retained. </p><p>This parameter is valid only when specified in the OverrideParameter parameter and is disabled in other cases.</p>
        /// </summary>
        [JsonProperty("StreamSelects")]
        public long?[] StreamSelects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamArraySimple(map, prefix + "StreamSelects.", this.StreamSelects);
        }
    }
}

