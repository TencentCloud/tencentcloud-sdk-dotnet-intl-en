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
        /// Whether to enable watermark. Possible values:
        /// <li>ON: means enabling watermark;</li>
        /// <li>OFF: means turning off watermark. </li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Watermark URL.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// The width of the watermark. 
        /// <li>The string ends with %, indicating that the watermark Width is a percentage of the video width, such as 10% indicating that the Width is 10% of the video width;</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// The height of the watermark. 
        /// <li>The string ends with %, indicating that the watermark Height is a percentage of the video height, for example, 10% means that the Height is 10% of the video height;</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// The horizontal position of the watermark origin from the video image coordinate origin. The string ends with %, indicating that the watermark XPos specifies a percentage of the video width, such as 10% indicating that XPos is 10% of the video width.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// The vertical position of the watermark origin from the video image coordinate origin. When the string ends with %, it means that the watermark YPos specifies a percentage of the video height. For example, 10% means that YPos is 10% of the video height.
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

