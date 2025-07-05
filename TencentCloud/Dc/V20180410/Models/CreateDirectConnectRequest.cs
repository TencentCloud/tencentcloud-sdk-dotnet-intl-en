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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDirectConnectRequest : AbstractModel
    {
        
        /// <summary>
        /// Connection name.
        /// </summary>
        [JsonProperty("DirectConnectName")]
        public string DirectConnectName{ get; set; }

        /// <summary>
        /// Access point of connection.
        /// You can call `DescribeAccessPoints` to get the region ID. The selected access point must exist and be available.
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// ISP that provides connections. Valid values: ChinaTelecom (China Telecom), ChinaMobile (China Mobile), ChinaUnicom (China Unicom), In-houseWiring (in-house wiring), ChinaOther (other Chinese ISPs), InternationalOperator (international ISPs).
        /// </summary>
        [JsonProperty("LineOperator")]
        public string LineOperator{ get; set; }

        /// <summary>
        /// Port type of connection. Valid values: 100Base-T (100-Megabit electrical Ethernet interface), 1000Base-T (1-Gigabit electrical Ethernet interface), 1000Base-LX (1-Gigabit single-module optical Ethernet interface; 10 KM), 10GBase-T (10-Gigabit electrical Ethernet interface), 10GBase-LR (10-Gigabit single-module optical Ethernet interface; 10 KM). Default value: 1000Base-LX.
        /// </summary>
        [JsonProperty("PortType")]
        public string PortType{ get; set; }

        /// <summary>
        /// Circuit code of a connection, which is provided by the ISP or connection provider.
        /// </summary>
        [JsonProperty("CircuitCode")]
        public string CircuitCode{ get; set; }

        /// <summary>
        /// Local IDC location.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Connection port bandwidth in Mbps. Value range: [2,10240]. Default value: 1000.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// ID of redundant connection.
        /// </summary>
        [JsonProperty("RedundantDirectConnectId")]
        public string RedundantDirectConnectId{ get; set; }

        /// <summary>
        /// VLAN for connection debugging, which is enabled and automatically assigned by default.
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// Tencent-side IP address for connection debugging, which is automatically assigned by default.
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// User-side IP address for connection debugging, which is automatically assigned by default.
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// Name of connection applicant, which is obtained from the account system by default.
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// Email address of connection applicant, which is obtained from the account system by default.
        /// </summary>
        [JsonProperty("CustomerContactMail")]
        public string CustomerContactMail{ get; set; }

        /// <summary>
        /// Contact number of connection applicant, which is obtained from the account system by default.
        /// </summary>
        [JsonProperty("CustomerContactNumber")]
        public string CustomerContactNumber{ get; set; }

        /// <summary>
        /// Fault reporting contact person.
        /// </summary>
        [JsonProperty("FaultReportContactPerson")]
        public string FaultReportContactPerson{ get; set; }

        /// <summary>
        /// Fault reporting contact number.
        /// </summary>
        [JsonProperty("FaultReportContactNumber")]
        public string FaultReportContactNumber{ get; set; }

        /// <summary>
        /// Whether the connection applicant has signed the service agreement. Default value: true.
        /// </summary>
        [JsonProperty("SignLaw")]
        public bool? SignLaw{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectName", this.DirectConnectName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "LineOperator", this.LineOperator);
            this.SetParamSimple(map, prefix + "PortType", this.PortType);
            this.SetParamSimple(map, prefix + "CircuitCode", this.CircuitCode);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "RedundantDirectConnectId", this.RedundantDirectConnectId);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "CustomerContactMail", this.CustomerContactMail);
            this.SetParamSimple(map, prefix + "CustomerContactNumber", this.CustomerContactNumber);
            this.SetParamSimple(map, prefix + "FaultReportContactPerson", this.FaultReportContactPerson);
            this.SetParamSimple(map, prefix + "FaultReportContactNumber", this.FaultReportContactNumber);
            this.SetParamSimple(map, prefix + "SignLaw", this.SignLaw);
        }
    }
}

