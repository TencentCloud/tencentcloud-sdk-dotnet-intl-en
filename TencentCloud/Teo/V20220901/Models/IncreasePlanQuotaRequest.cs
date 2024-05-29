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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncreasePlanQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// Plan ID, formatted as edgeone-2unuvzjmmn2q.
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// The types of new plan quotas available include:<li> site: Number of sites;</li><li> precise_access_control_rule: the number of rules under "Web Protection - Custom Rules - Precision Matching Policy";</li><li> rate_limiting_rule: the number of rules under "Web Protection - Rate Limiting - Precision Rate Limiting Module". </li>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// Number of new quotas. The maximum number of quotas that can be added at one time is 100.
        /// </summary>
        [JsonProperty("QuotaNumber")]
        public long? QuotaNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "QuotaNumber", this.QuotaNumber);
        }
    }
}

