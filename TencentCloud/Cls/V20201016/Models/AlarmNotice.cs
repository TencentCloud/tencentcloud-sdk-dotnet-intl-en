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
        /// Alarm notification channel group name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Tag information bound to the alarm notification channel group.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Alarm template type. Optional values:<br><li> Trigger - Alarm Trigger </li><br><li> Recovery - Alarm Recovery </li><br><li> All - Alarm Trigger and Alarm Recovery </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Alarm notification template recipient information.
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// Callback information of alarm notification template.
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// Alarm notification template ID.
        /// </summary>
        [JsonProperty("AlarmNoticeId")]
        public string AlarmNoticeId{ get; set; }

        /// <summary>
        /// Notification rules.
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }

        /// <summary>
        /// Login-free operation alarm switch.
        /// Parameter value: 1: Turn off 2: Turn on (enabled by default)
        /// </summary>
        [JsonProperty("AlarmShieldStatus")]
        public ulong? AlarmShieldStatus{ get; set; }

        /// <summary>
        /// Call link domain name. It must start with http:// or https:// and must not end with /.
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// Shipping-related information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmNoticeDeliverConfig")]
        public AlarmNoticeDeliverConfig AlarmNoticeDeliverConfig{ get; set; }

        /// <summary>
        /// Creation time. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest update time. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Delivery log switch.
        /// 
        /// Parameter value:
        /// 
        /// 1: Disabled
        /// 
        /// 2: enable 
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public ulong? DeliverStatus{ get; set; }

        /// <summary>
        /// Delivery log flag.
        /// 
        /// Parameter value:
        /// 
        /// 1: Disabled
        /// 
        /// 2: Enabled
        /// 
        /// 3: Delivery exception
        /// </summary>
        [JsonProperty("DeliverFlag")]
        public ulong? DeliverFlag{ get; set; }

        /// <summary>
        /// Alarm silence status quantity information configured for a notification channel group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmShieldCount")]
        public AlarmShieldCount AlarmShieldCount{ get; set; }

        /// <summary>
        /// Unify the setting of custom callback parameters.
        /// -true: Use the custom callback parameters in the notification content template to override the request header and request body separately configured in the alarm policy.
        /// -false: Prioritize using the request header and request body separately configured in the alarm policy.
        /// </summary>
        [JsonProperty("CallbackPrioritize")]
        public bool? CallbackPrioritize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "NoticeReceivers.", this.NoticeReceivers);
            this.SetParamArrayObj(map, prefix + "WebCallbacks.", this.WebCallbacks);
            this.SetParamSimple(map, prefix + "AlarmNoticeId", this.AlarmNoticeId);
            this.SetParamArrayObj(map, prefix + "NoticeRules.", this.NoticeRules);
            this.SetParamSimple(map, prefix + "AlarmShieldStatus", this.AlarmShieldStatus);
            this.SetParamSimple(map, prefix + "JumpDomain", this.JumpDomain);
            this.SetParamObj(map, prefix + "AlarmNoticeDeliverConfig.", this.AlarmNoticeDeliverConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamSimple(map, prefix + "DeliverFlag", this.DeliverFlag);
            this.SetParamObj(map, prefix + "AlarmShieldCount.", this.AlarmShieldCount);
            this.SetParamSimple(map, prefix + "CallbackPrioritize", this.CallbackPrioritize);
        }
    }
}

