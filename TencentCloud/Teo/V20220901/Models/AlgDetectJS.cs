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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgDetectJS : AbstractModel
    {
        
        /// <summary>
        /// Operation name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Proof of Work (proof_Of-Work) verification strength. Default value: low. Valid values:
        /// <li>low: low;</li>
        /// <li>middle: Medium;</li>
        /// <li>high: high.</li>
        /// </summary>
        [JsonProperty("WorkLevel")]
        public string WorkLevel{ get; set; }

        /// <summary>
        /// Execution mode. The time when js delay execution is triggered. Unit: ms. Default value: 500. Value range: 0–1000.
        /// </summary>
        [JsonProperty("ExecuteMode")]
        public long? ExecuteMode{ get; set; }

        /// <summary>
        /// Statistical cycle for clients that do not have JS enabled (test not completed). Unit: seconds. Default: 10. Value range: 5–3600.
        /// </summary>
        [JsonProperty("InvalidStatTime")]
        public long? InvalidStatTime{ get; set; }

        /// <summary>
        /// Client JS not enabled (test not completed) trigger threshold. Count. Default: 300. Value: 1–100000000.
        /// </summary>
        [JsonProperty("InvalidThreshold")]
        public long? InvalidThreshold{ get; set; }

        /// <summary>
        /// Bot proactive feature recognition client behavior validation result.
        /// </summary>
        [JsonProperty("AlgDetectResults")]
        public AlgDetectResult[] AlgDetectResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "WorkLevel", this.WorkLevel);
            this.SetParamSimple(map, prefix + "ExecuteMode", this.ExecuteMode);
            this.SetParamSimple(map, prefix + "InvalidStatTime", this.InvalidStatTime);
            this.SetParamSimple(map, prefix + "InvalidThreshold", this.InvalidThreshold);
            this.SetParamArrayObj(map, prefix + "AlgDetectResults.", this.AlgDetectResults);
        }
    }
}

