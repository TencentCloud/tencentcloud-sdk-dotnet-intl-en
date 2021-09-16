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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceCreateProxyResponse : AbstractModel
    {
        
        /// <summary>
        /// Basic price of connection in USD/day.
        /// </summary>
        [JsonProperty("ProxyDailyPrice")]
        public float? ProxyDailyPrice{ get; set; }

        /// <summary>
        /// Tiered price of connection bandwidth.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BandwidthUnitPrice")]
        public BandwidthPriceGradient[] BandwidthUnitPrice{ get; set; }

        /// <summary>
        /// Discounted basic price of connection in USD/day.
        /// </summary>
        [JsonProperty("DiscountProxyDailyPrice")]
        public float? DiscountProxyDailyPrice{ get; set; }

        /// <summary>
        /// Currency, which supports CNY, USD, etc.
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Connection traffic price in USD/GB.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FlowUnitPrice")]
        public float? FlowUnitPrice{ get; set; }

        /// <summary>
        /// Discounted connection traffic price in USD/GB.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiscountFlowUnitPrice")]
        public float? DiscountFlowUnitPrice{ get; set; }

        /// <summary>
        /// Dedicated BGP bandwidth price. Unit: USD/Mbps/day
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Cn2BandwidthPrice")]
        public float? Cn2BandwidthPrice{ get; set; }

        /// <summary>
        /// Dedicated BGP bandwidth discount price. Unit: USD/Mbps/day
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Cn2BandwidthPriceWithDiscount")]
        public float? Cn2BandwidthPriceWithDiscount{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyDailyPrice", this.ProxyDailyPrice);
            this.SetParamArrayObj(map, prefix + "BandwidthUnitPrice.", this.BandwidthUnitPrice);
            this.SetParamSimple(map, prefix + "DiscountProxyDailyPrice", this.DiscountProxyDailyPrice);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "FlowUnitPrice", this.FlowUnitPrice);
            this.SetParamSimple(map, prefix + "DiscountFlowUnitPrice", this.DiscountFlowUnitPrice);
            this.SetParamSimple(map, prefix + "Cn2BandwidthPrice", this.Cn2BandwidthPrice);
            this.SetParamSimple(map, prefix + "Cn2BandwidthPriceWithDiscount", this.Cn2BandwidthPriceWithDiscount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

