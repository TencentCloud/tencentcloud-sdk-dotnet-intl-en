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

    public class AdvancedSuperResolutionConfig : AbstractModel
    {
        
        /// <summary>
        /// Capability configuration switch. Valid values:
        /// <li>ON: enabled;</li>
        /// <li>OFF: Disabled.</li>
        /// Default value: ON.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Type, available values:
        /// <li>standard: common super resolution</li>
        /// <li>super: advanced super-resolution.</li>
        /// Default value: standard.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Image output mode. The default value is percent.
        /// <li>aspect: obtain a larger rectangle with specified width and height through super-resolution.</li>
        /// <li>fixed: obtain images of fixed width and height through super-resolution, with forced scaling supported.</li>
        /// <li>percent: Super-resolution multiplication rate, which can be a decimal.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Super-resolution multiplication rate, can be decimal.
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// Target image width must not exceed 4096.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Target image height must not exceed 4096.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// The long edge length of the target image must not exceed 4096.
        /// Note: This configuration is used when Mode equals aspect or fixed and the Width and Height fields are unconfigured.
        /// </summary>
        [JsonProperty("LongSide")]
        public long? LongSide{ get; set; }

        /// <summary>
        /// The short side length of the target image must not exceed 4096.
        /// Note: This configuration is used when Mode equals aspect or fixed and the Width and Height fields are unconfigured.
        /// </summary>
        [JsonProperty("ShortSide")]
        public long? ShortSide{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "LongSide", this.LongSide);
            this.SetParamSimple(map, prefix + "ShortSide", this.ShortSide);
        }
    }
}

