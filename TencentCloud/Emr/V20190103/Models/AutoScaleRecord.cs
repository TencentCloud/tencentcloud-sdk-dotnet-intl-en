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
        /// Name of the scale-in or scale-out rule.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// "SCALE_OUT" and "SCALE_IN", representing expansion and reduction respectively.
        /// </summary>
        [JsonProperty("ScaleAction")]
        public string ScaleAction{ get; set; }

        /// <summary>
        /// The values are "SUCCESS", "FAILED", "PART_SUCCESS", "IN_PROCESS", which indicate success, failure, partial success, and in-progress, respectively.
        /// </summary>
        [JsonProperty("ActionStatus")]
        public string ActionStatus{ get; set; }

        /// <summary>
        /// Process initiation time.
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// Description related to auto-scaling.
        /// </summary>
        [JsonProperty("ScaleInfo")]
        public string ScaleInfo{ get; set; }

        /// <summary>
        /// Valid only when ScaleAction is SCALE_OUT.
        /// </summary>
        [JsonProperty("ExpectScaleNum")]
        public long? ExpectScaleNum{ get; set; }

        /// <summary>
        /// Process termination time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Policy type. Valid values: 1 (load-based scaling), 2 (time-based scaling).
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// Specification information used during scale-out.
        /// </summary>
        [JsonProperty("SpecInfo")]
        public string SpecInfo{ get; set; }

        /// <summary>
        /// Compensatory scale-out. Valid values: 0 (disabled), 1 (enabled).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompensateFlag")]
        public long? CompensateFlag{ get; set; }

        /// <summary>
        /// Number of compensations
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompensateCount")]
        public long? CompensateCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RetryCount")]
        public ulong? RetryCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RetryInfo")]
        public string RetryInfo{ get; set; }


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
        }
    }
}

