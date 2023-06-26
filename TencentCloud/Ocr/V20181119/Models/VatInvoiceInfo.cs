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

    public class VatInvoiceInfo : AbstractModel
    {
        
        /// <summary>
        /// Check code
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// Form type
        /// </summary>
        [JsonProperty("FormType")]
        public string FormType{ get; set; }

        /// <summary>
        /// Vehicle and vessel tax
        /// </summary>
        [JsonProperty("TravelTax")]
        public string TravelTax{ get; set; }

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
        /// Company seal content
        /// </summary>
        [JsonProperty("CompanySealContent")]
        public string CompanySealContent{ get; set; }

        /// <summary>
        /// Tax authority seal content
        /// </summary>
        [JsonProperty("TaxSealContent")]
        public string TaxSealContent{ get; set; }

        /// <summary>
        /// Service type
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Whether there is a QR code (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// Whether there is an agent (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("AgentMark")]
        public long? AgentMark{ get; set; }

        /// <summary>
        /// Whether there is a toll (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("TransitMark")]
        public long? TransitMark{ get; set; }

        /// <summary>
        /// Whether there is refined oil (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("OilMark")]
        public long? OilMark{ get; set; }

        /// <summary>
        /// Invoice title
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Invoice type
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

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
        /// Machine-printed invoice number
        /// </summary>
        [JsonProperty("NumberConfirm")]
        public string NumberConfirm{ get; set; }

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
        /// Amount before tax
        /// </summary>
        [JsonProperty("PretaxAmount")]
        public string PretaxAmount{ get; set; }

        /// <summary>
        /// Tax
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// Machine No.
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// Ciphertext
        /// </summary>
        [JsonProperty("Ciphertext")]
        public string Ciphertext{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

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
        /// Whether there is a company seal (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// Issuer
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// Reviewer
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// Province
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// Information about VAT invoice items
        /// </summary>
        [JsonProperty("VatInvoiceItemInfos")]
        public VatInvoiceItemInfo[] VatInvoiceItemInfos{ get; set; }

        /// <summary>
        /// Machine-printed invoice code
        /// </summary>
        [JsonProperty("CodeConfirm")]
        public string CodeConfirm{ get; set; }

        /// <summary>
        /// Payee
        /// </summary>
        [JsonProperty("Receiptor")]
        public string Receiptor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ElectronicFullMark")]
        public long? ElectronicFullMark{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ElectronicFullNumber")]
        public string ElectronicFullNumber{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FormName")]
        public string FormName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "FormType", this.FormType);
            this.SetParamSimple(map, prefix + "TravelTax", this.TravelTax);
            this.SetParamSimple(map, prefix + "BuyerAddrTel", this.BuyerAddrTel);
            this.SetParamSimple(map, prefix + "BuyerBankAccount", this.BuyerBankAccount);
            this.SetParamSimple(map, prefix + "CompanySealContent", this.CompanySealContent);
            this.SetParamSimple(map, prefix + "TaxSealContent", this.TaxSealContent);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "AgentMark", this.AgentMark);
            this.SetParamSimple(map, prefix + "TransitMark", this.TransitMark);
            this.SetParamSimple(map, prefix + "OilMark", this.OilMark);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "NumberConfirm", this.NumberConfirm);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "Ciphertext", this.Ciphertext);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerAddrTel", this.SellerAddrTel);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamArrayObj(map, prefix + "VatInvoiceItemInfos.", this.VatInvoiceItemInfos);
            this.SetParamSimple(map, prefix + "CodeConfirm", this.CodeConfirm);
            this.SetParamSimple(map, prefix + "Receiptor", this.Receiptor);
            this.SetParamSimple(map, prefix + "ElectronicFullMark", this.ElectronicFullMark);
            this.SetParamSimple(map, prefix + "ElectronicFullNumber", this.ElectronicFullNumber);
            this.SetParamSimple(map, prefix + "FormName", this.FormName);
        }
    }
}

