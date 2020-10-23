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

    public class ModifyTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of a transcoding template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Container format. Valid values: mp4; flv; hls; mp3; flac; ogg; m4a. Among them, mp3, flac, ogg, and m4a are for audio files.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// Name of a transcoding template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Whether to remove video data. Valid values:
        /// <li>0: Retain</li>
        /// <li>1: Remove</li>
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Whether to remove audio data. Valid values:
        /// <li>0: Retain</li>
        /// <li>1: Remove</li>
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// Video stream configuration parameter.
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfoForUpdate VideoTemplate{ get; set; }

        /// <summary>
        /// Audio stream configuration parameter.
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfoForUpdate AudioTemplate{ get; set; }

        /// <summary>
        /// TESHD transcoding parameter. To enable it, please contact your Tencent Cloud sales rep.
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfigForUpdate TEHDConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamObj(map, prefix + "VideoTemplate.", this.VideoTemplate);
            this.SetParamObj(map, prefix + "AudioTemplate.", this.AudioTemplate);
            this.SetParamObj(map, prefix + "TEHDConfig.", this.TEHDConfig);
        }
    }
}

