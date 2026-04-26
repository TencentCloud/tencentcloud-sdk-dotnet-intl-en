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

    public class UsageDetails : AbstractModel
    {
        
        /// <summary>
        /// Product name
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// product details
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }

        /// <summary>
        /// Product code	
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Sub-product code	
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// Billing item code.	
        /// </summary>
        [JsonProperty("BillingItemCode")]
        public string BillingItemCode{ get; set; }

        /// <summary>
        /// Billing sub-item code.	
        /// </summary>
        [JsonProperty("SubBillingItemCode")]
        public string SubBillingItemCode{ get; set; }

        /// <summary>
        /// Product English Name	
        /// </summary>
        [JsonProperty("ProductEnName")]
        public string ProductEnName{ get; set; }

        /// <summary>
        /// English name of the sub-product.	
        /// </summary>
        [JsonProperty("SubProductEnName")]
        public string SubProductEnName{ get; set; }

        /// <summary>
        /// billing cycle	
        /// </summary>
        [JsonProperty("CalcUnit")]
        public string CalcUnit{ get; set; }

        /// <summary>
        /// payMode is prepay and payScene is common in the current situation
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "SubProductName", this.SubProductName);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "BillingItemCode", this.BillingItemCode);
            this.SetParamSimple(map, prefix + "SubBillingItemCode", this.SubBillingItemCode);
            this.SetParamSimple(map, prefix + "ProductEnName", this.ProductEnName);
            this.SetParamSimple(map, prefix + "SubProductEnName", this.SubProductEnName);
            this.SetParamSimple(map, prefix + "CalcUnit", this.CalcUnit);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

