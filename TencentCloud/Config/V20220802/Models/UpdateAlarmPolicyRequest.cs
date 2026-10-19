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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAlarmPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm Policy ID
        /// </summary>
        [JsonProperty("AlarmPolicyId")]
        public ulong? AlarmPolicyId{ get; set; }

        /// <summary>
        /// Alarm policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Event scope. Valid values: 1 (current account) and 2 (multiple accounts).
        /// </summary>
        [JsonProperty("EventScope")]
        public long?[] EventScope{ get; set; }

        /// <summary>
        /// Risk level. Valid values: 1 (high risk), 2 (medium risk), and 3 (low risk).
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long?[] RiskLevel{ get; set; }

        /// <summary>
        /// Notification period
        /// </summary>
        [JsonProperty("NoticeTime")]
        public string NoticeTime{ get; set; }

        /// <summary>
        /// Notification mechanism
        /// </summary>
        [JsonProperty("NotificationMechanism")]
        public string NotificationMechanism{ get; set; }

        /// <summary>
        /// Status. Valid values: 1 (enabled) and 2 (disabled).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Notification cycle. Value range: 1 to 7, representing Monday to Sunday respectively.
        /// </summary>
        [JsonProperty("NoticePeriod")]
        public long?[] NoticePeriod{ get; set; }

        /// <summary>
        /// Policy description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmPolicyId", this.AlarmPolicyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "EventScope.", this.EventScope);
            this.SetParamArraySimple(map, prefix + "RiskLevel.", this.RiskLevel);
            this.SetParamSimple(map, prefix + "NoticeTime", this.NoticeTime);
            this.SetParamSimple(map, prefix + "NotificationMechanism", this.NotificationMechanism);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "NoticePeriod.", this.NoticePeriod);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

