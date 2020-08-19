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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmallVideoLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// ID of the user in the small image.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Stream type of the small image. 0: camera; 1: screen sharing. If a web user's stream is displayed in the small image, enter 0 for this parameter.
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// Output width of the small image in pixels. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// Output height of the small image in pixels. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }

        /// <summary>
        /// Output X-axis offset of the small image in pixels. The sum of `LocationX` and `ImageWidth` cannot exceed the total width of the output mixed stream. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// Output Y-axis offset of the small image in pixels. The sum of `LocationY` and `ImageHeight` cannot exceed the total height of the output mixed stream. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
        }
    }
}

