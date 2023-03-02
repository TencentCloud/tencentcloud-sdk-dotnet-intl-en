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

    public class RebuildMediaTargetVideoStream : AbstractModel
    {
        
        /// <summary>
        /// The video codec. Valid values:
        /// <li>`libx264`: H.264</li>
        /// <li>`libx265`: H.265</li>
        /// <li>`av1`: AOMedia Video 1</li>
        /// The default codec is H.264.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// The video bitrate (Kbps). Value range: 0 and 128-35000.
        /// If the value is `0`, the original video bitrate will be used.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// The video frame rate (Hz). Value range: 0-100. If the value is `0`, the original video frame rate will be used.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>`open`: Enable. When resolution adaption is enabled, `Width` indicates the long side of a video, while `Height` indicates the short side.</li>
        /// <li>`close`: Disable. When resolution adaption is disabled, `Width` indicates the width of a video, while `Height` indicates the height.</li>
        /// 
        /// Default value: `open`.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// The maximum video width (or long side), in pixels. Value range: 0 and 128-8192.
        /// <li>If both `Width` and `Height` are `0`, the original resolution will be used.</li>
        /// <li>If `Width` is 0 and `Height` is not, the video width will be proportionally scaled.</li>
        /// <li>If `Width` is not 0 and `Height` is, the video height will be proportionally scaled.</li>
        /// <li>If neither `Width` nor `Height` is 0, the specified width and height will be used.</li>
        /// 
        /// Default value: `0`.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// The maximum video height (or short side), in pixels. Value range: 0 and 128-8192.
        /// <li>If both `Width` and `Height` are `0`, the original resolution will be used.</li>
        /// <li>If `Width` is 0 and `Height` is not, the video width will be proportionally scaled.</li>
        /// <li>If `Width` is not 0 and `Height` is, the video height will be proportionally scaled.</li>
        /// <li>If neither `Width` nor `Height` is 0, the specified width and height will be used.</li>
        /// 
        /// Default value: `0`.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// The fill mode, which indicates how a video is resized when the video’s original aspect ratio is different from the target aspect ratio. Valid values:
        /// <li>`stretch`: Stretch the image frame by frame to fill the entire screen. The video image may become "squashed" or "stretched" after transcoding.</li>
        /// <li>`black`: Keep the image's original aspect ratio and fill the blank space with black bars.</li>
        /// 
        /// Default value: `stretch`.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// The number of frames between two I-frames. Valid values: 0 and 1-100000.
        /// If this parameter is `0` or left empty, the interval will be determined by the system.
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
        }
    }
}

