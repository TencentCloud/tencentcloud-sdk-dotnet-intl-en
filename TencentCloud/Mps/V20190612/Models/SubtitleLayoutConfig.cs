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

    public class SubtitleLayoutConfig : AbstractModel
    {
        
        /// <summary>
        /// Subtitle arrangement configuration switch, 0 for off, 1 for on, default 0
        /// </summary>
        [JsonProperty("SubtitleLayoutConfigSwitch")]
        public long? SubtitleLayoutConfigSwitch{ get; set; }

        /// <summary>
        /// Line spacing. The value should be a positive integer.
        /// -Value range for pixels: [0, 1000].
        /// - Value range for percentages: [0, 100]. If this is not specified, the default value is 0.
        /// </summary>
        [JsonProperty("LineSpacing")]
        public long? LineSpacing{ get; set; }

        /// <summary>
        /// LineSpacing unit, 0 pixel, 1 percentage, defaults to 0, pixel
        /// </summary>
        [JsonProperty("LineSpacingUnit")]
        public long? LineSpacingUnit{ get; set; }

        /// <summary>
        /// Alignment mode. Valid values: top: The top position of the subtitle is fixed, while the bottom position changes according to the line count. bottom: The bottom position of the subtitle is fixed, while the top position changes according to the line count. If this is not specified, bottom alignment is used by default.
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleLayoutConfigSwitch", this.SubtitleLayoutConfigSwitch);
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
            this.SetParamSimple(map, prefix + "LineSpacingUnit", this.LineSpacingUnit);
            this.SetParamSimple(map, prefix + "Alignment", this.Alignment);
        }
    }
}

