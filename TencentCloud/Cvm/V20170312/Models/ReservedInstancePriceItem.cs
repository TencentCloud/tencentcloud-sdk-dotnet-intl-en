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

    public class ReservedInstancePriceItem : AbstractModel
    {
        
        /// <summary>
        /// Payment method. Valid values: All Upfront, Partial Upfront, and No Upfront.
        /// </summary>
        [JsonProperty("OfferingType")]
        public string OfferingType{ get; set; }

        /// <summary>
        /// Upfront payment, in USD.
        /// </summary>
        [JsonProperty("FixedPrice")]
        public float? FixedPrice{ get; set; }

        /// <summary>
        /// Subsequent unit price, in USD/hr.
        /// </summary>
        [JsonProperty("UsagePrice")]
        public float? UsagePrice{ get; set; }

        /// <summary>
        /// The ID of the reserved instance offering.
        /// </summary>
        [JsonProperty("ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId{ get; set; }

        /// <summary>
        /// The availability zone in which the reserved instance can be purchased.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// The **validity** of the reserved instance in seconds, which is the purchased usage period. For example, `31536000`.
        /// Unit: second
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// The operating system of the reserved instance, such as `Linux`.
        /// Valid value: `Linux`.
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// Upfront total cost, in USD.
        /// </summary>
        [JsonProperty("DiscountUsagePrice")]
        public float? DiscountUsagePrice{ get; set; }

        /// <summary>
        /// Discount price for subsequent total cost, in USD/hr.
        /// </summary>
        [JsonProperty("DiscountFixedPrice")]
        public float? DiscountFixedPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OfferingType", this.OfferingType);
            this.SetParamSimple(map, prefix + "FixedPrice", this.FixedPrice);
            this.SetParamSimple(map, prefix + "UsagePrice", this.UsagePrice);
            this.SetParamSimple(map, prefix + "ReservedInstancesOfferingId", this.ReservedInstancesOfferingId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "DiscountUsagePrice", this.DiscountUsagePrice);
            this.SetParamSimple(map, prefix + "DiscountFixedPrice", this.DiscountFixedPrice);
        }
    }
}

