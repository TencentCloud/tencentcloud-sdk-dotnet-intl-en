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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteRoomMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the target room
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// List of the members to remove
        /// </summary>
        [JsonProperty("Uids")]
        public string[] Uids{ get; set; }

        /// <summary>
        /// Operation type. `1`: Delete a room; `2`: Remove members
        /// </summary>
        [JsonProperty("DeleteType")]
        public ulong? DeleteType{ get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamArraySimple(map, prefix + "Uids.", this.Uids);
            this.SetParamSimple(map, prefix + "DeleteType", this.DeleteType);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
        }
    }
}

