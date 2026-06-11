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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventLog : AbstractModel
    {
        
        /// <summary>
        /// Event channel, support
        /// -Application log
        /// -Security log
        /// -Startup log
        /// -System log
        /// -ALL logs
        /// </summary>
        [JsonProperty("EventChannel")]
        public string EventChannel{ get; set; }

        /// <summary>
        /// Supported types of the time field (Timestamp)
        /// -1 (User-customized time)
        /// -2 (current time)
        /// </summary>
        [JsonProperty("TimeType")]
        public ulong? TimeType{ get; set; }

        /// <summary>
        /// Time, when users choose custom time type, specify the time in seconds
        /// Format: timestamp, 1754897446
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// Event ID filter list
        /// 	
        /// Optional. Being empty indicates no filtering is applied.
        /// Support forward filtering for a single value (for example: 20) or a range (for example: 0-20), also support reverse filtering for a single value (for example: -20).
        /// Multiple filter items can be separated by commas, for example: 1-200,-100 means collect event logs within the range of 1-200 except 100.
        /// </summary>
        [JsonProperty("EventIDs")]
        public string[] EventIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventChannel", this.EventChannel);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamArraySimple(map, prefix + "EventIDs.", this.EventIDs);
        }
    }
}

