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

    public class OutputAudioStream : AbstractModel
    {
        
        /// <summary>
        /// Encoding format for audio streams. Optional values:
        /// <li>libfdk_aac: suitable for mp4 files.</li>
        /// Default value: libfdk_aac.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Sampling rate of the audio stream. Available values:
        /// <li>16000</li>
        /// <li>32000</li>
        /// <li>44100</li>
        /// <li>48000</li>
        /// Unit: Hz.
        /// Default value: 16000.
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// Number of audio channels. Available values:
        /// <li>1: mono.</li>
        /// <li>2: stereo</li>
        /// Default value: 2.
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// Bitrate of the audio stream. Value range: 0 and [26, 256]. Unit: kbps.
        /// When the value is 0, the audio bitrate is set automatically.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
        }
    }
}

