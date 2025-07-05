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
        /// Input content of watermark image. JPEG and PNG images are supported.
        /// </summary>
        [JsonProperty("ImageContent")]
        public MediaInputInfo ImageContent{ get; set; }

        /// <summary>
        /// Watermark width. % and px formats are supported:
        /// <li>If the string ends in %, the `Width` of the watermark will be the specified percentage of the video width; for example, `10%` means that `Width` is 10% of the video width;</li>
        /// <li>If the string ends in px, the `Width` of the watermark will be in px; for example, `100px` means that `Width` is 100 px.</li>
        /// Default value: 10%.
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Watermark height. % and px formats are supported:
        /// <li>If the string ends in %, the `Height` of the watermark will be the specified percentage of the video height; for example, `10%` means that `Height` is 10% of the video height;</li>
        /// <li>If the string ends in px, the `Height` of the watermark will be in px; for example, `100px` means that `Height` is 100 px.</li>
        /// Default value: 0 px, which means that `Height` will be proportionally scaled according to the aspect ratio of the original watermark image.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Repeat type of an animated watermark. Valid values:
        /// <li>`once`: no longer appears after watermark playback ends.</li>
        /// <li>`repeat_last_frame`: stays on the last frame after watermark playback ends.</li>
        /// <li>`repeat` (default): repeats the playback until the video ends.</li>
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

