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

    public class AigcImageSceneInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>AI image generation scenario type, available values:</p><ul><li><code>ai_try_on</code>: AI dress up.</li><li><code>product_image</code>: AI product image.</li><li><code>outpainting</code>: AI outpainting.</li></ul><p>The following <code>Type</code> are abandoned and no longer updated subsequently:</p><ul><li><code>change_clothes</code></li><li><code>change_clothes_under</code></li><li><code>change_clothes_top_wear</code></li><li><code>change_clothes_bottom_wear</code></li><li><code>change_clothes_full_wear</code></li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Required when Type is ai_try_on. Represents AI dress up config.</p>
        /// </summary>
        [JsonProperty("AiTryOnConfig")]
        public AiTryOnConfig AiTryOnConfig{ get; set; }

        /// <summary>
        /// <p><strong>Abandoned, please use AiTryOnConfig.</strong> When Type is one of the following column types, this item is required and represents AI try-on image generation configuration parameters:</p><ul><li>change_clothes</li><li>change_clothes_under</li></ul>
        /// </summary>
        [JsonProperty("ChangeClothesConfig")]
        public ChangeClothesConfig ChangeClothesConfig{ get; set; }

        /// <summary>
        /// <p>Required when Type is product_image. It represents the AI product image config.</p>
        /// </summary>
        [JsonProperty("ProductImageConfig")]
        public ProductImageConfig ProductImageConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "AiTryOnConfig.", this.AiTryOnConfig);
            this.SetParamObj(map, prefix + "ChangeClothesConfig.", this.ChangeClothesConfig);
            this.SetParamObj(map, prefix + "ProductImageConfig.", this.ProductImageConfig);
        }
    }
}

