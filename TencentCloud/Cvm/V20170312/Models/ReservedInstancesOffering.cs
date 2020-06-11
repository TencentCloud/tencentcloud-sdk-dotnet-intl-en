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

    public class ReservedInstancesOffering : AbstractModel
    {
        
        /// <summary>
        /// The availability zones in which the Reserved Instance can be purchased, such as ap-guangzhou-1.
        /// Valid value: <a href="https://cloud.tencent.com/document/product/213/6091">Availability Zones</a>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// The currency of the Reserved Instance you are purchasing. It's specified using ISO 4217 standard currency.
        /// Valid value: USD.
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// The **duration** of the Reserved Instance in seconds, which is the purchased usage period. For example, 31536000.
        /// Unit: second
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// The purchase price of the Reserved Instance, such as 4000.0.
        /// Unit: this field uses the currency code specified in `currencyCode`, and only supports “USD” at this time.
        /// </summary>
        [JsonProperty("FixedPrice")]
        public float? FixedPrice{ get; set; }

        /// <summary>
        /// The instance type on which the Reserved Instance can be used, such as S3.MEDIUM4.
        /// Valid value: <a href="https://cloud.tencent.com/product/cvm/instances">Instance Types</a>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// The payment term of the Reserved Instance, such as All Upfront.
        /// Valid value: All Upfront.
        /// </summary>
        [JsonProperty("OfferingType")]
        public string OfferingType{ get; set; }

        /// <summary>
        /// The ID of the Reserved Instance offering, such as 650c138f-ae7e-4750-952a-96841d6e9fc1.
        /// </summary>
        [JsonProperty("ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId{ get; set; }

        /// <summary>
        /// The platform description (operating system) of the Reserved Instance, such as linux.
        /// Valid value: linux.
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// The hourly usage price of the Reserved Instance, such as 0.0.
        /// Currently, the only supported payment is “All Upfront”, so the default value of `UsagePrice` is 0 USD/hr.
        /// Unit: USD/hr. This field uses the currency code specified in `currencyCode`, and only supports “USD” at this time.
        /// </summary>
        [JsonProperty("UsagePrice")]
        public float? UsagePrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CurrencyCode", this.CurrencyCode);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "FixedPrice", this.FixedPrice);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "OfferingType", this.OfferingType);
            this.SetParamSimple(map, prefix + "ReservedInstancesOfferingId", this.ReservedInstancesOfferingId);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "UsagePrice", this.UsagePrice);
        }
    }
}

