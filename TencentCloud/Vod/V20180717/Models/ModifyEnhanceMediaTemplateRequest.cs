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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEnhanceMediaTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Enhance Media Template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// </b>VOD Application ID. If you want to access resources in a sub-app, fill in this field with the sub-app ID; otherwise, don't fill in this field.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Audio and video quality rebirth template name, length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description information, length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Media quality Enhance video control control information.
        /// </summary>
        [JsonProperty("RebuildVideoInfo")]
        public RebuildVideoInfo RebuildVideoInfo{ get; set; }

        /// <summary>
        /// Media quality Enhance audio control control information.
        /// </summary>
        [JsonProperty("RebuildAudioInfo")]
        public RebuildAudioInfo RebuildAudioInfo{ get; set; }

        /// <summary>
        /// Output target video control information.
        /// </summary>
        [JsonProperty("TargetVideoInfo")]
        public RebuildMediaTargetVideoStream TargetVideoInfo{ get; set; }

        /// <summary>
        /// Output target audio control information.
        /// </summary>
        [JsonProperty("TargetAudioInfo")]
        public RebuildMediaTargetAudioStream TargetAudioInfo{ get; set; }

        /// <summary>
        /// Output file encapsulation format, optional values: mp4, flv, hls.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// Whether to remove video data, optional values:
        /// <li>0: Keep</li>
        /// <li>1: Remove</li>
        /// Default value 0.
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Whether to remove audio data, optional values:
        /// <li>0: Keep</li>
        /// <li>1: Remove</li>
        /// Default value 0.
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "RebuildVideoInfo.", this.RebuildVideoInfo);
            this.SetParamObj(map, prefix + "RebuildAudioInfo.", this.RebuildAudioInfo);
            this.SetParamObj(map, prefix + "TargetVideoInfo.", this.TargetVideoInfo);
            this.SetParamObj(map, prefix + "TargetAudioInfo.", this.TargetAudioInfo);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
        }
    }
}

