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

    public class AlarmMessage : AbstractModel
    {
        
        /// <summary>
        /// Alarm message Id.
        /// </summary>
        [JsonProperty("AlarmMessageId")]
        public ulong? AlarmMessageId{ get; set; }

        /// <summary>
        /// Alarm time. the same Alarm may be sent multiple times, only the latest Alarm time is displayed.
        /// </summary>
        [JsonProperty("AlarmTime")]
        public string AlarmTime{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Instance data time of the task.
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// Indicates the Alarm cause.
        /// </summary>
        [JsonProperty("AlarmReason")]
        public string AlarmReason{ get; set; }

        /// <summary>
        /// Alarm level. 1. ordinary, 2. important, 3. critical.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Specifies the Id of the Alarm rule.
        /// </summary>
        [JsonProperty("AlarmRuleId")]
        public string AlarmRuleId{ get; set; }

        /// <summary>
        /// Alarm channel specifies the notification methods: 1. mail, 2. sms, 3. wechat, 4. voice, 5. wecom, 6. Http, 7. wecom group, 8. lark group, 9. dingtalk group, 10. Slack group, 11. Teams group (default: 1. mail).
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string[] AlarmWays{ get; set; }

        /// <summary>
        /// Alarm recipient
        /// </summary>
        [JsonProperty("AlarmRecipients")]
        public string[] AlarmRecipients{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmMessageId", this.AlarmMessageId);
            this.SetParamSimple(map, prefix + "AlarmTime", this.AlarmTime);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "AlarmReason", this.AlarmReason);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmRuleId", this.AlarmRuleId);
            this.SetParamArraySimple(map, prefix + "AlarmWays.", this.AlarmWays);
            this.SetParamArraySimple(map, prefix + "AlarmRecipients.", this.AlarmRecipients);
        }
    }
}

