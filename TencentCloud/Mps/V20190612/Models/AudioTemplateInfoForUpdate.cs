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

    public class AudioTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// <p>Audio stream encoding format.<br>When audio transcoding is not needed, the valid value is:</p><li>copy.</li>When the outer parameter Container is mp3, the valid value is:<li>mp3.</li>When the outer parameter Container is ogg or flac, the valid value is:<li>flac.</li>When the outer parameter Container is m4a, the valid values are:<li>aac;</li><li>ac3.</li>When the outer parameter Container is mp4 or flv, the valid values are:<li>aac: suitable for mp4.</li><li>mp3: suitable for flv.</li><li>mp2.</li>When the outer parameter Container is hls, the valid values are:<li>aac.</li><li>mp3.</li>When the outer parameter Container is wav, the valid values are:<li>pcm16 and pcm24.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// <p>Audio stream bitrate, in kbps. Value range: 0 and [26, 256]. When the value is 0, it means the audio bitrate remains consistent with that of the original audio.</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// <p>Audio stream sampling rate. Different sampling rate options are provided for different encoding standards. Enter 0 to use the source audio sampling rate.<br>For details, see <a href="https://www.tencentcloud.com/document/product/862/77166?from_cn_redirect=1#f3b039f1-d817-4a96-b4e4-90132d31cd53">Audio Sampling Rate Range</a>.<br>Unit: Hz.<br>Note: Ensure the source audio stream sampling rate is within the supported range. Otherwise, transcoding may fail.</p>
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// <p>Audio channel mode. Valid values:</p><li>0: The number of audio channels follows that of the source.</li><li>1: Single channel.</li><li>2: Two channels.</li><li>6: 5.1 channels.</li>When the media container format is an audio format (mp3), the number of audio channels cannot be set to 5.1.<p>Default value: 2.<br>Note: If you set the audio channel to follow that of the source and the audio encoding format does not support the current audio channel, the transcoding task may fail.</p>
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// <p>Specifies the retained audio tracks for output. All source tracks are retained by default.</p>
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

