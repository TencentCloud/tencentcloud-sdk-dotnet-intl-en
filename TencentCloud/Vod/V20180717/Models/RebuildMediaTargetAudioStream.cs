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

    public class RebuildMediaTargetAudioStream : AbstractModel
    {
        
        /// <summary>
        /// The audio codec.
        /// If `Container` is `mp3`, the valid value is:
        /// <li>`libmp3lame`</li>
        /// If `Container` is `ogg` or `flac`, the valid value is:
        /// <li>`flac`</li>
        /// If `Container` is `m4a`, the valid values are:
        /// <li>`libfdk_aac`</li>
        /// <li>`libmp3lame`</li>
        /// <li>`ac3`</li>
        /// If `Container` is `mp4` or `flv`, the valid values are:
        /// <li>`libfdk_aac` (Recommended for MP4)</li>
        /// <li>`libmp3lame` (Recommended for FLV)</li>
        /// <li>`mp2`</li>
        /// If `Container` is `hls`, the valid value is:
        /// <li>`libfdk_aac`</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// The audio bitrate, in Kbps. Value range: 0 and 26-256.
        /// If the value is `0`, the original audio bitrate will be used.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// The audio sample rate. Valid values:
        /// <li>`32000`</li>
        /// <li>`44100`</li>
        /// <li>`48000`</li>
        /// 
        /// Unit: Hz.
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// The audio channels. Valid values:
        /// <li>`1`: Mono-channel</li>
        /// <li>`2`: Dual-channel</li>
        /// <li>`6`: Stereo</li>
        /// 
        /// You cannot set this parameter to `6` if the container format is an audio format (FLAC, OGG, MP3, M4A).
        /// Default value: `2`.
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

