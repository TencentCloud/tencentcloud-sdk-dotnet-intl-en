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

    public class EraseArea : AbstractModel
    {
        
        /// <summary>
        /// X-axis coordinate of the upper left corner of the region.
        /// For example, when Unit is set to 1, which means using the percentage unit, 0.05 indicates that the horizontal distance from the top-left corner of the region to the top-left corner of the entire frame is 5% of the frame width.
        /// </summary>
        [JsonProperty("LeftTopX")]
        public float? LeftTopX{ get; set; }

        /// <summary>
        /// Y-axis coordinate of the upper left corner.
        /// For example, when Unit is set to 1, which means using the percentage unit, 0.1 indicates that the vertical distance from the top-left corner of the region to the top-left corner of the entire frame is 10% of the frame height.
        /// </summary>
        [JsonProperty("LeftTopY")]
        public float? LeftTopY{ get; set; }

        /// <summary>
        /// X-axis coordinate of the bottom-right corner of the region.
        /// For example, when Unit is set to 1, which means using the percentage unit, 0.75 indicates that the horizontal distance from the bottom-right corner of the region to the top-left corner of the entire frame is 75% of the frame width.
        /// </summary>
        [JsonProperty("RightBottomX")]
        public float? RightBottomX{ get; set; }

        /// <summary>
        /// Y-axis coordinate of the bottom-right corner of the region.
        /// For example, when Unit is set to 1, which means using the percentage unit, 0.9 indicates that the vertical distance from the bottom-right corner of the region to the top-left corner of the entire frame is 90% of the frame height.
        /// </summary>
        [JsonProperty("RightBottomY")]
        public float? RightBottomY{ get; set; }

        /// <summary>
        /// Coordinate unit
        /// -Percentage
        /// - 2 pixel values
        /// </summary>
        [JsonProperty("Unit")]
        public ulong? Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeftTopX", this.LeftTopX);
            this.SetParamSimple(map, prefix + "LeftTopY", this.LeftTopY);
            this.SetParamSimple(map, prefix + "RightBottomX", this.RightBottomX);
            this.SetParamSimple(map, prefix + "RightBottomY", this.RightBottomY);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

