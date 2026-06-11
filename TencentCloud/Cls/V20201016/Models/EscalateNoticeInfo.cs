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

    public class EscalateNoticeInfo : AbstractModel
    {
        
        /// <summary>
        /// Alarm notification template recipient information.
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// Callback information of alarm notification template.
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// Alarm escalation switch. `true`: enable alarm escalation, `false`: disable alarm escalation. Default: false.
        /// </summary>
        [JsonProperty("Escalate")]
        public bool? Escalate{ get; set; }

        /// <summary>
        /// Escalate alarms interval. Unit: minutes, range `[1, 14400]`.
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// Upgrade conditions. `1`: Unclaimed and unrecovered, `2`: Unrecovered, defaults to 1.
        /// -Unclaimed and unrecovered: Upgrade if the alert is not restored and no one claims it.
        /// -Unrecovered: Upgrade if the alarm persists without recovery.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Notification channel configuration for the next step after alarm severity escalation. A maximum of five steps can be configured.
        /// </summary>
        [JsonProperty("EscalateNotice")]
        public EscalateNoticeInfo EscalateNotice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NoticeReceivers.", this.NoticeReceivers);
            this.SetParamArrayObj(map, prefix + "WebCallbacks.", this.WebCallbacks);
            this.SetParamSimple(map, prefix + "Escalate", this.Escalate);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "EscalateNotice.", this.EscalateNotice);
        }
    }
}

