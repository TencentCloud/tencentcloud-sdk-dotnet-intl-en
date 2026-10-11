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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>Notification channel ID, which can be obtained through the notification channel APIs of the basic platform</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// <p>Notification channel name, which can be a user group name or email address</p>
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// <p>Whether to enable the email channel. Default value: false</p>
        /// </summary>
        [JsonProperty("IsEmailChannel")]
        public bool? IsEmailChannel{ get; set; }

        /// <summary>
        /// <p>Alarm condition list. Value: <br>START: Start up<br>SUCCESS: Success<br>FAILURE: Failure<br>MONITOR_INDICATOR_ALARM: Monitoring metric alarm</p>
        /// </summary>
        [JsonProperty("AlarmConditions")]
        public string[] AlarmConditions{ get; set; }

        /// <summary>
        /// <p>Notification channel type. Value: 0 unspecified, 1 Email, 2 Webhook, 3 Teams, 4 Slack</p>
        /// </summary>
        [JsonProperty("ChannelType")]
        public long? ChannelType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "IsEmailChannel", this.IsEmailChannel);
            this.SetParamArraySimple(map, prefix + "AlarmConditions.", this.AlarmConditions);
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
        }
    }
}

