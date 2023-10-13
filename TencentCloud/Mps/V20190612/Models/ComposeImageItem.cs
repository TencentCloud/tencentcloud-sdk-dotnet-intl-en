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

    public class ComposeImageItem : AbstractModel
    {
        
        /// <summary>
        /// The media information of the element.
        /// </summary>
        [JsonProperty("SourceMedia")]
        public ComposeSourceMedia SourceMedia{ get; set; }

        /// <summary>
        /// The time of the element in the timeline. If this is not specified, the element will follow the previous element.
        /// </summary>
        [JsonProperty("TrackTime")]
        public ComposeTrackTime TrackTime{ get; set; }

        /// <summary>
        /// The horizontal distance of the element's center from the canvas origin. Two formats are supported:
        /// <li>If the value ends with %, it specifies the distance as a percentage of the canvas width. For example, `10%` means that the distance is 10% of the canvas width. </li>
        /// u200c<li>If the value ends with px, it specifies the distance in pixels. For example, `100px` means that the distance is 100 pixels. </li>
        /// Default value: `50%`.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// The vertical distance of the element's center from the canvas origin. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the distance as a percentage of the canvas height. For example, `10%` means that the distance is 10% of the canvas height. </li>
        /// u200c<li>If the value ends with px, it specifies the distance in pixels. For example, `100px` means that the distance is 100 pixels. </li>
        /// Default value: `50%`.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// The width of the video segment. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the width as a percentage of the canvas width. For example, `10%` means that the video width is 10% of the canvas width. </li>
        /// u200c<li>If the value ends with px, it specifies the width in pixels. For example, `100px` means that the video width is 100 pixels. </li>
        /// If one or both parameters are empty or set to `0`:
        /// <li>If both `Width` and `Height` are empty, the original width and height of the element will be kept. </li>
        /// <li>If `Width` is empty and `Height` is not, the width will be auto scaled. </li>
        /// <li>If `Width` is not empty and `Height` is, the height will be auto scaled. </li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// The height of the element. Two formats are supported:
        /// u200c<li>If the value ends with %, it specifies the height as a percentage of the canvas height. For example, `10%` means that the height is 10% of the canvas height. </li>
        /// u200c<li>If the value ends with px, it specifies the height in pixels. For example, `100px` means that the height is 100 pixels. </li>
        /// If one or both parameters are empty or set to `0`:
        /// <li>If both `Width` and `Height` are empty, the original width and height of the video will be kept. </li>
        /// <li>If `Width` is empty and `Height` is not, the width will be auto scaled. </li>
        /// <li>If `Width` is not empty and `Height` is, the height will be auto scaled. </li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// The image operations, such as image rotation.
        /// </summary>
        [JsonProperty("ImageOperations")]
        public ComposeImageOperation[] ImageOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SourceMedia.", this.SourceMedia);
            this.SetParamObj(map, prefix + "TrackTime.", this.TrackTime);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArrayObj(map, prefix + "ImageOperations.", this.ImageOperations);
        }
    }
}

