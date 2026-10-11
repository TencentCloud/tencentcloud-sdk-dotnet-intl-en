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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>Scaling rule name.</p>
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// <p>&quot;SCALE_OUT&quot; and &quot;SCALE_IN&quot;, indicating scale-out and scale-in, respectively.</p>
        /// </summary>
        [JsonProperty("ScaleAction")]
        public string ScaleAction{ get; set; }

        /// <summary>
        /// <p>The value is &quot;SUCCESS&quot;, &quot;FAILED&quot;, &quot;PART_SUCCESS&quot;, or &quot;IN_PROCESS&quot;, indicating success, failure, partial success, and in-process, respectively.</p>
        /// </summary>
        [JsonProperty("ActionStatus")]
        public string ActionStatus{ get; set; }

        /// <summary>
        /// <p>Flow trigger time.</p>
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// <p>Scaling-related description.</p>
        /// </summary>
        [JsonProperty("ScaleInfo")]
        public string ScaleInfo{ get; set; }

        /// <summary>
        /// <p>Valid only when ScaleAction is SCALE_OUT.</p>
        /// </summary>
        [JsonProperty("ExpectScaleNum")]
        public long? ExpectScaleNum{ get; set; }

        /// <summary>
        /// <p>Flow end time.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Policy type. Load-based scaling or time-based scaling. 1 indicates load-based scaling, and 2 indicates time-based scaling.</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// <p>Specifications information used during scale-out.</p>
        /// </summary>
        [JsonProperty("SpecInfo")]
        public string SpecInfo{ get; set; }

        /// <summary>
        /// <p>Compensatory scale-out. Valid values: 0 (disable) and 1 (enable).</p>
        /// </summary>
        [JsonProperty("CompensateFlag")]
        public long? CompensateFlag{ get; set; }

        /// <summary>
        /// <p>Number of compensations.</p>
        /// </summary>
        [JsonProperty("CompensateCount")]
        public long? CompensateCount{ get; set; }

        /// <summary>
        /// <p>Number of retries.</p>
        /// </summary>
        [JsonProperty("RetryCount")]
        public ulong? RetryCount{ get; set; }

        /// <summary>
        /// <p>Retry information.</p>
        /// </summary>
        [JsonProperty("RetryInfo")]
        public string RetryInfo{ get; set; }

        /// <summary>
        /// <p>Retry description in English.</p>
        /// </summary>
        [JsonProperty("RetryEnReason")]
        public string RetryEnReason{ get; set; }

        /// <summary>
        /// <p>Retry description.</p>
        /// </summary>
        [JsonProperty("RetryReason")]
        public string RetryReason{ get; set; }

        /// <summary>
        /// <p>Missing category.</p>
        /// </summary>
        [JsonProperty("ShortageClass")]
        public long? ShortageClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ActionStatus", this.ActionStatus);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamSimple(map, prefix + "ScaleInfo", this.ScaleInfo);
            this.SetParamSimple(map, prefix + "ExpectScaleNum", this.ExpectScaleNum);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "SpecInfo", this.SpecInfo);
            this.SetParamSimple(map, prefix + "CompensateFlag", this.CompensateFlag);
            this.SetParamSimple(map, prefix + "CompensateCount", this.CompensateCount);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamSimple(map, prefix + "RetryInfo", this.RetryInfo);
            this.SetParamSimple(map, prefix + "RetryEnReason", this.RetryEnReason);
            this.SetParamSimple(map, prefix + "RetryReason", this.RetryReason);
            this.SetParamSimple(map, prefix + "ShortageClass", this.ShortageClass);
        }
    }
}

