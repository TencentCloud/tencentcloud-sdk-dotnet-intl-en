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

    public class MediaImageSpriteItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Sprite sheet specification. See <a href="https://www.tencentcloud.com/document/product/266/33480?from_cn_redirect=1#.E9.9B.AA.E7.A2.A7.E5.9B.BE.E6.A8.A1.E6.9D.BF">sprite sheet parameter template</a>.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Height of the small image in the sprite sheet.</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>Width of the small image in the sprite sheet.</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>The number of small images in each large sprite sheet.</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>Domain names or IP addresses of each sprite sheet.</p>
        /// </summary>
        [JsonProperty("ImageUrlSet")]
        public string[] ImageUrlSet{ get; set; }

        /// <summary>
        /// <p>Address of the WebVtt file that describes the temporal relationship between sprite subimages and time. The WebVtt file indicates the time point corresponding to each sprite subimage and its coordinates in the sprite sheet. It is used by the player to implement preview.</p>
        /// </summary>
        [JsonProperty("WebVttUrl")]
        public string WebVttUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArraySimple(map, prefix + "ImageUrlSet.", this.ImageUrlSet);
            this.SetParamSimple(map, prefix + "WebVttUrl", this.WebVttUrl);
        }
    }
}

