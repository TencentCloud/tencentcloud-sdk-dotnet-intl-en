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

    public class ImageTransform : AbstractModel
    {
        
        /// <summary>
        /// Type. Valid values:
        /// <li> Rotate: image rotation.</li>
        /// <li> Flip: image flipping.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Rotation angle of image with its center point as origin. Value range: 0-360. This parameter is valid if `Type` is `Rotate`.
        /// </summary>
        [JsonProperty("RotateAngle")]
        public float? RotateAngle{ get; set; }

        /// <summary>
        /// Image flipping action. Valid values:
        /// <li>Horizental: horizontal flipping, i.e., horizontally mirrored.</li>
        /// <li>Vertical: vertical flipping, i.e., vertically mirrored.</li>
        /// This is valid if `Type` is `Flip`.
        /// </summary>
        [JsonProperty("Flip")]
        public string Flip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RotateAngle", this.RotateAngle);
            this.SetParamSimple(map, prefix + "Flip", this.Flip);
        }
    }
}

