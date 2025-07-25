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

    public class MediaImageSpriteItem : AbstractModel
    {
        
        /// <summary>
        /// Image sprite specification. For more information, please see [Image Sprite Parameter Template](https://intl.cloud.tencent.com/document/product/266/33480?from_cn_redirect=1#.E9.9B.AA.E7.A2.A7.E5.9B.BE.E6.A8.A1.E6.9D.BF).
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Subimage height of an image sprite.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Subimage width of an image sprite.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Total number of subimages in each image sprite.
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Path to each image sprite.
        /// </summary>
        [JsonProperty("ImagePathSet")]
        public string[] ImagePathSet{ get; set; }

        /// <summary>
        /// Path to a WebVtt file for the position-time relationship among subimages in an image sprite. The WebVtt file indicates the corresponding time points of each subimage and their coordinates in the image sprite, which is typically used by the player for implementing preview.
        /// </summary>
        [JsonProperty("WebVttPath")]
        public string WebVttPath{ get; set; }

        /// <summary>
        /// Storage location of an image sprite file.
        /// </summary>
        [JsonProperty("Storage")]
        public TaskOutputStorage Storage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArraySimple(map, prefix + "ImagePathSet.", this.ImagePathSet);
            this.SetParamSimple(map, prefix + "WebVttPath", this.WebVttPath);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
        }
    }
}

