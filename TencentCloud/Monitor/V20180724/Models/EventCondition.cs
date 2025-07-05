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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventCondition : AbstractModel
    {
        
        /// <summary>
        /// Alarm notification frequency.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public string AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// Predefined repeated notification policy. `0`: One-time alarm; `1`: exponential alarm; `2`: consecutive alarm
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public string AlarmNotifyType{ get; set; }

        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("EventID")]
        public string EventID{ get; set; }

        /// <summary>
        /// Displayed event name.
        /// </summary>
        [JsonProperty("EventDisplayName")]
        public string EventDisplayName{ get; set; }

        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "EventDisplayName", this.EventDisplayName);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
        }
    }
}

