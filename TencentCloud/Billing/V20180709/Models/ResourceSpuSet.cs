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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceSpuSet : AbstractModel
    {
        
        /// <summary>
        /// Quoted subproduct (Chinese)
        /// </summary>
        [JsonProperty("SpuNameZh")]
        public string SpuNameZh{ get; set; }

        /// <summary>
        /// Quoted subproduct (English)
        /// </summary>
        [JsonProperty("SpuNameEn")]
        public string SpuNameEn{ get; set; }

        /// <summary>
        /// Quoted product (Chinese)
        /// </summary>
        [JsonProperty("CategoryNameZh")]
        public string CategoryNameZh{ get; set; }

        /// <summary>
        /// Quoted product (English)
        /// </summary>
        [JsonProperty("CategoryNameEn")]
        public string CategoryNameEn{ get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Product name (Chinese)
        /// </summary>
        [JsonProperty("BusinessNameZh")]
        public string BusinessNameZh{ get; set; }

        /// <summary>
        /// Product name (English)
        /// </summary>
        [JsonProperty("BusinessNameEn")]
        public string BusinessNameEn{ get; set; }

        /// <summary>
        /// Subproduct code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Subproduct name (Chinese)
        /// </summary>
        [JsonProperty("ProductNameZh")]
        public string ProductNameZh{ get; set; }

        /// <summary>
        /// Subproduct name (English)
        /// </summary>
        [JsonProperty("ProductNameEn")]
        public string ProductNameEn{ get; set; }

        /// <summary>
        /// Component type code
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Component type name (Chinese)
        /// </summary>
        [JsonProperty("ComponentNameZh")]
        public string ComponentNameZh{ get; set; }

        /// <summary>
        /// Component type name (English)
        /// </summary>
        [JsonProperty("ComponentNameEn")]
        public string ComponentNameEn{ get; set; }

        /// <summary>
        /// Component code
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// Component name (Chinese)
        /// </summary>
        [JsonProperty("ItemNameZh")]
        public string ItemNameZh{ get; set; }

        /// <summary>
        /// Component name (English)
        /// </summary>
        [JsonProperty("ItemNameEn")]
        public string ItemNameEn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpuNameZh", this.SpuNameZh);
            this.SetParamSimple(map, prefix + "SpuNameEn", this.SpuNameEn);
            this.SetParamSimple(map, prefix + "CategoryNameZh", this.CategoryNameZh);
            this.SetParamSimple(map, prefix + "CategoryNameEn", this.CategoryNameEn);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessNameZh", this.BusinessNameZh);
            this.SetParamSimple(map, prefix + "BusinessNameEn", this.BusinessNameEn);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductNameZh", this.ProductNameZh);
            this.SetParamSimple(map, prefix + "ProductNameEn", this.ProductNameEn);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ComponentNameZh", this.ComponentNameZh);
            this.SetParamSimple(map, prefix + "ComponentNameEn", this.ComponentNameEn);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ItemNameZh", this.ItemNameZh);
            this.SetParamSimple(map, prefix + "ItemNameEn", this.ItemNameEn);
        }
    }
}

