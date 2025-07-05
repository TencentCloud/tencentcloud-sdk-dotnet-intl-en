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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmNotice : AbstractModel
    {
        
        /// <summary>
        /// Alarm notification template name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Alarm template type. Optional values:<br><li> Trigger - Alarm Trigger </li><br><li> Recovery - Alarm Recovery </li><br><li> All - Alarm Trigger and Alarm Recovery </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Information of the recipient in alarm notification template
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// Callback information of alarm notification template
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// Alarm notification template ID
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmNoticeId")]
        public string AlarmNoticeId{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last update time
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Notification rules.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "NoticeReceivers.", this.NoticeReceivers);
            this.SetParamArrayObj(map, prefix + "WebCallbacks.", this.WebCallbacks);
            this.SetParamSimple(map, prefix + "AlarmNoticeId", this.AlarmNoticeId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "NoticeRules.", this.NoticeRules);
        }
    }
}

