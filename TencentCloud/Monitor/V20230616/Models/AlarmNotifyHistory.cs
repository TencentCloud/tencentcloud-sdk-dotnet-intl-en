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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmNotifyHistory : AbstractModel
    {
        
        /// <summary>
        /// Unique notification ID.
        /// </summary>
        [JsonProperty("NotifyId")]
        public string NotifyId{ get; set; }

        /// <summary>
        /// Alert policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// Alarm cycle iD
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Notification time in Unix timestamp (in seconds).
        /// </summary>
        [JsonProperty("NotifyTime")]
        public long? NotifyTime{ get; set; }

        /// <summary>
        /// Trigger time in Unix timestamp (in seconds).
        /// </summary>
        [JsonProperty("TriggerTime")]
        public long? TriggerTime{ get; set; }

        /// <summary>
        /// Alarm severity level. Valid values: None, Note, Warn, and Serious.
        /// </summary>
        [JsonProperty("TriggerLevel")]
        public string TriggerLevel{ get; set; }

        /// <summary>
        /// alert content
        /// </summary>
        [JsonProperty("AlarmContent")]
        public string AlarmContent{ get; set; }

        /// <summary>
        /// Alarm object
        /// </summary>
        [JsonProperty("AlarmObject")]
        public string AlarmObject{ get; set; }

        /// <summary>
        /// Alarm notification channel collection involved this time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChannelSet")]
        public string[] ChannelSet{ get; set; }

        /// <summary>
        /// Recipient information of the channel
        /// </summary>
        [JsonProperty("ChannelsReceivers")]
        public ChannelsReceivers[] ChannelsReceivers{ get; set; }

        /// <summary>
        /// Alarm policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Prometheus Instance ID, valid only when MT_PROME
        /// </summary>
        [JsonProperty("PromeInstanceID")]
        public string PromeInstanceID{ get; set; }

        /// <summary>
        /// Region of the Prometheus Instance. Valid at that time only for MT_PROME.
        /// </summary>
        [JsonProperty("PromeInstanceRegion")]
        public string PromeInstanceRegion{ get; set; }

        /// <summary>
        /// Notification template related configuration information
        /// </summary>
        [JsonProperty("Notices")]
        public NotifyRelatedNotice[] Notices{ get; set; }

        /// <summary>
        /// Alarm trigger status. Valid values: Trigger and Recovery.
        /// </summary>
        [JsonProperty("TriggerStatus")]
        public string TriggerStatus{ get; set; }

        /// <summary>
        /// Console page address related to the present Prometheus notification history, valid only when MR_PROME
        /// </summary>
        [JsonProperty("PromeConsoleURL")]
        public string PromeConsoleURL{ get; set; }

        /// <summary>
        /// Alarm label
        /// </summary>
        [JsonProperty("Labels")]
        public AlarmLable[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotifyId", this.NotifyId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "NotifyTime", this.NotifyTime);
            this.SetParamSimple(map, prefix + "TriggerTime", this.TriggerTime);
            this.SetParamSimple(map, prefix + "TriggerLevel", this.TriggerLevel);
            this.SetParamSimple(map, prefix + "AlarmContent", this.AlarmContent);
            this.SetParamSimple(map, prefix + "AlarmObject", this.AlarmObject);
            this.SetParamArraySimple(map, prefix + "ChannelSet.", this.ChannelSet);
            this.SetParamArrayObj(map, prefix + "ChannelsReceivers.", this.ChannelsReceivers);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PromeInstanceID", this.PromeInstanceID);
            this.SetParamSimple(map, prefix + "PromeInstanceRegion", this.PromeInstanceRegion);
            this.SetParamArrayObj(map, prefix + "Notices.", this.Notices);
            this.SetParamSimple(map, prefix + "TriggerStatus", this.TriggerStatus);
            this.SetParamSimple(map, prefix + "PromeConsoleURL", this.PromeConsoleURL);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

