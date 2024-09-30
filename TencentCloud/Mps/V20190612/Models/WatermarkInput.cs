/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// ID of a watermarking template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Custom watermark parameter, which is valid if `Definition` is 0.
        /// This parameter is used in highly customized scenarios. We recommend you use `Definition` to specify the watermark parameter preferably.
        /// Custom watermark parameter is not available for screenshot.
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawWatermarkParameter RawParameter{ get; set; }

        /// <summary>
        /// Text content of up to 100 characters. This field is required only when the watermark type is text.
        /// Text watermark is not available for screenshot.
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }

        /// <summary>
        /// SVG content of up to 2,000,000 characters. This field is required only when the watermark type is `SVG`.
        /// SVG watermark is not available for screenshot.
        /// </summary>
        [JsonProperty("SvgContent")]
        public string SvgContent{ get; set; }

        /// <summary>
        /// Start time offset of a watermark, in seconds. If not set or set to 0, a watermark starts appearing when a video starts.
        /// <li>If not set or set to 0, a watermark starts appearing when a video starts.</li>
        /// <li>If the value is greater than 0 (for example, n), a watermark will appear at second n of a video.</li>
        /// <li>If the value is less than 0 (for example, -n), a watermark will appear n seconds before the end of a video.</li>
        /// 
        /// Note: It is only used for video scenarios. Screenshots are not supported.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a watermark, in seconds.
        /// <li>If not set or set to 0, a watermark will last until the end of a video.</li>
        /// <li>If the value is greater than 0 (for example, n), a watermark will disappear at second n.</li>
        /// <li>If the value is less than 0 (for example, -n), a watermark will disappear n seconds before the end of a video.</li>
        /// 
        /// Note: It is only used for video scenarios. Screenshots are not supported.
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

