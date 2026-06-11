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

    public class NoticeContent : AbstractModel
    {
        
        /// <summary>
        /// Channel type
        /// 
        /// Email: mail; Sms: Sms; WeChat: WeChat; Phone: call; WeCom: WeCom; DingTalk: DingTalk; Lark: Lark; Http: Custom Callback
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Alarm trigger notification content template.
        /// </summary>
        [JsonProperty("TriggerContent")]
        public NoticeContentInfo TriggerContent{ get; set; }

        /// <summary>
        /// Alarm clearing notification content template.
        /// </summary>
        [JsonProperty("RecoveryContent")]
        public NoticeContentInfo RecoveryContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "TriggerContent.", this.TriggerContent);
            this.SetParamObj(map, prefix + "RecoveryContent.", this.RecoveryContent);
        }
    }
}

