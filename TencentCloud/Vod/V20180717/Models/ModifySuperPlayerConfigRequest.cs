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

    public class ModifySuperPlayerConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AudioVideoType")]
        public string AudioVideoType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DrmSwitch")]
        public string DrmSwitch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingDefinition")]
        public ulong? AdaptiveDynamicStreamingDefinition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DrmStreamingsInfo")]
        public DrmStreamingsInfoForUpdate DrmStreamingsInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TranscodeDefinition")]
        public ulong? TranscodeDefinition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageSpriteDefinition")]
        public ulong? ImageSpriteDefinition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResolutionNames")]
        public ResolutionNameInfo[] ResolutionNames{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AudioVideoType", this.AudioVideoType);
            this.SetParamSimple(map, prefix + "DrmSwitch", this.DrmSwitch);
            this.SetParamSimple(map, prefix + "AdaptiveDynamicStreamingDefinition", this.AdaptiveDynamicStreamingDefinition);
            this.SetParamObj(map, prefix + "DrmStreamingsInfo.", this.DrmStreamingsInfo);
            this.SetParamSimple(map, prefix + "TranscodeDefinition", this.TranscodeDefinition);
            this.SetParamSimple(map, prefix + "ImageSpriteDefinition", this.ImageSpriteDefinition);
            this.SetParamArrayObj(map, prefix + "ResolutionNames.", this.ResolutionNames);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

