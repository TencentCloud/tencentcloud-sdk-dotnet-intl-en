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
        /// AI image generation scenario type. valid values:
        /// -change_clothes: AI clothing change.
        /// -product_image: AI-generated product image.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Valid when Type is change_clothes. this item is required and indicates the AI clothes-changing image generation config.
        /// </summary>
        [JsonProperty("ChangeClothesConfig")]
        public ChangeClothesConfig ChangeClothesConfig{ get; set; }

        /// <summary>
        /// Valid when Type is product_image. indicates the AI-generated product image config.
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

