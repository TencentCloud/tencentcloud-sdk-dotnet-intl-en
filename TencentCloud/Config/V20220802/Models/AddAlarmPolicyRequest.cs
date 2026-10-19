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

    public class AddAlarmPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Alarm policy name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Event type 1: Resource non-compliance event.</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Event range. Valid values: 1 (current account) and 2 (multi-account).</p>
        /// </summary>
        [JsonProperty("EventScope")]
        public long?[] EventScope{ get; set; }

        /// <summary>
        /// <p>Risk level. 1: high-risk 2: medium-risk 3: low risk</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long?[] RiskLevel{ get; set; }

        /// <summary>
        /// <p>Notification period</p>
        /// </summary>
        [JsonProperty("NoticeTime")]
        public string NoticeTime{ get; set; }

        /// <summary>
        /// <p>Notification mechanism</p>
        /// </summary>
        [JsonProperty("NotificationMechanism")]
        public string NotificationMechanism{ get; set; }

        /// <summary>
        /// <p>Status. Valid values: 1 (enabled) and 2 (disabled).</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Notification cycle</p>
        /// </summary>
        [JsonProperty("NoticePeriod")]
        public long?[] NoticePeriod{ get; set; }

        /// <summary>
        /// <p>Policy description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
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

