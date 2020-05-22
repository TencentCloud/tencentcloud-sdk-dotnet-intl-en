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

    public class ReceiverInfo : AbstractModel
    {
        
        /// <summary>
        /// Start time of the alarm period. Value range: [0,86400). Convert the Unix timestamp to Beijing time and then remove the date. For example, 7200 indicates “10:0:0”.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time of the alarm period. The meaning is the same as that of StartTime.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Alarm notification type. Valid values: "SMS", "SITE", "EMAIL", "CALL", and "WECHAT".
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// Recipient type. Valid values: group and user.
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// ReceiverId
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Call alarm notification time. Valid values: OCCUR (indicating that a notice is sent when the alarm is reported) and RECOVER (indicating that a notice is sent when the alarm is cleared).
        /// </summary>
        [JsonProperty("SendFor")]
        public string[] SendFor{ get; set; }

        /// <summary>
        /// Uid of the alarm call receiver.
        /// </summary>
        [JsonProperty("UidList")]
        public long?[] UidList{ get; set; }

        /// <summary>
        /// Number of alarm call rounds.
        /// </summary>
        [JsonProperty("RoundNumber")]
        public long? RoundNumber{ get; set; }

        /// <summary>
        /// Person interval of alarm calls in seconds.
        /// </summary>
        [JsonProperty("PersonInterval")]
        public long? PersonInterval{ get; set; }

        /// <summary>
        /// Round interval of alarm calls in seconds.
        /// </summary>
        [JsonProperty("RoundInterval")]
        public long? RoundInterval{ get; set; }

        /// <summary>
        /// Notification method when an alarm is cleared. Valid value: SMS.
        /// </summary>
        [JsonProperty("RecoverNotify")]
        public string[] RecoverNotify{ get; set; }

        /// <summary>
        /// Whether to send an alarm call delivery notice. The value 0 indicates that no notice needs to be sent. The value 1 indicates that a notice needs to be sent.
        /// </summary>
        [JsonProperty("NeedSendNotice")]
        public long? NeedSendNotice{ get; set; }

        /// <summary>
        /// Recipient group list. The list of recipient group IDs that is queried by a platform API.
        /// </summary>
        [JsonProperty("ReceiverGroupList")]
        public long?[] ReceiverGroupList{ get; set; }

        /// <summary>
        /// Recipient list. The list of recipient IDs that is queried by a platform API.
        /// </summary>
        [JsonProperty("ReceiverUserList")]
        public long?[] ReceiverUserList{ get; set; }

        /// <summary>
        /// Language of received alarms. Enumerated values: zh-CN and en-US.
        /// </summary>
        [JsonProperty("ReceiveLanguage")]
        public string ReceiveLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "NotifyWay.", this.NotifyWay);
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "SendFor.", this.SendFor);
            this.SetParamArraySimple(map, prefix + "UidList.", this.UidList);
            this.SetParamSimple(map, prefix + "RoundNumber", this.RoundNumber);
            this.SetParamSimple(map, prefix + "PersonInterval", this.PersonInterval);
            this.SetParamSimple(map, prefix + "RoundInterval", this.RoundInterval);
            this.SetParamArraySimple(map, prefix + "RecoverNotify.", this.RecoverNotify);
            this.SetParamSimple(map, prefix + "NeedSendNotice", this.NeedSendNotice);
            this.SetParamArraySimple(map, prefix + "ReceiverGroupList.", this.ReceiverGroupList);
            this.SetParamArraySimple(map, prefix + "ReceiverUserList.", this.ReceiverUserList);
            this.SetParamSimple(map, prefix + "ReceiveLanguage", this.ReceiveLanguage);
        }
    }
}

