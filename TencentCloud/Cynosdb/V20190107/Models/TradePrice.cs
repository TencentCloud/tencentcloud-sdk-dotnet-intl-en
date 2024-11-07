/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TradePrice : AbstractModel
    {
        
        /// <summary>
        /// The non-discounted total price of monthly subscribed resources (unit: 0.000001 cent)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalPrice")]
        public long? TotalPrice{ get; set; }

        /// <summary>
        /// Total discount. `100` means no discount.
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// The discounted total price of monthly subscribed resources (unit: 0.000001 cent). If a discount is applied, `TotalPriceDiscount` will be the product of `TotalPrice` and `Discount`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalPriceDiscount")]
        public long? TotalPriceDiscount{ get; set; }

        /// <summary>
        /// The non-discounted unit price of pay-as-you-go resources (unit: 0.000001 cent)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPrice")]
        public long? UnitPrice{ get; set; }

        /// <summary>
        /// The discounted unit price of pay-as-you-go resources (unit: 0.000001 cent). If a discount is applied, `UnitPriceDiscount` will be the product of `UnitPrice` and `Discount`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public long? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// Price unit
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalPrice", this.TotalPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "TotalPriceDiscount", this.TotalPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
        }
    }
}

