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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BruteAttackInfo : AbstractModel
    {
        
        /// <summary>
        /// Unique ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// CWP client UUID.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host IP address
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// host name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Source IP
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// SUCCESS: cracking successful; FAILED: cracking failed
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Country/Region ID
        /// </summary>
        [JsonProperty("Country")]
        public ulong? Country{ get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("City")]
        public ulong? City{ get; set; }

        /// <summary>
        /// Province id
        /// </summary>
        [JsonProperty("Province")]
        public ulong? Province{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 0 - No blocking (not supported by the client version)
        /// 1: blocked
        /// 2: Blocking failed (program exception)
        /// 3: No blocking (No blocking for the private network)
        /// 4: Availability zone does not support blocking
        /// 10: blocking
        /// 81: no blocking (blocking disabled)
        /// 82-No Blocking (Non-Pro Edition)
        /// 83: no blocking (added to the allowlist)
        /// 86: no blocking (system allowlist)
        /// 87: No blocking (client offline)
        /// 88-No blocking (Source Ip belongs to the same customer)
        /// 89: no blocking (blocking is not supported for ipv6)
        /// </summary>
        [JsonProperty("BanStatus")]
        public ulong? BanStatus{ get; set; }

        /// <summary>
        /// Event type: 200 - brute force cracking event; 300 - successful brute force cracking event (the status is displayed on the page); 400 - brute force cracking event for non-existent accounts.
        /// </summary>
        [JsonProperty("EventType")]
        public ulong? EventType{ get; set; }

        /// <summary>
        /// Occurrence count
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// CVM instance UUID.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Whether it is the Pro Edition (true/false)
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// Username of the attacked service
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Last attack time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 0: pending; 1: ignored; 5: fixed; 6: added to allowlist
        /// </summary>
        [JsonProperty("DataStatus")]
        public ulong? DataStatus{ get; set; }

        /// <summary>
        /// Additional information
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// Chinese name of a geo location.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Threat level. 0: low risk, 1: medium risk, 2: high risk.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// Event source. 0: blocking rule, 1: threat intelligence.
        /// </summary>
        [JsonProperty("DataFrom")]
        public long? DataFrom{ get; set; }

        /// <summary>
        /// Cracking status description.
        /// </summary>
        [JsonProperty("AttackStatusDesc")]
        public string AttackStatusDesc{ get; set; }

        /// <summary>
        /// Block expiration time (only valid for blocked events).
        /// </summary>
        [JsonProperty("BanExpiredTime")]
        public string BanExpiredTime{ get; set; }

        /// <summary>
        /// IP analysis
        /// </summary>
        [JsonProperty("IPAnalyse")]
        public IPAnalyse IPAnalyse{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DataStatus", this.DataStatus);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "DataFrom", this.DataFrom);
            this.SetParamSimple(map, prefix + "AttackStatusDesc", this.AttackStatusDesc);
            this.SetParamSimple(map, prefix + "BanExpiredTime", this.BanExpiredTime);
            this.SetParamObj(map, prefix + "IPAnalyse.", this.IPAnalyse);
        }
    }
}

