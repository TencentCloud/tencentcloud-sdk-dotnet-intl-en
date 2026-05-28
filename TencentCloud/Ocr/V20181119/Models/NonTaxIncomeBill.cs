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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NonTaxIncomeBill : AbstractModel
    {
        
        /// <summary>
        /// Invoice title
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Invoice number
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// Invoice code
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// Check code
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// Date of issue
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Total amount (in figures)
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// Total amount (in words)
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// Payer's name
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// Payer's taxpayer identification number
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// Payee's name
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// Payee's company name
        /// </summary>
        [JsonProperty("SellerCompany")]
        public string SellerCompany{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// Reviewer
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// Whether there is a QR code (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// Other information
        /// </summary>
        [JsonProperty("OtherInfo")]
        public string OtherInfo{ get; set; }

        /// <summary>
        /// Payment code
        /// </summary>
        [JsonProperty("PaymentCode")]
        public string PaymentCode{ get; set; }

        /// <summary>
        /// Collecting organization's code
        /// </summary>
        [JsonProperty("ReceiveUnitCode")]
        public string ReceiveUnitCode{ get; set; }

        /// <summary>
        /// Collecting organization's name
        /// </summary>
        [JsonProperty("Receiver")]
        public string Receiver{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Payer's account
        /// </summary>
        [JsonProperty("PayerAccount")]
        public string PayerAccount{ get; set; }

        /// <summary>
        /// Payer's account opening bank
        /// </summary>
        [JsonProperty("PayerBank")]
        public string PayerBank{ get; set; }

        /// <summary>
        /// Payee's account
        /// </summary>
        [JsonProperty("ReceiverAccount")]
        public string ReceiverAccount{ get; set; }

        /// <summary>
        /// Payee's account opening bank
        /// </summary>
        [JsonProperty("ReceiverBank")]
        public string ReceiverBank{ get; set; }

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty("NonTaxItems")]
        public NonTaxItem[] NonTaxItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerCompany", this.SellerCompany);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CurrencyCode", this.CurrencyCode);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "OtherInfo", this.OtherInfo);
            this.SetParamSimple(map, prefix + "PaymentCode", this.PaymentCode);
            this.SetParamSimple(map, prefix + "ReceiveUnitCode", this.ReceiveUnitCode);
            this.SetParamSimple(map, prefix + "Receiver", this.Receiver);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "PayerAccount", this.PayerAccount);
            this.SetParamSimple(map, prefix + "PayerBank", this.PayerBank);
            this.SetParamSimple(map, prefix + "ReceiverAccount", this.ReceiverAccount);
            this.SetParamSimple(map, prefix + "ReceiverBank", this.ReceiverBank);
            this.SetParamArrayObj(map, prefix + "NonTaxItems.", this.NonTaxItems);
        }
    }
}

