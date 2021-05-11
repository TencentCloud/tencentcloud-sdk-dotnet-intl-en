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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DirectConnect : AbstractModel
    {
        
        /// <summary>
        /// Connection ID.
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// Connection name.
        /// </summary>
        [JsonProperty("DirectConnectName")]
        public string DirectConnectName{ get; set; }

        /// <summary>
        /// Access point ID of a connection.
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// Connection status.
        /// PENDING: Applying. 
        /// REJECTED: Application rejected.   
        /// TOPAY: Payment pending. 
        /// PAID: Paid. 
        /// ALLOCATED: Constructing.   
        /// AVAILABLE: Available.  
        /// DELETING: Deleting.
        /// DELETED: Deleted.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Connection creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Connection activation time.
        /// </summary>
        [JsonProperty("EnabledTime")]
        public string EnabledTime{ get; set; }

        /// <summary>
        /// ISP that provides connections. Valid values: ChinaTelecom (China Telecom), ChinaMobile (China Mobile), ChinaUnicom (China Unicom), In-houseWiring (in-house wiring), ChinaOther (other Chinese ISPs), InternationalOperator (international ISPs).
        /// </summary>
        [JsonProperty("LineOperator")]
        public string LineOperator{ get; set; }

        /// <summary>
        /// Location of a local IDC.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Connection port bandwidth in Mbps.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// User-side port type of a connection. Valid values: 100Base-T (100-Megabit electrical Ethernet interface), 1000Base-T (1-Gigabit electrical Ethernet interface; it is the default value), 1000Base-LX (1-Gigabit single-mode optical Ethernet interface; 10 KM), 10GBase-T (10-Gigabit electrical Ethernet interface), 10GBase-LR (10-Gigabit single-mode optical Ethernet interface; 10 KM).
        /// </summary>
        [JsonProperty("PortType")]
        public string PortType{ get; set; }

        /// <summary>
        /// Circuit code of a connection, which is provided by the ISP or service provider.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CircuitCode")]
        public string CircuitCode{ get; set; }

        /// <summary>
        /// ID of a redundant connection.
        /// </summary>
        [JsonProperty("RedundantDirectConnectId")]
        public string RedundantDirectConnectId{ get; set; }

        /// <summary>
        /// VLAN for connection debugging, which is enabled and automatically assigned by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// Tencent-side IP address for connection debugging.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// User-side IP address for connection debugging.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// Name of the connection applicant, which is obtained from the account system by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// Email address of the connection applicant, which is obtained from the account system by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomerContactMail")]
        public string CustomerContactMail{ get; set; }

        /// <summary>
        /// Contact number of the connection applicant, which is obtained from the account system by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomerContactNumber")]
        public string CustomerContactNumber{ get; set; }

        /// <summary>
        /// Connection expiration time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Connection billing mode. NON_RECURRING_CHARGE: One-time charge for accessing service
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// Fault reporting contact person.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaultReportContactPerson")]
        public string FaultReportContactPerson{ get; set; }

        /// <summary>
        /// Fault reporting contact number.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaultReportContactNumber")]
        public string FaultReportContactNumber{ get; set; }

        /// <summary>
        /// Tag key-value pair
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// Access point type of a connection.
        /// </summary>
        [JsonProperty("AccessPointType")]
        public string AccessPointType{ get; set; }

        /// <summary>
        /// IDC city.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdcCity")]
        public string IdcCity{ get; set; }

        /// <summary>
        /// Billing status
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeState")]
        public string ChargeState{ get; set; }

        /// <summary>
        /// Connection activation time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Whether the connection has the service agreement signed.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("SignLaw")]
        public bool? SignLaw{ get; set; }

        /// <summary>
        /// Whether the connection is an edge zone.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("LocalZone")]
        public bool? LocalZone{ get; set; }

        /// <summary>
        /// Number of dedicated tunnels with disabled VLAN in the connection
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VlanZeroDirectConnectTunnelCount")]
        public ulong? VlanZeroDirectConnectTunnelCount{ get; set; }

        /// <summary>
        /// Number of dedicated tunnels with enabled VLAN in the connection
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OtherVlanDirectConnectTunnelCount")]
        public ulong? OtherVlanDirectConnectTunnelCount{ get; set; }

        /// <summary>
        /// Minimum bandwidth of the connection
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinBandwidth")]
        public ulong? MinBandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "DirectConnectName", this.DirectConnectName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "EnabledTime", this.EnabledTime);
            this.SetParamSimple(map, prefix + "LineOperator", this.LineOperator);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "PortType", this.PortType);
            this.SetParamSimple(map, prefix + "CircuitCode", this.CircuitCode);
            this.SetParamSimple(map, prefix + "RedundantDirectConnectId", this.RedundantDirectConnectId);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "CustomerContactMail", this.CustomerContactMail);
            this.SetParamSimple(map, prefix + "CustomerContactNumber", this.CustomerContactNumber);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "FaultReportContactPerson", this.FaultReportContactPerson);
            this.SetParamSimple(map, prefix + "FaultReportContactNumber", this.FaultReportContactNumber);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "AccessPointType", this.AccessPointType);
            this.SetParamSimple(map, prefix + "IdcCity", this.IdcCity);
            this.SetParamSimple(map, prefix + "ChargeState", this.ChargeState);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "SignLaw", this.SignLaw);
            this.SetParamSimple(map, prefix + "LocalZone", this.LocalZone);
            this.SetParamSimple(map, prefix + "VlanZeroDirectConnectTunnelCount", this.VlanZeroDirectConnectTunnelCount);
            this.SetParamSimple(map, prefix + "OtherVlanDirectConnectTunnelCount", this.OtherVlanDirectConnectTunnelCount);
            this.SetParamSimple(map, prefix + "MinBandwidth", this.MinBandwidth);
        }
    }
}

