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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrderEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the order</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// <p>The amount of the order</p>
        /// </summary>
        [JsonProperty("Amount")]
        public Amount Amount{ get; set; }

        /// <summary>
        /// <p>The detail information of the merchant associated with the order</p>
        /// </summary>
        [JsonProperty("Merchant")]
        public Merchant Merchant{ get; set; }

        /// <summary>
        /// <p>The detail information of the bill associated with the order</p>
        /// </summary>
        [JsonProperty("Billing")]
        public Billing Billing{ get; set; }

        /// <summary>
        /// <p>The detail information of the items in the order</p>
        /// </summary>
        [JsonProperty("Items")]
        public Item[] Items{ get; set; }

        /// <summary>
        /// <p>The detail information of the delivery associated with the order</p>
        /// </summary>
        [JsonProperty("Delivery")]
        public Delivery Delivery{ get; set; }

        /// <summary>
        /// <p>The promotion(s) associated with the order</p>
        /// </summary>
        [JsonProperty("Promotions")]
        public Promotion[] Promotions{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamObj(map, prefix + "Amount.", this.Amount);
            this.SetParamObj(map, prefix + "Merchant.", this.Merchant);
            this.SetParamObj(map, prefix + "Billing.", this.Billing);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamObj(map, prefix + "Delivery.", this.Delivery);
            this.SetParamArrayObj(map, prefix + "Promotions.", this.Promotions);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

