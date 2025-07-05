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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MemberRecord : AbstractModel
    {
        
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Online duration, in seconds
        /// </summary>
        [JsonProperty("PresentTime")]
        public ulong? PresentTime{ get; set; }

        /// <summary>
        /// Whether the camera is enabled
        /// </summary>
        [JsonProperty("Camera")]
        public ulong? Camera{ get; set; }

        /// <summary>
        /// Whether the mic is enabled
        /// </summary>
        [JsonProperty("Mic")]
        public ulong? Mic{ get; set; }

        /// <summary>
        /// Whether the user is muted
        /// </summary>
        [JsonProperty("Silence")]
        public ulong? Silence{ get; set; }

        /// <summary>
        /// Number of questions answered by the user
        /// </summary>
        [JsonProperty("AnswerQuestions")]
        public ulong? AnswerQuestions{ get; set; }

        /// <summary>
        /// Number of hand raising times
        /// </summary>
        [JsonProperty("HandUps")]
        public ulong? HandUps{ get; set; }

        /// <summary>
        /// First time that the user entered the room, in UNIX timestamp format
        /// </summary>
        [JsonProperty("FirstJoinTimestamp")]
        public ulong? FirstJoinTimestamp{ get; set; }

        /// <summary>
        /// Last time that the user left the room, in UNIX timestamp format
        /// </summary>
        [JsonProperty("LastQuitTimestamp")]
        public ulong? LastQuitTimestamp{ get; set; }

        /// <summary>
        /// Number of rewards received
        /// </summary>
        [JsonProperty("Rewords")]
        public ulong? Rewords{ get; set; }

        /// <summary>
        /// The user's IP address.
        /// </summary>
        [JsonProperty("IPAddress")]
        public string IPAddress{ get; set; }

        /// <summary>
        /// The user's location.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// The user's device type. 0: Unknown; 1: Windows; 2: macOS; 3: Android; 4: iOS; 5: Web; 6: Mobile webpage; 7: Weixin Mini Program.
        /// </summary>
        [JsonProperty("Device")]
        public long? Device{ get; set; }

        /// <summary>
        /// The number of times a user turned their mic on.
        /// </summary>
        [JsonProperty("PerMemberMicCount")]
        public long? PerMemberMicCount{ get; set; }

        /// <summary>
        /// The number of messages sent by a user.
        /// </summary>
        [JsonProperty("PerMemberMessageCount")]
        public long? PerMemberMessageCount{ get; set; }

        /// <summary>
        /// The user role. `0`: Student; `1`: Teacher; `2`: Teaching Assistant; `3`: Spectator.
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }

        /// <summary>
        /// The class number.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// The sub-class number.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubGroupId")]
        public string[] SubGroupId{ get; set; }

        /// <summary>
        /// Whether the user is on the stage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Stage")]
        public long? Stage{ get; set; }

        /// <summary>
        /// User status. 0 is not present, 1 is online, 2 is offline, 3 is kicked, 4 is permanently kicked, 5 is temporarily offline
        /// </summary>
        [JsonProperty("CurrentState")]
        public ulong? CurrentState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PresentTime", this.PresentTime);
            this.SetParamSimple(map, prefix + "Camera", this.Camera);
            this.SetParamSimple(map, prefix + "Mic", this.Mic);
            this.SetParamSimple(map, prefix + "Silence", this.Silence);
            this.SetParamSimple(map, prefix + "AnswerQuestions", this.AnswerQuestions);
            this.SetParamSimple(map, prefix + "HandUps", this.HandUps);
            this.SetParamSimple(map, prefix + "FirstJoinTimestamp", this.FirstJoinTimestamp);
            this.SetParamSimple(map, prefix + "LastQuitTimestamp", this.LastQuitTimestamp);
            this.SetParamSimple(map, prefix + "Rewords", this.Rewords);
            this.SetParamSimple(map, prefix + "IPAddress", this.IPAddress);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "PerMemberMicCount", this.PerMemberMicCount);
            this.SetParamSimple(map, prefix + "PerMemberMessageCount", this.PerMemberMessageCount);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "SubGroupId.", this.SubGroupId);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "CurrentState", this.CurrentState);
        }
    }
}

