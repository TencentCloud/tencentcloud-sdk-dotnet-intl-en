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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPolicyGroupEventCondition : AbstractModel
    {
        
        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Alarm sending and convergence type. The value 0 indicates that alarms are sent consecutively. The value 1 indicates that alarms are sent exponentially.
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public long? AlarmNotifyType{ get; set; }

        /// <summary>
        /// Alarm sending period in seconds. If the value is less than 0, no alarm will be triggered. If the value is 0, an alarm will be triggered only once. If the value is greater than 0, an alarm will be triggered at the interval of triggerTime.
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public long? AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// Rule ID. No filling means new addition while filling in ruleId means to modify existing rules.
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

