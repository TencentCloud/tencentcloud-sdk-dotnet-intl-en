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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LSqueezeSetting : AbstractModel
    {
        
        /// <summary>
        /// Advertising benchmark position, 0 top left, 1 top right, 2 bottom right, 3 bottom left, default value 0, corresponding TOP_LEFT,TOP_RIGHT,BOTTOM_RIGHT,BOTTOM_LEFT
        /// </summary>
        [JsonProperty("Location")]
        public ulong? Location{ get; set; }

        /// <summary>
        /// The default value for the percentage in the X-axis direction is 20, with a range of 0-50
        /// </summary>
        [JsonProperty("OffsetX")]
        public ulong? OffsetX{ get; set; }

        /// <summary>
        /// The default value for the percentage in the Y-axis direction is 20, with a range of 0-50
        /// </summary>
        [JsonProperty("OffsetY")]
        public ulong? OffsetY{ get; set; }

        /// <summary>
        /// Background image URL, starting with http/https and ending in jpg/jpeg/png
        /// </summary>
        [JsonProperty("BackgroundImgUrl")]
        public string BackgroundImgUrl{ get; set; }

        /// <summary>
        /// Compress time. Unit ms, default value 2000, range: 500-10000, SqueezeInPeriod+SqueezeOutPeriod cannot be greater than duration, included in duration
        /// </summary>
        [JsonProperty("SqueezeInPeriod")]
        public ulong? SqueezeInPeriod{ get; set; }

        /// <summary>
        /// Restore to full screen time. Unit ms, default value 2000, range 500-10000, SqueezeInPeriod+SqueezeOutPeriod cannot be greater than duration, included in duration
        /// </summary>
        [JsonProperty("SqueezeOutPeriod")]
        public ulong? SqueezeOutPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "OffsetX", this.OffsetX);
            this.SetParamSimple(map, prefix + "OffsetY", this.OffsetY);
            this.SetParamSimple(map, prefix + "BackgroundImgUrl", this.BackgroundImgUrl);
            this.SetParamSimple(map, prefix + "SqueezeInPeriod", this.SqueezeInPeriod);
            this.SetParamSimple(map, prefix + "SqueezeOutPeriod", this.SqueezeOutPeriod);
        }
    }
}

