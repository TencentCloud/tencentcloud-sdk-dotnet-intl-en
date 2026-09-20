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

    public class VideoConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Maximum value of the video stream width (or long edge) in px. Value range: 0 and [128, 1920].
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// 
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Maximum value of the video stream height (or short side). Value range: 0 and [128, 1920]. Unit: px.
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// 
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Resolution adaptation. Available values:
        /// <li>open: enabled. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: closed. At this point, Width represents the width of the video, and Height indicates the height of the video.</li>
        /// 
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Bitrate of the video stream. Value range: 0 and [128, 10000]. Unit: kbps.
        /// When the value is 0, VOD automatically sets the bitrate.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
        }
    }
}

