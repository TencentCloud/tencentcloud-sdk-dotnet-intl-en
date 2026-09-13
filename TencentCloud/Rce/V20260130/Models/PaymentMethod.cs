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

    public class PaymentMethod : AbstractModel
    {
        
        /// <summary>
        /// <p>Payment method</p><p>Enumeration value:</p><ul><li>cash</li><li>check</li><li>credit_card</li><li>debit_card</li><li>crypto_currency</li><li>digital_wallet</li><li>gift_card</li><li>points</li><li>in_app_purchase</li><li>electronic_fund_transfer</li><li>financing</li><li>invoice</li><li>prepaid_card</li><li>sepa_credit</li></ul>
        /// </summary>
        [JsonProperty("PaymentType")]
        public string PaymentType{ get; set; }

        /// <summary>
        /// <p>The channel of the payment</p>
        /// </summary>
        [JsonProperty("PaymentChannel")]
        public string PaymentChannel{ get; set; }

        /// <summary>
        /// <p>The details of the card.Required while PaymentMethod is "credit_card","debit_card"</p>
        /// </summary>
        [JsonProperty("Card")]
        public Card Card{ get; set; }

        /// <summary>
        /// <p>SEPA direct debit mandate</p><p>Enumeration value:</p><ul><li>true: Yes</li><li>false: No</li></ul>
        /// </summary>
        [JsonProperty("SEPADirectDebitMandate")]
        public bool? SEPADirectDebitMandate{ get; set; }

        /// <summary>
        /// <p>The details of the digital wallet when involved digital trade</p>
        /// </summary>
        [JsonProperty("DigitalWallet")]
        public Wallet DigitalWallet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PaymentType", this.PaymentType);
            this.SetParamSimple(map, prefix + "PaymentChannel", this.PaymentChannel);
            this.SetParamObj(map, prefix + "Card.", this.Card);
            this.SetParamSimple(map, prefix + "SEPADirectDebitMandate", this.SEPADirectDebitMandate);
            this.SetParamObj(map, prefix + "DigitalWallet.", this.DigitalWallet);
        }
    }
}

