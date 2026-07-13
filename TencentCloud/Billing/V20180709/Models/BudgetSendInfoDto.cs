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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BudgetSendInfoDto : AbstractModel
    {
        
        /// <summary>
        /// Notification cycle, separated by commas.
        /// Enumeration values:
        /// Monday:1
        /// Tuesday:2
        /// Sunday: 7
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WeekDays")]
        public ulong?[] WeekDays{ get; set; }

        /// <summary>
        /// Reception type.
        /// Enumeration values:
        /// UIN default mode
        /// USER
        /// GROUP User group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// Sending and receiving window HH:mm:ss
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Budget configuration id (budget name)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BudgetId")]
        public long? BudgetId{ get; set; }

        /// <summary>
        /// receiving channel, separated by commas
        /// Enumeration values:
        /// TITLE
        /// Message Center
        /// mail
        /// SMS
        /// WECHAT
        /// VOICE
        /// WeCom
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeWays")]
        public string[] NoticeWays{ get; set; }

        /// <summary>
        /// Send start window HH:mm:ss
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// user id, user group id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReceiverIds")]
        public ulong?[] ReceiverIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamArraySimple(map, prefix + "NoticeWays.", this.NoticeWays);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "ReceiverIds.", this.ReceiverIds);
        }
    }
}

