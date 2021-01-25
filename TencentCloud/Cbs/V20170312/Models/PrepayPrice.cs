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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrepayPrice : AbstractModel
    {
        
        /// <summary>
        /// Original price of the advanced payment for a prepaid cloud disk or snapshot (in CNY).
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// Discount price of the advanced payment for a prepaid cloud disk or snapshot (in CNY).
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// Highly-precise published unit price of a monthly-subscribed cloud disk or a snapshot, in USD.
        /// </summary>
        [JsonProperty("OriginalPriceHigh")]
        public string OriginalPriceHigh{ get; set; }

        /// <summary>
        /// Highly-precise discounted unit price of a monthly-subscribed cloud disk or a snapshot, in USD.
        /// </summary>
        [JsonProperty("DiscountPriceHigh")]
        public string DiscountPriceHigh{ get; set; }

        /// <summary>
        /// Published unit price of a pay-as-you-go cloud disk, in USD.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPrice")]
        public string UnitPrice{ get; set; }

        /// <summary>
        /// Billing unit for pay-as-you-go cloud disks. Valid value: <br><li>HOUR: billed hourly.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// Discount unit price of a pay-as-you-go cloud disk, in USD.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public string UnitPriceDiscount{ get; set; }

        /// <summary>
        /// Highly-precise published unit price of a pay-as-you-go cloud disk, in USD.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceHigh")]
        public string UnitPriceHigh{ get; set; }

        /// <summary>
        /// Highly-precise discounted unit price of a pay-as-you-go cloud disk, in USD.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnitPriceDiscountHigh")]
        public string UnitPriceDiscountHigh{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "OriginalPriceHigh", this.OriginalPriceHigh);
            this.SetParamSimple(map, prefix + "DiscountPriceHigh", this.DiscountPriceHigh);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPriceHigh", this.UnitPriceHigh);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountHigh", this.UnitPriceDiscountHigh);
        }
    }
}

