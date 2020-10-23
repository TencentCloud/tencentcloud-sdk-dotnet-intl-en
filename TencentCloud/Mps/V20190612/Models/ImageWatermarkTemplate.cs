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

    public class ImageWatermarkTemplate : AbstractModel
    {
        
        /// <summary>
        /// Watermark image address.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Watermark width. % and px formats are supported:
        /// <li>If the string ends in %, the `Width` of the watermark will be the specified percentage of the video width; for example, `10%` means that `Width` is 10% of the video width;</li>
        /// <li>If the string ends in px, the `Width` of the watermark will be in px; for example, `100px` means that `Width` is 100 px.</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Watermark height. % and px formats are supported:
        /// <li>If the string ends in %, the `Height` of the watermark will be the specified percentage of the video height. For example, `10%` means that `Height` is 10% of the video height;</li>
        /// <li>If the string ends in px, the `Height` of the watermark will be in pixels. For example, `100px` means that `Height` is 100 pixels.</li>
        /// `0px` means that `Height` will be proportionally scaled according to the video width.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

