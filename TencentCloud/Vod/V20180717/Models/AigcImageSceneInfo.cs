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
        /// <p>AI image generation scenario type. Available values:</p><ul><li>change_clothes: Change clothes in regular scenes.</li><li>change_clothes_under: Change clothes in special scenarios.</li><li>change_clothes_top_wear: Change upper body clothes.</li><li>change_clothes_bottom_wear: Change lower body clothes.</li><li>change_clothes_full_wear: Change full body clothes.</li><li>product_image: AI-generated product image.</li><li>outpainting: AI image outpainting.</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>When the Type is one of the following column types, this item is required and represents the AI clothing change image generation config:</p><ul><li>change_clothes</li><li>change_clothes_under</li><li>change_clothes_full_wear</li><li>change_clothes_top_wear</li><li>change_clothes_bottom_wear</li></ul>
        /// </summary>
        [JsonProperty("ChangeClothesConfig")]
        public ChangeClothesConfig ChangeClothesConfig{ get; set; }

        /// <summary>
        /// <p>Valid when Type is product_image, indicating AI-generated product image config.</p>
        /// </summary>
        [JsonProperty("ProductImageConfig")]
        public ProductImageConfig ProductImageConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "ChangeClothesConfig.", this.ChangeClothesConfig);
            this.SetParamObj(map, prefix + "ProductImageConfig.", this.ProductImageConfig);
        }
    }
}

