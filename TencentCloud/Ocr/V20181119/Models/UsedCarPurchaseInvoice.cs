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

    public class UsedCarPurchaseInvoice : AbstractModel
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
        /// Seller's phone number
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// Seller's company code/personal ID card number
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// Seller's address
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// Buyer's name
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// Buyer's company code/personal ID card number
        /// </summary>
        [JsonProperty("BuyerID")]
        public string BuyerID{ get; set; }

        /// <summary>
        /// Buyer's address
        /// </summary>
        [JsonProperty("BuyerAddress")]
        public string BuyerAddress{ get; set; }

        /// <summary>
        /// Buyer's phone number
        /// </summary>
        [JsonProperty("BuyerTel")]
        public string BuyerTel{ get; set; }

        /// <summary>
        /// Company (used car market) name
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// Company's taxpayer identification number
        /// </summary>
        [JsonProperty("CompanyTaxID")]
        public string CompanyTaxID{ get; set; }

        /// <summary>
        /// Company's account opening bank and account number
        /// </summary>
        [JsonProperty("CompanyBankAccount")]
        public string CompanyBankAccount{ get; set; }

        /// <summary>
        /// Company's phone number
        /// </summary>
        [JsonProperty("CompanyTel")]
        public string CompanyTel{ get; set; }

        /// <summary>
        /// Company's address
        /// </summary>
        [JsonProperty("CompanyAddress")]
        public string CompanyAddress{ get; set; }

        /// <summary>
        /// Name of the transfer-to department of motor vehicles
        /// </summary>
        [JsonProperty("TransferAdministrationName")]
        public string TransferAdministrationName{ get; set; }

        /// <summary>
        /// License plate number
        /// </summary>
        [JsonProperty("LicensePlate")]
        public string LicensePlate{ get; set; }

        /// <summary>
        /// Registration certificate No.
        /// </summary>
        [JsonProperty("RegistrationNumber")]
        public string RegistrationNumber{ get; set; }

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
        /// Vehicle type
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

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
        /// Whether there is a company seal (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }


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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerID", this.BuyerID);
            this.SetParamSimple(map, prefix + "BuyerAddress", this.BuyerAddress);
            this.SetParamSimple(map, prefix + "BuyerTel", this.BuyerTel);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyTaxID", this.CompanyTaxID);
            this.SetParamSimple(map, prefix + "CompanyBankAccount", this.CompanyBankAccount);
            this.SetParamSimple(map, prefix + "CompanyTel", this.CompanyTel);
            this.SetParamSimple(map, prefix + "CompanyAddress", this.CompanyAddress);
            this.SetParamSimple(map, prefix + "TransferAdministrationName", this.TransferAdministrationName);
            this.SetParamSimple(map, prefix + "LicensePlate", this.LicensePlate);
            this.SetParamSimple(map, prefix + "RegistrationNumber", this.RegistrationNumber);
            this.SetParamSimple(map, prefix + "VIN", this.VIN);
            this.SetParamSimple(map, prefix + "VehicleModel", this.VehicleModel);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FormType", this.FormType);
            this.SetParamSimple(map, prefix + "FormName", this.FormName);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
        }
    }
}

