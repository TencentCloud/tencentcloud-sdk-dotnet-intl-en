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

    public class RawImageWatermarkInput : AbstractModel
    {
        
        /// <summary>
        /// Input content of the watermark image. jpeg and png image formats are supported.
        /// </summary>
        [JsonProperty("ImageContent")]
        public MediaInputInfo ImageContent{ get; set; }

        /// <summary>
        /// Width of a watermark, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Width` of a watermark is a percentage of a video's width. For example, `10%` means that `Width` is 10% of a video's width.</li>
        /// <li>If a string ends with px, it means the watermark Width is in pixels. For example, 100px means the Width is 100 pixels.</li>
        /// Default value: 10%.
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Height of a watermark. Supports two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Height` of a watermark is a percentage of a video's height. For example, `10%` means that `Height` is 10% of a video's height.</li>
        /// <li>If a string ends with px, it means the watermark Height is in pixels. For example, 100px means the Height is 100 pixels.</li>
        /// Default value: 0px, which means Height is scaled according to the aspect ratio of the raw watermark image.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Watermark repeat type. Usage scenario: the watermark is a dynamic image. Value range:
        /// <li>once: The dynamic watermark will no longer appear after it has finished playing;</li>
        /// <li>repeat_last_frame: Stay on the last frame after the watermark finished playing;</li>
        /// <li>repeat: Watermark loops until the video ends (default value).</li>
        /// </summary>
        [JsonProperty("RepeatType")]
        public string RepeatType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImageContent.", this.ImageContent);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "RepeatType", this.RepeatType);
        }
    }
}

