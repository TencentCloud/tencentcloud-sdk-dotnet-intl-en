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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInformation : AbstractModel
    {
        
        /// <summary>
        /// The room ID.
        /// </summary>
        [JsonProperty("RoomStr")]
        public string RoomStr{ get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// The time when the user entered the room.
        /// </summary>
        [JsonProperty("JoinTs")]
        public ulong? JoinTs{ get; set; }

        /// <summary>
        /// The time when the user left the room. If the user is still in the room, the current time will be returned.
        /// </summary>
        [JsonProperty("LeaveTs")]
        public ulong? LeaveTs{ get; set; }

        /// <summary>
        /// The device type.
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// The SDK version number.
        /// </summary>
        [JsonProperty("SdkVersion")]
        public string SdkVersion{ get; set; }

        /// <summary>
        /// The client IP address.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Whether a user has left the room.
        /// </summary>
        [JsonProperty("Finished")]
        public bool? Finished{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomStr", this.RoomStr);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "JoinTs", this.JoinTs);
            this.SetParamSimple(map, prefix + "LeaveTs", this.LeaveTs);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "Finished", this.Finished);
        }
    }
}

