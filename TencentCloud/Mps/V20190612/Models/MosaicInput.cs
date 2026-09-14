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

    public class MosaicInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Origin position. Currently, only the following is supported:</p><li>TopLeft: indicates that the coordinate origin is at the top left corner of the video image and the mosaic origin is at the top left corner of the image or text.</li>Default value: TopLeft.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// <p>Horizontal position of the mosaic origin relative to the origin of coordinates of the video image. Supports two formats: % and px:</p><li>If a string ends with %, the mosaic XPos is a specified percentage of the video width. For example, 10% means XPos is 10% of the video width;</li><li>If a string ends with px, the mosaic XPos is a specified pixel. For example, 100px means XPos is 100 pixels.</li>Default value: 0px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// <p>Vertical position of the mosaic origin relative to the origin of coordinates of the video image. Supports two formats: % and px:</p><li>If a string ends with %, the mosaic YPos is the specified percentage of the video height. For example, 10% means YPos is 10% of the video height.</li><li>If a string ends with px, the mosaic YPos is the specified pixel. For example, 100px means YPos is 100 pixels.</li>Default value: 0px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// <p>Mosaic width. Supports two formats: % and px:</p><li>If a string ends with %, it indicates that the mosaic `Width` is a percentage of a video's width. For example, `10%` means that `Width` is 10% of a video's width.</li><li>If a string ends with px, it indicates that the mosaic `Width` is in pixels. For example, `100px` means that `Width` is 100 pixels.</li>Default value: 10%.
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// <p>Height of a mosaic. Two formats are supported: % and px.</p><li>If a string ends with %, it indicates that the `Height` of a mosaic is a percentage of a video's height. For example, `10%` means that `Height` is 10% of a video's height.</li><li>If a string ends with px, it indicates that the `Height` of a mosaic is in pixels. For example, `100px` means that `Height` is 100 pixels.</li>Default value: 10%.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// <p>Start time offset of mosaic, in seconds. If not specified or set to 0, the mosaic appears when the frame appears.</p><li>If not specified or set to 0, the mosaic appears from the start of the frame;</li><li>If the value is greater than 0 (assuming n), the mosaic appears at the nth second from the start of the frame;</li><li>If the value is less than 0 (assuming -n), the mosaic appears n seconds before the end of the frame.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// <p>End time offset of mosaic, in seconds.</p><li>If not specified or set to 0, the mosaic lasts until the end of a video;</li><li>If the value is greater than 0 (assuming n), the mosaic disappears at second n;</li><li>If the value is less than 0 (assuming -n), the mosaic disappears n seconds before the end of a video.</li>
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

