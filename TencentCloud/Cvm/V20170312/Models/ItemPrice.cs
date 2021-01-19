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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ItemPrice : AbstractModel
    {
        
        /// <summary>
        /// The original unit price for pay-as-you-go mode in USD. <br><li>When a billing tier is returned, it indicates the price fo the returned billing tier. For example, if `UnitPriceSecondStep` is returned, it refers to the unit price for the usage between 0 to 96 hours. Otherwise, it refers to that the unit price for unlimited usage.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// Billing unit for pay-as-you-go mode. Valid values: <br><li>HOUR: billed on an hourly basis. It's used for hourly postpaid instances (`POSTPAID_BY_HOUR`). <br><li>GB: bill by traffic in GB. It's used for postpaid products that are billed by the hourly traffic (`TRAFFIC_POSTPAID_BY_HOUR`).
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// The original price of a pay-in-advance instance, in USD.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// Discount price of a prepaid instance, in USD.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// Discount. For example, 20.0 indicates 80% off.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// The discounted unit price for pay-as-you-go mode in USD. <br><li>When a billing tier is returned, it indicates the price fo the returned billing tier. For example, if `UnitPriceSecondStep` is returned, it refers to the unit price for the usage between 0 to 96 hours. Otherwise, it refers to that the unit price for unlimited usage.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// Original unit price for the usage between 96 to 360 hours in USD. It's applicable to pay-as-you-go mode.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UnitPriceSecondStep")]
        public float? UnitPriceSecondStep{ get; set; }

        /// <summary>
        /// Discounted unit price for the usage between 96 to 360 hours in USD. It's applicable to pay-as-you-go mode.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscountSecondStep")]
        public float? UnitPriceDiscountSecondStep{ get; set; }

        /// <summary>
        /// Original unit price for the usage after 360 hours in USD. It's applicable to pay-as-you-go mode.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UnitPriceThirdStep")]
        public float? UnitPriceThirdStep{ get; set; }

        /// <summary>
        /// Discounted unit price for the usage after 360 hours in USD. It's applicable to pay-as-you-go mode.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscountThirdStep")]
        public float? UnitPriceDiscountThirdStep{ get; set; }

        /// <summary>
        /// Original 3-year payment, in USD. This parameter is only available to upfront payment mode.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OriginalPriceThreeYear")]
        public float? OriginalPriceThreeYear{ get; set; }

        /// <summary>
        /// Discounted 3-year upfront payment, in USD. This parameter is only available to upfront payment mode.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DiscountPriceThreeYear")]
        public float? DiscountPriceThreeYear{ get; set; }

        /// <summary>
        /// Discount for 3-year upfront payment. For example, 20.0 indicates 80% off.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DiscountThreeYear")]
        public float? DiscountThreeYear{ get; set; }

        /// <summary>
        /// Original 5-year payment, in USD. This parameter is only available to upfront payment mode.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OriginalPriceFiveYear")]
        public float? OriginalPriceFiveYear{ get; set; }

        /// <summary>
        /// Discounted 5-year upfront payment, in USD. This parameter is only available to upfront payment mode.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DiscountPriceFiveYear")]
        public float? DiscountPriceFiveYear{ get; set; }

        /// <summary>
        /// Discount for 5-year upfront payment. For example, 20.0 indicates 80% off.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DiscountFiveYear")]
        public float? DiscountFiveYear{ get; set; }

        /// <summary>
        /// Original 1-year payment, in USD. This parameter is only available to upfront payment mode.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OriginalPriceOneYear")]
        public float? OriginalPriceOneYear{ get; set; }

        /// <summary>
        /// Discounted 1-year payment, in USD. This parameter is only available to upfront payment mode.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DiscountPriceOneYear")]
        public float? DiscountPriceOneYear{ get; set; }

        /// <summary>
        /// Discount for 1-year upfront payment. For example, 20.0 indicates 80% off.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Note: this field may return `null`, indicating that no valid value was found.
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

