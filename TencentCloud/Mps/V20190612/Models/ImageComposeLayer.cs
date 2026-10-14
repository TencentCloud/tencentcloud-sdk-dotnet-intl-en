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

    public class ImageComposeLayer : AbstractModel
    {
        
        /// <summary>
        /// <p>Layer stacking sequence, required. It cannot be repeated in the same request. The larger the value, the higher the layer (it is recommended to start consecutive numbering from 0).</p>
        /// </summary>
        [JsonProperty("ZIndex")]
        public long? ZIndex{ get; set; }

        /// <summary>
        /// <p>Layer source, required. Supports URL / COS / AWS-S3 / VOD.</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>The position and size of the layer in the canvas. Required. An array of length 4 [X1, Y1, X2, Y2]: coordinates of the top-left and bottom-right corners. X2 > X1 and Y2 > Y1 are required.</p><p>Two semantics (aligned with the BoundingBox of the image removal capability):</p><ul><li>Pixel: coordinate values in the range of [-10240, 10240]. Negative values or values beyond the canvas are allowed (the excess part is cropped).</li><li>Ratio: each value ∈ [-1, 1], converted based on the canvas width and height (x multiplied by canvas width, y multiplied by canvas height).</li></ul><p>The layer is scaled to fill this rectangle. Any part beyond the canvas is cropped, and the output size is always equal to the canvas size.</p>
        /// </summary>
        [JsonProperty("BoundingBox")]
        public float?[] BoundingBox{ get; set; }

        /// <summary>
        /// <p>Coordinate unit, aligned with the image removal capacity. Values:</p><ul><li>0: automatic judgment (default value if not passed);</li><li>1: ratio;</li><li>2: pixel.</li></ul><p>Automatic judgment rules: if all four values are greater than 1, they are interpreted as pixels; if all are not greater than 1, they are interpreted as ratios. Mixed values will return InvalidParameter. It is recommended to always explicitly specify.</p>
        /// </summary>
        [JsonProperty("BoundingBoxUnitType")]
        public ulong? BoundingBoxUnitType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZIndex", this.ZIndex);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamArraySimple(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "BoundingBoxUnitType", this.BoundingBoxUnitType);
        }
    }
}

