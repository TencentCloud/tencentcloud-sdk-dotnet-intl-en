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
        /// <p>Alarm name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Alarm level<br>0-Unavailable 1-Notification 2-Low risk 3-Medium risk 4-High risk 5-Critical</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>Alarm record ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Alarm rule ID</p>
        /// </summary>
        [JsonProperty("AlarmRuleID")]
        public long? AlarmRuleID{ get; set; }

        /// <summary>
        /// <p>Alarm type<br>0 Abnormal call<br>1 Leak monitoring</p>
        /// </summary>
        [JsonProperty("AlarmType")]
        public long? AlarmType{ get; set; }

        /// <summary>
        /// <p>Access key</p>
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// <p>Access Key ID</p>
        /// </summary>
        [JsonProperty("AccessKeyID")]
        public ulong? AccessKeyID{ get; set; }

        /// <summary>
        /// <p>Access key remark</p>
        /// </summary>
        [JsonProperty("AccessKeyRemark")]
        public string AccessKeyRemark{ get; set; }

        /// <summary>
        /// <p>Last alarm time</p>
        /// </summary>
        [JsonProperty("LastAlarmTime")]
        public string LastAlarmTime{ get; set; }

        /// <summary>
        /// <p>Alarm status<br>0-unprocessed 1-processed 2-ignored</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Aggregate date</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>Alarm tag</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// <p>Uin of the main account</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Nickname of the main account</p>
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// <p>Sub-account Uin</p>
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// <p>Sub-account nickname</p>
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// <p>Account type<br>0 Root account AK 1 Sub-account AK 2 Temporary key</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>App ID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>Leakage evidence</p>
        /// </summary>
        [JsonProperty("LeakEvidence")]
        public string[] LeakEvidence{ get; set; }

        /// <summary>
        /// <p>Whether support editing trust account</p>
        /// </summary>
        [JsonProperty("IsSupportEditWhiteAccount")]
        public bool? IsSupportEditWhiteAccount{ get; set; }

        /// <summary>
        /// <p>Alert evidence</p>
        /// </summary>
        [JsonProperty("Evidence")]
        public string Evidence{ get; set; }

        /// <summary>
        /// <p>Alarm rule flag</p>
        /// </summary>
        [JsonProperty("RuleKey")]
        public string RuleKey{ get; set; }

        /// <summary>
        /// <p>Cloud vendor type 0:Tencent Cloud 1:Amazon Web Services 2:Microsoft Azure 3:Google Cloud 4:Alibaba Cloud 5:Huawei Cloud</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>Alarm AI analysis status<br>-1 Analysis failed<br>0 Not analyzed<br>1 Under analysis<br>2 Analysis successful, real alarm<br>3 Analysis successful, suspicious alarm</p>
        /// </summary>
        [JsonProperty("AIStatus")]
        public long? AIStatus{ get; set; }

        /// <summary>
        /// <p>First alarm timestamp (in seconds)</p>
        /// </summary>
        [JsonProperty("FirstAlarmTimestamp")]
        public long? FirstAlarmTimestamp{ get; set; }

        /// <summary>
        /// <p>Last alarm timestamp (in seconds)</p>
        /// </summary>
        [JsonProperty("LastAlarmTimestamp")]
        public long? LastAlarmTimestamp{ get; set; }

        /// <summary>
        /// <p>AI analysis failure description. Empty string if not failed.</p>
        /// </summary>
        [JsonProperty("AIFailedReason")]
        public string AIFailedReason{ get; set; }


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
            this.SetParamSimple(map, prefix + "AIFailedReason", this.AIFailedReason);
        }
    }
}

