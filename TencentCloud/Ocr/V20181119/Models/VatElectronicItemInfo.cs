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

    public class VatElectronicItemInfo : AbstractModel
    {
        
        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// Specification
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// Unit price
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// Tax rate
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// Tax amount
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Vehicle type
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

        /// <summary>
        /// Vehicle No.
        /// </summary>
        [JsonProperty("VehicleBrand")]
        public string VehicleBrand{ get; set; }

        /// <summary>
        /// Departure place
        /// </summary>
        [JsonProperty("DeparturePlace")]
        public string DeparturePlace{ get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        [JsonProperty("ArrivalPlace")]
        public string ArrivalPlace{ get; set; }

        /// <summary>
        /// Name of the transported goods. It is returned only for a goods transport service invoice.
        /// </summary>
        [JsonProperty("TransportItemsName")]
        public string TransportItemsName{ get; set; }

        /// <summary>
        /// Location of the construction service. It is returned only for a construction invoice.
        /// </summary>
        [JsonProperty("PlaceOfBuildingService")]
        public string PlaceOfBuildingService{ get; set; }

        /// <summary>
        /// Name of the construction project. It is returned only for a construction invoice.
        /// </summary>
        [JsonProperty("BuildingName")]
        public string BuildingName{ get; set; }

        /// <summary>
        /// Property or real estate ownership certificate No. It is returned only for a real estate operation and leasing service invoice.
        /// </summary>
        [JsonProperty("EstateNumber")]
        public string EstateNumber{ get; set; }

        /// <summary>
        /// Unit of area. It is returned only for a real estate operation and leasing service invoice.
        /// </summary>
        [JsonProperty("AreaUnit")]
        public string AreaUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "VehicleBrand", this.VehicleBrand);
            this.SetParamSimple(map, prefix + "DeparturePlace", this.DeparturePlace);
            this.SetParamSimple(map, prefix + "ArrivalPlace", this.ArrivalPlace);
            this.SetParamSimple(map, prefix + "TransportItemsName", this.TransportItemsName);
            this.SetParamSimple(map, prefix + "PlaceOfBuildingService", this.PlaceOfBuildingService);
            this.SetParamSimple(map, prefix + "BuildingName", this.BuildingName);
            this.SetParamSimple(map, prefix + "EstateNumber", this.EstateNumber);
            this.SetParamSimple(map, prefix + "AreaUnit", this.AreaUnit);
        }
    }
}

