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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReconciliationStrategyInfo : AbstractModel
    {
        
        /// <summary>
        /// Offline Integration Task Reconciliation Alarms
        /// 
        /// reconciliationFailure: Alarm when offline reconciliation task fails
        /// 
        /// reconciliationOvertime: Alarm when offline reconciliation task runs overtime
        /// 
        /// reconciliationMismatch: Alarm when the number of mismatched records in reconciliation exceeds the threshold
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Reconciliation Mismatch Threshold - Required when RuleType = reconciliationMismatch. Specifies the threshold for the number of mismatched records in reconciliation. No default value.
        /// </summary>
        [JsonProperty("MismatchCount")]
        public ulong? MismatchCount{ get; set; }

        /// <summary>
        /// Task run timeout threshold for reconciliation: hr, defaults to 0.
        /// </summary>
        [JsonProperty("Hour")]
        public long? Hour{ get; set; }

        /// <summary>
        /// Reconciliation task timeout threshold: minutes, defaults to 1.
        /// </summary>
        [JsonProperty("Min")]
        public long? Min{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "MismatchCount", this.MismatchCount);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "Min", this.Min);
        }
    }
}

