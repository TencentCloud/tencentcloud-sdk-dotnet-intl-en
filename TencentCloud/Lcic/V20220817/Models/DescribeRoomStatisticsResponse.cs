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

    public class DescribeRoomStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// Peak number of online members
        /// </summary>
        [JsonProperty("PeakMemberNumber")]
        public ulong? PeakMemberNumber{ get; set; }

        /// <summary>
        /// Accumulated number of online members
        /// </summary>
        [JsonProperty("MemberNumber")]
        public ulong? MemberNumber{ get; set; }

        /// <summary>
        /// Total number of records, including members who entered the room and members who should attend the class but did not
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// Member record list
        /// </summary>
        [JsonProperty("MemberRecords")]
        public MemberRecord[] MemberRecords{ get; set; }

        /// <summary>
        /// The actual start time of the room, in Unix timestamp, accurate to seconds. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealStartTime")]
        public ulong? RealStartTime{ get; set; }

        /// <summary>
        /// The actual end time of the room, in Unix timestamp, accurate to seconds. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealEndTime")]
        public ulong? RealEndTime{ get; set; }

        /// <summary>
        /// The total message count of the room.
        /// </summary>
        [JsonProperty("MessageCount")]
        public ulong? MessageCount{ get; set; }

        /// <summary>
        /// The total number of mic-on students in the room.
        /// </summary>
        [JsonProperty("MicCount")]
        public ulong? MicCount{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeakMemberNumber", this.PeakMemberNumber);
            this.SetParamSimple(map, prefix + "MemberNumber", this.MemberNumber);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "MemberRecords.", this.MemberRecords);
            this.SetParamSimple(map, prefix + "RealStartTime", this.RealStartTime);
            this.SetParamSimple(map, prefix + "RealEndTime", this.RealEndTime);
            this.SetParamSimple(map, prefix + "MessageCount", this.MessageCount);
            this.SetParamSimple(map, prefix + "MicCount", this.MicCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

