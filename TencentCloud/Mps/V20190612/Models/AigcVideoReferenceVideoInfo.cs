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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcVideoReferenceVideoInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>url of the reference video. It must be accessible from the external network.<br>It can be used as a feature reference video or a video for editing. By default, it is a video for editing. You can selectively retain the original sound of the video.<br>The ReferType parameter specifies the reference video type: feature indicates feature reference video, and base indicates video for editing.<br>When the reference video is a video for editing, you cannot define the first and last frame of the video.</p>
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// <p>The ReferType parameter specifies the reference video type: feature indicates feature reference video, and base indicates video for editing.</p>
        /// </summary>
        [JsonProperty("ReferType")]
        public string ReferType{ get; set; }

        /// <summary>
        /// <p>The KeepOriginalSound parameter specifies whether to keep the original sound of the video. Valid values: yes (keep the original sound); no (remove the original sound). This parameter also applies to feature reference videos (feature).</p>
        /// </summary>
        [JsonProperty("KeepOriginalSound")]
        public string KeepOriginalSound{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "ReferType", this.ReferType);
            this.SetParamSimple(map, prefix + "KeepOriginalSound", this.KeepOriginalSound);
        }
    }
}

