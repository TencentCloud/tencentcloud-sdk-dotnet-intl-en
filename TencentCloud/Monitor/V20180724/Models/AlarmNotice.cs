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

    public class AlarmNotice : AbstractModel
    {
        
        /// <summary>
        /// Alarm notification template ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Alarm notification template name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Last modified time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// Last modified by
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdatedBy")]
        public string UpdatedBy{ get; set; }

        /// <summary>
        /// Alarm notification type. Valid values: ALARM (for unresolved alarms), OK (for resolved alarms), ALL (for all alarms)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeType")]
        public string NoticeType{ get; set; }

        /// <summary>
        /// User notification list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserNotices")]
        public UserNotice[] UserNotices{ get; set; }

        /// <summary>
        /// Callback notification list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("URLNotices")]
        public URLNotice[] URLNotices{ get; set; }

        /// <summary>
        /// Whether it is the system default notification template. Valid values: 0 (no), 1 (yes)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsPreset")]
        public long? IsPreset{ get; set; }

        /// <summary>
        /// Notification language. Valid values: zh-CN (Chinese), en-US (English)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeLanguage")]
        public string NoticeLanguage{ get; set; }

        /// <summary>
        /// List of IDs of the alarm policies bound to alarm notification template
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolicyIds")]
        public string[] PolicyIds{ get; set; }

        /// <summary>
        /// Channel to push alarm notifications to CLS.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CLSNotices")]
        public CLSNotice[] CLSNotices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "UpdatedBy", this.UpdatedBy);
            this.SetParamSimple(map, prefix + "NoticeType", this.NoticeType);
            this.SetParamArrayObj(map, prefix + "UserNotices.", this.UserNotices);
            this.SetParamArrayObj(map, prefix + "URLNotices.", this.URLNotices);
            this.SetParamSimple(map, prefix + "IsPreset", this.IsPreset);
            this.SetParamSimple(map, prefix + "NoticeLanguage", this.NoticeLanguage);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamArrayObj(map, prefix + "CLSNotices.", this.CLSNotices);
        }
    }
}

