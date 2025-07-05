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

    public class TrainTicket : AbstractModel
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
        /// Departure date
        /// </summary>
        [JsonProperty("DateGetOn")]
        public string DateGetOn{ get; set; }

        /// <summary>
        /// Departure time
        /// </summary>
        [JsonProperty("TimeGetOn")]
        public string TimeGetOn{ get; set; }

        /// <summary>
        /// Passenger's name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Departure station
        /// </summary>
        [JsonProperty("StationGetOn")]
        public string StationGetOn{ get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        [JsonProperty("StationGetOff")]
        public string StationGetOff{ get; set; }

        /// <summary>
        /// Seat class
        /// </summary>
        [JsonProperty("Seat")]
        public string Seat{ get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// Invoice type
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Serial number
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// ID card number
        /// </summary>
        [JsonProperty("UserID")]
        public string UserID{ get; set; }

        /// <summary>
        /// Check-in gate
        /// </summary>
        [JsonProperty("GateNumber")]
        public string GateNumber{ get; set; }

        /// <summary>
        /// Fleet number
        /// </summary>
        [JsonProperty("TrainNumber")]
        public string TrainNumber{ get; set; }

        /// <summary>
        /// Handling fee
        /// </summary>
        [JsonProperty("HandlingFee")]
        public string HandlingFee{ get; set; }

        /// <summary>
        /// Original ticket price
        /// </summary>
        [JsonProperty("OriginalFare")]
        public string OriginalFare{ get; set; }

        /// <summary>
        /// Total amount (in words)
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// Seat No.
        /// </summary>
        [JsonProperty("SeatNumber")]
        public string SeatNumber{ get; set; }

        /// <summary>
        /// Ticket pickup address
        /// </summary>
        [JsonProperty("PickUpAddress")]
        public string PickUpAddress{ get; set; }

        /// <summary>
        /// Ticket change information
        /// </summary>
        [JsonProperty("TicketChange")]
        public string TicketChange{ get; set; }

        /// <summary>
        /// Additional fare
        /// </summary>
        [JsonProperty("AdditionalFare")]
        public string AdditionalFare{ get; set; }

        /// <summary>
        /// Receipt No.
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber{ get; set; }

        /// <summary>
        /// Whether there is a QR code (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// Whether it is for reimbursement only (0: No, 1: Yes)
        /// </summary>
        [JsonProperty("ReimburseOnlyMark")]
        public long? ReimburseOnlyMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "DateGetOn", this.DateGetOn);
            this.SetParamSimple(map, prefix + "TimeGetOn", this.TimeGetOn);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StationGetOn", this.StationGetOn);
            this.SetParamSimple(map, prefix + "StationGetOff", this.StationGetOff);
            this.SetParamSimple(map, prefix + "Seat", this.Seat);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "UserID", this.UserID);
            this.SetParamSimple(map, prefix + "GateNumber", this.GateNumber);
            this.SetParamSimple(map, prefix + "TrainNumber", this.TrainNumber);
            this.SetParamSimple(map, prefix + "HandlingFee", this.HandlingFee);
            this.SetParamSimple(map, prefix + "OriginalFare", this.OriginalFare);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "SeatNumber", this.SeatNumber);
            this.SetParamSimple(map, prefix + "PickUpAddress", this.PickUpAddress);
            this.SetParamSimple(map, prefix + "TicketChange", this.TicketChange);
            this.SetParamSimple(map, prefix + "AdditionalFare", this.AdditionalFare);
            this.SetParamSimple(map, prefix + "ReceiptNumber", this.ReceiptNumber);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "ReimburseOnlyMark", this.ReimburseOnlyMark);
        }
    }
}

