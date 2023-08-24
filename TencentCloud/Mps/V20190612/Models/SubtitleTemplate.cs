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

    public class SubtitleTemplate : AbstractModel
    {
        
        /// <summary>
        /// The URL of the subtitles to add to the video.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// The subtitle track to add to the video. If both `Path` and `StreamIndex` are specified, `Path` will be used. You need to specify at least one of the two parameters.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// The font. Valid values:
        /// <li>`hei.ttf`: Heiti.</li>
        /// <li>`song.ttf`: Songti.</li>
        /// <li>`simkai.ttf`: Kaiti.</li>
        /// <li>`arial.ttf`: Arial.</li>
        /// The default is `hei.ttf`.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// The font size (pixels). If this is not specified, the font size in the subtitle file will be used.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// The font color in 0xRRGGBB format. Default value: 0xFFFFFF (white).
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// The text transparency. Value range: 0-1.
        /// <li>`0`: Fully transparent.</li>
        /// <li>`1`: u200dFully opaque.</li>
        /// Default value: 1.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "StreamIndex", this.StreamIndex);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
        }
    }
}

