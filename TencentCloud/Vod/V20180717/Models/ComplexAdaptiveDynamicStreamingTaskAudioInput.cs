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
        /// <p>Media ID of the audio source. The first audio stream in the media source file is used by default. The video stream and other audio streams (if any) will be ignored.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Name of the audio stream in the output adaptive bitrate stream. Length limit is 16 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>The language of the audio stream in the output adaptive bitrate stream, with a length limit of 16 characters. It must comply with RFC5646.</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Set as default audio for adaptive bitrate. Value:</p><li>YES: Set as default audio;</li><li>NO: Do not set as default audio (default value).</li>
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// <p>Audio track serial number, which means selecting the nth audio track in the audio source, counting begins from 0. Default value is 0, means selecting the audio track positioned towards the front.</p>
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

