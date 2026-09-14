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

    public class WatermarkInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Watermark template ID.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p>Watermark custom parameter, valid when Definition is set to 0.<br>This parameter is used for highly customized scenarios. We recommend you prioritize using Definition to specify watermark parameters.<br>Watermark custom parameters are not supported for screenshot watermarking.</p>
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawWatermarkParameter RawParameter{ get; set; }

        /// <summary>
        /// <p>Text content, length not exceeding 100 characters. Fill in only when the watermark type is text watermark.<br>Text watermark does not support screenshot watermarking.</p>
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }

        /// <summary>
        /// <p>SVG content. Length not exceeding 2000000 characters. Fill in only when the watermark type is SVG watermark.<br>SVG watermark does not support screenshot watermarking.</p>
        /// </summary>
        [JsonProperty("SvgContent")]
        public string SvgContent{ get; set; }

        /// <summary>
        /// <p>Start time offset of a watermark, in seconds. If not set or set to 0, a watermark starts appearing when a video starts.</p><li>If not set or set to 0, a watermark starts appearing when a video starts;</li><li>If the value is greater than 0 (assuming n), the watermark appears at second n after the video starts;</li><li>If the value is less than 0 (assuming -n), the watermark appears n seconds before the end of the video.</li>Note: Only used for video scenes. Screenshots do not support it.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// <p>End time offset of a watermark, in seconds.</p><li>Leave empty or set to 0: the watermark lasts until the end of the video.</li><li>Value greater than 0 (assuming n): the watermark disappears at second n.</li><li>Value smaller than 0 (assuming -n): the watermark disappears n seconds before the end of the video.</li>Note: Only used for video scenes. Screenshot is not supported.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
            this.SetParamSimple(map, prefix + "SvgContent", this.SvgContent);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

