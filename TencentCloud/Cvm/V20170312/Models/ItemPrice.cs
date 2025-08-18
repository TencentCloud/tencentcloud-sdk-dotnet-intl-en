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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ItemPrice : AbstractModel
    {
        
        /// <summary>
        /// Original price of subsequent total costs, postpaid billing mode usage, unit: usd. <li>if other time interval items are returned, such as UnitPriceSecondStep, this item represents the time interval (0, 96) hr. if no other time interval items are returned, this item represents the full period (0, ∞) hr.
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// Billing unit for pay-as-you-go mode. valid values: <br><li>HOUR: billed on an hourly basis. it's used for hourly POSTPAID instances (`POSTPAID_BY_HOUR`). <br><li>GB: bill BY TRAFFIC in GB. it's used for POSTPAID products that are billed BY the hourly TRAFFIC (`TRAFFIC_POSTPAID_BY_HOUR`).
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// Original price of total prepaid costs. measurement unit: usd.
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// Discount price of total prepaid costs. unit: usd.
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// Discount, such as 20.0 representing 80% off.
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// Discounted price of subsequent total cost, postpaid billing mode usage, unit: usd <li>if other time interval items are returned, such as UnitPriceDiscountSecondStep, this item represents the time interval (0, 96) hr; if no other time interval items are returned, this item represents the full period (0, ∞) hr.
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// Original price of subsequent total costs for usage time range (96, 360) hr in postpaid billing mode. unit: usd.
        /// </summary>
        [JsonProperty("UnitPriceSecondStep")]
        public float? UnitPriceSecondStep{ get; set; }

        /// <summary>
        /// Discounted price of subsequent total cost for usage time interval (96, 360) hr in postpaid billing mode. unit: usd.
        /// </summary>
        [JsonProperty("UnitPriceDiscountSecondStep")]
        public float? UnitPriceDiscountSecondStep{ get; set; }

        /// <summary>
        /// Specifies the original price of subsequent total costs with a usage time interval exceeding 360 hr in postpaid billing mode. measurement unit: usd.
        /// </summary>
        [JsonProperty("UnitPriceThirdStep")]
        public float? UnitPriceThirdStep{ get; set; }

        /// <summary>
        /// Discounted price of subsequent total cost for usage time interval exceeding 360 hr in postpaid billing mode. measurement unit: usd.
        /// </summary>
        [JsonProperty("UnitPriceDiscountThirdStep")]
        public float? UnitPriceDiscountThirdStep{ get; set; }

        /// <summary>
        /// Specifies the original price of total 3-year prepaid costs in prepaid billing mode. measurement unit: usd.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("OriginalPriceThreeYear")]
        public float? OriginalPriceThreeYear{ get; set; }

        /// <summary>
        /// Specifies the discount price for an advance payment of the total fee for three years, prepaid mode usage, measurement unit: usd.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DiscountPriceThreeYear")]
        public float? DiscountPriceThreeYear{ get; set; }

        /// <summary>
        /// Specifies the discount for a 3-year advance payment, for example 20.0 represents 80% off.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DiscountThreeYear")]
        public float? DiscountThreeYear{ get; set; }

        /// <summary>
        /// Specifies the original price of the 5-year total cost with advance payment, using prepaid billing mode. measurement unit: usd.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("OriginalPriceFiveYear")]
        public float? OriginalPriceFiveYear{ get; set; }

        /// <summary>
        /// Prepaid 5-year total cost discount price, prepaid billing mode usage. unit: usd.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DiscountPriceFiveYear")]
        public float? DiscountPriceFiveYear{ get; set; }

        /// <summary>
        /// Specifies the discount for 5-year advance payment, such as 20.0 for 80% off.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DiscountFiveYear")]
        public float? DiscountFiveYear{ get; set; }

        /// <summary>
        /// Original price of one-year advance payment total cost. prepaid mode usage. unit: usd.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("OriginalPriceOneYear")]
        public float? OriginalPriceOneYear{ get; set; }

        /// <summary>
        /// Discount price for total advance payment for one year. specifies prepaid mode usage. measurement unit: usd.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DiscountPriceOneYear")]
        public float? DiscountPriceOneYear{ get; set; }

        /// <summary>
        /// Specifies the discount for a one-year advance payment, such as 20.0 for 80% off.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DiscountOneYear")]
        public float? DiscountOneYear{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPriceSecondStep", this.UnitPriceSecondStep);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountSecondStep", this.UnitPriceDiscountSecondStep);
            this.SetParamSimple(map, prefix + "UnitPriceThirdStep", this.UnitPriceThirdStep);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountThirdStep", this.UnitPriceDiscountThirdStep);
            this.SetParamSimple(map, prefix + "OriginalPriceThreeYear", this.OriginalPriceThreeYear);
            this.SetParamSimple(map, prefix + "DiscountPriceThreeYear", this.DiscountPriceThreeYear);
            this.SetParamSimple(map, prefix + "DiscountThreeYear", this.DiscountThreeYear);
            this.SetParamSimple(map, prefix + "OriginalPriceFiveYear", this.OriginalPriceFiveYear);
            this.SetParamSimple(map, prefix + "DiscountPriceFiveYear", this.DiscountPriceFiveYear);
            this.SetParamSimple(map, prefix + "DiscountFiveYear", this.DiscountFiveYear);
            this.SetParamSimple(map, prefix + "OriginalPriceOneYear", this.OriginalPriceOneYear);
            this.SetParamSimple(map, prefix + "DiscountPriceOneYear", this.DiscountPriceOneYear);
            this.SetParamSimple(map, prefix + "DiscountOneYear", this.DiscountOneYear);
        }
    }
}

