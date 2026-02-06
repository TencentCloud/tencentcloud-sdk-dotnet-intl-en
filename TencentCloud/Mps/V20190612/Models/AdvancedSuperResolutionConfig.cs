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

    public class AdvancedSuperResolutionConfig : AbstractModel
    {
        
        /// <summary>
        /// Capability configuration switch. Valid values:
        /// <li>ON: enabled.</li>
        /// <li>OFF: disabled.</li>
        /// Default value: ON.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Type. Valid values:<li>standard: standard super-resolution.</li><li>super: super advanced super-resolution.</li><li>ultra: ultra advanced super-resolution.</li>Default value: standard.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Image output mode. The default value is percent.
        /// <li>aspect: obtain a larger rectangle with specified width and height through super-resolution.</li>
        /// <li>fixed: obtain images of fixed width and height through super-resolution, with forced scaling supported.</li>
        /// <li>percent: magnification factor of super-resolution, which can be a decimal.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Scale factor of super-resolution, which can be a decimal.Note: This is used when Mode is percent.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// Width of the target image. The value cannot exceed 4096.Note: When Mode is aspect or fixed, this configuration takes priority.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Height of the target image. The value cannot exceed 4096.Note: When Mode is aspect or fixed, this configuration takes priority.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Long side length of the target image. The value cannot exceed 4096.Note: This configuration is used when Mode is aspect or fixed and the Width and Height fields are not specified.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LongSide")]
        public long? LongSide{ get; set; }

        /// <summary>
        /// Short side length of the target image. The value cannot exceed 4096.Note: This configuration is used when Mode is aspect or fixed and the Width and Height fields are not specified.Note: This field may return null, indicating that no valid values can be obtained.
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

