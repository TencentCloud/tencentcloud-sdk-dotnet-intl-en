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

    public class UserNotice : AbstractModel
    {
        
        /// <summary>
        /// Recipient type. Valid values: USER (user), GROUP (user group)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// Notification start time, which is expressed by the number of seconds since 00:00:00. Value range: 0-86399
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Notification end time, which is expressed by the number of seconds since 00:00:00. Value range: 0-86399
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Notification channel list. Valid values: `EMAIL` (email), `SMS` (SMS), `CALL` (phone), `WECHAT` (WeChat), `RTX` (WeCom)
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeWay")]
        public string[] NoticeWay{ get; set; }

        /// <summary>
        /// User `uid` list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserIds")]
        public long?[] UserIds{ get; set; }

        /// <summary>
        /// User group ID list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupIds")]
        public long?[] GroupIds{ get; set; }

        /// <summary>
        /// Phone polling list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneOrder")]
        public long?[] PhoneOrder{ get; set; }

        /// <summary>
        /// Number of phone pollings. Value range: 1-5
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneCircleTimes")]
        public long? PhoneCircleTimes{ get; set; }

        /// <summary>
        /// Call interval in seconds within one polling. Value range: 60-900
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneInnerInterval")]
        public long? PhoneInnerInterval{ get; set; }

        /// <summary>
        /// Polling interval in seconds. Value range: 60-900
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneCircleInterval")]
        public long? PhoneCircleInterval{ get; set; }

        /// <summary>
        /// Whether receipt notification is required. Valid values: 0 (no), 1 (yes)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NeedPhoneArriveNotice")]
        public long? NeedPhoneArriveNotice{ get; set; }

        /// <summary>
        /// Dial type. `SYNC` (simultaneous dial), `CIRCLE` (polled dial). Default value: `CIRCLE`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneCallType")]
        public string PhoneCallType{ get; set; }

        /// <summary>
        /// Notification cycle. The values 1-7 indicate Monday to Sunday.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weekday")]
        public long?[] Weekday{ get; set; }

        /// <summary>
        /// List of schedule IDs
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormIDs")]
        public string[] OnCallFormIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "NoticeWay.", this.NoticeWay);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArraySimple(map, prefix + "PhoneOrder.", this.PhoneOrder);
            this.SetParamSimple(map, prefix + "PhoneCircleTimes", this.PhoneCircleTimes);
            this.SetParamSimple(map, prefix + "PhoneInnerInterval", this.PhoneInnerInterval);
            this.SetParamSimple(map, prefix + "PhoneCircleInterval", this.PhoneCircleInterval);
            this.SetParamSimple(map, prefix + "NeedPhoneArriveNotice", this.NeedPhoneArriveNotice);
            this.SetParamSimple(map, prefix + "PhoneCallType", this.PhoneCallType);
            this.SetParamArraySimple(map, prefix + "Weekday.", this.Weekday);
            this.SetParamArraySimple(map, prefix + "OnCallFormIDs.", this.OnCallFormIDs);
        }
    }
}

