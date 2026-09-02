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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmSupportedAssetType : AbstractModel
    {
        
        /// <summary>
        /// <p>Product name (used for querying)</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>Region list.</p>
        /// </summary>
        [JsonProperty("Regions")]
        public RegionConfig[] Regions{ get; set; }

        /// <summary>
        /// <p>Product name-for display</p>
        /// </summary>
        [JsonProperty("ProductDisplayName")]
        public string ProductDisplayName{ get; set; }

        /// <summary>
        /// <p>Product group name</p>
        /// </summary>
        [JsonProperty("ProductGroup")]
        public string ProductGroup{ get; set; }

        /// <summary>
        /// <p>Total number of asset instances for a given asset type</p>
        /// </summary>
        [JsonProperty("AssetTotal")]
        public long? AssetTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArrayObj(map, prefix + "Regions.", this.Regions);
            this.SetParamSimple(map, prefix + "ProductDisplayName", this.ProductDisplayName);
            this.SetParamSimple(map, prefix + "ProductGroup", this.ProductGroup);
            this.SetParamSimple(map, prefix + "AssetTotal", this.AssetTotal);
        }
    }
}

