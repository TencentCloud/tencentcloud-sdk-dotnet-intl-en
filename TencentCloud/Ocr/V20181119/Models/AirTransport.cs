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

    public class AirTransport : AbstractModel
    {
        
        /// <summary>
        /// Invoice title
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// E-ticket No.
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// Check code
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// Serial number
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// Date of issue
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Agent code
        /// </summary>
        [JsonProperty("AgentCode")]
        public string AgentCode{ get; set; }

        /// <summary>
        /// First line of the agent code
        /// </summary>
        [JsonProperty("AgentCodeFirst")]
        public string AgentCodeFirst{ get; set; }

        /// <summary>
        /// Second line of the agent code
        /// </summary>
        [JsonProperty("AgentCodeSecond")]
        public string AgentCodeSecond{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// ID card number
        /// </summary>
        [JsonProperty("UserID")]
        public string UserID{ get; set; }

        /// <summary>
        /// Issuer
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// Fare
        /// </summary>
        [JsonProperty("Fare")]
        public string Fare{ get; set; }

        /// <summary>
        /// Tax
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// Fuel surcharge
        /// </summary>
        [JsonProperty("FuelSurcharge")]
        public string FuelSurcharge{ get; set; }

        /// <summary>
        /// Aviation Development Fund
        /// </summary>
        [JsonProperty("AirDevelopmentFund")]
        public string AirDevelopmentFund{ get; set; }

        /// <summary>
        /// Insurance
        /// </summary>
        [JsonProperty("Insurance")]
        public string Insurance{ get; set; }

        /// <summary>
        /// Total amount (in figures)
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// Invoice type
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Domestic or international tag
        /// </summary>
        [JsonProperty("DomesticInternationalTag")]
        public string DomesticInternationalTag{ get; set; }

        /// <summary>
        /// Not-valid-before date
        /// </summary>
        [JsonProperty("DateStart")]
        public string DateStart{ get; set; }

        /// <summary>
        /// Not-valid-after date
        /// </summary>
        [JsonProperty("DateEnd")]
        public string DateEnd{ get; set; }

        /// <summary>
        /// Endorsements/Restrictions
        /// </summary>
        [JsonProperty("Endorsement")]
        public string Endorsement{ get; set; }

        /// <summary>
        /// Whether there is a QR code (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty("FlightItems")]
        public FlightItem[] FlightItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AgentCode", this.AgentCode);
            this.SetParamSimple(map, prefix + "AgentCodeFirst", this.AgentCodeFirst);
            this.SetParamSimple(map, prefix + "AgentCodeSecond", this.AgentCodeSecond);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserID", this.UserID);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "FuelSurcharge", this.FuelSurcharge);
            this.SetParamSimple(map, prefix + "AirDevelopmentFund", this.AirDevelopmentFund);
            this.SetParamSimple(map, prefix + "Insurance", this.Insurance);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "DomesticInternationalTag", this.DomesticInternationalTag);
            this.SetParamSimple(map, prefix + "DateStart", this.DateStart);
            this.SetParamSimple(map, prefix + "DateEnd", this.DateEnd);
            this.SetParamSimple(map, prefix + "Endorsement", this.Endorsement);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamArrayObj(map, prefix + "FlightItems.", this.FlightItems);
        }
    }
}

