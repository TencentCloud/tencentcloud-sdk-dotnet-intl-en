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

    public class Canvas : AbstractModel
    {
        
        /// <summary>
        /// Background color. Valid values:
        /// <li>Black: black background</li>
        /// <li>White: white background</li>
        /// Default value: Black.
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// Canvas width, i.e., the output video width. Value range: 0–3840. Unit: px.
        /// Default value: 0, which means the video width is the same as that of the first video clip on the first video track.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Canvas height, i.e. the height (or long side) of the output video. Value range: 0–3840. Unit: px.
        /// Default value: 0, which means the video height is the same as that of the first video clip on the first video track.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

