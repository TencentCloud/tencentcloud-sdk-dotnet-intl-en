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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusNotification : AbstractModel
    {
        
        /// <summary>
        /// Whether it is enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Convergence time
        /// </summary>
        [JsonProperty("RepeatInterval")]
        public string RepeatInterval{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("TimeRangeStart")]
        public string TimeRangeStart{ get; set; }

        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("TimeRangeEnd")]
        public string TimeRangeEnd{ get; set; }

        /// <summary>
        /// Alarm delivery method. Valid values: `SMS`, `EMAIL`, `CALL`, and `WECHAT`
        /// It respectively represents SMS, email, phone calls, and WeChat.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// The alarm recipient group (user group)
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public ulong?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// The alarm sequence of phone calls
        /// This parameter is used when you specify `CALL` for `NotifyWay`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PhoneNotifyOrder")]
        public ulong?[] PhoneNotifyOrder{ get; set; }

        /// <summary>
        /// The number of phone call alarms
        /// This parameter is used when you specify `CALL` for `NotifyWay`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PhoneCircleTimes")]
        public long? PhoneCircleTimes{ get; set; }

        /// <summary>
        /// Dialing interval in seconds within one polling
        /// This parameter is used when you specify `CALL` for `NotifyWay`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PhoneInnerInterval")]
        public long? PhoneInnerInterval{ get; set; }

        /// <summary>
        /// Polling interval in seconds
        /// This parameter is used when you specify `CALL` for `NotifyWay`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PhoneCircleInterval")]
        public long? PhoneCircleInterval{ get; set; }

        /// <summary>
        /// Phone call alarm arrival notification
        /// This parameter is used when you specify `CALL` for `NotifyWay`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PhoneArriveNotice")]
        public bool? PhoneArriveNotice{ get; set; }

        /// <summary>
        /// Channel type. Default value: `amp`. The following channels are supported:
        /// amp
        /// webhook
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// This parameter is required if `Type` is `webhook`.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WebHook")]
        public string WebHook{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RepeatInterval", this.RepeatInterval);
            this.SetParamSimple(map, prefix + "TimeRangeStart", this.TimeRangeStart);
            this.SetParamSimple(map, prefix + "TimeRangeEnd", this.TimeRangeEnd);
            this.SetParamArraySimple(map, prefix + "NotifyWay.", this.NotifyWay);
            this.SetParamArraySimple(map, prefix + "ReceiverGroups.", this.ReceiverGroups);
            this.SetParamArraySimple(map, prefix + "PhoneNotifyOrder.", this.PhoneNotifyOrder);
            this.SetParamSimple(map, prefix + "PhoneCircleTimes", this.PhoneCircleTimes);
            this.SetParamSimple(map, prefix + "PhoneInnerInterval", this.PhoneInnerInterval);
            this.SetParamSimple(map, prefix + "PhoneCircleInterval", this.PhoneCircleInterval);
            this.SetParamSimple(map, prefix + "PhoneArriveNotice", this.PhoneArriveNotice);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WebHook", this.WebHook);
        }
    }
}

