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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PSTNSession : AbstractModel
    {
        
        /// <summary>
        /// Session ID.
        /// </summary>
        [JsonProperty("SessionID")]
        public string SessionID{ get; set; }

        /// <summary>
        /// Temporary room ID for session.
        /// </summary>
        [JsonProperty("RoomID")]
        public string RoomID{ get; set; }

        /// <summary>
        /// Caller.
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// Called.
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// Start time. Unix timestamp.
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// Ring time. Unix timestamp.
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// Answer time. Unix timestamp.
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// Agent email.
        /// </summary>
        [JsonProperty("StaffEmail")]
        public string StaffEmail{ get; set; }

        /// <summary>
        /// Agent work number.
        /// </summary>
        [JsonProperty("StaffNumber")]
        public string StaffNumber{ get; set; }

        /// <summary>
        /// Session state.
        /// ringing - In progress.
        /// seatJoining - Waiting for agent to receive call.
        /// InProgress - Ongoing.
        /// finished - Completed.
        /// </summary>
        [JsonProperty("SessionStatus")]
        public string SessionStatus{ get; set; }

        /// <summary>
        /// Session call direction, 0 - Inbound | 1 - Outbound.
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// The number used for transferring to the external line (Outbound Caller).
        /// </summary>
        [JsonProperty("OutBoundCaller")]
        public string OutBoundCaller{ get; set; }

        /// <summary>
        /// Outbound callee.
        /// </summary>
        [JsonProperty("OutBoundCallee")]
        public string OutBoundCallee{ get; set; }

        /// <summary>
        /// Caller number protection ID. Effective when the number protection map feature is activated, and the Caller field is empty.
        /// </summary>
        [JsonProperty("ProtectedCaller")]
        public string ProtectedCaller{ get; set; }

        /// <summary>
        /// Called number protection ID. Effective when the number protection map feature is activated, and the Callee field is empty.
        /// </summary>
        [JsonProperty("ProtectedCallee")]
        public string ProtectedCallee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionID", this.SessionID);
            this.SetParamSimple(map, prefix + "RoomID", this.RoomID);
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "StaffEmail", this.StaffEmail);
            this.SetParamSimple(map, prefix + "StaffNumber", this.StaffNumber);
            this.SetParamSimple(map, prefix + "SessionStatus", this.SessionStatus);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "OutBoundCaller", this.OutBoundCaller);
            this.SetParamSimple(map, prefix + "OutBoundCallee", this.OutBoundCallee);
            this.SetParamSimple(map, prefix + "ProtectedCaller", this.ProtectedCaller);
            this.SetParamSimple(map, prefix + "ProtectedCallee", this.ProtectedCallee);
        }
    }
}

