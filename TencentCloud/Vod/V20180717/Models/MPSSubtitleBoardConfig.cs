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

    public class MPSSubtitleBoardConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Subtitle suppression module background configuration switch, 0 for off, 1 for on, default 0</p>
        /// </summary>
        [JsonProperty("SubtitleBoardConfigSwitch")]
        public long? SubtitleBoardConfigSwitch{ get; set; }

        /// <summary>
        /// <p>The X-coordinate position of the subtitle background base plate. Supports pixel and percentage formats: - Pixel: Npx, where N ranges from [-4096, 4096]. - Percentage: N%, where N ranges from [-100, 100]; for example, 10% means the X-coordinate of the subtitle background base plate equals 10% of the source video width. Default value: 0px. Note: The origin of the coordinate axes is located at the bottom of the central axis of the source video, and the reference point of the subtitle base plate is at the bottom of its central axis. See the following diagram: <img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></p>
        /// </summary>
        [JsonProperty("BoardX")]
        public long? BoardX{ get; set; }

        /// <summary>
        /// <p>BoardX unit, 0 pixel, 1 percentage, default is 0, pixel</p>
        /// </summary>
        [JsonProperty("BoardXUnit")]
        public long? BoardXUnit{ get; set; }

        /// <summary>
        /// <p>Y-coordinate position of the subtitle background base plate. Supports pixel and percentage formats: - Pixel: Npx, where N ranges from [0,4096]. - Percentage: N%, where N ranges from [0,100]. For example, 10% means the subtitle background base plate Y-coordinate = 10% * source video height. If not specified, the subtitle background base plate is disabled. Note: The coordinate axis origin is located at the bottom of the central axis of the source video, and the reference point of the subtitle background base plate is at the bottom of its central axis. Refer to the figure below: <img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></p>
        /// </summary>
        [JsonProperty("BoardY")]
        public long? BoardY{ get; set; }

        /// <summary>
        /// <p>BoardY measurement unit, 0 pixel, 1 percentage, defaults to 0, pixel</p>
        /// </summary>
        [JsonProperty("BoardYUnit")]
        public long? BoardYUnit{ get; set; }

        /// <summary>
        /// <p>Width of the base plate, a positive integer. - When representing pixels, value ranges from 0 to 4096. - When representing a percentage, value ranges from 0 to 100. If background is enabled and this parameter is not specified, the default width is 90% of the source video width.</p>
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// <p>Background width measurement unit. 0: pixel, 1: percentage. Default is 0 (pixel).</p>
        /// </summary>
        [JsonProperty("BoardWidthUnit")]
        public long? BoardWidthUnit{ get; set; }

        /// <summary>
        /// <p>Height of the base plate, a positive integer. - When representing pixels, the value ranges from 0 to 4096. - When representing a percentage, the value ranges from 0 to 100. If base plate is enabled and this parameter is not specified, the default height is 15% of the source video height.</p>
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// <p>Base plate height unit, 0 pixel, 1 percentage, defaults to 0, pixel</p>
        /// </summary>
        [JsonProperty("BoardHeightUnit")]
        public long? BoardHeightUnit{ get; set; }

        /// <summary>
        /// <p>Base plate color. Format: 0xRRGGBB. Default value: 0x000000 (black).</p>
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// <p>Subtitle background transparency. Value range: [0, 1] <li>0: completely transparent</li> <li>1: completely opaque</li> Default value: 0.8.</p>
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleBoardConfigSwitch", this.SubtitleBoardConfigSwitch);
            this.SetParamSimple(map, prefix + "BoardX", this.BoardX);
            this.SetParamSimple(map, prefix + "BoardXUnit", this.BoardXUnit);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "BoardYUnit", this.BoardYUnit);
            this.SetParamSimple(map, prefix + "BoardWidth", this.BoardWidth);
            this.SetParamSimple(map, prefix + "BoardWidthUnit", this.BoardWidthUnit);
            this.SetParamSimple(map, prefix + "BoardHeight", this.BoardHeight);
            this.SetParamSimple(map, prefix + "BoardHeightUnit", this.BoardHeightUnit);
            this.SetParamSimple(map, prefix + "BoardColor", this.BoardColor);
            this.SetParamSimple(map, prefix + "BoardAlpha", this.BoardAlpha);
        }
    }
}

