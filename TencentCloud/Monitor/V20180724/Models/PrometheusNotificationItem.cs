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

    public class PrometheusNotificationItem : AbstractModel
    {
        
        /// <summary>
        /// Whether it is enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Channel type. Default value: `amp`. Valid values:
        /// `amp`
        /// `webhook`
        /// `alertmanager`
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// If `Type` is `webhook`, this field is required.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebHook")]
        public string WebHook{ get; set; }

        /// <summary>
        /// If `Type` is `alertmanager`, this field is required.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlertManager")]
        public PrometheusAlertManagerConfig AlertManager{ get; set; }

        /// <summary>
        /// Convergence time
        /// </summary>
        [JsonProperty("RepeatInterval")]
        public string RepeatInterval{ get; set; }

        /// <summary>
        /// Effect start time
        /// </summary>
        [JsonProperty("TimeRangeStart")]
        public string TimeRangeStart{ get; set; }

        /// <summary>
        /// Effect end time
        /// </summary>
        [JsonProperty("TimeRangeEnd")]
        public string TimeRangeEnd{ get; set; }

        /// <summary>
        /// Alert notification channel. Valid values: `SMS`, `EMAIL`, `CALL`, `WECHAT`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// Alert recipient group (user group)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public string[] ReceiverGroups{ get; set; }

        /// <summary>
        /// Alert call sequence.
        /// Note: If `NotifyWay` is `CALL`, this parameter will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneNotifyOrder")]
        public ulong?[] PhoneNotifyOrder{ get; set; }

        /// <summary>
        /// Number of alert calls.
        /// Note: If `NotifyWay` is `CALL`, this parameter will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneCircleTimes")]
        public long? PhoneCircleTimes{ get; set; }

        /// <summary>
        /// Alert call interval within a cycle in seconds.
        /// Note: If `NotifyWay` is `CALL`, this parameter will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneInnerInterval")]
        public long? PhoneInnerInterval{ get; set; }

        /// <summary>
        /// Alert call cycle interval in seconds.
        /// Note: If `NotifyWay` is `CALL`, this parameter will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneCircleInterval")]
        public long? PhoneCircleInterval{ get; set; }

        /// <summary>
        /// Alert call receipt notification
        /// Note: If `NotifyWay` is `CALL`, this parameter will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneArriveNotice")]
        public bool? PhoneArriveNotice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WebHook", this.WebHook);
            this.SetParamObj(map, prefix + "AlertManager.", this.AlertManager);
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
        }
    }
}

