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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessKeyAlarm : AbstractModel
    {
        
        /// <summary>
        /// Alarm name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Alarm level.
        /// 0 - unavailable 1 - Note 2 - low risk 3 - medium risk 4 - high risk 5 - critical.
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// Alarm record ID.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Alarm rule ID.
        /// </summary>
        [JsonProperty("AlarmRuleID")]
        public long? AlarmRuleID{ get; set; }

        /// <summary>
        /// Alarm type
        /// Abnormal call.
        /// Leak monitoring.
        /// </summary>
        [JsonProperty("AlarmType")]
        public long? AlarmType{ get; set; }

        /// <summary>
        /// Access key.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// Access key ID.
        /// </summary>
        [JsonProperty("AccessKeyID")]
        public ulong? AccessKeyID{ get; set; }

        /// <summary>
        /// Access key remark.
        /// </summary>
        [JsonProperty("AccessKeyRemark")]
        public string AccessKeyRemark{ get; set; }

        /// <summary>
        /// Last Alarm Time
        /// </summary>
        [JsonProperty("LastAlarmTime")]
        public string LastAlarmTime{ get; set; }

        /// <summary>
        /// Alarm status.
        /// 0 - unprocessed 1 - processed 2 - ignored.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Aggregate date.
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Alarm Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// Account associate Uin belonging to main account.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Nickname of the main account.
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Sub-Account Uin belonging to.
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// Sub-Account nickname.
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// Account type.
        /// 0 root account AK 1 sub-account AK 2 temporary key.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// App ID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// Leakage evidence.
        /// </summary>
        [JsonProperty("LeakEvidence")]
        public string[] LeakEvidence{ get; set; }

        /// <summary>
        /// Whether editing a trusted account is supported.
        /// </summary>
        [JsonProperty("IsSupportEditWhiteAccount")]
        public bool? IsSupportEditWhiteAccount{ get; set; }

        /// <summary>
        /// Alarm evidence.
        /// </summary>
        [JsonProperty("Evidence")]
        public string Evidence{ get; set; }

        /// <summary>
        /// Alarm rule flag.
        /// </summary>
        [JsonProperty("RuleKey")]
        public string RuleKey{ get; set; }

        /// <summary>
        /// Cloud vendor type 0: tencent cloud 1: amazon web services 2: microsoft azure 3: google cloud 4: alibaba cloud 5: huawei cloud.
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// Alarm AI analysis status.
        /// -Analysis failed.
        /// 0 not analyzed.
        /// Under analysis.
        /// 2 analysis successful, real Alarm.
        /// 3 analysis successful, suspicious Alarm.
        /// </summary>
        [JsonProperty("AIStatus")]
        public long? AIStatus{ get; set; }

        /// <summary>
        /// First Alarm timestamp (in seconds).
        /// </summary>
        [JsonProperty("FirstAlarmTimestamp")]
        public long? FirstAlarmTimestamp{ get; set; }

        /// <summary>
        /// Last Alarm timestamp (in seconds).
        /// </summary>
        [JsonProperty("LastAlarmTimestamp")]
        public long? LastAlarmTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AlarmRuleID", this.AlarmRuleID);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "AccessKeyID", this.AccessKeyID);
            this.SetParamSimple(map, prefix + "AccessKeyRemark", this.AccessKeyRemark);
            this.SetParamSimple(map, prefix + "LastAlarmTime", this.LastAlarmTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubNickname", this.SubNickname);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamArraySimple(map, prefix + "LeakEvidence.", this.LeakEvidence);
            this.SetParamSimple(map, prefix + "IsSupportEditWhiteAccount", this.IsSupportEditWhiteAccount);
            this.SetParamSimple(map, prefix + "Evidence", this.Evidence);
            this.SetParamSimple(map, prefix + "RuleKey", this.RuleKey);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "AIStatus", this.AIStatus);
            this.SetParamSimple(map, prefix + "FirstAlarmTimestamp", this.FirstAlarmTimestamp);
            this.SetParamSimple(map, prefix + "LastAlarmTimestamp", this.LastAlarmTimestamp);
        }
    }
}

