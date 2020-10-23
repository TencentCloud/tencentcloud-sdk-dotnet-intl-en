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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LayoutParams : AbstractModel
    {
        
        /// <summary>
        /// Stream image width. Value range: [2,3000]
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Stream image height. Value range: [2,3000]
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Offset of the top point in the upper-left corner of the current image to the X axis of the top point in the upper-left corner of the canvas. Default value: 0. Value range: [0,3000].
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// Offset of the top point in the upper-left corner of the current image to the Y axis of the top point in the upper-left corner of the canvas. Default value: 0. Value range: [0,3000].
        /// </summary>
        [JsonProperty("Y")]
        public long? Y{ get; set; }

        /// <summary>
        /// Z-axis position of the image. The default value is 0.
        /// The Z axis determines the overlap sequence of images. The image with the largest z-axis value is at the top layer.
        /// </summary>
        [JsonProperty("ZOrder")]
        public long? ZOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "ZOrder", this.ZOrder);
        }
    }
}

