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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachinePrintedInvoice : AbstractModel
    {
        
        /// <summary>
        /// Invoice title
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Whether there is a QR code (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// Invoice code
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// Invoice number
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// Date of issue
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Time
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Check code
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// Ciphertext
        /// </summary>
        [JsonProperty("Ciphertext")]
        public string Ciphertext{ get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Amount before tax
        /// </summary>
        [JsonProperty("PretaxAmount")]
        public string PretaxAmount{ get; set; }

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
        /// Tax
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// Industry
        /// </summary>
        [JsonProperty("IndustryClass")]
        public string IndustryClass{ get; set; }

        /// <summary>
        /// Seller's name
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// Seller's taxpayer identification number
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// Seller's address and phone number
        /// </summary>
        [JsonProperty("SellerAddrTel")]
        public string SellerAddrTel{ get; set; }

        /// <summary>
        /// Seller's bank account number
        /// </summary>
        [JsonProperty("SellerBankAccount")]
        public string SellerBankAccount{ get; set; }

        /// <summary>
        /// Buyer's name
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// Buyer's taxpayer identification number
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// Buyer's address and phone number
        /// </summary>
        [JsonProperty("BuyerAddrTel")]
        public string BuyerAddrTel{ get; set; }

        /// <summary>
        /// Buyer's bank account number
        /// </summary>
        [JsonProperty("BuyerBankAccount")]
        public string BuyerBankAccount{ get; set; }

        /// <summary>
        /// Invoice type
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Province
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Whether there is a company seal (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// Whether it is a general machine-printed invoice issued by Zhejiang or Guangdong province (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("ElectronicMark")]
        public long? ElectronicMark{ get; set; }

        /// <summary>
        /// Issuer
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// Payee
        /// </summary>
        [JsonProperty("Receiptor")]
        public string Receiptor{ get; set; }

        /// <summary>
        /// Reviewer
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Operator's payment information
        /// </summary>
        [JsonProperty("PaymentInfo")]
        public string PaymentInfo{ get; set; }

        /// <summary>
        /// Operator-assigned invoice pickup user
        /// </summary>
        [JsonProperty("TicketPickupUser")]
        public string TicketPickupUser{ get; set; }

        /// <summary>
        /// Operator's merchant number
        /// </summary>
        [JsonProperty("MerchantNumber")]
        public string MerchantNumber{ get; set; }

        /// <summary>
        /// Operator's order number
        /// </summary>
        [JsonProperty("OrderNumber")]
        public string OrderNumber{ get; set; }

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty("GeneralMachineItems")]
        public GeneralMachineItem[] GeneralMachineItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Ciphertext", this.Ciphertext);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "IndustryClass", this.IndustryClass);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerAddrTel", this.SellerAddrTel);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "BuyerAddrTel", this.BuyerAddrTel);
            this.SetParamSimple(map, prefix + "BuyerBankAccount", this.BuyerBankAccount);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "ElectronicMark", this.ElectronicMark);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Receiptor", this.Receiptor);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PaymentInfo", this.PaymentInfo);
            this.SetParamSimple(map, prefix + "TicketPickupUser", this.TicketPickupUser);
            this.SetParamSimple(map, prefix + "MerchantNumber", this.MerchantNumber);
            this.SetParamSimple(map, prefix + "OrderNumber", this.OrderNumber);
            this.SetParamArrayObj(map, prefix + "GeneralMachineItems.", this.GeneralMachineItems);
        }
    }
}

