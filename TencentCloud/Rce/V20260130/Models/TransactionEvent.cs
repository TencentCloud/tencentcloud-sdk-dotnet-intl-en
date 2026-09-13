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

    public class TransactionEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The unique ID of the transaction</p>
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>The ID(s) of the order associated with the transaction</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string[] OrderId{ get; set; }

        /// <summary>
        /// <p>The amount of the transaction</p>
        /// </summary>
        [JsonProperty("PaymentAmount")]
        public Amount PaymentAmount{ get; set; }

        /// <summary>
        /// <p>The detail information of the payment method associated with the transaction</p>
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public PaymentMethod PaymentMethod{ get; set; }

        /// <summary>
        /// <p>Transaction type</p><p>Enumeration value:</p><ul><li>sale: One-time authorization and deduction (most common)</li><li>authorize: Authorization only (frozen amount)</li><li>capture: Execute deduction (after authorization)</li><li>void: Cancel pending authorization or deduction</li><li>refund: Refund (part or all)</li><li>deposit: Deposit to account</li><li>withdrawal: Withdrawal from account</li><li>transfer: Fund transfer between accounts</li><li>buy: Purchase asset (for example, crypto currency)</li><li>sell: Sell asset</li><li>send: Send fund/asset (for example, cross-wallet transfer)</li><li>receive: Receive fund/asset</li></ul><p>Default value: sale</p>
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType{ get; set; }

        /// <summary>
        /// <p>Bill information</p>
        /// </summary>
        [JsonProperty("Billing")]
        public Billing Billing{ get; set; }

        /// <summary>
        /// <p>Delivery information</p>
        /// </summary>
        [JsonProperty("Delivery")]
        public Delivery Delivery{ get; set; }

        /// <summary>
        /// <p>Merchant information</p>
        /// </summary>
        [JsonProperty("Merchant")]
        public Merchant Merchant{ get; set; }

        /// <summary>
        /// <p>Payment result</p>
        /// </summary>
        [JsonProperty("PaymentResult")]
        public PaymentResult PaymentResult{ get; set; }

        /// <summary>
        /// <p>The ID of the recipent in transfer transaction</p>
        /// </summary>
        [JsonProperty("TransferRecipientUserId")]
        public string TransferRecipientUserId{ get; set; }

        /// <summary>
        /// <p>The address of the sender in transfer transaction</p>
        /// </summary>
        [JsonProperty("TransferSentAddress")]
        public Address TransferSentAddress{ get; set; }

        /// <summary>
        /// <p>Physical address of the recipient, applicable to the transfer transaction type.</p>
        /// </summary>
        [JsonProperty("TransferReceivedAddress")]
        public Address TransferReceivedAddress{ get; set; }

        /// <summary>
        /// <p>The digital order(s) associated with the transaction</p>
        /// </summary>
        [JsonProperty("DigitalOrders")]
        public DigitalOrder[] DigitalOrders{ get; set; }

        /// <summary>
        /// <p>Wallet to receive crypto currency</p>
        /// </summary>
        [JsonProperty("ReceiverWallet")]
        public Wallet ReceiverWallet{ get; set; }

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
            this.SetParamObj(map, prefix + "PaymentAmount.", this.PaymentAmount);
            this.SetParamObj(map, prefix + "PaymentMethod.", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "TransactionType", this.TransactionType);
            this.SetParamObj(map, prefix + "Billing.", this.Billing);
            this.SetParamObj(map, prefix + "Delivery.", this.Delivery);
            this.SetParamObj(map, prefix + "Merchant.", this.Merchant);
            this.SetParamObj(map, prefix + "PaymentResult.", this.PaymentResult);
            this.SetParamSimple(map, prefix + "TransferRecipientUserId", this.TransferRecipientUserId);
            this.SetParamObj(map, prefix + "TransferSentAddress.", this.TransferSentAddress);
            this.SetParamObj(map, prefix + "TransferReceivedAddress.", this.TransferReceivedAddress);
            this.SetParamArrayObj(map, prefix + "DigitalOrders.", this.DigitalOrders);
            this.SetParamObj(map, prefix + "ReceiverWallet.", this.ReceiverWallet);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

