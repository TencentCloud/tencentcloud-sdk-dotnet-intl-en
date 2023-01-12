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
        }
    }
}

