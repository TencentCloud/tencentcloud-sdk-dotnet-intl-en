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

    public class SvgWatermarkInputForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Watermark width, which supports six formats of px, %, W%, H%, S%, and L%:
        /// <li>If the string ends in px, the `Width` of the watermark will be in px; for example, `100px` means that `Width` is 100 px; if `0px` is entered
        ///  and `Height` is not `0px`, the watermark width will be proportionally scaled based on the source SVG image; if `0px` is entered for both `Width` and `Height`, the watermark width will be the width of the source SVG image;</li>
        /// <li>If the string ends in `W%`, the `Width` of the watermark will be the specified percentage of the video width; for example, `10W%` means that `Width` is 10% of the video width;</li>
        /// <li>If the string ends in `H%`, the `Width` of the watermark will be the specified percentage of the video height; for example, `10H%` means that `Width` is 10% of the video height;</li>
        /// <li>If the string ends in `S%`, the `Width` of the watermark will be the specified percentage of the short side of the video; for example, `10S%` means that `Width` is 10% of the short side of the video;</li>
        /// <li>If the string ends in `L%`, the `Width` of the watermark will be the specified percentage of the long side of the video; for example, `10L%` means that `Width` is 10% of the long side of the video;</li>
        /// <li>If the string ends in %, the meaning is the same as `W%`.</li>
        /// Default value: 10W%.
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Watermark height, which supports six formats of px, %, W%, H%, S%, and L%:
        /// <li>If the string ends in px, the `Height` of the watermark will be in px; for example, `100px` means that `Height` is 100 px; if `0px` is entered
        ///  and `Width` is not `0px`, the watermark height will be proportionally scaled based on the source SVG image; if `0px` is entered for both `Width` and `Height`, the watermark height will be the height of the source SVG image;</li>
        /// <li>If the string ends in `W%`, the `Height` of the watermark will be the specified percentage of the video width; for example, `10W%` means that `Height` is 10% of the video width;</li>
        /// <li>If the string ends in `H%`, the `Height` of the watermark will be the specified percentage of the video height; for example, `10H%` means that `Height` is 10% of the video height;</li>
        /// <li>If the string ends in `S%`, the `Height` of the watermark will be the specified percentage of the short side of the video; for example, `10S%` means that `Height` is 10% of the short side of the video;</li>
        /// <li>If the string ends in `L%`, the `Height` of the watermark will be the specified percentage of the long side of the video; for example, `10L%` means that `Height` is 10% of the long side of the video;</li>
        /// <li>If the string ends in %, the meaning is the same as `H%`.
        /// Default value: 0 px.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Watermark cycle configuration, which is used to configure watermarks so that they will be displayed and hidden periodically.
        /// Primary use case: watermarks can be added at various positions in a video, which are displayed and hidden periodically to prevent them from being covered.
        /// For example, watermarks A, B, C, and D are set in the top-left corner, top-right corner, bottom-right corner, and bottom-left corner of a video, respectively. After the first video frame, { A will be displayed for 5s -> B for 5s -> C for 5s -> D for 5s } -> A for 5s -> B for 5s -> ... Only one watermark will be visible at any time.
        /// Within the braces ({}) is a major cycle composed of four watermarks, namely, A, B, C, and D, which lasts for 20 seconds in a cycle.
        /// Watermarks A, B, C, and D are displayed periodically for 5 seconds and hidden for 15 seconds each in a fixed order.
        /// This configuration item is used to describe the cycle configuration of a single watermark.
        /// </summary>
        [JsonProperty("CycleConfig")]
        public WatermarkCycleConfigForUpdate CycleConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamObj(map, prefix + "CycleConfig.", this.CycleConfig);
        }
    }
}

