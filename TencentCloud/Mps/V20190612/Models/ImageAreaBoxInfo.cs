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

    public class ImageAreaBoxInfo : AbstractModel
    {
        
        /// <summary>
        /// Type of the box selection area in the image. Valid values:
        /// <li>logo: icon.</li>
        /// <li>Text: text.</li>
        /// Default value: logo.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Coordinates (pixel-level) of the box selection area in the image, in the format of [x1, y1, x2, y2]. It indicates the coordinates of the top left corner and the bottom right corner. Note: The maximum value of this field is 4096.
        /// For example, [101, 85, 111, 95].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Coordinates of the box selection area in the image, in the format of [x1, y1, x2, y2]. It indicates the coordinates of the top left corner and the bottom right corner. This field takes effect when AreaCoordSet is not specified. When it indicates the pixel, the maximum value of this field is 4096.
        /// - [0.1, 0.1, 0.3, 0.3]: indicates the ratio (values are less than 1).
        /// - [50, 50, 350, 280]: indicates the pixel (values are greater than or equal to 1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BoundingBox")]
        public float?[] BoundingBox{ get; set; }

        /// <summary>
        /// BoundingBox field unit. When the value is set to 0, select the unit automatically according to the field rule. When it is set to 1, the unit is ratio. When it is set to 2, the unit is pixel.
        /// </summary>
        [JsonProperty("BoundingBoxUnitType")]
        public ulong? BoundingBoxUnitType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamArraySimple(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "BoundingBoxUnitType", this.BoundingBoxUnitType);
        }
    }
}

