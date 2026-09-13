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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Item : AbstractModel
    {
        
        /// <summary>
        /// <p>The unique ID of the item</p>
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// <p>The name of the item</p>
        /// </summary>
        [JsonProperty("ItemName")]
        public string ItemName{ get; set; }

        /// <summary>
        /// <p>The category of the item</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>The price of the item</p>
        /// </summary>
        [JsonProperty("Price")]
        public Amount Price{ get; set; }

        /// <summary>
        /// <p>If the item has a UPC (Universal Product Code), please provide it here.</p>
        /// </summary>
        [JsonProperty("UPC")]
        public string UPC{ get; set; }

        /// <summary>
        /// <p>If the item has an EAN (European Article Number), please provide it here.</p>
        /// </summary>
        [JsonProperty("EAN")]
        public string EAN{ get; set; }

        /// <summary>
        /// <p>If the item has an SKU (Stock Keeping Unit), please provide it here.</p>
        /// </summary>
        [JsonProperty("SKU")]
        public string SKU{ get; set; }

        /// <summary>
        /// <p>If the item has an ISBN (International Standard Book Number), please provide it here.</p>
        /// </summary>
        [JsonProperty("ISBN")]
        public string ISBN{ get; set; }

        /// <summary>
        /// <p>The brand of the item</p>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// <p>The quantity of the item</p>
        /// </summary>
        [JsonProperty("Quantity")]
        public long? Quantity{ get; set; }

        /// <summary>
        /// <p>The manufacture of the item</p>
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// <p>The tags of the item in your system</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemName", this.ItemName);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "UPC", this.UPC);
            this.SetParamSimple(map, prefix + "EAN", this.EAN);
            this.SetParamSimple(map, prefix + "SKU", this.SKU);
            this.SetParamSimple(map, prefix + "ISBN", this.ISBN);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
        }
    }
}

