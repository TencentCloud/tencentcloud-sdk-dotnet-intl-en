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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrepayPrice : AbstractModel
    {
        
        /// <summary>
        /// Discounted price of a monthly-subscribed cloud disk or a snapshot, in USD.
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// Billing unit for pay-as-you-go cloud disks. Valid value: <br><li>HOUR: billed hourly.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// Original unit price of a pay-as-you-go cloud disk, in USD, with six decimal places.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceHigh")]
        public string UnitPriceHigh{ get; set; }

        /// <summary>
        /// Original payment of a monthly-subscribed cloud disk or a snapshot, in USD, with six decimal places.
        /// </summary>
        [JsonProperty("OriginalPriceHigh")]
        public string OriginalPriceHigh{ get; set; }

        /// <summary>
        /// Original payment of a monthly-subscribed cloud disk or a snapshot, in USD.
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// Discount unit price of a pay-as-you-go cloud disk, in USD.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// Discounted unit price of a pay-as-you-go cloud disk, in USD, with six decimal places.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscountHigh")]
        public string UnitPriceDiscountHigh{ get; set; }

        /// <summary>
        /// Discounted price of a monthly-subscribed cloud disk or a snapshot, in USD, with six decimal places.
        /// </summary>
        [JsonProperty("DiscountPriceHigh")]
        public string DiscountPriceHigh{ get; set; }

        /// <summary>
        /// Original unit price of a pay-as-you-go cloud disk, in USD.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// Detailed billing items
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DetailPrices")]
        public DetailPrice[] DetailPrices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamSimple(map, prefix + "UnitPriceHigh", this.UnitPriceHigh);
            this.SetParamSimple(map, prefix + "OriginalPriceHigh", this.OriginalPriceHigh);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountHigh", this.UnitPriceDiscountHigh);
            this.SetParamSimple(map, prefix + "DiscountPriceHigh", this.DiscountPriceHigh);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamArrayObj(map, prefix + "DetailPrices.", this.DetailPrices);
        }
    }
}

