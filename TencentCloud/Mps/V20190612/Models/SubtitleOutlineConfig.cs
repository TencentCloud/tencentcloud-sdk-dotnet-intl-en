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

    public class SubtitleOutlineConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Text stroke configuration switch, 0 for off, 1 for on, default 0</p>
        /// </summary>
        [JsonProperty("SubtitleOutlineConfigSwitch")]
        public long? SubtitleOutlineConfigSwitch{ get; set; }

        /// <summary>
        /// <p>Stroke width, default unit pixel, underlying default value is 0.3% of the source video height</p>
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public float? OutlineWidth{ get; set; }

        /// <summary>
        /// <p>Stroke width unit, 0 pixel, 1 percentage, defaults to 0, pixel</p>
        /// </summary>
        [JsonProperty("OutlineWidthUnit")]
        public long? OutlineWidthUnit{ get; set; }

        /// <summary>
        /// <p>Border color. 6-digit base 16 RGB. Black by default if left blank.</p>
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// <p>Stroke transparency. The value should be a positive floating-point number in the range of (0, 1]. If this is not specified, the default value is 1, which means completely opaque.</p>
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleOutlineConfigSwitch", this.SubtitleOutlineConfigSwitch);
            this.SetParamSimple(map, prefix + "OutlineWidth", this.OutlineWidth);
            this.SetParamSimple(map, prefix + "OutlineWidthUnit", this.OutlineWidthUnit);
            this.SetParamSimple(map, prefix + "OutlineColor", this.OutlineColor);
            this.SetParamSimple(map, prefix + "OutlineAlpha", this.OutlineAlpha);
        }
    }
}

