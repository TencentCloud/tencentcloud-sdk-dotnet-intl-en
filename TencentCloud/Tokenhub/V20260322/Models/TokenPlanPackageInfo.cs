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

    public class TokenPlanPackageInfo : AbstractModel
    {
        
        /// <summary>
        /// Total quota. The unit is determined by the package type: credits for the Enterprise Professional package and tokens for the Enterprise auto package.
        /// </summary>
        [JsonProperty("TotalQuota")]
        public string TotalQuota{ get; set; }

        /// <summary>
        /// Total used quota. The unit varies by package type: credits (enterprise edition professional package), tokens (enterprise edition auto package)
        /// </summary>
        [JsonProperty("TotalUsed")]
        public string TotalUsed{ get; set; }

        /// <summary>
        /// Total number of periods.
        /// </summary>
        [JsonProperty("TotalCycles")]
        public long? TotalCycles{ get; set; }

        /// <summary>
        /// Period unit. Value: month
        /// </summary>
        [JsonProperty("CycleUnit")]
        public string CycleUnit{ get; set; }

        /// <summary>
        /// Package effective time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Package expiration time.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Allocated quota for dedicated pool. The unit varies by package type: credits (enterprise edition professional package), tokens (enterprise edition auto package)
        /// </summary>
        [JsonProperty("ExclusiveAllocated")]
        public string ExclusiveAllocated{ get; set; }

        /// <summary>
        /// Used credit of the dedicated pool. The unit varies based on the package type: credits for the enterprise professional package, and tokens for the enterprise auto package.
        /// </summary>
        [JsonProperty("ExclusiveUsed")]
        public string ExclusiveUsed{ get; set; }

        /// <summary>
        /// Total shared pool quota. The measurement unit varies based on the package type: credits (enterprise edition professional package), tokens (enterprise edition auto package).
        /// </summary>
        [JsonProperty("SharedPool")]
        public string SharedPool{ get; set; }

        /// <summary>
        /// Shared used credit. The unit varies by package type: credits (enterprise edition professional package), tokens (enterprise edition auto package)
        /// </summary>
        [JsonProperty("SharedUsed")]
        public string SharedUsed{ get; set; }

        /// <summary>
        /// Current period limit. The unit varies by package type: credits (Enterprise Edition Professional), tokens (Enterprise Edition auto).
        /// </summary>
        [JsonProperty("CycleQuota")]
        public string CycleQuota{ get; set; }

        /// <summary>
        /// Current cycle.
        /// </summary>
        [JsonProperty("CurrentCycle")]
        public long? CurrentCycle{ get; set; }

        /// <summary>
        /// Remaining cycle.
        /// </summary>
        [JsonProperty("RemainCycles")]
        public long? RemainCycles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "TotalUsed", this.TotalUsed);
            this.SetParamSimple(map, prefix + "TotalCycles", this.TotalCycles);
            this.SetParamSimple(map, prefix + "CycleUnit", this.CycleUnit);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ExclusiveAllocated", this.ExclusiveAllocated);
            this.SetParamSimple(map, prefix + "ExclusiveUsed", this.ExclusiveUsed);
            this.SetParamSimple(map, prefix + "SharedPool", this.SharedPool);
            this.SetParamSimple(map, prefix + "SharedUsed", this.SharedUsed);
            this.SetParamSimple(map, prefix + "CycleQuota", this.CycleQuota);
            this.SetParamSimple(map, prefix + "CurrentCycle", this.CurrentCycle);
            this.SetParamSimple(map, prefix + "RemainCycles", this.RemainCycles);
        }
    }
}

