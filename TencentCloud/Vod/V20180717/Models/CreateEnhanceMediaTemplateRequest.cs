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

    public class CreateEnhanceMediaTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Container format. Valid values: mp4, flv, and hls.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Audio and video quality rebirth template name, with a length limit of 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Audio-visual quality revival video control information.
        /// </summary>
        [JsonProperty("RebuildVideoInfo")]
        public RebuildVideoInfo RebuildVideoInfo{ get; set; }

        /// <summary>
        /// Audio-visual quality revival audio control information.
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
        /// Whether to remove video data. Available values:
        /// <li>`0`: reserved</li>
        /// <li>1: Remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Remove audio data. Available values:
        /// <li>`0`: reserved</li>
        /// <li>1: Remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "RebuildVideoInfo.", this.RebuildVideoInfo);
            this.SetParamObj(map, prefix + "RebuildAudioInfo.", this.RebuildAudioInfo);
            this.SetParamObj(map, prefix + "TargetVideoInfo.", this.TargetVideoInfo);
            this.SetParamObj(map, prefix + "TargetAudioInfo.", this.TargetAudioInfo);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
        }
    }
}

