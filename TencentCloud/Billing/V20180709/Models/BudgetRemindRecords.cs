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

    public class BudgetRemindRecords : AbstractModel
    {
        
        /// <summary>
        /// budget period
        /// </summary>
        [JsonProperty("DateDesc")]
        public string DateDesc{ get; set; }

        /// <summary>
        /// actual fee
        /// </summary>
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// Budget amount limit
        /// </summary>
        [JsonProperty("BudgetQuota")]
        public string BudgetQuota{ get; set; }

        /// <summary>
        /// Reminder type.
        /// Enumeration values:
        /// BUDGET reminder
        /// Fluctuation alert
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// message content
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageContent")]
        public string MessageContent{ get; set; }

        /// <summary>
        /// Send time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SendTime")]
        public long? SendTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DateDesc", this.DateDesc);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamSimple(map, prefix + "BudgetQuota", this.BudgetQuota);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "MessageContent", this.MessageContent);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

