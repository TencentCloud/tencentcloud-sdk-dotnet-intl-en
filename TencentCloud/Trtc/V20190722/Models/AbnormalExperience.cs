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

    public class AbnormalExperience : AbstractModel
    {
        
        /// <summary>
        /// The user ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// The abnormal experience ID.
        /// </summary>
        [JsonProperty("ExperienceId")]
        public ulong? ExperienceId{ get; set; }

        /// <summary>
        /// The room ID (string).
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// The possible error events.
        /// </summary>
        [JsonProperty("AbnormalEventList")]
        public AbnormalEvent[] AbnormalEventList{ get; set; }

        /// <summary>
        /// The report time.
        /// </summary>
        [JsonProperty("EventTime")]
        public ulong? EventTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "ExperienceId", this.ExperienceId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamArrayObj(map, prefix + "AbnormalEventList.", this.AbnormalEventList);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
        }
    }
}

