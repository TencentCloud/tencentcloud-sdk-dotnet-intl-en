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

    public class MotorVehicleSaleInvoice : AbstractModel
    {
        
        /// <summary>
        /// Invoice title
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

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
        /// Seller's name
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// Seller's company code
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// Seller's phone number
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// Seller's address
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// Seller's account opening bank
        /// </summary>
        [JsonProperty("SellerBank")]
        public string SellerBank{ get; set; }

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
        /// Buyer's ID number/organization code
        /// </summary>
        [JsonProperty("BuyerID")]
        public string BuyerID{ get; set; }

        /// <summary>
        /// Tax authority
        /// </summary>
        [JsonProperty("TaxAuthorities")]
        public string TaxAuthorities{ get; set; }

        /// <summary>
        /// Code of the tax authority
        /// </summary>
        [JsonProperty("TaxAuthoritiesCode")]
        public string TaxAuthoritiesCode{ get; set; }

        /// <summary>
        /// VIN
        /// </summary>
        [JsonProperty("VIN")]
        public string VIN{ get; set; }

        /// <summary>
        /// Vehicle model
        /// </summary>
        [JsonProperty("VehicleModel")]
        public string VehicleModel{ get; set; }

        /// <summary>
        /// Engine No.
        /// </summary>
        [JsonProperty("VehicleEngineCode")]
        public string VehicleEngineCode{ get; set; }

        /// <summary>
        /// No. of the certificate of conformity
        /// </summary>
        [JsonProperty("CertificateNumber")]
        public string CertificateNumber{ get; set; }

        /// <summary>
        /// Inspection No.
        /// </summary>
        [JsonProperty("InspectionNumber")]
        public string InspectionNumber{ get; set; }

        /// <summary>
        /// Machine No.
        /// </summary>
        [JsonProperty("MachineID")]
        public string MachineID{ get; set; }

        /// <summary>
        /// Vehicle type
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

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
        /// Tax
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// Tax rate
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// Whether there is a company seal (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// Tonnage
        /// </summary>
        [JsonProperty("Tonnage")]
        public string Tonnage{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Form type
        /// </summary>
        [JsonProperty("FormType")]
        public string FormType{ get; set; }

        /// <summary>
        /// Form name
        /// </summary>
        [JsonProperty("FormName")]
        public string FormName{ get; set; }

        /// <summary>
        /// Issuer
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// Tax payment voucher number
        /// </summary>
        [JsonProperty("TaxNum")]
        public string TaxNum{ get; set; }

        /// <summary>
        /// Passenger capacity
        /// </summary>
        [JsonProperty("MaxPeopleNum")]
        public string MaxPeopleNum{ get; set; }

        /// <summary>
        /// Origin
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Machine-printed invoice code
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// Machine-printed invoice number
        /// </summary>
        [JsonProperty("MachineNumber")]
        public string MachineNumber{ get; set; }

        /// <summary>
        /// Whether there is a QR code (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "SellerBank", this.SellerBank);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "BuyerID", this.BuyerID);
            this.SetParamSimple(map, prefix + "TaxAuthorities", this.TaxAuthorities);
            this.SetParamSimple(map, prefix + "TaxAuthoritiesCode", this.TaxAuthoritiesCode);
            this.SetParamSimple(map, prefix + "VIN", this.VIN);
            this.SetParamSimple(map, prefix + "VehicleModel", this.VehicleModel);
            this.SetParamSimple(map, prefix + "VehicleEngineCode", this.VehicleEngineCode);
            this.SetParamSimple(map, prefix + "CertificateNumber", this.CertificateNumber);
            this.SetParamSimple(map, prefix + "InspectionNumber", this.InspectionNumber);
            this.SetParamSimple(map, prefix + "MachineID", this.MachineID);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "Tonnage", this.Tonnage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FormType", this.FormType);
            this.SetParamSimple(map, prefix + "FormName", this.FormName);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "TaxNum", this.TaxNum);
            this.SetParamSimple(map, prefix + "MaxPeopleNum", this.MaxPeopleNum);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "MachineNumber", this.MachineNumber);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
        }
    }
}

