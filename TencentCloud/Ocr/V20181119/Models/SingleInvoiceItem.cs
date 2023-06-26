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

    public class SingleInvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// Special VAT invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatSpecialInvoice")]
        public VatInvoiceInfo VatSpecialInvoice{ get; set; }

        /// <summary>
        /// General VAT invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatCommonInvoice")]
        public VatInvoiceInfo VatCommonInvoice{ get; set; }

        /// <summary>
        /// Electronic general VAT invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatElectronicCommonInvoice")]
        public VatInvoiceInfo VatElectronicCommonInvoice{ get; set; }

        /// <summary>
        /// Electronic special VAT invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatElectronicSpecialInvoice")]
        public VatInvoiceInfo VatElectronicSpecialInvoice{ get; set; }

        /// <summary>
        /// Blockchain electronic invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatElectronicInvoiceBlockchain")]
        public VatInvoiceInfo VatElectronicInvoiceBlockchain{ get; set; }

        /// <summary>
        /// Electronic general VAT invoice (toll)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatElectronicInvoiceToll")]
        public VatInvoiceInfo VatElectronicInvoiceToll{ get; set; }

        /// <summary>
        /// Electronic invoice (special)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatElectronicSpecialInvoiceFull")]
        public VatElectronicInfo VatElectronicSpecialInvoiceFull{ get; set; }

        /// <summary>
        /// Electronic invoice (general)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatElectronicInvoiceFull")]
        public VatElectronicInfo VatElectronicInvoiceFull{ get; set; }

        /// <summary>
        /// General machine-printed invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachinePrintedInvoice")]
        public MachinePrintedInvoice MachinePrintedInvoice{ get; set; }

        /// <summary>
        /// Bus ticket
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusInvoice")]
        public BusInvoice BusInvoice{ get; set; }

        /// <summary>
        /// Ship ticket
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShippingInvoice")]
        public ShippingInvoice ShippingInvoice{ get; set; }

        /// <summary>
        /// Toll receipt
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TollInvoice")]
        public TollInvoice TollInvoice{ get; set; }

        /// <summary>
        /// Other invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OtherInvoice")]
        public OtherInvoice OtherInvoice{ get; set; }

        /// <summary>
        /// Motor vehicle sales invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MotorVehicleSaleInvoice")]
        public MotorVehicleSaleInvoice MotorVehicleSaleInvoice{ get; set; }

        /// <summary>
        /// Used car invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsedCarPurchaseInvoice")]
        public UsedCarPurchaseInvoice UsedCarPurchaseInvoice{ get; set; }

        /// <summary>
        /// General VAT invoice (roll)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VatInvoiceRoll")]
        public VatInvoiceRoll VatInvoiceRoll{ get; set; }

        /// <summary>
        /// Taxi receipt
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaxiTicket")]
        public TaxiTicket TaxiTicket{ get; set; }

        /// <summary>
        /// Quota invoice
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QuotaInvoice")]
        public QuotaInvoice QuotaInvoice{ get; set; }

        /// <summary>
        /// Itinerary/Receipt of e-ticket for air transportation
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AirTransport")]
        public AirTransport AirTransport{ get; set; }

        /// <summary>
        /// Non-tax revenue general receipt
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NonTaxIncomeGeneralBill")]
        public NonTaxIncomeBill NonTaxIncomeGeneralBill{ get; set; }

        /// <summary>
        /// Non-tax revenue unified payment voucher
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NonTaxIncomeElectronicBill")]
        public NonTaxIncomeBill NonTaxIncomeElectronicBill{ get; set; }

        /// <summary>
        /// Train ticket
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TrainTicket")]
        public TrainTicket TrainTicket{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MedicalOutpatientInvoice")]
        public MedicalInvoice MedicalOutpatientInvoice{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MedicalHospitalizedInvoice")]
        public MedicalInvoice MedicalHospitalizedInvoice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VatSpecialInvoice.", this.VatSpecialInvoice);
            this.SetParamObj(map, prefix + "VatCommonInvoice.", this.VatCommonInvoice);
            this.SetParamObj(map, prefix + "VatElectronicCommonInvoice.", this.VatElectronicCommonInvoice);
            this.SetParamObj(map, prefix + "VatElectronicSpecialInvoice.", this.VatElectronicSpecialInvoice);
            this.SetParamObj(map, prefix + "VatElectronicInvoiceBlockchain.", this.VatElectronicInvoiceBlockchain);
            this.SetParamObj(map, prefix + "VatElectronicInvoiceToll.", this.VatElectronicInvoiceToll);
            this.SetParamObj(map, prefix + "VatElectronicSpecialInvoiceFull.", this.VatElectronicSpecialInvoiceFull);
            this.SetParamObj(map, prefix + "VatElectronicInvoiceFull.", this.VatElectronicInvoiceFull);
            this.SetParamObj(map, prefix + "MachinePrintedInvoice.", this.MachinePrintedInvoice);
            this.SetParamObj(map, prefix + "BusInvoice.", this.BusInvoice);
            this.SetParamObj(map, prefix + "ShippingInvoice.", this.ShippingInvoice);
            this.SetParamObj(map, prefix + "TollInvoice.", this.TollInvoice);
            this.SetParamObj(map, prefix + "OtherInvoice.", this.OtherInvoice);
            this.SetParamObj(map, prefix + "MotorVehicleSaleInvoice.", this.MotorVehicleSaleInvoice);
            this.SetParamObj(map, prefix + "UsedCarPurchaseInvoice.", this.UsedCarPurchaseInvoice);
            this.SetParamObj(map, prefix + "VatInvoiceRoll.", this.VatInvoiceRoll);
            this.SetParamObj(map, prefix + "TaxiTicket.", this.TaxiTicket);
            this.SetParamObj(map, prefix + "QuotaInvoice.", this.QuotaInvoice);
            this.SetParamObj(map, prefix + "AirTransport.", this.AirTransport);
            this.SetParamObj(map, prefix + "NonTaxIncomeGeneralBill.", this.NonTaxIncomeGeneralBill);
            this.SetParamObj(map, prefix + "NonTaxIncomeElectronicBill.", this.NonTaxIncomeElectronicBill);
            this.SetParamObj(map, prefix + "TrainTicket.", this.TrainTicket);
            this.SetParamObj(map, prefix + "MedicalOutpatientInvoice.", this.MedicalOutpatientInvoice);
            this.SetParamObj(map, prefix + "MedicalHospitalizedInvoice.", this.MedicalHospitalizedInvoice);
        }
    }
}

