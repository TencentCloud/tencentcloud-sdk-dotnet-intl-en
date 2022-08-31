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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullPushWatermarkInfo : AbstractModel
    {
        
        /// <summary>
        /// The watermark image URL.
        /// Characters not allowed:
        /// ;(){}$>`#"'|
        /// </summary>
        [JsonProperty("PictureUrl")]
        public string PictureUrl{ get; set; }

        /// <summary>
        /// The horizontal offset (%) of the watermark. The default value is 0.
        /// </summary>
        [JsonProperty("XPosition")]
        public long? XPosition{ get; set; }

        /// <summary>
        /// The vertical offset (%) of the watermark. The default value is 0.
        /// </summary>
        [JsonProperty("YPosition")]
        public long? YPosition{ get; set; }

        /// <summary>
        /// The watermark width as a percentage of the video width. To avoid distorted images, we recommend you specify only the width or height so that the other side can be scaled proportionally. By default, the original width of the watermark image is used.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// The watermark height as a percentage of the video height. To avoid distorted images, we recommend you specify only the width or height so that the other side can be scaled proportionally. By default, the original height of the watermark image is used.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// The origin. The default value is 0.
        /// 0: Top left corner
        /// 1: Top right corner
        /// 2: Bottom right corner
        /// 3: Bottom left corner
        /// </summary>
        [JsonProperty("Location")]
        public long? Location{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PictureUrl", this.PictureUrl);
            this.SetParamSimple(map, prefix + "XPosition", this.XPosition);
            this.SetParamSimple(map, prefix + "YPosition", this.YPosition);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Location", this.Location);
        }
    }
}

