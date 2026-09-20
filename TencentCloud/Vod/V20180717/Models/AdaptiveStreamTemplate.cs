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

    public class AdaptiveStreamTemplate : AbstractModel
    {
        
        /// <summary>
        /// <p>Video parameter information.</p>
        /// </summary>
        [JsonProperty("Video")]
        public VideoTemplateInfo Video{ get; set; }

        /// <summary>
        /// <p>Audio parameter information.</p>
        /// </summary>
        [JsonProperty("Audio")]
        public AudioTemplateInfo Audio{ get; set; }

        /// <summary>
        /// <p>Indicates whether to remove the audio stream. Value range:</p><li>0: No,</li><li>1: Yes.</li>
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public ulong? RemoveAudio{ get; set; }

        /// <summary>
        /// <p>Indicates whether to remove the video stream. Value range:</p><li>0: No.</li><li>1: Yes.</li>
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public ulong? RemoveVideo{ get; set; }

        /// <summary>
        /// <p>Top Speed Codec transcoding parameters.</p>
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfig TEHDConfig{ get; set; }

        /// <summary>
        /// <p>Audio/video enhancement configurations.</p>
        /// </summary>
        [JsonProperty("EnhanceConfig")]
        public EnhanceConfig EnhanceConfig{ get; set; }

        /// <summary>
        /// <p>Extended parameter.</p>
        /// </summary>
        [JsonProperty("StdExtInfo")]
        public string StdExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Video.", this.Video);
            this.SetParamObj(map, prefix + "Audio.", this.Audio);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamObj(map, prefix + "TEHDConfig.", this.TEHDConfig);
            this.SetParamObj(map, prefix + "EnhanceConfig.", this.EnhanceConfig);
            this.SetParamSimple(map, prefix + "StdExtInfo", this.StdExtInfo);
        }
    }
}

