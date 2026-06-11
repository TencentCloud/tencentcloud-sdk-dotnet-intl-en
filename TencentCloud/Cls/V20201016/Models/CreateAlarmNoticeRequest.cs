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

    public class CreateAlarmNoticeRequest : AbstractModel
    {
        
        /// <summary>
        /// Notification channel group name. Supports a maximum of 255 bytes. Does not support '|'.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Tag description list. By specifying this parameter, you can bind multiple tags to the corresponding notification channel group. A maximum of 50 tag key-value pairs are supported, and there should not be duplicate key-value pairs.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// [Easy mode] (Select either easy mode or alarm mode and configure corresponding parameters)
        /// Alarm types that require sending notifications. Available values:
        /// - Trigger - Alarm trigger
        /// -Alarm Recovery
        /// -All - Alarm trigger and alarm recovery
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// [Easy mode] (Select either easy mode or alarm mode and configure corresponding parameters)
        /// Notification recipients
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// [Easy mode] (Select either easy mode or alarm mode and configure corresponding parameters)
        /// Interface callback information (including WeCom, DingTalk, Lark).
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// [Advanced mode] (Choose between easy mode and alarm mode, and configure corresponding parameters)
        /// Notification rules.
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }

        /// <summary>
        /// Query data link. It should start with http:// or https:// and should not end with /.
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// Delivery log switch. Values are as follows:
        /// 1: Off (default value).
        /// 2: Enable 
        /// When the delivery log switch is enabled, the DeliverConfig parameter is required.
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public ulong? DeliverStatus{ get; set; }

        /// <summary>
        /// Log shipping configuration parameter. It is required when DeliverStatus is enabled.
        /// </summary>
        [JsonProperty("DeliverConfig")]
        public DeliverConfig DeliverConfig{ get; set; }

        /// <summary>
        /// Login-free operation alarm switch. Values are as follows:
        /// - 1: disabled.
        /// -2: Enable (default value)
        /// </summary>
        [JsonProperty("AlarmShieldStatus")]
        public ulong? AlarmShieldStatus{ get; set; }

        /// <summary>
        /// Unify the custom callback parameter settings.
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
            this.SetParamArrayObj(map, prefix + "NoticeRules.", this.NoticeRules);
            this.SetParamSimple(map, prefix + "JumpDomain", this.JumpDomain);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamObj(map, prefix + "DeliverConfig.", this.DeliverConfig);
            this.SetParamSimple(map, prefix + "AlarmShieldStatus", this.AlarmShieldStatus);
            this.SetParamSimple(map, prefix + "CallbackPrioritize", this.CallbackPrioritize);
        }
    }
}

