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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventListener : AbstractModel
    {
        
        /// <summary>
        /// Event name
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// Event cycle. valid values: SECOND, MIN, HOUR, DAY.
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }

        /// <summary>
        /// Event BROADCAST type: SINGLE, BROADCAST.
        /// </summary>
        [JsonProperty("EventBroadcastType")]
        public string EventBroadcastType{ get; set; }

        /// <summary>
        /// Extension Information
        /// 
        /// </summary>
        [JsonProperty("PropertiesList")]
        public ParamInfo[] PropertiesList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
            this.SetParamSimple(map, prefix + "EventBroadcastType", this.EventBroadcastType);
            this.SetParamArrayObj(map, prefix + "PropertiesList.", this.PropertiesList);
        }
    }
}

