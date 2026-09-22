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

    public class ComplexAdaptiveDynamicStreamingTaskAudioInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Media ID of the audio source. The first audio stream in the media source file is always used, while video streams and other audio streams (if any) will be ignored.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Audio stream name in the output adaptive bitrate stream. Length limit: 16 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Language of the audio stream in the output adaptive bitrate stream. Length limit: 16 characters. It must comply with RFC5646.</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Whether to set as the default audio for adaptive bitrate. Parameter values:</p><li>YES: set as default audio;</li><li>NO: not set as default audio (default value).</li>
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// <p>Audio track serial number, indicating which audio track in the audio source to select. Counting begins from 0. The default value is 0, which means selecting the audio track positioned towards the front.</p>
        /// </summary>
        [JsonProperty("AudioTrackIdx")]
        public ulong? AudioTrackIdx{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "AudioTrackIdx", this.AudioTrackIdx);
        }
    }
}

