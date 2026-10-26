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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddRecordRetrieveTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Task name. It supports Chinese, English, digits, _, and -, with a length not exceeding 32 characters. The name must be globally unique and cannot be empty or repeated.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Start time for retrieving the video recording in UTC seconds, for example: 1662114146. The longest period between the start and end times is one day and cannot span multiple days.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// End time for retrieving the video recording, in UTC seconds, for example: 1662114146. The period between the start and end times can be up to one day and cannot span multiple days.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Retrieval mode. 1: ultrafast mode. Others not supported currently.
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// Retrieval replica validity period of the video recording. Minimum: 1 day. Maximum: 365 days.
        /// </summary>
        [JsonProperty("Expiration")]
        public long? Expiration{ get; set; }

        /// <summary>
        /// Device channel. A task can contain up to 32 device channels.
        /// </summary>
        [JsonProperty("Channels")]
        public ChannelInfo[] Channels{ get; set; }

        /// <summary>
        /// Retrieve the task description
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Expiration", this.Expiration);
            this.SetParamArrayObj(map, prefix + "Channels.", this.Channels);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
        }
    }
}

