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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GameServerSession : AbstractModel
    {
        
        /// <summary>
        /// Game server session creation time
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// Creator ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// Current number of players
        /// </summary>
        [JsonProperty("CurrentPlayerSessionCount")]
        public ulong? CurrentPlayerSessionCount{ get; set; }

        /// <summary>
        /// CVM DNS ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DnsName")]
        public string DnsName{ get; set; }

        /// <summary>
        /// Fleet ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// Game attributes
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GameProperties")]
        public GameProperty[] GameProperties{ get; set; }

        /// <summary>
        /// Game server session attribute details
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GameServerSessionData")]
        public string GameServerSessionData{ get; set; }

        /// <summary>
        /// Game server session ID
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// CVM IP address
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// Battle progress details
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MatchmakerData")]
        public string MatchmakerData{ get; set; }

        /// <summary>
        /// Maximum number of players
        /// </summary>
        [JsonProperty("MaximumPlayerSessionCount")]
        public ulong? MaximumPlayerSessionCount{ get; set; }

        /// <summary>
        /// Game server session name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Player session creation policy
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PlayerSessionCreationPolicy")]
        public string PlayerSessionCreationPolicy{ get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Game server session status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Additional information of game server session status
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }

        /// <summary>
        /// Termination time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TerminationTime")]
        public string TerminationTime{ get; set; }

        /// <summary>
        /// Instance type
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Current custom count
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentCustomCount")]
        public long? CurrentCustomCount{ get; set; }

        /// <summary>
        /// Maximum custom count
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxCustomCount")]
        public long? MaxCustomCount{ get; set; }

        /// <summary>
        /// Weight
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Session availability status, i.e., whether it is blocked
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailabilityStatus")]
        public string AvailabilityStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "CurrentPlayerSessionCount", this.CurrentPlayerSessionCount);
            this.SetParamSimple(map, prefix + "DnsName", this.DnsName);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamArrayObj(map, prefix + "GameProperties.", this.GameProperties);
            this.SetParamSimple(map, prefix + "GameServerSessionData", this.GameServerSessionData);
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamSimple(map, prefix + "MatchmakerData", this.MatchmakerData);
            this.SetParamSimple(map, prefix + "MaximumPlayerSessionCount", this.MaximumPlayerSessionCount);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PlayerSessionCreationPolicy", this.PlayerSessionCreationPolicy);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
            this.SetParamSimple(map, prefix + "TerminationTime", this.TerminationTime);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "CurrentCustomCount", this.CurrentCustomCount);
            this.SetParamSimple(map, prefix + "MaxCustomCount", this.MaxCustomCount);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "AvailabilityStatus", this.AvailabilityStatus);
        }
    }
}

