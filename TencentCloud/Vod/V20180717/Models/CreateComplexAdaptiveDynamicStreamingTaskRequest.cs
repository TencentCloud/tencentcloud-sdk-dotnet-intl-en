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
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Media ID of the main media file.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Adaptive Bitrate Parameters support a maximum of 8.
        /// </summary>
        [JsonProperty("StreamParaSet")]
        public ComplexAdaptiveDynamicStreamingTaskStreamPara[] StreamParaSet{ get; set; }

        /// <summary>
        /// Credits list, supports multiple opening and ending sequences, with a maximum of 4 supported. If this field is filled, the start time of the media specified in AudioSet and SubtitleSet will automatically adjust to keep synchronized with the main media.
        /// </summary>
        [JsonProperty("HeadTailSet")]
        public HeadTailTaskInput[] HeadTailSet{ get; set; }

        /// <summary>
        /// Multilingual audio stream parameters, supports a maximum of 16. Each array element corresponds to an audio stream in the adaptive bitrate stream. If you need to add the audio stream from the main media file to the output adaptive bitrate stream, you must specify it here. The order of elements in an array determines the order of audio streams in the adaptive bitrate stream. If the input media file contains both video and audio streams, the video stream will be ignored.
        /// </summary>
        [JsonProperty("AudioSet")]
        public ComplexAdaptiveDynamicStreamingTaskAudioInput[] AudioSet{ get; set; }

        /// <summary>
        /// Multilingual subtitle parameters, with a maximum of 16 supported. Each element in an array corresponds to a subtitle stream in the adaptive bitrate stream. The order of elements in an array determines the order of subtitle streams in the adaptive bitrate stream.
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

