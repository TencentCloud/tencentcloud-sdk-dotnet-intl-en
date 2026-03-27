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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TradePrice : AbstractModel
    {
        
        /// <summary>
        /// Resource total price under prepaid mode, excluding discounts. unit: microCent. 1 US dollar equals 1e8 microCents.
        /// </summary>
        [JsonProperty("TotalPrice")]
        public long? TotalPrice{ get; set; }

        /// <summary>
        /// Total discount. `100` means no discount.
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// Discounted total price under prepaid mode, unit: cent. 1 US dollar equals 1e8 microCents. for example, the user enjoys a Discount = TotalPrice * Discount.
        /// </summary>
        [JsonProperty("TotalPriceDiscount")]
        public long? TotalPriceDiscount{ get; set; }

        /// <summary>
        /// Unit resource price in postpaid mode, excluding discounts. unit: cent. 1 US dollar equals 1e2 cents
        /// </summary>
        [JsonProperty("UnitPrice")]
        public long? UnitPrice{ get; set; }

        /// <summary>
        /// Unit resource price in postpaid mode after Discount, unit: cent. 1 US dollar equals 1e2 cents. for example, the user enjoys a Discount = unitprice * Discount.
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public long? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// Price unit
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// Excludes discounted rates under high precision.
        /// </summary>
        [JsonProperty("UnitPriceHighPrecision")]
        public string UnitPriceHighPrecision{ get; set; }

        /// <summary>
        /// Discounted price under high precision.
        /// </summary>
        [JsonProperty("UnitPriceDiscountHighPrecision")]
        public string UnitPriceDiscountHighPrecision{ get; set; }

        /// <summary>
        /// Currency unit.
        /// </summary>
        [JsonProperty("AmountUnit")]
        public string AmountUnit{ get; set; }


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
            this.SetParamSimple(map, prefix + "UnitPriceHighPrecision", this.UnitPriceHighPrecision);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountHighPrecision", this.UnitPriceDiscountHighPrecision);
            this.SetParamSimple(map, prefix + "AmountUnit", this.AmountUnit);
        }
    }
}

