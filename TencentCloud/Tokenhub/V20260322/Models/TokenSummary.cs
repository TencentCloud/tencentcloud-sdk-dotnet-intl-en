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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TokenSummary : AbstractModel
    {
        
        /// <summary>
        /// Package serial number of the current billing cycle
        /// </summary>
        [JsonProperty("CycleSeq")]
        public long? CycleSeq{ get; set; }

        /// <summary>
        /// Package billing cycle start time (RFC3339)
        /// </summary>
        [JsonProperty("CycleStartTime")]
        public string CycleStartTime{ get; set; }

        /// <summary>
        /// Package billing cycle end time (RFC3339)
        /// </summary>
        [JsonProperty("CycleEndTime")]
        public string CycleEndTime{ get; set; }

        /// <summary>
        /// Summary list of tokens grouped by billing item
        /// </summary>
        [JsonProperty("BillingItems")]
        public TokenSummaryBillingItem[] BillingItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CycleSeq", this.CycleSeq);
            this.SetParamSimple(map, prefix + "CycleStartTime", this.CycleStartTime);
            this.SetParamSimple(map, prefix + "CycleEndTime", this.CycleEndTime);
            this.SetParamArrayObj(map, prefix + "BillingItems.", this.BillingItems);
        }
    }
}

