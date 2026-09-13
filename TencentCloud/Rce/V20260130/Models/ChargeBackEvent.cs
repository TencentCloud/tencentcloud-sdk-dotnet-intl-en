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

    public class ChargeBackEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the transaction</p>
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>The ID(s) of the order associated with the transaction</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string[] OrderId{ get; set; }

        /// <summary>
        /// <p>The code of the chargeback defined by the card organization, for example: 10.1, 13.1, 4870, 4871</p>
        /// </summary>
        [JsonProperty("ChargeBackCode")]
        public string ChargeBackCode{ get; set; }

        /// <summary>
        /// <p>The reason of the chargeback defined by the card organization, for example: non-receipt of goods, fraud</p>
        /// </summary>
        [JsonProperty("ChargeBackReason")]
        public string ChargeBackReason{ get; set; }

        /// <summary>
        /// <p>The process of the chargeback defined by the card organization</p><p>Enumeration values:</p><ul><li>need_response: Merchant needs to respond</li><li>information_supplied: Merchant has provided information</li><li>chargeback_reversed: Chargeback has been canceled</li><li>chargeback_sustained: Chargeback has been established</li></ul>
        /// </summary>
        [JsonProperty("ChargeBackProcess")]
        public string ChargeBackProcess{ get; set; }

        /// <summary>
        /// <p>The amount of the chargeback</p>
        /// </summary>
        [JsonProperty("ChargeBackAmount")]
        public Amount ChargeBackAmount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamArraySimple(map, prefix + "OrderId.", this.OrderId);
            this.SetParamSimple(map, prefix + "ChargeBackCode", this.ChargeBackCode);
            this.SetParamSimple(map, prefix + "ChargeBackReason", this.ChargeBackReason);
            this.SetParamSimple(map, prefix + "ChargeBackProcess", this.ChargeBackProcess);
            this.SetParamObj(map, prefix + "ChargeBackAmount.", this.ChargeBackAmount);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

