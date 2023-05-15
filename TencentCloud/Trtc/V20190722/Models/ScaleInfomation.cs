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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleInfomation : AbstractModel
    {
        
        /// <summary>
        /// Start time for each day
        /// </summary>
        [JsonProperty("Time")]
        public ulong? Time{ get; set; }

        /// <summary>
        /// The number of users. If a user enters a room multiple times, it will be counted as one user.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserNumber")]
        public ulong? UserNumber{ get; set; }

        /// <summary>
        /// The number of room entries. Every time a user enters a room, it will be counted as one room entry.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserCount")]
        public ulong? UserCount{ get; set; }

        /// <summary>
        /// The total number of rooms of the application on a day.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoomNumbers")]
        public ulong? RoomNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "UserNumber", this.UserNumber);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "RoomNumbers", this.RoomNumbers);
        }
    }
}

