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

    public class CreateTroubleInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// Room ID
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Teacher user ID
        /// </summary>
        [JsonProperty("TeacherUserId")]
        public string TeacherUserId{ get; set; }

        /// <summary>
        /// Student user ID
        /// </summary>
        [JsonProperty("StudentUserId")]
        public string StudentUserId{ get; set; }

        /// <summary>
        /// ID of the user (teacher or student) with exception.
        /// </summary>
        [JsonProperty("TroubleUserId")]
        public string TroubleUserId{ get; set; }

        /// <summary>
        /// Exception type.
        /// 1: exceptional video
        /// 2: exceptional audio
        /// 3: exceptional video and audio
        /// 5: exceptional room entry
        /// 4: course switch
        /// 6: help seeking
        /// 7: problem feedback
        /// 8: complaint
        /// </summary>
        [JsonProperty("TroubleType")]
        public ulong? TroubleType{ get; set; }

        /// <summary>
        /// UNIX timestamp when the exception occurred in seconds.
        /// </summary>
        [JsonProperty("TroubleTime")]
        public ulong? TroubleTime{ get; set; }

        /// <summary>
        /// Exception details
        /// </summary>
        [JsonProperty("TroubleMsg")]
        public string TroubleMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "TeacherUserId", this.TeacherUserId);
            this.SetParamSimple(map, prefix + "StudentUserId", this.StudentUserId);
            this.SetParamSimple(map, prefix + "TroubleUserId", this.TroubleUserId);
            this.SetParamSimple(map, prefix + "TroubleType", this.TroubleType);
            this.SetParamSimple(map, prefix + "TroubleTime", this.TroubleTime);
            this.SetParamSimple(map, prefix + "TroubleMsg", this.TroubleMsg);
        }
    }
}

