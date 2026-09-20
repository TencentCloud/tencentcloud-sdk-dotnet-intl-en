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
        /// Media material source of the audio clip, which can be:
        /// <li>Media file ID for VOD;</li>
        /// <li>Download URL of other media files.</li>
        /// Note: When using the download URL of another media file as the material source and access control (such as anti-leech) is enabled, the URL needs to carry access control parameters (such as an anti-leech signature).
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// The start time of the audio clip in the material file, in seconds. 0 means to capture from the start position of the material. Default value: 0.
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// Duration of the audio clip in seconds. Defaults to the length of the material itself, which means the entire material is captured.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Target duration of the audio clip in seconds.
        /// <li>If TargetDuration is not specified or set to 0, it means the target duration is the same as Duration;</li>
        /// <li>When TargetDuration is set to a value more than 0, the audio clip will be fast-forwarded or slowed down so that the duration of the output segment equals TargetDuration.</li>
        /// </summary>
        [JsonProperty("TargetDuration")]
        public float? TargetDuration{ get; set; }

        /// <summary>
        /// Operation performed on the audio clip, such as volume adjustment.
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

