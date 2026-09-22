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

    public class AudioTrackItem : AbstractModel
    {
        
        /// <summary>
        /// Media material source of the audio recording clip, which can be:
        /// <li>Media file ID for VOD;</li>
        /// <li>Download URL of other media files.</li>
        /// Note: When using the download URL of another media file as the material source and access control (such as hotlink protection) is enabled, the URL needs to carry access control parameters (such as a hotlink protection signature).
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// Start time of the audio clip in the material file, in seconds. 0 means capturing from the start position of the material. Default value: 0.
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// Duration of the audio clip in seconds. Default: same as the material length, which means the entire material is captured.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Target duration of the audio clip, in seconds.
        /// <li>If TargetDuration is not specified or set to 0, it means the target duration is the same as Duration;</li>
        /// <li>When TargetDuration is set to a value more than 0, the audio clip will be fast-forwarded or slowed down to make the output segment duration equal to TargetDuration.</li>
        /// </summary>
        [JsonProperty("TargetDuration")]
        public float? TargetDuration{ get; set; }

        /// <summary>
        /// Operation performed on the audio clip, for example, audio volume adjustment.
        /// </summary>
        [JsonProperty("AudioOperations")]
        public AudioTransform[] AudioOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "SourceMediaStartTime", this.SourceMediaStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "TargetDuration", this.TargetDuration);
            this.SetParamArrayObj(map, prefix + "AudioOperations.", this.AudioOperations);
        }
    }
}

