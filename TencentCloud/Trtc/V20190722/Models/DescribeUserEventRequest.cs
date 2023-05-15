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

    public class DescribeUserEventRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique ID of a call, whose format is `SdkAppId_CreateTime`, such as `1400xxxxxx_218695_1590065777`. `createTime` is the UNIX timestamp (seconds) when the room was created. Its value can be obtained using the [DescribeRoomInfo](https://intl.cloud.tencent.com/document/product/647/44050?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("CommId")]
        public string CommId{ get; set; }

        /// <summary>
        /// The start time, which is a Unix timestamp (seconds) in local time, such as `1590065777`.
        /// Note: Only data in the last 14 days can be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// The end time, which is a Unix timestamp (seconds) in local time, such as `1590065877`.
        /// Note: If you pass in an end time later than the room end time, the room end time will be used.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// The room ID, such as `223`.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// The application ID, such as `1400xxxxxx`.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommId", this.CommId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
        }
    }
}

