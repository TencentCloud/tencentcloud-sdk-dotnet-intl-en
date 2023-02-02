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

    public class ModifyAlarmNoticeRequest : AbstractModel
    {
        
        /// <summary>
        /// Module name. Enter "monitor" here
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Alarm notification rule name, which can contain up to 60 characters
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Notification type. Valid values: ALARM (for unresolved alarms), OK (for resolved alarms), ALL (for all alarms)
        /// </summary>
        [JsonProperty("NoticeType")]
        public string NoticeType{ get; set; }

        /// <summary>
        /// Notification language. Valid values: zh-CN (Chinese), en-US (English)
        /// </summary>
        [JsonProperty("NoticeLanguage")]
        public string NoticeLanguage{ get; set; }

        /// <summary>
        /// Alarm notification template ID
        /// </summary>
        [JsonProperty("NoticeId")]
        public string NoticeId{ get; set; }

        /// <summary>
        /// User notifications (up to 5)
        /// </summary>
        [JsonProperty("UserNotices")]
        public UserNotice[] UserNotices{ get; set; }

        /// <summary>
        /// Callback notifications (up to 3)
        /// </summary>
        [JsonProperty("URLNotices")]
        public URLNotice[] URLNotices{ get; set; }

        /// <summary>
        /// The operation of pushing alarm notifications to CLS. Up to one CLS log topic can be configured.
        /// </summary>
        [JsonProperty("CLSNotices")]
        public CLSNotice[] CLSNotices{ get; set; }

        /// <summary>
        /// List of IDs of the alerting rules bound to an alarm notification template
        /// </summary>
        [JsonProperty("PolicyIds")]
        public string[] PolicyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NoticeType", this.NoticeType);
            this.SetParamSimple(map, prefix + "NoticeLanguage", this.NoticeLanguage);
            this.SetParamSimple(map, prefix + "NoticeId", this.NoticeId);
            this.SetParamArrayObj(map, prefix + "UserNotices.", this.UserNotices);
            this.SetParamArrayObj(map, prefix + "URLNotices.", this.URLNotices);
            this.SetParamArrayObj(map, prefix + "CLSNotices.", this.CLSNotices);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
        }
    }
}

