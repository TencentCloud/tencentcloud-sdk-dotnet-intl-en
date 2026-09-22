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

    public class MosaicInput : AbstractModel
    {
        
        /// <summary>
        /// Origin position. Currently only support:
        /// <li>TopLeft: indicates that the coordinate origin is at the top left corner of the video image and the mosaic origin is at the top left corner of the image or text.</li>
        /// Default value: TopLeft.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// Horizontal position of the mosaic origin relative to the origin of coordinates of the video image. Supports two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `XPos` of a mosaic is a specified percentage of a video's width. For example, `10%` means that `XPos` is 10% of a video's width.</li>
        /// <li>If a string ends with px, it means the mosaic XPos is specified in pixels. For example, 100px means XPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the mosaic origin relative to the origin of coordinates of the video image. Supports two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `YPos` of a mosaic is a specified percentage of a video's height. For example, `10%` means that `YPos` is 10% of a video's height.</li>
        /// <li>If a string ends with px, it means the mosaic YPos is specified in pixels. For example, 100px means the YPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Width of the mosaic, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Width` of a mosaic is a percentage of a video's width. For example, `10%` means that `Width` is 10% of a video's width.</li>
        /// <li>If a string ends with px, it means the mosaic Width unit is pixel. For example, 100px means the Width is 100 pixels.</li>
        /// Default value: 10%.
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Height of a mosaic, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Height` of a mosaic is a percentage of a video's height. For example, `10%` means that `Height` is 10% of a video's height.</li>
        /// <li>If a string ends with px, it means the mosaic Height unit is pixel. For example, 100px means the Height is 100 pixels.</li>
        /// Default value: 10%.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Start time offset of a mosaic, in seconds. If not set or set to 0, a mosaic starts appearing when a video starts.
        /// <li>If not set or set to 0, a mosaic appears when a video starts.</li>
        /// <li>If the value is greater than 0 (for example, n), a mosaic will appear at second n of a frame.</li>
        /// <li>When the value is less than 0 (assuming -n), it means the mosaic appears n seconds before the end of a video.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a mosaic, in seconds.
        /// <li>If not set or set to 0, mosaic will last until the end of a frame.</li>
        /// <li>If the value is greater than 0 (for example, n), a mosaic will disappear at second n.</li>
        /// <li>When the value is less than 0 (assuming -n), it means the mosaic lasts until n seconds before the end of a video.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

