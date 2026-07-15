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

    public class AddOnAudio : AbstractModel
    {
        
        /// <summary>
        /// <p>Audio file input information. Note: (1) Supported audio stream encoding formats: AAC, AC3, EAC3, FLAC, Opus, and MP3. (2) If the segment type set in the adaptive bitrate streaming template is TS, the audio stream encoding format cannot be FLAC.</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>Audio track name, such as Chinese or English. Note: Only Chinese characters, letters, digits, spaces, underscores (_), hyphens (-), periods (.), and brackets are supported. The length cannot exceed 64 characters.</p>
        /// </summary>
        [JsonProperty("AudioName")]
        public string AudioName{ get; set; }

        /// <summary>
        /// <p>Audio track language, such as chi or eng. This follows the ISO 639-2 standard.</p>
        /// </summary>
        [JsonProperty("AudioLanguage")]
        public string AudioLanguage{ get; set; }

        /// <summary>
        /// <p>Default audio track. When set to true, the current audio is designated as the default audio track. A maximum of 1 default audio track can be specified.</p><p>Default value: false.</p>
        /// </summary>
        [JsonProperty("DefaultTrack")]
        public bool? DefaultTrack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "AudioName", this.AudioName);
            this.SetParamSimple(map, prefix + "AudioLanguage", this.AudioLanguage);
            this.SetParamSimple(map, prefix + "DefaultTrack", this.DefaultTrack);
        }
    }
}

