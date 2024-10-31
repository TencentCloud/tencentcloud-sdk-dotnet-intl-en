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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillAdjustInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Format: yyyy-MM.
        /// Billing month. Either Month or the combination of TimeFrom and TimeTo needs to be passed. If the TimeFrom and TimeTo are passed, the Month field is invalid.
        /// Example: 2024-10.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Format: yyyy-MM-dd.
        /// Start date. Either Month or the combination of TimeFrom and TimeTo needs to be passed. If TimeFrom and TimeTo are passed, the Month field is invalid. TimeFrom and TimeTo should represent the same month and be passed in together. Cross-month queries are not supported. The result will include the full month's data.
        /// Example: 2024-10-01.
        /// </summary>
        [JsonProperty("TimeFrom")]
        public string TimeFrom{ get; set; }

        /// <summary>
        /// Format: yyyy-MM-dd.
        /// End date. Either Month or the combination of TimeFrom and TimeTo needs to be passed. If TimeFrom and TimeTo are passed, the Month field is invalid. TimeFrom and TimeTo should represent the same month and be passed in together. Cross-month queries are not supported. The result will include the full month's data.
        /// Example: 2024-10-02.
        /// </summary>
        [JsonProperty("TimeTo")]
        public string TimeTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "TimeFrom", this.TimeFrom);
            this.SetParamSimple(map, prefix + "TimeTo", this.TimeTo);
        }
    }
}

