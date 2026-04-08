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

    public class SubtitleShadowConfig : AbstractModel
    {
        
        /// <summary>
        /// Text shadow configuration switch, 0 for off, 1 for on, default 0
        /// </summary>
        [JsonProperty("SubtitleShadowConfigSwitch")]
        public long? SubtitleShadowConfigSwitch{ get; set; }

        /// <summary>
        /// Shadow width, default unit pixel, underlying default value 0, no shading
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public float? ShadowWidth{ get; set; }

        /// <summary>
        /// Shadow width unit. 0 for pixel, 1 for percentage. Default is 0 (pixel).
        /// </summary>
        [JsonProperty("ShadowWidthUnit")]
        public long? ShadowWidthUnit{ get; set; }

        /// <summary>
        /// Shadow color. 6-digit base 16 RGB. Black by default if left blank (has set shadow in the current situation).
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// Shadow transparency. The value should be a positive floating-point number in the range of (0, 1]. If this is not specified, the default value is 1, which means completely opaque (with shadow configured).
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleShadowConfigSwitch", this.SubtitleShadowConfigSwitch);
            this.SetParamSimple(map, prefix + "ShadowWidth", this.ShadowWidth);
            this.SetParamSimple(map, prefix + "ShadowWidthUnit", this.ShadowWidthUnit);
            this.SetParamSimple(map, prefix + "ShadowColor", this.ShadowColor);
            this.SetParamSimple(map, prefix + "ShadowAlpha", this.ShadowAlpha);
        }
    }
}

