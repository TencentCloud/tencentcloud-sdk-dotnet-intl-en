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

    public class VideoConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// The maximum value of the video stream width (or long side), value range: 0 and [128, 1920], unit: px. 
        /// <li>When Width and Height are both 0, the resolution is from the same source;</li>
        /// <li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li>
        /// < li>When Width is non-0 and Height is 0, the Height is scaled proportionally; </li>
        /// <li>When both Width and Height are non-0, the resolution is specified by the user. </li>
        /// 
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// The maximum value of the video stream height (or short side), value range: 0 and [128, 1920], unit: px. 
        /// <li>When Width and Height are both 0, the resolution is from the same source;</li>
        /// <li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li>
        /// < li>When Width is non-0 and Height is 0, the Height is scaled proportionally; </li>
        /// <li>When both Width and Height are non-0, the resolution is specified by the user. </li>
        /// 
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Resolution adaptive, optional values:
        /// <li>open: open, at this time, Width represents the long side of the video, and Height represents the short side of the video;</li>
        /// <li>close: closed, at this time , Width represents the width of the video, and Height represents the height of the video. </li>
        /// 
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// The bit rate of the video stream, value range: 0 and [128, 10000], unit: kbps. 
        /// When the value is 0, it means that the video bitrate remains the same as the original video.
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

