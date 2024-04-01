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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventDataInfo : AbstractModel
    {
        
        /// <summary>
        /// The room ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// The ID of the user to whom the event occurred.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User device type. 0: Unknown; 1: Windows; 2: macOS; 3: Android; 4: iOS; 5: Web; 6: Mobile webpage; 7: Wechat Mini Program.
        /// </summary>
        [JsonProperty("Device")]
        public ulong? Device{ get; set; }

        /// <summary>
        /// Recording time. Unit: seconds
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// Recorded file size
        /// </summary>
        [JsonProperty("RecordSize")]
        public ulong? RecordSize{ get; set; }

        /// <summary>
        /// Recording url
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RecordSize", this.RecordSize);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
        }
    }
}

