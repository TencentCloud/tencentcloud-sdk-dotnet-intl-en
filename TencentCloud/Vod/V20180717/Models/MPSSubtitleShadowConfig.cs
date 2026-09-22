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

    public class MPSSubtitleShadowConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Text shadow configuration switch, 0 for off, 1 for on, default 0</p>
        /// </summary>
        [JsonProperty("SubtitleShadowConfigSwitch")]
        public long? SubtitleShadowConfigSwitch{ get; set; }

        /// <summary>
        /// <p>Shadow width, default unit pixel, underlying default value 0, no shading</p>
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public float? ShadowWidth{ get; set; }

        /// <summary>
        /// <p>Shadow width unit. 0 for pixel, 1 for percentage. Default is 0 (pixel).</p>
        /// </summary>
        [JsonProperty("ShadowWidthUnit")]
        public long? ShadowWidthUnit{ get; set; }

        /// <summary>
        /// <p>Shadow color. 6-digit hexadecimal RGB. Black by default if left blank (when shadow has set)</p>
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// <p>Shadow transparency. The value should be a positive floating-point number in the range of (0, 1]. If this is not specified, the default value is 1, which means completely opaque (with shadow configured).</p>
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

