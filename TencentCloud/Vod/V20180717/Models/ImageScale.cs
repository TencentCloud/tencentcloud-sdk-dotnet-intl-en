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

    public class ImageScale : AbstractModel
    {
        
        /// <summary>
        /// The scaling type. Valid values:
        /// <li>`WidthFirst`: Specify the width and proportionally scale the height.</li>
        /// <li>`HeightFirst`: Specify the height and proportionally scale the width.</li>
        /// <li>`LongEdgeFirst`: Specify the long side (`LongEdge`) and proportionally scale the short side.</li>
        /// <li>`ShortEdgeFirst`: Specify the short side (`ShortEdge`) and proportionally scale the long side.</li>
        /// <li>Force: Specify both the height and width. The output image may be distorted.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The image height (pixels). This parameter is valid only if `Type` is `HeightFirst` or `Force`.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// The image width (pixels). This parameter is valid only if `Type` is `WidthFirst` or `Force`.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The long side of the output image (pixels). This parameter is valid only if `Type` is `LongEdgeFirst`.
        /// </summary>
        [JsonProperty("LongEdge")]
        public ulong? LongEdge{ get; set; }

        /// <summary>
        /// The short side of the output image (pixels). This parameter is valid only if `Type` is `ShortEdgeFirst`.
        /// </summary>
        [JsonProperty("ShortEdge")]
        public ulong? ShortEdge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "LongEdge", this.LongEdge);
            this.SetParamSimple(map, prefix + "ShortEdge", this.ShortEdge);
        }
    }
}

