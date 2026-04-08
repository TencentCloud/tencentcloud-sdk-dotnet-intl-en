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

    public class SubtitleBoardConfig : AbstractModel
    {
        
        /// <summary>
        /// Subtitle suppression module background configuration switch, 0 for off, 1 for on, default 0
        /// </summary>
        [JsonProperty("SubtitleBoardConfigSwitch")]
        public long? SubtitleBoardConfigSwitch{ get; set; }

        /// <summary>
        /// Subtitle background base plate x-axis coordinate position; Supports pixel and percentage format:
        /// 
        /// - Pixel: Npx. Value range of N: [-4096,4096].
        /// -Percentage: N%, N range: [-100,100]. For example, 10% means the X-coordinate of the subtitle background base plate is 10% of the source video width.
        /// 
        /// Default value: 0px.
        /// Note: The origin of the coordinate axes is at the bottom of the central axis of the source video, and the reference position of the subtitle base plate is at the bottom of the central axis, as shown in the figure below.
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// </summary>
        [JsonProperty("BoardX")]
        public long? BoardX{ get; set; }

        /// <summary>
        /// BoardX unit, 0 pixel, 1 percentage, default is 0, pixel
        /// </summary>
        [JsonProperty("BoardXUnit")]
        public long? BoardXUnit{ get; set; }

        /// <summary>
        /// Subtitle background base plate y-axis coordinate position; Supports pixel and percentage format:
        /// 
        /// - Pixel: Npx. Value range of N: [0,4096].
        /// -Percentage: N%, where N ranges from [0,100]. For example, 10% means the y-coordinate of the subtitle background base plate equals 10% of the video height.
        /// 
        /// If this parameter is not specified, the subtitle background is disabled.
        /// Note: The origin point of the coordinate axis is located at the bottom of the central axis of the source video, and the benchmark of the subtitle background base plate is at the bottom of its central axis. See the following diagram.
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// </summary>
        [JsonProperty("BoardY")]
        public long? BoardY{ get; set; }

        /// <summary>
        /// BoardY unit, 0 pixel, 1 percentage, default is 0, pixel
        /// </summary>
        [JsonProperty("BoardYUnit")]
        public long? BoardYUnit{ get; set; }

        /// <summary>
        /// Background width. The value should be a positive integer.
        /// - Value range for pixels: [0,4096].
        /// - Value range for percentages: [0, 100].
        /// If the base plate is enabled and this parameter is not specified, the default width is 90% of the source video width.
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// Background width measurement unit. 0: pixel, 1: percentage. Default is 0 (pixel).
        /// </summary>
        [JsonProperty("BoardWidthUnit")]
        public long? BoardWidthUnit{ get; set; }

        /// <summary>
        /// Background height. The value should be a positive integer.
        /// - Value range for pixels: [0,4096].
        /// - Value range for percentages: [0, 100].
        /// If the base plate is enabled and this parameter is not specified, the default height is 15% of the source video height.
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// Base plate height unit, 0 pixel, 1 percentage, defaults to 0, pixel
        /// </summary>
        [JsonProperty("BoardHeightUnit")]
        public long? BoardHeightUnit{ get; set; }

        /// <summary>
        /// Board color. Format: 0xRRGGBB.
        /// Default value: 0x000000 (black).
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// Subtitle background transparency. Value range: [0, 1].
        /// <li>0: completely transparent.</li>
        /// <li>1: completely opaque.</li>
        /// Default value: 0.8.
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

