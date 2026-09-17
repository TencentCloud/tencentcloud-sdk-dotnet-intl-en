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

    public class ModifyEnhanceMediaTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RebuildVideoInfo")]
        public RebuildVideoInfo RebuildVideoInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RebuildAudioInfo")]
        public RebuildAudioInfo RebuildAudioInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TargetVideoInfo")]
        public RebuildMediaTargetVideoStream TargetVideoInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TargetAudioInfo")]
        public RebuildMediaTargetAudioStream TargetAudioInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// 
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

