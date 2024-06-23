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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmReceiverInfo : AbstractModel
    {
        
        /// <summary>
        /// Alert ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// Alarm Recipient ID
        /// </summary>
        [JsonProperty("AlarmReceiver")]
        public string AlarmReceiver{ get; set; }

        /// <summary>
        /// Email,0: Not set,1: Success,2: Failure
        /// </summary>
        [JsonProperty("Email")]
        public ulong? Email{ get; set; }

        /// <summary>
        /// SMS,0: Not set,1: Success,2: Failure
        /// </summary>
        [JsonProperty("Sms")]
        public ulong? Sms{ get; set; }

        /// <summary>
        /// WeChat,0: Not set,1: Success,2: Failure
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }

        /// <summary>
        /// Telephone,0: Not set,1: Success,2: Failure
        /// </summary>
        [JsonProperty("Voice")]
        public ulong? Voice{ get; set; }

        /// <summary>
        /// WeCom,0: Not set,1: Success,2: Failure
        /// </summary>
        [JsonProperty("Wecom")]
        public ulong? Wecom{ get; set; }

        /// <summary>
        /// http,0: Not set,1: Success,2: Failure
        /// </summary>
        [JsonProperty("Http")]
        public ulong? Http{ get; set; }

        /// <summary>
        /// Enterprise WeChat group,0: Not set,1: Success,2: Failure
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WecomGroup")]
        public ulong? WecomGroup{ get; set; }

        /// <summary>
        /// FeiShu Group,0: Not set,1: Success,2: Failure
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LarkGroup")]
        public ulong? LarkGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "AlarmReceiver", this.AlarmReceiver);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Sms", this.Sms);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "Voice", this.Voice);
            this.SetParamSimple(map, prefix + "Wecom", this.Wecom);
            this.SetParamSimple(map, prefix + "Http", this.Http);
            this.SetParamSimple(map, prefix + "WecomGroup", this.WecomGroup);
            this.SetParamSimple(map, prefix + "LarkGroup", this.LarkGroup);
        }
    }
}

