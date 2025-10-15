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

    public class AlarmGroup : AbstractModel
    {
        
        /// <summary>
        /// Specifies the list of Alarm escalation recipient ids.
        /// If the Alarm recipient or supervisor does not confirm the Alarm within the Alarm interval, an Alarm will be sent to the next-level superior.
        /// </summary>
        [JsonProperty("AlarmEscalationRecipientIds")]
        public string[] AlarmEscalationRecipientIds{ get; set; }

        /// <summary>
        /// Escalation interval for alarms.
        /// </summary>
        [JsonProperty("AlarmEscalationInterval")]
        public long? AlarmEscalationInterval{ get; set; }

        /// <summary>
        /// Alarm notification fatigue configuration.
        /// </summary>
        [JsonProperty("NotificationFatigue")]
        public NotificationFatigue NotificationFatigue{ get; set; }

        /// <summary>
        /// Alarm channel. valid values: 1. mail, 2. sms, 3. wechat, 4. voice, 5. wecom, 6. Http, 7. wecom group, 8. lark group, 9. dingtalk group, 10. Slack group, 11. Teams group (default: 1. mail). only select one channel.
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string[] AlarmWays{ get; set; }

        /// <summary>
        /// webhook url list for wecom group/lark group/dingtalk group/Slack group/Teams group.
        /// </summary>
        [JsonProperty("WebHooks")]
        public AlarmWayWebHook[] WebHooks{ get; set; }

        /// <summary>
        /// Alarm recipient type: 1. specified personnel, 2. task owner, 3. duty schedule (default: 1. specified personnel).
        /// </summary>
        [JsonProperty("AlarmRecipientType")]
        public long? AlarmRecipientType{ get; set; }

        /// <summary>
        /// Specifies different business ids based on AlarmRecipientType. valid values: 1 (designated personnel): Alarm recipient id list. 2 (task owner): no configuration required. 3 (duty schedule): schedule id list.
        /// </summary>
        [JsonProperty("AlarmRecipientIds")]
        public string[] AlarmRecipientIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AlarmEscalationRecipientIds.", this.AlarmEscalationRecipientIds);
            this.SetParamSimple(map, prefix + "AlarmEscalationInterval", this.AlarmEscalationInterval);
            this.SetParamObj(map, prefix + "NotificationFatigue.", this.NotificationFatigue);
            this.SetParamArraySimple(map, prefix + "AlarmWays.", this.AlarmWays);
            this.SetParamArrayObj(map, prefix + "WebHooks.", this.WebHooks);
            this.SetParamSimple(map, prefix + "AlarmRecipientType", this.AlarmRecipientType);
            this.SetParamArraySimple(map, prefix + "AlarmRecipientIds.", this.AlarmRecipientIds);
        }
    }
}

