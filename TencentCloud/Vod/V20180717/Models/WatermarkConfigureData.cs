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

    public class WatermarkConfigureData : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable watermark. Valid values:
        /// <li>ON: Enable watermark;</li>
        /// <li>OFF: Turn off watermark.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Watermark Url.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Width of a watermark.
        /// <li>If a string ends with %, it indicates that the `Width` of a watermark is a percentage of a video's width. For example, `10%` means that `Width` is 10% of a video's width.</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Height of the watermark.
        /// <li>If a string ends with %, it indicates that the `Height` of a watermark is a percentage of a video's height. For example, `10%` means that `Height` is 10% of a video's height.</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Horizontal position of the watermark origin relative to the origin of coordinates of the video image. A string ending with % means the watermark XPos is a specified percentage of the video width. For example, 10% means XPos is 10% of the video width.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the watermark origin relative to the origin of coordinates of the video image. When the string ends with %, the watermark YPos is the specified percentage of the video height. For example, 10% means YPos is 10% of the video height.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
        }
    }
}

