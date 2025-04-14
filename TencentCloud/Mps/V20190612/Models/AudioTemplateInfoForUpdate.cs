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

    public class AudioTemplateInfoForUpdate : AbstractModel
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
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Audio stream bitrate in Kbps. Value range: 0 and [26, 256]. If the value is 0, the bitrate of the audio stream will be the same as that of the original audio.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// The sampling rate of the audio stream. the supported sampling rate options vary for different encoding standards. for details, see audio sampling rate support scope document https://intl.cloud.tencent.com/document/product/862/77166?from_cn_redirect=1#f3b039f1-d817-4a96-b4e4-90132d31cd53.
        /// Please ensure that the sampling rate of the source audio stream is within the value range of the above options. otherwise, transcoding failure may occur.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// Audio channel mode. Valid values:
        /// <li>1: single channel.</li>
        /// <li>2: dual channel.</li>
        /// <li>6: 5.1 surround sound.</li>
        /// When the media encapsulation format is audio (flac, ogg, mp3, and m4a), the number of channels cannot be set to 5.1 surround sound.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// The audio tracks to retain. All audio tracks are retained by default.
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

