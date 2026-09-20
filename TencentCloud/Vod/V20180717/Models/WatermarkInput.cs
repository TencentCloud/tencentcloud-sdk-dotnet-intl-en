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

    public class WatermarkInput : AbstractModel
    {
        
        /// <summary>
        /// Watermark template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Text content, up to 100 characters. Fill in only when the watermark type is text watermark.
        /// Text watermarks do not support watermarking screenshots.
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }

        /// <summary>
        /// SVG content. Length not exceeding 2000000 characters. Fill in only when the watermark type is SVG watermark.
        /// SVG watermark does not support screenshot watermarking.
        /// </summary>
        [JsonProperty("SvgContent")]
        public string SvgContent{ get; set; }

        /// <summary>
        /// Start time offset of a watermark, in seconds. If not set or set to 0, a watermark starts appearing when a video starts.
        /// <li>If not set or set to 0, a watermark starts appearing when a video starts.</li>
        /// <li>If the value is greater than 0 (for example, n), a watermark will appear at second n of a video.</li>
        /// <li>When the value is less than 0 (assuming -n), the watermark appears n seconds before the end of the video.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a watermark, in seconds.
        /// <li>If not set or set to 0, a watermark will last until the end of a video.</li>
        /// <li>If the value is greater than 0 (for example, n), a watermark will disappear at second n.</li>
        /// <li>When the value is less than 0 (assuming -n), the watermark persists until n seconds before the end of the video.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
            this.SetParamSimple(map, prefix + "SvgContent", this.SvgContent);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

