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

    public class CreateComplexAdaptiveDynamicStreamingTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// The VOD application ID.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Media ID of the main media.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Adaptive bitrate streaming parameters, supporting up to 8 entries.
        /// </summary>
        [JsonProperty("StreamParaSet")]
        public ComplexAdaptiveDynamicStreamingTaskStreamPara[] StreamParaSet{ get; set; }

        /// <summary>
        /// List of video opening/closing credits configuration template IDs, supporting up to 4 entries. If this field is filled in, the start times of the media specified in AudioSet and SubtitleSet will be automatically adjusted to stay in sync with the main media.
        /// </summary>
        [JsonProperty("HeadTailSet")]
        public HeadTailTaskInput[] HeadTailSet{ get; set; }

        /// <summary>
        /// Audio media parameters, supporting up to 16 entries. Each array element corresponds to an audio stream in the output. If you want to add the audio stream from the main media file to the output, you also need to specify it here. The order of elements in the array will determine the order of audio streams in the output. If the input media file contains both video and audio streams, the video stream will be ignored.
        /// </summary>
        [JsonProperty("AudioSet")]
        public ComplexAdaptiveDynamicStreamingTaskAudioInput[] AudioSet{ get; set; }

        /// <summary>
        /// List of subtitle IDs, supporting up to 16 entries. Each array element corresponds to an subtitle stream in the output. The order of elements in the array will determine the order of subtitles in the output.
        /// </summary>
        [JsonProperty("SubtitleSet")]
        public ComplexAdaptiveDynamicStreamingTaskSubtitleInput[] SubtitleSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamArrayObj(map, prefix + "StreamParaSet.", this.StreamParaSet);
            this.SetParamArrayObj(map, prefix + "HeadTailSet.", this.HeadTailSet);
            this.SetParamArrayObj(map, prefix + "AudioSet.", this.AudioSet);
            this.SetParamArrayObj(map, prefix + "SubtitleSet.", this.SubtitleSet);
        }
    }
}

