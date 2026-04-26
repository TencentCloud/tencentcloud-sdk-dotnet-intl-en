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

    public class DescribeCPQBillingMappingRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// The number of entries returned at a time. The maximum value is `100`.	
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// Quoted subproduct name
        /// </summary>
        [JsonProperty("SpuName")]
        public string SpuName{ get; set; }

        /// <summary>
        /// Quoted product name
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        [JsonProperty("BusinessName")]
        public string BusinessName{ get; set; }

        /// <summary>
        /// Subproduct name
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Component type name
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// Component name
        /// </summary>
        [JsonProperty("ItemName")]
        public string ItemName{ get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Subproduct code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Component type code
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Component code
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SpuName", this.SpuName);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "BusinessName", this.BusinessName);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ItemName", this.ItemName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
        }
    }
}

